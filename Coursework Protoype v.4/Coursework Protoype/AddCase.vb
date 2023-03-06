Public Class AddCase
    'when the user adds a case
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'if the user has entered the name of the case
        If txt_name.Text <> "" Then
            'if the user has entered the manufacturer of the case
            If txt_manu.Text <> "" Then
                'if the user has entered the amount of HDD slots in the case
                If txt_HDD.Text <> "" Then
                    'if the user has entered the price of the case
                    If txt_price.Text <> "" Then
                        'if the user has entered the amount of SSD slots in the case
                        If txt_SSD.Text <> "" Then
                            'declare a new temporary case variable
                            Dim c As cases
                            'set the id of c to the next available ID for cases
                            c.id = findNextIndex("Case")
                            'sets the data of c to that which the user entered
                            c.name = txt_name.Text
                            c.manufacturer = txt_manu.Text
                            c.HDDs = txt_HDD.Text
                            c.SSDs = txt_SSD.Text
                            c.price = txt_price.Text
                            'add c to the list of cases
                            AllCases.Add(c)
                            'write to the cases file
                            writeCases()
                            'navigate back to the parts screen
                            parts.Show()
                            Me.Hide()
                            'set up the parts screen
                            parts.setup(parts.ptype)
                            'store a temporary log
                            Dim l As log
                            'set its id to the next available log id
                            l.id = findNextIndex("AllLogs")
                            'set the data of the log
                            l.user = Form1.currentUser
                            l.action = "Add"
                            l.data = c.id & "-" & c.name & "-" & c.manufacturer & "-" & c.price
                            l.time = Now
                            'add the temporary log to the list of logs
                            AllLogs.Add(l)
                            'write the logs file
                            writeLogs()
                            ' if the user hasn't entered the amount of SSD slots
                        Else
                            'ask them to
                            MsgBox("Please enter the amount of SSD slots in the case")
                        End If
                        ' if the user hasn't entered the price
                    Else
                        'ask them to
                        MsgBox("Please enter the price of the case")
                    End If
                    'if the user hasn't entered the amount of HDD slots
                Else
                    'ask them to
                    MsgBox("Please enter the amount of HDD slots in the case")
                End If
                ' if the user hasn't entered the manufacturer
            Else
                'ask them to
                MsgBox("Please enter the manufacturer of the case")
            End If
            ' if the user hasn't entered the name
        Else
            'ask them to
            MsgBox("Please enter the name of the case")
        End If

    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        parts.Show()
        Me.Hide()
    End Sub
End Class