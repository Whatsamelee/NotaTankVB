Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Nota" And TextBox2.Text = "Tank" Then
            Form2.Show()
            Me.Close()
        Else
            MsgBox("Nigga")
        End If
           End Sub
End Class
