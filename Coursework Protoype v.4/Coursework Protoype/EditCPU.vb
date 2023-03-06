Public Class EditCPU
    'store the original ID of the CPU
    Dim original As Integer
    'when the user edits a CPU
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        'if the user has entered the name
        If txt_name.Text <> "" Then
            'if the user has entered the manufacturer
            If txt_manufacturer.Text <> "" Then
                'if the user has entered the socket
                If txt_socket.Text <> "" Then
                    'if the user has entered the price
                    If txt_price.Text <> "" Then
                        'if the user has entered the power consumption of the cpu
                        If txt_power.Text <> "" Then
                            'if the user has entered the amount of cores in the CPU
                            If txt_cores.Text <> "" Then
                                'if the user has entered the boost speed of the CPU
                                If txt_boostSpeed.Text <> "" Then
                                    'if the user has entered the base speed of the CPU
                                    If txt_basespeed.Text <> "" Then
                                        'temporary CPU item to store the data entered
                                        Dim c As CPU
                                        'set C's ID to the same ID as the CPU we are editing
                                        c.id = original
                                        'add the data from the textboxes to c
                                        c.name = txt_name.Text
                                        c.manufacturer = txt_manufacturer.Text
                                        c.baseSpeed = txt_basespeed.Text
                                        c.TPD = txt_power.Text
                                        c.socket = txt_socket.Text
                                        c.boostSpeed = txt_boostSpeed.Text
                                        c.cores = txt_cores.Text
                                        c.price = txt_price.Text
                                        'loop through the CPUs
                                        For i = 0 To AllCPUs.Count - 1
                                            'if the id of the CPU matches
                                            If AllCPUs(i).ID = c.ID Then
                                                'set the CPU equal to the edited CPU
                                                AllCPUs(i) = c
                                            End If
                                        Next
                                        'naviagate back to the parts page and set it up
                                        Me.Hide()
                                        parts.Show()
                                        parts.setup(parts.ptype)
                                        'write the CPUs
                                        writeCPU()
                                        'declare a temporary variable to store the data for the log
                                        Dim l As log
                                        'assign the id of the temporary log item to the next available one
                                        l.id = findNextIndex("AllLogs")
                                        'assign the data to the log
                                        l.user = Form1.currentUser
                                        l.action = "Edit"
                                        l.data = c.ID & c.name & c.manufacturer & c.price
                                        l.time = Now
                                        'add the temporary log to the list of logs
                                        AllLogs.Add(l)
                                        'write the log file
                                        writeLogs()
                                        'if the user didnt enter the base speed of the CPU
                                    Else
                                        'ask them to
                                        MsgBox("Please enter the base speed of the CPU")
                                        'if the user hasn't entered the boost speed of the CPU
                                    End If
                                Else
                                    'ask them to
                                    MsgBox("Please enter the boost speed of the CPU")
                                End If
                                'if the user hasn't entered the amount of cores in the cpu
                            Else
                                'ask them to
                                MsgBox("Please enter the amount of cores in the CPU")
                            End If
                            'if the user hasn't entered the power draw of the cpu
                        Else
                            'ask them to
                            MsgBox("Please enter the power draw of the CPU")
                        End If
                        'if the user hasn't entered the price
                    Else
                        'ask them to
                        MsgBox("Please enter the price of the CPU")
                    End If
                    'if the user hasn't entered the socket of the CPU
                Else
                    'ask them to
                    MsgBox("Please enter the socket of the CPU")
                End If
                'if the user hasn't entered the manufacturer
            Else
                'ask them to
                MsgBox("Please enter the manufacturer of the CPU")
            End If
            'if the user hasn't entered the name
        Else
            'ask them to
            MsgBox("Please enter the name of the CPU")
        End If
    End Sub

    'initialise the CPU
    Sub init(c As CPU)
        'store the ID of the CPU we are editing
        original = c.ID
        'show the data of the CPU
        txt_name.Text = c.name
        txt_manufacturer.Text = c.manufacturer
        txt_basespeed.Text = c.baseSpeed
        txt_boostSpeed.Text = c.boostSpeed
        txt_cores.Text = c.cores
        txt_power.Text = c.TPD
        txt_socket.Text = c.socket
        txt_price.Text = c.price
    End Sub

    'if the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate to the parts page
        Me.Hide()
        parts.Show()
    End Sub

End Class