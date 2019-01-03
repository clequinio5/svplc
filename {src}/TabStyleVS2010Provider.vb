Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SVPLCApplication
	Public Class TabStyleVS2010Provider
		Inherits TabStyleRoundedProvider
		Public Sub New(ByVal tabControl As CustomTabControl)
			MyBase.New(tabControl)
			Me._Radius = 3
			Me._ShowTabCloser = True
			Me._CloserColorActive = Color.Black
			Me._CloserColor = Color.FromArgb(117, 99, 61)
			Me._TextColor = Color.White
			Me._TextColorDisabled = Color.WhiteSmoke
			Me._BorderColor = Color.Transparent
			Me._BorderColorHot = Color.FromArgb(155, 167, 183)
			Me.Padding = New Point(6, 5)
		End Sub

		Protected Overrides Sub DrawTabCloser(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			If (Me._ShowTabCloser) Then
				Dim tabCloserRect As Rectangle = Me._TabControl.GetTabCloserRect(index)
				graphics.SmoothingMode = SmoothingMode.AntiAlias
				If (tabCloserRect.Contains(Me._TabControl.MousePosition)) Then
					Using closerButtonPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleVS2010Provider.GetCloserButtonPath(tabCloserRect)
						graphics.FillPath(Brushes.White, closerButtonPath)
						Using pen As System.Drawing.Pen = New System.Drawing.Pen(Color.FromArgb(229, 195, 101))
							graphics.DrawPath(pen, closerButtonPath)
						End Using
					End Using
					Using closerPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
						Using pen1 As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColorActive)
							pen1.Width = 2!
							graphics.DrawPath(pen1, closerPath)
						End Using
					End Using
				ElseIf (index = Me._TabControl.SelectedIndex) Then
					Using graphicsPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
						Using pen2 As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColor)
							pen2.Width = 2!
							graphics.DrawPath(pen2, graphicsPath)
						End Using
					End Using
				ElseIf (index = Me._TabControl.ActiveIndex) Then
					Using closerPath1 As System.Drawing.Drawing2D.GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
						Using pen3 As System.Drawing.Pen = New System.Drawing.Pen(Color.FromArgb(155, 167, 183))
							pen3.Width = 2!
							graphics.DrawPath(pen3, closerPath1)
						End Using
					End Using
				End If
			End If
		End Sub

		Private Shared Function GetBackgroundBlend() As Blend
			Dim singleArray() As Single = { 0!, 0.5!, 1!, 1! }
			Dim singleArray1 As Single() = singleArray
			singleArray = New Single() { 0!, 0.5!, 0.51!, 1! }
			Return New Blend() With
			{
				.Factors = singleArray1,
				.Positions = singleArray
			}
		End Function

		Private Shared Function GetCloserButtonPath(ByVal closerRect As Rectangle) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			graphicsPath.AddLine(closerRect.X - 1, closerRect.Y - 2, closerRect.Right + 1, closerRect.Y - 2)
			graphicsPath.AddLine(closerRect.Right + 2, closerRect.Y - 1, closerRect.Right + 2, closerRect.Bottom + 1)
			graphicsPath.AddLine(closerRect.Right + 1, closerRect.Bottom + 2, closerRect.X - 1, closerRect.Bottom + 2)
			graphicsPath.AddLine(closerRect.X - 2, closerRect.Bottom + 1, closerRect.X - 2, closerRect.Y - 1)
			graphicsPath.CloseFigure()
			Return graphicsPath
		End Function

		Public Overrides Function GetPageBackgroundBrush(ByVal index As Integer) As Brush
			Dim transparent As Color = Color.Transparent
			If (Me._TabControl.SelectedIndex = index) Then
				transparent = Color.FromArgb(229, 195, 101)
			ElseIf (Not Me._TabControl.TabPages(index).Enabled) Then
				transparent = Color.Transparent
			ElseIf (Me._HotTrack AndAlso index = Me._TabControl.ActiveIndex) Then
				transparent = Color.Transparent
			End If
			Return New SolidBrush(transparent)
		End Function

		Protected Overrides Function GetTabBackgroundBrush(ByVal index As Integer) As Brush
			Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = Nothing
			Dim transparent As Color = Color.Transparent
			Dim window As Color = Color.Transparent
			If (Me._TabControl.SelectedIndex = index) Then
				transparent = Color.FromArgb(229, 195, 101)
				window = SystemColors.Window
			ElseIf (Not Me._TabControl.TabPages(index).Enabled) Then
				window = transparent
			ElseIf (Me.HotTrack AndAlso index = Me._TabControl.ActiveIndex) Then
				transparent = Color.FromArgb(108, 116, 118)
				window = transparent
			End If
			Dim tabRect As Rectangle = Me.GetTabRect(index)
			tabRect.Inflate(3, 3)
			tabRect.X = tabRect.X - 1
			tabRect.Y = tabRect.Y - 1
			Select Case Me._TabControl.Alignment
				Case TabAlignment.Top
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, window, transparent, LinearGradientMode.Vertical)
					Exit Select
				Case TabAlignment.Bottom
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, transparent, window, LinearGradientMode.Vertical)
					Exit Select
				Case TabAlignment.Left
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, window, transparent, LinearGradientMode.Horizontal)
					Exit Select
				Case TabAlignment.Right
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, transparent, window, LinearGradientMode.Horizontal)
					Exit Select
			End Select
			linearGradientBrush.Blend = TabStyleVS2010Provider.GetBackgroundBlend()
			Return linearGradientBrush
		End Function
	End Class
End Namespace