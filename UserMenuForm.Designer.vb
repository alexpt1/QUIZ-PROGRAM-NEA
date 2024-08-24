<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserMenuForm))
        Me.btn_Createquiz = New System.Windows.Forms.Button()
        Me.btn_PrevResults = New System.Windows.Forms.Button()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.pct_Set = New System.Windows.Forms.PictureBox()
        Me.pan_PasswordCheck = New System.Windows.Forms.Panel()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Enter = New System.Windows.Forms.Button()
        Me.txt_PasswordCheck = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pct_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_PasswordCheck.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Createquiz
        '
        Me.btn_Createquiz.BackColor = System.Drawing.Color.Teal
        Me.btn_Createquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Createquiz.Location = New System.Drawing.Point(149, 368)
        Me.btn_Createquiz.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Createquiz.Name = "btn_Createquiz"
        Me.btn_Createquiz.Size = New System.Drawing.Size(268, 62)
        Me.btn_Createquiz.TabIndex = 0
        Me.btn_Createquiz.Text = "Create Quiz"
        Me.btn_Createquiz.UseVisualStyleBackColor = False
        '
        'btn_PrevResults
        '
        Me.btn_PrevResults.BackColor = System.Drawing.Color.Teal
        Me.btn_PrevResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PrevResults.Location = New System.Drawing.Point(16, 368)
        Me.btn_PrevResults.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_PrevResults.Name = "btn_PrevResults"
        Me.btn_PrevResults.Size = New System.Drawing.Size(125, 62)
        Me.btn_PrevResults.TabIndex = 1
        Me.btn_PrevResults.Text = "Previous Results"
        Me.btn_PrevResults.UseVisualStyleBackColor = False
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.Teal
        Me.btn_Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.Location = New System.Drawing.Point(425, 368)
        Me.btn_Logout.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(137, 62)
        Me.btn_Logout.TabIndex = 2
        Me.btn_Logout.Text = "Log out"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'pct_Set
        '
        Me.pct_Set.BackColor = System.Drawing.Color.Transparent
        Me.pct_Set.Image = CType(resources.GetObject("pct_Set.Image"), System.Drawing.Image)
        Me.pct_Set.Location = New System.Drawing.Point(457, 12)
        Me.pct_Set.Name = "pct_Set"
        Me.pct_Set.Size = New System.Drawing.Size(110, 110)
        Me.pct_Set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Set.TabIndex = 3
        Me.pct_Set.TabStop = False
        '
        'pan_PasswordCheck
        '
        Me.pan_PasswordCheck.Controls.Add(Me.btn_Back)
        Me.pan_PasswordCheck.Controls.Add(Me.btn_Enter)
        Me.pan_PasswordCheck.Controls.Add(Me.txt_PasswordCheck)
        Me.pan_PasswordCheck.Controls.Add(Me.Label1)
        Me.pan_PasswordCheck.Location = New System.Drawing.Point(149, 136)
        Me.pan_PasswordCheck.Name = "pan_PasswordCheck"
        Me.pan_PasswordCheck.Size = New System.Drawing.Size(270, 138)
        Me.pan_PasswordCheck.TabIndex = 4
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = CType(resources.GetObject("btn_Back.BackgroundImage"), System.Drawing.Image)
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.Location = New System.Drawing.Point(25, 86)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(48, 38)
        Me.btn_Back.TabIndex = 3
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'btn_Enter
        '
        Me.btn_Enter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Enter.Location = New System.Drawing.Point(92, 86)
        Me.btn_Enter.Name = "btn_Enter"
        Me.btn_Enter.Size = New System.Drawing.Size(158, 38)
        Me.btn_Enter.TabIndex = 2
        Me.btn_Enter.Text = "Enter"
        Me.btn_Enter.UseVisualStyleBackColor = True
        '
        'txt_PasswordCheck
        '
        Me.txt_PasswordCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PasswordCheck.Location = New System.Drawing.Point(25, 50)
        Me.txt_PasswordCheck.MaxLength = 20
        Me.txt_PasswordCheck.Name = "txt_PasswordCheck"
        Me.txt_PasswordCheck.Size = New System.Drawing.Size(225, 30)
        Me.txt_PasswordCheck.TabIndex = 1
        Me.txt_PasswordCheck.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Password:"
        '
        'UserMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(579, 444)
        Me.Controls.Add(Me.pan_PasswordCheck)
        Me.Controls.Add(Me.pct_Set)
        Me.Controls.Add(Me.btn_Logout)
        Me.Controls.Add(Me.btn_PrevResults)
        Me.Controls.Add(Me.btn_Createquiz)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserMenuForm"
        Me.Text = "UserMenuForm"
        CType(Me.pct_Set, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_PasswordCheck.ResumeLayout(False)
        Me.pan_PasswordCheck.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Createquiz As Button
    Friend WithEvents btn_PrevResults As Button
    Friend WithEvents btn_Logout As Button
    Friend WithEvents pct_Set As PictureBox
    Friend WithEvents pan_PasswordCheck As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_PasswordCheck As TextBox
    Friend WithEvents btn_Enter As Button
    Friend WithEvents btn_Back As Button
End Class
