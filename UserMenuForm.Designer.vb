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
        Me.SuspendLayout()
        '
        'btn_Createquiz
        '
        Me.btn_Createquiz.BackColor = System.Drawing.Color.Teal
        Me.btn_Createquiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Createquiz.Location = New System.Drawing.Point(112, 299)
        Me.btn_Createquiz.Name = "btn_Createquiz"
        Me.btn_Createquiz.Size = New System.Drawing.Size(201, 50)
        Me.btn_Createquiz.TabIndex = 0
        Me.btn_Createquiz.Text = "Create Quiz"
        Me.btn_Createquiz.UseVisualStyleBackColor = False
        '
        'btn_PrevResults
        '
        Me.btn_PrevResults.BackColor = System.Drawing.Color.Teal
        Me.btn_PrevResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PrevResults.Location = New System.Drawing.Point(12, 299)
        Me.btn_PrevResults.Name = "btn_PrevResults"
        Me.btn_PrevResults.Size = New System.Drawing.Size(94, 50)
        Me.btn_PrevResults.TabIndex = 1
        Me.btn_PrevResults.Text = "Previous Results"
        Me.btn_PrevResults.UseVisualStyleBackColor = False
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.Teal
        Me.btn_Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.Location = New System.Drawing.Point(319, 299)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(103, 50)
        Me.btn_Logout.TabIndex = 2
        Me.btn_Logout.Text = "Log out"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'UserMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.Controls.Add(Me.btn_Logout)
        Me.Controls.Add(Me.btn_PrevResults)
        Me.Controls.Add(Me.btn_Createquiz)
        Me.Name = "UserMenuForm"
        Me.Text = "UserMenuForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Createquiz As Button
    Friend WithEvents btn_PrevResults As Button
    Friend WithEvents btn_Logout As Button
End Class
