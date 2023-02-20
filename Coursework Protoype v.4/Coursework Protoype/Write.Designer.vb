<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Write
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
        Me.btn_AddStorage = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lst_sto = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_due = New System.Windows.Forms.DateTimePicker()
        Me.btn_AddOrder = New System.Windows.Forms.Button()
        Me.btn_navi = New System.Windows.Forms.Button()
        Me.selCPU = New System.Windows.Forms.Button()
        Me.selRAM = New System.Windows.Forms.Button()
        Me.selCase = New System.Windows.Forms.Button()
        Me.selGPU = New System.Windows.Forms.Button()
        Me.selPSU = New System.Windows.Forms.Button()
        Me.selMoba = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU:"
        '
        'txt_CPU
        '
        Me.txt_CPU.Location = New System.Drawing.Point(114, 37)
        Me.txt_CPU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_CPU.Name = "txt_CPU"
        Me.txt_CPU.Size = New System.Drawing.Size(141, 31)
        Me.txt_CPU.TabIndex = 0
        Me.txt_CPU.Visible = False
        '
        'txt_GPU
        '
        Me.txt_GPU.Location = New System.Drawing.Point(481, 37)
        Me.txt_GPU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_GPU.Name = "txt_GPU"
        Me.txt_GPU.Size = New System.Drawing.Size(141, 31)
        Me.txt_GPU.TabIndex = 1
        Me.txt_GPU.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "GPU:"
        '
        'txt_PSU
        '
        Me.txt_PSU.Location = New System.Drawing.Point(481, 100)
        Me.txt_PSU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_PSU.Name = "txt_PSU"
        Me.txt_PSU.Size = New System.Drawing.Size(141, 31)
        Me.txt_PSU.TabIndex = 3
        Me.txt_PSU.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PSU:"
        '
        'txt_RAM
        '
        Me.txt_RAM.Location = New System.Drawing.Point(114, 100)
        Me.txt_RAM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_RAM.Name = "txt_RAM"
        Me.txt_RAM.Size = New System.Drawing.Size(141, 31)
        Me.txt_RAM.TabIndex = 2
        Me.txt_RAM.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RAM:"
        '
        'txt_motherboard
        '
        Me.txt_motherboard.Location = New System.Drawing.Point(481, 163)
        Me.txt_motherboard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_motherboard.Name = "txt_motherboard"
        Me.txt_motherboard.Size = New System.Drawing.Size(141, 31)
        Me.txt_motherboard.TabIndex = 5
        Me.txt_motherboard.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(353, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Motherboard:"
        '
        'txt_Case
        '
        Me.txt_Case.Location = New System.Drawing.Point(114, 163)
        Me.txt_Case.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Case.Name = "txt_Case"
        Me.txt_Case.Size = New System.Drawing.Size(141, 31)
        Me.txt_Case.TabIndex = 4
        Me.txt_Case.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Case:"
        '
        'btn_AddStorage
        '
        Me.btn_AddStorage.Location = New System.Drawing.Point(114, 247)
        Me.btn_AddStorage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_AddStorage.Name = "btn_AddStorage"
        Me.btn_AddStorage.Size = New System.Drawing.Size(143, 38)
        Me.btn_AddStorage.TabIndex = 7
        Me.btn_AddStorage.Text = "Add Storage"
        Me.btn_AddStorage.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 252)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Storage:"
        '
        'lst_sto
        '
        Me.lst_sto.FormattingEnabled = True
        Me.lst_sto.ItemHeight = 25
        Me.lst_sto.Location = New System.Drawing.Point(359, 247)
        Me.lst_sto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lst_sto.Name = "lst_sto"
        Me.lst_sto.Size = New System.Drawing.Size(264, 79)
        Me.lst_sto.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 383)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Customer:"
        '
        'txt_cust
        '
        Me.txt_cust.Location = New System.Drawing.Point(114, 378)
        Me.txt_cust.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.Size = New System.Drawing.Size(141, 31)
        Me.txt_cust.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(286, 383)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Due:"
        '
        'date_due
        '
        Me.date_due.Location = New System.Drawing.Point(339, 378)
        Me.date_due.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.date_due.Name = "date_due"
        Me.date_due.Size = New System.Drawing.Size(284, 31)
        Me.date_due.TabIndex = 9
        '
        'btn_AddOrder
        '
        Me.btn_AddOrder.Location = New System.Drawing.Point(17, 445)
        Me.btn_AddOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_AddOrder.Name = "btn_AddOrder"
        Me.btn_AddOrder.Size = New System.Drawing.Size(313, 123)
        Me.btn_AddOrder.TabIndex = 10
        Me.btn_AddOrder.Text = "Add Order"
        Me.btn_AddOrder.UseVisualStyleBackColor = True
        '
        'btn_navi
        '
        Me.btn_navi.Location = New System.Drawing.Point(339, 445)
        Me.btn_navi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_navi.Name = "btn_navi"
        Me.btn_navi.Size = New System.Drawing.Size(286, 123)
        Me.btn_navi.TabIndex = 11
        Me.btn_navi.Text = "Go Back To Navigation"
        Me.btn_navi.UseVisualStyleBackColor = True
        '
        'selCPU
        '
        Me.selCPU.Location = New System.Drawing.Point(114, 37)
        Me.selCPU.Name = "selCPU"
        Me.selCPU.Size = New System.Drawing.Size(141, 31)
        Me.selCPU.TabIndex = 14
        Me.selCPU.Text = "Select"
        Me.selCPU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selCPU.UseVisualStyleBackColor = True
        '
        'selRAM
        '
        Me.selRAM.Location = New System.Drawing.Point(114, 99)
        Me.selRAM.Name = "selRAM"
        Me.selRAM.Size = New System.Drawing.Size(141, 31)
        Me.selRAM.TabIndex = 14
        Me.selRAM.Text = "Select"
        Me.selRAM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selRAM.UseVisualStyleBackColor = True
        '
        'selCase
        '
        Me.selCase.Location = New System.Drawing.Point(114, 162)
        Me.selCase.Name = "selCase"
        Me.selCase.Size = New System.Drawing.Size(141, 31)
        Me.selCase.TabIndex = 14
        Me.selCase.Text = "Select"
        Me.selCase.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selCase.UseVisualStyleBackColor = True
        '
        'selGPU
        '
        Me.selGPU.Location = New System.Drawing.Point(481, 36)
        Me.selGPU.Name = "selGPU"
        Me.selGPU.Size = New System.Drawing.Size(141, 31)
        Me.selGPU.TabIndex = 14
        Me.selGPU.Text = "Select"
        Me.selGPU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selGPU.UseVisualStyleBackColor = True
        '
        'selPSU
        '
        Me.selPSU.Location = New System.Drawing.Point(481, 101)
        Me.selPSU.Name = "selPSU"
        Me.selPSU.Size = New System.Drawing.Size(141, 31)
        Me.selPSU.TabIndex = 14
        Me.selPSU.Text = "Select"
        Me.selPSU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selPSU.UseVisualStyleBackColor = True
        '
        'selMoba
        '
        Me.selMoba.Location = New System.Drawing.Point(481, 162)
        Me.selMoba.Name = "selMoba"
        Me.selMoba.Size = New System.Drawing.Size(141, 31)
        Me.selMoba.TabIndex = 14
        Me.selMoba.Text = "Select"
        Me.selMoba.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.selMoba.UseVisualStyleBackColor = True
        '
        'Write
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 588)
        Me.Controls.Add(Me.selMoba)
        Me.Controls.Add(Me.selPSU)
        Me.Controls.Add(Me.selGPU)
        Me.Controls.Add(Me.selCase)
        Me.Controls.Add(Me.selRAM)
        Me.Controls.Add(Me.selCPU)
        Me.Controls.Add(Me.btn_navi)
        Me.Controls.Add(Me.btn_AddOrder)
        Me.Controls.Add(Me.date_due)
        Me.Controls.Add(Me.lst_sto)
        Me.Controls.Add(Me.btn_AddStorage)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Write"
        Me.Text = "Select"
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
    Friend WithEvents btn_AddStorage As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lst_sto As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents date_due As DateTimePicker
    Friend WithEvents btn_AddOrder As Button
    Friend WithEvents btn_navi As Button
    Friend WithEvents selCPU As Button
    Friend WithEvents selRAM As Button
    Friend WithEvents selCase As Button
    Friend WithEvents selGPU As Button
    Friend WithEvents selPSU As Button
    Friend WithEvents selMoba As Button
End Class
