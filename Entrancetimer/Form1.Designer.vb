<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.t15 = New System.Windows.Forms.Label
        Me.t14 = New System.Windows.Forms.Label
        Me.La1 = New System.Windows.Forms.Label
        Me.la2 = New System.Windows.Forms.Label
        Me.la10 = New System.Windows.Forms.Label
        Me.la6 = New System.Windows.Forms.Label
        Me.la7 = New System.Windows.Forms.Label
        Me.la8 = New System.Windows.Forms.Label
        Me.closetim = New System.Windows.Forms.Timer(Me.components)
        Me.showtim = New System.Windows.Forms.Timer(Me.components)
        Me.hidetim = New System.Windows.Forms.Timer(Me.components)
        Me.timingtim = New System.Windows.Forms.Timer(Me.components)
        Me.ico1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        't15
        '
        Me.t15.AutoSize = True
        Me.t15.BackColor = System.Drawing.Color.Transparent
        Me.t15.Font = New System.Drawing.Font("Microsoft YaHei UI", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.t15.ForeColor = System.Drawing.Color.White
        Me.t15.Location = New System.Drawing.Point(321, 93)
        Me.t15.Name = "t15"
        Me.t15.Size = New System.Drawing.Size(135, 71)
        Me.t15.TabIndex = 0
        Me.t15.Text = "888"
        '
        't14
        '
        Me.t14.AutoSize = True
        Me.t14.BackColor = System.Drawing.Color.Transparent
        Me.t14.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t14.ForeColor = System.Drawing.Color.White
        Me.t14.Location = New System.Drawing.Point(288, 20)
        Me.t14.Name = "t14"
        Me.t14.Size = New System.Drawing.Size(75, 41)
        Me.t14.TabIndex = 1
        Me.t14.Text = "888"
        '
        'La1
        '
        Me.La1.AutoSize = True
        Me.La1.BackColor = System.Drawing.Color.Transparent
        Me.La1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.La1.ForeColor = System.Drawing.Color.White
        Me.La1.Location = New System.Drawing.Point(39, 28)
        Me.La1.Name = "La1"
        Me.La1.Size = New System.Drawing.Size(359, 30)
        Me.La1.TabIndex = 2
        Me.La1.Text = "距离          年高考还有            天"
        '
        'la2
        '
        Me.la2.AutoSize = True
        Me.la2.BackColor = System.Drawing.Color.Transparent
        Me.la2.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.la2.ForeColor = System.Drawing.Color.White
        Me.la2.Location = New System.Drawing.Point(93, 28)
        Me.la2.Name = "la2"
        Me.la2.Size = New System.Drawing.Size(70, 31)
        Me.la2.TabIndex = 3
        Me.la2.Text = "2014"
        '
        'la10
        '
        Me.la10.AutoSize = True
        Me.la10.BackColor = System.Drawing.Color.Transparent
        Me.la10.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.la10.ForeColor = System.Drawing.Color.White
        Me.la10.Location = New System.Drawing.Point(441, 136)
        Me.la10.Name = "la10"
        Me.la10.Size = New System.Drawing.Size(25, 20)
        Me.la10.TabIndex = 11
        Me.la10.Text = "天"
        '
        'la6
        '
        Me.la6.AutoSize = True
        Me.la6.BackColor = System.Drawing.Color.Transparent
        Me.la6.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la6.ForeColor = System.Drawing.Color.White
        Me.la6.Location = New System.Drawing.Point(59, 102)
        Me.la6.Name = "la6"
        Me.la6.Size = New System.Drawing.Size(54, 26)
        Me.la6.TabIndex = 7
        Me.la6.Text = "距离"
        '
        'la7
        '
        Me.la7.AutoSize = True
        Me.la7.BackColor = System.Drawing.Color.Transparent
        Me.la7.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.la7.ForeColor = System.Drawing.Color.White
        Me.la7.Location = New System.Drawing.Point(111, 93)
        Me.la7.Name = "la7"
        Me.la7.Size = New System.Drawing.Size(89, 37)
        Me.la7.TabIndex = 8
        Me.la7.Text = "2015"
        '
        'la8
        '
        Me.la8.AutoSize = True
        Me.la8.BackColor = System.Drawing.Color.Transparent
        Me.la8.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.la8.ForeColor = System.Drawing.Color.White
        Me.la8.Location = New System.Drawing.Point(195, 99)
        Me.la8.Name = "la8"
        Me.la8.Size = New System.Drawing.Size(133, 30)
        Me.la8.TabIndex = 9
        Me.la8.Text = "年高考还有"
        '
        'closetim
        '
        Me.closetim.Interval = 1
        '
        'showtim
        '
        Me.showtim.Interval = 1
        '
        'hidetim
        '
        Me.hidetim.Interval = 1
        '
        'timingtim
        '
        Me.timingtim.Interval = 3000
        '
        'ico1
        '
        Me.ico1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(513, 217)
        Me.Controls.Add(Me.la10)
        Me.Controls.Add(Me.t14)
        Me.Controls.Add(Me.t15)
        Me.Controls.Add(Me.la8)
        Me.Controls.Add(Me.la7)
        Me.Controls.Add(Me.la6)
        Me.Controls.Add(Me.la2)
        Me.Controls.Add(Me.La1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(511, 551)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t15 As System.Windows.Forms.Label
    Friend WithEvents t14 As System.Windows.Forms.Label
    Friend WithEvents La1 As System.Windows.Forms.Label
    Friend WithEvents la10 As System.Windows.Forms.Label
    Friend WithEvents la6 As System.Windows.Forms.Label
    Friend WithEvents la2 As System.Windows.Forms.Label
    Friend WithEvents la7 As System.Windows.Forms.Label
    Friend WithEvents la8 As System.Windows.Forms.Label
    Friend WithEvents closetim As System.Windows.Forms.Timer
    Friend WithEvents showtim As System.Windows.Forms.Timer
    Friend WithEvents hidetim As System.Windows.Forms.Timer
    Friend WithEvents timingtim As System.Windows.Forms.Timer
    Friend WithEvents ico1 As System.Windows.Forms.NotifyIcon

End Class
