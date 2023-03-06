Public Class Staff
    Sub init()
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
End Class