Imports MySql.Data.MySqlClient

Public Class PatientRegistrationForm

    Public changepictureindicator As Boolean = False
    Public random As System.Random = New System.Random()
    Public patientid As String
    Public bdayFieldChangeDetector As Boolean = False

    Private Sub PatientRegistrationForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Home.dbDataSet.Clear()
        Home.Load_Patientlist()
        Home.Show()
    End Sub



    Private Sub PatientRegistrationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        patientid = Now.ToString("yyyyHHmm")
        patientid = patientid + random.Next(1, 1000000000).ToString
        lbl_patientid.Text = patientid

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim query As String
        MySQLConn.ConnectionString = connstring


        If changepictureindicator = False Then
            Dim ans As Integer
            ans = MsgBox("You did not inculde a picture. Do you want to continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, SystemTitle)
            If ans = 6 Then
                If cboxpatientgender.Text = "" Or txt_fname.Text = "" Or txt_mname.Text = "" Or txt_lname.Text = "" Or txt_address.Text = "" Or txt_contactnum.Text = "" Or bdayFieldChangeDetector = False Then
                    MsgBox("Fileds marked with an asterisk(*) are required to be filled-up", MsgBoxStyle.Critical, SystemTitle)
                Else
                    Dim mstream As New System.IO.MemoryStream()
                    pbox_patientpic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer
                    mstream.Close()
                    Try
                        MySQLConn.Open()
                        query = "INSERT INTO patientlist values(@id, @gender, @fname, @mname, @lname,@dateofbirth, @bloodtype, @homeaddress, @contactnum, @emailaddress, @patient_image, @patientdate)"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("id", patientid)
                        comm.Parameters.AddWithValue("gender", cboxpatientgender)
                        comm.Parameters.AddWithValue("fname", txt_fname.Text)
                        comm.Parameters.AddWithValue("mname", txt_mname.Text)
                        comm.Parameters.AddWithValue("lname", txt_lname.Text)
                        comm.Parameters.AddWithValue("dateofbirth", dtp_bday.Value.ToString("yyyy-MM-dd"))
                        comm.Parameters.AddWithValue("bloodtype", cbox_bloodtype.Text)
                        comm.Parameters.AddWithValue("homeaddress", txt_address.Text)
                        comm.Parameters.AddWithValue("contactnum", txt_contactnum.Text)
                        comm.Parameters.AddWithValue("emailaddress", txt_emailaddress.Text)
                        comm.Parameters.AddWithValue("patient_image", arrImage)
                        comm.Parameters.AddWithValue("patientdate", Now.ToString("yyyy-MM-dd"))
                        reader = comm.ExecuteReader
                        MySQLConn.Close()
                        MsgBox("The Patient has been successfully registered", MsgBoxStyle.Information, SystemTitle)
                        Me.Dispose()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        MySQLConn.Dispose()
                    End Try
                End If
            End If
        Else
            If cboxpatientgender.Text = "" Or txt_fname.Text = "" Or txt_mname.Text = "" Or txt_lname.Text = "" Or txt_address.Text = "" Or txt_contactnum.Text = "" Or bdayFieldChangeDetector = False Then
                MsgBox("Fileds marked with an asterisk(*) are required to be filled-up", MsgBoxStyle.Critical, SystemTitle)
            Else
                Dim mstream As New System.IO.MemoryStream()
                pbox_patientpic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer
                mstream.Close()
                Try
                    MySQLConn.Open()
                    query = "INSERT INTO patientlist values(@id, @gender, @fname, @mname, @lname,@dateofbirth, @bloodtype, @homeaddress, @contactnum, @emailaddress, @patient_image, @patientdate)"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("id", patientid)
                    comm.Parameters.AddWithValue("gender", cboxpatientgender)
                    comm.Parameters.AddWithValue("fname", txt_fname.Text)
                    comm.Parameters.AddWithValue("mname", txt_mname.Text)
                    comm.Parameters.AddWithValue("lname", txt_lname.Text)
                    comm.Parameters.AddWithValue("dateofbirth", dtp_bday.Value.ToString("yyyy-MM-dd"))
                    comm.Parameters.AddWithValue("bloodtype", cbox_bloodtype.Text)
                    comm.Parameters.AddWithValue("homeaddress", txt_address.Text)
                    comm.Parameters.AddWithValue("contactnum", txt_contactnum.Text)
                    comm.Parameters.AddWithValue("emailaddress", txt_emailaddress.Text)
                    comm.Parameters.AddWithValue("patient_image", arrImage)
                    comm.Parameters.AddWithValue("patientdate", Now.ToString("yyyy-MM-dd"))
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MsgBox("The Patient has been successfully registered", MsgBoxStyle.Information, SystemTitle)
                    Me.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    MySQLConn.Dispose()
                End Try
            End If
        End If
    End Sub

    Private Sub cboxpatientgender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxpatientgender.SelectedIndexChanged
        If cboxpatientgender.Text = "Male" Then
            pbox_patientpic.Image = My.Resources.male_image
            changepictureindicator = False
        ElseIf cboxpatientgender.Text = "Female" Then
            pbox_patientpic.Image = My.Resources.female_image
            changepictureindicator = False
        End If
        Button1.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pbox_patientpic.Image = Image.FromFile(OpenFileDialog1.FileName)
            changepictureindicator = True
        End If
    End Sub

    Private Sub dtp_bday_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_bday.ValueChanged
        bdayFieldChangeDetector = True
    End Sub
End Class