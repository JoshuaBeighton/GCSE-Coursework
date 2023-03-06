<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_addCust = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(13, 14)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(851, 556)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(872, 115)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(187, 83)
        Me.btn_Clear.TabIndex = 14
        Me.btn_Clear.Text = "Clear Filters"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(872, 487)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(187, 83)
        Me.btn_back.TabIndex = 18
        Me.btn_back.Text = "Go Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(872, 394)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(187, 83)
        Me.btn_edit.TabIndex = 17
        Me.btn_edit.Text = "Edit Order"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(872, 301)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(187, 83)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "Delete Order"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_addCust
        '
        Me.btn_addCust.Location = New System.Drawing.Point(872, 208)
        Me.btn_addCust.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_addCust.Name = "btn_addCust"
        Me.btn_addCust.Size = New System.Drawing.Size(187, 83)
        Me.btn_addCust.TabIndex = 15
        Me.btn_addCust.Text = "Add Customer"
        Me.btn_addCust.UseVisualStyleBackColor = True
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 590)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_addCust)
        Me.Name = "Customers"
        Me.Text = "Customers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_addCust As Button
End Class
