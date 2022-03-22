Public Class Testcode

    Private Sub Testcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = IO.Path.GetTempPath & "TryHTML_usercode.html"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Me.Text = "Testing code of " & "'" & WebBrowser1.DocumentTitle & "'"
        TextBox1.Text = WebBrowser1.Document.Url.AbsoluteUri
        Page_Info.Getinfo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(TextBox1.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        TextBox1.Text = WebBrowser1.Url.AbsolutePath
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.BackColor = Color.Black
        Panel1.ForeColor = Color.White
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            WebBrowser1.Navigate(IO.Path.GetTempPath & "TryHTML_usercode.html")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Page_Info.Show()
    End Sub

    Private Sub Testcode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Page_Info.Close()
    End Sub
End Class