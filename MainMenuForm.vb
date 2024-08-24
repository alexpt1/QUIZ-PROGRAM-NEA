Option Strict On
Public Class MenuForm

    'When the login button is clicked, the user will be directed to the login screen.
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    'When the signup button is clicked, the user will be directed to the signup screen.
    Private Sub btn_SignUp_Click(sender As Object, e As EventArgs) Handles btn_SignUp.Click
        Me.Hide()
        SignUpForm.Show()
    End Sub

    'Sets the default position of the form on the screen.
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub

    'When the Exit button is clicked, the program will close.
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
        End
    End Sub
End Class