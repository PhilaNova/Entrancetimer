<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.guilab = New System.Windows.Forms.Label
        Me.tilab1 = New System.Windows.Forms.Label
        Me.tilab2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'guilab
        '
        Me.guilab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.guilab.ForeColor = System.Drawing.Color.White
        Me.guilab.Location = New System.Drawing.Point(0, 0)
        Me.guilab.Name = "guilab"
        Me.guilab.Size = New System.Drawing.Size(218, 768)
        Me.guilab.TabIndex = 0
        '
        'tilab1
        '
        Me.tilab1.AutoSize = True
        Me.tilab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tilab1.Font = New System.Drawing.Font("Microsoft YaHei UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tilab1.ForeColor = System.Drawing.Color.White
        Me.tilab1.Location = New System.Drawing.Point(95, 9)
        Me.tilab1.Name = "tilab1"
        Me.tilab1.Size = New System.Drawing.Size(123, 61)
        Me.tilab1.TabIndex = 1
        Me.tilab1.Text = "验证"
        '
        'tilab2
        '
        Me.tilab2.AutoSize = True
        Me.tilab2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tilab2.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tilab2.ForeColor = System.Drawing.Color.White
        Me.tilab2.Location = New System.Drawing.Point(12, 70)
        Me.tilab2.Name = "tilab2"
        Me.tilab2.Size = New System.Drawing.Size(205, 41)
        Me.tilab2.TabIndex = 2
        Me.tilab2.Text = "Certification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "· 要开始，您必须进行验证" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "· 请在右图中点击正确的三点"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(158, 733)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "退出"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tilab1)
        Me.Controls.Add(Me.tilab2)
        Me.Controls.Add(Me.guilab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "实验性分支"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guilab As System.Windows.Forms.Label
    Friend WithEvents tilab1 As System.Windows.Forms.Label
    Friend WithEvents tilab2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
