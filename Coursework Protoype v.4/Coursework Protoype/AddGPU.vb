Public Class AddGPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim g As New GPU
        g.ID = AllGPUs.Count
        g.Series = txt_series.Text
        g.Model = txt_model.Text
        g.manufacturer = txt_manufacturer.Text
        g.chipManufacturer = txt_chip.Text
        g.baseClock = txt_baseclock.Text
        g.VRAM = txt_VRAM.Text
        g.TPD = txt_power.Text
        g.price = txt_price.Text
        AllGPUs.Add(g)
        writeGPU()
    End Sub
End Class