<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomer
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.txt_last = New System.Windows.Forms.TextBox()
        Me.txt_first = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(12, 123)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(365, 38)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "First Name"
        '
        'txt_number
        '
        Me.txt_number.Location = New System.Drawing.Point(176, 86)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(201, 31)
        Me.txt_number.TabIndex = 9
        '
        'txt_last
        '
        Me.txt_last.Location = New System.Drawing.Point(176, 49)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.Size = New System.Drawing.Size(201, 31)
        Me.txt_last.TabIndex = 8
        '
        'txt_first
        '
        Me.txt_first.Location = New System.Drawing.Point(176, 12)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.Size = New System.Drawing.Size(201, 31)
        Me.txt_first.TabIndex = 4
        '
        'EditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 173)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.txt_last)
        Me.Controls.Add(Me.txt_first)
        Me.Name = "EditCustomer"
        Me.Text = "EditCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_edit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_number As TextBox
    Friend WithEvents txt_last As TextBox
    Friend WithEvents txt_first As TextBox
End Class
