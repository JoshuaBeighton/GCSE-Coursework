Imports System.Transactions
Imports System.Windows.Forms.Design

Public Class AddCustomer
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_first.Text <> "" Then
            If txt_last.Text <> "" Then
                If txt_number.Text <> "" Then
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
                Else
                    MsgBox("Please enter the customer's number")
                End If
            Else
                MsgBox("Please enter the customer's last name")
            End If
        Else
            MsgBox("Please enter the customer's first name")
        End If

    End Sub
End Class