<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label_EnteringTickets = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label_NextEntry = New System.Windows.Forms.Label()
        Me.label_TicketsOutstanding = New System.Windows.Forms.Label()
        Me.btn_IssueTicket = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBox_Outstanding = New System.Windows.Forms.ListBox()
        Me.btn_Options = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label_EnteringTickets)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guests with the following tickets may now enter:"
        '
        'label_EnteringTickets
        '
        Me.label_EnteringTickets.AutoSize = True
        Me.label_EnteringTickets.Location = New System.Drawing.Point(17, 16)
        Me.label_EnteringTickets.Name = "label_EnteringTickets"
        Me.label_EnteringTickets.Size = New System.Drawing.Size(28, 13)
        Me.label_EnteringTickets.TabIndex = 4
        Me.label_EnteringTickets.Text = "0 - 0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.label_NextEntry)
        Me.GroupBox2.Controls.Add(Me.label_TicketsOutstanding)
        Me.GroupBox2.Controls.Add(Me.btn_IssueTicket)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ticket Availability"
        '
        'label_NextEntry
        '
        Me.label_NextEntry.AutoSize = True
        Me.label_NextEntry.Location = New System.Drawing.Point(144, 46)
        Me.label_NextEntry.Name = "label_NextEntry"
        Me.label_NextEntry.Size = New System.Drawing.Size(0, 13)
        Me.label_NextEntry.TabIndex = 5
        '
        'label_TicketsOutstanding
        '
        Me.label_TicketsOutstanding.AutoSize = True
        Me.label_TicketsOutstanding.Location = New System.Drawing.Point(144, 20)
        Me.label_TicketsOutstanding.Name = "label_TicketsOutstanding"
        Me.label_TicketsOutstanding.Size = New System.Drawing.Size(0, 13)
        Me.label_TicketsOutstanding.TabIndex = 4
        '
        'btn_IssueTicket
        '
        Me.btn_IssueTicket.Location = New System.Drawing.Point(10, 74)
        Me.btn_IssueTicket.Name = "btn_IssueTicket"
        Me.btn_IssueTicket.Size = New System.Drawing.Size(75, 23)
        Me.btn_IssueTicket.TabIndex = 1
        Me.btn_IssueTicket.Text = "Issue Ticket"
        Me.btn_IssueTicket.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Next available entry:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Tickets outstanding:"
        '
        'listBox_Outstanding
        '
        Me.listBox_Outstanding.FormattingEnabled = True
        Me.listBox_Outstanding.Location = New System.Drawing.Point(24, 172)
        Me.listBox_Outstanding.Name = "listBox_Outstanding"
        Me.listBox_Outstanding.Size = New System.Drawing.Size(248, 134)
        Me.listBox_Outstanding.TabIndex = 0
        Me.listBox_Outstanding.TabStop = False
        Me.listBox_Outstanding.UseTabStops = False
        '
        'btn_Options
        '
        Me.btn_Options.Location = New System.Drawing.Point(24, 319)
        Me.btn_Options.Name = "btn_Options"
        Me.btn_Options.Size = New System.Drawing.Size(75, 23)
        Me.btn_Options.TabIndex = 2
        Me.btn_Options.Text = "Options"
        Me.btn_Options.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Exit.Location = New System.Drawing.Point(197, 319)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 3
        Me.btn_Exit.Text = "E&xit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'Form1
        '
        Me.AcceptButton = Me.btn_IssueTicket
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Exit
        Me.ClientSize = New System.Drawing.Size(304, 362)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Options)
        Me.Controls.Add(Me.listBox_Outstanding)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_IssueTicket As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listBox_Outstanding As ListBox
    Friend WithEvents btn_Options As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents label_EnteringTickets As Label
    Friend WithEvents label_NextEntry As Label
    Friend WithEvents label_TicketsOutstanding As Label
End Class
