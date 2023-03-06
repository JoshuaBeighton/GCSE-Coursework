Public Class EditMotherboard
    'store the ID of the motherboard we are editing
    Dim original As Integer
    'when the user presses the edit button
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
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
                                    'set the ID as the ID of the item we are editing
                                    m.id = original
                                    'set the motherboard data to the data entered by the user
                                    m.name = txt_name.Text
                                    m.manufacturer = txt_manufacturer.Text
                                    m.SATAs = txt_SATA.Text
                                    m.m2s = txt_m2.Text
                                    m.socket = txt_socket.Text
                                    m.ramSlots = txt_ram.Text
                                    m.price = txt_price.Text
                                    'loop through the motherboard items
                                    For i = 0 To AllMoba.Count - 1
                                        'if we find the one we are editing
                                        If AllMoba(i).id = m.id Then
                                            'set the motherboard that we are editing to the temporary motherboard
                                            AllMoba(i) = m
                                        End If
                                    Next
                                    'navigate back to the parts page
                                    Me.Hide()
                                    parts.Show()
                                    'set up the parts page
                                    parts.setup(parts.ptype)
                                    'write the motherboard file
                                    writeMoba()
                                    'declare a temporary log item
                                    Dim l As log
                                    'set the id of the log to the next available log id
                                    l.id = findNextIndex("AllLogs")
                                    'set the log data to the relevant data
                                    l.user = Form1.currentUser
                                    l.action = "Edit"
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
    'initialise the textboxes
    Sub init(m As motherboard)
        'set the ID we store to the ID of the part we are editing
        original = m.id
        'set the text boxes up
        txt_name.Text = m.name
        txt_manufacturer.Text = m.manufacturer
        txt_m2.Text = m.m2s
        txt_ram.Text = m.ramSlots
        txt_SATA.Text = m.SATAs
        txt_socket.Text = m.socket
        txt_price.Text = m.price
    End Sub

    'when the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate back to the parts page
        Me.Hide()
        parts.Show()
    End Sub
End Class