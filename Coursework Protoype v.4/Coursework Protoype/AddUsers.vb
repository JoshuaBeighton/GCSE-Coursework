Public Class AddUsers
    'when the user presses the add button
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'if the user entered the username
        If txt_username.Text <> "" Then
            'if the user entered the password
            If txt_password.Text <> "" Then
                'if the user entered the re-type password
                If txt_retype.Text <> "" Then
                    'if the user selected a permission level
                    If ComboBox1.SelectedIndex <> -1 Then
                        'if the two passwords the user entered match
                        If txt_password.Text = txt_retype.Text Then
                            'store a temporary user
                            Dim u As New user
                            'set the ID of the next available one
                            u.ID = findNextIndex("User")
                            'set the username and password of the temporary user to that which the user entered
                            u.username = txt_username.Text
                            u.password = txt_password.Text
                            'depending on the item the user selected from the combo box
                            Select Case ComboBox1.SelectedItem
                                'if they entered staff
                                Case "Staff"
                                    'set the permission level of the user to staff
                                    u.permission = "S"
                                'if they entered manager
                                Case "Manager"
                                    'set the permission level of the user to manager
                                    u.permission = "M"
                                    'if they entered Accountant
                            End Select
                            'add the temporary user to the list of users
                            AllUsers.Add(u)
                            'write to the user file
                            writeUser()
                            'navigate to the staff page
                            Me.Hide()
                            Staff.Show()
                            'initialise the staff page
                            Staff.init()
                            'if the user entered different passwords
                        Else
                            'ask them to enter the correct password in both boxes
                            MsgBox("Make sure you have entered your password correctly both times")
                        End If
                        'if the user didn't enter the permission level of the user
                    Else
                        'ask them to do so
                        MsgBox("Please enter the permission level of the new user")
                    End If
                    'if the user hasn't re-entered the password
                Else
                    'ask them to do so
                    MsgBox("Please enter the password a second time")
                End If
                'if the user hasn't entered the password
            Else
                'ask them to do so
                MsgBox("Please enter the password")
            End If
            'if the user hasn't entered a username
        Else
            'ask them to do so
            MsgBox("Please enter the username")
        End If
    End Sub

End Class