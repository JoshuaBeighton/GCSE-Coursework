Public Class Write
    Dim sCPU As Integer
    Dim sRAM As Integer
    Dim sGPU As Integer
    Dim sMoba As Integer
    Dim sCase As Integer
    Dim sPSU As Integer
    Dim sSto As New List(Of Integer)
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
        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = sCPU
        AllOrderStock.Add(os)

        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = sGPU
        AllOrderStock.Add(os)



        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = sRAM
        AllOrderStock.Add(os)



        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = sPSU
        AllOrderStock.Add(os)

        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = sCase
        AllOrderStock.Add(os)

        os.ID = AllOrderStock.Count
        os.order = o.id
        os.stock = sMoba
        AllOrderStock.Add(os)


        For i = 0 To sSto.Count - 1
            os.ID = AllOrderStock.Count
            os.stock = sSto(i)
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

        'write all of the changes to the files
        FileHandler.writeOrder()
        FileHandler.writeOrderStock()
        FileHandler.writeStockFile()
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

    Private Sub selCPU_Click(sender As Object, e As EventArgs) Handles selCPU.Click
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("CPU")
        type = "CPU"
    End Sub
    Public type As String

    Private Sub selRAM_Click(sender As Object, e As EventArgs) Handles selRAM.Click
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("RAM")
        type = "RAM"
    End Sub

    Private Sub selCase_Click(sender As Object, e As EventArgs) Handles selCase.Click
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("Case")
        type = "Case"
    End Sub

    Private Sub selGPU_Click(sender As Object, e As EventArgs) Handles selGPU.Click
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("GPU")
        type = "GPU"
    End Sub



    Private Sub selMoba_Click(sender As Object, e As EventArgs) Handles selMoba.Click
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("Motherboard")
        type = "Motherboard"
    End Sub
    Sub onReturn(index As Integer)
        Select Case type
            Case "CPU"
                selCPU.Hide()
                txt_CPU.Show()
                sCPU = index
                For i = 0 To AllStock.Count - 1
                    If index = AllStock(i).ID Then
                        txt_CPU.Text = AllStock(i).part
                    End If
                Next
            Case "GPU"
                selGPU.Hide()
                txt_GPU.Show()
                sGPU = index
                For i = 0 To AllStock.Count - 1
                    If index = AllStock(i).ID Then
                        txt_GPU.Text = AllStock(i).part
                    End If
                Next
            Case "PSU"
                selPSU.Hide()
                txt_PSU.Show()
                sPSU = index
                For i = 0 To AllStock.Count - 1
                    If index = AllStock(i).ID Then
                        txt_PSU.Text = AllStock(i).part
                    End If
                Next
            Case "Case"
                selCase.Hide()
                txt_Case.Show()
                sCase = index
                For i = 0 To AllStock.Count - 1
                    If index = AllStock(i).ID Then
                        txt_Case.Text = AllStock(i).part
                    End If
                Next
            Case "Motherboard"
                selMoba.Hide()
                txt_motherboard.Show()
                sMoba = index
                For i = 0 To AllStock.Count - 1
                    If index = AllStock(i).ID Then
                        txt_motherboard.Text = AllStock(i).part
                    End If
                Next
            Case "RAM"
                selRAM.Hide()
                txt_RAM.Show()
                sRAM = index
                For i = 0 To AllStock.Count - 1
                    If index = AllStock(i).ID Then
                        txt_RAM.Text = AllStock(i).part
                    End If
                Next
            Case "Storage"
                For i = 0 To AllStock.Count - 1
                    If index = AllStock(i).ID Then
                        lst_sto.Items.Add(AllStock(i).part)
                    End If
                Next

                sSto.Add(index)
        End Select
    End Sub
    Sub init()
        txt_Case.Hide()
        txt_CPU.Hide()
        txt_GPU.Hide()
        txt_motherboard.Hide()
        txt_PSU.Hide()
        txt_RAM.Hide()
        selCase.Show()
        selCPU.Show()
        selGPU.Show()
        selMoba.Show()
        selPSU.Show()
        selRAM.Show()
    End Sub
    Private Sub selPSU_Click(sender As Object, e As EventArgs) Handles selPSU.Click
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
        seeStock.selectInit("PSU")
        type = "PSU"
    End Sub
End Class