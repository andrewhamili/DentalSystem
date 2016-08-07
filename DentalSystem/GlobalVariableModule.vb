Imports MySql.Data.MySqlClient

Module GlobalVariableModule

    Public SystemTitle As String = "Dental System"

    Public MySQLConn As New MySqlConnection
    Public connstring As String = "server=localhost;userid=root;Password=microcircle;database=dentalsystem"
    Public comm As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As New MySqlDataAdapter
    Public username As String
    Public activeuserfname As String
    Public activeuserlname As String
    Public usertype As String
End Module
