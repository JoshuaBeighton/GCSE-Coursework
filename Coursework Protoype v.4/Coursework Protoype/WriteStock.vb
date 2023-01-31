Public Class WriteStock


    Private Sub btn_AddOrder_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        If cmb_type.SelectedIndex >= 0 Then
            If txt_part.Text.Length > 0 Then
                If txt_price.Text.Length > 0 Then
                    Dim s As New Stock
                    s.ID = AllStock.Count
                    s.ordered = date_ordered.Value
                    s.Due = date_due.Value
                    s.cost = Convert.ToInt32(txt_price.Text)
                    s.arrived = chk_arrived.Checked
                    s.type = cmb_type.SelectedItem
                    s.part = txt_part.Text
                    AllStock.Add(s)


                    txt_part.Clear()
                    txt_price.Clear()
                    chk_arrived.Checked = False
                    cmb_type.SelectedIndex = -1
                    cmb_type.Text = ""
                Else
                    MsgBox("Please Enter a Price")
                End If
            Else
                MsgBox("Please Enter a Part")
            End If
        Else
            MsgBox("Please Select A Type")
        End If

    End Sub

    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        Me.Close()
        seeStock.Show()
    End Sub
End Class