<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seeOrders
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txt_Cust = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmb_date = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_CPU = New System.Windows.Forms.ComboBox()
        Me.cmb_GPU = New System.Windows.Forms.ComboBox()
        Me.cmb_RAM = New System.Windows.Forms.ComboBox()
        Me.cmb_Case = New System.Windows.Forms.ComboBox()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1457, 262)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 83)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(17, 168)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1430, 556)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'txt_Cust
        '
        Me.txt_Cust.Location = New System.Drawing.Point(17, 20)
        Me.txt_Cust.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Cust.Name = "txt_Cust"
        Me.txt_Cust.Size = New System.Drawing.Size(255, 31)
        Me.txt_Cust.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(323, 20)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(284, 31)
        Me.DateTimePicker1.TabIndex = 1
        '
        'cmb_date
        '
        Me.cmb_date.FormattingEnabled = True
        Me.cmb_date.Items.AddRange(New Object() {"Before", "On", "After"})
        Me.cmb_date.Location = New System.Drawing.Point(436, 70)
        Me.cmb_date.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_date.Name = "cmb_date"
        Me.cmb_date.Size = New System.Drawing.Size(171, 33)
        Me.cmb_date.TabIndex = 2
        Me.cmb_date.Text = "Not Filtered"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Due"
        '
        'cmb_CPU
        '
        Me.cmb_CPU.FormattingEnabled = True
        Me.cmb_CPU.Location = New System.Drawing.Point(649, 20)
        Me.cmb_CPU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_CPU.Name = "cmb_CPU"
        Me.cmb_CPU.Size = New System.Drawing.Size(171, 33)
        Me.cmb_CPU.TabIndex = 3
        Me.cmb_CPU.Text = "CPU"
        '
        'cmb_GPU
        '
        Me.cmb_GPU.FormattingEnabled = True
        Me.cmb_GPU.Location = New System.Drawing.Point(860, 20)
        Me.cmb_GPU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_GPU.Name = "cmb_GPU"
        Me.cmb_GPU.Size = New System.Drawing.Size(171, 33)
        Me.cmb_GPU.TabIndex = 4
        Me.cmb_GPU.Text = "GPU"
        '
        'cmb_RAM
        '
        Me.cmb_RAM.FormattingEnabled = True
        Me.cmb_RAM.Location = New System.Drawing.Point(1064, 20)
        Me.cmb_RAM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_RAM.Name = "cmb_RAM"
        Me.cmb_RAM.Size = New System.Drawing.Size(171, 33)
        Me.cmb_RAM.TabIndex = 5
        Me.cmb_RAM.Text = "RAM"
        '
        'cmb_Case
        '
        Me.cmb_Case.FormattingEnabled = True
        Me.cmb_Case.Location = New System.Drawing.Point(1276, 20)
        Me.cmb_Case.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_Case.Name = "cmb_Case"
        Me.cmb_Case.Size = New System.Drawing.Size(171, 33)
        Me.cmb_Case.TabIndex = 6
        Me.cmb_Case.Text = "Case"
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(1457, 20)
        Me.btn_filter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(187, 83)
        Me.btn_filter.TabIndex = 7
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(1457, 168)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(187, 83)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "Clear Filters"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1457, 643)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 83)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Go Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1457, 355)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 83)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Delete Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1457, 448)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 83)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Edit Order"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'seeOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1661, 747)
        Me.Controls.Add(Me.cmb_Case)
        Me.Controls.Add(Me.cmb_RAM)
        Me.Controls.Add(Me.cmb_GPU)
        Me.Controls.Add(Me.cmb_CPU)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_date)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Cust)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "seeOrders"
        Me.Text = "Orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txt_Cust As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmb_date As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_CPU As ComboBox
    Friend WithEvents cmb_GPU As ComboBox
    Friend WithEvents cmb_RAM As ComboBox
    Friend WithEvents cmb_Case As ComboBox
    Friend WithEvents btn_filter As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
