Public Class EditOrder
    'store the ID of the order to be edited
    Dim oID As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        'order structure to store the edited data
        Dim o As New Order
        'set the ID of O equal to the ID of the order that's being edited
        o.id = AllOrders(oID).id
        'set the value of the customer equal to the value in txt cust
        o.customer = txt_cust.Text
        'set the due date equal to whats in date_due
        o.due = date_due.Value
        'set the order at position oID to O
        AllOrders(oID) = o

        'this will be changed in final
        Dim os As New orderStock
        Dim s As New Stock
        s.ID = AllStock.Count
        s.type = "CPU"
        s.part = txt_CPU.Text
        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "GPU"
        s.part = txt_GPU.Text
        os.ID = AllOrderStock.Count
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "RAM"
        s.part = txt_RAM.Text
        os.ID = AllOrderStock.Count
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "PSU"
        s.part = txt_PSU.Text
        os.ID = AllOrderStock.Count
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "Case"
        s.part = txt_Case.Text
        os.ID = AllOrderStock.Count
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "Motherboard"
        s.part = txt_motherboard.Text
        os.ID = AllOrderStock.Count
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)




        For i = 0 To lst_sto.Items.Count - 1
            s.ID = AllStock.Count
            s.type = "Storage"
            s.part = lst_sto.Items(i)
            os.ID = AllOrderStock.Count
            os.stock = s.ID
            AllOrderStock.Add(os)
            AllStock.Add(s)
        Next


        txt_Case.Clear()
        txt_CPU.Clear()
        txt_cust.Clear()
        txt_GPU.Clear()
        txt_motherboard.Clear()
        txt_PSU.Clear()
        txt_RAM.Clear()
        txt_sto.Clear()
        lst_sto.Items.Clear()

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
            txt_cust.Text = AllOrders(orderID).customer
            'set the due date box equal to the date stored in the order
            date_due.Value = AllOrders(orderID).due
            Dim startIndex As Integer = -1
            Dim index As Integer
            While startIndex = -1 And index < AllOrderStock.Count
                If AllOrderStock(index).order = orderID Then
                    startIndex = index
                End If
                index += 1
            End While
            index -= 1
            txt_CPU.Text = AllStock(AllOrderStock(index).stock).part
            txt_GPU.Text = AllStock(AllOrderStock(index + 1).stock).part
            txt_RAM.Text = AllStock(AllOrderStock(index + 2).stock).part
            txt_PSU.Text = AllStock(AllOrderStock(index + 3).stock).part
            txt_Case.Text = AllStock(AllOrderStock(index + 4).stock).part
            txt_motherboard.Text = AllStock(AllOrderStock(index + 5).stock).part
            index += 6
            lst_sto.Items.Clear()
            While index <= AllOrderStock.Count - 1
                If AllOrderStock(index).order = orderID Then
                    lst_sto.Items.Add(AllStock(AllOrderStock(index).stock).part)

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
            MsgBox("Oopsie Daisie, there was a problem!")
        End If
        oID = orderID
    End Sub

End Class