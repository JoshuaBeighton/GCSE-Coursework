Public Class Form1
    'set up the data
    Public currentUser As String = "testM"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Navigation.Show()
        Navigation.setup("M")
        Me.Hide()
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
                currentUser = AllUsers(i).username
                found = True
                Dim l As log
                l.id = findNextIndex("AllLogs")
                l.user = currentUser
                l.action = "Login"
                l.data = AllUsers(i).ID & AllUsers(i).username & AllUsers(i).permission
                l.time = Now
                AllLogs.Add(l)
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

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Hide()
        Navigation.Show()
        Navigation.setup("M")
    End Sub

End Class
