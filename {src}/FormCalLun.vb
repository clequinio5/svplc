Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormCalLun
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("lblMois")>
		Private _lblMois As Label

		<AccessedThroughProperty("Panel")>
		Private _Panel As System.Windows.Forms.Panel

		<AccessedThroughProperty("GroupBox")>
		Private _GroupBox As System.Windows.Forms.GroupBox

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("lblTrajectoire")>
		Private _lblTrajectoire As Label

		<AccessedThroughProperty("Buttonsuiv")>
		Private _Buttonsuiv As Button

		<AccessedThroughProperty("Buttonprec")>
		Private _Buttonprec As Button

		<AccessedThroughProperty("legluneasc")>
		Private _legluneasc As System.Windows.Forms.PictureBox

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As System.Windows.Forms.PictureBox

		<AccessedThroughProperty("PictureBox")>
		Private _PictureBox As System.Windows.Forms.PictureBox

		<AccessedThroughProperty("lbllegtrajdesc")>
		Private _lbllegtrajdesc As Label

		<AccessedThroughProperty("lblLegtrajectoire")>
		Private _lblLegtrajectoire As Label

		<AccessedThroughProperty("lblLegtrajasc")>
		Private _lblLegtrajasc As Label

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As System.Windows.Forms.PictureBox

		<AccessedThroughProperty("BackgroundWorker1")>
		Private _BackgroundWorker1 As BackgroundWorker

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("btnDefinition")>
		Private _btnDefinition As Button

		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As System.Windows.Forms.PictureBox

		<AccessedThroughProperty("PictureBoxtelescope")>
		Private _PictureBoxtelescope As System.Windows.Forms.PictureBox

		Private Definition As FormExplicationCalendrierLunaire

		Private compt As Integer

		Private numnouvellelune As Integer

		Private Hlbl As Integer

		Private Llbl1 As Integer

		Private Llbl2 As Integer

		Private Llbl3 As Integer

		Private Mhaut As Integer

		Private DECLINAISONS As Integer()

		Private selection As DateTime

		Private Arg As DateTime()

		Private referencephase As DateTime

		Private referenceapogee As DateTime

		Private referenceperigee As DateTime

		Private Apg As DateTime()

		Private Prg As DateTime()

		Private PL As DateTime()

		Private NL As DateTime()

		Private NEasc As DateTime()

		Private NEdesc As DateTime()

		Private DENO As DateTime()

		Private DESU As DateTime()

		Private Alldate As DateTime()

		Private Resultats As DateTime()

		Private jour As Label(,)

		Private euphemerides As Label(,)

		Private phase As System.Windows.Forms.PictureBox(,)

		Private imagephase As Image()

		Private firstdecno As Boolean

		Private empty0 As Boolean

		Private empty1 As Boolean

		Private empty2 As Boolean

		Private empty3 As Boolean

		Private empty4 As Boolean

		Private empty5 As Boolean

		Private mois As Double

		Private annee As Double

		Private start As Double

		Private Aphase As Double(,)

		Private S1 As Double

		Private S2 As Double

		Private Correction As Double(,)

		Private Facteur As Double()

		Private Kde As Double

		Private Tde As Double

		Private Adeno As Double()

		Private Adesu As Double()

		Private Mdeno As Double

		Private Mdesu As Double

		Private Mprimedeno As Double

		Private Mprimedesu As Double

		Private Ddeno As Double

		Private Ddesu As Double

		Private Fdeno As Double

		Private Fdesu As Double

		Private JDEdeno As Double

		Private JDEdesu As Double

		Private Kphase As Double

		Private Tphase As Double

		Private Eprime As Double

		Private Mphase As Double

		Private Mprime As Double

		Private D As Double

		Private Fphase As Double

		Private Omega As Double

		Private JDEphase As Double

		Private MJDmois As Double()

		Private JDEapprg As Double

		Private Aprg As Double()

		Private Aap As Double()

		Private Kapprg As Double

		Private Mapprg As Double

		Private Fapprg As Double

		Private Tapprg As Double

		Private degrad As Double

		Private Ane As Double()

		Private Kne As Double

		Private Mne As Double

		Private Mprimene As Double

		Private V As Double

		Private P As Double

		Private Tne As Double

		Private Dne As Double

		Private Ohmegane As Double

		Private JDEne As Double

		Private semaine As String()

		Private Overridable Property BackgroundWorker1 As BackgroundWorker
			Get
				Return Me._BackgroundWorker1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim formCalLun As SVPLCApplication.FormCalLun = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf formCalLun.BackgroundWorker1_DoWork)
				Dim formCalLun1 As SVPLCApplication.FormCalLun = Me
				Dim runWorkerCompletedEventHandler As System.ComponentModel.RunWorkerCompletedEventHandler = New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf formCalLun1.BackgroundWorker1_RunWorkerCompleted)
				If (Me._BackgroundWorker1 IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorker1.DoWork,  doWorkEventHandler
					RemoveHandler Me._BackgroundWorker1.RunWorkerCompleted,  runWorkerCompletedEventHandler
				End If
				Me._BackgroundWorker1 = value
				If (Me._BackgroundWorker1 IsNot Nothing) Then
					AddHandler Me._BackgroundWorker1.DoWork,  doWorkEventHandler
					AddHandler Me._BackgroundWorker1.RunWorkerCompleted,  runWorkerCompletedEventHandler
				End If
			End Set
		End Property

		Private Overridable Property btnDefinition As Button
			Get
				Return Me._btnDefinition
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formCalLun As SVPLCApplication.FormCalLun = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formCalLun.btnDefinition_Click)
				If (Me._btnDefinition IsNot Nothing) Then
					RemoveHandler Me._btnDefinition.Click,  eventHandler
				End If
				Me._btnDefinition = value
				If (Me._btnDefinition IsNot Nothing) Then
					AddHandler Me._btnDefinition.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property Buttonprec As Button
			Get
				Return Me._Buttonprec
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formCalLun As SVPLCApplication.FormCalLun = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formCalLun.btnPrec_Click)
				If (Me._Buttonprec IsNot Nothing) Then
					RemoveHandler Me._Buttonprec.Click,  eventHandler
				End If
				Me._Buttonprec = value
				If (Me._Buttonprec IsNot Nothing) Then
					AddHandler Me._Buttonprec.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property Buttonsuiv As Button
			Get
				Return Me._Buttonsuiv
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formCalLun As SVPLCApplication.FormCalLun = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formCalLun.Button1_Click)
				If (Me._Buttonsuiv IsNot Nothing) Then
					RemoveHandler Me._Buttonsuiv.Click,  eventHandler
				End If
				Me._Buttonsuiv = value
				If (Me._Buttonsuiv IsNot Nothing) Then
					AddHandler Me._Buttonsuiv.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property GroupBox As System.Windows.Forms.GroupBox
			Get
				Return Me._GroupBox
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.GroupBox)
				Me._GroupBox = value
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

		Friend Overridable Property Label4 As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label4 = value
			End Set
		End Property

		Friend Overridable Property Label5 As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label5 = value
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

		Friend Overridable Property lblLegtrajasc As Label
			Get
				Return Me._lblLegtrajasc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblLegtrajasc = value
			End Set
		End Property

		Friend Overridable Property lbllegtrajdesc As Label
			Get
				Return Me._lbllegtrajdesc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lbllegtrajdesc = value
			End Set
		End Property

		Friend Overridable Property lblLegtrajectoire As Label
			Get
				Return Me._lblLegtrajectoire
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblLegtrajectoire = value
			End Set
		End Property

		Friend Overridable Property lblMois As Label
			Get
				Return Me._lblMois
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblMois = value
			End Set
		End Property

		Private Overridable Property lblTrajectoire As Label
			Get
				Return Me._lblTrajectoire
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblTrajectoire = value
			End Set
		End Property

		Private Overridable Property legluneasc As System.Windows.Forms.PictureBox
			Get
				Return Me._legluneasc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._legluneasc = value
			End Set
		End Property

		Private Overridable Property Panel As System.Windows.Forms.Panel
			Get
				Return Me._Panel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Panel = value
			End Set
		End Property

		Friend Overridable Property PictureBox As System.Windows.Forms.PictureBox
			Get
				Return Me._PictureBox
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._PictureBox = value
			End Set
		End Property

		Private Overridable Property PictureBox1 As System.Windows.Forms.PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		Friend Overridable Property PictureBox2 As System.Windows.Forms.PictureBox
			Get
				Return Me._PictureBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		Private Overridable Property PictureBox3 As System.Windows.Forms.PictureBox
			Get
				Return Me._PictureBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		Friend Overridable Property PictureBoxtelescope As System.Windows.Forms.PictureBox
			Get
				Return Me._PictureBoxtelescope
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._PictureBoxtelescope = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formCalLun1 As FormCalLun = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formCalLun1.Form11_Load)
			Dim formCalLun2 As FormCalLun = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formCalLun2.Form11_FormClosed)
			Me.InitializeComponent()
		End Sub

		Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			ReDim Me.MJDmois(17)
			Me.degrad = 0.0174532925199433
			Me.Kphase = Conversion.Int((CDbl(Me.Arg(0).Year) + CDbl(Me.Arg(0).Month) / 12 - 2000) * 12.3685)
			Me.Tphase = Me.Kphase / 1236.85
			Me.Mphase = (2.5534 + 29.10535669 * Me.Kphase - 2.18E-05 * Math.Pow(Me.Tphase, 2) - 1.1E-07 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Mprime = (201.5643 + 385.81693528 * Me.Kphase + 0.0107438 * Math.Pow(Me.Tphase, 2) + 1.239E-05 * Math.Pow(Me.Tphase, 3) - 5.8E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Fphase = (160.7108 + 390.67050274 * Me.Kphase - 0.0016341 * Math.Pow(Me.Tphase, 2) - 2.27E-06 * Math.Pow(Me.Tphase, 3) + 1.1E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Omega = (124.7746 - 1.5637558 * Me.Kphase + 0.0020691 * Math.Pow(Me.Tphase, 2) + 2.15E-06 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tphase - 7.4E-06 * Math.Pow(Me.Tphase, 2)
			Me.JDEphase = 2451550.09765 + 29.530588853 * Me.Kphase + 0.0001337 * Math.Pow(Me.Tphase, 2) - 1.5E-07 * Math.Pow(Me.Tphase, 3) + 7.3E-10 * Math.Pow(Me.Tphase, 4)
			ReDim Me.Aphase(1, 14)
			Me.Aphase(0, 1) = 299.77 + 0.107408 * Me.Kphase - 0.009173 * Math.Pow(Me.Tphase, 2)
			Me.Aphase(0, 2) = 251.88 + 0.016321 * Me.Kphase
			Me.Aphase(0, 3) = 251.83 + 26.651886 * Me.Kphase
			Me.Aphase(0, 4) = 349.42 + 36.412478 * Me.Kphase
			Me.Aphase(0, 5) = 84.66 + 18.206239 * Me.Kphase
			Me.Aphase(0, 6) = 141.74 + 53.303771 * Me.Kphase
			Me.Aphase(0, 7) = 207.14 + 2.453732 * Me.Kphase
			Me.Aphase(0, 8) = 154.84 + 7.30686 * Me.Kphase
			Me.Aphase(0, 9) = 34.52 + 27.261239 * Me.Kphase
			Me.Aphase(0, 10) = 207.19 + 0.121824 * Me.Kphase
			Me.Aphase(0, 11) = 291.34 + 1.844379 * Me.Kphase
			Me.Aphase(0, 12) = 161.72 + 24.198154 * Me.Kphase
			Me.Aphase(0, 13) = 239.56 + 25.513099 * Me.Kphase
			Me.Aphase(0, 14) = 331.55 + 3.592518 * Me.Kphase
			Me.Aphase(1, 1) = 0.000325 * Math.Sin(Me.Aphase(0, 1) * Me.degrad)
			Me.Aphase(1, 2) = 0.000165 * Math.Sin(Me.Aphase(0, 2) * Me.degrad)
			Me.Aphase(1, 3) = 0.000164 * Math.Sin(Me.Aphase(0, 3) * Me.degrad)
			Me.Aphase(1, 4) = 0.000126 * Math.Sin(Me.Aphase(0, 4) * Me.degrad)
			Me.Aphase(1, 5) = 0.00011 * Math.Sin(Me.Aphase(0, 5) * Me.degrad)
			Me.Aphase(1, 6) = 6.2E-05 * Math.Sin(Me.Aphase(0, 6) * Me.degrad)
			Me.Aphase(1, 7) = 6E-05 * Math.Sin(Me.Aphase(0, 7) * Me.degrad)
			Me.Aphase(1, 8) = 5.6E-05 * Math.Sin(Me.Aphase(0, 8) * Me.degrad)
			Me.Aphase(1, 9) = 4.7E-05 * Math.Sin(Me.Aphase(0, 9) * Me.degrad)
			Me.Aphase(1, 10) = 4.2E-05 * Math.Sin(Me.Aphase(0, 10) * Me.degrad)
			Me.Aphase(1, 11) = 4E-05 * Math.Sin(Me.Aphase(0, 11) * Me.degrad)
			Me.Aphase(1, 12) = 3.7E-05 * Math.Sin(Me.Aphase(0, 12) * Me.degrad)
			Me.Aphase(1, 13) = 3.5E-05 * Math.Sin(Me.Aphase(0, 13) * Me.degrad)
			Me.Aphase(1, 14) = 2.3E-05 * Math.Sin(Me.Aphase(0, 14) * Me.degrad)
			Me.Facteur = New Double() { Nothing, Math.Sin(Me.Mprime * Me.degrad), Me.Eprime * Math.Sin(Me.Mphase * Me.degrad), Math.Sin(2 * Me.Mprime * Me.degrad), Math.Sin(2 * Me.Fphase * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime - Me.Mphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime + Me.Mphase) * Me.degrad), Math.Pow(Me.Eprime, 2) * Math.Sin(2 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(3 * Me.Mprime * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase - 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime - Me.Mphase) * Me.degrad), Math.Sin(Me.Omega * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Mphase) * Me.degrad), Math.Sin((2 * Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin(3 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((2 * Me.Mprime + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((3 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(4 * Me.Mprime * Me.degrad) }
			ReDim Me.Correction(1, 25)
			Me.Correction(0, 1) = -0.4072 * Me.Facteur(1)
			Me.Correction(0, 2) = 0.17241 * Me.Facteur(2)
			Me.Correction(0, 3) = 0.01608 * Me.Facteur(3)
			Me.Correction(0, 4) = 0.01039 * Me.Facteur(4)
			Me.Correction(0, 5) = 0.00739 * Me.Facteur(5)
			Me.Correction(0, 6) = -0.00514 * Me.Facteur(6)
			Me.Correction(0, 7) = 0.00208 * Me.Facteur(7)
			Me.Correction(0, 8) = -0.00111 * Me.Facteur(8)
			Me.Correction(0, 9) = -0.00057 * Me.Facteur(9)
			Me.Correction(0, 10) = 0.00056 * Me.Facteur(10)
			Me.Correction(0, 11) = -0.00042 * Me.Facteur(11)
			Me.Correction(0, 12) = 0.00042 * Me.Facteur(12)
			Me.Correction(0, 13) = 0.00038 * Me.Facteur(13)
			Me.Correction(0, 14) = -0.00024 * Me.Facteur(14)
			Me.Correction(0, 15) = -0.00017 * Me.Facteur(15)
			Me.Correction(0, 16) = -7E-05 * Me.Facteur(16)
			Me.Correction(0, 17) = 4E-05 * Me.Facteur(17)
			Me.Correction(0, 18) = 4E-05 * Me.Facteur(18)
			Me.Correction(0, 19) = 3E-05 * Me.Facteur(19)
			Me.Correction(0, 20) = 3E-05 * Me.Facteur(20)
			Me.Correction(0, 21) = -3E-05 * Me.Facteur(21)
			Me.Correction(0, 22) = 3E-05 * Me.Facteur(22)
			Me.Correction(0, 23) = -2E-05 * Me.Facteur(23)
			Me.Correction(0, 24) = -2E-05 * Me.Facteur(24)
			Me.Correction(0, 25) = 2E-05 * Me.Facteur(25)
			Me.S1 = 0
			Dim num As Integer = 1
			Do
				Me.S1 += Me.Aphase(1, num)
				num = num + 1
			Loop While num <= 14
			Me.S2 = 0
			Dim num1 As Integer = 1
			Do
				Me.S2 += Me.Correction(0, num1)
				num1 = num1 + 1
			Loop While num1 <= 25
			Me.MJDmois(0) = Me.JDEphase + Me.S1 + Me.S2 - 2400000.5
			Me.Kphase += 0.5
			Me.Tphase = Me.Kphase / 1236.85
			Me.Mphase = (2.5534 + 29.1053567 * Me.Kphase - 1.4E-06 * Math.Pow(Me.Tphase, 2) - 1.1E-07 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Mprime = (201.5643 + 385.81693528 * Me.Kphase + 0.0107438 * Math.Pow(Me.Tphase, 2) + 1.239E-05 * Math.Pow(Me.Tphase, 3) - 5.8E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Fphase = (160.7108 + 390.67050274 * Me.Kphase - 0.0016341 * Math.Pow(Me.Tphase, 2) - 2.27E-06 * Math.Pow(Me.Tphase, 3) + 1.1E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Omega = (124.7746 - 1.5637558 * Me.Kphase + 0.0020691 * Math.Pow(Me.Tphase, 2) + 2.15E-06 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tphase - 7.4E-06 * Math.Pow(Me.Tphase, 2)
			Me.JDEphase = 2451550.09766 + 29.530588853 * Me.Kphase + 0.00015437 * Math.Pow(Me.Tphase, 2) - 1.5E-07 * Math.Pow(Me.Tphase, 3) + 7.3E-10 * Math.Pow(Me.Tphase, 4)
			ReDim Me.Aphase(1, 14)
			Me.Aphase(0, 1) = 299.77 + 0.107408 * Me.Kphase - 0.009173 * Math.Pow(Me.Tphase, 2)
			Me.Aphase(0, 2) = 251.88 + 0.016321 * Me.Kphase
			Me.Aphase(0, 3) = 251.83 + 26.651886 * Me.Kphase
			Me.Aphase(0, 4) = 349.42 + 36.412478 * Me.Kphase
			Me.Aphase(0, 5) = 84.66 + 18.206239 * Me.Kphase
			Me.Aphase(0, 6) = 141.74 + 53.303771 * Me.Kphase
			Me.Aphase(0, 7) = 207.14 + 2.453732 * Me.Kphase
			Me.Aphase(0, 8) = 154.84 + 7.30686 * Me.Kphase
			Me.Aphase(0, 9) = 34.52 + 27.261239 * Me.Kphase
			Me.Aphase(0, 10) = 207.19 + 0.121824 * Me.Kphase
			Me.Aphase(0, 11) = 291.34 + 1.844379 * Me.Kphase
			Me.Aphase(0, 12) = 161.72 + 24.198154 * Me.Kphase
			Me.Aphase(0, 13) = 239.56 + 25.513099 * Me.Kphase
			Me.Aphase(0, 14) = 331.55 + 3.592518 * Me.Kphase
			Me.Aphase(1, 1) = 0.000325 * Math.Sin(Me.Aphase(0, 1) * Me.degrad)
			Me.Aphase(1, 2) = 0.000165 * Math.Sin(Me.Aphase(0, 2) * Me.degrad)
			Me.Aphase(1, 3) = 0.000164 * Math.Sin(Me.Aphase(0, 3) * Me.degrad)
			Me.Aphase(1, 4) = 0.000126 * Math.Sin(Me.Aphase(0, 4) * Me.degrad)
			Me.Aphase(1, 5) = 0.00011 * Math.Sin(Me.Aphase(0, 5) * Me.degrad)
			Me.Aphase(1, 6) = 6.2E-05 * Math.Sin(Me.Aphase(0, 6) * Me.degrad)
			Me.Aphase(1, 7) = 6E-05 * Math.Sin(Me.Aphase(0, 7) * Me.degrad)
			Me.Aphase(1, 8) = 5.6E-05 * Math.Sin(Me.Aphase(0, 8) * Me.degrad)
			Me.Aphase(1, 9) = 4.7E-05 * Math.Sin(Me.Aphase(0, 9) * Me.degrad)
			Me.Aphase(1, 10) = 4.2E-05 * Math.Sin(Me.Aphase(0, 10) * Me.degrad)
			Me.Aphase(1, 11) = 4E-05 * Math.Sin(Me.Aphase(0, 11) * Me.degrad)
			Me.Aphase(1, 12) = 3.7E-05 * Math.Sin(Me.Aphase(0, 12) * Me.degrad)
			Me.Aphase(1, 13) = 3.5E-05 * Math.Sin(Me.Aphase(0, 13) * Me.degrad)
			Me.Aphase(1, 14) = 2.3E-05 * Math.Sin(Me.Aphase(0, 14) * Me.degrad)
			Me.Facteur = New Double() { Nothing, Math.Sin(Me.Mprime * Me.degrad), Me.Eprime * Math.Sin(Me.Mphase * Me.degrad), Math.Sin(2 * Me.Mprime * Me.degrad), Math.Sin(2 * Me.Fphase * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime - Me.Mphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime + Me.Mphase) * Me.degrad), Math.Pow(Me.Eprime, 2) * Math.Sin(2 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(3 * Me.Mprime * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase - 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime - Me.Mphase) * Me.degrad), Math.Sin(Me.Omega * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Mphase) * Me.degrad), Math.Sin((2 * Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin(3 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((2 * Me.Mprime + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((3 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(4 * Me.Mprime * Me.degrad) }
			Me.Correction(1, 1) = -0.40614 * Me.Facteur(1)
			Me.Correction(1, 2) = 0.17302 * Me.Facteur(2)
			Me.Correction(1, 3) = 0.01614 * Me.Facteur(3)
			Me.Correction(1, 4) = 0.01043 * Me.Facteur(4)
			Me.Correction(1, 5) = 0.00734 * Me.Facteur(5)
			Me.Correction(1, 6) = -0.00515 * Me.Facteur(6)
			Me.Correction(1, 7) = 0.00209 * Me.Facteur(7)
			Me.Correction(1, 8) = 0.00111 * Me.Facteur(8)
			Me.Correction(1, 9) = -0.00057 * Me.Facteur(9)
			Me.Correction(1, 10) = 0.00056 * Me.Facteur(10)
			Me.Correction(1, 11) = -0.00042 * Me.Facteur(11)
			Me.Correction(1, 12) = 0.00042 * Me.Facteur(12)
			Me.Correction(1, 13) = 0.00038 * Me.Facteur(13)
			Me.Correction(1, 14) = -0.00024 * Me.Facteur(14)
			Me.Correction(1, 15) = -0.00017 * Me.Facteur(15)
			Me.Correction(1, 16) = -7E-05 * Me.Facteur(16)
			Me.Correction(1, 17) = 4E-05 * Me.Facteur(17)
			Me.Correction(1, 18) = 4E-05 * Me.Facteur(18)
			Me.Correction(1, 19) = 3E-05 * Me.Facteur(19)
			Me.Correction(1, 20) = 3E-05 * Me.Facteur(20)
			Me.Correction(1, 21) = -3E-05 * Me.Facteur(21)
			Me.Correction(1, 22) = 3E-05 * Me.Facteur(22)
			Me.Correction(1, 23) = -2E-05 * Me.Facteur(23)
			Me.Correction(1, 24) = -2E-05 * Me.Facteur(24)
			Me.Correction(1, 25) = 2E-05 * Me.Facteur(25)
			Me.S1 = 0
			Dim num2 As Integer = 1
			Do
				Me.S1 += Me.Aphase(1, num2)
				num2 = num2 + 1
			Loop While num2 <= 14
			Me.S2 = 0
			Dim num3 As Integer = 1
			Do
				Me.S2 += Me.Correction(1, num3)
				num3 = num3 + 1
			Loop While num3 <= 25
			Me.MJDmois(1) = Me.JDEphase + Me.S1 + Me.S2 - 2400000.5
			Me.Correction = Nothing
			Me.Facteur = Nothing
			Me.Aphase = Nothing
			Me.Kapprg = Conversion.Int((CDbl(Me.Arg(0).Year) + CDbl(Me.Arg(0).Month) / 12 - 1999.97) * 13.2555)
			Me.Tapprg = Me.Kapprg / 1325.55
			Me.D = (171.9179 + 335.9106046 * Me.Kapprg - 0.010025 * Math.Pow(Me.Tapprg, 2) - 1.156E-05 * Math.Pow(Me.Tapprg, 3) + 5.5E-08 * Math.Pow(Me.Tapprg, 4)) Mod 360
			Me.Mapprg = (347.3477 + 27.1577721 * Me.Kapprg - 0.0008323 * Math.Pow(Me.Tapprg, 2) - 1E-06 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.Fapprg = (316.6109 + 364.5287911 * Me.Kapprg - 0.0125131 * Math.Pow(Me.Tapprg, 2) - 1.48E-05 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.JDEapprg = 2451534.6698 + 27.55454988 * Me.Kapprg - 0.0006886 * Math.Pow(Me.Tapprg, 2) - 1.098E-06 * Math.Pow(Me.Tapprg, 3) + 5.2E-09 * Math.Pow(Me.Tapprg, 4)
			Me.Aprg = New Double() { Nothing, -1.6769 * Math.Sin(2 * Me.D * Me.degrad), 0.4589 * Math.Sin(4 * Me.D * Me.degrad), -0.1856 * Math.Sin(6 * Me.D * Me.degrad), 0.0883 * Math.Sin(8 * Me.D * Me.degrad), (-0.0773 + 0.00019 * Me.Tapprg) * Math.Sin((2 * Me.D - Me.Mapprg) * Me.degrad), (0.0502 - 0.00013 * Me.Tapprg) * Math.Sin(Me.Mapprg * Me.degrad), -0.046 * Math.Sin(10 * Me.D * Me.degrad), (0.0422 - 0.00011 * Me.Tapprg) * Math.Sin((4 * Me.D - Me.Mapprg) * Me.degrad), -0.0256 * Math.Sin((6 * Me.D - Me.Mapprg) * Me.degrad), 0.0253 * Math.Sin(12 * Me.D * Me.degrad), 0.0237 * Math.Sin(Me.D * Me.degrad), 0.0162 * Math.Sin((8 * Me.D - Me.Mapprg) * Me.degrad), -0.0145 * Math.Sin(14 * Me.D * Me.degrad), 0.0129 * Math.Sin(2 * Me.Fapprg * Me.degrad), -0.0112 * Math.Sin(3 * Me.D * Me.degrad), -0.0104 * Math.Sin((10 * Me.D - Me.Mapprg) * Me.degrad), 0.0086 * Math.Sin(16 * Me.D * Me.degrad), 0.0069 * Math.Sin((12 * Me.D - Me.Mapprg) * Me.degrad), 0.0066 * Math.Sin(5 * Me.D * Me.degrad), -0.0053 * Math.Sin((2 * Me.D + 2 * Me.Fapprg) * Me.degrad), -0.0052 * Math.Sin(18 * Me.D * Me.degrad), -0.0046 * Math.Sin((14 * Me.D - Me.Mapprg) * Me.degrad), -0.0041 * Math.Sin(7 * Me.D * Me.degrad), 0.004 * Math.Sin((2 * Me.D + Me.Mapprg) * Me.degrad), 0.0032 * Math.Sin(20 * Me.D * Me.degrad), -0.0032 * Math.Sin((Me.D + Me.Mapprg) * Me.degrad), 0.0031 * Math.Sin((16 * Me.D - Me.Mapprg) * Me.degrad), -0.0029 * Math.Sin((4 * Me.D + Me.Mapprg) * Me.degrad), 0.0027 * Math.Sin(9 * Me.D * Me.degrad), 0.0027 * Math.Sin((4 * Me.D + 2 * Me.Fapprg) * Me.degrad), -0.0027 * Math.Sin((2 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0024 * Math.Sin((4 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0021 * Math.Sin((6 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0021 * Math.Sin(22 * Me.D * Me.degrad), -0.0021 * Math.Sin((18 * Me.D - Me.Mapprg) * Me.degrad), 0.0019 * Math.Sin((6 * Me.D + Me.Mapprg) * Me.degrad), 0.0018 * Math.Sin(11 * Me.D * Me.degrad), -0.0014 * Math.Sin((8 * Me.D + Me.Mapprg) * Me.degrad), -0.0014 * Math.Sin((4 * Me.D - 2 * Me.Fapprg) * Me.degrad), -0.0014 * Math.Sin((6 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0014 * Math.Sin((3 * Me.D + Me.Mapprg) * Me.degrad), -0.0014 * Math.Sin((5 * Me.D + Me.Mapprg) * Me.degrad), 0.0013 * Math.Sin(13 * Me.D * Me.degrad), 0.0013 * Math.Sin((20 * Me.D - Me.Mapprg) * Me.degrad), 0.0011 * Math.Sin((3 * Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0011 * Math.Sin((4 * Me.D + 2 * Me.Fapprg - 2 * Me.Mapprg) * Me.degrad), 0.001 * Math.Sin((Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0009 * Math.Sin((22 * Me.D - Me.Mapprg) * Me.degrad), -0.0008 * Math.Sin(4 * Me.Fapprg * Me.degrad), 0.0008 * Math.Sin((6 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0008 * Math.Sin((2 * Me.D - 2 * Me.Fapprg + Me.Mapprg) * Me.degrad), 0.0007 * Math.Sin(2 * Me.Mapprg * Me.degrad), 0.0007 * Math.Sin((2 * Me.Fapprg - Me.Mapprg) * Me.degrad), 0.0007 * Math.Sin((2 * Me.D + 4 * Me.Fapprg) * Me.degrad), -0.0006 * Math.Sin((2 * Me.Fapprg - 2 * Me.Mapprg) * Me.degrad), -0.0006 * Math.Sin((2 * Me.D - 2 * Me.Fapprg + 2 * Me.Mapprg) * Me.degrad), 0.0006 * Math.Sin(24 * Me.D * Me.degrad), 0.0005 * Math.Sin((4 * Me.D - 4 * Me.Fapprg) * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0004 * Math.Sin((Me.D - Me.Mapprg) * Me.degrad) }
			Me.S1 = 0
			Dim num4 As Integer = 1
			Do
				Me.S1 += Me.Aprg(num4)
				num4 = num4 + 1
			Loop While num4 <= 60
			Me.MJDmois(2) = Me.JDEapprg + Me.S1 - 2400000.5
			Me.Aprg = Nothing
			Me.Kapprg += 0.5
			Me.Tapprg = Me.Kapprg / 1325.55
			Me.D = (171.9179 + 335.9106046 * Me.Kapprg - 0.010025 * Math.Pow(Me.Tapprg, 2) - 1.156E-05 * Math.Pow(Me.Tapprg, 3) + 5.5E-08 * Math.Pow(Me.Tapprg, 4)) Mod 360
			Me.Mapprg = (347.3477 + 27.1577721 * Me.Kapprg - 0.0008323 * Math.Pow(Me.Tapprg, 2) - 1E-06 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.Fapprg = (316.6109 + 364.5287911 * Me.Kapprg - 0.0125131 * Math.Pow(Me.Tapprg, 2) - 1.48E-05 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.JDEapprg = 2451534.6698 + 27.55454988 * Me.Kapprg - 0.0006886 * Math.Pow(Me.Tapprg, 2) - 1.098E-06 * Math.Pow(Me.Tapprg, 3) + 5.2E-09 * Math.Pow(Me.Tapprg, 4)
			Me.Aap = New Double() { Nothing, 0.4392 * Math.Sin(2 * Me.D * Me.degrad), 0.0684 * Math.Sin(4 * Me.D * Me.degrad), (0.0456 - 0.00011 * Me.Tapprg) * Math.Sin(Me.Mapprg * Me.degrad), (0.0426 - 0.00011 * Me.Tapprg) * Math.Sin((2 * Me.D - Me.Mapprg) * Me.degrad), 0.0212 * Math.Sin(2 * Me.Fapprg * Me.degrad), -0.0189 * Math.Sin(Me.D * Me.degrad), 0.0144 * Math.Sin(6 * Me.D * Me.degrad), 0.0113 * Math.Sin((4 * Me.D - Me.Mapprg) * Me.degrad), 0.0047 * Math.Sin((2 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0036 * Math.Sin((Me.D + Me.Mapprg) * Me.degrad), 0.0035 * Math.Sin(8 * Me.D * Me.degrad), 0.0034 * Math.Sin((6 * Me.D - Me.Mapprg) * Me.degrad), -0.0034 * Math.Sin((2 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0022 * Math.Sin((2 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0017 * Math.Sin(3 * Me.D * Me.degrad), 0.0013 * Math.Sin((4 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0011 * Math.Sin((8 * Me.D - Me.Mapprg) * Me.degrad), 0.001 * Math.Sin((4 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0009 * Math.Sin(10 * Me.D * Me.degrad), 0.0007 * Math.Sin((3 * Me.D + Me.Mapprg) * Me.degrad), 0.0006 * Math.Sin(2 * Me.Mapprg * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + Me.Mapprg) * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + 2 * Me.Mapprg) * Me.degrad), 0.0004 * Math.Sin((6 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0004 * Math.Sin((6 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0004 * Math.Sin((10 * Me.D - Me.Mapprg) * Me.degrad), -0.0004 * Math.Sin(5 * Me.D * Me.degrad), -0.0004 * Math.Sin((4 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0003 * Math.Sin((2 * Me.Fapprg + Me.Mapprg) * Me.degrad), 0.0003 * Math.Sin(12 * Me.D * Me.degrad), 0.0003 * Math.Sin((2 * Me.D + 2 * Me.Fapprg - Me.Mapprg) * Me.degrad), -0.0003 * Math.Sin((Me.D - Me.Mapprg) * Me.degrad) }
			Me.S1 = 0
			Dim num5 As Integer = 1
			Do
				Me.S1 += Me.Aap(num5)
				num5 = num5 + 1
			Loop While num5 <= 32
			Me.MJDmois(3) = Me.JDEapprg + Me.S1 - 2400000.5
			Me.Aap = Nothing
			Me.Kne = Conversion.Int((CDbl(Me.Arg(0).Year) + CDbl(Me.Arg(0).Month) / 12 - 2000.05) * 13.4223)
			Me.Tne = Me.Kne / 1342.23
			Me.Dne = (183.638 + 331.73735691 * Me.Kne + 0.0015057 * Math.Pow(Me.Tne, 2) + 2.09E-06 * Math.Pow(Me.Tne, 3) - 1E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Mne = (17.4006 + 26.8203725 * Me.Kne + 9.99E-05 * Math.Pow(Me.Tne, 2) + 6E-08 * Math.Pow(Me.Tne, 3)) Mod 360
			Me.Mprimene = (38.3776 + 355.52747322 * Me.Kne + 0.0123577 * Math.Pow(Me.Tne, 2) + 1.4628E-05 * Math.Pow(Me.Tne, 3) - 6.9E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Ohmegane = (123.9767 - 1.44098949 * Me.Kne + 0.0020625 * Math.Pow(Me.Tne, 2) + 2.14E-06 * Math.Pow(Me.Tne, 3) - 1.6E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.V = (299.75 + 132.85 * Me.Tne - 0.009173 * Math.Pow(Me.Tne, 2)) Mod 360
			Me.P = (Me.Ohmegane + 272.75 - 2.3 * Me.Tne) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tne - 7.4E-06 * Math.Pow(Me.Tne, 2)
			Me.JDEne = 2451565.1619 + 27.212220817 * Me.Kne + 0.0002572 * Math.Pow(Me.Tne, 2) + 2.1E-08 * Math.Pow(Me.Tne, 3) - 8.8E-11 * Math.Pow(Me.Tne, 4)
			Me.Ane = New Double() { Nothing, -0.4721 * Math.Sin(Me.Mprimene * Me.degrad), -0.1649 * Math.Sin(2 * Me.Dne * Me.degrad), -0.0868 * Math.Sin((2 * Me.Dne - Me.Mprimene) * Me.degrad), 0.0084 * Math.Sin((2 * Me.Dne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0083 * Math.Sin((2 * Me.Dne - Me.Mne) * Me.degrad), Me.Eprime * -0.0039 * Math.Sin((2 * Me.Dne - Me.Mne - Me.Mprimene) * Me.degrad), 0.0034 * Math.Sin(2 * Me.Mprimene * Me.degrad), -0.0031 * Math.Sin((2 * Me.Dne - 2 * Me.Mprimene) * Me.degrad), Me.Eprime * 0.003 * Math.Sin((2 * Me.Dne + Me.Mne) * Me.degrad), Me.Eprime * 0.0028 * Math.Sin((Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0026 * Math.Sin(Me.Mne * Me.degrad), 0.0025 * Math.Sin(4 * Me.Dne * Me.degrad), 0.0024 * Math.Sin(Me.Dne * Me.degrad), Me.Eprime * 0.0022 * Math.Sin((Me.Mne + Me.Mprimene) * Me.degrad), 0.0017 * Math.Sin(Me.Ohmegane * Me.degrad), 0.0014 * Math.Sin((4 * Me.Dne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0005 * Math.Sin((2 * Me.Dne + Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0004 * Math.Sin((2 * Me.Dne - Me.Mne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0003 * Math.Sin((2 * Me.Dne - 2 * Me.Mne) * Me.degrad), Me.Eprime * 0.0003 * Math.Sin((4 * Me.Dne - Me.Mne) * Me.degrad), 0.0003 * Math.Sin(Me.V * Me.degrad), 0.0003 * Math.Sin(Me.P * Me.degrad) }
			Me.S1 = 0
			Dim num6 As Integer = 1
			Do
				Me.S1 += Me.Ane(num6)
				num6 = num6 + 1
			Loop While num6 <= 22
			Me.MJDmois(4) = Me.JDEne + Me.S1 - 2400000.5
			Me.Kne += 0.5
			Me.Tne = Me.Kne / 1342.23
			Me.Dne = (183.638 + 331.73735691 * Me.Kne + 0.0015057 * Math.Pow(Me.Tne, 2) + 2.09E-06 * Math.Pow(Me.Tne, 3) - 1E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Mne = (17.4006 + 26.8203725 * Me.Kne + 9.99E-05 * Math.Pow(Me.Tne, 2) + 6E-08 * Math.Pow(Me.Tne, 3)) Mod 360
			Me.Mprimene = (38.3776 + 355.52747322 * Me.Kne + 0.0123577 * Math.Pow(Me.Tne, 2) + 1.4628E-05 * Math.Pow(Me.Tne, 3) - 6.9E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Ohmegane = (123.9767 - 1.44098949 * Me.Kne + 0.0020625 * Math.Pow(Me.Tne, 2) + 2.14E-06 * Math.Pow(Me.Tne, 3) - 1.6E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.V = (299.75 + 132.85 * Me.Tne - 0.009173 * Math.Pow(Me.Tne, 2)) Mod 360
			Me.P = (Me.Ohmegane + 272.75 - 2.3 * Me.Tne) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tne - 7.4E-06 * Math.Pow(Me.Tne, 2)
			Me.JDEne = 2451565.1619 + 27.212220817 * Me.Kne + 0.0002572 * Math.Pow(Me.Tne, 2) + 2.1E-08 * Math.Pow(Me.Tne, 3) - 8.8E-11 * Math.Pow(Me.Tne, 4)
			Me.Ane = New Double() { Nothing, -0.4721 * Math.Sin(Me.Mprimene * Me.degrad), -0.1649 * Math.Sin(2 * Me.Dne * Me.degrad), -0.0868 * Math.Sin((2 * Me.Dne - Me.Mprimene) * Me.degrad), 0.0084 * Math.Sin((2 * Me.Dne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0083 * Math.Sin((2 * Me.Dne - Me.Mne) * Me.degrad), Me.Eprime * -0.0039 * Math.Sin((2 * Me.Dne - Me.Mne - Me.Mprimene) * Me.degrad), 0.0034 * Math.Sin(2 * Me.Mprimene * Me.degrad), -0.0031 * Math.Sin((2 * Me.Dne - 2 * Me.Mprimene) * Me.degrad), Me.Eprime * 0.003 * Math.Sin((2 * Me.Dne + Me.Mne) * Me.degrad), Me.Eprime * 0.0028 * Math.Sin((Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0026 * Math.Sin(Me.Mne * Me.degrad), 0.0025 * Math.Sin(4 * Me.Dne * Me.degrad), 0.0024 * Math.Sin(Me.Dne * Me.degrad), Me.Eprime * 0.0022 * Math.Sin((Me.Mne + Me.Mprimene) * Me.degrad), 0.0017 * Math.Sin(Me.Ohmegane * Me.degrad), 0.0014 * Math.Sin((4 * Me.Dne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0005 * Math.Sin((2 * Me.Dne + Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0004 * Math.Sin((2 * Me.Dne - Me.Mne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0003 * Math.Sin((2 * Me.Dne - 2 * Me.Mne) * Me.degrad), Me.Eprime * 0.0003 * Math.Sin((4 * Me.Dne - Me.Mne) * Me.degrad), 0.0003 * Math.Sin(Me.V * Me.degrad), 0.0003 * Math.Sin(Me.P * Me.degrad) }
			Me.S1 = 0
			Dim num7 As Integer = 1
			Do
				Me.S1 += Me.Ane(num7)
				num7 = num7 + 1
			Loop While num7 <= 22
			Me.MJDmois(5) = Me.JDEne + Me.S1 - 2400000.5
			Me.Ane = Nothing
			Me.Kphase = Conversion.Int((CDbl(Me.Arg(1).Year) + CDbl(Me.Arg(1).Month) / 12 - 2000) * 12.3685)
			Me.Tphase = Me.Kphase / 1236.85
			Me.Mphase = (2.5534 + 29.10535669 * Me.Kphase - 2.18E-05 * Math.Pow(Me.Tphase, 2) - 1.1E-07 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Mprime = (201.5643 + 385.81693528 * Me.Kphase + 0.0107438 * Math.Pow(Me.Tphase, 2) + 1.239E-05 * Math.Pow(Me.Tphase, 3) - 5.8E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Fphase = (160.7108 + 390.67050274 * Me.Kphase - 0.0016341 * Math.Pow(Me.Tphase, 2) - 2.27E-06 * Math.Pow(Me.Tphase, 3) + 1.1E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Omega = (124.7746 - 1.5637558 * Me.Kphase + 0.0020691 * Math.Pow(Me.Tphase, 2) + 2.15E-06 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tphase - 7.4E-06 * Math.Pow(Me.Tphase, 2)
			Me.JDEphase = 2451550.09765 + 29.530588853 * Me.Kphase + 0.0001337 * Math.Pow(Me.Tphase, 2) - 1.5E-07 * Math.Pow(Me.Tphase, 3) + 7.3E-10 * Math.Pow(Me.Tphase, 4)
			ReDim Me.Aphase(1, 14)
			Me.Aphase(0, 1) = 299.77 + 0.107408 * Me.Kphase - 0.009173 * Math.Pow(Me.Tphase, 2)
			Me.Aphase(0, 2) = 251.88 + 0.016321 * Me.Kphase
			Me.Aphase(0, 3) = 251.83 + 26.651886 * Me.Kphase
			Me.Aphase(0, 4) = 349.42 + 36.412478 * Me.Kphase
			Me.Aphase(0, 5) = 84.66 + 18.206239 * Me.Kphase
			Me.Aphase(0, 6) = 141.74 + 53.303771 * Me.Kphase
			Me.Aphase(0, 7) = 207.14 + 2.453732 * Me.Kphase
			Me.Aphase(0, 8) = 154.84 + 7.30686 * Me.Kphase
			Me.Aphase(0, 9) = 34.52 + 27.261239 * Me.Kphase
			Me.Aphase(0, 10) = 207.19 + 0.121824 * Me.Kphase
			Me.Aphase(0, 11) = 291.34 + 1.844379 * Me.Kphase
			Me.Aphase(0, 12) = 161.72 + 24.198154 * Me.Kphase
			Me.Aphase(0, 13) = 239.56 + 25.513099 * Me.Kphase
			Me.Aphase(0, 14) = 331.55 + 3.592518 * Me.Kphase
			Me.Aphase(1, 1) = 0.000325 * Math.Sin(Me.Aphase(0, 1) * Me.degrad) Mod 360
			Me.Aphase(1, 2) = 0.000165 * Math.Sin(Me.Aphase(0, 2) * Me.degrad) Mod 360
			Me.Aphase(1, 3) = 0.000164 * Math.Sin(Me.Aphase(0, 3) * Me.degrad) Mod 360
			Me.Aphase(1, 4) = 0.000126 * Math.Sin(Me.Aphase(0, 4) * Me.degrad) Mod 360
			Me.Aphase(1, 5) = 0.00011 * Math.Sin(Me.Aphase(0, 5) * Me.degrad) Mod 360
			Me.Aphase(1, 6) = 6.2E-05 * Math.Sin(Me.Aphase(0, 6) * Me.degrad) Mod 360
			Me.Aphase(1, 7) = 6E-05 * Math.Sin(Me.Aphase(0, 7) * Me.degrad) Mod 360
			Me.Aphase(1, 8) = 5.6E-05 * Math.Sin(Me.Aphase(0, 8) * Me.degrad) Mod 360
			Me.Aphase(1, 9) = 4.7E-05 * Math.Sin(Me.Aphase(0, 9) * Me.degrad) Mod 360
			Me.Aphase(1, 10) = 4.2E-05 * Math.Sin(Me.Aphase(0, 10) * Me.degrad) Mod 360
			Me.Aphase(1, 11) = 4E-05 * Math.Sin(Me.Aphase(0, 11) * Me.degrad) Mod 360
			Me.Aphase(1, 12) = 3.7E-05 * Math.Sin(Me.Aphase(0, 12) * Me.degrad) Mod 360
			Me.Aphase(1, 13) = 3.5E-05 * Math.Sin(Me.Aphase(0, 13) * Me.degrad) Mod 360
			Me.Aphase(1, 14) = 2.3E-05 * Math.Sin(Me.Aphase(0, 14) * Me.degrad) Mod 360
			Me.Facteur = New Double() { Nothing, Math.Sin(Me.Mprime * Me.degrad), Me.Eprime * Math.Sin(Me.Mphase * Me.degrad), Math.Sin(2 * Me.Mprime * Me.degrad), Math.Sin(2 * Me.Fphase * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime - Me.Mphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime + Me.Mphase) * Me.degrad), Math.Pow(Me.Eprime, 2) * Math.Sin(2 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(3 * Me.Mprime * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase - 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime - Me.Mphase) * Me.degrad), Math.Sin(Me.Omega * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Mphase) * Me.degrad), Math.Sin((2 * Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin(3 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((2 * Me.Mprime + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((3 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(4 * Me.Mprime * Me.degrad) }
			ReDim Me.Correction(1, 25)
			Me.Correction(0, 1) = -0.4072 * Me.Facteur(1)
			Me.Correction(0, 2) = 0.17241 * Me.Facteur(2)
			Me.Correction(0, 3) = 0.01608 * Me.Facteur(3)
			Me.Correction(0, 4) = 0.01039 * Me.Facteur(4)
			Me.Correction(0, 5) = 0.00739 * Me.Facteur(5)
			Me.Correction(0, 6) = -0.00514 * Me.Facteur(6)
			Me.Correction(0, 7) = 0.00208 * Me.Facteur(7)
			Me.Correction(0, 8) = -0.00111 * Me.Facteur(8)
			Me.Correction(0, 9) = -0.00057 * Me.Facteur(9)
			Me.Correction(0, 10) = 0.00056 * Me.Facteur(10)
			Me.Correction(0, 11) = -0.00042 * Me.Facteur(11)
			Me.Correction(0, 12) = 0.00042 * Me.Facteur(12)
			Me.Correction(0, 13) = 0.00038 * Me.Facteur(13)
			Me.Correction(0, 14) = -0.00024 * Me.Facteur(14)
			Me.Correction(0, 15) = -0.00017 * Me.Facteur(15)
			Me.Correction(0, 16) = -7E-05 * Me.Facteur(16)
			Me.Correction(0, 17) = 4E-05 * Me.Facteur(17)
			Me.Correction(0, 18) = 4E-05 * Me.Facteur(18)
			Me.Correction(0, 19) = 3E-05 * Me.Facteur(19)
			Me.Correction(0, 20) = 3E-05 * Me.Facteur(20)
			Me.Correction(0, 21) = -3E-05 * Me.Facteur(21)
			Me.Correction(0, 22) = 3E-05 * Me.Facteur(22)
			Me.Correction(0, 23) = -2E-05 * Me.Facteur(23)
			Me.Correction(0, 24) = -2E-05 * Me.Facteur(24)
			Me.Correction(0, 25) = 2E-05 * Me.Facteur(25)
			Me.S1 = 0
			Dim num8 As Integer = 1
			Do
				Me.S1 += Me.Aphase(1, num8)
				num8 = num8 + 1
			Loop While num8 <= 14
			Me.S2 = 0
			Dim num9 As Integer = 1
			Do
				Me.S2 += Me.Correction(0, num9)
				num9 = num9 + 1
			Loop While num9 <= 25
			Me.MJDmois(6) = Me.JDEphase + Me.S1 + Me.S2 - 2400000.5
			Me.Kphase += 0.5
			Me.Tphase = Me.Kphase / 1236.85
			Me.Mphase = (2.5534 + 29.1053567 * Me.Kphase - 1.4E-06 * Math.Pow(Me.Tphase, 2) - 1.1E-07 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Mprime = (201.5643 + 385.81693528 * Me.Kphase + 0.0107438 * Math.Pow(Me.Tphase, 2) + 1.239E-05 * Math.Pow(Me.Tphase, 3) - 5.8E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Fphase = (160.7108 + 390.67050274 * Me.Kphase - 0.0016341 * Math.Pow(Me.Tphase, 2) - 2.27E-06 * Math.Pow(Me.Tphase, 3) + 1.1E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Omega = (124.7746 - 1.5637558 * Me.Kphase + 0.0020691 * Math.Pow(Me.Tphase, 2) + 2.15E-06 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tphase - 7.4E-06 * Math.Pow(Me.Tphase, 2)
			Me.JDEphase = 2451550.09766 + 29.530588853 * Me.Kphase + 0.00015437 * Math.Pow(Me.Tphase, 2) - 1.5E-07 * Math.Pow(Me.Tphase, 3) + 7.3E-10 * Math.Pow(Me.Tphase, 4)
			ReDim Me.Aphase(1, 14)
			Me.Aphase(0, 1) = 299.77 + 0.107408 * Me.Kphase - 0.009173 * Math.Pow(Me.Tphase, 2)
			Me.Aphase(0, 2) = 251.88 + 0.016321 * Me.Kphase
			Me.Aphase(0, 3) = 251.83 + 26.651886 * Me.Kphase
			Me.Aphase(0, 4) = 349.42 + 36.412478 * Me.Kphase
			Me.Aphase(0, 5) = 84.66 + 18.206239 * Me.Kphase
			Me.Aphase(0, 6) = 141.74 + 53.303771 * Me.Kphase
			Me.Aphase(0, 7) = 207.14 + 2.453732 * Me.Kphase
			Me.Aphase(0, 8) = 154.84 + 7.30686 * Me.Kphase
			Me.Aphase(0, 9) = 34.52 + 27.261239 * Me.Kphase
			Me.Aphase(0, 10) = 207.19 + 0.121824 * Me.Kphase
			Me.Aphase(0, 11) = 291.34 + 1.844379 * Me.Kphase
			Me.Aphase(0, 12) = 161.72 + 24.198154 * Me.Kphase
			Me.Aphase(0, 13) = 239.56 + 25.513099 * Me.Kphase
			Me.Aphase(0, 14) = 331.55 + 3.592518 * Me.Kphase
			Me.Aphase(1, 1) = 0.000325 * Math.Sin(Me.Aphase(0, 1) * Me.degrad)
			Me.Aphase(1, 2) = 0.000165 * Math.Sin(Me.Aphase(0, 2) * Me.degrad)
			Me.Aphase(1, 3) = 0.000164 * Math.Sin(Me.Aphase(0, 3) * Me.degrad)
			Me.Aphase(1, 4) = 0.000126 * Math.Sin(Me.Aphase(0, 4) * Me.degrad)
			Me.Aphase(1, 5) = 0.00011 * Math.Sin(Me.Aphase(0, 5) * Me.degrad)
			Me.Aphase(1, 6) = 6.2E-05 * Math.Sin(Me.Aphase(0, 6) * Me.degrad)
			Me.Aphase(1, 7) = 6E-05 * Math.Sin(Me.Aphase(0, 7) * Me.degrad)
			Me.Aphase(1, 8) = 5.6E-05 * Math.Sin(Me.Aphase(0, 8) * Me.degrad)
			Me.Aphase(1, 9) = 4.7E-05 * Math.Sin(Me.Aphase(0, 9) * Me.degrad)
			Me.Aphase(1, 10) = 4.2E-05 * Math.Sin(Me.Aphase(0, 10) * Me.degrad)
			Me.Aphase(1, 11) = 4E-05 * Math.Sin(Me.Aphase(0, 11) * Me.degrad)
			Me.Aphase(1, 12) = 3.7E-05 * Math.Sin(Me.Aphase(0, 12) * Me.degrad)
			Me.Aphase(1, 13) = 3.5E-05 * Math.Sin(Me.Aphase(0, 13) * Me.degrad)
			Me.Aphase(1, 14) = 2.3E-05 * Math.Sin(Me.Aphase(0, 14) * Me.degrad)
			Me.Facteur = New Double() { Nothing, Math.Sin(Me.Mprime * Me.degrad), Me.Eprime * Math.Sin(Me.Mphase * Me.degrad), Math.Sin(2 * Me.Mprime * Me.degrad), Math.Sin(2 * Me.Fphase * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime - Me.Mphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime + Me.Mphase) * Me.degrad), Math.Pow(Me.Eprime, 2) * Math.Sin(2 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(3 * Me.Mprime * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase - 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime - Me.Mphase) * Me.degrad), Math.Sin(Me.Omega * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Mphase) * Me.degrad), Math.Sin((2 * Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin(3 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((2 * Me.Mprime + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((3 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(4 * Me.Mprime * Me.degrad) }
			Me.Correction(1, 1) = -0.40614 * Me.Facteur(1)
			Me.Correction(1, 2) = 0.17302 * Me.Facteur(2)
			Me.Correction(1, 3) = 0.01614 * Me.Facteur(3)
			Me.Correction(1, 4) = 0.01043 * Me.Facteur(4)
			Me.Correction(1, 5) = 0.00734 * Me.Facteur(5)
			Me.Correction(1, 6) = -0.00515 * Me.Facteur(6)
			Me.Correction(1, 7) = 0.00209 * Me.Facteur(7)
			Me.Correction(1, 8) = 0.00111 * Me.Facteur(8)
			Me.Correction(1, 9) = -0.00057 * Me.Facteur(9)
			Me.Correction(1, 10) = 0.00056 * Me.Facteur(10)
			Me.Correction(1, 11) = -0.00042 * Me.Facteur(11)
			Me.Correction(1, 12) = 0.00042 * Me.Facteur(12)
			Me.Correction(1, 13) = 0.00038 * Me.Facteur(13)
			Me.Correction(1, 14) = -0.00024 * Me.Facteur(14)
			Me.Correction(1, 15) = -0.00017 * Me.Facteur(15)
			Me.Correction(1, 16) = -7E-05 * Me.Facteur(16)
			Me.Correction(1, 17) = 4E-05 * Me.Facteur(17)
			Me.Correction(1, 18) = 4E-05 * Me.Facteur(18)
			Me.Correction(1, 19) = 3E-05 * Me.Facteur(19)
			Me.Correction(1, 20) = 3E-05 * Me.Facteur(20)
			Me.Correction(1, 21) = -3E-05 * Me.Facteur(21)
			Me.Correction(1, 22) = 3E-05 * Me.Facteur(22)
			Me.Correction(1, 23) = -2E-05 * Me.Facteur(23)
			Me.Correction(1, 24) = -2E-05 * Me.Facteur(24)
			Me.Correction(1, 25) = 2E-05 * Me.Facteur(25)
			Me.S1 = 0
			Dim num10 As Integer = 1
			Do
				Me.S1 += Me.Aphase(1, num10)
				num10 = num10 + 1
			Loop While num10 <= 14
			Me.S2 = 0
			Dim num11 As Integer = 1
			Do
				Me.S2 += Me.Correction(1, num11)
				num11 = num11 + 1
			Loop While num11 <= 25
			Me.MJDmois(7) = Me.JDEphase + Me.S1 + Me.S2 - 2400000.5
			Me.Correction = Nothing
			Me.Facteur = Nothing
			Me.Aphase = Nothing
			Me.Kapprg = Conversion.Int((CDbl(Me.Arg(1).Year) + CDbl(Me.Arg(1).Month) / 12 - 1999.97) * 13.2555)
			Me.Tapprg = Me.Kapprg / 1325.55
			Me.D = (171.9179 + 335.9106046 * Me.Kapprg - 0.010025 * Math.Pow(Me.Tapprg, 2) - 1.156E-05 * Math.Pow(Me.Tapprg, 3) + 5.5E-08 * Math.Pow(Me.Tapprg, 4)) Mod 360
			Me.Mapprg = (347.3477 + 27.1577721 * Me.Kapprg - 0.0008323 * Math.Pow(Me.Tapprg, 2) - 1E-06 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.Fapprg = (316.6109 + 364.5287911 * Me.Kapprg - 0.0125131 * Math.Pow(Me.Tapprg, 2) - 1.48E-05 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.JDEapprg = 2451534.6698 + 27.55454988 * Me.Kapprg - 0.0006886 * Math.Pow(Me.Tapprg, 2) - 1.098E-06 * Math.Pow(Me.Tapprg, 3) + 5.2E-09 * Math.Pow(Me.Tapprg, 4)
			Me.Aprg = New Double() { Nothing, -1.6769 * Math.Sin(2 * Me.D * Me.degrad), 0.4589 * Math.Sin(4 * Me.D * Me.degrad), -0.1856 * Math.Sin(6 * Me.D * Me.degrad), 0.0883 * Math.Sin(8 * Me.D * Me.degrad), (-0.0773 + 0.00019 * Me.Tapprg) * Math.Sin((2 * Me.D - Me.Mapprg) * Me.degrad), (0.0502 - 0.00013 * Me.Tapprg) * Math.Sin(Me.Mapprg * Me.degrad), -0.046 * Math.Sin(10 * Me.D * Me.degrad), (0.0422 - 0.00011 * Me.Tapprg) * Math.Sin((4 * Me.D - Me.Mapprg) * Me.degrad), -0.0256 * Math.Sin((6 * Me.D - Me.Mapprg) * Me.degrad), 0.0253 * Math.Sin(12 * Me.D * Me.degrad), 0.0237 * Math.Sin(Me.D * Me.degrad), 0.0162 * Math.Sin((8 * Me.D - Me.Mapprg) * Me.degrad), -0.0145 * Math.Sin(14 * Me.D * Me.degrad), 0.0129 * Math.Sin(2 * Me.Fapprg * Me.degrad), -0.0112 * Math.Sin(3 * Me.D * Me.degrad), -0.0104 * Math.Sin((10 * Me.D - Me.Mapprg) * Me.degrad), 0.0086 * Math.Sin(16 * Me.D * Me.degrad), 0.0069 * Math.Sin((12 * Me.D - Me.Mapprg) * Me.degrad), 0.0066 * Math.Sin(5 * Me.D * Me.degrad), -0.0053 * Math.Sin((2 * Me.D + 2 * Me.Fapprg) * Me.degrad), -0.0052 * Math.Sin(18 * Me.D * Me.degrad), -0.0046 * Math.Sin((14 * Me.D - Me.Mapprg) * Me.degrad), -0.0041 * Math.Sin(7 * Me.D * Me.degrad), 0.004 * Math.Sin((2 * Me.D + Me.Mapprg) * Me.degrad), 0.0032 * Math.Sin(20 * Me.D * Me.degrad), -0.0032 * Math.Sin((Me.D + Me.Mapprg) * Me.degrad), 0.0031 * Math.Sin((16 * Me.D - Me.Mapprg) * Me.degrad), -0.0029 * Math.Sin((4 * Me.D + Me.Mapprg) * Me.degrad), 0.0027 * Math.Sin(9 * Me.D * Me.degrad), 0.0027 * Math.Sin((4 * Me.D + 2 * Me.Fapprg) * Me.degrad), -0.0027 * Math.Sin((2 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0024 * Math.Sin((4 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0021 * Math.Sin((6 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0021 * Math.Sin(22 * Me.D * Me.degrad), -0.0021 * Math.Sin((18 * Me.D - Me.Mapprg) * Me.degrad), 0.0019 * Math.Sin((6 * Me.D + Me.Mapprg) * Me.degrad), 0.0018 * Math.Sin(11 * Me.D * Me.degrad), -0.0014 * Math.Sin((8 * Me.D + Me.Mapprg) * Me.degrad), -0.0014 * Math.Sin((4 * Me.D - 2 * Me.Fapprg) * Me.degrad), -0.0014 * Math.Sin((6 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0014 * Math.Sin((3 * Me.D + Me.Mapprg) * Me.degrad), -0.0014 * Math.Sin((5 * Me.D + Me.Mapprg) * Me.degrad), 0.0013 * Math.Sin(13 * Me.D * Me.degrad), 0.0013 * Math.Sin((20 * Me.D - Me.Mapprg) * Me.degrad), 0.0011 * Math.Sin((3 * Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0011 * Math.Sin((4 * Me.D + 2 * Me.Fapprg - 2 * Me.Mapprg) * Me.degrad), 0.001 * Math.Sin((Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0009 * Math.Sin((22 * Me.D - Me.Mapprg) * Me.degrad), -0.0008 * Math.Sin(4 * Me.Fapprg * Me.degrad), 0.0008 * Math.Sin((6 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0008 * Math.Sin((2 * Me.D - 2 * Me.Fapprg + Me.Mapprg) * Me.degrad), 0.0007 * Math.Sin(2 * Me.Mapprg * Me.degrad), 0.0007 * Math.Sin((2 * Me.Fapprg - Me.Mapprg) * Me.degrad), 0.0007 * Math.Sin((2 * Me.D + 4 * Me.Fapprg) * Me.degrad), -0.0006 * Math.Sin((2 * Me.Fapprg - 2 * Me.Mapprg) * Me.degrad), -0.0006 * Math.Sin((2 * Me.D - 2 * Me.Fapprg + 2 * Me.Mapprg) * Me.degrad), 0.0006 * Math.Sin(24 * Me.D * Me.degrad), 0.0005 * Math.Sin((4 * Me.D - 4 * Me.Fapprg) * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0004 * Math.Sin((Me.D - Me.Mapprg) * Me.degrad) }
			Me.S1 = 0
			Dim num12 As Integer = 1
			Do
				Me.S1 += Me.Aprg(num12)
				num12 = num12 + 1
			Loop While num12 <= 60
			Me.MJDmois(8) = Me.JDEapprg + Me.S1 - 2400000.5
			Me.Aprg = Nothing
			Me.Kapprg += 0.5
			Me.Tapprg = Me.Kapprg / 1325.55
			Me.D = (171.9179 + 335.9106046 * Me.Kapprg - 0.010025 * Math.Pow(Me.Tapprg, 2) - 1.156E-05 * Math.Pow(Me.Tapprg, 3) + 5.5E-08 * Math.Pow(Me.Tapprg, 4)) Mod 360
			Me.Mapprg = (347.3477 + 27.1577721 * Me.Kapprg - 0.0008323 * Math.Pow(Me.Tapprg, 2) - 1E-06 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.Fapprg = (316.6109 + 364.5287911 * Me.Kapprg - 0.0125131 * Math.Pow(Me.Tapprg, 2) - 1.48E-05 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.JDEapprg = 2451534.6698 + 27.55454988 * Me.Kapprg - 0.0006886 * Math.Pow(Me.Tapprg, 2) - 1.098E-06 * Math.Pow(Me.Tapprg, 3) + 5.2E-09 * Math.Pow(Me.Tapprg, 4)
			Me.Aap = New Double() { Nothing, 0.4392 * Math.Sin(2 * Me.D * Me.degrad), 0.0684 * Math.Sin(4 * Me.D * Me.degrad), (0.0456 - 0.00011 * Me.Tapprg) * Math.Sin(Me.Mapprg * Me.degrad), (0.0426 - 0.00011 * Me.Tapprg) * Math.Sin((2 * Me.D - Me.Mapprg) * Me.degrad), 0.0212 * Math.Sin(2 * Me.Fapprg * Me.degrad), -0.0189 * Math.Sin(Me.D * Me.degrad), 0.0144 * Math.Sin(6 * Me.D * Me.degrad), 0.0113 * Math.Sin((4 * Me.D - Me.Mapprg) * Me.degrad), 0.0047 * Math.Sin((2 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0036 * Math.Sin((Me.D + Me.Mapprg) * Me.degrad), 0.0035 * Math.Sin(8 * Me.D * Me.degrad), 0.0034 * Math.Sin((6 * Me.D - Me.Mapprg) * Me.degrad), -0.0034 * Math.Sin((2 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0022 * Math.Sin((2 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0017 * Math.Sin(3 * Me.D * Me.degrad), 0.0013 * Math.Sin((4 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0011 * Math.Sin((8 * Me.D - Me.Mapprg) * Me.degrad), 0.001 * Math.Sin((4 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0009 * Math.Sin(10 * Me.D * Me.degrad), 0.0007 * Math.Sin((3 * Me.D + Me.Mapprg) * Me.degrad), 0.0006 * Math.Sin(2 * Me.Mapprg * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + Me.Mapprg) * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + 2 * Me.Mapprg) * Me.degrad), 0.0004 * Math.Sin((6 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0004 * Math.Sin((6 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0004 * Math.Sin((10 * Me.D - Me.Mapprg) * Me.degrad), -0.0004 * Math.Sin(5 * Me.D * Me.degrad), -0.0004 * Math.Sin((4 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0003 * Math.Sin((2 * Me.Fapprg + Me.Mapprg) * Me.degrad), 0.0003 * Math.Sin(12 * Me.D * Me.degrad), 0.0003 * Math.Sin((2 * Me.D + 2 * Me.Fapprg - Me.Mapprg) * Me.degrad), -0.0003 * Math.Sin((Me.D - Me.Mapprg) * Me.degrad) }
			Me.S1 = 0
			Dim num13 As Integer = 1
			Do
				Me.S1 += Me.Aap(num13)
				num13 = num13 + 1
			Loop While num13 <= 32
			Me.MJDmois(9) = Me.JDEapprg + Me.S1 - 2400000.5
			Me.Aap = Nothing
			Me.Kne = Conversion.Int((CDbl(Me.Arg(1).Year) + CDbl(Me.Arg(1).Month) / 12 - 2000.05) * 13.4223)
			Me.Tne = Me.Kne / 1342.23
			Me.Dne = (183.638 + 331.73735691 * Me.Kne + 0.0015057 * Math.Pow(Me.Tne, 2) + 2.09E-06 * Math.Pow(Me.Tne, 3) - 1E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Mne = (17.4006 + 26.8203725 * Me.Kne + 9.99E-05 * Math.Pow(Me.Tne, 2) + 6E-08 * Math.Pow(Me.Tne, 3)) Mod 360
			Me.Mprimene = (38.3776 + 355.52747322 * Me.Kne + 0.0123577 * Math.Pow(Me.Tne, 2) + 1.4628E-05 * Math.Pow(Me.Tne, 3) - 6.9E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Ohmegane = (123.9767 - 1.44098949 * Me.Kne + 0.0020625 * Math.Pow(Me.Tne, 2) + 2.14E-06 * Math.Pow(Me.Tne, 3) - 1.6E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.V = (299.75 + 132.85 * Me.Tne - 0.009173 * Math.Pow(Me.Tne, 2)) Mod 360
			Me.P = (Me.Ohmegane + 272.75 - 2.3 * Me.Tne) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tne - 7.4E-06 * Math.Pow(Me.Tne, 2)
			Me.JDEne = 2451565.1619 + 27.212220817 * Me.Kne + 0.0002572 * Math.Pow(Me.Tne, 2) + 2.1E-08 * Math.Pow(Me.Tne, 3) - 8.8E-11 * Math.Pow(Me.Tne, 4)
			Me.Ane = New Double() { Nothing, -0.4721 * Math.Sin(Me.Mprimene * Me.degrad), -0.1649 * Math.Sin(2 * Me.Dne * Me.degrad), -0.0868 * Math.Sin((2 * Me.Dne - Me.Mprimene) * Me.degrad), 0.0084 * Math.Sin((2 * Me.Dne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0083 * Math.Sin((2 * Me.Dne - Me.Mne) * Me.degrad), Me.Eprime * -0.0039 * Math.Sin((2 * Me.Dne - Me.Mne - Me.Mprimene) * Me.degrad), 0.0034 * Math.Sin(2 * Me.Mprimene * Me.degrad), -0.0031 * Math.Sin((2 * Me.Dne - 2 * Me.Mprimene) * Me.degrad), Me.Eprime * 0.003 * Math.Sin((2 * Me.Dne + Me.Mne) * Me.degrad), Me.Eprime * 0.0028 * Math.Sin((Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0026 * Math.Sin(Me.Mne * Me.degrad), 0.0025 * Math.Sin(4 * Me.Dne * Me.degrad), 0.0024 * Math.Sin(Me.Dne * Me.degrad), Me.Eprime * 0.0022 * Math.Sin((Me.Mne + Me.Mprimene) * Me.degrad), 0.0017 * Math.Sin(Me.Ohmegane * Me.degrad), 0.0014 * Math.Sin((4 * Me.Dne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0005 * Math.Sin((2 * Me.Dne + Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0004 * Math.Sin((2 * Me.Dne - Me.Mne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0003 * Math.Sin((2 * Me.Dne - 2 * Me.Mne) * Me.degrad), Me.Eprime * 0.0003 * Math.Sin((4 * Me.Dne - Me.Mne) * Me.degrad), 0.0003 * Math.Sin(Me.V * Me.degrad), 0.0003 * Math.Sin(Me.P * Me.degrad) }
			Me.S1 = 0
			Dim num14 As Integer = 1
			Do
				Me.S1 += Me.Ane(num14)
				num14 = num14 + 1
			Loop While num14 <= 22
			Me.MJDmois(10) = Me.JDEne + Me.S1 - 2400000.5
			Me.Kne += 0.5
			Me.Tne = Me.Kne / 1342.23
			Me.Dne = (183.638 + 331.73735691 * Me.Kne + 0.0015057 * Math.Pow(Me.Tne, 2) + 2.09E-06 * Math.Pow(Me.Tne, 3) - 1E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Mne = (17.4006 + 26.8203725 * Me.Kne + 9.99E-05 * Math.Pow(Me.Tne, 2) + 6E-08 * Math.Pow(Me.Tne, 3)) Mod 360
			Me.Mprimene = (38.3776 + 355.52747322 * Me.Kne + 0.0123577 * Math.Pow(Me.Tne, 2) + 1.4628E-05 * Math.Pow(Me.Tne, 3) - 6.9E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Ohmegane = (123.9767 - 1.44098949 * Me.Kne + 0.0020625 * Math.Pow(Me.Tne, 2) + 2.14E-06 * Math.Pow(Me.Tne, 3) - 1.6E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.V = (299.75 + 132.85 * Me.Tne - 0.009173 * Math.Pow(Me.Tne, 2)) Mod 360
			Me.P = (Me.Ohmegane + 272.75 - 2.3 * Me.Tne) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tne - 7.4E-06 * Math.Pow(Me.Tne, 2)
			Me.JDEne = 2451565.1619 + 27.212220817 * Me.Kne + 0.0002572 * Math.Pow(Me.Tne, 2) + 2.1E-08 * Math.Pow(Me.Tne, 3) - 8.8E-11 * Math.Pow(Me.Tne, 4)
			Me.Ane = New Double() { Nothing, -0.4721 * Math.Sin(Me.Mprimene * Me.degrad), -0.1649 * Math.Sin(2 * Me.Dne * Me.degrad), -0.0868 * Math.Sin((2 * Me.Dne - Me.Mprimene) * Me.degrad), 0.0084 * Math.Sin((2 * Me.Dne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0083 * Math.Sin((2 * Me.Dne - Me.Mne) * Me.degrad), Me.Eprime * -0.0039 * Math.Sin((2 * Me.Dne - Me.Mne - Me.Mprimene) * Me.degrad), 0.0034 * Math.Sin(2 * Me.Mprimene * Me.degrad), -0.0031 * Math.Sin((2 * Me.Dne - 2 * Me.Mprimene) * Me.degrad), Me.Eprime * 0.003 * Math.Sin((2 * Me.Dne + Me.Mne) * Me.degrad), Me.Eprime * 0.0028 * Math.Sin((Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0026 * Math.Sin(Me.Mne * Me.degrad), 0.0025 * Math.Sin(4 * Me.Dne * Me.degrad), 0.0024 * Math.Sin(Me.Dne * Me.degrad), Me.Eprime * 0.0022 * Math.Sin((Me.Mne + Me.Mprimene) * Me.degrad), 0.0017 * Math.Sin(Me.Ohmegane * Me.degrad), 0.0014 * Math.Sin((4 * Me.Dne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0005 * Math.Sin((2 * Me.Dne + Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0004 * Math.Sin((2 * Me.Dne - Me.Mne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0003 * Math.Sin((2 * Me.Dne - 2 * Me.Mne) * Me.degrad), Me.Eprime * 0.0003 * Math.Sin((4 * Me.Dne - Me.Mne) * Me.degrad), 0.0003 * Math.Sin(Me.V * Me.degrad), 0.0003 * Math.Sin(Me.P * Me.degrad) }
			Me.S1 = 0
			Dim num15 As Integer = 1
			Do
				Me.S1 += Me.Ane(num15)
				num15 = num15 + 1
			Loop While num15 <= 22
			Me.MJDmois(11) = Me.JDEne + Me.S1 - 2400000.5
			Me.Ane = Nothing
			Me.Kphase = Conversion.Int((CDbl(Me.Arg(2).Year) + CDbl(Me.Arg(2).Month) / 12 - 2000) * 12.3685)
			Me.Tphase = Me.Kphase / 1236.85
			Me.Mphase = (2.5534 + 29.10535669 * Me.Kphase - 2.18E-05 * Math.Pow(Me.Tphase, 2) - 1.1E-07 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Mprime = (201.5643 + 385.81693528 * Me.Kphase + 0.0107438 * Math.Pow(Me.Tphase, 2) + 1.239E-05 * Math.Pow(Me.Tphase, 3) - 5.8E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Fphase = (160.7108 + 390.67050274 * Me.Kphase - 0.0016341 * Math.Pow(Me.Tphase, 2) - 2.27E-06 * Math.Pow(Me.Tphase, 3) + 1.1E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Omega = (124.7746 - 1.5637558 * Me.Kphase + 0.0020691 * Math.Pow(Me.Tphase, 2) + 2.15E-06 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tphase - 7.4E-06 * Math.Pow(Me.Tphase, 2)
			Me.JDEphase = 2451550.09765 + 29.530588853 * Me.Kphase + 0.0001337 * Math.Pow(Me.Tphase, 2) - 1.5E-07 * Math.Pow(Me.Tphase, 3) + 7.3E-10 * Math.Pow(Me.Tphase, 4)
			ReDim Me.Aphase(1, 14)
			Me.Aphase(0, 1) = 299.77 + 0.107408 * Me.Kphase - 0.009173 * Math.Pow(Me.Tphase, 2)
			Me.Aphase(0, 2) = 251.88 + 0.016321 * Me.Kphase
			Me.Aphase(0, 3) = 251.83 + 26.651886 * Me.Kphase
			Me.Aphase(0, 4) = 349.42 + 36.412478 * Me.Kphase
			Me.Aphase(0, 5) = 84.66 + 18.206239 * Me.Kphase
			Me.Aphase(0, 6) = 141.74 + 53.303771 * Me.Kphase
			Me.Aphase(0, 7) = 207.14 + 2.453732 * Me.Kphase
			Me.Aphase(0, 8) = 154.84 + 7.30686 * Me.Kphase
			Me.Aphase(0, 9) = 34.52 + 27.261239 * Me.Kphase
			Me.Aphase(0, 10) = 207.19 + 0.121824 * Me.Kphase
			Me.Aphase(0, 11) = 291.34 + 1.844379 * Me.Kphase
			Me.Aphase(0, 12) = 161.72 + 24.198154 * Me.Kphase
			Me.Aphase(0, 13) = 239.56 + 25.513099 * Me.Kphase
			Me.Aphase(0, 14) = 331.55 + 3.592518 * Me.Kphase
			Me.Aphase(1, 1) = 0.000325 * Math.Sin(Me.Aphase(0, 1) * Me.degrad) Mod 360
			Me.Aphase(1, 2) = 0.000165 * Math.Sin(Me.Aphase(0, 2) * Me.degrad) Mod 360
			Me.Aphase(1, 3) = 0.000164 * Math.Sin(Me.Aphase(0, 3) * Me.degrad) Mod 360
			Me.Aphase(1, 4) = 0.000126 * Math.Sin(Me.Aphase(0, 4) * Me.degrad) Mod 360
			Me.Aphase(1, 5) = 0.00011 * Math.Sin(Me.Aphase(0, 5) * Me.degrad) Mod 360
			Me.Aphase(1, 6) = 6.2E-05 * Math.Sin(Me.Aphase(0, 6) * Me.degrad) Mod 360
			Me.Aphase(1, 7) = 6E-05 * Math.Sin(Me.Aphase(0, 7) * Me.degrad) Mod 360
			Me.Aphase(1, 8) = 5.6E-05 * Math.Sin(Me.Aphase(0, 8) * Me.degrad) Mod 360
			Me.Aphase(1, 9) = 4.7E-05 * Math.Sin(Me.Aphase(0, 9) * Me.degrad) Mod 360
			Me.Aphase(1, 10) = 4.2E-05 * Math.Sin(Me.Aphase(0, 10) * Me.degrad) Mod 360
			Me.Aphase(1, 11) = 4E-05 * Math.Sin(Me.Aphase(0, 11) * Me.degrad) Mod 360
			Me.Aphase(1, 12) = 3.7E-05 * Math.Sin(Me.Aphase(0, 12) * Me.degrad) Mod 360
			Me.Aphase(1, 13) = 3.5E-05 * Math.Sin(Me.Aphase(0, 13) * Me.degrad) Mod 360
			Me.Aphase(1, 14) = 2.3E-05 * Math.Sin(Me.Aphase(0, 14) * Me.degrad) Mod 360
			Me.Facteur = New Double() { Nothing, Math.Sin(Me.Mprime * Me.degrad), Me.Eprime * Math.Sin(Me.Mphase * Me.degrad), Math.Sin(2 * Me.Mprime * Me.degrad), Math.Sin(2 * Me.Fphase * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime - Me.Mphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime + Me.Mphase) * Me.degrad), Math.Pow(Me.Eprime, 2) * Math.Sin(2 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(3 * Me.Mprime * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase - 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime - Me.Mphase) * Me.degrad), Math.Sin(Me.Omega * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Mphase) * Me.degrad), Math.Sin((2 * Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin(3 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((2 * Me.Mprime + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((3 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(4 * Me.Mprime * Me.degrad) }
			ReDim Me.Correction(1, 25)
			Me.Correction(0, 1) = -0.4072 * Me.Facteur(1)
			Me.Correction(0, 2) = 0.17241 * Me.Facteur(2)
			Me.Correction(0, 3) = 0.01608 * Me.Facteur(3)
			Me.Correction(0, 4) = 0.01039 * Me.Facteur(4)
			Me.Correction(0, 5) = 0.00739 * Me.Facteur(5)
			Me.Correction(0, 6) = -0.00514 * Me.Facteur(6)
			Me.Correction(0, 7) = 0.00208 * Me.Facteur(7)
			Me.Correction(0, 8) = -0.00111 * Me.Facteur(8)
			Me.Correction(0, 9) = -0.00057 * Me.Facteur(9)
			Me.Correction(0, 10) = 0.00056 * Me.Facteur(10)
			Me.Correction(0, 11) = -0.00042 * Me.Facteur(11)
			Me.Correction(0, 12) = 0.00042 * Me.Facteur(12)
			Me.Correction(0, 13) = 0.00038 * Me.Facteur(13)
			Me.Correction(0, 14) = -0.00024 * Me.Facteur(14)
			Me.Correction(0, 15) = -0.00017 * Me.Facteur(15)
			Me.Correction(0, 16) = -7E-05 * Me.Facteur(16)
			Me.Correction(0, 17) = 4E-05 * Me.Facteur(17)
			Me.Correction(0, 18) = 4E-05 * Me.Facteur(18)
			Me.Correction(0, 19) = 3E-05 * Me.Facteur(19)
			Me.Correction(0, 20) = 3E-05 * Me.Facteur(20)
			Me.Correction(0, 21) = -3E-05 * Me.Facteur(21)
			Me.Correction(0, 22) = 3E-05 * Me.Facteur(22)
			Me.Correction(0, 23) = -2E-05 * Me.Facteur(23)
			Me.Correction(0, 24) = -2E-05 * Me.Facteur(24)
			Me.Correction(0, 25) = 2E-05 * Me.Facteur(25)
			Me.S1 = 0
			Dim num16 As Integer = 1
			Do
				Me.S1 += Me.Aphase(1, num16)
				num16 = num16 + 1
			Loop While num16 <= 14
			Me.S2 = 0
			Dim num17 As Integer = 1
			Do
				Me.S2 += Me.Correction(0, num17)
				num17 = num17 + 1
			Loop While num17 <= 25
			Me.MJDmois(12) = Me.JDEphase + Me.S1 + Me.S2 - 2400000.5
			Me.Kphase += 0.5
			Me.Tphase = Me.Kphase / 1236.85
			Me.Mphase = (2.5534 + 29.1053567 * Me.Kphase - 1.4E-06 * Math.Pow(Me.Tphase, 2) - 1.1E-07 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Mprime = (201.5643 + 385.81693528 * Me.Kphase + 0.0107438 * Math.Pow(Me.Tphase, 2) + 1.239E-05 * Math.Pow(Me.Tphase, 3) - 5.8E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Fphase = (160.7108 + 390.67050274 * Me.Kphase - 0.0016341 * Math.Pow(Me.Tphase, 2) - 2.27E-06 * Math.Pow(Me.Tphase, 3) + 1.1E-08 * Math.Pow(Me.Tphase, 4)) Mod 360
			Me.Omega = (124.7746 - 1.5637558 * Me.Kphase + 0.0020691 * Math.Pow(Me.Tphase, 2) + 2.15E-06 * Math.Pow(Me.Tphase, 3)) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tphase - 7.4E-06 * Math.Pow(Me.Tphase, 2)
			Me.JDEphase = 2451550.09766 + 29.530588853 * Me.Kphase + 0.00015437 * Math.Pow(Me.Tphase, 2) - 1.5E-07 * Math.Pow(Me.Tphase, 3) + 7.3E-10 * Math.Pow(Me.Tphase, 4)
			ReDim Me.Aphase(1, 14)
			Me.Aphase(0, 1) = 299.77 + 0.107408 * Me.Kphase - 0.009173 * Math.Pow(Me.Tphase, 2)
			Me.Aphase(0, 2) = 251.88 + 0.016321 * Me.Kphase
			Me.Aphase(0, 3) = 251.83 + 26.651886 * Me.Kphase
			Me.Aphase(0, 4) = 349.42 + 36.412478 * Me.Kphase
			Me.Aphase(0, 5) = 84.66 + 18.206239 * Me.Kphase
			Me.Aphase(0, 6) = 141.74 + 53.303771 * Me.Kphase
			Me.Aphase(0, 7) = 207.14 + 2.453732 * Me.Kphase
			Me.Aphase(0, 8) = 154.84 + 7.30686 * Me.Kphase
			Me.Aphase(0, 9) = 34.52 + 27.261239 * Me.Kphase
			Me.Aphase(0, 10) = 207.19 + 0.121824 * Me.Kphase
			Me.Aphase(0, 11) = 291.34 + 1.844379 * Me.Kphase
			Me.Aphase(0, 12) = 161.72 + 24.198154 * Me.Kphase
			Me.Aphase(0, 13) = 239.56 + 25.513099 * Me.Kphase
			Me.Aphase(0, 14) = 331.55 + 3.592518 * Me.Kphase
			Me.Aphase(1, 1) = 0.000325 * Math.Sin(Me.Aphase(0, 1) * Me.degrad)
			Me.Aphase(1, 2) = 0.000165 * Math.Sin(Me.Aphase(0, 2) * Me.degrad)
			Me.Aphase(1, 3) = 0.000164 * Math.Sin(Me.Aphase(0, 3) * Me.degrad)
			Me.Aphase(1, 4) = 0.000126 * Math.Sin(Me.Aphase(0, 4) * Me.degrad)
			Me.Aphase(1, 5) = 0.00011 * Math.Sin(Me.Aphase(0, 5) * Me.degrad)
			Me.Aphase(1, 6) = 6.2E-05 * Math.Sin(Me.Aphase(0, 6) * Me.degrad)
			Me.Aphase(1, 7) = 6E-05 * Math.Sin(Me.Aphase(0, 7) * Me.degrad)
			Me.Aphase(1, 8) = 5.6E-05 * Math.Sin(Me.Aphase(0, 8) * Me.degrad)
			Me.Aphase(1, 9) = 4.7E-05 * Math.Sin(Me.Aphase(0, 9) * Me.degrad)
			Me.Aphase(1, 10) = 4.2E-05 * Math.Sin(Me.Aphase(0, 10) * Me.degrad)
			Me.Aphase(1, 11) = 4E-05 * Math.Sin(Me.Aphase(0, 11) * Me.degrad)
			Me.Aphase(1, 12) = 3.7E-05 * Math.Sin(Me.Aphase(0, 12) * Me.degrad)
			Me.Aphase(1, 13) = 3.5E-05 * Math.Sin(Me.Aphase(0, 13) * Me.degrad)
			Me.Aphase(1, 14) = 2.3E-05 * Math.Sin(Me.Aphase(0, 14) * Me.degrad)
			Me.Facteur = New Double() { Nothing, Math.Sin(Me.Mprime * Me.degrad), Me.Eprime * Math.Sin(Me.Mphase * Me.degrad), Math.Sin(2 * Me.Mprime * Me.degrad), Math.Sin(2 * Me.Fphase * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime - Me.Mphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mprime + Me.Mphase) * Me.degrad), Math.Pow(Me.Eprime, 2) * Math.Sin(2 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(3 * Me.Mprime * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase + 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((Me.Mphase - 2 * Me.Fphase) * Me.degrad), Me.Eprime * Math.Sin((2 * Me.Mprime - Me.Mphase) * Me.degrad), Math.Sin(Me.Omega * Me.degrad), Math.Sin((Me.Mprime + 2 * Me.Mphase) * Me.degrad), Math.Sin((2 * Me.Mprime - 2 * Me.Fphase) * Me.degrad), Math.Sin(3 * Me.Mphase * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((2 * Me.Mprime + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime + Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase + 2 * Me.Fphase) * Me.degrad), Math.Sin((Me.Mprime - Me.Mphase - 2 * Me.Fphase) * Me.degrad), Math.Sin((3 * Me.Mprime + Me.Mphase) * Me.degrad), Math.Sin(4 * Me.Mprime * Me.degrad) }
			Me.Correction(1, 1) = -0.40614 * Me.Facteur(1)
			Me.Correction(1, 2) = 0.17302 * Me.Facteur(2)
			Me.Correction(1, 3) = 0.01614 * Me.Facteur(3)
			Me.Correction(1, 4) = 0.01043 * Me.Facteur(4)
			Me.Correction(1, 5) = 0.00734 * Me.Facteur(5)
			Me.Correction(1, 6) = -0.00515 * Me.Facteur(6)
			Me.Correction(1, 7) = 0.00209 * Me.Facteur(7)
			Me.Correction(1, 8) = 0.00111 * Me.Facteur(8)
			Me.Correction(1, 9) = -0.00057 * Me.Facteur(9)
			Me.Correction(1, 10) = 0.00056 * Me.Facteur(10)
			Me.Correction(1, 11) = -0.00042 * Me.Facteur(11)
			Me.Correction(1, 12) = 0.00042 * Me.Facteur(12)
			Me.Correction(1, 13) = 0.00038 * Me.Facteur(13)
			Me.Correction(1, 14) = -0.00024 * Me.Facteur(14)
			Me.Correction(1, 15) = -0.00017 * Me.Facteur(15)
			Me.Correction(1, 16) = -7E-05 * Me.Facteur(16)
			Me.Correction(1, 17) = 4E-05 * Me.Facteur(17)
			Me.Correction(1, 18) = 4E-05 * Me.Facteur(18)
			Me.Correction(1, 19) = 3E-05 * Me.Facteur(19)
			Me.Correction(1, 20) = 3E-05 * Me.Facteur(20)
			Me.Correction(1, 21) = -3E-05 * Me.Facteur(21)
			Me.Correction(1, 22) = 3E-05 * Me.Facteur(22)
			Me.Correction(1, 23) = -2E-05 * Me.Facteur(23)
			Me.Correction(1, 24) = -2E-05 * Me.Facteur(24)
			Me.Correction(1, 25) = 2E-05 * Me.Facteur(25)
			Me.S1 = 0
			Dim num18 As Integer = 1
			Do
				Me.S1 += Me.Aphase(1, num18)
				num18 = num18 + 1
			Loop While num18 <= 14
			Me.S2 = 0
			Dim num19 As Integer = 1
			Do
				Me.S2 += Me.Correction(1, num19)
				num19 = num19 + 1
			Loop While num19 <= 25
			Me.MJDmois(13) = Me.JDEphase + Me.S1 + Me.S2 - 2400000.5
			Me.Correction = Nothing
			Me.Facteur = Nothing
			Me.Aphase = Nothing
			Me.Kapprg = Conversion.Int((CDbl(Me.Arg(1).Year) + CDbl(Me.Arg(1).Month) / 12 - 1999.97) * 13.2555)
			Me.Tapprg = Me.Kapprg / 1325.55
			Me.D = (171.9179 + 335.9106046 * Me.Kapprg - 0.010025 * Math.Pow(Me.Tapprg, 2) - 1.156E-05 * Math.Pow(Me.Tapprg, 3) + 5.5E-08 * Math.Pow(Me.Tapprg, 4)) Mod 360
			Me.Mapprg = (347.3477 + 27.1577721 * Me.Kapprg - 0.0008323 * Math.Pow(Me.Tapprg, 2) - 1E-06 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.Fapprg = (316.6109 + 364.5287911 * Me.Kapprg - 0.0125131 * Math.Pow(Me.Tapprg, 2) - 1.48E-05 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.JDEapprg = 2451534.6698 + 27.55454988 * Me.Kapprg - 0.0006886 * Math.Pow(Me.Tapprg, 2) - 1.098E-06 * Math.Pow(Me.Tapprg, 3) + 5.2E-09 * Math.Pow(Me.Tapprg, 4)
			Me.Aprg = New Double() { Nothing, -1.6769 * Math.Sin(2 * Me.D * Me.degrad), 0.4589 * Math.Sin(4 * Me.D * Me.degrad), -0.1856 * Math.Sin(6 * Me.D * Me.degrad), 0.0883 * Math.Sin(8 * Me.D * Me.degrad), (-0.0773 + 0.00019 * Me.Tapprg) * Math.Sin((2 * Me.D - Me.Mapprg) * Me.degrad), (0.0502 - 0.00013 * Me.Tapprg) * Math.Sin(Me.Mapprg * Me.degrad), -0.046 * Math.Sin(10 * Me.D * Me.degrad), (0.0422 - 0.00011 * Me.Tapprg) * Math.Sin((4 * Me.D - Me.Mapprg) * Me.degrad), -0.0256 * Math.Sin((6 * Me.D - Me.Mapprg) * Me.degrad), 0.0253 * Math.Sin(12 * Me.D * Me.degrad), 0.0237 * Math.Sin(Me.D * Me.degrad), 0.0162 * Math.Sin((8 * Me.D - Me.Mapprg) * Me.degrad), -0.0145 * Math.Sin(14 * Me.D * Me.degrad), 0.0129 * Math.Sin(2 * Me.Fapprg * Me.degrad), -0.0112 * Math.Sin(3 * Me.D * Me.degrad), -0.0104 * Math.Sin((10 * Me.D - Me.Mapprg) * Me.degrad), 0.0086 * Math.Sin(16 * Me.D * Me.degrad), 0.0069 * Math.Sin((12 * Me.D - Me.Mapprg) * Me.degrad), 0.0066 * Math.Sin(5 * Me.D * Me.degrad), -0.0053 * Math.Sin((2 * Me.D + 2 * Me.Fapprg) * Me.degrad), -0.0052 * Math.Sin(18 * Me.D * Me.degrad), -0.0046 * Math.Sin((14 * Me.D - Me.Mapprg) * Me.degrad), -0.0041 * Math.Sin(7 * Me.D * Me.degrad), 0.004 * Math.Sin((2 * Me.D + Me.Mapprg) * Me.degrad), 0.0032 * Math.Sin(20 * Me.D * Me.degrad), -0.0032 * Math.Sin((Me.D + Me.Mapprg) * Me.degrad), 0.0031 * Math.Sin((16 * Me.D - Me.Mapprg) * Me.degrad), -0.0029 * Math.Sin((4 * Me.D + Me.Mapprg) * Me.degrad), 0.0027 * Math.Sin(9 * Me.D * Me.degrad), 0.0027 * Math.Sin((4 * Me.D + 2 * Me.Fapprg) * Me.degrad), -0.0027 * Math.Sin((2 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0024 * Math.Sin((4 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0021 * Math.Sin((6 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0021 * Math.Sin(22 * Me.D * Me.degrad), -0.0021 * Math.Sin((18 * Me.D - Me.Mapprg) * Me.degrad), 0.0019 * Math.Sin((6 * Me.D + Me.Mapprg) * Me.degrad), 0.0018 * Math.Sin(11 * Me.D * Me.degrad), -0.0014 * Math.Sin((8 * Me.D + Me.Mapprg) * Me.degrad), -0.0014 * Math.Sin((4 * Me.D - 2 * Me.Fapprg) * Me.degrad), -0.0014 * Math.Sin((6 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0014 * Math.Sin((3 * Me.D + Me.Mapprg) * Me.degrad), -0.0014 * Math.Sin((5 * Me.D + Me.Mapprg) * Me.degrad), 0.0013 * Math.Sin(13 * Me.D * Me.degrad), 0.0013 * Math.Sin((20 * Me.D - Me.Mapprg) * Me.degrad), 0.0011 * Math.Sin((3 * Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0011 * Math.Sin((4 * Me.D + 2 * Me.Fapprg - 2 * Me.Mapprg) * Me.degrad), 0.001 * Math.Sin((Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0009 * Math.Sin((22 * Me.D - Me.Mapprg) * Me.degrad), -0.0008 * Math.Sin(4 * Me.Fapprg * Me.degrad), 0.0008 * Math.Sin((6 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0008 * Math.Sin((2 * Me.D - 2 * Me.Fapprg + Me.Mapprg) * Me.degrad), 0.0007 * Math.Sin(2 * Me.Mapprg * Me.degrad), 0.0007 * Math.Sin((2 * Me.Fapprg - Me.Mapprg) * Me.degrad), 0.0007 * Math.Sin((2 * Me.D + 4 * Me.Fapprg) * Me.degrad), -0.0006 * Math.Sin((2 * Me.Fapprg - 2 * Me.Mapprg) * Me.degrad), -0.0006 * Math.Sin((2 * Me.D - 2 * Me.Fapprg + 2 * Me.Mapprg) * Me.degrad), 0.0006 * Math.Sin(24 * Me.D * Me.degrad), 0.0005 * Math.Sin((4 * Me.D - 4 * Me.Fapprg) * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + 2 * Me.Mapprg) * Me.degrad), -0.0004 * Math.Sin((Me.D - Me.Mapprg) * Me.degrad) }
			Me.S1 = 0
			Dim num20 As Integer = 1
			Do
				Me.S1 += Me.Aprg(num20)
				num20 = num20 + 1
			Loop While num20 <= 60
			Me.MJDmois(14) = Me.JDEapprg + Me.S1 - 2400000.5
			Me.Aprg = Nothing
			Me.Kapprg += 0.5
			Me.Tapprg = Me.Kapprg / 1325.55
			Me.D = (171.9179 + 335.9106046 * Me.Kapprg - 0.010025 * Math.Pow(Me.Tapprg, 2) - 1.156E-05 * Math.Pow(Me.Tapprg, 3) + 5.5E-08 * Math.Pow(Me.Tapprg, 4)) Mod 360
			Me.Mapprg = (347.3477 + 27.1577721 * Me.Kapprg - 0.0008323 * Math.Pow(Me.Tapprg, 2) - 1E-06 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.Fapprg = (316.6109 + 364.5287911 * Me.Kapprg - 0.0125131 * Math.Pow(Me.Tapprg, 2) - 1.48E-05 * Math.Pow(Me.Tapprg, 3)) Mod 360
			Me.JDEapprg = 2451534.6698 + 27.55454988 * Me.Kapprg - 0.0006886 * Math.Pow(Me.Tapprg, 2) - 1.098E-06 * Math.Pow(Me.Tapprg, 3) + 5.2E-09 * Math.Pow(Me.Tapprg, 4)
			Me.Aap = New Double() { Nothing, 0.4392 * Math.Sin(2 * Me.D * Me.degrad), 0.0684 * Math.Sin(4 * Me.D * Me.degrad), (0.0456 - 0.00011 * Me.Tapprg) * Math.Sin(Me.Mapprg * Me.degrad), (0.0426 - 0.00011 * Me.Tapprg) * Math.Sin((2 * Me.D - Me.Mapprg) * Me.degrad), 0.0212 * Math.Sin(2 * Me.Fapprg * Me.degrad), -0.0189 * Math.Sin(Me.D * Me.degrad), 0.0144 * Math.Sin(6 * Me.D * Me.degrad), 0.0113 * Math.Sin((4 * Me.D - Me.Mapprg) * Me.degrad), 0.0047 * Math.Sin((2 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0036 * Math.Sin((Me.D + Me.Mapprg) * Me.degrad), 0.0035 * Math.Sin(8 * Me.D * Me.degrad), 0.0034 * Math.Sin((6 * Me.D - Me.Mapprg) * Me.degrad), -0.0034 * Math.Sin((2 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0022 * Math.Sin((2 * Me.D - 2 * Me.Mapprg) * Me.degrad), -0.0017 * Math.Sin(3 * Me.D * Me.degrad), 0.0013 * Math.Sin((4 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0011 * Math.Sin((8 * Me.D - Me.Mapprg) * Me.degrad), 0.001 * Math.Sin((4 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0009 * Math.Sin(10 * Me.D * Me.degrad), 0.0007 * Math.Sin((3 * Me.D + Me.Mapprg) * Me.degrad), 0.0006 * Math.Sin(2 * Me.Mapprg * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + Me.Mapprg) * Me.degrad), 0.0005 * Math.Sin((2 * Me.D + 2 * Me.Mapprg) * Me.degrad), 0.0004 * Math.Sin((6 * Me.D + 2 * Me.Fapprg) * Me.degrad), 0.0004 * Math.Sin((6 * Me.D - 2 * Me.Mapprg) * Me.degrad), 0.0004 * Math.Sin((10 * Me.D - Me.Mapprg) * Me.degrad), -0.0004 * Math.Sin(5 * Me.D * Me.degrad), -0.0004 * Math.Sin((4 * Me.D - 2 * Me.Fapprg) * Me.degrad), 0.0003 * Math.Sin((2 * Me.Fapprg + Me.Mapprg) * Me.degrad), 0.0003 * Math.Sin(12 * Me.D * Me.degrad), 0.0003 * Math.Sin((2 * Me.D + 2 * Me.Fapprg - Me.Mapprg) * Me.degrad), -0.0003 * Math.Sin((Me.D - Me.Mapprg) * Me.degrad) }
			Me.S1 = 0
			Dim num21 As Integer = 1
			Do
				Me.S1 += Me.Aap(num21)
				num21 = num21 + 1
			Loop While num21 <= 32
			Me.MJDmois(15) = Me.JDEapprg + Me.S1 - 2400000.5
			Me.Aap = Nothing
			Me.Kne = Conversion.Int((CDbl(Me.Arg(2).Year) + CDbl(Me.Arg(2).Month) / 12 - 2000.05) * 13.4223)
			Me.Tne = Me.Kne / 1342.23
			Me.Dne = (183.638 + 331.73735691 * Me.Kne + 0.0015057 * Math.Pow(Me.Tne, 2) + 2.09E-06 * Math.Pow(Me.Tne, 3) - 1E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Mne = (17.4006 + 26.8203725 * Me.Kne + 9.99E-05 * Math.Pow(Me.Tne, 2) + 6E-08 * Math.Pow(Me.Tne, 3)) Mod 360
			Me.Mprimene = (38.3776 + 355.52747322 * Me.Kne + 0.0123577 * Math.Pow(Me.Tne, 2) + 1.4628E-05 * Math.Pow(Me.Tne, 3) - 6.9E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Ohmegane = (123.9767 - 1.44098949 * Me.Kne + 0.0020625 * Math.Pow(Me.Tne, 2) + 2.14E-06 * Math.Pow(Me.Tne, 3) - 1.6E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.V = (299.75 + 132.85 * Me.Tne - 0.009173 * Math.Pow(Me.Tne, 2)) Mod 360
			Me.P = (Me.Ohmegane + 272.75 - 2.3 * Me.Tne) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tne - 7.4E-06 * Math.Pow(Me.Tne, 2)
			Me.JDEne = 2451565.1619 + 27.212220817 * Me.Kne + 0.0002572 * Math.Pow(Me.Tne, 2) + 2.1E-08 * Math.Pow(Me.Tne, 3) - 8.8E-11 * Math.Pow(Me.Tne, 4)
			Me.Ane = New Double() { Nothing, -0.4721 * Math.Sin(Me.Mprimene * Me.degrad), -0.1649 * Math.Sin(2 * Me.Dne * Me.degrad), -0.0868 * Math.Sin((2 * Me.Dne - Me.Mprimene) * Me.degrad), 0.0084 * Math.Sin((2 * Me.Dne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0083 * Math.Sin((2 * Me.Dne - Me.Mne) * Me.degrad), Me.Eprime * -0.0039 * Math.Sin((2 * Me.Dne - Me.Mne - Me.Mprimene) * Me.degrad), 0.0034 * Math.Sin(2 * Me.Mprimene * Me.degrad), -0.0031 * Math.Sin((2 * Me.Dne - 2 * Me.Mprimene) * Me.degrad), Me.Eprime * 0.003 * Math.Sin((2 * Me.Dne + Me.Mne) * Me.degrad), Me.Eprime * 0.0028 * Math.Sin((Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0026 * Math.Sin(Me.Mne * Me.degrad), 0.0025 * Math.Sin(4 * Me.Dne * Me.degrad), 0.0024 * Math.Sin(Me.Dne * Me.degrad), Me.Eprime * 0.0022 * Math.Sin((Me.Mne + Me.Mprimene) * Me.degrad), 0.0017 * Math.Sin(Me.Ohmegane * Me.degrad), 0.0014 * Math.Sin((4 * Me.Dne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0005 * Math.Sin((2 * Me.Dne + Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0004 * Math.Sin((2 * Me.Dne - Me.Mne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0003 * Math.Sin((2 * Me.Dne - 2 * Me.Mne) * Me.degrad), Me.Eprime * 0.0003 * Math.Sin((4 * Me.Dne - Me.Mne) * Me.degrad), 0.0003 * Math.Sin(Me.V * Me.degrad), 0.0003 * Math.Sin(Me.P * Me.degrad) }
			Me.S1 = 0
			Dim num22 As Integer = 1
			Do
				Me.S1 += Me.Ane(num22)
				num22 = num22 + 1
			Loop While num22 <= 22
			Me.MJDmois(16) = Me.JDEne + Me.S1 - 2400000.5
			Me.Kne += 0.5
			Me.Tne = Me.Kne / 1342.23
			Me.Dne = (183.638 + 331.73735691 * Me.Kne + 0.0015057 * Math.Pow(Me.Tne, 2) + 2.09E-06 * Math.Pow(Me.Tne, 3) - 1E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Mne = (17.4006 + 26.8203725 * Me.Kne + 9.99E-05 * Math.Pow(Me.Tne, 2) + 6E-08 * Math.Pow(Me.Tne, 3)) Mod 360
			Me.Mprimene = (38.3776 + 355.52747322 * Me.Kne + 0.0123577 * Math.Pow(Me.Tne, 2) + 1.4628E-05 * Math.Pow(Me.Tne, 3) - 6.9E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.Ohmegane = (123.9767 - 1.44098949 * Me.Kne + 0.0020625 * Math.Pow(Me.Tne, 2) + 2.14E-06 * Math.Pow(Me.Tne, 3) - 1.6E-08 * Math.Pow(Me.Tne, 4)) Mod 360
			Me.V = (299.75 + 132.85 * Me.Tne - 0.009173 * Math.Pow(Me.Tne, 2)) Mod 360
			Me.P = (Me.Ohmegane + 272.75 - 2.3 * Me.Tne) Mod 360
			Me.Eprime = 1 - 0.002516 * Me.Tne - 7.4E-06 * Math.Pow(Me.Tne, 2)
			Me.JDEne = 2451565.1619 + 27.212220817 * Me.Kne + 0.0002572 * Math.Pow(Me.Tne, 2) + 2.1E-08 * Math.Pow(Me.Tne, 3) - 8.8E-11 * Math.Pow(Me.Tne, 4)
			Me.Ane = New Double() { Nothing, -0.4721 * Math.Sin(Me.Mprimene * Me.degrad), -0.1649 * Math.Sin(2 * Me.Dne * Me.degrad), -0.0868 * Math.Sin((2 * Me.Dne - Me.Mprimene) * Me.degrad), 0.0084 * Math.Sin((2 * Me.Dne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0083 * Math.Sin((2 * Me.Dne - Me.Mne) * Me.degrad), Me.Eprime * -0.0039 * Math.Sin((2 * Me.Dne - Me.Mne - Me.Mprimene) * Me.degrad), 0.0034 * Math.Sin(2 * Me.Mprimene * Me.degrad), -0.0031 * Math.Sin((2 * Me.Dne - 2 * Me.Mprimene) * Me.degrad), Me.Eprime * 0.003 * Math.Sin((2 * Me.Dne + Me.Mne) * Me.degrad), Me.Eprime * 0.0028 * Math.Sin((Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0026 * Math.Sin(Me.Mne * Me.degrad), 0.0025 * Math.Sin(4 * Me.Dne * Me.degrad), 0.0024 * Math.Sin(Me.Dne * Me.degrad), Me.Eprime * 0.0022 * Math.Sin((Me.Mne + Me.Mprimene) * Me.degrad), 0.0017 * Math.Sin(Me.Ohmegane * Me.degrad), 0.0014 * Math.Sin((4 * Me.Dne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0005 * Math.Sin((2 * Me.Dne + Me.Mne - Me.Mprimene) * Me.degrad), Me.Eprime * 0.0004 * Math.Sin((2 * Me.Dne - Me.Mne + Me.Mprimene) * Me.degrad), Me.Eprime * -0.0003 * Math.Sin((2 * Me.Dne - 2 * Me.Mne) * Me.degrad), Me.Eprime * 0.0003 * Math.Sin((4 * Me.Dne - Me.Mne) * Me.degrad), 0.0003 * Math.Sin(Me.V * Me.degrad), 0.0003 * Math.Sin(Me.P * Me.degrad) }
			Me.S1 = 0
			Dim num23 As Integer = 1
			Do
				Me.S1 += Me.Ane(num23)
				num23 = num23 + 1
			Loop While num23 <= 22
			Me.MJDmois(17) = Me.JDEne + Me.S1 - 2400000.5
			Me.Ane = Nothing
			ReDim Me.Alldate(17)
			Dim num24 As Integer = 0
			Do
				Me.Alldate(num24) = TimeZoneInfo.ConvertTimeFromUtc(Me.referencephase.AddDays(Me.MJDmois(num24)), TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"))
				num24 = num24 + 1
			Loop While num24 <= 17
			Me.compt = 0
			Me.empty0 = True
			Dim num25 As Integer = 0
			Do
				If (Me.Alldate(num25).Month = Me.Arg(0).Month) Then
					Me.NL = DirectCast(Utils.CopyArray(DirectCast(Me.NL, Array), New DateTime(Me.compt + 1 - 1) {}), DateTime())
					Me.NL(Me.compt) = Me.Alldate(num25)
					Me.compt = Me.compt + 1
				End If
				num25 = num25 + 6
			Loop While num25 <= 17
			If (Me.compt = 0) Then
				Me.empty0 = True
			End If
			Me.compt = 0
			Me.empty1 = False
			Dim num26 As Integer = 1
			Do
				If (Me.Alldate(num26).Month = Me.Arg(0).Month) Then
					Me.PL = DirectCast(Utils.CopyArray(DirectCast(Me.PL, Array), New DateTime(Me.compt + 1 - 1) {}), DateTime())
					Me.PL(Me.compt) = Me.Alldate(num26)
					Me.compt = Me.compt + 1
				End If
				num26 = num26 + 6
			Loop While num26 <= 17
			If (Me.compt = 0) Then
				Me.empty1 = True
			End If
			Me.compt = 0
			Me.empty2 = False
			Dim num27 As Integer = 2
			Do
				If (Me.Alldate(num27).Month = Me.Arg(0).Month) Then
					Me.Prg = DirectCast(Utils.CopyArray(DirectCast(Me.Prg, Array), New DateTime(Me.compt + 1 - 1) {}), DateTime())
					Me.Prg(Me.compt) = Me.Alldate(num27)
					Me.compt = Me.compt + 1
				End If
				num27 = num27 + 6
			Loop While num27 <= 17
			If (Me.compt = 0) Then
				Me.empty2 = True
			End If
			Me.compt = 0
			Me.empty3 = False
			Dim num28 As Integer = 3
			Do
				If (Me.Alldate(num28).Month = Me.Arg(0).Month) Then
					Me.Apg = DirectCast(Utils.CopyArray(DirectCast(Me.Apg, Array), New DateTime(Me.compt + 1 - 1) {}), DateTime())
					Me.Apg(Me.compt) = Me.Alldate(num28)
					Me.compt = Me.compt + 1
				End If
				num28 = num28 + 6
			Loop While num28 <= 17
			If (Me.compt = 0) Then
				Me.empty3 = True
			End If
			Me.compt = 0
			Me.empty4 = False
			Dim num29 As Integer = 4
			Do
				If (Me.Alldate(num29).Month = Me.Arg(0).Month) Then
					Me.NEasc = DirectCast(Utils.CopyArray(DirectCast(Me.NEasc, Array), New DateTime(Me.compt + 1 - 1) {}), DateTime())
					Me.NEasc(Me.compt) = Me.Alldate(num29)
					Me.compt = Me.compt + 1
				End If
				num29 = num29 + 6
			Loop While num29 <= 17
			If (Me.compt = 0) Then
				Me.empty4 = True
			End If
			Me.compt = 0
			Me.empty5 = False
			Dim num30 As Integer = 5
			Do
				If (Me.Alldate(num30).Month = Me.Arg(0).Month) Then
					Me.NEdesc = DirectCast(Utils.CopyArray(DirectCast(Me.NEdesc, Array), New DateTime(Me.compt + 1 - 1) {}), DateTime())
					Me.NEdesc(Me.compt) = Me.Alldate(num30)
					Me.compt = Me.compt + 1
				End If
				num30 = num30 + 6
			Loop While num30 <= 17
			If (Me.compt = 0) Then
				Me.empty5 = True
			End If
			Me.Kde = Conversion.Int((CDbl(Me.selection.Year) + CDbl(Me.selection.Month) / 12 - 2000.03) * 13.3686)
			Me.Tde = Me.Kde / 1336.86
			Me.Ddeno = 152.2029 + 333.0705546 * Me.Kde - 0.0004025 * Math.Pow(Me.Tde, 2) + 1.1E-07 * Math.Pow(Me.Tde, 3)
			Me.Ddesu = 345.6676 + 333.0705546 * Me.Kde - 0.0004025 * Math.Pow(Me.Tde, 2) + 1.1E-07 * Math.Pow(Me.Tde, 3)
			Me.Mdeno = 14.8591 + 26.9281592 * Me.Kde - 5.44E-05 * Math.Pow(Me.Tde, 2) - 1E-07 * Math.Pow(Me.Tde, 3)
			Me.Mdesu = 1.3951 + 26.9281592 * Me.Kde - 5.44E-05 * Math.Pow(Me.Tde, 2) - 1E-07 * Math.Pow(Me.Tde, 3)
			Me.Mprimedeno = 4.6881 + 356.9562795 * Me.Kde + 0.0103126 * Math.Pow(Me.Tde, 2) + 1.251E-05 * Math.Pow(Me.Tde, 3)
			Me.Mprimedesu = 186.21 + 356.9562795 * Me.Kde + 0.0103126 * Math.Pow(Me.Tde, 2) + 1.251E-05 * Math.Pow(Me.Tde, 3)
			Me.Fdeno = 325.8867 + 1.4467806 * Me.Kde - 0.0020708 * Math.Pow(Me.Tde, 2) - 2.15E-06 * Math.Pow(Me.Tde, 3)
			Me.Fdesu = 145.1633 + 1.4467806 * Me.Kde - 0.0020708 * Math.Pow(Me.Tde, 2) - 2.15E-06 * Math.Pow(Me.Tde, 3)
			Me.JDEdeno = 2451562.5897 + 27.321582241 * Me.Kde + 0.000100695 * Math.Pow(Me.Tde, 2) - 1.41E-07 * Math.Pow(Me.Tde, 3)
			Me.JDEdesu = 2451548.9289 + 27.321582241 * Me.Kde + 0.000100695 * Math.Pow(Me.Tde, 2) - 1.41E-07 * Math.Pow(Me.Tde, 3)
			Me.Adeno = New Double() { Nothing, 0.8975 * Math.Cos(Me.Fdeno * Me.degrad), -0.4726 * Math.Sin(Me.Mprimedeno * Me.degrad), -0.103 * Math.Sin(2 * Me.Fdeno * Me.degrad), -0.0976 * Math.Sin((2 * Me.Ddeno - Me.Mprimedeno) * Me.degrad), -0.0462 * Math.Cos((Me.Mprimedeno - Me.Fdeno) * Me.degrad), -0.0461 * Math.Cos((Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0438 * Math.Sin(2 * Me.Ddeno * Me.degrad), Me.Eprime * 0.0162 * Math.Sin(Me.Mdeno * Me.degrad), -0.0157 * Math.Cos(3 * Me.Fdeno * Me.degrad), 0.0145 * Math.Sin((Me.Mprimedeno + 2 * Me.Fdeno) * Me.degrad), 0.0136 * Math.Cos((2 * Me.Ddeno - Me.Fdeno) * Me.degrad), -0.0095 * Math.Cos((2 * Me.Ddeno - Me.Mprimedeno - Me.Fdeno) * Me.degrad), -0.0091 * Math.Cos((2 * Me.Ddeno - Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0089 * Math.Cos((2 * Me.Ddeno + Me.Fdeno) * Me.degrad), 0.0075 * Math.Sin(2 * Me.Mprimedeno * Me.degrad), -0.0068 * Math.Sin((Me.Mprimedeno - 2 * Me.Fdeno) * Me.degrad), 0.0061 * Math.Cos((2 * Me.Mprimedeno - Me.Fdeno) * Me.degrad), -0.0047 * Math.Sin((Me.Mprimedeno + 3 * Me.Fdeno) * Me.degrad), Me.Eprime * -0.0043 * Math.Sin((2 * Me.Ddeno - Me.Mdeno - Me.Mprimedeno) * Me.degrad), -0.004 * Math.Cos((Me.Mprimedeno - 2 * Me.Fdeno) * Me.degrad), -0.0037 * Math.Sin((2 * Me.Ddeno - 2 * Me.Mprimedeno) * Me.degrad), 0.0031 * Math.Sin(Me.Fdeno * Me.degrad), 0.003 * Math.Sin((2 * Me.Ddeno + Me.Mprimedeno) * Me.degrad), -0.0029 * Math.Cos((Me.Mprimedeno + 2 * Me.Fdeno) * Me.degrad), Me.Eprime * -0.0029 * Math.Sin((2 * Me.Ddeno - Me.Mdeno) * Me.degrad), -0.0027 * Math.Sin((Me.Mprimedeno + Me.Fdeno) * Me.degrad), Me.Eprime * 0.0024 * Math.Sin((Me.Mdeno - Me.Mprimedeno) * Me.degrad), -0.0021 * Math.Sin((Me.Mprimedeno - 3 * Me.Fdeno) * Me.degrad), 0.0019 * Math.Sin((2 * Me.Mprimedeno + Me.Fdeno) * Me.degrad), 0.0018 * Math.Sin((2 * Me.Ddeno - 2 * Me.Mprimedeno - Me.Fdeno) * Me.degrad), 0.0018 * Math.Sin(3 * Me.Fdeno * Me.degrad), 0.0017 * Math.Cos((Me.Mprimedeno + 3 * Me.Fdeno) * Me.degrad), 0.0017 * Math.Cos(2 * Me.Mprimedeno * Me.degrad), -0.0014 * Math.Cos((2 * Me.Ddeno - Me.Mprimedeno) * Me.degrad), 0.0013 * Math.Cos((2 * Me.Ddeno + Me.Mprimedeno + Me.Fdeno) * Me.degrad), 0.0013 * Math.Cos(Me.Mprimedeno * Me.degrad), 0.0012 * Math.Sin((3 * Me.Mprimedeno + Me.Fdeno) * Me.degrad), 0.0011 * Math.Sin((2 * Me.Ddeno - Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0011 * Math.Cos((2 * Me.Ddeno - 2 * Me.Mprimedeno) * Me.degrad), 0.001 * Math.Cos((Me.Ddeno + Me.Fdeno) * Me.degrad), Me.Eprime * 0.001 * Math.Sin((Me.Mdeno + Me.Mprimedeno) * Me.degrad), -0.0009 * Math.Sin((2 * Me.Ddeno - 2 * Me.Fdeno) * Me.degrad), 0.0007 * Math.Cos((2 * Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0007 * Math.Cos((3 * Me.Mprimedeno + Me.Fdeno) * Me.degrad) }
			Me.Adesu = New Double() { Nothing, -0.8975 * Math.Cos(Me.Fdesu * Me.degrad), -0.4726 * Math.Sin(Me.Mprimedesu * Me.degrad), -0.103 * Math.Sin(2 * Me.Fdesu * Me.degrad), -0.0976 * Math.Sin((2 * Me.Ddesu - Me.Mprimedesu) * Me.degrad), 0.0541 * Math.Cos((Me.Mprimedesu - Me.Fdesu) * Me.degrad), 0.0516 * Math.Cos((Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0438 * Math.Sin(2 * Me.Ddesu * Me.degrad), Me.Eprime * 0.0112 * Math.Sin(Me.Mdesu * Me.degrad), 0.0157 * Math.Cos(3 * Me.Fdesu * Me.degrad), 0.0023 * Math.Sin((Me.Mprimedesu + 2 * Me.Fdesu) * Me.degrad), -0.0136 * Math.Cos((2 * Me.Ddesu - Me.Fdesu) * Me.degrad), 0.011 * Math.Cos((2 * Me.Ddesu - Me.Mprimedesu - Me.Fdesu) * Me.degrad), 0.0091 * Math.Cos((2 * Me.Ddesu - Me.Mprimedesu + Me.Fdesu) * Me.degrad), 0.0089 * Math.Cos((2 * Me.Ddesu + Me.Fdesu) * Me.degrad), 0.0075 * Math.Sin(2 * Me.Mprimedesu * Me.degrad), -0.003 * Math.Sin((Me.Mprimedesu - 2 * Me.Fdesu) * Me.degrad), -0.0061 * Math.Cos((2 * Me.Mprimedesu - Me.Fdesu) * Me.degrad), -0.0047 * Math.Sin((Me.Mprimedesu + 3 * Me.Fdesu) * Me.degrad), Me.Eprime * -0.0043 * Math.Sin((2 * Me.Ddesu - Me.Mdesu - Me.Mprimedesu) * Me.degrad), 0.004 * Math.Cos((Me.Mprimedesu - 2 * Me.Fdesu) * Me.degrad), -0.0037 * Math.Sin((2 * Me.Ddesu - 2 * Me.Mprimedesu) * Me.degrad), -0.0031 * Math.Sin(Me.Fdesu * Me.degrad), 0.003 * Math.Sin((2 * Me.Ddesu + Me.Mprimedesu) * Me.degrad), 0.0029 * Math.Cos((Me.Mprimedesu + 2 * Me.Fdesu) * Me.degrad), Me.Eprime * -0.0029 * Math.Sin((2 * Me.Ddesu - Me.Mdesu) * Me.degrad), -0.0027 * Math.Sin((Me.Mprimedesu + Me.Fdesu) * Me.degrad), Me.Eprime * 0.0024 * Math.Sin((Me.Mdesu - Me.Mprimedesu) * Me.degrad), -0.0021 * Math.Sin((Me.Mprimedesu - 3 * Me.Fdesu) * Me.degrad), -0.0019 * Math.Sin((2 * Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0006 * Math.Sin((2 * Me.Ddesu - 2 * Me.Mprimedesu - Me.Fdesu) * Me.degrad), -0.0018 * Math.Sin(3 * Me.Fdesu * Me.degrad), -0.0017 * Math.Cos((Me.Mprimedesu + 3 * Me.Fdesu) * Me.degrad), 0.0017 * Math.Cos(2 * Me.Mprimedesu * Me.degrad), -0.0014 * Math.Cos((2 * Me.Ddesu - Me.Mprimedesu) * Me.degrad), -0.0013 * Math.Cos((2 * Me.Ddesu + Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0013 * Math.Cos(Me.Mprimedesu * Me.degrad), 0.0012 * Math.Sin((3 * Me.Mprimedesu + Me.Fdesu) * Me.degrad), 0.0011 * Math.Sin((2 * Me.Ddesu - Me.Mprimedesu + Me.Fdesu) * Me.degrad), 0.0011 * Math.Cos((2 * Me.Ddesu - 2 * Me.Mprimedesu) * Me.degrad), 0.001 * Math.Cos((Me.Ddesu + Me.Fdesu) * Me.degrad), Me.Eprime * 0.001 * Math.Sin((Me.Mdesu + Me.Mprimedesu) * Me.degrad), -0.0009 * Math.Sin((2 * Me.Ddesu - 2 * Me.Fdesu) * Me.degrad), -0.0007 * Math.Cos((2 * Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0007 * Math.Cos((3 * Me.Mprimedesu + Me.Fdesu) * Me.degrad) }
			Me.S1 = 0
			Dim num31 As Integer = 1
			Do
				Me.S1 += Me.Adeno(num31)
				num31 = num31 + 1
			Loop While num31 <= 44
			Me.S2 = 0
			Dim num32 As Integer = 1
			Do
				Me.S2 += Me.Adesu(num32)
				num32 = num32 + 1
			Loop While num32 <= 44
			ReDim Me.DENO(1)
			ReDim Me.DESU(1)
			Me.DENO(0) = TimeZoneInfo.ConvertTimeFromUtc(Me.referencephase.AddDays(Me.JDEdeno + Me.S1 - 2400000.5), TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"))
			Me.DESU(0) = TimeZoneInfo.ConvertTimeFromUtc(Me.referencephase.AddDays(Me.JDEdesu + Me.S2 - 2400000.5), TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"))
			Me.Kde = Conversion.Int((CDbl(Me.selection.Year) + CDbl((Me.selection.Month - 1)) / 12 - 2000.03) * 13.3686)
			Me.Tde = Me.Kde / 1336.86
			Me.Ddeno = 152.2029 + 333.0705546 * Me.Kde - 0.0004025 * Math.Pow(Me.Tde, 2) + 1.1E-07 * Math.Pow(Me.Tde, 3)
			Me.Ddesu = 345.6676 + 333.0705546 * Me.Kde - 0.0004025 * Math.Pow(Me.Tde, 2) + 1.1E-07 * Math.Pow(Me.Tde, 3)
			Me.Mdeno = 14.8591 + 26.9281592 * Me.Kde - 5.44E-05 * Math.Pow(Me.Tde, 2) - 1E-07 * Math.Pow(Me.Tde, 3)
			Me.Mdesu = 1.3951 + 26.9281592 * Me.Kde - 5.44E-05 * Math.Pow(Me.Tde, 2) - 1E-07 * Math.Pow(Me.Tde, 3)
			Me.Mprimedeno = 4.6881 + 356.9562795 * Me.Kde + 0.0103126 * Math.Pow(Me.Tde, 2) + 1.251E-05 * Math.Pow(Me.Tde, 3)
			Me.Mprimedesu = 186.21 + 356.9562795 * Me.Kde + 0.0103126 * Math.Pow(Me.Tde, 2) + 1.251E-05 * Math.Pow(Me.Tde, 3)
			Me.Fdeno = 325.8867 + 1.4467806 * Me.Kde - 0.0020708 * Math.Pow(Me.Tde, 2) - 2.15E-06 * Math.Pow(Me.Tde, 3)
			Me.Fdesu = 145.1633 + 1.4467806 * Me.Kde - 0.0020708 * Math.Pow(Me.Tde, 2) - 2.15E-06 * Math.Pow(Me.Tde, 3)
			Me.JDEdeno = 2451562.5897 + 27.321582241 * Me.Kde + 0.000100695 * Math.Pow(Me.Tde, 2) - 1.41E-07 * Math.Pow(Me.Tde, 3)
			Me.JDEdesu = 2451548.9289 + 27.321582241 * Me.Kde + 0.000100695 * Math.Pow(Me.Tde, 2) - 1.41E-07 * Math.Pow(Me.Tde, 3)
			Me.Adeno = New Double() { Nothing, 0.8975 * Math.Cos(Me.Fdeno * Me.degrad), -0.4726 * Math.Sin(Me.Mprimedeno * Me.degrad), -0.103 * Math.Sin(2 * Me.Fdeno * Me.degrad), -0.0976 * Math.Sin((2 * Me.Ddeno - Me.Mprimedeno) * Me.degrad), -0.0462 * Math.Cos((Me.Mprimedeno - Me.Fdeno) * Me.degrad), -0.0461 * Math.Cos((Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0438 * Math.Sin(2 * Me.Ddeno * Me.degrad), Me.Eprime * 0.0162 * Math.Sin(Me.Mdeno * Me.degrad), -0.0157 * Math.Cos(3 * Me.Fdeno * Me.degrad), 0.0145 * Math.Sin((Me.Mprimedeno + 2 * Me.Fdeno) * Me.degrad), 0.0136 * Math.Cos((2 * Me.Ddeno - Me.Fdeno) * Me.degrad), -0.0095 * Math.Cos((2 * Me.Ddeno - Me.Mprimedeno - Me.Fdeno) * Me.degrad), -0.0091 * Math.Cos((2 * Me.Ddeno - Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0089 * Math.Cos((2 * Me.Ddeno + Me.Fdeno) * Me.degrad), 0.0075 * Math.Sin(2 * Me.Mprimedeno * Me.degrad), -0.0068 * Math.Sin((Me.Mprimedeno - 2 * Me.Fdeno) * Me.degrad), 0.0061 * Math.Cos((2 * Me.Mprimedeno - Me.Fdeno) * Me.degrad), -0.0047 * Math.Sin((Me.Mprimedeno + 3 * Me.Fdeno) * Me.degrad), Me.Eprime * -0.0043 * Math.Sin((2 * Me.Ddeno - Me.Mdeno - Me.Mprimedeno) * Me.degrad), -0.004 * Math.Cos((Me.Mprimedeno - 2 * Me.Fdeno) * Me.degrad), -0.0037 * Math.Sin((2 * Me.Ddeno - 2 * Me.Mprimedeno) * Me.degrad), 0.0031 * Math.Sin(Me.Fdeno * Me.degrad), 0.003 * Math.Sin((2 * Me.Ddeno + Me.Mprimedeno) * Me.degrad), -0.0029 * Math.Cos((Me.Mprimedeno + 2 * Me.Fdeno) * Me.degrad), Me.Eprime * -0.0029 * Math.Sin((2 * Me.Ddeno - Me.Mdeno) * Me.degrad), -0.0027 * Math.Sin((Me.Mprimedeno + Me.Fdeno) * Me.degrad), Me.Eprime * 0.0024 * Math.Sin((Me.Mdeno - Me.Mprimedeno) * Me.degrad), -0.0021 * Math.Sin((Me.Mprimedeno - 3 * Me.Fdeno) * Me.degrad), 0.0019 * Math.Sin((2 * Me.Mprimedeno + Me.Fdeno) * Me.degrad), 0.0018 * Math.Sin((2 * Me.Ddeno - 2 * Me.Mprimedeno - Me.Fdeno) * Me.degrad), 0.0018 * Math.Sin(3 * Me.Fdeno * Me.degrad), 0.0017 * Math.Cos((Me.Mprimedeno + 3 * Me.Fdeno) * Me.degrad), 0.0017 * Math.Cos(2 * Me.Mprimedeno * Me.degrad), -0.0014 * Math.Cos((2 * Me.Ddeno - Me.Mprimedeno) * Me.degrad), 0.0013 * Math.Cos((2 * Me.Ddeno + Me.Mprimedeno + Me.Fdeno) * Me.degrad), 0.0013 * Math.Cos(Me.Mprimedeno * Me.degrad), 0.0012 * Math.Sin((3 * Me.Mprimedeno + Me.Fdeno) * Me.degrad), 0.0011 * Math.Sin((2 * Me.Ddeno - Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0011 * Math.Cos((2 * Me.Ddeno - 2 * Me.Mprimedeno) * Me.degrad), 0.001 * Math.Cos((Me.Ddeno + Me.Fdeno) * Me.degrad), Me.Eprime * 0.001 * Math.Sin((Me.Mdeno + Me.Mprimedeno) * Me.degrad), -0.0009 * Math.Sin((2 * Me.Ddeno - 2 * Me.Fdeno) * Me.degrad), 0.0007 * Math.Cos((2 * Me.Mprimedeno + Me.Fdeno) * Me.degrad), -0.0007 * Math.Cos((3 * Me.Mprimedeno + Me.Fdeno) * Me.degrad) }
			Me.Adesu = New Double() { Nothing, -0.8975 * Math.Cos(Me.Fdesu * Me.degrad), -0.4726 * Math.Sin(Me.Mprimedesu * Me.degrad), -0.103 * Math.Sin(2 * Me.Fdesu * Me.degrad), -0.0976 * Math.Sin((2 * Me.Ddesu - Me.Mprimedesu) * Me.degrad), 0.0541 * Math.Cos((Me.Mprimedesu - Me.Fdesu) * Me.degrad), 0.0516 * Math.Cos((Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0438 * Math.Sin(2 * Me.Ddesu * Me.degrad), Me.Eprime * 0.0112 * Math.Sin(Me.Mdesu * Me.degrad), 0.0157 * Math.Cos(3 * Me.Fdesu * Me.degrad), 0.0023 * Math.Sin((Me.Mprimedesu + 2 * Me.Fdesu) * Me.degrad), -0.0136 * Math.Cos((2 * Me.Ddesu - Me.Fdesu) * Me.degrad), 0.011 * Math.Cos((2 * Me.Ddesu - Me.Mprimedesu - Me.Fdesu) * Me.degrad), 0.0091 * Math.Cos((2 * Me.Ddesu - Me.Mprimedesu + Me.Fdesu) * Me.degrad), 0.0089 * Math.Cos((2 * Me.Ddesu + Me.Fdesu) * Me.degrad), 0.0075 * Math.Sin(2 * Me.Mprimedesu * Me.degrad), -0.003 * Math.Sin((Me.Mprimedesu - 2 * Me.Fdesu) * Me.degrad), -0.0061 * Math.Cos((2 * Me.Mprimedesu - Me.Fdesu) * Me.degrad), -0.0047 * Math.Sin((Me.Mprimedesu + 3 * Me.Fdesu) * Me.degrad), Me.Eprime * -0.0043 * Math.Sin((2 * Me.Ddesu - Me.Mdesu - Me.Mprimedesu) * Me.degrad), 0.004 * Math.Cos((Me.Mprimedesu - 2 * Me.Fdesu) * Me.degrad), -0.0037 * Math.Sin((2 * Me.Ddesu - 2 * Me.Mprimedesu) * Me.degrad), -0.0031 * Math.Sin(Me.Fdesu * Me.degrad), 0.003 * Math.Sin((2 * Me.Ddesu + Me.Mprimedesu) * Me.degrad), 0.0029 * Math.Cos((Me.Mprimedesu + 2 * Me.Fdesu) * Me.degrad), Me.Eprime * -0.0029 * Math.Sin((2 * Me.Ddesu - Me.Mdesu) * Me.degrad), -0.0027 * Math.Sin((Me.Mprimedesu + Me.Fdesu) * Me.degrad), Me.Eprime * 0.0024 * Math.Sin((Me.Mdesu - Me.Mprimedesu) * Me.degrad), -0.0021 * Math.Sin((Me.Mprimedesu - 3 * Me.Fdesu) * Me.degrad), -0.0019 * Math.Sin((2 * Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0006 * Math.Sin((2 * Me.Ddesu - 2 * Me.Mprimedesu - Me.Fdesu) * Me.degrad), -0.0018 * Math.Sin(3 * Me.Fdesu * Me.degrad), -0.0017 * Math.Cos((Me.Mprimedesu + 3 * Me.Fdesu) * Me.degrad), 0.0017 * Math.Cos(2 * Me.Mprimedesu * Me.degrad), -0.0014 * Math.Cos((2 * Me.Ddesu - Me.Mprimedesu) * Me.degrad), -0.0013 * Math.Cos((2 * Me.Ddesu + Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0013 * Math.Cos(Me.Mprimedesu * Me.degrad), 0.0012 * Math.Sin((3 * Me.Mprimedesu + Me.Fdesu) * Me.degrad), 0.0011 * Math.Sin((2 * Me.Ddesu - Me.Mprimedesu + Me.Fdesu) * Me.degrad), 0.0011 * Math.Cos((2 * Me.Ddesu - 2 * Me.Mprimedesu) * Me.degrad), 0.001 * Math.Cos((Me.Ddesu + Me.Fdesu) * Me.degrad), Me.Eprime * 0.001 * Math.Sin((Me.Mdesu + Me.Mprimedesu) * Me.degrad), -0.0009 * Math.Sin((2 * Me.Ddesu - 2 * Me.Fdesu) * Me.degrad), -0.0007 * Math.Cos((2 * Me.Mprimedesu + Me.Fdesu) * Me.degrad), -0.0007 * Math.Cos((3 * Me.Mprimedesu + Me.Fdesu) * Me.degrad) }
			Me.S1 = 0
			Dim num33 As Integer = 1
			Do
				Me.S1 += Me.Adeno(num33)
				num33 = num33 + 1
			Loop While num33 <= 44
			Me.S2 = 0
			Dim num34 As Integer = 1
			Do
				Me.S2 += Me.Adesu(num34)
				num34 = num34 + 1
			Loop While num34 <= 44
			Me.DENO(1) = TimeZoneInfo.ConvertTimeFromUtc(Me.referencephase.AddDays(Me.JDEdeno + Me.S1 - 2400000.5), TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"))
			Me.DESU(1) = TimeZoneInfo.ConvertTimeFromUtc(Me.referencephase.AddDays(Me.JDEdesu + Me.S2 - 2400000.5), TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"))
		End Sub

		Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			Dim labelArray As Label(,)
			Dim num As Integer
			Dim num1 As Integer
			Me.numnouvellelune = 0
			If (Not Me.empty0) Then
				Dim length As Integer = CInt(Me.NL.Length) - 1
				For i As Integer = 0 To length Step 1
					Dim num2 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					Dim num3 As Integer = 1
					While num3 <= num2
						If (Me.NL(i).Day <> num3) Then
							num3 = num3 + 1
						ElseIf (Not LikeOperator.LikeString(Me.euphemerides(0, num3).Text, "Nouvelle Lune*", CompareMethod.Binary)) Then
							If (Operators.CompareString(Me.euphemerides(0, num3).Text, "", False) <> 0) Then
								labelArray = Me.euphemerides
								num = 0
								num1 = num3
								labelArray(num, num1).Text = String.Concat(labelArray(num, num1).Text, "" & VbCrLf & "")
							End If
							labelArray = Me.euphemerides
							num1 = 0
							num = num3
							labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "Nouvelle Lune  ", Me.NL(i).ToString("(HH:mm)"))
							Me.euphemerides(0, num3).ForeColor = Color.RoyalBlue
							Me.numnouvellelune = num3
							Exit While
						Else
							Exit While
						End If
					End While
				Next

			End If
			If (Not Me.empty1) Then
				Dim length1 As Integer = CInt(Me.PL.Length) - 1
				For j As Integer = 0 To length1 Step 1
					Dim num4 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					Dim num5 As Integer = 1
					While num5 <= num4
						If (Me.PL(j).Day <> num5) Then
							num5 = num5 + 1
						ElseIf (Not LikeOperator.LikeString(Me.euphemerides(0, num5).Text, "Pleine Lune*", CompareMethod.Binary)) Then
							If (Operators.CompareString(Me.euphemerides(0, num5).Text, "", False) <> 0) Then
								labelArray = Me.euphemerides
								num1 = 0
								num = num5
								labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "" & VbCrLf & "")
							End If
							labelArray = Me.euphemerides
							num1 = 0
							num = num5
							labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "Pleine Lune  ", Me.PL(j).ToString("(HH:mm)"))
							Me.euphemerides(0, num5).ForeColor = Color.RoyalBlue
							Exit While
						Else
							Exit While
						End If
					End While
				Next

			End If
			If (Not Me.empty2) Then
				Dim length2 As Integer = CInt(Me.Prg.Length) - 1
				For k As Integer = 0 To length2 Step 1
					Dim num6 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					Dim num7 As Integer = 1
					While num7 <= num6
						If (Me.Prg(k).Day <> num7) Then
							num7 = num7 + 1
						ElseIf (Not LikeOperator.LikeString(Me.euphemerides(0, num7).Text, "Périgée*", CompareMethod.Binary)) Then
							If (Operators.CompareString(Me.euphemerides(0, num7).Text, "", False) <> 0) Then
								labelArray = Me.euphemerides
								num1 = 0
								num = num7
								labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "" & VbCrLf & "")
							End If
							labelArray = Me.euphemerides
							num1 = 0
							num = num7
							labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "Périgée  ", Me.Prg(k).ToString("(HH:mm)"))
							Me.euphemerides(0, num7).ForeColor = Color.Red
							Exit While
						Else
							Exit While
						End If
					End While
				Next

			End If
			If (Not Me.empty3) Then
				Dim length3 As Integer = CInt(Me.Apg.Length) - 1
				For l As Integer = 0 To length3 Step 1
					Dim num8 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					Dim num9 As Integer = 1
					While num9 <= num8
						If (Me.Apg(l).Day <> num9) Then
							num9 = num9 + 1
						ElseIf (Not LikeOperator.LikeString(Me.euphemerides(0, num9).Text, "Apogée*", CompareMethod.Binary)) Then
							If (Operators.CompareString(Me.euphemerides(0, num9).Text, "", False) <> 0) Then
								labelArray = Me.euphemerides
								num1 = 0
								num = num9
								labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "" & VbCrLf & "")
							End If
							labelArray = Me.euphemerides
							num1 = 0
							num = num9
							labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "Apogée  ", Me.Apg(l).ToString("(HH:mm)"))
							Me.euphemerides(0, num9).ForeColor = Color.Red
							Exit While
						Else
							Exit While
						End If
					End While
				Next

			End If
			If (Not Me.empty4) Then
				Dim length4 As Integer = CInt(Me.NEasc.Length) - 1
				For m As Integer = 0 To length4 Step 1
					Dim num10 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					Dim num11 As Integer = 1
					While num11 <= num10
						If (Me.NEasc(m).Day <> num11) Then
							num11 = num11 + 1
						ElseIf (Not LikeOperator.LikeString(Me.euphemerides(0, num11).Text, "Noeud*", CompareMethod.Binary)) Then
							If (Operators.CompareString(Me.euphemerides(0, num11).Text, "", False) <> 0) Then
								labelArray = Me.euphemerides
								num1 = 0
								num = num11
								labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "" & VbCrLf & "")
							End If
							labelArray = Me.euphemerides
							num1 = 0
							num = num11
							labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "Noeud ascendant  ", Me.NEasc(m).ToString("(HH:mm)"))
							Me.euphemerides(0, num11).ForeColor = Color.Red
							Exit While
						Else
							Exit While
						End If
					End While
				Next

			End If
			If (Not Me.empty5) Then
				Dim length5 As Integer = CInt(Me.NEdesc.Length) - 1
				For n As Integer = 0 To length5 Step 1
					Dim num12 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					Dim num13 As Integer = 1
					While num13 <= num12
						If (Me.NEdesc(n).Day <> num13) Then
							num13 = num13 + 1
						ElseIf (Not LikeOperator.LikeString(Me.euphemerides(0, num13).Text, "Noeud*", CompareMethod.Binary)) Then
							If (Operators.CompareString(Me.euphemerides(0, num13).Text, "", False) <> 0) Then
								labelArray = Me.euphemerides
								num1 = 0
								num = num13
								labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "" & VbCrLf & "")
							End If
							labelArray = Me.euphemerides
							num1 = 0
							num = num13
							labelArray(num1, num).Text = String.Concat(labelArray(num1, num).Text, "Noeud descendant  ", Me.NEdesc(n).ToString("(HH:mm)"))
							Me.euphemerides(0, num13).ForeColor = Color.Red
							Exit While
						Else
							Exit While
						End If
					End While
				Next

			End If
			Me.compt = 28 - Me.numnouvellelune
			If (Me.compt < 0) Then
				Me.compt = 28 + Me.compt
			End If
			Dim num14 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num15 As Integer = 1
			Do
				Me.phase(1, num15).Image = Me.imagephase(Me.compt)
				Me.compt = Me.compt + 1
				If (Me.compt = 29) Then
					Me.compt = 0
				End If
				num15 = num15 + 1
			Loop While num15 <= num14
			Me.compt = 0
			Dim num16 As Integer = 0
			Do
				If (Me.DENO(num16).Month = Me.selection.Month) Then
					Me.DECLINAISONS = DirectCast(Utils.CopyArray(DirectCast(Me.DECLINAISONS, Array), New Integer(Me.compt + 1 - 1) {}), Integer())
					Me.DECLINAISONS(Me.compt) = Me.DENO(num16).Day
					Me.compt = Me.compt + 1
				End If
				If (Me.DESU(num16).Month = Me.selection.Month) Then
					Me.DECLINAISONS = DirectCast(Utils.CopyArray(DirectCast(Me.DECLINAISONS, Array), New Integer(Me.compt + 1 - 1) {}), Integer())
					Me.DECLINAISONS(Me.compt) = Me.DESU(num16).Day
					Me.compt = Me.compt + 1
				End If
				num16 = num16 + 1
			Loop While num16 <= 1
			Array.Sort(Of Integer)(Me.DECLINAISONS)
			Me.firstdecno = False
			Dim num17 As Integer = 0
			Do
				If (Me.DECLINAISONS(0) = Me.DENO(num17).Day) Then
					Me.firstdecno = True
				End If
				num17 = num17 + 1
			Loop While num17 <= 1
			If (Me.firstdecno) Then
				Dim dECLINAISONS As Integer = Me.DECLINAISONS(0)
				Dim num18 As Integer = 1
				Do
					Me.phase(0, num18).Image = Resources.ascendante
					num18 = num18 + 1
				Loop While num18 <= dECLINAISONS
				If (CInt(Me.DECLINAISONS.Length) = 1) Then
					Dim dECLINAISONS1 As Integer = Me.DECLINAISONS(0) + 1
					Dim num19 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					For o As Integer = dECLINAISONS1 To num19 Step 1
						Me.phase(0, o).Image = Resources.descendante
					Next

				End If
				If (CInt(Me.DECLINAISONS.Length) = 2) Then
					Dim dECLINAISONS2 As Integer = Me.DECLINAISONS(0) + 1
					Dim dECLINAISONS3 As Integer = Me.DECLINAISONS(1)
					Dim num20 As Integer = dECLINAISONS2
					Do
						Me.phase(0, num20).Image = Resources.descendante
						num20 = num20 + 1
					Loop While num20 <= dECLINAISONS3
					Dim dECLINAISONS4 As Integer = Me.DECLINAISONS(1) + 1
					Dim num21 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					For p As Integer = dECLINAISONS4 To num21 Step 1
						Me.phase(0, p).Image = Resources.ascendante
					Next

				End If
				If (CInt(Me.DECLINAISONS.Length) = 3) Then
					Dim dECLINAISONS5 As Integer = Me.DECLINAISONS(0) + 1
					Dim dECLINAISONS6 As Integer = Me.DECLINAISONS(1)
					Dim num22 As Integer = dECLINAISONS5
					Do
						Me.phase(0, num22).Image = Resources.descendante
						num22 = num22 + 1
					Loop While num22 <= dECLINAISONS6
					Dim dECLINAISONS7 As Integer = Me.DECLINAISONS(1) + 1
					Dim dECLINAISONS8 As Integer = Me.DECLINAISONS(2)
					Dim num23 As Integer = dECLINAISONS7
					Do
						Me.phase(0, num23).Image = Resources.ascendante
						num23 = num23 + 1
					Loop While num23 <= dECLINAISONS8
					Dim dECLINAISONS9 As Integer = Me.DECLINAISONS(2) + 1
					Dim num24 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					For q As Integer = dECLINAISONS9 To num24 Step 1
						Me.phase(0, q).Image = Resources.descendante
					Next

				End If
			End If
			If (Not Me.firstdecno) Then
				Dim dECLINAISONS10 As Integer = Me.DECLINAISONS(0)
				Dim num25 As Integer = 1
				Do
					Me.phase(0, num25).Image = Resources.descendante
					num25 = num25 + 1
				Loop While num25 <= dECLINAISONS10
				If (CInt(Me.DECLINAISONS.Length) = 1) Then
					Dim dECLINAISONS11 As Integer = Me.DECLINAISONS(0) + 1
					Dim num26 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					For r As Integer = dECLINAISONS11 To num26 Step 1
						Me.phase(0, r).Image = Resources.ascendante
					Next

				End If
				If (CInt(Me.DECLINAISONS.Length) = 2) Then
					Dim dECLINAISONS12 As Integer = Me.DECLINAISONS(0) + 1
					Dim dECLINAISONS13 As Integer = Me.DECLINAISONS(1)
					Dim num27 As Integer = dECLINAISONS12
					Do
						Me.phase(0, num27).Image = Resources.ascendante
						num27 = num27 + 1
					Loop While num27 <= dECLINAISONS13
					Dim dECLINAISONS14 As Integer = Me.DECLINAISONS(1) + 1
					Dim num28 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					For s As Integer = dECLINAISONS14 To num28 Step 1
						Me.phase(0, s).Image = Resources.descendante
					Next

				End If
				If (CInt(Me.DECLINAISONS.Length) = 3) Then
					Dim dECLINAISONS15 As Integer = Me.DECLINAISONS(0) + 1
					Dim dECLINAISONS16 As Integer = Me.DECLINAISONS(1)
					Dim num29 As Integer = dECLINAISONS15
					Do
						Me.phase(0, num29).Image = Resources.ascendante
						num29 = num29 + 1
					Loop While num29 <= dECLINAISONS16
					Dim dECLINAISONS17 As Integer = Me.DECLINAISONS(1) + 1
					Dim dECLINAISONS18 As Integer = Me.DECLINAISONS(2)
					Dim num30 As Integer = dECLINAISONS17
					Do
						Me.phase(0, num30).Image = Resources.descendante
						num30 = num30 + 1
					Loop While num30 <= dECLINAISONS18
					Dim dECLINAISONS19 As Integer = Me.DECLINAISONS(2) + 1
					Dim num31 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
					For t As Integer = dECLINAISONS19 To num31 Step 1
						Me.phase(0, t).Image = Resources.ascendante
					Next

				End If
			End If
		End Sub

		Private Sub btnDefinition_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Definition = New FormExplicationCalendrierLunaire()
			Me.Definition.ShowDialog()
		End Sub

		Private Sub btnPrec_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim point As System.Drawing.Point
			Dim size As System.Drawing.Size
			Me.selection = Me.selection.AddMonths(-1)
			Me.lblMois.Text = String.Concat(Strings.UCase(Strings.Left(Me.selection.ToString("MMMM"), 1)), Strings.Mid(Me.selection.ToString("MMMM"), 2), " ", Me.selection.ToString("yyyy"))
			Me.Panel.Visible = False
			Me.Arg = New DateTime() { Me.selection, Me.selection.AddMonths(-1), Me.selection.AddMonths(1) }
			Me.BackgroundWorker1.RunWorkerAsync()
			Me.Panel.Controls.Clear()
			Me.start = CDbl(DateAndTime.Weekday(Me.selection, FirstDayOfWeek.Monday))
			ReDim Me.jour(0, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Me.compt = CInt(Math.Round(Me.start))
			Dim num As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num1 As Integer = 1
			Do
				Me.jour(0, num1) = New Label()
				Dim yellowGreen As Label = Me.jour(0, num1)
				yellowGreen.Text = String.Concat(Me.semaine(Me.compt), " ", num1.ToString())
				point = New System.Drawing.Point(1, (num1 - 1) * Me.Hlbl + 1 * num1)
				yellowGreen.Location = point
				size = New System.Drawing.Size(Me.Llbl1, Me.Hlbl)
				yellowGreen.Size = size
				yellowGreen.BackColor = Color.YellowGreen
				yellowGreen.TextAlign = ContentAlignment.MiddleCenter
				yellowGreen.ForeColor = Color.White
				yellowGreen.Font = New System.Drawing.Font("Times new roman", CSng(Module1.screenadaptX(9)), FontStyle.Bold)
				yellowGreen = Nothing
				Me.Panel.Controls.Add(Me.jour(0, num1))
				Me.compt = Me.compt + 1
				If (Me.compt = 8) Then
					Me.compt = 1
				End If
				num1 = num1 + 1
			Loop While num1 <= num
			ReDim Me.phase(1, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Dim num2 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num3 As Integer = 1
			Do
				Dim num4 As Integer = 0
				Do
					Me.phase(num4, num3) = New System.Windows.Forms.PictureBox()
					Dim pictureBox As System.Windows.Forms.PictureBox = Me.phase(num4, num3)
					point = New System.Drawing.Point(Me.Llbl1 + 2 + num4 * (Me.Llbl2 + 1), 1 + (num3 - 1) * (Me.Hlbl + 1))
					pictureBox.Location = point
					size = New System.Drawing.Size(Me.Llbl2, Me.Hlbl)
					pictureBox.Size = size
					pictureBox.SizeMode = PictureBoxSizeMode.CenterImage
					pictureBox = Nothing
					Me.Panel.Controls.Add(Me.phase(num4, num3))
					num4 = num4 + 1
				Loop While num4 <= 1
				num3 = num3 + 1
			Loop While num3 <= num2
			Dim num5 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num6 As Integer = 1
			Do
				Me.phase(0, num6).BackColor = Color.FromArgb(29, 47, 57)
				num6 = num6 + 1
			Loop While num6 <= num5
			Dim num7 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num8 As Integer = 1
			Do
				Me.phase(1, num8).BackColor = Color.FromArgb(86, 141, 183)
				num8 = num8 + 1
			Loop While num8 <= num7
			ReDim Me.euphemerides(0, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Dim num9 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num10 As Integer = 1
			Do
				Me.euphemerides(0, num10) = New Label()
				Dim font As Label = Me.euphemerides(0, num10)
				point = New System.Drawing.Point(Me.Llbl1 + 2 * Me.Llbl2 + 4, 1 + (num10 - 1) * (Me.Hlbl + 1))
				font.Location = point
				size = New System.Drawing.Size(Me.Llbl3, Me.Hlbl)
				font.Size = size
				font.AutoEllipsis = True
				font.TextAlign = ContentAlignment.MiddleCenter
				font.Font = New System.Drawing.Font("Times new roman", CSng(Module1.screenadaptY(9)), FontStyle.Bold)
				font.BackColor = Color.PaleGoldenrod
				font = Nothing
				Me.Panel.Controls.Add(Me.euphemerides(0, num10))
				num10 = num10 + 1
			Loop While num10 <= num9
			Me.Panel.Visible = True
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim point As System.Drawing.Point
			Dim size As System.Drawing.Size
			Me.selection = Me.selection.AddMonths(1)
			Me.lblMois.Text = String.Concat(Strings.UCase(Strings.Left(Me.selection.ToString("MMMM"), 1)), Strings.Mid(Me.selection.ToString("MMMM"), 2), " ", Me.selection.ToString("yyyy"))
			Me.Panel.Visible = False
			Me.Arg = New DateTime() { Me.selection, Me.selection.AddMonths(-1), Me.selection.AddMonths(1) }
			Me.BackgroundWorker1.RunWorkerAsync()
			Me.Panel.Controls.Clear()
			Me.start = CDbl(DateAndTime.Weekday(Me.selection, FirstDayOfWeek.Monday))
			ReDim Me.jour(0, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Me.compt = CInt(Math.Round(Me.start))
			Dim num As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num1 As Integer = 1
			Do
				Me.jour(0, num1) = New Label()
				Dim yellowGreen As Label = Me.jour(0, num1)
				yellowGreen.Text = String.Concat(Me.semaine(Me.compt), " ", num1.ToString())
				point = New System.Drawing.Point(1, (num1 - 1) * Me.Hlbl + 1 * num1)
				yellowGreen.Location = point
				size = New System.Drawing.Size(Me.Llbl1, Me.Hlbl)
				yellowGreen.Size = size
				yellowGreen.BackColor = Color.YellowGreen
				yellowGreen.TextAlign = ContentAlignment.MiddleCenter
				yellowGreen.ForeColor = Color.White
				yellowGreen.Font = New System.Drawing.Font("Times new roman", CSng(Module1.screenadaptX(9)), FontStyle.Bold)
				yellowGreen = Nothing
				Me.Panel.Controls.Add(Me.jour(0, num1))
				Me.compt = Me.compt + 1
				If (Me.compt = 8) Then
					Me.compt = 1
				End If
				num1 = num1 + 1
			Loop While num1 <= num
			ReDim Me.phase(1, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Dim num2 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num3 As Integer = 1
			Do
				Dim num4 As Integer = 0
				Do
					Me.phase(num4, num3) = New System.Windows.Forms.PictureBox()
					Dim pictureBox As System.Windows.Forms.PictureBox = Me.phase(num4, num3)
					point = New System.Drawing.Point(Me.Llbl1 + 2 + num4 * (Me.Llbl2 + 1), 1 + (num3 - 1) * (Me.Hlbl + 1))
					pictureBox.Location = point
					size = New System.Drawing.Size(Me.Llbl2, Me.Hlbl)
					pictureBox.Size = size
					pictureBox.SizeMode = PictureBoxSizeMode.CenterImage
					pictureBox = Nothing
					Me.Panel.Controls.Add(Me.phase(num4, num3))
					num4 = num4 + 1
				Loop While num4 <= 1
				num3 = num3 + 1
			Loop While num3 <= num2
			Dim num5 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num6 As Integer = 1
			Do
				Me.phase(0, num6).BackColor = Color.FromArgb(29, 47, 57)
				num6 = num6 + 1
			Loop While num6 <= num5
			Dim num7 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num8 As Integer = 1
			Do
				Me.phase(1, num8).BackColor = Color.FromArgb(86, 141, 183)
				num8 = num8 + 1
			Loop While num8 <= num7
			ReDim Me.euphemerides(0, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Dim num9 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num10 As Integer = 1
			Do
				Me.euphemerides(0, num10) = New Label()
				Dim font As Label = Me.euphemerides(0, num10)
				point = New System.Drawing.Point(Me.Llbl1 + 2 * Me.Llbl2 + 4, 1 + (num10 - 1) * (Me.Hlbl + 1))
				font.Location = point
				size = New System.Drawing.Size(Me.Llbl3, Me.Hlbl)
				font.Size = size
				font.AutoEllipsis = True
				font.TextAlign = ContentAlignment.MiddleCenter
				font.Font = New System.Drawing.Font("Times new roman", CSng(Module1.screenadaptY(9)), FontStyle.Bold)
				font.BackColor = Color.PaleGoldenrod
				font = Nothing
				Me.Panel.Controls.Add(Me.euphemerides(0, num10))
				num10 = num10 + 1
			Loop While num10 <= num9
			Me.Panel.Visible = True
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

		Private Sub Form11_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadmoon = False
		End Sub

		Private Sub Form11_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim current As System.Windows.Forms.Control
			Dim enumerator As IEnumerator = Nothing
			Dim point As System.Drawing.Point
			Dim enumerator1 As IEnumerator = Nothing
			Me.referencephase = New DateTime(1858, 11, 17, 0, 0, 0)
			Dim year As Integer = DateTime.Now.Year
			Dim now As DateTime = DateTime.Now
			Me.selection = New DateTime(year, now.Month, 1)
			Me.lblMois.Text = String.Concat(Strings.UCase(Strings.Left(Me.selection.ToString("MMMM"), 1)), Strings.Mid(Me.selection.ToString("MMMM"), 2), " ", Me.selection.ToString("yyyy"))
			Me.Panel.Visible = False
			Me.Arg = New DateTime() { Me.selection, Me.selection.AddMonths(-1), Me.selection.AddMonths(1) }
			Me.BackgroundWorker1.RunWorkerAsync()
			If (Not MyProject.Forms.FormPasPas.activation) Then
				Me.Buttonprec.Enabled = False
				Me.Buttonsuiv.Enabled = False
			End If
			Dim size As System.Drawing.Size = New System.Drawing.Size(Module1.screenadaptX(Me.Width), Module1.screenadaptY(Me.Height))
			Me.Size = size
			Try
				enumerator = Me.Controls.GetEnumerator()
				While enumerator.MoveNext()
					current = DirectCast(enumerator.Current, System.Windows.Forms.Control)
					Dim font As System.Windows.Forms.Control = current
					point = New System.Drawing.Point(Module1.screenadaptX(font.Left), Module1.screenadaptY(font.Top))
					font.Location = point
					size = New System.Drawing.Size(Module1.screenadaptX(font.Width), Module1.screenadaptY(font.Height))
					font.Size = size
					font.Font = New System.Drawing.Font(font.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(font.Font.Size))))), font.Font.Style)
					font = Nothing
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				enumerator1 = Me.GroupBox.Controls.GetEnumerator()
				While enumerator1.MoveNext()
					current = DirectCast(enumerator1.Current, System.Windows.Forms.Control)
					Dim control As System.Windows.Forms.Control = current
					point = New System.Drawing.Point(Module1.screenadaptX(control.Left), Module1.screenadaptY(control.Top))
					control.Location = point
					size = New System.Drawing.Size(Module1.screenadaptX(control.Width), Module1.screenadaptY(control.Height))
					control.Size = size
					control.Font = New System.Drawing.Font(control.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(control.Font.Size))))), control.Font.Style)
					control = Nothing
				End While
			Finally
				If (TypeOf enumerator1 Is IDisposable) Then
					TryCast(enumerator1, IDisposable).Dispose()
				End If
			End Try
			Me.Hlbl = Module1.screenadaptY(25)
			Me.Llbl1 = Module1.screenadaptX(150)
			Me.Llbl2 = Module1.screenadaptX(60)
			Me.Llbl3 = Module1.screenadaptX(210)
			Me.Mhaut = Module1.screenadaptY(40)
			Dim pictureBoxtelescope As System.Windows.Forms.PictureBox = Me.PictureBoxtelescope
			point = New System.Drawing.Point(0, Me.Mhaut + 33 * Me.Hlbl)
			pictureBoxtelescope.Location = point
			pictureBoxtelescope = Nothing
			Me.semaine = New String() { Nothing, "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" }
			Me.imagephase = New Image() { Resources.cal0, Resources.cal1, Resources.cal2, Resources.cal3, Resources.cal4, Resources.cal5, Resources.cal6, Resources.cal7, Resources.cal8, Resources.cal9, Resources.cal10, Resources.cal11, Resources.cal12, Resources.cal13, Resources.cal14, Resources.cal15, Resources.cal16, Resources.cal17, Resources.cal18, Resources.cal19, Resources.cal20, Resources.cal21, Resources.cal22, Resources.cal23, Resources.cal24, Resources.cal25, Resources.cal26, Resources.cal27, Resources.cal28 }
			Me.start = CDbl(DateAndTime.Weekday(Me.selection, FirstDayOfWeek.Monday))
			ReDim Me.jour(0, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Me.compt = CInt(Math.Round(Me.start))
			Dim num As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num1 As Integer = 1
			Do
				Me.jour(0, num1) = New Label()
				Dim yellowGreen As Label = Me.jour(0, num1)
				yellowGreen.Text = String.Concat(Me.semaine(Me.compt), " ", num1.ToString())
				point = New System.Drawing.Point(1, (num1 - 1) * Me.Hlbl + 1 * num1)
				yellowGreen.Location = point
				size = New System.Drawing.Size(Me.Llbl1, Me.Hlbl)
				yellowGreen.Size = size
				yellowGreen.BackColor = Color.YellowGreen
				yellowGreen.TextAlign = ContentAlignment.MiddleCenter
				yellowGreen.ForeColor = Color.White
				yellowGreen.Font = New System.Drawing.Font("Times new roman", CSng(Module1.screenadaptX(9)), FontStyle.Bold)
				yellowGreen = Nothing
				Me.Panel.Controls.Add(Me.jour(0, num1))
				Me.compt = Me.compt + 1
				If (Me.compt = 8) Then
					Me.compt = 1
				End If
				num1 = num1 + 1
			Loop While num1 <= num
			ReDim Me.phase(1, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Dim num2 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num3 As Integer = 1
			Do
				Dim num4 As Integer = 0
				Do
					Me.phase(num4, num3) = New System.Windows.Forms.PictureBox()
					Dim pictureBox As System.Windows.Forms.PictureBox = Me.phase(num4, num3)
					point = New System.Drawing.Point(Me.Llbl1 + 2 + num4 * (Me.Llbl2 + 1), 1 + (num3 - 1) * (Me.Hlbl + 1))
					pictureBox.Location = point
					size = New System.Drawing.Size(Me.Llbl2, Me.Hlbl)
					pictureBox.Size = size
					pictureBox.SizeMode = PictureBoxSizeMode.CenterImage
					pictureBox = Nothing
					Me.Panel.Controls.Add(Me.phase(num4, num3))
					num4 = num4 + 1
				Loop While num4 <= 1
				num3 = num3 + 1
			Loop While num3 <= num2
			Dim num5 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num6 As Integer = 1
			Do
				Me.phase(0, num6).BackColor = Color.FromArgb(29, 47, 57)
				num6 = num6 + 1
			Loop While num6 <= num5
			Dim num7 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num8 As Integer = 1
			Do
				Me.phase(1, num8).BackColor = Color.FromArgb(86, 141, 183)
				num8 = num8 + 1
			Loop While num8 <= num7
			ReDim Me.euphemerides(0, DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month) + 1 - 1)
			Dim num9 As Integer = DateTime.DaysInMonth(Me.selection.Year, Me.selection.Month)
			Dim num10 As Integer = 1
			Do
				Me.euphemerides(0, num10) = New Label()
				Dim paleGoldenrod As Label = Me.euphemerides(0, num10)
				point = New System.Drawing.Point(Me.Llbl1 + 2 * Me.Llbl2 + 4, 1 + (num10 - 1) * (Me.Hlbl + 1))
				paleGoldenrod.Location = point
				size = New System.Drawing.Size(Me.Llbl3, Me.Hlbl)
				paleGoldenrod.Size = size
				paleGoldenrod.AutoEllipsis = True
				paleGoldenrod.TextAlign = ContentAlignment.MiddleCenter
				paleGoldenrod.Font = New System.Drawing.Font("Times new roman", CSng(Module1.screenadaptY(9)), FontStyle.Bold)
				paleGoldenrod.BackColor = Color.PaleGoldenrod
				paleGoldenrod = Nothing
				Me.Panel.Controls.Add(Me.euphemerides(0, num10))
				num10 = num10 + 1
			Loop While num10 <= num9
			Me.Panel.Visible = True
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCalLun))
			Me.lblMois = New System.Windows.Forms.Label()
			Me.Panel = New System.Windows.Forms.Panel()
			Me.GroupBox = New System.Windows.Forms.GroupBox()
			Me.btnDefinition = New System.Windows.Forms.Button()
			Me.Label6 = New System.Windows.Forms.Label()
			Me.Label5 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.PictureBox2 = New System.Windows.Forms.PictureBox()
			Me.PictureBox = New System.Windows.Forms.PictureBox()
			Me.lbllegtrajdesc = New System.Windows.Forms.Label()
			Me.lblLegtrajectoire = New System.Windows.Forms.Label()
			Me.lblLegtrajasc = New System.Windows.Forms.Label()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.legluneasc = New System.Windows.Forms.PictureBox()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.lblTrajectoire = New System.Windows.Forms.Label()
			Me.Buttonsuiv = New System.Windows.Forms.Button()
			Me.Buttonprec = New System.Windows.Forms.Button()
			Me.BackgroundWorker1 = New BackgroundWorker()
			Me.PictureBox3 = New System.Windows.Forms.PictureBox()
			Me.PictureBoxtelescope = New System.Windows.Forms.PictureBox()
			Me.GroupBox.SuspendLayout()
			DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			DirectCast(Me.legluneasc, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox3, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBoxtelescope, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.lblMois.BackColor = SystemColors.ActiveCaption
			Me.lblMois.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label As System.Windows.Forms.Label = Me.lblMois
			Dim point As System.Drawing.Point = New System.Drawing.Point(154, 67)
			label.Location = point
			Me.lblMois.Name = "lblMois"
			Dim label1 As System.Windows.Forms.Label = Me.lblMois
			Dim size As System.Drawing.Size = New System.Drawing.Size(480, 40)
			label1.Size = size
			Me.lblMois.TabIndex = 1
			Me.lblMois.Text = "mois"
			Me.lblMois.TextAlign = ContentAlignment.MiddleCenter
			Me.Panel.AutoSize = True
			Me.Panel.BackColor = Color.White
			Dim panel As System.Windows.Forms.Panel = Me.Panel
			point = New System.Drawing.Point(153, 110)
			panel.Location = point
			Me.Panel.Name = "Panel"
			Dim panel1 As System.Windows.Forms.Panel = Me.Panel
			size = New System.Drawing.Size(480, 278)
			panel1.Size = size
			Me.Panel.TabIndex = 3
			Me.GroupBox.BackgroundImageLayout = ImageLayout.None
			Me.GroupBox.Controls.Add(Me.btnDefinition)
			Me.GroupBox.Controls.Add(Me.Label6)
			Me.GroupBox.Controls.Add(Me.Label5)
			Me.GroupBox.Controls.Add(Me.Label4)
			Me.GroupBox.Controls.Add(Me.Label3)
			Me.GroupBox.Controls.Add(Me.PictureBox2)
			Me.GroupBox.Controls.Add(Me.PictureBox)
			Me.GroupBox.Controls.Add(Me.lbllegtrajdesc)
			Me.GroupBox.Controls.Add(Me.lblLegtrajectoire)
			Me.GroupBox.Controls.Add(Me.lblLegtrajasc)
			Me.GroupBox.Controls.Add(Me.PictureBox1)
			Me.GroupBox.Controls.Add(Me.legluneasc)
			Me.GroupBox.Controls.Add(Me.Label2)
			Me.GroupBox.Controls.Add(Me.Label1)
			Me.GroupBox.Controls.Add(Me.lblTrajectoire)
			Me.GroupBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.GroupBox.ForeColor = Color.FromArgb(255, 128, 0)
			Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox
			point = New System.Drawing.Point(719, 67)
			groupBox.Location = point
			Me.GroupBox.Name = "GroupBox"
			Dim groupBox1 As System.Windows.Forms.GroupBox = Me.GroupBox
			size = New System.Drawing.Size(382, 748)
			groupBox1.Size = size
			Me.GroupBox.TabIndex = 4
			Me.GroupBox.TabStop = False
			Me.GroupBox.Text = "Légendes"
			Me.btnDefinition.FlatAppearance.BorderSize = 0
			Me.btnDefinition.FlatStyle = FlatStyle.Flat
			Me.btnDefinition.Font = New System.Drawing.Font("Times New Roman", 9.75!, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, 0)
			Me.btnDefinition.ForeColor = Color.FromArgb(255, 128, 0)
			Dim button As System.Windows.Forms.Button = Me.btnDefinition
			point = New System.Drawing.Point(6, 706)
			button.Location = point
			Me.btnDefinition.Name = "btnDefinition"
			Dim button1 As System.Windows.Forms.Button = Me.btnDefinition
			size = New System.Drawing.Size(369, 30)
			button1.Size = size
			Me.btnDefinition.TabIndex = 10
			Me.btnDefinition.Text = "Qu'est ce qu'un apogée, un périgée, un noeud?"
			Me.btnDefinition.UseVisualStyleBackColor = True
			Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = Color.Red
			Dim label6 As System.Windows.Forms.Label = Me.Label6
			point = New System.Drawing.Point(6, 654)
			label6.Location = point
			Me.Label6.Name = "Label6"
			Dim label61 As System.Windows.Forms.Label = Me.Label6
			size = New System.Drawing.Size(369, 37)
			label61.Size = size
			Me.Label6.TabIndex = 9
			Me.Label6.Text = "Apogée, Périgée et Noeud: il est conseillé d'éviter tous les travaux au jardin 6h avant et après."
			Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = SystemColors.ActiveCaption
			Dim label5 As System.Windows.Forms.Label = Me.Label5
			point = New System.Drawing.Point(7, 554)
			label5.Location = point
			Me.Label5.Name = "Label5"
			Dim label51 As System.Windows.Forms.Label = Me.Label5
			size = New System.Drawing.Size(369, 53)
			label51.Size = size
			Me.Label5.TabIndex = 7
			Me.Label5.Text = "Phase décroissante: Durant cette phase, les récoltes auront une saveur plus soutenue qu'en lune croissante, mais d'une qualité de conservation inférieure."
			Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = SystemColors.ActiveCaption
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(7, 451)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(369, 53)
			label41.Size = size
			Me.Label4.TabIndex = 6
			Me.Label4.Text = "Phase croissante: Cette phase est favorable aux récoltes destinées à la conservation. Les fruits et légumes se conserverons davantage, et bénéficieront d'une bonne résistance aux maladies."
			Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = SystemColors.ActiveCaption
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(7, 340)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(368, 54)
			label31.Size = size
			Me.Label3.TabIndex = 5
			Me.Label3.Text = componentResourceManager.GetString("Label3.Text")
			Me.PictureBox2.Image = Resources.phase2
			Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox2
			point = New System.Drawing.Point(111, 516)
			pictureBox2.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox2
			size = New System.Drawing.Size(166, 35)
			pictureBox.Size = size
			Me.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBox2.TabIndex = 7
			Me.PictureBox2.TabStop = False
			Me.PictureBox.Image = Resources.phase1
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox
			point = New System.Drawing.Point(111, 413)
			pictureBox1.Location = point
			Me.PictureBox.Name = "PictureBox"
			Dim pictureBox3 As System.Windows.Forms.PictureBox = Me.PictureBox
			size = New System.Drawing.Size(166, 35)
			pictureBox3.Size = size
			Me.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBox.TabIndex = 6
			Me.PictureBox.TabStop = False
			Me.lbllegtrajdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lbllegtrajdesc.ForeColor = SystemColors.ActiveCaption
			Dim label2 As System.Windows.Forms.Label = Me.lbllegtrajdesc
			point = New System.Drawing.Point(67, 216)
			label2.Location = point
			Me.lbllegtrajdesc.Name = "lbllegtrajdesc"
			Dim label7 As System.Windows.Forms.Label = Me.lbllegtrajdesc
			size = New System.Drawing.Size(308, 83)
			label7.Size = size
			Me.lbllegtrajdesc.TabIndex = 3
			Me.lbllegtrajdesc.Text = componentResourceManager.GetString("lbllegtrajdesc.Text")
			Me.lblLegtrajectoire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lblLegtrajectoire.ForeColor = SystemColors.ActiveCaption
			Dim label8 As System.Windows.Forms.Label = Me.lblLegtrajectoire
			point = New System.Drawing.Point(7, 64)
			label8.Location = point
			Me.lblLegtrajectoire.Name = "lblLegtrajectoire"
			Dim label9 As System.Windows.Forms.Label = Me.lblLegtrajectoire
			size = New System.Drawing.Size(368, 54)
			label9.Size = size
			Me.lblLegtrajectoire.TabIndex = 1
			Me.lblLegtrajectoire.Text = "La lune est ascendante (ou montante) pendant la période ou elle monte de l'horizon, et elle est descendante quand elle baisse vers l'horizon. chacun des deux cycles durent environ 13 jours."
			Me.lblLegtrajasc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.lblLegtrajasc.ForeColor = SystemColors.ActiveCaption
			Dim label10 As System.Windows.Forms.Label = Me.lblLegtrajasc
			point = New System.Drawing.Point(67, 138)
			label10.Location = point
			Me.lblLegtrajasc.Name = "lblLegtrajasc"
			Dim label11 As System.Windows.Forms.Label = Me.lblLegtrajasc
			size = New System.Drawing.Size(308, 68)
			label11.Size = size
			Me.lblLegtrajasc.TabIndex = 2
			Me.lblLegtrajasc.Text = "Trajectoire ascendante (ou montante): Durant cette période la sève monte dans les plantes, favorisant ainsi les parties hautes des plantes. Il est conseillé de planter, faire germer et greffer. "
			Me.PictureBox1.Image = Resources.desc
			Dim pictureBox11 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(9, 216)
			pictureBox11.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox12 As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(44, 36)
			pictureBox12.Size = size
			Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 4
			Me.PictureBox1.TabStop = False
			Me.legluneasc.Image = Resources.asc
			Dim pictureBox4 As System.Windows.Forms.PictureBox = Me.legluneasc
			point = New System.Drawing.Point(13, 138)
			pictureBox4.Location = point
			Me.legluneasc.Name = "legluneasc"
			Dim pictureBox5 As System.Windows.Forms.PictureBox = Me.legluneasc
			size = New System.Drawing.Size(41, 35)
			pictureBox5.Size = size
			Me.legluneasc.SizeMode = PictureBoxSizeMode.StretchImage
			Me.legluneasc.TabIndex = 3
			Me.legluneasc.TabStop = False
			Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Color.RoyalBlue
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(7, 625)
			label21.Location = point
			Me.Label2.Name = "Label2"
			Dim label22 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(104, 16)
			label22.Size = size
			Me.Label2.TabIndex = 8
			Me.Label2.Text = "Position"
			Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.RoyalBlue
			Dim label12 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(6, 318)
			label12.Location = point
			Me.Label1.Name = "Label1"
			Dim label13 As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(104, 16)
			label13.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Phases"
			Me.lblTrajectoire.Font = New System.Drawing.Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.lblTrajectoire.ForeColor = Color.RoyalBlue
			Dim label14 As System.Windows.Forms.Label = Me.lblTrajectoire
			point = New System.Drawing.Point(7, 43)
			label14.Location = point
			Me.lblTrajectoire.Name = "lblTrajectoire"
			Dim label15 As System.Windows.Forms.Label = Me.lblTrajectoire
			size = New System.Drawing.Size(104, 16)
			label15.Size = size
			Me.lblTrajectoire.TabIndex = 0
			Me.lblTrajectoire.Text = "Trajectoire"
			Me.Buttonsuiv.BackColor = SystemColors.ActiveCaption
			Me.Buttonsuiv.BackgroundImage = Resources.suiv282
			Me.Buttonsuiv.BackgroundImageLayout = ImageLayout.Center
			Me.Buttonsuiv.FlatAppearance.BorderSize = 0
			Me.Buttonsuiv.FlatStyle = FlatStyle.Flat
			Me.Buttonsuiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Buttonsuiv.ForeColor = Color.Black
			Dim buttonsuiv As System.Windows.Forms.Button = Me.Buttonsuiv
			point = New System.Drawing.Point(552, 73)
			buttonsuiv.Location = point
			Me.Buttonsuiv.Name = "Buttonsuiv"
			Dim buttonsuiv1 As System.Windows.Forms.Button = Me.Buttonsuiv
			size = New System.Drawing.Size(74, 28)
			buttonsuiv1.Size = size
			Me.Buttonsuiv.TabIndex = 2
			Me.Buttonsuiv.UseVisualStyleBackColor = False
			Me.Buttonprec.BackColor = SystemColors.ActiveCaption
			Me.Buttonprec.BackgroundImage = Resources.prec282
			Me.Buttonprec.BackgroundImageLayout = ImageLayout.Center
			Me.Buttonprec.FlatAppearance.BorderSize = 0
			Me.Buttonprec.FlatStyle = FlatStyle.Flat
			Me.Buttonprec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Buttonprec.ForeColor = Color.Black
			Dim buttonprec As System.Windows.Forms.Button = Me.Buttonprec
			point = New System.Drawing.Point(159, 73)
			buttonprec.Location = point
			Me.Buttonprec.Name = "Buttonprec"
			Dim buttonprec1 As System.Windows.Forms.Button = Me.Buttonprec
			size = New System.Drawing.Size(74, 28)
			buttonprec1.Size = size
			Me.Buttonprec.TabIndex = 0
			Me.Buttonprec.UseVisualStyleBackColor = False
			Me.PictureBox3.Image = Resources.earth
			Dim pictureBox31 As System.Windows.Forms.PictureBox = Me.PictureBox3
			point = New System.Drawing.Point(585, 12)
			pictureBox31.Location = point
			Me.PictureBox3.Name = "PictureBox3"
			Dim pictureBox32 As System.Windows.Forms.PictureBox = Me.PictureBox3
			size = New System.Drawing.Size(128, 128)
			pictureBox32.Size = size
			Me.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBox3.TabIndex = 5
			Me.PictureBox3.TabStop = False
			Me.PictureBoxtelescope.BackgroundImageLayout = ImageLayout.None
			Me.PictureBoxtelescope.Image = DirectCast(componentResourceManager.GetObject("PictureBoxtelescope.Image"), Image)
			Dim pictureBoxtelescope As System.Windows.Forms.PictureBox = Me.PictureBoxtelescope
			point = New System.Drawing.Point(12, 607)
			pictureBoxtelescope.Location = point
			Me.PictureBoxtelescope.Name = "PictureBoxtelescope"
			Dim pictureBoxtelescope1 As System.Windows.Forms.PictureBox = Me.PictureBoxtelescope
			size = New System.Drawing.Size(110, 141)
			pictureBoxtelescope1.Size = size
			Me.PictureBoxtelescope.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBoxtelescope.TabIndex = 6
			Me.PictureBoxtelescope.TabStop = False
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoScroll = True
			Me.BackColor = Color.MidnightBlue
			size = New System.Drawing.Size(1228, 752)
			Me.ClientSize = size
			Me.Controls.Add(Me.Buttonprec)
			Me.Controls.Add(Me.Buttonsuiv)
			Me.Controls.Add(Me.GroupBox)
			Me.Controls.Add(Me.Panel)
			Me.Controls.Add(Me.lblMois)
			Me.Controls.Add(Me.PictureBox3)
			Me.Controls.Add(Me.PictureBoxtelescope)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.Name = "FormCalLun"
			Me.Text = "Calendrier lunaire"
			Me.GroupBox.ResumeLayout(False)
			DirectCast(Me.PictureBox2, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			DirectCast(Me.legluneasc, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox3, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBoxtelescope, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
End Namespace