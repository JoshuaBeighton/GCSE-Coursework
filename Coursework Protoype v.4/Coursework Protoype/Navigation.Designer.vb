<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigation
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
        Me.btn_part = New System.Windows.Forms.Button()
        Me.btn_stock = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_cust = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_sales = New System.Windows.Forms.Button()
        Me.btn_logs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_part
        '
        Me.btn_part.Location = New System.Drawing.Point(12, 12)
        Me.btn_part.Name = "btn_part"
        Me.btn_part.Size = New System.Drawing.Size(184, 88)
        Me.btn_part.TabIndex = 0
        Me.btn_part.Text = "Part Database"
        Me.btn_part.UseVisualStyleBackColor = True
        '
        'btn_stock
        '
        Me.btn_stock.Location = New System.Drawing.Point(12, 106)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(184, 88)
        Me.btn_stock.TabIndex = 0
        Me.btn_stock.Text = "Stock Database"
        Me.btn_stock.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(12, 200)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(184, 88)
        Me.btn_order.TabIndex = 0
        Me.btn_order.Text = "Order Database"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_cust
        '
        Me.btn_cust.Location = New System.Drawing.Point(12, 294)
        Me.btn_cust.Name = "btn_cust"
        Me.btn_cust.Size = New System.Drawing.Size(184, 88)
        Me.btn_cust.TabIndex = 0
        Me.btn_cust.Text = "Customer Database"
        Me.btn_cust.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.Location = New System.Drawing.Point(12, 388)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(184, 88)
        Me.btn_staff.TabIndex = 0
        Me.btn_staff.Text = "Staff Database"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_sales
        '
        Me.btn_sales.Location = New System.Drawing.Point(601, 12)
        Me.btn_sales.Name = "btn_sales"
        Me.btn_sales.Size = New System.Drawing.Size(184, 88)
        Me.btn_sales.TabIndex = 0
        Me.btn_sales.Text = "Sales Data"
        Me.btn_sales.UseVisualStyleBackColor = True
        '
        'btn_logs
        '
        Me.btn_logs.Location = New System.Drawing.Point(313, 12)
        Me.btn_logs.Name = "btn_logs"
        Me.btn_logs.Size = New System.Drawing.Size(184, 88)
        Me.btn_logs.TabIndex = 0
        Me.btn_logs.Text = "Program Logs"
        Me.btn_logs.UseVisualStyleBackColor = True
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 490)
        Me.Controls.Add(Me.btn_logs)
        Me.Controls.Add(Me.btn_sales)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_cust)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_stock)
        Me.Controls.Add(Me.btn_part)
        Me.Name = "Navigation"
        Me.Text = "Navigation"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_part As Button
    Friend WithEvents btn_stock As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_cust As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_sales As Button
    Friend WithEvents btn_logs As Button
End Class
