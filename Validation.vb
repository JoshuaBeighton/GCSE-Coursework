Module Validation
    Public Function presenceCheck(input As String) As Boolean
        If input <> "" Then
            Return True
        End If
        MsgBox("Please Enter A Value")
        Return False
    End Function

    Public Function powerCheck(c As CPU, g As GPU, r As RAM, p As PSU) As Boolean
        If (c.TPD + g.TPD + r.tpd) > p.power Then
            MsgBox("The power supply does not provide enough power")
            Return False
        End If
        If (c.TPD + g.TPD + r.tpd) * 1.1 > p.power Then
            MsgBox("Warning: The Power Supply should provide more power")
        End If
        Return True
    End Function

    Public Function socketCheck(m As motherboard, c As CPU)
        If m.socket = c.socket Then
            Debug.WriteLine("Passed")
            Return True
        End If
        MsgBox("The motherboard and CPU must have matching sockets")
        Return False
    End Function

    Public Function connctionsCheck(m As motherboard, s() As store) As Boolean
        Dim SATA As Integer
        Dim m2 As Integer
        For i = 0 To s.Length - 1
            If s(i).connection = "SATA" Then
                SATA += 1
            End If
            If s(i).connection = "M.2" Then
                m2 += 1
            End If

        Next
        Dim flag As Boolean = True
        If SATA > m.SATAs Then
            MsgBox("Not enough SATA ports on motherboard")
            flag = False
        End If
        If m2 > m.m2s Then
            MsgBox("Not enough M.2 ports on motherboard")
            flag = False
        End If

        Return flag
    End Function

    Public Function lenCheck(input As String, min As Integer, max As Integer) As Boolean
        If input.Length < min Then
            MsgBox("Input must be at least " & min.ToString & " characters long")
            Return False
        End If
        If input.Length > max Then
            MsgBox("Input must be at most " & max.ToString & " characters long")
            Return False
        End If
        Debug.WriteLine("Passed")
        Return True
    End Function

    Public Function dateCheck(min As Date, test As Date) As Boolean
        If test < min Then
            MsgBox("Dates must be entered in correct date order")
            Return False
        End If
        Return True
    End Function

    Public Function rangeCheck(min As Integer, val As Integer) As Boolean
        If val >= min Then
            Return True
        End If
        MsgBox("Ensure That All Values Meet Minimum value requirements")
        Return False
    End Function

End Module
