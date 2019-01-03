Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SVPLCApplication
	Public MustInherit Class TabStyleProvider
		Inherits Component
		Protected _TabControl As CustomTabControl

		Protected _Padding As Point

		Protected _HotTrack As Boolean

		Protected _Style As TabStyle

		Protected _ImageAlign As ContentAlignment

		Protected _Radius As Integer

		Protected _Overlap As Integer

		Protected _FocusTrack As Boolean

		Protected _Opacity As Single

		Protected _ShowTabCloser As Boolean

		Protected _BorderColorSelected As Color

		Protected _BorderColor As Color

		Protected _BorderColorHot As Color

		Protected _CloserColorActive As Color

		Protected _CloserColor As Color

		Protected _FocusColor As Color

		Protected _TextColor As Color

		Protected _TextColorSelected As Color

		Protected _TextColorDisabled As Color

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "")>
		Public Property BorderColor As Color
			Get
				If (Me._BorderColor.IsEmpty) Then
					Return SystemColors.ControlDark
				End If
				Return Me._BorderColor
			End Get
			Set(ByVal value As Color)
				If (Not value.Equals(SystemColors.ControlDark)) Then
					Me._BorderColor = value
				Else
					Me._BorderColor = Color.Empty
				End If
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "")>
		Public Property BorderColorHot As Color
			Get
				If (Me._BorderColorHot.IsEmpty) Then
					Return SystemColors.ControlDark
				End If
				Return Me._BorderColorHot
			End Get
			Set(ByVal value As Color)
				If (Not value.Equals(SystemColors.ControlDark)) Then
					Me._BorderColorHot = value
				Else
					Me._BorderColorHot = Color.Empty
				End If
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "")>
		Public Property BorderColorSelected As Color
			Get
				If (Me._BorderColorSelected.IsEmpty) Then
					Return ThemedColors.ToolBorder
				End If
				Return Me._BorderColorSelected
			End Get
			Set(ByVal value As Color)
				If (Not value.Equals(ThemedColors.ToolBorder)) Then
					Me._BorderColorSelected = value
				Else
					Me._BorderColorSelected = Color.Empty
				End If
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "DarkGrey")>
		Public Property CloserColor As Color
			Get
				Return Me._CloserColor
			End Get
			Set(ByVal value As Color)
				Me._CloserColor = value
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "Black")>
		Public Property CloserColorActive As Color
			Get
				Return Me._CloserColorActive
			End Get
			Set(ByVal value As Color)
				Me._CloserColorActive = value
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Property DisplayStyle As TabStyle
			Get
				Return Me._Style
			End Get
			Set(ByVal value As TabStyle)
				Me._Style = value
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "Orange")>
		Public Property FocusColor As Color
			Get
				Return Me._FocusColor
			End Get
			Set(ByVal value As Color)
				Me._FocusColor = value
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		Public Property FocusTrack As Boolean
			Get
				Return Me._FocusTrack
			End Get
			Set(ByVal value As Boolean)
				Me._FocusTrack = value
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		Public Property HotTrack As Boolean
			Get
				Return Me._HotTrack
			End Get
			Set(ByVal value As Boolean)
				Me._HotTrack = value
				Me._TabControl.HotTrack = value
			End Set
		End Property

		<Category("Appearance")>
		Public Property ImageAlign As ContentAlignment
			Get
				Return Me._ImageAlign
			End Get
			Set(ByVal value As ContentAlignment)
				Me._ImageAlign = value
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		Public Property Opacity As Single
			Get
				Return Me._Opacity
			End Get
			Set(ByVal value As Single)
				If (value < 0!) Then
					Throw New ArgumentException("The opacity must be between 0 and 1", "value")
				End If
				If (value > 1!) Then
					Throw New ArgumentException("The opacity must be between 0 and 1", "value")
				End If
				Me._Opacity = value
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		Public Property Overlap As Integer
			Get
				Return Me._Overlap
			End Get
			Set(ByVal value As Integer)
				If (value < 0) Then
					Throw New ArgumentException("The tabs cannot have a negative overlap", "value")
				End If
				Me._Overlap = value
			End Set
		End Property

		<Category("Appearance")>
		Public Property Padding As Point
			Get
				Return Me._Padding
			End Get
			Set(ByVal value As System.Drawing.Point)
				Dim point As System.Drawing.Point
				Me._Padding = value
				If (Me._ShowTabCloser) Then
					If (value.X + Me._Radius / 2 >= -6) Then
						Dim customTabControl As SVPLCApplication.CustomTabControl = Me._TabControl
						point = New System.Drawing.Point(value.X + Me._Radius / 2 + 6, value.Y)
						customTabControl.Padding = point
					Else
						Dim customTabControl1 As SVPLCApplication.CustomTabControl = Me._TabControl
						point = New System.Drawing.Point(0, value.Y)
						customTabControl1.Padding = point
					End If
				ElseIf (value.X + Me._Radius / 2 >= 1) Then
					Dim customTabControl2 As SVPLCApplication.CustomTabControl = Me._TabControl
					point = New System.Drawing.Point(value.X + Me._Radius / 2 - 1, value.Y)
					customTabControl2.Padding = point
				Else
					Dim customTabControl3 As SVPLCApplication.CustomTabControl = Me._TabControl
					point = New System.Drawing.Point(0, value.Y)
					customTabControl3.Padding = point
				End If
			End Set
		End Property

		<Browsable(True)>
		<Category("Appearance")>
		<DefaultValue(1)>
		Public Property Radius As Integer
			Get
				Return Me._Radius
			End Get
			Set(ByVal value As Integer)
				If (value < 1) Then
					Throw New ArgumentException("The radius must be greater than 1", "value")
				End If
				Me._Radius = value
				Me.Padding = Me._Padding
			End Set
		End Property

		<Category("Appearance")>
		Public Property ShowTabCloser As Boolean
			Get
				Return Me._ShowTabCloser
			End Get
			Set(ByVal value As Boolean)
				Me._ShowTabCloser = value
				Me.Padding = Me._Padding
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "")>
		Public Property TextColor As Color
			Get
				If (Me._TextColor.IsEmpty) Then
					Return SystemColors.ControlText
				End If
				Return Me._TextColor
			End Get
			Set(ByVal value As Color)
				If (Not value.Equals(SystemColors.ControlText)) Then
					Me._TextColor = value
				Else
					Me._TextColor = Color.Empty
				End If
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "")>
		Public Property TextColorDisabled As Color
			Get
				If (Me._TextColor.IsEmpty) Then
					Return SystemColors.ControlDark
				End If
				Return Me._TextColorDisabled
			End Get
			Set(ByVal value As Color)
				If (Not value.Equals(SystemColors.ControlDark)) Then
					Me._TextColorDisabled = value
				Else
					Me._TextColorDisabled = Color.Empty
				End If
				Me._TabControl.Invalidate()
			End Set
		End Property

		<Category("Appearance")>
		<DefaultValue(GetType(Color), "")>
		Public Property TextColorSelected As Color
			Get
				If (Me._TextColorSelected.IsEmpty) Then
					Return SystemColors.ControlText
				End If
				Return Me._TextColorSelected
			End Get
			Set(ByVal value As Color)
				If (Not value.Equals(SystemColors.ControlText)) Then
					Me._TextColorSelected = value
				Else
					Me._TextColorSelected = Color.Empty
				End If
				Me._TabControl.Invalidate()
			End Set
		End Property

		Protected Sub New(ByVal tabControl As CustomTabControl)
			MyBase.New()
			Me._Style = TabStyle.[Default]
			Me._Radius = 1
			Me._Opacity = 1!
			Me._BorderColorSelected = Color.Empty
			Me._BorderColor = Color.Empty
			Me._BorderColorHot = Color.Empty
			Me._CloserColorActive = Color.Black
			Me._CloserColor = Color.DarkGray
			Me._FocusColor = Color.Empty
			Me._TextColor = Color.Empty
			Me._TextColorSelected = Color.Empty
			Me._TextColorDisabled = Color.Empty
			Me._TabControl = tabControl
			Me._BorderColor = Color.Empty
			Me._BorderColorSelected = Color.Empty
			Me._FocusColor = Color.Orange
			If (Not Me._TabControl.RightToLeftLayout) Then
				Me._ImageAlign = ContentAlignment.MiddleLeft
			Else
				Me._ImageAlign = ContentAlignment.MiddleRight
			End If
			Me.HotTrack = True
			Me.Padding = New Point(6, 3)
		End Sub

		Public MustOverride Sub AddTabBorder(ByVal path As GraphicsPath, ByVal tabBounds As Rectangle)

		Public Shared Function CreateProvider(ByVal tabControl As CustomTabControl) As TabStyleProvider
			Dim tabStyleNoneProvider As TabStyleProvider
			Select Case tabControl.DisplayStyle
				Case TabStyle.None
					tabStyleNoneProvider = New SVPLCApplication.TabStyleNoneProvider(tabControl)
					Exit Select
				Case TabStyle.[Default]
					tabStyleNoneProvider = New TabStyleDefaultProvider(tabControl)
					Exit Select
				Case TabStyle.VisualStudio
					tabStyleNoneProvider = New TabStyleVisualStudioProvider(tabControl)
					Exit Select
				Case TabStyle.Rounded
					tabStyleNoneProvider = New TabStyleRoundedProvider(tabControl)
					Exit Select
				Case TabStyle.Angled
					tabStyleNoneProvider = New TabStyleAngledProvider(tabControl)
					Exit Select
				Case TabStyle.Chrome
					tabStyleNoneProvider = New TabStyleChromeProvider(tabControl)
					Exit Select
				Case TabStyle.IE8
					tabStyleNoneProvider = New TabStyleIE8Provider(tabControl)
					Exit Select
				Case TabStyle.VS2010
					tabStyleNoneProvider = New TabStyleVS2010Provider(tabControl)
					Exit Select
				Case Else
					tabStyleNoneProvider = New TabStyleDefaultProvider(tabControl)
					Exit Select
			End Select
			tabStyleNoneProvider._Style = tabControl.DisplayStyle
			Return tabStyleNoneProvider
		End Function

		Protected Overridable Sub DrawTabCloser(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			If (Me._ShowTabCloser) Then
				Dim tabCloserRect As Rectangle = Me._TabControl.GetTabCloserRect(index)
				graphics.SmoothingMode = SmoothingMode.AntiAlias
				Using closerPath As GraphicsPath = TabStyleProvider.GetCloserPath(tabCloserRect)
					If (Not tabCloserRect.Contains(Me._TabControl.MousePosition)) Then
						Using pen As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColor)
							graphics.DrawPath(pen, closerPath)
						End Using
					Else
						Using pen1 As System.Drawing.Pen = New System.Drawing.Pen(Me._CloserColorActive)
							graphics.DrawPath(pen1, closerPath)
						End Using
					End If
				End Using
			End If
		End Sub

		Private Sub DrawTabFocusIndicator(ByVal tabpath As GraphicsPath, ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			If (Me._FocusTrack AndAlso Me._TabControl.Focused AndAlso index = Me._TabControl.SelectedIndex) Then
				Dim linearGradientBrush As Brush = Nothing
				Dim bounds As RectangleF = tabpath.GetBounds()
				Dim empty As Rectangle = Rectangle.Empty
				Select Case Me._TabControl.Alignment
					Case TabAlignment.Top
						empty = New Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))), 4)
						linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(empty, Me._FocusColor, SystemColors.Window, LinearGradientMode.Vertical)
						Exit Select
					Case TabAlignment.Bottom
						empty = New Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))) - 4, CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))), 4)
						linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(empty, SystemColors.ControlLight, Me._FocusColor, LinearGradientMode.Vertical)
						Exit Select
					Case TabAlignment.Left
						empty = New Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))), 4, CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))))
						linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(empty, Me._FocusColor, SystemColors.ControlLight, LinearGradientMode.Horizontal)
						Exit Select
					Case TabAlignment.Right
						empty = New Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))) - 4, CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))), 4, CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))))
						linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(empty, SystemColors.ControlLight, Me._FocusColor, LinearGradientMode.Horizontal)
						Exit Select
				End Select
				Dim region As System.Drawing.Region = New System.Drawing.Region(empty)
				region.Intersect(tabpath)
				graphics.FillRegion(linearGradientBrush, region)
				region.Dispose()
				linearGradientBrush.Dispose()
			End If
		End Sub

		Protected Overridable Sub EnsureFirstTabIsInView(ByRef tabBounds As Rectangle, ByVal index As Integer)
			Dim pageBounds As Rectangle
			If (Me._TabControl.IsFirstTabInRow(index)) Then
				If (Me._TabControl.Alignment <= TabAlignment.Bottom) Then
					If (Me._TabControl.RightToLeftLayout) Then
						If (tabBounds.Left < Me._TabControl.Right) Then
							pageBounds = Me._TabControl.GetPageBounds(index)
							Dim right As Integer = pageBounds.Right
							If (tabBounds.Right > right) Then
								tabBounds.Width = tabBounds.Width - (tabBounds.Right - right)
							End If
						End If
					ElseIf (tabBounds.Right > 0) Then
						pageBounds = Me._TabControl.GetPageBounds(index)
						Dim x As Integer = pageBounds.X
						If (tabBounds.X < x) Then
							tabBounds.Width = tabBounds.Width - (x - tabBounds.X)
							tabBounds.X = x
						End If
					End If
				ElseIf (Me._TabControl.RightToLeftLayout) Then
					If (tabBounds.Top < Me._TabControl.Bottom) Then
						pageBounds = Me._TabControl.GetPageBounds(index)
						Dim bottom As Integer = pageBounds.Bottom
						If (tabBounds.Bottom > bottom) Then
							tabBounds.Height = tabBounds.Height - (tabBounds.Bottom - bottom)
						End If
					End If
				ElseIf (tabBounds.Bottom > 0) Then
					pageBounds = Me._TabControl.GetPageBounds(index)
					Dim y As Integer = pageBounds.Location.Y
					If (tabBounds.Y < y) Then
						tabBounds.Height = tabBounds.Height - (y - tabBounds.Y)
						tabBounds.Y = y
					End If
				End If
			End If
		End Sub

		Private Function GetBackgroundBlend() As Blend
			Dim singleArray() As Single = { 0!, 0.7!, 1! }
			Dim singleArray1 As Single() = singleArray
			singleArray = New Single() { 0!, 0.6!, 1! }
			Dim singleArray2 As Single() = singleArray
			If (Me._TabControl.Alignment = TabAlignment.Top) Then
				singleArray = New Single() { 0!, 0.5!, 1!, 1! }
				singleArray1 = singleArray
				singleArray = New Single() { 0!, 0.5!, 0.51!, 1! }
				singleArray2 = singleArray
			End If
			Return New Blend() With
			{
				.Factors = singleArray1,
				.Positions = singleArray2
			}
		End Function

		Protected Shared Function GetCloserPath(ByVal closerRect As Rectangle) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			graphicsPath.AddLine(closerRect.X, closerRect.Y, closerRect.Right, closerRect.Bottom)
			graphicsPath.CloseFigure()
			graphicsPath.AddLine(closerRect.Right, closerRect.Y, closerRect.X, closerRect.Bottom)
			graphicsPath.CloseFigure()
			Return graphicsPath
		End Function

		Public Overridable Function GetPageBackgroundBrush(ByVal index As Integer) As Brush
			Dim window As Color = Color.FromArgb(242, 242, 242)
			If (Me._TabControl.Alignment = TabAlignment.Top) Then
				window = Color.FromArgb(207, 207, 207)
			End If
			If (Me._TabControl.SelectedIndex = index) Then
				window = SystemColors.Window
			ElseIf (Not Me._TabControl.TabPages(index).Enabled) Then
				window = Color.FromArgb(207, 207, 207)
			ElseIf (Me._HotTrack AndAlso index = Me._TabControl.ActiveIndex) Then
				window = Color.FromArgb(234, 246, 253)
			End If
			Return New SolidBrush(window)
		End Function

		Protected Overridable Function GetTabBackgroundBrush(ByVal index As Integer) As Brush
			Dim linearGradientBrush As System.Drawing.Drawing2D.LinearGradientBrush = Nothing
			Dim controlLight As Color = Color.FromArgb(207, 207, 207)
			Dim window As Color = Color.FromArgb(242, 242, 242)
			If (Me._TabControl.SelectedIndex = index) Then
				controlLight = SystemColors.ControlLight
				window = SystemColors.Window
			ElseIf (Not Me._TabControl.TabPages(index).Enabled) Then
				window = controlLight
			ElseIf (Me._HotTrack AndAlso index = Me._TabControl.ActiveIndex) Then
				window = Color.FromArgb(234, 246, 253)
				controlLight = Color.FromArgb(167, 217, 245)
			End If
			Dim tabRect As Rectangle = Me.GetTabRect(index)
			tabRect.Inflate(3, 3)
			tabRect.X = tabRect.X - 1
			tabRect.Y = tabRect.Y - 1
			Select Case Me._TabControl.Alignment
				Case TabAlignment.Top
					If (Me._TabControl.SelectedIndex = index) Then
						controlLight = window
					End If
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, window, controlLight, LinearGradientMode.Vertical)
					Exit Select
				Case TabAlignment.Bottom
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, window, controlLight, LinearGradientMode.Vertical)
					Exit Select
				Case TabAlignment.Left
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, controlLight, window, LinearGradientMode.Horizontal)
					Exit Select
				Case TabAlignment.Right
					linearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(tabRect, window, controlLight, LinearGradientMode.Horizontal)
					Exit Select
			End Select
			linearGradientBrush.Blend = Me.GetBackgroundBlend()
			Return linearGradientBrush
		End Function

		Public Function GetTabBorder(ByVal index As Integer) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Me.AddTabBorder(graphicsPath, Me.GetTabRect(index))
			graphicsPath.CloseFigure()
			Return graphicsPath
		End Function

		Public Overridable Function GetTabRect(ByVal index As Integer) As Rectangle
			If (index < 0) Then
				Return New Rectangle()
			End If
			Dim tabRect As Rectangle = Me._TabControl.GetTabRect(index)
			If (Me._TabControl.RightToLeftLayout) Then
				tabRect.X = Me._TabControl.Width - tabRect.Right
			End If
			Dim flag As Boolean = Me._TabControl.IsFirstTabInRow(index)
			Select Case Me._TabControl.Alignment
				Case TabAlignment.Top
					tabRect.Height = tabRect.Height + 2
					Exit Select
				Case TabAlignment.Bottom
					tabRect.Height = tabRect.Height + 2
					tabRect.Y = tabRect.Y - 2
					Exit Select
				Case TabAlignment.Left
					tabRect.Width = tabRect.Width + 2
					Exit Select
				Case TabAlignment.Right
					tabRect.X = tabRect.X - 2
					tabRect.Width = tabRect.Width + 2
					Exit Select
			End Select
			If ((Not flag OrElse Me._TabControl.RightToLeftLayout) AndAlso Me._Overlap > 0) Then
				If (Me._TabControl.Alignment > TabAlignment.Bottom) Then
					tabRect.Y = tabRect.Y - Me._Overlap
					tabRect.Height = tabRect.Height + Me._Overlap
				Else
					tabRect.X = tabRect.X - Me._Overlap
					tabRect.Width = tabRect.Width + Me._Overlap
				End If
			End If
			Me.EnsureFirstTabIsInView(tabRect, index)
			Return tabRect
		End Function

		Public Sub PaintTab(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			Using tabBorder As GraphicsPath = Me.GetTabBorder(index)
				Using tabBackgroundBrush As Brush = Me.GetTabBackgroundBrush(index)
					graphics.FillPath(tabBackgroundBrush, tabBorder)
					If (Me._TabControl.Focused) Then
						Me.DrawTabFocusIndicator(tabBorder, index, graphics)
					End If
					Me.DrawTabCloser(index, graphics)
				End Using
			End Using
		End Sub
	End Class
End Namespace