<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_AddScore
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
        Me.textBox_Score = New System.Windows.Forms.TextBox()
        Me.button_Add = New System.Windows.Forms.Button()
        Me.button_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Score: "
        '
        'textBox_Score
        '
        Me.textBox_Score.Location = New System.Drawing.Point(73, 12)
        Me.textBox_Score.Name = "textBox_Score"
        Me.textBox_Score.Size = New System.Drawing.Size(47, 23)
        Me.textBox_Score.TabIndex = 1
        '
        'button_Add
        '
        Me.button_Add.Location = New System.Drawing.Point(12, 50)
        Me.button_Add.Name = "button_Add"
        Me.button_Add.Size = New System.Drawing.Size(75, 23)
        Me.button_Add.TabIndex = 2
        Me.button_Add.Text = "Add"
        Me.button_Add.UseVisualStyleBackColor = True
        '
        'button_Cancel
        '
        Me.button_Cancel.Location = New System.Drawing.Point(93, 50)
        Me.button_Cancel.Name = "button_Cancel"
        Me.button_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel.TabIndex = 3
        Me.button_Cancel.Text = "Cancel"
        Me.button_Cancel.UseVisualStyleBackColor = True
        '
        'form_AddScore
        '
        Me.AcceptButton = Me.button_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Cancel
        Me.ClientSize = New System.Drawing.Size(192, 80)
        Me.Controls.Add(Me.button_Cancel)
        Me.Controls.Add(Me.button_Add)
        Me.Controls.Add(Me.textBox_Score)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_AddScore"
        Me.Text = "Add Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textBox_Score As TextBox
    Friend WithEvents button_Add As Button
    Friend WithEvents button_Cancel As Button
End Class
