Public Class TimeSlot
    Dim startTime As DateTime 'start time
    ReadOnly endTime As DateTime 'readonly end time
    Dim slotSpan As TimeSpan 'timespan
    Dim ticketsIssued As Integer 'tickets issued for slot

    'constructor
    Public Sub New(startTime As Date, endTime As Date)
        Me.startTime = startTime
        Me.endTime = endTime
        Me.slotSpan = endTime.Subtract(startTime) 'calculated slot span
        Me.ticketsIssued = 0 'default tickets issued as zero
    End Sub
    'returns end time
    Public Function getEndTime() As DateTime
        Return endTime
    End Function
    'returns start time
    Public Function getStartTime() As DateTime
        Return startTime
    End Function
    'increment tickets issued
    Public Sub issueTicket()
        ticketsIssued += 1
    End Sub

    'return tickets issued
    Public Function getTicketsIssued() As Integer
        Return ticketsIssued
    End Function

End Class
