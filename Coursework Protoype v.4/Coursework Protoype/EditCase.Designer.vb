<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCase
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_SSD = New System.Windows.Forms.TextBox()
        Me.txt_HDD = New System.Windows.Forms.TextBox()
        Me.txt_manu = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 25)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "SSD Slots"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "HDD Slots"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Manufacturer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Name"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(191, 160)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(150, 31)
        Me.txt_price.TabIndex = 4
        '
        'txt_SSD
        '
        Me.txt_SSD.Location = New System.Drawing.Point(191, 123)
        Me.txt_SSD.Name = "txt_SSD"
        Me.txt_SSD.Size = New System.Drawing.Size(150, 31)
        Me.txt_SSD.TabIndex = 3
        '
        'txt_HDD
        '
        Me.txt_HDD.Location = New System.Drawing.Point(191, 86)
        Me.txt_HDD.Name = "txt_HDD"
        Me.txt_HDD.Size = New System.Drawing.Size(150, 31)
        Me.txt_HDD.TabIndex = 2
        '
        'txt_manu
        '
        Me.txt_manu.Location = New System.Drawing.Point(191, 49)
        Me.txt_manu.Name = "txt_manu"
        Me.txt_manu.Size = New System.Drawing.Size(150, 31)
        Me.txt_manu.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(191, 12)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(150, 31)
        Me.txt_name.TabIndex = 0
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(207, 197)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(134, 80)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Go Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(10, 197)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(131, 80)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'EditCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 282)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_SSD)
        Me.Controls.Add(Me.txt_HDD)
        Me.Controls.Add(Me.txt_manu)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_edit)
        Me.Name = "EditCase"
        Me.Text = "Edit Case"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_SSD As TextBox
    Friend WithEvents txt_HDD As TextBox
    Friend WithEvents txt_manu As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_edit As Button
End Class
