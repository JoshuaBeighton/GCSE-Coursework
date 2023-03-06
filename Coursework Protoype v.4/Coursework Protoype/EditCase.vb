Public Class EditCase
    'store the original id of the case
    Dim original As Integer
    'when the user edits a case
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
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
                            'sets the ID of C to be the same as it was
                            c.id = original
                            'sets the data of c to that which the user entered
                            c.name = txt_name.Text
                            c.manufacturer = txt_manu.Text
                            c.HDDs = txt_HDD.Text
                            c.SSDs = txt_SSD.Text
                            c.price = txt_price.Text
                            'loop through all of the cases
                            For i = 0 To AllCases.Count - 1
                                'if the current case matches the id of the case we are editing
                                If AllCases(i).id = c.id Then
                                    'set the current case to the temporary case
                                    AllCases(i) = c
                                End If
                            Next
                            'navigate back to the parts menu and set it up
                            Me.Hide()
                            parts.Show()
                            parts.setup(parts.ptype)
                            'write the cases file
                            writeCases()
                            'store a temporary log file
                            Dim l As log
                            'set its id to the next available log id'sets the data of c to that which the user entered
                            l.id = findNextIndex("AllLogs")
                            'set the data of the log
                            l.user = Form1.currentUser
                            l.action = "Edit"
                            l.data = c.id & c.name & c.manufacturer & c.price
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
    'initialise the page
    Sub init(c As cases)
        'set the original ID equal to that of the case being edited
        original = c.id
        'set the data of the text boxes 
        txt_name.Text = c.name
        txt_manu.Text = c.manufacturer
        txt_HDD.Text = c.HDDs
        txt_SSD.Text = c.SSDs
        txt_price.Text = c.price
    End Sub
    'when the user clicks the "Go Back" button
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        'navigate to the parts screen
        Me.Hide()
        parts.Show()
    End Sub
End Class