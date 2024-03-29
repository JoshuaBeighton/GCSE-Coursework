﻿Public Class Form1
    'set up the data
    Public currentUser As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'read all of the data from the text files
        readOrders()
        readOrderStock()
        readStock()
        readUser()
        readCPU()
        readGPU()
        readCase()
        readMoba()
        readPSU()
        readRAM()
        readStorage()
        readLogs()
        readCustomers()
    End Sub

    'handle login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'store whether the username/password has been found
        Dim found As Boolean = False
        'loop through all users
        For i = 0 To AllUsers.Count - 1
            'if the username and password both match
            If txt_username.Text = AllUsers(i).username And txt_pass.Text = AllUsers(i).password Then
                'show and setup navigation form and hide the login form
                Navigation.Show()
                Navigation.setup(AllUsers(i).permission)
                Me.Hide()
                'set the current user to the username of the user who just logged in
                currentUser = AllUsers(i).username
                'store that we have found the user
                found = True
                'declare a new temporary log item
                Dim l As log
                'set it's ID to the next available ID
                l.id = findNextIndex("AllLogs")
                'set it's data appropriately
                l.user = currentUser
                l.action = "Login"
                l.data = AllUsers(i).ID & AllUsers(i).username & AllUsers(i).permission
                l.time = Now
                'add the temporary log to the lost of logs
                AllLogs.Add(l)
                'write to the log file
                writeLogs()
            End If
        Next
        'if the credentials are not in the system
        If found = False Then
            MsgBox("Please enter valid login info")
        End If
        'reset the form
        reset()
    End Sub

    'reset the login form and select the username text box 
    Sub reset()
        txt_pass.Clear()
        txt_username.Clear()
        txt_username.Select()
    End Sub


End Class
