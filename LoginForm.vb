Option Strict On
Imports System.Data.SqlClient

Public Class LoginForm

    'Declaring the sql variables.
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim sdr As SqlDataReader

    'Checks all the information entered by the user and if valid, then the user will be directed to the user menu screen.
    Private Sub Login()
        'Makes sure user enters a username.
        If txt_Username.Text = "" Then
            MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Focus()
            Exit Sub
        End If

        'Makes sure user enters a password.
        If txt_Password.Text = "" Then
            MessageBox.Show("Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Password.Focus()
            Exit Sub
        End If

        'Makes sure the account entered has been created.
        Try
            If CInt(GetSingleValue(txt_Username.Text, "key")) = 0 Then
                MsgBox("Create an account")
                Exit Sub
            Else
                UserKey = CInt(GetSingleValue(txt_Username.Text, "key"))
            End If
        Catch ex As Exception
            MsgBox("Create an account")
            txt_Username.Text = ""
            txt_Password.Text = ""
            Exit Sub
        End Try

        'Checks if the information entered by the user is already in the database.
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("SELECT * FROM UserInformation WHERE Username='" + txt_Username.Text + "' and Password='" + Encrypt(txt_Password.Text, UserKey) + "'", con)
            cmd.Connection = con
            sdr = cmd.ExecuteReader()
            If sdr.Read() Then
                UserUsername = txt_Username.Text
                Me.Close()
                UserMenuForm.Show()
            Else
                MessageBox.Show("Can't find record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Username.Text = ""
                txt_Password.Text = ""
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        txt_Username.Text = ""
        txt_Password.Text = ""
        con.Close()
    End Sub

    'When the menu button is clicked, the user will be directed to the main menu screen.
    Private Sub btn_ReturntoMenu_Click(sender As Object, e As EventArgs) Handles btn_ReturntoMenu.Click
        Me.Close()
        MenuForm.Show()
    End Sub

    'When the login button is clicked, the Login sub is called.
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Login()
    End Sub

    'Sets the position of the form.
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub

    'When the user presses the enter key, the Login sub will be called.
    Private Sub enter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Password.KeyPress, txt_Username.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            Login()
        End If
    End Sub

    'When the signup button is clicked, the user will be directed to the signup screen.
    Private Sub btn_SignUp_Click(sender As Object, e As EventArgs) Handles btn_SignUp.Click
        Me.Close()
        SignUpForm.Show()
    End Sub
End Class