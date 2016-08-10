Imports MySql.Data.MySqlClient
Public Class Home

    Public dbDataSet As New DataTable



    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer_DateTime.Enabled = True
        lbl_welcomeText.Text = "Welcome " & activeuserfname & " " & activeuserlname & ""

        Load_Patientlist()
    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Dim response As Integer
        'Display a Dialog box with Yes and No buttons and store the response number to the variable "response". The equivalent of Yes is 6, No is 7.
        response = MsgBox("Are you sure you want to Log-out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)

        If response = 6 Then
            'If the user responds YES
            Me.Dispose() 'Dispose the Home Form
            Login.Show() 'Show the Login page
        End If

    End Sub

    Private Sub Timer_DateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DateTime.Tick
        lbl_date.Text = Now.ToString("MMMM dd, yyyy")
        lbl_time.Text = Now.ToString("HH:mm:ss")

    End Sub

    Public Sub Load_Patientlist()

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring
        dbDataSet.Clear()
        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT patientid as 'Patient ID', lname as 'Last Name', fname as 'First Name', mname as 'Middle Name' FROM patientlist ORDER BY lname ASC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbDataSet)
            bsource.DataSource = dbDataSet
            dgv_patientlist.DataSource = bsource
            adapter.Update(dbDataSet)
            MySQLConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub btn_AddPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddPatient.Click
        Me.Hide()
        PatientRegistrationForm.ShowDialog()
    End Sub

    Private Sub btn_UserAccountManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UserAccountManagement.Click
        AccountManagement.ShowDialog()
    End Sub
End Class