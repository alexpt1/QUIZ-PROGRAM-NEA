Option Strict On
Imports System.Data.SqlClient

Public Class SettingsForm

    'Sets the position of the form on the screen.
    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub

    'When the back button is clicked, the user will be asked if they're sure they want to exit without making any changes.
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to exit? Your changes wont be saved.", vbYesNo, "Confirm")

        'Each case for the message box.
        Select Case result
            Case vbYes
                Me.Close()
                UserMenuForm.Show()
            Case vbNo

        End Select
    End Sub

    'When the confirm button is clicked, the settings are changed.
    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click
        Dim result As MsgBoxResult

        result = MsgBox("Are you sure you want to make these changes?", vbYesNo, "Confirm")

        'Each case for the message box.
        Select Case result
            Case vbYes

                'Checks if values are entered.
                If txt_NewUsername.Text <> "" AndAlso txt_NewUsernameConfirm.Text <> "" AndAlso txt_NewPassword.Text <> "" AndAlso txt_NewPasswordConfirm.Text <> "" Then
                    MessageBox.Show("Can only update one value at a time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_NewUsername.Text = ""
                    txt_NewUsernameConfirm.Text = ""
                    txt_NewPassword.Text = ""
                    txt_NewPasswordConfirm.Text = ""
                End If

                'Checks if values entered are valid.
                If txt_NewUsername.Text <> "" AndAlso txt_NewUsernameConfirm.Text <> "" Then
                    'Checks that values are the same.
                    If txt_NewUsername.Text = txt_NewUsernameConfirm.Text AndAlso Validation(txt_NewUsername.Text) Then
                        ChangeUsername(txt_NewUsername.Text)
                    Else
                        MessageBox.Show("Error changing username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                If txt_NewPassword.Text <> "" AndAlso txt_NewPasswordConfirm.Text <> "" Then
                    If txt_NewPassword.Text = txt_NewPasswordConfirm.Text AndAlso Validation(txt_NewPassword.Text) Then
                        ChangePassword(txt_NewPassword.Text)
                    Else
                        MessageBox.Show("Error changing username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

                If cbo_Background.SelectedIndex = -1 Then
                Else
                    img_Background = Image.FromFile("C:\Users\alexp\OneDrive\Pictures\Camera Roll\" & cbo_Background.SelectedItem.ToString & " NEA.jpg")
                End If


                Me.Close()
                UserMenuForm.Show()

                MsgBox("Saved")
            Case vbNo

        End Select
    End Sub

    'Changes the username in the UserInformation table in the database.
    Private Sub ChangeUsername(ByVal NewUsername As String)
        Dim Userid As String = GetSingleValue(UserUsername, "userid")
        If Validation(NewUsername) = True Then
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand("UPDATE UserInformation SET Username = @Username WHERE UserID = " & Userid, con)
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = NewUsername
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Else
            MsgBox("Invalid new username")
        End If
        UserUsername = NewUsername
    End Sub

    'Changes the password in the UserInformation table in the database.
    Private Sub ChangePassword(ByVal NewPassword As String)
        Dim Userid As String = GetSingleValue(UserUsername, "userid")
        If Validation(NewPassword) = True Then
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand("UPDATE UserInformation SET Password = @Password WHERE UserID = " & Userid, con)
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = Encrypt(NewPassword, UserKey)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Else
            MsgBox("Invalid new password")
        End If
    End Sub

End Class