Option Strict On
Imports System.Data.SqlClient

Public Class QuestionsForm
    Const cLettersandSymbols = "abcdefghijklmnopqrstuvwABCDEFGHIJKLMNOPQRSTUVWXYZ!£$%&*()_+-={}[]:@;'?,./#~¬`|\"
    Private TextBoxes As New List(Of TextBox)
    Private RadioButtons As New List(Of RadioButton)
    Private ComboBoxes As New List(Of ComboBox)
    Private UsedQuestions As New List(Of Integer)
    Private qposition As Integer
    Private Questions As New List(Of String)
    Private Answers As New List(Of String)
    Private Types As New List(Of Integer)

    Dim Tick As Image = Image.FromFile("C:\Users\alexp\OneDrive\Pictures\Camera Roll\Tick.png")
    Dim Cross As Image = Image.FromFile("C:\Users\alexp\OneDrive\Pictures\Camera Roll\Cross.png")

    'Only used with comboboxes and radio buttons, not textboxes.
    Private CorrectAnswer As String

    'Initialises the form by setting default values, creating the answer methods and calling the GetQuestion sub to show the first question to the user.
    Private Sub QuestionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Question As String = "<default>"
        Dim Answer As String = "<default>"
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = img_Background
        Me.Location = New Point(250, 250)
        pb1.BackgroundImageLayout = ImageLayout.Stretch

        'Creates all the answer methods and adds them to appropriate lists.
        DynamicCreationofControls()

        'Initialises the form and creates the answer methods.
        InitialiseForm()


        'Calls all the functions to add all the valid database values to lists.
        Questions = GetListofQuestions()
        Answers = GetListofAnswers()
        Types = GetListofTypes()

        GetQuestion()
    End Sub

    'Checks if the user enters a valid answer and if so calls the GetAnswer sub.
    Private Sub btn_CheckAnswer_Click(sender As Object, e As EventArgs) Handles btn_CheckAnswer.Click

        'Check if an answer is valid.
        If Types(qposition) = 1 Then
            If TextBoxes(0).Text = "" Or TextBoxes(0).Text.Length > 5 Then
                MsgBox("Enter valid answer")
                TextBoxes(0).Text = ""
                Exit Sub
            Else
                For Count = 0 To TextBoxes(0).Text.Length - 1
                    If cLettersandSymbols.Contains(TextBoxes(0).Text(Count)) Then
                        MsgBox("Enter valid answer")
                        TextBoxes(0).Text = ""
                        Exit Sub
                    End If
                Next Count
            End If
        ElseIf Types(qposition) = 2 Then
            If ComboBoxes(0).SelectedItem Is vbNullChar Then
                MsgBox("Select an answer")
                Exit Sub
            End If
        ElseIf Types(qposition) = 3 Then
            If RadioButtons(0).Checked = False AndAlso RadioButtons(1).Checked = False Then
                MsgBox("Check a box")
                Exit Sub
            End If
        End If

        'Incraments the progress counter.
        pgb_Questions.PerformStep()

        btn_NextQuestion.Show()
        btn_CheckAnswer.Hide()
        GetAnswer()
    End Sub

    'Resets all the values changed and calls the GetQuestion sub.
    Private Sub btn_NextQuestion_Click(sender As Object, e As EventArgs) Handles btn_NextQuestion.Click
        btn_CheckAnswer.Show()
        btn_NextQuestion.Hide()
        lbl_Answer.Text = ""
        TextBoxes(0).Text = ""
        TextBoxes(0).ForeColor = Color.Black
        ComboBoxes(0).Items.Clear()
        ComboBoxes(0).SelectedIndex = -1
        RadioButtons(0).Checked = False
        RadioButtons(1).Checked = False
        pb1.BackgroundImage = Nothing
        GetQuestion()
    End Sub

    'Displays the next question for the user to answer.
    Private Sub GetQuestion()
        Dim qOK As Boolean = False
        QuestionCount += 1
        lbl_QuestionCount.Text = CStr(QuestionCount)

        'Exit quiz if user has completed the set number of questions.
        If QuestionCount > NoofQuestions Then
            SubmitResuts()
            Me.Close()
            DeleteItemsinLists()
            MsgBox("Quiz Completed")
            UserMenuForm.Show()
            Exit Sub
        End If

        'Gets random question in the questions list and loops until it reaches one that hasn't already appeared.
        Do
            Randomize()
            qposition = CInt(Int(Questions.Count * Rnd()))
            If UsedQuestions.Contains(qposition) Then
                qOK = False
            Else
                qOK = True
                UsedQuestions.Add(qposition)
            End If
        Loop Until qOK = True

        lbl_QuestionProgress.Text = (QuestionCount & "/" & NoofQuestions)

        'When the question is answered with a textbox.
        If Types(qposition) = 1 Then
            lbl_QuestionCount.Text = CStr(QuestionCount)
            lbl_Question.Text = CStr(Questions(qposition))
            TextBoxes(0).Show()
            TextBoxes(0).BringToFront()

            'When the question is answered with a combobox.
        ElseIf Types(qposition) = 2 Then
            lbl_Question.Text = CStr(Questions(qposition))
            Dim strArr() As String

            'Adds all the answer options to an array.
            strArr = Answers(qposition).Split(CChar("|"))
            For Count = 0 To strArr.Length - 1
                If strArr(Count).Contains("C") Then
                    CorrectAnswer = strArr(Count).Replace("C", "")

                    'All answer options are added to the combobox.
                    ComboBoxes(0).Items.Add(strArr(Count).Replace("C", ""))
                Else
                    ComboBoxes(0).Items.Add(strArr(Count))
                End If
            Next Count
            ComboBoxes(0).Show()
            ComboBoxes(0).BringToFront()

            'When the question is answered with radio buttons.
        ElseIf Types(qposition) = 3 Then
            lbl_Question.Text = CStr(Questions(qposition))
            Dim strArr() As String

            'Adds all the answer options to an array.
            strArr = Answers(qposition).Split(CChar("|"))
            For Count = 0 To 1
                If strArr(Count).Contains("C") Then
                    CorrectAnswer = strArr(Count).Replace("C", "")

                    'All answer options are added to the radio buttons.
                    RadioButtons(Count).Text = (strArr(Count).Replace("C", ""))
                Else
                    RadioButtons(Count).Text = strArr(Count)
                End If
            Next Count
            If RadioButtons(0).Text.Length > 11 Then RadioButtons(0).Font = New Font("Micrisoft Sans Serif", 8, FontStyle.Regular)
            If RadioButtons(1).Text.Length > 11 Then RadioButtons(1).Font = New Font("Micrisoft Sans Serif", 8, FontStyle.Regular)
            RadioButtons(0).Show()
            RadioButtons(0).BringToFront()
            RadioButtons(1).Show()
            RadioButtons(1).BringToFront()
        End If
    End Sub

    'If the answer entered is valid, then the answer will be checked against the correct value in the database.
    Private Sub GetAnswer()
        If QuestionCount = NoofQuestions Then btn_NextQuestion.Text = "Finish Test"

        'When the question is answered with a textbox.
        If Types(qposition) = 1 Then
            lbl_Answer.Text = "Answer : " & CStr(Answers(qposition))
            If TextBoxes(0).Text = CStr(Answers(qposition)) Then
                Score += 1
                pb1.BackgroundImage = Tick
            Else
                pb1.BackgroundImage = Cross
            End If

            'When the question is answered with a combobox.
        ElseIf Types(qposition) = 2 Then
            lbl_Answer.Text = "Answer : " & CorrectAnswer
            If CStr(ComboBoxes(0).SelectedItem) = CStr(CorrectAnswer) Then
                Score += 1
                pb1.BackgroundImage = Tick
            Else
                pb1.BackgroundImage = Cross
            End If

            'When the question is answered with radio buttons.
        ElseIf Types(qposition) = 3 Then
            lbl_Answer.Text = "Answer : " & CorrectAnswer
            If RadioButtons(0).Text = CorrectAnswer Then
                If RadioButtons(0).Checked = True Then
                    Score += 1
                    pb1.BackgroundImage = Tick
                Else
                    pb1.BackgroundImage = Cross
                End If
            Else
                If RadioButtons(1).Checked = True Then
                    Score += 1
                    pb1.BackgroundImage = Tick
                Else
                    pb1.BackgroundImage = Cross
                End If
            End If
        End If

        TextBoxes(0).Hide()
        ComboBoxes(0).Hide()
        RadioButtons(0).Hide()
        RadioButtons(1).Hide()
        lbl_Score.Text = (Score & "/" & QuestionCount)
    End Sub

    'Adds all values of a specific type from all the topics into a list, so it's more manageable.
    Private Function GetListofQuestions() As List(Of String)
        Dim output As New List(Of String)()
        Dim sdr As SqlDataReader
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            con.Open()
            For Each item In ListofTopics
                Using cmd As New SqlCommand("SELECT Question FROM QuizQuestions WHERE TopicNumber='" & item & "'", con)
                    Try
                        sdr = cmd.ExecuteReader()
                        While sdr.Read()
                            output.Add(sdr("Question").ToString())
                        End While
                        sdr.Close()
                    Catch e As SqlException
                        MessageBox.Show("There was an error accessing your data. DETAIL: " & e.ToString())
                    End Try
                End Using
            Next item
        End Using
        Return output
    End Function

    'Adds all answers from all the topics into a list, so it's more manageable.
    Private Function GetListofAnswers() As List(Of String)
        Dim output As New List(Of String)()
        Dim sdr As SqlDataReader
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            con.Open()
            For Each item In ListofTopics
                Using cmd As New SqlCommand("SELECT Answer FROM QuizQuestions WHERE TopicNumber='" & item & "'", con)
                    Try
                        sdr = cmd.ExecuteReader()
                        While sdr.Read()
                            output.Add(sdr("Answer").ToString())
                        End While
                        sdr.Close()
                    Catch e As SqlException
                        MessageBox.Show("There was an error accessing your data. DETAIL: " & e.ToString())
                    End Try
                End Using
            Next item
        End Using
        Return output
    End Function

    'Adds all question types from all the topics into a list, so it's more manageable.
    Private Function GetListofTypes() As List(Of Integer)
        Dim output As New List(Of Integer)()
        Dim sdr As SqlDataReader
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            con.Open()
            For Each item In ListofTopics
                Using cmd As New SqlCommand("SELECT QuestionType FROM QuizQuestions WHERE TopicNumber='" & item & "'", con)
                    Try
                        sdr = cmd.ExecuteReader()
                        While sdr.Read()
                            output.Add(CInt(sdr("QuestionType")))
                        End While
                        sdr.Close()
                    Catch e As SqlException
                        MessageBox.Show("There was an error accessing your data. DETAIL: " & e.ToString())
                    End Try
                End Using
            Next item
        End Using
        Return output
    End Function

    'When the user clicks the exit test button, they will be directed to the user main menu.
    Private Sub btn_ExitTest_Click(sender As Object, e As EventArgs) Handles btn_ExitTest.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to exit the test?

