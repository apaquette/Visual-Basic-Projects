Public Class form_UpdateStudentScores
    'local variables in case user cancels operation
    Dim index As Integer
    Public scores As List(Of Integer) 'set as public so it can be accessed from updateScore form
    Dim studentName As String

    'onload, set local variables (index,scores, student name)
    Private Sub form_UpdateStudentScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set local variables
        index = form_StudentScores.listBox_Scores.SelectedIndex
        scores = form_StudentScores.studentRecords.GetByIndex(index)
        studentName = form_StudentScores.studentRecords.GetKey(index)
        textBox_Name.Text = studentName

        'display each score in the listBox
        For Each score As Integer In scores
            listBox_Scores.Items.Add(score)
        Next

    End Sub

    'open Add Score form
    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click
        form_AddScore.Show()
    End Sub

    'Update Score
    Private Sub button_Update_Click(sender As Object, e As EventArgs) Handles button_Update.Click
        If DataValidation.IsSelected(listBox_Scores, "Score") Then 'ensures a score is selected
            form_UpdateScore.Show() 'open form
        End If
    End Sub

    'Process updated record
    Private Sub button_OK_Click(sender As Object, e As EventArgs) Handles button_OK.Click
        form_StudentScores.studentRecords.RemoveAt(index) 'remove old record from list
        form_StudentScores.studentRecords.Add(studentName, scores) 'add new record to list
        form_StudentScores.listRecords(form_StudentScores.studentRecords) 'add new record to listbox
        form_StudentScores.displayScoreStats() 'update score stats
        Me.Close()
    End Sub

    'remove selected score
    Private Sub button_Remove_Click(sender As Object, e As EventArgs) Handles button_Remove.Click
        If DataValidation.IsSelected(listBox_Scores, "Score") Then 'check that a score is selected
            scores.RemoveAt(listBox_Scores.SelectedIndex) 'remove selected score from list
            listBox_Scores.Items.RemoveAt(listBox_Scores.SelectedIndex) 'remove selected score from listBox
        End If
    End Sub

    'clear all scores
    Private Sub button_Clear_Click(sender As Object, e As EventArgs) Handles button_Clear.Click
        scores.Clear() 'clear scores list
        listBox_Scores.Items.Clear() 'clear scores from listbox
    End Sub

    'close without applying operations
    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub
End Class