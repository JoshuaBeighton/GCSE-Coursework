Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readOrders()
        readOrderStock()
        readStock()
        readUser()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        For i = 0 To AllUsers.Count - 1
            If txt_username.Text = AllUsers(i).username And txt_pass.Text = AllUsers(i).password Then
                MessageBox.Show("Success")
            Else
                MessageBox.Show("Failure")
            End If
        Next
    End Sub
End Class
