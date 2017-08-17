Public Class Form1
    Dim click As String
    Dim mybrush As New SolidBrush(Color.Black)
    Dim thickness As Integer = 10
    Dim draw As System.Drawing.Graphics = Me.CreateGraphics
    Dim rightclick As Integer
    Dim square As Integer
    Dim rightx As Integer
    Dim righty As Integer
    Dim leftx As Integer
    Dim lefty As Integer





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        'draw.FillRectangle(Brushes.Red, 100, 100, 200, 200)
        'draw.FillRectangle(Brushes.Blue, 100, 315, 200, 230)
        'draw.FillRectangle(Brushes.Green, 325, 100, 225, 200)
        'draw.FillRectangle(Brushes.Yellow, 325, 315, 225, 230)





    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove



        Dim xPos As Integer = Me.MousePosition.X - Me.Location.X - 15
        Dim yPos As Integer = Me.MousePosition.Y - Me.Location.Y - 40



        Label1.Text = xPos
        Label2.Text = yPos

        If click >= 1 Then
            draw.FillEllipse(mybrush, xPos, yPos, thickness, thickness)
        End If

        If rightclick = 1 Then
            rightx = xPos
            righty = yPos

        End If

        If click = 1 Then
            leftx = xPos
            lefty = yPos

        End If



        'draw.FillEllipse(Brushes.Black, xPos, yPos, 10, 10)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        click = 1
        If e.Button = MouseButtons.Right Then
            rightclick = 1
        End If

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        click = 0
        rightclick = 0
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        mybrush.Color = Color.Red
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mybrush.Color = Color.Orange
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        mybrush.Color = Color.Yellow
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mybrush.Color = Color.Green
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mybrush.Color = Color.Blue
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mybrush.Color = Color.Purple
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mybrush.Color = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mybrush.Color = Color.White
    End Sub

    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            thickness = thickness + 2
        Else
            thickness = thickness - 2
        End If
    End Sub

    Private Sub Squarebox_Click(sender As Object, e As EventArgs) Handles Squarebox.Click
        draw.DrawRectangle(New Pen(mybrush.Color, thickness), leftx, lefty, rightx, righty)
    End Sub
End Class