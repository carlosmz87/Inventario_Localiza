Imports Microsoft.Office.Interop

Public Class ReporteGeneral
    Dim controlador As New Controlador()
    Private Sub RB_reporteGeneral_CheckedChanged(sender As Object, e As EventArgs) Handles RB_reporteGeneral.CheckedChanged
        If Not controlador.reportesGeneral() Then
            MessageBox.Show("No se pudo cargar la tabla del Reporte General.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        InformeActivos.Show()
    End Sub

    Private Sub BTN_reporteIntervalo_Click(sender As Object, e As EventArgs) Handles BTN_reporteIntervalo.Click
        controlador.reportesGeneralIntevalo(DTP_inicial.Text, DTP_final.Text)
    End Sub

    Private Sub BTN_exportar_Click(sender As Object, e As EventArgs) Handles BTN_exportar.Click
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet

        ' Agregar encabezados
        For i As Integer = 0 To DGV_reporteGeneral.ColumnCount - 1
            worksheet.Cells(1, i + 1) = DGV_reporteGeneral.Columns(i).HeaderText
        Next

        ' Agregar datos 
        For i As Integer = 0 To DGV_reporteGeneral.RowCount - 1
            For j As Integer = 0 To DGV_reporteGeneral.ColumnCount - 1
                worksheet.Cells(i + 2, j + 1) = DGV_reporteGeneral.Rows(i).Cells(j).Value.ToString()
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