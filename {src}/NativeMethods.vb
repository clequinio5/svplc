Imports System
Imports System.Drawing
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace SVPLCApplication
	Friend NotInheritable Class NativeMethods
		Public Const WM_GETTABRECT As Integer = 4874

		Public Const WS_EX_TRANSPARENT As Integer = 32

		Public Const WM_SETFONT As Integer = 48

		Public Const WM_FONTCHANGE As Integer = 29

		Public Const WM_HSCROLL As Integer = 276

		Public Const TCM_HITTEST As Integer = 4877

		Public Const WM_PAINT As Integer = 15

		Public Const WS_EX_LAYOUTRTL As Integer = 4194304

		Public Const WS_EX_NOINHERITLAYOUT As Integer = 1048576

		Public ReadOnly Shared AnyRightAlign As ContentAlignment

		Public ReadOnly Shared AnyLeftAlign As ContentAlignment

		Public ReadOnly Shared AnyTopAlign As ContentAlignment

		Public ReadOnly Shared AnyBottomAlign As ContentAlignment

		Public ReadOnly Shared AnyMiddleAlign As ContentAlignment

		Public ReadOnly Shared AnyCenterAlign As ContentAlignment

		Shared Sub New()
			SVPLCApplication.NativeMethods.AnyRightAlign = ContentAlignment.TopRight Or ContentAlignment.MiddleRight Or ContentAlignment.BottomRight
			SVPLCApplication.NativeMethods.AnyLeftAlign = ContentAlignment.TopLeft Or ContentAlignment.MiddleLeft Or ContentAlignment.BottomLeft
			SVPLCApplication.NativeMethods.AnyTopAlign = ContentAlignment.TopLeft Or ContentAlignment.TopCenter Or ContentAlignment.TopRight
			SVPLCApplication.NativeMethods.AnyBottomAlign = ContentAlignment.BottomLeft Or ContentAlignment.BottomCenter Or ContentAlignment.BottomRight
			SVPLCApplication.NativeMethods.AnyMiddleAlign = ContentAlignment.MiddleLeft Or ContentAlignment.MiddleCenter Or ContentAlignment.MiddleRight
			SVPLCApplication.NativeMethods.AnyCenterAlign = ContentAlignment.TopCenter Or ContentAlignment.MiddleCenter Or ContentAlignment.BottomCenter
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Shared Function HiWord(ByVal dWord As IntPtr) As Integer
			If ((CLng(dWord.ToInt32()) And CULng(-2147483648)) = CULng(-2147483648)) Then
				Return dWord.ToInt32() >> 16
			End If
			Return dWord.ToInt32() >> 16 And 65535
		End Function

		Public Shared Function LoWord(ByVal dWord As IntPtr) As Integer
			Return dWord.ToInt32() And 65535
		End Function

		Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
			Dim message As System.Windows.Forms.Message = New System.Windows.Forms.Message()
			Dim message1 As System.Windows.Forms.Message
			Dim control As System.Windows.Forms.Control = System.Windows.Forms.Control.FromHandle(hWnd)
			If (control Is Nothing) Then
				Return IntPtr.Zero
			End If
			Dim message2 As System.Windows.Forms.Message = New System.Windows.Forms.Message() With
			{
				.HWnd = hWnd,
				.LParam = lParam,
				.WParam = wParam,
				.Msg = msg
			}
			Dim method As MethodInfo = control.[GetType]().GetMethod("WndProc", BindingFlags.IgnoreCase Or BindingFlags.Instance Or BindingFlags.NonPublic Or BindingFlags.FlattenHierarchy Or BindingFlags.InvokeMethod)
			Dim objArray() As Object = { message2 }
			method.Invoke(control, objArray)
			Dim obj As Object = objArray(0)
			If (obj IsNot Nothing) Then
				message1 = DirectCast(obj, System.Windows.Forms.Message)
			Else
				message1 = message
			End If
			Return message1.Result
		End Function

		Public Shared Function ToIntPtr(ByVal [structure] As Object) As IntPtr
			Dim zero As IntPtr = IntPtr.Zero
			zero = Marshal.AllocCoTaskMem(Marshal.SizeOf(RuntimeHelpers.GetObjectValue([structure])))
			Marshal.StructureToPtr(RuntimeHelpers.GetObjectValue([structure]), zero, False)
			Return zero
		End Function

		Public Structure PAINTSTRUCT
			Public hdc As IntPtr

			Public fErase As Integer

			Public rcPaint As SVPLCApplication.NativeMethods.RECT

			Public fRestore As Integer

			Public fIncUpdate As Integer

			Public rgbReserved As Byte()
		End Structure

		Public Structure RECT
			Public left As Integer

			Public top As Integer

			Public right As Integer

			Public bottom As Integer

			Public ReadOnly Property Size As Size
				Get
					Dim size1 As Size = New Size(Me.right - Me.left, Me.bottom - Me.top)
					Return size1
				End Get
			End Property

			Public Sub New(ByVal left As Integer, ByVal top As Integer, ByVal right As Integer, ByVal bottom As Integer)
				Me = New SVPLCApplication.NativeMethods.RECT() With
				{
					.left = left,
					.top = top,
					.right = right,
					.bottom = bottom
				}
			End Sub

			Public Sub New(ByVal r As Rectangle)
				Me = New SVPLCApplication.NativeMethods.RECT() With
				{
					.left = r.Left,
					.top = r.Top,
					.right = r.Right,
					.bottom = r.Bottom
				}
			End Sub

			Public Shared Function FromIntPtr(ByVal ptr As IntPtr) As SVPLCApplication.NativeMethods.RECT
				Dim rECT As SVPLCApplication.NativeMethods.RECT = New SVPLCApplication.NativeMethods.RECT()
				Dim rECT1 As SVPLCApplication.NativeMethods.RECT
				Dim [structure] As Object = Marshal.PtrToStructure(ptr, GetType(SVPLCApplication.NativeMethods.RECT))
				If ([structure] IsNot Nothing) Then
					rECT1 = DirectCast([structure], SVPLCApplication.NativeMethods.RECT)
				Else
					rECT1 = rECT
				End If
				Return rECT1
			End Function

			Public Shared Function FromXYWH(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer) As SVPLCApplication.NativeMethods.RECT
				Dim rECT As SVPLCApplication.NativeMethods.RECT = New SVPLCApplication.NativeMethods.RECT(x, y, x + width, y + height)
				Return rECT
			End Function
		End Structure

		Public Enum TCHITTESTFLAGS
			TCHT_NOWHERE = 1
			TCHT_ONITEMICON = 2
			TCHT_ONITEMLABEL = 4
			TCHT_ONITEM = 6
		End Enum

		Public Structure TCHITTESTINFO
			Public pt As Point

			Public flags As SVPLCApplication.NativeMethods.TCHITTESTFLAGS

			Public Sub New(ByVal location As Point)
				Me = New SVPLCApplication.NativeMethods.TCHITTESTINFO() With
				{
					.pt = location,
					.flags = SVPLCApplication.NativeMethods.TCHITTESTFLAGS.TCHT_ONITEM
				}
			End Sub
		End Structure
	End Class
End Namespace