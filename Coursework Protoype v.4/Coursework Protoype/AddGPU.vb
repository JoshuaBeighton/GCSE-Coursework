Public Class AddGPU
'on the clicking the button to add a GPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'create a temporary variable to store the data
        Dim g As New GPU
        'set its ID to the amount of GPUs currently in the file
        g.ID = AllGPUs.Count
        'set the data of g equal to the data in the text boxes
        g.Series = txt_series.Text
        g.Model = txt_model.Text
        g.manufacturer = txt_manufacturer.Text
        g.chipManufacturer = txt_chip.Text
        g.baseClock = txt_baseclock.Text
        g.VRAM = txt_VRAM.Text
        g.TPD = txt_power.Text
        g.price = txt_price.Text
        'add g to the list of GPUs
        AllGPUs.Add(g)
        'write the GPUs
        writeGPU()
    End Sub
End Class