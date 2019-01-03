Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace SVPLCApplication
	Public Class TransparentRichTextBox
		Inherits RichTextBox
		Protected Overrides ReadOnly Property CreateParams As System.Windows.Forms.CreateParams
			Get
				Dim exStyle As System.Windows.Forms.CreateParams = MyBase.CreateParams
				If (TransparentRichTextBox.LoadLibrary("msftedit.dll") <> IntPtr.Zero) Then
					exStyle.ExStyle = exStyle.ExStyle Or 32
					exStyle.ClassName = "RICHEDIT50W"
				End If
				Return exStyle
			End Get
		End Property

		Public Sub New()
			MyBase.New()
		End Sub

		<DllImport("kernel32.dll", CharSet:=CharSet.Auto, ExactSpelling:=False)>
		Private Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
		End Function
	End Class
End Namespace