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
	Public Class FormBDDASS
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("ButtonFiltrer")>
		Private _ButtonFiltrer As Button

		<AccessedThroughProperty("Buttonaddfiltre")>
		Private _Buttonaddfiltre As Button

		<AccessedThroughProperty("Buttondelfiltre")>
		Private _Buttondelfiltre As Button

		<AccessedThroughProperty("Labellegume")>
		Private _Labellegume As Label

		<AccessedThroughProperty("Panelfiltre")>
		Private _Panelfiltre As Panel

		<AccessedThroughProperty("Labelgood")>
		Private _Labelgood As Label

		<AccessedThroughProperty("Labelbad")>
		Private _Labelbad As Label

		<AccessedThroughProperty("Panelgood")>
		Private _Panelgood As Panel

		<AccessedThroughProperty("Panelbad")>
		Private _Panelbad As Panel

		<AccessedThroughProperty("Labelligne")>
		Private _Labelligne As Label

		<AccessedThroughProperty("Buttonaddbdd")>
		Private _Buttonaddbdd As Button

		<AccessedThroughProperty("ComboBoxgood")>
		Private _ComboBoxgood As ComboBox

		<AccessedThroughProperty("ComboBoxbad")>
		Private _ComboBoxbad As ComboBox

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

		Private Aime As Label(,)

		Private Aimepas As Label(,)

		Private Affinites As Integer(,)

		Private nbrfiltre As Integer

		Private nligne As Integer

		Private anec As Integer

		Private comptass As Integer

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

		Private bddasstemp As String()

		Private titre As String

		Private présent1 As Boolean

		Private présent2 As Boolean

		Private add1 As Boolean

		Private add2 As Boolean

		Private del1 As Boolean

		Private del2 As Boolean

		Private filtre As ComboBox(,)

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.Button1_Click_1)
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
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.Button6_Click)
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
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.Button2_Click)
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
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.Button7_Click)
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
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.Button3_Click)
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
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.Button1_Click)
				If (Me._ButtonFiltrer IsNot Nothing) Then
					RemoveHandler Me._ButtonFiltrer.Click,  eventHandler
				End If
				Me._ButtonFiltrer = value
				If (Me._ButtonFiltrer IsNot Nothing) Then
					AddHandler Me._ButtonFiltrer.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ComboBoxbad As ComboBox
			Get
				Return Me._ComboBoxbad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.ComboBox2_SelectedIndexChanged)
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
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.ComboBox1_SelectedIndexChanged)
				If (Me._ComboBoxgood IsNot Nothing) Then
					RemoveHandler Me._ComboBoxgood.SelectedIndexChanged,  eventHandler
				End If
				Me._ComboBoxgood = value
				If (Me._ComboBoxgood IsNot Nothing) Then
					AddHandler Me._ComboBoxgood.SelectedIndexChanged,  eventHandler
				End If
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

		Friend Overridable Property Panelbad As Panel
			Get
				Return Me._Panelbad
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelbad = value
			End Set
		End Property

		Friend Overridable Property Panelfiltre As Panel
			Get
				Return Me._Panelfiltre
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelfiltre = value
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

		Friend Overridable Property Timer1 As Timer
			Get
				Return Me._Timer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Timer)
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDAss.Timer1_Tick)
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
			Dim formBDDAss1 As FormBDDASS = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formBDDAss1.Form2_Load)
			Dim formBDDAss2 As FormBDDASS = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formBDDAss2.FormBDDASS_FormClosed)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer
			Dim size As System.Drawing.Size
			Dim point As System.Drawing.Point
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
				Me.Aime = Nothing
				Me.Aimepas = Nothing
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
						If (Operators.ConditionalCompareObjectEqual(Module1.Base_de_données_associations(Me.legumesselectionnes(i), num), 1, False)) Then
							Me.Affinites(0, Me.nbraime) = num
							Me.nbraime = Me.nbraime + 1
						End If
						If (Operators.ConditionalCompareObjectEqual(Module1.Base_de_données_associations(num, Me.legumesselectionnes(i)), 1, False)) Then
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
						If (Operators.ConditionalCompareObjectEqual(Module1.Base_de_données_associations(Me.legumesselectionnes(i), num), -1, False)) Then
							Me.Affinites(1, Me.nbraimepas) = num
							Me.nbraimepas = Me.nbraimepas + 1
						End If
						If (Operators.ConditionalCompareObjectEqual(Module1.Base_de_données_associations(num, Me.legumesselectionnes(i)), -1, False)) Then
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
				ReDim Me.Aime(0, Me.nbraime + 1 - 1)
				Me.good = 0
				Dim num13 As Integer = Module1.nbrlegumesbase - 1
				i = 0
				Do
					If (Me.Occurence(0, i) = Me.nbrfiltre) Then
						Me.Aime(0, Me.good) = New Label()
						Dim aime As Label = Me.Aime(0, Me.good)
						size = New System.Drawing.Size(192, 16)
						aime.Size = size
						aime.AutoEllipsis = True
						aime.Text = Module1.listelégumes(i)
						point = New System.Drawing.Point(0, 21 * Me.good)
						aime.Location = point
						aime = Nothing
						Me.Panelgood.Controls.Add(Me.Aime(0, Me.good))
						Me.good = Me.good + 1
					End If
					i = i + 1
				Loop While i <= num13
				ReDim Me.Aimepas(0, Me.nbraimepas + 1 - 1)
				Me.bad = 0
				Dim num14 As Integer = Module1.nbrlegumesbase - 1
				For i = 0 To num14 Step 1
					If (Me.Occurence(1, i) = Me.nbrfiltre) Then
						Me.Aimepas(0, Me.bad) = New Label()
						Dim aimepas As Label = Me.Aimepas(0, Me.bad)
						size = New System.Drawing.Size(192, 16)
						aimepas.Size = size
						aimepas.AutoEllipsis = True
						aimepas.Text = Module1.listelégumes(i)
						point = New System.Drawing.Point(0, 21 * Me.bad)
						aimepas.Location = point
						aimepas = Nothing
						Me.Panelbad.Controls.Add(Me.Aimepas(0, Me.bad))
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
				Dim formBDDAss As SVPLCApplication.FormBDDASS = Me
				AddHandler comboBox.SelectedIndexChanged,  New EventHandler(AddressOf formBDDAss.filtre_selectedindexchanged)
				comboBox = Nothing
				Me.Panelfiltre.Controls.Add(Me.filtre(0, Me.nbrfiltre + 1))
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
			Me.Panelfiltre.Controls.Remove(Me.filtre(0, Me.nbrfiltre))
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
				If (Operators.CompareString(Me.ComboBoxgood.Text, Me.Aime(0, i).Text, False) = 0) Then
					Me.add1 = False
				End If
				i = i + 1
			Loop While i <= num
			Me.add2 = True
			Dim num1 As Integer = Me.bad - 1
			i = 0
			Do
				If (Operators.CompareString(Me.ComboBoxbad.Text, Me.Aimepas(0, i).Text, False) = 0) Then
					Me.add2 = False
				End If
				i = i + 1
			Loop While i <= num1
			If (Operators.CompareString(Me.ComboBoxgood.Text, "", False) <> 0 AndAlso Me.add1) Then
				Dim num2 As Integer = Me.nbrfiltre
				For i = 1 To num2 Step 1
					Try
						Dim num3 As Integer = String.Compare(Me.filtre(0, i).Text, Me.ComboBoxgood.Text)
						If (num3 < 0) Then
							File.AppendAllText(Module1.PATHS(1), String.Concat(Me.filtre(0, i).Text, "" & VbCrLf & "", Me.ComboBoxgood.Text, "" & VbCrLf & "o" & VbCrLf & ""), Encoding.UTF8)
						ElseIf (num3 > 0) Then
							File.AppendAllText(Module1.PATHS(1), String.Concat(Me.ComboBoxgood.Text, "" & VbCrLf & "", Me.filtre(0, i).Text, "" & VbCrLf & "o" & VbCrLf & ""), Encoding.UTF8)
						End If
					Catch exception As System.Exception
						ProjectData.SetProjectError(exception)
						MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture de l'association positive", "Erreur d'écriture")
						ProjectData.ClearProjectError()
					End Try
				Next

			End If
			If (Operators.CompareString(Me.ComboBoxbad.Text, "", False) <> 0 AndAlso Me.add2) Then
				Dim num4 As Integer = Me.nbrfiltre
				For i = 1 To num4 Step 1
					Try
						Dim num5 As Integer = String.Compare(Me.filtre(0, i).Text, Me.ComboBoxbad.Text)
						If (num5 < 0) Then
							File.AppendAllText(Module1.PATHS(1), String.Concat(Me.filtre(0, i).Text, "" & VbCrLf & "", Me.ComboBoxbad.Text, "" & VbCrLf & "n" & VbCrLf & ""), Encoding.UTF8)
						ElseIf (num5 > 0) Then
							File.AppendAllText(Module1.PATHS(1), String.Concat(Me.ComboBoxbad.Text, "" & VbCrLf & "", Me.filtre(0, i).Text, "" & VbCrLf & "n" & VbCrLf & ""), Encoding.UTF8)
						End If
					Catch exception1 As System.Exception
						ProjectData.SetProjectError(exception1)
						MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture de l'association négative", "Erreur d'écriture")
						ProjectData.ClearProjectError()
					End Try
				Next

			End If
			MyProject.Forms.FormPasPas.ChargementBDDasso()
			Me.Buttondelbdd.Enabled = False
			Me.Buttonaddbdd.Enabled = False
			Me.ComboBoxgood.SelectedItem = ""
			Me.ComboBoxbad.SelectedItem = ""
			Me.ButtonFiltrer.PerformClick()
		End Sub

		Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim i As Integer
			Dim j As Integer
			Me.comptass = 0
			Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Module1.PATHS(1), Encoding.[Default])
			Me.compt = 0
			While streamReader.Peek() <> -1
				Me.bddasstemp = DirectCast(Utils.CopyArray(DirectCast(Me.bddasstemp, Array), New String(Me.compt + 1 - 1) {}), String())
				Me.bddasstemp(Me.compt) = streamReader.ReadLine()
				Me.compt = Me.compt + 1
			End While
			streamReader.Close()
			Me.nligne = Me.compt
			Me.del1 = False
			If (Operators.CompareString(Me.ComboBoxgood.Text, "", False) <> 0) Then
				Dim num As Integer = Me.good - 1
				i = 0
				While i <= num
					If (Operators.CompareString(Me.Aime(0, i).Text, Me.ComboBoxgood.Text, False) <> 0) Then
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
					If (Operators.CompareString(Me.Aimepas(0, i).Text, Me.ComboBoxbad.Text, False) <> 0) Then
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
				i = 1
				Do
					Dim num3 As Integer = Me.nligne - 3
					j = 0
					Do
						If (Operators.CompareString(Me.bddasstemp(j), Me.ComboBoxgood.Text, False) = 0 AndAlso Operators.CompareString(Me.bddasstemp(j + 1), Me.filtre(0, i).Text, False) = 0 And Operators.CompareString(Me.bddasstemp(j + 2), "o", False) = 0) Then
							Me.bddasstemp(j) = ""
							Me.bddasstemp(j + 1) = ""
							Me.bddasstemp(j + 2) = ""
							Me.compt = Me.compt + 1
						End If
						j = j + 1
					Loop While j <= num3
					i = i + 1
				Loop While i <= num2
				Dim num4 As Integer = Me.nbrfiltre
				For i = 1 To num4 Step 1
					Dim num5 As Integer = Me.nligne - 2
					For j = 1 To num5 Step 1
						If (Operators.CompareString(Me.bddasstemp(j), Me.ComboBoxgood.Text, False) = 0 AndAlso Operators.CompareString(Me.bddasstemp(j + 1), "o", False) = 0 And Operators.CompareString(Me.bddasstemp(j - 1), Me.filtre(0, i).Text, False) = 0) Then
							Me.bddasstemp(j) = ""
							Me.bddasstemp(j + 1) = ""
							Me.bddasstemp(j - 1) = ""
							Me.compt = Me.compt + 1
						End If
					Next

				Next

			End If
			If (Me.del2) Then
				Dim num6 As Integer = Me.nbrfiltre
				i = 1
				Do
					Dim num7 As Integer = Me.nligne - 3
					j = 0
					Do
						If (Operators.CompareString(Me.bddasstemp(j), Me.ComboBoxbad.Text, False) = 0 AndAlso Operators.CompareString(Me.bddasstemp(j + 1), Me.filtre(0, i).Text, False) = 0 And Operators.CompareString(Me.bddasstemp(j + 2), "n", False) = 0) Then
							Me.bddasstemp(j) = ""
							Me.bddasstemp(j + 1) = ""
							Me.bddasstemp(j + 2) = ""
							Me.compt = Me.compt + 1
						End If
						j = j + 1
					Loop While j <= num7
					i = i + 1
				Loop While i <= num6
				Dim num8 As Integer = Me.nbrfiltre
				For i = 1 To num8 Step 1
					Dim num9 As Integer = Me.nligne - 2
					For j = 1 To num9 Step 1
						If (Operators.CompareString(Me.bddasstemp(j), Me.ComboBoxbad.Text, False) = 0 AndAlso Operators.CompareString(Me.bddasstemp(j + 1), "n", False) = 0 And Operators.CompareString(Me.bddasstemp(j - 1), Me.filtre(0, i).Text, False) = 0) Then
							Me.bddasstemp(j) = ""
							Me.bddasstemp(j + 1) = ""
							Me.bddasstemp(j - 1) = ""
							Me.compt = Me.compt + 1
						End If
					Next

				Next

			End If
			ReDim Me.suppnumeroligne(Me.nligne - 1 - 3 * (Me.comptass + Me.compt) + 1 - 1)
			Me.compt = 0
			Dim num10 As Integer = Me.nligne - 1
			Dim num11 As Integer = 0
			Do
				If (Operators.CompareString(Me.bddasstemp(num11), "", False) <> 0) Then
					Me.suppnumeroligne(Me.compt) = Me.bddasstemp(num11)
					Me.compt = Me.compt + 1
				End If
				num11 = num11 + 1
			Loop While num11 <= num10
			Me.nligne = Me.compt
			Try
				Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(Module1.PATHS(1), False, Encoding.[Default])
				Dim num12 As Integer = Me.nligne - 1
				j = 0
				Do
					streamWriter.WriteLine(Me.suppnumeroligne(j))
					j = j + 1
				Loop While j <= num12
				streamWriter.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture dans la nouvelle base de donnée", "Erreur")
				ProjectData.ClearProjectError()
			End Try
			MyProject.Forms.FormPasPas.ChargementBDDasso()
			Me.Buttondelbdd.Enabled = False
			Me.Buttonaddbdd.Enabled = False
			Me.ComboBoxgood.SelectedItem = ""
			Me.ComboBoxbad.SelectedItem = ""
			Me.ButtonFiltrer.PerformClick()
		End Sub

		Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.présent1 = False
			Dim num As Integer = Me.good - 1
			Dim num1 As Integer = 0
			While num1 <= num
				If (Operators.CompareString(Me.ComboBoxgood.Text, Me.Aime(0, num1).Text, False) <> 0) Then
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
				If (Operators.CompareString(Me.ComboBoxbad.Text, Me.Aimepas(0, num1).Text, False) <> 0) Then
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

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs)
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
			For i As Integer = 0 To num Step 1
				Me.ComboBoxgood.Items.Add(Module1.listelégumes(i))
				Me.ComboBoxbad.Items.Add(Module1.listelégumes(i))
			Next

		End Sub

		Private Sub FormBDDASS_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadbddass = False
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBDDASS))
			Me.ButtonFiltrer = New System.Windows.Forms.Button()
			Me.Buttonaddfiltre = New System.Windows.Forms.Button()
			Me.Buttondelfiltre = New System.Windows.Forms.Button()
			Me.Labellegume = New System.Windows.Forms.Label()
			Me.Panelfiltre = New System.Windows.Forms.Panel()
			Me.Labelgood = New System.Windows.Forms.Label()
			Me.Labelbad = New System.Windows.Forms.Label()
			Me.Panelgood = New System.Windows.Forms.Panel()
			Me.Panelbad = New System.Windows.Forms.Panel()
			Me.Labelligne = New System.Windows.Forms.Label()
			Me.Buttonaddbdd = New System.Windows.Forms.Button()
			Me.ComboBoxgood = New System.Windows.Forms.ComboBox()
			Me.ComboBoxbad = New System.Windows.Forms.ComboBox()
			Me.Buttondelbdd = New System.Windows.Forms.Button()
			Me.Labelsaviezvous = New System.Windows.Forms.Label()
			Me.Labelanecdote = New System.Windows.Forms.Label()
			Me.Timer1 = New Timer(Me.components)
			Me.Button1 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			Dim buttonFiltrer As System.Windows.Forms.Button = Me.ButtonFiltrer
			Dim point As System.Drawing.Point = New System.Drawing.Point(712, 331)
			buttonFiltrer.Location = point
			Me.ButtonFiltrer.Name = "ButtonFiltrer"
			Dim button As System.Windows.Forms.Button = Me.ButtonFiltrer
			Dim size As System.Drawing.Size = New System.Drawing.Size(300, 52)
			button.Size = size
			Me.ButtonFiltrer.TabIndex = 10
			Me.ButtonFiltrer.Text = "Filtrer"
			Me.ButtonFiltrer.UseVisualStyleBackColor = True
			Dim buttonaddfiltre As System.Windows.Forms.Button = Me.Buttonaddfiltre
			point = New System.Drawing.Point(40, 330)
			buttonaddfiltre.Location = point
			Me.Buttonaddfiltre.Name = "Buttonaddfiltre"
			Dim buttonaddfiltre1 As System.Windows.Forms.Button = Me.Buttonaddfiltre
			size = New System.Drawing.Size(124, 23)
			buttonaddfiltre1.Size = size
			Me.Buttonaddfiltre.TabIndex = 5
			Me.Buttonaddfiltre.Text = "Ajouter un filtre"
			Me.Buttonaddfiltre.UseVisualStyleBackColor = True
			Dim buttondelfiltre As System.Windows.Forms.Button = Me.Buttondelfiltre
			point = New System.Drawing.Point(40, 360)
			buttondelfiltre.Location = point
			Me.Buttondelfiltre.Name = "Buttondelfiltre"
			Dim buttondelfiltre1 As System.Windows.Forms.Button = Me.Buttondelfiltre
			size = New System.Drawing.Size(124, 23)
			buttondelfiltre1.Size = size
			Me.Buttondelfiltre.TabIndex = 8
			Me.Buttondelfiltre.Text = "Supprimer un filtre"
			Me.Buttondelfiltre.UseVisualStyleBackColor = True
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
			Dim panelfiltre As System.Windows.Forms.Panel = Me.Panelfiltre
			point = New System.Drawing.Point(40, 55)
			panelfiltre.Location = point
			Me.Panelfiltre.Name = "Panelfiltre"
			Dim panel As System.Windows.Forms.Panel = Me.Panelfiltre
			size = New System.Drawing.Size(158, 249)
			panel.Size = size
			Me.Panelfiltre.TabIndex = 4
			Me.Labelgood.AutoSize = True
			Me.Labelgood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelgood.ForeColor = Color.Green
			Dim labelgood As System.Windows.Forms.Label = Me.Labelgood
			point = New System.Drawing.Point(247, 22)
			labelgood.Location = point
			Me.Labelgood.Name = "Labelgood"
			Dim labelgood1 As System.Windows.Forms.Label = Me.Labelgood
			size = New System.Drawing.Size(63, 15)
			labelgood1.Size = size
			Me.Labelgood.TabIndex = 1
			Me.Labelgood.Text = "Apprécie"
			Me.Labelbad.AutoSize = True
			Me.Labelbad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelbad.ForeColor = Color.Red
			Dim labelbad As System.Windows.Forms.Label = Me.Labelbad
			point = New System.Drawing.Point(468, 22)
			labelbad.Location = point
			Me.Labelbad.Name = "Labelbad"
			Dim labelbad1 As System.Windows.Forms.Label = Me.Labelbad
			size = New System.Drawing.Size(104, 15)
			labelbad1.Size = size
			Me.Labelbad.TabIndex = 2
			Me.Labelbad.Text = "N'apprécie pas"
			Me.Panelgood.AutoScroll = True
			Dim panelgood As System.Windows.Forms.Panel = Me.Panelgood
			point = New System.Drawing.Point(250, 55)
			panelgood.Location = point
			Me.Panelgood.Name = "Panelgood"
			Dim panelgood1 As System.Windows.Forms.Panel = Me.Panelgood
			size = New System.Drawing.Size(192, 327)
			panelgood1.Size = size
			Me.Panelgood.TabIndex = 6
			Me.Panelbad.AutoScroll = True
			Dim panelbad As System.Windows.Forms.Panel = Me.Panelbad
			point = New System.Drawing.Point(471, 55)
			panelbad.Location = point
			Me.Panelbad.Name = "Panelbad"
			Dim panelbad1 As System.Windows.Forms.Panel = Me.Panelbad
			size = New System.Drawing.Size(192, 327)
			panelbad1.Size = size
			Me.Panelbad.TabIndex = 7
			Me.Labelligne.BackColor = Color.FromArgb(192, 64, 0)
			Dim labelligne As System.Windows.Forms.Label = Me.Labelligne
			point = New System.Drawing.Point(40, 410)
			labelligne.Location = point
			Me.Labelligne.Name = "Labelligne"
			Dim labelligne1 As System.Windows.Forms.Label = Me.Labelligne
			size = New System.Drawing.Size(960, 4)
			labelligne1.Size = size
			Me.Labelligne.TabIndex = 11
			Dim buttonaddbdd As System.Windows.Forms.Button = Me.Buttonaddbdd
			point = New System.Drawing.Point(712, 438)
			buttonaddbdd.Location = point
			Me.Buttonaddbdd.Name = "Buttonaddbdd"
			Dim buttonaddbdd1 As System.Windows.Forms.Button = Me.Buttonaddbdd
			size = New System.Drawing.Size(300, 23)
			buttonaddbdd1.Size = size
			Me.Buttonaddbdd.TabIndex = 15
			Me.Buttonaddbdd.Text = "Ajouter à la BDD"
			Me.Buttonaddbdd.UseVisualStyleBackColor = True
			Me.ComboBoxgood.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBoxgood.FormattingEnabled = True
			Dim comboBoxgood As System.Windows.Forms.ComboBox = Me.ComboBoxgood
			point = New System.Drawing.Point(250, 438)
			comboBoxgood.Location = point
			Me.ComboBoxgood.Name = "ComboBoxgood"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBoxgood
			size = New System.Drawing.Size(150, 21)
			comboBox.Size = size
			Me.ComboBoxgood.TabIndex = 13
			Me.ComboBoxbad.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBoxbad.FormattingEnabled = True
			Dim comboBoxbad As System.Windows.Forms.ComboBox = Me.ComboBoxbad
			point = New System.Drawing.Point(471, 438)
			comboBoxbad.Location = point
			Me.ComboBoxbad.Name = "ComboBoxbad"
			Dim comboBoxbad1 As System.Windows.Forms.ComboBox = Me.ComboBoxbad
			size = New System.Drawing.Size(150, 21)
			comboBoxbad1.Size = size
			Me.ComboBoxbad.TabIndex = 14
			Dim buttondelbdd As System.Windows.Forms.Button = Me.Buttondelbdd
			point = New System.Drawing.Point(712, 468)
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
			point = New System.Drawing.Point(801, 20)
			labelsaviezvous.Location = point
			Me.Labelsaviezvous.Name = "Labelsaviezvous"
			Dim labelsaviezvous1 As System.Windows.Forms.Label = Me.Labelsaviezvous
			size = New System.Drawing.Size(128, 17)
			labelsaviezvous1.Size = size
			Me.Labelsaviezvous.TabIndex = 3
			Me.Labelsaviezvous.Text = "Le Saviez-vous?"
			Me.Labelanecdote.AutoEllipsis = True
			Me.Labelanecdote.BackColor = SystemColors.ActiveCaption
			Me.Labelanecdote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim labelanecdote As System.Windows.Forms.Label = Me.Labelanecdote
			point = New System.Drawing.Point(712, 55)
			labelanecdote.Location = point
			Me.Labelanecdote.Name = "Labelanecdote"
			Dim labelanecdote1 As System.Windows.Forms.Label = Me.Labelanecdote
			size = New System.Drawing.Size(300, 328)
			labelanecdote1.Size = size
			Me.Labelanecdote.TabIndex = 9
			Me.Labelanecdote.Text = "Le poireau préfère les fraises"
			Me.Labelanecdote.TextAlign = ContentAlignment.MiddleCenter
			Me.Timer1.Interval = 50000
			Me.Button1.BackgroundImage = Resources.flechenext
			Me.Button1.BackgroundImageLayout = ImageLayout.Stretch
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(987, 386)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button11 As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(25, 23)
			button11.Size = size
			Me.Button1.TabIndex = 17
			Me.Button1.UseVisualStyleBackColor = True
			Me.AcceptButton = Me.Buttonaddfiltre
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			Me.BackColor = Color.DarkKhaki
			size = New System.Drawing.Size(1024, 508)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Labelanecdote)
			Me.Controls.Add(Me.Labelsaviezvous)
			Me.Controls.Add(Me.Buttondelbdd)
			Me.Controls.Add(Me.ComboBoxbad)
			Me.Controls.Add(Me.ComboBoxgood)
			Me.Controls.Add(Me.Buttonaddbdd)
			Me.Controls.Add(Me.Labelligne)
			Me.Controls.Add(Me.Panelbad)
			Me.Controls.Add(Me.Panelgood)
			Me.Controls.Add(Me.Labelbad)
			Me.Controls.Add(Me.Labelgood)
			Me.Controls.Add(Me.Panelfiltre)
			Me.Controls.Add(Me.Labellegume)
			Me.Controls.Add(Me.Buttondelfiltre)
			Me.Controls.Add(Me.Buttonaddfiltre)
			Me.Controls.Add(Me.ButtonFiltrer)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormBDDASS"
			Me.Text = "Base de données associations"
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