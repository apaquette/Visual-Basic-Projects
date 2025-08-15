Public Class form_AddNewStudent
    Dim scores As New List(Of Integer) 'local list for scores
    'close form
    Private Sub cancel_Exit(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    'add score to record
    Private Sub addScore(sender As Object, e As EventArgs) Handles button_AddScore.Click
        If DataValidation.IsValidScore(textBox_Score, "Score") Then 'ensure score is valid
            scores.Add(Convert.ToInt32(textBox_Score.Text)) 'Add Score to list
            textBox_Scores.Text &= (textBox_Score.Text & " ") 'Display score in scores text box
            textBox_Score.Clear() 'Empty score text box after it is added (forces the user to enter another one)
        End If
    End Sub

    'add student record 
    Private Sub addNewStudent_Exit(sender As Object, e As EventArgs) Handles button_OK.Click
        If DataValidation.IsPresent(textBox_Name, "Name") Then 'ensure name is present
            Try 'try to add record. if exception is thrown, student already exists
                form_StudentScores.studentRecords.Add(textBox_Name.Text, scores) 'add record to List from student scores form
                form_StudentScores.listRecords(form_StudentScores.studentRecords) 're-list records in listbox
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Student already Exists", "Entry Error") 'inform user student already exists
                textBox_Name.Clear() 'clear name textbox
            End Try
        End If
    End Sub

    'clear scores
    Private Sub clearScores(sender As Object, e As EventArgs) Handles button_ClearScores.Click
        scores.Clear()  'empties the scores list
        'clear textboxes
        textBox_Score.Clear()
        textBox_Scores.Clear()
    End Sub
End Class