<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Confirm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_NewUsername = New System.Windows.Forms.TextBox()
        Me.txt_NewUsernameConfirm = New System.Windows.Forms.TextBox()
        Me.txt_NewPassword = New System.Windows.Forms.TextBox()
        Me.txt_NewPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_Background = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Teal
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.Location = New System.Drawing.Point(12, 377)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(134, 55)
        Me.btn_Back.TabIndex = 0
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Confirm
        '
        Me.btn_Confirm.BackColor = System.Drawing.Color.Teal
        Me.btn_Confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Confirm.Location = New System.Drawing.Point(162, 377)
        Me.btn_Confirm.Name = "btn_Confirm"
        Me.btn_Confirm.Size = New System.Drawing.Size(405, 55)
        Me.btn_Confirm.TabIndex = 1
        Me.btn_Confirm.Text = "Save and Exit"
        Me.btn_Confirm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Change Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Change Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 50)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Change Background:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_NewUsername
        '
        Me.txt_NewUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewUsername.Location = New System.Drawing.Point(13, 225)
        Me.txt_NewUsername.Name = "txt_NewUsername"
        Me.txt_NewUsername.Size = New System.Drawing.Size(178, 28)
        Me.txt_NewUsername.TabIndex = 6
        '
        'txt_NewUsernameConfirm
        '
        Me.txt_NewUsernameConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewUsernameConfirm.Location = New System.Drawing.Point(13, 300)
        Me.txt_NewUsernameConfirm.Name = "txt_NewUsernameConfirm"
        Me.txt_NewUsernameConfirm.Size = New System.Drawing.Size(178, 28)
        Me.txt_NewUsernameConfirm.TabIndex = 7
        '
        'txt_NewPassword
        '
        Me.txt_NewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewPassword.Location = New System.Drawing.Point(201, 225)
        Me.txt_NewPassword.Name = "txt_NewPassword"
        Me.txt_NewPassword.Size = New System.Drawing.Size(178, 28)
        Me.txt_NewPassword.TabIndex = 8
        Me.txt_NewPassword.UseSystemPasswordChar = True
        '
        'txt_NewPasswordConfirm
        '
        Me.txt_NewPasswordConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NewPasswordConfirm.Location = New System.Drawing.Point(202, 300)
        Me.txt_NewPasswordConfirm.Name = "txt_NewPasswordConfirm"
        Me.txt_NewPasswordConfirm.Size = New System.Drawing.Size(178, 28)
        Me.txt_NewPasswordConfirm.TabIndex = 9
        Me.txt_NewPasswordConfirm.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(77, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Confirm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(265, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Confirm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Elephant", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(16, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(552, 155)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Settings"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(56, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "New Username"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(242, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "New Password"
        '
        'cbo_Background
        '
        Me.cbo_Background.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Background.FormattingEnabled = True
        Me.cbo_Background.Items.AddRange(New Object() {"Midnight Sea", "Forest Night", "Underwater", "White"})
        Me.cbo_Background.Location = New System.Drawing.Point(390, 264)
        Me.cbo_Background.Name = "cbo_Background"
        Me.cbo_Background.Size = New System.Drawing.Size(177, 33)
        Me.cbo_Background.TabIndex = 18
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 444)
        Me.Controls.Add(Me.cbo_Background)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_NewPasswordConfirm)
        Me.Controls.Add(Me.txt_NewPassword)
        Me.Controls.Add(Me.txt_NewUsernameConfirm)
        Me.Controls.Add(Me.txt_NewUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Confirm)
        Me.Controls.Add(Me.btn_Back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsForm"
        Me.Text = "SettingsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Back As Button
    Friend WithEvents btn_Confirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_NewUsername As TextBox
    Friend WithEvents txt_NewUsernameConfirm As TextBox
    Friend WithEvents txt_NewPassword As TextBox
    Friend WithEvents txt_NewPasswordConfirm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbo_Background As ComboBox
End Class
