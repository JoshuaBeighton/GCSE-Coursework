Public Class AddGPU
    'on the clicking the button to add a GPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_series.Text <> "" Then
            If txt_model.Text <> "" Then
                If txt_baseclock.Text <> "" Then
                    If txt_chip.Text <> "" Then
                        If txt_manufacturer.Text <> "" Then
                            If txt_power.Text <> "" Then
                                If txt_price.Text <> "" Then
                                    If txt_VRAM.Text <> "" Then
                                        'create a temporary variable to store the data
                                        Dim g As New GPU
                                        'set its ID to the amount of GPUs currently in the file
                                        g.ID = AllGPUs.Count
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
                                        parts.Show()
                                        Me.Hide()
                                        parts.setup(parts.ptype)
                                        Dim l As log
                                        l.id = findNextIndex("AllLogs")
                                        l.user = Form1.currentUser
                                        l.action = "Add"
                                        l.data = g.Series & g.Model & g.chipManufacturer & g.manufacturer & g.price
                                        l.time = Now
                                        AllLogs.Add(l)
                                        writeLogs()
                                    Else
                                        MsgBox("Please enter the VRAM of the GPU")
                                    End If
                                Else
                                    MsgBox("Please enter the price of the GPU")
                                End If
                            Else
                                MsgBox("Please enter the power consumption of the GPU")
                            End If
                        Else
                            MsgBox("Please enter the manufacturer of the GPU")
                        End If
                    Else
                        MsgBox("Please enter the chip of the GPU")
                    End If
                Else
                    MsgBox("Please enter the baseclock of the GPU")
                End If
            Else
                MsgBox("Please enter the model of the GPU")
            End If
        Else
            MsgBox("Please enter the series of the GPU")
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class