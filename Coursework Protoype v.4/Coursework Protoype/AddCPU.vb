Public Class AddCPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_name.Text <> "" Then
            If txt_manufacturer.Text <> "" Then
                If txt_socket.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_power.Text <> "" Then
                            If txt_cores.Text <> "" Then
                                If txt_boostSpeed.Text <> "" Then
                                    If txt_basespeed.Text <> "" Then

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
                                    Else
                                        MsgBox("Please enter the base speed of the CPU")
                                    End If
                                Else
                                    MsgBox("Please enter the boost speed of the CPU")
                                End If
                            Else
                                MsgBox("Please enter the amount of cores in the CPU")
                            End If
                        Else
                            MsgBox("Please enter the power draw of the CPU")
                        End If
                    Else
                        MsgBox("Please enter the price of the CPU")
                    End If
                Else
                    MsgBox("Please enter the socket of the CPU")
                End If
            Else
                MsgBox("Please enter the manufacturer of the CPU")
            End If
        Else
            MsgBox("Please enter the name of the CPU")
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub


End Class