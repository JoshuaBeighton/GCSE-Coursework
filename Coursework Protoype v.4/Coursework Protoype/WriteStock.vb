Public Class WriteStock

    Sub init(type As String)
        selecting = True
        cmb_type.SelectedItem = type
        cmb_type.Enabled = False
    End Sub
    Dim selecting As Boolean = False
    Private Sub btn_AddOrder_Click(sender As Object, e As EventArgs) Handles btn_AddOrder.Click
        'create a new stock item
        Dim s As New Stock
        'if the user has selected a type
        If cmb_type.SelectedIndex >= 0 Then
            'if the user has entered a part
            If txt_part.Text.Length > 0 Then
                'if the user has entered a price
                If txt_price.Text.Length > 0 Then

                    'set the stock item's ID to the amount of stock plus one
                    s.ID = AllStock.Count
                    'set the rest of the data according to what the user has entered
                    s.ordered = date_ordered.Value
                    s.Due = date_due.Value
                    s.cost = Convert.ToDecimal(txt_price.Text)
                    s.arrived = chk_arrived.Checked
                    s.type = cmb_type.SelectedItem
                    s.part = partIndex
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
        If selecting Then
            Me.Hide()
            Write.Show()
            Write.onReturn(s.ID)
        End If
    End Sub

    'go back to the main database
    Private Sub btn_navi_Click(sender As Object, e As EventArgs) Handles btn_navi.Click
        Me.Close()
        seeStock.Show()
    End Sub

    Private Sub btn_part_Click(sender As Object, e As EventArgs) Handles btn_part.Click
        If cmb_type.SelectedIndex <> -1 Then
            parts.Show()
            Me.Hide()
            parts.setup(cmb_type.SelectedText)
            parts.selecting = True
        End If

    End Sub
    Dim partIndex As Integer
    Public Sub onreturn(index As Integer)
        partIndex = index
        Select Case cmb_type.SelectedText
            Case "CPU"
                For i = 0 To AllCPUs.Count - 1
                    If index = AllCPUs(i).ID Then
                        txt_part.Text = AllCPUs(i).name
                        txt_price.Text = AllCPUs(i).price
                    End If
                Next
        End Select
    End Sub
End Class