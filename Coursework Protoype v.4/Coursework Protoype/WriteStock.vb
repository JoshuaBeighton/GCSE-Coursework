Public Class WriteStock


    Private Sub btn_AddOrder_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        'if the user has selected a type
        If cmb_type.SelectedIndex >= 0 Then
            'if the user has entered a part
            If txt_part.Text.Length > 0 Then
                'if the user has entered a price
                If txt_price.Text.Length > 0 Then
                    'create a new stock item
                    Dim s As New Stock
                    'set the stock item's ID to the amount of stock plus one
                    s.ID = AllStock.Count
                    'set the rest of the data according to what the user has entered
                    s.ordered = date_ordered.Value
                    s.Due = date_due.Value
                    s.cost = Convert.ToInt32(txt_price.Text)
                    s.arrived = chk_arrived.Checked
                    s.type = cmb_type.SelectedItem
                    s.part = txt_part.Text
                    AllStock.Add(s)

                    'clear the UI elements
                    txt_part.Clear()
                    txt_price.Clear()
                    chk_arrived.Checked = False
                    cmb_type.SelectedIndex = -1
                    cmb_type.Text = ""
                Else
                    'ask the user to enter a price
                    MsgBox("Please Enter a Price")
                End If
            Else
                'ask the user to enter a part
                MsgBox("Please Enter a Part")
            End If
        Else
            'ask the user to enter a type
            MsgBox("Please Select A Type")
        End If

    End Sub

    'go back to the main database
    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        Me.Close()
        seeStock.Show()
    End Sub
End Class