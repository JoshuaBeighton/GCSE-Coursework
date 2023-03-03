Public Class EditMotherboard
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim m As motherboard
        m.id = original
        m.name = txt_name.Text
        m.manufacturer = txt_manufacturer.Text
        m.SATAs = txt_SATA.Text
        m.m2s = txt_m2.Text
        m.socket = txt_socket.Text
        m.ramSlots = txt_ram.Text
        m.price = txt_price.Text

        For i = 0 To AllMoba.Count - 1
            If AllMoba(i).id = m.id Then
                AllMoba(i) = m
            End If
        Next
        Me.Hide()
        parts.Show()
        parts.setup(parts.ptype)
        writeMoba()
        Dim l As log
        l.id = findNextIndex("AllLogs")
        l.user = Form1.currentUser
        l.action = "Edit"
        l.data = m.id & m.name & m.manufacturer & m.price
        l.time = Now
        AllLogs.Add(l)
        writeLogs()
    End Sub
    Sub init(m As motherboard)
        original = m.id
        txt_name.Text = m.name
        txt_manufacturer.Text = m.manufacturer
        txt_m2.Text = m.m2s
        txt_ram.Text = m.ramSlots
        txt_SATA.Text = m.SATAs
        txt_socket.Text = m.socket
        txt_price.Text = m.price
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class