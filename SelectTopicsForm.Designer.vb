<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectTopicForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectTopicForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.clb_Pure = New System.Windows.Forms.CheckedListBox()
        Me.nud_Questions = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_rightpage = New System.Windows.Forms.Button()
        Me.pan_Pure = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pan_Applied = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clb_Applied = New System.Windows.Forms.CheckedListBox()
        Me.btn_leftpage = New System.Windows.Forms.Button()
        Me.btn_MainMenu = New System.Windows.Forms.Button()
        CType(Me.nud_Questions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan_Pure.SuspendLayout()
        Me.pan_Applied.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 47.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, -9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(576, 103)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select Topics"
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Save.Location = New System.Drawing.Point(416, 368)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(245, 74)
        Me.btn_Save.TabIndex = 18
        Me.btn_Save.Text = "Create Quiz"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'clb_Pure
        '
        Me.clb_Pure.BackColor = System.Drawing.Color.PowderBlue
        Me.clb_Pure.ColumnWidth = 200
        Me.clb_Pure.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Pure.FormattingEnabled = True
        Me.clb_Pure.Items.AddRange(New Object() {"1 - Algebra", "2 - Inequalities", "3 - Geometry", "4 - Binomial Expansion", "5 - Trigonometry", "6 - Logarithms", "7 - Differentiation", "8 - Integration", "9 - Vectors", "10 - Parametric Equations", "11 - Series", "12 - Numerical Methods"})
        Me.clb_Pure.Location = New System.Drawing.Point(30, 30)
        Me.clb_Pure.Margin = New System.Windows.Forms.Padding(4)
        Me.clb_Pure.MultiColumn = True
        Me.clb_Pure.Name = "clb_Pure"
        Me.clb_Pure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clb_Pure.Size = New System.Drawing.Size(496, 204)
        Me.clb_Pure.TabIndex = 30
        Me.clb_Pure.ThreeDCheckBoxes = True
        '
        'nud_Questions
        '
        Me.nud_Questions.BackColor = System.Drawing.Color.PowderBlue
        Me.nud_Questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_Questions.Location = New System.Drawing.Point(179, 395)
        Me.nud_Questions.Margin = New System.Windows.Forms.Padding(4)
        Me.nud_Questions.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nud_Questions.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nud_Questions.Name = "nud_Questions"
        Me.nud_Questions.Size = New System.Drawing.Size(157, 46)
        Me.nud_Questions.TabIndex = 26
        Me.nud_Questions.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 367)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Number of questions (5-50):"
        '
        'btn_rightpage
        '
        Me.btn_rightpage.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_rightpage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rightpage.Location = New System.Drawing.Point(616, 153)
        Me.btn_rightpage.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_rightpage.Name = "btn_rightpage"
        Me.btn_rightpage.Size = New System.Drawing.Size(45, 140)
        Me.btn_rightpage.TabIndex = 32
        Me.btn_rightpage.Text = ">"
        Me.btn_rightpage.UseVisualStyleBackColor = False
        '
        'pan_Pure
        '
        Me.pan_Pure.BackColor = System.Drawing.Color.CadetBlue
        Me.pan_Pure.Controls.Add(Me.Label4)
        Me.pan_Pure.Controls.Add(Me.clb_Pure)
        Me.pan_Pure.Location = New System.Drawing.Point(61, 98)
        Me.pan_Pure.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_Pure.Name = "pan_Pure"
        Me.pan_Pure.Size = New System.Drawing.Size(547, 238)
        Me.pan_Pure.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 26)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Pure"
        '
        'pan_Applied
        '
        Me.pan_Applied.BackColor = System.Drawing.Color.CadetBlue
        Me.pan_Applied.Controls.Add(Me.Label3)
        Me.pan_Applied.Controls.Add(Me.clb_Applied)
        Me.pan_Applied.Location = New System.Drawing.Point(61, 98)
        Me.pan_Applied.Margin = New System.Windows.Forms.Padding(4)
        Me.pan_Applied.Name = "pan_Applied"
        Me.pan_Applied.Size = New System.Drawing.Size(543, 238)
        Me.pan_Applied.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 26)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Statistics and Mechanics"
        '
        'clb_Applied
        '
        Me.clb_Applied.BackColor = System.Drawing.Color.PowderBlue
        Me.clb_Applied.ColumnWidth = 200
        Me.clb_Applied.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_Applied.FormattingEnabled = True
        Me.clb_Applied.Items.AddRange(New Object() {"13 - Sampling", "14 - Probability", "15 - Binomial Distributions", "16 - Hypothesis Testing", "17 - Normal Distribution", "18 - Kinematics", "19 - Newtons Laws", "20 - Moments"})
        Me.clb_Applied.Location = New System.Drawing.Point(25, 30)
        Me.clb_Applied.Margin = New System.Windows.Forms.Padding(4)
        Me.clb_Applied.Name = "clb_Applied"
        Me.clb_Applied.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clb_Applied.Size = New System.Drawing.Size(496, 204)
        Me.clb_Applied.TabIndex = 31
        Me.clb_Applied.ThreeDCheckBoxes = True
        '
        'btn_leftpage
        '
        Me.btn_leftpage.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_leftpage.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_leftpage.Location = New System.Drawing.Point(8, 153)
        Me.btn_leftpage.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_leftpage.Name = "btn_leftpage"
        Me.btn_leftpage.Size = New System.Drawing.Size(45, 140)
        Me.btn_leftpage.TabIndex = 34
        Me.btn_leftpage.Text = "<"
        Me.btn_leftpage.UseVisualStyleBackColor = False
        '
        'btn_MainMenu
        '
        Me.btn_MainMenu.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_MainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MainMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_MainMenu.Location = New System.Drawing.Point(13, 371)
        Me.btn_MainMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_MainMenu.Name = "btn_MainMenu"
        Me.btn_MainMenu.Size = New System.Drawing.Size(104, 70)
        Me.btn_MainMenu.TabIndex = 35
        Me.btn_MainMenu.Text = "Main Menu"
        Me.btn_MainMenu.UseVisualStyleBackColor = False
        '
        'SelectTopicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(668, 448)
        Me.Controls.Add(Me.btn_MainMenu)
        Me.Controls.Add(Me.pan_Applied)
        Me.Controls.Add(Me.pan_Pure)
        Me.Controls.Add(Me.btn_leftpage)
        Me.Controls.Add(Me.btn_rightpage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nud_Questions)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SelectTopicForm"
        Me.Text = "SelectTopic"
        CType(Me.nud_Questions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan_Pure.ResumeLayout(False)
        Me.pan_Pure.PerformLayout()
        Me.pan_Applied.ResumeLayout(False)
        Me.pan_Applied.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents clb_Pure As CheckedListBox
    Friend WithEvents nud_Questions As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_rightpage As Button
    Friend WithEvents pan_Pure As Panel
    Friend WithEvents pan_Applied As Panel
    Friend WithEvents btn_leftpage As Button
    Friend WithEvents clb_Applied As CheckedListBox
    Friend WithEvents btn_MainMenu As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
