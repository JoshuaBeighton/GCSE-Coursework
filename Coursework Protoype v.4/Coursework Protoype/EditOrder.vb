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
        If txt_Case.Text <> "" Then
            If txt_CPU.Text <> "" Then
                If txt_cust.Text <> "" Then
                    If txt_GPU.Text <> "" Then
                        If txt_motherboard.Text <> "" Then
                            If txt_price.Text <> "" Then
                                If txt_PSU.Text <> "" Then
                                    If txt_RAM.Text <> "" Then
                                        If lst_sto.Items.Count <> 0 Then
                                            'order structure to store the edited data
                                            Dim o As New Order
                                            'set the ID of O equal to the ID of the order that's being edited
                                            o.id = AllOrders(oID).id
                                            'set the value of the customer equal to the value in txt cust
                                            o.customer = custID
                                            'set the due date equal to whats in date_due
                                            o.due = date_due.Value
                                            'set the order at position oID to O
                                            o.price = txt_price.Text
                                            AllOrders(oID) = o

                                            Dim os As New orderStock
                                            os.ID = AllOrderStock.Count
                                            os.order = o.id
                                            os.stock = sCPU
                                            AllOrderStock.Add(os)



                                            os.ID = AllOrderStock.Count
                                            os.stock = sGPU
                                            AllOrderStock.Add(os)



                                            os.ID = AllOrderStock.Count
                                            os.stock = sRAM
                                            AllOrderStock.Add(os)


                                            os.ID = AllOrderStock.Count
                                            os.stock = sPSU
                                            AllOrderStock.Add(os)

                                            os.ID = AllOrderStock.Count
                                            os.stock = sCase
                                            AllOrderStock.Add(os)

                                            os.ID = AllOrderStock.Count
                                            os.stock = sMoba
                                            AllOrderStock.Add(os)


                                            For i = 0 To lst_sto.Items.Count - 1
                                                os.ID = AllOrderStock.Count
                                                os.stock = sSto(i)
                                                AllOrderStock.Add(os)
                                            Next


                                            FileHandler.writeOrder()
                                            FileHandler.writeOrderStock()
                                            FileHandler.writeStockFile()
                                            seeOrders.Show()
                                            Me.Hide()
                                            seeOrders.initialiseAllOrders()
                                            Dim l As log
                                            l.id = findNextIndex("AllLogs")
                                            l.user = Form1.currentUser
                                            l.action = "Edit"
                                            l.data = o.id & o.customer & o.due
                                            l.time = Now
                                            AllLogs.Add(l)
                                            writeLogs()
                                        Else
                                            MsgBox("Please enter which storage device(s) will be used in the order")
                                        End If
                                    Else
                                        MsgBox("Please enter which RAM will be used in the order")
                                    End If
                                Else
                                    MsgBox("Please enter which PSU will be used in the order")
                                End If
                            Else
                                MsgBox("Please enter the price of the order")
                            End If
                        Else
                            MsgBox("Please enter which motherboard will be used in the order")
                        End If
                    Else
                        MsgBox("Please enter which GPU will be used in the order")
                    End If
                Else
                    MsgBox("Please enter the custommer of the order")
                End If
            Else
                MsgBox("Please enter which CPU will be used in the order")
            End If
        Else
            MsgBox("Please enter which case will be used in the order")
        End If

    End Sub

    Private Sub btn_AddStorage_Click(sender As Object, e As EventArgs) Handles btn_AddStorage.Click
        lst_sto.Items.Add(txt_sto.Text)
        txt_sto.Clear()
        txt_sto.Select()
    End Sub

    'go back to see orders
    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
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
            Dim startIndex As Integer = -1
            Dim index As Integer
            While startIndex = -1 And index < AllOrderStock.Count
                If AllOrderStock(index).order = id Then
                    startIndex = index
                Else
                    index += 1
                End If
            End While
            index = startIndex
            For i = 0 To AllStock.Count - 1
                Select Case AllStock(i).ID
                    Case AllOrderStock(index).stock
                        sCPU = AllStock(i).ID
                        For j = 0 To AllCPUs.Count - 1
                            If AllCPUs(j).ID = AllStock(i).part Then
                                txt_CPU.Text = AllCPUs(j).name
                            End If
                        Next
                    Case AllOrderStock(index + 1).stock
                        sGPU = AllStock(i).ID
                        For j = 0 To AllGPUs.Count - 1
                            If AllGPUs(j).ID = AllStock(i).part Then
                                txt_GPU.Text = AllGPUs(j).Series & " " & AllGPUs(j).Model
                            End If
                        Next
                    Case AllOrderStock(index + 2).stock
                        sRAM = AllStock(i).ID
                        For j = 0 To AllRAMs.Count - 1
                            If AllRAMs(j).ID = AllStock(i).part Then
                                txt_RAM.Text = AllRAMs(j).name & " " & AllRAMs(j).capacity
                            End If
                        Next
                    Case AllOrderStock(index + 3).stock
                        sPSU = AllStock(i).ID
                        For j = 0 To AllPSUs.Count - 1
                            If AllPSUs(j).ID = AllStock(i).part Then
                                txt_PSU.Text = AllPSUs(j).name & " " & AllPSUs(j).power
                            End If
                        Next
                    Case AllOrderStock(index + 4).stock
                        sCase = AllStock(i).ID
                        For j = 0 To AllCases.Count - 1
                            If AllCases(j).id = AllStock(i).part Then
                                txt_Case.Text = AllCases(j).name
                            End If
                        Next
                    Case AllOrderStock(index + 5).stock
                        sMoba = AllStock(i).ID
                        For j = 0 To AllMoba.Count - 1
                            If AllMoba(j).id = AllStock(i).part Then
                                txt_motherboard.Text = AllMoba(j).name
                            End If
                        Next
                End Select

            Next
            index += 6
            lst_sto.Items.Clear()
            Dim foundEnd As Boolean = False
            While index <= AllOrderStock.Count - 1 And Not foundEnd
                If AllOrderStock(index).order = orderID Then
                    For i = 0 To AllStock.Count - 1
                        If AllStock(i).ID = AllOrderStock(index).stock Then
                            sSto.Add(AllStock(i).ID)
                            For j = 0 To AllStorage.Count - 1
                                If AllStorage(j).ID = AllStock(i).part Then
                                    lst_sto.Items.Add(AllStorage(j).name & " " & AllStorage(j).capacity & " " & AllStorage(j).type)
                                End If
                            Next
                        End If
                    Next
                Else
                    foundEnd = True
                End If
                index += 1
            End While
            Dim newlist As New List(Of orderStock)
            For i = 0 To AllOrderStock.Count - 1
                If AllOrderStock(i).order <> id Then
                    newlist.Add(AllOrderStock(i))
                End If
            Next
            AllOrderStock = newlist
        Else
            MsgBox("There was an issue locating the order")
        End If
        oID = orderID
    End Sub
    Dim Type As String
    Private Sub lbl_CPU_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_CPU.LinkClicked
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a CPU
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("CPU")
        'store that we are waiting for a CPU
        Type = "CPU"
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
        Customers.Show()
        Me.Hide()
        Customers.custInit()
        Customers.selecting = True
        Customers.editing = True
    End Sub
    Dim custID As Integer
    Public Sub onCustReturn(id As Integer)
        custID = id
        For i = 0 To allCustomers.Count - 1
            If allCustomers(i).ID = id Then
                txt_cust.Text = allCustomers(i).firstName & " " & allCustomers(i).lastName
            End If
        Next
    End Sub

    Private Sub EditOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SendToBack()
    End Sub
End Class