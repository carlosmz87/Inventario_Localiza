Imports Microsoft.Office.Interop

Public Class AsignarSIM
    Dim controlador As New Controlador()
    Dim valorSeleccionado_Equipo As String = ""
    Dim valorSeleccionado_Sim As String = ""
    Dim valorSeleccionado_Asignaciones As String = ""
    Dim valorSeleccionado2_Asignaciones As String = ""
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub AsignarSIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecemos el color al encabezado del datagridview.
        DGV_equipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_sim.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_asignaciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
        DGV_equipos.EnableHeadersVisualStyles = False
        DGV_sim.EnableHeadersVisualStyles = False
        DGV_asignaciones.EnableHeadersVisualStyles = False
        ' Carga de tablas (Equipo, SIM y asignaciones)
        If Not controlador.CargarTablaSim_Sim() Then
            MessageBox.Show("Error al cargar tabla de sim.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not controlador.CargarTablaEquipo_Sim() Then
            MessageBox.Show("Error al cargar tabla de equipos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not controlador.CargarTablaAsignaciones_Sim() Then
            MessageBox.Show("Error al cargar tabla de asignaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Metodos para filtrar en los datagrids
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

    Private Sub TB_buscarSim_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarSim.TextChanged
        Dim searchText As String = TB_buscarSim.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_sim.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_sim.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (ICC y Numero)
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

    Private Sub TB_buscarAsignaciones_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarAsignaciones.TextChanged
        Dim searchText As String = TB_buscarAsignaciones.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_asignaciones.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_asignaciones.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Equipo o ICC)
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

    ' Funciones para la obtención de datos
    Private Sub BTN_seleccionarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarEquipo.Click
        If valorSeleccionado_Equipo <> "" Then
            LB_equipoSeleccionado.Text = valorSeleccionado_Equipo
        Else
            MessageBox.Show("No ha seleccionado ningún equipo a asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_seleccionarSim_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarSim.Click
        If valorSeleccionado_Sim <> "" Then
            LB_simSeleccionado.Text = valorSeleccionado_Sim
        Else
            MessageBox.Show("No ha seleccionado ningún sim a asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_asignar_Click(sender As Object, e As EventArgs) Handles BTN_asignar.Click
        If LB_equipoSeleccionado.Text <> "No seleccionado" And LB_simSeleccionado.Text <> "No seleccionado" Then
            ' Codigo aqui para realizar querys (procedimiento almacenado)
            If controlador.asignacionSIM(LB_equipoSeleccionado.Text, LB_simSeleccionado.Text) Then
                MessageBox.Show("Asignación del equipo " & LB_equipoSeleccionado.Text & " con la sim " & LB_simSeleccionado.Text &
                                " exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LB_equipoSeleccionado.Text = "No seleccionado"
                LB_simSeleccionado.Text = "No seleccionado"
                TB_buscarEquipos.Clear()
                TB_buscarSim.Clear()
            End If
        Else
            MessageBox.Show("Equipo/SIM no seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_desasignarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_desasignarEquipo.Click
        If valorSeleccionado_Asignaciones <> "" Then
            'codigo aqui para realizar query (procedimiento almacenado)
            If controlador.desasignacionSIM(valorSeleccionado_Asignaciones, valorSeleccionado2_Asignaciones) Then
                MessageBox.Show("Se ha desasignado la sim " & valorSeleccionado2_Asignaciones &
                                " del equipo " & valorSeleccionado_Asignaciones, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TB_buscarAsignaciones.Clear()
            End If
        Else
            MessageBox.Show("No ha seleccionado ninguna asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Funciones para la obtencion de datos del datagirdview
    Private Sub DGV_equipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_equipos.CellClick
        If DGV_equipos.SelectedRows.Count > 0 Then
            valorSeleccionado_Equipo = DGV_equipos.CurrentRow.Cells(0)?.Value
        End If
    End Sub

    Private Sub DGV_sim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_sim.CellClick
        If DGV_sim.SelectedRows.Count > 0 Then
            valorSeleccionado_Sim = DGV_sim.CurrentRow.Cells(0)?.Value
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