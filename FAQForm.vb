Public Class FAQForm
    Private Sub FAQForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click
        Me.Hide()
        MenuForm.Show()
    End Sub

    'TO DO
    'Add more FAQ's to the box

End Class