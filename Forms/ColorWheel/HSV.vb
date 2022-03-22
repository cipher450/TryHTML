
''' <summary>
''' Structure HSB - Teinte/Saturation/Lumière.
''' </summary>
''' <remarks></remarks>
Public Structure HSV

    Private m_Hue As Integer
    Private m_Saturation As Integer
    Private m_Value As Integer

    ''' <summary>
    ''' Obtient/Définit la valeur de teinte.
    ''' </summary>
    Public Property Hue() As Integer
        Get
            Return m_Hue
        End Get
        Set(ByVal value As Integer)
            m_Hue = value
        End Set
    End Property

    ''' <summary>
    ''' Obtient/Définit la saturation.
    ''' </summary>
    Public Property Saturation() As Integer
        Get
            Return m_Saturation
        End Get
        Set(ByVal value As Integer)
            m_Saturation = value
        End Set
    End Property

    ''' <summary>
    ''' Obtient/Définit la luminosité.
    ''' </summary>
    Public Property Brightness() As Integer
        Get
            Return m_Value
        End Get
        Set(ByVal value As Integer)
            m_Value = value
        End Set
    End Property

    ''' <summary>
    ''' Constructeur.
    ''' </summary>
    Public Sub New(ByVal H As Integer, ByVal S As Integer, ByVal B As Integer)

        m_Hue = H
        m_Saturation = S
        m_Value = B

    End Sub

End Structure