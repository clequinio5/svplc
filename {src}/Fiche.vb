Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class Fiche
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("PictureBoxlbl2")>
		Private _PictureBoxlbl2 As PictureBox

		<AccessedThroughProperty("PictureBoxlbl4")>
		Private _PictureBoxlbl4 As PictureBox

		<AccessedThroughProperty("PictureBoxlbl3")>
		Private _PictureBoxlbl3 As PictureBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		<AccessedThroughProperty("Labelclock")>
		Private _Labelclock As Label

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		<AccessedThroughProperty("Labeldensite")>
		Private _Labeldensite As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("PictureBoximg")>
		Private _PictureBoximg As PictureBox

		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		<AccessedThroughProperty("TransparentRichTextBox1")>
		Private _TransparentRichTextBox1 As TransparentRichTextBox

		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		<AccessedThroughProperty("MyGroupBox21")>
		Private _MyGroupBox21 As myGroupBox2

		<AccessedThroughProperty("PictureBoximag")>
		Private _PictureBoximag As PictureBox

		Private pathfiche As String

		Private pathimage As String

		Private nomfichier As String

		Private nomfich As String

		Private compt As Integer

		Private mouse_offset As Point

		Private mousePos As Point

		Private lines As List(Of String)

		Friend Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.Label2_DoubleClick)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.Label2_MouseLeave)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.Label2_MouseEnter)
				If (Me._Label2 IsNot Nothing) Then
					RemoveHandler Me._Label2.DoubleClick,  eventHandler
					RemoveHandler Me._Label2.MouseLeave,  eventHandler1
					RemoveHandler Me._Label2.MouseEnter,  eventHandler2
				End If
				Me._Label2 = value
				If (Me._Label2 IsNot Nothing) Then
					AddHandler Me._Label2.DoubleClick,  eventHandler
					AddHandler Me._Label2.MouseLeave,  eventHandler1
					AddHandler Me._Label2.MouseEnter,  eventHandler2
				End If
			End Set
		End Property

		Friend Overridable Property Label3 As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.Label3_DoubleClick)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.Label3_MouseLeave)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.Label3_MouseEnter)
				If (Me._Label3 IsNot Nothing) Then
					RemoveHandler Me._Label3.DoubleClick,  eventHandler
					RemoveHandler Me._Label3.MouseLeave,  eventHandler1
					RemoveHandler Me._Label3.MouseEnter,  eventHandler2
				End If
				Me._Label3 = value
				If (Me._Label3 IsNot Nothing) Then
					AddHandler Me._Label3.DoubleClick,  eventHandler
					AddHandler Me._Label3.MouseLeave,  eventHandler1
					AddHandler Me._Label3.MouseEnter,  eventHandler2
				End If
			End Set
		End Property

		Friend Overridable Property Label4 As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.Label4_DoubleClick)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.Label4_MouseLeave)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.Label4_MouseEnter)
				If (Me._Label4 IsNot Nothing) Then
					RemoveHandler Me._Label4.DoubleClick,  eventHandler
					RemoveHandler Me._Label4.MouseLeave,  eventHandler1
					RemoveHandler Me._Label4.MouseEnter,  eventHandler2
				End If
				Me._Label4 = value
				If (Me._Label4 IsNot Nothing) Then
					AddHandler Me._Label4.DoubleClick,  eventHandler
					AddHandler Me._Label4.MouseLeave,  eventHandler1
					AddHandler Me._Label4.MouseEnter,  eventHandler2
				End If
			End Set
		End Property

		Friend Overridable Property Label6 As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property Labelclock As Label
			Get
				Return Me._Labelclock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.Label6_DoubleClick)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.Labelclock_MouseLeave)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.Labelclock_MouseEnter)
				If (Me._Labelclock IsNot Nothing) Then
					RemoveHandler Me._Labelclock.DoubleClick,  eventHandler
					RemoveHandler Me._Labelclock.MouseLeave,  eventHandler1
					RemoveHandler Me._Labelclock.MouseEnter,  eventHandler2
				End If
				Me._Labelclock = value
				If (Me._Labelclock IsNot Nothing) Then
					AddHandler Me._Labelclock.DoubleClick,  eventHandler
					AddHandler Me._Labelclock.MouseLeave,  eventHandler1
					AddHandler Me._Labelclock.MouseEnter,  eventHandler2
				End If
			End Set
		End Property

		Friend Overridable Property Labeldensite As Label
			Get
				Return Me._Labeldensite
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.Labeldensite_DoubleClick)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.Labeldensite_MouseLeave)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.Labeldensite_MouseEnter)
				If (Me._Labeldensite IsNot Nothing) Then
					RemoveHandler Me._Labeldensite.DoubleClick,  eventHandler
					RemoveHandler Me._Labeldensite.MouseLeave,  eventHandler1
					RemoveHandler Me._Labeldensite.MouseEnter,  eventHandler2
				End If
				Me._Labeldensite = value
				If (Me._Labeldensite IsNot Nothing) Then
					AddHandler Me._Labeldensite.DoubleClick,  eventHandler
					AddHandler Me._Labeldensite.MouseLeave,  eventHandler1
					AddHandler Me._Labeldensite.MouseEnter,  eventHandler2
				End If
			End Set
		End Property

		Friend Overridable Property MyGroupBox21 As myGroupBox2
			Get
				Return Me._MyGroupBox21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox2)
				Me._MyGroupBox21 = value
			End Set
		End Property

		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			Get
				Return Me._OpenFileDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As OpenFileDialog)
				Me._OpenFileDialog1 = value
			End Set
		End Property

		Friend Overridable Property PictureBox1 As PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		Friend Overridable Property PictureBox2 As PictureBox
			Get
				Return Me._PictureBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		Friend Overridable Property PictureBox3 As PictureBox
			Get
				Return Me._PictureBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.PictureBox3_Click)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.PictureBox3_MouseLeave)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.PictureBox3_MouseEnter)
				If (Me._PictureBox3 IsNot Nothing) Then
					RemoveHandler Me._PictureBox3.Click,  eventHandler
					RemoveHandler Me._PictureBox3.MouseLeave,  eventHandler1
					RemoveHandler Me._PictureBox3.MouseEnter,  eventHandler2
				End If
				Me._PictureBox3 = value
				If (Me._PictureBox3 IsNot Nothing) Then
					AddHandler Me._PictureBox3.Click,  eventHandler
					AddHandler Me._PictureBox3.MouseLeave,  eventHandler1
					AddHandler Me._PictureBox3.MouseEnter,  eventHandler2
				End If
			End Set
		End Property

		Friend Overridable Property PictureBox5 As PictureBox
			Get
				Return Me._PictureBox5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox5 = value
			End Set
		End Property

		Friend Overridable Property PictureBoximag As PictureBox
			Get
				Return Me._PictureBoximag
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.PictureBoximage_mouseleave)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.PictureBoximage_mouseenter)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.PictureBoximage_DoubleClick)
				If (Me._PictureBoximag IsNot Nothing) Then
					RemoveHandler Me._PictureBoximag.MouseLeave,  eventHandler
					RemoveHandler Me._PictureBoximag.MouseEnter,  eventHandler1
					RemoveHandler Me._PictureBoximag.DoubleClick,  eventHandler2
				End If
				Me._PictureBoximag = value
				If (Me._PictureBoximag IsNot Nothing) Then
					AddHandler Me._PictureBoximag.MouseLeave,  eventHandler
					AddHandler Me._PictureBoximag.MouseEnter,  eventHandler1
					AddHandler Me._PictureBoximag.DoubleClick,  eventHandler2
				End If
			End Set
		End Property

		Friend Overridable Property PictureBoximg As PictureBox
			Get
				Return Me._PictureBoximg
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoximg = value
			End Set
		End Property

		Friend Overridable Property PictureBoxlbl2 As PictureBox
			Get
				Return Me._PictureBoxlbl2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoxlbl2 = value
			End Set
		End Property

		Friend Overridable Property PictureBoxlbl3 As PictureBox
			Get
				Return Me._PictureBoxlbl3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoxlbl3 = value
			End Set
		End Property

		Friend Overridable Property PictureBoxlbl4 As PictureBox
			Get
				Return Me._PictureBoxlbl4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoxlbl4 = value
			End Set
		End Property

		Friend Overridable Property TransparentRichTextBox1 As TransparentRichTextBox
			Get
				Return Me._TransparentRichTextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TransparentRichTextBox)
				Dim fiche As SVPLCApplication.Fiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf fiche.TransparentRichTextBox1_DoubleClick)
				Dim fiche1 As SVPLCApplication.Fiche = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf fiche1.TransparentRichTextBox1_MouseLeave)
				Dim fiche2 As SVPLCApplication.Fiche = Me
				Dim eventHandler2 As System.EventHandler = New System.EventHandler(AddressOf fiche2.TransparentRichTextBox1_MouseEnter)
				If (Me._TransparentRichTextBox1 IsNot Nothing) Then
					RemoveHandler Me._TransparentRichTextBox1.DoubleClick,  eventHandler
					RemoveHandler Me._TransparentRichTextBox1.MouseLeave,  eventHandler1
					RemoveHandler Me._TransparentRichTextBox1.MouseEnter,  eventHandler2
				End If
				Me._TransparentRichTextBox1 = value
				If (Me._TransparentRichTextBox1 IsNot Nothing) Then
					AddHandler Me._TransparentRichTextBox1.DoubleClick,  eventHandler
					AddHandler Me._TransparentRichTextBox1.MouseLeave,  eventHandler1
					AddHandler Me._TransparentRichTextBox1.MouseEnter,  eventHandler2
				End If
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim fiche1 As Fiche = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf fiche1.Fiche_Load)
			Dim fiche2 As Fiche = Me
			AddHandler MyBase.MouseDown,  New MouseEventHandler(AddressOf fiche2.Form1_MouseDown)
			Dim fiche3 As Fiche = Me
			AddHandler MyBase.MouseMove,  New MouseEventHandler(AddressOf fiche3.Form1_MouseMove)
			Me.InitializeComponent()
		End Sub

		Private Sub Chargement_fiche()
			Try
				Me.lines = File.ReadLines(Me.pathfiche, Encoding.[Default]).ToList()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso(String.Concat("Erreur chargement fiche ", Me.nomfich, " !"), "Erreur")
				Me.Close()
				ProjectData.ClearProjectError()
			End Try
			Try
				Me.Label1.Text = Me.lines(0)
				Me.Label3.Text = Me.lines(1)
				Me.Label4.Text = Me.lines(2)
				Me.Label2.Text = Me.lines(3)
				Me.Labelclock.Text = Me.lines(4)
				Me.Labeldensite.Text = Me.lines(5)
				If (Me.lines.Count <= 6) Then
					Me.TransparentRichTextBox1.Text = ""
				Else
					Me.TransparentRichTextBox1.Text = ""
					Dim count As Integer = Me.lines.Count - 1
					For i As Integer = 7 To count Step 1
						Dim transparentRichTextBox1 As TransparentRichTextBox = Me.TransparentRichTextBox1
						transparentRichTextBox1.Text = String.Concat(transparentRichTextBox1.Text, Me.lines(i), "" & VbCrLf & "")
					Next

				End If
			Catch exception1 As System.Exception
				ProjectData.SetProjectError(exception1)
				MyProject.Forms.FormPasPas.Msgboxperso(String.Concat("Erreur de chargement fiche ", Me.nomfich, " !"), "Erreur")
				Me.Close()
				ProjectData.ClearProjectError()
			End Try
		End Sub

		<DebuggerNonUserCode>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Try
				If (disposing AndAlso Me.components IsNot Nothing) Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		Private Sub Fiche_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Dim enumerator1 As IEnumerator = Nothing
			Me.nomfich = Me.Label1.Text
			Me.pathfiche = String.Concat(Module1.PATHS(12), "\", Me.nomfich, ".txt")
			Me.pathimage = String.Concat(Module1.PATHS(13), "\", Me.nomfich, ".png")
			If (Decimal.Compare(MyProject.Application.mincoeff, Decimal.One) < 0) Then
				Dim size As System.Drawing.Size = New System.Drawing.Size(Module1.screenadaptX(Me.Width), Module1.screenadaptY(Me.Height))
				Me.Size = size
				Try
					enumerator = Me.Controls.GetEnumerator()
					While enumerator.MoveNext()
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
						Dim obj As Object = objectValue
						Dim font(0) As Object
						size = New System.Drawing.Size(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(obj, Nothing, "width", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(obj, Nothing, "height", New Object(-1) {}, Nothing, Nothing, Nothing))))
						font(0) = size
						NewLateBinding.LateSet(obj, Nothing, "size", font, Nothing, Nothing)
						ReDim font(0)
						Dim point As System.Drawing.Point = New System.Drawing.Point(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "x", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing))))
						font(0) = point
						NewLateBinding.LateSet(obj, Nothing, "location", font, Nothing, Nothing)
						font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing))))) }
						NewLateBinding.LateSet(obj, Nothing, "font", font, Nothing, Nothing)
						obj = Nothing
						If (TypeOf objectValue Is myGroupBox) Then
							Try
								enumerator1 = DirectCast(NewLateBinding.LateGet(objectValue, Nothing, "controls", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator()
								While enumerator1.MoveNext()
									Dim objectValue1 As Object = RuntimeHelpers.GetObjectValue(enumerator1.Current)
									ReDim font(0)
									size = New System.Drawing.Size(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(objectValue1, Nothing, "width", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(objectValue1, Nothing, "height", New Object(-1) {}, Nothing, Nothing, Nothing))))
									font(0) = size
									NewLateBinding.LateSet(objectValue1, Nothing, "size", font, Nothing, Nothing)
									ReDim font(0)
									point = New System.Drawing.Point(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue1, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "x", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue1, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing))))
									font(0) = point
									NewLateBinding.LateSet(objectValue1, Nothing, "location", font, Nothing, Nothing)
									font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue1, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue1, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing))))) }
									NewLateBinding.LateSet(objectValue1, Nothing, "font", font, Nothing, Nothing)
									objectValue1 = Nothing
								End While
							Finally
								If (TypeOf enumerator1 Is IDisposable) Then
									TryCast(enumerator1, IDisposable).Dispose()
								End If
							End Try
						End If
						If (Not TypeOf objectValue Is Label) Then
							Continue While
						End If
						If (objectValue = Me.Label1) Then
							font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing)))), FontStyle.Underline) }
							NewLateBinding.LateSet(objectValue, Nothing, "font", font, Nothing, Nothing)
						ElseIf (objectValue = Me.Label6) Then
							font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing)))), FontStyle.Underline) }
							NewLateBinding.LateSet(objectValue, Nothing, "font", font, Nothing, Nothing)
						Else
							font = New Object() { Cursors.Hand }
							NewLateBinding.LateSet(objectValue, Nothing, "cursor", font, Nothing, Nothing)
						End If
					End While
				Finally
					If (TypeOf enumerator Is IDisposable) Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
			Me.PictureBoximag.Cursor = Cursors.Hand
			If (Not Directory.Exists(Module1.PATHS(12))) Then
				Directory.CreateDirectory(Module1.PATHS(12))
				File.WriteAllText(Me.pathfiche, String.Concat(Me.nomfich, "" & VbCrLf & "0 cm" & VbCrLf & "0 cm" & VbCrLf & "0 cm" & VbCrLf & "0 semaines" & VbCrLf & "0/m²" & VbCrLf & ""), Encoding.[Default])
				Me.Chargement_fiche()
			ElseIf (Not File.Exists(Me.pathfiche)) Then
				File.WriteAllText(Me.pathfiche, String.Concat(Me.nomfich, "" & VbCrLf & "0 cm" & VbCrLf & "0 cm" & VbCrLf & "0 cm" & VbCrLf & "0 semaines" & VbCrLf & "0/m²" & VbCrLf & ""), Encoding.[Default])
				Me.Chargement_fiche()
			Else
				Me.Chargement_fiche()
			End If
			If (File.Exists(Me.pathimage)) Then
				Me.PictureBoximag.BackgroundImage = Image.FromFile(Me.pathimage)
			End If
		End Sub

		Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.mouse_offset = New Point(0 - e.X, 0 - e.Y)
		End Sub

		Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			If (e.Button = System.Windows.Forms.MouseButtons.Left) Then
				Me.mousePos = Control.MousePosition
				Me.mousePos.Offset(Me.mouse_offset.X, Me.mouse_offset.Y)
				Me.Location = Me.mousePos
			End If
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fiche))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.PictureBoxlbl2 = New System.Windows.Forms.PictureBox()
			Me.PictureBoxlbl4 = New System.Windows.Forms.PictureBox()
			Me.PictureBoxlbl3 = New System.Windows.Forms.PictureBox()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.PictureBox5 = New System.Windows.Forms.PictureBox()
			Me.Labelclock = New System.Windows.Forms.Label()
			Me.PictureBox2 = New System.Windows.Forms.PictureBox()
			Me.Labeldensite = New System.Windows.Forms.Label()
			Me.Label6 = New System.Windows.Forms.Label()
			Me.OpenFileDialog1 = New OpenFileDialog()
			Me.PictureBox3 = New System.Windows.Forms.PictureBox()
			Me.PictureBoximg = New System.Windows.Forms.PictureBox()
			Me.MyGroupBox21 = New myGroupBox2()
			Me.PictureBoximag = New System.Windows.Forms.PictureBox()
			Me.TransparentRichTextBox1 = New SVPLCApplication.TransparentRichTextBox()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBoxlbl2, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBoxlbl4, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBoxlbl3, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox5, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox3, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBoximg, ISupportInitialize).BeginInit()
			Me.MyGroupBox21.SuspendLayout()
			DirectCast(Me.PictureBoximag, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Label1.BackColor = Color.Transparent
			Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Underline, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.SaddleBrown
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(134, 48)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(281, 35)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Label1"
			Me.Label1.TextAlign = ContentAlignment.MiddleCenter
			Me.PictureBox1.BackColor = Color.Transparent
			Me.PictureBox1.BackgroundImage = Resources.champ
			Me.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(115, 106)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(319, 131)
			pictureBox.Size = size
			Me.PictureBox1.TabIndex = 2
			Me.PictureBox1.TabStop = False
			Me.PictureBoxlbl2.BackColor = Color.Transparent
			Me.PictureBoxlbl2.BackgroundImage = Resources.flechbleu
			Me.PictureBoxlbl2.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBoxlbl2 As System.Windows.Forms.PictureBox = Me.PictureBoxlbl2
			point = New System.Drawing.Point(331, 106)
			pictureBoxlbl2.Location = point
			Me.PictureBoxlbl2.Name = "PictureBoxlbl2"
			Dim pictureBoxlbl21 As System.Windows.Forms.PictureBox = Me.PictureBoxlbl2
			size = New System.Drawing.Size(69, 19)
			pictureBoxlbl21.Size = size
			Me.PictureBoxlbl2.TabIndex = 3
			Me.PictureBoxlbl2.TabStop = False
			Me.PictureBoxlbl4.BackColor = Color.Transparent
			Me.PictureBoxlbl4.BackgroundImage = Resources.flecheinbleu
			Me.PictureBoxlbl4.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBoxlbl4 As System.Windows.Forms.PictureBox = Me.PictureBoxlbl4
			point = New System.Drawing.Point(372, 178)
			pictureBoxlbl4.Location = point
			Me.PictureBoxlbl4.Name = "PictureBoxlbl4"
			Dim pictureBoxlbl41 As System.Windows.Forms.PictureBox = Me.PictureBoxlbl4
			size = New System.Drawing.Size(43, 42)
			pictureBoxlbl41.Size = size
			Me.PictureBoxlbl4.TabIndex = 4
			Me.PictureBoxlbl4.TabStop = False
			Me.PictureBoxlbl3.BackColor = Color.Transparent
			Me.PictureBoxlbl3.BackgroundImage = Resources.flecheverbleu
			Me.PictureBoxlbl3.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBoxlbl3 As System.Windows.Forms.PictureBox = Me.PictureBoxlbl3
			point = New System.Drawing.Point(115, 184)
			pictureBoxlbl3.Location = point
			Me.PictureBoxlbl3.Name = "PictureBoxlbl3"
			Dim pictureBoxlbl31 As System.Windows.Forms.PictureBox = Me.PictureBoxlbl3
			size = New System.Drawing.Size(18, 23)
			pictureBoxlbl31.Size = size
			Me.PictureBoxlbl3.TabIndex = 5
			Me.PictureBoxlbl3.TabStop = False
			Me.Label2.BackColor = Color.Transparent
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(331, 87)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(69, 16)
			label21.Size = size
			Me.Label2.TabIndex = 6
			Me.Label2.Text = "Label2"
			Me.Label2.TextAlign = ContentAlignment.MiddleCenter
			Me.Label3.BackColor = Color.Transparent
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(27, 186)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(83, 16)
			label31.Size = size
			Me.Label3.TabIndex = 7
			Me.Label3.Text = "Label3"
			Me.Label3.TextAlign = ContentAlignment.MiddleRight
			Me.Label4.BackColor = Color.Transparent
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(402, 204)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(59, 16)
			label41.Size = size
			Me.Label4.TabIndex = 8
			Me.Label4.Text = "Label4"
			Me.Label4.TextAlign = ContentAlignment.MiddleLeft
			Me.PictureBox5.BackColor = Color.Transparent
			Me.PictureBox5.BackgroundImage = Resources.clock
			Me.PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox5 As System.Windows.Forms.PictureBox = Me.PictureBox5
			point = New System.Drawing.Point(317, 238)
			pictureBox5.Location = point
			Me.PictureBox5.Name = "PictureBox5"
			Dim pictureBox51 As System.Windows.Forms.PictureBox = Me.PictureBox5
			size = New System.Drawing.Size(22, 22)
			pictureBox51.Size = size
			Me.PictureBox5.TabIndex = 10
			Me.PictureBox5.TabStop = False
			Me.Labelclock.AutoSize = True
			Me.Labelclock.BackColor = Color.Transparent
			Dim labelclock As System.Windows.Forms.Label = Me.Labelclock
			point = New System.Drawing.Point(346, 242)
			labelclock.Location = point
			Me.Labelclock.Name = "Labelclock"
			Dim labelclock1 As System.Windows.Forms.Label = Me.Labelclock
			size = New System.Drawing.Size(59, 13)
			labelclock1.Size = size
			Me.Labelclock.TabIndex = 11
			Me.Labelclock.Text = "Labelclock"
			Me.PictureBox2.BackColor = Color.Transparent
			Me.PictureBox2.BackgroundImage = Resources.densite
			Me.PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox2
			point = New System.Drawing.Point(117, 238)
			pictureBox2.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox21 As System.Windows.Forms.PictureBox = Me.PictureBox2
			size = New System.Drawing.Size(20, 20)
			pictureBox21.Size = size
			Me.PictureBox2.TabIndex = 12
			Me.PictureBox2.TabStop = False
			Me.Labeldensite.AutoSize = True
			Me.Labeldensite.BackColor = Color.Transparent
			Dim labeldensite As System.Windows.Forms.Label = Me.Labeldensite
			point = New System.Drawing.Point(143, 242)
			labeldensite.Location = point
			Me.Labeldensite.Name = "Labeldensite"
			Dim labeldensite1 As System.Windows.Forms.Label = Me.Labeldensite
			size = New System.Drawing.Size(67, 13)
			labeldensite1.Size = size
			Me.Labeldensite.TabIndex = 13
			Me.Labeldensite.Text = "Labeldensite"
			Me.Label6.AutoSize = True
			Me.Label6.BackColor = Color.Transparent
			Me.Label6.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Underline, GraphicsUnit.Point, 0)
			Dim label6 As System.Windows.Forms.Label = Me.Label6
			point = New System.Drawing.Point(58, 277)
			label6.Location = point
			Me.Label6.Name = "Label6"
			Dim label61 As System.Windows.Forms.Label = Me.Label6
			size = New System.Drawing.Size(71, 15)
			label61.Size = size
			Me.Label6.TabIndex = 15
			Me.Label6.Text = "Conseils :"
			Me.OpenFileDialog1.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg"
			Me.PictureBox3.BackColor = Color.Transparent
			Me.PictureBox3.BackgroundImage = Resources.delmarron
			Me.PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox3 As System.Windows.Forms.PictureBox = Me.PictureBox3
			point = New System.Drawing.Point(469, 35)
			pictureBox3.Location = point
			Me.PictureBox3.Name = "PictureBox3"
			Dim pictureBox31 As System.Windows.Forms.PictureBox = Me.PictureBox3
			size = New System.Drawing.Size(30, 30)
			pictureBox31.Size = size
			Me.PictureBox3.TabIndex = 17
			Me.PictureBox3.TabStop = False
			Me.PictureBoximg.BackColor = Color.Transparent
			Me.PictureBoximg.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBoximg As System.Windows.Forms.PictureBox = Me.PictureBoximg
			point = New System.Drawing.Point(4, 4)
			pictureBoximg.Location = point
			Me.PictureBoximg.Name = "PictureBoximg"
			Dim pictureBoximg1 As System.Windows.Forms.PictureBox = Me.PictureBoximg
			size = New System.Drawing.Size(60, 60)
			pictureBoximg1.Size = size
			Me.PictureBoximg.TabIndex = 17
			Me.PictureBoximg.TabStop = False
			Me.MyGroupBox21.BackColor = Color.Transparent
			Me.MyGroupBox21.BorderColor = Color.Wheat
			Me.MyGroupBox21.Controls.Add(Me.PictureBoximag)
			Me.MyGroupBox21.Diagonale = 0
			Me.MyGroupBox21.ForeColor = Color.Black
			Dim myGroupBox21 As myGroupBox2 = Me.MyGroupBox21
			point = New System.Drawing.Point(53, 49)
			myGroupBox21.Location = point
			Me.MyGroupBox21.Name = "MyGroupBox21"
			Me.MyGroupBox21.Padding = New System.Windows.Forms.Padding(3)
			Dim _myGroupBox2 As myGroupBox2 = Me.MyGroupBox21
			size = New System.Drawing.Size(76, 76)
			_myGroupBox2.Size = size
			Me.MyGroupBox21.TabIndex = 19
			Me.MyGroupBox21.Thickness = 4
			Me.MyGroupBox21.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.PictureBoximag.BackgroundImageLayout = ImageLayout.Stretch
			Me.PictureBoximag.Dock = DockStyle.Fill
			Dim pictureBoximag As System.Windows.Forms.PictureBox = Me.PictureBoximag
			point = New System.Drawing.Point(3, 3)
			pictureBoximag.Location = point
			Me.PictureBoximag.Name = "PictureBoximag"
			Dim pictureBoximag1 As System.Windows.Forms.PictureBox = Me.PictureBoximag
			size = New System.Drawing.Size(70, 70)
			pictureBoximag1.Size = size
			Me.PictureBoximag.TabIndex = 0
			Me.PictureBoximag.TabStop = False
			Me.TransparentRichTextBox1.BorderStyle = BorderStyle.None
			Me.TransparentRichTextBox1.Cursor = Cursors.Hand
			Me.TransparentRichTextBox1.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim transparentRichTextBox1 As SVPLCApplication.TransparentRichTextBox = Me.TransparentRichTextBox1
			point = New System.Drawing.Point(57, 314)
			transparentRichTextBox1.Location = point
			Me.TransparentRichTextBox1.Name = "TransparentRichTextBox1"
			Me.TransparentRichTextBox1.[ReadOnly] = True
			Me.TransparentRichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
			Dim transparentRichTextBox As SVPLCApplication.TransparentRichTextBox = Me.TransparentRichTextBox1
			size = New System.Drawing.Size(428, 385)
			transparentRichTextBox.Size = size
			Me.TransparentRichTextBox1.TabIndex = 16
			Me.TransparentRichTextBox1.Text = ""
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.LightGray
			Me.BackgroundImage = Resources.Parchemin
			Me.BackgroundImageLayout = ImageLayout.Stretch
			size = New System.Drawing.Size(537, 753)
			Me.ClientSize = size
			Me.Controls.Add(Me.MyGroupBox21)
			Me.Controls.Add(Me.PictureBox3)
			Me.Controls.Add(Me.TransparentRichTextBox1)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Labeldensite)
			Me.Controls.Add(Me.PictureBox2)
			Me.Controls.Add(Me.Labelclock)
			Me.Controls.Add(Me.PictureBox5)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.PictureBoxlbl3)
			Me.Controls.Add(Me.PictureBoxlbl4)
			Me.Controls.Add(Me.PictureBoxlbl2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Label1)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.Name = "Fiche"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Fiche"
			Me.TransparencyKey = Color.LightGray
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBoxlbl2, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBoxlbl4, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBoxlbl3, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox5, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox3, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBoximg, ISupportInitialize).EndInit()
			Me.MyGroupBox21.ResumeLayout(False)
			DirectCast(Me.PictureBoximag, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub Label2_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim formchangefiche As SVPLCApplication.Formchangefiche = New SVPLCApplication.Formchangefiche()
			formchangefiche.RichTextBox1.Text = Me.Label2.Text
			If (formchangefiche.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim list As List(Of String) = File.ReadLines(Me.pathfiche, Encoding.[Default]).ToList()
				list(3) = Module1.modiffiche
				File.WriteAllLines(Me.pathfiche, list, Encoding.[Default])
				Me.Chargement_fiche()
			End If
		End Sub

		Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.Label2.ForeColor = Color.Goldenrod
			Me.PictureBoxlbl2.BackgroundImage = Resources.flechejaune
		End Sub

		Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.Label2.ForeColor = Color.Black
			Me.PictureBoxlbl2.BackgroundImage = Resources.flechbleu
		End Sub

		Private Sub Label3_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim formchangefiche As SVPLCApplication.Formchangefiche = New SVPLCApplication.Formchangefiche()
			formchangefiche.RichTextBox1.Text = Me.Label3.Text
			If (formchangefiche.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim list As List(Of String) = File.ReadLines(Me.pathfiche, Encoding.[Default]).ToList()
				list(1) = Module1.modiffiche
				File.WriteAllLines(Me.pathfiche, list, Encoding.[Default])
				Me.Chargement_fiche()
			End If
		End Sub

		Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.Label3.ForeColor = Color.Goldenrod
			Me.PictureBoxlbl3.BackgroundImage = Resources.flecheverjaune
		End Sub

		Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.Label3.ForeColor = Color.Black
			Me.PictureBoxlbl3.BackgroundImage = Resources.flecheverbleu
		End Sub

		Private Sub Label4_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim formchangefiche As SVPLCApplication.Formchangefiche = New SVPLCApplication.Formchangefiche()
			formchangefiche.RichTextBox1.Text = Me.Label4.Text
			If (formchangefiche.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim list As List(Of String) = File.ReadLines(Me.pathfiche, Encoding.[Default]).ToList()
				list(2) = Module1.modiffiche
				File.WriteAllLines(Me.pathfiche, list, Encoding.[Default])
				Me.Chargement_fiche()
			End If
		End Sub

		Private Sub Label4_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.Label4.ForeColor = Color.Goldenrod
			Me.PictureBoxlbl4.BackgroundImage = Resources.flecheinjaune
		End Sub

		Private Sub Label4_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.Label4.ForeColor = Color.Black
			Me.PictureBoxlbl4.BackgroundImage = Resources.flecheinbleu
		End Sub

		Private Sub Label6_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim formchangefiche As SVPLCApplication.Formchangefiche = New SVPLCApplication.Formchangefiche()
			formchangefiche.RichTextBox1.Text = Me.Labelclock.Text
			If (formchangefiche.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim list As List(Of String) = File.ReadLines(Me.pathfiche, Encoding.[Default]).ToList()
				list(4) = Module1.modiffiche
				File.WriteAllLines(Me.pathfiche, list, Encoding.[Default])
				Me.Chargement_fiche()
			End If
		End Sub

		Private Sub Labelclock_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.Labelclock.ForeColor = Color.Goldenrod
		End Sub

		Private Sub Labelclock_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.Labelclock.ForeColor = Color.Black
		End Sub

		Private Sub Labeldensite_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim formchangefiche As SVPLCApplication.Formchangefiche = New SVPLCApplication.Formchangefiche()
			formchangefiche.RichTextBox1.Text = Me.Labeldensite.Text
			If (formchangefiche.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim list As List(Of String) = File.ReadLines(Me.pathfiche, Encoding.[Default]).ToList()
				list(5) = Module1.modiffiche
				File.WriteAllLines(Me.pathfiche, list, Encoding.[Default])
				Me.Chargement_fiche()
			End If
		End Sub

		Private Sub Labeldensite_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.Labeldensite.ForeColor = Color.Goldenrod
		End Sub

		Private Sub Labeldensite_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.Labeldensite.ForeColor = Color.Black
		End Sub

		Private Sub PictureBox3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.PictureBox3.BackgroundImage = Resources.delrouge
		End Sub

		Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.PictureBox3.BackgroundImage = Resources.delmarron
		End Sub

		Private Sub PictureBoximage_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Me.nomfichier = Me.OpenFileDialog1.FileName
				If (Not File.Exists(Me.pathimage)) Then
					File.Copy(Me.nomfichier, Me.pathimage)
				Else
					File.Delete(Me.pathimage)
					File.Copy(Me.nomfichier, Me.pathimage)
				End If
				Me.PictureBoximag.BackgroundImage = Image.FromFile(Me.pathimage)
			End If
		End Sub

		Private Sub PictureBoximage_mouseenter(ByVal sender As Object, ByVal e As EventArgs)
			Me.MyGroupBox21.BorderColor = Color.Goldenrod
			Me.MyGroupBox21.Refresh()
		End Sub

		Private Sub PictureBoximage_mouseleave(ByVal sender As Object, ByVal e As EventArgs)
			Me.MyGroupBox21.BorderColor = Color.Wheat
			Me.MyGroupBox21.Refresh()
		End Sub

		Private Sub TransparentRichTextBox1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim formchangefiche As SVPLCApplication.Formchangefiche = New SVPLCApplication.Formchangefiche()
			formchangefiche.RichTextBox1.Text = Me.TransparentRichTextBox1.Text
			If (formchangefiche.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim list As List(Of String) = File.ReadLines(Me.pathfiche, Encoding.[Default]).ToList()
				Dim item() As String = { list(0), "" & VbCrLf & "", list(1), "" & VbCrLf & "", list(2), "" & VbCrLf & "", list(3), "" & VbCrLf & "", list(4), "" & VbCrLf & "", list(5), "" & VbCrLf & "" & VbCrLf & "", Module1.modiffiche }
				Dim str As String = String.Concat(item)
				File.WriteAllText(Me.pathfiche, str, Encoding.[Default])
				Me.Chargement_fiche()
			End If
		End Sub

		Private Sub TransparentRichTextBox1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.TransparentRichTextBox1.ForeColor = Color.Goldenrod
		End Sub

		Private Sub TransparentRichTextBox1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			Me.TransparentRichTextBox1.ForeColor = Color.Black
		End Sub
	End Class
End Namespace