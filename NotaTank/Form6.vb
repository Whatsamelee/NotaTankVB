Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "ae310-391sk-dlzkm-al039" Then
            Form2.Text = "Home"
            MsgBox("Thank you for purchasing Notatank OS!")
            Form2.LinkLabel2.Hide()
            Form2.Button2.Enabled = True
            My.Computer.Audio.Play(My.Resources.Wat, AudioPlayMode.BackgroundLoop)
            Me.Close()
        Else
            MsgBox("Serial Key Invalid.")
        End If
    End Sub
End Class