<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_UpdateStudentScores
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
        Me.textBox_Name = New System.Windows.Forms.TextBox()
        Me.listBox_Scores = New System.Windows.Forms.ListBox()
        Me.button_Add = New System.Windows.Forms.Button()
        Me.button_Update = New System.Windows.Forms.Button()
        Me.button_Remove = New System.Windows.Forms.Button()
        Me.button_Clear = New System.Windows.Forms.Button()
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.button_OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Scores:"
        '
        'textBox_Name
        '
        Me.textBox_Name.Location = New System.Drawing.Point(60, 16)
        Me.textBox_Name.Name = "textBox_Name"
        Me.textBox_Name.ReadOnly = True
        Me.textBox_Name.Size = New System.Drawing.Size(164, 23)
        Me.textBox_Name.TabIndex = 2
        Me.textBox_Name.TabStop = False
        '
        'listBox_Scores
        '
        Me.listBox_Scores.FormattingEnabled = True
        Me.listBox_Scores.ItemHeight = 15
        Me.listBox_Scores.Location = New System.Drawing.Point(61, 47)
        Me.listBox_Scores.Name = "listBox_Scores"
        Me.listBox_Scores.Size = New System.Drawing.Size(81, 109)
        Me.listBox_Scores.TabIndex = 1
        '
        'button_Add
        '
        Me.button_Add.Location = New System.Drawing.Point(149, 47)
        Me.button_Add.Name = "button_Add"
        Me.button_Add.Size = New System.Drawing.Size(75, 23)
        Me.button_Add.TabIndex = 2
        Me.button_Add.Text = "&Add"
        Me.button_Add.UseVisualStyleBackColor = True
        '
        'button_Update
        '
        Me.button_Update.Location = New System.Drawing.Point(148, 76)
        Me.button_Update.Name = "button_Update"
        Me.button_Update.Size = New System.Drawing.Size(75, 23)
        Me.button_Update.TabIndex = 3
        Me.button_Update.Text = "&Update"
        Me.button_Update.UseVisualStyleBackColor = True
        '
        'button_Remove
        '
        Me.button_Remove.Location = New System.Drawing.Point(148, 105)
        Me.button_Remove.Name = "button_Remove"
        Me.button_Remove.Size = New System.Drawing.Size(75, 23)
        Me.button_Remove.TabIndex = 4
        Me.button_Remove.Text = "&Remove"
        Me.button_Remove.UseVisualStyleBackColor = True
        '
        'button_Clear
        '
        Me.button_Clear.Location = New System.Drawing.Point(149, 134)
        Me.button_Clear.Name = "button_Clear"
        Me.button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.button_Clear.TabIndex = 5
        Me.button_Clear.Text = "&Clear"
        Me.button_Clear.UseVisualStyleBackColor = True
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(149, 177)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel.TabIndex = 6
        Me.button_Cancel.Text = "Cancel"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'button_OK
        '
        Me.button_OK.Location = New System.Drawing.Point(68, 177)
        Me.button_OK.Name = "button_OK"
        Me.button_OK.Size = New System.Drawing.Size(75, 23)
        Me.button_OK.TabIndex = 6
        Me.button_OK.Text = "OK"
        Me.button_OK.UseVisualStyleBackColor = True
        '
        'form_UpdateStudentScores
        '
        Me.AcceptButton = Me.button_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Cancel
        Me.ClientSize = New System.Drawing.Size(235, 209)
        Me.Controls.Add(Me.button_OK)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Clear)
        Me.Controls.Add(Me.button_Remove)
        Me.Controls.Add(Me.button_Update)
        Me.Controls.Add(Me.button_Add)
        Me.Controls.Add(Me.listBox_Scores)
        Me.Controls.Add(Me.textBox_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_UpdateStudentScores"
        Me.Text = "Update Student Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textBox_Name As TextBox
    Friend WithEvents listBox_Scores As ListBox
    Friend WithEvents button_Add As Button
    Friend WithEvents button_Update As Button
    Friend WithEvents button_Remove As Button
    Friend WithEvents button_Clear As Button
    Friend WithEvents button_Cancel As Button
    Friend WithEvents button_OK As Button
End Class
