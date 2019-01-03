Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SVPLCApplication
	Public Class CustomTabControl
		Inherits TabControl
		Private _BackImage As Bitmap

		Private _BackBuffer As Bitmap

		Private _BackBufferGraphics As Graphics

		Private _TabBuffer As Bitmap

		Private _TabBufferGraphics As Graphics

		Private _oldValue As Integer

		Private _dragStartPosition As Point

		Private _Style As TabStyle

		Private _StyleProvider As TabStyleProvider

		Private _TabPages As List(Of TabPage)

		Private _lastClipRect As Rectangle

		Public ReadOnly Property ActiveIndex As Integer
			Get
				Dim tCHITTESTINFO As SVPLCApplication.NativeMethods.TCHITTESTINFO = New SVPLCApplication.NativeMethods.TCHITTESTINFO(Me.PointToClient(Control.MousePosition))
				Dim intPtr As System.IntPtr = SVPLCApplication.NativeMethods.SendMessage(Me.Handle, 4877, System.IntPtr.Zero, SVPLCApplication.NativeMethods.ToIntPtr(tCHITTESTINFO))
				Dim num As Integer = intPtr.ToInt32()
				If (num = -1) Then
					Return -1
				End If
				If (Me.TabPages(num).Enabled) Then
					Return num
				End If
				Return -1
			End Get
		End Property

		Public ReadOnly Property ActiveTab As TabPage
			Get
				Dim activeIndex As Integer = Me.ActiveIndex
				If (activeIndex <= -1) Then
					Return Nothing
				End If
				Return Me.TabPages(activeIndex)
			End Get
		End Property

		Public Shadows Property Alignment As TabAlignment
			Get
				Return MyBase.Alignment
			End Get
			Set(ByVal value As TabAlignment)
				MyBase.Alignment = value
				Select Case value
					Case TabAlignment.Top
					Case TabAlignment.Bottom
						Me.Multiline = False
						Exit Select
					Case TabAlignment.Left
					Case TabAlignment.Right
						Me.Multiline = True
						Exit Select
				End Select
			End Set
		End Property

		Public Shadows Property Appearance As TabAppearance
			Get
				Return MyBase.Appearance
			End Get
			Set(ByVal value As TabAppearance)
				MyBase.Appearance = TabAppearance.Normal
			End Set
		End Property

		Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
			Get
				Dim exStyle As System.Windows.Forms.CreateParams = MyBase.CreateParams
				If (Me.RightToLeftLayout) Then
					exStyle.ExStyle = exStyle.ExStyle Or 4194304 Or 1048576
				End If
				Return exStyle
			End Get
		End Property

		Public Overrides ReadOnly Property DisplayRectangle As Rectangle
			Get
				If (Me._Style = TabStyle.None) Then
					Return New System.Drawing.Rectangle(0, 0, Me.Width, Me.Height)
				End If
				Dim rowCount As Integer = 0
				Dim num As Integer = 0
				num = If(Me.Alignment > TabAlignment.Bottom, Me.ItemSize.Width, Me.ItemSize.Height)
				rowCount = 5 + num * Me.RowCount
				Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(4, rowCount, Me.Width - 8, Me.Height - rowCount - 4)
				Select Case Me.Alignment
					Case TabAlignment.Top
						rectangle = New System.Drawing.Rectangle(4, rowCount, Me.Width - 8, Me.Height - rowCount - 4)
						Exit Select
					Case TabAlignment.Bottom
						rectangle = New System.Drawing.Rectangle(4, 4, Me.Width - 8, Me.Height - rowCount - 4)
						Exit Select
					Case TabAlignment.Left
						rectangle = New System.Drawing.Rectangle(rowCount, 4, Me.Width - rowCount - 4, Me.Height - 8)
						Exit Select
					Case TabAlignment.Right
						rectangle = New System.Drawing.Rectangle(4, 4, Me.Width - rowCount - 4, Me.Height - 8)
						Exit Select
				End Select
				Return rectangle
			End Get
		End Property

		Public Property DisplayStyle As TabStyle
			Get
				Return Me._Style
			End Get
			Set(ByVal value As TabStyle)
				If (Me._Style <> value) Then
					Me._Style = value
					Me._StyleProvider = TabStyleProvider.CreateProvider(Me)
					Me.Invalidate()
				End If
			End Set
		End Property

		Public Property DisplayStyleProvider As TabStyleProvider
			Get
				If (Me._StyleProvider Is Nothing) Then
					Me.DisplayStyle = TabStyle.[Default]
				End If
				Return Me._StyleProvider
			End Get
			Set(ByVal value As TabStyleProvider)
				Me._StyleProvider = value
			End Set
		End Property

		Public Shadows Property HotTrack As Boolean
			Get
				Return Me.DisplayStyleProvider.HotTrack
			End Get
			Set(ByVal value As Boolean)
				Me.DisplayStyleProvider.HotTrack = value
			End Set
		End Property

		Public Shadows ReadOnly Property MousePosition As Point
			Get
				Dim client As Point = Me.PointToClient(Control.MousePosition)
				If (Me.RightToLeftLayout) Then
					client.X = Me.Width - client.X
				End If
				Return client
			End Get
		End Property

		Public Shadows Property Multiline As Boolean
			Get
				Return MyBase.Multiline
			End Get
			Set(ByVal value As Boolean)
				MyBase.Multiline = value
				Me.Invalidate()
			End Set
		End Property

		Public Shadows Property Padding As Point
			Get
				Return Me.DisplayStyleProvider.Padding
			End Get
			Set(ByVal value As Point)
				Me.DisplayStyleProvider.Padding = value
			End Set
		End Property

		Public Overrides Property RightToLeftLayout As Boolean
			Get
				Return MyBase.RightToLeftLayout
			End Get
			Set(ByVal value As Boolean)
				MyBase.RightToLeftLayout = value
				Me.UpdateStyles()
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me._dragStartPosition = Point.Empty
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.Opaque Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint, True)
			Me._BackBuffer = New Bitmap(Me.Width, Me.Height)
			Me._BackBufferGraphics = Graphics.FromImage(Me._BackBuffer)
			Me._TabBuffer = New Bitmap(Me.Width, Me.Height)
			Me._TabBufferGraphics = Graphics.FromImage(Me._TabBuffer)
			Me.DisplayStyle = TabStyle.[Default]
		End Sub

		Private Sub AddPageBorder(ByVal path As GraphicsPath, ByVal pageBounds As Rectangle, ByVal tabBounds As Rectangle)
			Select Case Me.Alignment
				Case TabAlignment.Top
					path.AddLine(tabBounds.Right, pageBounds.Y, pageBounds.Right, pageBounds.Y)
					path.AddLine(pageBounds.Right, pageBounds.Y, pageBounds.Right, pageBounds.Bottom)
					path.AddLine(pageBounds.Right, pageBounds.Bottom, pageBounds.X, pageBounds.Bottom)
					path.AddLine(pageBounds.X, pageBounds.Bottom, pageBounds.X, pageBounds.Y)
					path.AddLine(pageBounds.X, pageBounds.Y, tabBounds.X, pageBounds.Y)
					Exit Select
				Case TabAlignment.Bottom
					path.AddLine(tabBounds.X, pageBounds.Bottom, pageBounds.X, pageBounds.Bottom)
					path.AddLine(pageBounds.X, pageBounds.Bottom, pageBounds.X, pageBounds.Y)
					path.AddLine(pageBounds.X, pageBounds.Y, pageBounds.Right, pageBounds.Y)
					path.AddLine(pageBounds.Right, pageBounds.Y, pageBounds.Right, pageBounds.Bottom)
					path.AddLine(pageBounds.Right, pageBounds.Bottom, tabBounds.Right, pageBounds.Bottom)
					Exit Select
				Case TabAlignment.Left
					path.AddLine(pageBounds.X, tabBounds.Y, pageBounds.X, pageBounds.Y)
					path.AddLine(pageBounds.X, pageBounds.Y, pageBounds.Right, pageBounds.Y)
					path.AddLine(pageBounds.Right, pageBounds.Y, pageBounds.Right, pageBounds.Bottom)
					path.AddLine(pageBounds.Right, pageBounds.Bottom, pageBounds.X, pageBounds.Bottom)
					path.AddLine(pageBounds.X, pageBounds.Bottom, pageBounds.X, tabBounds.Bottom)
					Exit Select
				Case TabAlignment.Right
					path.AddLine(pageBounds.Right, tabBounds.Bottom, pageBounds.Right, pageBounds.Bottom)
					path.AddLine(pageBounds.Right, pageBounds.Bottom, pageBounds.X, pageBounds.Bottom)
					path.AddLine(pageBounds.X, pageBounds.Bottom, pageBounds.X, pageBounds.Y)
					path.AddLine(pageBounds.X, pageBounds.Y, pageBounds.Right, pageBounds.Y)
					path.AddLine(pageBounds.Right, pageBounds.Y, pageBounds.Right, tabBounds.Y)
					Exit Select
			End Select
		End Sub

		Private Sub BackupTabPages()
			Dim enumerator As IEnumerator = Nothing
			If (Me._TabPages Is Nothing) Then
				Me._TabPages = New List(Of TabPage)()
				Try
					enumerator = Me.TabPages.GetEnumerator()
					While enumerator.MoveNext()
						Dim current As TabPage = DirectCast(enumerator.Current, TabPage)
						Me._TabPages.Add(current)
					End While
				Finally
					If (TypeOf enumerator Is IDisposable) Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		Private Sub CustomPaint(ByVal screenGraphics As Graphics)
			Dim clientRectangle As Rectangle
			If (Me.Width > 0 AndAlso Me.Height > 0) Then
				If (Me._BackImage Is Nothing) Then
					Me._BackImage = New System.Drawing.Bitmap(Me.Width, Me.Height)
					Dim graphic As Graphics = Graphics.FromImage(Me._BackImage)
					graphic.Clear(Color.Transparent)
					Me.PaintTransparentBackground(graphic, Me.ClientRectangle)
				End If
				Me._BackBufferGraphics.Clear(Color.Transparent)
				Me._BackBufferGraphics.DrawImageUnscaled(Me._BackImage, 0, 0)
				Me._TabBufferGraphics.Clear(Color.Transparent)
				If (Me.TabCount > 0) Then
					If (Me.Alignment <= TabAlignment.Bottom AndAlso Not Me.Multiline) Then
						Dim region As Graphics = Me._TabBufferGraphics
						Dim x As Single = CSng((Me.ClientRectangle.X + 3))
						Dim y As Single = CSng(Me.ClientRectangle.Y)
						Dim width As Single = CSng((Me.ClientRectangle.Width - 6))
						clientRectangle = Me.ClientRectangle
						Dim rectangleF As System.Drawing.RectangleF = New System.Drawing.RectangleF(x, y, width, CSng(clientRectangle.Height))
						region.Clip = New System.Drawing.Region(rectangleF)
					End If
					If (Not Me.Multiline) Then
						For i As Integer = Me.TabCount - 1 To 0 Step -1
							If (i <> Me.SelectedIndex) Then
								Me.DrawTabPage(i, Me._TabBufferGraphics)
							End If
						Next

					Else
						Dim rowCount As Integer = Me.RowCount - 1
						For j As Integer = 0 To rowCount Step 1
							For k As Integer = Me.TabCount - 1 To 0 Step -1
								If (k <> Me.SelectedIndex AndAlso (Me.RowCount = 1 OrElse Me.GetTabRow(k) = j)) Then
									Me.DrawTabPage(k, Me._TabBufferGraphics)
								End If
							Next

						Next

					End If
					If (Me.SelectedIndex > -1) Then
						Me.DrawTabPage(Me.SelectedIndex, Me._TabBufferGraphics)
					End If
				End If
				Me._TabBufferGraphics.Flush()
				Dim colorMatrix As System.Drawing.Imaging.ColorMatrix = New System.Drawing.Imaging.ColorMatrix()
				Dim colorMatrix1 As System.Drawing.Imaging.ColorMatrix = colorMatrix
				Dim matrix11 As Single = colorMatrix1.Matrix11
				Dim colorMatrix2 As System.Drawing.Imaging.ColorMatrix = colorMatrix
				Dim matrix22 As Single = colorMatrix2.Matrix22
				Dim colorMatrix3 As System.Drawing.Imaging.ColorMatrix = colorMatrix
				Dim matrix44 As Single = colorMatrix3.Matrix44
				Dim [single] As Single = CustomTabControl.InlineAssignHelper(Of Single)(matrix44, 1!)
				colorMatrix3.Matrix44 = matrix44
				Dim single1 As Single = CustomTabControl.InlineAssignHelper(Of Single)(matrix22, [single])
				colorMatrix2.Matrix22 = matrix22
				Dim single2 As Single = CustomTabControl.InlineAssignHelper(Of Single)(matrix11, single1)
				colorMatrix1.Matrix11 = matrix11
				colorMatrix.Matrix00 = single2
				colorMatrix.Matrix33 = Me._StyleProvider.Opacity
				Using imageAttribute As ImageAttributes = New ImageAttributes()
					imageAttribute.SetColorMatrix(colorMatrix)
					Dim graphic1 As Graphics = Me._BackBufferGraphics
					Dim bitmap As System.Drawing.Bitmap = Me._TabBuffer
					clientRectangle = New Rectangle(0, 0, Me._TabBuffer.Width, Me._TabBuffer.Height)
					graphic1.DrawImage(bitmap, clientRectangle, 0, 0, Me._TabBuffer.Width, Me._TabBuffer.Height, GraphicsUnit.Pixel, imageAttribute)
				End Using
				Me._BackBufferGraphics.Flush()
				If (Not Me.RightToLeftLayout) Then
					screenGraphics.DrawImageUnscaled(Me._BackBuffer, 0, 0)
				Else
					screenGraphics.DrawImageUnscaled(Me._BackBuffer, -1, 0)
				End If
			End If
		End Sub

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			MyBase.Dispose(disposing)
			If (disposing) Then
				If (Me._BackImage IsNot Nothing) Then
					Me._BackImage.Dispose()
				End If
				If (Me._BackBufferGraphics IsNot Nothing) Then
					Me._BackBufferGraphics.Dispose()
				End If
				If (Me._BackBuffer IsNot Nothing) Then
					Me._BackBuffer.Dispose()
				End If
				If (Me._TabBufferGraphics IsNot Nothing) Then
					Me._TabBufferGraphics.Dispose()
				End If
				If (Me._TabBuffer IsNot Nothing) Then
					Me._TabBuffer.Dispose()
				End If
				If (Me._StyleProvider IsNot Nothing) Then
					Me._StyleProvider.Dispose()
				End If
			End If
		End Sub

		Private Sub DrawTabBorder(ByVal path As GraphicsPath, ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			Dim borderColorSelected As Color
			graphics.SmoothingMode = SmoothingMode.HighQuality
			If (index <> Me.SelectedIndex) Then
				borderColorSelected = If(Not Me._StyleProvider.HotTrack OrElse index <> Me.ActiveIndex, Me._StyleProvider.BorderColor, Me._StyleProvider.BorderColorHot)
			Else
				borderColorSelected = Me._StyleProvider.BorderColorSelected
			End If
			Using pen As System.Drawing.Pen = New System.Drawing.Pen(borderColorSelected)
				graphics.DrawPath(pen, path)
			End Using
		End Sub

		Private Sub DrawTabImage(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			Dim item As Image = Nothing
			If (Me.TabPages(index).ImageIndex > -1 AndAlso Me.ImageList IsNot Nothing AndAlso Me.ImageList.Images.Count > Me.TabPages(index).ImageIndex) Then
				item = Me.ImageList.Images(Me.TabPages(index).ImageIndex)
			ElseIf (Not String.IsNullOrEmpty(Me.TabPages(index).ImageKey) AndAlso Not Me.TabPages(index).ImageKey.Equals("(none)", StringComparison.OrdinalIgnoreCase) AndAlso Me.ImageList IsNot Nothing AndAlso Me.ImageList.Images.ContainsKey(Me.TabPages(index).ImageKey)) Then
				item = Me.ImageList.Images(Me.TabPages(index).ImageKey)
			End If
			If (item IsNot Nothing) Then
				If (Me.RightToLeftLayout) Then
					item.RotateFlip(RotateFlipType.RotateNoneFlipX)
				End If
				Dim tabImageRect As Rectangle = Me.GetTabImageRect(index)
				If (Not Me.TabPages(index).Enabled) Then
					ControlPaint.DrawImageDisabled(graphics, item, tabImageRect.X, tabImageRect.Y, Color.Transparent)
				Else
					graphics.DrawImage(item, tabImageRect)
				End If
			End If
		End Sub

		Private Sub DrawTabPage(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			graphics.SmoothingMode = SmoothingMode.HighSpeed
			Using tabPageBorder As GraphicsPath = Me.GetTabPageBorder(index)
				Using pageBackgroundBrush As Brush = Me._StyleProvider.GetPageBackgroundBrush(index)
					graphics.FillPath(pageBackgroundBrush, tabPageBorder)
				End Using
				If (Me._Style <> TabStyle.None) Then
					Me._StyleProvider.PaintTab(index, graphics)
					Me.DrawTabImage(index, graphics)
					Me.DrawTabText(index, graphics)
				End If
				Me.DrawTabBorder(tabPageBorder, index, graphics)
			End Using
		End Sub

		Private Sub DrawTabText(ByVal index As Integer, ByVal graphics As System.Drawing.Graphics)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			Dim tabTextRect As Rectangle = Me.GetTabTextRect(index)
			If (Me.SelectedIndex = index) Then
				Using solidBrush As System.Drawing.Brush = New System.Drawing.SolidBrush(Me._StyleProvider.TextColorSelected)
					graphics.DrawString(Me.TabPages(index).Text, Me.Font, solidBrush, tabTextRect, Me.GetStringFormat())
				End Using
			ElseIf (Not Me.TabPages(index).Enabled) Then
				Using brush As System.Drawing.Brush = New System.Drawing.SolidBrush(Me._StyleProvider.TextColorDisabled)
					graphics.DrawString(Me.TabPages(index).Text, Me.Font, brush, tabTextRect, Me.GetStringFormat())
				End Using
			Else
				Using solidBrush1 As System.Drawing.Brush = New System.Drawing.SolidBrush(Me._StyleProvider.TextColor)
					graphics.DrawString(Me.TabPages(index).Text, Me.Font, solidBrush1, tabTextRect, Me.GetStringFormat())
				End Using
			End If
		End Sub

		Public Function GetPageBounds(ByVal index As Integer) As Rectangle
			Dim bounds As Rectangle = Me.TabPages(index).Bounds
			bounds.Width = bounds.Width + 1
			bounds.Height = bounds.Height + 1
			bounds.X = bounds.X - 1
			bounds.Y = bounds.Y - 1
			If (bounds.Bottom > Me.Height - 4) Then
				bounds.Height = bounds.Height - (bounds.Bottom - Me.Height + 4)
			End If
			Return bounds
		End Function

		Private Function GetStringFormat() As System.Drawing.StringFormat
			Dim stringFormat As System.Drawing.StringFormat = Nothing
			Select Case Me.Alignment
				Case TabAlignment.Top
				Case TabAlignment.Bottom
					stringFormat = New System.Drawing.StringFormat()
					Exit Select
				Case TabAlignment.Left
				Case TabAlignment.Right
					stringFormat = New System.Drawing.StringFormat(StringFormatFlags.DirectionVertical)
					Exit Select
			End Select
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			If (Me.FindForm() Is Nothing OrElse Not Me.FindForm().KeyPreview) Then
				stringFormat.HotkeyPrefix = HotkeyPrefix.Hide
			Else
				stringFormat.HotkeyPrefix = HotkeyPrefix.Show
			End If
			If (Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes) Then
				stringFormat.FormatFlags = stringFormat.FormatFlags Or StringFormatFlags.DirectionRightToLeft
			End If
			Return stringFormat
		End Function

		Public Function GetTabCloserRect(ByVal index As Integer) As System.Drawing.Rectangle
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle()
			Using tabBorder As GraphicsPath = Me._StyleProvider.GetTabBorder(index)
				Dim bounds As RectangleF = tabBorder.GetBounds()
				Select Case Me.Alignment
					Case TabAlignment.Top
						bounds.Y = bounds.Y + 4!
						bounds.Height = bounds.Height - 6!
						Exit Select
					Case TabAlignment.Bottom
						bounds.Y = bounds.Y + 2!
						bounds.Height = bounds.Height - 6!
						Exit Select
					Case TabAlignment.Left
						bounds.X = bounds.X + 4!
						bounds.Width = bounds.Width - 6!
						Exit Select
					Case TabAlignment.Right
						bounds.X = bounds.X + 2!
						bounds.Width = bounds.Width - 6!
						Exit Select
				End Select
				If (Me.Alignment <= TabAlignment.Bottom) Then
					If (Not Me.RightToLeftLayout) Then
						rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))) - 6)) / 2)))), 6, 6)
						While Not tabBorder.IsVisible(rectangle.Right, rectangle.Y) AndAlso rectangle.Right > -6
							rectangle.X = rectangle.X - 1
						End While
						rectangle.X = rectangle.X - 4
					Else
						rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.Left)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))) - 6)) / 2)))), 6, 6)
						While Not tabBorder.IsVisible(rectangle.Left, rectangle.Y) AndAlso rectangle.Right < Me.Width
							rectangle.X = rectangle.X + 1
						End While
						rectangle.X = rectangle.X + 4
					End If
				ElseIf (Not Me.RightToLeftLayout) Then
					rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))) - 6)) / 2)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))), 6, 6)
					While Not tabBorder.IsVisible(rectangle.X, rectangle.Bottom) AndAlso rectangle.Top > -6
						rectangle.Y = rectangle.Y - 1
					End While
					rectangle.Y = rectangle.Y - 4
				Else
					rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))) - 6)) / 2)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Top)))), 6, 6)
					While Not tabBorder.IsVisible(rectangle.X, rectangle.Top) AndAlso rectangle.Bottom < Me.Height
						rectangle.Y = rectangle.Y + 1
					End While
					rectangle.Y = rectangle.Y + 4
				End If
			End Using
			Return rectangle
		End Function

		Private Function GetTabImageRect(ByVal index As Integer) As Rectangle
			Dim tabImageRect As Rectangle
			Using tabBorder As GraphicsPath = Me._StyleProvider.GetTabBorder(index)
				tabImageRect = Me.GetTabImageRect(tabBorder)
			End Using
			Return tabImageRect
		End Function

		Private Function GetTabImageRect(ByVal tabBorderPath As GraphicsPath) As System.Drawing.Rectangle
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle()
			Dim bounds As RectangleF = tabBorderPath.GetBounds()
			Select Case Me.Alignment
				Case TabAlignment.Top
					bounds.Y = bounds.Y + 4!
					bounds.Height = bounds.Height - 6!
					Exit Select
				Case TabAlignment.Bottom
					bounds.Y = bounds.Y + 2!
					bounds.Height = bounds.Height - 6!
					Exit Select
				Case TabAlignment.Left
					bounds.X = bounds.X + 4!
					bounds.Width = bounds.Width - 6!
					Exit Select
				Case TabAlignment.Right
					bounds.X = bounds.X + 2!
					bounds.Width = bounds.Width - 6!
					Exit Select
			End Select
			If (Me.Alignment <= TabAlignment.Bottom) Then
				If (CInt((Me._StyleProvider.ImageAlign And SVPLCApplication.NativeMethods.AnyLeftAlign)) <> 0) Then
					rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))) - 16)) / 2)))), 16, 16)
					While Not tabBorderPath.IsVisible(rectangle.X, rectangle.Y)
						rectangle.X = rectangle.X + 1
					End While
					rectangle.X = rectangle.X + 4
				ElseIf (CInt((Me._StyleProvider.ImageAlign And SVPLCApplication.NativeMethods.AnyCenterAlign)) = 0) Then
					rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))) - 16)) / 2)))), 16, 16)
					While Not tabBorderPath.IsVisible(rectangle.Right, rectangle.Y)
						rectangle.X = rectangle.X - 1
					End While
					rectangle.X = rectangle.X - 4
					If (Me._StyleProvider.ShowTabCloser AndAlso Not Me.RightToLeftLayout) Then
						rectangle.X = rectangle.X - 10
					End If
				Else
					rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl(((CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))) - CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))) - CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))) + 2) / 2)))))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))) - 16)) / 2)))), 16, 16)
				End If
			ElseIf (CInt((Me._StyleProvider.ImageAlign And SVPLCApplication.NativeMethods.AnyLeftAlign)) <> 0) Then
				rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))) - 16)) / 2)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))), 16, 16)
				While Not tabBorderPath.IsVisible(rectangle.X, rectangle.Y)
					rectangle.Y = rectangle.Y + 1
				End While
				rectangle.Y = rectangle.Y + 4
			ElseIf (CInt((Me._StyleProvider.ImageAlign And SVPLCApplication.NativeMethods.AnyCenterAlign)) = 0) Then
				rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))) - 16)) / 2)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))), 16, 16)
				While Not tabBorderPath.IsVisible(rectangle.X, rectangle.Bottom)
					rectangle.Y = rectangle.Y - 1
				End While
				rectangle.Y = rectangle.Y - 4
				If (Me._StyleProvider.ShowTabCloser AndAlso Not Me.RightToLeftLayout) Then
					rectangle.Y = rectangle.Y - 10
				End If
			Else
				rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl((CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))) - 16)) / 2)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))) + CInt(Math.Round(Math.Truncate(Math.Floor(CDbl(((CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))) - CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))) - CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))) + 2) / 2)))))), 16, 16)
			End If
			Return rectangle
		End Function

		Private Function GetTabPageBorder(ByVal index As Integer) As System.Drawing.Drawing2D.GraphicsPath
			Dim graphicsPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
			Dim pageBounds As Rectangle = Me.GetPageBounds(index)
			Dim tabRect As Rectangle = Me._StyleProvider.GetTabRect(index)
			Me._StyleProvider.AddTabBorder(graphicsPath, tabRect)
			Me.AddPageBorder(graphicsPath, pageBounds, tabRect)
			graphicsPath.CloseFigure()
			Return graphicsPath
		End Function

		Public Function GetTabPosition(ByVal index As Integer) As System.Drawing.Point
			Dim point As System.Drawing.Point
			Dim point1 As System.Drawing.Point
			If (Not Me.Multiline) Then
				point = New System.Drawing.Point(0, index)
				Return point
			End If
			If (Me.RowCount = 1) Then
				point = New System.Drawing.Point(0, index)
				Return point
			End If
			Dim tabRow As Integer = Me.GetTabRow(index)
			Dim tabRect As System.Drawing.Rectangle = Me.GetTabRect(index)
			Dim num As Integer = -1
			Dim tabCount As Integer = Me.TabCount - 1
			Dim num1 As Integer = 0
			Do
				Dim rectangle As System.Drawing.Rectangle = Me.GetTabRect(num1)
				If (Me.Alignment <= TabAlignment.Bottom) Then
					If (rectangle.Y = tabRect.Y) Then
						num = num + 1
					End If
				ElseIf (rectangle.X = tabRect.X) Then
					num = num + 1
				End If
				point = rectangle.Location
				If (point.Equals(tabRect.Location)) Then
					point1 = New System.Drawing.Point(tabRow, num)
					Return point1
				End If
				num1 = num1 + 1
			Loop While num1 <= tabCount
			point1 = New System.Drawing.Point(0, 0)
			Return point1
		End Function

		Public Function GetTabRow(ByVal index As Integer) As Integer
			Dim tabRect As Rectangle = Me.GetTabRect(index)
			Dim y As Integer = -1
			Select Case Me.Alignment
				Case TabAlignment.Top
					y = (tabRect.Y - 2) / tabRect.Height
					Exit Select
				Case TabAlignment.Bottom
					y = (Me.Height - tabRect.Y - 2) / tabRect.Height - 1
					Exit Select
				Case TabAlignment.Left
					y = (tabRect.X - 2) / tabRect.Width
					Exit Select
				Case TabAlignment.Right
					y = (Me.Width - tabRect.X - 2) / tabRect.Width - 1
					Exit Select
			End Select
			Return y
		End Function

		Private Function GetTabTextRect(ByVal index As Integer) As System.Drawing.Rectangle
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle()
			Using tabBorder As GraphicsPath = Me._StyleProvider.GetTabBorder(index)
				Dim bounds As RectangleF = tabBorder.GetBounds()
				rectangle = New System.Drawing.Rectangle(CInt(Math.Round(Math.Truncate(CDbl(bounds.X)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Y)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Width)))), CInt(Math.Round(Math.Truncate(CDbl(bounds.Height)))))
				Select Case Me.Alignment
					Case TabAlignment.Top
						rectangle.Y = rectangle.Y + 4
						rectangle.Height = rectangle.Height - 6
						Exit Select
					Case TabAlignment.Bottom
						rectangle.Y = rectangle.Y + 2
						rectangle.Height = rectangle.Height - 6
						Exit Select
					Case TabAlignment.Left
						rectangle.X = rectangle.X + 4
						rectangle.Width = rectangle.Width - 6
						Exit Select
					Case TabAlignment.Right
						rectangle.X = rectangle.X + 2
						rectangle.Width = rectangle.Width - 6
						Exit Select
				End Select
				If (Me.ImageList IsNot Nothing AndAlso (Me.TabPages(index).ImageIndex > -1 OrElse Not String.IsNullOrEmpty(Me.TabPages(index).ImageKey) AndAlso Not Me.TabPages(index).ImageKey.Equals("(none)", StringComparison.OrdinalIgnoreCase))) Then
					Dim tabImageRect As System.Drawing.Rectangle = Me.GetTabImageRect(index)
					If (CInt((Me._StyleProvider.ImageAlign And SVPLCApplication.NativeMethods.AnyLeftAlign)) <> 0) Then
						If (Me.Alignment > TabAlignment.Bottom) Then
							rectangle.Y = tabImageRect.Y + 4
							rectangle.Height = rectangle.Height - (rectangle.Bottom - CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))))
						Else
							rectangle.X = tabImageRect.Right + 4
							rectangle.Width = rectangle.Width - (rectangle.Right - CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))))
						End If
						If (Me._StyleProvider.ShowTabCloser) Then
							Dim tabCloserRect As System.Drawing.Rectangle = Me.GetTabCloserRect(index)
							If (Me.Alignment <= TabAlignment.Bottom) Then
								If (Not Me.RightToLeftLayout) Then
									rectangle.Width = rectangle.Width - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))) - tabCloserRect.X + 4)
								Else
									rectangle.Width = rectangle.Width - (tabCloserRect.Right + 4 - rectangle.X)
									rectangle.X = tabCloserRect.Right + 4
								End If
							ElseIf (Not Me.RightToLeftLayout) Then
								rectangle.Height = rectangle.Height - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))) - tabCloserRect.Y + 4)
							Else
								rectangle.Height = rectangle.Height - (tabCloserRect.Bottom + 4 - rectangle.Y)
								rectangle.Y = tabCloserRect.Bottom + 4
							End If
						End If
					ElseIf (CInt((Me._StyleProvider.ImageAlign And SVPLCApplication.NativeMethods.AnyCenterAlign)) = 0) Then
						If (Me.Alignment > TabAlignment.Bottom) Then
							rectangle.Height = rectangle.Height - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))) - tabImageRect.Y + 4)
						Else
							rectangle.Width = rectangle.Width - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))) - tabImageRect.X + 4)
						End If
						If (Me._StyleProvider.ShowTabCloser) Then
							Dim tabCloserRect1 As System.Drawing.Rectangle = Me.GetTabCloserRect(index)
							If (Me.Alignment <= TabAlignment.Bottom) Then
								If (Not Me.RightToLeftLayout) Then
									rectangle.Width = rectangle.Width - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))) - tabCloserRect1.X + 4)
								Else
									rectangle.Width = rectangle.Width - (tabCloserRect1.Right + 4 - rectangle.X)
									rectangle.X = tabCloserRect1.Right + 4
								End If
							ElseIf (Not Me.RightToLeftLayout) Then
								rectangle.Height = rectangle.Height - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))) - tabCloserRect1.Y + 4)
							Else
								rectangle.Height = rectangle.Height - (tabCloserRect1.Bottom + 4 - rectangle.Y)
								rectangle.Y = tabCloserRect1.Bottom + 4
							End If
						End If
					ElseIf (Me._StyleProvider.ShowTabCloser) Then
						Dim rectangle1 As System.Drawing.Rectangle = Me.GetTabCloserRect(index)
						If (Me.Alignment <= TabAlignment.Bottom) Then
							If (Not Me.RightToLeftLayout) Then
								rectangle.Width = rectangle.Width - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))) - rectangle1.X + 4)
							Else
								rectangle.Width = rectangle.Width - (rectangle1.Right + 4 - rectangle.X)
								rectangle.X = rectangle1.Right + 4
							End If
						ElseIf (Not Me.RightToLeftLayout) Then
							rectangle.Height = rectangle.Height - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))) - rectangle1.Y + 4)
						Else
							rectangle.Height = rectangle.Height - (rectangle1.Bottom + 4 - rectangle.Y)
							rectangle.Y = rectangle1.Bottom + 4
						End If
					End If
				ElseIf (Me._StyleProvider.ShowTabCloser) Then
					Dim tabCloserRect2 As System.Drawing.Rectangle = Me.GetTabCloserRect(index)
					If (Me.Alignment <= TabAlignment.Bottom) Then
						If (Not Me.RightToLeftLayout) Then
							rectangle.Width = rectangle.Width - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Right)))) - tabCloserRect2.X + 4)
						Else
							rectangle.Width = rectangle.Width - (tabCloserRect2.Right + 4 - rectangle.X)
							rectangle.X = tabCloserRect2.Right + 4
						End If
					ElseIf (Not Me.RightToLeftLayout) Then
						rectangle.Height = rectangle.Height - (CInt(Math.Round(Math.Truncate(CDbl(bounds.Bottom)))) - tabCloserRect2.Y + 4)
					Else
						rectangle.Height = rectangle.Height - (tabCloserRect2.Bottom + 4 - rectangle.Y)
						rectangle.Y = tabCloserRect2.Bottom + 4
					End If
				End If
				If (Me.Alignment > TabAlignment.Bottom) Then
					While Not tabBorder.IsVisible(rectangle.X, rectangle.Bottom)
						If (rectangle.Height > 0) Then
							rectangle.Height = rectangle.Height - 1
						Else
							Exit While
						End If
					End While
					While Not tabBorder.IsVisible(rectangle.X, rectangle.Y) AndAlso rectangle.Height > 0
						rectangle.Y = rectangle.Y + 1
						rectangle.Height = rectangle.Height - 1
					End While
				Else
					While Not tabBorder.IsVisible(rectangle.Right, rectangle.Y)
						If (rectangle.Width > 0) Then
							rectangle.Width = rectangle.Width - 1
						Else
							Exit While
						End If
					End While
					While Not tabBorder.IsVisible(rectangle.X, rectangle.Y)
						If (rectangle.Width > 0) Then
							rectangle.X = rectangle.X + 1
							rectangle.Width = rectangle.Width - 1
						Else
							Return rectangle
						End If
					End While
				End If
			End Using
			Return rectangle
		End Function

		Public Sub HideTab(ByVal page As TabPage)
			If (page IsNot Nothing AndAlso Me.TabPages.Contains(page)) Then
				Me.BackupTabPages()
				Me.TabPages.Remove(page)
			End If
		End Sub

		Public Sub HideTab(ByVal index As Integer)
			If (Me.IsValidTabIndex(index)) Then
				Me.HideTab(Me._TabPages(index))
			End If
		End Sub

		Public Sub HideTab(ByVal key As String)
			If (Me.TabPages.ContainsKey(key)) Then
				Me.HideTab(Me.TabPages(key))
			End If
		End Sub

		Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
			target = value
			Return value
		End Function

		Public Function IsFirstTabInRow(ByVal index As Integer) As Boolean
			If (index < 0) Then
				Return False
			End If
			Dim flag As Boolean = index = 0
			If (Not flag) Then
				If (Me.Alignment <= TabAlignment.Bottom) Then
					If (Me.GetTabRect(index).X = 2) Then
						flag = True
					End If
				ElseIf (Me.GetTabRect(index).Y = 2) Then
					flag = True
				End If
			End If
			Return flag
		End Function

		Private Function IsValidTabIndex(ByVal index As Integer) As Boolean
			Me.BackupTabPages()
			If (index >= 0 AndAlso index < Me._TabPages.Count) Then
				Return True
			End If
			Return False
		End Function

		Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
			MyBase.OnControlAdded(e)
			If (Me.Visible) Then
				Me.Invalidate()
			End If
		End Sub

		Protected Overrides Sub OnControlRemoved(ByVal e As ControlEventArgs)
			MyBase.OnControlRemoved(e)
			If (Me.Visible) Then
				Me.Invalidate()
			End If
		End Sub

		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			Me.OnFontChanged(EventArgs.Empty)
		End Sub

		Protected Overrides Sub OnDragDrop(ByVal drgevent As DragEventArgs)
			MyBase.OnDragDrop(drgevent)
			If (drgevent.Data.GetDataPresent(GetType(TabPage))) Then
				drgevent.Effect = DragDropEffects.Move
				Dim data As TabPage = DirectCast(drgevent.Data.GetData(GetType(TabPage)), TabPage)
				If (Me.ActiveTab = data) Then
					Return
				End If
				Dim activeIndex As Integer = Me.ActiveIndex
				If (data.Parent.Equals(Me) AndAlso Me.TabPages.IndexOf(data) < activeIndex) Then
					activeIndex = activeIndex - 1
				End If
				If (activeIndex < 0) Then
					activeIndex = 0
				End If
				DirectCast(data.Parent, TabControl).TabPages.Remove(data)
				Me.TabPages.Insert(activeIndex, data)
				Me.SelectedTab = data
			End If
		End Sub

		Protected Overrides Sub OnDragOver(ByVal drgevent As DragEventArgs)
			MyBase.OnDragOver(drgevent)
			If (Not drgevent.Data.GetDataPresent(GetType(TabPage))) Then
				drgevent.Effect = DragDropEffects.None
			Else
				drgevent.Effect = DragDropEffects.Move
			End If
		End Sub

		Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
			Dim hfont As IntPtr = Me.Font.ToHfont()
			SVPLCApplication.NativeMethods.SendMessage(Me.Handle, 48, hfont, DirectCast(-1, IntPtr))
			SVPLCApplication.NativeMethods.SendMessage(Me.Handle, 29, IntPtr.Zero, IntPtr.Zero)
			Me.UpdateStyles()
			If (Me.Visible) Then
				Me.Invalidate()
			End If
		End Sub

		Protected Overridable Sub OnHScroll(ByVal e As ScrollEventArgs)
			Me.Invalidate()
			RaiseEvent HScroll(Me, e)
			If (e.Type = ScrollEventType.EndScroll) Then
				Me._oldValue = e.NewValue
			End If
		End Sub

		Protected Overrides Sub OnMouseClick(ByVal e As MouseEventArgs)
			' 
			' Current member / type: System.Void SVPLCApplication.CustomTabControl::OnMouseClick(System.Windows.Forms.MouseEventArgs)
			' File path: C:\Users\clequinio\Desktop\SVPLC\{app}\SVPLC.exe
			' 
			' Product version: 2018.2.803.0
			' Exception in: System.Void OnMouseClick(System.Windows.Forms.MouseEventArgs)
			' 
			' Visual Basic does not support this type of event usage. Please, try using other language.
			'    à ...( ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:ligne 101
			'    à ..Visit(ICodeNode ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 213
			'    à ..(BinaryExpression ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 546
			'    à ...(BinaryExpression ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:ligne 96
			'    à ..Visit(ICodeNode ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 141
			'    à ..(BinaryExpression ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 547
			'    à ...(BinaryExpression ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:ligne 96
			'    à ..Visit(ICodeNode ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 141
			'    à ..(BinaryExpression ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 546
			'    à ...(BinaryExpression ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:ligne 96
			'    à ..Visit(ICodeNode ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 141
			'    à ..( ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 414
			'    à ..Visit(ICodeNode ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 81
			'    à ..Visit(IEnumerable ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 383
			'    à ..( ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 388
			'    à ..Visit(ICodeNode ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeVisitor.cs:ligne 69
			'    à ..(DecompilationContext ,  ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\DetermineNotSupportedVBCodeStep.cs:ligne 25
			'    à ..(MethodBody ,  , ILanguage ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:ligne 88
			'    à ..(MethodBody , ILanguage ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:ligne 70
			'    à Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:ligne 95
			'    à Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:ligne 58
			'    à ..(ILanguage , MethodDefinition ,  ) dans C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:ligne 117
			' 
			' mailto: JustDecompilePublicFeedback@telerik.com

		End Sub

		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If (Me.AllowDrop) Then
				Me._dragStartPosition = New Point(e.X, e.Y)
			End If
		End Sub

		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If (Me._StyleProvider.ShowTabCloser AndAlso Me._StyleProvider.GetTabRect(Me.ActiveIndex).Contains(Me.MousePosition)) Then
				Me.Invalidate()
			End If
			If (Me.AllowDrop AndAlso e.Button = System.Windows.Forms.MouseButtons.Left) Then
				Me.StartDragDrop()
			End If
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			If (Me.AllowDrop) Then
				Me._dragStartPosition = Point.Empty
			End If
		End Sub

		Protected Overrides Sub OnMove(ByVal e As EventArgs)
			If (Me.Width > 0 AndAlso Me.Height > 0 AndAlso Me._BackImage IsNot Nothing) Then
				Me._BackImage.Dispose()
				Me._BackImage = Nothing
			End If
			MyBase.OnMove(e)
			Me.Invalidate()
		End Sub

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			Dim graphic As Graphics = Me.CreateGraphics()
			If (Not Me._lastClipRect.Equals(e.ClipRectangle)) Then
				Me.ResetDoubleBuffering()
				Me._lastClipRect = e.ClipRectangle
			End If
			Me.CustomPaint(graphic)
		End Sub

		Protected Overrides Sub OnParentBackColorChanged(ByVal e As EventArgs)
			If (Me._BackImage IsNot Nothing) Then
				Me._BackImage.Dispose()
				Me._BackImage = Nothing
			End If
			MyBase.OnParentBackColorChanged(e)
		End Sub

		Protected Overrides Sub OnParentBackgroundImageChanged(ByVal e As EventArgs)
			If (Me._BackImage IsNot Nothing) Then
				Me._BackImage.Dispose()
				Me._BackImage = Nothing
			End If
			MyBase.OnParentBackgroundImageChanged(e)
		End Sub

		Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
			MyBase.OnParentChanged(e)
			If (Me.Parent IsNot Nothing) Then
				Dim customTabControl As SVPLCApplication.CustomTabControl = Me
				AddHandler Me.Parent.Resize,  New EventHandler(AddressOf customTabControl.OnParentResize)
			End If
		End Sub

		Private Sub OnParentResize(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.Visible) Then
				Me.Invalidate()
			End If
		End Sub

		Protected Overrides Sub OnResize(ByVal e As EventArgs)
			If (Me.Width > 0 AndAlso Me.Height > 0) Then
				If (Me._BackImage IsNot Nothing) Then
					Me._BackImage.Dispose()
					Me._BackImage = Nothing
				End If
				If (Me._BackBufferGraphics IsNot Nothing) Then
					Me._BackBufferGraphics.Dispose()
				End If
				If (Me._BackBuffer IsNot Nothing) Then
					Me._BackBuffer.Dispose()
				End If
				Me._BackBuffer = New Bitmap(Me.Width, Me.Height)
				Me._BackBufferGraphics = Graphics.FromImage(Me._BackBuffer)
				If (Me._TabBufferGraphics IsNot Nothing) Then
					Me._TabBufferGraphics.Dispose()
				End If
				If (Me._TabBuffer IsNot Nothing) Then
					Me._TabBuffer.Dispose()
				End If
				Me._TabBuffer = New Bitmap(Me.Width, Me.Height)
				Me._TabBufferGraphics = Graphics.FromImage(Me._TabBuffer)
				If (Me._BackImage IsNot Nothing) Then
					Me._BackImage.Dispose()
					Me._BackImage = Nothing
				End If
			End If
			MyBase.OnResize(e)
		End Sub

		Protected Overrides Sub OnSelectedIndexChanged(ByVal e As EventArgs)
			MyBase.OnSelectedIndexChanged(e)
		End Sub

		Protected Overrides Sub OnSelecting(ByVal e As TabControlCancelEventArgs)
			MyBase.OnSelecting(e)
			If (e.Action = TabControlAction.Selecting AndAlso e.TabPage IsNot Nothing AndAlso Not e.TabPage.Enabled) Then
				e.Cancel = True
			End If
		End Sub

		Protected Overridable Sub OnTabClosing(ByVal e As TabControlCancelEventArgs)
			RaiseEvent TabClosing(Me, e)
		End Sub

		Protected Overridable Sub OnTabImageClick(ByVal e As TabControlEventArgs)
			RaiseEvent TabImageClick(Me, e)
		End Sub

		Protected Sub PaintTransparentBackground(ByVal graphics As System.Drawing.Graphics, ByVal clipRect As Rectangle)
			If (Me.Parent IsNot Nothing) Then
				clipRect.Offset(Me.Location)
				Dim graphicsState As System.Drawing.Drawing2D.GraphicsState = graphics.Save()
				Dim location As System.Drawing.Point = Me.Location
				Dim x As Single = CSng((0 - location.X))
				Dim point As System.Drawing.Point = Me.Location
				graphics.TranslateTransform(x, CSng((0 - point.Y)))
				graphics.SmoothingMode = SmoothingMode.HighSpeed
				Dim paintEventArg As PaintEventArgs = New PaintEventArgs(graphics, clipRect)
				Try
					Me.InvokePaintBackground(Me.Parent, paintEventArg)
					Me.InvokePaint(Me.Parent, paintEventArg)
				Finally
					graphics.Restore(graphicsState)
					point = Me.Location
					Dim num As Integer = 0 - point.X
					location = Me.Location
					clipRect.Offset(num, 0 - location.Y)
				End Try
			End If
		End Sub

		Protected Overrides Function ProcessMnemonic(ByVal charCode As Char) As Boolean
			Dim flag As Boolean
			Dim enumerator As IEnumerator = Nothing
			Try
				enumerator = Me.TabPages.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As TabPage = DirectCast(enumerator.Current, TabPage)
					If (Not Control.IsMnemonic(charCode, current.Text)) Then
						Continue While
					End If
					Me.SelectedTab = current
					flag = True
					Return flag
				End While
				Return MyBase.ProcessMnemonic(charCode)
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return flag
		End Function

		Private Sub ResetDoubleBuffering()
			If (Me.Width > 0 AndAlso Me.Height > 0) Then
				If (Me._BackImage IsNot Nothing) Then
					Me._BackImage.Dispose()
					Me._BackImage = Nothing
				End If
				If (Me._BackBufferGraphics IsNot Nothing) Then
					Me._BackBufferGraphics.Dispose()
				End If
				If (Me._BackBuffer IsNot Nothing) Then
					Me._BackBuffer.Dispose()
				End If
				Me._BackBuffer = New Bitmap(Me.Width, Me.Height)
				Me._BackBufferGraphics = Graphics.FromImage(Me._BackBuffer)
				If (Me._TabBufferGraphics IsNot Nothing) Then
					Me._TabBufferGraphics.Dispose()
				End If
				If (Me._TabBuffer IsNot Nothing) Then
					Me._TabBuffer.Dispose()
				End If
				Me._TabBuffer = New Bitmap(Me.Width, Me.Height)
				Me._TabBufferGraphics = Graphics.FromImage(Me._TabBuffer)
				If (Me._BackImage IsNot Nothing) Then
					Me._BackImage.Dispose()
					Me._BackImage = Nothing
				End If
			End If
		End Sub

		Public Sub ShowTab(ByVal page As TabPage)
			If (page IsNot Nothing) Then
				If (Me._TabPages IsNot Nothing) Then
					If (Not Me.TabPages.Contains(page) AndAlso Me._TabPages.Contains(page)) Then
						Dim num As Integer = Me._TabPages.IndexOf(page)
						If (num > 0) Then
							Dim num1 As Integer = num - 1
							While num1 >= 0
								If (Not Me.TabPages.Contains(Me._TabPages(num1))) Then
									num1 = num1 + -1
								Else
									num = Me.TabPages.IndexOf(Me._TabPages(num1)) + 1
									Exit While
								End If
							End While
						End If
						If (num < 0 OrElse num >= Me.TabPages.Count) Then
							Me.TabPages.Add(page)
						Else
							Me.TabPages.Insert(num, page)
						End If
					End If
				ElseIf (Not Me.TabPages.Contains(page)) Then
					Me.TabPages.Add(page)
				End If
			End If
		End Sub

		Public Sub ShowTab(ByVal index As Integer)
			If (Me.IsValidTabIndex(index)) Then
				Me.ShowTab(Me._TabPages(index))
			End If
		End Sub

		Public Sub ShowTab(ByVal key As String)
			If (Me._TabPages IsNot Nothing) Then
				Dim tabPage As System.Windows.Forms.TabPage = Me._TabPages.Find(Function(page As System.Windows.Forms.TabPage) page.Name.Equals(key, StringComparison.OrdinalIgnoreCase))
				Me.ShowTab(tabPage)
			End If
		End Sub

		Private Sub StartDragDrop()
			If (Not Me._dragStartPosition.IsEmpty) Then
				Dim selectedTab As TabPage = Me.SelectedTab
				If (selectedTab IsNot Nothing) Then
					Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(Me._dragStartPosition, System.Drawing.Size.Empty)
					rectangle.Inflate(SystemInformation.DragSize)
					If (Not rectangle.Contains(Me.PointToClient(Control.MousePosition))) Then
						Me.DoDragDrop(selectedTab, DragDropEffects.All)
						Me._dragStartPosition = Point.Empty
					End If
				End If
			End If
		End Sub

		Protected Overrides Sub WndProc(ByRef m As Message)
			If (m.Msg <> 276) Then
				MyBase.WndProc(m)
			Else
				MyBase.WndProc(m)
				Me.OnHScroll(New ScrollEventArgs(DirectCast(SVPLCApplication.NativeMethods.LoWord(m.WParam), ScrollEventType), Me._oldValue, SVPLCApplication.NativeMethods.HiWord(m.WParam), ScrollOrientation.HorizontalScroll))
			End If
		End Sub

		Public Event HScroll As ScrollEventHandler

		Public Event TabClosing As EventHandler(Of TabControlCancelEventArgs)

		Public Event TabImageClick As EventHandler(Of TabControlEventArgs)
	End Class
End Namespace