Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports SVPLCApplication.My

Namespace SVPLCApplication
	Friend Module Module1
		Public nbrlignecal As Integer

		Public numeroparcelle As Integer

		Public numerocontrainte As Integer

		Public Destdir As String

		Public Base_de_données_associations As Object(,)

		Public listelégumes As String()

		Public Base_de_données_calendrier As String()

		Public Lepoireaupreferelesfraises As String()

		Public Base_de_données_rotations As Integer(,)

		Public Base_de_données_rotationsstr As String(,)

		Public checkrotfam As Boolean

		Public checkrottype As Boolean

		Public checkrotbdd As Boolean

		Public masquerlesconflits As Boolean

		Public FAMILLE As String()

		Public TYPE As String()

		Public ttcbb As String()

		Public TTfiltre As ToolTip

		Public TTfiltred As ToolTip

		Public loadcombass As Boolean

		Public loadbddfiche As Boolean

		Public loadcombrot1 As Boolean

		Public loadcombrot2 As Boolean

		Public loadcalc As Boolean

		Public loadactiv As Boolean

		Public loadbilan As Boolean

		Public loadgarden As Boolean

		Public loadbddrot As Boolean

		Public loadbddass As Boolean

		Public loadbiblio As Boolean

		Public loadcal As Boolean

		Public loadhelp As Boolean

		Public loadmoon As Boolean

		Public loadapropos As Boolean

		Public couleurs As Color()

		Public couleurscont As Color()

		Public COULEURSUTILES As Color()

		Public colortypefam As Color()

		Public PATHS As String()

		Public Legumes_selectionnésconvertis As Integer()

		Public Contraintes_selectionnéesconvertis As Integer()

		Public Notepp As Integer()

		Public Notepc As Integer()

		Public Notecc As Integer

		Public NOTESASS As Integer()

		Public nbrlegumesbase As Integer

		Public nbranecdote As Integer

		Public nbrmaxcontraintes As Integer

		Public nbrmaxparcelles As Integer

		Public nbrrotationoptimisees1 As Integer

		Public nbrrotationoptimisees2 As Integer

		Public nbrsolutionoptimisees As Integer

		Public numerocombinaisonrotation1 As Integer

		Public numerocombinaisonrotation2 As Integer

		Public factnumeroparcelle As Integer

		Public NOTEASSMAX As Integer

		Public NOTEMAX1 As Integer

		Public NOTEMAX2 As Integer

		Public nbrfrontierespartagees As Integer

		Public nbrcellulesutilisees As Integer

		Public COMBINAISONS As String()

		Public codecombinaisonchoisie1 As String

		Public codecombinaisonchoisie2 As String

		Public RESULTSASS As String(,)

		Public RESULTSROT1 As String(,)

		Public RESULTSROT2 As String(,)

		Public nomfiche As String

		Public grille2infosbulle As String(,)

		Public modiffiche As String

		Sub New()
			Module1.Destdir = String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "\SVPLC")
			Module1.TTfiltre = New ToolTip()
			Module1.TTfiltred = New ToolTip()
		End Sub

		Public Sub filtredrawitemb(ByVal sender As Object, ByVal e As DrawItemEventArgs)
			Dim rectangle As System.Drawing.Rectangle
			Dim bounds As System.Drawing.Rectangle
			Dim point As System.Drawing.Point
			Dim bounds1 As System.Drawing.Rectangle
			Dim index As Object()
			If (e.Index = -1) Then
				Module1.TTfiltre.Hide(DirectCast(sender, IWin32Window))
			ElseIf (Not Conversions.ToBoolean(NewLateBinding.LateGet(sender, Nothing, "DroppedDown", New Object(-1) {}, Nothing, Nothing, Nothing))) Then
				Dim graphics As System.Drawing.Graphics = e.Graphics
				Dim white As System.Drawing.Brush = Brushes.White
				bounds1 = e.Bounds
				Dim location As System.Drawing.Point = bounds1.Location
				bounds = e.Bounds
				rectangle = New System.Drawing.Rectangle(location, bounds.Size)
				graphics.FillRectangle(white, rectangle)
				Dim graphic As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font As System.Drawing.Font = e.Font
				Dim black As System.Drawing.Brush = Brushes.Black
				bounds1 = e.Bounds
				Dim x As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(x, bounds.Y)
				graphic.DrawString(str, font, black, point)
			ElseIf ((e.State And DrawItemState.Selected) <> DrawItemState.Selected) Then
				e.DrawBackground()
				Dim graphics1 As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str1 As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font1 As System.Drawing.Font = e.Font
				Dim brush As System.Drawing.Brush = Brushes.Black
				bounds1 = e.Bounds
				Dim num As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(num, bounds.Y)
				graphics1.DrawString(str1, font1, brush, point)
			Else
				Dim tTfiltre As ToolTip = Module1.TTfiltre
				Dim str2 As String = Module1.ttcbb(e.Index)
				Dim win32Window As IWin32Window = DirectCast(sender, IWin32Window)
				rectangle = e.Bounds
				Dim x1 As Integer = rectangle.X
				bounds = e.Bounds
				Dim width As Integer = x1 + bounds.Width
				Dim position As System.Drawing.Point = Cursor.Position
				Dim obj As Object = Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(position.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(sender, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing)), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, Nothing, "parent", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing)), Module1.screenadaptY(30))
				Dim location1 As System.Drawing.Point = Form.ActiveForm.Location
				point = New System.Drawing.Point(width, Conversions.ToInteger(Operators.SubtractObject(obj, location1.Y)))
				tTfiltre.Show(str2, win32Window, point, 2000)
				Dim graphic1 As System.Drawing.Graphics = e.Graphics
				Dim chartreuse As System.Drawing.Brush = Brushes.Chartreuse
				Dim point1 As System.Drawing.Point = e.Bounds.Location
				rectangle = e.Bounds
				bounds1 = New System.Drawing.Rectangle(point1, rectangle.Size)
				graphic1.FillRectangle(chartreuse, bounds1)
				Dim graphics2 As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str3 As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font2 As System.Drawing.Font = e.Font
				Dim white1 As System.Drawing.Brush = Brushes.White
				bounds1 = e.Bounds
				Dim num1 As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(num1, bounds.Y)
				graphics2.DrawString(str3, font2, white1, point)
			End If
		End Sub

		Public Sub filtredrawitemcont(ByVal sender As Object, ByVal e As DrawItemEventArgs)
			Dim rectangle As System.Drawing.Rectangle
			Dim bounds As System.Drawing.Rectangle
			Dim point As System.Drawing.Point
			Dim bounds1 As System.Drawing.Rectangle
			Dim index As Object()
			If (e.Index < 1) Then
				Module1.TTfiltred.Hide(DirectCast(sender, IWin32Window))
			ElseIf (Not Conversions.ToBoolean(NewLateBinding.LateGet(sender, Nothing, "DroppedDown", New Object(-1) {}, Nothing, Nothing, Nothing))) Then
				Dim graphics As System.Drawing.Graphics = e.Graphics
				Dim white As System.Drawing.Brush = Brushes.White
				bounds1 = e.Bounds
				Dim location As System.Drawing.Point = bounds1.Location
				bounds = e.Bounds
				rectangle = New System.Drawing.Rectangle(location, bounds.Size)
				graphics.FillRectangle(white, rectangle)
				Dim graphic As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font As System.Drawing.Font = e.Font
				Dim black As System.Drawing.Brush = Brushes.Black
				bounds1 = e.Bounds
				Dim x As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(x, bounds.Y)
				graphic.DrawString(str, font, black, point)
			ElseIf ((e.State And DrawItemState.Selected) <> DrawItemState.Selected) Then
				e.DrawBackground()
				Dim graphics1 As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str1 As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font1 As System.Drawing.Font = e.Font
				Dim brush As System.Drawing.Brush = Brushes.Black
				bounds1 = e.Bounds
				Dim num As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(num, bounds.Y)
				graphics1.DrawString(str1, font1, brush, point)
			Else
				Dim tTfiltred As ToolTip = Module1.TTfiltred
				Dim str2 As String = Module1.ttcbb(e.Index)
				Dim win32Window As IWin32Window = DirectCast(sender, IWin32Window)
				rectangle = e.Bounds
				Dim x1 As Integer = rectangle.X
				bounds = e.Bounds
				Dim width As Integer = x1 + bounds.Width
				Dim position As System.Drawing.Point = Cursor.Position
				Dim obj As Object = Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(position.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(sender, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing)), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(sender, Nothing, "parent", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing)), Module1.screenadaptY(30))
				Dim location1 As System.Drawing.Point = Form.ActiveForm.Location
				point = New System.Drawing.Point(width, Conversions.ToInteger(Operators.SubtractObject(obj, location1.Y)))
				tTfiltred.Show(str2, win32Window, point, 1500)
				Dim graphic1 As System.Drawing.Graphics = e.Graphics
				Dim blue As System.Drawing.Brush = Brushes.Blue
				Dim point1 As System.Drawing.Point = e.Bounds.Location
				rectangle = e.Bounds
				bounds1 = New System.Drawing.Rectangle(point1, rectangle.Size)
				graphic1.FillRectangle(blue, bounds1)
				Dim graphics2 As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str3 As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font2 As System.Drawing.Font = e.Font
				Dim white1 As System.Drawing.Brush = Brushes.White
				bounds1 = e.Bounds
				Dim num1 As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(num1, bounds.Y)
				graphics2.DrawString(str3, font2, white1, point)
			End If
		End Sub

		Public Sub filtredrawitemdh(ByVal sender As Object, ByVal e As DrawItemEventArgs)
			Dim rectangle As System.Drawing.Rectangle
			Dim bounds As System.Drawing.Rectangle
			Dim point As System.Drawing.Point
			Dim bounds1 As System.Drawing.Rectangle
			Dim index As Object()
			If (e.Index < 1) Then
				Module1.TTfiltred.Hide(DirectCast(sender, IWin32Window))
			ElseIf (Not Conversions.ToBoolean(NewLateBinding.LateGet(sender, Nothing, "DroppedDown", New Object(-1) {}, Nothing, Nothing, Nothing))) Then
				Dim graphics As System.Drawing.Graphics = e.Graphics
				Dim white As System.Drawing.Brush = Brushes.White
				bounds1 = e.Bounds
				Dim location As System.Drawing.Point = bounds1.Location
				bounds = e.Bounds
				rectangle = New System.Drawing.Rectangle(location, bounds.Size)
				graphics.FillRectangle(white, rectangle)
				Dim graphic As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font As System.Drawing.Font = e.Font
				Dim black As System.Drawing.Brush = Brushes.Black
				bounds1 = e.Bounds
				Dim x As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(x, bounds.Y)
				graphic.DrawString(str, font, black, point)
			ElseIf ((e.State And DrawItemState.Selected) <> DrawItemState.Selected) Then
				e.DrawBackground()
				Dim graphics1 As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str1 As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font1 As System.Drawing.Font = e.Font
				Dim brush As System.Drawing.Brush = Brushes.Black
				bounds1 = e.Bounds
				Dim num As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(num, bounds.Y)
				graphics1.DrawString(str1, font1, brush, point)
			Else
				Dim tTfiltred As ToolTip = Module1.TTfiltred
				Dim str2 As String = Module1.ttcbb(e.Index - 1)
				Dim win32Window As IWin32Window = DirectCast(sender, IWin32Window)
				rectangle = e.Bounds
				Dim x1 As Integer = rectangle.X
				bounds = e.Bounds
				Dim width As Integer = x1 + bounds.Width
				Dim position As System.Drawing.Point = Cursor.Position
				Dim obj As Object = Operators.SubtractObject(Operators.SubtractObject(position.Y, NewLateBinding.LateGet(NewLateBinding.LateGet(sender, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing)), Module1.screenadaptY(30))
				Dim location1 As System.Drawing.Point = Form.ActiveForm.Location
				point = New System.Drawing.Point(width, Conversions.ToInteger(Operators.SubtractObject(obj, location1.Y)))
				tTfiltred.Show(str2, win32Window, point, 2000)
				Dim graphic1 As System.Drawing.Graphics = e.Graphics
				Dim blue As System.Drawing.Brush = Brushes.Blue
				Dim point1 As System.Drawing.Point = e.Bounds.Location
				rectangle = e.Bounds
				bounds1 = New System.Drawing.Rectangle(point1, rectangle.Size)
				graphic1.FillRectangle(blue, bounds1)
				Dim graphics2 As System.Drawing.Graphics = e.Graphics
				index = New Object() { e.Index }
				Dim str3 As String = NewLateBinding.LateGet(sender, Nothing, "Items", index, Nothing, Nothing, Nothing).ToString()
				Dim font2 As System.Drawing.Font = e.Font
				Dim white1 As System.Drawing.Brush = Brushes.White
				bounds1 = e.Bounds
				Dim num1 As Integer = bounds1.X
				bounds = e.Bounds
				point = New System.Drawing.Point(num1, bounds.Y)
				graphics2.DrawString(str3, font2, white1, point)
			End If
		End Sub

		Public Function indexlegume(ByVal str As String) As Object
			Dim num As Integer = Module1.nbrlegumesbase - 1
			Dim num1 As Integer = 0
			Do
				If (Operators.CompareString(str, Module1.listelégumes(num1), False) = 0) Then
					Return num1
				End If
				num1 = num1 + 1
			Loop While num1 <= num
			Return -1
		End Function

		Public Function screenadaptfont(ByVal x As Integer) As Integer
			Return x
		End Function

		Public Function screenadaptX(ByVal x As Integer) As Integer
			Dim num As Integer = Convert.ToInt32(Math.Round(Decimal.Multiply(New Decimal(x), MyProject.Application.PL)))
			Return num
		End Function

		Public Function screenadaptY(ByVal x As Integer) As Integer
			Dim num As Integer = Convert.ToInt32(Math.Round(Decimal.Multiply(New Decimal(x), MyProject.Application.PH)))
			Return num
		End Function

		Public Function SptRg1(ByVal str As String) As Object
			Return Strings.Mid(str, 1, 1)
		End Function

		Public Function SptRg2(ByVal str As String) As Object
			Return Strings.Mid(str, 2)
		End Function
	End Module
End Namespace