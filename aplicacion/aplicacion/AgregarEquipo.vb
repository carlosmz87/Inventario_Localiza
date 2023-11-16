Public Class AgregarEquipo

    Dim controlador As New Controlador()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub BTN_agregarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_agregarEquipo.Click
        If (TB_imeiEquipo.Text <> String.Empty And CB_modelo.Text <> String.Empty) Then
            Try
                If controlador.AgregarEquipo_(TB_imeiEquipo.Text, CB_modelo.Text) Then
                    MessageBox.Show("Se agregó el equipo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarInputs()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Falta ingresar datos en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        CB_modelo.Text = "Seleccione un modelo"
        TB_imeiEquipo.Clear()
    End Sub

    Private Sub AgregarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        controlador.CargarModeloEquipo()
        CB_modelo.DropDownStyle = ComboBoxStyle.DropDownList ' Bloqueamos el combo box, para que no sea editable por el usuario
    End Sub
End Class