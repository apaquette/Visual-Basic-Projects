Public Class form_UpdateScore
    'close form without applying changes
    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    'apply changes and close form
    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Update.Click
        If DataValidation.IsValidScore(textBox_Score, "Score") Then 'check that the score is valid
            form_UpdateStudentScores.scores(form_UpdateStudentScores.listBox_Scores.SelectedIndex) = Convert.ToInt32(textBox_Score.Text) 'assign new score
            'remove old score and add new score
            form_UpdateStudentScores.listBox_Scores.Items.RemoveAt(form_UpdateStudentScores.listBox_Scores.SelectedIndex)
            form_UpdateStudentScores.listBox_Scores.Items.Add(Convert.ToInt32(textBox_Score.Text))
            Me.Close()
        End If
    End Sub
End Class