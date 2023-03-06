Module ExtraMethods
    Public Function findNextIndex(source As String) As Integer
        Dim max As Integer
        Select Case source
            Case "User"
                If AllUsers.Count > 0 Then
                    max = AllUsers(0).ID
                    For i = 0 To AllUsers.Count - 1
                        If AllUsers(i).ID > max Then
                            max = AllUsers(i).ID
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
            Case "Case"
                If AllCases.Count > 0 Then
                    max = AllCases(0).id
                    For i = 0 To AllCases.Count - 1
                        If AllCases(i).id > max Then
                            max = AllCases(i).id
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
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
            Case "Customer"
                If allCustomers.Count > 0 Then
                    max = allCustomers(0).ID
                    For i = 0 To allCustomers.Count - 1
                        If allCustomers(i).ID > max Then
                            max = allCustomers(i).ID
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
        End Select
    End Function
End Module
