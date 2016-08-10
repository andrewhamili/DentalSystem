<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_contactnum = New System.Windows.Forms.TextBox()
        Me.txt_emailaddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbox_bloodtype = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboxpatientgender = New System.Windows.Forms.ComboBox()
        Me.pbox_patientpic = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_patientid = New System.Windows.Forms.Label()
        Me.dtp_bday = New System.Windows.Forms.DateTimePicker()
        CType(Me.pbox_patientpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Birthday*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Home Address*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "E-mail Address"
        '
        'txt_fname
        '
        Me.txt_fname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fname.Location = New System.Drawing.Point(176, 259)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(394, 26)
        Me.txt_fname.TabIndex = 2
        '
        'txt_mname
        '
        Me.txt_mname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_mname.Location = New System.Drawing.Point(176, 296)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(394, 26)
        Me.txt_mname.TabIndex = 3
        '
        'txt_address
        '
        Me.txt_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_address.Location = New System.Drawing.Point(176, 424)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(394, 26)
        Me.txt_address.TabIndex = 6
        '
        'txt_contactnum
        '
        Me.txt_contactnum.Location = New System.Drawing.Point(176, 472)
        Me.txt_contactnum.Name = "txt_contactnum"
        Me.txt_contactnum.Size = New System.Drawing.Size(394, 26)
        Me.txt_contactnum.TabIndex = 7
        '
        'txt_emailaddress
        '
        Me.txt_emailaddress.Location = New System.Drawing.Point(176, 513)
        Me.txt_emailaddress.Name = "txt_emailaddress"
        Me.txt_emailaddress.Size = New System.Drawing.Size(394, 26)
        Me.txt_emailaddress.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(169, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(308, 37)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Patient Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(33, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Blood Type"
        '
        'cbox_bloodtype
        '
        Me.cbox_bloodtype.AutoCompleteCustomSource.AddRange(New String() {"O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"})
        Me.cbox_bloodtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_bloodtype.FormattingEnabled = True
        Me.cbox_bloodtype.Items.AddRange(New Object() {"O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"})
        Me.cbox_bloodtype.Location = New System.Drawing.Point(176, 370)
        Me.cbox_bloodtype.Name = "cbox_bloodtype"
        Me.cbox_bloodtype.Size = New System.Drawing.Size(59, 26)
        Me.cbox_bloodtype.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Gender"
        '
        'cboxpatientgender
        '
        Me.cboxpatientgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxpatientgender.FormattingEnabled = True
        Me.cboxpatientgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboxpatientgender.Location = New System.Drawing.Point(176, 167)
        Me.cboxpatientgender.Name = "cboxpatientgender"
        Me.cboxpatientgender.Size = New System.Drawing.Size(121, 26)
        Me.cboxpatientgender.TabIndex = 0
        '
        'pbox_patientpic
        '
        Me.pbox_patientpic.Location = New System.Drawing.Point(438, 79)
        Me.pbox_patientpic.Name = "pbox_patientpic"
        Me.pbox_patientpic.Size = New System.Drawing.Size(132, 130)
        Me.pbox_patientpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_patientpic.TabIndex = 28
        Me.pbox_patientpic.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(577, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 29
        Me.Button1.TabStop = False
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "JPG(*.jpg)|*.jpg|JPEG(*.jpeg)|*.jpeg|PNG(*.png)|*.png|BITMAP(*.bmp)|*.bmp"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(527, 628)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(128, 56)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_lname
        '
        Me.txt_lname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lname.Location = New System.Drawing.Point(176, 222)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(394, 26)
        Me.txt_lname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Last Name*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Patient ID"
        '
        'lbl_patientid
        '
        Me.lbl_patientid.AutoSize = True
        Me.lbl_patientid.Location = New System.Drawing.Point(118, 112)
        Me.lbl_patientid.Name = "lbl_patientid"
        Me.lbl_patientid.Size = New System.Drawing.Size(68, 18)
        Me.lbl_patientid.TabIndex = 23
        Me.lbl_patientid.Text = "patientid"
        '
        'dtp_bday
        '
        Me.dtp_bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_bday.Location = New System.Drawing.Point(176, 336)
        Me.dtp_bday.Name = "dtp_bday"
        Me.dtp_bday.Size = New System.Drawing.Size(200, 26)
        Me.dtp_bday.TabIndex = 32
        '
        'PatientRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 706)
        Me.Controls.Add(Me.dtp_bday)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbox_patientpic)
        Me.Controls.Add(Me.cboxpatientgender)
        Me.Controls.Add(Me.lbl_patientid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbox_bloodtype)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_emailaddress)
        Me.Controls.Add(Me.txt_contactnum)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PatientRegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Patient Registration Form"
        CType(Me.pbox_patientpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_contactnum As System.Windows.Forms.TextBox
    Friend WithEvents txt_emailaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbox_bloodtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboxpatientgender As System.Windows.Forms.ComboBox
    Friend WithEvents pbox_patientpic As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_patientid As System.Windows.Forms.Label
    Friend WithEvents dtp_bday As System.Windows.Forms.DateTimePicker
End Class

