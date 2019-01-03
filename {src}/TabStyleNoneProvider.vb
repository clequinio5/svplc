Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace SVPLCApplication
	<ToolboxItem(False)>
	Public Class TabStyleNoneProvider
		Inherits TabStyleProvider
		Public Sub New(ByVal tabControl As CustomTabControl)
			MyBase.New(tabControl)
		End Sub

		Public Overrides Sub AddTabBorder(ByVal path As GraphicsPath, ByVal tabBounds As Rectangle)
		End Sub
	End Class
End Namespace