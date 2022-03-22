
''' <summary>
''' Classe fournissant des informations de couleurs.
''' </summary>
''' <remarks></remarks>
Public Class ColorChangedEventArgs

    Inherits EventArgs

    Private m_RGB As RGB
    Private m_HSV As HSV
    Private m_Color As System.Drawing.Color

    Public ReadOnly Property Color() As Drawing.Color
        Get
            Return m_Color
        End Get
    End Property

    Public ReadOnly Property RGB() As RGB
        Get
            Return m_RGB
        End Get
    End Property

    Public ReadOnly Property HSV() As HSV
        Get
            Return m_HSV
        End Get
    End Property

    ''' <summary>
    ''' Constructeur.
    ''' </summary>
    Sub New(ByVal RGB As RGB, ByVal HSV As HSV)

        m_RGB = RGB
        m_HSV = HSV

    End Sub

    ''' <summary>
    ''' Constructeur.
    ''' </summary>
    Sub New(ByVal color As System.Drawing.Color)

        m_Color = color

    End Sub

End Class