Public Class QuestionsForm
    Private Sub QuestionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
        QuestionCount = QuestionCount + 1
        lbl_QuestionCount.Text = QuestionCount
        btn_Move.Text = "Show Answer"
        AddQuestion()
    End Sub

    Private Sub DisplayAnswer()
        AddAnswer()
        lbl_QuestionCount.Text = QuestionCount
    End Sub

    Private Sub btn_Move_Click(sender As Object, e As EventArgs) Handles btn_Move.Click
        If btn_Move.Text = "Show Answer" Then
            btn_Move.Text = "Next Question"
            DisplayAnswer()
        Else
            btn_Move.Text = "Show Answer"
            QuestionCount = QuestionCount + 1
            lbl_QuestionCount.Text = QuestionCount
        End If
    End Sub

End Class