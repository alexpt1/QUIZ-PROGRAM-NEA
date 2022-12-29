Imports System.Data
Imports System.Data.SqlClient

Public Class LoginForm
    Dim con As SqlConnection
    Dim cmd As SqlCommand            'Declaring the sql data types
    Dim sdr As SqlDataReader

    Private Sub btn_ReturntoMenu_Click(sender As Object, e As EventArgs) Handles btn_ReturntoMenu.Click
        Me.Hide()
        MenuForm.Show() 'opens menu form
    End Sub

    Private Sub lnk_SignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_SignUp.LinkClicked
        Me.Hide()
        SignUpForm.Show() 'opens signup form
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If txt_Username.Text = "" Then
            MessageBox.Show("Enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Username.Focus() 'focus the username textbox.            makes sure user enters a username
            Exit Sub
        End If
        If txt_Password.Text = "" Then
            MessageBox.Show("Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Password.Focus() 'focus the password textbox.        makes sure user enters a password
            Exit Sub
        End If
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\Documents\UserInformationDB.mdf;Integrated Security=True;Connect Timeout=30")
            con.Open()
            cmd = New SqlCommand("select * from UP where username='" + txt_Username.Text + "' and password='" + txt_Password.Text + "'", con)
            cmd.Connection = con
            sdr = cmd.ExecuteReader()
            If sdr.Read() Then
                Me.Hide()
                UserMenuForm.Show()
            Else
                MessageBox.Show("Enter valid username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Username.Text = ""
                txt_Password.Text = ""
                txt_Username.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        txt_Username.Text = ""
        txt_Password.Text = ""
        con.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub
End Class