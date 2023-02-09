﻿Public Module FileHandler

    
    'read from the orders file
    Public Sub readOrders()
        'open the file called order.txt for input
        FileOpen(1, "order.txt", OpenMode.Input)
        'store  temporary order
        Dim o As New Order
        'loop until the end of the file
        While Not EOF(1)
            'input the order details
            Input(1, o.id)
            Input(1, o.customer)
            Input(1, o.due)
            Input(1, o.price)
            AllOrders.Add(o)
        End While
        'close the file
        FileClose(1)
    End Sub
    
    'read from the stock file
    Public Sub readStock()
        'open the file called stock.txt for input
        FileOpen(1, "stock.txt", OpenMode.Input)
        'store  temporary stock
        Dim s As New Stock
        'loop until the end of the file
        While Not EOF(1)
            'input the stock details
            Input(1, s.ID)
            Input(1, s.type)
            Input(1, s.part)
            Input(1, s.ordered)
            Input(1, s.Due)
            Input(1, s.arrived)
            Input(1, s.cost)
            AllStock.Add(s)
        End While
        'close the file
        FileClose(1)
    End Sub


    'read from the orderstock file
    Public Sub readOrderStock()
        'open the file called orderstock.txt for input
        FileOpen(1, "orderStock.txt", OpenMode.Input)
        'store  temporary orderstock
        Dim o As New orderStock
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, o.ID)
            Input(1, o.order)
            Input(1, o.stock)
            AllOrderStock.Add(o)
        End While
        'close the file
        FileClose(1)
    End Sub

    'read from the user file
    Public Sub readUser()
        'open the file called user.txt for input
        FileOpen(1, "users.txt", OpenMode.Input)
        'store  temporary order
        Dim u As New user
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, u.ID)
            Input(1, u.username)
            Input(1, u.password)
            Input(1, u.permission)
            AllUsers.Add(u)
        End While
        'close the file
        FileClose(1)
    End Sub

    'write to the file for orders
    Public Sub writeOrder()
        'open the file called order.txt for output
        FileOpen(1, "order.txt", OpenMode.Output)
        'loop through all of the orders
        For i = 0 To AllOrders.Count - 1
            'if it has not been marked for deletion
            If AllOrders(i).id >= 0 Then
                'write that data to the file
                WriteLine(1, AllOrders(i).id, AllOrders(i).customer, AllOrders(i).due, AllOrders(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub

    'write to the file for stock
    Public Sub writeStockFile()
        'open the file called stock.txt for output
        FileOpen(1, "stock.txt", OpenMode.Output)
        'loop through all of the stock
        For i = 0 To AllStock.Count - 1
            'if it has not been marked for deletion
            If AllStock(i).ID >= 0 Then
                'write that data to the file
                WriteLine(1, AllStock(i).ID, AllStock(i).type, AllStock(i).part, AllStock(i).ordered, AllStock(i).Due, AllStock(i).arrived, AllStock(i).cost)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub

    'write to the file for orderstock
    Public Sub writeOrderStock()
        'open the file called orderstock.txt for output
        FileOpen(1, "orderStock.txt", OpenMode.Output)
        'loop through all of the orderstock
        For i = 0 To AllOrderStock.Count - 1
            'write that data to the file
            WriteLine(1, AllOrderStock(i).ID, AllOrderStock(i).order, AllOrderStock(i).stock)
        Next
        'close the file
        FileClose(1)
    End Sub

    'write to the file for users
    Public Sub writeUser()
        'open the file called users.txt for output
        FileOpen(1, "users.txt", OpenMode.Output)
        'loop through all of the users
        For i = 0 To AllUsers.Count - 1
            'if it has not been marked for deletion
            If AllUsers(i).ID >= 0 Then
                'write that data to the file
                WriteLine(1, AllUsers(i).ID, AllUsers(i).username, AllUsers(i).password, AllUsers(i).permission)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub

    Sub writeCPU()
        FileOpen(1, "CPU.text", OpenMode.Output)
        For i = 0 To AllCPUs.Count - 1
            If AllCPUs(i).ID >= 0 Then
                WriteLine(1, AllCPUs(i).ID, AllCPUs(i).name, AllCPUs(i).manufacturer, AllCPUs(i).socket, AllCPUs(i).cores, AllCPUs(i).baseSpeed, AllCPUs(i).boostSpeed, AllCPUs(i).TPD, AllCPUs(i).price)
            End If
        Next
    End Sub

    Sub writeGPU()
        FileOpen(1, "GPU.text", OpenMode.Output)
        For i = 0 To AllGPUs.Count - 1
            If AllGPUs(i).ID >= 0 Then
                WriteLine(1, AllGPUs(i).ID, AllGPUs(i).Series, AllGPUs(i).Model, AllGPUs(i).manufacturer, AllGPUs(i).chipmanufacturer, AllGPUs(i).baseclock, AllCPUs(i).VRAM, AllGPUs(i).TPD, AllGPUs(i).price)
            End If
        Next
    End Sub
    Sub writeRAM()
        FileOpen(1, "RAM.text", OpenMode.Output)
        For i = 0 To AllRAMs.Count - 1
            If AllRAMs(i).ID >= 0 Then
                WriteLine(1, allrams(i).id, allrams(i).name,allrams(i).manufacturer,allrams(i).latency,allrams(i).speed,allrams(i).ddr,allrams(i).tpd,allrams(i).dims,allrams(i).price)
            End If
        Next
    End Sub


    Sub writePSU()
        FileOpen(1, "PSU.text", OpenMode.Output)
        For i = 0 To AllPSUs.Count - 1
            If AllPSUs(i).ID >= 0 Then
                WriteLine(1, AllPSUs(i).id,AllPSUs(i).name,AllPSUs(i).manufacturer,AllPSUs(i).efficiency,AllPSUs(i).modular,AllPSUs(i).power,AllPSUs(i).price)
            End If
        Next
    end sub
End Module
