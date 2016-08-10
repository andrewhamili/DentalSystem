<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManagement
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
        Me.rdio_createUser = New System.Windows.Forms.RadioButton()
        Me.rdio_editUser = New System.Windows.Forms.RadioButton()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.cbox_usertype = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_retypepassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbox_username = New System.Windows.Forms.ListBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdio_createUser
        '
        Me.rdio_createUser.AutoSize = True
        Me.rdio_createUser.Checked = True
        Me.rdio_createUser.Location = New System.Drawing.Point(9, 50)
        Me.rdio_createUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdio_createUser.Name = "rdio_createUser"
        Me.rdio_createUser.Size = New System.Drawing.Size(111, 22)
        Me.rdio_createUser.TabIndex = 99
        Me.rdio_createUser.Text = "Create User"
        Me.rdio_createUser.UseVisualStyleBackColor = True
        '
        'rdio_editUser
        '
        Me.rdio_editUser.AutoSize = True
        Me.rdio_editUser.Location = New System.Drawing.Point(158, 50)
        Me.rdio_editUser.Name = "rdio_editUser"
        Me.rdio_editUser.Size = New System.Drawing.Size(159, 22)
        Me.rdio_editUser.TabIndex = 99
        Me.rdio_editUser.Text = "Edit or Delete User"
        Me.rdio_editUser.UseVisualStyleBackColor = True
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(143, 235)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(152, 26)
        Me.txt_lname.TabIndex = 0
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(143, 280)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(152, 26)
        Me.txt_fname.TabIndex = 1
        '
        'txt_mname
        '
        Me.txt_mname.Location = New System.Drawing.Point(143, 325)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(152, 26)
        Me.txt_mname.TabIndex = 2
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(143, 370)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(152, 26)
        Me.txt_username.TabIndex = 3
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(143, 413)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(152, 26)
        Me.txt_password.TabIndex = 4
        Me.txt_password.UseSystemPasswordChar = True
        '
        'cbox_usertype
        '
        Me.cbox_usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_usertype.FormattingEnabled = True
        Me.cbox_usertype.Items.AddRange(New Object() {"Admin", "User"})
        Me.cbox_usertype.Location = New System.Drawing.Point(141, 494)
        Me.cbox_usertype.Name = "cbox_usertype"
        Me.cbox_usertype.Size = New System.Drawing.Size(152, 26)
        Me.cbox_usertype.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Usertype"
        '
        'txt_retypepassword
        '
        Me.txt_retypepassword.Location = New System.Drawing.Point(143, 445)
        Me.txt_retypepassword.Name = "txt_retypepassword"
        Me.txt_retypepassword.Size = New System.Drawing.Size(152, 26)
        Me.txt_retypepassword.TabIndex = 5
        Me.txt_retypepassword.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Retype Password"
        '
        'lbox_username
        '
        Me.lbox_username.FormattingEnabled = True
        Me.lbox_username.ItemHeight = 18
        Me.lbox_username.Location = New System.Drawing.Point(27, 100)
        Me.lbox_username.Name = "lbox_username"
        Me.lbox_username.Size = New System.Drawing.Size(268, 94)
        Me.lbox_username.TabIndex = 15
        Me.lbox_username.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(197, 551)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 35)
        Me.btn_save.TabIndex = 16
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(68, 551)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(123, 35)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'AccountManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 598)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbox_username)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_retypepassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbox_usertype)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.rdio_editUser)
        Me.Controls.Add(Me.rdio_createUser)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountManagement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdio_createUser As System.Windows.Forms.RadioButton
    Friend WithEvents rdio_editUser As System.Windows.Forms.RadioButton
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents cbox_usertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_retypepassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbox_username As System.Windows.Forms.ListBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
End Class
