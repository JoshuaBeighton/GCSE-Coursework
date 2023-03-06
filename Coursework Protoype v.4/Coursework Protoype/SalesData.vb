Public Class SalesData
    Sub init()
        For i = 0 To allSales.Count - 1
            Dim l As New ListViewItem
            l.SubItems(0).Text = allSales(i).id
            l.SubItems.Add(allSales(i).amount)
            l.SubItems.Add(allSales(i).time)
            ListView1.Items.Add(l)
        Next
    End Sub

    Private Sub SalesData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns.Add("ID", 30)
        ListView1.Columns.Add("Amount", 200)
        ListView1.Columns.Add("Date", ListView1.Width - 230)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub
End Class