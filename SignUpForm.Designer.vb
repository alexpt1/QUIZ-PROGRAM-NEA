<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.lnk_Login = New System.Windows.Forms.LinkLabel()
        Me.btn_ReturntoMenu = New System.Windows.Forms.Button()
        Me.nud_Age = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        CType(Me.nud_Age, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(4, -10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 155)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sign Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(67, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(72, 197)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password:"
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(251, 145)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(279, 37)
        Me.txt_Username.TabIndex = 5
        '
        'txt_Password
        '
        Me.txt_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.Location = New System.Drawing.Point(251, 197)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(279, 37)
        Me.txt_Password.TabIndex = 6
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Teal
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(153, 363)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(409, 78)
        Me.btn_Save.TabIndex = 17
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'lnk_Login
        '
        Me.lnk_Login.AutoSize = True
        Me.lnk_Login.BackColor = System.Drawing.Color.Transparent
        Me.lnk_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Login.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lnk_Login.Location = New System.Drawing.Point(41, 416)
        Me.lnk_Login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnk_Login.Name = "lnk_Login"
        Me.lnk_Login.Size = New System.Drawing.Size(0, 25)
        Me.lnk_Login.TabIndex = 16
        '
        'btn_ReturntoMenu
        '
        Me.btn_ReturntoMenu.BackColor = System.Drawing.Color.Teal
        Me.btn_ReturntoMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ReturntoMenu.Location = New System.Drawing.Point(5, 363)
        Me.btn_ReturntoMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ReturntoMenu.Name = "btn_ReturntoMenu"
        Me.btn_ReturntoMenu.Size = New System.Drawing.Size(140, 38)
        Me.btn_ReturntoMenu.TabIndex = 15
        Me.btn_ReturntoMenu.Text = "Return"
        Me.btn_ReturntoMenu.UseVisualStyleBackColor = False
        '
        'nud_Age
        '
        Me.nud_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Age.Location = New System.Drawing.Point(251, 254)
        Me.nud_Age.Margin = New System.Windows.Forms.Padding(4)
        Me.nud_Age.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nud_Age.Name = "nud_Age"
        Me.nud_Age.Size = New System.Drawing.Size(280, 37)
        Me.nud_Age.TabIndex = 18
        Me.nud_Age.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(147, 254)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 31)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(127, 309)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 31)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Email:"
        '
        'txt_Email
        '
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(251, 309)
        Me.txt_Email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(279, 37)
        Me.txt_Email.TabIndex = 21
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Teal
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Location = New System.Drawing.Point(5, 403)
        Me.btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(140, 38)
        Me.btn_Login.TabIndex = 22
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(579, 444)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.txt_Email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nud_Age)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.lnk_Login)
        Me.Controls.Add(Me.btn_ReturntoMenu)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SignUpForm"
        Me.Text = "SignUp"
        CType(Me.nud_Age, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents lnk_Login As LinkLabel
    Friend WithEvents btn_ReturntoMenu As Button
    Friend WithEvents nud_Age As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents btn_Login As Button
End Class
