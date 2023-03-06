Public Class AddGPU
    'on the clicking the button to add a GPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'if the user has entered the series of GPU
        If txt_series.Text <> "" Then
            'if the user has entered the model of GPU
            If txt_model.Text <> "" Then
                'if the user has entered the baseclock of the GPU
                If txt_baseclock.Text <> "" Then
                    'if the user has entered the chip in the GPU
                    If txt_chip.Text <> "" Then
                        'if the user has entered the manufacturer of the gpu
                        If txt_manufacturer.Text <> "" Then
                            'if the user has entered the power consumption of the GPU
                            If txt_power.Text <> "" Then
                                'if the user has entered the price of the GPU
                                If txt_price.Text <> "" Then
                                    'if the user has entered the VRAM of the GPU
                                    If txt_VRAM.Text <> "" Then
                                        'create a temporary variable to store the data
                                        Dim g As New GPU
                                        'set its ID to the next availble GPU ID
                                        g.ID = findNextIndex("GPU")
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
                                        'navigate back to the parts database
                                        parts.Show()
                                        Me.Hide()
                                        'set up parts
                                        parts.setup(parts.ptype)
                                        'store a temporary log item
                                        Dim l As log
                                        'set its ID to the next available log ID
                                        l.id = findNextIndex("AllLogs")
                                        'set its data to the relavant data
                                        l.user = Form1.currentUser
                                        l.action = "Add"
                                        l.data = g.Series & g.Model & g.chipManufacturer & g.manufacturer & g.price
                                        l.time = Now
                                        'add the temporary log item to the list of logs
                                        AllLogs.Add(l)
                                        'write to the log file
                                        writeLogs()
                                        'if the user hasnt entered the vram of the gpu
                                    Else
                                        'ask them to do so
                                        MsgBox("Please enter the VRAM of the GPU")
                                    End If
                                    'if the user hasnt entered the price if the GPU
                                Else
                                    'ask them to do so
                                    MsgBox("Please enter the price of the GPU")
                                End If
                                'if the user hasnt entered the power consumption of the GPU
                            Else
                                'ask them to do so
                                MsgBox("Please enter the power consumption of the GPU")
                            End If
                            'if the user hasn't entered the manufacturer of the GPU
                        Else
                            'ask them to do so
                            MsgBox("Please enter the manufacturer of the GPU")
                        End If
                        'if the user hasnt entered the chip of the GPU
                    Else
                        'ask them to do so
                        MsgBox("Please enter the chip of the GPU")
                    End If
                    'if the user hasn't entered the base clock of the GPU
                Else
                    'ask them to do so
                    MsgBox("Please enter the baseclock of the GPU")
                End If
                'if the user hasn't entered the model of the GPU
            Else
                'ask them to do so
                MsgBox("Please enter the model of the GPU")
            End If
            'if the user hasn't entered the series of GPU
        Else
            'ask them to do so
            MsgBox("Please enter the series of the GPU")
        End If

    End Sub
    'if the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class