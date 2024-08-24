Option Strict On
Public Class SelectTopicForm

    'When the save button is clicked, a message pop-up is displayed with the topics covered and the number of questions covered.
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim cheq As New System.Text.StringBuilder
        Dim sheq As New System.Text.StringBuilder
        Dim topiccount As Integer = 0

        'Iterates through pure list and adds each checked item to a string.
        For Each item In clb_Pure.CheckedItems
            cheq.Append(item)
            cheq.Append("
")
        Next item

        'Iterates through applied list and adds each checked item to a string.
        For Each item In clb_Applied.CheckedItems
            sheq.Append(item)
            sheq.Append("
")
        Next item

        If cheq.Length = 0 AndAlso sheq.Length = 0 Then
            MsgBox("Select topics")
            Exit Sub
        End If

        Me.Location = New Point(250, 250)
        Dim result As New MsgBoxResult

        'Creates a message box to confirm topics selected.
        result = MsgBox(" TOPICS SELECTED: " & " 

" & cheq.ToString & " " & sheq.ToString & "You'll be answering " & nud_Questions.Value & " questions.

Do you confirm?", vbYesNo, "Confirm")

        'Each case for the message box.
        Select Case result
            Case vbYes
                CheckBoxes(cheq.ToString, topiccount, sheq.ToString)
                NoofQuestions = CInt(nud_Questions.Value)
                'If there are too many topics for the ammount of questions then exit the sub.
                If topiccount > NoofQuestions Then
                    MsgBox("Not enough questions for number of topics selected")
                    Exit Sub
                End If
                Me.Close()
                QuestionsForm.Show()
            Case vbNo

        End Select
    End Sub

    'Adds all the topics ticked into the list of topics for the user to be questioned on.
    Sub CheckBoxes(ByVal cheq As String, ByRef topiccount As Integer, ByVal sheq As String)
        For Count = 1 To 12
            If cheq.Contains(Count & " -") Then
                ListofTopics.Add(Count)
                topiccount += 1
            Else

            End If
        Next Count
        For Count = 13 To 20
            If sheq.Contains(Count & " -") Then
                ListofTopics.Add(Count)
                topiccount += 1
            Else

            End If
        Next Count
    End Sub

    'Sets default values of the form.
    Private Sub SelectTopicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = img_Background
        pan_Pure.Show()
        pan_Applied.Hide()
        btn_rightpage.Show()
        btn_leftpage.Hide()
        clb_Applied.ScrollAlwaysVisible = False
        clb_Pure.ScrollAlwaysVisible = False
    End Sub

    'When the right arrow is clicked, the applied topics will show.
    Private Sub btn_rightpage_Click(sender As Object, e As EventArgs) Handles btn_rightpage.Click
        pan_Applied.BringToFront()
        pan_Applied.Show()
        pan_Pure.Hide()
        btn_leftpage.Show()
        btn_rightpage.Hide()
    End Sub

    'When the left arrow is clicked, the pure topics will show.
    Private Sub btn_leftpage_Click(sender As Object, e As EventArgs) Handles btn_leftpage.Click
        pan_Pure.BringToFront()
        pan_Pure.Show()
        pan_Applied.Hide()
        btn_leftpage.Hide()
        btn_rightpage.Show()
    End Sub

    'If the main menu button is clicked, the user will be directed to the user menu screen.
    Private Sub btn_MainMenu_Click(sender As Object, e As EventArgs) Handles btn_MainMenu.Click
        Me.Close()
        UserMenuForm.Show()
    End Sub
End Class