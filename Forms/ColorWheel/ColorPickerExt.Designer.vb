<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPickerExt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ColorPicker1 = New ColorPicker
        Me.btnValid = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ColorPicker1
        '
        Me.ColorPicker1.ColorTableBoxTitle = ""
        Me.ColorPicker1.ColorWheelBoxTitle = "Selected color panel"
        Me.ColorPicker1.Location = New System.Drawing.Point(-2, 1)
        Me.ColorPicker1.Name = "ColorPicker1"
        Me.ColorPicker1.Size = New System.Drawing.Size(460, 207)
        Me.ColorPicker1.TabIndex = 0
        '
        'btnValid
        '
        Me.btnValid.Location = New System.Drawing.Point(283, 205)
        Me.btnValid.Name = "btnValid"
        Me.btnValid.Size = New System.Drawing.Size(75, 23)
        Me.btnValid.TabIndex = 1
        Me.btnValid.Text = "OK"
        Me.btnValid.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(364, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ColorPickerExt
        '
        Me.AcceptButton = Me.btnValid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(451, 237)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnValid)
        Me.Controls.Add(Me.ColorPicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ColorPickerExt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extented Color Picker"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorPicker1 As ColorPicker
    Friend WithEvents btnValid As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
