<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorWheel
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
        Me.picBrightness = New System.Windows.Forms.PictureBox
        Me.picColor = New System.Windows.Forms.PictureBox
        CType(Me.picBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBrightness
        '
        Me.picBrightness.Location = New System.Drawing.Point(170, 4)
        Me.picBrightness.Name = "picBrightness"
        Me.picBrightness.Size = New System.Drawing.Size(20, 160)
        Me.picBrightness.TabIndex = 19
        Me.picBrightness.TabStop = False
        '
        'picColor
        '
        Me.picColor.Location = New System.Drawing.Point(4, 4)
        Me.picColor.Name = "picColor"
        Me.picColor.Size = New System.Drawing.Size(160, 160)
        Me.picColor.TabIndex = 20
        Me.picColor.TabStop = False
        '
        'ColorWheel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picColor)
        Me.Controls.Add(Me.picBrightness)
        Me.Name = "ColorWheel"
        Me.Size = New System.Drawing.Size(196, 171)
        CType(Me.picBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBrightness As System.Windows.Forms.PictureBox
    Friend WithEvents picColor As System.Windows.Forms.PictureBox

End Class
