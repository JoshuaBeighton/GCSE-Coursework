Public Class EditOrder
    'store the ID of the order to be edited
    Dim oID As Integer
    'store the ID of the stock item storing the CPU
    Dim sCPU As Integer
    'store the ID of the stock item storing the RAM
    Dim sRAM As Integer
    'store the ID of the stock item storing the GPU
    Dim sGPU As Integer
    'store the ID of the stock item storing the Motherboard
    Dim sMoba As Integer
    'store the ID of the stock item storing the Case
    Dim sCase As Integer
    'store the ID of the stock item storing the PSU
    Dim sPSU As Integer
    'store the IDs of the stock items storing the storage
    Public sSto As New List(Of Integer)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        'if the user has entered a case
        If txt_Case.Text <> "" Then
            'if the user has entered a CPU
            If txt_CPU.Text <> "" Then
                'if the user has entered a customer
                If txt_cust.Text <> "" Then
                    'if the user has entered a gpu
                    If txt_GPU.Text <> "" Then
                        'if the user has entered a motherboard
                        If txt_motherboard.Text <> "" Then
                            'if the user has entered a price
                            If txt_price.Text <> "" Then
                                'if the user entered a PSU
                                If txt_PSU.Text <> "" Then
                                    'if the user entered RAM
                                    If txt_RAM.Text <> "" Then
                                        'if the user has entered a storage device
                                        If lst_sto.Items.Count <> 0 Then
                                            'order structure to store the edited data
                                            Dim o As New Order
                                            'set the ID of O equal to the ID of the order that's being edited
                                            o.id = AllOrders(oID).id
                                            'declare a new list to store all of the order items that don't match the order
                                            Dim newlist As New List(Of orderStock)
                                            'loop through the order stock list
                                            For i = 0 To AllOrderStock.Count - 1
                                                'if the order in the orderstock list at position i doesn't match the id of the order
                                                If AllOrderStock(i).order <> o.id Then
                                                    'add that orderstock item to the new list
                                                    newlist.Add(AllOrderStock(i))
                                                End If
                                            Next
                                            'set orderstock equal to the new list
                                            AllOrderStock = newlist
                                            'set the value of the customer equal to the value in txt cust
                                            o.customer = custID
                                            'set the due date equal to whats in date_due
                                            o.due = date_due.Value
                                            'set the order at position oID to O
                                            o.price = txt_price.Text
                                            AllOrders(oID) = o
                                            'declare a new item to store the orderstock items
                                            Dim os As New orderStock
                                            'set the ID to the next available orderstock id
                                            os.ID = findNextIndex("OrderStock")
                                            'set the orderstock order id to the id of the order
                                            os.order = o.id
                                            'set the orderstock stock id to the stock id of the cpu
                                            os.stock = sCPU
                                            'add the orderstock item to the list
                                            AllOrderStock.Add(os)


                                            'set the order id of the orderstock item to the next available one
                                            os.ID = findNextIndex("OrderStock")
                                            'set the stock id of the orderstock id to the stock ID of the GPU
                                            os.stock = sGPU
                                            'add the orderstock item to the list
                                            AllOrderStock.Add(os)


                                            'set the order id of the orderstock item to the next available one
                                            os.ID = findNextIndex("OrderStock")
                                            'set the stock id of the orderstock id to the stock ID of the RAM
                                            os.stock = sRAM
                                            'add the orderstock item to the list
                                            AllOrderStock.Add(os)


                                            'set the order id of the orderstock item to the next available one
                                            os.ID = findNextIndex("OrderStock")
                                            'set the stock id of the orderstock id to the stock ID of the PSU
                                            os.stock = sPSU
                                            'add the orderstock item to the list
                                            AllOrderStock.Add(os)


                                            'set the order id of the orderstock item to the next available one
                                            os.ID = findNextIndex("OrderStock")
                                            'set the stock id of the orderstock id to the stock ID of the case
                                            os.stock = sCase
                                            'add the orderstock item to the list
                                            AllOrderStock.Add(os)


                                            'set the order id of the orderstock item to the next available one
                                            os.ID = findNextIndex("OrderStock")
                                            'set the stock id of the orderstock id to the stock ID of the motherboard
                                            os.stock = sMoba
                                            'add the orderstock item to the list
                                            AllOrderStock.Add(os)

                                            'loop through the added storage items
                                            For i = 0 To lst_sto.Items.Count - 1
                                                'set the order id of the orderstock item to the next available one
                                                os.ID = findNextIndex("OrderStock")
                                                'set the stock id of the orderstock id to the stock ID of the motherboard
                                                os.stock = sSto(i)
                                                'add the orderstock item to the list
                                                AllOrderStock.Add(os)
                                            Next

                                            'write to the order, orderstock and stock files
                                            FileHandler.writeOrder()
                                            FileHandler.writeOrderStock()
                                            FileHandler.writeStockFile()
                                            'navigation back to see orders
                                            seeOrders.Show()
                                            Me.Hide()
                                            'initialise see orders
                                            seeOrders.initialiseAllOrders()
                                            'temporarily store the log data
                                            Dim l As log
                                            'set the ID to the next available log ID
                                            l.id = findNextIndex("AllLogs")
                                            'set the data of the log
                                            l.user = Form1.currentUser
                                            l.action = "Edit"
                                            l.data = o.id & " " & o.customer & " " & o.due
                                            l.time = Now
                                            'add the temporary log to the log file
                                            AllLogs.Add(l)
                                            'write to the log filr
                                            writeLogs()
                                            'if the user didn't enter a storage device
                                        Else
                                            'ask them to
                                            MsgBox("Please enter which storage device(s) will be used in the order")
                                        End If
                                        'if the user didn't enter the RAM
                                    Else
                                        'ask them to
                                        MsgBox("Please enter which RAM will be used in the order")
                                    End If
                                    'if the user didn't enter the PSU
                                Else
                                    'ask them to
                                    MsgBox("Please enter which PSU will be used in the order")
                                End If
                                'if the user didn't enter the price
                            Else
                                'ask them to
                                MsgBox("Please enter the price of the order")
                            End If
                            'if the user didn't enter the motherboard
                        Else
                            'ask them to
                            MsgBox("Please enter which motherboard will be used in the order")
                        End If
                        'if the user didn't enter the GPU
                    Else
                        'ask them to
                        MsgBox("Please enter which GPU will be used in the order")
                    End If
                    'if the user didn't enter the customer of the order
                Else
                    'ask them to
                    MsgBox("Please enter the custommer of the order")
                End If
                'if the user didn't enter the CPU of the order
            Else
                'ask them to
                MsgBox("Please enter which CPU will be used in the order")
            End If
            'if the user didn't enter the case to be user in the order
        Else
            MsgBox("Please enter which case will be used in the order")
        End If

    End Sub
    'when the user presses the button to add storage
    Private Sub btn_AddStorage_Click(sender As Object, e As EventArgs) Handles btn_AddStorage.Click
        'add the item in the text box 
        lst_sto.Items.Add(txt_sto.Text)
        txt_sto.Clear()
        txt_sto.Select()
    End Sub

    'when the user presses the back button
    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        'navigate back to see orders
        Me.Hide()
        seeOrders.Show()
    End Sub
    'setup the edit order form 
    Public Sub editOrderSetup(id As Integer)
        'store the ID of the order
        Dim orderID As Integer = -1
        'loop through all the order
        For i = 0 To AllOrders.Count - 1
            'if theID of the order at position i is equal to the ID we're after
            If AllOrders(i).id = id Then
                'set the order id to where we are in the list
                orderID = i
            End If
        Next
        'if we have found the order
        If orderID <> -1 Then
            'set the customer text box equal to the customer in the order
            For i = 0 To allCustomers.Count - 1
                If AllOrders(orderID).customer = allCustomers(i).ID Then
                    txt_cust.Text = allCustomers(i).firstName & " " & allCustomers(i).lastName
                End If
            Next
            txt_price.Text = AllOrders(orderID).price
            'set the due date box equal to the date stored in the order
            date_due.Value = AllOrders(orderID).due
            'store the start index of the orderstock items
            Dim startIndex As Integer = -1
            'store the index of the loop
            Dim index As Integer
            'while we have neither found the start index of the orderstock items or found the end of the orderstock list
            While startIndex = -1 And index < AllOrderStock.Count
                'if we have found the first index of the correct order
                If AllOrderStock(index).order = id Then
                    'set the start index to the current index
                    startIndex = index
                Else
                    'if we have not found it, increment by one
                    index += 1
                End If
            End While
            'set the index equal to the start index
            index = startIndex
            'loop through all the stock items
            For i = 0 To AllStock.Count - 1
                'do different things depending on the ID of the stock item
                Select Case AllStock(i).ID
                    'if it is the item at the first index that of the orderstock file that is from the order we are editing (I store the items in the order CPU, GPU, RAM, PSU, case, motherboard, storage)
                    Case AllOrderStock(index).stock
                        'store the ID of the stock item for the CPU
                        sCPU = AllStock(i).ID
                        'loop through all of the cpus
                        For j = 0 To AllCPUs.Count - 1
                            'if we have found the correct cpu
                            If AllCPUs(j).ID = AllStock(i).part Then
                                'set the textbox equal to the name of the cpu
                                txt_CPU.Text = AllCPUs(j).name
                            End If
                        Next
                    'if it is the item at the second index that of the orderstock file that is from the order we are editing
                    Case AllOrderStock(index + 1).stock
                        'store the ID of the stock item for the GPU
                        sGPU = AllStock(i).ID
                        'loop through all of the gpus
                        For j = 0 To AllGPUs.Count - 1
                            'if we have found the correct gpu
                            If AllGPUs(j).ID = AllStock(i).part Then
                                'set the textbox equal to the name of the gpu
                                txt_GPU.Text = AllGPUs(j).Series & " " & AllGPUs(j).Model
                            End If
                        Next
                    'if it is the item at the third index that of the orderstock file that is from the order we are editing
                    Case AllOrderStock(index + 2).stock
                        'store the ID of the stock item for the RAM
                        sRAM = AllStock(i).ID
                        'loop through all of the ram items
                        For j = 0 To AllRAMs.Count - 1
                            'if we have found the correct ram
                            If AllRAMs(j).ID = AllStock(i).part Then
                                'set the textbox equal to the name of the ram
                                txt_RAM.Text = AllRAMs(j).name & " " & AllRAMs(j).capacity
                            End If
                        Next
                    'if it is the item at the fourth index that of the orderstock file that is from the order we are editing
                    Case AllOrderStock(index + 3).stock
                        'store the ID of the stock item for the PSU
                        sPSU = AllStock(i).ID
                        'loop through all of the PSUs
                        For j = 0 To AllPSUs.Count - 1
                            'if we have found the correct psu
                            If AllPSUs(j).ID = AllStock(i).part Then
                                'set the textbox equal to the name of the PSU
                                txt_PSU.Text = AllPSUs(j).name & " " & AllPSUs(j).power
                            End If
                        Next
                    'if it is the item at the fifth index that of the orderstock file that is from the order we are editing
                    Case AllOrderStock(index + 4).stock
                        'store the ID of the stock item for the Case
                        sCase = AllStock(i).ID
                        'loop through all of the cases
                        For j = 0 To AllCases.Count - 1
                            'if we have found the correct cases
                            If AllCases(j).id = AllStock(i).part Then
                                'set the textbox equal to the name of the case
                                txt_Case.Text = AllCases(j).name
                            End If
                        Next
                    'if it is the item at the sixth index that of the orderstock file that is from the order we are editing
                    Case AllOrderStock(index + 5).stock
                        'store the ID of the stock item for the Motherboard
                        sMoba = AllStock(i).ID
                        'loop through all of the motherboard
                        For j = 0 To AllMoba.Count - 1
                            'if we have found the correct motherboard
                            If AllMoba(j).id = AllStock(i).part Then
                                'set the textbox equal to the name of the motherboard
                                txt_motherboard.Text = AllMoba(j).name
                            End If
                        Next
                End Select
            Next
            'add 6 to the index
            index += 6
            'clear the list of storage items
            lst_sto.Items.Clear()
            'store whether we have found the end of which items belong to the current order
            Dim foundEnd As Boolean = False
            'loop while the index is less than the end of the stock file and we haven't found the end of the storage items
            While index <= AllOrderStock.Count - 1 And Not foundEnd
                'if the order in the orderstock file at the position index is equal to the order id then
                If AllOrderStock(index).order = orderID Then
                    'loop through the stock items
                    For i = 0 To AllStock.Count - 1
                        'if the id of the stock item in the orderstock list is equal to the stock item at position i
                        If AllStock(i).ID = AllOrderStock(index).stock Then
                            'add the index of the stock item that stores the data about the storage item to the list of indexes
                            sSto.Add(AllStock(i).ID)
                            'loop through the storage list
                            For j = 0 To AllStorage.Count - 1
                                'if we find the storage part that is being referenced by the stock file
                                If AllStorage(j).ID = AllStock(i).part Then
                                    'add the name, capacity and type to thelist box
                                    lst_sto.Items.Add(AllStorage(j).name & " " & AllStorage(j).capacity & " " & AllStorage(j).type)
                                End If
                            Next
                        End If
                    Next
                Else
                    'if we found the end of the current order, store that we have found the end of the current in orderstock to terminate the loop
                    foundEnd = True
                End If
                'increment the index
                index += 1
            End While
            'if we can't find the order
        Else
            'notify the user
            MsgBox("There was an issue locating the order")
        End If
        'set the order ID
        oID = orderID
    End Sub
    'store the type of component that we are waiting for when we go to the see stock page
    Dim Type As String
    'when the user clicks to edit the cpu
    Private Sub lbl_CPU_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_CPU.LinkClicked
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a CPU
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("CPU")
        'store that we are waiting for a CPU
        Type = "CPU"
        'set the textbox of the price equal to itself minus the cost of the original CPU
        txt_price.Text = Convert.ToDecimal(txt_price.Text) - (AllStock(sCPU).cost * 1.1)
    End Sub

    Private Sub lbl_ram_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_ram.LinkClicked
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select RAM
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("RAM")
        'store that we are waiting for RAM
        Type = "RAM"
        'set the value of the text box equal to itself without the ram
        txt_price.Text = Convert.ToDecimal(txt_price.Text) - (AllStock(sRAM).cost * 1.1)
    End Sub

    Private Sub lbl_case_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_case.LinkClicked
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a case
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("Case")
        'store that we are waiting for a case
        Type = "Case"
        'set the text box that stores the price to itself minus the cost of the original case
        txt_price.Text = Convert.ToDecimal(txt_price.Text) - (AllStock(sCase).cost * 1.1)
    End Sub

    Private Sub lbl_gpu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_gpu.LinkClicked
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a GPU
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("GPU")
        'store that we are waiting for a GPU
        Type = "GPU"
        'set the text box that stores the price to itself minus the cost of the original GPU
        txt_price.Text = Convert.ToDecimal(txt_price.Text) - (AllStock(sGPU).cost * 1.1)
    End Sub

    Private Sub lbl_psu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_psu.LinkClicked
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a PSU
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("PSU")
        'store that we are waiting for a PSU
        Type = "PSU"
        'set the text box that stores the price to itself minus the cost of the original PSU
        txt_price.Text = Convert.ToDecimal(txt_price.Text) - (AllStock(sPSU).cost * 1.1)
    End Sub

    Private Sub lbl_motherboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_motherboard.LinkClicked
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a motherboard
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("Motherboard")
        'store that we are waiting for a motherboard
        Type = "Motherboard"
        'set the text box that stores the price to itself minus the cost of the original motherboard
        txt_price.Text = Convert.ToDecimal(txt_price.Text) - (AllStock(sMoba).cost * 1.1)
    End Sub

    'on returning from the see stock page 
    Sub onReturn(index As Integer)
        txt_price.Text = Convert.ToDecimal(txt_price.Text) + (AllStock(index).cost * 1.1)

        'do different things depending on which part we are waiting to get back
        Select Case Type
            'if we're waiting to get a CPU back
            Case "CPU"
                'store the ID of the selected item
                sCPU = index
                'loop through the stock list
                For i = 0 To AllStock.Count - 1
                    'if the selected item is the currently checked item in allstock
                    If index = AllStock(i).ID Then
                        'set the value of the text box to the name of the part
                        For j = 0 To AllCPUs.Count - 1
                            If AllCPUs(j).ID = AllStock(i).part Then
                                txt_CPU.Text = AllCPUs(j).name
                            End If
                        Next
                    End If
                Next
            'if we're waiting to get a GPU back
            Case "GPU"
                'store the ID of the selected item
                sGPU = index
                'loop through the stock list
                For i = 0 To AllStock.Count - 1
                    'if the selected item is the currently checked item in allstock
                    If index = AllStock(i).ID Then
                        'set the value of the text box to the name of the part
                        For j = 0 To AllGPUs.Count - 1
                            If AllGPUs(j).ID = AllStock(i).part Then
                                txt_GPU.Text = AllGPUs(j).Series & " " & AllGPUs(j).Model
                            End If
                        Next
                    End If
                Next
            'if we're waiting to get a PSU back
            Case "PSU"
                'store the ID of the selected item
                sPSU = index
                'loop through the stock list
                For i = 0 To AllStock.Count - 1
                    'if the selected item is the currently checked item in allstock
                    If index = AllStock(i).ID Then
                        'set the value of the text box to the name of the part
                        For j = 0 To AllPSUs.Count - 1
                            If AllPSUs(j).ID = AllStock(i).part Then
                                txt_PSU.Text = AllPSUs(j).name & " " & AllPSUs(j).power & "W"
                            End If
                        Next
                    End If
                Next
            'if we're waiting to get a case back
            Case "Case"
                'store the ID of the selected item
                sCase = index
                'loop through the stock list
                For i = 0 To AllStock.Count - 1
                    'if the selected item is the currently checked item in allstock
                    If index = AllStock(i).ID Then
                        'set the value of the text box to the name of the part
                        For j = 0 To AllCases.Count - 1
                            If AllCases(j).id = AllStock(i).part Then
                                txt_Case.Text = AllCases(j).name
                            End If
                        Next
                    End If
                Next
            'if we're waiting to get a motehrboard back
            Case "Motherboard"
                'store the ID of the selected item
                sMoba = index
                'loop through the stock list
                For i = 0 To AllStock.Count - 1
                    'if the selected item is the currently checked item in allstock
                    If index = AllStock(i).ID Then
                        'set the value of the text box to the name of the part
                        For j = 0 To AllMoba.Count - 1
                            If AllMoba(j).id = AllStock(i).part Then
                                txt_motherboard.Text = AllMoba(j).name
                            End If
                        Next
                    End If
                Next
            'if we're waiting to get RAM back
            Case "RAM"
                'store the ID of the selected item
                sRAM = index
                'loop through the stock list
                For i = 0 To AllStock.Count - 1
                    'if the selected item is the currently checked item in allstock
                    If index = AllStock(i).ID Then
                        'set the value of the text box to the name of the part
                        For j = 0 To AllRAMs.Count - 1
                            If AllRAMs(j).ID = AllStock(i).part Then
                                txt_RAM.Text = AllRAMs(j).name & AllRAMs(j).capacity & "GB"
                            End If
                        Next
                    End If
                Next
            'if we're waiting to get storage back
            Case "Storage"
                'loop through the stock list
                For i = 0 To AllStock.Count - 1
                    'if the selected item is the currently checked item in allstock
                    If index = AllStock(i).ID Then
                        'set the value of the text box to the name of the part
                        For j = 0 To AllStorage.Count - 1
                            If AllStorage(j).ID = AllStock(i).part Then
                                lst_sto.Items.Add(AllStorage(j).name + " " & AllStorage(j).capacity & "GB " & AllStorage(j).type)
                            End If
                        Next
                    End If
                Next
                'store the ID of the selected item
                sSto.Add(index)
        End Select
    End Sub

    Private Sub lbl_Cust_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_Cust.LinkClicked
        'navigate to the customers page
        Customers.Show()
        Me.Hide()
        'initialise the customers page
        Customers.custInit()
        'store that we are selecting an item and it should return to the edit order page when an item is selected not the add order page
        Customers.selecting = True
        Customers.editing = True
    End Sub
    'store the ID of the customer
    Dim custID As Integer
    'on returning from selecting a cusotmer
    Public Sub onCustReturn(id As Integer)
        'store the id of the customer
        custID = id
        'loop through all the customers
        For i = 0 To allCustomers.Count - 1
            'if we find the one who's ID matches the ID of the one that was double clicked by the user
            If allCustomers(i).ID = id Then
                'set the textbox for the customer name equal to their name
                txt_cust.Text = allCustomers(i).firstName & " " & allCustomers(i).lastName
            End If
        Next
    End Sub
    'when the form loads
    Private Sub EditOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'send the decorative picturebox to the back
        PictureBox1.SendToBack()
    End Sub
End Class