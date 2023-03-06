Public Class EditGPU
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_series.Text <> "" Then
            If txt_model.Text <> "" Then
                If txt_baseclock.Text <> "" Then
                    If txt_chip.Text <> "" Then
                        If txt_manufacturer.Text <> "" Then
                            If txt_power.Text <> "" Then
                                If txt_price.Text <> "" Then
                                    If txt_VRAM.Text <> "" Then
                                        Dim g As GPU
                                        g.ID = original
                                        g.Model = txt_model.Text
                                        g.Series = txt_series.Text
                                        g.manufacturer = txt_manufacturer.Text
                                        g.chipManufacturer = txt_chip.Text
                                        g.TPD = txt_power.Text
                                        g.baseClock = txt_baseclock.Text
                                        g.VRAM = txt_VRAM.Text
                                        g.price = txt_price.Text
                                        For i = 0 To AllGPUs.Count - 1
                                            If AllGPUs(i).ID = g.ID Then
                                                AllGPUs(i) = g
                                            End If
                                        Next
                                        Me.Hide()
                                        parts.Show()
                                        parts.setup(parts.ptype)
                                        writeGPU()
                                        Dim l As log
                                        l.id = findNextIndex("AllLogs")
                                        l.user = Form1.currentUser
                                        l.action = "Edit"
                                        l.data = g.ID & g.Model & g.Series & g.manufacturer & g.chipManufacturer & g.price
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
    Sub init(g As GPU)
        original = g.ID
        txt_model.Text = g.Model
        txt_baseclock.Text = g.baseClock
        txt_chip.Text = g.chipManufacturer
        txt_manufacturer.Text = g.manufacturer
        txt_power.Text = g.TPD
        txt_price.Text = g.price
        txt_series.Text = g.Series
        txt_VRAM.Text = g.VRAM
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class