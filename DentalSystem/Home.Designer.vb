<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.lbl_welcomeText = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Timer_DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPatientlist = New System.Windows.Forms.TabPage()
        Me.dgv_patientlist = New System.Windows.Forms.DataGridView()
        Me.btn_AddPatient = New System.Windows.Forms.Button()
        Me.btn_UserAccountManagement = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPatientlist.SuspendLayout()
        CType(Me.dgv_patientlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(1204, -1)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(95, 51)
        Me.btn_logout.TabIndex = 0
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'lbl_welcomeText
        '
        Me.lbl_welcomeText.AutoSize = True
        Me.lbl_welcomeText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_welcomeText.Location = New System.Drawing.Point(13, 12)
        Me.lbl_welcomeText.Name = "lbl_welcomeText"
        Me.lbl_welcomeText.Size = New System.Drawing.Size(134, 22)
        Me.lbl_welcomeText.TabIndex = 1
        Me.lbl_welcomeText.Text = "WelcomeText"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Location = New System.Drawing.Point(14, 42)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(42, 18)
        Me.lbl_date.TabIndex = 2
        Me.lbl_date.Text = "Date"
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(14, 60)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(42, 18)
        Me.lbl_time.TabIndex = 3
        Me.lbl_time.Text = "Time"
        '
        'Timer_DateTime
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPatientlist)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 143)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1306, 375)
        Me.TabControl1.TabIndex = 4
        '
        'TabPatientlist
        '
        Me.TabPatientlist.Controls.Add(Me.dgv_patientlist)
        Me.TabPatientlist.Location = New System.Drawing.Point(4, 27)
        Me.TabPatientlist.Name = "TabPatientlist"
        Me.TabPatientlist.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPatientlist.Size = New System.Drawing.Size(1298, 344)
        Me.TabPatientlist.TabIndex = 0
        Me.TabPatientlist.Text = "Patients"
        Me.TabPatientlist.UseVisualStyleBackColor = True
        '
        'dgv_patientlist
        '
        Me.dgv_patientlist.AllowUserToAddRows = False
        Me.dgv_patientlist.AllowUserToDeleteRows = False
        Me.dgv_patientlist.AllowUserToOrderColumns = True
        Me.dgv_patientlist.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv_patientlist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_patientlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_patientlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_patientlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_patientlist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_patientlist.Location = New System.Drawing.Point(3, 3)
        Me.dgv_patientlist.Name = "dgv_patientlist"
        Me.dgv_patientlist.RowHeadersVisible = False
        Me.dgv_patientlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_patientlist.Size = New System.Drawing.Size(1292, 338)
        Me.dgv_patientlist.TabIndex = 0
        '
        'btn_AddPatient
        '
        Me.btn_AddPatient.Location = New System.Drawing.Point(1153, 114)
        Me.btn_AddPatient.Name = "btn_AddPatient"
        Me.btn_AddPatient.Size = New System.Drawing.Size(146, 50)
        Me.btn_AddPatient.TabIndex = 5
        Me.btn_AddPatient.Text = "Add Patient"
        Me.btn_AddPatient.UseVisualStyleBackColor = True
        '
        'btn_UserAccountManagement
        '
        Me.btn_UserAccountManagement.Location = New System.Drawing.Point(1078, -1)
        Me.btn_UserAccountManagement.Name = "btn_UserAccountManagement"
        Me.btn_UserAccountManagement.Size = New System.Drawing.Size(120, 51)
        Me.btn_UserAccountManagement.TabIndex = 6
        Me.btn_UserAccountManagement.Text = "User Account Management"
        Me.btn_UserAccountManagement.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 518)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_UserAccountManagement)
        Me.Controls.Add(Me.btn_AddPatient)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_welcomeText)
        Me.Controls.Add(Me.btn_logout)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPatientlist.ResumeLayout(False)
        CType(Me.dgv_patientlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents lbl_welcomeText As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents Timer_DateTime As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPatientlist As System.Windows.Forms.TabPage
    Friend WithEvents dgv_patientlist As System.Windows.Forms.DataGridView
    Friend WithEvents btn_AddPatient As System.Windows.Forms.Button
    Friend WithEvents btn_UserAccountManagement As System.Windows.Forms.Button
End Class
