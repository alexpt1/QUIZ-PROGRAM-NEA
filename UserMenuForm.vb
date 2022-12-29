Imports System.Reflection

Public Class UserMenuForm
    Private Sub btn_Createquiz_Click(sender As Object, e As EventArgs) Handles btn_Createquiz.Click
        Me.Hide()
        SelectTopicForm.Show()
    End Sub

    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        Me.Hide()
        MenuForm.Show()
        MessageBox.Show("Successfully logged out", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UserMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
    End Sub
End Class