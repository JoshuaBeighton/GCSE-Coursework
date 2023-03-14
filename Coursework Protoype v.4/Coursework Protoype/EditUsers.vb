Public Class EditUsers
    'store the original ID of the user
    Dim uID As Integer
    'when the user presses the edit button
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
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
                            'set the ID to that of the user we are editing
                            u.ID = uID
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
                            'loop through the users
                            For i = 0 To AllUsers.Count - 1
                                'if the ID of the user at index i matches the ID of the user
                                If uID = AllUsers(i).ID Then
                                    'set the user at the position of i to the user created with the data the user entered
                                    AllUsers(i) = u
                                End If
                            Next
                            'write the user file
                            writeUser()
                            'navigate back to the staff page
                            Me.Hide()
                            Staff.Show()
                            'initialise the staff page
                            Staff.init()
                            'if the user has entered different passwords
                        Else
                            'ask the user to enter the same password both times
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

    'initialise the edit users page
    Public Sub init(id As Integer)
        'store the ID of the user we are trying to edit
        uID = id
        'loop through all of the users
        For i = 0 To AllUsers.Count - 1
            'if we find the right user
            If AllUsers(i).ID = id Then
                'set the password and username text boxes to the right values
                txt_password.Text = AllUsers(i).password
                txt_username.Text = AllUsers(i).username
                'depending on the permission the user has
                Select Case AllUsers(i).permission
                    'if they are an accountant
                    Case "A"
                        'select the accountant option
                        ComboBox1.SelectedItem = "Accountant"
                    'if they are a manager
                    Case "M"
                        'select manager in the combo box
                        ComboBox1.SelectedItem = "Manager"
                    'if they are a staff member
                    Case "S"
                        'select staff in the combo box
                        ComboBox1.SelectedItem = "Staff"
                End Select
            End If
        Next
    End Sub
End Class