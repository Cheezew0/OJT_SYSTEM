Imports MySql.Data.MySqlClient

Public Class DbConnection
    Private Shared ReadOnly connectionString As String =
    "Server=localhost;Port=3306;Database=ojt_management_system;User Id=root;"

    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Class
