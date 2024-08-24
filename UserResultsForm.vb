Option Strict On
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UserResultsForm

    Private Scores As New List(Of Integer)
    Private Totals As New List(Of Integer)
    Private Percentages As New List(Of Integer)

    'Sets the default values of the form.
    Private Sub UserResultsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(250, 250)
        lbl_Error.Hide()
        lbl_Error2.Hide()
        pan_Sort.Location = New Point(1, 1)
        pan_Sort.Hide()

        lbl_User.Text = "User: " & UserUsername
        lbl_UserID.Text = "UserID: " & CInt(GetSingleValue(UserUsername, "userid"))

        Scores = GetResults("Score")
        Totals = GetResults("Total")
        Percentages = GetResults("Percentage")

        If Scores.Count = 0 Then
            lbl_Score.Hide()
            lbl_Total.Hide()
            lbl_Percentage.Hide()
            lbl_Error.Show()
            lbl_Error.BringToFront()
            lbl_Error2.Show()
            lbl_Error2.BringToFront()
            btn_Sort.Hide()
            lbl_Sort.Hide()
        Else
            CreateTable()
            CreateGraph()
        End If

    End Sub

    'Creates table dynamically and fetches values from the database.
    Private Sub CreateTable()
        Dim tlp_Results = New TableLayoutPanel

        'Sets the formatting for the table.
        tp1.AutoScroll = True
        tlp_Results.ColumnCount = 3
        tlp_Results.RowCount = Scores.Count
        tlp_Results.AutoSize = True
        tlp_Results.BackColor = Color.White
        tlp_Results.Location = New Point(17, 100)
        tlp_Results.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble

        'Add all information in the QuizResults table in the DB to labels and adds them to the table.
        For Count = 0 To Scores.Count - 1
            Dim lab As New Label
            lab.Text = CStr(Scores(Count))
            tlp_Results.Controls.Add(lab, 0, Count)
            lab.Anchor = AnchorStyles.Top
            lab.TextAlign = ContentAlignment.MiddleCenter
        Next Count

        For Count = 0 To Totals.Count - 1
            Dim lab As New Label
            lab.Text = CStr(Totals(Count))
            tlp_Results.Controls.Add(lab, 1, Count)
            lab.Anchor = AnchorStyles.Top
            lab.TextAlign = ContentAlignment.MiddleCenter
        Next Count

        For Count = 0 To Percentages.Count - 1
            Dim lab As New Label
            lab.Text = CStr(Percentages(Count))
            tlp_Results.Controls.Add(lab, 2, Count)
            lab.Anchor = AnchorStyles.Top
            lab.TextAlign = ContentAlignment.MiddleCenter
        Next Count

        'Creates the size of each cell in the table.
        For Count = 0 To tlp_Results.ColumnCount - 1
            tlp_Results.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 125))
        Next Count
        For Count = 0 To tlp_Results.RowCount - 1
            tlp_Results.RowStyles.Add(New RowStyle(SizeType.Absolute, 25))
        Next Count

        'Adds the table to the first tab page.
        tp1.Controls.Add(tlp_Results)

    End Sub

    'Creates a graph dynamically to display previous result percentages.
    Private Sub CreateGraph()
        Dim chr_Graph As New Chart

        'Adds percentage series to the graph and sets the formatting.
        With chr_Graph
            .Series.Add(New Series("Percentage") With {.ChartType = SeriesChartType.Point, .Color = Color.DarkBlue})
            .ChartAreas.Add(New ChartArea)
            .Series("Percentage").ChartType = SeriesChartType.Line
            .Height = 270
            .Width = 450
            .ChartAreas(0).AxisX.Minimum = 1
            .ChartAreas(0).AxisY.Minimum = 0
            .ChartAreas(0).AxisY.Maximum = 100
            .ChartAreas(0).AxisY.Interval = 10
            .ChartAreas(0).AxisX.Interval = 1
            .Series("Percentage").BorderWidth = 5
        End With

        'Adds all the points to the graph.
        For Count = 0 To Percentages.Count - 1
            chr_Graph.Series("Percentage").Points.AddXY(Count + 1, Percentages(Count))
        Next Count

        'Adds the grpah to the second tab page.
        tp2.Controls.Add(chr_Graph)
        chr_Graph.Location = New Point(-20, 0)
    End Sub

    'Returns the results and puts them into a list.
    Private Function GetResults(ByVal type As String) As List(Of Integer)
        Dim output As New List(Of Integer)()
        Dim sdr As SqlDataReader
        Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\OneDrive\Documents\Visual Studio 2022\Projects\QUIZ-PROGRAM-NEA\QUIZDB.mdf;Integrated Security=True")
            con.Open()
            Using cmd As New SqlCommand("SELECT " & type & " FROM QuizResults WHERE UserID='" & CInt(GetSingleValue(UserUsername, "userid")) & "'", con)
                Try
                    sdr = cmd.ExecuteReader()
                    While sdr.Read()
                        output.Add(CInt(sdr(type)))
                    End While
                    sdr.Close()
                Catch e As SqlException
                    MessageBox.Show("There was an error accessing your " & type & " data. DETAIL: " & e.ToString())
                End Try
            End Using
        End Using
        Return output
    End Function

    'When the back button is clicked, the user will be directed to the user menu screen.
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
        UserMenuForm.Show()
        Scores.Clear()
        Totals.Clear()
        Percentages.Clear()
    End Sub

    'Displays the sorting pannel which creates a table dynamically with the sorted list of all previous percentages.
    Private Sub btn_Sort_Click(sender As Object, e As EventArgs) Handles btn_Sort.Click
        pan_Sort.Show()
        pan_Sort.BringToFront()
        tp1.AutoScroll = False

        'Adds all values in the percentages list into the sorting array.
        Dim SortingArr(Scores.Count) As Integer
        For Count = 0 To Scores.Count - 1
            SortingArr(Count) = Percentages(Count)
        Next Count

        QuickSort(SortingArr, 0, SortingArr.Length - 1)

        Dim tlp_Sort = New TableLayoutPanel

        'Sets the formatting for the table.
        pan_Sort.AutoScroll = True
        tlp_Sort.ColumnCount = 1
        tlp_Sort.RowCount = Percentages.Count
        tlp_Sort.AutoSize = True
        tlp_Sort.BackColor = Color.White
        tlp_Sort.Location = New Point(100, 1)
        tlp_Sort.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble

        'Add all information in the QuizResults table in the DB to labels and adds them to the table.
        For Count = 0 To Percentages.Count - 1
            Dim lab As New Label
            lab.Text = CStr(SortingArr(Count))
            tlp_Sort.Controls.Add(lab, 0, Count)
            lab.Anchor = AnchorStyles.Top
            lab.TextAlign = ContentAlignment.MiddleCenter
        Next Count

        'Creates the size of each cell in the table.
        For Count = 0 To tlp_Sort.ColumnCount - 1
            tlp_Sort.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 125))
        Next Count
        For Count = 0 To tlp_Sort.RowCount - 1
            tlp_Sort.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
        Next Count

        'Adds the table to the pannel.
        pan_Sort.Controls.Add(tlp_Sort)

    End Sub

    'Quicksort sub that uses an array, minimum and maximum as parameters and sorts the list into ascending order.
    Private Sub QuickSort(ByVal arr() As Integer, ByVal min As Integer, ByVal max As Integer)
        Dim pivot As Integer = 0
        Dim temp As Integer = 0
        Dim low As Integer = 0
        Dim high As Integer = 0

        If min < max Then
            pivot = min
            low = min
            high = max

            While (low < high)
                While (arr(low) <= arr(pivot) AndAlso low < max)
                    low = low + 1
                End While

                While (arr(high) > arr(pivot))
                    high = high - 1
                End While

                If low < high Then
                    temp = arr(low)
                    arr(low) = arr(high)
                    arr(high) = temp
                End If
            End While

            temp = arr(pivot)
            arr(pivot) = arr(high)
            arr(high) = temp

            'Recursion is used here (The sub calls itself):
            QuickSort(arr, min, high - 1)
            QuickSort(arr, high + 1, max)
        End If
    End Sub

    'Hides the sorting pannel that displays the sorted percentages in a table.
    Private Sub btn_GoBack_Click(sender As Object, e As EventArgs) Handles btn_GoBack.Click
        pan_Sort.Hide()
        tp1.AutoScroll = True
    End Sub

End Class