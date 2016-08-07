Public Class PatientRegistrationForm



    Public changepictureindicator As Boolean = False

    Private Sub cboxstudgender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxpatientgender.SelectedIndexChanged
        If cboxpatientgender.Text = "Male" Then
            pboxpatientpic.Image = My.Resources.male_image
        Else
            pboxpatientpic.Image = My.Resources.female_image
        End If
        changepictureindicator = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pboxpatientpic.Image = Image.FromFile(OpenFileDialog1.FileName)
            changepictureindicator = True
        End If


    End Sub

    Private Sub RegistrationFormStudent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub RegistrationFormStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        Dim patientfname As String
        Dim patientlname As String
        Dim patientmname As String
        Dim patientfullname As String
        Dim patientbday As Date
        Dim patientbloodtype As String
        Dim patientaddress As String
        Dim patientcontact As String
        Dim patientemailaddress As String

        Dim ans As Integer
        If changepictureindicator = True Then



            If cboxpatientgender.Text = "" Or txt_fname.Text = "" Or txt_mname.Text = "" Or txt_lname.Text = "" Or txt_address.Text = "" Then
                MsgBox("The fields marked with an asterisk (*) are required", MsgBoxStyle.Critical, "Insufficient Information")
            Else
                Me.Hide()
                patientfname = txt_fname.Text
                patientmname = txt_mname.Text
                patientlname = txt_lname.Text
                patientbloodtype = cbox_bloodtype.Text
                patientaddress = txt_address.Text
                patientcontact = txt_contactnum.Text
                patientemailaddress = txt_emailaddress.Text
            End If
        Else
            ans = MsgBox("You didn't include the patient's picture! Do you still want to proceed?" & vbCrLf & "(You could still add a picture after this Registration procedure by editing the Student Information)", vbYesNo, "No picture")

            If ans = 6 Then

                If cboxpatientgender.Text = "" Or txt_fname.Text = "" Or txt_mname.Text = "" Or txt_lname.Text = "" Or txt_address.Text = "" Then
                    MsgBox("The fields marked with an asterisk (*) are required", MsgBoxStyle.Critical, "Insufficient Information")
                Else
                    Me.Hide()
                    patientfname = txt_fname.Text
                    patientmname = txt_mname.Text
                    patientlname = txt_lname.Text
                    patientbday = dtp_bday.Text.("yyyy-MM-dd")
                    patientbloodtype = cbox_bloodtype.Text
                    patientaddress = txt_address.Text
                    patientcontact = txt_contactnum.Text
                    patientemailaddress = txt_emailaddress.Text
                End If
            End If

        End If
    End Sub

    Public Sub SavePatientToDatabase(ByVal gender As String, ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal bday As String)

    End Sub
End Class