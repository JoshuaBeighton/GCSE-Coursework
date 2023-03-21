Public Class Logs

    'initialise the log file
    Public Sub init()
        'string to store the log data
        Dim s As String
        'for each of the logs
        For i = 0 To AllLogs.Count - 1
            'set s to the ID plus a space, and add all of the log data seperated by ", "s
            s = AllLogs(i).id & ", "
            s = s + AllLogs(i).time & ", "
            s = s + AllLogs(i).user & ", "
            s = s + AllLogs(i).action & ", "
            s = s + AllLogs(i).data
            'add s to the listbox
            ListBox1.Items.Add(s)
        Next
    End Sub
    'when the user presses the button to go back
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'navigate to the navigation page
        Me.Hide()
        Navigation.Show()
    End Sub
End Class