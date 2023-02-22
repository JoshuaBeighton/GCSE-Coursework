Public Class AddCPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim c As New CPU
        c.ID = AllCPUs.Count
        c.name = txt_name.Text
        c.manufacturer = txt_manufacturer.Text
        c.socket = txt_socket.Text
        c.cores = txt_cores.Text
        c.baseSpeed = txt_basespeed.Text
        c.boostSpeed = txt_boostSpeed.Text
        c.TPD = txt_power.Text
        c.price = txt_price.Text
        AllCPUs.Add(c)
        Me.Hide()
        parts.Show()
        parts.setup(parts.ptype)
    End Sub
End Class