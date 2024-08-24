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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuestionsForm))
        Me.btn_CheckAnswer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_QuestionCount = New System.Windows.Forms.Label()
        Me.btn_NextQuestion = New System.Windows.Forms.Button()
        Me.lbl_Question = New System.Windows.Forms.Label()
        Me.lbl_Answer = New System.Windows.Forms.Label()
        Me.btn_ExitTest = New System.Windows.Forms.Button()
        Me.pgb_Questions = New System.Windows.Forms.ProgressBar()
        Me.lbl_QuestionProgress = New System.Windows.Forms.Label()
        Me.lbl_Score = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_CheckAnswer
        '
        Me.btn_CheckAnswer.Location = New System.Drawing.Point(114, 343)
        Me.btn_CheckAnswer.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_CheckAnswer.Name = "btn_CheckAnswer"
        Me.btn_CheckAnswer.Size = New System.Drawing.Size(365, 48)
        Me.btn_CheckAnswer.TabIndex = 0
        Me.btn_CheckAnswer.Text = "Check Answer"
        Me.btn_CheckAnswer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 103)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Question"
        '
        'lbl_QuestionCount
        '
        Me.lbl_QuestionCount.AutoSize = True
        Me.lbl_QuestionCount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_QuestionCount.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_QuestionCount.Location = New System.Drawing.Point(442, 9)
        Me.lbl_QuestionCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_QuestionCount.Name = "lbl_QuestionCount"
        Me.lbl_QuestionCount.Size = New System.Drawing.Size(86, 103)
        Me.lbl_QuestionCount.TabIndex = 3
        Me.lbl_QuestionCount.Text = "1"
        '
        'btn_NextQuestion
        '
        Me.btn_NextQuestion.Location = New System.Drawing.Point(114, 343)
        Me.btn_NextQuestion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_NextQuestion.Name = "btn_NextQuestion"
        Me.btn_NextQuestion.Size = New System.Drawing.Size(366, 49)
        Me.btn_NextQuestion.TabIndex = 4
        Me.btn_NextQuestion.Text = "Next Question"
        Me.btn_NextQuestion.UseVisualStyleBackColor = True
        '
        'lbl_Question
        '
        Me.lbl_Question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Question.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Question.Location = New System.Drawing.Point(114, 113)
        Me.lbl_Question.Name = "lbl_Question"
        Me.lbl_Question.Size = New System.Drawing.Size(366, 100)
        Me.lbl_Question.TabIndex = 5
        Me.lbl_Question.Text = "<Question>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_Question.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Answer
        '
        Me.lbl_Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Answer.Location = New System.Drawing.Point(114, 229)
        Me.lbl_Answer.Name = "lbl_Answer"
        Me.lbl_Answer.Size = New System.Drawing.Size(366, 100)
        Me.lbl_Answer.TabIndex = 6
        Me.lbl_Answer.Text = "<Answer>"
        Me.lbl_Answer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_ExitTest
        '
        Me.btn_ExitTest.Location = New System.Drawing.Point(12, 343)
        Me.btn_ExitTest.Name = "btn_ExitTest"
        Me.btn_ExitTest.Size = New System.Drawing.Size(95, 89)
        Me.btn_ExitTest.TabIndex = 7
        Me.btn_ExitTest.Text = "Exit Test"
        Me.btn_ExitTest.UseVisualStyleBackColor = True
        '
        'pgb_Questions
        '
        Me.pgb_Questions.Location = New System.Drawing.Point(114, 399)
        Me.pgb_Questions.Maximum = 10
        Me.pgb_Questions.Name = "pgb_Questions"
        Me.pgb_Questions.Size = New System.Drawing.Size(366, 33)
        Me.pgb_Questions.Step = 1
        Me.pgb_Questions.TabIndex = 9
        '
        'lbl_QuestionProgress
        '
        Me.lbl_QuestionProgress.AutoSize = True
        Me.lbl_QuestionProgress.BackColor = System.Drawing.Color.MintCream
        Me.lbl_QuestionProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_QuestionProgress.Location = New System.Drawing.Point(25, 204)
        Me.lbl_QuestionProgress.Name = "lbl_QuestionProgress"
        Me.lbl_QuestionProgress.Size = New System.Drawing.Size(56, 25)
        Me.lbl_QuestionProgress.TabIndex = 10
        Me.lbl_QuestionProgress.Text = "<-/->"
        '
        'lbl_Score
        '
        Me.lbl_Score.AutoSize = True
        Me.lbl_Score.BackColor = System.Drawing.Color.MintCream
        Me.lbl_Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Score.Location = New System.Drawing.Point(502, 204)
        Me.lbl_Score.Name = "lbl_Score"
        Me.lbl_Score.Size = New System.Drawing.Size(56, 25)
        Me.lbl_Score.TabIndex = 11
        Me.lbl_Score.Text = "<-/->"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(486, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 114)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Score"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 114)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Question"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Transparent
        Me.pb1.Location = New System.Drawing.Point(486, 343)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(90, 89)
        Me.pb1.TabIndex = 15
        Me.pb1.TabStop = False
        '
        'QuestionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(579, 444)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.lbl_Score)
        Me.Controls.Add(Me.lbl_QuestionProgress)
        Me.Controls.Add(Me.pgb_Questions)
        Me.Controls.Add(Me.btn_ExitTest)
        Me.Controls.Add(Me.lbl_Answer)
        Me.Controls.Add(Me.lbl_Question)
        Me.Controls.Add(Me.btn_NextQuestion)
        Me.Controls.Add(Me.lbl_QuestionCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_CheckAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "QuestionsForm"
        Me.Text = "Questions"
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_CheckAnswer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_QuestionCount As Label
    Friend WithEvents btn_NextQuestion As Button
    Friend WithEvents lbl_Question As Label
    Friend WithEvents lbl_Answer As Label
    Friend WithEvents btn_ExitTest As Button
    Friend WithEvents pgb_Questions As ProgressBar
    Friend WithEvents lbl_QuestionProgress As Label
    Friend WithEvents lbl_Score As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pb1 As PictureBox
End Class
