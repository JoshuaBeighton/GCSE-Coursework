<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_CPU = New System.Windows.Forms.TextBox()
        Me.txt_GPU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_PSU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_RAM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_motherboard = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Case = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sto = New System.Windows.Forms.TextBox()
        Me.btn_AddStorage = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lst_sto = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_due = New System.Windows.Forms.DateTimePicker()
        Me.btn_AddOrder = New System.Windows.Forms.Button()
        Me.btn_navi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU:"
        '
        'txt_CPU
        '
        Me.txt_CPU.Location = New System.Drawing.Point(80, 22)
        Me.txt_CPU.Name = "txt_CPU"
        Me.txt_CPU.Size = New System.Drawing.Size(100, 23)
        Me.txt_CPU.TabIndex = 0
        '
        'txt_GPU
        '
        Me.txt_GPU.Location = New System.Drawing.Point(337, 22)
        Me.txt_GPU.Name = "txt_GPU"
        Me.txt_GPU.Size = New System.Drawing.Size(100, 23)
        Me.txt_GPU.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GPU:"
        '
        'txt_PSU
        '
        Me.txt_PSU.Location = New System.Drawing.Point(337, 60)
        Me.txt_PSU.Name = "txt_PSU"
        Me.txt_PSU.Size = New System.Drawing.Size(100, 23)
        Me.txt_PSU.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PSU:"
        '
        'txt_RAM
        '
        Me.txt_RAM.Location = New System.Drawing.Point(80, 60)
        Me.txt_RAM.Name = "txt_RAM"
        Me.txt_RAM.Size = New System.Drawing.Size(100, 23)
        Me.txt_RAM.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RAM:"
        '
        'txt_motherboard
        '
        Me.txt_motherboard.Location = New System.Drawing.Point(337, 98)
        Me.txt_motherboard.Name = "txt_motherboard"
        Me.txt_motherboard.Size = New System.Drawing.Size(100, 23)
        Me.txt_motherboard.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Motherboard:"
        '
        'txt_Case
        '
        Me.txt_Case.Location = New System.Drawing.Point(80, 98)
        Me.txt_Case.Name = "txt_Case"
        Me.txt_Case.Size = New System.Drawing.Size(100, 23)
        Me.txt_Case.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Case:"
        '
        'txt_sto
        '
        Me.txt_sto.Location = New System.Drawing.Point(80, 148)
        Me.txt_sto.Name = "txt_sto"
        Me.txt_sto.Size = New System.Drawing.Size(100, 23)
        Me.txt_sto.TabIndex = 6
        '
        'btn_AddStorage
        '
        Me.btn_AddStorage.Location = New System.Drawing.Point(80, 177)
        Me.btn_AddStorage.Name = "btn_AddStorage"
        Me.btn_AddStorage.Size = New System.Drawing.Size(100, 23)
        Me.btn_AddStorage.TabIndex = 7
        Me.btn_AddStorage.Text = "Add Storage"
        Me.btn_AddStorage.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Storage:"
        '
        'lst_sto
        '
        Me.lst_sto.FormattingEnabled = True
        Me.lst_sto.ItemHeight = 15
        Me.lst_sto.Location = New System.Drawing.Point(251, 148)
        Me.lst_sto.Name = "lst_sto"
        Me.lst_sto.Size = New System.Drawing.Size(186, 49)
        Me.lst_sto.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Customer:"
        '
        'txt_cust
        '
        Me.txt_cust.Location = New System.Drawing.Point(80, 227)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.Size = New System.Drawing.Size(100, 23)
        Me.txt_cust.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Due:"
        '
        'date_due
        '
        Me.date_due.Location = New System.Drawing.Point(237, 227)
        Me.date_due.Name = "date_due"
        Me.date_due.Size = New System.Drawing.Size(200, 23)
        Me.date_due.TabIndex = 9
        '
        'btn_AddOrder
        '
        Me.btn_AddOrder.Location = New System.Drawing.Point(12, 267)
        Me.btn_AddOrder.Name = "btn_AddOrder"
        Me.btn_AddOrder.Size = New System.Drawing.Size(219, 74)
        Me.btn_AddOrder.TabIndex = 10
        Me.btn_AddOrder.Text = "Edit Order"
        Me.btn_AddOrder.UseVisualStyleBackColor = True
        '
        'btn_navi
        '
        Me.btn_navi.Location = New System.Drawing.Point(237, 267)
        Me.btn_navi.Name = "btn_navi"
        Me.btn_navi.Size = New System.Drawing.Size(200, 74)
        Me.btn_navi.TabIndex = 11
        Me.btn_navi.Text = "Go Back To Navigation"
        Me.btn_navi.UseVisualStyleBackColor = True
        '
        'EditOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 353)
        Me.Controls.Add(Me.btn_navi)
        Me.Controls.Add(Me.btn_AddOrder)
        Me.Controls.Add(Me.date_due)
        Me.Controls.Add(Me.lst_sto)
        Me.Controls.Add(Me.btn_AddStorage)
        Me.Controls.Add(Me.txt_sto)
        Me.Controls.Add(Me.txt_motherboard)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_cust)
        Me.Controls.Add(Me.txt_Case)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_PSU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_RAM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_GPU)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_CPU)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditOrder"
        Me.Text = "Edit Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_CPU As TextBox
    Friend WithEvents txt_GPU As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_PSU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_RAM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_motherboard As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Case As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_sto As TextBox
    Friend WithEvents btn_AddStorage As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lst_sto As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents date_due As DateTimePicker
    Friend WithEvents btn_AddOrder As Button
    Friend WithEvents btn_navi As Button
End Class
