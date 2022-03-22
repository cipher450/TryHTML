Public Class ColorPickerExt

    Public ReadOnly Property SelectedColor() As Drawing.Color
        Get
            Return ColorPicker1.picSelectedColor.BackColor
        End Get
    End Property

    Private Sub btnValid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValid.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

End Class