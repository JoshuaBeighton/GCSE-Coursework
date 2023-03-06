<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGPU
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_VRAM = New System.Windows.Forms.TextBox()
        Me.txt_power = New System.Windows.Forms.TextBox()
        Me.txt_baseclock = New System.Windows.Forms.TextBox()
        Me.txt_chip = New System.Windows.Forms.TextBox()
        Me.txt_manufacturer = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.txt_series = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Power Draw"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "VRAM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Base Clock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Chip Manufacturer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Manufacturer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Seires"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(193, 265)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(150, 31)
        Me.txt_price.TabIndex = 7
        '
        'txt_VRAM
        '
        Me.txt_VRAM.Location = New System.Drawing.Point(193, 191)
        Me.txt_VRAM.Name = "txt_VRAM"
        Me.txt_VRAM.Size = New System.Drawing.Size(150, 31)
        Me.txt_VRAM.TabIndex = 5
        '
        'txt_power
        '
        Me.txt_power.Location = New System.Drawing.Point(193, 228)
        Me.txt_power.Name = "txt_power"
        Me.txt_power.Size = New System.Drawing.Size(150, 31)
        Me.txt_power.TabIndex = 6
        '
        'txt_baseclock
        '
        Me.txt_baseclock.Location = New System.Drawing.Point(193, 154)
        Me.txt_baseclock.Name = "txt_baseclock"
        Me.txt_baseclock.Size = New System.Drawing.Size(150, 31)
        Me.txt_baseclock.TabIndex = 4
        '
        'txt_chip
        '
        Me.txt_chip.Location = New System.Drawing.Point(193, 117)
        Me.txt_chip.Name = "txt_chip"
        Me.txt_chip.Size = New System.Drawing.Size(150, 31)
        Me.txt_chip.TabIndex = 3
        '
        'txt_manufacturer
        '
        Me.txt_manufacturer.Location = New System.Drawing.Point(193, 80)
        Me.txt_manufacturer.Name = "txt_manufacturer"
        Me.txt_manufacturer.Size = New System.Drawing.Size(150, 31)
        Me.txt_manufacturer.TabIndex = 2
        '
        'txt_model
        '
        Me.txt_model.Location = New System.Drawing.Point(193, 43)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(150, 31)
        Me.txt_model.TabIndex = 1
        '
        'txt_series
        '
        Me.txt_series.Location = New System.Drawing.Point(193, 6)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.Size = New System.Drawing.Size(150, 31)
        Me.txt_series.TabIndex = 0
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(209, 302)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(134, 80)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "Go Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(12, 302)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(131, 80)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'AddGPU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 397)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_VRAM)
        Me.Controls.Add(Me.txt_power)
        Me.Controls.Add(Me.txt_baseclock)
        Me.Controls.Add(Me.txt_chip)
        Me.Controls.Add(Me.txt_manufacturer)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.txt_series)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "AddGPU"
        Me.Text = "Add GPU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_VRAM As TextBox
    Friend WithEvents txt_power As TextBox
    Friend WithEvents txt_baseclock As TextBox
    Friend WithEvents txt_chip As TextBox
    Friend WithEvents txt_manufacturer As TextBox
    Friend WithEvents txt_model As TextBox
    Friend WithEvents txt_series As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_add As Button
End Class
