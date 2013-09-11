Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        scrtim.Enabled = True

    End Sub

    Private Sub scrtim_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scrtim.Tick
        If Me.Location.Y > 0 Then
            Me.Location = New Point(0, Me.Location.Y - 80)
        Else
            Me.Location = New Point(0, 0)
            anitim2.Enabled = True
            scrtim.Enabled = False
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qulab.Click

        closetim.Enabled = True
    End Sub

    Private Sub anitim1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anitim1.Tick
        If Tilab1.Location.X < 31 Then
            Tilab1.Location = New Point(Tilab1.Location.X + 50, 18)
        Else
            Tilab1.Location = New Point(31, 18)
        End If
        If tilab2.Location.X < 40 Then
            tilab2.Location = New Point(tilab2.Location.X + 30, 89)
        Else
            tilab2.Location = New Point(40, 89)
        End If
        If qulab.Size.Width < 63 Then
            qulab.Size = New Point(qulab.Size.Width + 9, 32)
            qulab.Enabled = False
        Else
            qulab.Size = New Point(63, 32)
        End If
        If Tilab1.Location = New Point(31, 18) And tilab2.Location = New Point(40, 89) And qulab.Size.Width = 63 Then
            anitim1.Enabled = False
            qulab.Enabled = True
        End If
    End Sub

    Private Sub anitim2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anitim2.Tick
        If bklab.Location.Y < 0 Then
            bklab.Location = New Point(0, bklab.Location.Y + 25)
        Else
            bklab.Location = New Point(0, 0)
            anitim1.Enabled = True
            anitim2.Enabled = False
        End If
    End Sub

    Private Sub closetim_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles closetim.Tick
        If Me.Location.Y < 630 Then
            Me.Location = New Point(0, Me.Location.Y + 60)
        Else
            Me.Location = New Point(0, 630)
            closetim2.Enabled = True
            closetim.Enabled = False
        End If
    End Sub

    Private Sub closetim2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closetim2.Tick
        If Tilab1.Location.X > 10 Then
            Tilab1.Location = New Point(Tilab1.Location.X - 2, 18)
        Else
            Tilab1.Location = New Point(10, 18)
        End If
        If tilab2.Location.X > 9 Then
            tilab2.Location = New Point(tilab2.Location.X - 3, 89)
        Else
            tilab2.Location = New Point(9, 89)
        End If
        If Tilab1.Location = New Point(10, 18) And tilab2.Location = New Point(9, 89) Then
            closetim3.Enabled = True
            closetim2.Enabled = False
        End If
    End Sub

    Private Sub closetim3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closetim3.Tick
        If Tilab1.Location.X < 1024 Then
            Tilab1.Location = New Point(Tilab1.Location.X + 50, 18)
        Else
            Tilab1.Location = New Point(-498, 18)
        End If
        If tilab2.Location.X < 1024 Then
            tilab2.Location = New Point(tilab2.Location.X + 30, 89)
        Else
            tilab2.Location = New Point(-250, 89)
        End If
        If Tilab1.Location = New Point(-498, 18) Or tilab2.Location = New Point(-250, 89) Then
            closetim4.Enabled = True
            Tilab1.Location = New Point(-498, 18)
            tilab2.Location = New Point(-250, 89)
            closetim3.Enabled = False
        End If
    End Sub

    Private Sub closetim4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closetim4.Tick
        If Me.Location.Y < 768 Then
            Me.Location = New Point(0, Me.Location.Y + 20)
        Else
            Me.Location = New Point(0, 768)
            Form2.Show()
            closetim4.Enabled = False
            Me.Close()
        End If
    End Sub
End Class