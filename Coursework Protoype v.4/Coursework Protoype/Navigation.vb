Public Class Navigation
    Private Sub Navigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub setup(type As Char)
        btn_cust.Show()
        btn_logs.Show()
        btn_orders.Show()
        btn_parts.Show()
        btn_sales.Show()
        btn_stock.Show()
        If type = "A" Then
            btn_stock.Hide()
            btn_parts.Hide()
            btn_orders.Hide()
            btn_logs.Hide()
            btn_cust.Hide()
            btn_staff.Hide()
        ElseIf type = "S" Then
            btn_logs.Hide()
            btn_staff.Hide()
            btn_sales.Hide()
        End If
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        seeOrders.Show()
        Me.Hide()
    End Sub

    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        seeStock.Show()
        Me.Hide()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class