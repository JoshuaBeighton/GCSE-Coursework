<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WriteStock
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
        Me.btn_navi = New System.Windows.Forms.Button()
        Me.btn_AddOrder = New System.Windows.Forms.Button()
        Me.date_due = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.txt_part = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.date_ordered = New System.Windows.Forms.DateTimePicker()
        Me.chk_arrived = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_navi
        '
        Me.btn_navi.Location = New System.Drawing.Point(239, 109)
        Me.btn_navi.Name = "btn_navi"
        Me.btn_navi.Size = New System.Drawing.Size(200, 74)
        Me.btn_navi.TabIndex = 34
        Me.btn_navi.Text = "Go Back To Full List"
        Me.btn_navi.UseVisualStyleBackColor = True
        '
        'btn_AddOrder
        '
        Me.btn_AddOrder.Location = New System.Drawing.Point(14, 109)
        Me.btn_AddOrder.Name = "btn_AddOrder"
        Me.btn_AddOrder.Size = New System.Drawing.Size(219, 74)
        Me.btn_AddOrder.TabIndex = 32
        Me.btn_AddOrder.Text = "Add Stock"
        Me.btn_AddOrder.UseVisualStyleBackColor = True
        '
        'date_due
        '
        Me.date_due.Location = New System.Drawing.Point(276, 40)
        Me.date_due.Name = "date_due"
        Me.date_due.Size = New System.Drawing.Size(163, 23)
        Me.date_due.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(239, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Due:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Part:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Type:"
        '
        'cmb_type
        '
        Me.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Items.AddRange(New Object() {"CPU", "GPU", "RAM", "PSU", "Case", "Motherboard", "Storage", "Other"})
        Me.cmb_type.Location = New System.Drawing.Point(82, 11)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(137, 23)
        Me.cmb_type.TabIndex = 0
        '
        'txt_part
        '
        Me.txt_part.Location = New System.Drawing.Point(337, 11)
        Me.txt_part.Name = "txt_part"
        Me.txt_part.Size = New System.Drawing.Size(102, 23)
        Me.txt_part.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Ordered:"
        '
        'date_ordered
        '
        Me.date_ordered.Location = New System.Drawing.Point(78, 40)
        Me.date_ordered.Name = "date_ordered"
        Me.date_ordered.Size = New System.Drawing.Size(141, 23)
        Me.date_ordered.TabIndex = 2
        '
        'chk_arrived
        '
        Me.chk_arrived.AutoSize = True
        Me.chk_arrived.Location = New System.Drawing.Point(12, 75)
        Me.chk_arrived.Name = "chk_arrived"
        Me.chk_arrived.Size = New System.Drawing.Size(64, 19)
        Me.chk_arrived.TabIndex = 4
        Me.chk_arrived.Text = "Arrived"
        Me.chk_arrived.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Price:"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(276, 75)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(163, 23)
        Me.txt_price.TabIndex = 5
        '
        'WriteStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 195)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chk_arrived)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.btn_navi)
        Me.Controls.Add(Me.btn_AddOrder)
        Me.Controls.Add(Me.date_ordered)
        Me.Controls.Add(Me.date_due)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_part)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WriteStock"
        Me.Text = "Write Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_navi As Button
    Friend WithEvents btn_AddOrder As Button
    Friend WithEvents date_due As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents txt_part As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents date_ordered As DateTimePicker
    Friend WithEvents chk_arrived As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_price As TextBox
End Class
