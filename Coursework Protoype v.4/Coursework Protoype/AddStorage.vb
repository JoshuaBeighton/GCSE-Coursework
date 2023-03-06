Public Class AddStorage
    'when the user presses the add button
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'if the user has entered the manufacturer of the storage
        If txt_manufacturer.Text <> "" Then
            'if the user entered the name of the storage
            If txt_name.Text <> "" Then
                'if the user entered the capacity of the storage
                If txt_capacity.Text <> "" Then
                    'if the user entered the price of the storage
                    If txt_price.Text <> "" Then
                        'if the user entered the read speed of the storage
                        If txt_read.Text <> "" Then
                            'if the user entered the write speed of the storage
                            If txt_write.Text <> "" Then
                                'if the user entered the connection type
                                If cmb_connection.SelectedIndex <> -1 Then
                                    'if the user entered the type of storage
                                    If cmb_type.SelectedIndex <> -1 Then
                                        'store a temporary storage item
                                        Dim s As store
                                        'set the id of the temporary storage item to the next available storage ID
                                        s.ID = findNextIndex("Storage")
                                        'set the data of the temporary storage item to that which the user entered
                                        s.name = txt_name.Text
                                        s.manufacturer = txt_manufacturer.Text
                                        s.read = txt_write.Text
                                        s.read = txt_read.Text
                                        s.write = txt_write.Text
                                        s.type = cmb_type.SelectedItem
                                        s.capacity = txt_capacity.Text
                                        s.connection = cmb_connection.SelectedItem
                                        s.price = txt_price.Text
                                        'add the temporary storage item to the list of storage items
                                        AllStorage.Add(s)
                                        'write to the storage file
                                        writeStorage()
                                        'navigate to the parts page
                                        parts.Show()
                                        Me.Hide()
                                        'setup the parts page
                                        parts.setup(parts.ptype)
                                        'store a temporary log item
                                        Dim l As log
                                        'set the id of the log to the next available log id
                                        l.id = findNextIndex("AllLogs")
                                        'set the log data appropriately
                                        l.user = Form1.currentUser
                                        l.action = "Add"
                                        l.data = s.ID & s.name & s.manufacturer & s.price
                                        l.time = Now
                                        'add the temporary log item to the list
                                        AllLogs.Add(l)
                                        'write the log item
                                        writeLogs()
                                        'if the user didnt enter the type of storage device
                                    Else
                                        'ask them to do so
                                        MsgBox("Please enter the type of storage device")
                                    End If
                                    'if the user hasn't entered the connection type of the storage device
                                Else
                                    'ask them to do so
                                    MsgBox("Please enter the connection used by the storage device")
                                End If
                                'if the user didn't enter the write speed of the storage device
                            Else
                                'ask them to do so
                                MsgBox("Please enter the write speed of the storage device")
                            End If
                            'if the user hasn't entered the read speed of the storage device
                        Else
                            'ask them to do so
                            MsgBox("Please enter the read speed of the storage device")
                        End If
                        'if the user hasn't entered the price of the storage device
                    Else
                        'ask them to do so
                        MsgBox("Please enter the price of the storage device")
                    End If
                    'if the user hasn't entered the capacity of the storage device
                Else
                    'ask them to do so
                    MsgBox("Please enter the capacity of the storage device")
                End If
                'if the user hasn't entered the name of the storage device
            Else
                'ask them to do so
                MsgBox("Please enter the name of the storage device")
            End If
            'if the user hasn't entered the manufacturer of the storage device
        Else
            'ask them to do so
            MsgBox("Please enter the manufacturer of the storage device")
        End If

    End Sub
    'when the user clicks the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'go back to the parts page
        parts.Show()
        Me.Hide()
    End Sub

    'when the user selects the type of storage device
    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        'if the user selected a HDD, the connection must be SATA
        If cmb_type.SelectedItem = "HDD" Then
            cmb_connection.SelectedItem = "SATA"
        End If
    End Sub
End Class