Public Class form_AddScore
    'Close the form without adding score
    Private Sub button_Cancel_Click(sender As Object, e As EventArgs) Handles button_Cancel.Click
        Me.Close()
    End Sub

    'Close the form and apply changes
    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click
        If DataValidation.IsValidScore(textBox_Score, "Score") Then 'checks that the score entered is valid
            form_UpdateStudentScores.scores.Add(Convert.ToInt32(textBox_Score.Text)) 'add to scores list from UpdateStudentScores
            form_UpdateStudentScores.listBox_Scores.Items.Add(Convert.ToInt32(textBox_Score.Text)) 'add to listbox from UpdateStudentScores
            Me.Close()
        End If
    End Sub
End Class