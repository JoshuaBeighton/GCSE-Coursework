﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readOrders()
        readOrderStock()
        readStock()
        readUser()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim found As Boolean = False
        For i = 0 To AllUsers.Count - 1
            If txt_username.Text = AllUsers(i).username And txt_pass.Text = AllUsers(i).password Then
                found = True
                Navigation.Show()
                Navigation.setup(AllUsers(i).permission)
                Me.Hide()
            End If
        Next
        If Not found Then
            MsgBox("Please enter valid credentials")
        End If
    End Sub
End Class
