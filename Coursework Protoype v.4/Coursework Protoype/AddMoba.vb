Public Class AddMoba
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_manufacturer.Text <> "" Then
            If txt_name.Text <> "" Then
                If txt_m2.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_ram.Text <> "" Then
                            If txt_SATA.Text <> "" Then
                                If txt_socket.Text <> "" Then
                                    Dim m As motherboard
                                    m.id = AllMoba.Count
                                    m.name = txt_name.Text
                                    m.manufacturer = txt_manufacturer.Text
                                    m.ramSlots = txt_ram.Text
                                    m.socket = txt_socket.Text
                                    m.SATAs = txt_SATA.Text
                                    m.m2s = txt_m2.Text
                                    m.price = txt_price.Text
                                    AllMoba.Add(m)
                                    writeMoba()
                                    parts.Show()
                                    Me.Hide()
                                    parts.setup(parts.ptype)
                                    Dim l As log
                                    l.id = findNextIndex("AllLogs")
                                    l.user = Form1.currentUser
                                    l.action = "Add"
                                    l.data = m.id & m.name & m.manufacturer & m.price
                                    l.time = Now
                                    AllLogs.Add(l)
                                    writeLogs()
                                Else
                                    MsgBox("Please enter the socket of the motherboard")
                                End If
                            Else
                                MsgBox("Please enter the amount of SATA sockets on the motherboard")
                            End If
                        Else
                            MsgBox("Please enter the amount of RAM slots on the motherboard")
                        End If
                    Else
                        MsgBox("Please enter the price of the motherboard")
                    End If
                Else
                    MsgBox("Please enter the amount of m.2 slots in the motherboard")
                End If
            Else
                MsgBox("Please enter the name of the motherboard")
            End If
        Else
            MsgBox("Please enter the manufacturer of the motherboard")
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class