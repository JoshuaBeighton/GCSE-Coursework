Public Class EditCustomer
    'store the ID of the customer we are editing
    Dim id As Integer
    'initialise the page
    Public Sub init(tempID As Integer)
        'set the ID to the one we are editing
        id = tempID
        'loop through the customers
        For i = 0 To allCustomers.Count - 1
            'if the customer matches ID the ID we have been passed
            If allCustomers(i).ID = id Then
                'set the textbox values
                txt_first.Text = allCustomers(i).firstName
                txt_last.Text = allCustomers(i).lastName
                txt_number.Text = allCustomers(i).contact
            End If
        Next
    End Sub
    'if the user presses the add button
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'if they have entered the customers first name
        If txt_first.Text <> "" Then
            'if they have entered the customers last name
            If txt_last.Text <> "" Then
                'if the user has entered the customers number
                If txt_number.Text <> "" Then
                    'store a temporary customer variable called c
                    Dim c As customer
                    'set the id of the customer to that of the customer we are editing
                    c.ID = id
                    'store the data of the customer
                    c.firstName = txt_first.Text
                    c.lastName = txt_last.Text
                    c.contact = txt_number.Text
                    'loop thgrough the customers
                    For i = 0 To allCustomers.Count - 1
                        'if the ID of the customer matches the original ID
                        If id = allCustomers(i).ID Then
                            'set the customer data at that index to c
                            allCustomers(i) = c
                        End If
                    Next
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