Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readOrders()
        readOrderStock()
        readStock()
        readUser()
        Navigation.Show()
        Navigation.setup("M")
        Me.Hide()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim found As Boolean = False
        For i = 0 To AllUsers.Count - 1
            If txt_username.Text = AllUsers(i).username And txt_pass.Text = AllUsers(i).password Then
                Navigation.Show()
                Navigation.setup(AllUsers(i).permission)
                Me.Hide()
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Please enter valid login info")
        End If
        reset()
    End Sub
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
