Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SVPLCApplication
	<ToolboxItem(False)>
	Public Class TabStyleIE8Provider
		Inherits TabStyleRoundedProvider
		Public Sub New(ByVal tabControl As CustomTabControl)
			MyBase.New(tabControl)
			Me._Radius = 3
			Me._ShowTabCloser = True
			Me._CloserColorActive = Color.Red
			Me.Padding = New Point(6, 5)
		End Sub

		Protected Overrides Sub DrawTabCloser(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			If (Me._ShowTabCloser) Then
				Dim tabCloserRect As Rectangle = Me._TabControl.GetTabCloserRect(index)
				graphics.SmoothingMode = SmoothingMode.AntiAlias
				If (Not tabCloserRect.Contains(Me._TabControl.MousePosition)) Then
					Using closerPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
						Using pen As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColor)
							pen.Width = 2!
							graphics.DrawPath(pen, closerPath)
						End Using
					End Using
				Else
					Using closerButtonPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleIE8Provider.GetCloserButtonPath(tabCloserRect)
						graphics.FillPath(Brushes.White, closerButtonPath)
						Using pen1 As System.Drawing.Pen = New System.Drawing.Pen(Me.BorderColor)
							graphics.DrawPath(pen1, closerButtonPath)
						End Using
					End Using
					Using graphicsPath As System.Drawing.Drawing2D.GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
						Using pen2 As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColorActive)
							pen2.Width = 2!
							graphics.DrawPath(pen2, graphicsPath)
						End Using
					End Using
				End If
			End If
		End Sub

		Private Function GetBackgroundBlend(ByVal index As Integer) As Blend
			Dim singleArray() As Single = { 0!, 0.7!, 1! }
			Dim singleArray1 As Single() = singleArray
			singleArray = New Single() { 0!, 0.8!, 1! }
			Dim singleArray2 As Single() = singleArray
			If (Me._TabControl.SelectedIndex <> index) Then
				singleArray = New Single() { 0!, 0.3!, 1! }
				singleArray1 = singleArray
				singleArray = New Single() { 0!, 0.2!, 1! }
				singleArray2 = singleArray
			End If
			Return New Blend() With
			{
				.Factors = singleArray1,
				.Positions = singleArray2
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
			Dim window As Color = Color.FromArgb(227, 238, 251)
			If (Me._TabControl.SelectedIndex = index) Then
				window = SystemColors.Window
			ElseIf (Not Me._TabControl.TabPages(index).Enabled) Then
				window = Color.FromArgb(207, 207, 207)
			ElseIf (Me._HotTrack AndAlso index = Me._TabControl.ActiveIndex) Then
				window = Color.FromArgb(234, 246, 253)
			End If
			Return New SolidBrush(window)
		End Function

		Protected Overrides Function GetTabBackgroundBrush(ByVal index As Integer) As Brush
			Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = Nothing
			Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(227, 238, 251)
			Dim window As System.Drawing.Color = System.Drawing.Color.FromArgb(227, 238, 251)
			If (Me._TabControl.SelectedIndex = index) Then
				color = System.Drawing.Color.FromArgb(196, 222, 251)
				window = SystemColors.Window
			ElseIf (Not Me._TabControl.TabPages(index).Enabled) Then
				window = color
			ElseIf (Me.HotTrack AndAlso index = Me._TabControl.ActiveIndex) Then
				window = SystemColors.Window
				color = System.Drawing.Color.FromArgb(166, 203, 248)
			End If
			Dim tabRect As Rectangle = Me.GetTabRect(index)
			tabRect.Inflate(3, 3)
			tabRect.X = tabRect.X - 1
			tabRect.Y = tabRect.Y - 1
			Select Case Me._TabControl.Alignment
				Case TabAlignment.Top
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, color, window, LinearGradientMode.Vertical)
					Exit Select
				Case TabAlignment.Bottom
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, window, color, LinearGradientMode.Vertical)
					Exit Select
				Case TabAlignment.Left
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, color, window, LinearGradientMode.Horizontal)
					Exit Select
				Case TabAlignment.Right
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, window, color, LinearGradientMode.Horizontal)
					Exit Select
			End Select
			linearGradientBrush.Blend = Me.GetBackgroundBlend(index)
			Return linearGradientBrush
		End Function

		Public Overrides Function GetTabRect(ByVal index As Integer) As Rectangle
			If (index < 0) Then
				Return New Rectangle()
			End If
			Dim tabRect As Rectangle = MyBase.GetTabRect(index)
			Dim flag As Boolean = Me._TabControl.IsFirstTabInRow(index)
			If (index = Me._TabControl.SelectedIndex) Then
				Select Case Me._TabControl.Alignment
					Case TabAlignment.Top
						tabRect.Y = tabRect.Y - 1
						tabRect.Height = tabRect.Height + 1
						If (Not flag) Then
							tabRect.X = tabRect.X - 1
							tabRect.Width = tabRect.Width + 2
							Exit Select
						Else
							tabRect.Width = tabRect.Width + 1
							Exit Select
						End If
					Case TabAlignment.Bottom
						tabRect.Height = tabRect.Height + 1
						If (Not flag) Then
							tabRect.X = tabRect.X - 1
							tabRect.Width = tabRect.Width + 2
							Exit Select
						Else
							tabRect.Width = tabRect.Width + 1
							Exit Select
						End If
					Case TabAlignment.Left
						tabRect.X = tabRect.X - 1
						tabRect.Width = tabRect.Width + 1
						If (Not flag) Then
							tabRect.Y = tabRect.Y - 1
							tabRect.Height = tabRect.Height + 2
							Exit Select
						Else
							tabRect.Height = tabRect.Height + 1
							Exit Select
						End If
					Case TabAlignment.Right
						tabRect.Width = tabRect.Width + 1
						If (Not flag) Then
							tabRect.Y = tabRect.Y - 1
							tabRect.Height = tabRect.Height + 2
							Exit Select
						Else
							tabRect.Height = tabRect.Height + 1
							Exit Select
						End If
				End Select
			Else
				Select Case Me._TabControl.Alignment
					Case TabAlignment.Top
						tabRect.Y = tabRect.Y + 1
						tabRect.Height = tabRect.Height - 1
						Exit Select
					Case TabAlignment.Bottom
						tabRect.Height = tabRect.Height - 1
						Exit Select
					Case TabAlignment.Left
						tabRect.X = tabRect.X + 1
						tabRect.Width = tabRect.Width - 1
						Exit Select
					Case TabAlignment.Right
						tabRect.Width = tabRect.Width - 1
						Exit Select
				End Select
			End If
			Me.EnsureFirstTabIsInView(tabRect, index)
			Return tabRect
		End Function
	End Class
End Namespace