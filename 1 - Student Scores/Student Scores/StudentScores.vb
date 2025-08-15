Public Class form_StudentScores
    'Contains Student Name and Records
    Public studentRecords As New SortedList()

    'format records for listBox
    Public Shared Sub formatRecord(name As String, scores As List(Of Integer))
        Dim record As String = name 'add student name to string

        'add colon if scores are present
        If (scores.Count <> 0) Then
            record &= ": "
        End If

        'display each score with delimeter
        For x As Integer = 0 To (scores.Count - 1)
            record &= scores(x)
            If x < scores.Count - 1 Then 'only include delimeter if not last score
                record &= " | "
            End If
        Next

        form_StudentScores.listBox_Scores.Items.Add(record) 'add record to listBox
    End Sub

    Public Shared Sub listRecords(sortedList As SortedList)
        form_StudentScores.listBox_Scores.Items.Clear()

        For x As Integer = 0 To (sortedList.Count - 1)
            formatRecord(sortedList.GetKey(x), sortedList.GetByIndex(x))
        Next
    End Sub

    'close form
    Private Sub button_Exit_Click(sender As Object, e As EventArgs) Handles button_Exit.Click
        Me.Close()
    End Sub

    'open add new student form
    Private Sub button_AddNew_Click(sender As Object, e As EventArgs) Handles button_AddNew.Click
        form_AddNewStudent.Show()
    End Sub

    'open the update records form, must have one selected
    Private Sub button_Update_Click(sender As Object, e As EventArgs) Handles button_Update.Click
        If DataValidation.IsSelected(listBox_Scores, "Record") Then
            form_UpdateStudentScores.Show()
        End If

    End Sub

    'Display total, count, and average of scores when a student is selected. Stays blank if no scores exist
    Public Sub displayScoreStats() Handles listBox_Scores.Click
        Dim index As Integer = listBox_Scores.SelectedIndex
        'Check if something is selected and scores exists
        If index <> -1 AndAlso studentRecords.GetByIndex(index).count <> 0 Then
            Dim total As Integer = 0

            'calculate total
            For Each x As Integer In studentRecords.GetByIndex(index)
                total += x
            Next

            'display values
            textBox_ScoreTotal.Text = total
            textBox_ScoreCount.Text = studentRecords.GetByIndex(index).count
            textBox_Average.Text = total \ studentRecords.GetByIndex(index).count
        Else 'clear attributes
            textBox_Average.Clear()
            textBox_ScoreCount.Clear()
            textBox_ScoreTotal.Clear()
        End If
    End Sub

    'Delete a selected record. Only attempt deletion if a record is actually selected
    Private Sub deleteRecord(sender As Object, e As EventArgs) Handles button_Delete.Click
        If listBox_Scores.SelectedIndex <> -1 Then
            studentRecords.RemoveAt(listBox_Scores.SelectedIndex) 'remove record from list
            listRecords(studentRecords) 're-list records
        End If
    End Sub



    Private Sub form_StudentScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim recordsOne As New List(Of Integer)
        Dim recordsTwo As New List(Of Integer)
        Dim recordsThree As New List(Of Integer)

        recordsOne.Add(10)
        recordsOne.Add(20)
        recordsOne.Add(30)
        studentRecords.Add("A", recordsOne)

        recordsTwo.Add(40)
        recordsTwo.Add(50)
        recordsTwo.Add(60)
        studentRecords.Add("C", recordsTwo)

        recordsThree.Add(70)
        recordsThree.Add(80)
        recordsThree.Add(90)
        studentRecords.Add("B", recordsThree)

        listRecords(studentRecords)
    End Sub
End Class
