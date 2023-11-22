Public Class Conectividad
    Private conn As New Conexion()
    Public puerto As String = ""
    Public username As String = ""
    Public password As String = ""
    Public database As String = ""
    Public host As String = ""

    Private Sub BTN_conectar_Click(sender As Object, e As EventArgs) Handles BTN_conectar.Click
        If TB_puerto.Text <> String.Empty Then
            If TB_contrasenia.Text <> String.Empty And TB_usuario.Text <> String.Empty Then
                If TB_baseDatos.Text <> String.Empty Then
                    If TB_host.Text <> String.Empty Then
                        puerto = TB_puerto.Text
                        username = TB_usuario.Text
                        password = TB_contrasenia.Text
                        database = TB_baseDatos.Text
                        host = TB_host.Text
                        If conn.verificarConexion() Then
                            conn.desconexion()
                            Login.Show()
                            Me.Hide()
                        Else
                            TB_contrasenia.Clear()
                        End If
                    Else
                        MessageBox.Show("Ingrese el host/ip para conectarse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Ingrese el nombre de la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Ingrese el usuario/contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Ingrese el puerto al que desa conectarse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class