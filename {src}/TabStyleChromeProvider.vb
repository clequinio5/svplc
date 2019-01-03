Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SVPLCApplication
	Public Class TabStyleChromeProvider
		Inherits TabStyleProvider
		Public Sub New(ByVal tabControl As CustomTabControl)
			MyBase.New(tabControl)
			Me._Overlap = 16
			Me._Radius = 16
			Me._ShowTabCloser = True
			Me._CloserColorActive = Color.White
			Me.Padding = New Point(7, 5)
		End Sub

		Public Overrides Sub AddTabBorder(ByVal path As GraphicsPath, ByVal tabBounds As Rectangle)
			Dim num As Integer
			Dim num1 As Integer
			Dim num2 As Integer
			Dim num3 As Integer
			Dim point As System.Drawing.Point
			Dim point1 As System.Drawing.Point
			Dim point2 As System.Drawing.Point
			Dim point3 As System.Drawing.Point
			Dim pointArray As System.Drawing.Point()
			If (Me._TabControl.Alignment > TabAlignment.Bottom) Then
				num3 = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Width), New Decimal(CLng(2))), New Decimal(CLng(3))))))
				num = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Width), Decimal.One), New Decimal(CLng(8))))))
				num2 = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Width), Decimal.One), New Decimal(CLng(6))))))
				num1 = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Width), Decimal.One), New Decimal(CLng(4))))))
			Else
				num3 = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Height), New Decimal(CLng(2))), New Decimal(CLng(3))))))
				num = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Height), Decimal.One), New Decimal(CLng(8))))))
				num2 = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Height), Decimal.One), New Decimal(CLng(6))))))
				num1 = Convert.ToInt32(Math.Truncate(Math.Floor(Decimal.Divide(Decimal.Multiply(New Decimal(tabBounds.Height), Decimal.One), New Decimal(CLng(4))))))
			End If
			Select Case Me._TabControl.Alignment
				Case TabAlignment.Top
					ReDim pointArray(3)
					point = New System.Drawing.Point(tabBounds.X, tabBounds.Bottom)
					pointArray(0) = point
					point1 = New System.Drawing.Point(tabBounds.X + num2, tabBounds.Bottom - num)
					pointArray(1) = point1
					point2 = New System.Drawing.Point(tabBounds.X + num3 - num1, tabBounds.Y + num)
					pointArray(2) = point2
					point3 = New System.Drawing.Point(tabBounds.X + num3, tabBounds.Y)
					pointArray(3) = point3
					path.AddCurve(pointArray)
					path.AddLine(tabBounds.X + num3, tabBounds.Y, tabBounds.Right - num3, tabBounds.Y)
					ReDim pointArray(3)
					point3 = New System.Drawing.Point(tabBounds.Right - num3, tabBounds.Y)
					pointArray(0) = point3
					point2 = New System.Drawing.Point(tabBounds.Right - num3 + num1, tabBounds.Y + num)
					pointArray(1) = point2
					point1 = New System.Drawing.Point(tabBounds.Right - num2, tabBounds.Bottom - num)
					pointArray(2) = point1
					point = New System.Drawing.Point(tabBounds.Right, tabBounds.Bottom)
					pointArray(3) = point
					path.AddCurve(pointArray)
					Exit Select
				Case TabAlignment.Bottom
					ReDim pointArray(3)
					point3 = New System.Drawing.Point(tabBounds.Right, tabBounds.Y)
					pointArray(0) = point3
					point2 = New System.Drawing.Point(tabBounds.Right - num2, tabBounds.Y + num)
					pointArray(1) = point2
					point1 = New System.Drawing.Point(tabBounds.Right - num3 + num1, tabBounds.Bottom - num)
					pointArray(2) = point1
					point = New System.Drawing.Point(tabBounds.Right - num3, tabBounds.Bottom)
					pointArray(3) = point
					path.AddCurve(pointArray)
					path.AddLine(tabBounds.Right - num3, tabBounds.Bottom, tabBounds.X + num3, tabBounds.Bottom)
					ReDim pointArray(3)
					point3 = New System.Drawing.Point(tabBounds.X + num3, tabBounds.Bottom)
					pointArray(0) = point3
					point2 = New System.Drawing.Point(tabBounds.X + num3 - num1, tabBounds.Bottom - num)
					pointArray(1) = point2
					point1 = New System.Drawing.Point(tabBounds.X + num2, tabBounds.Y + num)
					pointArray(2) = point1
					point = New System.Drawing.Point(tabBounds.X, tabBounds.Y)
					pointArray(3) = point
					path.AddCurve(pointArray)
					Exit Select
				Case TabAlignment.Left
					ReDim pointArray(3)
					point3 = New System.Drawing.Point(tabBounds.Right, tabBounds.Bottom)
					pointArray(0) = point3
					point2 = New System.Drawing.Point(tabBounds.Right - num, tabBounds.Bottom - num2)
					pointArray(1) = point2
					point1 = New System.Drawing.Point(tabBounds.X + num, tabBounds.Bottom - num3 + num1)
					pointArray(2) = point1
					point = New System.Drawing.Point(tabBounds.X, tabBounds.Bottom - num3)
					pointArray(3) = point
					path.AddCurve(pointArray)
					path.AddLine(tabBounds.X, tabBounds.Bottom - num3, tabBounds.X, tabBounds.Y + num3)
					ReDim pointArray(3)
					point3 = New System.Drawing.Point(tabBounds.X, tabBounds.Y + num3)
					pointArray(0) = point3
					point2 = New System.Drawing.Point(tabBounds.X + num, tabBounds.Y + num3 - num1)
					pointArray(1) = point2
					point1 = New System.Drawing.Point(tabBounds.Right - num, tabBounds.Y + num2)
					pointArray(2) = point1
					point = New System.Drawing.Point(tabBounds.Right, tabBounds.Y)
					pointArray(3) = point
					path.AddCurve(pointArray)
					Exit Select
				Case TabAlignment.Right
					ReDim pointArray(3)
					point3 = New System.Drawing.Point(tabBounds.X, tabBounds.Y)
					pointArray(0) = point3
					point2 = New System.Drawing.Point(tabBounds.X + num, tabBounds.Y + num2)
					pointArray(1) = point2
					point1 = New System.Drawing.Point(tabBounds.Right - num, tabBounds.Y + num3 - num1)
					pointArray(2) = point1
					point = New System.Drawing.Point(tabBounds.Right, tabBounds.Y + num3)
					pointArray(3) = point
					path.AddCurve(pointArray)
					path.AddLine(tabBounds.Right, tabBounds.Y + num3, tabBounds.Right, tabBounds.Bottom - num3)
					ReDim pointArray(3)
					point3 = New System.Drawing.Point(tabBounds.Right, tabBounds.Bottom - num3)
					pointArray(0) = point3
					point2 = New System.Drawing.Point(tabBounds.Right - num, tabBounds.Bottom - num3 + num1)
					pointArray(1) = point2
					point1 = New System.Drawing.Point(tabBounds.X + num, tabBounds.Bottom - num2)
					pointArray(2) = point1
					point = New System.Drawing.Point(tabBounds.X, tabBounds.Bottom)
					pointArray(3) = point
					path.AddCurve(pointArray)
					Exit Select
			End Select
		End Sub

		Protected Overrides Sub DrawTabCloser(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			If (Me._ShowTabCloser) Then
				Dim tabCloserRect As Rectangle = Me._TabControl.GetTabCloserRect(index)
				graphics.SmoothingMode = SmoothingMode.AntiAlias
				If (Not tabCloserRect.Contains(Me._TabControl.MousePosition)) Then
					Using closerPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
						Using pen As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColor)
							graphics.DrawPath(pen, closerPath)
						End Using
					End Using
				Else
					Using closerButtonPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleChromeProvider.GetCloserButtonPath(tabCloserRect)
						Using solidBrush As System.Drawing.SolidBrush = New System.Drawing.SolidBrush(Color.FromArgb(193, 53, 53))
							graphics.FillPath(solidBrush, closerButtonPath)
						End Using
					End Using
					Using graphicsPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
						Using pen1 As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColorActive)
							graphics.DrawPath(pen1, graphicsPath)
						End Using
					End Using
				End If
			End If
		End Sub

		Private Shared Function GetCloserButtonPath(ByVal closerRect As System.Drawing.Rectangle) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(closerRect.X - 2, closerRect.Y - 2, closerRect.Width + 4, closerRect.Height + 4)
			graphicsPath.AddEllipse(rectangle)
			graphicsPath.CloseFigure()
			Return graphicsPath
		End Function
	End Class
End Namespace