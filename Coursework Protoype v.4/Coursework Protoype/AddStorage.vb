Public Class AddStorage
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim s As store
        s.ID = AllStorage.Count
        s.name = txt_name.Text
        s.manufacturer = txt_manufacturer.Text
        s.speed = txt_speed.Text
        s.type = txt_type.Text
        s.capacity = txt_capacity.Text
        s.connection = txt_connection.Text
        s.price = txt_price.Text
        AllStorage.Add(s)
        writeStorage()
        parts.Show()
        Me.Hide()
        parts.setup(parts.ptype)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
        parts.setup(parts.ptype)
    End Sub
End Class