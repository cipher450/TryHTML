Public Class Settings
#Region "Color Selection"
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox8.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox7.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox6.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox3.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox4.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox5.BackColor = ColorDialog1.Color
        End If
    End Sub
#End Region
   
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        With Form1.FastColoredTextBox1
            .ForeColor = PictureBox3.BackColor
            .BackColor = PictureBox4.BackColor
            .BookmarkColor = PictureBox5.BackColor
            .LineNumberColor = PictureBox8.BackColor
            .SelectionColor = PictureBox7.BackColor
            .ServiceLinesColor = PictureBox6.BackColor
            .ShowLineNumbers = CheckBox6.Checked
            .CurrentLineColor = PictureBox2.BackColor
            .FoldingIndicatorColor = PictureBox9.BackColor
            .PaddingBackColor = PictureBox1.BackColor
            If ComboBox1.Text = "HTML" Then
                .Language = FastColoredTextBoxNS.Language.HTML
            End If
            If ComboBox1.Text = "PHP" Then
                .Language = FastColoredTextBoxNS.Language.PHP
            End If
            If ComboBox1.Text = "JS" Then
                .Language = FastColoredTextBoxNS.Language.JS
            End If
            If ComboBox1.Text = "SQL" Then
                .Language = FastColoredTextBoxNS.Language.SQL
            End If
            If ComboBox2.Text = "None" Then
                .BorderStyle = BorderStyle.None
            End If
            If ComboBox2.Text = "FixedSingle" Then
                .BorderStyle = BorderStyle.FixedSingle
            End If
            If ComboBox2.Text = "Fixed3D" Then
                .BorderStyle = BorderStyle.Fixed3D
            End If
            Form1.TopMost = CheckBox13.Checked
            Form1.Opacity = Me.TrackBar1.Value / 100
        End With
        My.Settings.Save()
        Form1.Refresh()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ColorPickerExt.Show()
        Dim frm1Width As Integer = Me.Width
        ColorPickerExt.Location = New Point(Me.Location.X + frm1Width, Me.Location.Y)
    End Sub

  

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Value = 100
        If My.Settings.CurrentLineC = True Then
            LinkLabel2.Visible = True
        Else
            LinkLabel2.Visible = False
        End If
        If chekadmin() = True Then
            CheckBox11.Enabled = True
            PictureBox10.Visible = False
        Else
            CheckBox11.Enabled = False
            PictureBox10.Visible = True
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.BackColor = ColorDialog1.Color
            LinkLabel2.Visible = True
            My.Settings.CurrentLineC = True
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.FastColoredTextBox1.CurrentLineColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        LinkLabel2.Visible = False
        My.Settings.CurrentLineC = False
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox9.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.UseSystemPasswordChar = True Then
            TextBox1.UseSystemPasswordChar = False
            Button1.Text = "Hide"
        Else
            TextBox1.UseSystemPasswordChar = True
            Button1.Text = "Show"
        End If
    End Sub

   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
       
    End Sub
    Sub Addstartup()
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue("TryHTML 1.0", Application.ExecutablePath)
    End Sub
    Sub removeStarup()
        My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("TryHTML 1.0")
    End Sub
    Function chekadmin() As Boolean
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
       
    End Sub

    Private Sub FaTabStrip1_TabStripItemSelectionChanged(e As FarsiLibrary.Win.TabStripItemChangedEventArgs) Handles FaTabStrip1.TabStripItemSelectionChanged

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Form1.Opacity = Me.TrackBar1.Value / 100

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Reset()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class