Public Class EditStock

    Dim sID As Integer
    Dim osID As Integer = -1
    Private Sub btn_EditOrder_Click(sender As Object, e As EventArgs) Handles btn_EditOrder.Click
        If cmb_type.SelectedIndex >= 0 Then
            If txt_part.Text.Length > 0 Then
                If txt_price.Text.Length > 0 Then
                    Dim s As New Stock
                    s.ID = AllStock(sID).ID
                    s.ordered = date_ordered.Value
                    s.Due = date_due.Value
                    s.cost = Convert.ToInt32(txt_price.Text)
                    s.arrived = chk_arrived.Checked
                    s.type = cmb_type.Text
                    s.part = txt_part.Text
                    AllStock(sID) = s


                    txt_part.Clear()
                    txt_price.Clear()
                    chk_arrived.Checked = False
                    cmb_type.SelectedIndex = -1
                    cmb_type.Text = ""




                    If osID <> -1 Then
                        Dim os As orderStock = AllOrderStock(osID)
                        os.stock = s.ID
                        AllOrderStock(osID) = os
                    End If
                Else
                    MsgBox("Please Enter a Price")
                End If
            Else
                MsgBox("Please Enter a Part")
            End If
        Else
            MsgBox("Please Select A Type")
        End If
        writeStockFile()
        Me.Hide()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
    End Sub

    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        Me.Close()
        seeStock.Show()
        seeStock.InitialiseSeeStock()
    End Sub
    Public Sub initialiseEditStock(id As Integer)
        For i = 0 To AllStock.Count - 1
            If AllStock(i).ID = id Then
                sID = i
            End If
        Next
        For i = 0 To AllOrderStock.Count - 1
            If AllOrderStock(i).stock = sID Then
                osID = i
            End If
        Next
        txt_part.Text = AllStock(sID).part
        txt_price.Text = AllStock(sID).cost
        Try
            date_due.Value = AllStock(sID).Due.Date
            date_ordered.Value = AllStock(sID).ordered.Date
        Catch
        End Try
        chk_arrived.Checked = AllStock(sID).arrived
        cmb_type.Text = AllStock(sID).type
    End Sub
    Private Sub EditStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class