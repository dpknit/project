Public Class Form1
    Dim tick As Integer = 270
    Dim tick2 As Integer = 270
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl1.Location = New Point(505, 203)
        lbl2.Location = New Point(561, 261)
        lbl3.Location = New Point(592, 335)
        lbl4.Location = New Point(561, 404)
        lbl5.Location = New Point(505, 464)
        lbl6.Location = New Point(430, 489)
        lbl7.Location = New Point(357, 463)
        lbl8.Location = New Point(305, 408)
        lbl9.Location = New Point(272, 334)
        lbl10.Location = New Point(302, 259)
        lbl11.Location = New Point(354, 200)
        lbl12.Location = New Point(430, 177)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim seconds As Integer = (Now.Second * 6) + 270
        Dim minutes As Integer = (Now.Minute * 6) + 270
        Dim hours As Integer = (Now.Hour * 30) + 270
        lblTime.Text = Now
        Dim g As Graphics
        g = Me.CreateGraphics
        Dim hour As New Pen(Color.Blue)
        Dim hour2 As New Pen(Color.White)
        Dim second As New Pen(Color.Black)
        Dim minute As New Pen(Color.Red)
        Dim minute2 As New Pen(Color.White)
        Dim white As New Pen(Color.White)
        Dim circle As New Pen(Color.Black)
        hour.Width = 8
        hour2.Width = 10
        second.Width = 1
        minute.Width = 4
        minute2.Width = 4
        white.Width = 10
        circle.Width = 5
        g.DrawPie(hour2, 319, 219, 240, 240, hours - 30, 360)
        g.DrawPie(minute2, 289, 189, 300, 300, minutes - 6, 360)
        g.DrawPie(Pens.White, 269, 169, 340, 340, seconds - 6, 360)
        g.DrawPie(hour, 319, 219, 240, 240, hours, 360)
        g.DrawEllipse(white, 319, 219, 240, 240)
        g.DrawPie(minute, 289, 189, 300, 300, minutes, 360)
        g.DrawEllipse(white, 289, 189, 300, 300)
        g.DrawPie(second, 269, 169, 340, 340, seconds, 360)
        g.DrawEllipse(white, 269, 169, 340, 340)
        g.DrawEllipse(circle, 249, 149, 380, 380)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tick += 6
        tick2 += 30
        Dim g As Graphics
        Dim hoursMarks As New Pen(Color.Black)
        hoursMarks.Width = 5
        g = Me.CreateGraphics
        g.DrawPie(Pens.Black, 249, 149, 380, 380, tick, 360)
        g.DrawPie(hoursMarks, 249, 149, 380, 380, tick2, 360)
        g.DrawEllipse(Pens.White, 269, 169, 340, 340)
        g.FillEllipse(Brushes.White, 269, 169, 340, 340)
        If tick > 800 Then
            Timer2.Stop()
            tick = 270
            tick2 = 270
        End If
    End Sub
End Class
