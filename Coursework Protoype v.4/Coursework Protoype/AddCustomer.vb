Imports System.Transactions
Imports System.Windows.Forms.Design

Public Class AddCustomer
    'if the user presses the add button
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'if they have entered the customers first name
        If txt_first.Text <> "" Then
            'if they have entered the customers last name
            If txt_last.Text <> "" Then
                'if the user has entered the customers number
                If txt_number.Text <> "" Then
                    'store a temporary customer variable called c
                    Dim c As New customer
                    'set the ID of C to the next available customer index
                    c.ID = findNextIndex("Customer")
                    c.firstName = txt_first.Text
                    c.lastName = txt_last.Text
                    c.contact = txt_number.Text
                    'add c to the list of customers
                    allCustomers.Add(c)
                    'navigate back to the customers page and initialise it
                    Me.Hide()
                    Customers.Show()
                    Customers.custInit()
                    'write to the customers file
                    writeCustomers()
                    'if the user didn't enter the customers number
                Else
                    'ask them to
                    MsgBox("Please enter the customer's number")
                End If
                'if the user didn't enter the customer's last name
            Else
                'ask them to
                MsgBox("Please enter the customer's last name")
            End If
            'if the user didn't enter the customer's first name
        Else
            'ask them to
            MsgBox("Please enter the customer's first name")
        End If

    End Sub
End Class