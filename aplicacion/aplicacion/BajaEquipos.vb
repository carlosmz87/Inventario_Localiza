Public Class BajaEquipos
    Dim controlador As New Controlador()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub BajaEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_bajaEquipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_bajaEquipos.EnableHeadersVisualStyles = False
        If controlador.CargarTablaBajaEquipos() = False Then
            MessageBox.Show("No se pudo cargar la tabla baja de equipos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TB_buscarBajaEquipo_TextChanged(sender As Object, e As EventArgs)
        Dim searchText As String = TB_buscarBajaEquipo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_bajaEquipos.Rows
            If Not row.IsNewRow AndAlso row.Index <> 0 AndAlso row.Cells.Count >= 2 Then
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

    Private Sub TB_buscarBajaEquipo_TextChanged_1(sender As Object, e As EventArgs) Handles TB_buscarBajaEquipo.TextChanged
        Dim searchText As String = TB_buscarBajaEquipo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_bajaEquipos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_bajaEquipos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (Nombre de usuario)
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

    Private Sub DGV_bajaEquipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_bajaEquipos.CellClick
        If DGV_bajaEquipos.SelectedRows.Count > 0 Then

        End If
    End Sub
End Class