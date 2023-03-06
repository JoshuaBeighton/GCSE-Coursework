Public Class Staff
    Sub init()
        ListView1.Items.Clear()
        For i = 0 To AllUsers.Count - 1
            Dim l As New ListViewItem
            l.SubItems(0).Text = AllUsers(i).ID
            l.SubItems.Add(AllUsers(i).username)
            Select Case AllUsers(i).permission
                Case "M"
                    l.SubItems.Add("Manager")
                Case "S"
                    l.SubItems.Add("Staff")
                Case "A"
                    l.SubItems.Add("Accountant")
            End Select
            ListView1.Items.Add(l)
        Next
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListView1.Columns
            .Add("ID", 30)
            .Add("Username", 300)
            .Add("Permission", ListView1.Width - 330)
        End With

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        Navigation.Show()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        For i = 0 To AllUsers.Count - 1
            If AllUsers(i).ID = ListView1.SelectedItems(0).SubItems(0).Text Then
                Dim u As user = AllUsers(i)
                u.ID = -1 - u.ID
                AllUsers(i) = u
                ListView1.Items.Remove(ListView1.SelectedItems(0))
            End If
        Next
        writeUser()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        AddUsers.Show()
        Me.Hide()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        EditUsers.Show()
        EditUsers.init(ListView1.SelectedItems(0).SubItems(0).Text)
        Me.Hide()
    End Sub
End Class