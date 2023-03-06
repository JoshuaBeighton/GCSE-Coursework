<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Me.txt_first = New System.Windows.Forms.TextBox()
        Me.txt_last = New System.Windows.Forms.TextBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_first
        '
        Me.txt_first.Location = New System.Drawing.Point(176, 12)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.Size = New System.Drawing.Size(201, 31)
        Me.txt_first.TabIndex = 0
        '
        'txt_last
        '
        Me.txt_last.Location = New System.Drawing.Point(176, 49)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.Size = New System.Drawing.Size(201, 31)
        Me.txt_last.TabIndex = 1
        '
        'txt_number
        '
        Me.txt_number.Location = New System.Drawing.Point(176, 86)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(201, 31)
        Me.txt_number.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Phone Number"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(12, 123)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(365, 38)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 173)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.txt_last)
        Me.Controls.Add(Me.txt_first)
        Me.Name = "AddCustomer"
        Me.Text = "AddCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_first As TextBox
    Friend WithEvents txt_last As TextBox
    Friend WithEvents txt_number As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_add As Button
End Class
