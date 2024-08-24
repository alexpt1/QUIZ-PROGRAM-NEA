<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.btn_SignUp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, -13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 103)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A- Level"
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Teal
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Location = New System.Drawing.Point(109, 156)
        Me.btn_Login.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(358, 105)
        Me.btn_Login.TabIndex = 1
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'btn_SignUp
        '
        Me.btn_SignUp.BackColor = System.Drawing.Color.Teal
        Me.btn_SignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignUp.Location = New System.Drawing.Point(109, 268)
        Me.btn_SignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_SignUp.Name = "btn_SignUp"
        Me.btn_SignUp.Size = New System.Drawing.Size(358, 105)
        Me.btn_SignUp.TabIndex = 2
        Me.btn_SignUp.Text = "Sign Up"
        Me.btn_SignUp.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 77)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maths Quiz"
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Teal
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.Location = New System.Drawing.Point(228, 381)
        Me.btn_Exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(121, 50)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(579, 444)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_SignUp)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents btn_SignUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Exit As Button
End Class
