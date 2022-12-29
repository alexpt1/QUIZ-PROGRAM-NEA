Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Text.RegularExpressions

Public Class SignUpForm

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        'this constant is used to check if the characters entered are valid
        Const cCharacters As String = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!£$%^&*()_+-={}[]:@;'<>?,./#~"
        'makes sure the user has entered a username
        If txt_Username.Text = "" Then
            MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Focus() 'focus the username textbox.
            Exit Sub
        End If
        'makes sure the user has entered a password
        If txt_Password.Text = "" Then
            MessageBox.Show("Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Password.Focus() 'focus the password textbox.
            Exit Sub
        End If
        'makes sure the user has entered an email
        If txt_Email.Text = "" Then
            MessageBox.Show("Enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Email.Focus() 'focus the email textbox.
            Exit Sub
        End If
        'makes sure username and password are different
        If txt_Password.Text = txt_Username.Text Then
            MessageBox.Show("Username and password must be different", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Text = ""
            txt_Password.Text = ""
            txt_Username.Focus()
            Exit Sub
        End If

        'makes sure username and password are less than 21 characters in length
        If txt_Username.Text.Length > 20 Or txt_Password.Text.Length > 20 Then
            MessageBox.Show("Must be less then 21 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Text = ""
            txt_Password.Text = ""
            txt_Username.Focus()
            Exit Sub
        End If

        'makes sure username and password are less than 6 characters in length
        If txt_Username.Text.Length < 5 Or txt_Password.Text.Length < 5 Then
            MessageBox.Show("Must be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Text = ""
            txt_Password.Text = ""
            txt_Username.Focus()
            Exit Sub
        End If

        'loops to make sure each character in username is valid
        For i = 0 To txt_Username.Text.Length - 1
            If cCharacters.Contains(txt_Username.Text(i)) Then

            Else
                MessageBox.Show("Username must contain valid characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Username.Text = ""
                txt_Username.Focus()
                Exit Sub
            End If
        Next i

        'loops to make sure each character in password is valid
        For j = 0 To txt_Password.Text.Length - 1
            If cCharacters.Contains(txt_Password.Text(j)) Then

            Else
                MessageBox.Show("Password must contain valid characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Password.Text = ""
                txt_Password.Focus()
                Exit Sub
            End If
        Next j

        'checks the email aginst the regex string in the function IsEmail
        If IsEmail(txt_Email.Text) = True Then

        Else
            MessageBox.Show("Enter valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Email.Text = ""
            txt_Email.Focus()
            Exit Sub
        End If

        'checks if usuername is already in use
        If DatabaseCheck() = False Then
            MessageBox.Show("Username already in use, enter another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Text = ""
            txt_Username.Focus()
            Exit Sub
        End If

        'adds all data entered into the usernamepassword(UP) database
        Try
            Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\Documents\UserInformationDB.mdf;Integrated Security=True;Connect Timeout=30")
            Dim cmd = New SqlCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO UP (Username, Password, Age, Email) VALUES ('" & txt_Username.Text & "','" & txt_Password.Text & "', " & nud_Age.Value & ", '" & txt_Email.Text & "')"
            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception

        End Try

        txt_Username.Text = ""
        txt_Password.Text = ""
        txt_Email.Text = ""
        Me.Hide()
        UserMenuForm.Show() 'if all information entered is robust, then the user is directed to the user menu
    End Sub

    'checks the database to see whether the username is already in use with another account
    Private Function DatabaseCheck() As Boolean
        Dim con1 As SqlConnection
        Dim cmd1 As SqlCommand
        Try
            con1 = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\Documents\UserInformationDB.mdf;Integrated Security=True;Connect Timeout=30")
            con1.Open()
            cmd1 = New SqlCommand("select * from UP where username='" + txt_Username.Text + "'", con1)
            cmd1.Connection = con1
            Dim sdr1 As SqlDataReader
            sdr1 = cmd1.ExecuteReader()
            If sdr1.Read() Then
                Return False
            Else
                Return True
            End If
            con1.Close()
        Catch ex As Exception
            Return False
        End Try
    End Function

    'checks if email follows the typical email format
    Private Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Private Sub lnk_Login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Login.LinkClicked
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btn_ReturntoMenu_Click(sender As Object, e As EventArgs) Handles btn_ReturntoMenu.Click
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub
End Class