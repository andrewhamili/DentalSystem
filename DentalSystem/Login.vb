Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = btn_login
        CancelButton = btn_cancel


    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open() 'Open MySQL Connection
            query = "SELECT * FROM userlist WHERE username=@username and password=sha2(@password, 512)"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("username", txt_username.Text)
            comm.Parameters.AddWithValue("password", txt_password.Text)
            reader = comm.ExecuteReader
            Dim count As Integer 'Declare variable "count" to be used to count row results from the MySQL Query
            While reader.Read

                activeuserfname = reader.GetString("fname") 'Store the Logged-in user's Firstname to the Public declared variable "fname" from the Database.

                activeuserlname = reader.GetString("lname") 'Store the Logged-in user's Lastname to the Public declared variable "lname" from the Database

                usertype = reader.GetString("usertype")  'Store the Logged-in user's Usertype to the Public declared variable "usertype" from the Database. This will be used to detect the users Privileges.

                count += 1 'If the entered username and password matches one of the records in the Database, varialbe "count" will increment.

            End While
            If count > 0 Then
                'If variable "count" is greater than Zero (0), it means the MySQL Query returned a result. The username and password s correct.


                txt_username.Text = "" 'Clear the username TextBox
                txt_password.Text = "" 'Clear the password TextBox
                Me.Hide() 'Hide the Login Form
                Home.Show() 'Show the Home Form

            Else
                'Log-in credentials Error
                MsgBox("Incorrect username or password", MsgBoxStyle.Critical, "Dental System")

                txt_username.Text = "" 'Clear the username TextBox
                txt_password.Text = "" 'Clear the password TextBox

            End If
            MySQLConn.Close() 'Close MySQL Connection

        Catch ex As Exception
            'MySQL Connection Error has occured
            MsgBox(ex.Message) 'Display MySQL Error in a MessageBox
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        End
    End Sub
End Class
