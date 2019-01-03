Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Namespace SVPLCApplication
	Friend NotInheritable Class ThemedColors
		Private Const NormalColor As String = "NormalColor"

		Private Const HomeStead As String = "HomeStead"

		Private Const Metallic As String = "Metallic"

		Private Const NoTheme As String = "NoTheme"

		Private Shared _toolBorder As Color()

		Public ReadOnly Shared Property CurrentThemeIndex As ThemedColors.ColorScheme
			Get
				Return ThemedColors.GetCurrentThemeIndex()
			End Get
		End Property

		Public ReadOnly Shared Property ToolBorder As Color
			Get
				Return ThemedColors._toolBorder(CInt(ThemedColors.CurrentThemeIndex))
			End Get
		End Property

		Shared Sub New()
			Dim colorArray() As Color = { Color.FromArgb(127, 157, 185), Color.FromArgb(164, 185, 127), Color.FromArgb(165, 172, 178), Color.FromArgb(132, 130, 132) }
			ThemedColors._toolBorder = colorArray
		End Sub

		Private Sub New()
			MyBase.New()
		End Sub

		Private Shared Function GetCurrentThemeIndex() As ThemedColors.ColorScheme
			Dim colorScheme As ThemedColors.ColorScheme = ThemedColors.ColorScheme.NoTheme
			If (VisualStyleInformation.IsSupportedByOS AndAlso VisualStyleInformation.IsEnabledByUser AndAlso Application.RenderWithVisualStyles) Then
				Dim str As String = VisualStyleInformation.ColorScheme
				If (Operators.CompareString(str, "NormalColor", False) = 0) Then
					colorScheme = ThemedColors.ColorScheme.NormalColor
				ElseIf (Operators.CompareString(str, "HomeStead", False) <> 0) Then
					colorScheme = If(Operators.CompareString(str, "Metallic", False) <> 0, ThemedColors.ColorScheme.NoTheme, ThemedColors.ColorScheme.Metallic)
				Else
					colorScheme = ThemedColors.ColorScheme.HomeStead
				End If
			End If
			Return colorScheme
		End Function

		Public Enum ColorScheme
			NormalColor
			HomeStead
			Metallic
			NoTheme
		End Enum
	End Class
End Namespace