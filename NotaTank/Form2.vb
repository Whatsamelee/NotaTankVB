Imports System.Net
Imports System.IO

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Text = "Home [Trial]" Then
            My.Computer.Audio.Play(My.Resources.Wat, AudioPlayMode.Background)
            Button2.Enabled = False
        Else



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()


    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Hostname As IPHostEntry = Dns.GetHostEntry(TextBox1.Text)
        Dim ip As IPAddress() = Hostname.AddressList
        MsgBox(ip(0).ToString)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If NetworkInformation.NetworkInterface.GetIsNetworkAvailable Then
            MsgBox("You got internet, congrats. Can't use it anyway.")
        Else
            MsgBox("Learn to internet, faggot")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Notatank OS® and the NotaTank OS Theme Song® are registered trademarks of NotaTank LLC©. Copyright @2012-2013 NotaTank OS. You are bound to our terms of use(Findable in Readme.md), and by clicking activate, you agree to this.")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClickedvate
        Form6.Show()
    End Sub

    Private Function req() As Object
        Throw New NotImplementedException
    End Function

End Class