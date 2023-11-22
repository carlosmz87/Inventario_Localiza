Imports MySqlConnector

Public Class Conexion

    Private puerto As String
    Private username As String
    Private password As String
    Private database As String
    Private host As String

    Public connection As New MySqlConnection

    Function verificarConexion() As Boolean
        Try
            conexion()
            Return True
        Catch ex As Exception
            desconexion()
            MessageBox.Show("Ocurrió algun problema al intentar conectarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub conexion()
        puerto = Conectividad.puerto
        username = Conectividad.username
        password = Conectividad.password
        database = Conectividad.database
        host = Conectividad.host

        'MsgBox("datasource=localhost;port=" & puerto & ";username=" & username & ";password=;database=" & database & ";ConvertZeroDateTime=True")
        connection.ConnectionString = "datasource=" & host & ";port=" & puerto & ";username=" & username & ";password=" & password & ";database=" & database & ";ConvertZeroDateTime=True"
        connection.Open()
    End Sub

    Public Sub desconexion()
        connection.Close()
    End Sub

End Class
