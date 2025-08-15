Imports Microsoft.VisualBasic

Public Class DataValidation
	'Used to make sure required textbox is filled
	Public Shared Function IsPresent(textbox As TextBox, name As String) As Boolean
		If textbox.Text = "" Then
			MessageBox.Show(name & " is a required field.", "Entry Error")
			textbox.Select()
			textbox.SelectAll()
			Return False
		End If
		Return True
	End Function

	'Check if field is an integer
	Public Shared Function IsInt32(textBox As TextBox, name As String) As Boolean
		Dim state As Boolean
		Try 'Try to convert to integer
			Convert.ToInt32(textBox.Text)
			state = True 'return true if successful
		Catch ex As FormatException 'catch error thrown
			MessageBox.Show(name & " must be an integer value.", "Entry Error")
			state = False
		Finally
			textBox.Select()
			textBox.SelectAll()
		End Try
		Return state
	End Function

	'Check to make sure value is within a given range (inclusive)
	Public Shared Function IsWithinRange(textBox As TextBox, name As String, min As Decimal, max As Decimal) As Boolean
		Dim number As Decimal = CDec(textBox.Text) 'convert to decimal
		If number < min Or number > max Then 'check if within the given range
			MessageBox.Show(name & " must be between " & min & " and " & max & ".", "Entry Error")
			textBox.Select()
			textBox.SelectAll()
			Return False 'return false if outside of range
		End If
		Return True 'true if inside range
	End Function

	'Check if an item in the listbox is selected
	Public Shared Function IsSelected(listBox As ListBox, name As String) As Boolean
		If listBox.SelectedIndex <> -1 Then 'if not -1, an item is selected
			Return True
		Else
			MessageBox.Show(name & " must be selected", "Entry Error")
			Return False
		End If
	End Function

	'Check if dateTime is valid and the desired format
	Public Shared Function IsValidDate(textBox As TextBox, name As String, format As String) As Boolean
		Dim testDate As DateTime
		Try
			testDate = DateTime.ParseExact(textBox.Text, format, Nothing)
			Return True
		Catch ex As Exception
			MessageBox.Show(name & " must be a date with format " & format, "Entry Error")
			Return False
		End Try
	End Function

	Public Shared Function IsValidEndDate(startDate As DateTime, endDate As DateTime) As Boolean
		Dim result As Integer = DateTime.Compare(startDate, endDate)
		If (result >= 0) Then
			MessageBox.Show("End Date must be greater than start date.", "Entry Error")
			Return False
		End If

		Return True
	End Function
	Public Shared Function IsValidTimeSpan(startDate As DateTime, endDate As DateTime, timeSpan As TimeSpan) As Boolean
		Dim timeDiff As TimeSpan = endDate.Subtract(startDate)
		If (timeDiff >= timeSpan) Then
			Return True
		End If
		MessageBox.Show("Time interval between start and end date must allow two time slots", "Entry Error")
		Return False
	End Function

	Public Shared Function IsNotNegative(textBox As TextBox, name As String) As Boolean
		Dim number As Decimal = CDec(textBox.Text) 'convert to decimal
		If number >= 0 Then
			Return True 'return true if not negative
		Else
			MessageBox.Show(name & " cannot be negative", "Entry Error")
			textBox.Select()
			textBox.SelectAll()
			Return False 'return false if negative
		End If
	End Function

	Public Shared Function IsGreaterThanZero(textBox As TextBox, name As String) As Boolean
		Dim number As Decimal = CDec(textBox.Text) 'convert to decimal
		If number > 0 Then
			Return True 'return true if greater than zero
		Else
			MessageBox.Show(name & " must be greater than zero", "Entry Error")
			textBox.Select()
			textBox.SelectAll()
			Return False 'return false if negative
		End If
	End Function
End Class
