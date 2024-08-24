Option Strict On
Public Class UserMenuForm

    'When the logout button is clicked, the user will be asked if they're sure they want to logout.
    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to log out?", vbYesNo, "Confirm")

        'Each case for the message box.
        Select Case result
            Case vbYes
                Me.Close()
                MenuForm.Show()
            Case vbNo

        End Select
    End Sub

    'When the create quiz button is clicked, the user will be directed to the select topics screen.
    Private Sub btn_Createquiz_Click(sender As Object, e As EventArgs) Handles btn_Createquiz.Click
        Me.Close()
        SelectTopicForm.Show()
    End Sub

    'Sets the default values of the form.
    Private Sub UserMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = img_Background
        pan_PasswordCheck.Hide()
        btn_Createquiz.Show()
        btn_Logout.Show()
        btn_PrevResults.Show()
    End Sub

    'When the previous results button is clicked, the user will be directed to the previous results screen.
    Private Sub btn_PrevResults_Click(sender As Object, e As EventArgs) Handles btn_PrevResults.Click
        Me.Close()
        UserResultsForm.Show()
    End Sub

    'When the settings button is clicked, the pop-up will appear which asks the user to enter their password in order to change any settings.
    Private Sub pct_Set_Click(sender As Object, e As EventArgs) Handles pct_Set.Click
        btn_PrevResults.Hide()
        btn_Createquiz.Hide()
        btn_Logout.Hide()
        pan_PasswordCheck.Show()
    End Sub

    'When the enter button is clicked on the settings pop-up, the PasswordCheck sub is called.
    Private Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        PasswordCheck()
    End Sub

    'Checks if the password entered is valid and matches the value in the database.
    Private Sub PasswordCheck()
        If txt_PasswordCheck.Text = "" Then
            MsgBox("Enter Password")
            txt_PasswordCheck.Focus()
        End If
        If txt_PasswordCheck.Text = Decrypt(GetSingleValue(UserUsername, "password"), UserKey) Then
            Me.Close()
            SettingsForm.Show()
        Else
            MsgBox("Incorrect Password")
        End If
    End Sub

    'When the back icon is clicked, the settings pop-up will disappear.
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        pan_PasswordCheck.Hide()
        btn_Logout.Show()
        btn_PrevResults.Show()
        btn_Createquiz.Show()
    End Sub

    'When the enter key is pressed, the PasswordCheck sub is called.
    Private Sub enter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PasswordCheck.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            PasswordCheck()
        End If
    End Sub

End Class