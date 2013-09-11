Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        anitim1.Enabled = True
        anitim2.Enabled = True
        anitim3.Enabled = True
    End Sub
    Private Sub closelab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles closelab.Click
        closelab.Visible = False
        colorlab.Visible = False
        closetim.Enabled = True
        antim1.Enabled = True
        antim2.Enabled = True
        antim3.Enabled = True
    End Sub

    Private Sub closelab_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles closelab.MouseDown
        closelab.ForeColor = Color.Orange
    End Sub

    Private Sub closelab_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles closelab.MouseHover

    End Sub

    Private Sub closelab_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles closelab.MouseLeave
        hidetim.Enabled = True
        showtim.Enabled = False
        colorlab.Visible = True
    End Sub

    Private Sub closelab_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles closelab.MouseMove

    End Sub

    Private Sub closelab_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles closelab.MouseUp
        closelab.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub colorlab_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorlab.MouseLeave

    End Sub

    Private Sub colorlab_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles colorlab.MouseMove
        colorlab.Visible = False
        showtim.Enabled = True
        hidetim.Enabled = False
    End Sub

    Private Sub colorlab_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles colorlab.MouseUp
        closelab.ForeColor = Color.WhiteSmoke
    End Sub
    Private Sub colorlab_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles colorlab.MouseDown
        closelab.ForeColor = Color.Orange
    End Sub

    Private Sub colorlab_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorlab.MouseHover
    End Sub

    Private Sub closetim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closetim.Tick
        If scr.Location = New Point(90, 108) Then
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub colorlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorlab.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub showtim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showtim.Tick
        closelab.Visible = True
        closelab.Location = New Point(228, 4)
        showtim.Enabled = False
    End Sub

    Private Sub hidetim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hidetim.Tick
        closelab.Location = New Point(264, 4)
        closelab.Visible = False
    End Sub

    Private Sub anitim1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anitim1.Tick
        doc.Enabled = False
        doc.Location = New Point(doc.Location.X, doc.Location.Y - 8)
        If doc.Location.Y <= 4 Then
            doc.Location = New Point(90, 4)
            anitim1.Enabled = False
            doc.Enabled = True
        End If

    End Sub

    Private Sub anitim2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anitim2.Tick
        scr.Enabled = False
        scr.Location = New Point(scr.Location.X - 8, scr.Location.Y - (32 / 3))
        If scr.Location.X <= 12 Or scr.Location.Y <= 4 Then
            scr.Location = New Point(12, 4)
            anitim2.Enabled = False
            scr.Enabled = True
        End If
    End Sub

    Private Sub tim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tim.Click

    End Sub

    Private Sub anitim3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anitim3.Tick
        tim.Enabled = False
        tim.Location = New Point(tim.Location.X + 8, tim.Location.Y - (32 / 3))
        If tim.Location.X >= 168 Or tim.Location.Y <= 4 Then
            tim.Location = New Point(168, 4)
            anitim3.Enabled = False
            tim.Enabled = True
        End If
    End Sub

    Private Sub antim1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles antim1.Tick
        doc.Enabled = False
        doc.Location = New Point(doc.Location.X, doc.Location.Y + 8)
        If doc.Location.Y >= 108 Then
            doc.Location = New Point(90, 108)
            antim1.Enabled = False
            doc.Enabled = True
        End If
    End Sub

    Private Sub antim2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles antim2.Tick
        scr.Enabled = False
        scr.Location = New Point(scr.Location.X + 8, scr.Location.Y + (32 / 3))
        If scr.Location.X >= 90 Or scr.Location.Y >= 108 Then
            scr.Location = New Point(90, 108)
            antim2.Enabled = False
            scr.Enabled = True
        End If
    End Sub

    Private Sub antim3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles antim3.Tick
        tim.Enabled = False
        tim.Location = New Point(tim.Location.X - 8, tim.Location.Y + (32 / 3))
        If tim.Location.X <= 90 Or tim.Location.Y >= 108 Then
            tim.Location = New Point(90, 108)
            antim3.Enabled = False
            tim.Enabled = True
        End If
    End Sub

    Private Sub fhidetim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fhidetim.Tick
        If scr.Location = New Point(90, 108) Then
            Me.Close()
            Form1.Hide()
        End If
    End Sub

    Private Sub scr_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles scr.MouseClick
        Form3.Show()
        antim1.Enabled = True
        antim2.Enabled = True
        antim3.Enabled = True
        fhidetim.Enabled = True
    End Sub

    Private Sub doc_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles doc.MouseClick
        Form4.Show()
    End Sub
End Class