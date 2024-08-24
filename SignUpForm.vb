Option Strict On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class SignUpForm

    'Checks if the information entered by the user is valid and if so, the data is added to the UserInformation table in the database.
    Private Sub SignUp()
        'Checks the email aginst the REGEX string in the function IsEmail.
        If IsEmail(txt_Email.Text) = True Then

        Else
            MessageBox.Show("Enter valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Email.Text = ""
            txt_Email.Focus()
            Exit Sub
        End If

        'Calls the validation sub and checks if the criteria is met.
        If Validation(txt_Username.Text) = False Or Validation(txt_Password.Text) = False Or Validation(txt_Email.Text) = False Then
            txt_Username.Text = ""
            txt_Password.Text = ""
            txt_Email.Text = ""
            nud_Age.Value = 16
            Exit Sub
        End If

        'Makes sure username and password are different.
        If txt_Password.Text = txt_Username.Text Then
            MessageBox.Show("Username and password must be different", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Text = ""
            txt_Password.Text = ""
            txt_Username.Focus()
            Exit Sub
        End If

        'Checks if username is already in use.
        If DatabaseCheck() = False Then
            MessageBox.Show("Username already in use, enter another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Text = ""
            txt_Username.Focus()
            Exit Sub
        End If

        'Calls the Createkey sub to generate a random caeser cipher key.
        UserKey = CreateKey()

        'Adds all data entered into the UserInformation table in the database.
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            Dim cmd As New SqlCommand("INSERT INTO UserInformation (Username, Password, Age, Email, ShiftChar) VALUES ('" & txt_Username.Text & "','" & Encrypt(txt_Password.Text, UserKey) & "', " & nud_Age.Value & ", '" & txt_Email.Text & "', " & UserKey & ")", con)
            con.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                Me.Close()
                UserMenuForm.Show()
                UserUsername = txt_Username.Text
            Else
                MsgBox("User not added")
            End If
            con.Close()
        Catch ex As Exception

        End Try
        'Resets all values after exit.
        UserKey = 0
        txt_Username.Text = ""
        txt_Password.Text = ""
        txt_Email.Text = ""
        'If all information entered is robust, then the user is directed to the user menu.
    End Sub

    'When the save button is clicked, the SignUp sub is called.
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        SignUp()
    End Sub

    'Checks the database to see whether the username is already in use with another account.
    Private Function DatabaseCheck() As Boolean
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True;Connect Timeout=30")
            con.Open()
            cmd = New SqlCommand("SELECT * FROM UserInformation WHERE Username='" + txt_Username.Text + "'", con)
            cmd.Connection = con
            sdr = cmd.ExecuteReader()
            If sdr.Read() Then
                Return False
            Else
                Return True
            End If
            con.Close()
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Checks if the email follows the typical email format using REGEX.
    Private Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    'Returns a random number between 1 and 25 to create the key.
    Private Function CreateKey() As Integer
        Randomize()
        Return CInt(Int(25 * Rnd() + 1))
    End Function

    'When the return button is clicked, the user will be directed to the main menu screen.
    Private Sub btn_ReturntoMenu_Click(sender As Object, e As EventArgs) Handles btn_ReturntoMenu.Click
        Me.Close()
        MenuForm.Show()
    End Sub

    'Sets the position of the form on the screen.
    Private Sub SignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub

    'When the enter key is pressed, the SignUp sub is called.
    Private Sub enter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Password.KeyPress, txt_Username.KeyPress, txt_Email.KeyPress, nud_Age.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            SignUp()
        End If
    End Sub

    'When the login button is clicked, the user will be directed to the login screen.
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Me.Close()
        LoginForm.Show()
    End Sub

End Class