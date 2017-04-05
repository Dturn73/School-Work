Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class GradientLabel
    Inherits System.Windows.Forms.Label

    Private _LeftColor As System.Drawing.Color
    Private _RightColor As System.Drawing.Color
    Private _LinearGradientMode As LinearGradientMode

    Public Sub New()
        '* Set initial values
        _LeftColor = Me.BackColor
        _RightColor = Me.BackColor
        _LinearGradientMode = LinearGradientMode.Horizontal
    End Sub
    Protected Overrides Sub OnPaintBackground(pevent As Windows.Forms.PaintEventArgs)
        '* Set the rectangular border
        Dim oRect As Rectangle = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        '* Create the Brush
        Dim oLinearBrush As New LinearGradientBrush(oRect, _LeftColor, _RightColor, _LinearGradientMode)
        Try
            '* Fill the rectangle with a gradient
            pevent.Graphics.FillRectangle(oLinearBrush, oRect)
        Finally
            '* Send it to the garbage collector
            oLinearBrush.Dispose()
        End Try
    End Sub

    Public Property LeftColor() As Color
        Get
            Return _LeftColor
        End Get
        Set(ByVal Value As Color)
            _LeftColor = Value
        End Set
    End Property
    Public Property RightColor() As Color
        Get
            Return _RightColor
        End Get
        Set(ByVal Value As Color)
            _RightColor = Value
        End Set
    End Property
    Public Property LinearGradientMode() As LinearGradientMode
        Get
            Return _LinearGradientMode
        End Get
        Set(ByVal Value As LinearGradientMode)
            _LinearGradientMode = Value
        End Set
    End Property
End Class
