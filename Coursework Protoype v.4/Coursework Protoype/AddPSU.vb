Public Class AddPSU
    'when the user presses the add button
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'the the user has entered the manufacturer of the psu
        If txt_manu.Text <> "" Then
            'if the user has entered the name of the psu
            If txt_name.Text <> "" Then
                'if the user has entered the efficiency of the psu
                If txt_effeciency.Text <> "" Then
                    'if the user has entered the price of the psu
                    If txt_price.Text <> "" Then
                        'if the user has entered the power of the psu
                        If txt_power.Text <> "" Then
                            'if the user has entered the modularity of the psu
                            If ComboBox1.SelectedIndex <> -1 Then
                                'store a temporary PSU
                                Dim p As New PSU
                                'set it's ID to the next available psu ID
                                p.ID = findNextIndex("PSU")
                                'set the data of the temporary psu to the data entered by the user
                                p.name = txt_name.Text
                                p.efficiency = txt_effeciency.Text
                                p.modular = ComboBox1.SelectedText
                                p.manufacturer = txt_manu.Text
                                p.power = txt_power.Text
                                p.price = txt_price.Text
                                'add the temporary PSU to the list of psus
                                AllPSUs.Add(p)
                                'write to the psu file
                                writePSU()
                                'navigate back to the parts page
                                parts.Show()
                                Me.Hide()
                                'setup the parts page
                                parts.setup(parts.ptype)
                                'declare a temporary log
                                Dim l As log
                                'set its id to the next available ID
                                l.id = findNextIndex("AllLogs")
                                'set its data to the correct data
                                l.user = Form1.currentUser
                                l.action = "Add"
                                l.data = p.ID & p.name & p.manufacturer & p.price
                                l.time = Now
                                'add the log to the list of logs
                                AllLogs.Add(l)
                                'write to the log file
                                writeLogs()
                                'if the user hasn't entered the type of modularity
                            Else
                                'ask them to do so
                                MsgBox("Please enter the type of modularity")
                            End If
                            'if the user hasnt entered the amount of power from the PSU
                        Else
                            'ask them to do so
                            MsgBox("Please enter the amount of power provided by the PSU")
                        End If
                        'if the user hasn't entered the price of the PSU
                    Else
                        'ask them to do so
                        MsgBox("Please enter the price of the PSU")
                    End If
                    'if the user hasn't entered the effeciency of the PSU
                Else
                    'ask them to do so
                    MsgBox("Please enter the effeciency of the PSU")
                End If
                'if the user hasn't entered the name of the psu
            Else
                'ask them to do so
                MsgBox("Please enter the name of the PSU")
            End If
            'if the user hasn't entered the manufacturer of the psu
        Else
            'ask them to do so
            MsgBox("Please enter the manufacturer of the PSU")
        End If

    End Sub
    'if the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate to the parts page
        parts.Show()
        Me.Hide()
    End Sub
End Class