<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartsNaviagtion
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
        Me.btn_CPU = New System.Windows.Forms.Button()
        Me.btn_GPU = New System.Windows.Forms.Button()
        Me.btn_RAM = New System.Windows.Forms.Button()
        Me.btn_PSU = New System.Windows.Forms.Button()
        Me.btn_case = New System.Windows.Forms.Button()
        Me.btn_moba = New System.Windows.Forms.Button()
        Me.btn_sto = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_CPU
        '
        Me.btn_CPU.Location = New System.Drawing.Point(12, 12)
        Me.btn_CPU.Name = "btn_CPU"
        Me.btn_CPU.Size = New System.Drawing.Size(130, 83)
        Me.btn_CPU.TabIndex = 0
        Me.btn_CPU.Text = "CPUs"
        Me.btn_CPU.UseVisualStyleBackColor = True
        '
        'btn_GPU
        '
        Me.btn_GPU.Location = New System.Drawing.Point(148, 12)
        Me.btn_GPU.Name = "btn_GPU"
        Me.btn_GPU.Size = New System.Drawing.Size(130, 83)
        Me.btn_GPU.TabIndex = 1
        Me.btn_GPU.Text = "GPUs"
        Me.btn_GPU.UseVisualStyleBackColor = True
        '
        'btn_RAM
        '
        Me.btn_RAM.Location = New System.Drawing.Point(284, 12)
        Me.btn_RAM.Name = "btn_RAM"
        Me.btn_RAM.Size = New System.Drawing.Size(130, 83)
        Me.btn_RAM.TabIndex = 2
        Me.btn_RAM.Text = "RAM"
        Me.btn_RAM.UseVisualStyleBackColor = True
        '
        'btn_PSU
        '
        Me.btn_PSU.Location = New System.Drawing.Point(420, 12)
        Me.btn_PSU.Name = "btn_PSU"
        Me.btn_PSU.Size = New System.Drawing.Size(130, 83)
        Me.btn_PSU.TabIndex = 3
        Me.btn_PSU.Text = "PSU"
        Me.btn_PSU.UseVisualStyleBackColor = True
        '
        'btn_case
        '
        Me.btn_case.Location = New System.Drawing.Point(12, 101)
        Me.btn_case.Name = "btn_case"
        Me.btn_case.Size = New System.Drawing.Size(130, 83)
        Me.btn_case.TabIndex = 4
        Me.btn_case.Text = "Case"
        Me.btn_case.UseVisualStyleBackColor = True
        '
        'btn_moba
        '
        Me.btn_moba.Location = New System.Drawing.Point(148, 101)
        Me.btn_moba.Name = "btn_moba"
        Me.btn_moba.Size = New System.Drawing.Size(130, 83)
        Me.btn_moba.TabIndex = 5
        Me.btn_moba.Text = "Motherboard"
        Me.btn_moba.UseVisualStyleBackColor = True
        '
        'btn_sto
        '
        Me.btn_sto.Location = New System.Drawing.Point(284, 101)
        Me.btn_sto.Name = "btn_sto"
        Me.btn_sto.Size = New System.Drawing.Size(130, 83)
        Me.btn_sto.TabIndex = 6
        Me.btn_sto.Text = "Storage"
        Me.btn_sto.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(420, 101)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(130, 83)
        Me.btn_back.TabIndex = 7
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'PartsNaviagtion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 194)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_sto)
        Me.Controls.Add(Me.btn_moba)
        Me.Controls.Add(Me.btn_case)
        Me.Controls.Add(Me.btn_PSU)
        Me.Controls.Add(Me.btn_RAM)
        Me.Controls.Add(Me.btn_GPU)
        Me.Controls.Add(Me.btn_CPU)
        Me.Name = "PartsNaviagtion"
        Me.Text = "Select Part"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_CPU As Button
    Friend WithEvents btn_GPU As Button
    Friend WithEvents btn_RAM As Button
    Friend WithEvents btn_PSU As Button
    Friend WithEvents btn_case As Button
    Friend WithEvents btn_moba As Button
    Friend WithEvents btn_sto As Button
    Friend WithEvents btn_back As Button
End Class
