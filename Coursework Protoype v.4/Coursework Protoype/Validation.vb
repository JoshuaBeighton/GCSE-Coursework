Module Validation

    'check that the order has sufficient power
    Public Function powerCheck(c As CPU, g As GPU, r As RAM, p As PSU) As Boolean
        'if the power drawn by the components exceeds the PSU power spec
        If (c.TPD + g.TPD + r.tpd) > p.power Then
            'tell the user and stop the order from being made / edited
            MsgBox("The power supply does not provide enough power")
            Return False
        End If
        'if there is not sufficient overhead on the power supply 
        If (c.TPD + g.TPD + r.tpd) * 1.1 > p.power Then
            'warn the user but allow it to pass
            MsgBox("Warning: The Power Supply should provide more power")
        End If
        'return true if there is sufficient power
        Return True
    End Function
    'check the socket matches on the cpu and motherboard
    Public Function socketCheck(m As motherboard, c As CPU)
        'if the sockets match
        If m.socket = c.socket Then
            'return that the check has passed
            Return True
        End If
        'if the cpu socket and motherboard socket don't match, tell the user and stop the order from being made
        MsgBox("The motherboard and CPU must have matching sockets")
        Return False
    End Function
    'check that there are enough ports on the motherboard for the storage
    Public Function connctionsCheck(m As motherboard, s() As store) As Boolean
        'store how many sata ports are needed
        Dim SATA As Integer
        'store how many m.2 ports are needed
        Dim m2 As Integer
        'loop through the storage devices used in the order
        For i = 0 To s.Length - 1
            'if we find one that uses a sata connection
            If s(i).connection = "SATA" Then
                'increment the SATA counter by 1
                SATA += 1
            End If
            'if we find one that uses an m.2 connection
            If s(i).connection = "M.2" Then
                'increment the m.2 counter by 1
                m2 += 1
            End If

        Next
        'store whether the check has passed or failed
        Dim flag As Boolean = True
        'if we ndont have enough sata ports
        If SATA > m.SATAs Then
            'tell the user and stop the order from going through
            MsgBox("Not enough SATA ports on motherboard")
            flag = False
        End If
        'if there aren't enough m.2 slots on the motherboard
        If m2 > m.m2s Then
            'tell the user and stop the order from going through
            MsgBox("Not enough M.2 ports on motherboard")
            flag = False
        End If
        'return the flag
        Return flag
    End Function


    'check there are enough slots in the case for the storage devices
    Public Function slotsCheck(c As cases, s() As store) As Boolean
        'store how many HDDs and SSDs there are
        Dim hdd As Integer
        Dim ssd As Integer
        'loop through the storage devices
        For i = 0 To s.Length - 1
            'if the type is a HDD
            If s(i).type = "HDD" Then
                'increment the hdd counter by one
                hdd += 1
                'if the type is an SSD
            ElseIf s(i).type = "SSD" Then
                'increment the SSD counter
                ssd += 1
            End If
        Next
        'store the result of the check
        Dim flag As Boolean = True
        'if there are too many HDDs
        If hdd > c.HDDs Then
            'stop the order from progressing and warn the user
            flag = False
            MsgBox("Not Enough Slots for the HDDs")
        End If
        'if there are too many HDDs
        If ssd > c.SSDs Then
            'warn the user
            MsgBox("Not Enough Slots for the SSDs")
        End If
        Return flag
    End Function


End Module
