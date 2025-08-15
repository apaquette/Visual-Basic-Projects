<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textBox_MinutesPerWindow = New System.Windows.Forms.TextBox()
        Me.textBox_GuestsPerWindow = New System.Windows.Forms.TextBox()
        Me.textBox_StartTime = New System.Windows.Forms.TextBox()
        Me.textBox_EndTime = New System.Windows.Forms.TextBox()
        Me.textBox_FirstTicketNumber = New System.Windows.Forms.TextBox()
        Me.button_OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Minutes per window:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Guests per window:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End time: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "First ticket number:"
        '
        'textBox_MinutesPerWindow
        '
        Me.textBox_MinutesPerWindow.Location = New System.Drawing.Point(124, 11)
        Me.textBox_MinutesPerWindow.Name = "textBox_MinutesPerWindow"
        Me.textBox_MinutesPerWindow.Size = New System.Drawing.Size(100, 20)
        Me.textBox_MinutesPerWindow.TabIndex = 5
        '
        'textBox_GuestsPerWindow
        '
        Me.textBox_GuestsPerWindow.Location = New System.Drawing.Point(124, 37)
        Me.textBox_GuestsPerWindow.Name = "textBox_GuestsPerWindow"
        Me.textBox_GuestsPerWindow.Size = New System.Drawing.Size(100, 20)
        Me.textBox_GuestsPerWindow.TabIndex = 6
        '
        'textBox_StartTime
        '
        Me.textBox_StartTime.Location = New System.Drawing.Point(124, 63)
        Me.textBox_StartTime.Name = "textBox_StartTime"
        Me.textBox_StartTime.Size = New System.Drawing.Size(100, 20)
        Me.textBox_StartTime.TabIndex = 7
        '
        'textBox_EndTime
        '
        Me.textBox_EndTime.Location = New System.Drawing.Point(124, 89)
        Me.textBox_EndTime.Name = "textBox_EndTime"
        Me.textBox_EndTime.Size = New System.Drawing.Size(100, 20)
        Me.textBox_EndTime.TabIndex = 8
        '
        'textBox_FirstTicketNumber
        '
        Me.textBox_FirstTicketNumber.Location = New System.Drawing.Point(124, 115)
        Me.textBox_FirstTicketNumber.Name = "textBox_FirstTicketNumber"
        Me.textBox_FirstTicketNumber.Size = New System.Drawing.Size(100, 20)
        Me.textBox_FirstTicketNumber.TabIndex = 9
        '
        'button_OK
        '
        Me.button_OK.Location = New System.Drawing.Point(149, 159)
        Me.button_OK.Name = "button_OK"
        Me.button_OK.Size = New System.Drawing.Size(75, 23)
        Me.button_OK.TabIndex = 10
        Me.button_OK.Text = "OK"
        Me.button_OK.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AcceptButton = Me.button_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 191)
        Me.Controls.Add(Me.button_OK)
        Me.Controls.Add(Me.textBox_FirstTicketNumber)
        Me.Controls.Add(Me.textBox_EndTime)
        Me.Controls.Add(Me.textBox_StartTime)
        Me.Controls.Add(Me.textBox_GuestsPerWindow)
        Me.Controls.Add(Me.textBox_MinutesPerWindow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents textBox_MinutesPerWindow As TextBox
    Friend WithEvents textBox_GuestsPerWindow As TextBox
    Friend WithEvents textBox_StartTime As TextBox
    Friend WithEvents textBox_EndTime As TextBox
    Friend WithEvents textBox_FirstTicketNumber As TextBox
    Friend WithEvents button_OK As Button
End Class
