Public Class EditGPU
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim g As GPU
        g.ID = original
        g.Model = txt_model.Text
        g.Series = txt_series.Text
        g.manufacturer = txt_manufacturer.Text
        g.chipManufacturer = txt_chip.Text
        g.TPD = txt_power.Text
        g.baseClock = txt_baseclock.Text
        g.VRAM = txt_VRAM.Text
        g.price = txt_price.Text
        For i = 0 To AllGPUs.Count - 1
            If AllGPUs(i).ID = g.ID Then
                AllGPUs(i) = g
            End If
        Next
        Me.Hide()
        parts.Show()
        parts.setup(parts.ptype)
        writeGPU()
        Dim l As log
        l.id = findNextIndex("AllLogs")
        l.user = Form1.currentUser
        l.action = "Edit"
        l.data = g.ID & g.Model & g.Series & g.manufacturer & g.chipManufacturer & g.price
        l.time = Now
        AllLogs.Add(l)
        writeLogs()
    End Sub
    Sub init(g As GPU)
        original = g.ID
        txt_model.Text = g.Model
        txt_baseclock.Text = g.baseClock
        txt_chip.Text = g.chipManufacturer
        txt_manufacturer.Text = g.manufacturer
        txt_power.Text = g.TPD
        txt_price.Text = g.price
        txt_series.Text = g.Series
        txt_VRAM.Text = g.VRAM
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class