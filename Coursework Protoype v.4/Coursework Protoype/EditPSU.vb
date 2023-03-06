﻿Public Class EditPSU
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_manu.Text <> "" Then
            If txt_name.Text <> "" Then
                If txt_effeciency.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_power.Text <> "" Then
                            If ComboBox1.SelectedIndex <> -1 Then
                                Dim p As PSU
                                p.ID = original
                                p.name = txt_name.Text
                                p.manufacturer = txt_manu.Text
                                p.power = txt_power.Text
                                p.efficiency = txt_effeciency.Text
                                p.modular = ComboBox1.SelectedItem
                                p.price = txt_price.Text
                                For i = 0 To AllPSUs.Count - 1
                                    If AllPSUs(i).ID = p.ID Then
                                        AllPSUs(i) = p
                                    End If
                                Next
                                Me.Hide()
                                parts.Show()
                                parts.setup(parts.ptype)
                                writePSU()
                                Dim l As log
                                l.id = findNextIndex("AllLogs")
                                l.user = Form1.currentUser
                                l.action = "Edit"
                                l.data = p.ID & p.name & p.manufacturer & p.price
                                l.time = Now
                                AllLogs.Add(l)
                                writeLogs()
                            Else
                                MsgBox("Please enter the type of modularity")
                            End If
                        Else
                            MsgBox("Please enter the amount of power provided by the PSU")
                        End If
                    Else
                        MsgBox("Please enter the price of the PSU")
                    End If
                Else
                    MsgBox("Please enter the effeciency of the PSU")
                End If
            Else
                MsgBox("Please enter the name of the PSU")
            End If
        Else
            MsgBox("Please enter the manufacturer of the PSU")
        End If
    End Sub
    Sub init(p As PSU)
        original = p.ID
        txt_name.Text = p.name
        txt_manu.Text = p.manufacturer
        txt_effeciency.Text = p.efficiency
        txt_power.Text = p.power
        ComboBox1.SelectedItem = p.modular
        txt_price.Text = p.price
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class