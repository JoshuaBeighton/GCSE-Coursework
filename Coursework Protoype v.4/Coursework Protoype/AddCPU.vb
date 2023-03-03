Public Class AddCPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'store the data entered
        Dim c As New CPU
        'set the ID equal to the count of CPUs currently stored
        c.ID = AllCPUs.Count
        'add the data from the textboxes to c
        c.name = txt_name.Text
        c.manufacturer = txt_manufacturer.Text
        c.socket = txt_socket.Text
        c.cores = txt_cores.Text
        c.baseSpeed = txt_basespeed.Text
        c.boostSpeed = txt_boostSpeed.Text
        c.TPD = txt_power.Text
        c.price = txt_price.Text
        'add c to the allCPUs list
        AllCPUs.Add(c)
        'go back to parts
        Me.Hide()
        parts.Show()
        'reset the parts form based on what type it currently on
        parts.setup(parts.ptype)
        'write the CPUs
        FileHandler.writeCPU()
        Dim l As log
        l.id = findNextIndex("AllLogs")
        l.user = Form1.currentUser
        l.action = "Add"
        l.data = c.ID & c.name & c.manufacturer & c.price
        l.time = Now
        AllLogs.Add(l)
        writeLogs()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class