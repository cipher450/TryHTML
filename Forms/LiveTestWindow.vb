Public Class LiveTestWindow

    Private Sub LiveTestWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next

        Me.Width = Form1.Width
        Me.Height = Form1.Height
        WebBrowser1.DocumentText = Form1.FastColoredTextBox1.Text

    End Sub

    Private Sub LiveTestWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.LiveTestWindowToolStripMenuItem.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Me.Width = Form1.Width
        Me.Height = Form1.Height
        Me.Text = "LiveTestWindow - " & WebBrowser1.DocumentTitle
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

        If ToolStripStatusLabel1.Text = "[Separate]" Then
            Timer1.Stop()
            ToolStripStatusLabel1.Text = "[Atache]"
            Form1.Timer1.Stop()
        End If
        If ToolStripStatusLabel1.Text = "[Attach]" Then
            Form1.Timer1.Start()
            Timer1.Start()
            ToolStripStatusLabel1.Text = "[Separate]"
        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Me.Text = WebBrowser1.
    End Sub
End Class