Imports System.Globalization

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_OK.Click
        If isValidMinutesPerWindow(textBox_MinutesPerWindow) AndAlso isValidGuestsPerWindow(textBox_GuestsPerWindow) AndAlso isValidStartTime(textBox_StartTime) AndAlso isValidEndTime(textBox_EndTime) AndAlso isValidFirstTicketNumber(textBox_FirstTicketNumber) Then
            Ticket.nextTicket = CInt(textBox_FirstTicketNumber.Text) 'first ticket number
            Form1.maxGuests = CInt(textBox_GuestsPerWindow.Text) 'max guest per ride

            'Reset lists
            Form1.timeSlots = New List(Of TimeSlot)
            Form1.tickets = New List(Of Ticket)
            Form1.listBox_Outstanding.Items.Clear()

            'create time slots
            Dim startTime As DateTime = DateTime.ParseExact(textBox_StartTime.Text, "hh:mm tt", Nothing)
            Dim endTime As DateTime = startTime.AddMinutes(CInt(textBox_MinutesPerWindow.Text))
            Do
                Dim timeSlot As New TimeSlot(startTime, endTime)
                Form1.timeSlots.Add(timeSlot)
                startTime = endTime
                endTime = endTime.AddMinutes(CInt(textBox_MinutesPerWindow.Text))
            Loop While endTime <= DateTime.ParseExact(textBox_EndTime.Text, "hh:mm tt", Nothing) 'keep making timeslots while not reaching user endtime

            Me.Hide() 'hide options form
            Form1.Show() 'show tickets form
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set default values
        textBox_MinutesPerWindow.Text = CStr(5)
        textBox_GuestsPerWindow.Text = CStr(5)
        textBox_StartTime.Text = TimeOfDay.ToString("hh:mm tt")
        textBox_EndTime.Text = TimeOfDay.AddHours(4).ToString("hh:mm tt")
        textBox_FirstTicketNumber.Text = CStr(1)
    End Sub

    'Data Validation
    Private Function isValidMinutesPerWindow(textbox As TextBox) As Boolean
        Dim title As String = "Minutes per Window"
        Return _
            DataValidation.IsPresent(textbox, title) AndAlso
            DataValidation.IsInt32(textbox, title) AndAlso
            DataValidation.IsGreaterThanZero(textbox, title)
    End Function
    Private Function isValidGuestsPerWindow(textBox As TextBox) As Boolean
        Dim title As String = "Guests Per Window"
        Return _
            DataValidation.IsPresent(textBox, title) AndAlso
            DataValidation.IsInt32(textBox, title) AndAlso
            DataValidation.IsGreaterThanZero(textBox, title)
    End Function
    Private Function isValidStartTime(textBox As TextBox) As Boolean
        Dim title As String = "Start Time"
        Return _
            DataValidation.IsPresent(textBox, title) AndAlso
            DataValidation.IsValidDate(textBox, title, "hh:mm tt")
    End Function
    Private Function isValidEndTime(textBox As TextBox) As Boolean
        Dim title As String = "End Time"
        Dim startDate As DateTime = DateTime.ParseExact(textBox_StartTime.Text, "hh:mm tt", Nothing)
        Dim endDate As DateTime = DateTime.ParseExact(textBox.Text, "hh:mm tt", Nothing)
        Dim minutesPerWindow As Integer = CInt(textBox_MinutesPerWindow.Text)
        Dim timeSpan As TimeSpan = startDate.AddMinutes(2 * minutesPerWindow).Subtract(startDate)
        Return _
            DataValidation.IsPresent(textBox, title) AndAlso
            DataValidation.IsValidDate(textBox, title, "hh:mm tt") AndAlso
            DataValidation.IsValidEndDate(startDate, endDate) AndAlso
            DataValidation.IsValidTimeSpan(startDate, endDate, timeSpan)
    End Function
    Private Function isValidFirstTicketNumber(textBox As TextBox) As Boolean
        Dim title As String = "First Ticket Number"
        Return _
            DataValidation.IsPresent(textBox, title) AndAlso
            DataValidation.IsInt32(textBox, title) AndAlso
            DataValidation.IsGreaterThanZero(textBox, title)
    End Function
End Class