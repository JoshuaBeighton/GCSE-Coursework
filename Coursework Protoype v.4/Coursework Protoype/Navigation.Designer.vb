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
        Me.btn_sales = New System.Windows.Forms.Button()
        Me.btn_logs = New System.Windows.Forms.Button()
        Me.btn_cust = New System.Windows.Forms.Button()
        Me.btn_orders = New System.Windows.Forms.Button()
        Me.btn_stock = New System.Windows.Forms.Button()
        Me.btn_parts = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_sales
        '
        Me.btn_sales.Location = New System.Drawing.Point(713, 12)
        Me.btn_sales.Name = "btn_sales"
        Me.btn_sales.Size = New System.Drawing.Size(75, 56)
        Me.btn_sales.TabIndex = 0
        Me.btn_sales.Text = "sales"
        Me.btn_sales.UseVisualStyleBackColor = True
        '
        'btn_logs
        '
        Me.btn_logs.Location = New System.Drawing.Point(358, 12)
        Me.btn_logs.Name = "btn_logs"
        Me.btn_logs.Size = New System.Drawing.Size(75, 56)
        Me.btn_logs.TabIndex = 0
        Me.btn_logs.Text = "Logs"
        Me.btn_logs.UseVisualStyleBackColor = True
        '
        'btn_cust
        '
        Me.btn_cust.Location = New System.Drawing.Point(12, 12)
        Me.btn_cust.Name = "btn_cust"
        Me.btn_cust.Size = New System.Drawing.Size(75, 56)
        Me.btn_cust.TabIndex = 0
        Me.btn_cust.Text = "Customers"
        Me.btn_cust.UseVisualStyleBackColor = True
        '
        'btn_orders
        '
        Me.btn_orders.Location = New System.Drawing.Point(12, 74)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(75, 56)
        Me.btn_orders.TabIndex = 0
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = True
        '
        'btn_stock
        '
        Me.btn_stock.Location = New System.Drawing.Point(12, 136)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(75, 56)
        Me.btn_stock.TabIndex = 0
        Me.btn_stock.Text = "Stock"
        Me.btn_stock.UseVisualStyleBackColor = True
        '
        'btn_parts
        '
        Me.btn_parts.Location = New System.Drawing.Point(12, 198)
        Me.btn_parts.Name = "btn_parts"
        Me.btn_parts.Size = New System.Drawing.Size(75, 56)
        Me.btn_parts.TabIndex = 0
        Me.btn_parts.Text = "Parts"
        Me.btn_parts.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 260)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 56)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Staff"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.btn_parts)
        Me.Controls.Add(Me.btn_stock)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.btn_cust)
        Me.Controls.Add(Me.btn_logs)
        Me.Controls.Add(Me.btn_sales)
        Me.Name = "Navigation"
        Me.Text = "Navigation"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_sales As Button
    Friend WithEvents btn_logs As Button
    Friend WithEvents btn_cust As Button
    Friend WithEvents btn_orders As Button
    Friend WithEvents btn_stock As Button
    Friend WithEvents btn_parts As Button
    Friend WithEvents Button7 As Button
End Class
