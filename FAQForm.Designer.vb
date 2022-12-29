<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAQForm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1. Click Sign Up on the main menu.")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2. Enter username, password, age and email.")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("How do you create an account?", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("All questions from the Edexcel A-Level mathematics syllabus.")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Which questions can I include in my quizzes?", New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.FAQ_Content = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Return
        '
        Me.btn_Return.BackColor = System.Drawing.Color.Teal
        Me.btn_Return.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Return.Location = New System.Drawing.Point(3, 311)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(419, 38)
        Me.btn_Return.TabIndex = 0
        Me.btn_Return.Text = "Return"
        Me.btn_Return.UseVisualStyleBackColor = False
        '
        'FAQ_Content
        '
        Me.FAQ_Content.BackColor = System.Drawing.Color.PowderBlue
        Me.FAQ_Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FAQ_Content.ItemHeight = 20
        Me.FAQ_Content.Location = New System.Drawing.Point(3, 83)
        Me.FAQ_Content.Name = "FAQ_Content"
        TreeNode1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        TreeNode1.ForeColor = System.Drawing.Color.Black
        TreeNode1.Name = "Child0"
        TreeNode1.Text = "1. Click Sign Up on the main menu."
        TreeNode2.Name = "Child1"
        TreeNode2.Text = "2. Enter username, password, age and email."
        TreeNode3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        TreeNode3.ForeColor = System.Drawing.Color.Black
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "How do you create an account?"
        TreeNode4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        TreeNode4.ForeColor = System.Drawing.Color.Black
        TreeNode4.Name = "Child2"
        TreeNode4.Text = "All questions from the Edexcel A-Level mathematics syllabus."
        TreeNode5.Name = "Node1"
        TreeNode5.Text = "Which questions can I include in my quizzes?"
        Me.FAQ_Content.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode5})
        Me.FAQ_Content.Size = New System.Drawing.Size(426, 222)
        Me.FAQ_Content.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Elephant", 47.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 83)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FAQ's"
        '
        'FAQForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FAQ_Content)
        Me.Controls.Add(Me.btn_Return)
        Me.Name = "FAQForm"
        Me.Text = "FAQForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Return As Button
    Friend WithEvents FAQ_Content As TreeView
    Friend WithEvents Label1 As Label
End Class
