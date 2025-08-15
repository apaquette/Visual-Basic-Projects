Public Class Form1
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TechSupportDataSet)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.CustomersTableAdapter.FillByCustomerID(Me.TechSupportDataSet.Customers, CInt(textBox_CustomerID.Text)) 'get customer info
            Me.IncidentsTableAdapter.FillByCustomerID(Me.TechSupportDataSet.Incidents, CInt(textBox_CustomerID.Text)) 'get incidents for specific customer
        Catch ex As Exception
            MessageBox.Show("Invalid Customer ID") 'show error message for invalid IDs
        End Try

    End Sub
End Class
