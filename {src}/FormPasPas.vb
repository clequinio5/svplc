Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports Microsoft.Win32
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormPasPas
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Panel")>
		Private _Panel As System.Windows.Forms.Panel

		<AccessedThroughProperty("Buttonreset")>
		Private _Buttonreset As Button

		<AccessedThroughProperty("CheckBoxsupp")>
		Private _CheckBoxsupp As CheckBox

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As System.Windows.Forms.Panel

		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		<AccessedThroughProperty("BackgroundWorker1")>
		Private _BackgroundWorker1 As BackgroundWorker

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Buttonchangementimg")>
		Private _Buttonchangementimg As Button

		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		<AccessedThroughProperty("ImageList2")>
		Private _ImageList2 As ImageList

		<AccessedThroughProperty("Tableauannee")>
		Private _Tableauannee As myGroupBox

		<AccessedThroughProperty("MyGroupBox1")>
		Private _MyGroupBox1 As myGroupBox

		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		<AccessedThroughProperty("Buttonsauvegarder")>
		Private _Buttonsauvegarder As Button

		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		<AccessedThroughProperty("MyGroupBox2")>
		Private _MyGroupBox2 As myGroupBox

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("OpenFileDialog2")>
		Private _OpenFileDialog2 As OpenFileDialog

		<AccessedThroughProperty("Buttonimporter")>
		Private _Buttonimporter As Button

		<AccessedThroughProperty("Buttonenregistrer")>
		Private _Buttonenregistrer As Button

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Bordannee1")>
		Private _Bordannee1 As myGroupBox

		<AccessedThroughProperty("PictureBoxannee1")>
		Private _PictureBoxannee1 As PictureBox

		<AccessedThroughProperty("Bordannee2")>
		Private _Bordannee2 As myGroupBox

		<AccessedThroughProperty("PictureBoxannee2")>
		Private _PictureBoxannee2 As PictureBox

		<AccessedThroughProperty("Bordannee0")>
		Private _Bordannee0 As myGroupBox

		<AccessedThroughProperty("PictureBoxannee0")>
		Private _PictureBoxannee0 As PictureBox

		<AccessedThroughProperty("Assopos")>
		Private _Assopos As Label

		<AccessedThroughProperty("Assoneg")>
		Private _Assoneg As Label

		<AccessedThroughProperty("Assoechelle")>
		Private _Assoechelle As Label

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("Rotneg")>
		Private _Rotneg As Label

		<AccessedThroughProperty("Rotpos")>
		Private _Rotpos As Label

		<AccessedThroughProperty("Rotechelle")>
		Private _Rotechelle As Label

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		<AccessedThroughProperty("ImageList3")>
		Private _ImageList3 As ImageList

		<AccessedThroughProperty("ImageList4")>
		Private _ImageList4 As ImageList

		<AccessedThroughProperty("ImageList5")>
		Private _ImageList5 As ImageList

		<AccessedThroughProperty("ImageList6")>
		Private _ImageList6 As ImageList

		<AccessedThroughProperty("Buttonajouter")>
		Private _Buttonajouter As Button

		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("MenuPrinc")>
		Private _MenuPrinc As MenuStrip

		<AccessedThroughProperty("FichierMenu")>
		Private _FichierMenu As ToolStripMenuItem

		<AccessedThroughProperty("ImprimerMenu")>
		Private _ImprimerMenu As ToolStripMenuItem

		<AccessedThroughProperty("QuitterMenu")>
		Private _QuitterMenu As ToolStripMenuItem

		<AccessedThroughProperty("BasededonneesMenu")>
		Private _BasededonneesMenu As ToolStripMenuItem

		<AccessedThroughProperty("BDDAssociationsMenu")>
		Private _BDDAssociationsMenu As ToolStripMenuItem

		<AccessedThroughProperty("BDDRotationsMenu")>
		Private _BDDRotationsMenu As ToolStripMenuItem

		<AccessedThroughProperty("BDDCalendrierMenu")>
		Private _BDDCalendrierMenu As ToolStripMenuItem

		<AccessedThroughProperty("ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem")>
		Private _ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("AjouterUnNouveauLégumeToolStripMenuItem")>
		Private _AjouterUnNouveauLégumeToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("RenommerUnLégumeExistantToolStripMenuItem")>
		Private _RenommerUnLégumeExistantToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("SupprimerUnLégumeToolStripMenuItem")>
		Private _SupprimerUnLégumeToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("OutilsToolStripMenuItem")>
		Private _OutilsToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("MonJardinMenu")>
		Private _MonJardinMenu As ToolStripMenuItem

		<AccessedThroughProperty("CalculatriceToolStripMenuItem")>
		Private _CalculatriceToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("CalendrierLunaireToolStripMenuItem")>
		Private _CalendrierLunaireToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("BibliothèqueMenu")>
		Private _BibliothèqueMenu As ToolStripMenuItem

		<AccessedThroughProperty("HelpMenu")>
		Private _HelpMenu As ToolStripMenuItem

		<AccessedThroughProperty("AProposDeMenu")>
		Private _AProposDeMenu As ToolStripMenuItem

		<AccessedThroughProperty("AboutMenu")>
		Private _AboutMenu As ToolStripMenuItem

		<AccessedThroughProperty("Panel5")>
		Private _Panel5 As System.Windows.Forms.Panel

		<AccessedThroughProperty("Panel6")>
		Private _Panel6 As System.Windows.Forms.Panel

		<AccessedThroughProperty("Panelonglet")>
		Private _Panelonglet As System.Windows.Forms.Panel

		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		<AccessedThroughProperty("PrintDocument1")>
		Private _PrintDocument1 As PrintDocument

		<AccessedThroughProperty("Infobullegrille")>
		Private _Infobullegrille As ToolTip

		<AccessedThroughProperty("Infobulleraccourcis")>
		Private _Infobulleraccourcis As ToolTip

		<AccessedThroughProperty("Infobullegrille2")>
		Private _Infobullegrille2 As ToolTip

		<AccessedThroughProperty("Ttradiobutton")>
		Private _Ttradiobutton As ToolTip

		<AccessedThroughProperty("ImageList7")>
		Private _ImageList7 As ImageList

		<AccessedThroughProperty("Timerinstallmsg")>
		Private _Timerinstallmsg As Timer

		<AccessedThroughProperty("CustomTabControl1")>
		Private _CustomTabControl1 As CustomTabControl

		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		<AccessedThroughProperty("PictureBoxpanneau")>
		Private _PictureBoxpanneau As PictureBox

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Buttonnbrcellules")>
		Private _Buttonnbrcellules As Button

		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As System.Windows.Forms.Panel

		<AccessedThroughProperty("Button9")>
		Private _Button9 As Button

		<AccessedThroughProperty("Button8")>
		Private _Button8 As Button

		<AccessedThroughProperty("Labelcote")>
		Private _Labelcote As Label

		<AccessedThroughProperty("FaireUnDonToolStripMenuItem")>
		Private _FaireUnDonToolStripMenuItem As ToolStripMenuItem

		<AccessedThroughProperty("CacherLaBarreDeTâcheToolStripMenuItem")>
		Private _CacherLaBarreDeTâcheToolStripMenuItem As ToolStripMenuItem

		Private stpwch As Stopwatch

		Public activation As Boolean

		Public util As String

		Public activcode As String

		Public version As String

		Public jrestant As Integer

		Public titrephot As String

		Public datephot As String

		Public comphot As String

		Public Recoltedata As String()

		Public Materieldata As String()

		Public Gardenfinance As Double()

		Public stringinputbox As String

		Public titreinput As String

		Public labelinput As String

		Public reponse As String

		Public msgboxtitre As String

		Public msgboxmess As String

		Public pathbmp As String

		Private CBDDFiche As FormBDDFICHE

		Private CBDDCAL As FormBDDCal

		Private CBDDASS As FormBDDASS

		Private CBDDROT As FormBDDROT

		Private WinMonJardin As FormMonJardin

		Private WinCalLun As FormCalLun

		Private CALCULTRC As Calculatrice

		Private WinInternet As FormInternet

		Private fenfiche As Fiche

		Private Winpaypal As Formpaypal

		Private WinInputbox As FormInputbox

		Private WinApropos As Formapropos

		Private lecture As StringReader

		Private lecture0 As StreamReader

		Public imgtoadd As String

		Public txttoadd As String

		Private nbchecklarge As Integer

		Private comptpos As Integer

		Private hautp As Integer

		Private largp As Integer

		Private surf As Integer

		Private im As Integer

		Private tague As Integer

		Private tague2 As Integer

		Private indexselectsurf As Integer

		Private indexselectamen As Integer

		Private GrilleReferente As Integer(,)

		Private comptneg As Integer

		Private comptech As Integer

		Private assod As Integer

		Private assog As Integer

		Private assoh As Integer

		Private indexselectleg As Integer

		Private leg1 As Integer

		Private leg2 As Integer

		Private assob As Integer

		Private compt As Integer

		Private haut As Integer

		Private larg As Integer

		Private nbrcellules As Integer

		Private cotecelluleX As Integer

		Private cotecelluleY As Integer

		Private cotecelluleX2 As Integer

		Private cotecelluleY2 As Integer

		Private espaceentredeuxcellules As Integer

		Private espaceentredeuxcellules2 As Integer

		Private Lgrille As Integer

		Private Hgrille As Integer

		Private Mgauche As Integer

		Private Mhaut As Integer

		Private grille As SVPLCApplication.PictureBox1(,)

		Private grille2 As SVPLCApplication.PictureBox1(,)

		Private doctxt As String()

		Private doctxt2 As String()

		Private nomfichier As String

		Private cheminfichier As String()

		Private lignefichiertxt As String()

		Private check As RadioButton(,)

		Private surface As RadioButton(,)

		Private amen As RadioButton(,)

		Private imagetraitee As Image

		Private imagetraitee2 As Image

		Private fs As FileStream

		Private fs2 As FileStream

		Private Ecriture As StreamWriter

		Private Lect As StreamReader

		Private coordX As Integer

		Private coordY As Integer

		Private nbrligne As Integer

		Private lignefichiertxtconverties As Integer()

		Private installmsg As Integer

		Private Const nbrcellulespanel As Integer = 16

		Private Const TASKBAR_SHOW As Integer = 64

		Private Const TASKBAR_HIDE As Integer = 128

		Private pos As Integer

		Private neg As Integer

		Private ech As Integer

		Private trouve As Boolean

		Private ind As Integer

		Private memoryImage As Bitmap

		Friend Overridable Property AboutMenu As ToolStripMenuItem
			Get
				Return Me._AboutMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.AboutToolStripMenuItem_Click)
				If (Me._AboutMenu IsNot Nothing) Then
					RemoveHandler Me._AboutMenu.Click,  eventHandler
				End If
				Me._AboutMenu = value
				If (Me._AboutMenu IsNot Nothing) Then
					AddHandler Me._AboutMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property AjouterUnNouveauLégumeToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._AjouterUnNouveauLégumeToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.AjouterUnNouveauLégumeToolStripMenuItem_Click)
				If (Me._AjouterUnNouveauLégumeToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._AjouterUnNouveauLégumeToolStripMenuItem.Click,  eventHandler
				End If
				Me._AjouterUnNouveauLégumeToolStripMenuItem = value
				If (Me._AjouterUnNouveauLégumeToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._AjouterUnNouveauLégumeToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property AProposDeMenu As ToolStripMenuItem
			Get
				Return Me._AProposDeMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.AProposDeToolStripMenuItem_Click)
				If (Me._AProposDeMenu IsNot Nothing) Then
					RemoveHandler Me._AProposDeMenu.Click,  eventHandler
				End If
				Me._AProposDeMenu = value
				If (Me._AProposDeMenu IsNot Nothing) Then
					AddHandler Me._AProposDeMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Assoechelle As Label
			Get
				Return Me._Assoechelle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Assoechelle = value
			End Set
		End Property

		Friend Overridable Property Assoneg As Label
			Get
				Return Me._Assoneg
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Assoneg = value
			End Set
		End Property

		Friend Overridable Property Assopos As Label
			Get
				Return Me._Assopos
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Assopos = value
			End Set
		End Property

		Friend Overridable Property BackgroundWorker1 As BackgroundWorker
			Get
				Return Me._BackgroundWorker1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim formPasPa As FormPasPas = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf formPasPa.BackgroundWorker1_DoWork)
				If (Me._BackgroundWorker1 IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorker1.DoWork,  doWorkEventHandler
				End If
				Me._BackgroundWorker1 = value
				If (Me._BackgroundWorker1 IsNot Nothing) Then
					AddHandler Me._BackgroundWorker1.DoWork,  doWorkEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property BasededonneesMenu As ToolStripMenuItem
			Get
				Return Me._BasededonneesMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Me._BasededonneesMenu = value
			End Set
		End Property

		Friend Overridable Property BDDAssociationsMenu As ToolStripMenuItem
			Get
				Return Me._BDDAssociationsMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.ConsulterEtGérerLaBasedeDonnéesAssociationsToolStripMenuItem_Click)
				If (Me._BDDAssociationsMenu IsNot Nothing) Then
					RemoveHandler Me._BDDAssociationsMenu.Click,  eventHandler
				End If
				Me._BDDAssociationsMenu = value
				If (Me._BDDAssociationsMenu IsNot Nothing) Then
					AddHandler Me._BDDAssociationsMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property BDDCalendrierMenu As ToolStripMenuItem
			Get
				Return Me._BDDCalendrierMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.ConsulterEtGérerLaBaseDeDonnéesCalendrierToolStripMenuItem_Click)
				If (Me._BDDCalendrierMenu IsNot Nothing) Then
					RemoveHandler Me._BDDCalendrierMenu.Click,  eventHandler
				End If
				Me._BDDCalendrierMenu = value
				If (Me._BDDCalendrierMenu IsNot Nothing) Then
					AddHandler Me._BDDCalendrierMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property BDDRotationsMenu As ToolStripMenuItem
			Get
				Return Me._BDDRotationsMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.ConsulterEtGérerLaBaseDeDonnéesRotationsToolStripMenuItem_Click)
				If (Me._BDDRotationsMenu IsNot Nothing) Then
					RemoveHandler Me._BDDRotationsMenu.Click,  eventHandler
				End If
				Me._BDDRotationsMenu = value
				If (Me._BDDRotationsMenu IsNot Nothing) Then
					AddHandler Me._BDDRotationsMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property BibliothèqueMenu As ToolStripMenuItem
			Get
				Return Me._BibliothèqueMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.BibliothèqueToolStripMenuItem_Click)
				If (Me._BibliothèqueMenu IsNot Nothing) Then
					RemoveHandler Me._BibliothèqueMenu.Click,  eventHandler
				End If
				Me._BibliothèqueMenu = value
				If (Me._BibliothèqueMenu IsNot Nothing) Then
					AddHandler Me._BibliothèqueMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Bordannee0 As myGroupBox
			Get
				Return Me._Bordannee0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._Bordannee0 = value
			End Set
		End Property

		Friend Overridable Property Bordannee1 As myGroupBox
			Get
				Return Me._Bordannee1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._Bordannee1 = value
			End Set
		End Property

		Friend Overridable Property Bordannee2 As myGroupBox
			Get
				Return Me._Bordannee2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._Bordannee2 = value
			End Set
		End Property

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button1_Click_1)
				If (Me._Button1 IsNot Nothing) Then
					RemoveHandler Me._Button1.Click,  eventHandler
				End If
				Me._Button1 = value
				If (Me._Button1 IsNot Nothing) Then
					AddHandler Me._Button1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button2 As Button
			Get
				Return Me._Button2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button2_Click_2)
				If (Me._Button2 IsNot Nothing) Then
					RemoveHandler Me._Button2.Click,  eventHandler
				End If
				Me._Button2 = value
				If (Me._Button2 IsNot Nothing) Then
					AddHandler Me._Button2.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button3 As Button
			Get
				Return Me._Button3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button3_Click_1)
				If (Me._Button3 IsNot Nothing) Then
					RemoveHandler Me._Button3.Click,  eventHandler
				End If
				Me._Button3 = value
				If (Me._Button3 IsNot Nothing) Then
					AddHandler Me._Button3.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button4 As Button
			Get
				Return Me._Button4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button4_Click_1)
				If (Me._Button4 IsNot Nothing) Then
					RemoveHandler Me._Button4.Click,  eventHandler
				End If
				Me._Button4 = value
				If (Me._Button4 IsNot Nothing) Then
					AddHandler Me._Button4.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button5 As Button
			Get
				Return Me._Button5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button5_Click)
				If (Me._Button5 IsNot Nothing) Then
					RemoveHandler Me._Button5.Click,  eventHandler
				End If
				Me._Button5 = value
				If (Me._Button5 IsNot Nothing) Then
					AddHandler Me._Button5.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button6 As Button
			Get
				Return Me._Button6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button6_Click)
				If (Me._Button6 IsNot Nothing) Then
					RemoveHandler Me._Button6.Click,  eventHandler
				End If
				Me._Button6 = value
				If (Me._Button6 IsNot Nothing) Then
					AddHandler Me._Button6.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button7 As Button
			Get
				Return Me._Button7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button7_Click)
				If (Me._Button7 IsNot Nothing) Then
					RemoveHandler Me._Button7.Click,  eventHandler
				End If
				Me._Button7 = value
				If (Me._Button7 IsNot Nothing) Then
					AddHandler Me._Button7.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button8 As Button
			Get
				Return Me._Button8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button8_Click_1)
				If (Me._Button8 IsNot Nothing) Then
					RemoveHandler Me._Button8.Click,  eventHandler
				End If
				Me._Button8 = value
				If (Me._Button8 IsNot Nothing) Then
					AddHandler Me._Button8.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button9 As Button
			Get
				Return Me._Button9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button9_Click)
				If (Me._Button9 IsNot Nothing) Then
					RemoveHandler Me._Button9.Click,  eventHandler
				End If
				Me._Button9 = value
				If (Me._Button9 IsNot Nothing) Then
					AddHandler Me._Button9.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonajouter As Button
			Get
				Return Me._Buttonajouter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Buttonajouter_Click)
				If (Me._Buttonajouter IsNot Nothing) Then
					RemoveHandler Me._Buttonajouter.Click,  eventHandler
				End If
				Me._Buttonajouter = value
				If (Me._Buttonajouter IsNot Nothing) Then
					AddHandler Me._Buttonajouter.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonchangementimg As Button
			Get
				Return Me._Buttonchangementimg
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button1_Click)
				If (Me._Buttonchangementimg IsNot Nothing) Then
					RemoveHandler Me._Buttonchangementimg.Click,  eventHandler
				End If
				Me._Buttonchangementimg = value
				If (Me._Buttonchangementimg IsNot Nothing) Then
					AddHandler Me._Buttonchangementimg.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonenregistrer As Button
			Get
				Return Me._Buttonenregistrer
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.ENREGISTRER)
				If (Me._Buttonenregistrer IsNot Nothing) Then
					RemoveHandler Me._Buttonenregistrer.Click,  eventHandler
				End If
				Me._Buttonenregistrer = value
				If (Me._Buttonenregistrer IsNot Nothing) Then
					AddHandler Me._Buttonenregistrer.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonimporter As Button
			Get
				Return Me._Buttonimporter
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.IMPORTER)
				If (Me._Buttonimporter IsNot Nothing) Then
					RemoveHandler Me._Buttonimporter.Click,  eventHandler
				End If
				Me._Buttonimporter = value
				If (Me._Buttonimporter IsNot Nothing) Then
					AddHandler Me._Buttonimporter.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonnbrcellules As Button
			Get
				Return Me._Buttonnbrcellules
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Button8_Click)
				If (Me._Buttonnbrcellules IsNot Nothing) Then
					RemoveHandler Me._Buttonnbrcellules.Click,  eventHandler
				End If
				Me._Buttonnbrcellules = value
				If (Me._Buttonnbrcellules IsNot Nothing) Then
					AddHandler Me._Buttonnbrcellules.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonreset As Button
			Get
				Return Me._Buttonreset
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Buttonreset_Click)
				If (Me._Buttonreset IsNot Nothing) Then
					RemoveHandler Me._Buttonreset.Click,  eventHandler
				End If
				Me._Buttonreset = value
				If (Me._Buttonreset IsNot Nothing) Then
					AddHandler Me._Buttonreset.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonsauvegarder As Button
			Get
				Return Me._Buttonsauvegarder
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.SAUVEGARDER)
				If (Me._Buttonsauvegarder IsNot Nothing) Then
					RemoveHandler Me._Buttonsauvegarder.Click,  eventHandler
				End If
				Me._Buttonsauvegarder = value
				If (Me._Buttonsauvegarder IsNot Nothing) Then
					AddHandler Me._Buttonsauvegarder.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CacherLaBarreDeTâcheToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._CacherLaBarreDeTâcheToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.CacherLaBarreDeTâcheToolStripMenuItem_Click)
				If (Me._CacherLaBarreDeTâcheToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._CacherLaBarreDeTâcheToolStripMenuItem.Click,  eventHandler
				End If
				Me._CacherLaBarreDeTâcheToolStripMenuItem = value
				If (Me._CacherLaBarreDeTâcheToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._CacherLaBarreDeTâcheToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CalculatriceToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._CalculatriceToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.ModePasÀPasToolStripMenuItem_Click)
				If (Me._CalculatriceToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._CalculatriceToolStripMenuItem.Click,  eventHandler
				End If
				Me._CalculatriceToolStripMenuItem = value
				If (Me._CalculatriceToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._CalculatriceToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CalendrierLunaireToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._CalendrierLunaireToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.CalendrierLunaireToolStripMenuItem_Click)
				If (Me._CalendrierLunaireToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._CalendrierLunaireToolStripMenuItem.Click,  eventHandler
				End If
				Me._CalendrierLunaireToolStripMenuItem = value
				If (Me._CalendrierLunaireToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._CalendrierLunaireToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBoxsupp As CheckBox
			Get
				Return Me._CheckBoxsupp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.CheckBoxsupp_CheckedChanged)
				If (Me._CheckBoxsupp IsNot Nothing) Then
					RemoveHandler Me._CheckBoxsupp.CheckedChanged,  eventHandler
				End If
				Me._CheckBoxsupp = value
				If (Me._CheckBoxsupp IsNot Nothing) Then
					AddHandler Me._CheckBoxsupp.CheckedChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem_Click)
				If (Me._ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem.Click,  eventHandler
				End If
				Me._ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem = value
				If (Me._ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CustomTabControl1 As CustomTabControl
			Get
				Return Me._CustomTabControl1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CustomTabControl)
				Me._CustomTabControl1 = value
			End Set
		End Property

		Friend Overridable Property FaireUnDonToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._FaireUnDonToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.FaireUnDonToolStripMenuItem_Click)
				If (Me._FaireUnDonToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._FaireUnDonToolStripMenuItem.Click,  eventHandler
				End If
				Me._FaireUnDonToolStripMenuItem = value
				If (Me._FaireUnDonToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._FaireUnDonToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property FichierMenu As ToolStripMenuItem
			Get
				Return Me._FichierMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Me._FichierMenu = value
			End Set
		End Property

		Friend Overridable Property HelpMenu As ToolStripMenuItem
			Get
				Return Me._HelpMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Me._HelpMenu = value
			End Set
		End Property

		Friend Overridable Property ImageList1 As ImageList
			Get
				Return Me._ImageList1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		Friend Overridable Property ImageList2 As ImageList
			Get
				Return Me._ImageList2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ImageList)
				Me._ImageList2 = value
			End Set
		End Property

		Friend Overridable Property ImageList3 As ImageList
			Get
				Return Me._ImageList3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ImageList)
				Me._ImageList3 = value
			End Set
		End Property

		Friend Overridable Property ImageList4 As ImageList
			Get
				Return Me._ImageList4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ImageList)
				Me._ImageList4 = value
			End Set
		End Property

		Friend Overridable Property ImageList5 As ImageList
			Get
				Return Me._ImageList5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ImageList)
				Me._ImageList5 = value
			End Set
		End Property

		Friend Overridable Property ImageList6 As ImageList
			Get
				Return Me._ImageList6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ImageList)
				Me._ImageList6 = value
			End Set
		End Property

		Friend Overridable Property ImageList7 As ImageList
			Get
				Return Me._ImageList7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ImageList)
				Me._ImageList7 = value
			End Set
		End Property

		Friend Overridable Property ImprimerMenu As ToolStripMenuItem
			Get
				Return Me._ImprimerMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.PrintButton_Click)
				If (Me._ImprimerMenu IsNot Nothing) Then
					RemoveHandler Me._ImprimerMenu.Click,  eventHandler
				End If
				Me._ImprimerMenu = value
				If (Me._ImprimerMenu IsNot Nothing) Then
					AddHandler Me._ImprimerMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Infobullegrille As ToolTip
			Get
				Return Me._Infobullegrille
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolTip)
				Me._Infobullegrille = value
			End Set
		End Property

		Friend Overridable Property Infobullegrille2 As ToolTip
			Get
				Return Me._Infobullegrille2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolTip)
				Me._Infobullegrille2 = value
			End Set
		End Property

		Friend Overridable Property Infobulleraccourcis As ToolTip
			Get
				Return Me._Infobulleraccourcis
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolTip)
				Me._Infobulleraccourcis = value
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

		Friend Overridable Property Label2 As Label
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

		Friend Overridable Property Label7 As Label
			Get
				Return Me._Label7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label7 = value
			End Set
		End Property

		Friend Overridable Property Labelcote As Label
			Get
				Return Me._Labelcote
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelcote = value
			End Set
		End Property

		Friend Overridable Property MenuPrinc As MenuStrip
			Get
				Return Me._MenuPrinc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As MenuStrip)
				Me._MenuPrinc = value
			End Set
		End Property

		Friend Overridable Property MonJardinMenu As ToolStripMenuItem
			Get
				Return Me._MonJardinMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.MonJardinToolStripMenuItem_Click)
				If (Me._MonJardinMenu IsNot Nothing) Then
					RemoveHandler Me._MonJardinMenu.Click,  eventHandler
				End If
				Me._MonJardinMenu = value
				If (Me._MonJardinMenu IsNot Nothing) Then
					AddHandler Me._MonJardinMenu.Click,  eventHandler
				End If
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

		Friend Overridable Property MyGroupBox2 As myGroupBox
			Get
				Return Me._MyGroupBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._MyGroupBox2 = value
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

		Friend Overridable Property OpenFileDialog2 As OpenFileDialog
			Get
				Return Me._OpenFileDialog2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As OpenFileDialog)
				Me._OpenFileDialog2 = value
			End Set
		End Property

		Friend Overridable Property OutilsToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._OutilsToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Me._OutilsToolStripMenuItem = value
			End Set
		End Property

		Friend Overridable Property Panel As System.Windows.Forms.Panel
			Get
				Return Me._Panel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Panel = value
			End Set
		End Property

		Friend Overridable Property Panel1 As System.Windows.Forms.Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Panel1 = value
			End Set
		End Property

		Friend Overridable Property Panel2 As System.Windows.Forms.Panel
			Get
				Return Me._Panel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Panel2 = value
			End Set
		End Property

		Friend Overridable Property Panel5 As System.Windows.Forms.Panel
			Get
				Return Me._Panel5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Panel5 = value
			End Set
		End Property

		Friend Overridable Property Panel6 As System.Windows.Forms.Panel
			Get
				Return Me._Panel6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Panel6 = value
			End Set
		End Property

		Friend Overridable Property Panelonglet As System.Windows.Forms.Panel
			Get
				Return Me._Panelonglet
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Panelonglet_MouseEnter)
				Dim formPasPa1 As FormPasPas = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf formPasPa1.Panelonglet_MouseLeave)
				If (Me._Panelonglet IsNot Nothing) Then
					RemoveHandler Me._Panelonglet.MouseEnter,  eventHandler
					RemoveHandler Me._Panelonglet.MouseLeave,  eventHandler1
				End If
				Me._Panelonglet = value
				If (Me._Panelonglet IsNot Nothing) Then
					AddHandler Me._Panelonglet.MouseEnter,  eventHandler
					AddHandler Me._Panelonglet.MouseLeave,  eventHandler1
				End If
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
				Me._PictureBox3 = value
			End Set
		End Property

		Friend Overridable Property PictureBox4 As PictureBox
			Get
				Return Me._PictureBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox4 = value
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

		Friend Overridable Property PictureBoxannee0 As PictureBox
			Get
				Return Me._PictureBoxannee0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.PictureBox0_Click)
				If (Me._PictureBoxannee0 IsNot Nothing) Then
					RemoveHandler Me._PictureBoxannee0.Click,  eventHandler
				End If
				Me._PictureBoxannee0 = value
				If (Me._PictureBoxannee0 IsNot Nothing) Then
					AddHandler Me._PictureBoxannee0.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property PictureBoxannee1 As PictureBox
			Get
				Return Me._PictureBoxannee1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.PictureBoxannee1_Click)
				If (Me._PictureBoxannee1 IsNot Nothing) Then
					RemoveHandler Me._PictureBoxannee1.Click,  eventHandler
				End If
				Me._PictureBoxannee1 = value
				If (Me._PictureBoxannee1 IsNot Nothing) Then
					AddHandler Me._PictureBoxannee1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property PictureBoxannee2 As PictureBox
			Get
				Return Me._PictureBoxannee2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.PictureBoxannee2_Click)
				If (Me._PictureBoxannee2 IsNot Nothing) Then
					RemoveHandler Me._PictureBoxannee2.Click,  eventHandler
				End If
				Me._PictureBoxannee2 = value
				If (Me._PictureBoxannee2 IsNot Nothing) Then
					AddHandler Me._PictureBoxannee2.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property PictureBoxpanneau As PictureBox
			Get
				Return Me._PictureBoxpanneau
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoxpanneau = value
			End Set
		End Property

		Friend Overridable Property PrintDocument1 As PrintDocument
			Get
				Return Me._PrintDocument1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Dim formPasPa As FormPasPas = Me
				Dim printPageEventHandler As System.Drawing.Printing.PrintPageEventHandler = New System.Drawing.Printing.PrintPageEventHandler(AddressOf formPasPa.PrintDocument1_PrintPage)
				If (Me._PrintDocument1 IsNot Nothing) Then
					RemoveHandler Me._PrintDocument1.PrintPage,  printPageEventHandler
				End If
				Me._PrintDocument1 = value
				If (Me._PrintDocument1 IsNot Nothing) Then
					AddHandler Me._PrintDocument1.PrintPage,  printPageEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property QuitterMenu As ToolStripMenuItem
			Get
				Return Me._QuitterMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.QuitterToolStripMenuItem_Click)
				If (Me._QuitterMenu IsNot Nothing) Then
					RemoveHandler Me._QuitterMenu.Click,  eventHandler
				End If
				Me._QuitterMenu = value
				If (Me._QuitterMenu IsNot Nothing) Then
					AddHandler Me._QuitterMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property RenommerUnLégumeExistantToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._RenommerUnLégumeExistantToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.RenommerUnLégumeExistantToolStripMenuItem_Click)
				If (Me._RenommerUnLégumeExistantToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._RenommerUnLégumeExistantToolStripMenuItem.Click,  eventHandler
				End If
				Me._RenommerUnLégumeExistantToolStripMenuItem = value
				If (Me._RenommerUnLégumeExistantToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._RenommerUnLégumeExistantToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Rotechelle As Label
			Get
				Return Me._Rotechelle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Rotechelle = value
			End Set
		End Property

		Friend Overridable Property Rotneg As Label
			Get
				Return Me._Rotneg
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Rotneg = value
			End Set
		End Property

		Friend Overridable Property Rotpos As Label
			Get
				Return Me._Rotpos
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Rotpos = value
			End Set
		End Property

		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			Get
				Return Me._SaveFileDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As SaveFileDialog)
				Me._SaveFileDialog1 = value
			End Set
		End Property

		Friend Overridable Property StatusStrip1 As StatusStrip
			Get
				Return Me._StatusStrip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		Friend Overridable Property SupprimerUnLégumeToolStripMenuItem As ToolStripMenuItem
			Get
				Return Me._SupprimerUnLégumeToolStripMenuItem
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.SupprimerUnLégumeToolStripMenuItem_Click)
				If (Me._SupprimerUnLégumeToolStripMenuItem IsNot Nothing) Then
					RemoveHandler Me._SupprimerUnLégumeToolStripMenuItem.Click,  eventHandler
				End If
				Me._SupprimerUnLégumeToolStripMenuItem = value
				If (Me._SupprimerUnLégumeToolStripMenuItem IsNot Nothing) Then
					AddHandler Me._SupprimerUnLégumeToolStripMenuItem.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Tableauannee As myGroupBox
			Get
				Return Me._Tableauannee
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._Tableauannee = value
			End Set
		End Property

		Friend Overridable Property TabPage1 As TabPage
			Get
				Return Me._TabPage1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabPage)
				Me._TabPage1 = value
			End Set
		End Property

		Friend Overridable Property TabPage2 As TabPage
			Get
				Return Me._TabPage2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		Friend Overridable Property TabPage3 As TabPage
			Get
				Return Me._TabPage3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		Friend Overridable Property Timer1 As Timer
			Get
				Return Me._Timer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Timer)
				Me._Timer1 = value
			End Set
		End Property

		Friend Overridable Property Timerinstallmsg As Timer
			Get
				Return Me._Timerinstallmsg
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Timer)
				Dim formPasPa As FormPasPas = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formPasPa.Timerinstallmsg_Tick)
				If (Me._Timerinstallmsg IsNot Nothing) Then
					RemoveHandler Me._Timerinstallmsg.Tick,  eventHandler
				End If
				Me._Timerinstallmsg = value
				If (Me._Timerinstallmsg IsNot Nothing) Then
					AddHandler Me._Timerinstallmsg.Tick,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel1 = value
			End Set
		End Property

		Friend Overridable Property Ttradiobutton As ToolTip
			Get
				Return Me._Ttradiobutton
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolTip)
				Me._Ttradiobutton = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formPasPa As FormPasPas = Me
			AddHandler MyBase.FormClosing,  New FormClosingEventHandler(AddressOf formPasPa.Pas_à_pas_FormClosing)
			Dim formPasPa1 As FormPasPas = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formPasPa1.Pas_à_pas_Load)
			Dim formPasPa2 As FormPasPas = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formPasPa2.Form1_FormClosed)
			ReDim Me.Recoltedata(12)
			ReDim Me.Materieldata(6)
			ReDim Me.Gardenfinance(3)
			Me.InitializeComponent()
		End Sub

		Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadapropos) Then
				Me.WinApropos = New Formapropos()
				Me.WinApropos.Show()
				Module1.loadapropos = True
			Else
				Me.WinApropos.WindowState = FormWindowState.Normal
				Me.WinApropos.Activate()
			End If
		End Sub

		Private Sub Add_asso(ByVal str As String)
			Dim assopos As Label = Me.Assopos
			assopos.Text = Conversions.ToString(Conversions.ToDouble(assopos.Text) + CDbl(Conversions.ToInteger(Strings.Mid(str, 1, 1))))
			assopos = Me.Assoneg
			assopos.Text = Conversions.ToString(Conversions.ToDouble(assopos.Text) - CDbl(Conversions.ToInteger(Strings.Mid(str, 2, 1))))
			assopos = Me.Assoechelle
			assopos.Text = Conversions.ToString(Conversions.ToDouble(assopos.Text) + CDbl(Conversions.ToInteger(Strings.Mid(str, 3, 1))))
		End Sub

		Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
			Dim str As String
			Dim rijndaelManaged As System.Security.Cryptography.RijndaelManaged = New System.Security.Cryptography.RijndaelManaged()
			Dim mD5CryptoServiceProvider As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider()
			Dim str1 As String = ""
			Try
				Dim numArray(31) As Byte
				Dim numArray1 As Byte() = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass))
				Array.Copy(numArray1, 0, numArray, 0, 16)
				Array.Copy(numArray1, 0, numArray, 15, 16)
				rijndaelManaged.Key = numArray
				rijndaelManaged.Mode = CipherMode.ECB
				Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateDecryptor()
				Dim numArray2 As Byte() = Convert.FromBase64String(input)
				str1 = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(numArray2, 0, CInt(numArray2.Length)))
				str = str1
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				str = Nothing
				ProjectData.ClearProjectError()
			End Try
			Return str
		End Function

		Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
			Dim str As String
			Dim rijndaelManaged As System.Security.Cryptography.RijndaelManaged = New System.Security.Cryptography.RijndaelManaged()
			Dim mD5CryptoServiceProvider As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider()
			Dim base64String As String = ""
			Try
				Dim numArray(31) As Byte
				Dim numArray1 As Byte() = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass))
				Array.Copy(numArray1, 0, numArray, 0, 16)
				Array.Copy(numArray1, 0, numArray, 15, 16)
				rijndaelManaged.Key = numArray
				rijndaelManaged.Mode = CipherMode.ECB
				Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateEncryptor()
				Dim bytes As Byte() = Encoding.ASCII.GetBytes(input)
				base64String = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, CInt(bytes.Length)))
				str = base64String
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				str = Nothing
				ProjectData.ClearProjectError()
			End Try
			Return str
		End Function

		Private Sub Affect(ByVal pict As SVPLCApplication.PictureBox1, ByVal img As Image)
			If (pict.Indexa = -1) Then
				pict.Image = img
			End If
		End Sub

		Private Sub Affichage_grilles()
			Dim size As System.Drawing.Size
			Dim point As System.Drawing.Point
			Me.espaceentredeuxcellules = 0
			ReDim Me.grille(Me.nbrcellules - 1 + 1 - 1, Me.nbrcellules - 1 + 1 - 1)
			Dim num As Integer = Me.nbrcellules - 1
			Dim num1 As Integer = 0
			Do
				Dim num2 As Integer = Me.nbrcellules - 1
				Dim num3 As Integer = 0
				Do
					Me.grille(num1, num3) = New SVPLCApplication.PictureBox1()
					Dim khaki As SVPLCApplication.PictureBox1 = Me.grille(num1, num3)
					khaki.BackColor = Color.Khaki
					khaki.CX = num1
					khaki.CY = num3
					khaki.Tag = "000"
					size = New System.Drawing.Size(Me.cotecelluleX, Me.cotecelluleY)
					khaki.Size = size
					point = New System.Drawing.Point(num1 * (Me.cotecelluleX + Me.espaceentredeuxcellules), num3 * (Me.cotecelluleY + Me.espaceentredeuxcellules))
					khaki.Location = point
					khaki.BackgroundImageLayout = ImageLayout.Stretch
					AddHandler khaki.Click,  New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me.checkbox_Click(DirectCast(a0, SVPLCApplication.PictureBox1), a1))
					AddHandler khaki.MouseEnter,  New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me.check_mousehover(DirectCast(a0, SVPLCApplication.PictureBox1), a1))
					AddHandler khaki.MouseLeave,  New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me.check_mouseleave(DirectCast(a0, SVPLCApplication.PictureBox1), a1))
					khaki = Nothing
					Me.Lgrille = 16 * (Me.cotecelluleX + Me.espaceentredeuxcellules) - Me.espaceentredeuxcellules
					Me.Hgrille = 16 * (Me.cotecelluleY + Me.espaceentredeuxcellules) - Me.espaceentredeuxcellules
					Dim panel As System.Windows.Forms.Panel = Me.Panel
					panel.Controls.Add(Me.grille(num1, num3))
					size = New System.Drawing.Size(Me.Lgrille, Me.Hgrille)
					panel.Size = size
					panel.BackColor = Color.Black
					panel = Nothing
					num3 = num3 + 1
				Loop While num3 <= num2
				num1 = num1 + 1
			Loop While num1 <= num
			ReDim Module1.grille2infosbulle(Me.nbrcellules - 1 + 1 - 1, Me.nbrcellules - 1 + 1 - 1)
			Me.espaceentredeuxcellules2 = 1
			ReDim Me.grille2(Me.nbrcellules - 1 + 1 - 1, Me.nbrcellules - 1 + 1 - 1)
			Dim num4 As Integer = Me.nbrcellules - 1
			For i As Integer = 0 To num4 Step 1
				Dim num5 As Integer = Me.nbrcellules - 1
				For j As Integer = 0 To num5 Step 1
					Me.grille2(i, j) = New SVPLCApplication.PictureBox1()
					Dim pictureBox1 As SVPLCApplication.PictureBox1 = Me.grille2(i, j)
					pictureBox1.BackColor = Color.Khaki
					pictureBox1.CX = i
					pictureBox1.CY = j
					pictureBox1.Tag = "000"
					size = New System.Drawing.Size(Me.cotecelluleX2, Me.cotecelluleY2)
					pictureBox1.Size = size
					point = New System.Drawing.Point(i * (Me.cotecelluleX2 + Me.espaceentredeuxcellules2) + Me.espaceentredeuxcellules2, j * (Me.cotecelluleY2 + Me.espaceentredeuxcellules2) + Me.espaceentredeuxcellules2)
					pictureBox1.Location = point
					pictureBox1 = Nothing
					Dim panel1 As System.Windows.Forms.Panel = Me.Panel1
					size = New System.Drawing.Size((Me.cotecelluleX2 + Me.espaceentredeuxcellules2) * 16 + Me.espaceentredeuxcellules2, (Me.cotecelluleY2 + Me.espaceentredeuxcellules2) * 16 + Me.espaceentredeuxcellules2)
					panel1.Size = size
					panel1.Controls.Add(Me.grille2(i, j))
					panel1.BackColor = Color.SaddleBrown
					panel1 = Nothing
				Next

			Next

		End Sub

		Private Sub Afficher_les_rotations(ByVal ref As String, ByVal act As String)
			Dim rotneg As Label
			ReDim Me.doctxt(0)
			Me.Lect = New StreamReader(ref, Encoding.[Default])
			Me.compt = 0
			While Me.Lect.Peek() <> -1
				Me.doctxt = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(Me.doctxt, Array), New String(Me.compt + 1 - 1) {}), String())
				Me.doctxt(Me.compt) = Me.Lect.ReadLine()
				Me.compt = Me.compt + 1
			End While
			Me.Lect.Close()
			Me.RESET_grilleB()
			Dim length As Integer = CInt(Me.doctxt.Length) - 1
			Dim num As Integer = 0
			Do
				If (Operators.CompareString(Me.doctxt(num + 2), "", False) <> 0) Then
					Me.ind = Conversions.ToInteger(Module1.indexlegume(Me.doctxt(num + 2)))
					If (Me.ind = -1) Then
						Me.Msgboxperso(String.Concat("La plante ' ", Me.doctxt(num + 2), " ' n'a pas été trouvée dans la BDD." & VbCrLf & "Vérifiez que vous n'avez pas modifier son nom."), "")
					Else
						Dim darkGray As SVPLCApplication.PictureBox1 = Me.grille2(Conversions.ToInteger(Me.doctxt(num)), Conversions.ToInteger(Me.doctxt(num + 1)))
						darkGray.BackColor = Color.DarkGray
						Module1.grille2infosbulle(Conversions.ToInteger(Me.doctxt(num)), Conversions.ToInteger(Me.doctxt(num + 1))) = Conversions.ToString(Operators.ConcatenateObject(String.Concat(String.Concat(String.Concat(String.Concat("(", Module1.listelégumes(Me.ind)), ","), Module1.listelégumes(Me.indexselectleg - 1)), ") "), Module1.SptRg2(Module1.Base_de_données_rotationsstr(Me.ind, Me.indexselectleg - 1))))
						If (Module1.Base_de_données_rotations(Me.ind, Me.indexselectleg - 1) = 1 AndAlso darkGray.BackColor = Color.DarkGray) Then
							darkGray.BackColor = Color.Green
						End If
						If (Module1.Base_de_données_rotations(Me.ind, Me.indexselectleg - 1) = -1 AndAlso darkGray.BackColor = Color.DarkGray) Then
							darkGray.BackColor = Color.Red
						End If
						darkGray = Nothing
					End If
				End If
				num = num + 6
			Loop While num <= length
			Dim num1 As Integer = Me.nbrcellules - 1
			Dim num2 As Integer = 0
			Do
				Dim num3 As Integer = Me.nbrcellules - 1
				Dim num4 As Integer = 0
				Do
					If (Me.grille(num2, num4).Indexp <> -1) Then
						Dim length1 As Integer = CInt(Me.doctxt.Length) - 1
						For i As Integer = 0 To length1 Step 6
							If (Conversions.ToDouble(Me.doctxt(i)) = CDbl(num2) AndAlso Conversions.ToDouble(Me.doctxt(i + 1)) = CDbl(num4)) Then
								If (Operators.CompareString(Me.doctxt(i + 2), "", False) = 0) Then
									Me.ind = -1
								Else
									Me.ind = Conversions.ToInteger(Module1.indexlegume(Me.doctxt(i + 2)))
								End If
								If (Me.ind <> -1) Then
									Module1.grille2infosbulle(num2, num4) = Conversions.ToString(Operators.ConcatenateObject(String.Concat(String.Concat(String.Concat(String.Concat("(", Module1.listelégumes(Me.ind)), ","), Module1.listelégumes(Me.grille(num2, num4).Indexp)), ") "), Module1.SptRg2(Module1.Base_de_données_rotationsstr(Me.ind, Me.grille(num2, num4).Indexp))))
									Select Case Module1.Base_de_données_rotations(Me.ind, Me.grille(num2, num4).Indexp)
										Case -1
											Me.grille2(num2, num4).BackColor = Color.DarkRed
											Me.grille2(num2, num4).Tag = 4
											rotneg = Me.Rotneg
											rotneg.Text = Conversions.ToString(Conversions.ToDouble(rotneg.Text) - 1)
											rotneg = Me.Rotechelle
											rotneg.Text = Conversions.ToString(Conversions.ToDouble(rotneg.Text) + 1)
											Exit Select
										Case 0
											Me.grille2(num2, num4).BackColor = Color.Gray
											Me.grille2(num2, num4).Tag = 2
											rotneg = Me.Rotechelle
											rotneg.Text = Conversions.ToString(Conversions.ToDouble(rotneg.Text) + 1)
											Exit Select
										Case 1
											Me.grille2(num2, num4).BackColor = Color.DarkGreen
											Me.grille2(num2, num4).Tag = 1
											rotneg = Me.Rotpos
											rotneg.Text = Conversions.ToString(Conversions.ToDouble(rotneg.Text) + 1)
											rotneg = Me.Rotechelle
											rotneg.Text = Conversions.ToString(Conversions.ToDouble(rotneg.Text) + 1)
											Exit Select
									End Select
								Else
									Me.grille2(num2, num4).BackColor = Color.DarkGray
									Me.grille2(num2, num4).Tag = 3
								End If
							End If
						Next

					End If
					num4 = num4 + 1
				Loop While num4 <= num3
				num2 = num2 + 1
			Loop While num2 <= num1
			Dim num5 As Integer = Me.nbrcellules - 1
			For j As Integer = 0 To num5 Step 1
				Dim num6 As Integer = Me.nbrcellules - 1
				For k As Integer = 0 To num6 Step 1
					Me.Infobullegrille2.SetToolTip(Me.grille2(j, k), Module1.grille2infosbulle(j, k))
				Next

			Next

		End Sub

		Private Sub AjouterUnNouveauLégumeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.WinInputbox = New FormInputbox()
			Dim winInputbox As FormInputbox = Me.WinInputbox
			winInputbox.Text = "Ajouter une nouvelle plante..."
			winInputbox.Icon = Resources.plus
			winInputbox.Label1.Text = "Entrez le nom de la plante à ajouter aux BDD:"
			winInputbox.Button1.Text = "Ajouter"
			winInputbox.Show()
			winInputbox = Nothing
		End Sub

		Private Sub AProposDeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not File.Exists(Module1.PATHS(18))) Then
				Me.Msgboxperso("Fichier d'aide introuvable!", "Fichier d'aide introuvable!")
			Else
				Process.Start(Module1.PATHS(18))
			End If
		End Sub

		Private Sub aucunerot()
			ReDim Module1.Base_de_données_rotations(Module1.nbrlegumesbase - 1 + 1 - 1, Module1.nbrlegumesbase - 1 + 1 - 1)
			ReDim Module1.Base_de_données_rotationsstr(Module1.nbrlegumesbase - 1 + 1 - 1, Module1.nbrlegumesbase - 1 + 1 - 1)
			Dim num As Integer = Module1.nbrlegumesbase - 1
			Dim num1 As Integer = 0
			Do
				Dim num2 As Integer = Module1.nbrlegumesbase - 1
				Dim num3 As Integer = 0
				Do
					Module1.Base_de_données_rotations(num1, num3) = 0
					num3 = num3 + 1
				Loop While num3 <= num2
				num1 = num1 + 1
			Loop While num1 <= num
			Dim num4 As Integer = Module1.nbrlignecal - 1
			For i As Integer = 0 To num4 Step 9
				Me.ind = Conversions.ToInteger(Module1.indexlegume(Module1.Base_de_données_calendrier(i)))
				If (Me.ind <> -1) Then
					If (Operators.CompareString(Module1.Base_de_données_calendrier(i + 7), "True", False) <> 0) Then
						Module1.Base_de_données_rotations(Me.ind, Me.ind) = -1
					Else
						Module1.Base_de_données_rotations(Me.ind, Me.ind) = 0
					End If
					Module1.Base_de_données_rotationsstr(Me.ind, Me.ind) = "0Initialisation/Vivace"
				End If
			Next

		End Sub

		Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Dim num As Integer = Me.nbrcellules - 1
			For i As Integer = 0 To num Step 1
				Dim num1 As Integer = Me.nbrcellules - 1
				For j As Integer = 0 To num1 Step 1
					If (Me.grille(i, j).Indexp = -1) Then
						Me.assoh = 0
						Me.assob = 0
						Me.assod = 0
						Me.assog = 0
						Me.ech = 0
						If (i <> Me.nbrcellules - 1) Then
							Me.ind = Me.grille(i + 1, j).Indexp
							If (Me.ind <> -1) Then
								If (Me.indexselectleg >= Me.ind) Then
									Me.assod = Conversions.ToInteger(Module1.Base_de_données_associations(Me.ind, Me.indexselectleg - 1))
								Else
									Me.assod = Conversions.ToInteger(Module1.Base_de_données_associations(Me.indexselectleg - 1, Me.ind))
								End If
								Me.ech = Me.ech + 1
							End If
						End If
						If (i <> 0) Then
							Me.ind = Me.grille(i - 1, j).Indexp
							If (Me.ind <> -1) Then
								If (Me.indexselectleg >= Me.ind) Then
									Me.assog = Conversions.ToInteger(Module1.Base_de_données_associations(Me.ind, Me.indexselectleg - 1))
								Else
									Me.assog = Conversions.ToInteger(Module1.Base_de_données_associations(Me.indexselectleg - 1, Me.ind))
								End If
								Me.ech = Me.ech + 1
							End If
						End If
						If (j <> Me.nbrcellules - 1) Then
							Me.ind = Me.grille(i, j + 1).Indexp
							If (Me.ind <> -1) Then
								If (Me.indexselectleg >= Me.ind) Then
									Me.assob = Conversions.ToInteger(Module1.Base_de_données_associations(Me.ind, Me.indexselectleg - 1))
								Else
									Me.assob = Conversions.ToInteger(Module1.Base_de_données_associations(Me.indexselectleg - 1, Me.ind))
								End If
								Me.ech = Me.ech + 1
							End If
						End If
						If (j <> 0) Then
							Me.ind = Me.grille(i, j - 1).Indexp
							If (Me.ind <> -1) Then
								If (Me.indexselectleg >= Me.ind) Then
									Me.assoh = Conversions.ToInteger(Module1.Base_de_données_associations(Me.ind, Me.indexselectleg - 1))
								Else
									Me.assoh = Conversions.ToInteger(Module1.Base_de_données_associations(Me.indexselectleg - 1, Me.ind))
								End If
								Me.ech = Me.ech + 1
							End If
						End If
						Select Case Me.assoh
							Case -1
								Select Case Me.assob
									Case -1
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(79))
														Me.grille(i, j).Tag = "04"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(78))
														Me.grille(i, j).Tag = "03"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(77))
														Me.grille(i, j).Tag = "13"

												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(76))
														Me.grille(i, j).Tag = "03"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(75))
														Me.grille(i, j).Tag = "02"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(74))
														Me.grille(i, j).Tag = "12"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(73))
														Me.grille(i, j).Tag = "13"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(72))
														Me.grille(i, j).Tag = "12"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(71))
														Me.grille(i, j).Tag = "22"

												End Select

										End Select

									Case 0
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(70))
														Me.grille(i, j).Tag = "03"
														Exit Select
													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(69))
														Me.grille(i, j).Tag = "02"
														Exit Select
													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(68))
														Me.grille(i, j).Tag = "12"
														Exit Select
												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(67))
														Me.grille(i, j).Tag = "02"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(66))
														Me.grille(i, j).Tag = "01"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(65))
														Me.grille(i, j).Tag = "11"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(64))
														Me.grille(i, j).Tag = "12"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(63))
														Me.grille(i, j).Tag = "11"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(62))
														Me.grille(i, j).Tag = "21"

												End Select

										End Select

									Case 1
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(61))
														Me.grille(i, j).Tag = "13"
														Exit Select
													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(60))
														Me.grille(i, j).Tag = "12"
														Exit Select
													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(59))
														Me.grille(i, j).Tag = "22"
														Exit Select
												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(58))
														Me.grille(i, j).Tag = "12"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(57))
														Me.grille(i, j).Tag = "11"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(56))
														Me.grille(i, j).Tag = "21"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(55))
														Me.grille(i, j).Tag = "22"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(54))
														Me.grille(i, j).Tag = "21"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(53))
														Me.grille(i, j).Tag = "31"

												End Select

										End Select

								End Select

							Case 0
								Select Case Me.assob
									Case -1
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(52))
														Me.grille(i, j).Tag = "03"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(51))
														Me.grille(i, j).Tag = "02"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(50))
														Me.grille(i, j).Tag = "12"

												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(49))
														Me.grille(i, j).Tag = "02"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(48))
														Me.grille(i, j).Tag = "01"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(47))
														Me.grille(i, j).Tag = "11"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(46))
														Me.grille(i, j).Tag = "12"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(45))
														Me.grille(i, j).Tag = "11"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(44))
														Me.grille(i, j).Tag = "21"

												End Select

										End Select

									Case 0
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(43))
														Me.grille(i, j).Tag = "02"
														Exit Select
													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(42))
														Me.grille(i, j).Tag = "01"
														Exit Select
													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(41))
														Me.grille(i, j).Tag = "11"
														Exit Select
												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(40))
														Me.grille(i, j).Tag = "01"

													Case 0
														Me.Affect(Me.grille(i, j), Nothing)
														Me.grille(i, j).Tag = "00"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(39))
														Me.grille(i, j).Tag = "10"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(38))
														Me.grille(i, j).Tag = "11"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(37))
														Me.grille(i, j).Tag = "10"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(36))
														Me.grille(i, j).Tag = "20"

												End Select

										End Select

									Case 1
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(35))
														Me.grille(i, j).Tag = "12"
														Exit Select
													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(34))
														Me.grille(i, j).Tag = "11"
														Exit Select
													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(33))
														Me.grille(i, j).Tag = "21"
														Exit Select
												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(32))
														Me.grille(i, j).Tag = "11"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(31))
														Me.grille(i, j).Tag = "10"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(30))
														Me.grille(i, j).Tag = "20"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(29))
														Me.grille(i, j).Tag = "21"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(28))
														Me.grille(i, j).Tag = "20"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(27))
														Me.grille(i, j).Tag = "30"

												End Select

										End Select

								End Select

							Case 1
								Select Case Me.assob
									Case -1
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(26))
														Me.grille(i, j).Tag = "13"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(25))
														Me.grille(i, j).Tag = "12"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(24))
														Me.grille(i, j).Tag = "22"

												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(23))
														Me.grille(i, j).Tag = "12"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(22))
														Me.grille(i, j).Tag = "11"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(21))
														Me.grille(i, j).Tag = "21"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(20))
														Me.grille(i, j).Tag = "22"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(19))
														Me.grille(i, j).Tag = "21"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(18))
														Me.grille(i, j).Tag = "31"

												End Select

										End Select

									Case 0
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(17))
														Me.grille(i, j).Tag = "12"
														Exit Select
													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(16))
														Me.grille(i, j).Tag = "11"
														Exit Select
													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(15))
														Me.grille(i, j).Tag = "21"
														Exit Select
												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(14))
														Me.grille(i, j).Tag = "11"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(13))
														Me.grille(i, j).Tag = "10"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(12))
														Me.grille(i, j).Tag = "20"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(11))
														Me.grille(i, j).Tag = "21"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(10))
														Me.grille(i, j).Tag = "20"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(9))
														Me.grille(i, j).Tag = "30"

												End Select

										End Select

									Case 1
										Select Case Me.assod
											Case -1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(8))
														Me.grille(i, j).Tag = "22"
														Exit Select
													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(7))
														Me.grille(i, j).Tag = "21"
														Exit Select
													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(6))
														Me.grille(i, j).Tag = "31"
														Exit Select
												End Select

											Case 0
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(5))
														Me.grille(i, j).Tag = "21"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(4))
														Me.grille(i, j).Tag = "20"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(3))
														Me.grille(i, j).Tag = "30"

												End Select

											Case 1
												Select Case Me.assog
													Case -1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(2))
														Me.grille(i, j).Tag = "31"

													Case 0
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(1))
														Me.grille(i, j).Tag = "30"

													Case 1
														Me.Affect(Me.grille(i, j), Me.ImageList7.Images(0))
														Me.grille(i, j).Tag = "40"

												End Select

										End Select

								End Select

						End Select
						Me.grille(i, j).Tag = Operators.ConcatenateObject(Me.grille(i, j).Tag, Me.ech)
					End If
				Next

			Next

		End Sub

		Private Sub BibliothèqueToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadbiblio) Then
				Me.WinInternet = New FormInternet()
				Me.WinInternet.Show()
				Module1.loadbiblio = True
			Else
				Me.WinInternet.WindowState = FormWindowState.Normal
				Me.WinInternet.Activate()
			End If
		End Sub

		<DllImport("gdi32.dll", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
		Private Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Long
		End Function

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Dim item As Object()
			Dim enumerator1 As IEnumerator = Nothing
			Dim enumerator2 As IEnumerator = Nothing
			If (Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Me.nomfichier = Me.OpenFileDialog1.FileName
				If (Me.nomfichier IsNot Nothing) Then
					Select Case Me.CustomTabControl1.SelectedIndex
						Case 0
							Me.fs = File.OpenRead(Me.nomfichier)
							Me.imagetraitee = Image.FromStream(Me.fs)
							Me.ImageList1.Images.Add(Me.imagetraitee)
							Me.ImageList1.Images(Me.indexselectleg - 1) = Me.ImageList1.Images(Me.ImageList1.Images.Count - 1)
							Me.ImageList1.Images.RemoveAt(Me.ImageList1.Images.Count - 1)
							Me.ImageList2.Images.Add(Me.imagetraitee)
							Me.ImageList2.Images(Me.indexselectleg - 1) = Me.ImageList2.Images(Me.ImageList2.Images.Count - 1)
							Me.ImageList2.Images.RemoveAt(Me.ImageList1.Images.Count - 1)
							Me.fs.Close()
							Try
								enumerator = Me.TabPage1.Controls.GetEnumerator()
								While enumerator.MoveNext()
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
									If (Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "checked", New Object(-1) {}, Nothing, Nothing, Nothing), True, False)) Then
										Continue While
									End If
									item = New Object() { Me.ImageList1.Images(Me.indexselectleg - 1) }
									NewLateBinding.LateSet(objectValue, Nothing, "BackgroundImage", item, Nothing, Nothing)
									If (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(13), "\"), NewLateBinding.LateGet(objectValue, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))) Then
										File.Delete(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(13), "\"), NewLateBinding.LateGet(objectValue, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))
									End If
									File.Copy(Me.nomfichier, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(13), "\"), NewLateBinding.LateGet(objectValue, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))
									Return
								End While
								Exit Select
							Finally
								If (TypeOf enumerator Is IDisposable) Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try

						Case 1
							Me.fs = File.OpenRead(Me.nomfichier)
							Me.imagetraitee = Image.FromStream(Me.fs)
							Me.ImageList3.Images.Add(Me.imagetraitee)
							Me.ImageList3.Images(Me.indexselectsurf - 1) = Me.ImageList3.Images(Me.ImageList3.Images.Count - 1)
							Me.ImageList3.Images.RemoveAt(Me.ImageList3.Images.Count - 1)
							Me.ImageList4.Images.Add(Me.imagetraitee)
							Me.ImageList4.Images(Me.indexselectsurf - 1) = Me.ImageList4.Images(Me.ImageList4.Images.Count - 1)
							Me.ImageList4.Images.RemoveAt(Me.ImageList4.Images.Count - 1)
							Me.fs.Close()
							Try
								enumerator1 = Me.TabPage2.Controls.GetEnumerator()
								While enumerator1.MoveNext()
									Dim obj As Object = RuntimeHelpers.GetObjectValue(enumerator1.Current)
									If (Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, Nothing, "checked", New Object(-1) {}, Nothing, Nothing, Nothing), True, False)) Then
										Continue While
									End If
									item = New Object() { Me.ImageList3.Images(Me.indexselectsurf - 1) }
									NewLateBinding.LateSet(obj, Nothing, "BackgroundImage", item, Nothing, Nothing)
									If (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(14), "\"), NewLateBinding.LateGet(obj, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))) Then
										File.Delete(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(14), "\"), NewLateBinding.LateGet(obj, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))
									End If
									File.Copy(Me.nomfichier, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(14), "\"), NewLateBinding.LateGet(obj, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))
									Return
								End While
								Exit Select
							Finally
								If (TypeOf enumerator1 Is IDisposable) Then
									TryCast(enumerator1, IDisposable).Dispose()
								End If
							End Try

						Case 2
							Me.fs = File.OpenRead(Me.nomfichier)
							Me.imagetraitee = Image.FromStream(Me.fs)
							Me.ImageList5.Images.Add(Me.imagetraitee)
							Me.ImageList5.Images(Me.indexselectamen - 1) = Me.ImageList5.Images(Me.ImageList5.Images.Count - 1)
							Me.ImageList5.Images.RemoveAt(Me.ImageList5.Images.Count - 1)
							Me.ImageList6.Images.Add(Me.imagetraitee)
							Me.ImageList6.Images(Me.indexselectamen - 1) = Me.ImageList6.Images(Me.ImageList6.Images.Count - 1)
							Me.ImageList6.Images.RemoveAt(Me.ImageList6.Images.Count - 1)
							Me.fs.Close()
							Try
								enumerator2 = Me.TabPage3.Controls.GetEnumerator()
								While enumerator2.MoveNext()
									Dim objectValue1 As Object = RuntimeHelpers.GetObjectValue(enumerator2.Current)
									If (Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue1, Nothing, "checked", New Object(-1) {}, Nothing, Nothing, Nothing), True, False)) Then
										Continue While
									End If
									item = New Object() { Me.ImageList5.Images(Me.indexselectamen - 1) }
									NewLateBinding.LateSet(objectValue1, Nothing, "BackgroundImage", item, Nothing, Nothing)
									If (File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(15), "\"), NewLateBinding.LateGet(objectValue1, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))) Then
										File.Delete(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(15), "\"), NewLateBinding.LateGet(objectValue1, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))
									End If
									File.Copy(Me.nomfichier, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(Module1.PATHS(15), "\"), NewLateBinding.LateGet(objectValue1, Nothing, "Text", New Object(-1) {}, Nothing, Nothing, Nothing)), ".png")))
									Return
								End While
								Exit Select
							Finally
								If (TypeOf enumerator2 Is IDisposable) Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try

					End Select
				End If
			End If
		End Sub

		Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Dim fiche As SVPLCApplication.Fiche = New SVPLCApplication.Fiche()
			Try
				enumerator = Me.TabPage1.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
					If (Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, Nothing, "checked", New Object(-1) {}, Nothing, Nothing, Nothing), True, False)) Then
						Continue While
					End If
					Dim str As SVPLCApplication.Fiche = fiche
					str.Text = Conversions.ToString(NewLateBinding.LateGet(objectValue, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing))
					str.Label1.Text = Conversions.ToString(NewLateBinding.LateGet(objectValue, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing))
					str = Nothing
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			fiche.Show()
		End Sub

		Private Sub Button2_Click_2(ByVal sender As Object, ByVal e As EventArgs)
			Me.CalculatriceToolStripMenuItem.PerformClick()
			Me.hideonglet()
		End Sub

		Private Sub Button3_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Me.CalendrierLunaireToolStripMenuItem.PerformClick()
			Me.hideonglet()
		End Sub

		Private Sub Button4_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadgarden) Then
				Me.WinMonJardin = New FormMonJardin()
				Me.WinMonJardin.TabControl.SelectedIndex = 0
				Me.WinMonJardin.Show()
				Module1.loadgarden = True
				Me.hideonglet()
			Else
				Me.WinMonJardin.TabControl.SelectedIndex = 0
				Me.WinMonJardin.WindowState = FormWindowState.Normal
				Me.WinMonJardin.Activate()
				Me.hideonglet()
			End If
		End Sub

		Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadgarden) Then
				Me.WinMonJardin = New FormMonJardin()
				Me.WinMonJardin.TabControl.SelectedIndex = 1
				Me.WinMonJardin.Show()
				Module1.loadgarden = True
				Me.hideonglet()
			Else
				Me.WinMonJardin.TabControl.SelectedIndex = 1
				Me.WinMonJardin.WindowState = FormWindowState.Normal
				Me.WinMonJardin.Activate()
				Me.hideonglet()
			End If
		End Sub

		Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadgarden) Then
				Me.WinMonJardin = New FormMonJardin()
				Me.WinMonJardin.TabControl.SelectedIndex = 2
				Me.WinMonJardin.Show()
				Module1.loadgarden = True
				Me.hideonglet()
			Else
				Me.WinMonJardin.TabControl.SelectedIndex = 2
				Me.WinMonJardin.WindowState = FormWindowState.Normal
				Me.WinMonJardin.Activate()
				Me.hideonglet()
			End If
		End Sub

		Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.BibliothèqueMenu.PerformClick()
			Me.hideonglet()
		End Sub

		Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.msgboxmess = "Attention! Toute donnée non enregistrée sera perdue! Redimenssionner la grille tout de même?"
			If (MyProject.Forms.FormMSGBOXPerso.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Me.nbrcellules = Conversions.ToInteger(Me.Labelcote.Text)
				Me.Cursor = Cursors.WaitCursor
				Me.Panel.Visible = False
				Me.Panel1.Visible = False
				Me.Panel.Controls.Clear()
				Me.Panel1.Controls.Clear()
				Me.grille = Nothing
				Me.grille2 = Nothing
				Me.Affichage_grilles()
				Me.Panel.Visible = True
				Me.Panel1.Visible = True
				Me.Cursor = Cursors.[Default]
			End If
		End Sub

		Private Sub Button8_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Dim labelcote As Label = Me.Labelcote
			labelcote.Text = Conversions.ToString(Conversions.ToDouble(labelcote.Text) + 1)
			Me.Labelcote.Focus()
		End Sub

		Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Conversions.ToDouble(Me.Labelcote.Text) > 16) Then
				Dim labelcote As Label = Me.Labelcote
				labelcote.Text = Conversions.ToString(Conversions.ToDouble(labelcote.Text) - 1)
			End If
			Me.Labelcote.Focus()
		End Sub

		Private Sub Buttonactiv_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadactiv) Then
				Me.Winpaypal = New Formpaypal()
				Me.Winpaypal.Show()
				Module1.loadactiv = True
			Else
				Me.Winpaypal.WindowState = FormWindowState.Normal
				Me.Winpaypal.Activate()
			End If
		End Sub

		Private Sub Buttonajouter_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.CustomTabControl1.SelectedIndex = 0) Then
				Me.Msgboxperso("Vous essayer d'ajouter une plante." & VbCrLf & "Merci de passer par la boîte de dialogue 'Ajouter une plante' disponible dans le menu 'Base de données'", "Procédure non valide")
			ElseIf (MyProject.Forms.Formajoutbouton.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Select Case Me.CustomTabControl1.SelectedIndex
					Case 1
						If (File.Exists(String.Concat(Module1.PATHS(14), "\", Me.txttoadd, ".png"))) Then
							If (Interaction.MsgBox(String.Concat("'", Me.txttoadd, "' existe déjà. Le fichier sera remplacé"), MsgBoxStyle.Information, "Le fichier existe déjà") <> MsgBoxResult.Ok) Then
								Exit Select
							End If
							File.Delete(String.Concat(Module1.PATHS(14), "\", Me.txttoadd, ".png"))
						End If
						If (Operators.CompareString(Me.imgtoadd, "", False) <> 0) Then
							File.Copy(Me.imgtoadd, String.Concat(Module1.PATHS(14), "\", Me.txttoadd, ".png"))
						Else
							Resources.blanc.Save(String.Concat(Module1.PATHS(14), "\", Me.txttoadd, ".png"))
						End If
						Me.TabPage2.Controls.Clear()
						Me.Chargement_radiobutton(Module1.PATHS(14))
						Exit Select
					Case 2
						If (File.Exists(String.Concat(Module1.PATHS(14), "\", Me.txttoadd, ".png"))) Then
							If (Interaction.MsgBox(String.Concat("'", Me.txttoadd, "' existe déjà. Le fichier sera remplacé"), MsgBoxStyle.Information, "Le fichier existe déjà") <> MsgBoxResult.Ok) Then
								Exit Select
							End If
							File.Delete(String.Concat(Module1.PATHS(14), "\", Me.txttoadd, ".png"))
						End If
						If (Operators.CompareString(Me.imgtoadd, "", False) <> 0) Then
							File.Copy(Me.imgtoadd, String.Concat(Module1.PATHS(15), "\", Me.txttoadd, ".png"))
						Else
							Resources.blanc.Save(String.Concat(Module1.PATHS(15), "\", Me.txttoadd, ".png"))
						End If
						Me.TabPage3.Controls.Clear()
						Me.Chargement_radiobutton(Module1.PATHS(15))
						Exit Select
				End Select
			End If
		End Sub

		Private Sub Buttonreset_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.Bordannee0.BorderColor = Color.Green) Then
				If (File.Exists(String.Concat(Module1.PATHS(17), "\annee0.txt"))) Then
					File.Delete(String.Concat(Module1.PATHS(17), "\annee0.txt"))
				End If
				Me.PictureBoxannee0.BackgroundImage = Resources.Fondsvplc2
				Me.PictureBoxannee0.BackgroundImage.Tag = 2
			End If
			If (Me.Bordannee1.BorderColor = Color.Green) Then
				If (File.Exists(String.Concat(Module1.PATHS(17), "\annee1.txt"))) Then
					File.Delete(String.Concat(Module1.PATHS(17), "\annee1.txt"))
				End If
				Me.PictureBoxannee1.BackgroundImage = Resources.Fondsvplc2
				Me.PictureBoxannee1.BackgroundImage.Tag = 2
			End If
			If (Me.Bordannee2.BorderColor = Color.Green) Then
				If (File.Exists(String.Concat(Module1.PATHS(17), "\annee2.txt"))) Then
					File.Delete(String.Concat(Module1.PATHS(17), "\annee2.txt"))
				End If
				Me.PictureBoxannee2.BackgroundImage = Resources.Fondsvplc2
				Me.PictureBoxannee2.BackgroundImage.Tag = 2
			End If
			Me.RESET_GrilleA()
		End Sub

		Public Sub CacherBarreTacheWindows()
			Dim str As String = "Shell_traywnd"
			Dim str1 As String = ""
			Dim num As Long = CLng(FormPasPas.FindWindow(str, str1))
			FormPasPas.SetWindowPos(CInt(num), 0, 0, 0, 0, 0, 128)
		End Sub

		Private Sub CacherLaBarreDeTâcheToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.CacherLaBarreDeTâcheToolStripMenuItem.Checked) Then
				Me.CacherBarreTacheWindows()
				Me.CacherLaBarreDeTâcheToolStripMenuItem.Checked = True
			Else
				Me.MontrerBarreTacheWindows()
				Me.CacherLaBarreDeTâcheToolStripMenuItem.Checked = False
			End If
		End Sub

		Private Sub CalendrierLunaireToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadmoon) Then
				Me.WinCalLun = New FormCalLun()
				Me.WinCalLun.Show()
				Module1.loadmoon = True
			Else
				Me.WinCalLun.WindowState = FormWindowState.Normal
				Me.WinCalLun.Activate()
			End If
		End Sub

		Private Sub CaptureScreen()
			Dim graphic As Graphics = Me.CreateGraphics()
			Dim size As System.Drawing.Size = Me.Size
			Me.memoryImage = New Bitmap(size.Width, size.Height, graphic)
			Dim graphic1 As Graphics = Graphics.FromImage(Me.memoryImage)
			Dim hdc As System.IntPtr = graphic.GetHdc()
			Dim intPtr As System.IntPtr = graphic1.GetHdc()
			Dim width As Integer = Me.ClientRectangle.Width
			Dim clientRectangle As Rectangle = Me.ClientRectangle
			FormPasPas.BitBlt(intPtr, 0, 0, width, clientRectangle.Height, hdc, 0, 0, 13369376)
			graphic.ReleaseHdc(hdc)
			graphic1.ReleaseHdc(intPtr)
		End Sub

		Private Sub Chargement(ByVal PATHS As String)
			Dim enumerator As IEnumerator = Nothing
			Dim objArray As Object()
			Dim enumerator1 As IEnumerator = Nothing
			Me.RESET_GrilleA()
			If (File.Exists(PATHS)) Then
				Me.doctxt = Nothing
				Me.Lect = New StreamReader(PATHS, Encoding.[Default])
				Me.compt = 0
				While Me.Lect.Peek() <> -1
					Me.doctxt = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(Me.doctxt, Array), New String(Me.compt + 1 - 1) {}), String())
					Me.doctxt(Me.compt) = Me.Lect.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Me.Lect.Close()
				If (Math.Sqrt(CDbl(CInt(Me.doctxt.Length)) / 6) <> CDbl(Conversions.ToInteger(Me.Labelcote.Text))) Then
					Me.Labelcote.Text = Conversions.ToString(Math.Sqrt(CDbl(CInt(Me.doctxt.Length)) / 6))
					Me.Buttonnbrcellules.PerformClick()
				End If
				Dim length As Integer = CInt(Me.doctxt.Length) - 1
				Dim num As Integer = 0
				Do
					Dim item As SVPLCApplication.PictureBox1 = Me.grille(Conversions.ToInteger(Me.doctxt(num)), Conversions.ToInteger(Me.doctxt(num + 1)))
					If (Operators.CompareString(Me.doctxt(num + 2), "", False) <> 0) Then
						Me.ind = Conversions.ToInteger(Module1.indexlegume(Me.doctxt(num + 2)))
						If (Me.ind = -1) Then
							Me.Msgboxperso(String.Concat("La plante ' ", Me.doctxt(num + 2), " ' est introuvable." & VbCrLf & "Vérifiez que vous n'avez pas changé son nom."), "Erreur chargement")
						Else
							item.Indexp = Me.ind
							item.Image = Me.ImageList2.Images(Me.ind)
							Me.Infobullegrille.SetToolTip(Me.grille(Conversions.ToInteger(Me.doctxt(num)), Conversions.ToInteger(Me.doctxt(num + 1))), Module1.listelégumes(Me.ind))
						End If
					End If
					Me.trouve = False
					If (Operators.CompareString(Me.doctxt(num + 3), "", False) <> 0) Then
						Try
							enumerator = Me.TabPage2.Controls.GetEnumerator()
							While enumerator.MoveNext()
								Dim current As System.Windows.Forms.RadioButton = DirectCast(enumerator.Current, System.Windows.Forms.RadioButton)
								If (Operators.CompareString(current.Text, Me.doctxt(num + 3), False) <> 0) Then
									Continue While
								End If
								item.Indexs = Conversions.ToInteger(Operators.SubtractObject(current.Tag, 1))
								Dim images As ImageList.ImageCollection = Me.ImageList4.Images
								objArray = New Object() { Operators.SubtractObject(current.Tag, 1) }
								item.BackgroundImage = DirectCast(NewLateBinding.LateGet(images, Nothing, "Item", objArray, Nothing, Nothing, Nothing), Image)
								Me.trouve = True
								GoTo Label0
							End While
						Finally
							If (TypeOf enumerator Is IDisposable) Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					Label0:
						If (Not Me.trouve) Then
							Me.Msgboxperso(String.Concat("La surface ' ", Me.doctxt(num + 3), " ' est introuvable." & VbCrLf & "Vérifiez que vous n'avez pas changé son nom."), "Erreur chargement")
						End If
					End If
					Me.trouve = False
					If (Operators.CompareString(Me.doctxt(num + 4), "", False) <> 0) Then
						Try
							enumerator1 = Me.TabPage3.Controls.GetEnumerator()
							While enumerator1.MoveNext()
								Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(enumerator1.Current, System.Windows.Forms.RadioButton)
								If (Operators.CompareString(radioButton.Text, Me.doctxt(num + 4), False) <> 0) Then
									Continue While
								End If
								item.Indexa = Conversions.ToInteger(Operators.SubtractObject(radioButton.Tag, 1))
								Dim imageCollections As ImageList.ImageCollection = Me.ImageList6.Images
								objArray = New Object() { Operators.SubtractObject(radioButton.Tag, 1) }
								item.Image = DirectCast(NewLateBinding.LateGet(imageCollections, Nothing, "Item", objArray, Nothing, Nothing, Nothing), Image)
								Me.trouve = True
								GoTo Label1
							End While
						Finally
							If (TypeOf enumerator1 Is IDisposable) Then
								TryCast(enumerator1, IDisposable).Dispose()
							End If
						End Try
					Label1:
						If (Not Me.trouve) Then
							Me.Msgboxperso(String.Concat("L'aménagement ' ", Me.doctxt(num + 4), " ' est introuvable." & VbCrLf & "Vérifiez que vous n'avez pas changé son nom."), "Erreur chargement")
						End If
					End If
					If (Operators.CompareString(Me.doctxt(num + 5), "", False) <> 0) Then
						item.Tagfix = Me.doctxt(num + 5)
						Me.Add_asso(item.Tagfix)
					End If
					item = Nothing
					num = num + 6
				Loop While num <= length
				Me.Buttonsauvegarder.PerformClick()
			End If
		End Sub

		Private Sub Chargement_radiobutton(ByVal path As String)
			Dim size As System.Drawing.Size
			Dim point As System.Drawing.Point
			If (Directory.Exists(path)) Then
				Me.cheminfichier = Nothing
				Me.cheminfichier = Directory.GetFiles(path)
				If (CInt(Me.cheminfichier.Length) = 0) Then
					Return
				End If
				Dim str As String = path
				If (Operators.CompareString(str, Module1.PATHS(14), False) = 0) Then
					Me.surface = Nothing
					Me.ImageList3.Images.Clear()
					Me.ImageList4.Images.Clear()
					Dim length As Integer = CInt(Me.cheminfichier.Length) - 1
					Dim num As Integer = 0
					Do
						Me.fs2 = File.OpenRead(Me.cheminfichier(num))
						Me.imagetraitee2 = Image.FromStream(Me.fs2)
						Me.ImageList3.Images.Add(Me.imagetraitee2)
						Me.ImageList4.Images.Add(Me.imagetraitee2)
						Me.fs2.Close()
						num = num + 1
					Loop While num <= length
					Me.hautp = Me.nbchecklarge - 1
					Me.largp = CInt(Math.Round(Conversion.Int(CDbl(CInt(Me.cheminfichier.Length)) / CDbl(Me.nbchecklarge))))
					Me.compt = 0
					ReDim Me.surface(Me.hautp + 1 - 1, Me.largp + 1 - 1)
					Dim num1 As Integer = Me.largp
					For i As Integer = 0 To num1 Step 1
						Dim num2 As Integer = Me.hautp
						For j As Integer = 0 To num2 Step 1
							Me.surface(j, i) = New RadioButton()
							Dim fileNameWithoutExtension As RadioButton = Me.surface(j, i)
							fileNameWithoutExtension.Appearance = Appearance.Button
							fileNameWithoutExtension.FlatStyle = FlatStyle.Standard
							size = New System.Drawing.Size(Module1.screenadaptX(70), Module1.screenadaptY(70))
							fileNameWithoutExtension.Size = size
							point = New System.Drawing.Point(Module1.screenadaptX(5 + j * 75), Module1.screenadaptY(5 + i * 75))
							fileNameWithoutExtension.Location = point
							fileNameWithoutExtension.Text = System.IO.Path.GetFileNameWithoutExtension(Me.cheminfichier(Me.compt))
							fileNameWithoutExtension.TextAlign = ContentAlignment.BottomCenter
							fileNameWithoutExtension.BackgroundImageLayout = ImageLayout.Center
							fileNameWithoutExtension.BackgroundImage = Me.ImageList3.Images(Me.compt)
							fileNameWithoutExtension.BackColor = Color.White
							fileNameWithoutExtension.Tag = Me.compt + 1
							AddHandler fileNameWithoutExtension.Click,  New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me.radiobuttonsurfclick(DirectCast(a0, RadioButton), a1))
							fileNameWithoutExtension.Cursor = Cursors.Hand
							fileNameWithoutExtension = Nothing
							If (j = 0 AndAlso i = 0) Then
								Me.surface(j, i).BackColor = Color.SkyBlue
								Me.surface(j, i).Checked = True
							End If
							Me.TabPage2.Controls.Add(Me.surface(j, i))
							Me.compt = Me.compt + 1
							If (Me.compt = CInt(Me.cheminfichier.Length)) Then
								Return
							End If
						Next

					Next

				ElseIf (Operators.CompareString(str, Module1.PATHS(15), False) = 0) Then
					Me.amen = Nothing
					Me.ImageList5.Images.Clear()
					Me.ImageList6.Images.Clear()
					Dim length1 As Integer = CInt(Me.cheminfichier.Length) - 1
					Dim num3 As Integer = 0
					Do
						Me.fs2 = File.OpenRead(Me.cheminfichier(num3))
						Me.imagetraitee2 = Image.FromStream(Me.fs2)
						Me.ImageList5.Images.Add(Me.imagetraitee2)
						Me.ImageList6.Images.Add(Me.imagetraitee2)
						Me.fs2.Close()
						num3 = num3 + 1
					Loop While num3 <= length1
					Me.hautp = Me.nbchecklarge - 1
					Me.largp = CInt(Math.Round(Conversion.Int(CDbl(CInt(Me.cheminfichier.Length)) / CDbl(Me.nbchecklarge))))
					Me.compt = 0
					ReDim Me.amen(Me.hautp + 1 - 1, Me.largp + 1 - 1)
					Dim num4 As Integer = Me.largp
					For k As Integer = 0 To num4 Step 1
						Dim num5 As Integer = Me.hautp
						For l As Integer = 0 To num5 Step 1
							Me.amen(l, k) = New RadioButton()
							Dim item As RadioButton = Me.amen(l, k)
							item.Appearance = Appearance.Button
							item.FlatStyle = FlatStyle.Standard
							size = New System.Drawing.Size(Module1.screenadaptX(70), Module1.screenadaptY(70))
							item.Size = size
							point = New System.Drawing.Point(Module1.screenadaptX(5 + l * 75), Module1.screenadaptY(5 + k * 75))
							item.Location = point
							item.Text = System.IO.Path.GetFileNameWithoutExtension(Me.cheminfichier(Me.compt))
							item.TextAlign = ContentAlignment.BottomCenter
							item.BackgroundImageLayout = ImageLayout.Center
							item.BackgroundImage = Me.ImageList5.Images(Me.compt)
							item.BackColor = Color.Transparent
							item.Tag = Me.compt + 1
							AddHandler item.Click,  New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me.radiobuttonamenclick(DirectCast(a0, RadioButton), a1))
							item.Cursor = Cursors.Hand
							item = Nothing
							If (l = 0 AndAlso k = 0) Then
								Me.amen(l, k).BackColor = Color.SkyBlue
								Me.amen(l, k).Checked = True
							End If
							Me.TabPage3.Controls.Add(Me.amen(l, k))
							Me.compt = Me.compt + 1
							If (Me.compt = CInt(Me.cheminfichier.Length)) Then
								Return
							End If
						Next

					Next

				End If
			End If
		End Sub

		Public Sub Chargement_radiobutton_listeleg()
			Me.TabPage1.Controls.Clear()
			Me.ImageList1.Images.Clear()
			Me.ImageList2.Images.Clear()
			Dim num As Integer = Module1.nbrlegumesbase - 1
			Dim num1 As Integer = 0
			Do
				If (Not File.Exists(String.Concat(Module1.PATHS(13), "\", Module1.listelégumes(num1), ".png"))) Then
					Me.ImageList1.Images.Add(Resources.blanc)
					Me.ImageList2.Images.Add(Resources.blanc)
				Else
					Me.fs = File.OpenRead(String.Concat(Module1.PATHS(13), "\", Module1.listelégumes(num1), ".png"))
					Me.imagetraitee = Image.FromStream(Me.fs)
					Me.ImageList1.Images.Add(Me.imagetraitee)
					Me.ImageList2.Images.Add(Me.imagetraitee)
					Me.fs.Close()
				End If
				num1 = num1 + 1
			Loop While num1 <= num
			Me.haut = Me.nbchecklarge - 1
			Me.larg = CInt(Math.Round(Conversion.Int(CDbl(CInt(Module1.listelégumes.Length)) / CDbl(Me.nbchecklarge))))
			Me.compt = 0
			ReDim Me.check(Me.haut + 1 - 1, Me.larg + 1 - 1)
			Dim num2 As Integer = Me.larg
			For i As Integer = 0 To num2 Step 1
				Dim num3 As Integer = Me.haut
				Dim num4 As Integer = 0
				Do
					Me.check(num4, i) = New RadioButton()
					Me.Ttradiobutton.SetToolTip(Me.check(num4, i), Module1.ttcbb(Me.compt))
					Dim white As RadioButton = Me.check(num4, i)
					white.Appearance = Appearance.Button
					white.FlatStyle = FlatStyle.Standard
					Dim size As System.Drawing.Size = New System.Drawing.Size(Module1.screenadaptX(70), Module1.screenadaptY(70))
					white.Size = size
					Dim point As System.Drawing.Point = New System.Drawing.Point(Module1.screenadaptX(5 + num4 * 75), Module1.screenadaptY(5 + i * 75))
					white.Location = point
					white.Text = Module1.listelégumes(Me.compt)
					white.TextAlign = ContentAlignment.BottomCenter
					white.BackgroundImageLayout = ImageLayout.Center
					white.BackColor = Color.White
					white.Tag = Me.compt + 1
					AddHandler white.Click,  New EventHandler(Sub(a0 As Object, a1 As EventArgs) Me.radiobuttonlegclick(DirectCast(a0, RadioButton), a1))
					white.BackgroundImage = Me.ImageList1.Images(Me.compt)
					white.Cursor = Cursors.Hand
					white = Nothing
					If (num4 = 0 AndAlso i = 0) Then
						Me.check(num4, i).BackColor = Color.SkyBlue
						Me.check(num4, i).Checked = True
					End If
					Me.TabPage1.Controls.Add(Me.check(num4, i))
					Me.compt = Me.compt + 1
					If (Me.compt = CInt(Module1.listelégumes.Length)) Then
						Exit Do
					End If
					num4 = num4 + 1
				Loop While num4 <= num3
				If (Me.compt = CInt(Module1.listelégumes.Length)) Then
					Exit For
				End If
			Next

		End Sub

		Public Sub ChargementBDDasso()
			Try
				Me.lecture0 = New StreamReader(Module1.PATHS(1), Encoding.[Default])
				ReDim Module1.Base_de_données_associations(Module1.nbrlegumesbase - 1 + 1 - 1, Module1.nbrlegumesbase - 1 + 1 - 1)
				Me.compt = 0
				While Me.lecture0.Peek() <> -1
					Me.lignefichiertxt = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(Me.lignefichiertxt, Array), New String(Me.compt + 1 - 1) {}), String())
					Me.lignefichiertxt(Me.compt) = Me.lecture0.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Me.nbrligne = Me.compt - 1
				ReDim Me.lignefichiertxtconverties(Me.nbrligne + 1 - 1)
				Dim num As Integer = Me.nbrligne
				Dim num1 As Integer = 0
				Do
					Dim num2 As Integer = Module1.nbrlegumesbase - 1
					Dim num3 As Integer = 0
					Do
						If (Operators.CompareString(Module1.listelégumes(num3), Me.lignefichiertxt(num1), False) = 0) Then
							Me.lignefichiertxtconverties(num1) = num3
						End If
						num3 = num3 + 1
					Loop While num3 <= num2
					If (Operators.CompareString(Me.lignefichiertxt(num1), "n", False) = 0) Then
						Me.lignefichiertxtconverties(num1) = -1
					End If
					If (Operators.CompareString(Me.lignefichiertxt(num1), "o", False) = 0) Then
						Me.lignefichiertxtconverties(num1) = 1
					End If
					num1 = num1 + 1
				Loop While num1 <= num
				Dim num4 As Integer = Me.nbrligne - 2
				Dim num5 As Integer = 0
				Do
					Module1.Base_de_données_associations(Me.lignefichiertxtconverties(num5), Me.lignefichiertxtconverties(num5 + 1)) = Me.lignefichiertxtconverties(num5 + 2)
					num5 = num5 + 3
				Loop While num5 <= num4
				Me.lecture0.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Me.Msgboxperso("Erreur chargement base de données associations !", "Erreur")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Public Sub ChargementBDDcal()
			Try
				Me.lecture0 = New StreamReader(Module1.PATHS(11), Encoding.[Default])
				Me.compt = 0
				While Me.lecture0.Peek() <> -1
					Module1.Base_de_données_calendrier = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(Module1.Base_de_données_calendrier, Array), New String(Me.compt + 1 - 1) {}), String())
					Module1.Base_de_données_calendrier(Me.compt) = Me.lecture0.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Module1.nbrlignecal = Me.compt
				Me.lecture0.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Me.Msgboxperso("Erreur chargement base de données calendrier !", "Erreur")
				ProjectData.ClearProjectError()
			End Try
			Module1.ttcbb = Nothing
			ReDim Module1.ttcbb(Module1.nbrlegumesbase - 1 + 1 - 1)
			Dim num As Integer = Module1.nbrlignecal - 1
			For i As Integer = 0 To num Step 9
				Dim num1 As Integer = Module1.nbrlegumesbase - 1
				Dim num2 As Integer = 0
				While num2 <= num1
					If (Operators.CompareString(Module1.Base_de_données_calendrier(i), Module1.listelégumes(num2), False) <> 0) Then
						num2 = num2 + 1
					Else
						Dim strArrays As String() = Module1.ttcbb
						Dim baseDeDonnéesCalendrier() As String = { Module1.Base_de_données_calendrier(i), " : ", Module1.Base_de_données_calendrier(i + 6), ",", Module1.Base_de_données_calendrier(i + 1) }
						strArrays(num2) = String.Concat(baseDeDonnéesCalendrier)
						Exit While
					End If
				End While
			Next

		End Sub

		Public Sub ChargementBDDlisteleg()
			Try
				Me.lecture0 = New StreamReader(Module1.PATHS(0), Encoding.[Default])
				Me.compt = 0
				While Me.lecture0.Peek() <> -1
					Module1.listelégumes = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(Module1.listelégumes, Array), New String(Me.compt + 1 - 1) {}), String())
					Module1.listelégumes(Me.compt) = Me.lecture0.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Module1.nbrlegumesbase = Me.compt
				Array.Sort(Of String)(Module1.listelégumes)
				Me.lecture0.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Me.Msgboxperso("Erreur chargement base de données légumes !", "Erreur")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Public Sub ChargementBDDpoireau()
			Try
				Me.lecture = New StringReader(Module1.PATHS(10))
				Me.compt = 0
				While Me.lecture.Peek() <> -1
					Module1.Lepoireaupreferelesfraises = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(Module1.Lepoireaupreferelesfraises, Array), New String(Me.compt + 1 - 1) {}), String())
					Module1.Lepoireaupreferelesfraises(Me.compt) = Me.lecture.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Module1.nbranecdote = Me.compt / 3
				Me.lecture.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Me.Msgboxperso("Erreur chargement le poireau préfère les fraises !", "Erreur")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Public Sub ChargementBDDrot()
			Me.ChargementBDDcal()
			Select Case Module1.checkrotfam
				Case False
					Select Case Module1.checkrottype
						Case False
							Select Case Module1.checkrotbdd
								Case False
									Me.aucunerot()

								Case True
									Me.aucunerot()
									Me.rotbdd()

							End Select

						Case True
							Select Case Module1.checkrotbdd
								Case False
									Me.aucunerot()
									Me.rottype()

								Case True
									Me.aucunerot()
									Me.rotbdd()
									Me.rottype()

							End Select

					End Select

				Case True
					Select Case Module1.checkrottype
						Case False
							Select Case Module1.checkrotbdd
								Case False
									Me.aucunerot()
									Me.rotfam()
									Exit Select
								Case True
									Me.aucunerot()
									Me.rotbdd()
									Me.rotfam()
									Exit Select
							End Select

						Case True
							Select Case Module1.checkrotbdd
								Case False
									Me.aucunerot()
									Me.rottype()
									Me.rotfam()

								Case True
									Me.aucunerot()
									Me.rotbdd()
									Me.rottype()
									Me.rotfam()

							End Select

					End Select

			End Select
		End Sub

		Private Sub check_mousehover(ByVal sender As SVPLCApplication.PictureBox1, ByVal e As EventArgs)
			sender.BackColor = Color.Peru
			Me.coordX = sender.CX
			Me.coordY = sender.CY
			Dim darkGreen As SVPLCApplication.PictureBox1 = Me.grille2(Me.coordX, Me.coordY)
			Dim backColor As Color = darkGreen.BackColor
			If (backColor = Color.Green) Then
				darkGreen.BackColor = Color.DarkGreen
			ElseIf (backColor = Color.Red) Then
				darkGreen.BackColor = Color.DarkRed
			ElseIf (backColor = Color.LightGray) Then
				darkGreen.BackColor = Color.DarkGray
			ElseIf (backColor = Color.DarkGray) Then
				If (Me.grille(Me.coordX, Me.coordY).Indexp = -1) Then
					darkGreen.BackColor = Color.Gray
				End If
			ElseIf (backColor = Color.Khaki) Then
				darkGreen.BackColor = Color.LightGray
			End If
			darkGreen = Nothing
		End Sub

		Private Sub check_mouseleave(ByVal sender As SVPLCApplication.PictureBox1, ByVal e As EventArgs)
			sender.BackColor = Color.Khaki
			Me.coordX = sender.CX
			Me.coordY = sender.CY
			Dim green As SVPLCApplication.PictureBox1 = Me.grille2(Me.coordX, Me.coordY)
			Dim backColor As Color = green.BackColor
			If (backColor = Color.DarkGreen) Then
				If (Operators.ConditionalCompareObjectNotEqual(green.Tag, 1, False)) Then
					green.BackColor = Color.Green
				End If
			ElseIf (backColor = Color.DarkRed) Then
				If (Operators.ConditionalCompareObjectNotEqual(green.Tag, 4, False)) Then
					green.BackColor = Color.Red
				End If
			ElseIf (backColor = Color.DarkGray) Then
				If (Operators.ConditionalCompareObjectNotEqual(green.Tag, 3, False)) Then
					green.BackColor = Color.LightGray
				End If
			ElseIf (backColor = Color.Gray) Then
				If (Operators.ConditionalCompareObjectNotEqual(green.Tag, 2, False)) Then
					green.BackColor = Color.DarkGray
				End If
			ElseIf (backColor = Color.LightGray) Then
				If (Me.grille(Me.coordX, Me.coordY).Indexp <> -1) Then
					green.BackColor = Color.DarkGray
				Else
					green.BackColor = Color.Khaki
				End If
			End If
			green = Nothing
		End Sub

		Private Sub checkbox_Click(ByVal sender As SVPLCApplication.PictureBox1, ByVal e As EventArgs)
			Dim rotpos As Label
			Select Case Me.CheckBoxsupp.Checked
				Case False
					Select Case Me.CustomTabControl1.SelectedIndex
						Case 0
							Me.Correction_echelle(sender)
							If (Operators.ConditionalCompareObjectNotEqual(sender.Tag, "000", False)) Then
								Me.Add_asso(Conversions.ToString(sender.Tag))
								sender.Tagfix = Conversions.ToString(sender.Tag)
								sender.Tag = "000"
							End If
							Me.Infobullegrille.SetToolTip(sender, Module1.listelégumes(Me.indexselectleg - 1))
							sender.Image = Me.ImageList2.Images(Me.indexselectleg - 1)
							sender.Indexp = Me.indexselectleg - 1
							sender.Indexa = -1
							Me.coordX = sender.CX
							Me.coordY = sender.CY
							Dim backColor As Color = Me.grille2(Me.coordX, Me.coordY).BackColor
							If (backColor = Color.DarkGreen) Then
								Me.grille2(Me.coordX, Me.coordY).Tag = 1
								rotpos = Me.Rotpos
								rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) + 1)
								rotpos = Me.Rotechelle
								rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) + 1)
							ElseIf (backColor = Color.DarkRed) Then
								Me.grille2(Me.coordX, Me.coordY).Tag = 4
								rotpos = Me.Rotneg
								rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) - 1)
								rotpos = Me.Rotechelle
								rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) + 1)
							ElseIf (backColor = Color.LightGray) Then
								Me.grille2(Me.coordX, Me.coordY).BackColor = Color.DarkGray
								Me.grille2(Me.coordX, Me.coordY).Tag = 3
							ElseIf (backColor <> Color.DarkGray) Then
								If (backColor <> Color.Gray) Then
									Return
								End If
								Me.grille2(Me.coordX, Me.coordY).Tag = 2
								rotpos = Me.Rotechelle
								rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) + 1)
							Else
								If (Not Operators.ConditionalCompareObjectNotEqual(Me.grille2(Me.coordX, Me.coordY).Tag, 3, False)) Then
									Return
								End If
								Me.grille2(Me.coordX, Me.coordY).BackColor = Color.Gray
								Me.grille2(Me.coordX, Me.coordY).Tag = 3
							End If

						Case 1
							sender.BackgroundImage = Me.ImageList4.Images(Me.indexselectsurf - 1)
							sender.Indexs = Me.indexselectsurf - 1

						Case 2
							If (sender.Indexp <> -1) Then
								Me.Del_asso(sender.Tagfix)
								sender.Indexp = -1
							End If
							sender.Image = Me.ImageList6.Images(Me.indexselectamen - 1)
							sender.Indexa = Me.indexselectamen - 1

					End Select

				Case True
					Me.Infobullegrille.SetToolTip(sender, Nothing)
					sender.Image = Nothing
					sender.BackgroundImage = Nothing
					sender.Indexa = -1
					sender.Indexp = -1
					sender.Indexs = -1
					sender.Tag = "000"
					If (sender.Tagfix IsNot Nothing) Then
						Me.Correction_echelle(sender)
						Me.Del_asso(sender.Tagfix)
						sender.Tagfix = "000"
					End If
					If (Operators.ConditionalCompareObjectEqual(Me.grille2(Me.coordX, Me.coordY).Tag, 1, False)) Then
						rotpos = Me.Rotechelle
						rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) - 1)
						rotpos = Me.Rotpos
						rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) - 1)
						Me.grille2(Me.coordX, Me.coordY).Tag = Nothing
						Me.grille2(Me.coordX, Me.coordY).BackColor = Color.DarkGray
						If (Module1.Base_de_données_rotations(Me.GrilleReferente(Me.coordX, Me.coordY) - 1, Me.indexselectleg - 1) = 1) Then
							Me.grille2(Me.coordX, Me.coordY).BackColor = Color.Green
							Return
						End If
						If (Module1.Base_de_données_rotations(Me.GrilleReferente(Me.coordX, Me.coordY) - 1, Me.indexselectleg - 1) = -1) Then
							Me.grille2(Me.coordX, Me.coordY).BackColor = Color.Red
							Return
						End If
					End If
					If (Me.grille2(Me.coordX, Me.coordY).BackColor = Color.Gray) Then
						If (Operators.ConditionalCompareObjectEqual(Me.grille2(Me.coordX, Me.coordY).Tag, 3, False)) Then
							Me.grille2(Me.coordX, Me.coordY).BackColor = Color.Khaki
							Me.grille2(Me.coordX, Me.coordY).Tag = Nothing
						End If
						If (Operators.ConditionalCompareObjectEqual(Me.grille2(Me.coordX, Me.coordY).Tag, 2, False)) Then
							rotpos = Me.Rotechelle
							rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) - 1)
							Me.grille2(Me.coordX, Me.coordY).Tag = Nothing
						End If
					End If
					If (Not Operators.ConditionalCompareObjectEqual(Me.grille2(Me.coordX, Me.coordY).Tag, 4, False)) Then
						Exit Select
					End If
					rotpos = Me.Rotechelle
					rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) - 1)
					rotpos = Me.Rotneg
					rotpos.Text = Conversions.ToString(Conversions.ToDouble(rotpos.Text) + 1)
					Me.grille2(Me.coordX, Me.coordY).Tag = Nothing
					Me.grille2(Me.coordX, Me.coordY).BackColor = Color.DarkGray
					If (Module1.Base_de_données_rotations(Me.GrilleReferente(Me.coordX, Me.coordY) - 1, Me.indexselectleg - 1) = 1) Then
						Me.grille2(Me.coordX, Me.coordY).BackColor = Color.Green
						Return
					End If
					If (Module1.Base_de_données_rotations(Me.GrilleReferente(Me.coordX, Me.coordY) - 1, Me.indexselectleg - 1) <> -1) Then
						Exit Select
					End If
					Me.grille2(Me.coordX, Me.coordY).BackColor = Color.Red
					Return
			End Select
		End Sub

		Private Sub CheckBoxsupp_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim str As String
			Select Case Me.CheckBoxsupp.Checked
				Case False
					Dim panel As System.Windows.Forms.Panel = Me.Panel
					str = String.Concat(Application.StartupPath, "\Pellecurseur.cur")
					panel.Cursor = New System.Windows.Forms.Cursor(FormPasPas.LoadCursorFromFile(str))
					Me.ROTATIONGRILLE2()
					Exit Select
				Case True
					Dim cursor As System.Windows.Forms.Panel = Me.Panel
					str = String.Concat(Application.StartupPath, "\grass.cur")
					cursor.Cursor = New System.Windows.Forms.Cursor(FormPasPas.LoadCursorFromFile(str))
					Exit Select
			End Select
		End Sub

		Private Sub ConsulterEtGérerLaBasedeDonnéesAssociationsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadbddass) Then
				Me.CBDDASS = New FormBDDASS()
				Me.CBDDASS.Show()
				Module1.loadbddass = True
			Else
				Me.CBDDASS.WindowState = FormWindowState.Normal
				Me.CBDDASS.Activate()
			End If
		End Sub

		Private Sub ConsulterEtGérerLaBaseDeDonnéesCalendrierToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadcal) Then
				Me.CBDDCAL = New FormBDDCal()
				Me.CBDDCAL.Show()
				Module1.loadcal = True
			Else
				Me.CBDDCAL.WindowState = FormWindowState.Normal
				Me.CBDDCAL.Activate()
			End If
		End Sub

		Private Sub ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadbddfiche) Then
				Me.CBDDFiche = New FormBDDFICHE()
				Me.CBDDFiche.Show()
				Module1.loadbddfiche = True
			Else
				Me.CBDDFiche.WindowState = FormWindowState.Normal
				Me.CBDDFiche.Activate()
			End If
		End Sub

		Private Sub ConsulterEtGérerLaBaseDeDonnéesRotationsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadbddrot) Then
				Me.CBDDROT = New FormBDDROT()
				Me.CBDDROT.Show()
				Module1.loadbddrot = True
			Else
				Me.CBDDROT.WindowState = FormWindowState.Normal
				Me.CBDDROT.Activate()
			End If
		End Sub

		Private Sub Correction_echelle(ByVal pict As SVPLCApplication.PictureBox1)
			If (pict.Indexp = -1) Then
				Me.ech = 0
				If (pict.CX <> Me.nbrcellules - 1 AndAlso Me.grille(pict.CX + 1, pict.CY).Indexp <> -1) Then
					Me.ech = Me.ech + 1
				End If
				If (pict.CY <> Me.nbrcellules - 1 AndAlso Me.grille(pict.CX, pict.CY + 1).Indexp <> -1) Then
					Me.ech = Me.ech + 1
				End If
				If (pict.CX <> 0 AndAlso Me.grille(pict.CX - 1, pict.CY).Indexp <> -1) Then
					Me.ech = Me.ech + 1
				End If
				If (pict.CY <> 0 AndAlso Me.grille(pict.CX, pict.CY - 1).Indexp <> -1) Then
					Me.ech = Me.ech + 1
				End If
				Select Case Me.CheckBoxsupp.Checked
					Case False
						pict.Tag = String.Concat(Strings.Mid(Conversions.ToString(pict.Tag), 1, 2), Conversions.ToString(Me.ech))
						Exit Select
					Case True
						pict.Tagfix = String.Concat(Strings.Mid(Conversions.ToString(pict.Tag), 1, 2), Conversions.ToString(Me.ech))
						Exit Select
				End Select
			End If
		End Sub

		Private Sub Del_asso(ByVal str As String)
			Dim assopos As Label = Me.Assopos
			assopos.Text = Conversions.ToString(Conversions.ToDouble(assopos.Text) - CDbl(Conversions.ToInteger(Strings.Mid(str, 1, 1))))
			assopos = Me.Assoneg
			assopos.Text = Conversions.ToString(Conversions.ToDouble(assopos.Text) + CDbl(Conversions.ToInteger(Strings.Mid(str, 2, 1))))
			assopos = Me.Assoechelle
			assopos.Text = Conversions.ToString(Conversions.ToDouble(assopos.Text) - CDbl(Conversions.ToInteger(Strings.Mid(str, 3, 1))))
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

		Private Sub Empreinte_grilleA()
			Me.RESET_grilleB()
			Dim num As Integer = Me.nbrcellules - 1
			For i As Integer = 0 To num Step 1
				Dim num1 As Integer = Me.nbrcellules - 1
				For j As Integer = 0 To num1 Step 1
					If (Me.grille(i, j).Indexp = -1) Then
						Me.grille2(i, j).BackColor = Color.Khaki
					Else
						Me.grille2(i, j).BackColor = Color.DarkGray
						Me.grille2(i, j).Indexp = 1
					End If
				Next

			Next

		End Sub

		Public Function encrypt(ByVal str As String) As String
			Dim mD5CryptoServiceProvider As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider()
			Dim numArray As Byte() = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(str))
			Dim str1 As String = ""
			Dim numArray1 As Byte() = numArray
			Dim num As Integer = 0
			Do
				Dim num1 As Byte = numArray1(num)
				str1 = String.Concat(str1, num1.ToString("x2"))
				num = num + 1
			Loop While num < CInt(numArray1.Length)
			Return str1
		End Function

		Private Sub ENREGISTRER(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Me.nomfichier = Me.SaveFileDialog1.FileName
				If (Me.Bordannee0.BorderColor = Color.Green) Then
					If (File.Exists(Me.nomfichier)) Then
						File.Delete(Me.nomfichier)
					End If
					File.Copy(String.Concat(Module1.PATHS(17), "\annee0.txt"), Me.nomfichier)
					File.Copy(String.Concat(Module1.PATHS(17), "\annee0.bmp"), String.Concat(Module1.PATHS(16), "\", Path.GetFileNameWithoutExtension(Me.nomfichier), ".bmp"))
				End If
				If (Me.Bordannee1.BorderColor = Color.Green) Then
					If (File.Exists(Me.nomfichier)) Then
						File.Delete(Me.nomfichier)
					End If
					File.Copy(String.Concat(Module1.PATHS(17), "\annee1.txt"), Me.nomfichier)
					File.Copy(String.Concat(Module1.PATHS(17), "\annee1.bmp"), String.Concat(Module1.PATHS(16), "\", Path.GetFileNameWithoutExtension(Me.nomfichier), ".bmp"))
				End If
				If (Me.Bordannee2.BorderColor = Color.Green) Then
					If (File.Exists(Me.nomfichier)) Then
						File.Delete(Me.nomfichier)
					End If
					File.Copy(String.Concat(Module1.PATHS(17), "\annee2.txt"), Me.nomfichier)
					File.Copy(String.Concat(Module1.PATHS(17), "\annee2.bmp"), String.Concat(Module1.PATHS(16), "\", Path.GetFileNameWithoutExtension(Me.nomfichier), ".bmp"))
				End If
			End If
		End Sub

		Private Sub FaireUnDonToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=Q77WT2ELDK3K8")
		End Sub

		<DllImport("user32", CharSet:=CharSet.Ansi, EntryPoint:="FindWindowA", ExactSpelling:=True, SetLastError:=True)>
		Public Shared Function FindWindow(ByRef lpClassName As String, ByRef lpWindowName As String) As Integer
		End Function

		Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Dim enumerator As IEnumerator = Nothing
			Me.Visible = False
			Try
				enumerator = MyProject.Application.OpenForms.GetEnumerator()
				While enumerator.MoveNext()
					DirectCast(enumerator.Current, Form).Visible = False
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		Private Sub gestionconflitrot(ByVal int1 As Integer, ByVal int2 As Integer, ByVal str As String, ByVal int As Integer)
			Dim str1 As String = ""
			Select Case int
				Case -1
					str1 = "négative"
					If (Module1.masquerlesconflits) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					ElseIf (Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat("Un conflit dans la matrice de rotations a été détecté." & VbCrLf & "" & VbCrLf & "", Module1.listelégumes(int1)), "" & VbCrLf & ""), Module1.listelégumes(int2)), "" & VbCrLf & ""), "" & VbCrLf & ""), "La rotation entre ces deux légumes est incompatible entre:"), "" & VbCrLf & ""), "" & VbCrLf & ""), Module1.SptRg2(Module1.Base_de_données_rotationsstr(int1, int2))), "" & VbCrLf & ""), Module1.SptRg2(str)), "" & VbCrLf & ""), "" & VbCrLf & ""), "Voulez vous mettre à jour la matrice?"), "" & VbCrLf & ""), "Cliquez sur le bouton 'Oui' pour privilégier la contrainte "), Module1.SptRg2(str)), " ou sur le bouton 'Non' pour garder la rotation "), str1), "."), MsgBoxStyle.YesNo, "Conflit sur les rotations") = MsgBoxResult.Yes) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					End If
					Return
				Case 0
					If (Module1.masquerlesconflits) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					ElseIf (Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat("Un conflit dans la matrice de rotations a été détecté." & VbCrLf & "" & VbCrLf & "", Module1.listelégumes(int1)), "" & VbCrLf & ""), Module1.listelégumes(int2)), "" & VbCrLf & ""), "" & VbCrLf & ""), "La rotation entre ces deux légumes est incompatible entre:"), "" & VbCrLf & ""), "" & VbCrLf & ""), Module1.SptRg2(Module1.Base_de_données_rotationsstr(int1, int2))), "" & VbCrLf & ""), Module1.SptRg2(str)), "" & VbCrLf & ""), "" & VbCrLf & ""), "Voulez vous mettre à jour la matrice?"), "" & VbCrLf & ""), "Cliquez sur le bouton 'Oui' pour privilégier la contrainte "), Module1.SptRg2(str)), " ou sur le bouton 'Non' pour garder la rotation "), str1), "."), MsgBoxStyle.YesNo, "Conflit sur les rotations") = MsgBoxResult.Yes) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					End If
					Return
				Case 1
					str1 = "positive"
					If (Module1.masquerlesconflits) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					ElseIf (Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat("Un conflit dans la matrice de rotations a été détecté." & VbCrLf & "" & VbCrLf & "", Module1.listelégumes(int1)), "" & VbCrLf & ""), Module1.listelégumes(int2)), "" & VbCrLf & ""), "" & VbCrLf & ""), "La rotation entre ces deux légumes est incompatible entre:"), "" & VbCrLf & ""), "" & VbCrLf & ""), Module1.SptRg2(Module1.Base_de_données_rotationsstr(int1, int2))), "" & VbCrLf & ""), Module1.SptRg2(str)), "" & VbCrLf & ""), "" & VbCrLf & ""), "Voulez vous mettre à jour la matrice?"), "" & VbCrLf & ""), "Cliquez sur le bouton 'Oui' pour privilégier la contrainte "), Module1.SptRg2(str)), " ou sur le bouton 'Non' pour garder la rotation "), str1), "."), MsgBoxStyle.YesNo, "Conflit sur les rotations") = MsgBoxResult.Yes) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					End If
					Return
				Case Else
					If (Module1.masquerlesconflits) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					ElseIf (Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat(String.Concat("Un conflit dans la matrice de rotations a été détecté." & VbCrLf & "" & VbCrLf & "", Module1.listelégumes(int1)), "" & VbCrLf & ""), Module1.listelégumes(int2)), "" & VbCrLf & ""), "" & VbCrLf & ""), "La rotation entre ces deux légumes est incompatible entre:"), "" & VbCrLf & ""), "" & VbCrLf & ""), Module1.SptRg2(Module1.Base_de_données_rotationsstr(int1, int2))), "" & VbCrLf & ""), Module1.SptRg2(str)), "" & VbCrLf & ""), "" & VbCrLf & ""), "Voulez vous mettre à jour la matrice?"), "" & VbCrLf & ""), "Cliquez sur le bouton 'Oui' pour privilégier la contrainte "), Module1.SptRg2(str)), " ou sur le bouton 'Non' pour garder la rotation "), str1), "."), MsgBoxStyle.YesNo, "Conflit sur les rotations") = MsgBoxResult.Yes) Then
						Module1.Base_de_données_rotations(int1, int2) = 0 - Module1.Base_de_données_rotations(int1, int2)
						Module1.Base_de_données_rotationsstr(int1, int2) = Conversions.ToString(Operators.ConcatenateObject("1", Module1.SptRg2(str)))
					End If
					Return
			End Select
		End Sub

		Public Function GetDriveSerialNumber() As String
			Dim num As Long
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject", ""))
			Dim objArray(0) As Object
			Dim obj As Object = objectValue
			Dim baseDirectory(0) As Object
			Dim currentDomain As AppDomain = AppDomain.CurrentDomain
			baseDirectory(0) = currentDomain.BaseDirectory
			objArray(0) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, Nothing, "GetDriveName", baseDirectory, Nothing, Nothing, Nothing))
			Dim objArray1 As Object() = objArray
			Dim flagArray() As Boolean = { True }
			Dim obj1 As Object = NewLateBinding.LateGet(objectValue, Nothing, "GetDrive", objArray1, Nothing, Nothing, flagArray)
			If (flagArray(0)) Then
				Dim baseDirectory1() As Object = { currentDomain.BaseDirectory, RuntimeHelpers.GetObjectValue(objArray1(0)) }
				NewLateBinding.LateSetComplex(obj, Nothing, "GetDriveName", baseDirectory1, Nothing, Nothing, True, False)
			End If
			Dim objectValue1 As Object = RuntimeHelpers.GetObjectValue(obj1)
			num = If(Not Conversions.ToBoolean(NewLateBinding.LateGet(objectValue1, Nothing, "IsReady", New Object(-1) {}, Nothing, Nothing, Nothing)), CLng(-1), Conversions.ToLong(NewLateBinding.LateGet(objectValue1, Nothing, "SerialNumber", New Object(-1) {}, Nothing, Nothing, Nothing)))
			objectValue1 = Nothing
			objectValue = Nothing
			Return Conversion.Hex(num)
		End Function

		Private Sub hideonglet()
			Dim panelonglet As System.Windows.Forms.Panel = Me.Panelonglet
			panelonglet.BackgroundImage = Resources.Tiroir
			Dim num As Integer = 0 - Module1.screenadaptX(97)
			Dim location As Point = Me.Panelonglet.Location
			panelonglet.Location = New Point(num, location.Y)
			panelonglet.SendToBack()
			panelonglet = Nothing
		End Sub

		Private Sub IMPORTER(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.OpenFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Me.nomfichier = Me.OpenFileDialog2.FileName
				If (Me.Bordannee0.BorderColor = Color.Green) Then
					If (MyProject.Computer.FileSystem.FileExists(String.Concat(Module1.PATHS(17), "\annee0.txt"))) Then
						MyProject.Computer.FileSystem.DeleteFile(String.Concat(Module1.PATHS(17), "\annee0.txt"))
					End If
					File.Copy(Me.nomfichier, String.Concat(Module1.PATHS(17), "\annee0.txt"))
				End If
				If (Me.Bordannee1.BorderColor = Color.Green) Then
					If (MyProject.Computer.FileSystem.FileExists(String.Concat(Module1.PATHS(17), "\annee1.txt"))) Then
						MyProject.Computer.FileSystem.DeleteFile(String.Concat(Module1.PATHS(17), "\annee1.txt"))
					End If
					File.Copy(Me.nomfichier, String.Concat(Module1.PATHS(17), "\annee1.txt"))
				End If
				If (Me.Bordannee2.BorderColor = Color.Green) Then
					If (MyProject.Computer.FileSystem.FileExists(String.Concat(Module1.PATHS(17), "\annee2.txt"))) Then
						MyProject.Computer.FileSystem.DeleteFile(String.Concat(Module1.PATHS(17), "\annee2.txt"))
					End If
					File.Copy(Me.nomfichier, String.Concat(Module1.PATHS(17), "\annee2.txt"))
				End If
				Me.Chargement(Me.nomfichier)
				Me.ROTATIONGRILLE2()
			End If
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPasPas))
			Me.Panel = New System.Windows.Forms.Panel()
			Me.Buttonreset = New System.Windows.Forms.Button()
			Me.CheckBoxsupp = New System.Windows.Forms.CheckBox()
			Me.Panel1 = New System.Windows.Forms.Panel()
			Me.ImageList1 = New ImageList(Me.components)
			Me.BackgroundWorker1 = New BackgroundWorker()
			Me.Buttonchangementimg = New System.Windows.Forms.Button()
			Me.OpenFileDialog1 = New OpenFileDialog()
			Me.ImageList2 = New ImageList(Me.components)
			Me.PictureBox4 = New System.Windows.Forms.PictureBox()
			Me.PictureBox5 = New System.Windows.Forms.PictureBox()
			Me.Buttonsauvegarder = New System.Windows.Forms.Button()
			Me.SaveFileDialog1 = New SaveFileDialog()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.OpenFileDialog2 = New OpenFileDialog()
			Me.PictureBox2 = New System.Windows.Forms.PictureBox()
			Me.ImageList3 = New ImageList(Me.components)
			Me.ImageList4 = New ImageList(Me.components)
			Me.ImageList5 = New ImageList(Me.components)
			Me.ImageList6 = New ImageList(Me.components)
			Me.Buttonajouter = New System.Windows.Forms.Button()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Assopos = New System.Windows.Forms.Label()
			Me.Assoneg = New System.Windows.Forms.Label()
			Me.Assoechelle = New System.Windows.Forms.Label()
			Me.Label7 = New System.Windows.Forms.Label()
			Me.Rotneg = New System.Windows.Forms.Label()
			Me.Rotechelle = New System.Windows.Forms.Label()
			Me.Rotpos = New System.Windows.Forms.Label()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
			Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.MenuPrinc = New System.Windows.Forms.MenuStrip()
			Me.FichierMenu = New ToolStripMenuItem()
			Me.ImprimerMenu = New ToolStripMenuItem()
			Me.CacherLaBarreDeTâcheToolStripMenuItem = New ToolStripMenuItem()
			Me.QuitterMenu = New ToolStripMenuItem()
			Me.BasededonneesMenu = New ToolStripMenuItem()
			Me.BDDAssociationsMenu = New ToolStripMenuItem()
			Me.BDDRotationsMenu = New ToolStripMenuItem()
			Me.BDDCalendrierMenu = New ToolStripMenuItem()
			Me.ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem = New ToolStripMenuItem()
			Me.AjouterUnNouveauLégumeToolStripMenuItem = New ToolStripMenuItem()
			Me.RenommerUnLégumeExistantToolStripMenuItem = New ToolStripMenuItem()
			Me.SupprimerUnLégumeToolStripMenuItem = New ToolStripMenuItem()
			Me.OutilsToolStripMenuItem = New ToolStripMenuItem()
			Me.MonJardinMenu = New ToolStripMenuItem()
			Me.CalculatriceToolStripMenuItem = New ToolStripMenuItem()
			Me.CalendrierLunaireToolStripMenuItem = New ToolStripMenuItem()
			Me.BibliothèqueMenu = New ToolStripMenuItem()
			Me.HelpMenu = New ToolStripMenuItem()
			Me.AProposDeMenu = New ToolStripMenuItem()
			Me.AboutMenu = New ToolStripMenuItem()
			Me.FaireUnDonToolStripMenuItem = New ToolStripMenuItem()
			Me.Panel5 = New System.Windows.Forms.Panel()
			Me.Panel6 = New System.Windows.Forms.Panel()
			Me.Panelonglet = New System.Windows.Forms.Panel()
			Me.PictureBox3 = New System.Windows.Forms.PictureBox()
			Me.Button7 = New System.Windows.Forms.Button()
			Me.Button6 = New System.Windows.Forms.Button()
			Me.Button5 = New System.Windows.Forms.Button()
			Me.Button4 = New System.Windows.Forms.Button()
			Me.Button3 = New System.Windows.Forms.Button()
			Me.Button2 = New System.Windows.Forms.Button()
			Me.PrintDocument1 = New PrintDocument()
			Me.Infobullegrille = New ToolTip(Me.components)
			Me.Infobulleraccourcis = New ToolTip(Me.components)
			Me.Infobullegrille2 = New ToolTip(Me.components)
			Me.Ttradiobutton = New ToolTip(Me.components)
			Me.ImageList7 = New ImageList(Me.components)
			Me.Label5 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Timerinstallmsg = New Timer(Me.components)
			Me.Timer1 = New Timer(Me.components)
			Me.PictureBoxpanneau = New System.Windows.Forms.PictureBox()
			Me.Label6 = New System.Windows.Forms.Label()
			Me.Buttonnbrcellules = New System.Windows.Forms.Button()
			Me.Panel2 = New System.Windows.Forms.Panel()
			Me.Button9 = New System.Windows.Forms.Button()
			Me.Button8 = New System.Windows.Forms.Button()
			Me.Labelcote = New System.Windows.Forms.Label()
			Me.CustomTabControl1 = New SVPLCApplication.CustomTabControl()
			Me.TabPage1 = New System.Windows.Forms.TabPage()
			Me.TabPage2 = New System.Windows.Forms.TabPage()
			Me.TabPage3 = New System.Windows.Forms.TabPage()
			Me.MyGroupBox2 = New myGroupBox()
			Me.Buttonimporter = New System.Windows.Forms.Button()
			Me.MyGroupBox1 = New myGroupBox()
			Me.Buttonenregistrer = New System.Windows.Forms.Button()
			Me.Tableauannee = New myGroupBox()
			Me.Bordannee0 = New myGroupBox()
			Me.PictureBoxannee0 = New System.Windows.Forms.PictureBox()
			Me.Bordannee1 = New myGroupBox()
			Me.PictureBoxannee1 = New System.Windows.Forms.PictureBox()
			Me.Bordannee2 = New myGroupBox()
			Me.PictureBoxannee2 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.PictureBox4, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox5, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit()
			Me.StatusStrip1.SuspendLayout()
			Me.MenuPrinc.SuspendLayout()
			Me.Panel5.SuspendLayout()
			Me.Panel6.SuspendLayout()
			Me.Panelonglet.SuspendLayout()
			DirectCast(Me.PictureBox3, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBoxpanneau, ISupportInitialize).BeginInit()
			Me.Panel2.SuspendLayout()
			Me.CustomTabControl1.SuspendLayout()
			Me.MyGroupBox2.SuspendLayout()
			Me.MyGroupBox1.SuspendLayout()
			Me.Tableauannee.SuspendLayout()
			Me.Bordannee0.SuspendLayout()
			DirectCast(Me.PictureBoxannee0, ISupportInitialize).BeginInit()
			Me.Bordannee1.SuspendLayout()
			DirectCast(Me.PictureBoxannee1, ISupportInitialize).BeginInit()
			Me.Bordannee2.SuspendLayout()
			DirectCast(Me.PictureBoxannee2, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Panel.AutoScroll = True
			Me.Panel.BackColor = Color.Khaki
			Dim panel As System.Windows.Forms.Panel = Me.Panel
			Dim point As System.Drawing.Point = New System.Drawing.Point(13, 123)
			panel.Location = point
			Me.Panel.Name = "Panel"
			Dim panel1 As System.Windows.Forms.Panel = Me.Panel
			Dim size As System.Drawing.Size = New System.Drawing.Size(480, 480)
			panel1.Size = size
			Me.Panel.TabIndex = 1
			Me.Buttonreset.BackColor = SystemColors.ActiveCaption
			Me.Buttonreset.FlatStyle = FlatStyle.Popup
			Me.Buttonreset.Font = New System.Drawing.Font("Segoe UI", 6.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim buttonreset As System.Windows.Forms.Button = Me.Buttonreset
			point = New System.Drawing.Point(14, 618)
			buttonreset.Location = point
			Me.Buttonreset.Name = "Buttonreset"
			Dim button As System.Windows.Forms.Button = Me.Buttonreset
			size = New System.Drawing.Size(109, 24)
			button.Size = size
			Me.Buttonreset.TabIndex = 2
			Me.Buttonreset.Text = "Recommencer"
			Me.Buttonreset.UseVisualStyleBackColor = False
			Me.CheckBoxsupp.Appearance = Appearance.Button
			Me.CheckBoxsupp.BackColor = Color.IndianRed
			Me.CheckBoxsupp.FlatAppearance.BorderColor = Color.DarkRed
			Me.CheckBoxsupp.FlatStyle = FlatStyle.Flat
			Me.CheckBoxsupp.Font = New System.Drawing.Font("Segoe UI", 6.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim checkBoxsupp As System.Windows.Forms.CheckBox = Me.CheckBoxsupp
			point = New System.Drawing.Point(129, 618)
			checkBoxsupp.Location = point
			Me.CheckBoxsupp.Name = "CheckBoxsupp"
			Dim checkBox As System.Windows.Forms.CheckBox = Me.CheckBoxsupp
			size = New System.Drawing.Size(104, 24)
			checkBox.Size = size
			Me.CheckBoxsupp.TabIndex = 3
			Me.CheckBoxsupp.Text = "Supprimer"
			Me.CheckBoxsupp.TextAlign = ContentAlignment.MiddleCenter
			Me.CheckBoxsupp.UseVisualStyleBackColor = False
			Me.Panel1.AutoScroll = True
			Dim panel11 As System.Windows.Forms.Panel = Me.Panel1
			point = New System.Drawing.Point(966, 175)
			panel11.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel12 As System.Windows.Forms.Panel = Me.Panel1
			size = New System.Drawing.Size(369, 369)
			panel12.Size = size
			Me.Panel1.TabIndex = 4
			Me.ImageList1.ColorDepth = ColorDepth.Depth32Bit
			Dim imageList1 As ImageList = Me.ImageList1
			size = New System.Drawing.Size(60, 60)
			imageList1.ImageSize = size
			Me.ImageList1.TransparentColor = Color.Transparent
			Me.BackgroundWorker1.WorkerSupportsCancellation = True
			Me.Buttonchangementimg.BackColor = SystemColors.Control
			Me.Buttonchangementimg.BackgroundImage = Resources.photo
			Me.Buttonchangementimg.BackgroundImageLayout = ImageLayout.Stretch
			Me.Buttonchangementimg.FlatAppearance.BorderSize = 2
			Dim buttonchangementimg As System.Windows.Forms.Button = Me.Buttonchangementimg
			point = New System.Drawing.Point(530, 610)
			buttonchangementimg.Location = point
			Me.Buttonchangementimg.Name = "Buttonchangementimg"
			Dim buttonchangementimg1 As System.Windows.Forms.Button = Me.Buttonchangementimg
			size = New System.Drawing.Size(25, 23)
			buttonchangementimg1.Size = size
			Me.Buttonchangementimg.TabIndex = 8
			Me.Buttonchangementimg.UseVisualStyleBackColor = False
			Me.OpenFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
			Me.ImageList2.ColorDepth = ColorDepth.Depth32Bit
			Dim imageList2 As ImageList = Me.ImageList2
			size = New System.Drawing.Size(30, 30)
			imageList2.ImageSize = size
			Me.ImageList2.TransparentColor = Color.Transparent
			Me.PictureBox4.BackgroundImage = Resources.flechepenchee
			Me.PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox4 As System.Windows.Forms.PictureBox = Me.PictureBox4
			point = New System.Drawing.Point(293, 653)
			pictureBox4.Location = point
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox4
			size = New System.Drawing.Size(79, 74)
			pictureBox.Size = size
			Me.PictureBox4.TabIndex = 19
			Me.PictureBox4.TabStop = False
			Me.PictureBox5.BackgroundImage = Resources.fleched
			Me.PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox5 As System.Windows.Forms.PictureBox = Me.PictureBox5
			point = New System.Drawing.Point(1223, 677)
			pictureBox5.Location = point
			Me.PictureBox5.Name = "PictureBox5"
			Dim pictureBox51 As System.Windows.Forms.PictureBox = Me.PictureBox5
			size = New System.Drawing.Size(65, 50)
			pictureBox51.Size = size
			Me.PictureBox5.TabIndex = 20
			Me.PictureBox5.TabStop = False
			Me.Buttonsauvegarder.BackColor = Color.Goldenrod
			Me.Buttonsauvegarder.FlatAppearance.BorderColor = Color.Yellow
			Me.Buttonsauvegarder.FlatStyle = FlatStyle.Flat
			Me.Buttonsauvegarder.Font = New System.Drawing.Font("Segoe UI", 6.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim buttonsauvegarder As System.Windows.Forms.Button = Me.Buttonsauvegarder
			point = New System.Drawing.Point(239, 618)
			buttonsauvegarder.Location = point
			Me.Buttonsauvegarder.Name = "Buttonsauvegarder"
			Dim buttonsauvegarder1 As System.Windows.Forms.Button = Me.Buttonsauvegarder
			size = New System.Drawing.Size(109, 24)
			buttonsauvegarder1.Size = size
			Me.Buttonsauvegarder.TabIndex = 21
			Me.Buttonsauvegarder.Text = "Sauvegarder"
			Me.Buttonsauvegarder.UseVisualStyleBackColor = False
			Me.SaveFileDialog1.Filter = "Fichier svplc(*.svplc)|*.svplc"
			Me.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
			Me.PictureBox1.Image = Resources.flecheg
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(1057, 774)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox11 As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(71, 50)
			pictureBox11.Size = size
			Me.PictureBox1.TabIndex = 23
			Me.PictureBox1.TabStop = False
			Me.OpenFileDialog2.Filter = "Fichier svplc (*.svplc) | *.svplc"
			Me.PictureBox2.BackgroundImage = Resources.papillon
			Me.PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox2
			point = New System.Drawing.Point(24, 670)
			pictureBox2.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox21 As System.Windows.Forms.PictureBox = Me.PictureBox2
			size = New System.Drawing.Size(236, 228)
			pictureBox21.Size = size
			Me.PictureBox2.TabIndex = 38
			Me.PictureBox2.TabStop = False
			Me.ImageList3.ColorDepth = ColorDepth.Depth32Bit
			Dim imageList3 As ImageList = Me.ImageList3
			size = New System.Drawing.Size(60, 60)
			imageList3.ImageSize = size
			Me.ImageList3.TransparentColor = Color.Transparent
			Me.ImageList4.ColorDepth = ColorDepth.Depth32Bit
			Dim imageList4 As ImageList = Me.ImageList4
			size = New System.Drawing.Size(30, 30)
			imageList4.ImageSize = size
			Me.ImageList4.TransparentColor = Color.Transparent
			Me.ImageList5.ColorDepth = ColorDepth.Depth32Bit
			Dim imageList5 As ImageList = Me.ImageList5
			size = New System.Drawing.Size(60, 60)
			imageList5.ImageSize = size
			Me.ImageList5.TransparentColor = Color.Transparent
			Me.ImageList6.ColorDepth = ColorDepth.Depth32Bit
			Dim imageList6 As ImageList = Me.ImageList6
			size = New System.Drawing.Size(30, 30)
			imageList6.ImageSize = size
			Me.ImageList6.TransparentColor = Color.Transparent
			Me.Buttonajouter.BackgroundImage = Resources.ajadd
			Me.Buttonajouter.BackgroundImageLayout = ImageLayout.Stretch
			Dim buttonajouter As System.Windows.Forms.Button = Me.Buttonajouter
			point = New System.Drawing.Point(561, 610)
			buttonajouter.Location = point
			Me.Buttonajouter.Name = "Buttonajouter"
			Dim buttonajouter1 As System.Windows.Forms.Button = Me.Buttonajouter
			size = New System.Drawing.Size(24, 23)
			buttonajouter1.Size = size
			Me.Buttonajouter.TabIndex = 39
			Me.Buttonajouter.UseVisualStyleBackColor = True
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Color.Transparent
			Me.Label2.Font = New System.Drawing.Font("Cooper Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Color.Chocolate
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(148, 16)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(132, 21)
			label.Size = size
			Me.Label2.TabIndex = 7
			Me.Label2.Text = "Associations"
			Me.Assopos.AutoSize = True
			Me.Assopos.BackColor = Color.Transparent
			Me.Assopos.Font = New System.Drawing.Font("Wide Latin", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Assopos.ForeColor = Color.ForestGreen
			Dim assopos As System.Windows.Forms.Label = Me.Assopos
			point = New System.Drawing.Point(80, 36)
			assopos.Location = point
			Me.Assopos.Name = "Assopos"
			Dim assopos1 As System.Windows.Forms.Label = Me.Assopos
			size = New System.Drawing.Size(27, 18)
			assopos1.Size = size
			Me.Assopos.TabIndex = 28
			Me.Assopos.Text = "0"
			Me.Assoneg.AutoSize = True
			Me.Assoneg.BackColor = Color.Transparent
			Me.Assoneg.Font = New System.Drawing.Font("Wide Latin", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Assoneg.ForeColor = Color.Firebrick
			Dim assoneg As System.Windows.Forms.Label = Me.Assoneg
			point = New System.Drawing.Point(321, 34)
			assoneg.Location = point
			Me.Assoneg.Name = "Assoneg"
			Dim assoneg1 As System.Windows.Forms.Label = Me.Assoneg
			size = New System.Drawing.Size(27, 18)
			assoneg1.Size = size
			Me.Assoneg.TabIndex = 29
			Me.Assoneg.Text = "0"
			Me.Assoechelle.AutoSize = True
			Me.Assoechelle.BackColor = Color.Transparent
			Me.Assoechelle.Font = New System.Drawing.Font("Wide Latin", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Assoechelle.ForeColor = Color.DarkGoldenrod
			Dim assoechelle As System.Windows.Forms.Label = Me.Assoechelle
			point = New System.Drawing.Point(248, 50)
			assoechelle.Location = point
			Me.Assoechelle.Name = "Assoechelle"
			Dim assoechelle1 As System.Windows.Forms.Label = Me.Assoechelle
			size = New System.Drawing.Size(21, 14)
			assoechelle1.Size = size
			Me.Assoechelle.TabIndex = 30
			Me.Assoechelle.Text = "0"
			Me.Label7.AutoSize = True
			Me.Label7.BackColor = Color.Transparent
			Me.Label7.Font = New System.Drawing.Font("Wide Latin", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label7.ForeColor = Color.DarkGoldenrod
			Dim label7 As System.Windows.Forms.Label = Me.Label7
			point = New System.Drawing.Point(161, 50)
			label7.Location = point
			Me.Label7.Name = "Label7"
			Dim label71 As System.Windows.Forms.Label = Me.Label7
			size = New System.Drawing.Size(81, 14)
			label71.Size = size
			Me.Label7.TabIndex = 31
			Me.Label7.Text = "Echelle:"
			Me.Rotneg.AutoSize = True
			Me.Rotneg.BackColor = Color.Transparent
			Me.Rotneg.Font = New System.Drawing.Font("Wide Latin", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Rotneg.ForeColor = Color.DarkRed
			Dim rotneg As System.Windows.Forms.Label = Me.Rotneg
			point = New System.Drawing.Point(233, 65)
			rotneg.Location = point
			Me.Rotneg.Name = "Rotneg"
			Dim rotneg1 As System.Windows.Forms.Label = Me.Rotneg
			size = New System.Drawing.Size(27, 18)
			rotneg1.Size = size
			Me.Rotneg.TabIndex = 32
			Me.Rotneg.Text = "0"
			Me.Rotechelle.AutoSize = True
			Me.Rotechelle.BackColor = Color.Transparent
			Me.Rotechelle.Font = New System.Drawing.Font("Wide Latin", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Rotechelle.ForeColor = Color.DarkGoldenrod
			Dim rotechelle As System.Windows.Forms.Label = Me.Rotechelle
			point = New System.Drawing.Point(170, 84)
			rotechelle.Location = point
			Me.Rotechelle.Name = "Rotechelle"
			Dim rotechelle1 As System.Windows.Forms.Label = Me.Rotechelle
			size = New System.Drawing.Size(21, 14)
			rotechelle1.Size = size
			Me.Rotechelle.TabIndex = 35
			Me.Rotechelle.Text = "0"
			Me.Rotpos.AutoSize = True
			Me.Rotpos.BackColor = Color.Transparent
			Me.Rotpos.Font = New System.Drawing.Font("Wide Latin", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Rotpos.ForeColor = Color.DarkGreen
			Dim rotpos As System.Windows.Forms.Label = Me.Rotpos
			point = New System.Drawing.Point(106, 65)
			rotpos.Location = point
			Me.Rotpos.Name = "Rotpos"
			Dim rotpos1 As System.Windows.Forms.Label = Me.Rotpos
			size = New System.Drawing.Size(27, 18)
			rotpos1.Size = size
			Me.Rotpos.TabIndex = 33
			Me.Rotpos.Text = "0"
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Color.Transparent
			Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.SaddleBrown
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(132, 36)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label11 As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(105, 21)
			label11.Size = size
			Me.Label1.TabIndex = 6
			Me.Label1.Text = "Rotations"
			Me.StatusStrip1.BackColor = Color.DarkKhaki
			Dim items As ToolStripItemCollection = Me.StatusStrip1.Items
			Dim toolStripStatusLabel1() As ToolStripItem = { Me.ToolStripStatusLabel1 }
			items.AddRange(toolStripStatusLabel1)
			Dim statusStrip1 As System.Windows.Forms.StatusStrip = Me.StatusStrip1
			point = New System.Drawing.Point(0, 902)
			statusStrip1.Location = point
			Me.StatusStrip1.Name = "StatusStrip1"
			Dim statusStrip As System.Windows.Forms.StatusStrip = Me.StatusStrip1
			size = New System.Drawing.Size(1387, 22)
			statusStrip.Size = size
			Me.StatusStrip1.TabIndex = 40
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.ToolStripStatusLabel1.BackColor = Color.DarkKhaki
			Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
			Dim toolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel = Me.ToolStripStatusLabel1
			size = New System.Drawing.Size(1030, 17)
			toolStripStatusLabel.Size = size
			Me.ToolStripStatusLabel1.Text = "Sélectionnez une année dans la boîte en dessous des grilles en cliquant dessus, dessinez votre jardin sur la grille de gauche et sauvegardez sa configuration en cliquant sur ""Sauvegarder"""
			Me.Button1.BackgroundImage = Resources.fiche
			Me.Button1.BackgroundImageLayout = ImageLayout.Stretch
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(591, 610)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button11 As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(24, 23)
			button11.Size = size
			Me.Button1.TabIndex = 41
			Me.Button1.UseVisualStyleBackColor = True
			Me.MenuPrinc.BackColor = Color.FromArgb(255, 128, 0)
			Dim toolStripItemCollections As ToolStripItemCollection = Me.MenuPrinc.Items
			toolStripStatusLabel1 = New ToolStripItem() { Me.FichierMenu, Me.BasededonneesMenu, Me.OutilsToolStripMenuItem, Me.HelpMenu }
			toolStripItemCollections.AddRange(toolStripStatusLabel1)
			Me.MenuPrinc.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
			Dim menuPrinc As System.Windows.Forms.MenuStrip = Me.MenuPrinc
			point = New System.Drawing.Point(0, 0)
			menuPrinc.Location = point
			Me.MenuPrinc.Name = "MenuPrinc"
			Dim menuStrip As System.Windows.Forms.MenuStrip = Me.MenuPrinc
			size = New System.Drawing.Size(1387, 24)
			menuStrip.Size = size
			Me.MenuPrinc.TabIndex = 42
			Me.MenuPrinc.Text = "MenuStrip1"
			Me.FichierMenu.CheckOnClick = True
			Dim dropDownItems As ToolStripItemCollection = Me.FichierMenu.DropDownItems
			toolStripStatusLabel1 = New ToolStripItem() { Me.ImprimerMenu, Me.CacherLaBarreDeTâcheToolStripMenuItem, Me.QuitterMenu }
			dropDownItems.AddRange(toolStripStatusLabel1)
			Me.FichierMenu.ForeColor = Color.Black
			Me.FichierMenu.Name = "FichierMenu"
			Dim fichierMenu As ToolStripMenuItem = Me.FichierMenu
			size = New System.Drawing.Size(54, 20)
			fichierMenu.Size = size
			Me.FichierMenu.Text = "&Fichier"
			Me.ImprimerMenu.Image = Resources.print1
			Me.ImprimerMenu.Name = "ImprimerMenu"
			Dim imprimerMenu As ToolStripMenuItem = Me.ImprimerMenu
			size = New System.Drawing.Size(201, 22)
			imprimerMenu.Size = size
			Me.ImprimerMenu.Text = "Impression express"
			Me.CacherLaBarreDeTâcheToolStripMenuItem.Name = "CacherLaBarreDeTâcheToolStripMenuItem"
			Dim cacherLaBarreDeTâcheToolStripMenuItem As ToolStripMenuItem = Me.CacherLaBarreDeTâcheToolStripMenuItem
			size = New System.Drawing.Size(201, 22)
			cacherLaBarreDeTâcheToolStripMenuItem.Size = size
			Me.CacherLaBarreDeTâcheToolStripMenuItem.Text = "Cacher la barre de tâche"
			Me.QuitterMenu.Image = Resources.cancel1
			Me.QuitterMenu.Name = "QuitterMenu"
			Dim quitterMenu As ToolStripMenuItem = Me.QuitterMenu
			size = New System.Drawing.Size(201, 22)
			quitterMenu.Size = size
			Me.QuitterMenu.Text = "Quitter"
			Dim dropDownItems1 As ToolStripItemCollection = Me.BasededonneesMenu.DropDownItems
			toolStripStatusLabel1 = New ToolStripItem() { Me.BDDAssociationsMenu, Me.BDDRotationsMenu, Me.BDDCalendrierMenu, Me.ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem, Me.AjouterUnNouveauLégumeToolStripMenuItem, Me.RenommerUnLégumeExistantToolStripMenuItem, Me.SupprimerUnLégumeToolStripMenuItem }
			dropDownItems1.AddRange(toolStripStatusLabel1)
			Me.BasededonneesMenu.ForeColor = Color.Black
			Me.BasededonneesMenu.Name = "BasededonneesMenu"
			Dim basededonneesMenu As ToolStripMenuItem = Me.BasededonneesMenu
			size = New System.Drawing.Size(107, 20)
			basededonneesMenu.Size = size
			Me.BasededonneesMenu.Text = "Base de données"
			Me.BDDAssociationsMenu.Image = Resources.book2
			Me.BDDAssociationsMenu.Name = "BDDAssociationsMenu"
			Dim bDDAssociationsMenu As ToolStripMenuItem = Me.BDDAssociationsMenu
			size = New System.Drawing.Size(338, 22)
			bDDAssociationsMenu.Size = size
			Me.BDDAssociationsMenu.Text = "Consulter et gérer la base de données associations"
			Me.BDDRotationsMenu.Image = Resources.book2
			Me.BDDRotationsMenu.Name = "BDDRotationsMenu"
			Dim bDDRotationsMenu As ToolStripMenuItem = Me.BDDRotationsMenu
			size = New System.Drawing.Size(338, 22)
			bDDRotationsMenu.Size = size
			Me.BDDRotationsMenu.Text = "Consulter et gérer la base de données rotations"
			Me.BDDCalendrierMenu.Image = Resources.calendrier
			Me.BDDCalendrierMenu.Name = "BDDCalendrierMenu"
			Dim bDDCalendrierMenu As ToolStripMenuItem = Me.BDDCalendrierMenu
			size = New System.Drawing.Size(338, 22)
			bDDCalendrierMenu.Size = size
			Me.BDDCalendrierMenu.Text = "Consulter et gérer la base de données calendrier"
			Me.ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem.Image = Resources.fiche
			Me.ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem.Name = "ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem"
			Dim consulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem As ToolStripMenuItem = Me.ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem
			size = New System.Drawing.Size(338, 22)
			consulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem.Size = size
			Me.ConsulterEtGérerLaBaseDeDonnéesFichesLégumesToolStripMenuItem.Text = "Consulter et gérer la base de données fiches"
			Me.AjouterUnNouveauLégumeToolStripMenuItem.Image = Resources.ajadd
			Me.AjouterUnNouveauLégumeToolStripMenuItem.Name = "AjouterUnNouveauLégumeToolStripMenuItem"
			Dim ajouterUnNouveauLégumeToolStripMenuItem As ToolStripMenuItem = Me.AjouterUnNouveauLégumeToolStripMenuItem
			size = New System.Drawing.Size(338, 22)
			ajouterUnNouveauLégumeToolStripMenuItem.Size = size
			Me.AjouterUnNouveauLégumeToolStripMenuItem.Text = "Ajouter une nouvelle plante aux BDD..."
			Me.RenommerUnLégumeExistantToolStripMenuItem.Image = Resources.modify
			Me.RenommerUnLégumeExistantToolStripMenuItem.Name = "RenommerUnLégumeExistantToolStripMenuItem"
			Dim renommerUnLégumeExistantToolStripMenuItem As ToolStripMenuItem = Me.RenommerUnLégumeExistantToolStripMenuItem
			size = New System.Drawing.Size(338, 22)
			renommerUnLégumeExistantToolStripMenuItem.Size = size
			Me.RenommerUnLégumeExistantToolStripMenuItem.Text = "Renommer une plante existante..."
			Me.SupprimerUnLégumeToolStripMenuItem.Image = Resources.suppdel
			Me.SupprimerUnLégumeToolStripMenuItem.Name = "SupprimerUnLégumeToolStripMenuItem"
			Dim supprimerUnLégumeToolStripMenuItem As ToolStripMenuItem = Me.SupprimerUnLégumeToolStripMenuItem
			size = New System.Drawing.Size(338, 22)
			supprimerUnLégumeToolStripMenuItem.Size = size
			Me.SupprimerUnLégumeToolStripMenuItem.Text = "Supprimer une plante des BDD..."
			Dim toolStripItemCollections1 As ToolStripItemCollection = Me.OutilsToolStripMenuItem.DropDownItems
			toolStripStatusLabel1 = New ToolStripItem() { Me.MonJardinMenu, Me.CalculatriceToolStripMenuItem, Me.CalendrierLunaireToolStripMenuItem, Me.BibliothèqueMenu }
			toolStripItemCollections1.AddRange(toolStripStatusLabel1)
			Me.OutilsToolStripMenuItem.ForeColor = Color.Black
			Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
			Dim outilsToolStripMenuItem As ToolStripMenuItem = Me.OutilsToolStripMenuItem
			size = New System.Drawing.Size(50, 20)
			outilsToolStripMenuItem.Size = size
			Me.OutilsToolStripMenuItem.Text = "Outils"
			Me.MonJardinMenu.Image = Resources.garden1
			Me.MonJardinMenu.Name = "MonJardinMenu"
			Dim monJardinMenu As ToolStripMenuItem = Me.MonJardinMenu
			size = New System.Drawing.Size(186, 22)
			monJardinMenu.Size = size
			Me.MonJardinMenu.Text = "Mon jardin"
			Me.CalculatriceToolStripMenuItem.Image = Resources.Boulier
			Me.CalculatriceToolStripMenuItem.Name = "CalculatriceToolStripMenuItem"
			Dim calculatriceToolStripMenuItem As ToolStripMenuItem = Me.CalculatriceToolStripMenuItem
			size = New System.Drawing.Size(186, 22)
			calculatriceToolStripMenuItem.Size = size
			Me.CalculatriceToolStripMenuItem.Text = "Calculatrice avancée"
			Me.CalendrierLunaireToolStripMenuItem.Image = Resources.Moon1
			Me.CalendrierLunaireToolStripMenuItem.Name = "CalendrierLunaireToolStripMenuItem"
			Dim calendrierLunaireToolStripMenuItem As ToolStripMenuItem = Me.CalendrierLunaireToolStripMenuItem
			size = New System.Drawing.Size(186, 22)
			calendrierLunaireToolStripMenuItem.Size = size
			Me.CalendrierLunaireToolStripMenuItem.Text = "Calendrier lunaire"
			Me.BibliothèqueMenu.Image = Resources.biblio1
			Me.BibliothèqueMenu.Name = "BibliothèqueMenu"
			Dim bibliothèqueMenu As ToolStripMenuItem = Me.BibliothèqueMenu
			size = New System.Drawing.Size(186, 22)
			bibliothèqueMenu.Size = size
			Me.BibliothèqueMenu.Text = "&Bibliothèque en ligne"
			Dim dropDownItems2 As ToolStripItemCollection = Me.HelpMenu.DropDownItems
			toolStripStatusLabel1 = New ToolStripItem() { Me.AProposDeMenu, Me.AboutMenu, Me.FaireUnDonToolStripMenuItem }
			dropDownItems2.AddRange(toolStripStatusLabel1)
			Me.HelpMenu.ForeColor = Color.Black
			Me.HelpMenu.Name = "HelpMenu"
			Dim helpMenu As ToolStripMenuItem = Me.HelpMenu
			size = New System.Drawing.Size(24, 20)
			helpMenu.Size = size
			Me.HelpMenu.Text = "?"
			Me.AProposDeMenu.Image = Resources.aide2
			Me.AProposDeMenu.Name = "AProposDeMenu"
			Dim aProposDeMenu As ToolStripMenuItem = Me.AProposDeMenu
			size = New System.Drawing.Size(147, 22)
			aProposDeMenu.Size = size
			Me.AProposDeMenu.Text = "&Aide"
			Me.AboutMenu.Image = Resources.informpng
			Me.AboutMenu.Name = "AboutMenu"
			Dim aboutMenu As ToolStripMenuItem = Me.AboutMenu
			size = New System.Drawing.Size(147, 22)
			aboutMenu.Size = size
			Me.AboutMenu.Text = "A propos de..."
			Me.FaireUnDonToolStripMenuItem.Image = DirectCast(componentResourceManager.GetObject("FaireUnDonToolStripMenuItem.Image"), Image)
			Me.FaireUnDonToolStripMenuItem.Name = "FaireUnDonToolStripMenuItem"
			Dim faireUnDonToolStripMenuItem As ToolStripMenuItem = Me.FaireUnDonToolStripMenuItem
			size = New System.Drawing.Size(147, 22)
			faireUnDonToolStripMenuItem.Size = size
			Me.FaireUnDonToolStripMenuItem.Text = "Faire un don"
			Me.Panel5.BackgroundImage = Resources.Cadre_bois1
			Me.Panel5.BackgroundImageLayout = ImageLayout.Stretch
			Me.Panel5.Controls.Add(Me.Label2)
			Me.Panel5.Controls.Add(Me.Assoneg)
			Me.Panel5.Controls.Add(Me.Label7)
			Me.Panel5.Controls.Add(Me.Assoechelle)
			Me.Panel5.Controls.Add(Me.Assopos)
			Dim panel5 As System.Windows.Forms.Panel = Me.Panel5
			point = New System.Drawing.Point(57, 28)
			panel5.Location = point
			Me.Panel5.Name = "Panel5"
			Dim panel51 As System.Windows.Forms.Panel = Me.Panel5
			size = New System.Drawing.Size(412, 90)
			panel51.Size = size
			Me.Panel5.TabIndex = 0
			Me.Panel6.BackgroundImage = Resources.Cadre_bois2
			Me.Panel6.BackgroundImageLayout = ImageLayout.Stretch
			Me.Panel6.Controls.Add(Me.Label1)
			Me.Panel6.Controls.Add(Me.Rotneg)
			Me.Panel6.Controls.Add(Me.Rotechelle)
			Me.Panel6.Controls.Add(Me.Rotpos)
			Dim panel6 As System.Windows.Forms.Panel = Me.Panel6
			point = New System.Drawing.Point(964, 27)
			panel6.Location = point
			Me.Panel6.Name = "Panel6"
			Dim panel61 As System.Windows.Forms.Panel = Me.Panel6
			size = New System.Drawing.Size(371, 141)
			panel61.Size = size
			Me.Panel6.TabIndex = 0
			Me.Panelonglet.BackgroundImage = Resources.Tiroir_transp
			Me.Panelonglet.BackgroundImageLayout = ImageLayout.Stretch
			Me.Panelonglet.Controls.Add(Me.PictureBox3)
			Me.Panelonglet.Controls.Add(Me.Button7)
			Me.Panelonglet.Controls.Add(Me.Button6)
			Me.Panelonglet.Controls.Add(Me.Button5)
			Me.Panelonglet.Controls.Add(Me.Button4)
			Me.Panelonglet.Controls.Add(Me.Button3)
			Me.Panelonglet.Controls.Add(Me.Button2)
			Dim panelonglet As System.Windows.Forms.Panel = Me.Panelonglet
			point = New System.Drawing.Point(6, 136)
			panelonglet.Location = point
			Me.Panelonglet.Name = "Panelonglet"
			Dim panelonglet1 As System.Windows.Forms.Panel = Me.Panelonglet
			size = New System.Drawing.Size(125, 440)
			panelonglet1.Size = size
			Me.Panelonglet.TabIndex = 0
			Me.PictureBox3.BackColor = Color.Transparent
			Me.PictureBox3.BackgroundImage = Resources.Icone_svplc
			Me.PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox3 As System.Windows.Forms.PictureBox = Me.PictureBox3
			point = New System.Drawing.Point(27, 378)
			pictureBox3.Location = point
			Me.PictureBox3.Name = "PictureBox3"
			Dim pictureBox31 As System.Windows.Forms.PictureBox = Me.PictureBox3
			size = New System.Drawing.Size(45, 45)
			pictureBox31.Size = size
			Me.PictureBox3.TabIndex = 6
			Me.PictureBox3.TabStop = False
			Me.Button7.BackColor = Color.Tan
			Me.Button7.BackgroundImage = Resources.Booklibrary
			Me.Button7.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button7.Cursor = Cursors.Hand
			Dim button7 As System.Windows.Forms.Button = Me.Button7
			point = New System.Drawing.Point(24, 317)
			button7.Location = point
			Me.Button7.Name = "Button7"
			Dim button71 As System.Windows.Forms.Button = Me.Button7
			size = New System.Drawing.Size(55, 55)
			button71.Size = size
			Me.Button7.TabIndex = 0
			Me.Button7.UseVisualStyleBackColor = False
			Me.Button6.BackColor = Color.CadetBlue
			Me.Button6.BackgroundImage = Resources.photo
			Me.Button6.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button6.Cursor = Cursors.Hand
			Dim button6 As System.Windows.Forms.Button = Me.Button6
			point = New System.Drawing.Point(24, 256)
			button6.Location = point
			Me.Button6.Name = "Button6"
			Dim button61 As System.Windows.Forms.Button = Me.Button6
			size = New System.Drawing.Size(55, 55)
			button61.Size = size
			Me.Button6.TabIndex = 0
			Me.Button6.UseVisualStyleBackColor = False
			Me.Button5.BackColor = Color.Goldenrod
			Me.Button5.BackgroundImage = Resources.moneybag
			Me.Button5.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button5.Cursor = Cursors.Hand
			Dim button5 As System.Windows.Forms.Button = Me.Button5
			point = New System.Drawing.Point(24, 195)
			button5.Location = point
			Me.Button5.Name = "Button5"
			Dim button51 As System.Windows.Forms.Button = Me.Button5
			size = New System.Drawing.Size(55, 55)
			button51.Size = size
			Me.Button5.TabIndex = 0
			Me.Button5.UseVisualStyleBackColor = False
			Me.Button4.BackColor = Color.Olive
			Me.Button4.BackgroundImage = Resources.draw
			Me.Button4.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button4.Cursor = Cursors.Hand
			Dim button4 As System.Windows.Forms.Button = Me.Button4
			point = New System.Drawing.Point(24, 134)
			button4.Location = point
			Me.Button4.Name = "Button4"
			Dim button41 As System.Windows.Forms.Button = Me.Button4
			size = New System.Drawing.Size(55, 55)
			button41.Size = size
			Me.Button4.TabIndex = 0
			Me.Button4.UseVisualStyleBackColor = False
			Me.Button3.BackColor = Color.DarkKhaki
			Me.Button3.BackgroundImage = Resources.Moonmouse
			Me.Button3.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button3.Cursor = Cursors.Hand
			Dim button3 As System.Windows.Forms.Button = Me.Button3
			point = New System.Drawing.Point(24, 73)
			button3.Location = point
			Me.Button3.Name = "Button3"
			Dim button31 As System.Windows.Forms.Button = Me.Button3
			size = New System.Drawing.Size(55, 55)
			button31.Size = size
			Me.Button3.TabIndex = 0
			Me.Button3.UseVisualStyleBackColor = False
			Me.Button2.BackColor = Color.Khaki
			Me.Button2.BackgroundImage = Resources.adddel
			Me.Button2.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button2.Cursor = Cursors.Hand
			Me.Button2.FlatAppearance.BorderColor = Color.White
			Dim button2 As System.Windows.Forms.Button = Me.Button2
			point = New System.Drawing.Point(24, 12)
			button2.Location = point
			Me.Button2.Name = "Button2"
			Dim button21 As System.Windows.Forms.Button = Me.Button2
			size = New System.Drawing.Size(55, 55)
			button21.Size = size
			Me.Button2.TabIndex = 0
			Me.Button2.UseVisualStyleBackColor = False
			Me.ImageList7.ColorDepth = ColorDepth.Depth32Bit
			Dim imageList7 As ImageList = Me.ImageList7
			size = New System.Drawing.Size(30, 30)
			imageList7.ImageSize = size
			Me.ImageList7.TransparentColor = Color.Transparent
			Me.Label5.AutoSize = True
			Me.Label5.Font = New System.Drawing.Font("Wide Latin", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label5 As System.Windows.Forms.Label = Me.Label5
			point = New System.Drawing.Point(421, 15)
			label5.Location = point
			Me.Label5.Name = "Label5"
			Dim label51 As System.Windows.Forms.Label = Me.Label5
			size = New System.Drawing.Size(97, 15)
			label51.Size = size
			Me.Label5.TabIndex = 5
			Me.Label5.Text = "Année +2"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New System.Drawing.Font("Wide Latin", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(242, 15)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(94, 15)
			label41.Size = size
			Me.Label4.TabIndex = 4
			Me.Label4.Text = "Année +1"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New System.Drawing.Font("Wide Latin", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(64, 16)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(92, 15)
			label31.Size = size
			Me.Label3.TabIndex = 3
			Me.Label3.Text = "Année 0"
			Me.Timerinstallmsg.Interval = 5000
			Me.PictureBoxpanneau.BackgroundImage = Resources.Pancarte
			Me.PictureBoxpanneau.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBoxpanneau As System.Windows.Forms.PictureBox = Me.PictureBoxpanneau
			point = New System.Drawing.Point(953, 565)
			pictureBoxpanneau.Location = point
			Me.PictureBoxpanneau.Name = "PictureBoxpanneau"
			Dim pictureBoxpanneau1 As System.Windows.Forms.PictureBox = Me.PictureBoxpanneau
			size = New System.Drawing.Size(147, 189)
			pictureBoxpanneau1.Size = size
			Me.PictureBoxpanneau.TabIndex = 44
			Me.PictureBoxpanneau.TabStop = False
			Me.Label6.AutoSize = True
			Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label6 As System.Windows.Forms.Label = Me.Label6
			point = New System.Drawing.Point(515, 867)
			label6.Location = point
			Me.Label6.Name = "Label6"
			Dim label61 As System.Windows.Forms.Label = Me.Label6
			size = New System.Drawing.Size(140, 19)
			label61.Size = size
			Me.Label6.TabIndex = 45
			Me.Label6.Text = "Coté de la grille:"
			Me.Buttonnbrcellules.BackColor = SystemColors.HotTrack
			Me.Buttonnbrcellules.FlatAppearance.BorderSize = 2
			Me.Buttonnbrcellules.FlatStyle = FlatStyle.Flat
			Me.Buttonnbrcellules.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim buttonnbrcellules As System.Windows.Forms.Button = Me.Buttonnbrcellules
			point = New System.Drawing.Point(734, 863)
			buttonnbrcellules.Location = point
			Me.Buttonnbrcellules.Name = "Buttonnbrcellules"
			Dim buttonnbrcellules1 As System.Windows.Forms.Button = Me.Buttonnbrcellules
			size = New System.Drawing.Size(47, 29)
			buttonnbrcellules1.Size = size
			Me.Buttonnbrcellules.TabIndex = 47
			Me.Buttonnbrcellules.Text = "Ok"
			Me.Buttonnbrcellules.UseVisualStyleBackColor = False
			Me.Panel2.BorderStyle = BorderStyle.FixedSingle
			Me.Panel2.Controls.Add(Me.Button9)
			Me.Panel2.Controls.Add(Me.Button8)
			Me.Panel2.Controls.Add(Me.Labelcote)
			Dim panel2 As System.Windows.Forms.Panel = Me.Panel2
			point = New System.Drawing.Point(665, 861)
			panel2.Location = point
			Me.Panel2.Name = "Panel2"
			Dim panel21 As System.Windows.Forms.Panel = Me.Panel2
			size = New System.Drawing.Size(62, 34)
			panel21.Size = size
			Me.Panel2.TabIndex = 48
			Me.Button9.BackColor = SystemColors.GrayText
			Me.Button9.BackgroundImage = Resources.flb
			Me.Button9.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button9.FlatAppearance.BorderSize = 0
			Me.Button9.FlatStyle = FlatStyle.Flat
			Me.Button9.Font = New System.Drawing.Font("Mistral", 6!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Button9.ForeColor = SystemColors.ControlLightLight
			Dim button9 As System.Windows.Forms.Button = Me.Button9
			point = New System.Drawing.Point(42, 16)
			button9.Location = point
			Dim button91 As System.Windows.Forms.Button = Me.Button9
			Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(0)
			button91.Margin = padding
			Me.Button9.Name = "Button9"
			Dim button92 As System.Windows.Forms.Button = Me.Button9
			size = New System.Drawing.Size(18, 16)
			button92.Size = size
			Me.Button9.TabIndex = 49
			Me.Button9.UseVisualStyleBackColor = False
			Me.Button8.BackColor = SystemColors.GrayText
			Me.Button8.BackgroundImage = Resources.flh
			Me.Button8.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button8.FlatAppearance.BorderSize = 0
			Me.Button8.FlatStyle = FlatStyle.Flat
			Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Button8.ForeColor = SystemColors.Control
			Dim button8 As System.Windows.Forms.Button = Me.Button8
			point = New System.Drawing.Point(42, 0)
			button8.Location = point
			Dim button81 As System.Windows.Forms.Button = Me.Button8
			padding = New System.Windows.Forms.Padding(0)
			button81.Margin = padding
			Me.Button8.Name = "Button8"
			Dim button82 As System.Windows.Forms.Button = Me.Button8
			size = New System.Drawing.Size(18, 16)
			button82.Size = size
			Me.Button8.TabIndex = 1
			Me.Button8.TextAlign = ContentAlignment.TopCenter
			Me.Button8.UseVisualStyleBackColor = False
			Me.Labelcote.BackColor = SystemColors.HotTrack
			Me.Labelcote.Dock = DockStyle.Left
			Me.Labelcote.Font = New System.Drawing.Font("Cooper Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim labelcote As System.Windows.Forms.Label = Me.Labelcote
			point = New System.Drawing.Point(0, 0)
			labelcote.Location = point
			Me.Labelcote.Name = "Labelcote"
			Dim labelcote1 As System.Windows.Forms.Label = Me.Labelcote
			size = New System.Drawing.Size(43, 32)
			labelcote1.Size = size
			Me.Labelcote.TabIndex = 0
			Me.Labelcote.Text = "16"
			Me.Labelcote.TextAlign = ContentAlignment.MiddleCenter
			Me.CustomTabControl1.Controls.Add(Me.TabPage1)
			Me.CustomTabControl1.Controls.Add(Me.TabPage2)
			Me.CustomTabControl1.Controls.Add(Me.TabPage3)
			Me.CustomTabControl1.DisplayStyle = TabStyle.Angled
			Me.CustomTabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
			Me.CustomTabControl1.HotTrack = True
			Dim customTabControl1 As SVPLCApplication.CustomTabControl = Me.CustomTabControl1
			size = New System.Drawing.Size(114, 40)
			customTabControl1.ItemSize = size
			Dim customTabControl As SVPLCApplication.CustomTabControl = Me.CustomTabControl1
			point = New System.Drawing.Point(526, 50)
			customTabControl.Location = point
			Me.CustomTabControl1.Name = "CustomTabControl1"
			Me.CustomTabControl1.SelectedIndex = 0
			Dim customTabControl11 As SVPLCApplication.CustomTabControl = Me.CustomTabControl1
			size = New System.Drawing.Size(404, 554)
			customTabControl11.Size = size
			Me.CustomTabControl1.SizeMode = TabSizeMode.Fixed
			Me.CustomTabControl1.TabIndex = 43
			Me.TabPage1.AutoScroll = True
			Me.TabPage1.BackColor = Color.DarkKhaki
			Dim tabPage1 As System.Windows.Forms.TabPage = Me.TabPage1
			point = New System.Drawing.Point(4, 45)
			tabPage1.Location = point
			Me.TabPage1.Name = "TabPage1"
			Dim tabPage As System.Windows.Forms.TabPage = Me.TabPage1
			padding = New System.Windows.Forms.Padding(3)
			tabPage.Padding = padding
			Dim tabPage11 As System.Windows.Forms.TabPage = Me.TabPage1
			size = New System.Drawing.Size(396, 505)
			tabPage11.Size = size
			Me.TabPage1.TabIndex = 0
			Me.TabPage1.Text = "Plantes"
			Me.TabPage2.AutoScroll = True
			Me.TabPage2.BackColor = Color.Tan
			Dim tabPage2 As System.Windows.Forms.TabPage = Me.TabPage2
			point = New System.Drawing.Point(4, 45)
			tabPage2.Location = point
			Me.TabPage2.Name = "TabPage2"
			Dim tabPage21 As System.Windows.Forms.TabPage = Me.TabPage2
			padding = New System.Windows.Forms.Padding(3)
			tabPage21.Padding = padding
			Dim tabPage22 As System.Windows.Forms.TabPage = Me.TabPage2
			size = New System.Drawing.Size(396, 505)
			tabPage22.Size = size
			Me.TabPage2.TabIndex = 1
			Me.TabPage2.Text = "Surfaces"
			Me.TabPage3.AutoScroll = True
			Me.TabPage3.BackColor = Color.Gray
			Dim tabPage3 As System.Windows.Forms.TabPage = Me.TabPage3
			point = New System.Drawing.Point(4, 45)
			tabPage3.Location = point
			Me.TabPage3.Name = "TabPage3"
			Dim tabPage31 As System.Windows.Forms.TabPage = Me.TabPage3
			size = New System.Drawing.Size(396, 505)
			tabPage31.Size = size
			Me.TabPage3.TabIndex = 2
			Me.TabPage3.Text = "Aménagements"
			Me.MyGroupBox2.BorderColor = Color.DimGray
			Me.MyGroupBox2.Controls.Add(Me.Buttonimporter)
			Me.MyGroupBox2.Diagonale = 10
			Me.MyGroupBox2.ForeColor = Color.Black
			Dim myGroupBox2 As myGroupBox = Me.MyGroupBox2
			point = New System.Drawing.Point(1147, 768)
			myGroupBox2.Location = point
			Me.MyGroupBox2.Name = "MyGroupBox2"
			Dim _myGroupBox As myGroupBox = Me.MyGroupBox2
			size = New System.Drawing.Size(141, 74)
			_myGroupBox.Size = size
			Me.MyGroupBox2.TabIndex = 22
			Me.MyGroupBox2.TabStop = False
			Me.MyGroupBox2.Thickness = 10
			Me.MyGroupBox2.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.Buttonimporter.BackColor = Color.Indigo
			Me.Buttonimporter.FlatAppearance.BorderColor = Color.Navy
			Me.Buttonimporter.FlatStyle = FlatStyle.Flat
			Me.Buttonimporter.Font = New System.Drawing.Font("Segoe UI", 6.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim buttonimporter As System.Windows.Forms.Button = Me.Buttonimporter
			point = New System.Drawing.Point(16, 17)
			buttonimporter.Location = point
			Me.Buttonimporter.Name = "Buttonimporter"
			Dim buttonimporter1 As System.Windows.Forms.Button = Me.Buttonimporter
			size = New System.Drawing.Size(109, 39)
			buttonimporter1.Size = size
			Me.Buttonimporter.TabIndex = 28
			Me.Buttonimporter.Text = "Importer"
			Me.Buttonimporter.UseVisualStyleBackColor = False
			Me.MyGroupBox1.BorderColor = Color.DimGray
			Me.MyGroupBox1.Controls.Add(Me.Buttonenregistrer)
			Me.MyGroupBox1.Diagonale = 10
			Me.MyGroupBox1.ForeColor = Color.Black
			Dim myGroupBox1 As myGroupBox = Me.MyGroupBox1
			point = New System.Drawing.Point(1057, 670)
			myGroupBox1.Location = point
			Me.MyGroupBox1.Name = "MyGroupBox1"
			Dim myGroupBox11 As myGroupBox = Me.MyGroupBox1
			size = New System.Drawing.Size(141, 74)
			myGroupBox11.Size = size
			Me.MyGroupBox1.TabIndex = 18
			Me.MyGroupBox1.TabStop = False
			Me.MyGroupBox1.Thickness = 10
			Me.MyGroupBox1.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.Buttonenregistrer.BackColor = Color.Green
			Me.Buttonenregistrer.FlatAppearance.BorderColor = Color.DarkGreen
			Me.Buttonenregistrer.FlatStyle = FlatStyle.Flat
			Me.Buttonenregistrer.Font = New System.Drawing.Font("Segoe UI", 6.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim buttonenregistrer As System.Windows.Forms.Button = Me.Buttonenregistrer
			point = New System.Drawing.Point(16, 17)
			buttonenregistrer.Location = point
			Me.Buttonenregistrer.Name = "Buttonenregistrer"
			Dim buttonenregistrer1 As System.Windows.Forms.Button = Me.Buttonenregistrer
			size = New System.Drawing.Size(109, 39)
			buttonenregistrer1.Size = size
			Me.Buttonenregistrer.TabIndex = 29
			Me.Buttonenregistrer.Text = "Enregistrer"
			Me.Buttonenregistrer.UseVisualStyleBackColor = False
			Me.Tableauannee.BackColor = Color.Transparent
			Me.Tableauannee.BackgroundImage = Resources.Boisfond2
			Me.Tableauannee.BackgroundImageLayout = ImageLayout.Stretch
			Me.Tableauannee.BorderColor = Color.DimGray
			Me.Tableauannee.Controls.Add(Me.Bordannee0)
			Me.Tableauannee.Controls.Add(Me.Bordannee1)
			Me.Tableauannee.Controls.Add(Me.Bordannee2)
			Me.Tableauannee.Diagonale = 10
			Me.Tableauannee.ForeColor = Color.Black
			Dim tableauannee As myGroupBox = Me.Tableauannee
			point = New System.Drawing.Point(396, 653)
			tableauannee.Location = point
			Me.Tableauannee.Name = "Tableauannee"
			Dim tableauannee1 As myGroupBox = Me.Tableauannee
			size = New System.Drawing.Size(572, 205)
			tableauannee1.Size = size
			Me.Tableauannee.TabIndex = 16
			Me.Tableauannee.TabStop = False
			Me.Tableauannee.Thickness = 10
			Me.Tableauannee.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.Bordannee0.BorderColor = Color.Green
			Me.Bordannee0.Controls.Add(Me.PictureBoxannee0)
			Me.Bordannee0.Diagonale = 0
			Me.Bordannee0.ForeColor = Color.Black
			Dim bordannee0 As myGroupBox = Me.Bordannee0
			point = New System.Drawing.Point(28, 23)
			bordannee0.Location = point
			Me.Bordannee0.Name = "Bordannee0"
			Dim bordannee01 As myGroupBox = Me.Bordannee0
			size = New System.Drawing.Size(158, 158)
			bordannee01.Size = size
			Me.Bordannee0.TabIndex = 0
			Me.Bordannee0.TabStop = False
			Me.Bordannee0.Thickness = 4
			Me.Bordannee0.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.PictureBoxannee0.BackgroundImage = Resources.Fondsvplc2
			Me.PictureBoxannee0.BackgroundImageLayout = ImageLayout.Stretch
			Me.PictureBoxannee0.BorderStyle = BorderStyle.FixedSingle
			Dim pictureBoxannee0 As System.Windows.Forms.PictureBox = Me.PictureBoxannee0
			point = New System.Drawing.Point(4, 4)
			pictureBoxannee0.Location = point
			Me.PictureBoxannee0.Name = "PictureBoxannee0"
			Dim pictureBoxannee01 As System.Windows.Forms.PictureBox = Me.PictureBoxannee0
			size = New System.Drawing.Size(150, 150)
			pictureBoxannee01.Size = size
			Me.PictureBoxannee0.TabIndex = 0
			Me.PictureBoxannee0.TabStop = False
			Me.Bordannee1.BorderColor = Color.Green
			Me.Bordannee1.Controls.Add(Me.PictureBoxannee1)
			Me.Bordannee1.Diagonale = 0
			Me.Bordannee1.ForeColor = Color.Black
			Dim bordannee1 As myGroupBox = Me.Bordannee1
			point = New System.Drawing.Point(207, 23)
			bordannee1.Location = point
			Me.Bordannee1.Name = "Bordannee1"
			Dim bordannee11 As myGroupBox = Me.Bordannee1
			size = New System.Drawing.Size(158, 158)
			bordannee11.Size = size
			Me.Bordannee1.TabIndex = 1
			Me.Bordannee1.TabStop = False
			Me.Bordannee1.Thickness = 4
			Me.Bordannee1.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.PictureBoxannee1.BackgroundImage = Resources.Fondsvplc
			Me.PictureBoxannee1.BackgroundImageLayout = ImageLayout.Stretch
			Me.PictureBoxannee1.BorderStyle = BorderStyle.FixedSingle
			Dim pictureBoxannee1 As System.Windows.Forms.PictureBox = Me.PictureBoxannee1
			point = New System.Drawing.Point(4, 4)
			pictureBoxannee1.Location = point
			Me.PictureBoxannee1.Name = "PictureBoxannee1"
			Dim pictureBoxannee11 As System.Windows.Forms.PictureBox = Me.PictureBoxannee1
			size = New System.Drawing.Size(150, 150)
			pictureBoxannee11.Size = size
			Me.PictureBoxannee1.TabIndex = 1
			Me.PictureBoxannee1.TabStop = False
			Me.Bordannee2.BorderColor = Color.Green
			Me.Bordannee2.Controls.Add(Me.PictureBoxannee2)
			Me.Bordannee2.Diagonale = 0
			Me.Bordannee2.ForeColor = Color.Black
			Dim bordannee2 As myGroupBox = Me.Bordannee2
			point = New System.Drawing.Point(386, 23)
			bordannee2.Location = point
			Me.Bordannee2.Name = "Bordannee2"
			Dim bordannee21 As myGroupBox = Me.Bordannee2
			size = New System.Drawing.Size(158, 158)
			bordannee21.Size = size
			Me.Bordannee2.TabIndex = 2
			Me.Bordannee2.TabStop = False
			Me.Bordannee2.Thickness = 4
			Me.Bordannee2.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.PictureBoxannee2.BackgroundImage = Resources.Fondsvplc
			Me.PictureBoxannee2.BackgroundImageLayout = ImageLayout.Stretch
			Me.PictureBoxannee2.BorderStyle = BorderStyle.FixedSingle
			Dim pictureBoxannee2 As System.Windows.Forms.PictureBox = Me.PictureBoxannee2
			point = New System.Drawing.Point(4, 4)
			pictureBoxannee2.Location = point
			Me.PictureBoxannee2.Name = "PictureBoxannee2"
			Dim pictureBoxannee21 As System.Windows.Forms.PictureBox = Me.PictureBoxannee2
			size = New System.Drawing.Size(150, 150)
			pictureBoxannee21.Size = size
			Me.PictureBoxannee2.TabIndex = 1
			Me.PictureBoxannee2.TabStop = False
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoScroll = True
			Me.BackColor = SystemColors.ButtonShadow
			size = New System.Drawing.Size(1387, 924)
			Me.ClientSize = size
			Me.Controls.Add(Me.Panel2)
			Me.Controls.Add(Me.Buttonnbrcellules)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.CustomTabControl1)
			Me.Controls.Add(Me.Panelonglet)
			Me.Controls.Add(Me.MenuPrinc)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.StatusStrip1)
			Me.Controls.Add(Me.Buttonajouter)
			Me.Controls.Add(Me.PictureBox2)
			Me.Controls.Add(Me.Panel5)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.MyGroupBox2)
			Me.Controls.Add(Me.Buttonsauvegarder)
			Me.Controls.Add(Me.MyGroupBox1)
			Me.Controls.Add(Me.Tableauannee)
			Me.Controls.Add(Me.Buttonchangementimg)
			Me.Controls.Add(Me.CheckBoxsupp)
			Me.Controls.Add(Me.Buttonreset)
			Me.Controls.Add(Me.Panel)
			Me.Controls.Add(Me.PictureBox4)
			Me.Controls.Add(Me.PictureBox5)
			Me.Controls.Add(Me.Panel6)
			Me.Controls.Add(Me.PictureBoxpanneau)
			Me.DoubleBuffered = True
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.Name = "FormPasPas"
			Me.Opacity = 0
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "SVPLC - Optimisateur de plantations en jardin potager / Gestion du jardin"
			DirectCast(Me.PictureBox4, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox5, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).EndInit()
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			Me.MenuPrinc.ResumeLayout(False)
			Me.MenuPrinc.PerformLayout()
			Me.Panel5.ResumeLayout(False)
			Me.Panel5.PerformLayout()
			Me.Panel6.ResumeLayout(False)
			Me.Panel6.PerformLayout()
			Me.Panelonglet.ResumeLayout(False)
			DirectCast(Me.PictureBox3, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBoxpanneau, ISupportInitialize).EndInit()
			Me.Panel2.ResumeLayout(False)
			Me.CustomTabControl1.ResumeLayout(False)
			Me.MyGroupBox2.ResumeLayout(False)
			Me.MyGroupBox1.ResumeLayout(False)
			Me.Tableauannee.ResumeLayout(False)
			Me.Bordannee0.ResumeLayout(False)
			DirectCast(Me.PictureBoxannee0, ISupportInitialize).EndInit()
			Me.Bordannee1.ResumeLayout(False)
			DirectCast(Me.PictureBoxannee1, ISupportInitialize).EndInit()
			Me.Bordannee2.ResumeLayout(False)
			DirectCast(Me.PictureBoxannee2, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Public Function Inputboxperso(ByVal str As String, ByVal str2 As String) As String
			Me.titreinput = str2
			Me.labelinput = str
			If ((New FormBDNumerique()).ShowDialog() <> System.Windows.Forms.DialogResult.OK) Then
				Return ""
			End If
			Return Me.reponse
		End Function

		<DllImport("user32.dll", CharSet:=CharSet.Unicode, EntryPoint:="LoadCursorFromFileW", ExactSpelling:=True, SetLastError:=True)>
		Private Shared Function LoadCursorFromFile(ByRef filename As String) As IntPtr
		End Function

		Private Sub ModePasÀPasToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadcalc) Then
				Me.CALCULTRC = New Calculatrice()
				Me.CALCULTRC.Show()
				Module1.loadcalc = True
			Else
				Me.CALCULTRC.WindowState = FormWindowState.Normal
				Me.CALCULTRC.Activate()
			End If
		End Sub

		Private Sub MonJardinToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadgarden) Then
				Me.WinMonJardin = New FormMonJardin()
				Me.WinMonJardin.Show()
				Module1.loadgarden = True
			Else
				Me.WinMonJardin.WindowState = FormWindowState.Normal
				Me.WinMonJardin.Activate()
			End If
		End Sub

		Public Sub MontrerBarreTacheWindows()
			Dim str As String = "Shell_traywnd"
			Dim str1 As String = ""
			Dim num As Long = CLng(FormPasPas.FindWindow(str, str1))
			FormPasPas.SetWindowPos(CInt(num), 0, 0, 0, 0, 0, 64)
		End Sub

		Public Sub Msgboxperso(ByVal str As String, ByVal str2 As String)
			Me.msgboxtitre = str2
			Me.msgboxmess = str
			Dim dialogResult As System.Windows.Forms.DialogResult = (New FormMSGBOXPerso()).ShowDialog()
		End Sub

		Private Sub Panelonglet_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			Me.showonglet()
		End Sub

		Private Sub Panelonglet_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.Panelonglet.ClientRectangle.Contains(Me.Panelonglet.PointToClient(System.Windows.Forms.Cursor.Position))) Then
				Me.hideonglet()
			End If
		End Sub

		Private Sub Pas_à_pas_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			Module1.loadcalc = False
			If (Directory.Exists(Module1.PATHS(17))) Then
				Dim files As String() = Directory.GetFiles(Module1.PATHS(17))
				For i As Integer = 0 To CInt(files.Length) Step 1
					File.Delete(files(i))
				Next

			End If
			Me.MontrerBarreTacheWindows()
		End Sub

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Pas_à_pas_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim str As String
			Dim enumerator As IEnumerator = Nothing
			Dim enumerator1 As IEnumerator = Nothing
			Dim enumerator2 As IEnumerator = Nothing
			Dim enumerator3 As IEnumerator = Nothing
			Dim enumerator4 As IEnumerator = Nothing
			Me.stpwch = New Stopwatch()
			Me.stpwch.Start()
			Me.version = "8.1.5"
			Me.activation = False
			Me.jrestant = 365
			Me.util = ""
			Me.activcode = ""
			Me.installmsg = 0
			Dim registryKey As Microsoft.Win32.RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Svplc\\activ", False)
			Dim registryKey1 As Microsoft.Win32.RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Svplc\\util", False)
			If (registryKey IsNot Nothing AndAlso registryKey1 IsNot Nothing) Then
				Me.util = Conversions.ToString(registryKey1.GetValue("Utilisateur", ""))
				Me.activcode = Conversions.ToString(registryKey.GetValue("License", ""))
				If (Operators.CompareString(Me.util, "", False) <> 0 And Operators.CompareString(Me.activcode, "", False) <> 0 AndAlso Operators.CompareString(Me.encrypt(Me.util.Insert(4, "108").Insert(15, "Ch212").Remove(8, 5)), Me.activcode, False) = 0) Then
					Me.activation = True
				End If
			End If
			If (Not Me.activation) Then
				Dim num As Integer = 10
				Dim now As System.DateTime = System.DateTime.Now
				Dim registryKey2 As Microsoft.Win32.RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Svplc\\date", False)
				If (registryKey2 IsNot Nothing) Then
					str = Conversions.ToString(registryKey2.GetValue("Date installation", ""))
					If (Operators.CompareString(str, "", False) <> 0) Then
						Try
							Dim dateTime As System.DateTime = Convert.ToDateTime(Me.AES_Decrypt(str, "108"))
							Dim dateTime1 As System.DateTime = dateTime.AddDays(CDbl(num))
							Me.jrestant = CInt(DateAndTime.DateDiff(DateInterval.Day, now, dateTime1, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1))
							If (Not (Me.jrestant >= 0 And Me.jrestant <= num)) Then
								Me.installmsg = 3
							Else
								Me.installmsg = 2
							End If
						Catch exception As System.Exception
							ProjectData.SetProjectError(exception)
							Me.installmsg = 3
							ProjectData.ClearProjectError()
						End Try
					Else
						ProjectData.EndApp()
					End If
				Else
					Me.installmsg = 1
					registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Svplc\\date")
					str = Me.AES_Encrypt(now.ToString(), "108")
					registryKey2.SetValue("Date installation", str)
				End If
			End If
			Module1.PATHS = New String() { String.Concat(Module1.Destdir, "\Liste légumes.txt"), String.Concat(Module1.Destdir, "\Base de données associations.txt"), String.Concat(Module1.Destdir, "\Base de données rotations.txt"), Resources._3, Resources._4, Resources._5, Resources._6, Resources._7, Resources._8, Resources._9, Resources.Le_poireau_préfère_les_fraises, String.Concat(Module1.Destdir, "\Base de données calendrier.txt"), String.Concat(Module1.Destdir, "\Fiches légumes"), String.Concat(Module1.Destdir, "\Legimg"), String.Concat(Module1.Destdir, "\Surfaces"), String.Concat(Module1.Destdir, "\Aménagements"), String.Concat(Module1.Destdir, "\Bmp"), String.Concat(Module1.Destdir, "\Temp"), String.Concat(Module1.Destdir, "\Help_SVPLC.chm") }
			If (Not Directory.Exists(Module1.PATHS(16))) Then
				Directory.CreateDirectory(Module1.PATHS(16))
			End If
			If (Not Directory.Exists(Module1.PATHS(17))) Then
				Directory.CreateDirectory(Module1.PATHS(17))
			End If
			If (Not File.Exists(String.Concat(Module1.PATHS(17), "\conf.txt"))) Then
				File.Create(String.Concat(Module1.PATHS(17), "\conf.txt")).Close()
			End If
			Module1.nbrmaxparcelles = 9
			ReDim Module1.couleurs(Module1.nbrmaxparcelles + 1 - 1)
			Module1.couleurs(1) = Color.Green
			Module1.couleurs(2) = Color.Yellow
			Module1.couleurs(3) = Color.Blue
			Module1.couleurs(4) = Color.Red
			Module1.couleurs(5) = Color.Maroon
			Module1.couleurs(6) = Color.Crimson
			Module1.couleurs(7) = Color.Violet
			Module1.couleurs(8) = Color.SteelBlue
			Module1.couleurs(9) = Color.GreenYellow
			Module1.nbrmaxcontraintes = 9
			ReDim Module1.couleurscont(Module1.nbrmaxcontraintes + 1 - 1)
			Module1.couleurscont(1) = Color.Chartreuse
			Module1.couleurscont(2) = Color.Thistle
			Module1.couleurscont(3) = Color.Chocolate
			Module1.couleurscont(4) = Color.YellowGreen
			Module1.couleurscont(5) = Color.Gainsboro
			Module1.couleurscont(6) = Color.Goldenrod
			Module1.couleurscont(7) = Color.Coral
			Module1.couleurscont(8) = Color.DarkGreen
			Module1.couleurscont(9) = Color.IndianRed
			Module1.colortypefam = New Color() { Color.Black, Color.DarkRed, Color.Navy }
			If (Not Directory.Exists(Module1.PATHS(13))) Then
				Directory.CreateDirectory(Module1.PATHS(13))
				Resources.Abricotier.Save(String.Concat(Module1.PATHS(13), "\Abricotier.png"))
				Resources.Absinthe.Save(String.Concat(Module1.PATHS(13), "\Absinthe.png"))
				Resources.Ail.Save(String.Concat(Module1.PATHS(13), "\Ail.png"))
				Resources.Aneth.Save(String.Concat(Module1.PATHS(13), "\Aneth.png"))
				Resources.Artichaut.Save(String.Concat(Module1.PATHS(13), "\Artichaut.png"))
				Resources.Asperge.Save(String.Concat(Module1.PATHS(13), "\Asperge.png"))
				Resources.Aubergine.Save(String.Concat(Module1.PATHS(13), "\Aubergine.png"))
				Resources.Basilic.Save(String.Concat(Module1.PATHS(13), "\Basilic.png"))
				Resources.Bette_à_carde.Save(String.Concat(Module1.PATHS(13), "\Bette à carde.png"))
				Resources.Betterave.Save(String.Concat(Module1.PATHS(13), "\Betterave.png"))
				Resources.Brocoli.Save(String.Concat(Module1.PATHS(13), "\Brocoli.png"))
				Resources.Calendula.Save(String.Concat(Module1.PATHS(13), "\Calendula.png"))
				Resources.Camomille.Save(String.Concat(Module1.PATHS(13), "\Camomille.png"))
				Resources.Capucine.Save(String.Concat(Module1.PATHS(13), "\Capucine.png"))
				Resources.Carotte.Save(String.Concat(Module1.PATHS(13), "\Carotte.png"))
				Resources.Celeri.Save(String.Concat(Module1.PATHS(13), "\Céleri.png"))
				Resources.Cerfeuil.Save(String.Concat(Module1.PATHS(13), "\Cerfeuil.png"))
				Resources.Chardon.Save(String.Concat(Module1.PATHS(13), "\Chardon bleu.png"))
				Resources.Chicorée.Save(String.Concat(Module1.PATHS(13), "\Chicorée.png"))
				Resources.Choux.Save(String.Concat(Module1.PATHS(13), "\Chou.png"))
				Resources.Chou_de_Bruxelles.Save(String.Concat(Module1.PATHS(13), "\Chou de Bruxelles.png"))
				Resources.Chou_Fleur.Save(String.Concat(Module1.PATHS(13), "\Chou-Fleur.png"))
				Resources.Ciboulette.Save(String.Concat(Module1.PATHS(13), "\Ciboulette.png"))
				Resources.Citrouille.Save(String.Concat(Module1.PATHS(13), "\Citrouille.png"))
				Resources.Concombre.Save(String.Concat(Module1.PATHS(13), "\Concombre.png"))
				Resources.Coriandre.Save(String.Concat(Module1.PATHS(13), "\Coriandre.png"))
				Resources.Cornichon.Save(String.Concat(Module1.PATHS(13), "\Cornichon.png"))
				Resources.Cosmos.Save(String.Concat(Module1.PATHS(13), "\Cosmos.png"))
				Resources.Courge.Save(String.Concat(Module1.PATHS(13), "\Courge.png"))
				Resources.Echalotte.Save(String.Concat(Module1.PATHS(13), "\Echalotte.png"))
				Resources.Epicéa.Save(String.Concat(Module1.PATHS(13), "\Epicéa.png"))
				Resources.Epinard.Save(String.Concat(Module1.PATHS(13), "\Epinard.png"))
				Resources.Erable.Save(String.Concat(Module1.PATHS(13), "\Erable.png"))
				Resources.Euphorbe.Save(String.Concat(Module1.PATHS(13), "\Euphorbe.png"))
				Resources.Fenouil.Save(String.Concat(Module1.PATHS(13), "\Fenouil.png"))
				Resources.Fève.Save(String.Concat(Module1.PATHS(13), "\Fève.png"))
				Resources.Fougère.Save(String.Concat(Module1.PATHS(13), "\Fougère.png"))
				Resources.Fraise.Save(String.Concat(Module1.PATHS(13), "\Fraisier.png"))
				Resources.Framboisier.Save(String.Concat(Module1.PATHS(13), "\Framboisier.png"))
				Resources.Genêt.Save(String.Concat(Module1.PATHS(13), "\Genêt.png"))
				Resources.Géranium.Save(String.Concat(Module1.PATHS(13), "\Géranium.png"))
				Resources.Giroflée.Save(String.Concat(Module1.PATHS(13), "\Giroflée.png"))
				Resources.Groseillier.Save(String.Concat(Module1.PATHS(13), "\Groseillier.png"))
				Resources.Haricot.Save(String.Concat(Module1.PATHS(13), "\Haricot.png"))
				Resources.Haricot_rame.Save(String.Concat(Module1.PATHS(13), "\Haricot rame.png"))
				Resources.Houx.Save(String.Concat(Module1.PATHS(13), "\Houx.png"))
				Resources.Hysope.Save(String.Concat(Module1.PATHS(13), "\Hysope.png"))
				Resources.Laitue.Save(String.Concat(Module1.PATHS(13), "\Laitue.png"))
				Resources.Lavande.Save(String.Concat(Module1.PATHS(13), "\Lavande.png"))
				Resources.Mache.Save(String.Concat(Module1.PATHS(13), "\Mâche.png"))
				Resources.Maïs.Save(String.Concat(Module1.PATHS(13), "\Maïs.png"))
				Resources.Melon.Save(String.Concat(Module1.PATHS(13), "\Melon.png"))
				Resources.Menthe.Save(String.Concat(Module1.PATHS(13), "\Menthe.png"))
				Resources.Molène.Save(String.Concat(Module1.PATHS(13), "\Molène.png"))
				Resources.Myosotis.Save(String.Concat(Module1.PATHS(13), "\Myosotis.png"))
				Resources.Navet.Save(String.Concat(Module1.PATHS(13), "\Navet.png"))
				Resources.Oeillet_d_Inde.Save(String.Concat(Module1.PATHS(13), "\Oeillet d'Inde.png"))
				Resources.Oignon.Save(String.Concat(Module1.PATHS(13), "\Oignon.png"))
				Resources.Origan.Save(String.Concat(Module1.PATHS(13), "\Origan.png"))
				Resources.Orme.Save(String.Concat(Module1.PATHS(13), "\Orme.png"))
				Resources.Ortie.Save(String.Concat(Module1.PATHS(13), "\Ortie.png"))
				Resources.Panais.Save(String.Concat(Module1.PATHS(13), "\Panais.png"))
				Resources.Pêche.Save(String.Concat(Module1.PATHS(13), "\Pêcher.png"))
				Resources.Persil.Save(String.Concat(Module1.PATHS(13), "\Persil.png"))
				Resources.Phacélie.Save(String.Concat(Module1.PATHS(13), "\Phacélie.png"))
				Resources.Piment.Save(String.Concat(Module1.PATHS(13), "\Piment.png"))
				Resources.Pin.Save(String.Concat(Module1.PATHS(13), "\Pin.png"))
				Resources.Poireau.Save(String.Concat(Module1.PATHS(13), "\Poireau.png"))
				Resources.Poirier.Save(String.Concat(Module1.PATHS(13), "\Poirier.png"))
				Resources.Pois.Save(String.Concat(Module1.PATHS(13), "\Pois.png"))
				Resources.Poivron.Save(String.Concat(Module1.PATHS(13), "\Poivron.png"))
				Resources.Pomme_de_Terre.Save(String.Concat(Module1.PATHS(13), "\Pomme de Terre.png"))
				Resources.Pommier.Save(String.Concat(Module1.PATHS(13), "\Pommier.png"))
				Resources.Potiron.Save(String.Concat(Module1.PATHS(13), "\Potiron.png"))
				Resources.Radis.Save(String.Concat(Module1.PATHS(13), "\Radis.png"))
				Resources.Rhubarbe.Save(String.Concat(Module1.PATHS(13), "\Rhubarbe.png"))
				Resources.Romarin.Save(String.Concat(Module1.PATHS(13), "\Romarin.png"))
				Resources.Rosier.Save(String.Concat(Module1.PATHS(13), "\Rosier.png"))
				Resources.Rue.Save(String.Concat(Module1.PATHS(13), "\Rue.png"))
				Resources.Sarrasin.Save(String.Concat(Module1.PATHS(13), "\Sarrasin.png"))
				Resources.Sarriette.Save(String.Concat(Module1.PATHS(13), "\Sarriette.png"))
				Resources.Sauge.Save(String.Concat(Module1.PATHS(13), "\Sauge.png"))
				Resources.Sureau.Save(String.Concat(Module1.PATHS(13), "\Sureau.png"))
				Resources.Tanaisie.Save(String.Concat(Module1.PATHS(13), "\Tanaisie.png"))
				Resources.Thym.Save(String.Concat(Module1.PATHS(13), "\Thym.png"))
				Resources.Tomate.Save(String.Concat(Module1.PATHS(13), "\Tomate.png"))
				Resources.Topinambour.Save(String.Concat(Module1.PATHS(13), "\Topinambour.png"))
				Resources.Tournesol.Save(String.Concat(Module1.PATHS(13), "\Tournesol.png"))
				Resources.Vigne.Save(String.Concat(Module1.PATHS(13), "\Vigne.png"))
				Resources.Arroche.Save(String.Concat(Module1.PATHS(13), "\Arroche.png"))
				Resources.Bourrache.Save(String.Concat(Module1.PATHS(13), "\Bourrache.png"))
				Resources.Chou_de_Chine.Save(String.Concat(Module1.PATHS(13), "\Chou de Chine.png"))
				Resources.Chou_Tatsoi.Save(String.Concat(Module1.PATHS(13), "\Chou chinois Tatsoi.png"))
				Resources.Cerise.Save(String.Concat(Module1.PATHS(13), "\Cerise.png"))
				Resources.raifort.Save(String.Concat(Module1.PATHS(13), "\Raifort.png"))
				Resources.Courgette.Save(String.Concat(Module1.PATHS(13), "\Courgette.png"))
				Resources.Cresson.Save(String.Concat(Module1.PATHS(13), "\Cresson.png"))
				Resources.Haricot_nain.Save(String.Concat(Module1.PATHS(13), "\Haricot nain.png"))
				Resources.Pissenlit.Save(String.Concat(Module1.PATHS(13), "\Pissenlit.png"))
				Resources.Radis_noir.Save(String.Concat(Module1.PATHS(13), "\Radis noir.png"))
				Resources.Salsifis.Save(String.Concat(Module1.PATHS(13), "\Salsifis.png"))
				Resources.Valériane.Save(String.Concat(Module1.PATHS(13), "\Valériane.png"))
				Resources.Chou_pommé.Save(String.Concat(Module1.PATHS(13), "\Chou pommé.png"))
				Resources.Autres_chou.Save(String.Concat(Module1.PATHS(13), "\Autres choux.png"))
				Resources.Autres_pois.Save(String.Concat(Module1.PATHS(13), "\Autres pois.png"))
				Resources.Salade.Save(String.Concat(Module1.PATHS(13), "\Salade.png"))
				Resources.Chou_non_pommé.Save(String.Concat(Module1.PATHS(13), "\Choux non Pommés.png"))
				Resources.Chou_rave.Save(String.Concat(Module1.PATHS(13), "\Chou-Rave.png"))
				Resources.Arbres_fruitiers.Save(String.Concat(Module1.PATHS(13), "\Arbres fruitiers.png"))
				Resources.Blé.Save(String.Concat(Module1.PATHS(13), "\Blé.png"))
				Resources.Chrysantheme2.Save(String.Concat(Module1.PATHS(13), "\Chrysanthème.png"))
				Resources.christophine.Save(String.Concat(Module1.PATHS(13), "\Christophine.png"))
				Resources.Vesce.Save(String.Concat(Module1.PATHS(13), "\Vesce.png"))
				Resources.Trèfle.Save(String.Concat(Module1.PATHS(13), "\Trèfle.png"))
				Resources.Moutarde.Save(String.Concat(Module1.PATHS(13), "\Moutarde.png"))
				Resources.Orge.Save(String.Concat(Module1.PATHS(13), "\Orge.png"))
				Resources.Oseille.Save(String.Concat(Module1.PATHS(13), "\Oseille.png"))
				Resources.Patate_Douce.Save(String.Concat(Module1.PATHS(13), "\Patate Douce.png"))
				Resources.Prèle.Save(String.Concat(Module1.PATHS(13), "\Prèle.png"))
				Resources.Ipomée.Save(String.Concat(Module1.PATHS(13), "\Ipomée.png"))
				Resources.liseron.Save(String.Concat(Module1.PATHS(13), "\Liseron.png"))
			End If
			If (Not Directory.Exists(Module1.PATHS(14))) Then
				Directory.CreateDirectory(Module1.PATHS(14))
				Resources.Gravier_blanc.Save(String.Concat(Module1.PATHS(14), "\Gravier blanc.png"))
				Resources.Gravier_gris.Save(String.Concat(Module1.PATHS(14), "\Gravier gris.png"))
				Resources.Gravier_mixte.Save(String.Concat(Module1.PATHS(14), "\Gravier mixte.png"))
				Resources.Gros_galet.Save(String.Concat(Module1.PATHS(14), "\Galet gros.png"))
				Resources.Gros_gravier_gris.Save(String.Concat(Module1.PATHS(14), "\Gravier gris gros.png"))
				Resources.Gazon.Save(String.Concat(Module1.PATHS(14), "\Pelouse.png"))
				Resources.Galet.Save(String.Concat(Module1.PATHS(14), "\Galet.png"))
				Resources.Pierre_de_lave.Save(String.Concat(Module1.PATHS(14), "\Pierre de lave.png"))
				Resources.Terreau.Save(String.Concat(Module1.PATHS(14), "\Terreau.png"))
				Resources.Toile_de_paillage.Save(String.Concat(Module1.PATHS(14), "\Toile de paillage.png"))
				Resources.Eau.Save(String.Concat(Module1.PATHS(14), "\Eau.png"))
				Resources.Paille.Save(String.Concat(Module1.PATHS(14), "\Paille.png"))
			End If
			If (Not Directory.Exists(Module1.PATHS(15))) Then
				Directory.CreateDirectory(Module1.PATHS(15))
				Resources.Pas_japonaish.Save(String.Concat(Module1.PATHS(15), "\Pas japonais horizontal.png"))
				Resources.Pas_japonaisv.Save(String.Concat(Module1.PATHS(15), "\Pas japonais vertical.png"))
				Resources.Caillebotiscbd.Save(String.Concat(Module1.PATHS(15), "\Caillebotis coin bd.png"))
				Resources.Caillebotiscbg.Save(String.Concat(Module1.PATHS(15), "\Caillebotis coin bg.png"))
				Resources.Caillebotischd.Save(String.Concat(Module1.PATHS(15), "\Caillebotis coin hd.png"))
				Resources.Caillebotischg.Save(String.Concat(Module1.PATHS(15), "\Caillebotis coin hg.png"))
				Resources.Caillebotish.Save(String.Concat(Module1.PATHS(15), "\Caillebotis horizontal.png"))
				Resources.Caillebotisv.Save(String.Concat(Module1.PATHS(15), "\Caillebotis vertical.png"))
				Resources.Muret_galetcbd.Save(String.Concat(Module1.PATHS(15), "\Muret coin bd.png"))
				Resources.Muret_galetchd.Save(String.Concat(Module1.PATHS(15), "\Muret coin hd.png"))
				Resources.Muret_galetcbg.Save(String.Concat(Module1.PATHS(15), "\Muret coin bg.png"))
				Resources.Muret_galetchg.Save(String.Concat(Module1.PATHS(15), "\Muret coin hg.png"))
				Resources.Muret_galetv.Save(String.Concat(Module1.PATHS(15), "\Muret vertical.png"))
				Resources.Muret_galeth.Save(String.Concat(Module1.PATHS(15), "\Muret horizontal.png"))
				Resources.Eau_coin_ebd.Save(String.Concat(Module1.PATHS(15), "\Eau coin ebd.png"))
				Resources.Eau_coin_ebg.Save(String.Concat(Module1.PATHS(15), "\Eau coin ebg.png"))
				Resources.Eau_coin_ehd.Save(String.Concat(Module1.PATHS(15), "\Eau coin ehd.png"))
				Resources.Eau_coin_ehg.Save(String.Concat(Module1.PATHS(15), "\Eau coin ehg.png"))
				Resources.Eau_coin_ihd.Save(String.Concat(Module1.PATHS(15), "\Eau coin ihd.png"))
				Resources.Eau_coin_ihg.Save(String.Concat(Module1.PATHS(15), "\Eau coin ihg.png"))
				Resources.Eau_coin_ibd.Save(String.Concat(Module1.PATHS(15), "\Eau coin ibd.png"))
				Resources.Eau_coin_ibg.Save(String.Concat(Module1.PATHS(15), "\Eau coin ibg.png"))
			End If
			Module1.FAMILLE = New String() { "ABIETACEES", "APIACEES", "AQUIFOLIACEES", "ASTERACEES", "BORAGINACEES", "BRASSICACEES", "CAPRIFOLIACEES", "CONVOLVULACEES", "CHENOPODIACEES", "CUCURBITACEES", "EUPHORBIACEES", "FABACEES", "GERANIACEES", "GROSSULARIACEES", "HYDROPHYLACEES", "LAMIACEES", "LAURACEES", "LILIACEES", "PINACEES", "POACEES", "POLYGONACEES", "ROSACEES", "RUTACEES", "SAPINDACEES", "SCROPHULARIACEES", "SOLANACEES", "TROPAEOLACEES", "ULMACEES", "URTICACEES", "VALERIANACEES", "VITACEES" }
			Module1.TYPE = New String() { "Arbres", "Arbres fruitiers", "Arbuste", "Aromates et condiments", "Fleur", "Légume Bulbe", "Légume Feuille", "Légume Fruit", "Légume Graine", "Légume Racine" }
			Dim images As ImageList.ImageCollection = Me.ImageList7.Images
			images.Add(Resources.toutvn)
			images.Add(Resources.hbdvn)
			images.Add(Resources.hvbvdvgr)
			images.Add(Resources.bhgvn)
			images.Add(Resources.hbvn)
			images.Add(Resources.hvbvdngr)
			images.Add(Resources.toutvdr)
			images.Add(Resources.hvbvdrgn)
			images.Add(Resources.hbvgdr)
			images.Add(Resources.hdgvn)
			images.Add(Resources.hdvn)
			images.Add(Resources.hvbndvgr)
			images.Add(Resources.hgvn)
			images.Add(Resources.hvn)
			images.Add(Resources.hvgr)
			images.Add(Resources.hvbndrgv)
			images.Add(Resources.hvdr)
			images.Add(Resources.hvbndrgr)
			images.Add(Resources.toutvbr)
			images.Add(Resources.hvbrdvgn)
			images.Add(Resources.hvbrdvgr)
			images.Add(Resources.hvdnbrgv)
			images.Add(Resources.hvbr)
			images.Add(Resources.hvbrdngr)
			images.Add(Resources.hvbrdrgv)
			images.Add(Resources.hvbrdrgn)
			images.Add(Resources.toutrhv)
			images.Add(Resources.bdgvn)
			images.Add(Resources.bdvn)
			images.Add(Resources.hnbvdvgr)
			images.Add(Resources.bgvn)
			images.Add(Resources.bvn)
			images.Add(Resources.bvgr)
			images.Add(Resources.hndrbvgv)
			images.Add(Resources.bvdr)
			images.Add(Resources.hnbvdrgr)
			images.Add(Resources.dgvn)
			images.Add(Resources.dvn)
			images.Add(Resources.dvgr)
			images.Add(Resources.gvn)
			images.Add(Resources.grn)
			images.Add(Resources.drgv)
			images.Add(Resources.drn)
			images.Add(Resources.dgrn)
			images.Add(Resources.hnbrdvgv)
			images.Add(Resources.brdv)
			images.Add(Resources.hnbrdvgr)
			images.Add(Resources.brgv)
			images.Add(Resources.brn)
			images.Add(Resources.bgrn)
			images.Add(Resources.hnbrdrgv)
			images.Add(Resources.bdrn)
			images.Add(Resources.bdgrn)
			images.Add(Resources.toutvhr)
			images.Add(Resources.hrbvdvgn)
			images.Add(Resources.hrbvdvgr)
			images.Add(Resources.hrbvdngv)
			images.Add(Resources.hrbv)
			images.Add(Resources.hrbvdngr)
			images.Add(Resources.hrbvdrgv)
			images.Add(Resources.hrbvdrgn)
			images.Add(Resources.toutrbv)
			images.Add(Resources.hrbndvgv)
			images.Add(Resources.hrdv)
			images.Add(Resources.hrbndvgr)
			images.Add(Resources.hrgv)
			images.Add(Resources.hrn)
			images.Add(Resources.hgrn)
			images.Add(Resources.hrbndrgv)
			images.Add(Resources.hdrn)
			images.Add(Resources.gdhrn)
			images.Add(Resources.hbrgdv)
			images.Add(Resources.hrbrdvgn)
			images.Add(Resources.toutrdv)
			images.Add(Resources.hrbrdngv)
			images.Add(Resources.bhrn)
			images.Add(Resources.bghrn)
			images.Add(Resources.toutrgv)
			images.Add(Resources.bdhrn)
			images.Add(Resources.toutrn)
			images = Nothing
			Module1.checkrotfam = True
			Module1.checkrotbdd = True
			Module1.checkrottype = True
			Module1.masquerlesconflits = True
			Me.ChargementBDDpoireau()
			Me.ChargementBDDlisteleg()
			Me.ChargementBDDasso()
			Me.ChargementBDDrot()
			Me.ChargementBDDcal()
			Dim imageList1 As ImageList = Me.ImageList1
			Dim imageSize As System.Drawing.Size = Me.ImageList1.ImageSize
			Dim num1 As Integer = Module1.screenadaptX(imageSize.Width)
			Dim size As System.Drawing.Size = Me.ImageList1.ImageSize
			Dim size1 As System.Drawing.Size = New System.Drawing.Size(num1, Module1.screenadaptY(size.Height))
			imageList1.ImageSize = size1
			Dim imageList2 As ImageList = Me.ImageList2
			size1 = Me.ImageList2.ImageSize
			Dim num2 As Integer = Module1.screenadaptX(size1.Width)
			size = Me.ImageList2.ImageSize
			imageSize = New System.Drawing.Size(num2, Module1.screenadaptY(size.Height))
			imageList2.ImageSize = imageSize
			Dim imageList3 As ImageList = Me.ImageList3
			size1 = Me.ImageList3.ImageSize
			Dim num3 As Integer = Module1.screenadaptX(size1.Width)
			size = Me.ImageList3.ImageSize
			imageSize = New System.Drawing.Size(num3, Module1.screenadaptY(size.Height))
			imageList3.ImageSize = imageSize
			Dim imageList4 As ImageList = Me.ImageList4
			size1 = Me.ImageList4.ImageSize
			Dim num4 As Integer = Module1.screenadaptX(size1.Width)
			size = Me.ImageList4.ImageSize
			imageSize = New System.Drawing.Size(num4, Module1.screenadaptY(size.Height))
			imageList4.ImageSize = imageSize
			Dim imageList5 As ImageList = Me.ImageList5
			size1 = Me.ImageList5.ImageSize
			Dim num5 As Integer = Module1.screenadaptX(size1.Width)
			size = Me.ImageList5.ImageSize
			imageSize = New System.Drawing.Size(num5, Module1.screenadaptY(size.Height))
			imageList5.ImageSize = imageSize
			Dim imageList6 As ImageList = Me.ImageList6
			size1 = Me.ImageList6.ImageSize
			Dim num6 As Integer = Module1.screenadaptX(size1.Width)
			size = Me.ImageList6.ImageSize
			imageSize = New System.Drawing.Size(num6, Module1.screenadaptY(size.Height))
			imageList6.ImageSize = imageSize
			Dim imageList7 As ImageList = Me.ImageList7
			size1 = Me.ImageList7.ImageSize
			Dim num7 As Integer = Module1.screenadaptX(size1.Width)
			size = Me.ImageList7.ImageSize
			imageSize = New System.Drawing.Size(num7, Module1.screenadaptY(size.Height))
			imageList7.ImageSize = imageSize
			size1 = New System.Drawing.Size(MyProject.Application.largeurscreen, MyProject.Application.hauteurscreen)
			Me.MaximumSize = size1
			size1 = New System.Drawing.Size(MyProject.Application.largeurscreen, MyProject.Application.hauteurscreen)
			Me.Size = size1
			Dim point As System.Drawing.Point = New System.Drawing.Point(0, 0)
			Me.Location = point
			Try
				enumerator = Me.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
					Dim obj As Object = objectValue
					Dim font(0) As Object
					size1 = New System.Drawing.Size(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(obj, Nothing, "width", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(obj, Nothing, "height", New Object(-1) {}, Nothing, Nothing, Nothing))))
					font(0) = size1
					NewLateBinding.LateSet(obj, Nothing, "size", font, Nothing, Nothing)
					ReDim font(0)
					point = New System.Drawing.Point(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "x", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing))))
					font(0) = point
					NewLateBinding.LateSet(obj, Nothing, "location", font, Nothing, Nothing)
					font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing))))) }
					NewLateBinding.LateSet(obj, Nothing, "font", font, Nothing, Nothing)
					obj = Nothing
					If (TypeOf objectValue Is System.Windows.Forms.Panel) Then
						Try
							enumerator1 = DirectCast(NewLateBinding.LateGet(objectValue, Nothing, "Controls", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator()
							While enumerator1.MoveNext()
								Dim objectValue1 As Object = RuntimeHelpers.GetObjectValue(enumerator1.Current)
								ReDim font(0)
								size1 = New System.Drawing.Size(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(objectValue1, Nothing, "width", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(objectValue1, Nothing, "height", New Object(-1) {}, Nothing, Nothing, Nothing))))
								font(0) = size1
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
					If (TypeOf objectValue Is TabControl) Then
						Try
							enumerator2 = DirectCast(NewLateBinding.LateGet(objectValue, Nothing, "Controls", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator()
							While enumerator2.MoveNext()
								Dim obj1 As Object = RuntimeHelpers.GetObjectValue(enumerator2.Current)
								ReDim font(0)
								size1 = New System.Drawing.Size(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(obj1, Nothing, "width", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(obj1, Nothing, "height", New Object(-1) {}, Nothing, Nothing, Nothing))))
								font(0) = size1
								NewLateBinding.LateSet(obj1, Nothing, "size", font, Nothing, Nothing)
								ReDim font(0)
								point = New System.Drawing.Point(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj1, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "x", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj1, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing))))
								font(0) = point
								NewLateBinding.LateSet(obj1, Nothing, "location", font, Nothing, Nothing)
								font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj1, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj1, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing))))) }
								NewLateBinding.LateSet(obj1, Nothing, "font", font, Nothing, Nothing)
								obj1 = Nothing
							End While
						Finally
							If (TypeOf enumerator2 Is IDisposable) Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
					If (Not TypeOf objectValue Is myGroupBox) Then
						Continue While
					End If
					Try
						enumerator3 = DirectCast(NewLateBinding.LateGet(objectValue, Nothing, "Controls", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator()
						While enumerator3.MoveNext()
							Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(enumerator3.Current)
							Dim obj2 As Object = objectValue2
							ReDim font(0)
							size1 = New System.Drawing.Size(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(obj2, Nothing, "width", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(obj2, Nothing, "height", New Object(-1) {}, Nothing, Nothing, Nothing))))
							font(0) = size1
							NewLateBinding.LateSet(obj2, Nothing, "size", font, Nothing, Nothing)
							ReDim font(0)
							point = New System.Drawing.Point(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "x", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing))))
							font(0) = point
							NewLateBinding.LateSet(obj2, Nothing, "location", font, Nothing, Nothing)
							font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing))))) }
							NewLateBinding.LateSet(obj2, Nothing, "font", font, Nothing, Nothing)
							obj2 = Nothing
							If (Not TypeOf objectValue2 Is myGroupBox) Then
								Continue While
							End If
							Try
								enumerator4 = DirectCast(NewLateBinding.LateGet(objectValue2, Nothing, "controls", New Object(-1) {}, Nothing, Nothing, Nothing), IEnumerable).GetEnumerator()
								While enumerator4.MoveNext()
									Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(enumerator4.Current)
									ReDim font(0)
									size1 = New System.Drawing.Size(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(objectValue3, Nothing, "width", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(objectValue3, Nothing, "height", New Object(-1) {}, Nothing, Nothing, Nothing))))
									font(0) = size1
									NewLateBinding.LateSet(objectValue3, Nothing, "size", font, Nothing, Nothing)
									ReDim font(0)
									point = New System.Drawing.Point(Module1.screenadaptX(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "x", New Object(-1) {}, Nothing, Nothing, Nothing))), Module1.screenadaptY(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "location", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "y", New Object(-1) {}, Nothing, Nothing, Nothing))))
									font(0) = point
									NewLateBinding.LateSet(objectValue3, Nothing, "location", font, Nothing, Nothing)
									font = New Object() { New System.Drawing.Font(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "name", New Object(-1) {}, Nothing, Nothing, Nothing)), CSng(Module1.screenadaptfont(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "size", New Object(-1) {}, Nothing, Nothing, Nothing))))) }
									NewLateBinding.LateSet(objectValue3, Nothing, "font", font, Nothing, Nothing)
									objectValue3 = Nothing
								End While
							Finally
								If (TypeOf enumerator4 Is IDisposable) Then
									TryCast(enumerator4, IDisposable).Dispose()
								End If
							End Try
						End While
					Finally
						If (TypeOf enumerator3 Is IDisposable) Then
							TryCast(enumerator3, IDisposable).Dispose()
						End If
					End Try
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.ToolStripStatusLabel1.Font = New System.Drawing.Font(Me.ToolStripStatusLabel1.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(Me.ToolStripStatusLabel1.Font.Size))))), FontStyle.Bold)
			Dim panel As System.Windows.Forms.Panel = Me.Panel
			Dim str1 As String = String.Concat(Application.StartupPath, "\Pellecurseur.cur")
			panel.Cursor = New System.Windows.Forms.Cursor(FormPasPas.LoadCursorFromFile(str1))
			Me.CacherLaBarreDeTâcheToolStripMenuItem.Checked = False
			Me.Bordannee0.BorderColor = Color.Green
			Me.PictureBoxannee0.BackgroundImage.Tag = 2
			Me.Bordannee1.BorderColor = Color.Silver
			Me.PictureBoxannee1.BackgroundImage.Tag = 1
			Me.Bordannee2.BorderColor = Color.Silver
			Me.PictureBoxannee2.BackgroundImage.Tag = 1
			Me.indexselectleg = 1
			Me.indexselectsurf = 1
			Me.indexselectamen = 1
			Me.nbchecklarge = 5
			Me.nbrcellules = 16
			Me.cotecelluleX = Module1.screenadaptX(30)
			Me.cotecelluleY = Module1.screenadaptY(30)
			Me.cotecelluleX2 = Module1.screenadaptX(22)
			Me.cotecelluleY2 = Module1.screenadaptY(22)
			Me.Affichage_grilles()
			Me.Chargement_radiobutton(Module1.PATHS(14))
			Me.Chargement_radiobutton(Module1.PATHS(15))
			Me.Chargement_radiobutton_listeleg()
			Module1.loadmoon = False
			Module1.loadcombass = False
			Module1.loadcombrot1 = False
			Module1.loadcombrot2 = False
			Module1.loadcal = False
			Module1.loadbddrot = False
			Module1.loadbddass = False
			Module1.loadbiblio = False
			Module1.loadbilan = False
			Module1.loadhelp = False
			Module1.loadgarden = False
			Module1.loadactiv = False
			Module1.loadbddfiche = False
			Dim panelonglet As System.Windows.Forms.Panel = Me.Panelonglet
			point = New System.Drawing.Point(0 - Module1.screenadaptX(97), Module1.screenadaptY(25))
			panelonglet.Location = point
			panelonglet.BackgroundImage = Resources.Tiroir
			panelonglet.SendToBack()
			panelonglet = Nothing
			Dim infobullegrille As ToolTip = Me.Infobullegrille
			infobullegrille.SetToolTip(Me.Button2, "Calculatrice avancée")
			infobullegrille.SetToolTip(Me.Button3, "Calendrier lunaire")
			infobullegrille.SetToolTip(Me.Button4, "Schéma de mon jardin")
			infobullegrille.SetToolTip(Me.Button5, "Gestion financière de mon jardin")
			infobullegrille.SetToolTip(Me.Button6, "Photos de mon jardin")
			infobullegrille.SetToolTip(Me.Button7, "Bibliothèque en ligne")
			infobullegrille = Nothing
			If (Not Me.activation) Then
				Dim toolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem() With
				{
					.Text = "Soutenir"
				}
				Dim formPasPa As FormPasPas = Me
				AddHandler toolStripMenuItem.Click,  New EventHandler(AddressOf formPasPa.Buttonactiv_Click)
				Me.MenuPrinc.Items.Add(toolStripMenuItem)
			End If
			If (Not Me.activation) Then
				Me.Buttonsauvegarder.Enabled = False
				Me.Buttonenregistrer.Enabled = False
				Me.Buttonimporter.Enabled = False
			End If
			Me.Timerinstallmsg.Start()
		End Sub

		Private Sub PictureBox0_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Bordannee0.BorderColor = Color.Green
			Dim pictureBoxannee0 As PictureBox = Me.PictureBoxannee0
			If (Operators.ConditionalCompareObjectNotEqual(pictureBoxannee0.BackgroundImage.Tag, 0, False)) Then
				pictureBoxannee0.BackgroundImage = Resources.Fondsvplc2
				pictureBoxannee0.BackgroundImage.Tag = 2
			End If
			pictureBoxannee0 = Nothing
			Me.Bordannee0.Refresh()
			If (Me.Bordannee1.BorderColor = Color.Green) Then
				Me.Bordannee1.BorderColor = Color.Silver
				If (Operators.ConditionalCompareObjectEqual(Me.PictureBoxannee1.BackgroundImage.Tag, 2, False)) Then
					Me.PictureBoxannee1.BackgroundImage = Resources.Fondsvplc
					Me.PictureBoxannee1.BackgroundImage.Tag = 1
				End If
				Me.Bordannee1.Refresh()
			End If
			If (Me.Bordannee2.BorderColor = Color.Green) Then
				Me.Bordannee2.BorderColor = Color.Silver
				If (Operators.ConditionalCompareObjectEqual(Me.PictureBoxannee2.BackgroundImage.Tag, 2, False)) Then
					Me.PictureBoxannee2.BackgroundImage = Resources.Fondsvplc
					Me.PictureBoxannee2.BackgroundImage.Tag = 1
				End If
				Me.Bordannee2.Refresh()
			End If
			Me.Chargement(String.Concat(Module1.PATHS(17), "\annee0.txt"))
			Me.ROTATIONGRILLE2()
		End Sub

		Private Sub PictureBoxannee1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Bordannee1.BorderColor = Color.Green
			Dim pictureBoxannee1 As PictureBox = Me.PictureBoxannee1
			If (Operators.ConditionalCompareObjectNotEqual(pictureBoxannee1.BackgroundImage.Tag, 0, False)) Then
				pictureBoxannee1.BackgroundImage = Resources.Fondsvplc2
				pictureBoxannee1.BackgroundImage.Tag = 2
			End If
			pictureBoxannee1 = Nothing
			Me.Bordannee1.Refresh()
			If (Me.Bordannee0.BorderColor = Color.Green) Then
				Me.Bordannee0.BorderColor = Color.Silver
				If (Operators.ConditionalCompareObjectEqual(Me.PictureBoxannee0.BackgroundImage.Tag, 2, False)) Then
					Me.PictureBoxannee0.BackgroundImage = Resources.Fondsvplc
					Me.PictureBoxannee0.BackgroundImage.Tag = 1
				End If
				Me.Bordannee0.Refresh()
			End If
			If (Me.Bordannee2.BorderColor = Color.Green) Then
				Me.Bordannee2.BorderColor = Color.Silver
				If (Operators.ConditionalCompareObjectEqual(Me.PictureBoxannee2.BackgroundImage.Tag, 2, False)) Then
					Me.PictureBoxannee2.BackgroundImage = Resources.Fondsvplc
					Me.PictureBoxannee2.BackgroundImage.Tag = 1
				End If
				Me.Bordannee2.Refresh()
			End If
			Me.Chargement(String.Concat(Module1.PATHS(17), "\annee1.txt"))
			Me.ROTATIONGRILLE2()
		End Sub

		Private Sub PictureBoxannee2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Bordannee2.BorderColor = Color.Green
			Dim pictureBoxannee2 As PictureBox = Me.PictureBoxannee2
			If (Operators.ConditionalCompareObjectNotEqual(pictureBoxannee2.BackgroundImage.Tag, 0, False)) Then
				pictureBoxannee2.BackgroundImage = Resources.Fondsvplc2
				pictureBoxannee2.BackgroundImage.Tag = 2
			End If
			pictureBoxannee2 = Nothing
			Me.Bordannee2.Refresh()
			If (Me.Bordannee1.BorderColor = Color.Green) Then
				Me.Bordannee1.BorderColor = Color.Silver
				If (Operators.ConditionalCompareObjectEqual(Me.PictureBoxannee1.BackgroundImage.Tag, 2, False)) Then
					Me.PictureBoxannee1.BackgroundImage = Resources.Fondsvplc
					Me.PictureBoxannee1.BackgroundImage.Tag = 1
				End If
				Me.Bordannee1.Refresh()
			End If
			If (Me.Bordannee0.BorderColor = Color.Green) Then
				Me.Bordannee0.BorderColor = Color.Silver
				If (Operators.ConditionalCompareObjectEqual(Me.PictureBoxannee0.BackgroundImage.Tag, 2, False)) Then
					Me.PictureBoxannee0.BackgroundImage = Resources.Fondsvplc
					Me.PictureBoxannee0.BackgroundImage.Tag = 1
				End If
				Me.Bordannee0.Refresh()
			End If
			Me.Chargement(String.Concat(Module1.PATHS(17), "\annee2.txt"))
			Me.ROTATIONGRILLE2()
		End Sub

		Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CaptureScreen()
			Me.PrintDocument1.Print()
		End Sub

		Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			e.Graphics.DrawImage(Me.memoryImage, 0, 0)
		End Sub

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub QuitterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			ProjectData.EndApp()
		End Sub

		Private Sub radiobuttonamenclick(ByVal sender As RadioButton, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Try
				enumerator = Me.TabPage3.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
					Dim transparent() As Object = { Color.Transparent }
					NewLateBinding.LateSet(objectValue, Nothing, "BackColor", transparent, Nothing, Nothing)
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			sender.BackColor = Color.SkyBlue
			Me.indexselectamen = Conversions.ToInteger(sender.Tag)
		End Sub

		Private Sub radiobuttonlegclick(ByVal sender As RadioButton, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Dim color As System.Drawing.Color = New System.Drawing.Color()
			Dim color1 As System.Drawing.Color
			Try
				enumerator = Me.TabPage1.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
					Dim obj As Object = NewLateBinding.LateGet(objectValue, Nothing, "backcolor", New Object(-1) {}, Nothing, Nothing, Nothing)
					If (obj IsNot Nothing) Then
						color1 = DirectCast(obj, System.Drawing.Color)
					Else
						color1 = color
					End If
					If (color1 <> System.Drawing.Color.SkyBlue) Then
						Continue While
					End If
					Dim white() As Object = { System.Drawing.Color.White }
					NewLateBinding.LateSet(objectValue, Nothing, "backcolor", white, Nothing, Nothing)
					sender.BackColor = System.Drawing.Color.SkyBlue
					Me.indexselectleg = Conversions.ToInteger(sender.Tag)
					Me.BackgroundWorker1.CancelAsync()
					Me.Panel.Enabled = False
					Me.BackgroundWorker1.RunWorkerAsync()
					Me.Panel.Enabled = True
					Me.ROTATIONGRILLE2()
					Return
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			sender.BackColor = System.Drawing.Color.SkyBlue
			Me.indexselectleg = Conversions.ToInteger(sender.Tag)
			Me.BackgroundWorker1.CancelAsync()
			Me.Panel.Enabled = False
			Me.BackgroundWorker1.RunWorkerAsync()
			Me.Panel.Enabled = True
			Me.ROTATIONGRILLE2()
		End Sub

		Private Sub radiobuttonsurfclick(ByVal sender As RadioButton, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Try
				enumerator = Me.TabPage2.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(enumerator.Current)
					Dim white() As Object = { Color.White }
					NewLateBinding.LateSet(objectValue, Nothing, "BackColor", white, Nothing, Nothing)
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			sender.BackColor = Color.SkyBlue
			Me.indexselectsurf = Conversions.ToInteger(sender.Tag)
		End Sub

		Private Sub RenommerUnLégumeExistantToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.WinInputbox = New FormInputbox()
			Dim winInputbox As FormInputbox = Me.WinInputbox
			winInputbox.Text = "Renommer une plante existante..."
			winInputbox.Label1.Text = "Respectez la syntaxe:"
			winInputbox.Button1.Text = "Renommer"
			winInputbox.Button1.BackColor = Color.Gold
			winInputbox.Button1.FlatAppearance.BorderColor = Color.Goldenrod
			winInputbox.ShowDialog()
			winInputbox = Nothing
		End Sub

		Private Sub RESET_GrilleA()
			Dim num As Integer = Me.nbrcellules - 1
			Dim num1 As Integer = 0
			Do
				Dim num2 As Integer = Me.nbrcellules - 1
				Dim num3 As Integer = 0
				Do
					Dim khaki As SVPLCApplication.PictureBox1 = Me.grille(num1, num3)
					khaki.BackColor = Color.Khaki
					khaki.BackgroundImage = Nothing
					khaki.Indexa = -1
					khaki.Indexs = -1
					khaki.Indexp = -1
					khaki.Image = Nothing
					khaki.Tag = "000"
					khaki.Tagfix = "000"
					khaki = Nothing
					num3 = num3 + 1
				Loop While num3 <= num2
				num1 = num1 + 1
			Loop While num1 <= num
			Me.Infobullegrille.RemoveAll()
			Me.Assopos.Text = Conversions.ToString(0)
			Me.Assoneg.Text = Conversions.ToString(0)
			Me.Assoechelle.Text = Conversions.ToString(0)
			Me.ROTATIONGRILLE2()
		End Sub

		Private Sub RESET_grilleB()
			Dim num As Integer = Me.nbrcellules - 1
			Dim num1 As Integer = 0
			Do
				Dim num2 As Integer = Me.nbrcellules - 1
				Dim num3 As Integer = 0
				Do
					Dim khaki As SVPLCApplication.PictureBox1 = Me.grille2(num1, num3)
					khaki.BackColor = Color.Khaki
					khaki.Tag = Nothing
					khaki = Nothing
					num3 = num3 + 1
				Loop While num3 <= num2
				num1 = num1 + 1
			Loop While num1 <= num
			Me.Infobullegrille2.RemoveAll()
			Me.Rotechelle.Text = Conversions.ToString(0)
			Me.Rotpos.Text = Conversions.ToString(0)
			Me.Rotneg.Text = Conversions.ToString(0)
		End Sub

		Private Sub ROTATIONGRILLE2()
			If (Me.Bordannee0.BorderColor = Color.Green) Then
				If (Not File.Exists(String.Concat(Module1.PATHS(17), "\annee2.txt"))) Then
					Me.Empreinte_grilleA()
				Else
					Me.Afficher_les_rotations(String.Concat(Module1.PATHS(17), "\annee2.txt"), String.Concat(Module1.PATHS(17), "\annee0.txt"))
				End If
			End If
			If (Me.Bordannee1.BorderColor = Color.Green) Then
				If (Not File.Exists(String.Concat(Module1.PATHS(17), "\annee0.txt"))) Then
					Me.Empreinte_grilleA()
				Else
					Me.Afficher_les_rotations(String.Concat(Module1.PATHS(17), "\annee0.txt"), String.Concat(Module1.PATHS(17), "\annee1.txt"))
				End If
			End If
			If (Me.Bordannee2.BorderColor = Color.Green) Then
				If (Not File.Exists(String.Concat(Module1.PATHS(17), "\annee1.txt"))) Then
					Me.Empreinte_grilleA()
				Else
					Me.Afficher_les_rotations(String.Concat(Module1.PATHS(17), "\annee1.txt"), String.Concat(Module1.PATHS(17), "\annee2.txt"))
				End If
			End If
		End Sub

		Private Sub rotbdd()
			Me.lignefichiertxt = Nothing
			Me.nbrligne = 0
			Try
				Me.lecture0 = New StreamReader(Module1.PATHS(2), Encoding.[Default])
				Me.compt = 0
				While Me.lecture0.Peek() <> -1
					Me.lignefichiertxt = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(Me.lignefichiertxt, Array), New String(Me.compt + 1 - 1) {}), String())
					Me.lignefichiertxt(Me.compt) = Me.lecture0.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Me.nbrligne = Me.compt - 1
				Me.lecture0.Close()
				Dim num As Integer = Me.nbrligne - 2
				Dim num1 As Integer = 0
				Do
					Me.lignefichiertxt(num1) = Conversions.ToString(Module1.indexlegume(Me.lignefichiertxt(num1)))
					Me.lignefichiertxt(num1 + 1) = Conversions.ToString(Module1.indexlegume(Me.lignefichiertxt(num1 + 1)))
					If (Operators.CompareString(Me.lignefichiertxt(num1 + 2), "n", False) = 0) Then
						Me.lignefichiertxt(num1 + 2) = Conversions.ToString(-1)
					End If
					If (Operators.CompareString(Me.lignefichiertxt(num1 + 2), "o", False) = 0) Then
						Me.lignefichiertxt(num1 + 2) = Conversions.ToString(1)
					End If
					num1 = num1 + 3
				Loop While num1 <= num
				Dim num2 As Integer = Me.nbrligne - 2
				For i As Integer = 0 To num2 Step 3
					If (Conversions.ToDouble(Me.lignefichiertxt(i)) <> -1 AndAlso Conversions.ToDouble(Me.lignefichiertxt(i + 1)) <> -1) Then
						If (Module1.Base_de_données_rotations(Conversions.ToInteger(Me.lignefichiertxt(i)), Conversions.ToInteger(Me.lignefichiertxt(i + 1))) = 0) Then
							Module1.Base_de_données_rotations(Conversions.ToInteger(Me.lignefichiertxt(i)), Conversions.ToInteger(Me.lignefichiertxt(i + 1))) = Conversions.ToInteger(Me.lignefichiertxt(i + 2))
							Module1.Base_de_données_rotationsstr(Conversions.ToInteger(Me.lignefichiertxt(i)), Conversions.ToInteger(Me.lignefichiertxt(i + 1))) = "0BDD"
						ElseIf (CDbl(Module1.Base_de_données_rotations(Conversions.ToInteger(Me.lignefichiertxt(i)), Conversions.ToInteger(Me.lignefichiertxt(i + 1)))) = -Conversions.ToDouble(Me.lignefichiertxt(i + 2))) Then
							Me.gestionconflitrot(Conversions.ToInteger(Me.lignefichiertxt(i)), Conversions.ToInteger(Me.lignefichiertxt(i + 1)), "0BDD", CInt(Math.Round(-Conversions.ToDouble(Me.lignefichiertxt(i + 2)))))
						End If
					End If
				Next

			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				Me.Msgboxperso("Erreur chargement base de données rotations !", "Erreur")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub rotfam()
			Dim length As Integer = CInt(Module1.FAMILLE.Length) - 1
			For i As Integer = 0 To length Step 1
				Dim [integer] As Integer() = Nothing
				ReDim [integer](0)
				Dim num As Integer = 0
				Dim num1 As Integer = Module1.nbrlignecal - 1
				Dim num2 As Integer = 1
				Do
					If (Operators.CompareString(Module1.Base_de_données_calendrier(num2), Module1.FAMILLE(i), False) = 0) Then
						[integer] = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast([integer], Array), New Integer(num + 1 - 1) {}), Integer())
						[integer](num) = Conversions.ToInteger(Module1.indexlegume(Module1.Base_de_données_calendrier(num2 - 1)))
						num = num + 1
					End If
					num2 = num2 + 9
				Loop While num2 <= num1
				If (num > 1) Then
					Dim num3 As Integer = num - 1
					For j As Integer = 0 To num3 Step 1
						If (num - 1 >= j + 1) Then
							Dim num4 As Integer = j + 1
							Dim num5 As Integer = num - 1
							For k As Integer = num4 To num5 Step 1
								If ([integer](j) > -1 AndAlso [integer](k) > -1) Then
									If (Module1.Base_de_données_rotations([integer](j), [integer](k)) <> 1) Then
										Module1.Base_de_données_rotations([integer](j), [integer](k)) = -1
										Module1.Base_de_données_rotationsstr([integer](j), [integer](k)) = "0Famille"
									Else
										Me.gestionconflitrot([integer](j), [integer](k), "0Famille", 1)
									End If
									If (Module1.Base_de_données_rotations([integer](k), [integer](j)) <> 1) Then
										Module1.Base_de_données_rotations([integer](k), [integer](j)) = -1
										Module1.Base_de_données_rotationsstr([integer](k), [integer](j)) = "0Famille"
									Else
										Me.gestionconflitrot([integer](k), [integer](j), "0Famille", 1)
									End If
								End If
							Next

						End If
					Next

				End If
			Next

		End Sub

		Private Sub rottype()
			Dim numArray(0) As Integer
			Dim numArray1(0) As Integer
			Dim numArray2(0) As Integer
			numArray = Nothing
			numArray1 = Nothing
			numArray2 = Nothing
			Dim num As Integer = 0
			Dim num1 As Integer = 0
			Dim num2 As Integer = 0
			Dim num3 As Integer = Module1.nbrlignecal - 1
			Dim num4 As Integer = 6
			Do
				Dim [integer] As Integer = Conversions.ToInteger(Module1.indexlegume(Module1.Base_de_données_calendrier(num4 - 6)))
				Dim baseDeDonnéesCalendrier As String = Module1.Base_de_données_calendrier(num4)
				If (Operators.CompareString(baseDeDonnéesCalendrier, Module1.TYPE(4), False) = 0 OrElse Operators.CompareString(baseDeDonnéesCalendrier, Module1.TYPE(5), False) = 0) Then
					If ([integer] <> -1) Then
						numArray = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(numArray, Array), New Integer(num + 1 - 1) {}), Integer())
						numArray(num) = [integer]
						num = num + 1
					End If
				ElseIf (Operators.CompareString(baseDeDonnéesCalendrier, Module1.TYPE(7), False) <> 0 AndAlso Operators.CompareString(baseDeDonnéesCalendrier, Module1.TYPE(3), False) <> 0) Then
					If (Operators.CompareString(baseDeDonnéesCalendrier, Module1.TYPE(6), False) = 0 AndAlso [integer] <> -1) Then
						numArray2 = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(numArray2, Array), New Integer(num2 + 1 - 1) {}), Integer())
						numArray2(num2) = [integer]
						num2 = num2 + 1
					End If
				ElseIf ([integer] <> -1) Then
					numArray1 = DirectCast(Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(DirectCast(numArray1, Array), New Integer(num1 + 1 - 1) {}), Integer())
					numArray1(num1) = [integer]
					num1 = num1 + 1
				End If
				num4 = num4 + 9
			Loop While num4 <= num3
			If (num > 0 AndAlso num1 > 0) Then
				Dim num5 As Integer = num - 1
				For i As Integer = 0 To num5 Step 1
					Dim num6 As Integer = num1 - 1
					For j As Integer = 0 To num6 Step 1
						If (Module1.Base_de_données_rotations(numArray(i), numArray1(j)) <> -1) Then
							Module1.Base_de_données_rotations(numArray(i), numArray1(j)) = 1
							Module1.Base_de_données_rotationsstr(numArray(i), numArray1(j)) = "0Type"
						Else
							Me.gestionconflitrot(numArray(i), numArray1(j), "0Type", -1)
						End If
					Next

				Next

			End If
			If (num1 > 0 AndAlso num2 > 0) Then
				Dim num7 As Integer = num1 - 1
				For k As Integer = 0 To num7 Step 1
					Dim num8 As Integer = num2 - 1
					For l As Integer = 0 To num8 Step 1
						If (Module1.Base_de_données_rotations(numArray1(k), numArray2(l)) <> -1) Then
							Module1.Base_de_données_rotations(numArray1(k), numArray2(l)) = 1
							Module1.Base_de_données_rotationsstr(numArray1(k), numArray2(l)) = "0Type"
						Else
							Me.gestionconflitrot(numArray1(k), numArray2(l), "0Type", -1)
						End If
					Next

				Next

			End If
			If (num2 > 0 AndAlso num > 0) Then
				Dim num9 As Integer = num2 - 1
				For m As Integer = 0 To num9 Step 1
					Dim num10 As Integer = num - 1
					For n As Integer = 0 To num10 Step 1
						If (Module1.Base_de_données_rotations(numArray2(m), numArray(n)) <> -1) Then
							Module1.Base_de_données_rotations(numArray2(m), numArray(n)) = 1
							Module1.Base_de_données_rotationsstr(numArray2(m), numArray(n)) = "0Type"
						Else
							Me.gestionconflitrot(numArray2(m), numArray(n), "0Type", -1)
						End If
					Next

				Next

			End If
		End Sub

		Private Sub SAUVEGARDER(ByVal sender As Object, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Dim enumerator1 As IEnumerator = Nothing
			Dim num As Integer = Me.nbrcellules - 1
			Dim num1 As Integer = 0
			Do
				Dim num2 As Integer = Me.nbrcellules - 1
				Dim num3 As Integer = 0
				Do
					If (Me.grille(num1, num3).Indexp = -1 AndAlso Me.grille(num1, num3).Indexa = -1) Then
						Me.grille(num1, num3).Tag = "000"
						Me.grille(num1, num3).Image = Nothing
					End If
					num3 = num3 + 1
				Loop While num3 <= num2
				num1 = num1 + 1
			Loop While num1 <= num
			Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.Panel.Width, Me.Panel.Height)
			Dim panel As System.Windows.Forms.Panel = Me.Panel
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.Panel.Width, Me.Panel.Height)
			panel.DrawToBitmap(bitmap, rectangle)
			Me.Ecriture = New StreamWriter(String.Concat(Module1.PATHS(17), "\conf.txt"), False, Encoding.[Default])
			Dim num4 As Integer = Me.nbrcellules - 1
			Dim num5 As Integer = 0
			Do
				Dim num6 As Integer = Me.nbrcellules - 1
				Dim num7 As Integer = 0
				Do
					Me.Ecriture.WriteLine(num5)
					Me.Ecriture.WriteLine(num7)
					If (Me.grille(num5, num7).Indexp = -1) Then
						Me.Ecriture.WriteLine("")
					Else
						Me.Ecriture.WriteLine(Module1.listelégumes(Me.grille(num5, num7).Indexp))
					End If
					If (Me.grille(num5, num7).Indexs = -1) Then
						Me.Ecriture.WriteLine("")
					Else
						Try
							enumerator = Me.TabPage2.Controls.GetEnumerator()
							While enumerator.MoveNext()
								Dim current As System.Windows.Forms.RadioButton = DirectCast(enumerator.Current, System.Windows.Forms.RadioButton)
								If (Not Operators.ConditionalCompareObjectEqual(current.Tag, Me.grille(num5, num7).Indexs + 1, False)) Then
									Continue While
								End If
								Me.Ecriture.WriteLine(current.Text)
							End While
						Finally
							If (TypeOf enumerator Is IDisposable) Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					End If
					If (Me.grille(num5, num7).Indexa = -1) Then
						Me.Ecriture.WriteLine("")
					Else
						Try
							enumerator1 = Me.TabPage3.Controls.GetEnumerator()
							While enumerator1.MoveNext()
								Dim radioButton As System.Windows.Forms.RadioButton = DirectCast(enumerator1.Current, System.Windows.Forms.RadioButton)
								If (Not Operators.ConditionalCompareObjectEqual(radioButton.Tag, Me.grille(num5, num7).Indexa + 1, False)) Then
									Continue While
								End If
								Me.Ecriture.WriteLine(radioButton.Text)
							End While
						Finally
							If (TypeOf enumerator1 Is IDisposable) Then
								TryCast(enumerator1, IDisposable).Dispose()
							End If
						End Try
					End If
					If (Me.grille(num5, num7).Tagfix Is Nothing) Then
						Me.Ecriture.WriteLine("")
					Else
						Me.Ecriture.WriteLine(Me.grille(num5, num7).Tagfix)
					End If
					num7 = num7 + 1
				Loop While num7 <= num6
				num5 = num5 + 1
			Loop While num5 <= num4
			Me.Ecriture.Close()
			If (Me.Bordannee0.BorderColor = Color.Green) Then
				bitmap.Save(String.Concat(Module1.PATHS(17), "\annee0.bmp"))
				If (MyProject.Computer.FileSystem.FileExists(String.Concat(Module1.PATHS(17), "\annee0.txt"))) Then
					MyProject.Computer.FileSystem.DeleteFile(String.Concat(Module1.PATHS(17), "\annee0.txt"))
				End If
				File.Copy(String.Concat(Module1.PATHS(17), "\conf.txt"), String.Concat(Module1.PATHS(17), "\annee0.txt"))
				Me.PictureBoxannee0.BackgroundImage = bitmap
				Me.PictureBoxannee0.BackgroundImage.Tag = 0
			End If
			If (Me.Bordannee1.BorderColor = Color.Green) Then
				bitmap.Save(String.Concat(Module1.PATHS(17), "\annee1.bmp"))
				If (MyProject.Computer.FileSystem.FileExists(String.Concat(Module1.PATHS(17), "\annee1.txt"))) Then
					MyProject.Computer.FileSystem.DeleteFile(String.Concat(Module1.PATHS(17), "\annee1.txt"))
				End If
				File.Copy(String.Concat(Module1.PATHS(17), "\conf.txt"), String.Concat(Module1.PATHS(17), "\annee1.txt"))
				Me.PictureBoxannee1.BackgroundImage = bitmap
				Me.PictureBoxannee1.BackgroundImage.Tag = 0
			End If
			If (Me.Bordannee2.BorderColor = Color.Green) Then
				bitmap.Save(String.Concat(Module1.PATHS(17), "\annee2.bmp"))
				If (MyProject.Computer.FileSystem.FileExists(String.Concat(Module1.PATHS(17), "\annee2.txt"))) Then
					MyProject.Computer.FileSystem.DeleteFile(String.Concat(Module1.PATHS(17), "\annee2.txt"))
				End If
				File.Copy(String.Concat(Module1.PATHS(17), "\conf.txt"), String.Concat(Module1.PATHS(17), "\annee2.txt"))
				Me.PictureBoxannee2.BackgroundImage = bitmap
				Me.PictureBoxannee2.BackgroundImage.Tag = 0
			End If
		End Sub

		<DllImport("user32", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)>
		Public Shared Function SetWindowPos(ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
		End Function

		Private Sub showonglet()
			Dim panelonglet As System.Windows.Forms.Panel = Me.Panelonglet
			panelonglet.BackgroundImage = Resources.Tiroir_transp
			panelonglet.BringToFront()
			Dim location As Point = Me.Panelonglet.Location
			panelonglet.Location = New Point(0, location.Y)
			panelonglet = Nothing
		End Sub

		Private Sub SupprimerUnLégumeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.WinInputbox = New FormInputbox()
			Dim winInputbox As FormInputbox = Me.WinInputbox
			winInputbox.Text = "Supprimer une plante..."
			winInputbox.Icon = Resources.moins
			winInputbox.Label1.Text = "Entrez le nom de la plante à supprimer des BDD:"
			winInputbox.Button1.Text = "Supprimer"
			winInputbox.Button1.BackColor = Color.Red
			winInputbox.Button1.FlatAppearance.BorderColor = Color.DarkRed
			winInputbox.ShowDialog()
			winInputbox = Nothing
		End Sub

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Timerinstallmsg_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.Timerinstallmsg.[Stop]()
			Select Case Me.installmsg
				Case 1
					Dim dialogResult As System.Windows.Forms.DialogResult = (New FormBienvenue()).ShowDialog()
					Exit Select
				Case 2
					Me.Msgboxperso(String.Concat("Il vous reste ", Conversions.ToString(Me.jrestant), " jours d'évaluation" & VbCrLf & "L'activation du logiciel vous donne accès à:" & VbCrLf & "- le Calcul de l'année +2" & VbCrLf & "- le Calendrier Lunaire intégral" & VbCrLf & "- la sauvegarde" & VbCrLf & "- l'impression" & VbCrLf & "- le Bilan Financier"), "Nombre de jours avant échéance")
					Exit Select
				Case 3
					Me.Msgboxperso("La période d'évaluation est arrivée à terme. Si vous souhaitez vous enregistrer, merci de cliquer sur ok", "Evaluation à terme")
					Me.Winpaypal = New Formpaypal()
					Me.Winpaypal.ShowDialog()
					ProjectData.EndApp()
					Exit Select
			End Select
			Me.Timerinstallmsg.Dispose()
		End Sub
	End Class
End Namespace