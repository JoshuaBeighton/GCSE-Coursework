Module ExtraMethods
    Public Function findNextIndex(source As String) As Integer
        Dim max As Integer
        Select Case source
            Case "AllLogs"
                If AllLogs.Count > 0 Then
                    max = AllLogs(0).id
                    For i = 0 To AllLogs.Count - 1
                        If AllLogs(i).id > max Then
                            max = AllLogs(i).id
                        End If
                    Next
                    Return max
                Else
                    Return 0
                End If
                'more work here
        End Select
    End Function
End Module
