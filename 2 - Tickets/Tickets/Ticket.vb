Public Class Ticket
    Dim ticketNumber As Integer 'ticket number
    Dim timeSlot As DateTime 'ticket timeslot
    Public Shared nextTicket As Integer 'shared variable to determine next ticket number

    'constructor
    Public Sub New(timeSlot As Date)
        Me.ticketNumber = nextTicket 'assign next ticket number
        Me.timeSlot = timeSlot 'assing timeslot
        nextTicket += 1 'increment next ticket number
    End Sub

    'toString override to print in listbox
    Public Overrides Function ToString() As String
        Return "Ticket " & ticketNumber & ": " & timeSlot.ToString("hh:mm tt")
    End Function
    'return ticket number
    Public Function getTicketNumber() As Integer
        Return ticketNumber
    End Function
End Class
