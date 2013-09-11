<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.scr = New System.Windows.Forms.Label
        Me.tim = New System.Windows.Forms.Label
        Me.closelab = New System.Windows.Forms.Label
        Me.colorlab = New System.Windows.Forms.Label
        Me.doc = New System.Windows.Forms.Label
        Me.closetim = New System.Windows.Forms.Timer(Me.components)
        Me.showtim = New System.Windows.Forms.Timer(Me.components)
        Me.hidetim = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.anitim1 = New System.Windows.Forms.Timer(Me.components)
        Me.anitim2 = New System.Windows.Forms.Timer(Me.components)
        Me.anitim3 = New System.Windows.Forms.Timer(Me.components)
        Me.antim1 = New System.Windows.Forms.Timer(Me.components)
        Me.antim2 = New System.Windows.Forms.Timer(Me.components)
        Me.antim3 = New System.Windows.Forms.Timer(Me.components)
        Me.fhidetim = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'scr
        '
        Me.scr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.scr.Image = Global.Entrancetimer.My.Resources.Resources.monitor
        Me.scr.Location = New System.Drawing.Point(90, 108)
        Me.scr.Name = "scr"
        Me.scr.Size = New System.Drawing.Size(72, 72)
        Me.scr.TabIndex = 0
        '
        'tim
        '
        Me.tim.BackColor = System.Drawing.Color.RoyalBlue
        Me.tim.Image = Global.Entrancetimer.My.Resources.Resources.stopwatch
        Me.tim.Location = New System.Drawing.Point(90, 108)
        Me.tim.Name = "tim"
        Me.tim.Size = New System.Drawing.Size(72, 72)
        Me.tim.TabIndex = 2
        '
        'closelab
        '
        Me.closelab.BackColor = System.Drawing.Color.OrangeRed
        Me.closelab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closelab.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.closelab.ForeColor = System.Drawing.Color.SeaShell
        Me.closelab.Location = New System.Drawing.Point(264, 4)
        Me.closelab.Name = "closelab"
        Me.closelab.Size = New System.Drawing.Size(28, 28)
        Me.closelab.TabIndex = 15
        Me.closelab.Text = "×"
        Me.closelab.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'colorlab
        '
        Me.colorlab.BackColor = System.Drawing.Color.OrangeRed
        Me.colorlab.ForeColor = System.Drawing.Color.Transparent
        Me.colorlab.Location = New System.Drawing.Point(247, 4)
        Me.colorlab.Name = "colorlab"
        Me.colorlab.Size = New System.Drawing.Size(10, 28)
        Me.colorlab.TabIndex = 14
        '
        'doc
        '
        Me.doc.BackColor = System.Drawing.Color.OliveDrab
        Me.doc.Image = Global.Entrancetimer.My.Resources.Resources.stackoverflow_com
        Me.doc.Location = New System.Drawing.Point(90, 108)
        Me.doc.Name = "doc"
        Me.doc.Size = New System.Drawing.Size(72, 72)
        Me.doc.TabIndex = 1
        '
        'closetim
        '
        Me.closetim.Interval = 20
        '
        'showtim
        '
        Me.showtim.Interval = 5
        '
        'hidetim
        '
        Me.hidetim.Interval = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "三个标签位置：红12,4绿90,4蓝168.4"
        Me.Label3.Visible = False
        '
        'anitim1
        '
        Me.anitim1.Interval = 1
        '
        'anitim2
        '
        Me.anitim2.Interval = 1
        '
        'anitim3
        '
        Me.anitim3.Interval = 1
        '
        'antim1
        '
        Me.antim1.Interval = 1
        '
        'antim2
        '
        Me.antim2.Interval = 1
        '
        'antim3
        '
        Me.antim3.Interval = 1
        '
        'fhidetim
        '
        Me.fhidetim.Interval = 20
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(252, 143)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.closelab)
        Me.Controls.Add(Me.colorlab)
        Me.Controls.Add(Me.tim)
        Me.Controls.Add(Me.doc)
        Me.Controls.Add(Me.scr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(772, 625)
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form2"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents scr As System.Windows.Forms.Label
    Friend WithEvents tim As System.Windows.Forms.Label
    Friend WithEvents closelab As System.Windows.Forms.Label
    Friend WithEvents colorlab As System.Windows.Forms.Label
    Friend WithEvents doc As System.Windows.Forms.Label
    Friend WithEvents closetim As System.Windows.Forms.Timer
    Friend WithEvents showtim As System.Windows.Forms.Timer
    Friend WithEvents hidetim As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents anitim1 As System.Windows.Forms.Timer
    Friend WithEvents anitim2 As System.Windows.Forms.Timer
    Friend WithEvents anitim3 As System.Windows.Forms.Timer
    Friend WithEvents antim1 As System.Windows.Forms.Timer
    Friend WithEvents antim2 As System.Windows.Forms.Timer
    Friend WithEvents antim3 As System.Windows.Forms.Timer
    Friend WithEvents fhidetim As System.Windows.Forms.Timer
End Class
