Imports System.Text.RegularExpressions
Imports FarsiLibrary

Imports System.Net
Public Class Form1
    Dim newpoint As New Point
    Dim X As Integer
    Dim Y As Integer
    Public Passed As Boolean
    Dim Lastsavepath As String = My.Settings.Last_Save_Path
    Dim TabpageCount As Integer
    Dim FastTextbox As New FastColoredTextBoxNS.FastColoredTextBox



    Private Sub RunCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunCodeToolStripMenuItem.Click
        Dim s As String = FastColoredTextBox1.Text
        If IO.File.Exists(IO.Path.GetTempPath & "TryHTML_usercode.html") = True Then
            IO.File.Delete(IO.Path.GetTempPath & "TryHTML_usercode.html")
        End If

        IO.File.AppendAllText(IO.Path.GetTempPath & "TryHTML_usercode.html", FastColoredTextBox1.Text)
        Testcode.Show()
        Testcode.WebBrowser1.Navigate(IO.Path.GetTempPath & "TryHTML_usercode.html")

    End Sub
    Sub Customthem()
        Dim Drk As Color = Color.FromArgb(45, 45, 48)
        FastColoredTextBox1.BackColor = Drk
        FastColoredTextBox1.ForeColor = Color.White
        Testcode.Panel1.BackColor = Drk
        GetSrc.FastColoredTextBox1.BackColor = Drk
        GetSrc.FastColoredTextBox1.ForeColor = Color.White
        Code_library.txtbox1.BackColor = Drk
        Code_library.txtbox1.ForeColor = Color.White
        Code_library.Srclist.BackColor = Drk
        Code_library.Srclist.ForeColor = Color.White
        Testcode.Panel1.BackColor = Drk
    End Sub
    Sub Withtheme()
        FastColoredTextBox1.BackColor = Color.White
        FastColoredTextBox1.ForeColor = Color.Black
        GetSrc.FastColoredTextBox1.BackColor = Color.White
        GetSrc.FastColoredTextBox1.ForeColor = Color.Black
        Testcode.Panel1.BackColor = Color.White
        Code_library.txtbox1.BackColor = Color.White
        Code_library.txtbox1.ForeColor = Color.Black
        Code_library.Srclist.BackColor = Color.White
        Code_library.Srclist.ForeColor = Color.Black
    End Sub
   

    Private Sub CoperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CoperToolStripMenuItem.Click
        Dim s As String = FastColoredTextBox1.Text
        If IO.File.Exists(IO.Path.GetTempPath & "TryHTML_usercode.html") = True Then
            IO.File.Delete(IO.Path.GetTempPath & "TryHTML_usercode.html")
        End If
        IO.File.AppendAllText(IO.Path.GetTempPath & "TryHTML_usercode.html", FastColoredTextBox1.Text)
        Testcode.Show()
        Testcode.WebBrowser1.Navigate(IO.Path.GetTempPath & "TryHTML_usercode.html")
    End Sub


    Private Sub PastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        FastColoredTextBox1.SelectAll()
    End Sub

   
   

   

    Private Sub CustomeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        DarkToolStripMenuItem1.Checked = False
        WhiteToolStripMenuItem.Checked = False


    End Sub
    
    Private Sub ViweToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Function Readlastsave() As String
        Dim rd As New IO.StreamReader(My.Settings.Last_Save_Path)
        Readlastsave = rd.ReadToEnd
        rd.Close()
        Return Readlastsave
    End Function
    Sub Load()
        My.Settings.Reload()
       
        Me.Opacity = 1.0
        If My.Settings.Last_Save_Path = Nothing Then
        Else

            If IO.File.Exists(My.Settings.Last_Save_Path) = True Then
                FastColoredTextBox1.Text = Readlastsave()
                Dim File As New IO.FileInfo(My.Settings.Last_Save_Path)
                Me.Text = File.Name & " - TryHTML 3.0"
            Else
                FastColoredTextBox1.Text = My.Settings.LastText
            End If
        End If


        With FastColoredTextBox1
            .ForeColor = Settings.PictureBox3.BackColor
            .BackColor = Settings.PictureBox4.BackColor
            .BookmarkColor = Settings.PictureBox5.BackColor
            .LineNumberColor = Settings.PictureBox8.BackColor
            .SelectionColor = Settings.PictureBox7.BackColor
            .ServiceLinesColor = Settings.PictureBox6.BackColor
            .ShowLineNumbers = Settings.CheckBox6.Checked
            .PaddingBackColor = Settings.PictureBox1.BackColor
            Me.TopMost = Settings.CheckBox13.Checked
            If Settings.ComboBox1.Text = "HTML" Then
                .Language = FastColoredTextBoxNS.Language.HTML
            End If

            If Settings.ComboBox1.Text = "PHP" Then
                .Language = FastColoredTextBoxNS.Language.PHP
            End If
            If Settings.ComboBox1.Text = "JS" Then
                .Language = FastColoredTextBoxNS.Language.JS
            End If
            If Settings.ComboBox1.Text = "SQL" Then
                .Language = FastColoredTextBoxNS.Language.SQL
            End If
            If Settings.ComboBox2.Text = "None" Then
                .BorderStyle = BorderStyle.None
            End If
            If Settings.ComboBox2.Text = "FixedSingle" Then
                .BorderStyle = BorderStyle.FixedSingle
            End If
            If Settings.ComboBox2.Text = "Fixed3D" Then
                .BorderStyle = BorderStyle.Fixed3D
            End If
            If My.Settings.Frm_Starthiden = True Then
                Me.WindowState = FormWindowState.Minimized
            End If
            
            If My.Settings.teststr = "Dark" Then

                Customthem()
                DarkToolStripMenuItem1.Checked = True
                WhiteToolStripMenuItem.Checked = False
            End If
            If My.Settings.teststr = "With" Then
                Withtheme()
                DarkToolStripMenuItem1.Checked = False
                WhiteToolStripMenuItem.Checked = True
            End If
            If My.Settings.teststr = "" Then
                CustomToolStripMenuItem.Checked = True
                DarkToolStripMenuItem1.Checked = False
                WhiteToolStripMenuItem.Checked = False
            End If
        End With

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
        If My.Settings.Frm_Lock = True Then
            If Passed = True Then
               
                Me.Show()
                Me.Opacity = My.Settings.frm_Opacity / 100
            Else
                Lock.Show()
                Me.Close()
            End If
           
        End If

    End Sub

    Private Sub SdfToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SdfToolStripMenuItem1.Click

    End Sub

    Private Sub SdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SdfToolStripMenuItem.Click

    End Sub
    Function Settxtcolor(ByVal col As Color)
        FastColoredTextBox1.ForeColor = col
        GetSrc.FastColoredTextBox1.ForeColor = col
        Code_library.txtbox1.ForeColor = col
        Code_library.Srclist.ForeColor = col
    End Function
    Function SetBackcolor(ByVal col As Color)
        FastColoredTextBox1.BackColor = col
        GetSrc.FastColoredTextBox1.BackColor = col
        Code_library.txtbox1.BackColor = col
        Code_library.Srclist.BackColor = col
    End Function

    Private Sub InsertCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertCodeToolStripMenuItem.Click
      
        GetSrc.Show()
        GetSrc.Select()
    End Sub


    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim sv As New SaveFileDialog
        sv.Filter = "HTML File|*.html| File TXT |*.txt| All Files |*.*"
        If sv.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.AppendAllText(sv.FileName, FastColoredTextBox1.Text)
            My.Settings.Last_Save_Path = sv.FileName
        End If
    End Sub

    Private Sub LiveTestWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiveTestWindowToolStripMenuItem.Click
        If LiveTestWindowToolStripMenuItem.Checked = True Then
            Timer1.Start()
            LiveTestWindow.Show()
            LiveTestWindow.WebBrowser1.DocumentText = FastColoredTextBox1.Text
        Else
            Timer1.Start()
            LiveTestWindow.Visible = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
       
        If LiveTestWindowToolStripMenuItem.Checked = True Then

            If Me.WindowState = FormWindowState.Maximized Then

                LiveTestWindow.Timer1.Stop()


                LiveTestWindow.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            Else

                Dim frm1Width As Integer = Me.Width
                LiveTestWindow.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
                LiveTestWindow.Timer1.Start()
                LiveTestWindow.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
                LiveTestWindow.Timer1.Start()
            End If

        End If

    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load

    End Sub
    Sub SvDialog2()
        Dim sv As New SaveFileDialog
        sv.Filter = "HTML File|*.html| Text File |*.txt| All Files |*.*"
        If sv.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.AppendAllText(sv.FileName, FastColoredTextBox1.Text)
            My.Settings.Last_Save_Path = sv.FileName
        End If
    End Sub
    Sub SvDialog()
        Dim sv As New SaveFileDialog
        sv.Filter = "HTML File|*.html| Text File |*.txt| All Files |*.*"
        If sv.ShowDialog = Windows.Forms.DialogResult.OK Then
            IO.File.AppendAllText(sv.FileName, FastColoredTextBox1.Text)
            My.Settings.Last_Save_Path = sv.FileName
            Dim d As New IO.FileInfo(My.Settings.Last_Save_Path)
            Me.Text = d.Name & " - TryHTML 3.0"
        End If
    End Sub
    Private Sub FastColoredTextBox1_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles FastColoredTextBox1.TextChanged
        If LiveTestWindow.Visible = True Then
            LiveTestWindow.WebBrowser1.DocumentText = FastColoredTextBox1.Text
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        If My.Settings.Last_Save_Path = Nothing Then
            SvDialog()
        Else
            If IO.File.Exists(My.Settings.Last_Save_Path) = True Then
                IO.File.WriteAllText(My.Settings.Last_Save_Path, FastColoredTextBox1.Text)
            Else
                SvDialog()
            End If

        End If
    End Sub

    Private Sub CodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodesToolStripMenuItem.Click
        Code_library.Show()
        Code_library.Select()
    End Sub
