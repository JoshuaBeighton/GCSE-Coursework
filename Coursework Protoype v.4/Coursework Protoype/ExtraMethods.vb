Module ExtraMethods
    'find the next index of a list
    Public Function findNextIndex(source As String) As Integer
        'store the max index of the string
        Dim max As Integer
        'do different things depending on the list who's last index we are looking for
        Select Case source
            'if we're looking for the last index of the users
            Case "User"
                'if there's more than one 
                If AllUsers.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllUsers(0).ID
                    'loop through the list
                    For i = 0 To AllUsers.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllUsers(i).ID > max Then
                            'set the highest to the current one
                            max = AllUsers(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no users
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the orderstock
            Case "OrderStock"
                'if there's more than one 
                If AllOrderStock.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllOrderStock(0).ID
                    'loop through the list
                    For i = 0 To AllOrderStock.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllOrderStock(i).ID > max Then
                            'set the highest to the current one
                            max = AllOrderStock(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no orderstock items
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the Cases
            Case "Case"
                'if there's more than one 
                If AllCases.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllCases(0).id
                    'loop through the list
                    For i = 0 To AllCases.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllCases(i).id > max Then
                            'set the highest to the current one
                            max = AllCases(i).id
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no cases
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the CPUs
            Case "CPU"
                'if there's more than one 
                If AllCPUs.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllCPUs(0).ID
                    'loop through the list
                    For i = 0 To AllCPUs.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllCPUs(i).ID > max Then
                            'set the highest to the current one
                            max = AllCPUs(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no CPUs
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the GPUs
            Case "GPU"
                'if there's more than one 
                If AllGPUs.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllGPUs(0).ID
                    'loop through the list
                    For i = 0 To AllGPUs.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllGPUs(i).ID > max Then
                            'set the highest to the current one
                            max = AllGPUs(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no GPUs
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the motherboards
            Case "Motherboard"
                'if there's more than one 
                If AllMoba.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllMoba(0).id
                    'loop through the list
                    For i = 0 To AllMoba.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllMoba(i).id > max Then
                            'set the highest to the current one
                            max = AllMoba(i).id
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no motherboards
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the psus
            Case "PSU"
                'if there's more than one 
                If AllPSUs.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllPSUs(0).ID
                    'loop through the list
                    For i = 0 To AllPSUs.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllPSUs(i).ID > max Then
                            'set the highest to the current one
                            max = AllPSUs(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no PSUs
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the ram
            Case "RAM"
                'if there's more than one 
                If AllRAMs.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllRAMs(0).ID
                    'loop through the list
                    For i = 0 To AllRAMs.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllRAMs(i).ID > max Then
                            'set the highest to the current one
                            max = AllRAMs(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no RAMs
                Else
                    'return 0
                    Return 0
                End If
                'if we're looking for the last index of the storage
            Case "Storage"
                'if there's more than one 
                If AllStorage.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllStorage(0).ID
                    'loop through the list
                    For i = 0 To AllStorage.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllStorage(i).ID > max Then
                            'set the highest to the current one
                            max = AllStorage(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no storage items
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the logs
            Case "AllLogs"
                'if there's more than one 
                If AllLogs.Count > 0 Then
                    'set the max to the first item in the list
                    max = AllLogs(0).id
                    'loop through the list
                    For i = 0 To AllLogs.Count - 1
                        'if we find an id thats greater than the current highest
                        If AllLogs(i).id > max Then
                            'set the highest to the current one
                            max = AllLogs(i).id
                        End If
                    Next
                    Return max
                    'if there are no logs
                Else
                    'return 0
                    Return 0
                End If
            'if we're looking for the last index of the customers
            Case "Customer"
                'if there's more than one 
                If allCustomers.Count > 0 Then
                    'set the max to the first item in the list
                    max = allCustomers(0).ID
                    'loop through the list
                    For i = 0 To allCustomers.Count - 1
                        'if we find an id thats greater than the current highest
                        If allCustomers(i).ID > max Then
                            'set the highest to the current one
                            max = allCustomers(i).ID
                        End If
                    Next
                    'return the max index plus one
                    Return max + 1
                    'if there are no customers
                Else
                    'return 0
                    Return 0
                End If
        End Select
    End Function
End Module
