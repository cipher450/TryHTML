Imports System.Drawing

''' <summary>
''' Structure RGB - Rouge/Vert/Bleue.
''' </summary>
''' <remarks></remarks>
Public Structure RGB

    Private m_Red As Integer
    Private m_Green As Integer
    Private m_Blue As Integer

    ''' <summary>
    ''' Obtient/Définit la valeur de rouge.
    ''' </summary>
    Public Property Red() As Integer
        Get
            Return m_Red
        End Get
        Set(ByVal value As Integer)
            m_Red = value
        End Set
    End Property

    ''' <summary>
    ''' Obtient/Définit la valeur de vert.
    ''' </summary>
    Public Property Green() As Integer
        Get
            Return m_Green
        End Get
        Set(ByVal value As Integer)
            m_Green = value
        End Set
    End Property

    ''' <summary>
    ''' Obtient/Définit la valeur de bleu.
    ''' </summary>
    Public Property Blue() As Integer
        Get
            Return m_Blue
        End Get
        Set(ByVal value As Integer)
            m_Blue = value
        End Set
    End Property

    ''' <summary>
    ''' Retourne la structure RGB.
    ''' </summary>
    Public Function GetRGB() As RGB

        Return Me

    End Function

    ''' <summary>
    ''' Retourne un objet <see cref="Color"></see>.
    ''' </summary>
    Public Function GetColorValue() As Color

        Return Color.FromArgb(m_Red, m_Green, m_Blue)

    End Function

    ''' <summary>
    ''' Constructeur.
    ''' </summary>
    Public Sub New(ByVal R As Integer, ByVal G As Integer, ByVal B As Integer)

        m_Red = R
        m_Green = G
        m_Blue = B

    End Sub

End Structure
