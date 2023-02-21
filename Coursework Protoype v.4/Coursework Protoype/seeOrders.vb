Public Class seeOrders
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'shows the write order form instead of the current form
        Write.Show()
        Write.init()
        Me.Close()
    End Sub

    Public Sub initialiseAllOrders()
        'initialising listview 
        ListView1.Items.Clear()
        Dim l As New List(Of ListViewItem)
        'adding relavant columns
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
        'making final column fit to the end of the listbox
        ListView1.Columns.Add("Storage", ListView1.Width - 20 - 150 - 100 - 50 - 70 - 70 - 70 - 70 - 70 - 70, HorizontalAlignment.Left)


        'variable to store all of the components attached to the current order
        Dim components() As String
        'temporary string to store all of the Storage devices in the current project
        Dim s As String = ""
        'store a temporary list view item
        Dim tempL As New ListViewItem
        'loop through all the orders
        For i = 0 To AllOrders.Count - 1
            'if the order hasn't been deleted
            If AllOrders(i).id >= 0 Then
                'reset the temporary string
                s = ""
                'find all of the components in the current order
                components = findComponents(AllOrders(i).id)
                'reset the list item
                tempL = New ListViewItem
                'assign the elements to their positions in the list box
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


                'add all of the storage devices. As this is open-ended, it will loop until it gets to the end of the list 
                For j = 6 To components.Length - 1
                    s = s + components(j) + ", "
                Next
                'if there are any devices
                If s.Length > 0 Then
                    'remove the last ", " from the storage list
                    s = s.Substring(0, s.Length - 2)
                End If
                'add the storage to the list box
                tempL.SubItems.Add(s)
                'add the list view item
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
        'add the list view items
        ListView1.Items.AddRange(l.ToArray)

        'populate the drop down boxes for filtering
        CPUPopulate()
        GPUPopulate()
        RAMPopulate()
        casePopulate()
    End Sub


    'when the form is shown, call the method to initialise
    Private Sub seeOrders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        initialiseAllOrders()
    End Sub


    'finding all components
    Function findComponents(search As Integer) As String()
        'declare list variable to store all of the components attached to an order
        Dim components As New List(Of String)

        'index to find where the order starts in the orderstock file
        Dim startIndex As Integer = -1

        'index of the loop
        Dim i As Integer

        'loop through all  the orderstock file items until it finds any item that belongs to the correct order
        While (i < AllOrderStock.Count) And (startIndex = -1)
            'check if the order is what we're after
            If search = AllOrderStock(i).order Then
                startIndex = i
            Else
                i += 1
            End If
        End While

        'variable to determine if we found the end of the array
        Dim maxLength As Boolean = False

        'variable to determine if we have reached the end of the order we are looking at
        Dim foundEnd As Boolean = False

        'while we haven't reached the end of the array and haven't moved on to another order
        While maxLength = False And foundEnd = False

            'check if we found the end of the array
            If i < AllOrderStock.Count Then

                'check if we found the end of the current order
                If AllOrderStock(i).order = search Then
                    'add the stock to the list of components
                    For j = 0 To AllStock.Count - 1
                        If AllStock(j).ID = AllOrderStock(i).stock Then
                            components.Add(AllStock(j).part)
                        End If

                    Next

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

    'list to store the items removed during in filtering so they can be re-added later
    Dim removed As New List(Of ListViewItem)

    'filter through the elements when a filter value is changed
    Private Sub filter_click(sender As Object, e As EventArgs) Handles btn_filter.Click, cmb_CPU.TextChanged, cmb_GPU.TextChanged, cmb_RAM.TextChanged, cmb_Case.TextChanged, cmb_date.TextChanged, txt_Cust.Leave

        'if the user has entered data in the text box for filtering by customer 
        If txt_Cust.Text <> "" Then

            'filter based on that 
            filterCustomer()
        End If

        'if the user has selected a case, filter by case
        If Convert.ToInt32(cmb_Case.SelectedIndex) <> -1 Then
            filterCase()
            cmb_Case.Enabled = False
        End If

        'if the user has selected a cpu, filter by that
        If Convert.ToInt32(cmb_CPU.SelectedIndex) <> -1 Then
            filterCPU()
            cmb_CPU.Enabled = False
        End If

        'if the user has selected a gpu to filter by, filter by that
        If Convert.ToInt32(cmb_GPU.SelectedIndex) <> -1 Then
            filterGPU()
            cmb_GPU.Enabled = False
        End If

        'if the user has selected a RAM to filter by, filter by that
        If Convert.ToInt32(cmb_RAM.SelectedIndex) <> -1 Then
            filterRAM()
            cmb_RAM.Enabled = False
        End If

        'if the user has selected a date
        If Convert.ToInt32(cmb_date.SelectedIndex) <> -1 Then
            filterDate(cmb_date.SelectedItem)
            cmb_date.Enabled = False
            DateTimePicker1.Enabled = False
        End If

        'clear the text boxes and enter the new data
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




    'filter for cpu
    Sub filterCPU()
        'declare a list of the items to keep
        Dim newList As New List(Of ListViewItem)

        'loop through all of the list view items
        For i = 0 To ListView1.Items.Count - 1
        'check if it matches and act accordingly
            If ListView1.Items(i).SubItems(4).Text <> cmb_CPU.SelectedItem Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        'clear, then add the items that are included in the appropriate categories
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub

    'filter for GPU
    Sub filterGPU()
        'declare a list of the items to keep
        Dim newList As New List(Of ListViewItem)

        'loop through all of the list view items
        For i = 0 To ListView1.Items.Count - 1
            'check if it matches and act accoridngly
            If ListView1.Items(i).SubItems(5).Text <> cmb_GPU.SelectedItem Then
                removed.Add(ListView1.Items(i))

            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        'clear, then add the items that are included in the appropriate categories 
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub

    'filter by RAM
    Sub filterRAM()
        'declare a list of the list view items to keep
        Dim newList As New List(Of ListViewItem)

        'loop through the list view
        For i = 0 To ListView1.Items.Count - 1
            'check if it matches, and if does, act accordingly
            If ListView1.Items(i).SubItems(6).Text <> cmb_RAM.SelectedItem Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        'clear the list view items, then add the ones i need to keep
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub

    'filter by case
    Sub filterCase()
        ''declare a list of the list view items to keep
        Dim newList As New List(Of ListViewItem)

        'loop through the list view
        For i = 0 To ListView1.Items.Count - 1
        'check if the item matches the filter, then act accordingly
            If ListView1.Items(i).SubItems(8).Text <> cmb_Case.SelectedItem Then
                removed.Add(ListView1.Items(i))

            Else
                newList.Add(ListView1.Items(i))
            End If
        Next
        'clear the list view items, then add the ones i want to keep
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub

    'filter by date
    Sub filterDate(mode As String)
        'declare a list of the list view items to keep
        Dim newList As New List(Of ListViewItem)
        'if it's filtering by finding all orders before a certain date
        If mode = "Before" Then
            'For j = 0 To ListView1.Items.Count - 1

            'loop through all of the items in the list view
            For i = 0 To ListView1.Items.Count - 1

                'determine if the list view item is acceptable under the filter and act accordingly
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(2).Text).Date > DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next

        'if it's filtering by finding all the orders due after a certain date
        ElseIf mode = "After" Then
            ''For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            'loop through all the items in the list view
            For i = 0 To ListView1.Items.Count - 1

                'determine if the list view item is acceptable under the filter and act accordingly
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(2).Text).Date < DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next

        'if its filtering by finding all the orders due on a certain date
        ElseIf mode = "On" Then
            'For j = 0 To ListView1.Items.Count - 1 - countDestroyed
            For i = 0 To ListView1.Items.Count - 1
                'determine if the current list view item fits the filter and act accordingly
                If (Convert.ToDateTime(ListView1.Items(i).SubItems(2).Text).Date <> DateTimePicker1.Value) Then
                    removed.Add(ListView1.Items(i))
                Else
                    newList.Add(ListView1.Items(i))
                End If
            Next
            'Next
        End If
        'remove the list view items, and add only the items that fit the filter
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())

    End Sub

    'filter by customer
    Sub filterCustomer()
        'declare list of list view items to store only the fitting items
        Dim newList As New List(Of ListViewItem)

        'loop through all of the list view items
        For i = 0 To ListView1.Items.Count - 1

            'check if the item fits under the filter
            If (ListView1.Items(i).SubItems(1).Text <> txt_Cust.Text) Then
                removed.Add(ListView1.Items(i))
            Else
                newList.Add(ListView1.Items(i))
            End If
        Next

        'clear all the items then add only the ones that fit the filter
        ListView1.Items.Clear()
        ListView1.Items.AddRange(newList.ToArray())
    End Sub




    'populating the filter combo boxes


    'Populate the CPU combo box
    Sub CPUPopulate()

        'clear the items currently present
        cmb_CPU.Items.Clear()

        'store all of the values that have been found so far 
        Dim vals As New List(Of String)

        'store whether the current item that is being added to the list is already there
        Dim found As Boolean

        'loop through the list view
        For i = 0 To ListView1.Items.Count - 1
            'reset whether the current item that is being added to the list is already there
            found = False
            'check whether the current item that is being added to the list is already there
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(4).Text Then
                    found = True
                End If
            Next
            'if it's not already in the list, add it
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(4).Text)
            End If
        Next

        'add the values we found to the combo box
        cmb_CPU.Items.AddRange(vals.ToArray)
    End Sub


    'populate the GPU combo box
    Sub GPUPopulate()
        'clear all the items currently present
        cmb_GPU.Items.Clear()

        'store all of the values that have been found so far
        Dim vals As New List(Of String)

        'store whether the current item that is being added to the list is already there
        Dim found As Boolean

        'loop through the list view
        For i = 0 To ListView1.Items.Count - 1
            'reset whether the current item that is being added to the list is already there
            found = False
            'check whether the current item that is being added to the list is already there
            For j = 0 To vals.Count - 1
            'its its not already in the list, add it
                If vals(j) = ListView1.Items(i).SubItems(5).Text Then
                    found = True
                End If
            Next
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(5).Text)
            End If
        Next

        'add the values we found to the combo box
        cmb_GPU.Items.AddRange(vals.ToArray)
    End Sub

    'populate the RAM combo box
    Sub RAMPopulate()
    'clear the items currently present
        cmb_RAM.Items.Clear()

        'store all the values that have been found so far
        Dim vals As New List(Of String)
        ' store whether the current item that is being added to the list is already there
        Dim found As Boolean
        'loop through the list view
        For i = 0 To ListView1.Items.Count - 1
            'reset whether the current item that is being added to the list is already there
            found = False
            'check whether the current item that is being added to the list is already there
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(6).Text Then
                    found = True
                End If
            Next
            'if its not already in the list, add it
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(6).Text)
            End If
        Next
        'add the values we found to the combo box 
        cmb_RAM.Items.AddRange(vals.ToArray)
    End Sub

    'populate the case box
    Sub casePopulate()
        'clear the items currently present
        cmb_Case.Items.Clear()

        'store all the values that have been found so far
        Dim vals As New List(Of String)
        'store whether the current item that is being added to the list is already there
        Dim found As Boolean
        'loop through the list view
        For i = 0 To ListView1.Items.Count - 1
            'reset whether the current item that is being added to the list is already there
            found = False
            'check whether the current item that is being added to the list is already there
            For j = 0 To vals.Count - 1
                If vals(j) = ListView1.Items(i).SubItems(8).Text Then
                    found = True
                End If
            Next
            'if its not already in the list, add it
            If found = False Then
                vals.Add(ListView1.Items(i).SubItems(8).Text)
            End If
        Next
        'add the values we found
        cmb_Case.Items.AddRange(vals.ToArray)
    End Sub


    'clearing filters
    Private Sub clearfilter_click(sender As Object, e As EventArgs) Handles btn_Clear.Click
    'add the items that got removed during filtering
        ListView1.Items.AddRange(removed.ToArray())
        'clear the list of items that have been removed
        removed.Clear()

        'reset the filtering components of the form
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


    'going back to the navigation screen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Navigation.Show()
    End Sub



    'deleting
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'store the ID of the order
        Dim oID As Integer
        'loop through all the selected items
        While ListView1.SelectedItems.Count > 0
            'store the ID of the order found in the list view item
            Dim item As Integer = ListView1.SelectedItems(0).SubItems(0).Text
            'the order to delete
            Dim o As Order
            'loop through all the orders to see if its the right one
            For j = 0 To AllOrders.Count - 1
                'check if we found the right order
                If item = AllOrders(j).id Then
                    oID = j
                End If
            Next
            'set o to the Order at the ID of the one selected to delete
            o = AllOrders(oID)
            'set the ID to itself times -1, subtract one so that it will always end up below 0, so its marked to be deleted
            o.id = (o.id * -1) - 1

            AllOrders(oID) = o

            Dim newOS As New List(Of orderStock)
            For i = 0 To AllOrderStock.Count - 1
                If AllOrderStock(i).order <> ListView1.SelectedItems(0).SubItems(0).Text Then
                    newOS.Add(AllOrderStock(i))
                End If
            Next
            AllOrderStock.Clear()
            AllOrderStock.AddRange(newOS)

            ListView1.Items.Remove(ListView1.SelectedItems(0))


        End While
        writeOrder()
    End Sub


    'saving when closed
    Private Sub seeOrders_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        writeOrder()
    End Sub
    'saving when closed
    Private Sub seeOrders_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        writeOrder()
    End Sub


    'opening editorder
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'if an item has been selected
        If ListView1.SelectedItems.Count = 1 Then
            'show the edit order page and configure it based on the order that has been selected
            EditOrder.Show()
            EditOrder.editOrderSetup(ListView1.SelectedItems(0).SubItems(0).Text)
            Me.Hide()
            'if the user has selected multiple items to edit, ask them to only select one
        ElseIf ListView1.SelectedItems.Count > 1 Then
            MsgBox("Please only select one item to it")
        Else
            'if they've not selected anything then ask them to
            MsgBox("Please select an item to edit")
        End If

    End Sub

    Private Sub seeOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

