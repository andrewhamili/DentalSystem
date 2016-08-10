Imports MySql.Data.MySqlClient
Class AccountManagement

    Private Sub AccountManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Load_Usernames()

        lbox_username.Items.Clear()

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            query = "SELECT * FROM userlist"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer
            While reader.Read
                lbox_username.Items.Add(reader.GetString("username"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub rdio_createUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdio_createUser.CheckedChanged
        txt_lname.Text = ""
        txt_fname.Text = ""
        txt_mname.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        txt_retypepassword.Text = ""
        cbox_usertype.Text = ""

        txt_lname.Enabled = True
        txt_mname.Enabled = True
        txt_fname.Enabled = True
        txt_username.Enabled = True
        lbox_username.Enabled = False
    End Sub

    Private Sub rdio_editUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdio_editUser.CheckedChanged
        txt_lname.Enabled = False
        txt_mname.Enabled = False
        txt_fname.Enabled = False
        txt_username.Enabled = False
        lbox_username.Enabled = False
        lbox_username.Enabled = True
        Load_Usernames()
    End Sub

    Private Sub lbox_username_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbox_username.SelectedIndexChanged

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            query = "SELECT * FROM userlist WHERE username=@selectedusername"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("selectedusername", lbox_username.Text)
            reader = comm.ExecuteReader
            While reader.Read
                txt_lname.Text = reader.GetString("lname")
                txt_fname.Text = reader.GetString("fname")
                txt_mname.Text = reader.GetString("mname")
                txt_username.Text = reader.GetString("username")
                cbox_usertype.Text = reader.GetString("usertype")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Close()
        End Try
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        MySQLConn.ConnectionString = connstring
        If txt_username.Text = username Then
            MsgBox("You cannot delete this user because it is being used", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to Delete this User?", MsgBoxStyle.YesNo, SystemTitle)
            If ans = 6 Then
                Try
                    MySQLConn.Open()
                    query = "DELETE FROM userlist WHERE username=@selectedusername"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("selectedusername", txt_username.Text)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MsgBox("User Deleted Successfully", MsgBoxStyle.Information, SystemTitle)
                Catch ex As Exception
                    MsgBox("Error deleting the User!" & ex.Message, MsgBoxStyle.Exclamation, SystemTitle)
                Finally
                    MySQLConn.Dispose()
                End Try
            End If
        End If
        
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        MySQLConn.ConnectionString = connstring
        If txt_lname.Text = "" Or txt_fname.Text = "" Or txt_username.Text = "" Or txt_password.Text = "" Or txt_retypepassword.Text = "" Then
            MsgBox("All field that are marked with an asterisk(*) are required", MsgBoxStyle.Exclamation, SystemTitle)
        ElseIf txt_password.Text <> txt_retypepassword.Text Then
            MsgBox("Passwords do not match", MsgBoxStyle.Exclamation, SystemTitle)
        Else
            Try
                MySQLConn.Open()
                query = "INSERT INTO userlist values(@firstname, @middlename, @lastname, @username, sha2(@password, 512), @usertype)"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("firstname", txt_fname.Text)
                comm.Parameters.AddWithValue("middlename", txt_mname.Text)
                comm.Parameters.AddWithValue("lastname", txt_lname.Text)
                comm.Parameters.AddWithValue("username", txt_username.Text)
                comm.Parameters.AddWithValue("password", txt_retypepassword.Text)
                comm.Parameters.AddWithValue("usertype", cbox_usertype.Text)
                reader = comm.ExecuteReader
                MySQLConn.Close()
            Catch ex As Exception
                If ex.Message.Contains("Duplicate") Then
                    MsgBox("The username is already used", MsgBoxStyle.Exclamation, SystemTitle)
                Else
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, SystemTitle)
                End If

            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub
End Class