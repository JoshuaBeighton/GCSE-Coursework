Public Class EditStorage
    'store the original ID of the storage item
    Dim original As Integer
    'when the user presses the edit button
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
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
                                        'set the ID of the temporary storage item to that of the storage item we are trying to edit
                                        s.ID = original
                                        'set the id of the temporary storage item to the next available storage ID
                                        s.name = txt_name.Text
                                        s.manufacturer = txt_manufacturer.Text
                                        s.capacity = txt_capacity.Text
                                        s.read = txt_read.Text
                                        s.write = txt_write.Text
                                        s.connection = cmb_connection.SelectedItem
                                        s.type = cmb_type.SelectedItem
                                        s.price = txt_price.Text
                                        'loop through the storage devices
                                        For i = 0 To AllStorage.Count - 1
                                            'If the current one If the one we are trying To edit
                                            If AllStorage(i).ID = s.ID Then
                                                'set it equal to the temporary item with the data provided by the user
                                                AllStorage(i) = s
                                            End If
                                        Next
                                        'navigate back to the parts page
                                        Me.Hide()
                                        parts.Show()
                                        'set up the parts page
                                        parts.setup(parts.ptype)
                                        'write the storage file
                                        writeStorage()
                                        'store a temporary log item
                                        Dim l As log
                                        'set the id of the log to the next available log id
                                        l.id = findNextIndex("AllLogs")
                                        'set the log data appropriately
                                        l.user = Form1.currentUser
                                        l.action = "Edit"
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
    'initialise the storage page
    Sub init(s As store)
        'store the ID of the storage item we are editing
        original = s.ID
        'set the text boxes and combo boxes up with the data storage about the part already
        txt_name.Text = s.name
        txt_manufacturer.Text = s.manufacturer
        txt_capacity.Text = s.capacity
        txt_read.Text = s.read
        txt_write.Text = s.write
        cmb_connection.SelectedItem = s.connection
        cmb_type.SelectedItem = s.type
        txt_price.Text = s.price
    End Sub
    'when the user presses the back button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate back to the parts page
        Me.Hide()
        parts.Show()
    End Sub
End Class