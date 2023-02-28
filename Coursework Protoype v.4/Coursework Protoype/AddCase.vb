Public Class AddCase
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim c As cases
        c.id = AllCases.Count
        c.name = txt_name.Text
        c.manufacturer = txt_manu.Text
        c.HDDs = txt_HDD.Text
        c.SSDs = txt_SSD.Text
        c.price = txt_price.Text
        AllCases.Add(c)
        writeCases()
        parts.Show()
        Me.Hide()
        parts.setup(parts.ptype)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class