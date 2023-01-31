Public Class seeStock
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteStock.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
    Public Sub InitialiseSeeStock()
        Dim l As New List(Of ListViewItem)
        ListView1.Columns.Add("ID", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("Type", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Part", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Ordered", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Due", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Arrived", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("Cost", ListView1.Width - 20 - 150 - 100 - 200 - 200 - 70, HorizontalAlignment.Left)
        ListView1.Items.Clear()
        Dim tempL As ListViewItem
        For i = 0 To AllStock.Count - 1
            If AllStock(i).ID >= 0 Then
                tempL = New ListViewItem
                tempL.SubItems(0).Text = (AllStock(i).ID)
                tempL.SubItems.Add(AllStock(i).type)
                tempL.SubItems.Add(AllStock(i).part)
                tempL.SubItems.Add(AllStock(i).ordered)
                tempL.SubItems.Add(AllStock(i).Due)
                tempL.SubItems.Add(AllStock(i).arrived)
                tempL.SubItems.Add(AllStock(i).cost)
                l.Add(tempL)
            End If
        Next

        ListView1.Items.AddRange(l.ToArray)
        typePopulate()
        partPopulate()
        If ListView1.Items.Count > 0 Then
            Dim val As Integer = ListView1.Items(0).SubItems(6).Text
            Dim max As Integer = val
            Dim min As Integer = val

            For i = 0 To ListView1.Items.Count - 1
                val = ListView1.Items(i).SubItems(6).Text
                If val > max Then
                    max = val
                End If
                If val < min Then
                    min = val
                End If
            Next

            trk_max.Maximum = max
            trk_max.Minimum = min
            trk_min.Maximum = max
            trk_min.Minimum = min
            trk_min.Value = min
            trk_max.Value = max
            lbl_max.Text = max
            lbl_min.Text = min
        Else
            trk_max.Maximum = 100
            trk_min.Maximum = 100
            trk_max.Minimum = 0
            trk_min.Minimum = 0
        End If
        Label2.Text = "Min: " & trk_min.Value
        Label3.Text = "Max: " & trk_max.Value
    End Sub
    Public Sub seeStock_Shown() Handles MyBase.Shown
        InitialiseSeeStock()
    End Sub


    Dim removed As New List(Of ListViewItem)




    'filters
    Private Sub filter_click(sender As Object, e As EventArgs)
        If cmb_part.SelectedIndex <> -1 Then
            filterPart()
            cmb_part.Enabled = False
        End If
        If Convert.ToInt32(cmb_arrived.SelectedIndex) <> -1 Then
            filterArrived()
            cmb_arrived.Enabled = False
        End If
        If Convert.ToInt32(cmb_ordered.SelectedIndex) <> -1 Then
            filterOrdered(cmb_ordered.SelectedItem)
            cmb_ordered.Enabled = False
        End If
        If Convert.ToInt32(cmb_type.SelectedIndex) <> -1 Then
            filterType()
            cmb_type.Enabled = False
        End If
        If Convert.ToInt32(cmb_due.SelectedIndex) <> -1 Then
            filterDue(cmb_due.SelectedItem)
            cmb_due.Enabled = False
        End If

        cmb_arrived.Items.Clear()
        cmb_due.Items.Clear()
        cmb_ordered.Items.Clear()
        cmb_part.Items.Clear()
        cmb_type.Items.Clear()

        typePopulate()
        partPopulate()

    End Sub

    Sub filterPart()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(2).Text <> cmb_part.SelectedItem Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub
    Sub filterType()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(1).Text <> cmb_type.SelectedItem Then
                removed.Add(ListView1.Items(i))

            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub
    Sub filterArrived()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(5).Text <> cmb_arrived.SelectedItem Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub


    Sub filterOrdered(mode As String)
        Dim newList As New List(Of ListViewItem)
        If mode = "Before" Then
            'For j = 0 To ListView1.Items.Count - 1
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(3).Text).Date > DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        ElseIf mode = "After" Then
            ''For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(3).Text).Date < DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        ElseIf mode = "On" Then
            'For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(3).Text).Date <> DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        End If
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())

    End Sub

    Sub filterDue(mode As String)
        Dim newList As New List(Of ListViewItem)
        If mode = "Before" Then
            'For j = 0 To ListView1.Items.Count - 1
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(4).Text).Date > DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        ElseIf mode = "After" Then
            ''For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(4).Text).Date < DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        ElseIf mode = "On" Then
            'For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(4).Text).Date <> DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        End If
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())

    End Sub



    'populate combo boxes
    Sub typePopulate()
        cmb_type.Items.Clear()
        Dim vals As New List(Of String)
        Dim found As Boolean
        For i = 0 To ListView1.Items.Count - 1
            found = False
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(1).Text Then
                    found = True
                End If
            Next
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(1).Text)
            End If
        Next
        cmb_type.Items.AddRange(vals.ToArray)
    End Sub

    Sub partPopulate()
        cmb_part.Items.Clear()
        Dim vals As New List(Of String)
        Dim found As Boolean
        For i = 0 To ListView1.Items.Count - 1
            found = False
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(2).Text Then
                    found = True
                End If
            Next
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(2).Text)
            End If
        Next
        cmb_part.Items.AddRange(vals.ToArray)
    End Sub



    'clear filters
    Private Sub clearfilter_click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        'ListView1.Items.AddRange(removed.ToArray())
        'removed.Clear()
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
        InitialiseSeeStock()
    End Sub


    'price filters
    Private Sub trk_min_Scroll(sender As Object, e As EventArgs) Handles trk_min.Scroll
        Label2.Text = "Min: " & trk_min.Value
        filterMinCost()
    End Sub
    Private Sub trk_max_Scroll(sender As Object, e As EventArgs) Handles trk_max.Scroll
        Label3.Text = "Max: " & trk_max.Value
        filterMaxCost()
    End Sub

    Sub filterMaxCost()
        Dim edited As Boolean = False
        Dim added As New List(Of ListViewItem)
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If Convert.ToInt32(ListView1.Items(i).SubItems(6).Text) > Convert.ToInt32(trk_max.Value) Then
                removed.Add(ListView1.Items(i))
                edited = True
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        For i = 0 To removed.Count - 1
            If (Convert.ToInt32(Convert.ToInt32(removed(i).SubItems(6).Text) >= Convert.ToInt32(trk_min.Value)) And Convert.ToInt32(removed(i).SubItems(6).Text) <= Convert.ToInt32(trk_max.Value)) Then

                added.Add(removed(i))
                edited = True
            End If
        Next
        newList.AddRange(added.ToArray)
        Dim newRemoved As New List(Of ListViewItem)
        Dim found As Boolean
        For i = 0 To removed.Count - 1
            found = False
            For j = 0 To added.Count - 1
                If added(j).SubItems(0).Text = removed(i).SubItems(0).Text Then
                    found = True
                End If
            Next
            If Not found Then
                newRemoved.Add(removed(i))
            End If
        Next
        If edited Then
            removed = newRemoved
            ListView1.BeginUpdate()
            ListView1.Items.Clear()
            ListView1.Items.AddRange(newList.ToArray())
            ListView1.Sort()
            ListView1.EndUpdate()
        End If

    End Sub
    Sub filterMinCost()
        Dim added As New List(Of ListViewItem)
        Dim newList As New List(Of ListViewItem)
        Dim edited As Boolean = False
        For i = 0 To ListView1.Items.Count - 1
            If Convert.ToInt32(ListView1.Items(i).SubItems(6).Text) < Convert.ToInt32(trk_min.Value) Then
                removed.Add(ListView1.Items(i))
                edited = True
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        For i = 0 To removed.Count - 1
            If (Convert.ToInt32(removed(i).SubItems(6).Text) >= Convert.ToInt32(trk_min.Value)) And Convert.ToInt32(removed(i).SubItems(6).Text) <= Convert.ToInt32(trk_max.Value) Then
                edited = True
                added.Add(removed(i))

            End If
        Next
        newList.AddRange(added.ToArray)
        Dim newRemoved As New List(Of ListViewItem)
        Dim found As Boolean
        For i = 0 To removed.Count - 1
            found = False
            For j = 0 To added.Count - 1
                If added(j).SubItems(0).Text = removed(i).SubItems(0).Text Then
                    found = True
                End If
            Next
            If Not found Then
                newRemoved.Add(removed(i))
            End If
        Next

        removed = newRemoved
        If edited Then
            ListView1.BeginUpdate()
            ListView1.Items.Clear()
            ListView1.Items.AddRange(newList.ToArray())
            ListView1.Sort()
            ListView1.EndUpdate()
        End If
    End Sub



    'deletion
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then

            Dim itemID As Integer
            Dim s As Stock
            Dim item As Integer
            While ListView1.SelectedItems.Count > 0
                itemID = ListView1.SelectedItems(0).SubItems(0).Text
                For j = 0 To AllStock.Count - 1
                    If AllStock(j).ID = itemID Then
                        item = j
                    End If
                Next
                s = AllStock(item)
                s.ID = (s.ID * -1) - 1
                AllStock(item) = s
                ListView1.Items.Remove(ListView1.SelectedItems(0))
            End While


        Else
            MsgBox("Please Select An Item")
        End If
        WriteStockFile()
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        filterType()
        cmb_type.Enabled = False
        cmb_part.Items.Clear()

        partPopulate()
    End Sub

    Private Sub cmb_part_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_part.SelectedIndexChanged
        filterPart()
        cmb_part.Enabled = False

        cmb_type.Items.Clear()

        typePopulate()

    End Sub

    Private Sub cmb_ordered_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ordered.SelectedIndexChanged
        filterOrdered(cmb_ordered.SelectedItem)
        cmb_ordered.Enabled = False
        cmb_part.Items.Clear()
        cmb_type.Items.Clear()

        typePopulate()
        partPopulate()
    End Sub

    Private Sub cmb_due_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_due.SelectedIndexChanged
        filterDue(cmb_due.SelectedItem)
        cmb_due.Enabled = False
        cmb_part.Items.Clear()
        cmb_type.Items.Clear()

        typePopulate()
        partPopulate()
    End Sub

    Private Sub cmb_arrived_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_arrived.SelectedIndexChanged
        filterArrived()
        cmb_arrived.Enabled = False
        cmb_part.Items.Clear()
        cmb_type.Items.Clear()

        typePopulate()
        partPopulate()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EditStock.Show()
        EditStock.initialiseEditStock(ListView1.SelectedItems(0).SubItems(0).Text)
        Me.Hide()
    End Sub

    Private Sub seeStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class