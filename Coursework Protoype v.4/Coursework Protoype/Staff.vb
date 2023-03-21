Public Class Staff
    'initialise the staff page
    Sub init()
        'clear the items from the list view
        ListView1.Items.Clear()
        'loop through all of the users
        For i = 0 To AllUsers.Count - 1
            'if the user has not been marked for deletion
            If AllUsers(i).ID >= 0 Then
                'store a temporary list view item
                Dim l As New ListViewItem
                'set the first sub item equal to the ID of the user
                l.SubItems(0).Text = AllUsers(i).ID
                'add the username of the user
                l.SubItems.Add(AllUsers(i).username)
                'depending on the users permission level
                Select Case AllUsers(i).permission
                    'in the case that the user is a manager
                    Case "M"
                        'add manager to the subitems of the listviewitem
                        l.SubItems.Add("Manager")
                    'if the user is a staff member 
                    Case "S"
                        'add staff to the subitems of the listviewitem
                        l.SubItems.Add("Staff")
                End Select
                'add the listviewitem to the listview
                ListView1.Items.Add(l)
            End If
        Next
    End Sub
    'when the form is loaded
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'replace listview1.columns. with simply a .
        With ListView1.Columns
            'add the relevant columns to the listview
            .Add("ID", 30)
            .Add("Username", 300)
            .Add("Permission", ListView1.Width - 330)
        End With

    End Sub
    'when the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate back to the navigation page
        Me.Hide()
        Navigation.Show()
    End Sub
    'when the user deletes a staff member
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        'loop through the users
        For i = 0 To AllUsers.Count - 1
            'if we have found the right user
            If AllUsers(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                'store a temporary user based on the current uset
                Dim u As user = AllUsers(i)
                'set its id to a negative version
                u.ID = -1 - u.ID
                'set the current user equal to the tenmporary one
                AllUsers(i) = u
                'remove the listviewitem containing the user to be deleted
                ListView1.Items.Remove(ListView1.SelectedItems(0))
            End If
        Next
        'write to the users file
        writeUser()
    End Sub
    'when the user presses the add button
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'navigate to the add file
        AddUsers.Show()
        Me.Hide()
    End Sub
    'when the user presses the edit button
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'if the user has selected exactly one item
        If ListView1.SelectedItems.Count = 1 Then
            'navigate to the edit page and set it up
            EditUsers.Show()
            EditUsers.init(ListView1.SelectedItems(0).SubItems(0).Text)
            Me.Hide()
        End If

    End Sub
End Class