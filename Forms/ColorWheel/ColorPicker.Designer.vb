<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPicker
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container
        Me.grpBoxColor = New System.Windows.Forms.GroupBox
        Me.ColorWheel1 = New ColorWheel
        Me.grpBoxColorTable = New System.Windows.Forms.GroupBox
        Me.numUpV = New System.Windows.Forms.NumericUpDown
        Me.numUpS = New System.Windows.Forms.NumericUpDown
        Me.numUpH = New System.Windows.Forms.NumericUpDown
        Me.lblH = New System.Windows.Forms.Label
        Me.lblBrightness = New System.Windows.Forms.Label
        Me.lblS = New System.Windows.Forms.Label
        Me.numUpB = New System.Windows.Forms.NumericUpDown
        Me.numUpG = New System.Windows.Forms.NumericUpDown
        Me.numUpR = New System.Windows.Forms.NumericUpDown
        Me.lblHSV = New System.Windows.Forms.Label
        Me.lblRgb = New System.Windows.Forms.Label
        Me.lblR = New System.Windows.Forms.Label
        Me.lblB = New System.Windows.Forms.Label
        Me.lblG = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.grpBoxZoom = New System.Windows.Forms.GroupBox
        Me.ScreenColorPicker1 = New ScreenColorPicker
        Me.picSelectedColor = New System.Windows.Forms.PictureBox
        Me.lblHexa = New System.Windows.Forms.Label
        Me.ToolTipUC = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpBoxColor.SuspendLayout()
        Me.grpBoxColorTable.SuspendLayout()
        CType(Me.numUpV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numUpR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grpBoxZoom.SuspendLayout()
        CType(Me.picSelectedColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxColor
        '
        Me.grpBoxColor.Controls.Add(Me.ColorWheel1)
        Me.grpBoxColor.Location = New System.Drawing.Point(5, 2)
        Me.grpBoxColor.Name = "grpBoxColor"
        Me.grpBoxColor.Size = New System.Drawing.Size(235, 198)
        Me.grpBoxColor.TabIndex = 0
        Me.grpBoxColor.TabStop = False
        Me.grpBoxColor.Text = "Selected color panel"
        '
        'ColorWheel1
        '
        Me.ColorWheel1.Blue = 0
        Me.ColorWheel1.Brightness = 0
        Me.ColorWheel1.Green = 0
        Me.ColorWheel1.Hue = 0
        Me.ColorWheel1.Location = New System.Drawing.Point(7, 20)
        Me.ColorWheel1.Name = "ColorWheel1"
        Me.ColorWheel1.Red = 0
        Me.ColorWheel1.Saturation = 0
        Me.ColorWheel1.Size = New System.Drawing.Size(196, 171)
        Me.ColorWheel1.TabIndex = 0
        '
        'grpBoxColorTable
        '
        Me.grpBoxColorTable.Controls.Add(Me.numUpV)
        Me.grpBoxColorTable.Controls.Add(Me.numUpS)
        Me.grpBoxColorTable.Controls.Add(Me.numUpH)
        Me.grpBoxColorTable.Controls.Add(Me.lblH)
        Me.grpBoxColorTable.Controls.Add(Me.lblBrightness)
        Me.grpBoxColorTable.Controls.Add(Me.lblS)
        Me.grpBoxColorTable.Controls.Add(Me.numUpB)
        Me.grpBoxColorTable.Controls.Add(Me.numUpG)
        Me.grpBoxColorTable.Controls.Add(Me.numUpR)
        Me.grpBoxColorTable.Controls.Add(Me.lblHSV)
        Me.grpBoxColorTable.Controls.Add(Me.lblRgb)
        Me.grpBoxColorTable.Controls.Add(Me.lblR)
        Me.grpBoxColorTable.Controls.Add(Me.lblB)
        Me.grpBoxColorTable.Controls.Add(Me.lblG)
        Me.grpBoxColorTable.Location = New System.Drawing.Point(246, 3)
        Me.grpBoxColorTable.Name = "grpBoxColorTable"
        Me.grpBoxColorTable.Size = New System.Drawing.Size(202, 122)
        Me.grpBoxColorTable.TabIndex = 1
        Me.grpBoxColorTable.TabStop = False
        '
        'numUpV
        '
        Me.numUpV.BackColor = System.Drawing.SystemColors.Window
        Me.numUpV.Location = New System.Drawing.Point(132, 91)
        Me.numUpV.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numUpV.Name = "numUpV"
        Me.numUpV.ReadOnly = True
        Me.numUpV.Size = New System.Drawing.Size(57, 20)
        Me.numUpV.TabIndex = 13
        Me.numUpV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numUpS
        '
        Me.numUpS.BackColor = System.Drawing.SystemColors.Window
        Me.numUpS.Location = New System.Drawing.Point(132, 66)
        Me.numUpS.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numUpS.Name = "numUpS"
        Me.numUpS.ReadOnly = True
        Me.numUpS.Size = New System.Drawing.Size(57, 20)
        Me.numUpS.TabIndex = 12
        Me.numUpS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numUpH
        '
        Me.numUpH.BackColor = System.Drawing.SystemColors.Window
        Me.numUpH.Location = New System.Drawing.Point(132, 41)
        Me.numUpH.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numUpH.Name = "numUpH"
        Me.numUpH.ReadOnly = True
        Me.numUpH.Size = New System.Drawing.Size(57, 20)
        Me.numUpH.TabIndex = 11
        Me.numUpH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblH.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblH.Location = New System.Drawing.Point(110, 43)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(16, 13)
        Me.lblH.TabIndex = 8
        Me.lblH.Text = "H"
        '
        'lblBrightness
        '
        Me.lblBrightness.AutoSize = True
        Me.lblBrightness.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrightness.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBrightness.Location = New System.Drawing.Point(110, 93)
        Me.lblBrightness.Name = "lblBrightness"
        Me.lblBrightness.Size = New System.Drawing.Size(15, 13)
        Me.lblBrightness.TabIndex = 10
        Me.lblBrightness.Text = "B"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblS.Location = New System.Drawing.Point(110, 68)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(15, 13)
        Me.lblS.TabIndex = 9
        Me.lblS.Text = "S"
        '
        'numUpB
        '
        Me.numUpB.BackColor = System.Drawing.SystemColors.Window
        Me.numUpB.Location = New System.Drawing.Point(28, 91)
        Me.numUpB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numUpB.Name = "numUpB"
        Me.numUpB.ReadOnly = True
        Me.numUpB.Size = New System.Drawing.Size(57, 20)
        Me.numUpB.TabIndex = 7
        Me.numUpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numUpG
        '
        Me.numUpG.BackColor = System.Drawing.SystemColors.Window
        Me.numUpG.Location = New System.Drawing.Point(28, 66)
        Me.numUpG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numUpG.Name = "numUpG"
        Me.numUpG.ReadOnly = True
        Me.numUpG.Size = New System.Drawing.Size(57, 20)
        Me.numUpG.TabIndex = 6
        Me.numUpG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numUpR
        '
        Me.numUpR.BackColor = System.Drawing.SystemColors.Window
        Me.numUpR.Location = New System.Drawing.Point(28, 41)
        Me.numUpR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numUpR.Name = "numUpR"
        Me.numUpR.ReadOnly = True
        Me.numUpR.Size = New System.Drawing.Size(57, 20)
        Me.numUpR.TabIndex = 5
        Me.numUpR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHSV
        '
        Me.lblHSV.AutoSize = True
        Me.lblHSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSV.Location = New System.Drawing.Point(138, 16)
        Me.lblHSV.Name = "lblHSV"
        Me.lblHSV.Size = New System.Drawing.Size(32, 13)
        Me.lblHSV.TabIndex = 1
        Me.lblHSV.Text = "HSV"
        '
        'lblRgb
        '
        Me.lblRgb.AutoSize = True
        Me.lblRgb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRgb.Location = New System.Drawing.Point(38, 16)
        Me.lblRgb.Name = "lblRgb"
        Me.lblRgb.Size = New System.Drawing.Size(33, 13)
        Me.lblRgb.TabIndex = 0
        Me.lblRgb.Text = "RGB"
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.ForeColor = System.Drawing.Color.Red
        Me.lblR.Location = New System.Drawing.Point(6, 43)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(16, 13)
        Me.lblR.TabIndex = 2
        Me.lblR.Text = "R"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.ForeColor = System.Drawing.Color.Blue
        Me.lblB.Location = New System.Drawing.Point(6, 93)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(15, 13)
        Me.lblB.TabIndex = 4
        Me.lblB.Text = "B"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.ForeColor = System.Drawing.Color.Green
        Me.lblG.Location = New System.Drawing.Point(6, 68)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(16, 13)
        Me.lblG.TabIndex = 3
        Me.lblG.Text = "G"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpBoxZoom)
        Me.GroupBox1.Controls.Add(Me.picSelectedColor)
        Me.GroupBox1.Controls.Add(Me.lblHexa)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 75)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'grpBoxZoom
        '
        Me.grpBoxZoom.Controls.Add(Me.ScreenColorPicker1)
        Me.grpBoxZoom.Location = New System.Drawing.Point(141, 7)
        Me.grpBoxZoom.Name = "grpBoxZoom"
        Me.grpBoxZoom.Size = New System.Drawing.Size(50, 61)
        Me.grpBoxZoom.TabIndex = 4
        Me.grpBoxZoom.TabStop = False
        '
        'ScreenColorPicker1
        '
        Me.ScreenColorPicker1.Location = New System.Drawing.Point(2, 11)
        Me.ScreenColorPicker1.Name = "ScreenColorPicker1"
        Me.ScreenColorPicker1.Size = New System.Drawing.Size(45, 45)
        Me.ScreenColorPicker1.TabIndex = 7
        Me.ToolTipUC.SetToolTip(Me.ScreenColorPicker1, "Screen color picker")
        '
        'picSelectedColor
        '
        Me.picSelectedColor.Location = New System.Drawing.Point(7, 11)
        Me.picSelectedColor.Name = "picSelectedColor"
        Me.picSelectedColor.Size = New System.Drawing.Size(128, 30)
        Me.picSelectedColor.TabIndex = 0
        Me.picSelectedColor.TabStop = False
        '
        'lblHexa
        '
        Me.lblHexa.AutoSize = True
        Me.lblHexa.Location = New System.Drawing.Point(6, 47)
        Me.lblHexa.Name = "lblHexa"
        Me.lblHexa.Size = New System.Drawing.Size(50, 13)
        Me.lblHexa.TabIndex = 3
        Me.lblHexa.Text = "#FFFFFF"
        '
        'ColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpBoxColorTable)
        Me.Controls.Add(Me.grpBoxColor)
        Me.Name = "ColorPicker"
        Me.Size = New System.Drawing.Size(460, 207)
        Me.grpBoxColor.ResumeLayout(False)
        Me.grpBoxColorTable.ResumeLayout(False)
        Me.grpBoxColorTable.PerformLayout()
        CType(Me.numUpV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numUpR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpBoxZoom.ResumeLayout(False)
        CType(Me.picSelectedColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBoxColor As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxColorTable As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picSelectedColor As System.Windows.Forms.PictureBox
    Friend WithEvents lblHSV As System.Windows.Forms.Label
    Friend WithEvents lblRgb As System.Windows.Forms.Label
    Friend WithEvents lblR As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblG As System.Windows.Forms.Label
    Friend WithEvents numUpR As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpB As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpG As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpV As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpS As System.Windows.Forms.NumericUpDown
    Friend WithEvents numUpH As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblH As System.Windows.Forms.Label
    Friend WithEvents lblBrightness As System.Windows.Forms.Label
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents lblHexa As System.Windows.Forms.Label
    Friend WithEvents ColorWheel1 As ColorWheel
    Friend WithEvents grpBoxZoom As System.Windows.Forms.GroupBox
    Friend WithEvents ScreenColorPicker1 As ScreenColorPicker
    Friend WithEvents ToolTipUC As System.Windows.Forms.ToolTip

End Class
