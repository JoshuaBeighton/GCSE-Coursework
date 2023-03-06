Public Class AddUsers
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
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
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_retype_TextChanged(sender As Object, e As EventArgs) Handles txt_retype.TextChanged

    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub
End Class