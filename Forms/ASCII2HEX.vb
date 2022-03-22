Public Class ASCII2HEX

   

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try

            ASCII_LEN.Text = TextBox1.Text.Length
            TextBox3.Text = StringToHex(TextBox1.Text)
            TextBox4.Text = StrtoBin(TextBox1.Text)
           
        Catch ex As Exception

        End Try
      
    End Sub
    Function StrtoBin(ByVal Str As String) As String

        Dim Result As New System.Text.StringBuilder
        For Each Character As Byte In System.Text.ASCIIEncoding.ASCII.GetBytes(TextBox1.Text)
            Result.Append(Convert.ToString(Character, 2).PadLeft(8, "0"))
            Result.Append(" ")
        Next
        Str = Result.ToString.Substring(0, Result.ToString.Length - 1)
        Return Str
    End Function
    Private Sub ASCII2HEX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
    Function Bin2Text(ByVal bin As String) As String
        Dim Val As String = Nothing
        Dim Characters As String = System.Text.RegularExpressions.Regex.Replace(TextBox1.Text, "[^01]", "")
        Dim ByteArray((Characters.Length / 8) - 1) As Byte
        For Index As Integer = 0 To ByteArray.Length - 1
            ByteArray(Index) = Convert.ToByte(Characters.Substring(Index * 8, 8), 2)
        Next
        Val = System.Text.ASCIIEncoding.ASCII.GetString(ByteArray)
        Return Val
    End Function
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Try

            BIN_LEN.Text = TextBox4.Text.Length
            'TextBox1.Text = Bin2Text(TextBox4.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Try
            Clipboard.SetText(TextBox3.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Clipboard.SetText(TextBox4.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Try
            Clipboard.SetText(TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Try
            Form1.FastColoredTextBox1.InsertText(" " & TextBox1.Text, True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Form1.FastColoredTextBox1.InsertText(" " & TextBox3.Text, True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Form1.FastColoredTextBox1.InsertText(" " & TextBox4.Text, True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Try
            HEX_LEN.Text = TextBox3.Text.Length
            ' TextBox1.Text = HexToString(TextBox3.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class