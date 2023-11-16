Imports System.Security.Cryptography
Imports System.Text

Public Class Encrypted
    Public Function EncriptarSHA1(texto As String) As String
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
        Dim sha1 As New SHA1CryptoServiceProvider()
        Dim hash As Byte() = sha1.ComputeHash(bytes)
        Dim sb As New StringBuilder()
        For Each b As Byte In hash
            sb.AppendFormat("{0:x2}", b)
        Next

        Return sb.ToString()
    End Function

    Public Function VerificarSHA1(texto As String, hash As String) As Boolean
        Dim hashTexto As String = EncriptarSHA1(texto)
        Return hashTexto.Equals(hash)
    End Function
End Class
