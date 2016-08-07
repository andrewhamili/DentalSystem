Public Class Home

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Dim response As Integer
        'Display a Dialog box with Yes and No buttons and store the response number to the variable "response". The equivalent of Yes is 6, No is 7.
        response = MsgBox("Are you sure you want to Log-out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Dental System")

        If response = 6 Then
            'If the user responds YES
            Me.Dispose() 'Dispose the Home Form
            Login.Show() 'Show the Login page
        End If

    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer_DateTime.Enabled = True
        lbl_welcomeText.Text = "Welcome " & activeuserfname & " " & activeuserlname & ""
    End Sub

    Private Sub Timer_DateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_DateTime.Tick
        lbl_date.Text = Now.ToString("MMMM dd, yyyy")
        lbl_time.Text = Now.ToString("HH:mm:ss")

    End Sub
End Class