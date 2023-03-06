Public Class AddMoba
    'if the user presses the add button
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'if the user has entered the manufacturer
        If txt_manufacturer.Text <> "" Then
            'if the user has entered the name of the motherboard
            If txt_name.Text <> "" Then
                'if the user has entered how many m.2 slots are on the motherboard
                If txt_m2.Text <> "" Then
                    'if the user has entered the price of the motherboard
                    If txt_price.Text <> "" Then
                        'if the user has entered the amount of RAM slots in the motherboard
                        If txt_ram.Text <> "" Then
                            'if the user has entered how many SATA ports are on the motherboard
                            If txt_SATA.Text <> "" Then
                                'if the user has entered the socket on the motherboard
                                If txt_socket.Text <> "" Then
                                    'store a temporary motherboard item
                                    Dim m As motherboard
                                    'set the ID to the next available motherboard id
                                    m.id = findNextIndex("Motherboard")
                                    'set the motherboard data to the data entered by the user
                                    m.name = txt_name.Text
                                    m.manufacturer = txt_manufacturer.Text
                                    m.ramSlots = txt_ram.Text
                                    m.socket = txt_socket.Text
                                    m.SATAs = txt_SATA.Text
                                    m.m2s = txt_m2.Text
                                    m.price = txt_price.Text
                                    'add the temporary motherboard item to the list
                                    AllMoba.Add(m)
                                    'write the motherboard file
                                    writeMoba()
                                    'navigate back to the parts page
                                    parts.Show()
                                    Me.Hide()
                                    'set up the parts page
                                    parts.setup(parts.ptype)
                                    'declare a temporary log item
                                    Dim l As log
                                    'set the id of the log to the next available log id
                                    l.id = findNextIndex("AllLogs")
                                    'set the log data to the relevant data
                                    l.user = Form1.currentUser
                                    l.action = "Add"
                                    l.data = m.id & m.name & m.manufacturer & m.price
                                    l.time = Now
                                    'add the temporary log to the list of logs
                                    AllLogs.Add(l)
                                    'write the logs file
                                    writeLogs()
                                    'if the user hasnt entered the socket
                                Else
                                    'ask them to
                                    MsgBox("Please enter the socket of the motherboard")
                                End If
                                'if the user hasn't entered the amount of sata ports on the motherboard
                            Else
                                'ask them to
                                MsgBox("Please enter the amount of SATA ports on the motherboard")
                            End If
                            'if the user hasn't entered the amount of RAM slots
                        Else
                            'ask them to
                            MsgBox("Please enter the amount of RAM slots on the motherboard")
                        End If
                        'if the user hasn't entered the price of the motherboard
                    Else
                        'ask them to
                        MsgBox("Please enter the price of the motherboard")
                    End If
                    'if the user hasnt entered the amount of m.2 ports on the motherboard
                Else
                    'ask them to
                    MsgBox("Please enter the amount of m.2 slots in the motherboard")
                End If
                'if the user hasn't entered the name of the motherboard
            Else
                'ask them to
                MsgBox("Please enter the name of the motherboard")
            End If
            'if the user hasnt entered the manufacturer of the motherboard
        Else
            'ask them to
            MsgBox("Please enter the manufacturer of the motherboard")
        End If
    End Sub
    'if the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'naviagate back to the parts page
        parts.Show()
        Me.Hide()
    End Sub
End Class