Option Strict On
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Module Variables
    Public QuestionCount As Integer = 0
    Public NoofQuestions As Integer = 0
    Public Score As Integer = 0
    Public UserUsername As String = ""
    Public UserKey As Integer = 0
    Public img_Background As Image = Image.FromFile("C:\Users\alexp\OneDrive\Pictures\Camera Roll\Midnight Sea NEA.jpg")
    Public ListofTopics As New List(Of Integer)

    'Encrypts the password with the caeser cipher with specified key as the parameter.
    Public Function Encrypt(ByVal password As String, ByVal key As Integer) As String
        Dim EPassword As String = ""
        For Count = 0 To password.Length - 1
            EPassword = EPassword & Chr(Asc(password(Count)) + key)
        Next Count
        Return EPassword
    End Function

    'Decrypts the encrypted password with the caeser cipher with specified key as the parameter.
    Public Function Decrypt(ByVal epassword As String, ByVal key As Integer) As String
        Dim Password As String = ""
        For Count = 0 To epassword.Length - 1
            Password = Password & Chr(Asc(epassword(Count)) - key)
        Next Count
        Return Password
    End Function

    'Fetches a single value from the database such as: UserID, Password, Age, Email and Key.
    Public Function GetSingleValue(ByVal username As String, ByVal type As String) As String
        Dim typeno As Integer
        If type = "userid" Then typeno = 0
        If type = "password" Then typeno = 2
        If type = "age" Then typeno = 3
        If type = "email" Then typeno = 4
        If type = "key" Then typeno = 5
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM UserInformation WHERE Username = '" & username & "'", con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Return CStr(dt.Rows(0)(typeno))
                        Else
                            MsgBox("cannot find the * " & type & " * record")
                            Return "error"
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Function

    'Checks if the value entered as a parameter is valid and meets the criteria.
    Public Function Validation(ByVal var As String) As Boolean

        'Constants are used to check if the characters entered are valid.
        Const cCharacters As String = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!£$%^&*()_+-={}[]:;'<>?,./#~"
        Const cNumber As String = "1234567890"
        Const cUpper As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Const cLower As String = "abcdefghijklmnopqrstuvwxyz"

        Dim NumberOK As Boolean = False
        Dim UpperOK As Boolean = False
        Dim LowerOK As Boolean = False

        'Makes sure the user enters a value.
        If var = "" Then
            MessageBox.Show("Enter " & var, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        'Makes sure value is less than 21 characters in length.
        If var.Length > 20 Then
            MessageBox.Show("Must be less then 21 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Ignores long emails.
            If var.Contains("@") Then
            Else
                Return False
            End If
        End If

        'Makes sure value is less than 6 characters in length.
        If var.Length < 5 Then
            MessageBox.Show("Must be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If var.Contains("@") Then Return True

        'Loops to make sure each character in the value is valid.
        For Count = 0 To var.Length - 1
            If cCharacters.Contains(var(Count)) Then

            Else
                MessageBox.Show("Invalid characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next Count

        'Loops to make sure that the value conatins at least 1 upper, lower and number.
        For Count = 0 To var.Length - 1
            If cNumber.Contains(var(Count)) Then NumberOK = True
            If cUpper.Contains(var(Count)) Then UpperOK = True
            If cLower.Contains(var(Count)) Then LowerOK = True
        Next Count

        If NumberOK And UpperOK And LowerOK Then
        Else
            MessageBox.Show("Must contain 1 uppercase, 1 lowercase and 1 digit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

End Module