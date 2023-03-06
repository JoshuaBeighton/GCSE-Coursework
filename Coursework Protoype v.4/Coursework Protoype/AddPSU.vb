Public Class AddPSU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_manu.Text <> "" Then
            If txt_name.Text <> "" Then
                If txt_effeciency.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_power.Text <> "" Then
                            If ComboBox1.SelectedIndex <> -1 Then
                                Dim p As New PSU
                                p.ID = AllPSUs.Count
                                p.name = txt_name.Text
                                p.efficiency = txt_effeciency.Text
                                p.modular = ComboBox1.SelectedText
                                p.manufacturer = txt_manu.Text
                                p.power = txt_power.Text
                                p.price = txt_price.Text
                                AllPSUs.Add(p)
                                writePSU()
                                parts.Show()
                                Me.Hide()
                                parts.setup(parts.ptype)
                                Dim l As log
                                l.id = findNextIndex("AllLogs")
                                l.user = Form1.currentUser
                                l.action = "Add"
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

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class