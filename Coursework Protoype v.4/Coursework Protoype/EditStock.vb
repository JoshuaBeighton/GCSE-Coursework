Public Class EditStock
    'store the ID of the stock item
    Dim sID As Integer
    'store the ID of anywhere the stock item is used in the orderstock menu
    Dim osID As Integer = -1
    'store the ID of the part used in the stock item
    Dim partID As Integer
    'when the user presses the edit button
    Private Sub btn_EditOrder_Click(sender As Object, e As EventArgs) Handles btn_EditOrder.Click
        'if the user has selected a type
        If cmb_type.SelectedIndex >= 0 Then
            'if the user has selected a part
            If txt_part.Text.Length > 0 Then
                'if the user has entered the price
                If txt_price.Text.Length > 0 Then
                    'declare a new temporary stock item
                    Dim s As New Stock
                    'set its ID to the ID of the stock item we are editing
                    s.ID = AllStock(sID).ID
                    'set its data to that in the textboxes
                    s.ordered = date_ordered.Value
                    s.Due = date_due.Value
                    s.cost = Convert.ToInt32(txt_price.Text)
                    s.arrived = chk_arrived.Checked
                    s.type = cmb_type.Text
                    s.part = partID
                    'loop through the stock items
                    For i = 0 To AllStock.Count
                        'if we have found the correct stock item
                        If AllStock(i).ID = sID Then
                            'set the stock item equal to the temporary one storing the user-entered data
                            AllStock(i) = s
                        End If
                    Next

                    'clear the user entry tools
                    txt_part.Clear()
                    txt_price.Clear()
                    chk_arrived.Checked = False
                    cmb_type.SelectedIndex = -1
                    cmb_type.Text = ""



                    'if the part is being used in an order
                    If osID <> -1 Then
                        'store a new orderstock item
                        Dim os As orderStock = AllOrderStock(osID)
                        'set the ID of the stock item equal to the new stock item id
                        os.stock = s.ID
                        'store the orderstock item
                        AllOrderStock(osID) = os
                    End If
                    'set the ID of the log to the next available log id
                    Dim l As log
                    'set the data of the log according to the data it should have
                    l.id = findNextIndex("AllLogs")
                    l.user = Form1.currentUser
                    l.action = "Edit"
                    l.data = s.ID & s.part & s.cost
                    l.time = Now
                    'add the temporary log to the list
                    AllLogs.Add(l)
                    'write to the log file
                    writeLogs()
                    'if the user hasn't entered the price
                Else
                    'ask them to do so
                    MsgBox("Please Enter a Price")
                End If
                'if the user hasn't entered a part
            Else
                'ask them to do so
                MsgBox("Please Enter a Part")
            End If
            'if the user hasn't entered a type
        Else
            'ask them to do so
            MsgBox("Please Select A Type")
        End If
        'write to the stock file
        writeStockFile()
        'navigate back to the see stock page
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
    End Sub
    'when the user clicks the back button
    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        'navigate back to see stock
        Me.Close()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
    End Sub

    'initialise the edit stock page
    Public Sub initialiseEditStock(id As Integer)
        'loop through all of the stock file and if we find the item who's ID matches the one of the stock we are tyring to edit
        For i = 0 To AllStock.Count - 1
            If AllStock(i).ID = id Then
                'store it in the sID variable
                sID = i
            End If
        Next
        'loop through the orderstock file and if the stock id of the item matches that of the stock id in the orderstock file
        For i = 0 To AllOrderStock.Count - 1
            If AllOrderStock(i).stock = sID Then
                'store the ID of the orderstock object
                osID = i
            End If
        Next
        'loop through the stock file
        For i = 0 To AllStock.Count - 1
            'if the id of the current stock item matches the index of the loop
            If AllStock(i).ID = i Then
                'set the text boxes, combo boxes and date boxes up with the data from that index of the stock file
                txt_part.Text = AllStock(i).part
                txt_price.Text = AllStock(i).cost
                Try
                    date_due.Value = AllStock(i).Due.Date
                    date_ordered.Value = AllStock(i).ordered.Date
                Catch
                End Try
                chk_arrived.Checked = AllStock(i).arrived
                cmb_type.SelectedItem = AllStock(i).type
                partID = AllStock(i).part
            End If
        Next

    End Sub

    'if the user presses the part button
    Private Sub btn_part_Click(sender As Object, e As EventArgs) Handles btn_part.Click
        'if the user has selected a type
        If cmb_type.SelectedIndex <> -1 Then
            'navigate to the parts page and set it up
            parts.Show()
            Me.Hide()
            parts.setup(cmb_type.SelectedItem)
            'store that we are trying to select an item and on selecting an item it should return to the edit stock page not the add stock page
            parts.selecting = True
            parts.editing = True
        End If
    End Sub
    'on returning from the parts page
    Public Sub onreturn(index As Integer)
        'store the part id
        partID = index
        'do different things based on the type of part from the combobox
        Select Case cmb_type.SelectedItem
            'if we're waiting for a CPU
            Case "CPU"
                'loop through the CPU list
                For i = 0 To AllCPUs.Count - 1
                    'if we find the right CPU
                    If index = AllCPUs(i).ID Then
                        'set the textboxes accordingly
                        txt_part.Text = AllCPUs(i).name
                        txt_price.Text = AllCPUs(i).price
                    End If
                Next
                'if we're waiting for a CPU
            Case "GPU"
                'loop through the GPU list
                For i = 0 To AllGPUs.Count - 1
                    'if we find the right GPU
                    If index = AllGPUs(i).ID Then
                        'set the textboxes accordingly
                        txt_part.Text = AllGPUs(i).Series
                        txt_price.Text = AllGPUs(i).price
                    End If
                Next
            Case "RAM"
                'loop through the RAM list
                For i = 0 To AllRAMs.Count - 1
                    'if we find the right RAM
                    If index = AllRAMs(i).ID Then
                        'set the textboxes accordingly
                        txt_part.Text = AllRAMs(i).name
                        txt_price.Text = AllRAMs(i).price
                    End If
                Next
            Case "PSU"
                'loop through the PSU list
                For i = 0 To AllPSUs.Count - 1
                    'if we find the right PSU
                    If index = AllPSUs(i).ID Then
                        'set the textboxes accordingly
                        txt_part.Text = AllPSUs(i).name
                        txt_price.Text = AllPSUs(i).price
                    End If
                Next
            Case "Motherboard"
                'loop through the motherboard list
                For i = 0 To AllMoba.Count - 1
                    'if we find the right Motherboard
                    If index = AllMoba(i).id Then
                        'set the textboxes accordingly
                        txt_part.Text = AllMoba(i).name
                        txt_price.Text = AllMoba(i).price
                    End If
                Next
            Case "Storage"
                'loop through the storage list
                For i = 0 To AllStorage.Count - 1
                    'if we find the right Storage
                    If index = AllStorage(i).ID Then
                        'set the textboxes accordingly
                        txt_part.Text = AllStorage(i).name
                        txt_price.Text = AllStorage(i).price
                    End If
                Next
            Case "Case"
                'loop through the case list
                For i = 0 To AllCases.Count - 1
                    'if we find the right case
                    If index = AllCases(i).id Then
                        'set the textboxes accordingly
                        txt_part.Text = AllCases(i).name
                        txt_price.Text = AllCases(i).price
                    End If
                Next
        End Select
        'hide the button to pick a part and show the text box that allows you to
        btn_part.Hide()
        txt_part.Show()
    End Sub
End Class