Public Class Page_Info

    Private Sub Page_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm1Width As Integer = Testcode.Width
        Me.Location = New Point(Testcode.Location.X + frm1Width, Testcode.Location.Y)
        Me.Height = Testcode.Height
        Getinfo()
    End Sub
    Public Sub Getinfo()
        Try
            Dim Wb1 As WebBrowser = Testcode.WebBrowser1

            With Wb1
                URL.Text = Wb1.Url.AbsoluteUri
                Label3.Text = .Document.Title
                Label2.Text = .EncryptionLevel.ToString
                Label6.Text = .Document.DefaultEncoding
                Label8.Text = .Document.Encoding
                Label10.Text = .Document.Domain
                Label12.Text = .Document.ForeColor.R & "," & .Document.ForeColor.G & "," & .Document.ForeColor.B
                PictureBox1.BackColor = .Document.ForeColor
                Label18.Text = .Document.BackColor.R & "," & .Document.BackColor.G & "," & .Document.BackColor.B
                PictureBox2.BackColor = .Document.BackColor
                Label16.Text = .Document.Images.Count
                Label14.Text = .Document.Forms.Count
                

            End With
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Testcode.WindowState = FormWindowState.Maximized Then
            Dim frm1Width As Integer = Testcode.Width
            Me.Location = New Point(Testcode.Location.X + frm1Width, Testcode.Location.Y)
            Me.Height = Testcode.Height
        End If
        Try
            Label22.Text = Testcode.WebBrowser1 .ReadyState
            Label25.Text = Testcode.WebBrowser1.StatusText
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        Testcode.WebBrowser1.ScriptErrorsSuppressed = CheckBox1.Checked
      
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

        Testcode.WebBrowser1.WebBrowserShortcutsEnabled = CheckBox2.Checked
        
    End Sub
End Class