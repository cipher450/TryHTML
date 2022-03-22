Imports System.Drawing

''' <summary>
''' Fournit des méthodes de conversion d'espace colorimétrique.
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class ColorHelper

    ''' <summary>
    ''' Convertit un type HSV vers un objet <see cref="Color"></see>.
    ''' </summary>
    ''' <param name="H">Valeur de teinte.</param>
    ''' <param name="S">Valeur de saturation.</param>
    ''' <param name="V">Valeur de luminosité.</param>
    ''' <returns>Un objet <see cref="Color"></see>.</returns>
    Public Shared Function ConvertHsvToColor(ByVal H As Integer, ByVal S As Integer, ByVal V As Integer) As Color

        Return ConvertHsvToColor(New HSV(H, S, V))

    End Function

    ''' <summary>
    ''' Convertit un type HSV vers un objet <see cref="Color"></see>.
    ''' </summary>
    ''' <param name="HSVValues">Structure de type <see cref="HSV"></see>.</param>
    ''' <returns>Un objet <see cref="Color"></see>.</returns>
    Public Shared Function ConvertHsvToColor(ByVal HSVValues As HSV) As Color

        Dim RGB As RGB = ConvertHsvToRgb(HSVValues)

        Return Color.FromArgb(RGB.Red, RGB.Green, RGB.Blue)

    End Function

    ''' <summary>
    ''' Convertit un type HSV vers un objet <see cref="RGB"></see>.
    ''' </summary>
    ''' <param name="H">Valeur de teinte.</param>
    ''' <param name="S">Valeur de saturation.</param>
    ''' <param name="V">Valeur de luminosité.</param>
    ''' <returns>Un objet <see cref="Color"></see>.</returns>
    Public Shared Function ConvertHsvToRgb(ByVal H As Integer, ByVal S As Integer, ByVal V As Integer) As RGB

        Return ConvertHsvToRgb(New HSV(H, S, V))

    End Function

    ''' <summary>
    ''' Convertit un type HSV vers un objet <see cref="RGB"></see>.
    ''' </summary>
    ''' <param name="HSVValues">Structure de type <see cref="HSV"></see>.</param>
    ''' <returns>Un objet <see cref="RGB"></see>.</returns>
    Public Shared Function ConvertHsvToRgb(ByVal HSVValues As HSV) As RGB

        Dim decR, decG, decB As Decimal
        Dim decH, decS, decV As Decimal

        ' Scale Hue to be between 0 and 360. Saturation
        ' and Value scale to be between 0 and 1.
        decH = (HSVValues.Hue / 255D * 360) Mod 360
        decS = HSVValues.Saturation / 255D
        decV = HSVValues.Brightness / 255D

        If decS = 0 Then

            ' If s is 0, all colors are the same.
            ' This is some flavor of gray.
            decR = decV
            decG = decV
            decB = decV

        Else

            Dim p As Decimal
            Dim q As Decimal
            Dim t As Decimal

            Dim fractionalSector As Decimal
            Dim sectorNumber As Integer
            Dim sectorPos As Decimal

            ' The color wheel consists of 6 sectors.
            ' Figure out which sector you're in.
            sectorPos = decH / 60
            sectorNumber = CInt(Math.Floor(sectorPos))

            ' Get the fractional part of the sector.
            ' That is, how many degrees into the sector
            ' are you?
            fractionalSector = sectorPos - sectorNumber

            ' Calculate values for the three axes
            ' of the color. 
            p = decV * (1 - decS)
            q = decV * (1 - (decS * fractionalSector))
            t = decV * (1 - (decS * (1 - fractionalSector)))

            ' Assign the fractional colors to r, g, and b
            ' based on the sector the angle is in.
            Select Case sectorNumber
                Case 0
                    decR = decV
                    decG = t
                    decB = p

                Case 1
                    decR = q
                    decG = decV
                    decB = p

                Case 2
                    decR = p
                    decG = decV
                    decB = t

                Case 3
                    decR = p
                    decG = q
                    decB = decV

                Case 4
                    decR = t
                    decG = p
                    decB = decV

                Case 5
                    decR = decV
                    decG = p
                    decB = q
            End Select
        End If

        ' Return an RGB structure, with values scaled
        ' to be between 0 and 255.
        Return New RGB(CInt(decR * 255), CInt(decG * 255), CInt(decB * 255))

    End Function

    ''' <summary>
    ''' Convertit un type RGB vers un type <see cref="HSV"></see>.
    ''' </summary>
    ''' <param name="RGBValues">Structure de type <see cref="HSV"></see>.</param>
    ''' <returns>Un objet <see cref="Color">HSV</see>.</returns>
    Public Shared Function ConvertRgbToHsv(ByVal RGBValues As RGB) As HSV

        ' In this function, R, G, and B values must be scaled 
        ' to be between 0 and 1.
        ' HSV.Hue will be a value between 0 and 360, and 
        ' HSV.Saturation and Value are between 0 and 1.
        ' The code must scale these to be between 0 and 255 for
        ' the purposes of this application.

        Dim min As Decimal
        Dim max As Decimal
        Dim delta As Decimal

        Dim r As Decimal = RGBValues.Red / 255D
        Dim g As Decimal = RGBValues.Green / 255D
        Dim b As Decimal = RGBValues.Blue / 255D

        Dim h As Decimal
        Dim s As Decimal
        Dim v As Decimal

        min = Math.Min(Math.Min(r, g), b)
        max = Math.Max(Math.Max(r, g), b)
        v = max
        delta = max - min
        If max = 0 Or delta = 0 Then
            ' R, G, and B must be 0, or all the same.
            ' In this case, S is 0, and H is undefined.
            ' Using H = 0 is as good as any...
            s = 0
            h = 0
        Else
            s = delta / max
            If r = max Then
                ' Between Yellow and Magenta
                h = (g - b) / delta
            ElseIf g = max Then
                ' Between Cyan and Yellow
                h = 2 + (b - r) / delta
            Else
                ' Between Magenta and Cyan
                h = 4 + (r - g) / delta
            End If

        End If
        ' Scale h to be between 0 and 360. 
        ' This may require adding 360, if the value
        ' is negative.
        h *= 60
        If h < 0 Then
            h += 360
        End If

        ' Scale to the requirements of this 
        ' application. All values are between 0 and 255.
        Return New HSV(CInt(h / 360 * 255), CInt(s * 255), CInt(v * 255))

    End Function

End Class