Your progress wont be saved.", vbYesNo, "Confirm")

        Select Case result
            Case vbYes
                Me.Close()
                DeleteItemsinLists()
                UserMenuForm.Show()
                MessageBox.Show("Successfully exited the test", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case vbNo

        End Select
    End Sub

    'Submits the user's results to the database in the QuizResults table.
    Private Sub SubmitResuts()
        Try
            Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            Dim cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO QuizResults (UserID, Score, Total, Percentage) VALUES (" & CInt(GetSingleValue(UserUsername, "userid")) & ", " & Score & ", " & NoofQuestions & ", " & Math.Round((Score / NoofQuestions) * 100, 3) & ")"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Results saved")
            con.Close()
        Catch ex As Exception
            MsgBox("Problem saving quiz")
            MsgBox("Error" & ex.Message)
        End Try
    End Sub

    'Dynamically creates each answer method: textbox, combobox and radio buttons.
    Private Sub DynamicCreationofControls()
        Dim txt_input As New TextBox
        Dim DefaultFont As New Font("Micrisoft Sans Serif", 12, FontStyle.Regular)

        txt_input.Text = ""
        txt_input.Font = DefaultFont
        txt_input.Location = New Point(160, 220)
        txt_input.Width = 108
        txt_input.Height = 38
        txt_input.ForeColor = Color.Black

        Dim cb1 As New ComboBox
        cb1.Location = New Point(160, 220)
        cb1.Width = 142
        cb1.Height = 24
        cb1.Font = DefaultFont

        Dim rb1 As New RadioButton
        rb1.Text = "option 1"
        rb1.Location = New Point(90, 220)
        rb1.Font = DefaultFont

        Dim rb2 As New RadioButton
        rb2.Text = "option 2"
        rb2.Location = New Point(250, 220)
        rb2.Font = DefaultFont

        Me.Controls.Add(txt_input)
        Me.Controls.Add(rb1)
        Me.Controls.Add(rb2)
        Me.Controls.Add(cb1)

        'Adding dynamically created items to lists to allow them to be accessed in other subs easily.
        TextBoxes.Add(txt_input)
        RadioButtons.Add(rb1)
        RadioButtons.Add(rb2)
        ComboBoxes.Add(cb1)

        TextBoxes(0).Hide()
        ComboBoxes(0).Hide()
        RadioButtons(0).Hide()
        RadioButtons(1).Hide()
    End Sub

    'Sets all the default values for all items in the form.
    Private Sub InitialiseForm()
        pgb_Questions.Value = 0
        btn_CheckAnswer.Show()
        btn_NextQuestion.Hide()
        lbl_Answer.Text = ""
        TextBoxes(0).Text = ""
        TextBoxes(0).ForeColor = Color.Black
        ComboBoxes(0).Items.Clear()
        ComboBoxes(0).SelectedIndex = -1
        RadioButtons(0).Checked = False
        RadioButtons(1).Checked = False
        pb1.BackgroundImage = Nothing
        QuestionCount = 0
        Score = 0
        pgb_Questions.Maximum = (NoofQuestions)
        lbl_Question.Show()
        lbl_Answer.Show()
        lbl_QuestionProgress.Text = (QuestionCount & "/" & NoofQuestions)
        lbl_Score.Text = (Score & "/" & QuestionCount)
    End Sub

    'When the enter key is pressed, the answer will be checked or the next quesiton will be loaded.
    Private Sub enter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            If pb1.Visible = False Then
                btn_CheckAnswer_Click(sender, e)
            Else
                btn_NextQuestion_Click(sender, e)
            End If
        End If
    End Sub

    'Deletes all items in the lists.
    Private Sub DeleteItemsinLists()
        TextBoxes.Clear()
        ComboBoxes.Clear()
        RadioButtons.Clear()
    End Sub

End Class