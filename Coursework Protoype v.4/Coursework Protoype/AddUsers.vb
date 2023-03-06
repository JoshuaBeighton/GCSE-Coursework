﻿Public Class AddUsers
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_username.Text <> "" Then
            If txt_password.Text <> "" Then
                If txt_retype.Text <> "" Then
                    If ComboBox1.SelectedIndex <> -1 Then
                        If txt_password.Text = txt_retype.Text Then
                            Dim u As New user
                            u.ID = findNextIndex("User")
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
                            AllUsers.Add(u)
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

End Class