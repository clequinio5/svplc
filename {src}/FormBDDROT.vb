Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormBDDROT
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Panellegume")>
		Private _Panellegume As Panel

		<AccessedThroughProperty("Panelgood")>
		Private _Panelgood As Panel

		<AccessedThroughProperty("Panelbad")>
		Private _Panelbad As Panel

		<AccessedThroughProperty("Labellegume")>
		Private _Labellegume As Label

		<AccessedThroughProperty("Labelgood")>
		Private _Labelgood As Label

		<AccessedThroughProperty("Labelbad")>
		Private _Labelbad As Label

		<AccessedThroughProperty("Buttonaddfiltre")>
		Private _Buttonaddfiltre As Button

		<AccessedThroughProperty("Buttondelfiltre")>
		Private _Buttondelfiltre As Button

		<AccessedThroughProperty("ButtonFiltrer")>
		Private _ButtonFiltrer As Button

		<AccessedThroughProperty("Labelligne")>
		Private _Labelligne As Label

		<AccessedThroughProperty("ComboBoxgood")>
		Private _ComboBoxgood As ComboBox

		<AccessedThroughProperty("ComboBoxbad")>
		Private _ComboBoxbad As ComboBox

		<AccessedThroughProperty("Buttonaddbdd")>
		Private _Buttonaddbdd As Button

		<AccessedThroughProperty("Buttondelbdd")>
		Private _Buttondelbdd As Button

		<AccessedThroughProperty("Labelsaviezvous")>
		Private _Labelsaviezvous As Label

		<AccessedThroughProperty("Labelanecdote")>
		Private _Labelanecdote As Label

		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		<AccessedThroughProperty("CheckBox2")>
		Private _CheckBox2 As CheckBox

		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		<AccessedThroughProperty("CheckBox4")>
		Private _CheckBox4 As CheckBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("MyGroupBox1")>
		Private _MyGroupBox1 As myGroupBox

		Private Bonne As Label(,)

		Private Mauvaise As Label(,)

		Private Affinites As Integer(,)

		Private nbrfiltre As Integer

		Private nligne As Integer

		Private anec As Integer

		Private comptrot As Integer

		Private compt As Integer

		Private good As Integer

		Private bad As Integer

		Private legumesselectionnes As Integer()

		Private nbraime As Integer

		Private occ As Integer

		Private nbraimepas As Integer

		Private Occurence As Integer(,)

		Private nouvellelistelégumes As String()

		Private suppnumeroligne As String()

		Private bddrottemp As String()

		Private titre As String

		Private présent1 As Boolean

		Private présent2 As Boolean

		Private add1 As Boolean

		Private add2 As Boolean

		Private del1 As Boolean

		Private del2 As Boolean

		Private loading As Boolean

		Private filtre As ComboBox(,)

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.Button1_Click_1)
				If (Me._Button1 IsNot Nothing) Then
					RemoveHandler Me._Button1.Click,  eventHandler
				End If
				Me._Button1 = value
				If (Me._Button1 IsNot Nothing) Then
					AddHandler Me._Button1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonaddbdd As Button
			Get
				Return Me._Buttonaddbdd
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.Button6_Click)
				If (Me._Buttonaddbdd IsNot Nothing) Then
					RemoveHandler Me._Buttonaddbdd.Click,  eventHandler
				End If
				Me._Buttonaddbdd = value
				If (Me._Buttonaddbdd IsNot Nothing) Then
					AddHandler Me._Buttonaddbdd.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonaddfiltre As Button
			Get
				Return Me._Buttonaddfiltre
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.Button2_Click)
				If (Me._Buttonaddfiltre IsNot Nothing) Then
					RemoveHandler Me._Buttonaddfiltre.Click,  eventHandler
				End If
				Me._Buttonaddfiltre = value
				If (Me._Buttonaddfiltre IsNot Nothing) Then
					AddHandler Me._Buttonaddfiltre.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttondelbdd As Button
			Get
				Return Me._Buttondelbdd
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.Button7_Click)
				If (Me._Buttondelbdd IsNot Nothing) Then
					RemoveHandler Me._Buttondelbdd.Click,  eventHandler
				End If
				Me._Buttondelbdd = value
				If (Me._Buttondelbdd IsNot Nothing) Then
					AddHandler Me._Buttondelbdd.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttondelfiltre As Button
			Get
				Return Me._Buttondelfiltre
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.Button3_Click)
				If (Me._Buttondelfiltre IsNot Nothing) Then
					RemoveHandler Me._Buttondelfiltre.Click,  eventHandler
				End If
				Me._Buttondelfiltre = value
				If (Me._Buttondelfiltre IsNot Nothing) Then
					AddHandler Me._Buttondelfiltre.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ButtonFiltrer As Button
			Get
				Return Me._ButtonFiltrer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.Button1_Click)
				If (Me._ButtonFiltrer IsNot Nothing) Then
					RemoveHandler Me._ButtonFiltrer.Click,  eventHandler
				End If
				Me._ButtonFiltrer = value
				If (Me._ButtonFiltrer IsNot Nothing) Then
					AddHandler Me._ButtonFiltrer.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBox1 As CheckBox
			Get
				Return Me._CheckBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.CheckBox1_CheckedChanged)
				If (Me._CheckBox1 IsNot Nothing) Then
					RemoveHandler Me._CheckBox1.CheckedChanged,  eventHandler
				End If
				Me._CheckBox1 = value
				If (Me._CheckBox1 IsNot Nothing) Then
					AddHandler Me._CheckBox1.CheckedChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBox2 As CheckBox
			Get
				Return Me._CheckBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.CheckBox2_CheckedChanged)
				If (Me._CheckBox2 IsNot Nothing) Then
					RemoveHandler Me._CheckBox2.CheckedChanged,  eventHandler
				End If
				Me._CheckBox2 = value
				If (Me._CheckBox2 IsNot Nothing) Then
					AddHandler Me._CheckBox2.CheckedChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBox3 As CheckBox
			Get
				Return Me._CheckBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.CheckBox3_CheckedChanged)
				If (Me._CheckBox3 IsNot Nothing) Then
					RemoveHandler Me._CheckBox3.CheckedChanged,  eventHandler
				End If
				Me._CheckBox3 = value
				If (Me._CheckBox3 IsNot Nothing) Then
					AddHandler Me._CheckBox3.CheckedChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBox4 As CheckBox
			Get
				Return Me._CheckBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.CheckBox4_CheckedChanged)
				If (Me._CheckBox4 IsNot Nothing) Then
					RemoveHandler Me._CheckBox4.CheckedChanged,  eventHandler
				End If
				Me._CheckBox4 = value
				If (Me._CheckBox4 IsNot Nothing) Then
					AddHandler Me._CheckBox4.CheckedChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ComboBoxbad As ComboBox
			Get
				Return Me._ComboBoxbad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.ComboBox2_SelectedIndexChanged)
				If (Me._ComboBoxbad IsNot Nothing) Then
					RemoveHandler Me._ComboBoxbad.SelectedIndexChanged,  eventHandler
				End If
				Me._ComboBoxbad = value
				If (Me._ComboBoxbad IsNot Nothing) Then
					AddHandler Me._ComboBoxbad.SelectedIndexChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ComboBoxgood As ComboBox
			Get
				Return Me._ComboBoxgood
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.ComboBox1_SelectedIndexChanged)
				If (Me._ComboBoxgood IsNot Nothing) Then
					RemoveHandler Me._ComboBoxgood.SelectedIndexChanged,  eventHandler
				End If
				Me._ComboBoxgood = value
				If (Me._ComboBoxgood IsNot Nothing) Then
					AddHandler Me._ComboBoxgood.SelectedIndexChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property Labelanecdote As Label
			Get
				Return Me._Labelanecdote
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelanecdote = value
			End Set
		End Property

		Friend Overridable Property Labelbad As Label
			Get
				Return Me._Labelbad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelbad = value
			End Set
		End Property

		Friend Overridable Property Labelgood As Label
			Get
				Return Me._Labelgood
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelgood = value
			End Set
		End Property

		Friend Overridable Property Labellegume As Label
			Get
				Return Me._Labellegume
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labellegume = value
			End Set
		End Property

		Friend Overridable Property Labelligne As Label
			Get
				Return Me._Labelligne
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelligne = value
			End Set
		End Property

		Friend Overridable Property Labelsaviezvous As Label
			Get
				Return Me._Labelsaviezvous
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelsaviezvous = value
			End Set
		End Property

		Friend Overridable Property MyGroupBox1 As myGroupBox
			Get
				Return Me._MyGroupBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._MyGroupBox1 = value
			End Set
		End Property

		Friend Overridable Property Panelbad As Panel
			Get
				Return Me._Panelbad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelbad = value
			End Set
		End Property

		Friend Overridable Property Panelgood As Panel
			Get
				Return Me._Panelgood
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelgood = value
			End Set
		End Property

		Friend Overridable Property Panellegume As Panel
			Get
				Return Me._Panellegume
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panellegume = value
			End Set
		End Property

		Friend Overridable Property Timer1 As Timer
			Get
				Return Me._Timer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Timer)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDROT.Timer1_Tick)
				If (Me._Timer1 IsNot Nothing) Then
					RemoveHandler Me._Timer1.Tick,  eventHandler
				End If
				Me._Timer1 = value
				If (Me._Timer1 IsNot Nothing) Then
					AddHandler Me._Timer1.Tick,  eventHandler
				End If
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formBDDROT1 As FormBDDROT = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formBDDROT1.Form3_Load)
			Dim formBDDROT2 As FormBDDROT = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formBDDROT2.FormBDDROT_FormClosed)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer
			Dim size As System.Drawing.Size
			Dim color As System.Drawing.Color = New System.Drawing.Color()
			Dim point As System.Drawing.Point
			Dim color1 As System.Drawing.Color
			Dim color2 As System.Drawing.Color
			Me.compt = 0
			Dim num1 As Integer = Me.nbrfiltre
			Dim num2 As Integer = 1
			Do
				If (Operators.CompareString(Me.filtre(0, num2).Text, "", False) = 0) Then
					Me.compt = Me.compt + 1
				End If
				num2 = num2 + 1
			Loop While num2 <= num1
			If (Me.compt = 0) Then
				Me.Affinites = Nothing
				Me.Bonne = Nothing
				Me.Mauvaise = Nothing
				Me.Occurence = Nothing
				Me.legumesselectionnes = Nothing
				Me.Panelgood.Controls.Clear()
				Me.Panelbad.Controls.Clear()
				Me.nbraime = 0
				Me.nbraimepas = 0
				ReDim Me.legumesselectionnes(Me.nbrfiltre + 1 - 1)
				Dim num3 As Integer = Me.nbrfiltre
				Dim i As Integer = 1
				Do
					Dim num4 As Integer = Module1.nbrlegumesbase - 1
					num = 0
					Do
						If (Operators.CompareString(Me.filtre(0, i).Text, Module1.listelégumes(num), False) = 0) Then
							Me.legumesselectionnes(i) = num
						End If
						num = num + 1
					Loop While num <= num4
					i = i + 1
				Loop While i <= num3
				ReDim Me.Affinites(1, Me.nbrfiltre * Module1.nbrlegumesbase + 1 - 1)
				Dim num5 As Integer = Me.nbrfiltre
				i = 1
				Do
					Dim num6 As Integer = Module1.nbrlegumesbase - 1
					num = 0
					Do
						If (Module1.Base_de_données_rotations(Me.legumesselectionnes(i), num) = 1) Then
							Me.Affinites(0, Me.nbraime) = num
							Me.nbraime = Me.nbraime + 1
						End If
						num = num + 1
					Loop While num <= num6
					i = i + 1
				Loop While i <= num5
				Dim num7 As Integer = Me.nbrfiltre
				i = 1
				Do
					Dim num8 As Integer = Module1.nbrlegumesbase - 1
					num = 0
					Do
						If (Module1.Base_de_données_rotations(Me.legumesselectionnes(i), num) = -1) Then
							Me.Affinites(1, Me.nbraimepas) = num
							Me.nbraimepas = Me.nbraimepas + 1
						End If
						num = num + 1
					Loop While num <= num8
					i = i + 1
				Loop While i <= num7
				ReDim Me.Occurence(1, Module1.nbrlegumesbase - 1 + 1 - 1)
				Dim num9 As Integer = Module1.nbrlegumesbase - 1
				i = 0
				Do
					Me.occ = 0
					Dim num10 As Integer = Me.nbraime - 1
					num = 0
					Do
						If (Me.Affinites(0, num) = i) Then
							Me.occ = Me.occ + 1
						End If
						num = num + 1
					Loop While num <= num10
					Me.Occurence(0, i) = Me.occ
					i = i + 1
				Loop While i <= num9
				Dim num11 As Integer = Module1.nbrlegumesbase - 1
				i = 0
				Do
					Me.occ = 0
					Dim num12 As Integer = Me.nbraimepas - 1
					num = 0
					Do
						If (Me.Affinites(1, num) = i) Then
							Me.occ = Me.occ + 1
						End If
						num = num + 1
					Loop While num <= num12
					Me.Occurence(1, i) = Me.occ
					i = i + 1
				Loop While i <= num11
				ReDim Me.Bonne(0, Me.nbraime + 1 - 1)
				Me.good = 0
				Dim num13 As Integer = Module1.nbrlegumesbase - 1
				i = 0
				Do
					If (Me.Occurence(0, i) = Me.nbrfiltre) Then
						Me.Bonne(0, Me.good) = New System.Windows.Forms.Label()
						Dim bonne As System.Windows.Forms.Label = Me.Bonne(0, Me.good)
						size = New System.Drawing.Size(192, 16)
						bonne.Size = size
						bonne.AutoEllipsis = True
						bonne.Text = Module1.listelégumes(i)
						Dim label As System.Windows.Forms.Label = bonne
						Dim obj As Object = Me.coloreregle(i)
						If (obj IsNot Nothing) Then
							color1 = DirectCast(obj, System.Drawing.Color)
						Else
							color1 = color
						End If
						label.ForeColor = color1
						point = New System.Drawing.Point(0, 21 * Me.good)
						bonne.Location = point
						If (Me.nbrfiltre = 1 AndAlso Operators.ConditionalCompareObjectEqual(Module1.SptRg1(Module1.Base_de_données_rotationsstr(Me.legumesselectionnes(1), i)), "1", False)) Then
							bonne.Font = New System.Drawing.Font(bonne.Font.Name, bonne.Font.Size, FontStyle.Bold)
						End If
						bonne = Nothing
						Me.Panelgood.Controls.Add(Me.Bonne(0, Me.good))
						Me.good = Me.good + 1
					End If
					i = i + 1
				Loop While i <= num13
				ReDim Me.Mauvaise(0, Me.nbraimepas + 1 - 1)
				Me.bad = 0
				Dim num14 As Integer = Module1.nbrlegumesbase - 1
				For i = 0 To num14 Step 1
					If (Me.Occurence(1, i) = Me.nbrfiltre) Then
						Me.Mauvaise(0, Me.bad) = New System.Windows.Forms.Label()
						Dim mauvaise As System.Windows.Forms.Label = Me.Mauvaise(0, Me.bad)
						size = New System.Drawing.Size(192, 16)
						mauvaise.Size = size
						mauvaise.AutoEllipsis = True
						mauvaise.Text = Module1.listelégumes(i)
						Dim label1 As System.Windows.Forms.Label = mauvaise
						Dim obj1 As Object = Me.coloreregle(i)
						If (obj1 IsNot Nothing) Then
							color2 = DirectCast(obj1, System.Drawing.Color)
						Else
							color2 = color
						End If
						label1.ForeColor = color2
						point = New System.Drawing.Point(0, 21 * Me.bad)
						mauvaise.Location = point
						If (Me.nbrfiltre = 1 AndAlso Operators.ConditionalCompareObjectEqual(Module1.SptRg1(Module1.Base_de_données_rotationsstr(Me.legumesselectionnes(1), i)), "1", False)) Then
							mauvaise.Font = New System.Drawing.Font(mauvaise.Font.Name, mauvaise.Font.Size, FontStyle.Bold)
						End If
						mauvaise = Nothing
						Me.Panelbad.Controls.Add(Me.Mauvaise(0, Me.bad))
						Me.bad = Me.bad + 1
					End If
				Next

			End If
		End Sub

		Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Me.Timer1.[Stop]()
			If (Me.anec < Module1.nbranecdote) Then
				Me.anec = Me.anec + 3
			End If
			If (Me.anec = Module1.nbranecdote + 1) Then
				Me.anec = 0
			End If
			Me.titre = Module1.Lepoireaupreferelesfraises(Me.anec)
			Me.Labelanecdote.Text = String.Concat(Me.titre, "" & VbCrLf & "" & VbCrLf & "", Module1.Lepoireaupreferelesfraises(Me.anec + 1))
			Me.Timer1.Start()
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.nbrfiltre < 6) Then
				Me.filtre(0, Me.nbrfiltre + 1) = New System.Windows.Forms.ComboBox()
				Dim comboBox As System.Windows.Forms.ComboBox = Me.filtre(0, Me.nbrfiltre + 1)
				comboBox.DrawMode = DrawMode.OwnerDrawFixed
				Dim point As System.Drawing.Point = New System.Drawing.Point(0, 24 * Me.nbrfiltre)
				comboBox.Location = point
				comboBox.DropDownStyle = ComboBoxStyle.DropDownList
				AddHandler comboBox.DrawItem,  New DrawItemEventHandler(AddressOf Module1.filtredrawitemb)
				Dim formBDDROT As SVPLCApplication.FormBDDROT = Me
				AddHandler comboBox.SelectedIndexChanged,  New EventHandler(AddressOf formBDDROT.filtre_selectedindexchanged)
				comboBox = Nothing
				Me.Panellegume.Controls.Add(Me.filtre(0, Me.nbrfiltre + 1))
				Dim num As Integer = Module1.nbrlegumesbase - 1
				Dim num1 As Integer = 0
				Do
					Me.filtre(0, Me.nbrfiltre + 1).Items.Add(Module1.listelégumes(num1))
					num1 = num1 + 1
				Loop While num1 <= num
				Me.nbrfiltre = Me.nbrfiltre + 1
			End If
			If (Me.nbrfiltre > 0) Then
				Me.Buttondelfiltre.Enabled = True
			End If
			If (Me.nbrfiltre = 6) Then
				Me.Buttonaddfiltre.Enabled = False
			End If
		End Sub

		Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Panellegume.Controls.Remove(Me.filtre(0, Me.nbrfiltre))
			Me.nbrfiltre = Me.nbrfiltre - 1
			If (Me.nbrfiltre <> 0) Then
				Me.ButtonFiltrer.PerformClick()
			Else
				Me.Buttondelfiltre.Enabled = False
				Me.Panelgood.Controls.Clear()
				Me.Panelbad.Controls.Clear()
			End If
		End Sub

		Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.add1 = True
			Dim num As Integer = Me.good - 1
			Dim i As Integer = 0
			Do
				If (Operators.CompareString(Me.ComboBoxgood.Text, Me.Bonne(0, i).Text, False) = 0) Then
					Me.add1 = False
				End If
				i = i + 1
			Loop While i <= num
			Me.add2 = True
			Dim num1 As Integer = Me.bad - 1
			i = 0
			Do
				If (Operators.CompareString(Me.ComboBoxbad.Text, Me.Mauvaise(0, i).Text, False) = 0) Then
					Me.add2 = False
				End If
				i = i + 1
			Loop While i <= num1
			If (Operators.CompareString(Me.ComboBoxgood.Text, "", False) <> 0 AndAlso Me.add1) Then
				Dim num2 As Integer = Me.nbrfiltre
				For i = 1 To num2 Step 1
					Try
						File.AppendAllText(Module1.PATHS(2), String.Concat(Me.filtre(0, i).Text, "" & VbCrLf & "", Me.ComboBoxgood.Text, "" & VbCrLf & "o" & VbCrLf & ""), Encoding.UTF8)
					Catch exception As System.Exception
						ProjectData.SetProjectError(exception)
						MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture de la rotation positive", "Erreur d'écriture")
						ProjectData.ClearProjectError()
					End Try
				Next

			End If
			If (Operators.CompareString(Me.ComboBoxbad.Text, "", False) <> 0 AndAlso Me.add2) Then
				Dim num3 As Integer = Me.nbrfiltre
				For i = 1 To num3 Step 1
					Try
						File.AppendAllText(Module1.PATHS(2), String.Concat(Me.filtre(0, i).Text, "" & VbCrLf & "", Me.ComboBoxbad.Text, "" & VbCrLf & "n" & VbCrLf & ""), Encoding.UTF8)
					Catch exception1 As System.Exception
						ProjectData.SetProjectError(exception1)
						MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture de la rotation négative", "Erreur d'écriture")
						ProjectData.ClearProjectError()
					End Try
				Next

			End If
			MyProject.Forms.FormPasPas.ChargementBDDrot()
			Me.Buttondelbdd.Enabled = False
			Me.Buttonaddbdd.Enabled = False
			Me.ComboBoxgood.SelectedItem = ""
			Me.ComboBoxbad.SelectedItem = ""
			Me.ButtonFiltrer.PerformClick()
		End Sub

		Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim i As Integer
			Dim j As Integer
			Me.comptrot = 0
			Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Module1.PATHS(2), Encoding.[Default])
			Me.compt = 0
			While streamReader.Peek() <> -1
				Me.bddrottemp = DirectCast(Utils.CopyArray(DirectCast(Me.bddrottemp, Array), New String(Me.compt + 1 - 1) {}), String())
				Me.bddrottemp(Me.compt) = streamReader.ReadLine()
				Me.compt = Me.compt + 1
			End While
			streamReader.Close()
			Me.nligne = Me.compt
			Me.del1 = False
			If (Operators.CompareString(Me.ComboBoxgood.Text, "", False) <> 0) Then
				Dim num As Integer = Me.good - 1
				i = 0
				While i <= num
					If (Operators.CompareString(Me.Bonne(0, i).Text, Me.ComboBoxgood.Text, False) <> 0) Then
						i = i + 1
					Else
						Me.del1 = True
						Exit While
					End If
				End While
			End If
			Me.del2 = False
			If (Operators.CompareString(Me.ComboBoxbad.Text, "", False) <> 0) Then
				Dim num1 As Integer = Me.bad - 1
				i = 0
				While i <= num1
					If (Operators.CompareString(Me.Mauvaise(0, i).Text, Me.ComboBoxbad.Text, False) <> 0) Then
						i = i + 1
					Else
						Me.del2 = True
						Exit While
					End If
				End While
			End If
			Me.compt = 0
			If (Me.del1) Then
				Dim num2 As Integer = Me.nbrfiltre
				For i = 1 To num2 Step 1
					Dim num3 As Integer = Me.nligne - 3
					For j = 0 To num3 Step 1
						If (Operators.CompareString(Me.bddrottemp(j), Me.filtre(0, i).Text, False) = 0 AndAlso Operators.CompareString(Me.bddrottemp(j + 1), Me.ComboBoxgood.Text, False) = 0 And Operators.CompareString(Me.bddrottemp(j + 2), "o", False) = 0) Then
							Me.bddrottemp(j) = ""
							Me.bddrottemp(j + 1) = ""
							Me.bddrottemp(j + 2) = ""
							Me.compt = Me.compt + 1
						End If
					Next

				Next

			End If
			If (Me.del2) Then
				Dim num4 As Integer = Me.nbrfiltre
				For i = 1 To num4 Step 1
					Dim num5 As Integer = Me.nligne - 3
					For j = 0 To num5 Step 1
						If (Operators.CompareString(Me.bddrottemp(j), Me.filtre(0, i).Text, False) = 0 AndAlso Operators.CompareString(Me.bddrottemp(j + 1), Me.ComboBoxbad.Text, False) = 0 And Operators.CompareString(Me.bddrottemp(j + 2), "n", False) = 0) Then
							Me.bddrottemp(j) = ""
							Me.bddrottemp(j + 1) = ""
							Me.bddrottemp(j + 2) = ""
							Me.compt = Me.compt + 1
						End If
					Next

				Next

			End If
			ReDim Me.suppnumeroligne(Me.nligne - 1 - 3 * (Me.comptrot + Me.compt) + 1 - 1)
			Me.compt = 0
			Dim num6 As Integer = Me.nligne - 1
			Dim num7 As Integer = 0
			Do
				If (Operators.CompareString(Me.bddrottemp(num7), "", False) <> 0) Then
					Me.suppnumeroligne(Me.compt) = Me.bddrottemp(num7)
					Me.compt = Me.compt + 1
				End If
				num7 = num7 + 1
			Loop While num7 <= num6
			Me.nligne = Me.compt
			Try
				Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(Module1.PATHS(2), False, Encoding.[Default])
				Dim num8 As Integer = Me.nligne - 1
				j = 0
				Do
					streamWriter.WriteLine(Me.suppnumeroligne(j))
					j = j + 1
				Loop While j <= num8
				streamWriter.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture dans la nouvelle base de donnée", "Erreur")
				ProjectData.ClearProjectError()
			End Try
			MyProject.Forms.FormPasPas.ChargementBDDrot()
			Me.Buttondelbdd.Enabled = False
			Me.Buttonaddbdd.Enabled = False
			Me.ComboBoxgood.SelectedItem = ""
			Me.ComboBoxbad.SelectedItem = ""
			Me.ButtonFiltrer.PerformClick()
		End Sub

		Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.loading) Then
				If (Not Me.CheckBox1.Checked) Then
					Module1.checkrotfam = False
				Else
					Module1.checkrotfam = True
				End If
				MyProject.Forms.FormPasPas.ChargementBDDrot()
				If (Me.nbrfiltre > 0) Then
					Me.ButtonFiltrer.PerformClick()
				End If
			End If
		End Sub

		Private Sub CheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.loading) Then
				If (Not Me.CheckBox2.Checked) Then
					Module1.checkrottype = False
				Else
					Module1.checkrottype = True
				End If
				MyProject.Forms.FormPasPas.ChargementBDDrot()
				If (Me.nbrfiltre > 0) Then
					Me.ButtonFiltrer.PerformClick()
				End If
			End If
		End Sub

		Private Sub CheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.loading) Then
				If (Not Me.CheckBox3.Checked) Then
					Module1.checkrotbdd = False
				Else
					Module1.checkrotbdd = True
				End If
				MyProject.Forms.FormPasPas.ChargementBDDrot()
				If (Me.nbrfiltre > 0) Then
					Me.ButtonFiltrer.PerformClick()
				End If
			End If
		End Sub

		Private Sub CheckBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.loading) Then
				If (Not Me.CheckBox4.Checked) Then
					Module1.masquerlesconflits = False
				Else
					Module1.masquerlesconflits = True
				End If
			End If
			MyProject.Forms.FormPasPas.ChargementBDDrot()
			If (Me.nbrfiltre > 0) Then
				Me.ButtonFiltrer.PerformClick()
			End If
		End Sub

		Private Function coloreregle(ByVal pl1 As Integer) As Object
			Dim obj As Object
			If (Me.nbrfiltre <> 1) Then
				obj = Module1.colortypefam(0)
			Else
				obj = Module1.colortypefam(0)
				Dim obj1 As Object = Module1.SptRg2(Module1.Base_de_données_rotationsstr(Me.legumesselectionnes(1), pl1))
				If (Operators.ConditionalCompareObjectEqual(obj1, "Type", False)) Then
					obj = Module1.colortypefam(1)
				ElseIf (Operators.ConditionalCompareObjectEqual(obj1, "Famille", False)) Then
					obj = Module1.colortypefam(2)
				End If
			End If
			Return obj
		End Function

		Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.présent1 = False
			Dim num As Integer = Me.good - 1
			Dim num1 As Integer = 0
			While num1 <= num
				If (Operators.CompareString(Me.ComboBoxgood.Text, Me.Bonne(0, num1).Text, False) <> 0) Then
					num1 = num1 + 1
				Else
					Me.présent1 = True
					Exit While
				End If
			End While
			Me.Comportementbtn()
		End Sub

		Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.présent2 = False
			Dim num As Integer = Me.bad - 1
			Dim num1 As Integer = 0
			While num1 <= num
				If (Operators.CompareString(Me.ComboBoxbad.Text, Me.Mauvaise(0, num1).Text, False) <> 0) Then
					num1 = num1 + 1
				Else
					Me.présent2 = True
					Exit While
				End If
			End While
			Me.Comportementbtn()
		End Sub

		Private Sub Comportementbtn()
			If (Me.présent1) Then
				If (Me.présent2) Then
					Me.Buttonaddbdd.Enabled = False
					Me.Buttondelbdd.Enabled = True
				End If
				If (Not Me.présent2 And Operators.CompareString(Me.ComboBoxbad.Text, "", False) <> 0) Then
					Me.Buttonaddbdd.Enabled = False
					Me.Buttondelbdd.Enabled = False
					MyProject.Forms.FormPasPas.Msgboxperso("Vérifiez les entrées, les valeurs renseignées dans les champs doivent concorder!" & VbCrLf & "En l'occurrence l'entrée associée au premier champ de saisie existe déjà tandis que celle associée au second champ est nouvelle!", "Correspondance non valide")
					Return
				End If
				If (Not Me.présent2 And Operators.CompareString(Me.ComboBoxbad.Text, "", False) = 0) Then
					Me.Buttonaddbdd.Enabled = False
					Me.Buttondelbdd.Enabled = True
				End If
			End If
			If (Not Me.présent1 And Operators.CompareString(Me.ComboBoxgood.Text, "", False) <> 0) Then
				If (Not Me.présent2) Then
					Me.Buttonaddbdd.Enabled = True
					Me.Buttondelbdd.Enabled = False
				End If
				If (Me.présent2) Then
					Me.Buttonaddbdd.Enabled = False
					Me.Buttondelbdd.Enabled = False
					MyProject.Forms.FormPasPas.Msgboxperso("Vérifiez les entrées, les valeurs renseignées dans les champs doivent concorder!" & VbCrLf & "En l'occurrence l'entrée associée au second champ de saisie existe déjà tandis que celle associée au premier champ est nouvelle!", "Correspondance non valide")
					Return
				End If
			End If
			If (Not Me.présent1 And Operators.CompareString(Me.ComboBoxgood.Text, "", False) = 0) Then
				If (Not Me.présent2 And Operators.CompareString(Me.ComboBoxbad.Text, "", False) = 0) Then
					Me.Buttonaddbdd.Enabled = False
					Me.Buttondelbdd.Enabled = False
				End If
				If (Not Me.présent2 And Operators.CompareString(Me.ComboBoxbad.Text, "", False) <> 0) Then
					Me.Buttonaddbdd.Enabled = True
					Me.Buttondelbdd.Enabled = False
				End If
				If (Me.présent2) Then
					Me.Buttonaddbdd.Enabled = False
					Me.Buttondelbdd.Enabled = True
				End If
			End If
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

		Private Sub filtre_selectedindexchanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.ButtonFiltrer.PerformClick()
		End Sub

		Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.loading = True
			Me.CheckBox1.ForeColor = Module1.colortypefam(2)
			Me.CheckBox2.ForeColor = Module1.colortypefam(1)
			If (Not Module1.checkrotfam) Then
				Me.CheckBox1.Checked = False
			Else
				Me.CheckBox1.Checked = True
			End If
			If (Not Module1.checkrottype) Then
				Me.CheckBox2.Checked = False
			Else
				Me.CheckBox2.Checked = True
			End If
			If (Not Module1.checkrotbdd) Then
				Me.CheckBox3.Checked = False
			Else
				Me.CheckBox3.Checked = True
			End If
			If (Not Module1.masquerlesconflits) Then
				Me.CheckBox4.Checked = False
			Else
				Me.CheckBox4.Checked = True
			End If
			Me.Buttondelfiltre.Enabled = False
			Me.Buttonaddbdd.Enabled = False
			Me.Buttondelbdd.Enabled = False
			Me.Timer1.Enabled = True
			Me.nbrfiltre = 0
			Me.anec = 0
			ReDim Me.filtre(0, 7)
			Me.titre = Module1.Lepoireaupreferelesfraises(Me.anec)
			Me.Labelanecdote.Text = String.Concat(Me.titre, "" & VbCrLf & "" & VbCrLf & "", Module1.Lepoireaupreferelesfraises(Me.anec + 1))
			Dim comboBoxbad As ComboBox = Me.ComboBoxbad
			comboBoxbad.DrawMode = DrawMode.OwnerDrawFixed
			comboBoxbad.Items.Add("")
			AddHandler comboBoxbad.DrawItem,  New DrawItemEventHandler(AddressOf Module1.filtredrawitemdh)
			comboBoxbad = Nothing
			Dim comboBoxgood As ComboBox = Me.ComboBoxgood
			comboBoxgood.DrawMode = DrawMode.OwnerDrawFixed
			comboBoxgood.Items.Add("")
			AddHandler comboBoxgood.DrawItem,  New DrawItemEventHandler(AddressOf Module1.filtredrawitemdh)
			comboBoxgood = Nothing
			Dim num As Integer = Module1.nbrlegumesbase - 1
			Dim num1 As Integer = 0
			Do
				Me.ComboBoxgood.Items.Add(Module1.listelégumes(num1))
				Me.ComboBoxbad.Items.Add(Module1.listelégumes(num1))
				num1 = num1 + 1
			Loop While num1 <= num
			Me.loading = False
		End Sub

		Private Sub FormBDDROT_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadbddrot = False
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBDDROT))
			Me.Panellegume = New System.Windows.Forms.Panel()
			Me.Panelgood = New System.Windows.Forms.Panel()
			Me.Panelbad = New System.Windows.Forms.Panel()
			Me.Labellegume = New System.Windows.Forms.Label()
			Me.Labelgood = New System.Windows.Forms.Label()
			Me.Labelbad = New System.Windows.Forms.Label()
			Me.Buttonaddfiltre = New System.Windows.Forms.Button()
			Me.Buttondelfiltre = New System.Windows.Forms.Button()
			Me.ButtonFiltrer = New System.Windows.Forms.Button()
			Me.Labelligne = New System.Windows.Forms.Label()
			Me.ComboBoxgood = New System.Windows.Forms.ComboBox()
			Me.ComboBoxbad = New System.Windows.Forms.ComboBox()
			Me.Buttonaddbdd = New System.Windows.Forms.Button()
			Me.Buttondelbdd = New System.Windows.Forms.Button()
			Me.Labelsaviezvous = New System.Windows.Forms.Label()
			Me.Labelanecdote = New System.Windows.Forms.Label()
			Me.Timer1 = New Timer(Me.components)
			Me.Button1 = New System.Windows.Forms.Button()
			Me.MyGroupBox1 = New myGroupBox()
			Me.CheckBox1 = New System.Windows.Forms.CheckBox()
			Me.CheckBox2 = New System.Windows.Forms.CheckBox()
			Me.CheckBox3 = New System.Windows.Forms.CheckBox()
			Me.CheckBox4 = New System.Windows.Forms.CheckBox()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.MyGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			Dim panellegume As System.Windows.Forms.Panel = Me.Panellegume
			Dim point As System.Drawing.Point = New System.Drawing.Point(40, 55)
			panellegume.Location = point
			Me.Panellegume.Name = "Panellegume"
			Dim panel As System.Windows.Forms.Panel = Me.Panellegume
			Dim size As System.Drawing.Size = New System.Drawing.Size(157, 260)
			panel.Size = size
			Me.Panellegume.TabIndex = 4
			Me.Panelgood.AutoScroll = True
			Dim panelgood As System.Windows.Forms.Panel = Me.Panelgood
			point = New System.Drawing.Point(275, 56)
			panelgood.Location = point
			Me.Panelgood.Name = "Panelgood"
			Dim panelgood1 As System.Windows.Forms.Panel = Me.Panelgood
			size = New System.Drawing.Size(192, 327)
			panelgood1.Size = size
			Me.Panelgood.TabIndex = 6
			Me.Panelbad.AutoScroll = True
			Dim panelbad As System.Windows.Forms.Panel = Me.Panelbad
			point = New System.Drawing.Point(489, 56)
			panelbad.Location = point
			Me.Panelbad.Name = "Panelbad"
			Dim panelbad1 As System.Windows.Forms.Panel = Me.Panelbad
			size = New System.Drawing.Size(192, 327)
			panelbad1.Size = size
			Me.Panelbad.TabIndex = 7
			Me.Labellegume.AutoSize = True
			Me.Labellegume.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim labellegume As System.Windows.Forms.Label = Me.Labellegume
			point = New System.Drawing.Point(40, 20)
			labellegume.Location = point
			Me.Labellegume.Name = "Labellegume"
			Dim label As System.Windows.Forms.Label = Me.Labellegume
			size = New System.Drawing.Size(74, 17)
			label.Size = size
			Me.Labellegume.TabIndex = 0
			Me.Labellegume.Text = "Plante(s)"
			Me.Labelgood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelgood.ForeColor = Color.Green
			Dim labelgood As System.Windows.Forms.Label = Me.Labelgood
			point = New System.Drawing.Point(272, 13)
			labelgood.Location = point
			Me.Labelgood.Name = "Labelgood"
			Dim labelgood1 As System.Windows.Forms.Label = Me.Labelgood
			size = New System.Drawing.Size(124, 32)
			labelgood1.Size = size
			Me.Labelgood.TabIndex = 1
			Me.Labelgood.Text = "Bonne plantation suivante"
			Me.Labelbad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelbad.ForeColor = Color.Red
			Dim labelbad As System.Windows.Forms.Label = Me.Labelbad
			point = New System.Drawing.Point(486, 13)
			labelbad.Location = point
			Me.Labelbad.Name = "Labelbad"
			Dim labelbad1 As System.Windows.Forms.Label = Me.Labelbad
			size = New System.Drawing.Size(138, 32)
			labelbad1.Size = size
			Me.Labelbad.TabIndex = 2
			Me.Labelbad.Text = "Mauvaise plantation suivante"
			Dim buttonaddfiltre As System.Windows.Forms.Button = Me.Buttonaddfiltre
			point = New System.Drawing.Point(40, 330)
			buttonaddfiltre.Location = point
			Me.Buttonaddfiltre.Name = "Buttonaddfiltre"
			Dim button As System.Windows.Forms.Button = Me.Buttonaddfiltre
			size = New System.Drawing.Size(120, 23)
			button.Size = size
			Me.Buttonaddfiltre.TabIndex = 5
			Me.Buttonaddfiltre.Text = "Ajouter un filtre"
			Me.Buttonaddfiltre.UseVisualStyleBackColor = True
			Dim buttondelfiltre As System.Windows.Forms.Button = Me.Buttondelfiltre
			point = New System.Drawing.Point(40, 360)
			buttondelfiltre.Location = point
			Me.Buttondelfiltre.Name = "Buttondelfiltre"
			Dim buttondelfiltre1 As System.Windows.Forms.Button = Me.Buttondelfiltre
			size = New System.Drawing.Size(120, 23)
			buttondelfiltre1.Size = size
			Me.Buttondelfiltre.TabIndex = 8
			Me.Buttondelfiltre.Text = "Supprimer un filtre"
			Me.Buttondelfiltre.UseVisualStyleBackColor = True
			Dim buttonFiltrer As System.Windows.Forms.Button = Me.ButtonFiltrer
			point = New System.Drawing.Point(712, 330)
			buttonFiltrer.Location = point
			Me.ButtonFiltrer.Name = "ButtonFiltrer"
			Dim buttonFiltrer1 As System.Windows.Forms.Button = Me.ButtonFiltrer
			size = New System.Drawing.Size(300, 52)
			buttonFiltrer1.Size = size
			Me.ButtonFiltrer.TabIndex = 10
			Me.ButtonFiltrer.Text = "Filtrer"
			Me.ButtonFiltrer.UseVisualStyleBackColor = True
			Me.Labelligne.BackColor = Color.FromArgb(192, 64, 0)
			Dim labelligne As System.Windows.Forms.Label = Me.Labelligne
			point = New System.Drawing.Point(40, 410)
			labelligne.Location = point
			Me.Labelligne.Name = "Labelligne"
			Dim labelligne1 As System.Windows.Forms.Label = Me.Labelligne
			size = New System.Drawing.Size(970, 4)
			labelligne1.Size = size
			Me.Labelligne.TabIndex = 11
			Me.ComboBoxgood.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBoxgood.FormattingEnabled = True
			Dim comboBoxgood As System.Windows.Forms.ComboBox = Me.ComboBoxgood
			point = New System.Drawing.Point(275, 438)
			comboBoxgood.Location = point
			Me.ComboBoxgood.Name = "ComboBoxgood"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBoxgood
			size = New System.Drawing.Size(150, 21)
			comboBox.Size = size
			Me.ComboBoxgood.TabIndex = 13
			Me.ComboBoxbad.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBoxbad.FormattingEnabled = True
			Dim comboBoxbad As System.Windows.Forms.ComboBox = Me.ComboBoxbad
			point = New System.Drawing.Point(489, 436)
			comboBoxbad.Location = point
			Me.ComboBoxbad.Name = "ComboBoxbad"
			Dim comboBoxbad1 As System.Windows.Forms.ComboBox = Me.ComboBoxbad
			size = New System.Drawing.Size(150, 21)
			comboBoxbad1.Size = size
			Me.ComboBoxbad.TabIndex = 14
			Dim buttonaddbdd As System.Windows.Forms.Button = Me.Buttonaddbdd
			point = New System.Drawing.Point(716, 440)
			buttonaddbdd.Location = point
			Me.Buttonaddbdd.Name = "Buttonaddbdd"
			Dim buttonaddbdd1 As System.Windows.Forms.Button = Me.Buttonaddbdd
			size = New System.Drawing.Size(300, 23)
			buttonaddbdd1.Size = size
			Me.Buttonaddbdd.TabIndex = 15
			Me.Buttonaddbdd.Text = "Ajouter à la BDD"
			Me.Buttonaddbdd.UseVisualStyleBackColor = True
			Dim buttondelbdd As System.Windows.Forms.Button = Me.Buttondelbdd
			point = New System.Drawing.Point(716, 470)
			buttondelbdd.Location = point
			Me.Buttondelbdd.Name = "Buttondelbdd"
			Dim buttondelbdd1 As System.Windows.Forms.Button = Me.Buttondelbdd
			size = New System.Drawing.Size(300, 23)
			buttondelbdd1.Size = size
			Me.Buttondelbdd.TabIndex = 16
			Me.Buttondelbdd.Text = "Supprimer de la BDD"
			Me.Buttondelbdd.UseVisualStyleBackColor = True
			Me.Labelsaviezvous.AutoSize = True
			Me.Labelsaviezvous.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelsaviezvous.ForeColor = SystemColors.HotTrack
			Dim labelsaviezvous As System.Windows.Forms.Label = Me.Labelsaviezvous
			point = New System.Drawing.Point(790, 20)
			labelsaviezvous.Location = point
			Me.Labelsaviezvous.Name = "Labelsaviezvous"
			Dim labelsaviezvous1 As System.Windows.Forms.Label = Me.Labelsaviezvous
			size = New System.Drawing.Size(128, 17)
			labelsaviezvous1.Size = size
			Me.Labelsaviezvous.TabIndex = 3
			Me.Labelsaviezvous.Text = "Le Saviez-vous?"
			Me.Labelanecdote.AutoEllipsis = True
			Me.Labelanecdote.BackColor = Color.FromArgb(255, 255, 128)
			Me.Labelanecdote.Font = New System.Drawing.Font("Papyrus", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim labelanecdote As System.Windows.Forms.Label = Me.Labelanecdote
			point = New System.Drawing.Point(712, 55)
			labelanecdote.Location = point
			Me.Labelanecdote.Name = "Labelanecdote"
			Dim labelanecdote1 As System.Windows.Forms.Label = Me.Labelanecdote
			size = New System.Drawing.Size(300, 328)
			labelanecdote1.Size = size
			Me.Labelanecdote.TabIndex = 9
			Me.Labelanecdote.Text = "Le poireau prefere les fraises "
			Me.Labelanecdote.TextAlign = ContentAlignment.MiddleCenter
			Me.Timer1.Interval = 50000
			Me.Button1.BackgroundImage = Resources.flechenext
			Me.Button1.BackgroundImageLayout = ImageLayout.Stretch
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(985, 386)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button11 As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(27, 23)
			button11.Size = size
			Me.Button1.TabIndex = 17
			Me.Button1.UseVisualStyleBackColor = True
			Me.MyGroupBox1.BackColor = Color.FromArgb(128, 128, 255)
			Me.MyGroupBox1.BorderColor = Color.Teal
			Me.MyGroupBox1.Controls.Add(Me.CheckBox1)
			Me.MyGroupBox1.Controls.Add(Me.CheckBox2)
			Me.MyGroupBox1.Controls.Add(Me.CheckBox3)
			Me.MyGroupBox1.Controls.Add(Me.CheckBox4)
			Me.MyGroupBox1.Controls.Add(Me.Label1)
			Me.MyGroupBox1.Diagonale = 6
			Me.MyGroupBox1.ForeColor = Color.Black
			Dim myGroupBox1 As myGroupBox = Me.MyGroupBox1
			point = New System.Drawing.Point(37, 422)
			myGroupBox1.Location = point
			Me.MyGroupBox1.Name = "MyGroupBox1"
			Dim _myGroupBox As myGroupBox = Me.MyGroupBox1
			size = New System.Drawing.Size(218, 122)
			_myGroupBox.Size = size
			Me.MyGroupBox1.TabIndex = 23
			Me.MyGroupBox1.TabStop = False
			Me.MyGroupBox1.Thickness = 5
			Me.MyGroupBox1.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.ForeColor = Color.Navy
			Dim checkBox1 As System.Windows.Forms.CheckBox = Me.CheckBox1
			point = New System.Drawing.Point(114, 62)
			checkBox1.Location = point
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox As System.Windows.Forms.CheckBox = Me.CheckBox1
			size = New System.Drawing.Size(58, 17)
			checkBox.Size = size
			Me.CheckBox1.TabIndex = 18
			Me.CheckBox1.Text = "Famille"
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.CheckBox2.AutoSize = True
			Me.CheckBox2.ForeColor = Color.DarkRed
			Dim checkBox2 As System.Windows.Forms.CheckBox = Me.CheckBox2
			point = New System.Drawing.Point(114, 39)
			checkBox2.Location = point
			Me.CheckBox2.Name = "CheckBox2"
			Dim checkBox21 As System.Windows.Forms.CheckBox = Me.CheckBox2
			size = New System.Drawing.Size(50, 17)
			checkBox21.Size = size
			Me.CheckBox2.TabIndex = 19
			Me.CheckBox2.Text = "Type"
			Me.CheckBox2.UseVisualStyleBackColor = True
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.BackColor = Color.Orange
			Me.CheckBox3.FlatStyle = FlatStyle.Flat
			Dim checkBox3 As System.Windows.Forms.CheckBox = Me.CheckBox3
			point = New System.Drawing.Point(16, 18)
			checkBox3.Location = point
			Me.CheckBox3.Name = "CheckBox3"
			Dim checkBox31 As System.Windows.Forms.CheckBox = Me.CheckBox3
			size = New System.Drawing.Size(135, 17)
			checkBox31.Size = size
			Me.CheckBox3.TabIndex = 20
			Me.CheckBox3.Text = "Charger la BDD rotation"
			Me.CheckBox3.UseVisualStyleBackColor = False
			Me.CheckBox4.AutoSize = True
			Me.CheckBox4.BackColor = Color.OliveDrab
			Me.CheckBox4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 0)
			Me.CheckBox4.FlatAppearance.CheckedBackColor = Color.DarkOliveGreen
			Me.CheckBox4.FlatStyle = FlatStyle.Flat
			Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim checkBox4 As System.Windows.Forms.CheckBox = Me.CheckBox4
			point = New System.Drawing.Point(14, 86)
			checkBox4.Location = point
			Me.CheckBox4.Name = "CheckBox4"
			Dim checkBox41 As System.Windows.Forms.CheckBox = Me.CheckBox4
			size = New System.Drawing.Size(198, 16)
			checkBox41.Size = size
			Me.CheckBox4.TabIndex = 21
			Me.CheckBox4.Text = "Gérer automatiquement les conflits"
			Me.CheckBox4.UseVisualStyleBackColor = False
			Me.Label1.AutoSize = True
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(17, 50)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label11 As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(91, 13)
			label11.Size = size
			Me.Label1.TabIndex = 22
			Me.Label1.Text = "Appliquer la règle:"
			Me.AcceptButton = Me.Buttonaddfiltre
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.BackColor = Color.DarkKhaki
			size = New System.Drawing.Size(1024, 551)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Labelanecdote)
			Me.Controls.Add(Me.Labelsaviezvous)
			Me.Controls.Add(Me.Buttondelbdd)
			Me.Controls.Add(Me.Buttonaddbdd)
			Me.Controls.Add(Me.ComboBoxbad)
			Me.Controls.Add(Me.ComboBoxgood)
			Me.Controls.Add(Me.Labelligne)
			Me.Controls.Add(Me.ButtonFiltrer)
			Me.Controls.Add(Me.Buttondelfiltre)
			Me.Controls.Add(Me.Buttonaddfiltre)
			Me.Controls.Add(Me.Labelbad)
			Me.Controls.Add(Me.Labelgood)
			Me.Controls.Add(Me.Labellegume)
			Me.Controls.Add(Me.Panelbad)
			Me.Controls.Add(Me.Panelgood)
			Me.Controls.Add(Me.Panellegume)
			Me.Controls.Add(Me.MyGroupBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormBDDROT"
			Me.Text = "Base de données rotations"
			Me.MyGroupBox1.ResumeLayout(False)
			Me.MyGroupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.anec < Module1.nbranecdote) Then
				Me.anec = Me.anec + 3
			End If
			If (Me.anec = Module1.nbranecdote + 1) Then
				Me.anec = 0
			End If
			Me.titre = Module1.Lepoireaupreferelesfraises(Me.anec)
			Me.Labelanecdote.Text = String.Concat(Me.titre, "" & VbCrLf & "" & VbCrLf & "", Module1.Lepoireaupreferelesfraises(Me.anec + 1))
		End Sub
	End Class
End Namespace