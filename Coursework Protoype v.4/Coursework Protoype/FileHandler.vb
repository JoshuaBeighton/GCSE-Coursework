Public Module FileHandler

    'Sub readOrders(ByRef AllOrders As List(Of Order))
    Public Sub readOrders()
        FileOpen(1, "order.txt", OpenMode.Input)
        Dim o As New Order
        While Not EOF(1)

            Input(1, o.id)
            Input(1, o.customer)
            Input(1, o.due)
            Input(1, o.price)
            AllOrders.Add(o)
        End While
        FileClose(1)
    End Sub
    'Sub readStock(ByRef AllStock As List(Of Stock))
    Public Sub readStock()
        FileOpen(1, "stock.txt", OpenMode.Input)
        Dim s As New Stock
        While Not EOF(1)
            Input(1, s.ID)
            Input(1, s.type)
            Input(1, s.part)
            Input(1, s.ordered)
            Input(1, s.Due)
            Input(1, s.arrived)
            Input(1, s.cost)
            AllStock.Add(s)
        End While
        FileClose(1)
    End Sub

    Public Sub readOrderStock()
        FileOpen(1, "orderStock.txt", OpenMode.Input)
        Dim o As New orderStock
        While Not EOF(1)
            Input(1, o.ID)
            Input(1, o.order)
            Input(1, o.stock)
            AllOrderStock.Add(o)
        End While
        FileClose(1)
    End Sub

    Public Sub readUser()
        FileOpen(1, "users.txt", OpenMode.Input)
        Dim u As New user
        While Not EOF(1)
            Input(1, u.ID)
            Input(1, u.username)
            Input(1, u.password)
            Input(1, u.permission)
            AllUsers.Add(u)
        End While
        FileClose(1)
    End Sub


    Public Sub writeOrder()
        FileOpen(1, "order.txt", OpenMode.Output)
        For i = 0 To AllOrders.Count - 1
            If AllOrders(i).id >= 0 Then
                WriteLine(1, AllOrders(i).id, AllOrders(i).customer, AllOrders(i).due, AllOrders(i).price)
            End If
        Next
        FileClose(1)
    End Sub
    Public Sub writeStockFile()
        FileOpen(1, "stock.txt", OpenMode.Output)
        For i = 0 To AllStock.Count - 1
            WriteLine(1, AllStock(i).ID, AllStock(i).type, AllStock(i).part, AllStock(i).ordered, AllStock(i).Due, AllStock(i).arrived, AllStock(i).cost)
        Next
        FileClose(1)
    End Sub

    Public Sub writeOrderStock()
        FileOpen(1, "orderStock.txt", OpenMode.Output)
        For i = 0 To AllOrderStock.Count - 1
            WriteLine(1, AllOrderStock(i).ID, AllOrderStock(i).order, AllOrderStock(i).stock)
        Next
        FileClose(1)
    End Sub
    Public Sub writeUser()
        FileOpen(1, "users.txt", OpenMode.Output)
        For i = 0 To AllUsers.Count - 1
            If AllUsers(i).ID >= 0 Then
                WriteLine(1, AllUsers(i).ID, AllUsers(i).username, AllUsers(i).password, AllUsers(i).permission)
            End If
        Next
        FileClose(1)
    End Sub
End Module
