Public Class Navigation
    Private Sub Navigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setup(type As Char)
        'show and enable all of the buttons
        btn_sales.Show()
        btn_sales.Enabled = True
        btn_cust.Show()
        btn_cust.Enabled = True
        btn_logs.Show()
        btn_logs.Enabled = True
        btn_order.Show()
        btn_order.Enabled = True
        btn_part.Show()
        btn_part.Enabled = True
        btn_staff.Show()
        btn_staff.Enabled = True
        btn_stock.Show()
        btn_stock.Enabled = True

        'if the user is a staff member then hide sales data and program logs
        If type.ToString.ToUpper = "S" Then
            btn_sales.Hide()
            btn_sales.Enabled = False
            btn_logs.Hide()
            btn_logs.Enabled = False
        ElseIf type.ToString.ToUpper = "A" Then
            btn_cust.Hide()
            btn_cust.Enabled = False
            btn_logs.Hide()
            btn_logs.Enabled = False
            btn_order.Hide()
            btn_order.Enabled = False
            btn_part.Hide()
            btn_part.Enabled = False
            btn_staff.Hide()
            btn_staff.Enabled = False
            btn_stock.Hide()
            btn_stock.Enabled = False
        End If
    End Sub
End Class