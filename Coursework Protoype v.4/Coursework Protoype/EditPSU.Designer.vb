<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPSU
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_power = New System.Windows.Forms.TextBox()
        Me.txt_effeciency = New System.Windows.Forms.TextBox()
        Me.txt_manu = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Full", "Semi", "Not"})
        Me.ComboBox1.Location = New System.Drawing.Point(195, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 33)
        Me.ComboBox1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 25)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Power"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Modularity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Effeciency"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Manufacturer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Name"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(195, 197)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(150, 31)
        Me.txt_price.TabIndex = 5
        '
        'txt_power
        '
        Me.txt_power.Location = New System.Drawing.Point(195, 160)
        Me.txt_power.Name = "txt_power"
        Me.txt_power.Size = New System.Drawing.Size(150, 31)
        Me.txt_power.TabIndex = 4
        '
        'txt_effeciency
        '
        Me.txt_effeciency.Location = New System.Drawing.Point(195, 86)
        Me.txt_effeciency.Name = "txt_effeciency"
        Me.txt_effeciency.Size = New System.Drawing.Size(150, 31)
        Me.txt_effeciency.TabIndex = 2
        '
        'txt_manu
        '
        Me.txt_manu.Location = New System.Drawing.Point(195, 49)
        Me.txt_manu.Name = "txt_manu"
        Me.txt_manu.Size = New System.Drawing.Size(150, 31)
        Me.txt_manu.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(195, 12)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(150, 31)
        Me.txt_name.TabIndex = 0
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(211, 234)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(134, 80)
        Me.btn_back.TabIndex = 7
        Me.btn_back.Text = "Go Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(14, 234)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(131, 80)
        Me.btn_edit.TabIndex = 6
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'EditPSU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 322)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_power)
        Me.Controls.Add(Me.txt_effeciency)
        Me.Controls.Add(Me.txt_manu)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_edit)
        Me.Name = "EditPSU"
        Me.Text = "Edit PSU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_power As TextBox
    Friend WithEvents txt_effeciency As TextBox
    Friend WithEvents txt_manu As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_edit As Button
End Class
