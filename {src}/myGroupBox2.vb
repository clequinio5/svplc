Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SVPLCApplication
	Public Class myGroupBox2
		Inherits Panel
		Private _thickness As Integer

		Private _borderColor As Color

		Private _titleColor As Color

		Private diago As Integer

		Public Property BorderColor As Color
			Get
				Return Me._borderColor
			End Get
			Set(ByVal value As Color)
				Me._borderColor = value
			End Set
		End Property

		Public Property Diagonale As Integer
			Get
				Return Me.diago
			End Get
			Set(ByVal value As Integer)
				Me.diago = value
			End Set
		End Property

		Public Property Thickness As Integer
			Get
				Return Me._thickness
			End Get
			Set(ByVal value As Integer)
				Me._thickness = value
			End Set
		End Property

		Public Property Titlecolor As Color
			Get
				Return Me._titleColor
			End Get
			Set(ByVal value As Color)
				Me._titleColor = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me._titleColor = Color.FromArgb(0, 192, 0)
			Me.ForeColor = Color.Black
			Me._borderColor = Color.Green
			Me._thickness = 4
			Me.diago = 4
			Me.DoubleBuffered = True
			Me.ResizeRedraw = True
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle()
			Dim size As System.Drawing.Size = TextRenderer.MeasureText(Me.Text, Me.Font)
			Dim clientRectangle As System.Drawing.Rectangle = Me.ClientRectangle
			Dim pen As System.Drawing.Pen = New System.Drawing.Pen(Me._borderColor, CSng(Me._thickness))
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim num As Integer = CInt(Math.Round(CDbl(size.Height) / 2 + CDbl(Me._thickness) / 2))
			Dim num1 As Integer = CInt(Math.Round(CDbl(size.Height) / 2 + CDbl(Me._thickness) / 2 + CDbl(Me.diago)))
			Dim num2 As Integer = CInt(Math.Round(CDbl((clientRectangle.Height - Me.diago)) - CDbl(Me._thickness) / 2))
			Dim num3 As Integer = CInt(Math.Round(CDbl(clientRectangle.Height) - CDbl(Me._thickness) / 2))
			Dim num4 As Integer = CInt(Math.Round(CDbl(Me._thickness) / 2))
			Dim num5 As Integer = CInt(Math.Round(CDbl(Me.diago) + CDbl(Me._thickness) / 2))
			Dim num6 As Integer = CInt(Math.Round(CDbl((clientRectangle.Width - Me.diago)) - CDbl(Me._thickness) / 2))
			Dim num7 As Integer = CInt(Math.Round(CDbl(clientRectangle.Width) - CDbl(Me._thickness) / 2))
			Dim point As System.Drawing.Point = New System.Drawing.Point(14, num)
			Dim point1 As System.Drawing.Point = New System.Drawing.Point(num5, num)
			graphicsPath.AddLine(point, point1)
			point1 = New System.Drawing.Point(num5, num)
			point = New System.Drawing.Point(num4, num1)
			graphicsPath.AddLine(point1, point)
			point1 = New System.Drawing.Point(num4, num1)
			point = New System.Drawing.Point(num4, num2)
			graphicsPath.AddLine(point1, point)
			point1 = New System.Drawing.Point(num4, num2)
			point = New System.Drawing.Point(num5, num3)
			graphicsPath.AddLine(point1, point)
			point1 = New System.Drawing.Point(num5, num3)
			point = New System.Drawing.Point(num6, num3)
			graphicsPath.AddLine(point1, point)
			point1 = New System.Drawing.Point(num6, num3)
			point = New System.Drawing.Point(num7, num2)
			graphicsPath.AddLine(point1, point)
			point1 = New System.Drawing.Point(num7, num2)
			point = New System.Drawing.Point(num7, num1)
			graphicsPath.AddLine(point1, point)
			point1 = New System.Drawing.Point(num7, num1)
			point = New System.Drawing.Point(num6, num)
			graphicsPath.AddLine(point1, point)
			point1 = New System.Drawing.Point(num6, num)
			point = New System.Drawing.Point(12 + size.Width, num)
			graphicsPath.AddLine(point1, point)
			e.Graphics.DrawPath(pen, graphicsPath)
			rectangle.X = rectangle.X + 14 + Module1.screenadaptX(6)
			rectangle.Width = size.Width
			rectangle.Height = size.Height
			e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), rectangle)
			e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.Titlecolor), rectangle)
			graphicsPath.Dispose()
			pen.Dispose()
		End Sub
	End Class
End Namespace