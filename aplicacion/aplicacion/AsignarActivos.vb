Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop

Public Class AsignarActivos
    Dim controlador As New Controlador()
    Dim valorSeleccionado_Cliente As String = ""
    Dim valorSeleccionado_Activo As String = ""
    Dim valorSeleccionado_Asignaciones As String = ""
    Dim valorSeleccionado2_Asignaciones As String = ""
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub AsignarActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecemos el color al encabezado del datagridview.
        DGV_Clientes.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_Activos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_asignaciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
        DGV_Clientes.EnableHeadersVisualStyles = False
        DGV_Activos.EnableHeadersVisualStyles = False
        DGV_asignaciones.EnableHeadersVisualStyles = False

        'Cargamos tablas (Clientes, activos y asignaciones)
        If Not controlador.CargarTablaClientes_Activo() Then
            MessageBox.Show("Error al cargar la tabla de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not controlador.CargarTablaActivos_Activo() Then
            MessageBox.Show("Error al cargar la tabla de activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not controlador.CargarTablaAsignaciones_Activo() Then
            MessageBox.Show("Error al cargar la tabla de asignaciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ' Busquedas en las tablas
    Private Sub TB_buscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarCliente.TextChanged
        Dim searchText As String = TB_buscarCliente.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Clientes.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Clientes.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (Nombre del cliente)
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

    Private Sub TB_buscarActivo_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivo.TextChanged
        Dim searchText As String = TB_buscarActivo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Activos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Activos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Placa o chasis)
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
                ' Obtener los valores de las celdas en la primera y segunda columna (Cliente[Nonmbre] y placa)
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

    ' Funciones para obtener datos de las tablas
    Private Sub BTN_seleccionarCliente_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarCliente.Click
        If valorSeleccionado_Cliente <> "" Then
            LB_clienteSeleccionado.Text = valorSeleccionado_Cliente
        Else
            MessageBox.Show("No ha seleccionado ningún cliente a asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_seleccionarActivo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarActivo.Click
        If valorSeleccionado_Activo <> "" Then
            LB_activoSeleccionado.Text = valorSeleccionado_Activo
        Else
            MessageBox.Show("No ha seleccionado ningún activo a asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_asignar_Click(sender As Object, e As EventArgs) Handles BTN_asignar.Click
        If LB_clienteSeleccionado.Text <> "No seleccionado" And LB_activoSeleccionado.Text <> "No seleccionado" Then
            ' codigo aqui para realizar query (procedimiento almacenado)
            If controlador.asignacionActivo(LB_clienteSeleccionado.Text, LB_activoSeleccionado.Text) Then
                MessageBox.Show("Se asignó al cliente " & LB_clienteSeleccionado.Text &
                                " el activo " & LB_activoSeleccionado.Text, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LB_activoSeleccionado.Text = "No seleccionado"
                LB_clienteSeleccionado.Text = "No seleccionado"
                TB_buscarActivo.Clear()
                TB_buscarCliente.Clear()
            End If
        Else
            MessageBox.Show("Cliente/Activo no seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
    End Sub

    Private Sub BTN_desasignarActivo_Click(sender As Object, e As EventArgs) Handles BTN_desasignarActivo.Click
        If valorSeleccionado_Asignaciones <> "" And valorSeleccionado2_Asignaciones <> "" Then
            ' Codigo para realizar desasignación (procedimiento almacenado)
            If controlador.desasignacionActivo(valorSeleccionado_Asignaciones, valorSeleccionado2_Asignaciones) Then
                MessageBox.Show("Se desasignó correctamente al cliente " & valorSeleccionado_Asignaciones &
                                " del activo " & valorSeleccionado2_Asignaciones, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No ha seleccionado ninguna asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Funciones para obtener el valor del datagridview
    Private Sub DGV_Clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellClick
        If DGV_Clientes.SelectedRows.Count > 0 Then
            valorSeleccionado_Cliente = DGV_Clientes.CurrentRow.Cells(0)?.Value
        End If
    End Sub

    Private Sub DGV_Activos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Activos.CellClick
        If DGV_Activos.SelectedRows.Count > 0 Then
            valorSeleccionado_Activo = DGV_Activos.CurrentRow.Cells(0)?.Value
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