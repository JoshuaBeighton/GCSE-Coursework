Public Class AddRAM
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim r As RAM
        r.ID = AllRAMs.Count
        r.name = txt_name.Text
        r.manufacturer = txt_manufacturer.Text
        r.speed = txt_speed.Text
        r.ddr = txt_DDR.Text
        r.tpd = txt_power.Text
        r.dims = txt_dimms.Text
        r.capacity = txt_capacity.Text
        r.price = txt_price.Text

        AllRAMs.Add(r)
        parts.Show()
        Me.Hide()
        writeRAM()
        parts.setup(parts.ptype)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class