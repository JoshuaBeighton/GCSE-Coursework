Public Module FileHandler

    
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


    'read from the logs file
    Public Sub readLogs()
        'open the file called Logs.txt for input
        FileOpen(1, "Logs.txt", OpenMode.Input)
        'store  temporary log
        Dim l As New log
        'loop until the end of the file
        While Not EOF(1)
            'input the stock details
            Input(1, l.id)
            Input(1, l.user)
            Input(1, l.action)
            Input(1, l.data)
            Input(1, l.time)
            AllLogs.Add(l)
        End While
        'close the file
        FileClose(1)
    End Sub
    Public Sub writeLogs()
        'open the file called Logs.txt for output
        FileOpen(1, "Logs.txt", OpenMode.Output)
        'loop through all of the orders
        For i = 0 To AllLogs.Count - 1
            'if it has not been marked for deletion
            If AllLogs(i).id >= 0 Then
                'write that data to the file
                WriteLine(1, AllLogs(i).id, AllLogs(i).user, AllLogs(i).action, AllLogs(i).data, AllLogs(i).time)
            End If
        Next
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
    Sub readGPU()
        'open the file called GPU.txt for input
        FileOpen(1, "GPU.txt", OpenMode.Input)
        'store  temporary GPU
        Dim g As New GPU
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, g.ID)
            Input(1, g.Series)
            Input(1, g.Model)
            Input(1, g.manufacturer)
            Input(1, g.chipManufacturer)
            Input(1, g.baseClock)
            Input(1, g.VRAM)
            Input(1, g.TPD)
            Input(1, g.price)
            AllGPUs.Add(g)
        End While
        'close the file
        FileClose(1)
    End Sub
    Sub readRAM()
        'open the file called GPU.txt for input
        FileOpen(1, "RAM.txt", OpenMode.Input)
        'store  temporary GPU
        Dim r As New RAM
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, r.ID)
            Input(1, r.name)
            Input(1, r.manufacturer)
            Input(1, r.latency)
            Input(1, r.speed)
            Input(1, r.ddr)
            Input(1, r.tpd)
            Input(1, r.dims)
            Input(1, r.capacity)
            Input(1, r.price)
            AllRAMs.Add(r)
        End While
        'close the file
        FileClose(1)
    End Sub
    Sub readPSU()
        'open the file called GPU.txt for input
        FileOpen(1, "PSU.txt", OpenMode.Input)
        'store  temporary GPU
        Dim p As New PSU
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, p.ID)
            Input(1, p.name)
            Input(1, p.manufacturer)
            Input(1, p.efficiency)
            Input(1, p.modular)
            Input(1, p.power)
            Input(1, p.price)
            AllPSUs.Add(p)
        End While
        'close the file
        FileClose(1)
    End Sub

    Sub readCase()
        'open the file called GPU.txt for input
        FileOpen(1, "Case.txt", OpenMode.Input)
        'store  temporary GPU
        Dim c As New cases
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, c.id)
            Input(1, c.name)
            Input(1, c.manufacturer)
            Input(1, c.HDDs)
            Input(1, c.SSDs)
            Input(1, c.price)
            AllCases.Add(c)
        End While
        'close the file
        FileClose(1)
    End Sub
    Sub readMoba()
        'open the file called GPU.txt for input
        FileOpen(1, "Motherboard.txt", OpenMode.Input)
        'store  temporary GPU
        Dim m As New motherboard
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, m.id)
            Input(1, m.name)
            Input(1, m.manufacturer)
            Input(1, m.ramSlots)
            Input(1, m.socket)
            Input(1, m.SATAs)
            Input(1, m.m2s)
            Input(1, m.price)
            AllMoba.Add(m)
        End While
        'close the file
        FileClose(1)
    End Sub
    Sub readStorage()
        'open the file called Storage.txt for input
        FileOpen(1, "Storage.txt", OpenMode.Input)
        'store  temporary GPU
        Dim s As New store
        'loop until the end of the file
        While Not EOF(1)
            'input the orderstock details
            Input(1, s.ID)
            Input(1, s.name)
            Input(1, s.manufacturer)
            Input(1, s.type)
            Input(1, s.read)
            Input(1, s.write)
            Input(1, s.capacity)
            Input(1, s.connection)
            Input(1, s.price)
            AllStorage.Add(s)
        End While
        'close the file
        FileClose(1)
    End Sub


    Sub readCPU()
        'open the file called CPU.txt for input
        FileOpen(1, "CPU.txt", OpenMode.Input)
        'store  temporary CPU
        Dim c As New CPU
        'loop until the end of the file

        While Not EOF(1)
            
            Input(1, c.ID)
            Input(1, c.name)
            Input(1, c.manufacturer)
            Input(1, c.socket)
            Input(1, c.cores)
            Input(1, c.baseSpeed)
            Input(1, c.boostSpeed)
            Input(1, c.TPD)
            Input(1, c.price)
            AllCPUs.Add(c)
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

    'write CPUs
    Sub writeCPU()
        'open the file called CPU.txt for output
        FileOpen(1, "CPU.txt", OpenMode.Output)
        'loop through all the CPUs
        For i = 0 To AllCPUs.Count - 1
            'if the cpu has not been marked for deletion
            If AllCPUs(i).ID >= 0 Then
                'write to the line
                WriteLine(1, AllCPUs(i).ID, AllCPUs(i).name, AllCPUs(i).manufacturer, AllCPUs(i).socket, AllCPUs(i).cores, AllCPUs(i).baseSpeed, AllCPUs(i).boostSpeed, AllCPUs(i).TPD, AllCPUs(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub

    'write GPUs 
    Sub writeGPU()
        'open the file GPU.txt for output
        FileOpen(1, "GPU.txt", OpenMode.Output)
        'loop through all the GPUs
        For i = 0 To AllGPUs.Count - 1
            'if the GPU has not been marked for deletion
            If AllGPUs(i).ID >= 0 Then
                'write line with the GPU data
                WriteLine(1, AllGPUs(i).ID, AllGPUs(i).Series, AllGPUs(i).Model, AllGPUs(i).manufacturer, AllGPUs(i).chipManufacturer, AllGPUs(i).baseClock, AllGPUs(i).VRAM, AllGPUs(i).TPD, AllGPUs(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub
    'write RAM
    Sub writeRAM()
        'open the file called "RAM.txt" for output
        FileOpen(1, "RAM.txt", OpenMode.Output)
        'loop through the RAM data
        For i = 0 To AllRAMs.Count - 1
            'if the item hasn't been marked for deletion
            If AllRAMs(i).ID >= 0 Then
                'write line with the RAM data
                WriteLine(1, AllRAMs(i).ID, AllRAMs(i).name, AllRAMs(i).manufacturer, AllRAMs(i).latency, AllRAMs(i).speed, AllRAMs(i).ddr, AllRAMs(i).tpd, AllRAMs(i).dims, AllRAMs(i).capacity, AllRAMs(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub

    'write psu data
    Sub writePSU()
        'open the PSU.txt file for output
        FileOpen(1, "PSU.txt", OpenMode.Output)
        'loop through the PSUs
        For i = 0 To AllPSUs.Count - 1
            'if the item hasn't been marked for deletion
            If AllPSUs(i).ID >= 0 Then
                'write line with the data
                WriteLine(1, AllPSUs(i).id, AllPSUs(i).name, AllPSUs(i).manufacturer, AllPSUs(i).efficiency, AllPSUs(i).modular, AllPSUs(i).power, AllPSUs(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub
    'write case data
    Sub writeCases()
        'open the case.txt file for output
        FileOpen(1, "Case.txt", OpenMode.Output)
        'loop through the cases
        For i = 0 To AllCases.Count - 1
            'if the item hasn't been marked for deletion
            If AllCases(i).id >= 0 Then
                'write line with the data
                WriteLine(1, AllCases(i).id, AllCases(i).name, AllCases(i).manufacturer, AllCases(i).HDDs, AllCases(i).SSDs, AllCases(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub

    'write motherboard data
    Sub writeMoba()
        'open the motherboard.txt file for output
        FileOpen(1, "Motherboard.txt", OpenMode.Output)
        'loop through the motherboard
        For i = 0 To AllMoba.Count - 1
            'if the item hasn't been marked for deletion
            If AllMoba(i).id >= 0 Then
                'write line with the data
                WriteLine(1, AllMoba(i).id, AllMoba(i).name, AllMoba(i).manufacturer, AllMoba(i).ramSlots, AllMoba(i).socket, AllMoba(i).SATAs, AllMoba(i).m2s, AllMoba(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub
    'write storage data
    Sub writeStorage()
        'open the storage.txt file for output
        FileOpen(1, "Storage.txt", OpenMode.Output)
        'loop through the storage
        For i = 0 To AllStorage.Count - 1
            'if the item hasn't been marked for deletion
            If AllStorage(i).ID >= 0 Then
                'write line with the data
                WriteLine(1, AllStorage(i).ID, AllStorage(i).name, AllStorage(i).manufacturer, AllStorage(i).type, AllStorage(i).read, AllStorage(i).write, AllStorage(i).capacity, AllStorage(i).connection, AllStorage(i).price)
            End If
        Next
        'close the file
        FileClose(1)
    End Sub

End Module
