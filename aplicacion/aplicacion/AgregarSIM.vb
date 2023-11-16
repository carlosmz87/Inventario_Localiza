Public Class AgregarSIM
    Dim numeroValido As New Auxiliares()
    Dim controlador As New Controlador()

    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub
    Private Sub BTN_agregarSIM_Click(sender As Object, e As EventArgs) Handles BTN_agregarSIM.Click
        If (TB_iccSim.Text <> String.Empty And TB_numeroSim.Text <> String.Empty And TB_companiaSim.Text <> String.Empty And
            TB_propietarioSim.Text <> String.Empty And TB_plandatosSim.Text <> String.Empty) Then
            If (numeroValido.ValidarTelefono(TB_numeroSim.Text)) Then
                Try
                    If controlador.AgregarSim(TB_iccSim.Text, TB_numeroSim.Text, TB_companiaSim.Text, TB_propietarioSim.Text, TB_plandatosSim.Text, DateTime.Text) Then
                        MessageBox.Show("Se agregó la SIM correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarInputs()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Ocurrió algo inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TB_numeroSim.Clear()
            End If
        Else
            MessageBox.Show("Falta ingresar datos en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_iccSim.Clear()
        TB_numeroSim.Clear()
        TB_companiaSim.Clear()
        TB_propietarioSim.Clear()
        TB_plandatosSim.Clear()
    End Sub
End Class