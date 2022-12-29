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
        Me.btn_Faqs = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 83)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A- Level"
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.Teal
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.Location = New System.Drawing.Point(129, 147)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(173, 85)
        Me.btn_Login.TabIndex = 1
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'btn_SignUp
        '
        Me.btn_SignUp.BackColor = System.Drawing.Color.Teal
        Me.btn_SignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SignUp.Location = New System.Drawing.Point(129, 238)
        Me.btn_SignUp.Name = "btn_SignUp"
        Me.btn_SignUp.Size = New System.Drawing.Size(173, 85)
        Me.btn_SignUp.TabIndex = 2
        Me.btn_SignUp.Text = "Sign Up"
        Me.btn_SignUp.UseVisualStyleBackColor = False
        '
        'btn_Faqs
        '
        Me.btn_Faqs.BackColor = System.Drawing.Color.Teal
        Me.btn_Faqs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Faqs.Location = New System.Drawing.Point(12, 315)
        Me.btn_Faqs.Name = "btn_Faqs"
        Me.btn_Faqs.Size = New System.Drawing.Size(82, 34)
        Me.btn_Faqs.TabIndex = 3
        Me.btn_Faqs.Text = "FAQ's"
        Me.btn_Faqs.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 62)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maths Quiz"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Faqs)
        Me.Controls.Add(Me.btn_SignUp)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents btn_SignUp As Button
    Friend WithEvents btn_Faqs As Button
    Friend WithEvents Label2 As Label
End Class
