Public Class PartsNaviagtion
    'if the user clicks the back button, navigate back to the navigation page
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Navigation.Show()
        Me.Hide()
    End Sub
    'if the user clicks to see the CPU, naviagate to the parts page and set it up accordingly
    Private Sub btn_CPU_Click(sender As Object, e As EventArgs) Handles btn_CPU.Click
        parts.setup("CPU")
        parts.Show()
        Me.Hide()
    End Sub
    'if the user clicks to see the GPU, naviagate to the parts page and set it up accordingly
    Private Sub btn_GPU_Click(sender As Object, e As EventArgs) Handles btn_GPU.Click
        parts.setup("GPU")
        parts.Show()
        Me.Hide()
    End Sub
    'if the user clicks to see the RAM, naviagate to the parts page and set it up accordingly
    Private Sub btn_RAM_Click(sender As Object, e As EventArgs) Handles btn_RAM.Click
        parts.setup("RAM")
        parts.Show()
        Me.Hide()
    End Sub
    'if the user clicks to see the PSU, naviagate to the parts page and set it up accordingly
    Private Sub btn_PSU_Click(sender As Object, e As EventArgs) Handles btn_PSU.Click
        parts.setup("PSU")
        parts.Show()
        Me.Hide()
    End Sub
    'if the user clicks to see the case, naviagate to the parts page and set it up accordingly
    Private Sub btn_case_Click(sender As Object, e As EventArgs) Handles btn_case.Click
        parts.setup("Case")
        parts.Show()
        Me.Hide()
    End Sub
    'if the user clicks to see the motherboard, naviagate to the parts page and set it up accordingly
    Private Sub btn_moba_Click(sender As Object, e As EventArgs) Handles btn_moba.Click
        parts.setup("Motherboard")
        parts.Show()
        Me.Hide()
    End Sub
    'if the user clicks to see the storage, naviagate to the parts page and set it up accordingly
    Private Sub btn_sto_Click(sender As Object, e As EventArgs) Handles btn_sto.Click
        parts.setup("Storage")
        parts.Show()
        Me.Hide()
    End Sub

End Class