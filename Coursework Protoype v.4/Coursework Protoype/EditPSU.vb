Public Class EditPSU
    'store the ID of the original 
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
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
                                Dim p As PSU
                                'set the id of the PSU to that of the original
                                p.ID = original
                                'set the data of the temporary psu to the data entered by the user
                                p.name = txt_name.Text
                                p.manufacturer = txt_manu.Text
                                p.power = txt_power.Text
                                p.efficiency = txt_effeciency.Text
                                p.modular = ComboBox1.SelectedItem
                                p.price = txt_price.Text
                                'loop through all of the PSUs
                                For i = 0 To AllPSUs.Count - 1
                                    'if we have found the one we are editing
                                    If AllPSUs(i).ID = p.ID Then
                                        'set the original PSU equal to the new one
                                        AllPSUs(i) = p
                                    End If
                                Next
                                'navigate back to the parts page
                                Me.Hide()
                                parts.Show()
                                'set up the parts page again
                                parts.setup(parts.ptype)
                                'write to the PSU file
                                writePSU()
                                'declare a temporary log
                                Dim l As log
                                'set its id to the next available ID
                                l.id = findNextIndex("AllLogs")
                                'set its data to the correct data
                                l.user = Form1.currentUser
                                l.action = "Edit"
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
    'initialise the edit psu form
    Sub init(p As PSU)
        'store the ID of the original PSU data
        original = p.ID
        'set up the text boxes and combo boxes with the data already held
        txt_name.Text = p.name
        txt_manu.Text = p.manufacturer
        txt_effeciency.Text = p.efficiency
        txt_power.Text = p.power
        ComboBox1.SelectedItem = p.modular
        txt_price.Text = p.price
    End Sub
    'when the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate to the parts page
        Me.Hide()
        parts.Show()
    End Sub
End Class