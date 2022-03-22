Public Class image_show

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim g As New SaveFileDialog
        g.Filter = "Jpg|*.jpg|Png|*.png|bmp|*.bmp| All Files |*.*"
        If g.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image.Save(g.FileName)
            MsgBox("successfully saved", MsgBoxStyle.Information, "Done !")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PictureBox1.SizeMode = PictureBoxSizeMode.Normal Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub
End Class