#Region "Drag Drop "
    Private Sub FastColoredTextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles FastColoredTextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)
            If file.EndsWith("html") Or file.EndsWith("txt") Then
                e.Effect = DragDropEffects.All
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    Private Sub FastColoredTextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles FastColoredTextBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) = True Then
            Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)
            Dim d As New IO.StreamReader(file)
            FastColoredTextBox1.Text = d.ReadToEnd()
            d.Close()
        End If
    End Sub
#End Region

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click

    End Sub

    Private Sub EncodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncodeToolStripMenuItem.Click
        On Error Resume Next
        FastColoredTextBox1.SelectedText = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(FastColoredTextBox1.SelectedText))
    End Sub

    Private Sub DecodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecodeToolStripMenuItem.Click
        On Error Resume Next
        FastColoredTextBox1.SelectedText = New System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(FastColoredTextBox1.SelectedText))
    End Sub

    Private Sub EncodeToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        FastColoredTextBox1.SelectedText = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(FastColoredTextBox1.SelectedText))
    End Sub

    Private Sub DecodeToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        FastColoredTextBox1.SelectedText = New System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(FastColoredTextBox1.SelectedText))
    End Sub



    Private Sub Info_Tick(sender As Object, e As EventArgs) Handles Info.Tick
        On Error Resume Next
        If My.Settings.HideWhenmini = True Then
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Hide()
                NotifyIcon1.Visible = True


           
            End If
        End If

        txtLength.Text = FastColoredTextBox1.Text.Length
        txt_Lines.Text = FastColoredTextBox1.Lines.Count
        Selected_txt_lenght.Text = FastColoredTextBox1.SelectedText.Length


    End Sub

    Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs) Handles txtLength.Click

    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FindRepalceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindRepalceToolStripMenuItem.Click
  FastColoredTextBox1.ShowReplaceDialog()

    End Sub
    
   

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub




    Private Sub Label2_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
       

    End Sub

   

  



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        FastColoredTextBox1.ShowGoToDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        FastColoredTextBox1.ShowFindDialog()
    End Sub

   

    Private Sub DarkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem1.Click
        DarkToolStripMenuItem1.Checked = True
        WhiteToolStripMenuItem.Checked = False
        CustomToolStripMenuItem.Checked = False
        Customthem()
        My.Settings.teststr = "Dark"
        My.Settings.Save()

    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        DarkToolStripMenuItem1.Checked = False
        WhiteToolStripMenuItem.Checked = True
        CustomToolStripMenuItem.Checked = False
        My.Settings.teststr = "With"
        Withtheme()
        My.Settings.Save()
    End Sub

    Private Sub BacroudeColorToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim h As New ColorDialog
        If h.ShowDialog = Windows.Forms.DialogResult.OK Then
            SetBackcolor(h.Color)
        End If
    End Sub

    Private Sub TextColorToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim d As New ColorDialog
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            Settxtcolor(d.Color)

        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub
    Private Sub EncodeToolStripMenuItem1_Click_2(sender As Object, e As EventArgs)
        On Error Resume Next
        FastColoredTextBox1.SelectedText = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(FastColoredTextBox1.SelectedText))
    End Sub

    Private Sub EncodeToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        FastColoredTextBox1.SelectedText = New System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(FastColoredTextBox1.SelectedText))
    End Sub

    Private Sub ImageToBase64ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        img2base64.Show()
    End Sub

    Private Sub RGBColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RGBColorToolStripMenuItem.Click
        ColorPickerExt.Show()

    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click

    End Sub

    Private Sub FromDiskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromDiskToolStripMenuItem.Click

        Dim f As New OpenFileDialog
        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim filpath As String = """" & f.FileName & """"
            FastColoredTextBox1.Text += " " & "<img src=" & filpath & "width=""104"" height=""142""" & ">"
        End If

    End Sub

    

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

        Dim URL As String = """" & img_URL.Text & """"
        FastColoredTextBox1.Text += " " & "<img src=" & URL & "width=""104"" height=""142""" & ">"
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
      
        Dim urltext As String = ToolStripTextBox1.Text
        Dim URL As String = """" & ToolStripTextBox2.Text & """"
        FastColoredTextBox1.Text += " " & "<a href=" & URL & ">" & urltext & "</a>"
    End Sub

    Private Sub DOCTYPEHtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOCTYPEHtmlToolStripMenuItem.Click
        FastColoredTextBox1.Text += DOCTYPEHtmlToolStripMenuItem.Text

    End Sub

    Private Sub BodyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BodyToolStripMenuItem.Click
        FastColoredTextBox1.Text += BodyToolStripMenuItem.Text
    End Sub

    Private Sub HtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HtmlToolStripMenuItem.Click
        FastColoredTextBox1.Text += HtmlToolStripMenuItem.Text
    End Sub

    Private Sub H1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H1ToolStripMenuItem.Click
        FastColoredTextBox1.Text += H1ToolStripMenuItem.Text
    End Sub

    Private Sub ImageToBase64ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToBase64ToolStripMenuItem.Click
        img2base64.Show()
        img2base64.Select()
    End Sub

    Private Sub HtmlToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HtmlToolStripMenuItem1.Click
        FastColoredTextBox1.Text += HtmlToolStripMenuItem1.Text
    End Sub

    Private Sub BodyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BodyToolStripMenuItem1.Click
        FastColoredTextBox1.Text += BodyToolStripMenuItem1.Text
    End Sub

  
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Settings.Frm_hidWhenClosed Then
            e.Cancel = True
            NotifyIcon1.Visible = True
            Me.Hide()
        Else
            e.Cancel = False
            If Settings.Visible = True Or GetSrc.Visible = True Or LiveTestWindow.Visible = True Or Testcode.Visible = True Or image_show.Visible = True Or Testcode.Visible = True Then
                Settings.Close()
                GetSrc.Close()
                LiveTestWindow.Close()
                Testcode.Close()
                image_show.Close()
                Code_library.Close()
                ColorPickerExt.Close()
            End If
        End If
        
    End Sub

    

    Private Sub NotifyIcon1_MouseDoubleClick_1(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            If My.Settings.Last_Save_Path = Nothing Or My.Settings.Last_Save_Path = IO.Path.GetTempPath & "TryHTML_usercode.html" Then

                If MessageBox.Show("The current document is not saved , Do you want to save it ?", "Document not saveed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                    SvDialog2()
                    Dim j As New OpenFileDialog
                    j.Filter = "HTML File|*.html| Text File |*.txt| All Files |*.*"
                    If j.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim f As String = FastColoredTextBox1.Text
                        FastColoredTextBox1.Text = IO.File.ReadAllText(j.FileName)
                        Dim d As New IO.FileInfo(j.FileName)
                        Me.Text = d.Name & " - TryHTML 3.0"
                        My.Settings.Last_Save_Path = j.FileName
                    End If

                Else
                    Dim j As New OpenFileDialog
                    j.Filter = "HTML File|*.html| Text File |*.txt| All Files |*.*"
                    If j.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim f As String = FastColoredTextBox1.Text
                        FastColoredTextBox1.Text = IO.File.ReadAllText(j.FileName)
                        Dim d As New IO.FileInfo(j.FileName)
                        Me.Text = d.Name & " - TryHTML 3.0"
                        My.Settings.Last_Save_Path = j.FileName
                    End If

                End If
            Else
                Dim j As New OpenFileDialog
                j.Filter = "HTML File|*.html| Text File |*.txt| All Files |*.*"
                If j.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim f As String = FastColoredTextBox1.Text
                    IO.File.AppendAllText(j.FileName, f)
                    Dim d As New IO.FileInfo(j.FileName)
                    Me.Text = d.Name & " - TryHTML 3.0"
                    My.Settings.Last_Save_Path = j.FileName
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
       
    End Sub

   
    Private Sub DisabelToolStripMenuItem_Click(sender As Object, e As EventArgs)
        DarkToolStripMenuItem1.Checked = False
        WhiteToolStripMenuItem.Checked = False
        Customthem()
        My.Settings.teststr = ""
    End Sub

    Private Sub ClearCurrentLineToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearCurrentLineToolStripMenuItem1.Click
        Try
            FastColoredTextBox1.ClearCurrentLine()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearCurrentLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearCurrentLineToolStripMenuItem.Click
        Try
            FastColoredTextBox1.ClearCurrentLine()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        FastColoredTextBox1.Clear()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        FastColoredTextBox1.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem1.Click
        FastColoredTextBox1.SelectAll()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub PastToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PastToolStripMenuItem1.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        About.Show()
    End Sub

    Private Sub ThemeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThemeToolStripMenuItem1.Click

    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        DarkToolStripMenuItem1.Checked = False
        WhiteToolStripMenuItem.Checked = False
        My.Settings.teststr = ""
        CustomToolStripMenuItem.Checked = True
        My.Settings.Save()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If My.Settings.Last_Save_Path = Nothing Or My.Settings.Last_Save_Path = IO.Path.GetTempPath & "TryHTML_usercode.html" Then
            If MessageBox.Show("The current document is not saved , Do you want to save it ?", "Document not saveed", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                SvDialog2()
                End
            Else
                End
            End If
        Else
            End
        End If

    End Sub

    Private Sub NewFormToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Code_library.Show()
        Code_library.Select()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        GetSrc.Show()
        GetSrc.Select()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        ColorPickerExt.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        On Error Resume Next
        FastColoredTextBox1.SelectedText = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(FastColoredTextBox1.SelectedText))
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        On Error Resume Next
        FastColoredTextBox1.SelectedText = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(FastColoredTextBox1.SelectedText))
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        img2base64.Show()
        img2base64.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        TabpageCount = TabpageCount + 1

        Dim Tabpage As New FarsiLibrary.Win.FATabStripItem

       
        Tabpage.Title = "New " & TabpageCount


    End Sub

    Private Sub ButtoonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtoonToolStripMenuItem.Click
        Dim code As String = InputBox("Button text ", "Button text ", "")
        FastColoredTextBox1.Text += "  <button type=""button""> " & code & "</button> " & vbNewLine
    End Sub

    Private Sub TextBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextBoxToolStripMenuItem.Click
        Dim code As String = " <textarea> </textarea>" & vbNewLine
        FastColoredTextBox1.Text += code


    End Sub

    Private Sub ChekBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChekBoxToolStripMenuItem.Click
        FastColoredTextBox1.Text += " <INPUT type= ""checkbox"" name=""name"" value=""Value"">ChekBox" & vbNewLine





    End Sub

    Private Sub HEXASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ASCII2HEX.Show()
    End Sub

    Private Sub MD5ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            MD5.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Try
            Dim Str As String = FastColoredTextBox1.SelectedText
            FastColoredTextBox1.SelectedText = FastColoredTextBox1.SelectedText.Replace(Str, MD51(Str))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click

    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        On Error Resume Next
        MD5.Show()
        MD5.Select()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        On Error Resume Next
        ASCII2HEX.Show()
        ASCII2HEX.Select()
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        Try
            Dim str As String = FastColoredTextBox1.SelectedText
            FastColoredTextBox1.SelectedText = FastColoredTextBox1.SelectedText.Replace(str, HexToString(str))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        Try
            Dim str As String = FastColoredTextBox1.SelectedText
            FastColoredTextBox1.SelectedText = FastColoredTextBox1.SelectedText.Replace(str, StringToHex(str))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        Try
            Dim Str As String = FastColoredTextBox1.SelectedText
            FastColoredTextBox1.SelectedText = FastColoredTextBox1.SelectedText.Replace(Str, MD51(Str))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        On Error Resume Next
        MD5.Show()
        MD5.Select()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        Try
            Dim str As String = FastColoredTextBox1.SelectedText
            FastColoredTextBox1.SelectedText = FastColoredTextBox1.SelectedText.Replace(str, StringToHex(str))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        Try
            Dim str As String = FastColoredTextBox1.SelectedText
            FastColoredTextBox1.SelectedText = FastColoredTextBox1.SelectedText.Replace(str, HexToString(str))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        On Error Resume Next
        ASCII2HEX.Show()
        ASCII2HEX.Select()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Try
            Dim hasSpaces As String = FastColoredTextBox1.SelectedText
            ' Encode it as url.
            Dim result1 As String = WebUtility.UrlEncode(hasSpaces)
            Dim result2 As String = WebUtility.UrlDecode(result1)
            FastColoredTextBox1.SelectedText = result2
        Catch ex As Exception
            FastColoredTextBox1.SelectedText = ex.Message
        End Try

    End Sub
End Class
