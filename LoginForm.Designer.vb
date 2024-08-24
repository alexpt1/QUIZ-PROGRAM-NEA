<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_ReturntoMenu = New System.Windows.Forms.Button()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.btn_SignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 155)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(231, 246)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(279, 37)
        Me.txt_Password.TabIndex = 10
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(231, 194)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(279, 37)
        Me.txt_Username.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 246)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 194)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username:"
        '
        'btn_ReturntoMenu
        '
        Me.btn_ReturntoMenu.BackColor = System.Drawing.Color.Teal
        Me.btn_ReturntoMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ReturntoMenu.Location = New System.Drawing.Point(311, 384)
        Me.btn_ReturntoMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ReturntoMenu.Name = "btn_ReturntoMenu"
        Me.btn_ReturntoMenu.Size = New System.Drawing.Size(179, 47)
        Me.btn_ReturntoMenu.TabIndex = 11
        Me.btn_ReturntoMenu.Text = "Return"
        Me.btn_ReturntoMenu.UseVisualStyleBackColor = False
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Teal
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Location = New System.Drawing.Point(113, 314)
        Me.btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(377, 63)
        Me.btn_Login.TabIndex = 14
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'btn_SignUp
        '
        Me.btn_SignUp.BackColor = System.Drawing.Color.Teal
        Me.btn_SignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignUp.Location = New System.Drawing.Point(113, 384)
        Me.btn_SignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SignUp.Name = "btn_SignUp"
        Me.btn_SignUp.Size = New System.Drawing.Size(190, 47)
        Me.btn_SignUp.TabIndex = 15
        Me.btn_SignUp.Text = "Sign Up"
        Me.btn_SignUp.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(579, 444)
        Me.Controls.Add(Me.btn_SignUp)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.btn_ReturntoMenu)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginForm"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_ReturntoMenu As Button
    Friend WithEvents btn_Login As Button
    Friend WithEvents btn_SignUp As Button
End Class
