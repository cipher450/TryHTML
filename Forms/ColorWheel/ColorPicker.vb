Imports System.Windows.Forms

Public Class ColorPicker

    Private ColorChangedValues As ColorChangedEventArgs

    Private Sub ColorPicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Valeur défaut.
        ColorWheel1.Red = 127
        ColorWheel1.Green = 127
        ColorWheel1.Blue = 127

        picSelectedColor.BackColor = ColorWheel1.ColorValue

    End Sub

    Public Shadows Property BackgroundImage() As System.Drawing.Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(ByVal value As System.Drawing.Image)
            MyBase.BackgroundImage = value
        End Set
    End Property

    Public Overrides Property BackColor() As System.Drawing.Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            MyBase.BackColor = value
        End Set
    End Property

    Public Property ColorWheelBoxTitle() As String
        Get
            Return grpBoxColor.Text
        End Get
        Set(ByVal value As String)
            grpBoxColor.Text = value
        End Set
    End Property

    Public Property ColorTableBoxTitle() As String
        Get
            Return grpBoxColorTable.Text
        End Get
        Set(ByVal value As String)
            grpBoxColorTable.Text = value
        End Set
    End Property

    Private Sub ColorWheel1_ColorChanged(ByVal sender As System.Object, ByVal e As ColorChangedEventArgs) Handles ColorWheel1.ColorChanged

        'Rafraichit les contrôles liés aux espaces de couleurs.
        RefreshControls(e)

    End Sub

    Private Sub numRGB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles numUpR.ValueChanged, numUpG.ValueChanged, numUpB.ValueChanged

        Select Case DirectCast(sender, NumericUpDown).Name
            Case numUpR.Name
                ColorWheel1.Red = Convert.ToInt32(numUpR.Value)
            Case numUpG.Name
                ColorWheel1.Green = Convert.ToInt32(numUpG.Value)
            Case numUpB.Name
                ColorWheel1.Blue = Convert.ToInt32(numUpB.Value)
        End Select


        ColorChangedValues = New ColorChangedEventArgs( _
                                        New RGB(ColorWheel1.Red, ColorWheel1.Green, ColorWheel1.Blue), _
                                        New HSV(ColorWheel1.Hue, ColorWheel1.Saturation, ColorWheel1.Brightness))

        RefreshControls(ColorChangedValues)

    End Sub

    Private Sub numUpHSV_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles numUpH.ValueChanged, numUpS.ValueChanged, numUpV.ValueChanged

        Select Case DirectCast(sender, NumericUpDown).Name
            Case numUpH.Name
                ColorWheel1.Hue = Convert.ToInt32(numUpH.Value)
            Case numUpS.Name
                ColorWheel1.Saturation = Convert.ToInt32(numUpS.Value)
            Case numUpV.Name
                ColorWheel1.Brightness = Convert.ToInt32(numUpV.Value)
        End Select

        ColorChangedValues = New ColorChangedEventArgs( _
                                New RGB(ColorWheel1.Red, ColorWheel1.Green, ColorWheel1.Blue), _
                                New HSV(ColorWheel1.Hue, ColorWheel1.Saturation, ColorWheel1.Brightness))

        RefreshControls(ColorChangedValues)

    End Sub

    Private Sub RefreshControls(ByVal e As ColorChangedEventArgs)

        picSelectedColor.BackColor = ColorWheel1.ColorValue

        numUpR.Value = e.RGB.Red
        numUpG.Value = e.RGB.Green
        numUpB.Value = e.RGB.Blue
        numUpH.Value = e.HSV.Hue
        numUpS.Value = e.HSV.Saturation
        numUpV.Value = e.HSV.Brightness

        lblHexa.Text = String.Format("#{0}{1}{2}", e.RGB.Red.ToString("x2"), _
                                     e.RGB.Green.ToString("x2"), e.RGB.Blue.ToString("x2")).ToUpper()

    End Sub

    Private Sub RefreshControls(ByVal c As Drawing.Color)

        picSelectedColor.BackColor = c

        numUpR.Value = c.R
        numUpG.Value = c.G
        numUpB.Value = c.B

        lblHexa.Text = String.Format("#{0}{1}{2}", c.R.ToString("x2"), _
                                     c.G.ToString("x2"), c.B.ToString("x2")).ToUpper()

    End Sub

    Private Sub ScreenColorPicker1_SelectedColorChanged(ByVal sender As System.Object, ByVal e As ColorChangedEventArgs) _
    Handles ScreenColorPicker1.SelectedColor

        'Rafraichit les contrôles liés aux espaces de couleurs.
        RefreshControls(e.Color)

    End Sub

End Class
