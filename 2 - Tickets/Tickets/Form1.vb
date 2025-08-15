Public Class Form1
    Public tickets As List(Of Ticket) = New List(Of Ticket) 'tickets list
    Public timeSlots As List(Of TimeSlot) = New List(Of TimeSlot) 'timeslots list
    Public maxGuests As Integer 'max guests
    Dim index As Integer = 0 'index for tickets to be assigned
    Dim timeIndex As Integer = 0 'index for current timeslot based on time (ie slot actively running)

    'close forms on exit
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Form2.Close()
        Me.Close()
    End Sub

    'open options menu
    Private Sub Options(sender As Object, e As EventArgs) Handles btn_Options.Click
        If MessageBox.Show("Outstanding tickets will be removed. Proceed?", "Warning", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Form2.Show()
        End If
    End Sub

    'ticke each second
    Private Sub Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim time As DateTime = DateTime.ParseExact((TimeOfDay.ToString("hh:mm:ss tt")), "hh:mm:ss tt", Nothing) 'get current time and remove date
        Dim status As String = "Open" 'defaults to open, updates on line 54 if closed
        label_NextEntry.Text = "NA" 'shows NA when in last entry

        If (time >= timeSlots.Item(timeIndex).getStartTime() AndAlso timeIndex <> (timeSlots.Count - 1)) Then 'move index when timeslot starts
            If (tickets.Count <> 0) Then 'only if there are tickets in the list
                'update entering tickets
                Dim firstTicket As Integer = tickets.Item(0).getTicketNumber()
                Dim lastTicket As Integer = tickets.Item(timeSlots.Item(timeIndex).getTicketsIssued() - 1).getTicketNumber()
                label_EnteringTickets.Text = firstTicket & "-" & lastTicket

                'remove listbox items and old tickets
                For ticketNum As Integer = 0 To timeSlots.Item(timeIndex).getTicketsIssued() - 1
                    tickets.RemoveAt(0)
                    listBox_Outstanding.Items.RemoveAt(0)
                Next
            End If
            timeIndex += 1
        End If

        'increment if past start time and not final slot
        If (time >= timeSlots.Item(index).getStartTime() OrElse timeSlots.Item(index).getTicketsIssued() = maxGuests) AndAlso index <> (timeSlots.Count - 1) Then
            index = index + 1
        End If

        'show time if not full AND current time is before start time
        If timeSlots.Item(index).getTicketsIssued() <> maxGuests AndAlso time < timeSlots.Item(index).getStartTime() Then
            label_NextEntry.Text = timeSlots.Item(index).getStartTime().ToString("hh:mm tt")
        End If

        'show closed if before first slot or after final slot
        If time < timeSlots.First.getStartTime() OrElse time > timeSlots.Last.getEndTime() Then
            status = "Closed"
        End If

        Me.Text = CStr(TimeOfDay) + (" (" + status + ")") 'show time
        label_TicketsOutstanding.Text = CStr(tickets.Count) 'show outstanding ticket count
    End Sub

    'start time on load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Enabled = True
    End Sub

    'issue tickets
    Private Sub IssueTicket(sender As Object, e As EventArgs) Handles btn_IssueTicket.Click
        If label_NextEntry.Text <> "NA" AndAlso timeSlots.Item(index).getTicketsIssued() < maxGuests Then 'only allow tickets if tickes available and timeslot open
            tickets.Add(New Ticket(timeSlots.Item(index).getStartTime()))
            listBox_Outstanding.Items.Add(tickets.Last)
            timeSlots.Item(index).issueTicket()
        End If
    End Sub
End Class
