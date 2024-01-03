Public Class Splash
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles GroceryStoreImg1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LblReportProgress.Click

    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles GroceryStoreLbl1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblReportProgress.text = Myprogress.Value & "%"
        Myprogress.Value += 1
        If Myprogress.Value > 30 Then
            LblStatustext.Text = "Loading... Please wait"
        End If
        If Myprogress.Value > 70 Then
            LblStatustext.Text = "Almost.. there..."
        End If
        If Myprogress.Value > 85 Then
            LblStatustext.Text = "Here we go Launching Project..."
            login.Show()
            Me.Hide()
            Timer1.Dispose()
        End If

    End Sub

    Private Sub Myprogress_Click(sender As Object, e As EventArgs) Handles Myprogress.Click

    End Sub
End Class
