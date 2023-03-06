Public Class AddCustomer
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim c As New customer
        c.ID = findNextIndex("Customer")
        c.firstName = txt_first.Text
        c.lastName = txt_last.Text
        c.contact = txt_number.Text
        allCustomers.Add(c)
        Me.Hide()
        Customers.Show()
        Customers.custInit()
        writeCustomers()
    End Sub
End Class