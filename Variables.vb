Module Variables
    Public Question As New Label
    Public Answer As New Label
    Public tbox As New TextBox
    Public QuestionCount As Integer = 0
    Public NoofQuestions As Integer = 0
    Public labels(20) As Label
    Public Topics(20) As String
    Public Sub AddQuestion()
        'QuestionsForm.Controls.Add(Question)
        'Question.AutoSize = False
        'Question.SetBounds(20, 100, 400, 100)
        'Question.Font = New Font("Arial", 18)
        'Question.Text = "Differentiate x^5 with respect to x"
        'Question.Visible = True
    End Sub
    Public Sub AddAnswer()
        'QuestionsForm.Controls.Add(Answer)
        'Answer.AutoSize = False
        'Answer.SetBounds(100, 200, 200, 200)
        'Answer.Font = New Font("Arial", 18)
        'Answer.Text = ("Answer : 5x^4")
        'Answer.Visible = True
    End Sub
    Public Sub AddTbox()
        QuestionsForm.Controls.Add(tbox)
    End Sub




    'Public TopicList(100) As String
    'Public UsedTopicList() As String
End Module