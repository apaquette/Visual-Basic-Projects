<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_StudentScores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBox_Scores = New System.Windows.Forms.ListBox()
        Me.button_AddNew = New System.Windows.Forms.Button()
        Me.button_Update = New System.Windows.Forms.Button()
        Me.button_Delete = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.textBox_ScoreTotal = New System.Windows.Forms.TextBox()
        Me.textBox_ScoreCount = New System.Windows.Forms.TextBox()
        Me.textBox_Average = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Students:"
        '
        'listBox_Scores
        '
        Me.listBox_Scores.FormattingEnabled = True
        Me.listBox_Scores.ItemHeight = 15
        Me.listBox_Scores.Location = New System.Drawing.Point(12, 38)
        Me.listBox_Scores.Name = "listBox_Scores"
        Me.listBox_Scores.Size = New System.Drawing.Size(294, 139)
        Me.listBox_Scores.TabIndex = 1
        '
        'button_AddNew
        '
        Me.button_AddNew.Location = New System.Drawing.Point(312, 38)
        Me.button_AddNew.Name = "button_AddNew"
        Me.button_AddNew.Size = New System.Drawing.Size(75, 23)
        Me.button_AddNew.TabIndex = 2
        Me.button_AddNew.Text = "&Add New..."
        Me.button_AddNew.UseVisualStyleBackColor = True
        '
        'button_Update
        '
        Me.button_Update.Location = New System.Drawing.Point(312, 67)
        Me.button_Update.Name = "button_Update"
        Me.button_Update.Size = New System.Drawing.Size(75, 23)
        Me.button_Update.TabIndex = 3
        Me.button_Update.Text = "&Update..."
        Me.button_Update.UseVisualStyleBackColor = True
        '
        'button_Delete
        '
        Me.button_Delete.Location = New System.Drawing.Point(312, 96)
        Me.button_Delete.Name = "button_Delete"
        Me.button_Delete.Size = New System.Drawing.Size(75, 23)
        Me.button_Delete.TabIndex = 4
        Me.button_Delete.Text = "&Delete"
        Me.button_Delete.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.Location = New System.Drawing.Point(312, 244)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(75, 23)
        Me.button_Exit.TabIndex = 5
        Me.button_Exit.Text = "E&xit"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'textBox_ScoreTotal
        '
        Me.textBox_ScoreTotal.Location = New System.Drawing.Point(266, 183)
        Me.textBox_ScoreTotal.Name = "textBox_ScoreTotal"
        Me.textBox_ScoreTotal.ReadOnly = True
        Me.textBox_ScoreTotal.Size = New System.Drawing.Size(40, 23)
        Me.textBox_ScoreTotal.TabIndex = 6
        Me.textBox_ScoreTotal.TabStop = False
        '
        'textBox_ScoreCount
        '
        Me.textBox_ScoreCount.Location = New System.Drawing.Point(266, 212)
        Me.textBox_ScoreCount.Name = "textBox_ScoreCount"
        Me.textBox_ScoreCount.ReadOnly = True
        Me.textBox_ScoreCount.Size = New System.Drawing.Size(40, 23)
        Me.textBox_ScoreCount.TabIndex = 7
        Me.textBox_ScoreCount.TabStop = False
        '
        'textBox_Average
        '
        Me.textBox_Average.Location = New System.Drawing.Point(266, 241)
        Me.textBox_Average.Name = "textBox_Average"
        Me.textBox_Average.ReadOnly = True
        Me.textBox_Average.Size = New System.Drawing.Size(40, 23)
        Me.textBox_Average.TabIndex = 8
        Me.textBox_Average.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Score total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Score count:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Average:"
        '
        'form_StudentScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Exit
        Me.ClientSize = New System.Drawing.Size(402, 280)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.textBox_Average)
        Me.Controls.Add(Me.textBox_ScoreCount)
        Me.Controls.Add(Me.textBox_ScoreTotal)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_Delete)
        Me.Controls.Add(Me.button_Update)
        Me.Controls.Add(Me.button_AddNew)
        Me.Controls.Add(Me.listBox_Scores)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_StudentScores"
        Me.Text = "Student Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents listBox_Scores As ListBox
    Friend WithEvents button_AddNew As Button
    Friend WithEvents button_Update As Button
    Friend WithEvents button_Delete As Button
    Friend WithEvents button_Exit As Button
    Friend WithEvents textBox_ScoreTotal As TextBox
    Friend WithEvents textBox_ScoreCount As TextBox
    Friend WithEvents textBox_Average As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
