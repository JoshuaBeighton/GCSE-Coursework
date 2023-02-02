Public Class Write
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        'create new order to store all of the 
        Dim o As New Order
        'set the ID to equal the amount of orders plus one
        o.id = AllOrders.Count
        'set the customer to the value of the text box for customers
        o.customer = txt_cust.Text
        'set the due date to the datetimepicker value
        o.due = date_due.Value
        'add o to orders
        AllOrders.Add(o)
        
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
        os.order = o.id
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "RAM"
        s.part = txt_RAM.Text
        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "PSU"
        s.part = txt_PSU.Text
        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "Case"
        s.part = txt_Case.Text
        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = s.ID
        AllOrderStock.Add(os)
        AllStock.Add(s)



        s.ID = AllStock.Count
        s.type = "Motherboard"
        s.part = txt_motherboard.Text
        os.ID = AllOrderStock.Count
        os.order = o.id
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

        'clear all of the values
        txt_Case.Clear()
        txt_CPU.Clear()
        txt_cust.Clear()
        txt_GPU.Clear()
        txt_motherboard.Clear()
        txt_PSU.Clear()
        txt_RAM.Clear()
        txt_sto.Clear()
        lst_sto.Items.Clear()

        'write all of the changes to the files
        FileHandler.writeOrder()
        FileHandler.writeOrderStock()
        FileHandler.writeStockFile()
    End Sub

    'when the button to add a storage device is pressed
    Private Sub btn_AddStorage_Click(sender As Object, e As EventArgs) Handles btn_AddStorage.Click
        'add whats in the temporary text box to the list box, clear the text box and select it
        lst_sto.Items.Add(txt_sto.Text)
        txt_sto.Clear()
        txt_sto.Select()
    End Sub

    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click#
        'go back to the main database
        Me.Hide()
        seeOrders.Show()
    End Sub

    
End Class