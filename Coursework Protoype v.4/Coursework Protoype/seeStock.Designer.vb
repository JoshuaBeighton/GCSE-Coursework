<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seeStock
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
        Me.cmb_arrived = New System.Windows.Forms.ComboBox()
        Me.cmb_type = New System.Windows.Forms.ComboBox()
        Me.lbl_Ordered = New System.Windows.Forms.Label()
        Me.cmb_ordered = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.cmb_due = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trk_min = New System.Windows.Forms.TrackBar()
        Me.trk_max = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_part = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_max = New System.Windows.Forms.Label()
        Me.lbl_min = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.trk_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trk_max, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_arrived
        '
        Me.cmb_arrived.FormattingEnabled = True
        Me.cmb_arrived.Location = New System.Drawing.Point(1053, 20)
        Me.cmb_arrived.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_arrived.Name = "cmb_arrived"
        Me.cmb_arrived.Size = New System.Drawing.Size(171, 33)
        Me.cmb_arrived.TabIndex = 19
        Me.cmb_arrived.Text = "Arrived"
        '
        'cmb_type
        '
        Me.cmb_type.FormattingEnabled = True
        Me.cmb_type.Location = New System.Drawing.Point(17, 20)
        Me.cmb_type.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_type.Name = "cmb_type"
        Me.cmb_type.Size = New System.Drawing.Size(171, 33)
        Me.cmb_type.TabIndex = 21
        Me.cmb_type.Text = "Type"
        '
        'lbl_Ordered
        '
        Me.lbl_Ordered.AutoSize = True
        Me.lbl_Ordered.Location = New System.Drawing.Point(464, 75)
        Me.lbl_Ordered.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Ordered.Name = "lbl_Ordered"
        Me.lbl_Ordered.Size = New System.Drawing.Size(78, 25)
        Me.lbl_Ordered.TabIndex = 17
        Me.lbl_Ordered.Text = "Ordered"
        '
        'cmb_ordered
        '
        Me.cmb_ordered.FormattingEnabled = True
        Me.cmb_ordered.Items.AddRange(New Object() {"Before", "On", "After"})
        Me.cmb_ordered.Location = New System.Drawing.Point(577, 70)
        Me.cmb_ordered.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_ordered.Name = "cmb_ordered"
        Me.cmb_ordered.Size = New System.Drawing.Size(171, 33)
        Me.cmb_ordered.TabIndex = 16
        Me.cmb_ordered.Text = "Not Filtered"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(464, 20)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(284, 31)
        Me.DateTimePicker1.TabIndex = 15
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(17, 262)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1210, 542)
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(1234, 17)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(187, 83)
        Me.btn_Clear.TabIndex = 9
        Me.btn_Clear.Text = "Clear Filters"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1234, 262)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 83)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add Stock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(759, 20)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(284, 31)
        Me.DateTimePicker2.TabIndex = 15
        '
        'cmb_due
        '
        Me.cmb_due.FormattingEnabled = True
        Me.cmb_due.Items.AddRange(New Object() {"Before", "On", "After"})
        Me.cmb_due.Location = New System.Drawing.Point(871, 70)
        Me.cmb_due.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_due.Name = "cmb_due"
        Me.cmb_due.Size = New System.Drawing.Size(171, 33)
        Me.cmb_due.TabIndex = 16
        Me.cmb_due.Text = "Not Filtered"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(759, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Due"
        '
        'trk_min
        '
        Me.trk_min.Location = New System.Drawing.Point(17, 118)
        Me.trk_min.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trk_min.Name = "trk_min"
        Me.trk_min.Size = New System.Drawing.Size(1139, 69)
        Me.trk_min.TabIndex = 22
        '
        'trk_max
        '
        Me.trk_max.Location = New System.Drawing.Point(17, 177)
        Me.trk_max.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trk_max.Name = "trk_max"
        Me.trk_max.Size = New System.Drawing.Size(1139, 69)
        Me.trk_max.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1186, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1186, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Max"
        '
        'cmb_part
        '
        Me.cmb_part.FormattingEnabled = True
        Me.cmb_part.Location = New System.Drawing.Point(199, 20)
        Me.cmb_part.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_part.Name = "cmb_part"
        Me.cmb_part.Size = New System.Drawing.Size(255, 33)
        Me.cmb_part.TabIndex = 19
        Me.cmb_part.Text = "Part"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1234, 723)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 83)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Go Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_max
        '
        Me.lbl_max.AutoSize = True
        Me.lbl_max.Location = New System.Drawing.Point(1111, 232)
        Me.lbl_max.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_max.Name = "lbl_max"
        Me.lbl_max.Size = New System.Drawing.Size(45, 25)
        Me.lbl_max.TabIndex = 24
        Me.lbl_max.Text = "max"
        '
        'lbl_min
        '
        Me.lbl_min.AutoSize = True
        Me.lbl_min.Location = New System.Drawing.Point(17, 232)
        Me.lbl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_min.Name = "lbl_min"
        Me.lbl_min.Size = New System.Drawing.Size(42, 25)
        Me.lbl_min.TabIndex = 24
        Me.lbl_min.Text = "min"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1234, 356)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 83)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete Stock"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1234, 449)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(187, 83)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Edit Stock"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'seeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 827)
        Me.Controls.Add(Me.lbl_min)
        Me.Controls.Add(Me.lbl_max)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.trk_max)
        Me.Controls.Add(Me.trk_min)
        Me.Controls.Add(Me.cmb_part)
        Me.Controls.Add(Me.cmb_arrived)
        Me.Controls.Add(Me.cmb_type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Ordered)
        Me.Controls.Add(Me.cmb_due)
        Me.Controls.Add(Me.cmb_ordered)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "seeStock"
        Me.Text = "See Stock"
        CType(Me.trk_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trk_max, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_arrived As ComboBox
    Friend WithEvents cmb_type As ComboBox
    Friend WithEvents lbl_Ordered As Label
    Friend WithEvents cmb_ordered As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btn_Clear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents cmb_due As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents trk_min As TrackBar
    Friend WithEvents trk_max As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_part As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_max As Label
    Friend WithEvents lbl_min As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
