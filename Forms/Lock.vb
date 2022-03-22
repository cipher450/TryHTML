Public Class Lock
    Dim Password As String = My.Settings.Frm_LokePass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = Password Then
            Form1.Passed = True
            Form1.Show()
            Me.Close()
        Else
            MsgBox("You entred a worng password !", MsgBoxStyle.Critical, "Worng Password")
        End If
    End Sub

    Private Sub TextBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDoubleClick
        If TextBox1.UseSystemPasswordChar = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub
End Class