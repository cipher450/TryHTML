Public Class Code_library

    
    Private Sub txtbox1_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles txtbox1.TextChanged
        WebBrowser1.DocumentText = txtbox1.Text
    End Sub

    Private Sub Code_library_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FaTabStrip1.AlwaysShowClose = False
    End Sub
#Region "Show Source Code JavaScrpit"
    Sub Load_JS_Src()
        With Srclist.SelectedNode
            If .Text = "Add to Favorites" Then
                txtbox1.Text = My.Resources.Add_to_Favorites
            End If
            If .Text = "Back Button" Then
                txtbox1.Text = My.Resources.Back_Button
            End If
            If .Text = "Calendar" Then
                txtbox1.Text = My.Resources.Calendar
            End If
            If .Text = "Change Background Colors" Then
                txtbox1.Text = My.Resources.Change_Background_Colors
            End If
            If .Text = "Close Window" Then
                txtbox1.Text = My.Resources.Close_Window
            End If
            If .Text = "Copy Selected Text" Then
                txtbox1.Text = My.Resources.Copy_Selected_Text
            End If
            If .Text = "Date Display" Then
                txtbox1.Text = My.Resources.Date_Display
            End If
            If .Text = "Focus OnLoad" Then
                txtbox1.Text = My.Resources.Focus_OnLoad
            End If
            If .Text = "Detecting Google Chrome" Then
                txtbox1.Text = My.Resources.Detecting_Google_Chrome
            End If
            If .Text = "IP Address" Then
                txtbox1.Text = My.Resources.IP_Address
            End If
            If .Text = "Password Generator" Then
                txtbox1.Text = My.Resources.Pass_genert
            End If
            '
            If .Text = "Client Window Size" Then
                txtbox1.Text = My.Resources.Client_Window_Size
            End If
            If .Text = "Popup Blocker Detection" Then
                txtbox1.Text = My.Resources.Popup_Blocker_Detection_2
            End If
            If .Text = "Window Close Automatically" Then
                txtbox1.Text = My.Resources.Window_Close_Automatically
            End If
            If .Text = "Specify Referring Page" Then
                txtbox1.Text = My.Resources.Specify_Referring_Page
            End If
        End With
    End Sub
#End Region
#Region "Show Source Code HTML"
    Sub Load_HTML_Src()
        With Srclist.SelectedNode
            If .Text = "Basic" Then
                txtbox1.Text = My.Resources.Basic
            End If
            If .Text = "External" Then
                txtbox1.Text = My.Resources.External
            End If
            If .Text = "Fonts" Then
                txtbox1.Text = My.Resources.Fonts
            End If
            If .Text = "Internal" Then
                txtbox1.Text = My.Resources.Internal
            End If
            If .Text = "Margin" Then
                txtbox1.Text = My.Resources.Margin
            End If
            If .Text = "Images Syntax" Then
                txtbox1.Text = My.Resources.Images_Syntax
            End If
            If .Text = "Alt Attribute" Then
                txtbox1.Text = My.Resources.alt_Attribute
            End If
            If .Text = "Images Syntax" Then
                txtbox1.Text = My.Resources.Images_Syntax
            End If
            If .Text = "Padding" Then

                txtbox1.Text = My.Resources.Padding
            End If
            If .Text = "drop-down list" Then
                txtbox1.Text = My.Resources.drop_down_list
            End If
            If .Text = "Login" Then
                txtbox1.Text = My.Resources.Login
            End If
            If .Text = "Message Box" Then
                txtbox1.Text = My.Resources.Message_Box
            End If
            If .Text = "Plug-ins" Then
                txtbox1.Text = My.Resources.Plug_ins
            End If
            If .Text = "Radio buttons" Then
                txtbox1.Text = My.Resources.Radio_buttons
            End If
            If .Text = "Table" Then
                txtbox1.Text = My.Resources.alt_Attribute
            End If
            If .Text = "Text Area" Then
                txtbox1.Text = My.Resources.alt_Attribute
            End If
            If .Text = "alt Attribute" Then
                txtbox1.Text = My.Resources.alt_Attribute
            End If
            If .Text = "Image as Link" Then
                txtbox1.Text = My.Resources.Image_as_Link
            End If
            If .Text = "Link Colors" Then
                txtbox1.Text = My.Resources.Link_Colors
            End If
            If .Text = "Local Links" Then
                txtbox1.Text = My.Resources.Local_Links
            End If
            If .Text = "Simple Link" Then
                txtbox1.Text = My.Resources.Simple_Link
            End If
            If .Text = "Circle" Then
                txtbox1.Text = My.Resources.Circle
            End If
            If .Text = "Disc" Then
                txtbox1.Text = My.Resources.Disc
            End If
            If .Text = "Numbers" Then
                txtbox1.Text = My.Resources.Numbers
            End If

            If .Text = "Square Bullets" Then
                txtbox1.Text = My.Resources.Square_Bullets
            End If

            If .Text = "Audio" Then
                txtbox1.Text = My.Resources.Audio
            End If


            If .Text = "Loop" Then
                txtbox1.Text = My.Resources._Loop
            End If
            If .Text = "Auto Play" Then
                txtbox1.Text = My.Resources.Auto_Play
            End If
            If .Text = "Simple Video " Then
                txtbox1.Text = My.Resources.Simple_Video
            End If
            If .Text = "Color Selection" Then
                txtbox1.Text = My.Resources.Color_Selection
            End If
            If .Text = "Poem" Then
                txtbox1.Text = My.Resources.Poem
            End If
            If .Text = "Line Breaks" Then
                txtbox1.Text = My.Resources.Line_Breaks
            End If
            If .Text = "Video" Then
                txtbox1.Text = My.Resources.Video
            End If

        End With
    End Sub
#End Region
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Srclist.AfterSelect
        On Error Resume Next
        Load_JS_Src()
        Load_HTML_Src()
        If Srclist.SelectedNode.Text = "HTML" Then
            txtbox1.Language = FastColoredTextBoxNS.Language.HTML
            txtbox1.Refresh()
        Else
            If Srclist.SelectedNode.Text = "JavaScripte" Then
                txtbox1.Language = FastColoredTextBoxNS.Language.JS
                txtbox1.Refresh()
            End If
        End If
    End Sub
End Class