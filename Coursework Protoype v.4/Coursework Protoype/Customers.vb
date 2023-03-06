Public Class Customers
    Public selecting As Boolean = False
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("ID", 40)
        ListView1.Columns.Add("Name", 350)
        ListView1.Columns.Add("Contact", ListView1.Width - 390)
        custInit()
    End Sub
    Public Sub custInit()
        ListView1.Items.Clear()
        selecting = False
        Dim s As String
        For i = 0 To allCustomers.Count - 1
            If allCustomers(i).ID >= 0 Then
                Dim l As New ListViewItem
                l.SubItems(0).Text = allCustomers(i).ID.ToString()
                s = allCustomers(i).firstName & " " & allCustomers(i).lastName
                l.SubItems.Add(s)
                l.SubItems.Add(allCustomers(i).contact)
                ListView1.Items.Add(l)
            End If
        Next
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        While ListView1.SelectedItems.Count > 0
            For i = 0 To allCustomers.Count - 1
                If allCustomers(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                    Dim c As customer = allCustomers(i)
                    c.ID = -1 - c.ID
                    allCustomers(i) = c
                End If
            Next
            ListView1.Items.Remove(ListView1.SelectedItems(0))
        End While
    End Sub

    Private Sub btn_addCust_Click(sender As Object, e As EventArgs) Handles btn_addCust.Click
        Me.Hide()
        AddCustomer.Show()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        EditCustomer.Show()
        EditCustomer.init(ListView1.SelectedItems(0).SubItems(0).Text)
        Me.Hide()
    End Sub

    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        If selecting Then
            Write.Show()
            Me.Hide()
            Write.onCustReturn(ListView1.SelectedItems(0).SubItems(0).Text)
        End If
    End Sub
End Class