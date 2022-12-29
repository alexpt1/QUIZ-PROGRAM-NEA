Public Class SelectTopicForm
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim cheq As New System.Text.StringBuilder
        Dim sheq As New System.Text.StringBuilder
        Dim result As New MsgBoxResult
        'iterates through pure list and adds each checked item to a string
        For Each item In clb_Pure.CheckedItems
            cheq.Append(item)
            cheq.Append("
")
        Next item
        'iterates through applied list and adds each checked item to a string
        For Each item In clb_Applied.CheckedItems
            sheq.Append(item)
            sheq.Append("
")
        Next item
        Me.Location = New Point(250, 250)
        'creates message box to confirm topics selected
        result = MsgBox(" TOPICS SELECTED: " & "

From Pure: 
" & cheq.ToString() & "
From Applied : 
" & sheq.ToString() & "

You'll be answering " & nud_Questions.Value & " questions." & "

Do you confirm?", vbYesNo, "Confirm")

        'each case for the message box
        Select Case result
            Case vbYes
                Me.Hide()
                QuestionsForm.Show()
            Case vbNo

        End Select
    End Sub



    'To do 

    ' add more topics to the list
    Sub CheckBoxes()
        If chk_1.Checked = True Then Topics(1) = chk_1.Text
        If chk_2.Checked = True Then Topics(2) = chk_2.Text
        If chk_3.Checked = True Then Topics(3) = chk_3.Text
        If chk_4.Checked = True Then Topics(4) = chk_4.Text
        If chk_5.Checked = True Then Topics(5) = chk_5.Text
        If chk_6.Checked = True Then Topics(6) = chk_6.Text
        If chk_7.Checked = True Then Topics(7) = chk_7.Text
        If chk_8.Checked = True Then Topics(8) = chk_8.Text
        If chk_9.Checked = True Then Topics(9) = chk_9.Text
        If chk_10.Checked = True Then Topics(10) = chk_10.Text
    End Sub

    Private Sub SelectTopicForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
        pan_Pure.Show()
        pan_Applied.Hide()
        btn_rightpage.Show()
        btn_leftpage.Hide()
    End Sub

    Private Sub btn_rightpage_Click(sender As Object, e As EventArgs) Handles btn_rightpage.Click
        pan_Applied.Show()
        pan_Pure.Hide()
        btn_leftpage.Show()
        btn_rightpage.Hide()
    End Sub

    Private Sub btn_leftpage_Click(sender As Object, e As EventArgs) Handles btn_leftpage.Click
        pan_Pure.Show()
        pan_Applied.Hide()
        btn_leftpage.Hide()
        btn_rightpage.Show()
    End Sub
End Class