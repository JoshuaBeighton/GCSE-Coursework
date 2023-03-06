Public Class AddCPU
    'when the user adds a CPU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
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
                                        Dim c As New CPU
                                        'set the ID equal to the next available CPU ID
                                        c.ID = findNextIndex("CPU")
                                        'add the data from the textboxes to c
                                        c.name = txt_name.Text
                                        c.manufacturer = txt_manufacturer.Text
                                        c.socket = txt_socket.Text
                                        c.cores = txt_cores.Text
                                        c.baseSpeed = txt_basespeed.Text
                                        c.boostSpeed = txt_boostSpeed.Text
                                        c.TPD = txt_power.Text
                                        c.price = txt_price.Text
                                        'add c to the allCPUs list
                                        AllCPUs.Add(c)
                                        'go back to parts
                                        Me.Hide()
                                        parts.Show()
                                        'reset the parts form based on what type it currently on
                                        parts.setup(parts.ptype)
                                        'write the CPUs
                                        FileHandler.writeCPU()
                                        'declare a temporary variable to store the data for the log
                                        Dim l As log
                                        'assign the id of the temporary log item to the next available one
                                        l.id = findNextIndex("AllLogs")
                                        'assign the data to the log
                                        l.user = Form1.currentUser
                                        l.action = "Add"
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
                                    End If
                                    'if the user hasn't entered the boost speed of the CPU
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

    'if the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate to the parts page
        parts.Show()
        Me.Hide()
    End Sub


End Class