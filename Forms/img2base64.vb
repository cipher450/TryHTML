Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing.Imaging
Imports System.Net

Public Class img2base64
    Dim trd As System.Threading.Thread
    Dim file_Format As String
    Dim CanClose As Boolean = True
    Dim Filepath As String = IO.Path.GetTempPath & "tmp_img." & file_Format
    Private Sub img2base64_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 493
        Me.Height = 389
        Control.CheckForIllegalCrossThreadCalls = False
        PictureBox1.AllowDrop = True

    End Sub
    Public Function ImageToBase64(image As Image, format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As New MemoryStream()
            ' Convert Image to byte[]
            image.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()

            ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function
    Public Function Base64ToImage(base64String As String) As Image
        ' Convert Base64 String to byte[]
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim image__1 As Image = Image.FromStream(ms, True)
        Return image__1
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)
            With file
                If .EndsWith("jpg") Or .EndsWith("png") Or .EndsWith("bmp") Or .EndsWith("jpeg") Or .EndsWith("svg") Or .EndsWith("PNG") Then
                    e.Effect = DragDropEffects.All
                Else
                    e.Effect = DragDropEffects.None
                End If
            End With

        End If
    End Sub

    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)
            PictureBox1.Image = Image.FromFile(file)
            Dim flinfo As New IO.FileInfo(file)
            Label4.Text = flinfo.Extension
            Label2.Text = file
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


        TextBox1.Text = ImageToBase64(PictureBox1.Image, System.Drawing.Imaging.ImageFormat.Png)


    End Sub

#Region "Download Image"
    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Label8.Visible = False
        Button1.Enabled = True
        Button2.Enabled = True
        PictureBox1.ImageLocation = Label2.Text
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0
        CanClose = True
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

#End Region
  
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim pattern As String
        pattern = "http(s)?://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?"
        If Regex.IsMatch(TextBox2.Text, pattern) Then

            Dim Str As String = TextBox2.Text
            file_Format = Str.Substring(Str.Length - 3)
            If file_Format = "jpg" Or file_Format = "png" Or file_Format = "bmp" Or file_Format = "jpeg" Then
                Label2.Text = Filepath
                Label4.Text = file_Format
                If IO.File.Exists(Filepath) Then
                    IO.File.Delete(Filepath)
                End If
                ProgressBar1.Visible = True
                Label8.Visible = True
                Button1.Enabled = False
                Button2.Enabled = False
                CanClose = False
                Dim Wb1 As New Net.WebClient
                AddHandler Wb1.DownloadProgressChanged, AddressOf client_ProgressChanged
                AddHandler Wb1.DownloadFileCompleted, AddressOf client_DownloadCompleted
                Wb1.DownloadFileAsync(New Uri(TextBox2.Text), Filepath)

               
               
            Else
                MsgBox("this Format is not Supprted ", MsgBoxStyle.Exclamation, "error")
            End If
        Else

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles IsAlive.Tick
        If trd.IsAlive = True Then
            Panel1.Visible = True
            Button1.Enabled = False
            Button2.Enabled = False
            TextBox2.Enabled = False

        Else
            Panel1.Visible = False
            Button1.Enabled = True
            Button2.Enabled = True
            TextBox2.Enabled = True

            IsAlive.Stop()
        End If
    End Sub
    Sub Basetoimg()

        Try
            PictureBox1.Image = Base64ToImage(TextBox1.Text)
            Label6.Visible = False
            Button1.Enabled = True
        Catch ex As Exception
            trd.Abort()
            Label6.Visible = False
            Button1.Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If Not TextBox1.Text = Nothing Then
            Label6.Visible = True
            Button1.Enabled = False
            trd = New Threading.Thread(AddressOf Basetoimg)
            trd.IsBackground = True
            trd.Start()
            IsAlive.Start()
        End If
        





    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TextBox1.Text = Clipboard.GetText
    End Sub
    Sub imgtobas()
        Try

            If Not Label2.Text = "<filePath>" Then
                With Label4
                    If .Text.Contains("png") Or .Text.Contains("PNG") Then
                        TextBox1.Text = ImageToBase64(PictureBox1.Image, ImageFormat.Png)
                        Button2.Enabled = True
                        Label6.Visible = False
                    End If
                    If .Text.Contains("bmp") Then
                        TextBox1.Text = ImageToBase64(PictureBox1.Image, ImageFormat.Bmp)
                        Button2.Enabled = True
                        Label6.Visible = False
                    End If
                    If .Text.Contains("jpg") Or .Text.Contains(".jpeg") Then
                        TextBox1.Text = ImageToBase64(PictureBox1.Image, ImageFormat.Jpeg)
                        Button2.Enabled = True
                        Label6.Visible = False
                    End If

                End With
            End If

        Catch ex As Exception
            Button2.Enabled = True
            Label6.Visible = False
            trd.Abort()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
   
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Label6.Visible = True
        Button2.Enabled = False
        trd = New Threading.Thread(AddressOf imgtobas)
        trd.IsBackground = True
        trd.Start()
        IsAlive.Start()

    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        image_show.Show()
        image_show.PictureBox1.Image = PictureBox1.Image
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
      
    End Sub
    Sub Rest()
        PictureBox1.Image = My.Resources.drg_drop
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label2.Text = "<filePath>"
        Label4.Text = "supported formats (jpg,png,bmp,svg)"
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Rest()
    End Sub

    Private Sub img2base64_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If CanClose = False Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MsgBox("Warning ! if the selected image is big (For exemple an HD Wallper ) keep in minde that it may take awhile to be encoded.", MsgBoxStyle.Exclamation)
    End Sub

  

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Sub Encode_all_image()
        Using ms As New MemoryStream()
            ' Convert Image to byte[]
            ' Image.Save(ms, Format)
            Dim imageBytes As Byte() = ms.ToArray()

            ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            '    Return base64String
        End Using
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub AddImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddImageToolStripMenuItem.Click
        Dim f As New OpenFileDialog
        If f.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim s As New SaveFileDialog
        s.Filter = "Images|*.jpeg"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub
End Class