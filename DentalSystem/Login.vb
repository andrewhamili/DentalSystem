Imports MySql.Data.MySqlClient

Public Class Login

    Public attempt As Integer 'Declared a variable "attempt" as a public Integer to be used for counting the login attempts the user has made.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AcceptButton = btn_login 'Set the Button "btn_login" to be pressed using carriage return.

        CancelButton = btn_cancel 'Set the Button "btn_cancel" to be pressed using the ESC key.


        'This commands was used because the Login window does not show after logging out.
        Me.TopMost = True 'Set the Login window to be at the top of all Active windows
        Me.TopMost = False 'Stopped the Login window to be at the Top of all Active  Windows.



    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String

        If attempt <= 3 Then 'If attempts was less than 3
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
                    attempt += 1 'Incremet the "attempt" variable

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
            If attempt = 3 Then
                'If the "attempt" variable reached 3 then this will occur
                MsgBox("You have reached the maximum attempts allowed for Logging-in. System terminate.", MsgBoxStyle.Critical, "Dental System") 'Display MessageBox informin the user that he has reachd the maximum attempts.

                End 'Terminate the process.
            End If
            

        End If
        
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        End
    End Sub
End Class
