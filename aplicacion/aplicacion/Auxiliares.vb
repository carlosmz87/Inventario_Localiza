Imports System.Text.RegularExpressions

Public Class Auxiliares
    Dim controlador As New Controlador()

    ' Función para validar numero telefono correcto (12345678)
    Public Function ValidarTelefono(numero As String) As Boolean

        Dim regex As New Regex("^\d{8}$")

        If regex.IsMatch(numero) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function MigrarSim(ByVal icc_actual As String)

        Dim icc_nueva As String

        icc_nueva = InputBox("Ingrese ICC nueva:", "Migrar SIM")

        If icc_nueva <> "" Then
            Dim resultado = MessageBox.Show("¿Desea migrar la SIM con el siguiente ICC " & icc_nueva & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If resultado = DialogResult.OK Then
                ' Codigo para migrar sim
                If controlador.MigrarSim(icc_actual, icc_nueva) Then
                    MessageBox.Show("Migracion de sim con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'MessageBox.Show("No se ingresó ningún ICC.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            End If
        End If

    End Function

    Public Function agregarMarca()

        Dim marca_nueva As String

        marca_nueva = InputBox("Ingrese el nombre de la marca: ", "Agregar marcas")

        If marca_nueva <> "" Then
            Dim resultado = MessageBox.Show("¿Desea agregar la marca " & marca_nueva.ToUpper() & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If resultado = DialogResult.OK Then
                ' Codigo para migrar sim
                If controlador.agregarMarca(marca_nueva.ToUpper()) Then
                    MessageBox.Show("Marca agregada con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'MessageBox.Show("No se ingresó ningún ICC.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            End If
        End If

    End Function

    Public Function agregarModelo(ByVal marca As String)

        Dim modelo_nuevo As String

        modelo_nuevo = InputBox("Ingrese el modelo a agregar: ", "Agregar marcas")

        If modelo_nuevo <> "" Then
            Dim resultado = MessageBox.Show("¿Desea agregar el modelo " & modelo_nuevo & " a la marca " & marca & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                ' Codigo para migrar sim
                If controlador.agregarModelo(marca, modelo_nuevo) Then
                    MessageBox.Show("Modelo agregado con exito con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'MessageBox.Show("No se ingresó ningún ICC.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            End If
        End If

    End Function

End Class
