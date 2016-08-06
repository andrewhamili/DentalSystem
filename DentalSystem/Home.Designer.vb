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
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.lbl_welcomeText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(319, 12)
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
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 363)
        Me.Controls.Add(Me.lbl_welcomeText)
        Me.Controls.Add(Me.btn_logout)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents lbl_welcomeText As System.Windows.Forms.Label
End Class
