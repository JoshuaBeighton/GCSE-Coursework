Public Class EditRAM
    'store the ID of the original RAM data
    Dim original As Integer
    'when the user clicks the button to add a ram item
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'if the user has entered the manufacturer of the ram
        If txt_manufacturer.Text <> "" Then
            'if the user has entered the name
            If txt_name.Text <> "" Then
                'if the user has entered the latency
                If txt_latency.Text <> "" Then
                    'if the user has entered the price
                    If txt_price.Text <> "" Then
                        'if the user has entered the amount of DIMMs
                        If txt_dimms.Text <> "" Then
                            'if the user has entered the ddr of the ram
                            If txt_DDR.Text <> "" Then
                                'if the user has entered the capacity of the RAM
                                If txt_capacity.Text <> "" Then
                                    'if the user has entered the power consumption of the RAM
                                    If txt_power.Text <> "" Then
                                        'store a temporary RAM item
                                        Dim r As RAM
                                        'set it's ID to that of the original
                                        r.ID = original
                                        ''set it's ID to the next available RAM ID
                                        r.name = txt_name.Text
                                        r.manufacturer = txt_manufacturer.Text
                                        r.tpd = txt_power.Text
                                        r.dims = txt_dimms.Text
                                        r.capacity = txt_capacity.Text
                                        r.ddr = txt_DDR.Text
                                        r.latency = txt_latency.Text
                                        r.speed = txt_speed.Text
                                        r.price = txt_price.Text
                                        'loop through the RAM list
                                        For i = 0 To AllRAMs.Count - 1
                                            'if the ID of the RAM item is equal to the ID of the item we are trying to edit
                                            If AllRAMs(i).ID = r.ID Then
                                                AllRAMs(i) = r
                                            End If
                                        Next
                                        'navigate back to the parts page
                                        Me.Hide()
                                        parts.Show()
                                        'write to the RAM file
                                        parts.setup(parts.ptype)
                                        'set up the parts form
                                        writeRAM()
                                        'store a temporary log item
                                        Dim l As log
                                        'set the ID of the log to the next available log id
                                        l.id = findNextIndex("AllLogs")
                                        'set the data of the log according to the data it should have
                                        l.user = Form1.currentUser
                                        l.action = "Edit"
                                        l.data = r.ID & r.name & r.manufacturer & r.price
                                        l.time = Now
                                        'add the temporary log to the list
                                        AllLogs.Add(l)
                                        'write to the log file
                                        writeLogs()
                                        'if the user hasn't entered the power used by the RAM
                                    Else
                                        'ask them to do so
                                        MsgBox("Please enter the power used by the RAM")
                                    End If
                                    'if the user hasn't entered the capacity of the RAM
                                Else
                                    'ask them to do so
                                    MsgBox("Please enter the capacity of the RAM")
                                End If
                                'if the user hasn't entered the DDR level of the RAM
                            Else
                                'ask them to do so
                                MsgBox("Please enter the DDR level of the RAM")
                            End If
                            'if the user hasn't entered the amount of dimms of the RAM
                        Else
                            'ask them to do so
                            MsgBox("Please enter the amount of DIMMs in the RAM kit")
                        End If
                        'if the user hasn't entered the price of the RAM
                    Else
                        'ask them to do so
                        MsgBox("Please enter the price of the RAM")
                    End If
                    'if the user hasn't entered the latency of the RAM
                Else
                    'ask them to do so
                    MsgBox("Please enter the latency of the RAM")
                End If
                'if the user hasn't entered the name of the RAM
            Else
                'ask them to do so
                MsgBox("Please enter the name of the RAM")
            End If
            'if the user hasn't entered the manufacturer of the RAM
        Else
            'ask them to do so
            MsgBox("Please enter the manufacturer of the RAM")
        End If
    End Sub
    'initialise the page
    Sub init(r As RAM)
        'store the original ID
        original = r.ID
        'set up the text boxes with the correct values from the existing RAM item
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
    'when the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate back to te parts menu
        Me.Hide()
        parts.Show()
    End Sub
End Class