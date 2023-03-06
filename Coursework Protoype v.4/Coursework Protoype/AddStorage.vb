Public Class AddStorage
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_manufacturer.Text <> "" Then
            If txt_name.Text <> "" Then
                If txt_capacity.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_read.Text <> "" Then
                            If txt_write.Text <> "" Then
                                If cmb_connection.SelectedIndex <> -1 Then
                                    If cmb_type.SelectedIndex <> -1 Then
                                        Dim s As store
                                        s.ID = AllStorage.Count
                                        s.name = txt_name.Text
                                        s.manufacturer = txt_manufacturer.Text
                                        s.read = txt_write.Text
                                        s.read = txt_read.Text
                                        s.write = txt_write.Text

                                        s.type = cmb_type.SelectedItem
                                        s.capacity = txt_capacity.Text
                                        s.connection = cmb_connection.SelectedItem
                                        s.price = txt_price.Text
                                        AllStorage.Add(s)
                                        writeStorage()
                                        parts.Show()
                                        Me.Hide()
                                        parts.setup(parts.ptype)
                                        Dim l As log
                                        l.id = findNextIndex("AllLogs")
                                        l.user = Form1.currentUser
                                        l.action = "Add"
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

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
        parts.setup(parts.ptype)
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        If cmb_type.SelectedItem = "HDD" Then
            cmb_connection.SelectedItem = "SATA"
        End If
    End Sub
End Class