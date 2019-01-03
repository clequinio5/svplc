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

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class Formbilanfin
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Labelplant")>
		Private _Labelplant As Label

		<AccessedThroughProperty("Labelmat")>
		Private _Labelmat As Label

		<AccessedThroughProperty("Labeleco")>
		Private _Labeleco As Label

		<AccessedThroughProperty("Labelvente")>
		Private _Labelvente As Label

		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		<AccessedThroughProperty("Labeldep")>
		Private _Labeldep As Label

		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		<AccessedThroughProperty("Labelgain")>
		Private _Labelgain As Label

		<AccessedThroughProperty("Label15")>
		Private _Label15 As Label

		<AccessedThroughProperty("Label16")>
		Private _Label16 As Label

		<AccessedThroughProperty("Labeltotal")>
		Private _Labeltotal As Label

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		<AccessedThroughProperty("Labelrent")>
		Private _Labelrent As Label

		<AccessedThroughProperty("Label18")>
		Private _Label18 As Label

		<AccessedThroughProperty("Panel3")>
		Private _Panel3 As Panel

		<AccessedThroughProperty("Label34")>
		Private _Label34 As Label

		<AccessedThroughProperty("Label33")>
		Private _Label33 As Label

		<AccessedThroughProperty("Label32")>
		Private _Label32 As Label

		<AccessedThroughProperty("Label31")>
		Private _Label31 As Label

		<AccessedThroughProperty("Labeldiamat")>
		Private _Labeldiamat As Label

		<AccessedThroughProperty("Label29")>
		Private _Label29 As Label

		<AccessedThroughProperty("Label28")>
		Private _Label28 As Label

		<AccessedThroughProperty("Label27")>
		Private _Label27 As Label

		<AccessedThroughProperty("Label26")>
		Private _Label26 As Label

		<AccessedThroughProperty("Labeldiaplant")>
		Private _Labeldiaplant As Label

		<AccessedThroughProperty("Label21")>
		Private _Label21 As Label

		<AccessedThroughProperty("Label20")>
		Private _Label20 As Label

		<AccessedThroughProperty("Label24")>
		Private _Label24 As Label

		<AccessedThroughProperty("Label22")>
		Private _Label22 As Label

		<AccessedThroughProperty("Label25")>
		Private _Label25 As Label

		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		<AccessedThroughProperty("Label35")>
		Private _Label35 As Label

		<AccessedThroughProperty("Label36")>
		Private _Label36 As Label

		<AccessedThroughProperty("Label37")>
		Private _Label37 As Label

		<AccessedThroughProperty("Label38")>
		Private _Label38 As Label

		<AccessedThroughProperty("Labeldiavente")>
		Private _Labeldiavente As Label

		<AccessedThroughProperty("Label40")>
		Private _Label40 As Label

		<AccessedThroughProperty("Label41")>
		Private _Label41 As Label

		<AccessedThroughProperty("Label42")>
		Private _Label42 As Label

		<AccessedThroughProperty("Label43")>
		Private _Label43 As Label

		<AccessedThroughProperty("Labeldiaeco")>
		Private _Labeldiaeco As Label

		<AccessedThroughProperty("Label45")>
		Private _Label45 As Label

		<AccessedThroughProperty("Label46")>
		Private _Label46 As Label

		<AccessedThroughProperty("Label47")>
		Private _Label47 As Label

		<AccessedThroughProperty("Label48")>
		Private _Label48 As Label

		<AccessedThroughProperty("Label49")>
		Private _Label49 As Label

		Private total As Single

		Private pourcentmat As Single

		Private pourcentplant As Single

		Private pourcentvente As Single

		Private pourcenteco As Single

		Friend Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label1 = value
			End Set
		End Property

		Friend Overridable Property Label11 As Label
			Get
				Return Me._Label11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label11 = value
			End Set
		End Property

		Friend Overridable Property Label13 As Label
			Get
				Return Me._Label13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label13 = value
			End Set
		End Property

		Friend Overridable Property Label15 As Label
			Get
				Return Me._Label15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label15 = value
			End Set
		End Property

		Friend Overridable Property Label16 As Label
			Get
				Return Me._Label16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label16 = value
			End Set
		End Property

		Friend Overridable Property Label18 As Label
			Get
				Return Me._Label18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label18 = value
			End Set
		End Property

		Friend Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label2 = value
			End Set
		End Property

		Friend Overridable Property Label20 As Label
			Get
				Return Me._Label20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label20 = value
			End Set
		End Property

		Friend Overridable Property Label21 As Label
			Get
				Return Me._Label21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label21 = value
			End Set
		End Property

		Friend Overridable Property Label22 As Label
			Get
				Return Me._Label22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label22 = value
			End Set
		End Property

		Friend Overridable Property Label24 As Label
			Get
				Return Me._Label24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label24 = value
			End Set
		End Property

		Friend Overridable Property Label25 As Label
			Get
				Return Me._Label25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label25 = value
			End Set
		End Property

		Friend Overridable Property Label26 As Label
			Get
				Return Me._Label26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label26 = value
			End Set
		End Property

		Friend Overridable Property Label27 As Label
			Get
				Return Me._Label27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label27 = value
			End Set
		End Property

		Friend Overridable Property Label28 As Label
			Get
				Return Me._Label28
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label28 = value
			End Set
		End Property

		Friend Overridable Property Label29 As Label
			Get
				Return Me._Label29
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label29 = value
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

		Friend Overridable Property Label31 As Label
			Get
				Return Me._Label31
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label31 = value
			End Set
		End Property

		Friend Overridable Property Label32 As Label
			Get
				Return Me._Label32
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label32 = value
			End Set
		End Property

		Friend Overridable Property Label33 As Label
			Get
				Return Me._Label33
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label33 = value
			End Set
		End Property

		Friend Overridable Property Label34 As Label
			Get
				Return Me._Label34
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label34 = value
			End Set
		End Property

		Friend Overridable Property Label35 As Label
			Get
				Return Me._Label35
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label35 = value
			End Set
		End Property

		Friend Overridable Property Label36 As Label
			Get
				Return Me._Label36
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label36 = value
			End Set
		End Property

		Friend Overridable Property Label37 As Label
			Get
				Return Me._Label37
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label37 = value
			End Set
		End Property

		Friend Overridable Property Label38 As Label
			Get
				Return Me._Label38
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label38 = value
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

		Friend Overridable Property Label40 As Label
			Get
				Return Me._Label40
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label40 = value
			End Set
		End Property

		Friend Overridable Property Label41 As Label
			Get
				Return Me._Label41
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label41 = value
			End Set
		End Property

		Friend Overridable Property Label42 As Label
			Get
				Return Me._Label42
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label42 = value
			End Set
		End Property

		Friend Overridable Property Label43 As Label
			Get
				Return Me._Label43
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label43 = value
			End Set
		End Property

		Friend Overridable Property Label45 As Label
			Get
				Return Me._Label45
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label45 = value
			End Set
		End Property

		Friend Overridable Property Label46 As Label
			Get
				Return Me._Label46
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label46 = value
			End Set
		End Property

		Friend Overridable Property Label47 As Label
			Get
				Return Me._Label47
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label47 = value
			End Set
		End Property

		Friend Overridable Property Label48 As Label
			Get
				Return Me._Label48
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label48 = value
			End Set
		End Property

		Friend Overridable Property Label49 As Label
			Get
				Return Me._Label49
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label49 = value
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

		Friend Overridable Property Labeldep As Label
			Get
				Return Me._Labeldep
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeldep = value
			End Set
		End Property

		Friend Overridable Property Labeldiaeco As Label
			Get
				Return Me._Labeldiaeco
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeldiaeco = value
			End Set
		End Property

		Friend Overridable Property Labeldiamat As Label
			Get
				Return Me._Labeldiamat
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeldiamat = value
			End Set
		End Property

		Friend Overridable Property Labeldiaplant As Label
			Get
				Return Me._Labeldiaplant
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeldiaplant = value
			End Set
		End Property

		Friend Overridable Property Labeldiavente As Label
			Get
				Return Me._Labeldiavente
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeldiavente = value
			End Set
		End Property

		Friend Overridable Property Labeleco As Label
			Get
				Return Me._Labeleco
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeleco = value
			End Set
		End Property

		Friend Overridable Property Labelgain As Label
			Get
				Return Me._Labelgain
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelgain = value
			End Set
		End Property

		Friend Overridable Property Labelmat As Label
			Get
				Return Me._Labelmat
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelmat = value
			End Set
		End Property

		Friend Overridable Property Labelplant As Label
			Get
				Return Me._Labelplant
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelplant = value
			End Set
		End Property

		Friend Overridable Property Labelrent As Label
			Get
				Return Me._Labelrent
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelrent = value
			End Set
		End Property

		Friend Overridable Property Labeltotal As Label
			Get
				Return Me._Labeltotal
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labeltotal = value
			End Set
		End Property

		Friend Overridable Property Labelvente As Label
			Get
				Return Me._Labelvente
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelvente = value
			End Set
		End Property

		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		Friend Overridable Property Panel2 As Panel
			Get
				Return Me._Panel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panel2 = value
			End Set
		End Property

		Friend Overridable Property Panel3 As Panel
			Get
				Return Me._Panel3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panel3 = value
			End Set
		End Property

		Friend Overridable Property Panel4 As Panel
			Get
				Return Me._Panel4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panel4 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formbilanfin1 As Formbilanfin = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formbilanfin1.Formbilanfin_Load)
			Me.InitializeComponent()
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

		Private Sub Formbilanfin_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Dim point As System.Drawing.Point
			Dim enumerator1 As IEnumerator = Nothing
			Dim size As System.Drawing.Size = New System.Drawing.Size(Module1.screenadaptX(Me.Width), Module1.screenadaptY(Me.Height))
			Me.Size = size
			Try
				enumerator = Me.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As Control = DirectCast(enumerator.Current, Control)
					point = New System.Drawing.Point(Module1.screenadaptX(current.Left), Module1.screenadaptY(current.Top))
					current.Location = point
					size = New System.Drawing.Size(Module1.screenadaptX(current.Width), Module1.screenadaptY(current.Height))
					current.Size = size
					Try
						enumerator1 = current.Controls.GetEnumerator()
						While enumerator1.MoveNext()
							Dim font As Control = DirectCast(enumerator1.Current, Control)
							point = New System.Drawing.Point(Module1.screenadaptX(font.Left), Module1.screenadaptY(font.Top))
							font.Location = point
							size = New System.Drawing.Size(Module1.screenadaptX(font.Width), Module1.screenadaptY(font.Height))
							font.Size = size
							font.Font = New System.Drawing.Font(font.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(font.Font.Size))))), font.Font.Style)
							font = Nothing
						End While
					Finally
						If (TypeOf enumerator1 Is IDisposable) Then
							TryCast(enumerator1, IDisposable).Dispose()
						End If
					End Try
					current = Nothing
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Try
				Dim labelplant As System.Windows.Forms.Label = Me.Labelplant
				Dim num As Double = Math.Round(MyProject.Forms.FormPasPas.Gardenfinance(0), 2)
				labelplant.Text = String.Concat("- ", num.ToString())
				Dim labelmat As System.Windows.Forms.Label = Me.Labelmat
				num = Math.Round(MyProject.Forms.FormPasPas.Gardenfinance(1), 2)
				labelmat.Text = String.Concat("- ", num.ToString())
				Dim labeldep As System.Windows.Forms.Label = Me.Labeldep
				num = Math.Round(MyProject.Forms.FormPasPas.Gardenfinance(0) + MyProject.Forms.FormPasPas.Gardenfinance(1), 2)
				labeldep.Text = String.Concat("- ", num.ToString())
				Dim labeleco As System.Windows.Forms.Label = Me.Labeleco
				num = Math.Round(MyProject.Forms.FormPasPas.Gardenfinance(2), 2)
				labeleco.Text = String.Concat("+ ", num.ToString())
				Dim labelvente As System.Windows.Forms.Label = Me.Labelvente
				num = Math.Round(MyProject.Forms.FormPasPas.Gardenfinance(3), 2)
				labelvente.Text = String.Concat("+ ", num.ToString())
				Dim labelgain As System.Windows.Forms.Label = Me.Labelgain
				num = Math.Round(MyProject.Forms.FormPasPas.Gardenfinance(2) + MyProject.Forms.FormPasPas.Gardenfinance(3), 2)
				labelgain.Text = String.Concat("+ ", num.ToString())
				Me.total = CSng(Math.Round(MyProject.Forms.FormPasPas.Gardenfinance(2) + MyProject.Forms.FormPasPas.Gardenfinance(3) - (MyProject.Forms.FormPasPas.Gardenfinance(0) + MyProject.Forms.FormPasPas.Gardenfinance(1)), 2))
				Me.Labeltotal.Text = Me.total.ToString()
				If (Me.total > 0!) Then
					Me.Labeltotal.ForeColor = Color.Green
					Me.Labelrent.ForeColor = Color.Green
				End If
				If (Me.total < 0!) Then
					Me.Labeltotal.ForeColor = Color.Red
					Me.Labelrent.ForeColor = Color.Red
				End If
				Dim labelrent As System.Windows.Forms.Label = Me.Labelrent
				num = Math.Round(CDbl((Me.total * 100!)) / (MyProject.Forms.FormPasPas.Gardenfinance(0) + MyProject.Forms.FormPasPas.Gardenfinance(1)), 2)
				labelrent.Text = String.Concat(num.ToString(), " %")
				Me.pourcentplant = CSng((MyProject.Forms.FormPasPas.Gardenfinance(0) * 100 / (MyProject.Forms.FormPasPas.Gardenfinance(0) + MyProject.Forms.FormPasPas.Gardenfinance(1))))
				Me.pourcentmat = 100! - Me.pourcentplant
				Me.pourcenteco = CSng((MyProject.Forms.FormPasPas.Gardenfinance(2) * 100 / (MyProject.Forms.FormPasPas.Gardenfinance(2) + MyProject.Forms.FormPasPas.Gardenfinance(3))))
				Me.pourcentvente = 100! - Me.pourcenteco
				Dim labeldiaplant As System.Windows.Forms.Label = Me.Labeldiaplant
				num = Math.Round(CDbl(Me.pourcentplant), 2)
				labeldiaplant.Text = String.Concat(num.ToString(), " %")
				Dim label As System.Windows.Forms.Label = Me.Labeldiaplant
				size = New System.Drawing.Size(50, CInt(Math.Round(Math.Round(CDbl(Me.pourcentplant)))))
				label.Size = size
				Dim labeldiaplant1 As System.Windows.Forms.Label = Me.Labeldiaplant
				point = New System.Drawing.Point(83, CInt(Math.Round(140 - Math.Round(CDbl(Me.pourcentplant)))))
				labeldiaplant1.Location = point
				Dim labeldiamat As System.Windows.Forms.Label = Me.Labeldiamat
				num = Math.Round(CDbl(Me.pourcentmat), 2)
				labeldiamat.Text = String.Concat(num.ToString(), " %")
				Dim labeldiamat1 As System.Windows.Forms.Label = Me.Labeldiamat
				size = New System.Drawing.Size(50, CInt(Math.Round(Math.Round(CDbl(Me.pourcentmat)))))
				labeldiamat1.Size = size
				Dim label1 As System.Windows.Forms.Label = Me.Labeldiamat
				point = New System.Drawing.Point(159, CInt(Math.Round(140 - Math.Round(CDbl(Me.pourcentmat)))))
				label1.Location = point
				Dim labeldiaeco As System.Windows.Forms.Label = Me.Labeldiaeco
				num = Math.Round(CDbl(Me.pourcenteco), 2)
				labeldiaeco.Text = String.Concat(num.ToString(), " %")
				Dim labeldiaeco1 As System.Windows.Forms.Label = Me.Labeldiaeco
				size = New System.Drawing.Size(50, CInt(Math.Round(Math.Round(CDbl(Me.pourcenteco)))))
				labeldiaeco1.Size = size
				Dim labeldiaeco2 As System.Windows.Forms.Label = Me.Labeldiaeco
				point = New System.Drawing.Point(83, CInt(Math.Round(140 - Math.Round(CDbl(Me.pourcenteco)))))
				labeldiaeco2.Location = point
				Dim labeldiavente As System.Windows.Forms.Label = Me.Labeldiavente
				num = Math.Round(CDbl(Me.pourcentvente), 2)
				labeldiavente.Text = String.Concat(num.ToString(), " %")
				Dim labeldiavente1 As System.Windows.Forms.Label = Me.Labeldiavente
				size = New System.Drawing.Size(50, CInt(Math.Round(Math.Round(CDbl(Me.pourcentvente)))))
				labeldiavente1.Size = size
				Dim labeldiavente2 As System.Windows.Forms.Label = Me.Labeldiavente
				point = New System.Drawing.Point(159, CInt(Math.Round(140 - Math.Round(CDbl(Me.pourcentvente)))))
				labeldiavente2.Location = point
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Félicitations vous avez trouvé un bug!" & VbCrLf & "Veuillez contacter le programmeur au plus vite!", "Erreur de calcul")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formbilanfin))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Label5 = New System.Windows.Forms.Label()
			Me.Label6 = New System.Windows.Forms.Label()
			Me.Labelplant = New System.Windows.Forms.Label()
			Me.Labelmat = New System.Windows.Forms.Label()
			Me.Labeleco = New System.Windows.Forms.Label()
			Me.Labelvente = New System.Windows.Forms.Label()
			Me.Label11 = New System.Windows.Forms.Label()
			Me.Labeldep = New System.Windows.Forms.Label()
			Me.Label13 = New System.Windows.Forms.Label()
			Me.Labelgain = New System.Windows.Forms.Label()
			Me.Label15 = New System.Windows.Forms.Label()
			Me.Label16 = New System.Windows.Forms.Label()
			Me.Labeltotal = New System.Windows.Forms.Label()
			Me.Panel1 = New System.Windows.Forms.Panel()
			Me.Panel2 = New System.Windows.Forms.Panel()
			Me.Labelrent = New System.Windows.Forms.Label()
			Me.Label18 = New System.Windows.Forms.Label()
			Me.Panel3 = New System.Windows.Forms.Panel()
			Me.Label34 = New System.Windows.Forms.Label()
			Me.Label33 = New System.Windows.Forms.Label()
			Me.Label32 = New System.Windows.Forms.Label()
			Me.Label31 = New System.Windows.Forms.Label()
			Me.Labeldiamat = New System.Windows.Forms.Label()
			Me.Label29 = New System.Windows.Forms.Label()
			Me.Label28 = New System.Windows.Forms.Label()
			Me.Label27 = New System.Windows.Forms.Label()
			Me.Label26 = New System.Windows.Forms.Label()
			Me.Labeldiaplant = New System.Windows.Forms.Label()
			Me.Label21 = New System.Windows.Forms.Label()
			Me.Label20 = New System.Windows.Forms.Label()
			Me.Label24 = New System.Windows.Forms.Label()
			Me.Label22 = New System.Windows.Forms.Label()
			Me.Label25 = New System.Windows.Forms.Label()
			Me.Panel4 = New System.Windows.Forms.Panel()
			Me.Label35 = New System.Windows.Forms.Label()
			Me.Label36 = New System.Windows.Forms.Label()
			Me.Label37 = New System.Windows.Forms.Label()
			Me.Label38 = New System.Windows.Forms.Label()
			Me.Labeldiavente = New System.Windows.Forms.Label()
			Me.Label40 = New System.Windows.Forms.Label()
			Me.Label41 = New System.Windows.Forms.Label()
			Me.Label42 = New System.Windows.Forms.Label()
			Me.Label43 = New System.Windows.Forms.Label()
			Me.Labeldiaeco = New System.Windows.Forms.Label()
			Me.Label45 = New System.Windows.Forms.Label()
			Me.Label46 = New System.Windows.Forms.Label()
			Me.Label47 = New System.Windows.Forms.Label()
			Me.Label48 = New System.Windows.Forms.Label()
			Me.Label49 = New System.Windows.Forms.Label()
			Me.Panel1.SuspendLayout()
			Me.Panel2.SuspendLayout()
			Me.Panel3.SuspendLayout()
			Me.Panel4.SuspendLayout()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.Red
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(40, 26)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(108, 19)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "DEPENSES :"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Color.Green
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(40, 198)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(74, 19)
			label21.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "GAINS :"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(170, 26)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(94, 16)
			label31.Size = size
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "- Plantations"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(170, 66)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(81, 16)
			label41.Size = size
			Me.Label4.TabIndex = 3
			Me.Label4.Text = "- Matériels"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
			Dim label5 As System.Windows.Forms.Label = Me.Label5
			point = New System.Drawing.Point(170, 198)
			label5.Location = point
			Me.Label5.Name = "Label5"
			Dim label51 As System.Windows.Forms.Label = Me.Label5
			size = New System.Drawing.Size(94, 16)
			label51.Size = size
			Me.Label5.TabIndex = 4
			Me.Label5.Text = "- Economies"
			Me.Label6.AutoSize = True
			Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
			Dim label6 As System.Windows.Forms.Label = Me.Label6
			point = New System.Drawing.Point(170, 238)
			label6.Location = point
			Me.Label6.Name = "Label6"
			Dim label61 As System.Windows.Forms.Label = Me.Label6
			size = New System.Drawing.Size(65, 16)
			label61.Size = size
			Me.Label6.TabIndex = 5
			Me.Label6.Text = "- Ventes"
			Me.Labelplant.AutoSize = True
			Me.Labelplant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelplant.ForeColor = Color.Red
			Dim labelplant As System.Windows.Forms.Label = Me.Labelplant
			point = New System.Drawing.Point(282, 26)
			labelplant.Location = point
			Me.Labelplant.Name = "Labelplant"
			Dim labelplant1 As System.Windows.Forms.Label = Me.Labelplant
			size = New System.Drawing.Size(55, 16)
			labelplant1.Size = size
			Me.Labelplant.TabIndex = 6
			Me.Labelplant.Text = "Label7"
			Me.Labelmat.AutoSize = True
			Me.Labelmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelmat.ForeColor = Color.Red
			Dim labelmat As System.Windows.Forms.Label = Me.Labelmat
			point = New System.Drawing.Point(282, 69)
			labelmat.Location = point
			Me.Labelmat.Name = "Labelmat"
			Dim labelmat1 As System.Windows.Forms.Label = Me.Labelmat
			size = New System.Drawing.Size(55, 16)
			labelmat1.Size = size
			Me.Labelmat.TabIndex = 7
			Me.Labelmat.Text = "Label8"
			Me.Labeleco.AutoSize = True
			Me.Labeleco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labeleco.ForeColor = Color.Green
			Dim labeleco As System.Windows.Forms.Label = Me.Labeleco
			point = New System.Drawing.Point(282, 198)
			labeleco.Location = point
			Me.Labeleco.Name = "Labeleco"
			Dim labeleco1 As System.Windows.Forms.Label = Me.Labeleco
			size = New System.Drawing.Size(55, 16)
			labeleco1.Size = size
			Me.Labeleco.TabIndex = 8
			Me.Labeleco.Text = "Label9"
			Me.Labelvente.AutoSize = True
			Me.Labelvente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelvente.ForeColor = Color.Green
			Dim labelvente As System.Windows.Forms.Label = Me.Labelvente
			point = New System.Drawing.Point(282, 238)
			labelvente.Location = point
			Me.Labelvente.Name = "Labelvente"
			Dim labelvente1 As System.Windows.Forms.Label = Me.Labelvente
			size = New System.Drawing.Size(63, 16)
			labelvente1.Size = size
			Me.Labelvente.TabIndex = 9
			Me.Labelvente.Text = "Label10"
			Me.Label11.BackColor = Color.FromArgb(192, 64, 0)
			Dim label11 As System.Windows.Forms.Label = Me.Label11
			point = New System.Drawing.Point(163, 101)
			label11.Location = point
			Me.Label11.Name = "Label11"
			Dim label111 As System.Windows.Forms.Label = Me.Label11
			size = New System.Drawing.Size(180, 4)
			label111.Size = size
			Me.Label11.TabIndex = 10
			Me.Labeldep.AutoSize = True
			Me.Labeldep.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Labeldep.ForeColor = Color.Red
			Dim labeldep As System.Windows.Forms.Label = Me.Labeldep
			point = New System.Drawing.Point(259, 121)
			labeldep.Location = point
			Me.Labeldep.Name = "Labeldep"
			Dim labeldep1 As System.Windows.Forms.Label = Me.Labeldep
			size = New System.Drawing.Size(44, 19)
			labeldep1.Size = size
			Me.Labeldep.TabIndex = 11
			Me.Labeldep.Text = "DEP"
			Me.Label13.BackColor = Color.FromArgb(192, 64, 0)
			Dim label13 As System.Windows.Forms.Label = Me.Label13
			point = New System.Drawing.Point(163, 273)
			label13.Location = point
			Me.Label13.Name = "Label13"
			Dim label131 As System.Windows.Forms.Label = Me.Label13
			size = New System.Drawing.Size(180, 4)
			label131.Size = size
			Me.Label13.TabIndex = 12
			Me.Labelgain.AutoSize = True
			Me.Labelgain.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Labelgain.ForeColor = Color.Green
			Dim labelgain As System.Windows.Forms.Label = Me.Labelgain
			point = New System.Drawing.Point(262, 291)
			labelgain.Location = point
			Me.Labelgain.Name = "Labelgain"
			Dim labelgain1 As System.Windows.Forms.Label = Me.Labelgain
			size = New System.Drawing.Size(42, 19)
			labelgain1.Size = size
			Me.Labelgain.TabIndex = 13
			Me.Labelgain.Text = "GAI"
			Me.Label15.BackColor = Color.FromArgb(192, 64, 0)
			Dim label15 As System.Windows.Forms.Label = Me.Label15
			point = New System.Drawing.Point(41, 339)
			label15.Location = point
			Me.Label15.Name = "Label15"
			Dim label151 As System.Windows.Forms.Label = Me.Label15
			size = New System.Drawing.Size(310, 4)
			label151.Size = size
			Me.Label15.TabIndex = 14
			Me.Label16.AutoSize = True
			Me.Label16.Font = New System.Drawing.Font("Cooper Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label16.ForeColor = Color.Black
			Dim label16 As System.Windows.Forms.Label = Me.Label16
			point = New System.Drawing.Point(40, 364)
			label16.Location = point
			Me.Label16.Name = "Label16"
			Dim label161 As System.Windows.Forms.Label = Me.Label16
			size = New System.Drawing.Size(90, 21)
			label161.Size = size
			Me.Label16.TabIndex = 15
			Me.Label16.Text = "TOTAL :"
			Me.Labeltotal.AutoSize = True
			Me.Labeltotal.Font = New System.Drawing.Font("Cooper Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Labeltotal.ForeColor = Color.Goldenrod
			Dim labeltotal As System.Windows.Forms.Label = Me.Labeltotal
			point = New System.Drawing.Point(243, 363)
			labeltotal.Location = point
			Me.Labeltotal.Name = "Labeltotal"
			Dim labeltotal1 As System.Windows.Forms.Label = Me.Labeltotal
			size = New System.Drawing.Size(51, 21)
			labeltotal1.Size = size
			Me.Labeltotal.TabIndex = 16
			Me.Labeltotal.Text = "TOT"
			Me.Panel1.BackColor = Color.LightSteelBlue
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Labeltotal)
			Me.Panel1.Controls.Add(Me.Label6)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.Labeleco)
			Me.Panel1.Controls.Add(Me.Labeldep)
			Me.Panel1.Controls.Add(Me.Label16)
			Me.Panel1.Controls.Add(Me.Labelgain)
			Me.Panel1.Controls.Add(Me.Labelvente)
			Me.Panel1.Controls.Add(Me.Labelplant)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.Labelmat)
			Me.Panel1.Controls.Add(Me.Label11)
			Me.Panel1.Controls.Add(Me.Label15)
			Dim panel1 As System.Windows.Forms.Panel = Me.Panel1
			point = New System.Drawing.Point(12, 26)
			panel1.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel As System.Windows.Forms.Panel = Me.Panel1
			size = New System.Drawing.Size(396, 420)
			panel.Size = size
			Me.Panel1.TabIndex = 17
			Me.Panel2.BackColor = Color.Gold
			Me.Panel2.Controls.Add(Me.Labelrent)
			Me.Panel2.Controls.Add(Me.Label18)
			Dim panel2 As System.Windows.Forms.Panel = Me.Panel2
			point = New System.Drawing.Point(414, 390)
			panel2.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel21 As System.Windows.Forms.Panel = Me.Panel2
			size = New System.Drawing.Size(376, 42)
			panel21.Size = size
			Me.Panel2.TabIndex = 18
			Me.Labelrent.AutoSize = True
			Me.Labelrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim labelrent As System.Windows.Forms.Label = Me.Labelrent
			point = New System.Drawing.Point(265, 14)
			labelrent.Location = point
			Me.Labelrent.Name = "Labelrent"
			Dim labelrent1 As System.Windows.Forms.Label = Me.Labelrent
			size = New System.Drawing.Size(63, 16)
			labelrent1.Size = size
			Me.Labelrent.TabIndex = 1
			Me.Labelrent.Text = "Label19"
			Me.Label18.AutoSize = True
			Me.Label18.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Italic, GraphicsUnit.Point, 0)
			Dim label18 As System.Windows.Forms.Label = Me.Label18
			point = New System.Drawing.Point(33, 14)
			label18.Location = point
			Me.Label18.Name = "Label18"
			Dim label181 As System.Windows.Forms.Label = Me.Label18
			size = New System.Drawing.Size(158, 15)
			label181.Size = size
			Me.Label18.TabIndex = 0
			Me.Label18.Text = "Rentabilité du jardin :"
			Me.Panel3.BackColor = Color.LightSteelBlue
			Me.Panel3.Controls.Add(Me.Label34)
			Me.Panel3.Controls.Add(Me.Label33)
			Me.Panel3.Controls.Add(Me.Label32)
			Me.Panel3.Controls.Add(Me.Label31)
			Me.Panel3.Controls.Add(Me.Labeldiamat)
			Me.Panel3.Controls.Add(Me.Label29)
			Me.Panel3.Controls.Add(Me.Label28)
			Me.Panel3.Controls.Add(Me.Label27)
			Me.Panel3.Controls.Add(Me.Label26)
			Me.Panel3.Controls.Add(Me.Labeldiaplant)
			Me.Panel3.Controls.Add(Me.Label21)
			Me.Panel3.Controls.Add(Me.Label20)
			Me.Panel3.Controls.Add(Me.Label24)
			Me.Panel3.Controls.Add(Me.Label22)
			Me.Panel3.Controls.Add(Me.Label25)
			Dim panel3 As System.Windows.Forms.Panel = Me.Panel3
			point = New System.Drawing.Point(414, 26)
			panel3.Location = point
			Me.Panel3.Name = "Panel3"
			Dim panel31 As System.Windows.Forms.Panel = Me.Panel3
			size = New System.Drawing.Size(376, 161)
			panel31.Size = size
			Me.Panel3.TabIndex = 19
			Me.Label34.AutoSize = True
			Dim label34 As System.Windows.Forms.Label = Me.Label34
			point = New System.Drawing.Point(290, 51)
			label34.Location = point
			Me.Label34.Name = "Label34"
			Dim label341 As System.Windows.Forms.Label = Me.Label34
			size = New System.Drawing.Size(49, 13)
			label341.Size = size
			Me.Label34.TabIndex = 14
			Me.Label34.Text = "Matériels"
			Me.Label33.AutoSize = True
			Dim label33 As System.Windows.Forms.Label = Me.Label33
			point = New System.Drawing.Point(290, 20)
			label33.Location = point
			Me.Label33.Name = "Label33"
			Dim label331 As System.Windows.Forms.Label = Me.Label33
			size = New System.Drawing.Size(59, 13)
			label331.Size = size
			Me.Label33.TabIndex = 13
			Me.Label33.Text = "Plantations"
			Me.Label32.BackColor = Color.Green
			Me.Label32.BorderStyle = BorderStyle.FixedSingle
			Dim label32 As System.Windows.Forms.Label = Me.Label32
			point = New System.Drawing.Point(269, 20)
			label32.Location = point
			Me.Label32.Name = "Label32"
			Dim label321 As System.Windows.Forms.Label = Me.Label32
			size = New System.Drawing.Size(15, 15)
			label321.Size = size
			Me.Label32.TabIndex = 12
			Me.Label31.BackColor = Color.DarkCyan
			Me.Label31.BorderStyle = BorderStyle.FixedSingle
			Dim label311 As System.Windows.Forms.Label = Me.Label31
			point = New System.Drawing.Point(269, 49)
			label311.Location = point
			Me.Label31.Name = "Label31"
			Dim label312 As System.Windows.Forms.Label = Me.Label31
			size = New System.Drawing.Size(15, 15)
			label312.Size = size
			Me.Label31.TabIndex = 11
			Me.Labeldiamat.BackColor = Color.DarkCyan
			Dim labeldiamat As System.Windows.Forms.Label = Me.Labeldiamat
			point = New System.Drawing.Point(159, 49)
			labeldiamat.Location = point
			Me.Labeldiamat.Name = "Labeldiamat"
			Dim labeldiamat1 As System.Windows.Forms.Label = Me.Labeldiamat
			size = New System.Drawing.Size(50, 91)
			labeldiamat1.Size = size
			Me.Labeldiamat.TabIndex = 10
			Me.Labeldiamat.TextAlign = ContentAlignment.MiddleCenter
			Me.Label29.AutoSize = True
			Dim label29 As System.Windows.Forms.Label = Me.Label29
			point = New System.Drawing.Point(33, 133)
			label29.Location = point
			Me.Label29.Name = "Label29"
			Dim label291 As System.Windows.Forms.Label = Me.Label29
			size = New System.Drawing.Size(13, 13)
			label291.Size = size
			Me.Label29.TabIndex = 9
			Me.Label29.Text = "0"
			Me.Label28.AutoSize = True
			Dim label28 As System.Windows.Forms.Label = Me.Label28
			point = New System.Drawing.Point(27, 85)
			label28.Location = point
			Me.Label28.Name = "Label28"
			Dim label281 As System.Windows.Forms.Label = Me.Label28
			size = New System.Drawing.Size(19, 13)
			label281.Size = size
			Me.Label28.TabIndex = 8
			Me.Label28.Text = "50"
			Me.Label27.AutoSize = True
			Dim label27 As System.Windows.Forms.Label = Me.Label27
			point = New System.Drawing.Point(20, 36)
			label27.Location = point
			Me.Label27.Name = "Label27"
			Dim label271 As System.Windows.Forms.Label = Me.Label27
			size = New System.Drawing.Size(25, 13)
			label271.Size = size
			Me.Label27.TabIndex = 7
			Me.Label27.Text = "100"
			Me.Label26.AutoSize = True
			Dim label26 As System.Windows.Forms.Label = Me.Label26
			point = New System.Drawing.Point(27, 10)
			label26.Location = point
			Me.Label26.Name = "Label26"
			Dim label261 As System.Windows.Forms.Label = Me.Label26
			size = New System.Drawing.Size(15, 13)
			label261.Size = size
			Me.Label26.TabIndex = 6
			Me.Label26.Text = "%"
			Me.Labeldiaplant.BackColor = Color.Green
			Dim labeldiaplant As System.Windows.Forms.Label = Me.Labeldiaplant
			point = New System.Drawing.Point(83, 49)
			labeldiaplant.Location = point
			Me.Labeldiaplant.Name = "Labeldiaplant"
			Dim labeldiaplant1 As System.Windows.Forms.Label = Me.Labeldiaplant
			size = New System.Drawing.Size(50, 91)
			labeldiaplant1.Size = size
			Me.Labeldiaplant.TabIndex = 3
			Me.Labeldiaplant.TextAlign = ContentAlignment.MiddleCenter
			Me.Label21.BackColor = Color.Black
			Dim label211 As System.Windows.Forms.Label = Me.Label21
			point = New System.Drawing.Point(48, 20)
			label211.Location = point
			Me.Label21.Name = "Label21"
			Dim label212 As System.Windows.Forms.Label = Me.Label21
			size = New System.Drawing.Size(3, 120)
			label212.Size = size
			Me.Label21.TabIndex = 1
			Me.Label21.Text = "Label21"
			Me.Label20.BackColor = Color.Black
			Dim label20 As System.Windows.Forms.Label = Me.Label20
			point = New System.Drawing.Point(48, 140)
			label20.Location = point
			Me.Label20.Name = "Label20"
			Dim label201 As System.Windows.Forms.Label = Me.Label20
			size = New System.Drawing.Size(200, 3)
			label201.Size = size
			Me.Label20.TabIndex = 0
			Me.Label20.Text = "Label20"
			Me.Label24.AutoSize = True
			Dim label24 As System.Windows.Forms.Label = Me.Label24
			point = New System.Drawing.Point(43, 35)
			label24.Location = point
			Me.Label24.Name = "Label24"
			Dim label241 As System.Windows.Forms.Label = Me.Label24
			size = New System.Drawing.Size(10, 13)
			label241.Size = size
			Me.Label24.TabIndex = 4
			Me.Label24.Text = "-"
			Me.Label22.AutoSize = True
			Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim label22 As System.Windows.Forms.Label = Me.Label22
			point = New System.Drawing.Point(34, 10)
			label22.Location = point
			Me.Label22.Name = "Label22"
			Dim label221 As System.Windows.Forms.Label = Me.Label22
			size = New System.Drawing.Size(34, 39)
			label221.Size = size
			Me.Label22.TabIndex = 2
			Me.Label22.Text = "^"
			Dim label25 As System.Windows.Forms.Label = Me.Label25
			point = New System.Drawing.Point(43, 85)
			label25.Location = point
			Me.Label25.Name = "Label25"
			Dim label251 As System.Windows.Forms.Label = Me.Label25
			size = New System.Drawing.Size(10, 13)
			label251.Size = size
			Me.Label25.TabIndex = 5
			Me.Label25.Text = "-"
			Me.Panel4.BackColor = Color.LightSteelBlue
			Me.Panel4.Controls.Add(Me.Label35)
			Me.Panel4.Controls.Add(Me.Label36)
			Me.Panel4.Controls.Add(Me.Label37)
			Me.Panel4.Controls.Add(Me.Label38)
			Me.Panel4.Controls.Add(Me.Labeldiavente)
			Me.Panel4.Controls.Add(Me.Label40)
			Me.Panel4.Controls.Add(Me.Label41)
			Me.Panel4.Controls.Add(Me.Label42)
			Me.Panel4.Controls.Add(Me.Label43)
			Me.Panel4.Controls.Add(Me.Labeldiaeco)
			Me.Panel4.Controls.Add(Me.Label45)
			Me.Panel4.Controls.Add(Me.Label46)
			Me.Panel4.Controls.Add(Me.Label47)
			Me.Panel4.Controls.Add(Me.Label48)
			Me.Panel4.Controls.Add(Me.Label49)
			Dim panel4 As System.Windows.Forms.Panel = Me.Panel4
			point = New System.Drawing.Point(414, 202)
			panel4.Location = point
			Me.Panel4.Name = "Panel4"
			Dim panel41 As System.Windows.Forms.Panel = Me.Panel4
			size = New System.Drawing.Size(376, 161)
			panel41.Size = size
			Me.Panel4.TabIndex = 20
			Me.Label35.AutoSize = True
			Dim label35 As System.Windows.Forms.Label = Me.Label35
			point = New System.Drawing.Point(290, 51)
			label35.Location = point
			Me.Label35.Name = "Label35"
			Dim label351 As System.Windows.Forms.Label = Me.Label35
			size = New System.Drawing.Size(40, 13)
			label351.Size = size
			Me.Label35.TabIndex = 14
			Me.Label35.Text = "Ventes"
			Me.Label36.AutoSize = True
			Dim label36 As System.Windows.Forms.Label = Me.Label36
			point = New System.Drawing.Point(290, 20)
			label36.Location = point
			Me.Label36.Name = "Label36"
			Dim label361 As System.Windows.Forms.Label = Me.Label36
			size = New System.Drawing.Size(59, 13)
			label361.Size = size
			Me.Label36.TabIndex = 13
			Me.Label36.Text = "Economies"
			Me.Label37.BackColor = Color.DarkViolet
			Me.Label37.BorderStyle = BorderStyle.FixedSingle
			Dim label37 As System.Windows.Forms.Label = Me.Label37
			point = New System.Drawing.Point(269, 20)
			label37.Location = point
			Me.Label37.Name = "Label37"
			Dim label371 As System.Windows.Forms.Label = Me.Label37
			size = New System.Drawing.Size(15, 15)
			label371.Size = size
			Me.Label37.TabIndex = 12
			Me.Label38.BackColor = Color.Goldenrod
			Me.Label38.BorderStyle = BorderStyle.FixedSingle
			Dim label38 As System.Windows.Forms.Label = Me.Label38
			point = New System.Drawing.Point(269, 49)
			label38.Location = point
			Me.Label38.Name = "Label38"
			Dim label381 As System.Windows.Forms.Label = Me.Label38
			size = New System.Drawing.Size(15, 15)
			label381.Size = size
			Me.Label38.TabIndex = 11
			Me.Labeldiavente.BackColor = Color.Goldenrod
			Dim labeldiavente As System.Windows.Forms.Label = Me.Labeldiavente
			point = New System.Drawing.Point(159, 49)
			labeldiavente.Location = point
			Me.Labeldiavente.Name = "Labeldiavente"
			Dim labeldiavente1 As System.Windows.Forms.Label = Me.Labeldiavente
			size = New System.Drawing.Size(50, 91)
			labeldiavente1.Size = size
			Me.Labeldiavente.TabIndex = 10
			Me.Labeldiavente.TextAlign = ContentAlignment.MiddleCenter
			Me.Label40.AutoSize = True
			Dim label40 As System.Windows.Forms.Label = Me.Label40
			point = New System.Drawing.Point(33, 133)
			label40.Location = point
			Me.Label40.Name = "Label40"
			Dim label401 As System.Windows.Forms.Label = Me.Label40
			size = New System.Drawing.Size(13, 13)
			label401.Size = size
			Me.Label40.TabIndex = 9
			Me.Label40.Text = "0"
			Me.Label41.AutoSize = True
			Dim label411 As System.Windows.Forms.Label = Me.Label41
			point = New System.Drawing.Point(27, 85)
			label411.Location = point
			Me.Label41.Name = "Label41"
			Dim label412 As System.Windows.Forms.Label = Me.Label41
			size = New System.Drawing.Size(19, 13)
			label412.Size = size
			Me.Label41.TabIndex = 8
			Me.Label41.Text = "50"
			Me.Label42.AutoSize = True
			Dim label42 As System.Windows.Forms.Label = Me.Label42
			point = New System.Drawing.Point(20, 36)
			label42.Location = point
			Me.Label42.Name = "Label42"
			Dim label421 As System.Windows.Forms.Label = Me.Label42
			size = New System.Drawing.Size(25, 13)
			label421.Size = size
			Me.Label42.TabIndex = 7
			Me.Label42.Text = "100"
			Me.Label43.AutoSize = True
			Dim label43 As System.Windows.Forms.Label = Me.Label43
			point = New System.Drawing.Point(27, 10)
			label43.Location = point
			Me.Label43.Name = "Label43"
			Dim label431 As System.Windows.Forms.Label = Me.Label43
			size = New System.Drawing.Size(15, 13)
			label431.Size = size
			Me.Label43.TabIndex = 6
			Me.Label43.Text = "%"
			Me.Labeldiaeco.BackColor = Color.DarkViolet
			Dim labeldiaeco As System.Windows.Forms.Label = Me.Labeldiaeco
			point = New System.Drawing.Point(83, 49)
			labeldiaeco.Location = point
			Me.Labeldiaeco.Name = "Labeldiaeco"
			Dim labeldiaeco1 As System.Windows.Forms.Label = Me.Labeldiaeco
			size = New System.Drawing.Size(50, 91)
			labeldiaeco1.Size = size
			Me.Labeldiaeco.TabIndex = 3
			Me.Labeldiaeco.TextAlign = ContentAlignment.MiddleCenter
			Me.Label45.BackColor = Color.Black
			Dim label45 As System.Windows.Forms.Label = Me.Label45
			point = New System.Drawing.Point(48, 20)
			label45.Location = point
			Me.Label45.Name = "Label45"
			Dim label451 As System.Windows.Forms.Label = Me.Label45
			size = New System.Drawing.Size(3, 120)
			label451.Size = size
			Me.Label45.TabIndex = 1
			Me.Label45.Text = "Label45"
			Me.Label46.BackColor = Color.Black
			Dim label46 As System.Windows.Forms.Label = Me.Label46
			point = New System.Drawing.Point(48, 140)
			label46.Location = point
			Me.Label46.Name = "Label46"
			Dim label461 As System.Windows.Forms.Label = Me.Label46
			size = New System.Drawing.Size(200, 3)
			label461.Size = size
			Me.Label46.TabIndex = 0
			Me.Label46.Text = "Label46"
			Me.Label47.AutoSize = True
			Dim label47 As System.Windows.Forms.Label = Me.Label47
			point = New System.Drawing.Point(43, 35)
			label47.Location = point
			Me.Label47.Name = "Label47"
			Dim label471 As System.Windows.Forms.Label = Me.Label47
			size = New System.Drawing.Size(10, 13)
			label471.Size = size
			Me.Label47.TabIndex = 4
			Me.Label47.Text = "-"
			Me.Label48.AutoSize = True
			Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim label48 As System.Windows.Forms.Label = Me.Label48
			point = New System.Drawing.Point(34, 10)
			label48.Location = point
			Me.Label48.Name = "Label48"
			Dim label481 As System.Windows.Forms.Label = Me.Label48
			size = New System.Drawing.Size(34, 39)
			label481.Size = size
			Me.Label48.TabIndex = 2
			Me.Label48.Text = "^"
			Dim label49 As System.Windows.Forms.Label = Me.Label49
			point = New System.Drawing.Point(43, 85)
			label49.Location = point
			Me.Label49.Name = "Label49"
			Dim label491 As System.Windows.Forms.Label = Me.Label49
			size = New System.Drawing.Size(10, 13)
			label491.Size = size
			Me.Label49.TabIndex = 5
			Me.Label49.Text = "-"
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.RoyalBlue
			size = New System.Drawing.Size(834, 476)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel4)
			Me.Controls.Add(Me.Panel3)
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Panel1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.Name = "Formbilanfin"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Bilan Financier"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			Me.Panel2.PerformLayout()
			Me.Panel3.ResumeLayout(False)
			Me.Panel3.PerformLayout()
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace