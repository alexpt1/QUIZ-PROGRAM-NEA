<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserResultsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserResultsForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.lbl_Sort = New System.Windows.Forms.Label()
        Me.btn_Sort = New System.Windows.Forms.Button()
        Me.lbl_Error = New System.Windows.Forms.Label()
        Me.lbl_Percentage = New System.Windows.Forms.Label()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lbl_Score = New System.Windows.Forms.Label()
        Me.lbl_UserID = New System.Windows.Forms.Label()
        Me.lbl_User = New System.Windows.Forms.Label()
        Me.pan_Sort = New System.Windows.Forms.Panel()
        Me.btn_GoBack = New System.Windows.Forms.Button()
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Error2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.pan_Sort.SuspendLayout()
        Me.tp2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp1)
        Me.TabControl1.Controls.Add(Me.tp2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(270, 30)
        Me.TabControl1.Location = New System.Drawing.Point(-2, 77)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(85, 3)
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(594, 384)
        Me.TabControl1.TabIndex = 0
        '
        'tp1
        '
        Me.tp1.BackColor = System.Drawing.Color.Teal
        Me.tp1.Controls.Add(Me.lbl_Sort)
        Me.tp1.Controls.Add(Me.btn_Sort)
        Me.tp1.Controls.Add(Me.lbl_Error)
        Me.tp1.Controls.Add(Me.lbl_Percentage)
        Me.tp1.Controls.Add(Me.lbl_Total)
        Me.tp1.Controls.Add(Me.lbl_Score)
        Me.tp1.Controls.Add(Me.lbl_UserID)
        Me.tp1.Controls.Add(Me.lbl_User)
        Me.tp1.Controls.Add(Me.pan_Sort)
        Me.tp1.Location = New System.Drawing.Point(4, 34)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tp1.Size = New System.Drawing.Size(586, 346)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "List"
        '
        'lbl_Sort
        '
        Me.lbl_Sort.AutoSize = True
        Me.lbl_Sort.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Sort.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sort.Location = New System.Drawing.Point(202, 45)
        Me.lbl_Sort.Name = "lbl_Sort"
        Me.lbl_Sort.Size = New System.Drawing.Size(211, 20)
        Me.lbl_Sort.TabIndex = 8
        Me.lbl_Sort.Text = "(Ascending Percentage)"
        '
        'btn_Sort
        '
        Me.btn_Sort.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sort.Location = New System.Drawing.Point(133, 38)
        Me.btn_Sort.Name = "btn_Sort"
        Me.btn_Sort.Size = New System.Drawing.Size(63, 31)
        Me.btn_Sort.TabIndex = 7
        Me.btn_Sort.Text = "Sort"
        Me.btn_Sort.UseVisualStyleBackColor = True
        '
        'lbl_Error
        '
        Me.lbl_Error.AutoSize = True
        Me.lbl_Error.BackColor = System.Drawing.Color.White
        Me.lbl_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Error.Location = New System.Drawing.Point(171, 132)
        Me.lbl_Error.Name = "lbl_Error"
        Me.lbl_Error.Size = New System.Drawing.Size(190, 20)
        Me.lbl_Error.TabIndex = 6
        Me.lbl_Error.Text = "No Records Available"
        '
        'lbl_Percentage
        '
        Me.lbl_Percentage.AutoSize = True
        Me.lbl_Percentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Percentage.Location = New System.Drawing.Point(405, 74)
        Me.lbl_Percentage.Name = "lbl_Percentage"
        Me.lbl_Percentage.Size = New System.Drawing.Size(104, 20)
        Me.lbl_Percentage.TabIndex = 5
        Me.lbl_Percentage.Text = "Percentage"
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(240, 74)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(51, 20)
        Me.lbl_Total.TabIndex = 4
        Me.lbl_Total.Text = "Total"
        '
        'lbl_Score
        '
        Me.lbl_Score.AutoSize = True
        Me.lbl_Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score.Location = New System.Drawing.Point(59, 74)
        Me.lbl_Score.Name = "lbl_Score"
        Me.lbl_Score.Size = New System.Drawing.Size(58, 20)
        Me.lbl_Score.TabIndex = 3
        Me.lbl_Score.Text = "Score"
        '
        'lbl_UserID
        '
        Me.lbl_UserID.Location = New System.Drawing.Point(376, 3)
        Me.lbl_UserID.Name = "lbl_UserID"
        Me.lbl_UserID.Size = New System.Drawing.Size(210, 32)
        Me.lbl_UserID.TabIndex = 2
        Me.lbl_UserID.Text = "User ID :"
        '
        'lbl_User
        '
        Me.lbl_User.Location = New System.Drawing.Point(51, 3)
        Me.lbl_User.Name = "lbl_User"
        Me.lbl_User.Size = New System.Drawing.Size(319, 32)
        Me.lbl_User.TabIndex = 0
        Me.lbl_User.Text = "User :"
        '
        'pan_Sort
        '
        Me.pan_Sort.Controls.Add(Me.btn_GoBack)
        Me.pan_Sort.Location = New System.Drawing.Point(25, 169)
        Me.pan_Sort.Name = "pan_Sort"
        Me.pan_Sort.Size = New System.Drawing.Size(555, 334)
        Me.pan_Sort.TabIndex = 9
        '
        'btn_GoBack
        '
        Me.btn_GoBack.BackColor = System.Drawing.Color.Transparent
        Me.btn_GoBack.BackgroundImage = CType(resources.GetObject("btn_GoBack.BackgroundImage"), System.Drawing.Image)
        Me.btn_GoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_GoBack.Location = New System.Drawing.Point(35, 28)
        Me.btn_GoBack.Name = "btn_GoBack"
        Me.btn_GoBack.Size = New System.Drawing.Size(48, 38)
        Me.btn_GoBack.TabIndex = 4
        Me.btn_GoBack.UseVisualStyleBackColor = False
        '
        'tp2
        '
        Me.tp2.BackColor = System.Drawing.Color.Teal
        Me.tp2.Controls.Add(Me.Label3)
        Me.tp2.Controls.Add(Me.lbl_Error2)
        Me.tp2.Location = New System.Drawing.Point(4, 34)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(3)
        Me.tp2.Size = New System.Drawing.Size(586, 346)
        Me.tp2.TabIndex = 1
        Me.tp2.Text = "Graph"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Percent in Each Quiz"
        '
        'lbl_Error2
        '
        Me.lbl_Error2.AutoSize = True
        Me.lbl_Error2.BackColor = System.Drawing.Color.White
        Me.lbl_Error2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Error2.Location = New System.Drawing.Point(170, 123)
        Me.lbl_Error2.Name = "lbl_Error2"
        Me.lbl_Error2.Size = New System.Drawing.Size(190, 20)
        Me.lbl_Error2.TabIndex = 7
        Me.lbl_Error2.Text = "No Records Available"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-5, -3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(597, 77)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Results"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BackgroundImage = CType(resources.GetObject("btn_Back.BackgroundImage"), System.Drawing.Image)
        Me.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Back.Location = New System.Drawing.Point(-2, -3)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(64, 59)
        Me.btn_Back.TabIndex = 5
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'UserResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 444)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserResultsForm"
        Me.Text = "UserResultsForm"
        Me.TabControl1.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.tp1.PerformLayout()
        Me.pan_Sort.ResumeLayout(False)
        Me.tp2.ResumeLayout(False)
        Me.tp2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tp1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_User As Label
    Friend WithEvents tp2 As TabPage
    Friend WithEvents lbl_UserID As Label
    Friend WithEvents lbl_Percentage As Label
    Friend WithEvents lbl_Total As Label
    Friend WithEvents lbl_Score As Label
    Friend WithEvents btn_Back As Button
    Friend WithEvents lbl_Error As Label
    Friend WithEvents lbl_Error2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_Sort As Label
    Friend WithEvents btn_Sort As Button
    Friend WithEvents pan_Sort As Panel
    Friend WithEvents btn_GoBack As Button
End Class
