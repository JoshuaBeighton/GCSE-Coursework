Public Class EditStorage
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_manufacturer.Text <> "" Then
            If txt_name.Text <> "" Then
                If txt_capacity.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_read.Text <> "" Then
                            If txt_write.Text <> "" Then
                                If cmb_connection.SelectedIndex <> -1 Then
                                    If cmb_type.SelectedIndex <> -1 Then
                                        Dim s As store
                                        s.ID = original
                                        s.name = txt_name.Text
                                        s.manufacturer = txt_manufacturer.Text
                                        s.capacity = txt_capacity.Text
                                        s.read = txt_read.Text
                                        s.write = txt_write.Text
                                        s.connection = cmb_connection.SelectedItem
                                        s.type = cmb_type.SelectedItem
                                        s.price = txt_price.Text
                                        For i = 0 To AllStorage.Count - 1
                                            If AllStorage(i).ID = s.ID Then
                                                AllStorage(i) = s
                                            End If
                                        Next
                                        Me.Hide()
                                        parts.Show()
                                        parts.setup(parts.ptype)
                                        writeStorage()
                                        Dim l As log
                                        l.id = findNextIndex("AllLogs")
                                        l.user = Form1.currentUser
                                        l.action = "Edit"
                                        l.data = s.ID & s.name & s.manufacturer & s.price
                                        l.time = Now
                                        AllLogs.Add(l)
                                        writeLogs()
                                    Else
                                        MsgBox("Please enter the type of storage device")
                                    End If
                                Else
                                    MsgBox("Please enter the connection used by the storage device")
                                End If
                            Else
                                MsgBox("Please enter the write speed of the storage device")
                            End If
                        Else
                            MsgBox("Please enter the read speed of the storage device")
                        End If
                    Else
                        MsgBox("Please enter the price of the storage device")
                    End If
                Else
                    MsgBox("Please enter the capacity of the storage device")
                End If
            Else
                MsgBox("Please enter the name of the storage device")
            End If
        Else
            MsgBox("Please enter the manufacturer of the storage device")
        End If
    End Sub
    Sub init(s As store)
        original = s.ID
        txt_name.Text = s.name
        txt_manufacturer.Text = s.manufacturer
        txt_capacity.Text = s.capacity
        txt_read.Text = s.read
        txt_write.Text = s.write
        cmb_connection.SelectedItem = s.connection
        cmb_type.SelectedItem = s.type
        txt_price.Text = s.price
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class