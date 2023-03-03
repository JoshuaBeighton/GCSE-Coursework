Public Class EditRAM
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim r As RAM
        r.ID = original
        r.name = txt_name.Text
        r.manufacturer = txt_manufacturer.Text
        r.tpd = txt_power.Text
        r.dims = txt_dimms.Text
        r.capacity = txt_capacity.Text
        r.ddr = txt_DDR.Text
        r.latency = txt_latency.Text
        r.speed = txt_speed.Text
        r.price = txt_price.Text
        For i = 0 To AllRAMs.Count - 1
            If AllRAMs(i).ID = r.ID Then
                AllRAMs(i) = r
            End If
        Next
        Me.Hide()
        parts.Show()
        parts.setup(parts.ptype)
        writeRAM()
        Dim l As log
        l.id = findNextIndex("AllLogs")
        l.user = Form1.currentUser
        l.action = "Edit"
        l.data = r.ID & r.name & r.manufacturer & r.price
        l.time = Now
        AllLogs.Add(l)
        writeLogs()
    End Sub
    Sub init(r As RAM)
        original = r.ID
        txt_name.Text = r.name
        txt_manufacturer.Text = r.manufacturer
        txt_capacity.Text = r.capacity
        txt_DDR.Text = r.dims
        txt_dimms.Text = r.dims
        txt_latency.Text = r.latency
        txt_power.Text = r.tpd
        txt_speed.Text = r.speed
        txt_price.Text = r.price
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class