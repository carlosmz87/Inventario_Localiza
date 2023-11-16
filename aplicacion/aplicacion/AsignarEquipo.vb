Imports Microsoft.Office.Interop

Public Class AsignarEquipo
    Dim controlador As New Controlador()
    Dim valorSeleccionado_Activo As String = ""
    Dim valorSeleccionado_Equipo As String = ""
    Dim valorSeleccionado_Asignaciones As String = ""
    Dim valorSeleccionado2_Asignaciones As String = ""
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub AsignarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecemos el color al encabezado del datagridview.
        DGV_Activos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_equipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_asignaciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
        DGV_Activos.EnableHeadersVisualStyles = False
        DGV_equipos.EnableHeadersVisualStyles = False
        DGV_asignaciones.EnableHeadersVisualStyles = False
        ' Carga de tablas (Activo, equipo y asignaciones)
        If Not controlador.CargarTablaActivos_Equipo() Then
            MessageBox.Show("Error al cargar la tabla de activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not controlador.CargarTablaEquipo_Equipo() Then
            MessageBox.Show("Error al cargar la tabla de equipos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ' Carga de combobox
        If Not controlador.CargarPlataformaEquipo() Then
            MessageBox.Show("Error al cargar las plataformas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not controlador.CargarTablaAsignaciones_Equipo() Then
            MessageBox.Show("Error al cargar la tabla de asignaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Busquedas en las tablas
    Private Sub TB_buscarActivos_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivos.TextChanged
        Dim searchText As String = TB_buscarActivos.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Activos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Activos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Placa y chásis)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(1).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub TB_buscarEquipos_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarEquipos.TextChanged
        Dim searchText As String = TB_buscarEquipos.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_equipos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_equipos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (IMEI)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub TB_buscarAsignaciones_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarAsignaciones.TextChanged
        Dim searchText As String = TB_buscarAsignaciones.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_asignaciones.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_asignaciones.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (ACTIVO[placa] y Equipo[IMEI])
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(1).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    ' Funcionalidades de los botones para obtener valores
    Private Sub BTN_seleccionarActivo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarActivo.Click
        If valorSeleccionado_Activo <> "" Then
            LB_activoSeleccionado.Text = valorSeleccionado_Activo
        Else
            MessageBox.Show("No ha seleccionado ningún activo a asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BTN_seleccionarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarEquipo.Click
        If valorSeleccionado_Equipo <> "" Then
            LB_equipoSeleccionado.Text = valorSeleccionado_Equipo
        Else
            MessageBox.Show("No ha seleccionado ningún equipo a asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BTN_asignar_Click(sender As Object, e As EventArgs) Handles BTN_asignar.Click
        If LB_activoSeleccionado.Text <> "No seleccionado" And LB_equipoSeleccionado.Text <> "No seleccionado" Then
            If CB_plataforma.Text <> "" Then
                If CB_adquisicion.Text <> "" Then
                    'Codigo aqui para query (procedimiento almacenado)
                    If controlador.asignacionEquipo(LB_activoSeleccionado.Text, LB_equipoSeleccionado.Text, CB_plataforma.Text, CB_adquisicion.Text) Then
                        MessageBox.Show("Se ha asignado el activo " & LB_activoSeleccionado.Text &
                                        " con el equipo " & LB_equipoSeleccionado.Text, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LB_activoSeleccionado.Text = "No seleccionado"
                        LB_equipoSeleccionado.Text = "No seleccionado"
                        TB_buscarActivos.Clear()
                        TB_buscarEquipos.Clear()
                    End If
                Else
                    MessageBox.Show("Seleccione el tipo de adquisición para el equipo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Seleccione la plataforma para el equipo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Activo/Equipo no seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BTN_desasignarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_desasignarEquipo.Click
        If valorSeleccionado_Asignaciones <> "" Then
            'Codigo aqui para desasignar (procedimiento almacenado)
            If controlador.desasignacionEquipo(valorSeleccionado_Asignaciones, valorSeleccionado2_Asignaciones) Then
                MessageBox.Show("Se ha desasignado correctamente el equipo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No ha seleccionado ninguna asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' funciones para obtener valor seleccionado del datagridview
    Private Sub DGV_Activos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Activos.CellClick
        If DGV_Activos.SelectedRows.Count > 0 Then
            valorSeleccionado_Activo = DGV_Activos.CurrentRow.Cells(0)?.Value
        End If
    End Sub

    Private Sub DGV_equipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_equipos.CellClick
        If DGV_equipos.SelectedRows.Count > 0 Then
            valorSeleccionado_Equipo = DGV_equipos.CurrentRow.Cells(0)?.Value
        End If
    End Sub

    Private Sub DGV_asignaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_asignaciones.CellClick
        If DGV_asignaciones.SelectedRows.Count > 0 Then
            valorSeleccionado_Asignaciones = DGV_asignaciones.CurrentRow.Cells(0)?.Value
            valorSeleccionado2_Asignaciones = DGV_asignaciones.CurrentRow.Cells(1)?.Value
        End If
    End Sub

    Private Sub BTN_exportar_Click(sender As Object, e As EventArgs) Handles BTN_exportar.Click
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Agregar encabezados
        For i As Integer = 0 To DGV_asignaciones.ColumnCount - 1
            worksheet.Cells(1, i + 1) = DGV_asignaciones.Columns(i).HeaderText
        Next

        ' Agregar datos 
        For i As Integer = 0 To DGV_asignaciones.RowCount - 1
            For j As Integer = 0 To DGV_asignaciones.ColumnCount - 1
                worksheet.Cells(i + 2, j + 1) = DGV_asignaciones.Rows(i).Cells(j).Value.ToString()
            Next
        Next

        'Mostrar cuadro de diálogo para guardar archivo
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            workbook.SaveAs(saveDialog.FileName)
        End If

        excelApp.Quit()
    End Sub
End Class