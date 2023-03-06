Public Class Customers
    'store whether this page is being used to select a customer
    Public selecting As Boolean = False
    'store whether this page was called from the edit order page or add order
    Public editing As Boolean = False

    'on loading
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add the needed columns to the list view
        ListView1.Columns.Add("ID", 40)
        ListView1.Columns.Add("Name", 350)
        ListView1.Columns.Add("Contact", ListView1.Width - 390)
        'initialise the data
        custInit()
    End Sub
    'initialise the data of the customers
    Public Sub custInit()
        'clear the items already in listview1
        ListView1.Items.Clear()
        'set selecting to its default of false
        selecting = False
        'set editing to its default value of false
        editing = False
        'store teh concatenated version of the customers name
        Dim s As String
        'loop through all of the customers
        For i = 0 To allCustomers.Count - 1
            'if the customer hasn't been marked for deletion
            If allCustomers(i).ID >= 0 Then
                'declare a nwe temporary listviewitem
                Dim l As New ListViewItem
                'set its first subitem to the of the customer at the current position in the loop
                l.SubItems(0).Text = allCustomers(i).ID.ToString()
                'set the string storing it's name accurately
                s = allCustomers(i).firstName & " " & allCustomers(i).lastName
                'add the string of the name as another sub item of the listviewitem
                l.SubItems.Add(s)
                'add the contact info of the customer as another subitem of l
                l.SubItems.Add(allCustomers(i).contact)
                'add l to the listview
                ListView1.Items.Add(l)
            End If
        Next
    End Sub

    'when the user presses delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        'for all of the selected items in the list view
        While ListView1.SelectedItems.Count > 0
            'loop through the customers
            For i = 0 To allCustomers.Count - 1
                'when we find the customer that matches the id of the current listviewitem to be removed
                If allCustomers(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                    'store a temporary customer equal to the customer with the ID of one of the selected items
                    Dim c As customer = allCustomers(i)
                    'set its ID to -1 subtract itself as to ensure that it is always negative, even for the index of 0
                    c.ID = -1 - c.ID
                    'set the original value in allcustomers to c
                    allCustomers(i) = c
                End If
            Next
            'remove the item from the listview
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        End While
    End Sub

    'when the user presses the add customer button 
    Private Sub btn_addCust_Click(sender As Object, e As EventArgs) Handles btn_addCust.Click
        'naviagte to the add customer page
        Me.Hide()
        AddCustomer.Show()
    End Sub

    'when the user presses the edit button
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'navigate to the edit page and set it up based on the ID stored in the listviewitem at the index that the user selected
        EditCustomer.Show()
        EditCustomer.init(ListView1.SelectedItems(0).SubItems(0).Text)
        Me.Hide()
    End Sub

    'when the user double-clicks on an item / selects it otherwise
    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        'if we are using this form as a way to select a customer
        If selecting Then
            'if this page was called from the add order form
            If Not editing Then
                'go back to write and call it's function for returning with a customer index
                Write.Show()
                Me.Hide()
                Write.onCustReturn(ListView1.SelectedItems(0).SubItems(0).Text)
                'if the page was called from edit order
            Else
                'navigate back to the edit order page and 
                EditOrder.Show()
                Me.Hide()
                EditOrder.onCustReturn(ListView1.SelectedItems(0).SubItems(0).Text)
            End If
        End If
    End Sub
    'on clicking the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate back to the navigation page
        Me.Hide()
        Navigation.Show()
    End Sub
End Class