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

        End If
    End Sub
End Class