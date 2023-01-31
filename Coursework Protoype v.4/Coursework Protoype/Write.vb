Public Class Write
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        Dim o As New Order
        o.id = AllOrders.Count
        o.customer = txt_cust.Text
        o.due = date_due.Value
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
    End Sub

    Private Sub btn_AddStorage_Click(sender As Object, e As EventArgs) Handles btn_AddStorage.Click
        lst_sto.Items.Add(txt_sto.Text)
        txt_sto.Clear()
        txt_sto.Select()
    End Sub

    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        Me.Hide()
        seeOrders.Show()
    End Sub

    Private Sub date_due_ValueChanged(sender As Object, e As EventArgs) Handles date_due.ValueChanged

    End Sub

    Private Sub lst_sto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_sto.SelectedIndexChanged

    End Sub

    Private Sub txt_sto_TextChanged(sender As Object, e As EventArgs) Handles txt_sto.TextChanged

    End Sub

    Private Sub txt_motherboard_TextChanged(sender As Object, e As EventArgs) Handles txt_motherboard.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt_cust_TextChanged(sender As Object, e As EventArgs) Handles txt_cust.TextChanged

    End Sub

    Private Sub txt_Case_TextChanged(sender As Object, e As EventArgs) Handles txt_Case.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txt_PSU_TextChanged(sender As Object, e As EventArgs) Handles txt_PSU.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txt_RAM_TextChanged(sender As Object, e As EventArgs) Handles txt_RAM.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txt_GPU_TextChanged(sender As Object, e As EventArgs) Handles txt_GPU.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_CPU_TextChanged(sender As Object, e As EventArgs) Handles txt_CPU.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class