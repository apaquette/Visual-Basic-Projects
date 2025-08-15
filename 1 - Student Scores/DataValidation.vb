Imports Microsoft.VisualBasic

Public Class DataValidation
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
End Class
