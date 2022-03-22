Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

''' <summary>
''' Contrôle utilisateur de sélection de couleur sur la surface du bureau.
''' </summary>
''' <remarks></remarks>
Public Class ScreenColorPicker

    Private m_capture As Bitmap
    Private m_selectedColor As Color
    Private m_zoom As Integer = 3
    Private bCapturing As Boolean = False

    ''' <summary>
    ''' Evénement lors de changement de couleur.
    ''' </summary>
    ''' <remarks></remarks>
    Public Event SelectedColor As EventHandler(Of ColorChangedEventArgs)

    ''' <summary>
    ''' Obtient le centre d'un rectangle
    ''' </summary>
    ''' <param name="rect"></param>
    ''' <returns>Un point <see cref="PointF"></see></returns>
    Private Function GetCenterPoint(ByVal rect As RectangleF) As PointF

        Dim pf As PointF = rect.Location

        pf.Y += rect.Height / 2
        pf.X += rect.Width / 2

        Return pf

    End Function

    ''' <summary>
    ''' Convertit un <see cref="Rectangle"></see> vers un <see cref="RectangleF"></see>.
    ''' </summary>
    ''' <param name="rect">Un <see cref="Rectangle"></see>.</param>
    ''' <returns>Un <see cref="RectangleF"></see>.</returns>
    Private Function ConvertRectangleToFloating(ByVal rect As Rectangle) As RectangleF

        Dim rectF As New RectangleF

        rectF.Y = Convert.ToSingle(rect.Y)
        rectF.X = Convert.ToSingle(rect.X)

        rectF.Width = Convert.ToSingle(rect.Width)
        rectF.Height = Convert.ToSingle(rect.Height)

        Return rectF

    End Function

    ''' <summary>
    ''' Capture d'une zone entourant la souris.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetCapture()

        Dim MousePos As Point = Control.MousePosition

        'Définit la zone à capturer.
        MousePos.X -= m_capture.Width / 2
        MousePos.Y -= m_capture.Height / 2

        Using g As Graphics = Graphics.FromImage(m_capture)

            'Capture d'écran de la taille de notre UC.
            g.CopyFromScreen(MousePos, New Point(0, 0), m_capture.Size)

            'Force le UC à redessiner tout sont contenu.
            Me.Refresh()

            'Récupération de la partie qui entoure la souris.
            Dim center As PointF = GetCenterPoint(New RectangleF(0, 0, m_capture.Size.Width, m_capture.Size.Height))

            'Récupération de la couleur pointé par la souris.
            m_selectedColor = m_capture.GetPixel(Convert.ToInt32(Math.Round(center.X)), Convert.ToInt32(Math.Round(center.Y)))

            RaiseEvent SelectedColor(Me, New ColorChangedEventArgs(m_selectedColor))

        End Using
    End Sub

    ''' <summary>
    ''' Mode capture.
    ''' </summary>
    Private Sub ScreenColorPicker_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then

            'Change le curseur pour indiquer le mode capture.
            Cursor = Cursors.Cross

            bCapturing = True

            Me.Invalidate()

        End If

    End Sub

    ''' <summary>
    ''' Déplacement souris.
    ''' </summary>
    Private Sub ScreenColorPicker_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'Prend des captures suivant la position de la souris.
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then

            'Déclenche la récupération d'une capture + couleur du pixel poité par la souris.
            GetCapture()

        End If

    End Sub

    ''' <summary>
    ''' Arrêt capture au relachement du bouton de la souris.
    ''' </summary>
    Private Sub ScreenColorPicker_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        'Redéfinit le curseur par défaut (flèche).
        Cursor = Cursors.Arrow

        bCapturing = False

        Me.Invalidate()

    End Sub

    ''' <summary>
    ''' Dessine la capture dans la zone cliente de notre UC.
    ''' </summary>
    Private Sub ScreenColorPicker_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim clientRect As Rectangle = Me.ClientRectangle

        If Not m_capture Is Nothing Then

            'Définit le mode d'interpolation voulu sur l'objet Graphics.
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor

            'Créér le rectangle pour recevoir la capture (avec prise en charge d'un zoom).
            Dim rectF As New RectangleF
            rectF.Width = m_capture.Size.Width * m_zoom
            rectF.Height = m_capture.Size.Height * m_zoom
            rectF.X = 0
            rectF.Y = 0

            'Transfert la capture.
            e.Graphics.DrawImage(m_capture, rectF)

            'Si on est en mode capture.
            If bCapturing Then

                'Obtient le centre du rectangle.
                Dim centerPoint As PointF = GetCenterPoint(rectF)

                'Créér le rectangle en se basant sur le point centrale.
                Dim CenterRect As New Rectangle(New Point( _
                                                Convert.ToInt32(centerPoint.X), _
                                                Convert.ToInt32(centerPoint.Y)), New Size(0, 0))

                CenterRect.X -= (m_zoom / 2 - 1)
                CenterRect.Y -= (m_zoom / 2 - 1)
                CenterRect.Width = m_zoom
                CenterRect.Height = m_zoom

                'Dessine le rectangle.
                e.Graphics.DrawRectangle(Pens.Black, CenterRect)

            End If

        End If

        'Maintenant on dessine le sélecteur (carré noir).
        Dim pen As New Pen(BackColor, 3)
        clientRect.Inflate(-1, -1)
        e.Graphics.DrawRectangle(pen, clientRect)

    End Sub

    Private Sub ScreenColorPicker_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        'Libère ressources utilisés pour le bitmap de capture.
        'Si il existe déjà pour le recréer par la suite.
        If m_capture IsNot Nothing Then
            m_capture.Dispose()
        End If

        Dim rectF As RectangleF = ConvertRectangleToFloating(Me.ClientRectangle)
        Dim iHeight As Integer = Convert.ToInt32(Math.Floor(rectF.Height / m_zoom))
        Dim iWidth As Integer = Convert.ToInt32(Math.Floor(rectF.Width / m_zoom))

        m_capture = New Bitmap(iWidth, iHeight)

    End Sub

End Class
