Public Class EditStock

    Dim sID As Integer
    Dim osID As Integer = -1
    Dim partID As Integer
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
                    s.part = partID
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
                    Dim l As log
                    l.id = findNextIndex("AllLogs")
                    l.user = Form1.currentUser
                    l.action = "Edit"
                    l.data = s.ID & s.part & s.cost
                    l.time = Now
                    AllLogs.Add(l)
                    writeLogs()
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
        cmb_type.SelectedItem = AllStock(sID).type
        partID = AllStock(sID).part
    End Sub
    Private Sub EditStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btn_part_Click(sender As Object, e As EventArgs) Handles btn_part.Click
        If cmb_type.SelectedIndex <> -1 Then
            parts.Show()
            Me.Hide()
            parts.setup(cmb_type.SelectedItem)
            parts.selecting = True
            parts.editing = True
        End If
    End Sub
    Public Sub onreturn(index As Integer)
        partID = index
        Select Case cmb_type.SelectedItem
            Case "CPU"
                For i = 0 To AllCPUs.Count - 1
                    If index = AllCPUs(i).ID Then
                        txt_part.Text = AllCPUs(i).name
                        txt_price.Text = AllCPUs(i).price
                    End If
                Next
            Case "GPU"
                For i = 0 To AllGPUs.Count - 1
                    If index = AllGPUs(i).ID Then
                        txt_part.Text = AllGPUs(i).Series
                        txt_price.Text = AllGPUs(i).price
                    End If
                Next
            Case "RAM"
                For i = 0 To AllRAMs.Count - 1
                    If index = AllRAMs(i).ID Then
                        txt_part.Text = AllRAMs(i).name
                        txt_price.Text = AllRAMs(i).price
                    End If
                Next
            Case "PSU"
                For i = 0 To AllPSUs.Count - 1
                    If index = AllPSUs(i).ID Then
                        txt_part.Text = AllPSUs(i).name
                        txt_price.Text = AllPSUs(i).price
                    End If
                Next
            Case "Motherboard"
                For i = 0 To AllMoba.Count - 1
                    If index = AllMoba(i).id Then
                        txt_part.Text = AllMoba(i).name
                        txt_price.Text = AllMoba(i).price
                    End If
                Next
            Case "Storage"
                For i = 0 To AllStorage.Count - 1
                    If index = AllStorage(i).ID Then
                        txt_part.Text = AllStorage(i).name
                        txt_price.Text = AllStorage(i).price
                    End If
                Next
            Case "Case"
                For i = 0 To AllCases.Count - 1
                    If index = AllCases(i).id Then
                        txt_part.Text = AllCases(i).name
                        txt_price.Text = AllCases(i).price
                    End If
                Next
        End Select
        btn_part.Hide()
        txt_part.Show()
    End Sub
End Class