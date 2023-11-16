Imports Microsoft.Office.Interop
Imports MySqlConnector

Public Class InformeActivos
    Dim controlador As New Controlador()
    Dim conn As New Conexion()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If Not controlador.CargarTablaPlataforma_InformeActivos(RadioButton3.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If Not controlador.CargarTablaPlataforma_InformeActivos(RadioButton4.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Not controlador.CargarTablaAdquisicion_InformeActivos(RadioButton1.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Not controlador.CargarTablaAdquisicion_InformeActivos(RadioButton2.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TB_buscarActivo_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivo.TextChanged
        Dim searchText As String = TB_buscarActivo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_informeActivos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_informeActivos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (Nombre de usuario)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(0).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub DGV_informeActivos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_informeActivos.CellClick
        If DGV_informeActivos.SelectedRows.Count > 0 Then

        End If
    End Sub

    Private Sub BTN_reporteIntervalo_Click(sender As Object, e As EventArgs) Handles BTN_reporteIntervalo.Click
        ReporteGeneral.Show()
        Me.Close()
    End Sub

    Private Sub BTN_exportar_Click(sender As Object, e As EventArgs) Handles BTN_exportar.Click

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()

        Dim dtPlataformaPosition As DataTable = CargarTablaPlataforma_InformeActivos("POSITION LOGIC")
        Dim dtPlataformaRed As DataTable = CargarTablaPlataforma_InformeActivos("RED GPS")
        Dim dtAdquisicionVenta As DataTable = CargarTablaAdquisicion_InformeActivos("VENTA")
        Dim dtAdquisicionRenta As DataTable = CargarTablaAdquisicion_InformeActivos("RENTA")

        dtPlataformaPosition.TableName = "Position Logic"
        dtPlataformaRed.TableName = "Red GPS"
        dtAdquisicionVenta.TableName = "Venta"
        dtAdquisicionRenta.TableName = "Renta"

        ExportDataTableToExcel(dtPlataformaPosition, workbook, excelApp)
        ExportDataTableToExcel(dtPlataformaRed, workbook, excelApp)
        ExportDataTableToExcel(dtAdquisicionVenta, workbook, excelApp)
        ExportDataTableToExcel(dtAdquisicionRenta, workbook, excelApp)

        'workbook.SaveAs("InformeActivos.xlsx")

        'Mostrar cuadro de diálogo para guardar archivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
        End If

        workbook.Close()
        excelApp.Quit()
    End Sub

    Sub ExportDataTableToExcel(dt As DataTable, workbook As Excel.Workbook, excelApp As Excel.Application)

        Dim worksheet As Excel.Worksheet = workbook.Sheets.Add()
        worksheet.Name = dt.TableName

        For i As Integer = 0 To dt.Columns.Count - 1
            worksheet.Cells(1, i + 1).value = dt.Columns(i).ColumnName
        Next

        For i As Integer = 0 To dt.Rows.Count - 1
            For j As Integer = 0 To dt.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1).value = dt.Rows(i)(j)
            Next
        Next

    End Sub

    Function CargarTablaPlataforma_InformeActivos(ByVal plataforma As String) As DataTable

        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT a.PLACA AS 'Placa', a.CHASIS AS 'Chasis', e.IMEI AS 'IMEI Equipo', m.MODELO AS 'Modelo Equipo'
                                                FROM ASIGNACION_PLATAFORMA ap
                                                INNER JOIN PLATAFORMA p ON ap.PLATAFORMA_PLAT_ID = p.PLAT_ID
                                                INNER JOIN ASIGNACION_EQUIPO ae ON ap.ACTIVO_ACT_ID = ae.ACTIVO_ACT_ID   
                                                INNER JOIN ACTIVO a ON ae.ACTIVO_ACT_ID = a.ACT_ID
                                                INNER JOIN EQUIPO e ON ae.EQUIPO_EQUI_ID = e.EQUI_ID
                                                INNER JOIN MODELO_GPS m ON e.ID_MODELO = m.ID_MODELO
                                                WHERE p.NOMBRE = '" & plataforma & "'
                                                ORDER BY a.PLACA;", conn.connection)
            Dim table As New DataTable()
            adapter.FillSchema(table, SchemaType.Source)
            adapter.Fill(table)

            conn.desconexion()
            Return table
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
        End Try

    End Function
    Function CargarTablaAdquisicion_InformeActivos(ByVal adiquisiciom As String) As DataTable
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT a.PLACA AS 'Placa', a.CHASIS AS 'Chasis', e.IMEI AS 'IMEI', m.MODELO AS 'Modelo'
                                                FROM ASIGNACION_EQUIPO ae
                                                INNER JOIN ACTIVO a ON ae.ACTIVO_ACT_ID = a.ACT_ID  
                                                INNER JOIN EQUIPO e ON ae.EQUIPO_EQUI_ID = e.EQUI_ID
                                                INNER JOIN MODELO_GPS m ON e.ID_MODELO = m.ID_MODELO
                                                WHERE ae.ESTADO = '" & adiquisiciom & "'
                                                ORDER BY a.PLACA", conn.connection)
            Dim table As New DataTable()
            adapter.FillSchema(table, SchemaType.Source)
            adapter.Fill(table)

            conn.desconexion()
            Return table

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
        End Try

    End Function


End Class