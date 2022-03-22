<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Code_library
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disc")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Circle")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Square Bullets")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Numbers")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lists", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Simple Link")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Local Links")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Image as Link")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Links", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Images Syntax")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alt Attribute")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Images", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Radio buttons")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Login")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("drop-down list")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Text Area")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Message Box")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Color Selection")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Forms", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Video")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Audio")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Plug-ins")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Simple Video ")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auto Play")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Loop")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Youtube", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Flash, Audio, and Video", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Basic")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Line Breaks")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Poem")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Paragraphs", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Internal")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("External")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fonts")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Padding")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Margin")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CSS", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36})
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTML", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode12, TreeNode19, TreeNode27, TreeNode31, TreeNode37})
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add to Favorites")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Back Button")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Calendar")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Change Background Colors")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Client Window Size")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Close Window")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Copy Selected Text")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Date Display")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detecting Google Chrome")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Focus OnLoad")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IP Address")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Password generator")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Popup Blocker Detection ")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Specify Referring Page")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Window Close Automatically")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("JavaScripte", New System.Windows.Forms.TreeNode() {TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43, TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Code_library))
        Me.Srclist = New System.Windows.Forms.TreeView()
        Me.FaTabStrip1 = New FarsiLibrary.Win.FATabStrip()
        Me.FaTabStripItem1 = New FarsiLibrary.Win.FATabStripItem()
        Me.txtbox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FaTabStripItem2 = New FarsiLibrary.Win.FATabStripItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.FaTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FaTabStrip1.SuspendLayout()
        Me.FaTabStripItem1.SuspendLayout()
        CType(Me.txtbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FaTabStripItem2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Srclist
        '
        Me.Srclist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Srclist.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Srclist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Srclist.ForeColor = System.Drawing.Color.White
        Me.Srclist.Location = New System.Drawing.Point(12, 12)
        Me.Srclist.Name = "Srclist"
        TreeNode1.Name = "Nœud12"
        TreeNode1.Text = "Disc"
        TreeNode2.Name = "Nœud13"
        TreeNode2.Text = "Circle"
        TreeNode3.Name = "Nœud14"
        TreeNode3.Text = "Square Bullets"
        TreeNode4.Name = "Nœud16"
        TreeNode4.Text = "Numbers"
        TreeNode5.Name = "Nœud11"
        TreeNode5.Text = "Lists"
        TreeNode6.Name = "Nœud7"
        TreeNode6.Text = "Simple Link"
        TreeNode7.Name = "Nœud8"
        TreeNode7.Text = "Local Links"
        TreeNode8.Name = "Nœud10"
        TreeNode8.Text = "Image as Link"
        TreeNode9.Name = "Nœud12"
        TreeNode9.Text = "Links"
        TreeNode10.Name = "Nœud17"
        TreeNode10.Text = "Images Syntax"
        TreeNode11.Name = "Nœud18"
        TreeNode11.Text = "Alt Attribute"
        TreeNode12.Name = "Nœud13"
        TreeNode12.Text = "Images"
        TreeNode13.Name = "Nœud0"
        TreeNode13.Text = "Radio buttons"
        TreeNode14.Name = "Nœud1"
        TreeNode14.Text = "Login"
        TreeNode15.Name = "Nœud2"
        TreeNode15.Text = "drop-down list"
        TreeNode16.Name = "Nœud3"
        TreeNode16.Text = "Text Area"
        TreeNode17.Name = "Nœud4"
        TreeNode17.Text = "Message Box"
        TreeNode18.Name = "Nœud5"
        TreeNode18.Text = "Color Selection"
        TreeNode19.Name = "Nœud15"
        TreeNode19.Text = "Forms"
        TreeNode20.Name = "Nœud19"
        TreeNode20.Text = "Video"
        TreeNode21.Name = "Nœud20"
        TreeNode21.Text = "Audio"
        TreeNode22.Name = "Nœud21"
        TreeNode22.Text = "Plug-ins"
        TreeNode23.Name = "Nœud23"
        TreeNode23.Text = "Simple Video "
        TreeNode24.Name = "Nœud24"
        TreeNode24.Text = "Auto Play"
        TreeNode25.Name = "Nœud25"
        TreeNode25.Text = "Loop"
        TreeNode26.Name = "Nœud22"
        TreeNode26.Text = "Youtube"
        TreeNode27.Name = "Nœud17"
        TreeNode27.Text = "Flash, Audio, and Video"
        TreeNode28.Name = "Nœud27"
        TreeNode28.Text = "Basic"
        TreeNode29.Name = "Nœud28"
        TreeNode29.Text = "Line Breaks"
        TreeNode30.Name = "Nœud29"
        TreeNode30.Text = "Poem"
        TreeNode31.Name = "Nœud26"
        TreeNode31.Text = "Paragraphs"
        TreeNode32.Name = "Nœud31"
        TreeNode32.Text = "Internal"
        TreeNode33.Name = "Nœud32"
        TreeNode33.Text = "External"
        TreeNode34.Name = "Nœud33"
        TreeNode34.Text = "Fonts"
        TreeNode35.Name = "Nœud34"
        TreeNode35.Text = "Padding"
        TreeNode36.Name = "Nœud35"
        TreeNode36.Text = "Margin"
        TreeNode37.Name = "Nœud30"
        TreeNode37.Text = "CSS"
        TreeNode38.Name = "Nœud0"
        TreeNode38.Text = "HTML"
        TreeNode39.Name = "Nœud11"
        TreeNode39.Text = "Add to Favorites"
        TreeNode40.Name = "Nœud12"
        TreeNode40.Text = "Back Button"
        TreeNode41.Name = "Nœud13"
        TreeNode41.Text = "Calendar"
        TreeNode42.Name = "Nœud14"
        TreeNode42.Text = "Change Background Colors"
        TreeNode43.Name = "Nœud0"
        TreeNode43.Tag = "test"
        TreeNode43.Text = "Client Window Size"
        TreeNode44.Name = "Nœud1"
        TreeNode44.Text = "Close Window"
        TreeNode45.Name = "Nœud2"
        TreeNode45.Text = "Copy Selected Text"
        TreeNode46.Name = "Nœud3"
        TreeNode46.Text = "Date Display"
        TreeNode47.Name = "Nœud4"
        TreeNode47.Text = "Detecting Google Chrome"
        TreeNode48.Name = "Nœud5"
        TreeNode48.Text = "Focus OnLoad"
        TreeNode49.Name = "Nœud6"
        TreeNode49.Text = "IP Address"
        TreeNode50.Name = "Nœud7"
        TreeNode50.Text = "Password generator"
        TreeNode51.Name = "Nœud8"
        TreeNode51.Text = "Popup Blocker Detection "
        TreeNode52.Name = "Nœud9"
        TreeNode52.Text = "Specify Referring Page"
        TreeNode53.Name = "Nœud10"
        TreeNode53.Text = "Window Close Automatically"
        TreeNode54.Name = "Nœud10"
        TreeNode54.Tag = "test"
        TreeNode54.Text = "JavaScripte"
        Me.Srclist.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode38, TreeNode54})
        Me.Srclist.Size = New System.Drawing.Size(204, 359)
        Me.Srclist.TabIndex = 2
        '
        'FaTabStrip1
        '
        Me.FaTabStrip1.AlwaysShowClose = False
        Me.FaTabStrip1.AlwaysShowMenuGlyph = False
        Me.FaTabStrip1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaTabStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FaTabStrip1.Items.AddRange(New FarsiLibrary.Win.FATabStripItem() {Me.FaTabStripItem1, Me.FaTabStripItem2})
        Me.FaTabStrip1.Location = New System.Drawing.Point(222, 12)
        Me.FaTabStrip1.Name = "FaTabStrip1"
        Me.FaTabStrip1.SelectedItem = Me.FaTabStripItem2
        Me.FaTabStrip1.Size = New System.Drawing.Size(657, 359)
        Me.FaTabStrip1.TabIndex = 3
        '
        'FaTabStripItem1
        '
        Me.FaTabStripItem1.CanClose = False
        Me.FaTabStripItem1.Controls.Add(Me.txtbox1)
        Me.FaTabStripItem1.IsDrawn = True
        Me.FaTabStripItem1.Name = "FaTabStripItem1"
        Me.FaTabStripItem1.Size = New System.Drawing.Size(655, 338)
        Me.FaTabStripItem1.TabIndex = 3
        Me.FaTabStripItem1.Title = "Code"
        '
        'txtbox1
        '
        Me.txtbox1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.txtbox1.BackBrush = Nothing
        Me.txtbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.txtbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbox1.CharHeight = 14
        Me.txtbox1.CharWidth = 8
        Me.txtbox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbox1.ForeColor = System.Drawing.Color.White
        Me.txtbox1.IsReplaceMode = False
        Me.txtbox1.Language = FastColoredTextBoxNS.Language.JS
        Me.txtbox1.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtbox1.Location = New System.Drawing.Point(0, 0)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtbox1.ReadOnly = True
        Me.txtbox1.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtbox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox1.Size = New System.Drawing.Size(655, 338)
        Me.txtbox1.TabIndex = 3
        Me.txtbox1.Zoom = 100
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FaTabStripItem2
        '
        Me.FaTabStripItem2.CanClose = False
        Me.FaTabStripItem2.Controls.Add(Me.WebBrowser1)
        Me.FaTabStripItem2.IsDrawn = True
        Me.FaTabStripItem2.Name = "FaTabStripItem2"
        Me.FaTabStripItem2.Selected = True
        Me.FaTabStripItem2.Size = New System.Drawing.Size(655, 338)
        Me.FaTabStripItem2.TabIndex = 4
        Me.FaTabStripItem2.Title = "Preview"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(655, 338)
        Me.WebBrowser1.TabIndex = 0
        '
        'Code_library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 382)
        Me.Controls.Add(Me.FaTabStrip1)
        Me.Controls.Add(Me.Srclist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Code_library"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code library"
        CType(Me.FaTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FaTabStrip1.ResumeLayout(False)
        Me.FaTabStripItem1.ResumeLayout(False)
        CType(Me.txtbox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FaTabStripItem2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Srclist As System.Windows.Forms.TreeView
    Friend WithEvents FaTabStrip1 As FarsiLibrary.Win.FATabStrip
    Friend WithEvents FaTabStripItem1 As FarsiLibrary.Win.FATabStripItem
    Friend WithEvents txtbox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents FaTabStripItem2 As FarsiLibrary.Win.FATabStripItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
