Public Class EditGPU
    'store the ID of the GPU we are editing
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

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
                                        'set the ID of g to the same ID that we are editing
                                        g.ID = original
                                        'set the data of g equal to the data in the text boxes
                                        g.Model = txt_model.Text
                                        g.Series = txt_series.Text
                                        g.manufacturer = txt_manufacturer.Text
                                        g.chipManufacturer = txt_chip.Text
                                        g.TPD = txt_power.Text
                                        g.baseClock = txt_baseclock.Text
                                        g.VRAM = txt_VRAM.Text
                                        g.price = txt_price.Text
                                        'loop through the GPUs
                                        For i = 0 To AllGPUs.Count - 1
                                            'if we find the GPU we are editing
                                            If AllGPUs(i).ID = g.ID Then
                                                'set it's data to the temporary data we stored in G
                                                AllGPUs(i) = g
                                            End If
                                        Next
                                        'navigate back to the parts database
                                        Me.Hide()
                                        parts.Show()
                                        'set up parts
                                        parts.setup(parts.ptype)
                                        'write to the GPU file
                                        writeGPU()
                                        'store a temporary log item
                                        Dim l As log
                                        'set its ID to the next available log ID
                                        l.id = findNextIndex("AllLogs")
                                        l.user = Form1.currentUser
                                        l.action = "Edit"
                                        l.data = g.ID & g.Model & g.Series & g.manufacturer & g.chipManufacturer & g.price
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
    'initialise the textboxes
    Sub init(g As GPU)
        'set the ID to the ID of the item we are editing
        original = g.ID
        'set up the textboxes
        txt_model.Text = g.Model
        txt_baseclock.Text = g.baseClock
        txt_chip.Text = g.chipManufacturer
        txt_manufacturer.Text = g.manufacturer
        txt_power.Text = g.TPD
        txt_price.Text = g.price
        txt_series.Text = g.Series
        txt_VRAM.Text = g.VRAM
    End Sub

    'if the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class