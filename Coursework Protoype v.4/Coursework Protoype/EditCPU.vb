Public Class EditCPU
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim c As CPU
        c.id = original
        c.name = txt_name.Text
        c.manufacturer = txt_manufacturer.Text
        c.baseSpeed = txt_basespeed.Text
        c.TPD = txt_power.Text
        c.socket = txt_socket.Text
        c.boostSpeed = txt_boostSpeed.Text
        c.cores = txt_cores.Text
        c.price = txt_price.Text
        For i = 0 To AllCPUs.Count - 1
            If AllCPUs(i).ID = c.ID Then
                AllCPUs(i) = c
            End If
        Next
        Me.Hide()
        parts.Show()
        parts.setup(parts.ptype)
        writeCPU()
        Dim l As log
        l.id = findNextIndex("AllLogs")
        l.user = Form1.currentUser
        l.action = "Edit"
        l.data = c.ID & c.name & c.manufacturer & c.price
        l.time = Now
        AllLogs.Add(l)
        writeLogs()
    End Sub
    Sub init(c As CPU)
        original = c.ID
        txt_name.Text = c.name
        txt_manufacturer.Text = c.manufacturer
        txt_basespeed.Text = c.baseSpeed
        txt_boostSpeed.Text = c.boostSpeed
        txt_cores.Text = c.cores
        txt_power.Text = c.TPD
        txt_socket.Text = c.socket
        txt_price.Text = c.price
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub

End Class