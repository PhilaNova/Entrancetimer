<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container
        Me.Tilab1 = New System.Windows.Forms.Label
        Me.tilab2 = New System.Windows.Forms.Label
        Me.scrtim = New System.Windows.Forms.Timer(Me.components)
        Me.bklab = New System.Windows.Forms.Label
        Me.qulab = New System.Windows.Forms.Label
        Me.anitim1 = New System.Windows.Forms.Timer(Me.components)
        Me.tiplab = New System.Windows.Forms.Label
        Me.anitim2 = New System.Windows.Forms.Timer(Me.components)
        Me.closetim = New System.Windows.Forms.Timer(Me.components)
        Me.closetim2 = New System.Windows.Forms.Timer(Me.components)
        Me.closetim3 = New System.Windows.Forms.Timer(Me.components)
        Me.closetim4 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Tilab1
        '
        Me.Tilab1.AutoSize = True
        Me.Tilab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Tilab1.Font = New System.Drawing.Font("Microsoft YaHei UI", 42.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tilab1.ForeColor = System.Drawing.Color.White
        Me.Tilab1.Location = New System.Drawing.Point(-498, 18)
        Me.Tilab1.Name = "Tilab1"
        Me.Tilab1.Size = New System.Drawing.Size(498, 71)
        Me.Tilab1.TabIndex = 0
        Me.Tilab1.Text = "Presentation 演示"
        '
        'tilab2
        '
        Me.tilab2.AutoSize = True
        Me.tilab2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tilab2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tilab2.ForeColor = System.Drawing.Color.White
        Me.tilab2.Location = New System.Drawing.Point(-250, 89)
        Me.tilab2.Name = "tilab2"
        Me.tilab2.Size = New System.Drawing.Size(221, 18)
        Me.tilab2.TabIndex = 1
        Me.tilab2.Text = "在下方点击并输入文字,即可被演示"
        '
        'scrtim
        '
        Me.scrtim.Interval = 1
        '
        'bklab
        '
        Me.bklab.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bklab.Location = New System.Drawing.Point(0, -138)
        Me.bklab.Name = "bklab"
        Me.bklab.Size = New System.Drawing.Size(1024, 138)
        Me.bklab.TabIndex = 2
        '
        'qulab
        '
        Me.qulab.BackColor = System.Drawing.Color.Transparent
        Me.qulab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.qulab.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qulab.ForeColor = System.Drawing.Color.White
        Me.qulab.Location = New System.Drawing.Point(878, 707)
        Me.qulab.Name = "qulab"
        Me.qulab.Size = New System.Drawing.Size(0, 32)
        Me.qulab.TabIndex = 3
        Me.qulab.Text = "退出"
        '
        'anitim1
        '
        Me.anitim1.Interval = 1
        '
        'tiplab
        '
        Me.tiplab.AutoSize = True
        Me.tiplab.ForeColor = System.Drawing.Color.White
        Me.tiplab.Location = New System.Drawing.Point(31, 199)
        Me.tiplab.Name = "tiplab"
        Me.tiplab.Size = New System.Drawing.Size(281, 36)
        Me.tiplab.TabIndex = 4
        Me.tiplab.Text = "tilab1 31, 18 ;tilab2 40, 89 ;bklab 0,0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tilab1 -498, 18 ;tilab2 -250, 89 ;bklab " & _
            "0,-138" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "qulab.size=63, 32"
        Me.tiplab.Visible = False
        '
        'anitim2
        '
        Me.anitim2.Interval = 1
        '
        'closetim
        '
        Me.closetim.Interval = 1
        '
        'closetim2
        '
        Me.closetim2.Interval = 1
        '
        'closetim3
        '
        Me.closetim3.Interval = 1
        '
        'closetim4
        '
        Me.closetim4.Interval = 1
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.tiplab)
        Me.Controls.Add(Me.qulab)
        Me.Controls.Add(Me.tilab2)
        Me.Controls.Add(Me.Tilab1)
        Me.Controls.Add(Me.bklab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 768)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tilab1 As System.Windows.Forms.Label
    Friend WithEvents tilab2 As System.Windows.Forms.Label
    Friend WithEvents scrtim As System.Windows.Forms.Timer
    Friend WithEvents bklab As System.Windows.Forms.Label
    Friend WithEvents qulab As System.Windows.Forms.Label
    Friend WithEvents anitim1 As System.Windows.Forms.Timer
    Friend WithEvents tiplab As System.Windows.Forms.Label
    Friend WithEvents anitim2 As System.Windows.Forms.Timer
    Friend WithEvents closetim As System.Windows.Forms.Timer
    Friend WithEvents closetim2 As System.Windows.Forms.Timer
    Friend WithEvents closetim3 As System.Windows.Forms.Timer
    Friend WithEvents closetim4 As System.Windows.Forms.Timer
End Class
