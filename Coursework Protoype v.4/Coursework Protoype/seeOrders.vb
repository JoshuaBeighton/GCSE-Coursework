Public Class seeOrders
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Write.Show()
        Me.Close()
    End Sub
    Public Sub initialiseAllOrders()
        'initialising listview
        ListView1.Items.Clear()
        Dim l As New List(Of ListViewItem)
        ListView1.Columns.Add("ID", 20, HorizontalAlignment.Left)
        ListView1.Columns.Add("Customer", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Due", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Price", 50, HorizontalAlignment.Left)
        ListView1.Columns.Add("CPU", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("GPU", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("RAM", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("PSU", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("Case", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("Motherboard", 70, HorizontalAlignment.Left)
        ListView1.Columns.Add("Storage", ListView1.Width - 20 - 150 - 100 - 50 - 70 - 70 - 70 - 70 - 70 - 70, HorizontalAlignment.Left)



        Dim components() As String
        Dim s As String = ""
        Dim tempL As New ListViewItem
        For i = 0 To AllOrders.Count - 1
            If AllOrders(i).id >= 0 Then
                s = ""
                components = findComponents(AllOrders(i).id)
                tempL = New ListViewItem
                tempL.SubItems(0).Text = (AllOrders(i).id)
                tempL.SubItems.Add(AllOrders(i).customer)
                tempL.SubItems.Add(AllOrders(i).due)
                tempL.SubItems.Add(AllOrders(i).price)
                tempL.SubItems.Add(components(0)) 'components start at index 4, CPU is 4
                tempL.SubItems.Add(components(1)) 'GPU at 5
                tempL.SubItems.Add(components(2)) 'ram at 6
                tempL.SubItems.Add(components(3)) 'PSU at 7
                tempL.SubItems.Add(components(4)) 'case at 8
                tempL.SubItems.Add(components(5)) 'motherbaord at 9
                'l(i).SubItems.Add(components(6))
                For j = 6 To components.Length - 1
                    s = s + components(j) + ", "
                Next
                If s.Length > 0 Then
                    s = s.Substring(0, s.Length - 2)
                End If
                tempL.SubItems.Add(s)
                l.Add(tempL)




                'tempL = New ListViewItem
                'Dim j As Integer = 0
                'Dim startIndex As Integer = -1
                'While (j < AllOrderStock.Count) And (startIndex = -1)
                '    If AllOrders(i).id = AllOrderStock(j).order Then
                '        startIndex = j
                '    Else
                '        j += 1
                '    End If
                'End While
                'Dim endIndex As Integer = -1
                'While (j < AllOrderStock.Count) And (startIndex = -1)
                '    If AllOrders(i).id <> AllOrderStock(j).order Then
                '        endIndex = j
                '    ElseIf j = AllOrderStock.Count - 1 Then
                '        endIndex = j - 1
                '    Else
                '        j += 1
                '    End If
                'End While

                'Dim lcpu As String
                'Dim lram As String
                'Dim lgpu As String
                'Dim lcase As String
                'Dim lmotherboard As String
                'Dim lstorage As New List(Of String)
                'Dim lpsu As String


                'For k = startIndex To endIndex
                '    Select Case AllStock(AllOrderStock(k).stock).type.ToUpper()
                '        Case "CPU"
                '            lcpu = AllStock(AllOrderStock(k).stock).part
                '        Case "GPU"
                '            lgpu = AllStock(AllOrderStock(k).stock).part

                '        Case "PSU"
                '            lpsu = AllStock(AllOrderStock(k).stock).part

                '        Case "RAM"
                '            lram = AllStock(AllOrderStock(k).stock).part

                '        Case "CASE"
                '            lcase = AllStock(AllOrderStock(k).stock).part

                '        Case "MOTHERBOARD"
                '            lmotherboard = AllStock(AllOrderStock(k).stock).part

                '        Case "STORAGE"
                '            lstorage.Add(AllStock(AllOrderStock(k).stock).part)
                '    End Select

                'Next
                'tempL.SubItems.Add(lcpu)
                'tempL.SubItems.Add(lgpu)
                'tempL.SubItems.Add(lram)
                'tempL.SubItems.Add(lpsu)
                'tempL.SubItems.Add(lcase)
                'tempL.SubItems.Add(lmotherboard)
                'tempL.SubItems.Add(String.Join(", ", lstorage.ToArray))




                'l.Add(tempL)
            End If
        Next
        ListView1.Items.AddRange(l.ToArray)

        CPUPopulate()
        GPUPopulate()
        RAMPopulate()
        casePopulate()
    End Sub
    Private Sub seeOrders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        initialiseAllOrders()

    End Sub
    'finding all components
    Function findComponents(search As Integer) As String()
        Dim components As New List(Of String)
        Dim startIndex As Integer = -1
        Dim i As Integer
        While (i < AllOrderStock.Count) And (startIndex = -1)
            If search = AllOrderStock(i).order Then
                startIndex = i
            Else
                i += 1
            End If
        End While
        Dim maxLength As Boolean = False
        Dim foundEnd As Boolean = False
        While maxLength = False And foundEnd = False
            If i < AllOrderStock.Count Then
                If AllOrderStock(i).order = search Then
                    components.Add(AllStock(AllOrderStock(i).stock).part)
                    i += 1
                Else
                    foundEnd = True
                End If
            Else
                maxLength = True
            End If
        End While
        Return (components.ToArray())
    End Function
    Dim removed As New List(Of ListViewItem)
    Private Sub filter_click(sender As Object, e As EventArgs) Handles btn_filter.Click, cmb_CPU.TextChanged, cmb_GPU.TextChanged, cmb_RAM.TextChanged, cmb_Case.TextChanged, cmb_date.TextChanged, txt_Cust.Leave
        If txt_Cust.Text <> "" Then
            filterCustomer()
        End If
        If Convert.ToInt32(cmb_Case.SelectedIndex) <> -1 Then
            filterCase()
            cmb_Case.Enabled = False
        End If
        If Convert.ToInt32(cmb_CPU.SelectedIndex) <> -1 Then
            filterCPU()
            cmb_CPU.Enabled = False
        End If
        If Convert.ToInt32(cmb_GPU.SelectedIndex) <> -1 Then
            filterGPU()
            cmb_GPU.Enabled = False
        End If
        If Convert.ToInt32(cmb_RAM.SelectedIndex) <> -1 Then
            filterRAM()
            cmb_RAM.Enabled = False
        End If
        If Convert.ToInt32(cmb_date.SelectedIndex) <> -1 Then
            filterDate(cmb_date.SelectedItem)
            cmb_date.Enabled = False
            DateTimePicker1.Enabled = False
        End If
        cmb_CPU.Items.Clear()
        cmb_GPU.Items.Clear()
        cmb_RAM.Items.Clear()
        cmb_Case.Items.Clear()
        CPUPopulate()
        GPUPopulate()
        RAMPopulate()
        casePopulate()
    End Sub
    'filters
    Sub filterCPU()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(4).Text <> cmb_CPU.SelectedItem Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub
    Sub filterGPU()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(5).Text <> cmb_GPU.SelectedItem Then
                removed.Add(ListView1.Items(i))

            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub
    Sub filterRAM()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(6).Text <> cmb_RAM.SelectedItem Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub
    Sub filterCase()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(8).Text <> cmb_Case.SelectedItem Then
                removed.Add(ListView1.Items(i))

            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub

    Sub filterDate(mode As String)
        Dim newList As New List(Of ListViewItem)
        If mode = "Before" Then
            'For j = 0 To ListView1.Items.Count - 1
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(2).Text).Date > DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        ElseIf mode = "After" Then
            ''For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(2).Text).Date < DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        ElseIf mode = "On" Then
            'For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            For i = 0 To ListView1.Items.Count - 1
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(2).Text).Date <> DateTimePicker1.Value) Then
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

    Sub filterCustomer()
        Dim newList As New List(Of ListViewItem)
        For i = 0 To ListView1.Items.Count - 1
            If (ListView1.Items(i).SubItems(1).Text <> txt_Cust.Text) Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub




    'populating
    Sub CPUPopulate()
        cmb_CPU.Items.Clear()
        Dim vals As New List(Of String)
        Dim found As Boolean
        For i = 0 To ListView1.Items.Count - 1
            found = False
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(4).Text Then
                    found = True
                End If
            Next
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(4).Text)
            End If
        Next
        cmb_CPU.Items.AddRange(vals.ToArray)
    End Sub
    Sub GPUPopulate()
        cmb_GPU.Items.Clear()
        Dim vals As New List(Of String)
        Dim found As Boolean
        For i = 0 To ListView1.Items.Count - 1
            found = False
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(5).Text Then
                    found = True
                End If
            Next
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(5).Text)
            End If
        Next
        cmb_GPU.Items.AddRange(vals.ToArray)
    End Sub
    Sub RAMPopulate()
        cmb_RAM.Items.Clear()
        Dim vals As New List(Of String)
        Dim found As Boolean
        For i = 0 To ListView1.Items.Count - 1
            found = False
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(6).Text Then
                    found = True
                End If
            Next
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(6).Text)
            End If
        Next
        cmb_RAM.Items.AddRange(vals.ToArray)
    End Sub
    Sub casePopulate()
        cmb_Case.Items.Clear()
        Dim vals As New List(Of String)
        Dim found As Boolean
        For i = 0 To ListView1.Items.Count - 1
            found = False
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(8).Text Then
                    found = True
                End If
            Next
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(8).Text)
            End If
        Next
        cmb_Case.Items.AddRange(vals.ToArray)
    End Sub


    'clearing filters
    Private Sub clearfilter_click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        ListView1.Items.AddRange(removed.ToArray())
        removed.Clear()
        cmb_Case.SelectedIndex = -1
        cmb_Case.Text = "Case"
        cmb_Case.Enabled = True
        cmb_CPU.SelectedIndex = -1
        cmb_CPU.Text = "CPU"
        cmb_CPU.Enabled = True
        cmb_GPU.SelectedIndex = -1
        cmb_GPU.Text = "GPU"
        cmb_GPU.Enabled = True
        cmb_RAM.SelectedIndex = -1
        cmb_RAM.Text = "RAM"
        cmb_RAM.Enabled = True
        cmb_date.SelectedIndex = -1
        txt_Cust.Clear()
        cmb_date.Text = "Not Sorted"
        cmb_date.Enabled = True
        DateTimePicker1.Enabled = True
        ListView1.Sorting = SortOrder.Ascending
    End Sub


    'going back
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub



    'deleting
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim oID As Integer
        While ListView1.SelectedItems.Count > 0
            Dim item As Integer = ListView1.SelectedItems(0).SubItems(0).Text
            Dim o As Order
            For j = 0 To AllOrders.Count - 1
                If item = AllOrders(j).id Then
                    oID = j
                End If
            Next
            o = AllOrders(oID)
            o.id = (o.id * -1) - 1
            AllOrders(oID) = o
            ListView1.Items.Remove(ListView1.SelectedItems(0))

        End While
        writeOrder()
    End Sub


    'saving when closed
    Private Sub seeOrders_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        writeOrder()
    End Sub

    Private Sub seeOrders_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        writeOrder()
    End Sub


    'opening editorder
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListView1.SelectedItems.Count = 1 Then
            EditOrder.Show()
            EditOrder.editOrderSetup(ListView1.SelectedItems(0).SubItems(0).Text)
            Me.Hide()
        ElseIf ListView1.SelectedItems.Count > 1 Then
            MsgBox("Please only select one item to edit")
        Else
            MsgBox("Please select an item to edit")
        End If

    End Sub

    Private Sub seeOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



' TO DO LIST
'Editing of stock
'Editing of orders





'BUGS
'Filling up the type / part cmbs on the seestock form - type gets messed up after filtering and clearing, and part just straight up doesnt work
'issues removing items in order form, haven't started with stock