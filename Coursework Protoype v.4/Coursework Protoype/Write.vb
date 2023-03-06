Imports System.Threading

Public Class Write
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
    'store the id of the customer of the order
    Dim custID As Integer
    'store the IDs of the stock items storing the storage
    Public sSto As New List(Of Integer)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        Dim c As CPU
        Dim g As GPU
        Dim r As RAM
        Dim m As motherboard
        Dim p As PSU
        Dim ca As cases
        Dim s(sSto.Count - 1) As store
        For i = 0 To AllCPUs.Count - 1
            If sCPU = AllCPUs(i).ID Then
                c = AllCPUs(i)
            End If
        Next
        For i = 0 To AllGPUs.Count - 1
            If sGPU = AllGPUs(i).ID Then
                g = AllGPUs(i)
            End If
        Next
        For i = 0 To AllRAMs.Count - 1
            If sRAM = AllRAMs(i).ID Then
                r = AllRAMs(i)
            End If
        Next
        For i = 0 To AllMoba.Count - 1
            If sMoba = AllMoba(i).id Then
                m = AllMoba(i)
            End If
        Next
        For i = 0 To AllPSUs.Count - 1
            If sPSU = AllPSUs(i).ID Then
                p = AllPSUs(i)
            End If
        Next
        For j = 0 To sSto.Count - 1
            For i = 0 To AllStorage.Count - 1
                If sSto(j) = AllStorage(i).ID Then
                    s(j) = AllStorage(i)
                End If
            Next
        Next
        For i = 0 To AllCases.Count - 1
            If sCase = AllCases(i).id Then
                ca = AllCases(i)
            End If
        Next
        If powerCheck(c, g, r, p) And socketCheck(m, c) And connctionsCheck(m, s) And slotsCheck(ca, s) Then

            'create new order to store all of the data
            Dim o As New Order
            'set the ID to equal the amount of orders plus one
            o.id = AllOrders.Count
            'set the customer to the value of the text box for customers
            o.customer = custID
            'set the due date to the datetimepicker value
            o.due = date_due.Value
            'add o to orders
            AllOrders.Add(o)
            Dim l As log
            l.id = findNextIndex("AllLogs")
            l.user = Form1.currentUser
            l.action = "Delete"
            l.data = o.id & o.customer & o.price
            l.time = Now
            AllLogs.Add(l)
            writeLogs()
            'create new orderstock item
            Dim os As New orderStock
            'set its ID to the count of orderstock items
            os.ID = AllOrderStock.Count
            'set its order ID to that of the Order - this will not need to be changed again as it is the same for all orderstock items for the same order
            os.order = o.id
            'set its stock ID to that of the CPU
            os.stock = sCPU
            'add the orderstock item
            AllOrderStock.Add(os)

            'set its ID to the count of orderstock items
            os.ID = AllOrderStock.Count
            'set its stock ID to that of the GPU
            os.stock = sGPU
            'add the orderstock item
            AllOrderStock.Add(os)


            'set its ID to the count of orderstock items
            os.ID = AllOrderStock.Count
            'set its stock ID to that of the RAM
            os.stock = sRAM
            'add the orderstock item
            AllOrderStock.Add(os)


            'set its ID to the count of orderstock items
            os.ID = AllOrderStock.Count
            'set its stock ID to that of the PSU
            os.stock = sPSU
            'add the orderstock item
            AllOrderStock.Add(os)

            'set its ID to the count of orderstock items
            os.ID = AllOrderStock.Count
            'set its stock ID to that of the case
            os.stock = sCase
            'add the orderstock item
            AllOrderStock.Add(os)

            'set its ID to the count of orderstock items
            os.ID = AllOrderStock.Count
            'set its stock ID to that of the motherboard
            os.stock = sMoba
            'add the orderstock item
            AllOrderStock.Add(os)

            'loop through the storage devices
            For i = 0 To sSto.Count - 1
                'set the orderstock ID to the count of orderstock items
                os.ID = AllOrderStock.Count
                'set its stock ID to that of the current storage device
                os.stock = sSto(i)
                'add the orderstock item
                AllOrderStock.Add(os)
            Next

            'clear all of the values
            txt_Case.Clear()
            txt_CPU.Clear()
            txt_cust.Clear()
            txt_GPU.Clear()
            txt_motherboard.Clear()
            txt_PSU.Clear()
            txt_RAM.Clear()
            lst_sto.Items.Clear()
            txt_cust.Clear()


            'write all of the changes to the files
            FileHandler.writeOrder()
            FileHandler.writeOrderStock()
            FileHandler.writeStockFile()
        End If
    End Sub

    'when the button to add a storage device is pressed
    Private Sub btn_AddStorage_Click(sender As Object, e As EventArgs) Handles btn_AddStorage.Click
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("Storage")
        type = "Storage"
    End Sub

    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click#
        'go back to the main database
        Me.Hide()
        seeOrders.Show()
    End Sub

    'on clicking the select CPU button
    Private Sub selCPU_Click(sender As Object, e As EventArgs) Handles btn_cpu.Click
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a CPU
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("CPU")
        'store that we are waiting for a CPU
        type = "CPU"
    End Sub
    'store what type of item we are waiting to be selected 
    Public type As String

    'on clicking the select RAM button
    Private Sub selRAM_Click(sender As Object, e As EventArgs) Handles btn_RAM.Click
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select RAM
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("RAM")
        'store that we are waiting for RAM
        type = "RAM"
    End Sub

    'on clicking the select Case button
    Private Sub selCase_Click(sender As Object, e As EventArgs) Handles btn_Case.Click
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a case
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("Case")
        'store that we are waiting for a case
        type = "Case"
    End Sub

    'on clicking the select GPU button
    Private Sub selGPU_Click(sender As Object, e As EventArgs) Handles btn_GPU.Click
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a GPU
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("GPU")
        'store that we are waiting for a GPU
        type = "GPU"
    End Sub


    'on clicking the select motherboard button
    Private Sub selMoba_Click(sender As Object, e As EventArgs) Handles btn_Moba.Click
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a motherboard
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("Motherboard")
        'store that we are waiting for a motherboard
        type = "Motherboard"
    End Sub

    'on returning from the see stock page 
    Sub onReturn(index As Integer)
        'do different things depending on which part we are waiting to get back
        Select Case type
            'if we're waiting to get a CPU back
            Case "CPU"
                'hide the button to select and show the text box that shows which item was selected
                btn_cpu.Hide()
                txt_CPU.Show()
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
                'hide the button to select and show the text box that shows which item was selected
                btn_GPU.Hide()
                txt_GPU.Show()
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
                'hide the button to select and show the text box that shows which item was selected
                btn_PSU.Hide()
                txt_PSU.Show()
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
                'hide the button to select and show the text box that shows which item was selected
                btn_Case.Hide()
                txt_Case.Show()
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
                'hide the button to select and show the text box that shows which item was selected
                btn_Moba.Hide()
                txt_motherboard.Show()
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
                'hide the button to select and show the text box that shows which item was selected
                btn_RAM.Hide()
                txt_RAM.Show()
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

    'initialise the write page
    Sub init()
        'hide all of the text boxes that store the values that have been selected
        txt_Case.Hide()
        txt_CPU.Hide()
        txt_GPU.Hide()
        txt_motherboard.Hide()
        txt_PSU.Hide()
        txt_RAM.Hide()
        'show the buttons that select the items
        btn_Case.Show()
        btn_cpu.Show()
        btn_GPU.Show()
        btn_Moba.Show()
        btn_PSU.Show()
        btn_RAM.Show()
        btn_cust.Show()
        txt_cust.Hide()
    End Sub

    'on clicking the select PSU button
    Private Sub selPSU_Click(sender As Object, e As EventArgs) Handles btn_PSU.Click
        'navigate to the see stock page
        Me.Hide()
        seeStock.Show()
        'initialise see stock to select a PSU
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("PSU")
        'store that we are waiting for a PSU
        type = "PSU"
    End Sub

    Private Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click
        Customers.Show()
        Customers.custInit()
        Customers.selecting = True
        Me.Hide()
        btn_cust.Hide()
        txt_cust.Show()
    End Sub

    Public Sub onCustReturn(id As Integer)
        custID = id
        For i = 0 To allCustomers.Count - 1
            If allCustomers(i).ID = id Then
                txt_cust.Text = allCustomers(i).firstName & " " & allCustomers(i).lastName
            End If
        Next
    End Sub
End Class