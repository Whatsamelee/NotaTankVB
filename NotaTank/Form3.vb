Public Class Form3

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileToSaveAs As String = SaveFileDialog1.FileName

        Dim objwriter As New System.IO.StreamWriter(FileToSaveAs)
        objwriter.Write(RichTextBox1.Text)
        objwriter.Close()
    End Sub
End Class