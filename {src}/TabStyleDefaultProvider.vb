Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace SVPLCApplication
	<ToolboxItem(False)>
	Public Class TabStyleDefaultProvider
		Inherits TabStyleProvider
		Public Sub New(ByVal tabControl As CustomTabControl)
			MyBase.New(tabControl)
			Me._FocusTrack = True
			Me._Radius = 2
		End Sub

		Public Overrides Sub AddTabBorder(ByVal path As GraphicsPath, ByVal tabBounds As Rectangle)
			Select Case Me._TabControl.Alignment
				Case TabAlignment.Top
					path.AddLine(tabBounds.X, tabBounds.Bottom, tabBounds.X, tabBounds.Y)
					path.AddLine(tabBounds.X, tabBounds.Y, tabBounds.Right, tabBounds.Y)
					path.AddLine(tabBounds.Right, tabBounds.Y, tabBounds.Right, tabBounds.Bottom)
					Exit Select
				Case TabAlignment.Bottom
					path.AddLine(tabBounds.Right, tabBounds.Y, tabBounds.Right, tabBounds.Bottom)
					path.AddLine(tabBounds.Right, tabBounds.Bottom, tabBounds.X, tabBounds.Bottom)
					path.AddLine(tabBounds.X, tabBounds.Bottom, tabBounds.X, tabBounds.Y)
					Exit Select
				Case TabAlignment.Left
					path.AddLine(tabBounds.Right, tabBounds.Bottom, tabBounds.X, tabBounds.Bottom)
					path.AddLine(tabBounds.X, tabBounds.Bottom, tabBounds.X, tabBounds.Y)
					path.AddLine(tabBounds.X, tabBounds.Y, tabBounds.Right, tabBounds.Y)
					Exit Select
				Case TabAlignment.Right
					path.AddLine(tabBounds.X, tabBounds.Y, tabBounds.Right, tabBounds.Y)
					path.AddLine(tabBounds.Right, tabBounds.Y, tabBounds.Right, tabBounds.Bottom)
					path.AddLine(tabBounds.Right, tabBounds.Bottom, tabBounds.X, tabBounds.Bottom)
					Exit Select
			End Select
		End Sub

		Public Overrides Function GetTabRect(ByVal index As Integer) As Rectangle
			If (index < 0) Then
				Return New Rectangle()
			End If
			Dim tabRect As Rectangle = MyBase.GetTabRect(index)
			Dim flag As Boolean = Me._TabControl.IsFirstTabInRow(index)
			If (index = Me._TabControl.SelectedIndex) Then
				Select Case Me._TabControl.Alignment
					Case TabAlignment.Top
						If (tabRect.Y > 0) Then
							tabRect.Y = tabRect.Y - 1
							tabRect.Height = tabRect.Height + 1
						End If
						If (Not flag) Then
							tabRect.X = tabRect.X - 1
							tabRect.Width = tabRect.Width + 2
							Exit Select
						Else
							tabRect.Width = tabRect.Width + 1
							Exit Select
						End If
					Case TabAlignment.Bottom
						If (tabRect.Bottom < Me._TabControl.Bottom) Then
							tabRect.Height = tabRect.Height + 1
						End If
						If (Not flag) Then
							tabRect.X = tabRect.X - 1
							tabRect.Width = tabRect.Width + 2
							Exit Select
						Else
							tabRect.Width = tabRect.Width + 1
							Exit Select
						End If
					Case TabAlignment.Left
						If (tabRect.X > 0) Then
							tabRect.X = tabRect.X - 1
							tabRect.Width = tabRect.Width + 1
						End If
						If (Not flag) Then
							tabRect.Y = tabRect.Y - 1
							tabRect.Height = tabRect.Height + 2
							Exit Select
						Else
							tabRect.Height = tabRect.Height + 1
							Exit Select
						End If
					Case TabAlignment.Right
						If (tabRect.Right < Me._TabControl.Right) Then
							tabRect.Width = tabRect.Width + 1
						End If
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