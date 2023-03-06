Public Class Navigation

    
    Sub setup(type As Char)
        'show all the text boxes
        btn_cust.Show()
        btn_logs.Show()
        btn_orders.Show()
        btn_parts.Show()
        btn_sales.Show()
        btn_stock.Show()
        btn_staff.Show()
        'if the user is an accountant
        If type = "A" Then
            'hide all irrelavant buttons
            btn_stock.Hide()
            btn_parts.Hide()
            btn_orders.Hide()
            btn_logs.Hide()
            btn_cust.Hide()
            btn_staff.Hide()
        'if user is staff member
        ElseIf type = "S" Then
            'hide irrelavant buttons
            btn_logs.Hide()
            btn_staff.Hide()
            btn_sales.Hide()
        End If
    End Sub

    'navigate to the orders for when the orders button is clicked
    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        seeOrders.Show()
        Me.Hide()
    End Sub

    'navigate to the stock form when the button is clicked
    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        seeStock.Show()
        Me.Hide()
    End Sub

    'go back to the login form when the user signs out
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    'go to the parts form when the user clicks on the parts button
    Private Sub btn_parts_Click(sender As Object, e As EventArgs) Handles btn_parts.Click
        PartsNaviagtion.Show()
        Me.Hide()
    End Sub


    Private Sub btn_logs_Click(sender As Object, e As EventArgs) Handles btn_logs.Click
        Logs.Show()
        Me.Hide()
        Logs.init()
    End Sub

    Private Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click
        Customers.Show()
        Customers.custInit()
        Me.Hide()
    End Sub
End Class