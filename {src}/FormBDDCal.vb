Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormBDDCal
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("ComboBoxlegume")>
		Private _ComboBoxlegume As ComboBox

		<AccessedThroughProperty("Labellegume")>
		Private _Labellegume As Label

		<AccessedThroughProperty("Labelfam")>
		Private _Labelfam As Label

		<AccessedThroughProperty("Labelsemis")>
		Private _Labelsemis As Label

		<AccessedThroughProperty("Labelrecolte")>
		Private _Labelrecolte As Label

		<AccessedThroughProperty("Labelfamresult")>
		Private _Labelfamresult As Label

		<AccessedThroughProperty("Labelsemisresult")>
		Private _Labelsemisresult As Label

		<AccessedThroughProperty("Labelrecolteresult")>
		Private _Labelrecolteresult As Label

		<AccessedThroughProperty("ComboBox1semis")>
		Private _ComboBox1semis As ComboBox

		<AccessedThroughProperty("lbl")>
		Private _lbl As Label

		<AccessedThroughProperty("lblsep")>
		Private _lblsep As Label

		<AccessedThroughProperty("ComboBox2semis")>
		Private _ComboBox2semis As ComboBox

		<AccessedThroughProperty("ComboBox1recolte")>
		Private _ComboBox1recolte As ComboBox

		<AccessedThroughProperty("ComboBox2recolte")>
		Private _ComboBox2recolte As ComboBox

		<AccessedThroughProperty("lblDe")>
		Private _lblDe As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("lblA")>
		Private _lblA As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Labeltype")>
		Private _Labeltype As Label

		<AccessedThroughProperty("ComboBoxtype")>
		Private _ComboBoxtype As ComboBox

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("ComboBoxfam")>
		Private _ComboBoxfam As ComboBox

		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		Private convertcal As String()

		Private nouvelledonnees As String()

		Private Nouvellebddcalendrier As String()

		Private newlegume As Boolean

		Private compt As Integer

		Private pathimage As String

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDCal As SVPLCApplication.FormBDDCal = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDCal.Button1_Click)
				If (Me._Button1 IsNot Nothing) Then
					RemoveHandler Me._Button1.Click,  eventHandler
				End If
				Me._Button1 = value
				If (Me._Button1 IsNot Nothing) Then
					AddHandler Me._Button1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBox1 As CheckBox
			Get
				Return Me._CheckBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Me._CheckBox1 = value
			End Set
		End Property

		Friend Overridable Property ComboBox1recolte As ComboBox
			Get
				Return Me._ComboBox1recolte
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox1recolte = value
			End Set
		End Property

		Friend Overridable Property ComboBox1semis As ComboBox
			Get
				Return Me._ComboBox1semis
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox1semis = value
			End Set
		End Property

		Friend Overridable Property ComboBox2recolte As ComboBox
			Get
				Return Me._ComboBox2recolte
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox2recolte = value
			End Set
		End Property

		Friend Overridable Property ComboBox2semis As ComboBox
			Get
				Return Me._ComboBox2semis
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox2semis = value
			End Set
		End Property

		Friend Overridable Property ComboBoxfam As ComboBox
			Get
				Return Me._ComboBoxfam
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBoxfam = value
			End Set
		End Property

		Friend Overridable Property ComboBoxlegume As ComboBox
			Get
				Return Me._ComboBoxlegume
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Dim formBDDCal As SVPLCApplication.FormBDDCal = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDCal.comboboxitemschanged)
				If (Me._ComboBoxlegume IsNot Nothing) Then
					RemoveHandler Me._ComboBoxlegume.SelectedIndexChanged,  eventHandler
				End If
				Me._ComboBoxlegume = value
				If (Me._ComboBoxlegume IsNot Nothing) Then
					AddHandler Me._ComboBoxlegume.SelectedIndexChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ComboBoxtype As ComboBox
			Get
				Return Me._ComboBoxtype
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBoxtype = value
			End Set
		End Property

		Private Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label1 = value
			End Set
		End Property

		Private Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property Label3 As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label3 = value
			End Set
		End Property

		Friend Overridable Property Labelfam As Label
			Get
				Return Me._Labelfam
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelfam = value
			End Set
		End Property

		Friend Overridable Property Labelfamresult As Label
			Get
				Return Me._Labelfamresult
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelfamresult = value
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

		Friend Overridable Property Labelrecolte As Label
			Get
				Return Me._Labelrecolte
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelrecolte = value
			End Set
		End Property

		Friend Overridable Property Labelrecolteresult As Label
			Get
				Return Me._Labelrecolteresult
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelrecolteresult = value
			End Set
		End Property

		Friend Overridable Property Labelsemis As Label
			Get
				Return Me._Labelsemis
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelsemis = value
			End Set
		End Property

		Friend Overridable Property Labelsemisresult As Label
			Get
				Return Me._Labelsemisresult
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelsemisresult = value
			End Set
		End Property

		Friend Overridable Property Labeltype As Label
			Get
				Return Me._Labeltype
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeltype = value
			End Set
		End Property

		Friend Overridable Property lbl As Label
			Get
				Return Me._lbl
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lbl = value
			End Set
		End Property

		Private Overridable Property lblA As Label
			Get
				Return Me._lblA
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblA = value
			End Set
		End Property

		Private Overridable Property lblDe As Label
			Get
				Return Me._lblDe
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblDe = value
			End Set
		End Property

		Private Overridable Property lblsep As Label
			Get
				Return Me._lblsep
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblsep = value
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

		Public Sub New()
			MyBase.New()
			Dim formBDDCal1 As FormBDDCal = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formBDDCal1.Form10_Load)
			Dim formBDDCal2 As FormBDDCal = Me
			AddHandler MyBase.FormClosing,  New FormClosingEventHandler(AddressOf formBDDCal2.FormMajbddcal_FormClosing)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.nouvelledonnees = Nothing
			Me.nouvelledonnees = New String() { Me.ComboBoxlegume.Text, Me.ComboBoxfam.Text, Conversions.ToString(Me.moischiffre(Me.ComboBox1semis.Text)), Conversions.ToString(Me.moischiffre(Me.ComboBox2semis.Text)), Conversions.ToString(Me.moischiffre(Me.ComboBox1recolte.Text)), Conversions.ToString(Me.moischiffre(Me.ComboBox2recolte.Text)), Me.ComboBoxtype.Text, Nothing }
			Me.nouvelledonnees(7) = Me.CheckBox1.Checked.ToString()
			Select Case Me.newlegume
				Case False
					Dim num As Integer = Module1.nbrlignecal - 1
					Dim num1 As Integer = 0
					Do
						If (Operators.CompareString(Module1.Base_de_données_calendrier(num1), Me.nouvelledonnees(0), False) = 0) Then
							Module1.Base_de_données_calendrier(num1 + 1) = Me.nouvelledonnees(1)
							Module1.Base_de_données_calendrier(num1 + 2) = Me.nouvelledonnees(2)
							Module1.Base_de_données_calendrier(num1 + 3) = Me.nouvelledonnees(3)
							Module1.Base_de_données_calendrier(num1 + 4) = Me.nouvelledonnees(4)
							Module1.Base_de_données_calendrier(num1 + 5) = Me.nouvelledonnees(5)
							Module1.Base_de_données_calendrier(num1 + 6) = Me.nouvelledonnees(6)
							Module1.Base_de_données_calendrier(num1 + 7) = Me.nouvelledonnees(7)
							Me.ComboBoxfam.SelectedIndex = -1
							Dim length As Integer = CInt(Module1.FAMILLE.Length) - 1
							Dim num2 As Integer = 0
							While num2 <= length
								If (Operators.CompareString(Module1.Base_de_données_calendrier(num1 + 1), Module1.FAMILLE(num2), False) <> 0) Then
									num2 = num2 + 1
								Else
									Me.ComboBoxfam.SelectedIndex = num2
									Exit While
								End If
							End While
							Me.ComboBoxtype.SelectedIndex = -1
							Dim length1 As Integer = CInt(Module1.TYPE.Length) - 1
							Dim num3 As Integer = 0
							While num3 <= length1
								If (Operators.CompareString(Module1.Base_de_données_calendrier(num1 + 6), Module1.TYPE(num3), False) <> 0) Then
									num3 = num3 + 1
								Else
									Me.ComboBoxtype.SelectedIndex = num3
									Exit While
								End If
							End While
							Me.ComboBox1semis.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 2)) - 1))
							Me.ComboBox2semis.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 3)) - 1))
							Me.ComboBox1recolte.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 4)) - 1))
							Me.ComboBox2recolte.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 5)) - 1))
							Me.CheckBox1.Checked = Conversions.ToBoolean(Module1.Base_de_données_calendrier(num1 + 7))
						End If
						num1 = num1 + 1
					Loop While num1 <= num
					Exit Select
				Case True
					Dim num4 As Integer = 0
					Do
						Module1.Base_de_données_calendrier = DirectCast(Utils.CopyArray(DirectCast(Module1.Base_de_données_calendrier, Array), New String(Module1.nbrlignecal + num4 + 1 - 1) {}), String())
						If (num4 > 0) Then
							Module1.Base_de_données_calendrier(Module1.nbrlignecal + num4) = Me.nouvelledonnees(num4 - 1)
						End If
						num4 = num4 + 1
					Loop While num4 <= 8
					Module1.nbrlignecal = Module1.nbrlignecal + 9
					Exit Select
			End Select
			Try
				Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(Module1.PATHS(11), False, Encoding.[Default])
				Dim num5 As Integer = Module1.nbrlignecal - 1
				Dim num6 As Integer = 0
				Do
					streamWriter.WriteLine(Module1.Base_de_données_calendrier(num6))
					num6 = num6 + 1
				Loop While num6 <= num5
				streamWriter.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur écriture nouvelle base de données calendrier !", "Erreur")
				ProjectData.ClearProjectError()
			End Try
			Me.ComboBoxfam.SelectedIndex = -1
			Me.ComboBoxtype.SelectedIndex = -1
			Me.ComboBox1semis.SelectedIndex = -1
			Me.ComboBox1recolte.SelectedIndex = -1
			Me.ComboBox2semis.SelectedIndex = -1
			Me.ComboBox2recolte.SelectedIndex = -1
			Me.CheckBox1.Checked = False
			Dim num7 As Integer = Module1.nbrlignecal - 1
			Dim num8 As Integer = 0
			Do
				If (Operators.CompareString(Me.ComboBoxlegume.Text, Module1.Base_de_données_calendrier(num8), False) = 0) Then
					Me.Labelfamresult.Text = Module1.Base_de_données_calendrier(num8 + 1)
					Me.Labelsemisresult.Text = String.Concat("De ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num8 + 2))), " à ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num8 + 3))))
					Me.Labelrecolteresult.Text = String.Concat("De ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num8 + 4))), " à ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num8 + 5))))
					Me.Labeltype.Text = Conversions.ToString(Operators.ConcatenateObject(String.Concat(Module1.Base_de_données_calendrier(num8 + 6), "  "), Me.vivace(Module1.Base_de_données_calendrier(num8 + 7))))
					Me.ComboBoxfam.SelectedIndex = -1
					Dim length2 As Integer = CInt(Module1.FAMILLE.Length) - 1
					Dim num9 As Integer = 0
					While num9 <= length2
						If (Operators.CompareString(Module1.Base_de_données_calendrier(num8 + 1), Module1.FAMILLE(num9), False) <> 0) Then
							num9 = num9 + 1
						Else
							Me.ComboBoxfam.SelectedIndex = num9
							Exit While
						End If
					End While
					Me.ComboBoxtype.SelectedIndex = -1
					Dim length3 As Integer = CInt(Module1.TYPE.Length) - 1
					Dim num10 As Integer = 0
					While num10 <= length3
						If (Operators.CompareString(Module1.Base_de_données_calendrier(num8 + 6), Module1.TYPE(num10), False) <> 0) Then
							num10 = num10 + 1
						Else
							Me.ComboBoxtype.SelectedIndex = num10
							Exit While
						End If
					End While
					Me.ComboBox1semis.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num8 + 2)) - 1))
					Me.ComboBox2semis.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num8 + 3)) - 1))
					Me.ComboBox1recolte.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num8 + 4)) - 1))
					Me.ComboBox2recolte.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num8 + 5)) - 1))
					Me.CheckBox1.Checked = Conversions.ToBoolean(Module1.Base_de_données_calendrier(num8 + 7))
				End If
				num8 = num8 + 1
			Loop While num8 <= num7
			MyProject.Forms.FormPasPas.ChargementBDDrot()
		End Sub

		Private Function chiffremois(ByVal x As Integer) As String
			Dim str As String = ""
			Select Case x Mod 2
				Case 0
					str = String.Concat("mi-", Me.convertcal(CInt(Math.Round(CDbl(x) / 2))))
					Exit Select
				Case 1
					str = Me.convertcal(CInt(Math.Round(CDbl((x + 1)) / 2)))
					Exit Select
			End Select
			Return str
		End Function

		Private Sub comboboxitemschanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.pathimage = String.Concat(Module1.PATHS(13), "\", Me.ComboBoxlegume.Text, ".png")
			If (Not File.Exists(Me.pathimage)) Then
				Me.PictureBox1.BackgroundImage = Nothing
			Else
				Me.PictureBox1.BackgroundImage = Image.FromFile(Me.pathimage)
			End If
			Me.Button1.Enabled = True
			Me.compt = 0
			Dim num As Integer = Module1.nbrlignecal - 1
			Dim num1 As Integer = 0
			Do
				If (Operators.CompareString(Me.ComboBoxlegume.Text, Module1.Base_de_données_calendrier(num1), False) = 0) Then
					Me.Labelfamresult.Text = Module1.Base_de_données_calendrier(num1 + 1)
					Me.Labelsemisresult.Text = String.Concat("De ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num1 + 2))), " à ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num1 + 3))))
					Me.Labelrecolteresult.Text = String.Concat("De ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num1 + 4))), " à ", Me.chiffremois(Conversions.ToInteger(Module1.Base_de_données_calendrier(num1 + 5))))
					Me.Labeltype.Text = Conversions.ToString(Operators.ConcatenateObject(String.Concat(Module1.Base_de_données_calendrier(num1 + 6), "  "), Me.vivace(Module1.Base_de_données_calendrier(num1 + 7))))
					Me.ComboBoxfam.SelectedIndex = -1
					Dim length As Integer = CInt(Module1.FAMILLE.Length) - 1
					Dim num2 As Integer = 0
					While num2 <= length
						If (Operators.CompareString(Module1.Base_de_données_calendrier(num1 + 1), Module1.FAMILLE(num2), False) <> 0) Then
							num2 = num2 + 1
						Else
							Me.ComboBoxfam.SelectedIndex = num2
							Exit While
						End If
					End While
					Me.ComboBoxtype.SelectedIndex = -1
					Dim length1 As Integer = CInt(Module1.TYPE.Length) - 1
					Dim num3 As Integer = 0
					While num3 <= length1
						If (Operators.CompareString(Module1.Base_de_données_calendrier(num1 + 6), Module1.TYPE(num3), False) <> 0) Then
							num3 = num3 + 1
						Else
							Me.ComboBoxtype.SelectedIndex = num3
							Exit While
						End If
					End While
					Me.ComboBox1semis.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 2)) - 1))
					Me.ComboBox2semis.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 3)) - 1))
					Me.ComboBox1recolte.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 4)) - 1))
					Me.ComboBox2recolte.SelectedIndex = CInt(Math.Round(Conversions.ToDouble(Module1.Base_de_données_calendrier(num1 + 5)) - 1))
					Me.CheckBox1.Checked = False
					Try
						Me.CheckBox1.Checked = Conversions.ToBoolean(Module1.Base_de_données_calendrier(num1 + 7))
					Catch exception As System.Exception
						ProjectData.SetProjectError(exception)
						ProjectData.ClearProjectError()
					End Try
					Me.newlegume = False
					Return
				End If
				Me.compt = Me.compt + 1
				num1 = num1 + 1
			Loop While num1 <= num
			If (Me.compt = Module1.nbrlignecal) Then
				Me.Labelfamresult.Text = ""
				Me.Labelsemisresult.Text = ""
				Me.Labelrecolteresult.Text = ""
				Me.Labeltype.Text = ""
				Me.ComboBoxfam.SelectedIndex = -1
				Me.ComboBoxtype.SelectedIndex = -1
				Me.ComboBox1semis.SelectedIndex = -1
				Me.ComboBox1recolte.SelectedIndex = -1
				Me.ComboBox2semis.SelectedIndex = -1
				Me.ComboBox2recolte.SelectedIndex = -1
				Me.CheckBox1.Checked = False
				Me.newlegume = True
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

		Private Sub Form10_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Me.Button1.Enabled = False
			Me.Labeltype.Text = ""
			Me.Labelfamresult.Text = ""
			Me.Labelsemisresult.Text = ""
			Me.Labelrecolteresult.Text = ""
			Me.newlegume = False
			Me.convertcal = New String() { "", "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" }
			Dim num As Integer = Module1.nbrlegumesbase - 1
			Dim num1 As Integer = 0
			Do
				Me.ComboBoxlegume.Items.Add(Module1.listelégumes(num1))
				num1 = num1 + 1
			Loop While num1 <= num
			Dim length As Integer = CInt(Module1.FAMILLE.Length) - 1
			Dim num2 As Integer = 0
			Do
				Me.ComboBoxfam.Items.Add(Module1.FAMILLE(num2))
				num2 = num2 + 1
			Loop While num2 <= length
			Dim length1 As Integer = CInt(Module1.TYPE.Length) - 1
			Dim num3 As Integer = 0
			Do
				Me.ComboBoxtype.Items.Add(Module1.TYPE(num3))
				num3 = num3 + 1
			Loop While num3 <= length1
			Dim num4 As Integer = 1
			Do
				Dim items As ComboBox.ObjectCollection = Me.ComboBox1semis.Items
				items.Add(Me.convertcal(num4))
				items.Add(String.Concat("mi-", Me.convertcal(num4)))
				items = Nothing
				Dim objectCollections As ComboBox.ObjectCollection = Me.ComboBox2semis.Items
				objectCollections.Add(Me.convertcal(num4))
				objectCollections.Add(String.Concat("mi-", Me.convertcal(num4)))
				objectCollections = Nothing
				Dim items1 As ComboBox.ObjectCollection = Me.ComboBox1recolte.Items
				items1.Add(Me.convertcal(num4))
				items1.Add(String.Concat("mi-", Me.convertcal(num4)))
				items1 = Nothing
				Dim objectCollections1 As ComboBox.ObjectCollection = Me.ComboBox2recolte.Items
				objectCollections1.Add(Me.convertcal(num4))
				objectCollections1.Add(String.Concat("mi-", Me.convertcal(num4)))
				objectCollections1 = Nothing
				num4 = num4 + 1
			Loop While num4 <= 12
			Try
				enumerator = Me.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As Control = DirectCast(enumerator.Current, Control)
					If (Not TypeOf current Is ComboBox) Then
						Continue While
					End If
					Dim formBDDCal As SVPLCApplication.FormBDDCal = Me
					AddHandler current.TextChanged,  New EventHandler(AddressOf formBDDCal.selectedindexchanged)
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Sub FormMajbddcal_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			Module1.loadcal = False
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBDDCal))
			Me.Button1 = New System.Windows.Forms.Button()
			Me.ComboBoxlegume = New System.Windows.Forms.ComboBox()
			Me.Labellegume = New System.Windows.Forms.Label()
			Me.Labelfam = New System.Windows.Forms.Label()
			Me.Labelsemis = New System.Windows.Forms.Label()
			Me.Labelrecolte = New System.Windows.Forms.Label()
			Me.Labelfamresult = New System.Windows.Forms.Label()
			Me.Labelsemisresult = New System.Windows.Forms.Label()
			Me.Labelrecolteresult = New System.Windows.Forms.Label()
			Me.ComboBox1semis = New System.Windows.Forms.ComboBox()
			Me.lbl = New System.Windows.Forms.Label()
			Me.lblsep = New System.Windows.Forms.Label()
			Me.ComboBox2semis = New System.Windows.Forms.ComboBox()
			Me.ComboBox1recolte = New System.Windows.Forms.ComboBox()
			Me.ComboBox2recolte = New System.Windows.Forms.ComboBox()
			Me.lblDe = New System.Windows.Forms.Label()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.lblA = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Labeltype = New System.Windows.Forms.Label()
			Me.ComboBoxtype = New System.Windows.Forms.ComboBox()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.ComboBoxfam = New System.Windows.Forms.ComboBox()
			Me.CheckBox1 = New System.Windows.Forms.CheckBox()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			Dim point As System.Drawing.Point = New System.Drawing.Point(602, 270)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			Dim size As System.Drawing.Size = New System.Drawing.Size(153, 44)
			button.Size = size
			Me.Button1.TabIndex = 19
			Me.Button1.Text = "Mettre à jour"
			Me.Button1.UseVisualStyleBackColor = True
			Me.ComboBoxlegume.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBoxlegume.FormattingEnabled = True
			Dim comboBoxlegume As System.Windows.Forms.ComboBox = Me.ComboBoxlegume
			point = New System.Drawing.Point(145, 32)
			comboBoxlegume.Location = point
			Me.ComboBoxlegume.Name = "ComboBoxlegume"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBoxlegume
			size = New System.Drawing.Size(121, 21)
			comboBox.Size = size
			Me.ComboBoxlegume.TabIndex = 2
			Me.Labellegume.AutoSize = True
			Me.Labellegume.Font = New System.Drawing.Font("Times New Roman", 15.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labellegume.ForeColor = SystemColors.InfoText
			Dim labellegume As System.Windows.Forms.Label = Me.Labellegume
			point = New System.Drawing.Point(12, 27)
			labellegume.Location = point
			Me.Labellegume.Name = "Labellegume"
			Dim label As System.Windows.Forms.Label = Me.Labellegume
			size = New System.Drawing.Size(80, 24)
			label.Size = size
			Me.Labellegume.TabIndex = 1
			Me.Labellegume.Text = "Plante :"
			Me.Labelfam.AutoSize = True
			Me.Labelfam.Font = New System.Drawing.Font("Times New Roman", 12!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelfam.ForeColor = Color.FromArgb(255, 128, 0)
			Dim labelfam As System.Windows.Forms.Label = Me.Labelfam
			point = New System.Drawing.Point(13, 80)
			labelfam.Location = point
			Me.Labelfam.Name = "Labelfam"
			Dim labelfam1 As System.Windows.Forms.Label = Me.Labelfam
			size = New System.Drawing.Size(89, 19)
			labelfam1.Size = size
			Me.Labelfam.TabIndex = 3
			Me.Labelfam.Text = "FAMILLE :"
			Me.Labelsemis.AutoSize = True
			Me.Labelsemis.Font = New System.Drawing.Font("Times New Roman", 12!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelsemis.ForeColor = Color.Green
			Dim labelsemis As System.Windows.Forms.Label = Me.Labelsemis
			point = New System.Drawing.Point(13, 176)
			labelsemis.Location = point
			Me.Labelsemis.Name = "Labelsemis"
			Dim labelsemis1 As System.Windows.Forms.Label = Me.Labelsemis
			size = New System.Drawing.Size(129, 19)
			labelsemis1.Size = size
			Me.Labelsemis.TabIndex = 7
			Me.Labelsemis.Text = "Semis/Plantation :"
			Me.Labelrecolte.AutoSize = True
			Me.Labelrecolte.Font = New System.Drawing.Font("Times New Roman", 12!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelrecolte.ForeColor = Color.Red
			Dim labelrecolte As System.Windows.Forms.Label = Me.Labelrecolte
			point = New System.Drawing.Point(13, 217)
			labelrecolte.Location = point
			Me.Labelrecolte.Name = "Labelrecolte"
			Dim labelrecolte1 As System.Windows.Forms.Label = Me.Labelrecolte
			size = New System.Drawing.Size(70, 19)
			labelrecolte1.Size = size
			Me.Labelrecolte.TabIndex = 13
			Me.Labelrecolte.Text = "Récolte :"
			Me.Labelfamresult.AutoSize = True
			Dim labelfamresult As System.Windows.Forms.Label = Me.Labelfamresult
			point = New System.Drawing.Point(148, 84)
			labelfamresult.Location = point
			Me.Labelfamresult.Name = "Labelfamresult"
			Dim labelfamresult1 As System.Windows.Forms.Label = Me.Labelfamresult
			size = New System.Drawing.Size(39, 13)
			labelfamresult1.Size = size
			Me.Labelfamresult.TabIndex = 4
			Me.Labelfamresult.Text = "Label5"
			Me.Labelsemisresult.AutoSize = True
			Dim labelsemisresult As System.Windows.Forms.Label = Me.Labelsemisresult
			point = New System.Drawing.Point(148, 180)
			labelsemisresult.Location = point
			Me.Labelsemisresult.Name = "Labelsemisresult"
			Dim labelsemisresult1 As System.Windows.Forms.Label = Me.Labelsemisresult
			size = New System.Drawing.Size(39, 13)
			labelsemisresult1.Size = size
			Me.Labelsemisresult.TabIndex = 8
			Me.Labelsemisresult.Text = "Label6"
			Me.Labelrecolteresult.AutoSize = True
			Dim labelrecolteresult As System.Windows.Forms.Label = Me.Labelrecolteresult
			point = New System.Drawing.Point(148, 221)
			labelrecolteresult.Location = point
			Me.Labelrecolteresult.Name = "Labelrecolteresult"
			Dim labelrecolteresult1 As System.Windows.Forms.Label = Me.Labelrecolteresult
			size = New System.Drawing.Size(39, 13)
			labelrecolteresult1.Size = size
			Me.Labelrecolteresult.TabIndex = 14
			Me.Labelrecolteresult.Text = "Label7"
			Me.ComboBox1semis.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox1semis.FormattingEnabled = True
			Dim comboBox1semis As System.Windows.Forms.ComboBox = Me.ComboBox1semis
			point = New System.Drawing.Point(416, 173)
			comboBox1semis.Location = point
			Me.ComboBox1semis.Name = "ComboBox1semis"
			Dim comboBox1semis1 As System.Windows.Forms.ComboBox = Me.ComboBox1semis
			size = New System.Drawing.Size(149, 21)
			comboBox1semis1.Size = size
			Me.ComboBox1semis.TabIndex = 10
			Me.lbl.AutoSize = True
			Dim label1 As System.Windows.Forms.Label = Me.lbl
			point = New System.Drawing.Point(387, 9)
			label1.Location = point
			Me.lbl.Name = "lbl"
			Dim label2 As System.Windows.Forms.Label = Me.lbl
			size = New System.Drawing.Size(0, 13)
			label2.Size = size
			Me.lbl.TabIndex = 0
			Me.lblsep.BackColor = Color.FromArgb(128, 64, 0)
			Dim label3 As System.Windows.Forms.Label = Me.lblsep
			point = New System.Drawing.Point(358, 81)
			label3.Location = point
			Me.lblsep.Name = "lblsep"
			Dim label4 As System.Windows.Forms.Label = Me.lblsep
			size = New System.Drawing.Size(5, 166)
			label4.Size = size
			Me.lblsep.TabIndex = 5
			Me.ComboBox2semis.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox2semis.FormattingEnabled = True
			Dim comboBox2semis As System.Windows.Forms.ComboBox = Me.ComboBox2semis
			point = New System.Drawing.Point(602, 173)
			comboBox2semis.Location = point
			Me.ComboBox2semis.Name = "ComboBox2semis"
			Dim comboBox2semis1 As System.Windows.Forms.ComboBox = Me.ComboBox2semis
			size = New System.Drawing.Size(149, 21)
			comboBox2semis1.Size = size
			Me.ComboBox2semis.TabIndex = 12
			Me.ComboBox1recolte.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox1recolte.FormattingEnabled = True
			Dim comboBox1recolte As System.Windows.Forms.ComboBox = Me.ComboBox1recolte
			point = New System.Drawing.Point(416, 214)
			comboBox1recolte.Location = point
			Me.ComboBox1recolte.Name = "ComboBox1recolte"
			Dim comboBox1recolte1 As System.Windows.Forms.ComboBox = Me.ComboBox1recolte
			size = New System.Drawing.Size(149, 21)
			comboBox1recolte1.Size = size
			Me.ComboBox1recolte.TabIndex = 16
			Me.ComboBox2recolte.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox2recolte.FormattingEnabled = True
			Dim comboBox2recolte As System.Windows.Forms.ComboBox = Me.ComboBox2recolte
			point = New System.Drawing.Point(602, 214)
			comboBox2recolte.Location = point
			Me.ComboBox2recolte.Name = "ComboBox2recolte"
			Dim comboBox2recolte1 As System.Windows.Forms.ComboBox = Me.ComboBox2recolte
			size = New System.Drawing.Size(149, 21)
			comboBox2recolte1.Size = size
			Me.ComboBox2recolte.TabIndex = 18
			Dim label5 As System.Windows.Forms.Label = Me.lblDe
			point = New System.Drawing.Point(384, 178)
			label5.Location = point
			Me.lblDe.Name = "lblDe"
			Dim label6 As System.Windows.Forms.Label = Me.lblDe
			size = New System.Drawing.Size(26, 16)
			label6.Size = size
			Me.lblDe.TabIndex = 9
			Me.lblDe.Text = "De"
			Dim label11 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(384, 219)
			label11.Location = point
			Me.Label1.Name = "Label1"
			Dim label12 As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(26, 16)
			label12.Size = size
			Me.Label1.TabIndex = 15
			Me.Label1.Text = "De"
			Dim label7 As System.Windows.Forms.Label = Me.lblA
			point = New System.Drawing.Point(578, 178)
			label7.Location = point
			Me.lblA.Name = "lblA"
			Dim label8 As System.Windows.Forms.Label = Me.lblA
			size = New System.Drawing.Size(16, 16)
			label8.Size = size
			Me.lblA.TabIndex = 11
			Me.lblA.Text = "à"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(578, 219)
			label21.Location = point
			Me.Label2.Name = "Label2"
			Dim label22 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(16, 16)
			label22.Size = size
			Me.Label2.TabIndex = 17
			Me.Label2.Text = "à"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Color.Purple
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(13, 124)
			label31.Location = point
			Me.Label3.Name = "Label3"
			Dim label32 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(57, 19)
			label32.Size = size
			Me.Label3.TabIndex = 20
			Me.Label3.Text = "TYPE :"
			Me.Labeltype.AutoSize = True
			Dim labeltype As System.Windows.Forms.Label = Me.Labeltype
			point = New System.Drawing.Point(148, 128)
			labeltype.Location = point
			Me.Labeltype.Name = "Labeltype"
			Dim labeltype1 As System.Windows.Forms.Label = Me.Labeltype
			size = New System.Drawing.Size(39, 13)
			labeltype1.Size = size
			Me.Labeltype.TabIndex = 21
			Me.Labeltype.Text = "Label5"
			Me.ComboBoxtype.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBoxtype.FormattingEnabled = True
			Dim comboBoxtype As System.Windows.Forms.ComboBox = Me.ComboBoxtype
			point = New System.Drawing.Point(416, 125)
			comboBoxtype.Location = point
			Me.ComboBoxtype.Name = "ComboBoxtype"
			Dim comboBoxtype1 As System.Windows.Forms.ComboBox = Me.ComboBoxtype
			size = New System.Drawing.Size(149, 21)
			comboBoxtype1.Size = size
			Me.ComboBoxtype.TabIndex = 22
			Me.PictureBox1.BorderStyle = BorderStyle.FixedSingle
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(693, 9)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(70, 70)
			pictureBox.Size = size
			Me.PictureBox1.TabIndex = 23
			Me.PictureBox1.TabStop = False
			Me.ComboBoxfam.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBoxfam.FormattingEnabled = True
			Dim comboBoxfam As System.Windows.Forms.ComboBox = Me.ComboBoxfam
			point = New System.Drawing.Point(416, 78)
			comboBoxfam.Location = point
			Me.ComboBoxfam.Name = "ComboBoxfam"
			Dim comboBoxfam1 As System.Windows.Forms.ComboBox = Me.ComboBoxfam
			size = New System.Drawing.Size(149, 21)
			comboBoxfam1.Size = size
			Me.ComboBoxfam.TabIndex = 24
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.CheckBox1.ForeColor = Color.Purple
			Dim checkBox1 As System.Windows.Forms.CheckBox = Me.CheckBox1
			point = New System.Drawing.Point(602, 128)
			checkBox1.Location = point
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox As System.Windows.Forms.CheckBox = Me.CheckBox1
			size = New System.Drawing.Size(75, 20)
			checkBox.Size = size
			Me.CheckBox1.TabIndex = 25
			Me.CheckBox1.Text = "Vivace"
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.AcceptButton = Me.Button1
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.OliveDrab
			size = New System.Drawing.Size(775, 326)
			Me.ClientSize = size
			Me.Controls.Add(Me.CheckBox1)
			Me.Controls.Add(Me.ComboBoxfam)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.ComboBoxtype)
			Me.Controls.Add(Me.Labeltype)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.lblA)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.lblDe)
			Me.Controls.Add(Me.ComboBox2recolte)
			Me.Controls.Add(Me.ComboBox1recolte)
			Me.Controls.Add(Me.ComboBox2semis)
			Me.Controls.Add(Me.lblsep)
			Me.Controls.Add(Me.lbl)
			Me.Controls.Add(Me.ComboBox1semis)
			Me.Controls.Add(Me.Labelrecolteresult)
			Me.Controls.Add(Me.Labelsemisresult)
			Me.Controls.Add(Me.Labelfamresult)
			Me.Controls.Add(Me.Labelrecolte)
			Me.Controls.Add(Me.Labelsemis)
			Me.Controls.Add(Me.Labelfam)
			Me.Controls.Add(Me.Labellegume)
			Me.Controls.Add(Me.ComboBoxlegume)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormBDDCal"
			Me.Text = "Base de données calendrier"
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Function moischiffre(ByVal x As String) As Integer
			Dim num As Integer = 0
			Dim num1 As Integer = 1
			Do
				If (Operators.CompareString(Me.convertcal(num1), x, False) = 0) Then
					num = num1 * 2 - 1
				End If
				If (Operators.CompareString(String.Concat("mi-", Me.convertcal(num1)), x, False) = 0) Then
					num = 2 * num1
				End If
				num1 = num1 + 1
			Loop While num1 <= 12
			Return num
		End Function

		Private Sub selectedindexchanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.Labellegume.Focus()
		End Sub

		Private Function vivace(ByVal str As String) As Object
			If (Operators.CompareString(str, "True", False) = 0) Then
				Return "(Vivace)"
			End If
			Return Nothing
		End Function
	End Class
End Namespace