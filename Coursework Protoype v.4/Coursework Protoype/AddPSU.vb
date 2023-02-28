Public Class AddPSU
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim p As New PSU
        p.ID = AllPSUs.Count
        p.name = txt_name.Text
        p.efficiency = txt_effeciency.Text
        p.modular = ComboBox1.SelectedText
        p.manufacturer = txt_manu.Text
        p.power = txt_power.Text
        p.price = txt_price.Text
        AllPSUs.Add(p)
        writePSU()
        parts.Show()
        Me.Hide()
        parts.setup(parts.ptype)
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class