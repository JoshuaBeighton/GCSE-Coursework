Public Class EditCase
    Dim original As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_name.Text <> "" Then
            If txt_manu.Text <> "" Then
                If txt_HDD.Text <> "" Then
                    If txt_price.Text <> "" Then
                        If txt_SSD.Text <> "" Then
                            Dim c As cases
                            c.id = original
                            c.name = txt_name.Text
                            c.manufacturer = txt_manu.Text
                            c.HDDs = txt_HDD.Text
                            c.SSDs = txt_SSD.Text
                            c.price = txt_price.Text
                            For i = 0 To AllCases.Count - 1
                                If AllCases(i).id = c.id Then
                                    AllCases(i) = c
                                End If
                            Next
                            Me.Hide()
                            parts.Show()
                            parts.setup(parts.ptype)
                            writeCases()
                            Dim l As log
                            l.id = findNextIndex("AllLogs")
                            l.user = Form1.currentUser
                            l.action = "Edit"
                            l.data = c.id & c.name & c.manufacturer & c.price
                            l.time = Now
                            AllLogs.Add(l)
                            writeLogs()
                        Else
                            MsgBox("Please enter the amount of SSD slots in the case")
                        End If
                    Else
                        MsgBox("Please enter the price of the case")
                    End If
                Else
                    MsgBox("Please enter the amount of HDD slots in the case")
                End If
            Else
                MsgBox("Please enter the manufacturer of the case")
            End If
        Else
            MsgBox("Please enter the name of the case")
        End If
    End Sub
    Sub init(c As cases)
        original = c.id
        txt_name.Text = c.name
        txt_manu.Text = c.manufacturer
        txt_HDD.Text = c.HDDs
        txt_SSD.Text = c.SSDs
        txt_price.Text = c.price
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Hide()
        parts.Show()
    End Sub
End Class