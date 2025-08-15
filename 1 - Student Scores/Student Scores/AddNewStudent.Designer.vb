<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_AddNewStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textBox_Name = New System.Windows.Forms.TextBox()
        Me.textBox_Score = New System.Windows.Forms.TextBox()
        Me.textBox_Scores = New System.Windows.Forms.TextBox()
        Me.button_AddScore = New System.Windows.Forms.Button()
        Me.button_ClearScores = New System.Windows.Forms.Button()
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.button_OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Score: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Scores: "
        '
        'textBox_Name
        '
        Me.textBox_Name.Location = New System.Drawing.Point(63, 8)
        Me.textBox_Name.Name = "textBox_Name"
        Me.textBox_Name.Size = New System.Drawing.Size(181, 23)
        Me.textBox_Name.TabIndex = 1
        '
        'textBox_Score
        '
        Me.textBox_Score.Location = New System.Drawing.Point(63, 46)
        Me.textBox_Score.Name = "textBox_Score"
        Me.textBox_Score.Size = New System.Drawing.Size(100, 23)
        Me.textBox_Score.TabIndex = 2
        '
        'textBox_Scores
        '
        Me.textBox_Scores.Location = New System.Drawing.Point(63, 80)
        Me.textBox_Scores.Name = "textBox_Scores"
        Me.textBox_Scores.ReadOnly = True
        Me.textBox_Scores.Size = New System.Drawing.Size(181, 23)
        Me.textBox_Scores.TabIndex = 5
        Me.textBox_Scores.TabStop = False
        '
        'button_AddScore
        '
        Me.button_AddScore.Location = New System.Drawing.Point(169, 46)
        Me.button_AddScore.Name = "button_AddScore"
        Me.button_AddScore.Size = New System.Drawing.Size(75, 23)
        Me.button_AddScore.TabIndex = 3
        Me.button_AddScore.Text = "&Add Score"
        Me.button_AddScore.UseVisualStyleBackColor = True
        '
        'button_ClearScores
        '
        Me.button_ClearScores.Location = New System.Drawing.Point(161, 109)
        Me.button_ClearScores.Name = "button_ClearScores"
        Me.button_ClearScores.Size = New System.Drawing.Size(82, 23)
        Me.button_ClearScores.TabIndex = 4
        Me.button_ClearScores.Text = "&Clear Scores"
        Me.button_ClearScores.UseVisualStyleBackColor = True
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(168, 138)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel.TabIndex = 6
        Me.button_Cancel.Text = "Cancel"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'button_OK
        '
        Me.button_OK.Location = New System.Drawing.Point(88, 138)
        Me.button_OK.Name = "button_OK"
        Me.button_OK.Size = New System.Drawing.Size(75, 23)
        Me.button_OK.TabIndex = 5
        Me.button_OK.Text = "OK"
        Me.button_OK.UseVisualStyleBackColor = True
        '
        'form_AddNewStudent
        '
        Me.AcceptButton = Me.button_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Cancel
        Me.ClientSize = New System.Drawing.Size(253, 174)
        Me.Controls.Add(Me.button_OK)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_ClearScores)
        Me.Controls.Add(Me.button_AddScore)
        Me.Controls.Add(Me.textBox_Scores)
        Me.Controls.Add(Me.textBox_Score)
        Me.Controls.Add(Me.textBox_Name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_AddNewStudent"
        Me.Text = "Add New Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textBox_Name As TextBox
    Friend WithEvents textBox_Score As TextBox
    Friend WithEvents textBox_Scores As TextBox
    Friend WithEvents button_AddScore As Button
    Friend WithEvents button_ClearScores As Button
    Friend WithEvents button_Cancel As Button
    Friend WithEvents button_OK As Button
End Class
