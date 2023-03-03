Public Class Logs
    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub init()
        Dim s As String
        For i = 0 To AllLogs.Count - 1
            s = AllLogs(i).id & ", "
            s = s + AllLogs(i).time & ", "
            s = s + AllLogs(i).user & ", "
            s = s + AllLogs(i).action & ", "
            s = s + AllLogs(i).data
            ListBox1.Items.Add(s)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Navigation.Show()
    End Sub
End Class