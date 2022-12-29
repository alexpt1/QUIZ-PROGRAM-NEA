<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuestionsForm
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
        Me.btn_Move = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_QuestionCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_Move
        '
        Me.btn_Move.Location = New System.Drawing.Point(158, 305)
        Me.btn_Move.Name = "btn_Move"
        Me.btn_Move.Size = New System.Drawing.Size(117, 23)
        Me.btn_Move.TabIndex = 0
        Me.btn_Move.Text = "Show Answer"
        Me.btn_Move.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 83)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Question"
        '
        'lbl_QuestionCount
        '
        Me.lbl_QuestionCount.AutoSize = True
        Me.lbl_QuestionCount.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_QuestionCount.Location = New System.Drawing.Point(333, 9)
        Me.lbl_QuestionCount.Name = "lbl_QuestionCount"
        Me.lbl_QuestionCount.Size = New System.Drawing.Size(69, 83)
        Me.lbl_QuestionCount.TabIndex = 3
        Me.lbl_QuestionCount.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "f(x) = 4x^3 – 12x^2 + 2x – 6 "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(411, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Show that (x – 3) is a factor of f(x)"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"f(3) = 0", "f(-3) = 0"})
        Me.ComboBox1.Location = New System.Drawing.Point(108, 234)
        Me.ComboBox1.MaxDropDownItems = 2
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 45)
        Me.ComboBox1.TabIndex = 7
        '
        'QuestionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_QuestionCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Move)
        Me.Name = "QuestionsForm"
        Me.Text = "Questions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Move As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_QuestionCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
