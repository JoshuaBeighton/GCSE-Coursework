Public Class EditStorage
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim s As store
        s.ID = original
        s.name = txt_name.Text
        s.manufacturer = txt_manufacturer.Text
        s.capacity = txt_capacity.Text
        s.read = txt_read.Text
        s.write = txt_write.Text
        s.connection = cmb_connection.SelectedItem
        s.type = cmb_type.SelectedItem
        s.price = txt_price.Text
        For i = 0 To AllStorage.Count - 1
            If AllStorage(i).ID = s.ID Then
                AllStorage(i) = s
            End If
        Next
        Me.Hide()
        parts.Show()
        parts.setup(parts.ptype)
        writeStorage()
        Dim l As log
        l.id = findNextIndex("AllLogs")
        l.user = Form1.currentUser
        l.action = "Edit"
        l.data = s.ID & s.name & s.manufacturer & s.price
        l.time = Now
        AllLogs.Add(l)
        writeLogs()
    End Sub
    Sub init(s As store)
        original = s.ID
        txt_name.Text = s.name
        txt_manufacturer.Text = s.manufacturer
        txt_capacity.Text = s.capacity
        txt_read.Text = s.read
        txt_write.Text = s.write
        cmb_connection.SelectedItem = s.connection
        cmb_type.SelectedItem = s.type
        txt_price.Text = s.price
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class