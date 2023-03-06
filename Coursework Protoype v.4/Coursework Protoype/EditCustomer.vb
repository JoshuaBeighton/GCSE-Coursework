Public Class EditCustomer
    Dim id As Integer
    Public Sub init(tempID As Integer)
        id = tempID
        For i = 0 To allCustomers.Count - 1
            If allCustomers(i).ID = id Then
                txt_first.Text = allCustomers(i).firstName
                txt_last.Text = allCustomers(i).lastName
                txt_number.Text = allCustomers(i).contact
            End If
        Next
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim c As customer
        c.ID = id
        c.firstName = txt_first.Text
        c.lastName = txt_last.Text
        c.contact = txt_number.Text
        For i = 0 To allCustomers.Count - 1
            If id = allCustomers(i).ID Then
                allCustomers(i) = c
            End If
        Next
        Me.Hide()
        Customers.Show()
        Customers.custInit()
        writeCustomers()
    End Sub
End Class