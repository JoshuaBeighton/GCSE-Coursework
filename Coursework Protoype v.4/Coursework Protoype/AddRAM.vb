Public Class AddRAM
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_manufacturer.Text <> "" Then
            If txt_name.Text <> "" Then
                If txt_latency.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_dimms.Text <> "" Then
                            If txt_DDR.Text <> "" Then
                                If txt_capacity.Text <> "" Then
                                    If txt_power.Text <> "" Then
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
                                        Dim l As log
                                        l.id = findNextIndex("AllLogs")
                                        l.user = Form1.currentUser
                                        l.action = "Add"
                                        l.data = r.ID & r.name & r.manufacturer & r.price
                                        l.time = Now
                                        AllLogs.Add(l)
                                        writeLogs()
                                    Else
                                        MsgBox("Please enter the power used by the RAM")
                                    End If
                                Else
                                    MsgBox("Please enter the capacity of the RAM")
                                End If
                            Else
                                MsgBox("Please enter the DDR level of the RAM")
                            End If
                        Else
                            MsgBox("Please enter the amount of DIMMs in the RAM kit")
                        End If
                    Else
                        MsgBox("Please enter the price of the RAM")
                    End If
                Else
                    MsgBox("Please enter the latency of the RAM")
                End If
            Else
                MsgBox("Please enter the name of the RAM")
            End If
        Else
            MsgBox("Please enter the manufacturer of the RAM")
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class