Public Class Form1

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ico1.Visible = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        t14.Text = DateDiff(DateInterval.Day, DateTime.Today, DateSerial(2014, 6, 7))
        t15.Text = DateDiff(DateInterval.Day, DateTime.Today, DateSerial(2015, 6, 7))
        timingtim.Interval = 3000
        timingtim.Enabled = True
        ico1.Icon = New System.Drawing.Icon(My.Computer.FileSystem.CurrentDirectory + "\ico\paper.ico")
        ico1.Visible = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub La1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles La1.Click

    End Sub

  

    Private Sub closetim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closetim.Tick
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        If Me.Location.Y >= 768 Then Me.Hide()
    End Sub


    Private Sub Form1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        timingtim.Interval = 1000
        timingtim.Enabled = True
    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub



   

    Private Sub timingtim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timingtim.Tick
        closetim.Enabled = True
        timingtim.Enabled = False
    End Sub


    Private Sub La1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles La1.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub

    Private Sub t14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t14.Click

    End Sub

    Private Sub t14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles t14.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub

    Private Sub la6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles la6.Click

    End Sub

    Private Sub la6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles la6.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub

    Private Sub la7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles la7.Click

    End Sub

    Private Sub la7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles la7.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub

    Private Sub la8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles la8.Click

    End Sub

    Private Sub la8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles la8.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub

    Private Sub t15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t15.Click

    End Sub

    Private Sub t15_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles t15.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub

    Private Sub la10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles la10.Click

    End Sub

    Private Sub la10_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles la10.MouseMove
        timingtim.Enabled = False
        closetim.Enabled = False
        Me.Location = New Point(511, 551)
    End Sub

    Private Sub ico1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ico1.Click

    End Sub

    Private Sub ico1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ico1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Form2.Visible = True Then
                Form2.antim1.Enabled = True
                Form2.antim2.Enabled = True
                Form2.antim3.Enabled = True
                Form2.fhidetim.Enabled = True
            Else
                Form2.Visible = True
            End If
        End If
    End Sub

    Private Sub ico1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ico1.MouseDoubleClick

    End Sub
End Class
