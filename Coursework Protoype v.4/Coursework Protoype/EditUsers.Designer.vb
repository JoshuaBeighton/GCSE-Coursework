<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_retype = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(15, 162)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(309, 55)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Manager", "Staff"})
        Me.ComboBox1.Location = New System.Drawing.Point(172, 123)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 33)
        Me.ComboBox1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Re-type Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Permission Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'txt_retype
        '
        Me.txt_retype.Location = New System.Drawing.Point(172, 86)
        Me.txt_retype.Name = "txt_retype"
        Me.txt_retype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_retype.Size = New System.Drawing.Size(150, 31)
        Me.txt_retype.TabIndex = 11
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(172, 49)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(150, 31)
        Me.txt_password.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(172, 12)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(150, 31)
        Me.txt_username.TabIndex = 5
        '
        'EditUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 226)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_retype)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_username)
        Me.Name = "EditUsers"
        Me.Text = "EditUsers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_edit As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_retype As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As TextBox
End Class
