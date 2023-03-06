Public Class EditUsers
    Dim uID As Integer
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_username.Text <> "" Then
            If txt_password.Text <> "" Then
                If txt_retype.Text <> "" Then
                    If ComboBox1.SelectedIndex <> -1 Then
                        If txt_password.Text = txt_retype.Text Then
                            Dim u As New user
                            u.ID = uID
                            u.username = txt_username.Text
                            u.password = txt_password.Text
                            Select Case ComboBox1.SelectedItem
                                Case "Staff"
                                    u.permission = "S"
                                Case "Manager"
                                    u.permission = "M"
                                Case "Accountant"
                                    u.permission = "A"
                            End Select
                            For i = 0 To AllUsers.Count - 1
                                If uID = AllUsers(i).ID Then
                                    AllUsers(i) = u
                                End If
                            Next
                            writeUser()
                            Me.Hide()
                            Staff.Show()
                            Staff.init()
                        Else
                            MsgBox("Make sure you have entered your password correctly both times")
                        End If
                        txt_password.Clear()
                        txt_retype.Clear()
                        txt_username.Clear()
                        ComboBox1.SelectedIndex = -1
                    Else
                        MsgBox("Please enter the permission level of the new user")
                    End If
                Else
                    MsgBox("Please enter the password a second time")
                End If
            Else
                MsgBox("Please enter the password")
            End If
        Else
            MsgBox("Please enter the username")
        End If
    End Sub
    Public Sub init(id As Integer)
        uID = id
        For i = 0 To AllUsers.Count - 1
            If AllUsers(i).ID = id Then
                txt_password.Text = AllUsers(i).password
                txt_username.Text = AllUsers(i).username
                Select Case AllUsers(i).permission
                    Case "A"
                        ComboBox1.SelectedItem = "Accountant"
                    Case "M"
                        ComboBox1.SelectedItem = "Manager"
                    Case "S"
                        ComboBox1.SelectedItem = "Staff"
                End Select
            End If
        Next
    End Sub
End Class