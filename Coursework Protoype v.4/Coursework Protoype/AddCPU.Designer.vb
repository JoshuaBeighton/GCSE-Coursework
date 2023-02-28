<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCPU
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
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_manufacturer = New System.Windows.Forms.TextBox()
        Me.txt_socket = New System.Windows.Forms.TextBox()
        Me.txt_cores = New System.Windows.Forms.TextBox()
        Me.txt_basespeed = New System.Windows.Forms.TextBox()
        Me.txt_boostSpeed = New System.Windows.Forms.TextBox()
        Me.txt_power = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(12, 308)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(131, 80)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(163, 308)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(134, 80)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "Go Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(147, 12)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(150, 31)
        Me.txt_name.TabIndex = 0
        '
        'txt_manufacturer
        '
        Me.txt_manufacturer.Location = New System.Drawing.Point(147, 49)
        Me.txt_manufacturer.Name = "txt_manufacturer"
        Me.txt_manufacturer.Size = New System.Drawing.Size(150, 31)
        Me.txt_manufacturer.TabIndex = 1
        '
        'txt_socket
        '
        Me.txt_socket.Location = New System.Drawing.Point(147, 86)
        Me.txt_socket.Name = "txt_socket"
        Me.txt_socket.Size = New System.Drawing.Size(150, 31)
        Me.txt_socket.TabIndex = 2
        '
        'txt_cores
        '
        Me.txt_cores.Location = New System.Drawing.Point(147, 123)
        Me.txt_cores.Name = "txt_cores"
        Me.txt_cores.Size = New System.Drawing.Size(150, 31)
        Me.txt_cores.TabIndex = 3
        '
        'txt_basespeed
        '
        Me.txt_basespeed.Location = New System.Drawing.Point(147, 160)
        Me.txt_basespeed.Name = "txt_basespeed"
        Me.txt_basespeed.Size = New System.Drawing.Size(150, 31)
        Me.txt_basespeed.TabIndex = 4
        '
        'txt_boostSpeed
        '
        Me.txt_boostSpeed.Location = New System.Drawing.Point(147, 197)
        Me.txt_boostSpeed.Name = "txt_boostSpeed"
        Me.txt_boostSpeed.Size = New System.Drawing.Size(150, 31)
        Me.txt_boostSpeed.TabIndex = 5
        '
        'txt_power
        '
        Me.txt_power.Location = New System.Drawing.Point(147, 234)
        Me.txt_power.Name = "txt_power"
        Me.txt_power.Size = New System.Drawing.Size(150, 31)
        Me.txt_power.TabIndex = 6
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(147, 271)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(150, 31)
        Me.txt_price.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Manufacturer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Socket"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cores"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Base Speed"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Boost Speed"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Power Draw"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Price"
        '
        'AddCPU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 396)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_boostSpeed)
        Me.Controls.Add(Me.txt_power)
        Me.Controls.Add(Me.txt_basespeed)
        Me.Controls.Add(Me.txt_cores)
        Me.Controls.Add(Me.txt_socket)
        Me.Controls.Add(Me.txt_manufacturer)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "AddCPU"
        Me.Text = "Add CPU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_manufacturer As TextBox
    Friend WithEvents txt_socket As TextBox
    Friend WithEvents txt_cores As TextBox
    Friend WithEvents txt_basespeed As TextBox
    Friend WithEvents txt_boostSpeed As TextBox
    Friend WithEvents txt_power As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
