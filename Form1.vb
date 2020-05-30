Public Class Form1
    Dim a As Double = 0
    Dim b As Double = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a + 1
        If a > 9 Then
            a = 0
            b = b + 1
        End If
        If b > 50 Then
            b = 0
        End If

        If b >= 3 Then
            CircularProgressBar1.ProgressColor = Color.BlueViolet
        End If
        If b >= 5 Then
            CircularProgressBar1.ProgressColor = Color.Blue
        End If
        If b > 8 Then
            CircularProgressBar1.ProgressColor = Color.Orange
        End If
        If b > 10 Then
            CircularProgressBar1.ProgressColor = Color.DarkRed
        End If
        If b = 12 Then
            CircularProgressBar1.ProgressColor = Color.Red

        End If

        CircularProgressBar1.SubscriptText = "." & a

        Try
            CircularProgressBar1.Value = b
            CircularProgressBar1.Text = CircularProgressBar1.Value

        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CircularProgressBar1.Value = 0
    End Sub
End Class
