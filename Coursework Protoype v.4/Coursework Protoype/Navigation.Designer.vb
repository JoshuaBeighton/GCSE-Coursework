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
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_sales
        '
        Me.btn_sales.Location = New System.Drawing.Point(1019, 20)
        Me.btn_sales.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_sales.Name = "btn_sales"
        Me.btn_sales.Size = New System.Drawing.Size(107, 93)
        Me.btn_sales.TabIndex = 0
        Me.btn_sales.Text = "sales"
        Me.btn_sales.UseVisualStyleBackColor = True
        '
        'btn_logs
        '
        Me.btn_logs.Location = New System.Drawing.Point(511, 20)
        Me.btn_logs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_logs.Name = "btn_logs"
        Me.btn_logs.Size = New System.Drawing.Size(107, 93)
        Me.btn_logs.TabIndex = 0
        Me.btn_logs.Text = "Logs"
        Me.btn_logs.UseVisualStyleBackColor = True
        '
        'btn_cust
        '
        Me.btn_cust.Location = New System.Drawing.Point(17, 20)
        Me.btn_cust.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cust.Name = "btn_cust"
        Me.btn_cust.Size = New System.Drawing.Size(107, 93)
        Me.btn_cust.TabIndex = 0
        Me.btn_cust.Text = "Customers"
        Me.btn_cust.UseVisualStyleBackColor = True
        '
        'btn_orders
        '
        Me.btn_orders.Location = New System.Drawing.Point(17, 123)
        Me.btn_orders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_orders.Name = "btn_orders"
        Me.btn_orders.Size = New System.Drawing.Size(107, 93)
        Me.btn_orders.TabIndex = 0
        Me.btn_orders.Text = "Orders"
        Me.btn_orders.UseVisualStyleBackColor = True
        '
        'btn_stock
        '
        Me.btn_stock.Location = New System.Drawing.Point(17, 227)
        Me.btn_stock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(107, 93)
        Me.btn_stock.TabIndex = 0
        Me.btn_stock.Text = "Stock"
        Me.btn_stock.UseVisualStyleBackColor = True
        '
        'btn_parts
        '
        Me.btn_parts.Location = New System.Drawing.Point(17, 330)
        Me.btn_parts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_parts.Name = "btn_parts"
        Me.btn_parts.Size = New System.Drawing.Size(107, 93)
        Me.btn_parts.TabIndex = 0
        Me.btn_parts.Text = "Parts"
        Me.btn_parts.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.Location = New System.Drawing.Point(17, 433)
        Me.btn_staff.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(107, 93)
        Me.btn_staff.TabIndex = 0
        Me.btn_staff.Text = "Staff"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(801, 660)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(325, 76)
        Me.btn_logout.TabIndex = 0
        Me.btn_logout.Text = "Sign Out"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 750)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_parts)
        Me.Controls.Add(Me.btn_stock)
        Me.Controls.Add(Me.btn_orders)
        Me.Controls.Add(Me.btn_cust)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_logs)
        Me.Controls.Add(Me.btn_sales)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents btn_staff As Button
    Friend WithEvents btn_logout As Button
End Class
