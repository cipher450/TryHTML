Public Class GetSrc
    Dim Src As String
    Dim trd As System.Threading.Thread
   
    Sub GetSrc()
        Try
            Dim Wb1 As New Net.WebClient

            Src = Wb1.DownloadString(TextBox1.Text)
            FastColoredTextBox1.Text = Src
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error !")
        End Try
       

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With TextBox1
            If .Text = Nothing Or .Text.StartsWith("http") = False Then
                MsgBox("invalid url", MsgBoxStyle.Critical, "invalid url")
            Else
                trd = New System.Threading.Thread(AddressOf GetSrc)
                trd.IsBackground = True
                trd.Start()
                Timer1.Start()
            End If
        End With
       

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If trd.IsAlive = True Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False

            Timer1.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FastColoredTextBox1.SelectAll()
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

       
    End Sub

  

    Private Sub GetSrc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

  
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Suspend" Then
            trd.Suspend()
            Button4.Text = "Resume"
        Else
            trd.Resume()
            Button4.Text = "Suspend"
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        trd.Abort()
        Panel2.Visible = False
    End Sub
End Class