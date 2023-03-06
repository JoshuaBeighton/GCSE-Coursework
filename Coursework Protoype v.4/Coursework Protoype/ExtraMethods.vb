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
            Case "CPU"
                If AllCPUs.Count > 0 Then
                    max = AllCPUs(0).ID
                    For i = 0 To AllCPUs.Count - 1
                        If AllCPUs(i).ID > max Then
                            max = AllCPUs(i).ID
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
            Case "GPU"
                If AllGPUs.Count > 0 Then
                    max = AllGPUs(0).ID
                    For i = 0 To AllGPUs.Count - 1
                        If AllGPUs(i).ID > max Then
                            max = AllGPUs(i).ID
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
            Case "Motherboard"
                If AllMoba.Count > 0 Then
                    max = AllMoba(0).id
                    For i = 0 To AllMoba.Count - 1
                        If AllMoba(i).id > max Then
                            max = AllMoba(i).id
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
            Case "PSU"
                If AllPSUs.Count > 0 Then
                    max = AllPSUs(0).ID
                    For i = 0 To AllPSUs.Count - 1
                        If AllPSUs(i).ID > max Then
                            max = AllPSUs(i).ID
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
            Case "RAM"
                If AllRAMs.Count > 0 Then
                    max = AllRAMs(0).ID
                    For i = 0 To AllRAMs.Count - 1
                        If AllRAMs(i).ID > max Then
                            max = AllRAMs(i).ID
                        End If
                    Next
                    Return max + 1
                Else
                    Return 0
                End If
            Case "Storage"
                If AllStorage.Count > 0 Then
                    max = AllStorage(0).ID
                    For i = 0 To AllStorage.Count - 1
                        If AllStorage(i).ID > max Then
                            max = AllStorage(i).ID
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
