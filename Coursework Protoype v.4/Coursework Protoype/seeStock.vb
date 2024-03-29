﻿Imports System.Windows.Forms.Design

Public Class seeStock
    'open the form to write stock items
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteStock.Show()
        'if we are trying to select an item, let the write stock form know so it goes straight back to the write page
        If selecting Then
            WriteStock.selectInit(Write.type)
        Else
            WriteStock.init()
        End If
        Me.Close()
    End Sub

    'go back
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'if we are trying to select an item, return to the write page
        If selecting Then
            Write.Show()
        Else
            'otherwise go back to the navigation page
            Navigation.Show()
        End If

        Me.Close()
    End Sub

    'initialise the appearance and data of the form
    Public Sub InitialiseSeeStock()
        'store all of the listviewitems to go in to the list view
        Dim l As New List(Of ListViewItem)
        'add all of the relavant columns to the list view
        ListView1.Columns.Add("ID", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("Type", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Part", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Ordered", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Due", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Arrived", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("Cost", ListView1.Width - 20 - 150 - 100 - 200 - 200 - 70, HorizontalAlignment.Left)
        'make sure there are no items in the listview
        ListView1.Items.Clear()
        'store a temporary listviewitem
        Dim tempL As ListViewItem
        'loop through all of the stock items
        For i = 0 To AllStock.Count - 1
            'if the stock item hasnt been deleted
            If AllStock(i).ID >= 0 Then
                'reset templ
                tempL = New ListViewItem
                'add all of the necessary subitems
                tempL.SubItems(0).Text = (AllStock(i).ID)
                tempL.SubItems.Add(AllStock(i).type)
                'depending on the type of stock item
                Select Case AllStock(i).type
                    'if its a CPU
                    Case "CPU"
                        'loop through all of the CPUs
                        For j = 0 To AllCPUs.Count - 1
                            'if we find the correct part
                            If AllCPUs(j).ID = AllStock(i).part Then
                                'add the correct part name to the temporary listviewitem
                                tempL.SubItems.Add(AllCPUs(j).name)
                            End If
                        Next
                    'if its a GPU
                    Case "GPU"
                        'loop through all of the GPUs
                        For j = 0 To AllGPUs.Count - 1
                            'if we find the correct part
                            If AllGPUs(j).ID = AllStock(i).part Then
                                'add the correct part name to the temporary listviewitem
                                tempL.SubItems.Add(AllGPUs(j).Series & " " & AllGPUs(j).Model)
                            End If
                        Next
                    'if its a PSU
                    Case "PSU"
                        'loop through all of the PSUs
                        For j = 0 To AllPSUs.Count - 1
                            'if we find the correct part
                            If AllPSUs(j).ID = AllStock(i).part Then
                                'add the correct part name to the temporary listviewitem
                                tempL.SubItems.Add(AllPSUs(j).name & " " & AllPSUs(j).power & "W")
                            End If
                        Next
                    'if its a Motherboard
                    Case "Motherboard"
                        'loop through all of the motherboards
                        For j = 0 To AllMoba.Count - 1
                            'if we find the correct part
                            If AllMoba(j).id = AllStock(i).part Then
                                'add the correct part name to the temporary listviewitem
                                tempL.SubItems.Add(AllMoba(j).name)
                            End If
                        Next
                    'if its storage
                    Case "Storage"
                        'loop through all of the storage
                        For j = 0 To AllStorage.Count - 1
                            'if we find the correct part
                            If AllStorage(j).ID = AllStock(i).part Then
                                'add the correct part name to the temporary listviewitem
                                tempL.SubItems.Add(AllStorage(j).name & " " & AllStorage(j).capacity & "GB " & AllStorage(j).type)
                            End If
                        Next
                    'if its RAM
                    Case "RAM"
                        'loop through all of the RAM
                        For j = 0 To AllRAMs.Count - 1
                            'if we find the correct part
                            If AllRAMs(j).ID = AllStock(i).part Then
                                'add the correct part name to the temporary listviewitem
                                tempL.SubItems.Add(AllRAMs(j).name & " " & AllRAMs(j).capacity & "GB " & AllRAMs(j).speed & "MHz")
                            End If
                        Next
                    'if its a case
                    Case "Case"
                        'loop through all of the cases
                        For j = 0 To AllCases.Count - 1
                            'if we find the correct part
                            If AllCases(j).id = AllStock(i).part Then
                                'add the correct part name to the temporary listviewitem
                                tempL.SubItems.Add(AllCases(j).name)
                            End If
                        Next
                End Select
                'add the stock data to the listviewitem
                tempL.SubItems.Add(AllStock(i).ordered)
                tempL.SubItems.Add(AllStock(i).Due)
                tempL.SubItems.Add(AllStock(i).arrived)
                tempL.SubItems.Add(AllStock(i).cost)
                'add the temporary listitem to the whole list
                l.Add(tempL)
            End If
        Next

        'add all of the listviewitems to the listview
        ListView1.Items.AddRange(l.ToArray)
        'populate the comboboxes for type and part
        typePopulate()
        partPopulate()

        'if there is more than one item in the listbox
        If ListView1.Items.Count > 0 Then
            'temporary value to store the price of the current stock item
            Dim val As Integer = ListView1.Items(0).SubItems(6).Text
            'store the maximum value found so far
            Dim max As Integer = val
            'store the minimum value found so far
            Dim min As Integer = val

            'loop through all of the listview items
            For i = 0 To ListView1.Items.Count - 1
                'set val equal to the current listviewitem
                val = ListView1.Items(i).SubItems(6).Text
                'if val is bigger than the max found so far, set max to the current item
                If val > max Then
                    max = val
                End If

                'if val is smaller than the smallest found so far, then set min to val
                If val < min Then
                    min = val
                End If
            Next

            'set the values of the trackbars and labels based on the min and max vals found
            trk_max.Maximum = max
            trk_max.Minimum = min
            trk_min.Maximum = max
            trk_min.Minimum = min
            trk_min.Value = min
            trk_max.Value = max
            lbl_max.Text = max
            lbl_min.Text = min
            'if there are no values present
        Else
            'set the max values of the trackbars to 100 and the mins to 0
            trk_max.Maximum = 100
            trk_min.Maximum = 100
            trk_max.Minimum = 0
            trk_min.Minimum = 0
        End If
        'set the labels that denote the current value of the slider to the sliders' positions
        Label2.Text = "Min: " & trk_min.Value
        Label3.Text = "Max: " & trk_max.Value
    End Sub

    'when the form is shown, initialise
    Public Sub seeStock_Shown() Handles MyBase.Shown
        InitialiseSeeStock()
        If selecting Then
            selectInit(Write.type)
        End If
    End Sub

    'store all of the items removed in
    Dim removed As New List(Of ListViewItem)

    'filter based on what part the user has selected
    Sub filterPart(part As String)
        'store all of the values that fit the criteria
        Dim newList As New List(Of ListViewItem)
        'loop through the listview items
        For i = 0 To ListView1.Items.Count - 1
            'if the current listview item doent fit the criteria, add it to the list of removed items
            If ListView1.Items(i).SubItems(2).Text <> part Then
                removed.Add(ListView1.Items(i))
                'otherwise add it to the values to keep
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        'clear all the items in the listview, then add only the ones that should be there
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
        selecting = False
    End Sub
    Sub filterType(type As String)

        'store all of the values that fit the criteria
        Dim newList As New List(Of ListViewItem)
        'loop through the listview items
        For i = 0 To ListView1.Items.Count - 1
            'if the current listview item doent fit the criteria, add it to the list of removed items
            If ListView1.Items(i).SubItems(1).Text <> type Then
                removed.Add(ListView1.Items(i))

            Else
                'otherwise add it to the values to keep
                newList.Add(ListView1.Items(i))
            End If
        Next
        'clear all the items in the listview, then add only the ones that should be there
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub
    Sub filterArrived()
        'store all of the values that fit the criteria
        Dim newList As New List(Of ListViewItem)
        'loop through the listview items
        For i = 0 To ListView1.Items.Count - 1
            'if the current listview item doent fit the criteria, add it to the list of removed items
            If ListView1.Items(i).SubItems(5).Text <> cmb_arrived.SelectedItem Then
                removed.Add(ListView1.Items(i))
            Else
                'otherwise add it to the values to keep
                newList.Add(ListView1.Items(i))
            End If
        Next
        'clear all the items in the listview, then add only the ones that should be there
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub


    Sub filterOrdered(mode As String)
        'store all of the values that fit the criteria
        Dim newList As New List(Of ListViewItem)
        'if filtering by choosing a date before a certain date
        If mode = "Before" Then
            'For j = 0 To ListView1.Items.Count - 1
            'loop through the listview items
            For i = 0 To ListView1.Items.Count - 1
                'if the current listview item doent fit the criteria, add it to the list of removed items
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(3).Text).Date > DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                    'otherwise add it to the values to keep
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
            'if filtering by choosing a date after a certain date
        ElseIf mode = "After" Then
            ''For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            'loop through the listview items
            For i = 0 To ListView1.Items.Count - 1
                'if the current listview item doent fit the criteria, add it to the list of removed items
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(3).Text).Date < DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                    'otherwise add it to the values to keep
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
            'if filtering by choosing an order on a certain date
        ElseIf mode = "On" Then
            'For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            'loop through the listview items
            For i = 0 To ListView1.Items.Count - 1
                'if the current listview item doent fit the criteria, add it to the list of removed items
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(3).Text).Date <> DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                    'otherwise add it to the values to keep
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        End If
        'clear all the items in the listview, then add only the ones that should be there
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())

    End Sub

    Sub filterDue(mode As String)
        'store all of the values that fit the criteria
        Dim newList As New List(Of ListViewItem)
        'if filtering by choosing a date before a certain date
        If mode = "Before" Then
            'For j = 0 To ListView1.Items.Count - 1
            'loop through the listview items
            For i = 0 To ListView1.Items.Count - 1
                'if the current listview item doent fit the criteria, add it to the list of removed items
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(4).Text).Date > DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                    'otherwise add it to the values to keep
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
            'if filtering by choosing a date after a certain date
        ElseIf mode = "After" Then
            ''For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            'loop through the listview items
            For i = 0 To ListView1.Items.Count - 1
                'if the current listview item doent fit the criteria, add it to the list of removed items
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(4).Text).Date < DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    'otherwise add it to the values to keep
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
            'if filtering by choosing an order on a certain date
        ElseIf mode = "On" Then
            'For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            'loop through the listview items
            For i = 0 To ListView1.Items.Count - 1
                'if the current listview item doent fit the criteria, add it to the list of removed items
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(4).Text).Date <> DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    'otherwise add it to the values to keep
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        End If
        'clear all the items in the listview, then add only the ones that should be there
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())

    End Sub



    'populate combo boxes
    Sub typePopulate()
        'clear all of the items in the combo box
        cmb_type.Items.Clear()
        'list to store all of the different values found
        Dim vals As New List(Of String)
        'temporary value to store whether the current value has already been found
        Dim found As Boolean
        'loop through the list view item
        For i = 0 To ListView1.Items.Count - 1
            'reset the found boolean
            found = False
            'loop through all of the found values
            For j = 0 To vals.Count - 1
                'if the current item has already been found, mark it as such
                If vals(j) = ListView1.Items(i).SubItems(1).Text Then
                    found = True
                End If
            Next
            'if the current values isn't already in the array, add it in
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(1).Text)
            End If
        Next
        'add all of the unique values to the combo box
        cmb_type.Items.AddRange(vals.ToArray)
    End Sub

    Sub partPopulate()
        'clear all of the items in the combo box
        cmb_part.Items.Clear()
        'list to store all of the different values found
        Dim vals As New List(Of String)
        'temporary value to store whether the current value has already been found
        Dim found As Boolean
        'loop through the list view item
        For i = 0 To ListView1.Items.Count - 1
            'reset the found boolean
            found = False
            'loop through all of the found values
            For j = 0 To vals.Count - 1
                'if the current item has already been found, mark it as such
                If vals(j) = ListView1.Items(i).SubItems(2).Text Then
                    found = True
                End If
            Next
            'if the current values isn't already in the array, add it in
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(2).Text)
            End If
        Next
        'add all of the unique values to the combo box
        cmb_part.Items.AddRange(vals.ToArray)
    End Sub



    'clear filters
    Private Sub clearfilter_click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        'ListView1.Items.AddRange(removed.ToArray())
        'removed.Clear()
        'reset the UI items
        cmb_arrived.SelectedIndex = -1
        cmb_arrived.Text = "Not Filtered"
        cmb_arrived.Enabled = True
        cmb_part.SelectedIndex = -1
        cmb_part.Text = "Part"
        cmb_part.Enabled = True

        cmb_type.SelectedIndex = -1
        cmb_type.Text = "Type"
        cmb_type.Enabled = True

        cmb_due.SelectedIndex = -1
        cmb_due.Text = "RAM"
        cmb_due.Enabled = True

        cmb_ordered.SelectedIndex = -1
        cmb_ordered.Text = "Not Sorted"
        cmb_ordered.Enabled = True

        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        'ListView1.Sorting = SortOrder.Ascending

        'typePopulate()
        'partPopulate()
        'reinintialise the form
        InitialiseSeeStock()
    End Sub


    'price filters

    'when the minimum value scroller is changed
    Private Sub trk_min_Scroll(sender As Object, e As EventArgs) Handles trk_min.Scroll
        'set the value of label2
        Label2.Text = "Min: " & trk_min.Value
        'call the function to filter by the minimum value
        filterMinCost()
    End Sub

    'when the maximum value scroller is changed
    Private Sub trk_max_Scroll(sender As Object, e As EventArgs) Handles trk_max.Scroll
        'set the value of label2
        Label3.Text = "Max: " & trk_max.Value
        'call the function to filter by the minimum value
        filterMaxCost()
    End Sub

    'filter by the maximum cost
    Sub filterMaxCost()
        'store whether anything has changed
        Dim edited As Boolean = False

        'store all the values that will be readded
        Dim added As New List(Of ListViewItem)

        'store all of the values that will stay from what's there already
        Dim newList As New List(Of ListViewItem)
        'loop through all of the listview items
        For i = 0 To ListView1.Items.Count - 1
            'if the current item we're on in the loop is more expensive than the max cost add it to the removed list
            If Convert.ToInt32(ListView1.Items(i).SubItems(6).Text) > Convert.ToInt32(trk_max.Value) Then
                removed.Add(ListView1.Items(i))
                'we have therefore changed something
                edited = True
                'if its not more expensive, add it to the list to keep
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next

        'loop through all of the items that have been removed
        For i = 0 To removed.Count - 1
            'if they now come under the filter, add them to the list of values to add back in
            If (Convert.ToInt32(Convert.ToInt32(removed(i).SubItems(6).Text) >= Convert.ToInt32(trk_min.Value)) And Convert.ToInt32(removed(i).SubItems(6).Text) <= Convert.ToInt32(trk_max.Value)) Then
                added.Add(removed(i))
                'we have therefore changed something so we mark it as such
                edited = True
            End If
        Next
        Dim newRemoved As New List(Of ListViewItem)
        'if we will add some items back in to the listview
        If added.Count > 0 Then
            'add all of the items that have newly been found to the list of items to add back to the list view after its been cleared
            newList.AddRange(added.ToArray)

            'store all of the values that we haven't added back in from the removed list

            'store whether a item has been added back in or not
            Dim found As Boolean
            'for every item in the removed list
            For i = 0 To removed.Count - 1
                'reset the found value
                found = False
                'loop through all of the values that we have added back
                For j = 0 To added.Count - 1
                    'if the item in the removed list is also in the added list, it has been found
                    If added(j).SubItems(0).Text = removed(i).SubItems(0).Text Then
                        found = True
                    End If
                Next
                'if the item in the removed list is not present in the added list, add it to the new removed list
                If Not found Then
                    newRemoved.Add(removed(i))
                End If
            Next
        End If
        'if something has changed
        If edited Then
            'if we have added something back, ensure that we remove the items we have added back from the removed list
            If added.Count > 0 Then
                removed = newRemoved
            End If
            'visually update the listview
            ListView1.BeginUpdate()
            ListView1.Items.Clear()
            ListView1.Items.AddRange(newList.ToArray())
            ListView1.Sort()
            ListView1.EndUpdate()
        End If

    End Sub

    'filter by the maximum cost
    Sub filterMinCost()
        'store all the values that will be readded
        Dim added As New List(Of ListViewItem)
        'store all of the values that will stay from what's there already
        Dim newList As New List(Of ListViewItem)
        'store whether anything has changed
        Dim edited As Boolean = False
        'loop through all of the listview items
        For i = 0 To ListView1.Items.Count - 1
            'if the current item we're on in the loop is less expensive than the min cost add it to the removed list
            If Convert.ToInt32(ListView1.Items(i).SubItems(6).Text) < Convert.ToInt32(trk_min.Value) Then
                removed.Add(ListView1.Items(i))
                edited = True
                'if its not more expensive, add it to the list to keep
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        'loop through all of the items that have been removed
        For i = 0 To removed.Count - 1
            'if they now come under the filter, add them to the list of values to add back in
            If (Convert.ToInt32(removed(i).SubItems(6).Text) >= Convert.ToInt32(trk_min.Value)) And Convert.ToInt32(removed(i).SubItems(6).Text) <= Convert.ToInt32(trk_max.Value) Then
                'we have therefore changed something so we mark it as such
                edited = True
                added.Add(removed(i))

            End If
        Next
        'if we will add some items back in to the listview
        If added.Count > 0 Then
            'add all of the items that have newly been found to the list of items to add back to the list view after its been cleared
            newList.AddRange(added.ToArray)
            'store all of the values that we haven't added back in from the removed list
            Dim newRemoved As New List(Of ListViewItem)
            'store whether a item has been added back in or not
            Dim found As Boolean
            'for every item in the removed list
            For i = 0 To removed.Count - 1
                'reset the found value
                found = False
                'loop through all of the values that we have added back
                For j = 0 To added.Count - 1
                    'if the item in the removed list is also in the added list, it has been found
                    If added(j).SubItems(0).Text = removed(i).SubItems(0).Text Then
                        found = True
                    End If
                Next
                'if the item in the removed list is not present in the added list, add it to the new removed list
                If Not found Then
                    newRemoved.Add(removed(i))
                End If
            Next
            'ensure that we remove the items we have added back from the removed list
            removed = newRemoved
        End If
        'if something has changed
        If edited Then
            'visually update the listview
            ListView1.BeginUpdate()
            ListView1.Items.Clear()
            ListView1.Items.AddRange(newList.ToArray())
            ListView1.Sort()
            ListView1.EndUpdate()
        End If
    End Sub



    'deletion
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'if the user has selected at least one item
        If ListView1.SelectedItems.Count > 0 Then
            'store the ID of the item
            Dim itemID As Integer
            'store a temporary stock item
            Dim s As Stock
            'store the index of the item in allstock
            Dim item As Integer
            'go through all of the items selected for deletion
            While ListView1.SelectedItems.Count > 0
                'set the ID of the item to the lefthand number in the list view (the ID of the stock item)
                itemID = ListView1.SelectedItems(0).SubItems(0).Text
                'loop through allstock
                For j = 0 To AllStock.Count - 1
                    'if the current item in allstock matches the id shown in the listview
                    If AllStock(j).ID = itemID Then
                        'the index of the item is J
                        item = j
                    End If
                Next
                'set s equal to the stock item in allstock at position j and set its ID to itself *-1, subtract one so that even the ID with 0 will have a negative index when this is performed
                s = AllStock(item)
                Dim l As log
                l.id = findNextIndex("AllLogs")
                l.user = Form1.currentUser
                l.action = "Delete"
                l.data = s.ID & s.part & s.cost
                l.time = Now
                AllLogs.Add(l)
                writeLogs()
                s.ID = (s.ID * -1) - 1
                'set the item in all stock to be the new item
                AllStock(item) = s
                'remove the item from the listview
                ListView1.Items.Remove(ListView1.SelectedItems(0))
            End While

            'if the user hasn't selected anything
        Else
            'tell them to select something
            MsgBox("Please Select An Item")
        End If
        'write to the stock file
        writeStockFile()
    End Sub

    'when the combo box for type is changed
    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        'filter by type
        filterType(cmb_type.SelectedItem)
        'lock the combo box and clear the items within it
        cmb_type.Enabled = False
        cmb_part.Items.Clear()
        'repopulate the parts combo box
        partPopulate()
    End Sub

    Private Sub cmb_part_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_part.SelectedIndexChanged
        'filter by part    
        filterPart(cmb_part.SelectedText)
        'lock the combo box and clear the items within it
        cmb_part.Enabled = False

        cmb_type.Items.Clear()
        'repopulate the types combo box
        typePopulate()

    End Sub

    'when the ordered date is changed
    Private Sub cmb_ordered_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ordered.SelectedIndexChanged
        'filter by date orderd
        filterOrdered(cmb_ordered.SelectedItem)
        'lock the date box
        cmb_ordered.Enabled = False
        'reset the part and type combo boxes 
        cmb_part.Items.Clear()
        cmb_type.Items.Clear()

        typePopulate()
        partPopulate()
    End Sub

    'when the due date is changed
    Private Sub cmb_due_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_due.SelectedIndexChanged
        'filter by date due
        filterDue(cmb_due.SelectedItem)
        'lock the date box
        cmb_due.Enabled = False
        'reset the part and type combo boxes 
        cmb_part.Items.Clear()
        cmb_type.Items.Clear()

        typePopulate()
        partPopulate()
    End Sub

    'when the arrived date is changed
    Private Sub cmb_arrived_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_arrived.SelectedIndexChanged
        'filter by date arrived
        filterArrived()
        'lock the date box
        cmb_arrived.Enabled = False
        'reset the part and type combo boxes 
        cmb_part.Items.Clear()
        cmb_type.Items.Clear()

        typePopulate()
        partPopulate()
    End Sub

    'when the edit button is clicked
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'show the editstock form and initialize it, and hide the current form
        EditStock.Show()
        EditStock.initialiseEditStock(ListView1.SelectedItems(0).SubItems(0).Text)
        Me.Hide()
    End Sub



    'store whether we are trying to select an item from this database or just browsing
    Dim selecting As Boolean

    'initilise when we are selecting
    Sub selectInit(type As String)
        'disable the cobo box that selects the type of part to filter by
        cmb_type.Enabled = False
        'filter by the type we're selecting
        filterType(type)
        'set the selecting value to true
        selecting = True
        'store whether the current stock item is being in another order
        Dim found As Boolean = False
        'store a list of all the items that survive the filter
        Dim newITems As New List(Of ListViewItem)
        'loop through the listviewitems
        For i = 0 To ListView1.Items.Count - 1
            'loop through orderstock
            For j = 0 To AllOrderStock.Count - 1
                'check if the listviewitem we are on is referenced in orderstock at the j index
                If ListView1.Items(i).SubItems(0).Text = AllOrderStock(j).stock.ToString() Then
                    'if it is, it is being used in an order so we add the listviewitem to a list that stores all the items that have been removed by filtering
                    removed.Add(ListView1.Items(i))
                    'record that we have found the item and it being used in an order
                    found = True
                End If
            Next
            'if the item is not being used in an order
            If Not found Then
                'add the listviewitem to a list of listviewitems to add back to the listview after filtering
                newITems.Add(ListView1.Items(i))
            End If
            found = False
        Next
        'clear the items in the listview and only add back the items that aren't being used in any orders
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newITems.ToArray())
        Dim flag As Boolean = False
        newITems = New List(Of ListViewItem)
        For j = 0 To ListView1.Items.Count - 1
            For i = 0 To Write.sSto.Count - 1
                If ListView1.Items(j).SubItems(0).Text = Write.sSto(i).ToString Then
                    flag = True
                    removed.Add(ListView1.Items(j))
                End If
            Next
            If Not flag Then
                newITems.Add(ListView1.Items(j))
            End If
            flag = False
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newITems.ToArray())

    End Sub

    'when an item is selected
    Private Sub ListView1_ItemActivate(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        'if the user has selected an item
        If ListView1.SelectedItems.Count = 1 Then
            'if we are trying to select a stock item
            If selecting Then
                'pass the ID of the stock item back to the add parts form
                Write.onReturn(Convert.ToInt32(ListView1.SelectedItems(0).SubItems(0).Text))
                'navigate the user back to add parts
                Me.Hide()
                Write.Show()
            End If
        Else
            'if the user hasn't selected an item or has selected multiple
            MsgBox("Please Select Exactly One Item")
        End If

    End Sub


End Class