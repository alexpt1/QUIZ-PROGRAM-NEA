Public Class MenuForm
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
    Private Sub btn_SignUp_Click(sender As Object, e As EventArgs) Handles btn_SignUp.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub

    Private Sub btn_Faqs_Click(sender As Object, e As EventArgs) Handles btn_Faqs.Click
        FAQForm.Show()
        Me.Hide()
    End Sub
End Class