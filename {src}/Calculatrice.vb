Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports System.Linq
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class Calculatrice
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Panel")>
		Private _Panel As System.Windows.Forms.Panel

		<AccessedThroughProperty("Buttonpart")>
		Private _Buttonpart As Button

		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		<AccessedThroughProperty("Buttonpartaveccontrainte")>
		Private _Buttonpartaveccontrainte As Button

		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		<AccessedThroughProperty("Annee02")>
		Private _Annee02 As Label

		<AccessedThroughProperty("Annee01")>
		Private _Annee01 As Label

		<AccessedThroughProperty("Annee03")>
		Private _Annee03 As Label

		<AccessedThroughProperty("MenuPrinc")>
		Private _MenuPrinc As MenuStrip

		<AccessedThroughProperty("FichierMenu")>
		Private _FichierMenu As ToolStripMenuItem

		<AccessedThroughProperty("EnregistrerSousMenu")>
		Private _EnregistrerSousMenu As ToolStripMenuItem

		<AccessedThroughProperty("RésultatsMenu")>
		Private _RésultatsMenu As ToolStripMenuItem

		<AccessedThroughProperty("ResultatsAssociationMenu")>
		Private _ResultatsAssociationMenu As ToolStripMenuItem

		<AccessedThroughProperty("CheckBoxsupp")>
		Private _CheckBoxsupp As CheckBox

		<AccessedThroughProperty("AfficherCombinaisons0Menu")>
		Private _AfficherCombinaisons0Menu As ToolStripMenuItem

		<AccessedThroughProperty("ResetMenu")>
		Private _ResetMenu As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		<AccessedThroughProperty("Annee1")>
		Private _Annee1 As System.Windows.Forms.Panel

		<AccessedThroughProperty("Annee11")>
		Private _Annee11 As Label

		<AccessedThroughProperty("Annee13")>
		Private _Annee13 As Label

		<AccessedThroughProperty("Annee12")>
		Private _Annee12 As Label

		<AccessedThroughProperty("Annee23")>
		Private _Annee23 As Label

		<AccessedThroughProperty("Annee22")>
		Private _Annee22 As Label

		<AccessedThroughProperty("Annee21")>
		Private _Annee21 As Label

		<AccessedThroughProperty("Annee2")>
		Private _Annee2 As System.Windows.Forms.Panel

		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		<AccessedThroughProperty("StatutLabel")>
		Private _StatutLabel As ToolStripStatusLabel

		<AccessedThroughProperty("ImprimerMenu")>
		Private _ImprimerMenu As ToolStripMenuItem

		<AccessedThroughProperty("PrintDialog1")>
		Private _PrintDialog1 As PrintDialog

		<AccessedThroughProperty("PrintPreviewDialog1")>
		Private _PrintPreviewDialog1 As PrintPreviewDialog

		<AccessedThroughProperty("PrintDocument1")>
		Private _PrintDocument1 As PrintDocument

		<AccessedThroughProperty("PictureBoxcocc1")>
		Private _PictureBoxcocc1 As PictureBox

		<AccessedThroughProperty("PictureBoxpap")>
		Private _PictureBoxpap As PictureBox

		<AccessedThroughProperty("Légende")>
		Private _Légende As System.Windows.Forms.Panel

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("semis")>
		Private _semis As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("BackgroundWorkerannee0")>
		Private _BackgroundWorkerannee0 As BackgroundWorker

		<AccessedThroughProperty("Buttonreset")>
		Private _Buttonreset As Button

		<AccessedThroughProperty("Empecherredondance1Menu")>
		Private _Empecherredondance1Menu As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator2")>
		Private _ToolStripSeparator2 As ToolStripSeparator

		<AccessedThroughProperty("CalculerAnnee0Menu")>
		Private _CalculerAnnee0Menu As ToolStripMenuItem

		<AccessedThroughProperty("CalculerAnnee1Menu")>
		Private _CalculerAnnee1Menu As ToolStripMenuItem

		<AccessedThroughProperty("CalculerAnnee2Menu")>
		Private _CalculerAnnee2Menu As ToolStripMenuItem

		<AccessedThroughProperty("ToolStripSeparator3")>
		Private _ToolStripSeparator3 As ToolStripSeparator

		<AccessedThroughProperty("BackgroundWorkerannee1")>
		Private _BackgroundWorkerannee1 As BackgroundWorker

		<AccessedThroughProperty("BackgroundWorkerannee2")>
		Private _BackgroundWorkerannee2 As BackgroundWorker

		<AccessedThroughProperty("lblProgression")>
		Private _lblProgression As Label

		<AccessedThroughProperty("BilanMenu")>
		Private _BilanMenu As ToolStripMenuItem

		<AccessedThroughProperty("Empecherredondance2Menu")>
		Private _Empecherredondance2Menu As ToolStripMenuItem

		<AccessedThroughProperty("btnAnnee2")>
		Private _btnAnnee2 As Button

		<AccessedThroughProperty("btnAnnee1")>
		Private _btnAnnee1 As Button

		<AccessedThroughProperty("btnAnnee0")>
		Private _btnAnnee0 As Button

		<AccessedThroughProperty("AfficherCombinaisons1Menu")>
		Private _AfficherCombinaisons1Menu As ToolStripMenuItem

		<AccessedThroughProperty("AfficherCombinaisons2Menu")>
		Private _AfficherCombinaisons2Menu As ToolStripMenuItem

		<AccessedThroughProperty("GroupBoxPartitionnement")>
		Private _GroupBoxPartitionnement As myGroupBox

		<AccessedThroughProperty("GroupBoxcalculs")>
		Private _GroupBoxcalculs As myGroupBox

		<AccessedThroughProperty("GroupBoxlégumes")>
		Private _GroupBoxlégumes As myGroupBox

		<AccessedThroughProperty("GroupBoxcontraintes")>
		Private _GroupBoxcontraintes As myGroupBox

		<AccessedThroughProperty("GroupBoxannee0")>
		Private _GroupBoxannee0 As myGroupBox

		<AccessedThroughProperty("Annee0")>
		Private _Annee0 As System.Windows.Forms.Panel

		<AccessedThroughProperty("GroupBoxannee1")>
		Private _GroupBoxannee1 As myGroupBox

		<AccessedThroughProperty("GroupBoxannee2")>
		Private _GroupBoxannee2 As myGroupBox

		<AccessedThroughProperty("GroupBoxcalendrier")>
		Private _GroupBoxcalendrier As myGroupBox

		<AccessedThroughProperty("PictureBoxjardinier")>
		Private _PictureBoxjardinier As PictureBox

		Private grille As CheckBox(,)

		Private Légume As ComboBox(,)

		Private Légumecont As ComboBox(,)

		Private Résultatstab As Label(,)

		Private colonne12 As Label(,)

		Private ligne1 As Label()

		Private resultatcalendrier As Label(,)

		Private Capt As Bitmap

		Private trouv As Boolean

		Private Panelcalendrier As System.Windows.Forms.Panel

		Private largeur As Integer

		Private hauteur As Integer

		Private ran As Integer

		Private valeurprec As String

		Private valeurnouv As String

		Private L As List(Of String)

		Private calendrierselectionne As List(Of String)

		Private Hgrille As Integer

		Private Lgrille As Integer

		Private ComboX As Integer

		Private cotecelluleX As Integer

		Private cotecelluleY As Integer

		Private Mgauche As Integer

		Private Mhaut As Integer

		Private Llegcont As Integer

		Private Hmaxlegcont As Integer

		Private largcol As Integer

		Private longcol As Integer

		Private longcol1 As Integer

		Private CELLULES As Integer()

		Private FRONTIERES As Integer(,)

		Private NOTES1 As Integer()

		Private NOTES2 As Integer()

		Private NOTESROT1 As Integer()

		Private NOTESROT2 As Integer()

		Private dimnoterotfiltre As Integer()

		Private datacal As Integer()

		Private lignefichiertxt As String()

		Private COMBINAISONSFILTRE1 As String(,)

		Private COMBINAISONSFILTRE2 As String(,)

		Private rep As String

		Private ch As String

		Private parcelleok As Boolean

		Private contrainteok As Boolean

		Private bgcalinit As Boolean

		Private mousedownQ As Boolean

		Private nbrcellules As Integer

		Private rang As Integer

		Private chiffrecodecombinaisonchoisie As Integer()

		Private nbrsolutionaffichees As Integer

		Private nbrrotationaffichees As Integer

		Private traitab As Integer

		Private espaceentredeuxcellules As Integer

		Private compt As Integer

		Private note As Integer

		Private nbrlignecalselec As Integer

		Private WinBilan As FormBilan

		Private COMBASS As FormCO0

		Private COMBROT1 As FormCO1

		Private COMBROT2 As FormCO2

		Friend Overridable Property AfficherCombinaisons0Menu As ToolStripMenuItem
			Get
				Return Me._AfficherCombinaisons0Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.AfficherToutesLesCombinaisonsOptimiséesToolStripMenuItem1_Click)
				If (Me._AfficherCombinaisons0Menu IsNot Nothing) Then
					RemoveHandler Me._AfficherCombinaisons0Menu.Click,  eventHandler
				End If
				Me._AfficherCombinaisons0Menu = value
				If (Me._AfficherCombinaisons0Menu IsNot Nothing) Then
					AddHandler Me._AfficherCombinaisons0Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property AfficherCombinaisons1Menu As ToolStripMenuItem
			Get
				Return Me._AfficherCombinaisons1Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.AfficherToutesLesCombinaisonsOptimiséesDeLannée1ToolStripMenuItem_Click)
				If (Me._AfficherCombinaisons1Menu IsNot Nothing) Then
					RemoveHandler Me._AfficherCombinaisons1Menu.Click,  eventHandler
				End If
				Me._AfficherCombinaisons1Menu = value
				If (Me._AfficherCombinaisons1Menu IsNot Nothing) Then
					AddHandler Me._AfficherCombinaisons1Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property AfficherCombinaisons2Menu As ToolStripMenuItem
			Get
				Return Me._AfficherCombinaisons2Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.AfficherToutesLesCombinaisonsOptimiséesDeLannée2ToolStripMenuItem_Click)
				If (Me._AfficherCombinaisons2Menu IsNot Nothing) Then
					RemoveHandler Me._AfficherCombinaisons2Menu.Click,  eventHandler
				End If
				Me._AfficherCombinaisons2Menu = value
				If (Me._AfficherCombinaisons2Menu IsNot Nothing) Then
					AddHandler Me._AfficherCombinaisons2Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Annee0 As System.Windows.Forms.Panel
			Get
				Return Me._Annee0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Annee0 = value
			End Set
		End Property

		Friend Overridable Property Annee01 As Label
			Get
				Return Me._Annee01
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee01 = value
			End Set
		End Property

		Friend Overridable Property Annee02 As Label
			Get
				Return Me._Annee02
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee02 = value
			End Set
		End Property

		Friend Overridable Property Annee03 As Label
			Get
				Return Me._Annee03
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee03 = value
			End Set
		End Property

		Friend Overridable Property Annee1 As System.Windows.Forms.Panel
			Get
				Return Me._Annee1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Annee1 = value
			End Set
		End Property

		Friend Overridable Property Annee11 As Label
			Get
				Return Me._Annee11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee11 = value
			End Set
		End Property

		Friend Overridable Property Annee12 As Label
			Get
				Return Me._Annee12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee12 = value
			End Set
		End Property

		Friend Overridable Property Annee13 As Label
			Get
				Return Me._Annee13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee13 = value
			End Set
		End Property

		Friend Overridable Property Annee2 As System.Windows.Forms.Panel
			Get
				Return Me._Annee2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Annee2 = value
			End Set
		End Property

		Friend Overridable Property Annee21 As Label
			Get
				Return Me._Annee21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee21 = value
			End Set
		End Property

		Friend Overridable Property Annee22 As Label
			Get
				Return Me._Annee22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee22 = value
			End Set
		End Property

		Friend Overridable Property Annee23 As Label
			Get
				Return Me._Annee23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Annee23 = value
			End Set
		End Property

		Friend Overridable Property BackgroundWorkerannee0 As BackgroundWorker
			Get
				Return Me._BackgroundWorkerannee0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim runWorkerCompletedEventHandler As System.ComponentModel.RunWorkerCompletedEventHandler = New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf calculatrice.BackgroundWorker0_RunWorkerCompleted)
				Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
				Dim progressChangedEventHandler As System.ComponentModel.ProgressChangedEventHandler = New System.ComponentModel.ProgressChangedEventHandler(AddressOf calculatrice1.BackgroundWorker0_ProgressChanged)
				Dim calculatrice2 As SVPLCApplication.Calculatrice = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf calculatrice2.BackgroundWorker0_DoWork)
				If (Me._BackgroundWorkerannee0 IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorkerannee0.RunWorkerCompleted,  runWorkerCompletedEventHandler
					RemoveHandler Me._BackgroundWorkerannee0.ProgressChanged,  progressChangedEventHandler
					RemoveHandler Me._BackgroundWorkerannee0.DoWork,  doWorkEventHandler
				End If
				Me._BackgroundWorkerannee0 = value
				If (Me._BackgroundWorkerannee0 IsNot Nothing) Then
					AddHandler Me._BackgroundWorkerannee0.RunWorkerCompleted,  runWorkerCompletedEventHandler
					AddHandler Me._BackgroundWorkerannee0.ProgressChanged,  progressChangedEventHandler
					AddHandler Me._BackgroundWorkerannee0.DoWork,  doWorkEventHandler
				End If
			End Set
		End Property

		Private Overridable Property BackgroundWorkerannee1 As BackgroundWorker
			Get
				Return Me._BackgroundWorkerannee1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim runWorkerCompletedEventHandler As System.ComponentModel.RunWorkerCompletedEventHandler = New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf calculatrice.BackgroundWorkerannee1_RunWorkerCompleted)
				Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
				Dim progressChangedEventHandler As System.ComponentModel.ProgressChangedEventHandler = New System.ComponentModel.ProgressChangedEventHandler(AddressOf calculatrice1.BackgroundWorkerannee1_ProgressChanged)
				Dim calculatrice2 As SVPLCApplication.Calculatrice = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf calculatrice2.BackgroundWorkerannee1_DoWork)
				If (Me._BackgroundWorkerannee1 IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorkerannee1.RunWorkerCompleted,  runWorkerCompletedEventHandler
					RemoveHandler Me._BackgroundWorkerannee1.ProgressChanged,  progressChangedEventHandler
					RemoveHandler Me._BackgroundWorkerannee1.DoWork,  doWorkEventHandler
				End If
				Me._BackgroundWorkerannee1 = value
				If (Me._BackgroundWorkerannee1 IsNot Nothing) Then
					AddHandler Me._BackgroundWorkerannee1.RunWorkerCompleted,  runWorkerCompletedEventHandler
					AddHandler Me._BackgroundWorkerannee1.ProgressChanged,  progressChangedEventHandler
					AddHandler Me._BackgroundWorkerannee1.DoWork,  doWorkEventHandler
				End If
			End Set
		End Property

		Private Overridable Property BackgroundWorkerannee2 As BackgroundWorker
			Get
				Return Me._BackgroundWorkerannee2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim runWorkerCompletedEventHandler As System.ComponentModel.RunWorkerCompletedEventHandler = New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf calculatrice.BackgroundWorkerannee2_RunWorkerCompleted)
				Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
				Dim progressChangedEventHandler As System.ComponentModel.ProgressChangedEventHandler = New System.ComponentModel.ProgressChangedEventHandler(AddressOf calculatrice1.BackgroundWorkerannee2_ProgressChanged)
				Dim calculatrice2 As SVPLCApplication.Calculatrice = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf calculatrice2.BackgroundWorkerannee2_DoWork)
				If (Me._BackgroundWorkerannee2 IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorkerannee2.RunWorkerCompleted,  runWorkerCompletedEventHandler
					RemoveHandler Me._BackgroundWorkerannee2.ProgressChanged,  progressChangedEventHandler
					RemoveHandler Me._BackgroundWorkerannee2.DoWork,  doWorkEventHandler
				End If
				Me._BackgroundWorkerannee2 = value
				If (Me._BackgroundWorkerannee2 IsNot Nothing) Then
					AddHandler Me._BackgroundWorkerannee2.RunWorkerCompleted,  runWorkerCompletedEventHandler
					AddHandler Me._BackgroundWorkerannee2.ProgressChanged,  progressChangedEventHandler
					AddHandler Me._BackgroundWorkerannee2.DoWork,  doWorkEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property BilanMenu As ToolStripMenuItem
			Get
				Return Me._BilanMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.BilanMenu_Click)
				If (Me._BilanMenu IsNot Nothing) Then
					RemoveHandler Me._BilanMenu.Click,  eventHandler
				End If
				Me._BilanMenu = value
				If (Me._BilanMenu IsNot Nothing) Then
					AddHandler Me._BilanMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property btnAnnee0 As Button
			Get
				Return Me._btnAnnee0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.btnAnnee0_Click)
				If (Me._btnAnnee0 IsNot Nothing) Then
					RemoveHandler Me._btnAnnee0.Click,  eventHandler
				End If
				Me._btnAnnee0 = value
				If (Me._btnAnnee0 IsNot Nothing) Then
					AddHandler Me._btnAnnee0.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property btnAnnee1 As Button
			Get
				Return Me._btnAnnee1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.btnAnnee1_Click)
				If (Me._btnAnnee1 IsNot Nothing) Then
					RemoveHandler Me._btnAnnee1.Click,  eventHandler
				End If
				Me._btnAnnee1 = value
				If (Me._btnAnnee1 IsNot Nothing) Then
					AddHandler Me._btnAnnee1.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property btnAnnee2 As Button
			Get
				Return Me._btnAnnee2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.btnAnnee2_Click)
				If (Me._btnAnnee2 IsNot Nothing) Then
					RemoveHandler Me._btnAnnee2.Click,  eventHandler
				End If
				Me._btnAnnee2 = value
				If (Me._btnAnnee2 IsNot Nothing) Then
					AddHandler Me._btnAnnee2.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonpart As Button
			Get
				Return Me._Buttonpart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.Button2_Click)
				If (Me._Buttonpart IsNot Nothing) Then
					RemoveHandler Me._Buttonpart.Click,  eventHandler
				End If
				Me._Buttonpart = value
				If (Me._Buttonpart IsNot Nothing) Then
					AddHandler Me._Buttonpart.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonpartaveccontrainte As Button
			Get
				Return Me._Buttonpartaveccontrainte
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.Button5_Click)
				If (Me._Buttonpartaveccontrainte IsNot Nothing) Then
					RemoveHandler Me._Buttonpartaveccontrainte.Click,  eventHandler
				End If
				Me._Buttonpartaveccontrainte = value
				If (Me._Buttonpartaveccontrainte IsNot Nothing) Then
					AddHandler Me._Buttonpartaveccontrainte.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonreset As Button
			Get
				Return Me._Buttonreset
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.Buttonreset_Click)
				If (Me._Buttonreset IsNot Nothing) Then
					RemoveHandler Me._Buttonreset.Click,  eventHandler
				End If
				Me._Buttonreset = value
				If (Me._Buttonreset IsNot Nothing) Then
					AddHandler Me._Buttonreset.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CalculerAnnee0Menu As ToolStripMenuItem
			Get
				Return Me._CalculerAnnee0Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.CalculerAnnee0Menu_Click)
				If (Me._CalculerAnnee0Menu IsNot Nothing) Then
					RemoveHandler Me._CalculerAnnee0Menu.Click,  eventHandler
				End If
				Me._CalculerAnnee0Menu = value
				If (Me._CalculerAnnee0Menu IsNot Nothing) Then
					AddHandler Me._CalculerAnnee0Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CalculerAnnee1Menu As ToolStripMenuItem
			Get
				Return Me._CalculerAnnee1Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.CalculerAnnee1Menu_Click)
				If (Me._CalculerAnnee1Menu IsNot Nothing) Then
					RemoveHandler Me._CalculerAnnee1Menu.Click,  eventHandler
				End If
				Me._CalculerAnnee1Menu = value
				If (Me._CalculerAnnee1Menu IsNot Nothing) Then
					AddHandler Me._CalculerAnnee1Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CalculerAnnee2Menu As ToolStripMenuItem
			Get
				Return Me._CalculerAnnee2Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.CalculerAnnee2Menu_Click)
				If (Me._CalculerAnnee2Menu IsNot Nothing) Then
					RemoveHandler Me._CalculerAnnee2Menu.Click,  eventHandler
				End If
				Me._CalculerAnnee2Menu = value
				If (Me._CalculerAnnee2Menu IsNot Nothing) Then
					AddHandler Me._CalculerAnnee2Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBoxsupp As CheckBox
			Get
				Return Me._CheckBoxsupp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.CheckBox_Click)
				Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
				Dim eventHandler1 As System.EventHandler = New System.EventHandler(AddressOf calculatrice1.CheckBox1_CheckedChanged)
				If (Me._CheckBoxsupp IsNot Nothing) Then
					RemoveHandler Me._CheckBoxsupp.Click,  eventHandler
					RemoveHandler Me._CheckBoxsupp.CheckedChanged,  eventHandler1
				End If
				Me._CheckBoxsupp = value
				If (Me._CheckBoxsupp IsNot Nothing) Then
					AddHandler Me._CheckBoxsupp.Click,  eventHandler
					AddHandler Me._CheckBoxsupp.CheckedChanged,  eventHandler1
				End If
			End Set
		End Property

		Friend Overridable Property Empecherredondance1Menu As ToolStripMenuItem
			Get
				Return Me._Empecherredondance1Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.Empecherredondance1Menu_Click)
				If (Me._Empecherredondance1Menu IsNot Nothing) Then
					RemoveHandler Me._Empecherredondance1Menu.Click,  eventHandler
				End If
				Me._Empecherredondance1Menu = value
				If (Me._Empecherredondance1Menu IsNot Nothing) Then
					AddHandler Me._Empecherredondance1Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Empecherredondance2Menu As ToolStripMenuItem
			Get
				Return Me._Empecherredondance2Menu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.Empecherredondance2Menu_Click)
				If (Me._Empecherredondance2Menu IsNot Nothing) Then
					RemoveHandler Me._Empecherredondance2Menu.Click,  eventHandler
				End If
				Me._Empecherredondance2Menu = value
				If (Me._Empecherredondance2Menu IsNot Nothing) Then
					AddHandler Me._Empecherredondance2Menu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property EnregistrerSousMenu As ToolStripMenuItem
			Get
				Return Me._EnregistrerSousMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.EnregistrerSousToolStripMenuItem_Click)
				If (Me._EnregistrerSousMenu IsNot Nothing) Then
					RemoveHandler Me._EnregistrerSousMenu.Click,  eventHandler
				End If
				Me._EnregistrerSousMenu = value
				If (Me._EnregistrerSousMenu IsNot Nothing) Then
					AddHandler Me._EnregistrerSousMenu.Click,  eventHandler
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

		Friend Overridable Property GroupBoxannee0 As myGroupBox
			Get
				Return Me._GroupBoxannee0
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxannee0 = value
			End Set
		End Property

		Friend Overridable Property GroupBoxannee1 As myGroupBox
			Get
				Return Me._GroupBoxannee1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxannee1 = value
			End Set
		End Property

		Friend Overridable Property GroupBoxannee2 As myGroupBox
			Get
				Return Me._GroupBoxannee2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxannee2 = value
			End Set
		End Property

		Friend Overridable Property GroupBoxcalculs As myGroupBox
			Get
				Return Me._GroupBoxcalculs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxcalculs = value
			End Set
		End Property

		Friend Overridable Property GroupBoxcalendrier As myGroupBox
			Get
				Return Me._GroupBoxcalendrier
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxcalendrier = value
			End Set
		End Property

		Friend Overridable Property GroupBoxcontraintes As myGroupBox
			Get
				Return Me._GroupBoxcontraintes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxcontraintes = value
			End Set
		End Property

		Friend Overridable Property GroupBoxlégumes As myGroupBox
			Get
				Return Me._GroupBoxlégumes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxlégumes = value
			End Set
		End Property

		Friend Overridable Property GroupBoxPartitionnement As myGroupBox
			Get
				Return Me._GroupBoxPartitionnement
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As myGroupBox)
				Me._GroupBoxPartitionnement = value
			End Set
		End Property

		Friend Overridable Property ImprimerMenu As ToolStripMenuItem
			Get
				Return Me._ImprimerMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.ImprimerToolStripMenuItem_Click)
				If (Me._ImprimerMenu IsNot Nothing) Then
					RemoveHandler Me._ImprimerMenu.Click,  eventHandler
				End If
				Me._ImprimerMenu = value
				If (Me._ImprimerMenu IsNot Nothing) Then
					AddHandler Me._ImprimerMenu.Click,  eventHandler
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

		Private Overridable Property lblProgression As Label
			Get
				Return Me._lblProgression
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblProgression = value
			End Set
		End Property

		Friend Overridable Property Légende As System.Windows.Forms.Panel
			Get
				Return Me._Légende
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Légende = value
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

		Friend Overridable Property Panel As System.Windows.Forms.Panel
			Get
				Return Me._Panel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.Panel)
				Me._Panel = value
			End Set
		End Property

		Friend Overridable Property PictureBoxcocc1 As PictureBox
			Get
				Return Me._PictureBoxcocc1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoxcocc1 = value
			End Set
		End Property

		Friend Overridable Property PictureBoxjardinier As PictureBox
			Get
				Return Me._PictureBoxjardinier
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoxjardinier = value
			End Set
		End Property

		Friend Overridable Property PictureBoxpap As PictureBox
			Get
				Return Me._PictureBoxpap
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBoxpap = value
			End Set
		End Property

		Friend Overridable Property PrintDialog1 As PrintDialog
			Get
				Return Me._PrintDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDialog)
				Me._PrintDialog1 = value
			End Set
		End Property

		Friend Overridable Property PrintDocument1 As PrintDocument
			Get
				Return Me._PrintDocument1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintDocument)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim printPageEventHandler As System.Drawing.Printing.PrintPageEventHandler = New System.Drawing.Printing.PrintPageEventHandler(AddressOf calculatrice.PrintDocument1_PrintPage)
				If (Me._PrintDocument1 IsNot Nothing) Then
					RemoveHandler Me._PrintDocument1.PrintPage,  printPageEventHandler
				End If
				Me._PrintDocument1 = value
				If (Me._PrintDocument1 IsNot Nothing) Then
					AddHandler Me._PrintDocument1.PrintPage,  printPageEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property PrintPreviewDialog1 As PrintPreviewDialog
			Get
				Return Me._PrintPreviewDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PrintPreviewDialog)
				Me._PrintPreviewDialog1 = value
			End Set
		End Property

		Friend Overridable Property ProgressBar1 As ProgressBar
			Get
				Return Me._ProgressBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		Friend Overridable Property ResetMenu As ToolStripMenuItem
			Get
				Return Me._ResetMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf calculatrice.ResetToolStripMenuItem_Click)
				If (Me._ResetMenu IsNot Nothing) Then
					RemoveHandler Me._ResetMenu.Click,  eventHandler
				End If
				Me._ResetMenu = value
				If (Me._ResetMenu IsNot Nothing) Then
					AddHandler Me._ResetMenu.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ResultatsAssociationMenu As ToolStripMenuItem
			Get
				Return Me._ResultatsAssociationMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Me._ResultatsAssociationMenu = value
			End Set
		End Property

		Friend Overridable Property RésultatsMenu As ToolStripMenuItem
			Get
				Return Me._RésultatsMenu
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripMenuItem)
				Me._RésultatsMenu = value
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

		Friend Overridable Property semis As Label
			Get
				Return Me._semis
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._semis = value
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

		Friend Overridable Property StatutLabel As ToolStripStatusLabel
			Get
				Return Me._StatutLabel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripStatusLabel)
				Me._StatutLabel = value
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator2 As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripSeparator)
				Me._ToolStripSeparator2 = value
			End Set
		End Property

		Friend Overridable Property ToolStripSeparator3 As ToolStripSeparator
			Get
				Return Me._ToolStripSeparator3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripSeparator)
				Me._ToolStripSeparator3 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim calculatrice1 As Calculatrice = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf calculatrice1.Form1_Load)
			Dim calculatrice2 As Calculatrice = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf calculatrice2.Calculatrice_FormClosed)
			Me.L = New List(Of String)()
			Me.calendrierselectionne = New List(Of String)()
			Me.InitializeComponent()
		End Sub

		Private Sub AfficherToutesLesCombinaisonsOptimiséesDeLannée1ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadcombrot1) Then
				Me.COMBROT1 = New FormCO1()
				Me.COMBROT1.Show()
				Module1.loadcombrot1 = True
			Else
				Me.COMBROT1.Activate()
			End If
		End Sub

		Private Sub AfficherToutesLesCombinaisonsOptimiséesDeLannée2ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadcombrot2) Then
				Me.COMBROT2 = New FormCO2()
				Me.COMBROT2.Show()
				Module1.loadcombrot2 = True
			Else
				Me.COMBROT2.Activate()
			End If
		End Sub

		Private Sub AfficherToutesLesCombinaisonsOptimiséesToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadcombass) Then
				Me.COMBASS = New FormCO0()
				Me.COMBASS.Show()
				Module1.loadcombass = True
			Else
				Me.COMBASS.Activate()
			End If
		End Sub

		Private Sub BackgroundWorker0_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Me.BackgroundWorkerannee0.ReportProgress(20, "Chargement des combinaisons...")
			Module1.factnumeroparcelle = Me.fact(Module1.numeroparcelle)
			If (Module1.numeroparcelle > 2) Then
				Dim stringReader As System.IO.StringReader = New System.IO.StringReader(Module1.PATHS(Module1.numeroparcelle))
				ReDim Module1.COMBINAISONS(Module1.factnumeroparcelle + 1 - 1)
				Dim num As Integer = Module1.factnumeroparcelle
				Dim num1 As Integer = 1
				Do
					Module1.COMBINAISONS(num1) = stringReader.ReadLine()
					Me.BackgroundWorkerannee0.ReportProgress(CInt(Math.Round(20 + CDbl((num1 * 50)) / CDbl(Module1.factnumeroparcelle))))
					num1 = num1 + 1
				Loop While num1 <= num
				stringReader.Close()
			End If
			If (Module1.numeroparcelle = 1) Then
				Module1.COMBINAISONS = New String() { Nothing, "1" }
			End If
			If (Module1.numeroparcelle = 2) Then
				Module1.COMBINAISONS = New String() { Nothing, "12", "21" }
			End If
			If (Module1.numeroparcelle > 1) Then
				ReDim Module1.Notepp(Module1.factnumeroparcelle + 1 - 1)
				Dim num2 As Integer = Module1.factnumeroparcelle
				For i As Integer = 1 To num2 Step 1
					Module1.Notepp(i) = 0
					Dim num3 As Integer = Module1.numeroparcelle
					Dim num4 As Integer = 1
					Do
						Dim num5 As Integer = Module1.numeroparcelle
						Dim num6 As Integer = 1
						Do
							Module1.Notepp(i) = Conversions.ToInteger(Operators.AddObject(Module1.Notepp(i), Operators.MultiplyObject(Me.FRONTIERES(num4, num6), Module1.Base_de_données_associations(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(i), num4, 1))), Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(i), num6, 1)))))))
							num6 = num6 + 1
						Loop While num6 <= num5
						num4 = num4 + 1
					Loop While num4 <= num3
					Me.BackgroundWorkerannee0.ReportProgress(CInt(Math.Round(70 + CDbl((i * 10)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes parcelle...")
				Next

			End If
			ReDim Module1.Notepc(Module1.factnumeroparcelle + 1 - 1)
			If (Module1.numerocontrainte > 0 And Module1.numeroparcelle > 0) Then
				Dim num7 As Integer = Module1.factnumeroparcelle
				For j As Integer = 1 To num7 Step 1
					Dim num8 As Integer = Module1.numeroparcelle + 1
					Dim num9 As Integer = Module1.numerocontrainte + Module1.numeroparcelle
					Dim num10 As Integer = num8
					Do
						Dim num11 As Integer = Module1.numeroparcelle
						Dim num12 As Integer = 1
						Do
							Module1.Notepc(j) = Conversions.ToInteger(Operators.AddObject(Module1.Notepc(j), Operators.MultiplyObject(Me.FRONTIERES(num12, num10), Module1.Base_de_données_associations(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(j), num12, 1))), Module1.Contraintes_selectionnéesconvertis(num10 - Module1.numeroparcelle)))))
							num12 = num12 + 1
						Loop While num12 <= num11
						num10 = num10 + 1
					Loop While num10 <= num9
					Me.BackgroundWorkerannee0.ReportProgress(CInt(Math.Round(80 + CDbl((j * 10)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes contrainte...")
				Next

			End If
			If (Module1.numerocontrainte > 1) Then
				Module1.Notecc = 0
				Dim num13 As Integer = Module1.numeroparcelle + 1
				Dim num14 As Integer = Module1.numerocontrainte + Module1.numeroparcelle
				For k As Integer = num13 To num14 Step 1
					Dim num15 As Integer = Module1.numeroparcelle + 1
					Dim num16 As Integer = Module1.numerocontrainte + Module1.numeroparcelle
					For l As Integer = num15 To num16 Step 1
						Module1.Notecc = Conversions.ToInteger(Operators.AddObject(Module1.Notecc, Operators.MultiplyObject(Me.FRONTIERES(l, k), Module1.Base_de_données_associations(Module1.Contraintes_selectionnéesconvertis(l - Module1.numeroparcelle), Module1.Contraintes_selectionnéesconvertis(k - Module1.numeroparcelle)))))
					Next

				Next

			End If
			ReDim Module1.NOTESASS(Module1.factnumeroparcelle - 1 + 1 - 1)
			If (Module1.numeroparcelle > 1) Then
				Dim num17 As Integer = Module1.factnumeroparcelle - 1
				Dim num18 As Integer = 0
				Do
					Module1.NOTESASS(num18) = Module1.Notepp(num18 + 1) + Module1.Notepc(num18 + 1) + Module1.Notecc
					Me.BackgroundWorkerannee0.ReportProgress(CInt(Math.Round(90 + CDbl(((num18 + 1) * 5)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes...")
					num18 = num18 + 1
				Loop While num18 <= num17
				Module1.NOTEASSMAX = Module1.NOTESASS.Max()
			End If
			Me.BackgroundWorkerannee0.ReportProgress(95, "Affichage des résultats...")
		End Sub

		Private Sub BackgroundWorker0_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
			Me.ProgressBar1.Value = e.ProgressPercentage
			Me.lblProgression.Text = Conversions.ToString(e.UserState)
		End Sub

		Private Sub BackgroundWorker0_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			Dim str As String()
			Dim size As System.Drawing.Size
			If (Module1.numeroparcelle <= 1) Then
				If (Module1.numeroparcelle = 1) Then
					Me.note = Module1.Notecc + Module1.Notepc(1)
				End If
				If (Module1.numeroparcelle = 0) Then
					Me.note = Module1.Notecc
				End If
				Dim annee01 As System.Windows.Forms.Label = Me.Annee01
				str = New String() { "La note de la configuration est ", Conversions.ToString(Me.note), "" & VbCrLf & "Sur une échelle allant de -", Conversions.ToString(Module1.nbrfrontierespartagees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees) }
				annee01.Text = String.Concat(str)
				Dim groupBoxannee0 As myGroupBox = Me.GroupBoxannee0
				size = New System.Drawing.Size(Module1.screenadaptX(390), Module1.screenadaptY(60))
				groupBoxannee0.Size = size
				groupBoxannee0.Visible = True
				groupBoxannee0 = Nothing
				Me.ProgressBar1.Value = 100
				Me.lblProgression.Text = "Calculs terminés"
				Me.ResultatsAssociationMenu.Enabled = False
				Me.ImprimerMenu.Enabled = False
				Me.EnregistrerSousMenu.Enabled = False
				Me.BilanMenu.Enabled = False
				Me.CalculerAnnee0Menu.Enabled = True
				Me.btnAnnee0.Enabled = True
				Me.CalculerAnnee1Menu.Enabled = False
				Me.btnAnnee1.Enabled = False
				Me.CalculerAnnee2Menu.Enabled = False
				Me.btnAnnee2.Enabled = False
			End If
			If (Module1.numeroparcelle > 1) Then
				Dim label As System.Windows.Forms.Label = Me.Annee01
				str = New String() { "La note de la meilleure configuration est ", Conversions.ToString(Module1.NOTEASSMAX), "" & VbCrLf & "Sur une échelle allant de -", Conversions.ToString(Module1.nbrfrontierespartagees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees) }
				label.Text = String.Concat(str)
				Module1.nbrsolutionoptimisees = 0
				ReDim Module1.RESULTSASS(Me.fact(Module1.numeroparcelle) + 1 - 1, Module1.numeroparcelle + 1 - 1)
				Dim num As Integer = Me.fact(Module1.numeroparcelle) - 1
				Dim num1 As Integer = 0
				Do
					If (Module1.NOTESASS(num1) = Module1.NOTEASSMAX) Then
						Module1.nbrsolutionoptimisees = Module1.nbrsolutionoptimisees + 1
						Dim num2 As Integer = Module1.numeroparcelle
						For i As Integer = 1 To num2 Step 1
							Module1.RESULTSASS(Module1.nbrsolutionoptimisees, i) = Module1.listelégumes(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(num1 + 1), i, 1))))
						Next

					End If
					num1 = num1 + 1
				Loop While num1 <= num
				Dim annee02 As System.Windows.Forms.Label = Me.Annee02
				str = New String() { "Il y a ", Conversions.ToString(Module1.nbrsolutionoptimisees), " configuration(s) optimisée(s) pour ", Conversions.ToString(Me.fact(Module1.numeroparcelle)), " configuration(s) possible(s)." }
				annee02.Text = String.Concat(str)
				If (Module1.nbrsolutionoptimisees <= 3) Then
					Me.nbrsolutionaffichees = Module1.nbrsolutionoptimisees
					Me.Annee03.Text = "Voici toutes les combinaisons optimisées:"
				Else
					Me.nbrsolutionaffichees = 3
					Me.Annee03.Text = String.Concat("Voici 3 des ", Conversions.ToString(Module1.nbrsolutionoptimisees), " configurations optimisées:")
				End If
				ReDim Me.Résultatstab(Me.nbrsolutionaffichees + 1 - 1, Module1.numeroparcelle + 1 - 1)
				Me.traitab = 1
				Me.Résultatstab(0, 0) = New System.Windows.Forms.Label()
				Dim résultatstab As System.Windows.Forms.Label = Me.Résultatstab(0, 0)
				résultatstab.Text = "Parcelle"
				résultatstab.AutoEllipsis = True
				Dim point As System.Drawing.Point = New System.Drawing.Point(Me.traitab, Me.traitab)
				résultatstab.Location = point
				résultatstab.BackColor = Color.DarkKhaki
				résultatstab.TextAlign = ContentAlignment.MiddleCenter
				size = New System.Drawing.Size(Me.longcol1, Me.largcol)
				résultatstab.Size = size
				résultatstab = Nothing
				Me.Annee0.Controls.Add(Me.Résultatstab(0, 0))
				Dim num3 As Integer = Me.nbrsolutionaffichees
				Dim num4 As Integer = 1
				Do
					Me.Résultatstab(num4, 0) = New System.Windows.Forms.Label()
					Dim darkKhaki As System.Windows.Forms.Label = Me.Résultatstab(num4, 0)
					darkKhaki.BackColor = Color.DarkKhaki
					darkKhaki.AutoEllipsis = True
					darkKhaki.Text = String.Concat("Combinaison ", num4.ToString())
					size = New System.Drawing.Size(Me.longcol, Me.largcol)
					darkKhaki.Size = size
					point = New System.Drawing.Point(Me.longcol1 + (num4 - 1) * Me.longcol + (num4 + 1) * Me.traitab, Me.traitab)
					darkKhaki.Location = point
					darkKhaki = Nothing
					Me.Annee0.Controls.Add(Me.Résultatstab(num4, 0))
					num4 = num4 + 1
				Loop While num4 <= num3
				Dim num5 As Integer = Module1.numeroparcelle
				Dim num6 As Integer = 1
				Do
					Me.Résultatstab(0, num6) = New System.Windows.Forms.Label()
					Dim résultatstab1 As System.Windows.Forms.Label = Me.Résultatstab(0, num6)
					résultatstab1.BackColor = Module1.couleurs(num6)
					résultatstab1.Text = num6.ToString()
					résultatstab1.AutoEllipsis = True
					résultatstab1.TextAlign = ContentAlignment.MiddleCenter
					size = New System.Drawing.Size(Me.longcol1, Me.largcol)
					résultatstab1.Size = size
					point = New System.Drawing.Point(Me.traitab, num6 * Me.largcol + (num6 + 1) * Me.traitab)
					résultatstab1.Location = point
					résultatstab1 = Nothing
					Me.Annee0.Controls.Add(Me.Résultatstab(0, num6))
					num6 = num6 + 1
				Loop While num6 <= num5
				Dim num7 As Integer = Me.nbrsolutionaffichees
				Dim num8 As Integer = 1
				Do
					Dim num9 As Integer = Module1.numeroparcelle
					Dim num10 As Integer = 1
					Do
						Me.Résultatstab(num8, num10) = New System.Windows.Forms.Label()
						Dim rESULTSASS As System.Windows.Forms.Label = Me.Résultatstab(num8, num10)
						rESULTSASS.BackColor = Color.DarkKhaki
						rESULTSASS.AutoEllipsis = True
						rESULTSASS.Text = Module1.RESULTSASS(num8, num10)
						size = New System.Drawing.Size(Me.longcol, Me.largcol)
						rESULTSASS.Size = size
						point = New System.Drawing.Point(Me.longcol1 + (num8 - 1) * Me.longcol + (num8 + 1) * Me.traitab, num10 * Me.largcol + (num10 + 1) * Me.traitab)
						rESULTSASS.Location = point
						rESULTSASS = Nothing
						Me.Annee0.Controls.Add(Me.Résultatstab(num8, num10))
						num10 = num10 + 1
					Loop While num10 <= num9
					num8 = num8 + 1
				Loop While num8 <= num7
				Dim annee0 As System.Windows.Forms.Panel = Me.Annee0
				annee0.BackColor = Color.Black
				point = New System.Drawing.Point(Module1.screenadaptX(10), Module1.screenadaptY(120))
				annee0.Location = point
				size = New System.Drawing.Size(Me.nbrsolutionaffichees * Me.longcol + Me.longcol1 + (Me.nbrsolutionaffichees + 2) * Me.traitab, (Module1.numeroparcelle + 1) * Me.largcol + (Module1.numeroparcelle + 2) * Me.traitab)
				annee0.Size = size
				annee0 = Nothing
				Dim _myGroupBox As myGroupBox = Me.GroupBoxannee0
				size = New System.Drawing.Size(Module1.screenadaptX(500), Module1.screenadaptY(120) + (Me.largcol + 2) * (Module1.numeroparcelle + 1) + Module1.screenadaptY(10))
				_myGroupBox.Size = size
				_myGroupBox.Controls.Add(Me.Annee0)
				_myGroupBox.Visible = True
				_myGroupBox = Nothing
				Me.PHOTOPANEL(Me.Annee0)
				Me.Résultatstab = Nothing
				Me.ResultatsAssociationMenu.Enabled = True
				Me.AfficherCombinaisons1Menu.Enabled = False
				Me.AfficherCombinaisons2Menu.Enabled = False
				Me.BilanMenu.Enabled = False
				Me.CalculerAnnee0Menu.Enabled = True
				Me.btnAnnee0.Enabled = True
				If (MyProject.Forms.FormPasPas.activation) Then
					Me.ImprimerMenu.Enabled = True
					Me.EnregistrerSousMenu.Enabled = True
				End If
				Me.CalculerAnnee1Menu.Enabled = True
				Me.btnAnnee1.Enabled = True
				Me.CalculerAnnee2Menu.Enabled = False
				Me.btnAnnee2.Enabled = False
				Me.ProgressBar1.Value = 100
				Me.lblProgression.Text = "Calculs terminés"
				Me.StatutLabel.Text = "Associations calculées avec succès! Vous pouvez à présent calculer les meilleures rotations possibles pour les solutions obtenues"
				Me.Cursor = Cursors.[Default]
				Me.Refresh()
			End If
		End Sub

		Private Sub BackgroundWorkerannee1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Dim nOTESROT1 As Integer()
			Dim num As Integer
			Me.BackgroundWorkerannee1.ReportProgress(0, "Récupération du code de la combinaison choisie...")
			Module1.codecombinaisonchoisie1 = ""
			Dim num1 As Integer = Module1.numeroparcelle
			Dim num2 As Integer = 1
			Do
				Dim num3 As Integer = Module1.numeroparcelle
				Dim num4 As Integer = 1
				Do
					If (Operators.CompareString(Module1.listelégumes(Module1.Legumes_selectionnésconvertis(num4)), Module1.RESULTSASS(Module1.numerocombinaisonrotation1, num2), False) = 0) Then
						Module1.codecombinaisonchoisie1 = String.Concat(Module1.codecombinaisonchoisie1, Conversions.ToString(num4))
					End If
					num4 = num4 + 1
				Loop While num4 <= num3
				num2 = num2 + 1
			Loop While num2 <= num1
			Me.BackgroundWorkerannee1.ReportProgress(5, "Comptage des cellules de chaque parcelles...")
			Module1.nbrcellulesutilisees = 0
			ReDim Me.CELLULES(Module1.numeroparcelle + 1 - 1)
			Dim num5 As Integer = Module1.numeroparcelle
			Dim num6 As Integer = 1
			Do
				Me.CELLULES(num6) = Me.cellule(num6)
				Module1.nbrcellulesutilisees = Module1.nbrcellulesutilisees + Me.cellule(num6)
				Me.BackgroundWorkerannee1.ReportProgress(CInt(Math.Round(5 + CDbl((5 * num6)) / CDbl(Module1.numeroparcelle))), "Calcul des notes...")
				num6 = num6 + 1
			Loop While num6 <= num5
			ReDim Me.chiffrecodecombinaisonchoisie(Module1.numeroparcelle + 1 - 1)
			Dim num7 As Integer = Module1.numeroparcelle
			Dim num8 As Integer = 1
			Do
				Me.chiffrecodecombinaisonchoisie(num8) = Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.codecombinaisonchoisie1, num8, 1))
				num8 = num8 + 1
			Loop While num8 <= num7
			If (Me.Empecherredondance1Menu.Checked) Then
				Me.compt = 0
				Me.rang = 0
				ReDim Me.COMBINAISONSFILTRE1(1, Me.dimnoterotfiltre(Module1.numeroparcelle) + 1 - 1)
				Dim num9 As Integer = Module1.factnumeroparcelle
				Dim num10 As Integer = 1
				Do
					Dim num11 As Integer = Module1.numeroparcelle
					Dim num12 As Integer = 1
					Do
						If (Operators.CompareString(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(num10), num12, 1), Me.chiffrecodecombinaisonchoisie(num12).ToString(), False) <> 0) Then
							Me.compt = Me.compt + 1
						End If
						num12 = num12 + 1
					Loop While num12 <= num11
					If (Me.compt = Module1.numeroparcelle) Then
						Me.rang = Me.rang + 1
						Me.COMBINAISONSFILTRE1(0, Me.rang) = Module1.COMBINAISONS(num10)
						Me.COMBINAISONSFILTRE1(1, Me.rang) = num10.ToString()
					End If
					Me.compt = 0
					num10 = num10 + 1
				Loop While num10 <= num9
				ReDim Me.NOTESROT1(Me.dimnoterotfiltre(Module1.numeroparcelle) - 1 + 1 - 1)
				Dim num13 As Integer = Me.dimnoterotfiltre(Module1.numeroparcelle) - 1
				Dim num14 As Integer = 0
				Do
					Dim num15 As Integer = Module1.numeroparcelle
					Dim num16 As Integer = 1
					Do
						nOTESROT1 = Me.NOTESROT1
						num = num14
						nOTESROT1(num) = nOTESROT1(num) + Me.CELLULES(num16) * Module1.Base_de_données_rotations(Module1.Legumes_selectionnésconvertis(Me.chiffrecodecombinaisonchoisie(num16)), Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Me.COMBINAISONSFILTRE1(0, num14 + 1), num16, 1))))
						Me.BackgroundWorkerannee1.ReportProgress(CInt(Math.Round(10 + CDbl((60 * num14)) / CDbl(Me.dimnoterotfiltre(Module1.numeroparcelle)))), "Calcul des notes...")
						num16 = num16 + 1
					Loop While num16 <= num15
					num14 = num14 + 1
				Loop While num14 <= num13
				ReDim Me.NOTES1(Me.dimnoterotfiltre(Module1.numeroparcelle) - 1 + 1 - 1)
				Dim num17 As Integer = Me.dimnoterotfiltre(Module1.numeroparcelle) - 1
				Dim num18 As Integer = 0
				Do
					Me.NOTES1(num18) = Module1.NOTESASS(Conversions.ToInteger(Me.COMBINAISONSFILTRE1(1, num18 + 1)) - 1) + Me.NOTESROT1(num18)
					Me.BackgroundWorkerannee1.ReportProgress(CInt(Math.Round(70 + CDbl((10 * num18)) / CDbl(Me.dimnoterotfiltre(Module1.numeroparcelle)))), "Calcul des notes...")
					num18 = num18 + 1
				Loop While num18 <= num17
				Module1.NOTEMAX1 = Me.NOTES1.Max()
				Module1.nbrrotationoptimisees1 = 0
				ReDim Module1.RESULTSROT1(Me.dimnoterotfiltre(Module1.numeroparcelle) + 1 - 1, Module1.numeroparcelle + 1 - 1)
				Dim num19 As Integer = Me.dimnoterotfiltre(Module1.numeroparcelle) - 1
				For i As Integer = 0 To num19 Step 1
					If (Me.NOTES1(i) = Module1.NOTEMAX1) Then
						Module1.nbrrotationoptimisees1 = Module1.nbrrotationoptimisees1 + 1
						Dim num20 As Integer = Module1.numeroparcelle
						Dim num21 As Integer = 1
						Do
							Module1.RESULTSROT1(Module1.nbrrotationoptimisees1, num21) = Module1.listelégumes(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Me.COMBINAISONSFILTRE1(0, i + 1), num21, 1))))
							num21 = num21 + 1
						Loop While num21 <= num20
						Me.BackgroundWorkerannee1.ReportProgress(CInt(Math.Round(80 + CDbl((15 * i)) / CDbl(Me.dimnoterotfiltre(Module1.numeroparcelle)))), "Calcul des notes...")
					End If
				Next

			End If
			If (Not Me.Empecherredondance1Menu.Checked) Then
				ReDim Me.NOTESROT1(Module1.factnumeroparcelle - 1 + 1 - 1)
				Dim num22 As Integer = Module1.factnumeroparcelle - 1
				Dim num23 As Integer = 0
				Do
					Dim num24 As Integer = Module1.numeroparcelle
					Dim num25 As Integer = 1
					Do
						nOTESROT1 = Me.NOTESROT1
						num = num23
						nOTESROT1(num) = nOTESROT1(num) + Me.CELLULES(num25) * Module1.Base_de_données_rotations(Module1.Legumes_selectionnésconvertis(Me.chiffrecodecombinaisonchoisie(num25)), Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(num23 + 1), num25, 1))))
						num25 = num25 + 1
					Loop While num25 <= num24
					Me.BackgroundWorkerannee1.ReportProgress(CInt(Math.Round(10 + CDbl((60 * num23)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes...")
					num23 = num23 + 1
				Loop While num23 <= num22
				ReDim Me.NOTES1(Module1.factnumeroparcelle - 1 + 1 - 1)
				Dim num26 As Integer = Module1.factnumeroparcelle - 1
				Dim num27 As Integer = 0
				Do
					Me.NOTES1(num27) = Module1.NOTESASS(num27) + Me.NOTESROT1(num27)
					Me.BackgroundWorkerannee1.ReportProgress(CInt(Math.Round(70 + CDbl((10 * num27)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes...")
					num27 = num27 + 1
				Loop While num27 <= num26
				Module1.NOTEMAX1 = Me.NOTES1.Max()
				Module1.nbrrotationoptimisees1 = 0
				ReDim Module1.RESULTSROT1(Module1.factnumeroparcelle + 1 - 1, Module1.numeroparcelle + 1 - 1)
				Dim num28 As Integer = Module1.factnumeroparcelle - 1
				For j As Integer = 0 To num28 Step 1
					If (Me.NOTES1(j) = Module1.NOTEMAX1) Then
						Module1.nbrrotationoptimisees1 = Module1.nbrrotationoptimisees1 + 1
						Dim num29 As Integer = Module1.numeroparcelle
						For k As Integer = 1 To num29 Step 1
							Module1.RESULTSROT1(Module1.nbrrotationoptimisees1, k) = Module1.listelégumes(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(j + 1), k, 1))))
						Next

					End If
					Me.BackgroundWorkerannee1.ReportProgress(CInt(Math.Round(80 + CDbl((15 * j)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes...")
				Next

			End If
		End Sub

		Private Sub BackgroundWorkerannee1_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
			Me.ProgressBar1.Value = e.ProgressPercentage
			Me.lblProgression.Text = Conversions.ToString(e.UserState)
		End Sub

		Private Sub BackgroundWorkerannee1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			Me.lblProgression.Text = "Affichage des résultats..."
			Me.GroupBoxannee1.Text = String.Concat("Année +1 - Calculée à partir de la combinaison ", Conversions.ToString(Module1.numerocombinaisonrotation1), "      ")
			Dim annee11 As System.Windows.Forms.Label = Me.Annee11
			Dim str() As String = { "La note de la meilleure configuration est ", Conversions.ToString(Module1.NOTEMAX1), "" & VbCrLf & "Sur une échelle allant de -", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees) }
			annee11.Text = String.Concat(str)
			Dim annee12 As System.Windows.Forms.Label = Me.Annee12
			str = New String() { "Il y a ", Conversions.ToString(Module1.nbrrotationoptimisees1), " configuration(s) optimisée(s) pour ", Conversions.ToString(Me.fact(Module1.numeroparcelle)), " configurations possibles." }
			annee12.Text = String.Concat(str)
			If (Module1.nbrrotationoptimisees1 <= 3) Then
				Me.nbrrotationaffichees = Module1.nbrrotationoptimisees1
				Me.Annee13.Text = "Voici toutes les combinaisons optimisées:"
			Else
				Me.nbrrotationaffichees = 3
				Me.Annee13.Text = String.Concat("Voici 3 des ", Conversions.ToString(Module1.nbrrotationoptimisees1), " configurations optimisées:")
			End If
			ReDim Me.Résultatstab(Me.nbrrotationaffichees + 1 - 1, Module1.numeroparcelle + 1 - 1)
			Me.traitab = 1
			Me.Résultatstab(0, 0) = New System.Windows.Forms.Label()
			Dim résultatstab As System.Windows.Forms.Label = Me.Résultatstab(0, 0)
			résultatstab.Text = "Parcelle"
			Dim point As System.Drawing.Point = New System.Drawing.Point(Me.traitab, Me.traitab)
			résultatstab.Location = point
			résultatstab.BackColor = Color.DarkKhaki
			résultatstab.TextAlign = ContentAlignment.MiddleCenter
			Dim size As System.Drawing.Size = New System.Drawing.Size(Me.longcol1, Me.largcol)
			résultatstab.Size = size
			résultatstab = Nothing
			Me.Annee1.Controls.Add(Me.Résultatstab(0, 0))
			Dim num As Integer = Me.nbrrotationaffichees
			Dim num1 As Integer = 1
			Do
				Me.Résultatstab(num1, 0) = New System.Windows.Forms.Label()
				Dim darkKhaki As System.Windows.Forms.Label = Me.Résultatstab(num1, 0)
				darkKhaki.BackColor = Color.DarkKhaki
				darkKhaki.AutoEllipsis = True
				darkKhaki.Text = String.Concat("Combinaison ", num1.ToString())
				size = New System.Drawing.Size(Me.longcol, Me.largcol)
				darkKhaki.Size = size
				point = New System.Drawing.Point(Me.longcol1 + (num1 - 1) * Me.longcol + (num1 + 1) * Me.traitab, Me.traitab)
				darkKhaki.Location = point
				darkKhaki = Nothing
				Me.Annee1.Controls.Add(Me.Résultatstab(num1, 0))
				num1 = num1 + 1
			Loop While num1 <= num
			Dim num2 As Integer = Module1.numeroparcelle
			Dim num3 As Integer = 1
			Do
				Me.Résultatstab(0, num3) = New System.Windows.Forms.Label()
				Dim label As System.Windows.Forms.Label = Me.Résultatstab(0, num3)
				label.BackColor = Module1.couleurs(num3)
				label.AutoEllipsis = True
				label.Text = num3.ToString()
				label.TextAlign = ContentAlignment.MiddleCenter
				size = New System.Drawing.Size(Me.longcol1, Me.largcol)
				label.Size = size
				point = New System.Drawing.Point(Me.traitab, num3 * Me.largcol + (num3 + 1) * Me.traitab)
				label.Location = point
				label = Nothing
				Me.Annee1.Controls.Add(Me.Résultatstab(0, num3))
				num3 = num3 + 1
			Loop While num3 <= num2
			Dim num4 As Integer = Me.nbrrotationaffichees
			Dim num5 As Integer = 1
			Do
				Dim num6 As Integer = Module1.numeroparcelle
				Dim num7 As Integer = 1
				Do
					Me.Résultatstab(num5, num7) = New System.Windows.Forms.Label()
					Dim rESULTSROT1 As System.Windows.Forms.Label = Me.Résultatstab(num5, num7)
					rESULTSROT1.BackColor = Color.DarkKhaki
					rESULTSROT1.AutoEllipsis = True
					rESULTSROT1.Text = Module1.RESULTSROT1(num5, num7)
					size = New System.Drawing.Size(Me.longcol, Me.largcol)
					rESULTSROT1.Size = size
					point = New System.Drawing.Point(Me.longcol1 + (num5 - 1) * Me.longcol + (num5 + 1) * Me.traitab, num7 * Me.largcol + (num7 + 1) * Me.traitab)
					rESULTSROT1.Location = point
					rESULTSROT1 = Nothing
					Me.Annee1.Controls.Add(Me.Résultatstab(num5, num7))
					num7 = num7 + 1
				Loop While num7 <= num6
				num5 = num5 + 1
			Loop While num5 <= num4
			Dim annee1 As System.Windows.Forms.Panel = Me.Annee1
			annee1.BackColor = Color.Black
			point = New System.Drawing.Point(Module1.screenadaptX(10), Module1.screenadaptY(120))
			annee1.Location = point
			size = New System.Drawing.Size(Me.nbrrotationaffichees * Me.longcol + Me.longcol1 + (Me.nbrrotationaffichees + 2) * Me.traitab, (Module1.numeroparcelle + 1) * Me.largcol + (Module1.numeroparcelle + 2) * Me.traitab)
			annee1.Size = size
			annee1.Visible = True
			annee1 = Nothing
			Dim groupBoxannee1 As myGroupBox = Me.GroupBoxannee1
			Dim mgauche As Integer = Me.Mgauche + Me.Lgrille + Module1.screenadaptX(30) + Me.Llegcont + Module1.screenadaptX(90)
			point = Me.AutoScrollPosition
			Dim point1 As System.Drawing.Point = New System.Drawing.Point(mgauche, point.Y + Me.Mhaut + Module1.screenadaptY(120) + (Module1.screenadaptY(14) + 2) * (Module1.numeroparcelle + 1) + Module1.screenadaptY(10) + Module1.screenadaptY(40))
			groupBoxannee1.Location = point1
			size = New System.Drawing.Size(Module1.screenadaptX(500), Module1.screenadaptY(120) + (Me.largcol + 2) * (Module1.numeroparcelle + 1) + Module1.screenadaptY(10))
			groupBoxannee1.Size = size
			groupBoxannee1.Visible = True
			groupBoxannee1.Controls.Add(Me.Annee1)
			groupBoxannee1 = Nothing
			Me.PHOTOPANEL(Me.Annee1)
			Me.Résultatstab = Nothing
			Me.ProgressBar1.Value = 100
			Me.lblProgression.Text = "Calculs terminés"
			Me.StatutLabel.Text = "Le calcul de la première rotation a été effectué avec succès! Vous pouvez à présent lancer le calcul de la seconde rotation"
			Me.ResultatsAssociationMenu.Enabled = True
			Me.AfficherCombinaisons1Menu.Enabled = True
			Me.AfficherCombinaisons2Menu.Enabled = False
			Me.ImprimerMenu.Enabled = True
			Me.EnregistrerSousMenu.Enabled = True
			Me.BilanMenu.Enabled = False
			Me.CalculerAnnee0Menu.Enabled = True
			Me.btnAnnee0.Enabled = True
			Me.CalculerAnnee1Menu.Enabled = True
			Me.btnAnnee1.Enabled = True
			If (MyProject.Forms.FormPasPas.activation) Then
				Me.CalculerAnnee2Menu.Enabled = True
				Me.btnAnnee2.Enabled = True
			End If
			Me.Cursor = Cursors.[Default]
			Me.Refresh()
		End Sub

		Private Sub BackgroundWorkerannee2_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Dim nOTESROT2 As Integer()
			Dim num As Integer
			Me.BackgroundWorkerannee2.ReportProgress(0)
			Module1.codecombinaisonchoisie2 = ""
			Dim num1 As Integer = Module1.numeroparcelle
			Dim num2 As Integer = 1
			Do
				Dim num3 As Integer = Module1.numeroparcelle
				Dim num4 As Integer = 1
				Do
					If (Operators.CompareString(Module1.listelégumes(Module1.Legumes_selectionnésconvertis(num4)), Module1.RESULTSROT1(Module1.numerocombinaisonrotation2, num2), False) = 0) Then
						Module1.codecombinaisonchoisie2 = String.Concat(Module1.codecombinaisonchoisie2, Conversions.ToString(num4))
					End If
					num4 = num4 + 1
				Loop While num4 <= num3
				num2 = num2 + 1
			Loop While num2 <= num1
			ReDim Me.chiffrecodecombinaisonchoisie(Module1.numeroparcelle + 1 - 1)
			Dim num5 As Integer = Module1.numeroparcelle
			Dim num6 As Integer = 1
			Do
				Me.chiffrecodecombinaisonchoisie(num6) = Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.codecombinaisonchoisie2, num6, 1))
				num6 = num6 + 1
			Loop While num6 <= num5
			If (Me.Empecherredondance1Menu.Checked) Then
				If (Not Me.Empecherredondance2Menu.Checked) Then
					Me.compt = 0
					Me.rang = 1
					ReDim Me.COMBINAISONSFILTRE2(1, Me.dimnoterotfiltre(Module1.numeroparcelle) + 1 - 1)
					Dim num7 As Integer = Module1.factnumeroparcelle
					Dim num8 As Integer = 1
					Do
						Dim num9 As Integer = Module1.numeroparcelle
						Dim num10 As Integer = 1
						Do
							If (Operators.CompareString(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(num8), num10, 1), Me.chiffrecodecombinaisonchoisie(num10).ToString(), False) <> 0) Then
								Me.compt = Me.compt + 1
							End If
							num10 = num10 + 1
						Loop While num10 <= num9
						If (Me.compt = Module1.numeroparcelle) Then
							Me.COMBINAISONSFILTRE2(0, Me.rang) = Module1.COMBINAISONS(num8)
							Me.COMBINAISONSFILTRE2(1, Me.rang) = num8.ToString()
							Me.rang = Me.rang + 1
						End If
						Me.compt = 0
						num8 = num8 + 1
					Loop While num8 <= num7
					ReDim Me.NOTESROT2(Me.dimnoterotfiltre(Module1.numeroparcelle) - 1 + 1 - 1)
					Dim num11 As Integer = Me.dimnoterotfiltre(Module1.numeroparcelle) - 1
					Dim num12 As Integer = 0
					Do
						Dim num13 As Integer = Module1.numeroparcelle
						Dim num14 As Integer = 1
						Do
							nOTESROT2 = Me.NOTESROT2
							num = num12
							nOTESROT2(num) = nOTESROT2(num) + Me.CELLULES(num14) * Module1.Base_de_données_rotations(Module1.Legumes_selectionnésconvertis(Me.chiffrecodecombinaisonchoisie(num14)), Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Me.COMBINAISONSFILTRE2(0, num12 + 1), num14, 1))))
							Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(10 + CDbl((60 * num12)) / CDbl(Me.dimnoterotfiltre(Module1.numeroparcelle)))), "Calcul des notes...")
							num14 = num14 + 1
						Loop While num14 <= num13
						num12 = num12 + 1
					Loop While num12 <= num11
					ReDim Me.NOTES2(Me.dimnoterotfiltre(Module1.numeroparcelle) - 1 + 1 - 1)
					Dim num15 As Integer = Me.dimnoterotfiltre(Module1.numeroparcelle) - 1
					Dim num16 As Integer = 0
					Do
						Me.NOTES2(num16) = Module1.NOTESASS(Conversions.ToInteger(Me.COMBINAISONSFILTRE2(1, num16))) + Me.NOTESROT2(num16)
						Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(70 + CDbl((10 * num16)) / CDbl(Me.dimnoterotfiltre(Module1.numeroparcelle)))), "Calcul des notes...")
						num16 = num16 + 1
					Loop While num16 <= num15
					Module1.NOTEMAX2 = Me.NOTES2.Max()
					Module1.nbrrotationoptimisees2 = 0
					ReDim Module1.RESULTSROT2(Me.dimnoterotfiltre(Module1.numeroparcelle) + 1 - 1, Module1.numeroparcelle + 1 - 1)
					Dim num17 As Integer = Me.dimnoterotfiltre(Module1.numeroparcelle) - 1
					For i As Integer = 0 To num17 Step 1
						If (Me.NOTES2(i) = Module1.NOTEMAX2) Then
							Module1.nbrrotationoptimisees2 = Module1.nbrrotationoptimisees2 + 1
							Dim num18 As Integer = Module1.numeroparcelle
							Dim num19 As Integer = 1
							Do
								Module1.RESULTSROT2(Module1.nbrrotationoptimisees2, num19) = Module1.listelégumes(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Me.COMBINAISONSFILTRE2(0, i + 1), num19, 1))))
								num19 = num19 + 1
							Loop While num19 <= num18
							Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(80 + CDbl((15 * i)) / CDbl(Me.dimnoterotfiltre(Module1.numeroparcelle)))), "Calcul des notes...")
						End If
					Next

				End If
				If (Me.Empecherredondance2Menu.Checked) Then
					Me.compt = 0
					Me.rang = 0
					ReDim Me.COMBINAISONSFILTRE2(1, Me.dimnoterotfiltre(Module1.numeroparcelle) + 1 - 1)
					Dim num20 As Integer = Me.dimnoterotfiltre(Module1.numeroparcelle)
					Dim num21 As Integer = 1
					Do
						Dim num22 As Integer = Module1.numeroparcelle
						Dim num23 As Integer = 1
						Do
							If (Operators.CompareString(Microsoft.VisualBasic.Strings.Mid(Me.COMBINAISONSFILTRE1(0, num21), num23, 1), Me.chiffrecodecombinaisonchoisie(num23).ToString(), False) <> 0) Then
								Me.compt = Me.compt + 1
							End If
							num23 = num23 + 1
						Loop While num23 <= num22
						If (Me.compt = Module1.numeroparcelle) Then
							Me.rang = Me.rang + 1
							Me.COMBINAISONSFILTRE2(0, Me.rang) = Me.COMBINAISONSFILTRE1(0, num21)
							Me.COMBINAISONSFILTRE2(1, Me.rang) = Me.COMBINAISONSFILTRE1(1, num21)
						End If
						Me.compt = 0
						num21 = num21 + 1
					Loop While num21 <= num20
					If (Me.rang <> 0) Then
						ReDim Me.NOTESROT2(Me.rang - 1 + 1 - 1)
						Dim num24 As Integer = Me.rang - 1
						Dim num25 As Integer = 0
						Do
							Dim num26 As Integer = Module1.numeroparcelle
							Dim num27 As Integer = 1
							Do
								nOTESROT2 = Me.NOTESROT2
								num = num25
								nOTESROT2(num) = nOTESROT2(num) + Me.CELLULES(num27) * Module1.Base_de_données_rotations(Module1.Legumes_selectionnésconvertis(Me.chiffrecodecombinaisonchoisie(num27)), Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Me.COMBINAISONSFILTRE2(0, num25 + 1), num27, 1))))
								Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(10 + CDbl((60 * num25)) / CDbl(Me.rang))), "Calcul des notes...")
								num27 = num27 + 1
							Loop While num27 <= num26
							num25 = num25 + 1
						Loop While num25 <= num24
						ReDim Me.NOTES2(Me.rang - 1 + 1 - 1)
						Dim num28 As Integer = Me.rang - 1
						Dim num29 As Integer = 0
						Do
							Me.NOTES2(num29) = Module1.NOTESASS(Conversions.ToInteger(Me.COMBINAISONSFILTRE2(1, num29 + 1)) - 1) + Me.NOTESROT2(num29)
							Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(70 + CDbl((10 * num29)) / CDbl(Me.rang))), "Calcul des notes...")
							num29 = num29 + 1
						Loop While num29 <= num28
						Module1.NOTEMAX2 = Me.NOTES2.Max()
						Module1.nbrrotationoptimisees2 = 0
						ReDim Module1.RESULTSROT2(Me.rang + 1 - 1, Module1.numeroparcelle + 1 - 1)
						Dim num30 As Integer = Me.rang - 1
						For j As Integer = 0 To num30 Step 1
							If (Me.NOTES2(j) = Module1.NOTEMAX2) Then
								Module1.nbrrotationoptimisees2 = Module1.nbrrotationoptimisees2 + 1
								Dim num31 As Integer = Module1.numeroparcelle
								Dim num32 As Integer = 1
								Do
									Module1.RESULTSROT2(Module1.nbrrotationoptimisees2, num32) = Module1.listelégumes(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Me.COMBINAISONSFILTRE2(0, j + 1), num32, 1))))
									num32 = num32 + 1
								Loop While num32 <= num31
								Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(80 + CDbl((15 * j)) / CDbl(Me.rang))), "Calcul des notes...")
							End If
						Next

					End If
				End If
			End If
			If (Not Me.Empecherredondance1Menu.Checked) Then
				ReDim Me.NOTESROT2(Module1.factnumeroparcelle - 1 + 1 - 1)
				Dim num33 As Integer = Module1.factnumeroparcelle - 1
				Dim num34 As Integer = 0
				Do
					Dim num35 As Integer = Module1.numeroparcelle
					Dim num36 As Integer = 1
					Do
						nOTESROT2 = Me.NOTESROT2
						num = num34
						nOTESROT2(num) = nOTESROT2(num) + Me.CELLULES(num36) * Module1.Base_de_données_rotations(Module1.Legumes_selectionnésconvertis(Me.chiffrecodecombinaisonchoisie(num36)), Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(num34 + 1), num36, 1))))
						num36 = num36 + 1
					Loop While num36 <= num35
					Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(10 + CDbl((60 * num34)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes...")
					num34 = num34 + 1
				Loop While num34 <= num33
				ReDim Me.NOTES2(Module1.factnumeroparcelle - 1 + 1 - 1)
				Dim num37 As Integer = Module1.factnumeroparcelle - 1
				Dim num38 As Integer = 0
				Do
					Me.NOTES2(num38) = Module1.NOTESASS(num38) + Me.NOTESROT2(num38)
					Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(70 + CDbl((10 * num38)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes...")
					num38 = num38 + 1
				Loop While num38 <= num37
				Module1.NOTEMAX2 = Me.NOTES2.Max()
				Module1.nbrrotationoptimisees2 = 0
				ReDim Module1.RESULTSROT2(Module1.factnumeroparcelle + 1 - 1, Module1.numeroparcelle + 1 - 1)
				Dim num39 As Integer = Module1.factnumeroparcelle - 1
				For k As Integer = 0 To num39 Step 1
					If (Me.NOTES2(k) = Module1.NOTEMAX2) Then
						Module1.nbrrotationoptimisees2 = Module1.nbrrotationoptimisees2 + 1
						Dim num40 As Integer = Module1.numeroparcelle
						For l As Integer = 1 To num40 Step 1
							Module1.RESULTSROT2(Module1.nbrrotationoptimisees2, l) = Module1.listelégumes(Module1.Legumes_selectionnésconvertis(Conversions.ToInteger(Microsoft.VisualBasic.Strings.Mid(Module1.COMBINAISONS(k + 1), l, 1))))
						Next

					End If
					Me.BackgroundWorkerannee2.ReportProgress(CInt(Math.Round(80 + CDbl((15 * k)) / CDbl(Module1.factnumeroparcelle))), "Calcul des notes...")
				Next

			End If
		End Sub

		Private Sub BackgroundWorkerannee2_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
			Me.ProgressBar1.Value = e.ProgressPercentage
			Me.lblProgression.Text = Conversions.ToString(e.UserState)
		End Sub

		Private Sub BackgroundWorkerannee2_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			Me.GroupBoxannee2.Text = String.Concat("Année +2 - Calculée à partir de la combinaison ", Conversions.ToString(Module1.numerocombinaisonrotation2), "      ")
			Dim annee21 As System.Windows.Forms.Label = Me.Annee21
			Dim str() As String = { "La note de la meilleure configuration est ", Conversions.ToString(Module1.NOTEMAX2), "" & VbCrLf & "Sur une échelle allant de -", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees) }
			annee21.Text = String.Concat(str)
			Dim annee22 As System.Windows.Forms.Label = Me.Annee22
			str = New String() { "Il y a ", Conversions.ToString(Module1.nbrrotationoptimisees2), " configuration(s) optimisée(s) pour ", Conversions.ToString(Module1.factnumeroparcelle), " configurations possibles." }
			annee22.Text = String.Concat(str)
			If (Module1.nbrrotationoptimisees2 <= 3) Then
				Me.nbrrotationaffichees = Module1.nbrrotationoptimisees2
				Me.Annee23.Text = "Voici toutes les combinaisons optimisées:"
			Else
				Me.nbrrotationaffichees = 3
				Me.Annee23.Text = String.Concat("Voici 3 des ", Conversions.ToString(Module1.nbrrotationoptimisees2), " configurations optimisées:")
			End If
			Me.Résultatstab = Nothing
			ReDim Me.Résultatstab(Me.nbrrotationaffichees + 1 - 1, Module1.numeroparcelle + 1 - 1)
			Me.traitab = 1
			Me.Résultatstab(0, 0) = New System.Windows.Forms.Label()
			Dim résultatstab As System.Windows.Forms.Label = Me.Résultatstab(0, 0)
			résultatstab.Text = "Parcelle"
			Dim point As System.Drawing.Point = New System.Drawing.Point(Me.traitab, Me.traitab)
			résultatstab.Location = point
			résultatstab.BackColor = Color.DarkKhaki
			résultatstab.AutoEllipsis = True
			résultatstab.TextAlign = ContentAlignment.MiddleCenter
			Dim size As System.Drawing.Size = New System.Drawing.Size(Me.longcol1, Me.largcol)
			résultatstab.Size = size
			résultatstab = Nothing
			Me.Annee2.Controls.Add(Me.Résultatstab(0, 0))
			Dim num As Integer = Me.nbrrotationaffichees
			Dim num1 As Integer = 1
			Do
				Me.Résultatstab(num1, 0) = New System.Windows.Forms.Label()
				Dim darkKhaki As System.Windows.Forms.Label = Me.Résultatstab(num1, 0)
				darkKhaki.BackColor = Color.DarkKhaki
				darkKhaki.AutoEllipsis = True
				darkKhaki.Text = String.Concat("Combinaison ", num1.ToString())
				size = New System.Drawing.Size(Me.longcol, Me.largcol)
				darkKhaki.Size = size
				point = New System.Drawing.Point(Me.longcol1 + (num1 - 1) * Me.longcol + (num1 + 1) * Me.traitab, Me.traitab)
				darkKhaki.Location = point
				darkKhaki = Nothing
				Me.Annee2.Controls.Add(Me.Résultatstab(num1, 0))
				num1 = num1 + 1
			Loop While num1 <= num
			Dim num2 As Integer = Module1.numeroparcelle
			Dim num3 As Integer = 1
			Do
				Me.Résultatstab(0, num3) = New System.Windows.Forms.Label()
				Dim label As System.Windows.Forms.Label = Me.Résultatstab(0, num3)
				label.BackColor = Module1.couleurs(num3)
				label.AutoEllipsis = True
				label.Text = num3.ToString()
				label.TextAlign = ContentAlignment.MiddleCenter
				size = New System.Drawing.Size(Me.longcol1, Me.largcol)
				label.Size = size
				point = New System.Drawing.Point(Me.traitab, num3 * Me.largcol + (num3 + 1) * Me.traitab)
				label.Location = point
				label = Nothing
				Me.Annee2.Controls.Add(Me.Résultatstab(0, num3))
				num3 = num3 + 1
			Loop While num3 <= num2
			Dim num4 As Integer = Me.nbrrotationaffichees
			Dim num5 As Integer = 1
			Do
				Dim num6 As Integer = Module1.numeroparcelle
				Dim num7 As Integer = 1
				Do
					Me.Résultatstab(num5, num7) = New System.Windows.Forms.Label()
					Dim rESULTSROT2 As System.Windows.Forms.Label = Me.Résultatstab(num5, num7)
					rESULTSROT2.BackColor = Color.DarkKhaki
					rESULTSROT2.AutoEllipsis = True
					rESULTSROT2.Text = Module1.RESULTSROT2(num5, num7)
					size = New System.Drawing.Size(Me.longcol, Me.largcol)
					rESULTSROT2.Size = size
					point = New System.Drawing.Point(Me.longcol1 + (num5 - 1) * Me.longcol + (num5 + 1) * Me.traitab, num7 * Me.largcol + (num7 + 1) * Me.traitab)
					rESULTSROT2.Location = point
					rESULTSROT2 = Nothing
					Me.Annee2.Controls.Add(Me.Résultatstab(num5, num7))
					num7 = num7 + 1
				Loop While num7 <= num6
				num5 = num5 + 1
			Loop While num5 <= num4
			Dim annee2 As System.Windows.Forms.Panel = Me.Annee2
			annee2.BackColor = Color.Black
			point = New System.Drawing.Point(Module1.screenadaptX(10), Module1.screenadaptY(120))
			annee2.Location = point
			size = New System.Drawing.Size(Me.nbrrotationaffichees * Me.longcol + Me.longcol1 + (Me.nbrrotationaffichees + 2) * Me.traitab, (Module1.numeroparcelle + 1) * Module1.screenadaptY(14) + (Module1.numeroparcelle + 2) * Me.traitab)
			annee2.Size = size
			annee2.Visible = True
			annee2 = Nothing
			Dim groupBoxannee2 As myGroupBox = Me.GroupBoxannee2
			Dim mgauche As Integer = Me.Mgauche + Me.Lgrille + Module1.screenadaptX(30) + Me.Llegcont + Module1.screenadaptX(90)
			point = Me.AutoScrollPosition
			Dim point1 As System.Drawing.Point = New System.Drawing.Point(mgauche, point.Y + Me.Mhaut + (Module1.screenadaptY(120) + (Module1.screenadaptY(14) + 2) * (Module1.numeroparcelle + 1) + Module1.screenadaptY(10) + Module1.screenadaptY(40)) * 2)
			groupBoxannee2.Location = point1
			size = New System.Drawing.Size(Module1.screenadaptX(500), Module1.screenadaptY(120) + (Me.largcol + 2) * (Module1.numeroparcelle + 1) + Module1.screenadaptY(10))
			groupBoxannee2.Size = size
			groupBoxannee2.Visible = True
			groupBoxannee2.Controls.Add(Me.Annee2)
			groupBoxannee2 = Nothing
			Me.PHOTOPANEL(Me.Annee2)
			Me.Résultatstab = Nothing
			Me.ProgressBar1.Value = 100
			Me.lblProgression.Text = "Calculs terminés"
			Me.StatutLabel.Text = "Le calcul de la seconde rotation a été effectué avec succès! Le programme est maintenant terminé."
			Me.ResultatsAssociationMenu.Enabled = True
			Me.AfficherCombinaisons1Menu.Enabled = True
			Me.AfficherCombinaisons2Menu.Enabled = True
			Me.ImprimerMenu.Enabled = True
			Me.EnregistrerSousMenu.Enabled = True
			Me.BilanMenu.Enabled = True
			Me.CalculerAnnee0Menu.Enabled = True
			Me.btnAnnee0.Enabled = True
			Me.CalculerAnnee1Menu.Enabled = True
			Me.btnAnnee1.Enabled = True
			Me.CalculerAnnee2Menu.Enabled = True
			Me.btnAnnee2.Enabled = True
			Me.Cursor = Cursors.[Default]
			Me.Refresh()
		End Sub

		Private Sub BilanMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Module1.loadbilan) Then
				Me.WinBilan = New FormBilan()
				Me.WinBilan.Show()
				Module1.loadbilan = True
			Else
				Me.WinBilan.Activate()
			End If
		End Sub

		Private Sub btnAnnee0_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CalculerAnnee0Menu.PerformClick()
		End Sub

		Private Sub btnAnnee1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CalculerAnnee1Menu.PerformClick()
		End Sub

		Private Sub btnAnnee2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.CalculerAnnee2Menu.PerformClick()
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer
			Dim num1 As Integer = 0
			Dim num2 As Integer = Me.nbrcellules - 1
			Dim num3 As Integer = 0
			Do
				Dim num4 As Integer = Me.nbrcellules - 1
				num = 0
				Do
					If (Me.grille(num3, num).Checked) Then
						num1 = num1 + 1
					End If
					num = num + 1
				Loop While num <= num4
				num3 = num3 + 1
			Loop While num3 <= num2
			If (num1 > 0 And Module1.numeroparcelle < Module1.nbrmaxparcelles + 1) Then
				Module1.numeroparcelle = Module1.numeroparcelle + 1
			End If
			If (Module1.numeroparcelle >= Module1.nbrmaxparcelles + 1) Then
				MyProject.Forms.FormPasPas.Msgboxperso("Vous avez atteint le nombre limite de parcelles", "Ail! Plus z'un zeste...")
				Dim num5 As Integer = Me.nbrcellules - 1
				num3 = 0
				Do
					Dim num6 As Integer = Me.nbrcellules - 1
					num = 0
					Do
						If (Me.grille(num3, num).Checked) Then
							Me.grille(num3, num).Checked = False
						End If
						num = num + 1
					Loop While num <= num6
					num3 = num3 + 1
				Loop While num3 <= num5
				Module1.numeroparcelle = Module1.numeroparcelle - 1
			ElseIf (num1 <= 0) Then
				MyProject.Forms.FormPasPas.Msgboxperso("Vous n'avez sélectionner aucune cellule!", "Ail! Plus z'un zeste...")
			Else
				Dim num7 As Integer = Me.nbrcellules - 1
				num3 = 0
				Do
					Dim num8 As Integer = Me.nbrcellules - 1
					num = 0
					Do
						If (Me.grille(num3, num).Checked) Then
							Dim str As CheckBox = Me.grille(num3, num)
							str.Checked = False
							str.BackColor = Module1.couleurs(Module1.numeroparcelle)
							str.Text = Module1.numeroparcelle.ToString()
							str.TextAlign = ContentAlignment.TopLeft
							str.Font = New System.Drawing.Font("Calibri", CSng(Module1.screenadaptfont(8)), FontStyle.Bold)
							str.Enabled = False
							str = Nothing
						End If
						num = num + 1
					Loop While num <= num8
					num3 = num3 + 1
				Loop While num3 <= num7
				Me.Légume = DirectCast(Utils.CopyArray(DirectCast(Me.Légume, Array), New ComboBox(1, Module1.numeroparcelle + 1 - 1) {}), ComboBox(,))
				Me.Légume(1, Module1.numeroparcelle) = New ComboBox()
				Dim légume As ComboBox = Me.Légume(1, Module1.numeroparcelle)
				légume.DrawMode = DrawMode.OwnerDrawFixed
				Dim point As System.Drawing.Point = New System.Drawing.Point(Module1.screenadaptX(10), (Module1.numeroparcelle - 1) * Module1.screenadaptY(25) + Module1.screenadaptY(25))
				légume.Location = point
				Dim comboX As Integer = Me.ComboX
				Dim size As System.Drawing.Size = légume.Size
				Dim size1 As System.Drawing.Size = New System.Drawing.Size(comboX, Module1.screenadaptY(size.Height))
				légume.Size = size1
				légume.DropDownStyle = ComboBoxStyle.DropDownList
				AddHandler légume.DrawItem,  New DrawItemEventHandler(AddressOf Module1.filtredrawitemb)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				AddHandler légume.Click,  New EventHandler(AddressOf calculatrice.comboclick)
				Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
				AddHandler légume.SelectedIndexChanged,  New EventHandler(AddressOf calculatrice1.selectedindexchanged)
				légume = Nothing
				Dim num9 As Integer = Module1.nbrlegumesbase - 1
				Dim num10 As Integer = 0
				Do
					Me.Légume(1, Module1.numeroparcelle).Items.Add(Module1.listelégumes(num10))
					num10 = num10 + 1
				Loop While num10 <= num9
				Dim groupBoxlégumes As myGroupBox = Me.GroupBoxlégumes
				groupBoxlégumes.Controls.Add(Me.Légume(1, Module1.numeroparcelle))
				size1 = New System.Drawing.Size(Me.Llegcont, Module1.screenadaptY(25) * (Module1.numeroparcelle + 1) + Module1.screenadaptY(10))
				groupBoxlégumes.Size = size1
				groupBoxlégumes.Visible = True
				groupBoxlégumes = Nothing
				Me.CalculerAnnee1Menu.Enabled = False
				Me.CalculerAnnee2Menu.Enabled = False
				Me.btnAnnee1.Enabled = False
				Me.btnAnnee2.Enabled = False
			End If
		End Sub

		Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer
			Dim num1 As Integer = 0
			Dim num2 As Integer = Me.nbrcellules - 1
			Dim num3 As Integer = 0
			Do
				Dim num4 As Integer = Me.nbrcellules - 1
				num = 0
				Do
					If (Me.grille(num3, num).Checked) Then
						num1 = num1 + 1
					End If
					num = num + 1
				Loop While num <= num4
				num3 = num3 + 1
			Loop While num3 <= num2
			If (num1 > 0 And Module1.numerocontrainte < Module1.nbrmaxcontraintes + 1) Then
				Module1.numerocontrainte = Module1.numerocontrainte + 1
			End If
			If (Module1.numerocontrainte >= Module1.nbrmaxcontraintes + 1) Then
				MyProject.Forms.FormPasPas.Msgboxperso("Vous avez atteint le nombre limite de contraintes", "Ail! Plus z'un zeste!")
				Dim num5 As Integer = Me.nbrcellules - 1
				num3 = 0
				Do
					Dim num6 As Integer = Me.nbrcellules - 1
					num = 0
					Do
						If (Me.grille(num3, num).Checked) Then
							Me.grille(num3, num).Checked = False
						End If
						num = num + 1
					Loop While num <= num6
					num3 = num3 + 1
				Loop While num3 <= num5
				Module1.numerocontrainte = Module1.numerocontrainte - 1
			ElseIf (num1 <= 0) Then
				MyProject.Forms.FormPasPas.Msgboxperso("Vous n'avez sélectionner aucune cellule!", "Ail! Plus z'un zeste!")
			Else
				Dim num7 As Integer = Me.nbrcellules - 1
				num3 = 0
				Do
					Dim num8 As Integer = Me.nbrcellules - 1
					num = 0
					Do
						If (Me.grille(num3, num).Checked) Then
							Dim font As CheckBox = Me.grille(num3, num)
							font.Checked = False
							font.BackColor = Module1.couleurscont(Module1.numerocontrainte)
							font.Text = String.Concat("C", Conversions.ToString(Module1.numerocontrainte))
							font.TextAlign = ContentAlignment.TopLeft
							font.Font = New System.Drawing.Font("Calibri", CSng(Module1.screenadaptfont(8)), FontStyle.Bold)
							font.Enabled = False
							font = Nothing
						End If
						num = num + 1
					Loop While num <= num8
					num3 = num3 + 1
				Loop While num3 <= num7
				Me.Légumecont = DirectCast(Utils.CopyArray(DirectCast(Me.Légumecont, Array), New ComboBox(1, Module1.numerocontrainte + 1 - 1) {}), ComboBox(,))
				Me.Légumecont(1, Module1.numerocontrainte) = New ComboBox()
				Dim légumecont As ComboBox = Me.Légumecont(1, Module1.numerocontrainte)
				légumecont.DrawMode = DrawMode.OwnerDrawFixed
				Dim point As System.Drawing.Point = New System.Drawing.Point(Module1.screenadaptX(10), (Module1.numerocontrainte - 1) * Module1.screenadaptY(25) + Module1.screenadaptY(25))
				légumecont.Location = point
				Dim comboX As Integer = Me.ComboX
				Dim size As System.Drawing.Size = légumecont.Size
				Dim size1 As System.Drawing.Size = New System.Drawing.Size(comboX, Module1.screenadaptY(size.Height))
				légumecont.Size = size1
				légumecont.DropDownStyle = ComboBoxStyle.DropDownList
				légumecont.FlatStyle = FlatStyle.Flat
				légumecont.BackColor = Module1.couleurscont(Module1.numerocontrainte)
				AddHandler légumecont.DrawItem,  New DrawItemEventHandler(AddressOf Module1.filtredrawitemcont)
				Dim calculatrice As SVPLCApplication.Calculatrice = Me
				AddHandler légumecont.Click,  New EventHandler(AddressOf calculatrice.comboclick)
				Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
				AddHandler légumecont.SelectedIndexChanged,  New EventHandler(AddressOf calculatrice1.selectedindexchanged)
				légumecont = Nothing
				Dim num9 As Integer = Module1.nbrlegumesbase - 1
				Dim num10 As Integer = 0
				Do
					Me.Légumecont(1, Module1.numerocontrainte).Items.Add(Module1.listelégumes(num10))
					num10 = num10 + 1
				Loop While num10 <= num9
				Dim groupBoxcontraintes As myGroupBox = Me.GroupBoxcontraintes
				groupBoxcontraintes.Controls.Add(Me.Légumecont(1, Module1.numerocontrainte))
				size1 = New System.Drawing.Size(Me.Llegcont, Module1.screenadaptY(25) * (Module1.numerocontrainte + 1) + Module1.screenadaptY(10))
				groupBoxcontraintes.Size = size1
				groupBoxcontraintes.Visible = True
				groupBoxcontraintes = Nothing
			End If
		End Sub

		Private Sub Buttonreset_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.ResetMenu.PerformClick()
		End Sub

		Private Sub Calculatrice_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadcalc = False
		End Sub

		Private Sub CalculerAnnee0Menu_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer
			If (Module1.numeroparcelle + Module1.numerocontrainte > 1) Then
				Me.GroupBoxannee0.Visible = False
				Me.GroupBoxannee1.Visible = False
				Me.GroupBoxannee2.Visible = False
				Me.Annee0.Controls.Clear()
				Me.Annee1.Controls.Clear()
				Me.Annee2.Controls.Clear()
				If (Module1.loadcombass) Then
					Me.COMBASS.Close()
					Module1.loadcombass = False
				End If
				If (Module1.loadcombrot1) Then
					Me.COMBROT1.Close()
					Module1.loadcombrot1 = False
				End If
				If (Module1.loadcombrot2) Then
					Me.COMBROT2.Close()
					Module1.loadcombrot2 = False
				End If
				If (Module1.loadbilan) Then
					Me.WinBilan.Close()
					Module1.loadbilan = False
				End If
				Module1.Legumes_selectionnésconvertis = Nothing
				Module1.Contraintes_selectionnéesconvertis = Nothing
				Module1.COULEURSUTILES = Nothing
				Me.FRONTIERES = Nothing
				Module1.Notepp = Nothing
				Module1.Notepc = Nothing
				Module1.NOTESASS = Nothing
				Dim progressBar1 As ProgressBar = Me.ProgressBar1
				progressBar1.Minimum = 0
				progressBar1.Maximum = 100
				progressBar1.Value = 0
				progressBar1 = Nothing
				Me.StatutLabel.Text = "Algorithme en cours..."
				Me.lblProgression.Text = "Vérification des entrées..."
				Me.Refresh()
				Me.parcelleok = False
				Me.contrainteok = False
				Me.compt = 0
				Dim num1 As Integer = Module1.numeroparcelle
				Dim num2 As Integer = 1
				Do
					If (Operators.CompareString(Me.Légume(1, num2).Text, "", False) <> 0) Then
						Me.compt = Me.compt + 1
					End If
					num2 = num2 + 1
				Loop While num2 <= num1
				If (Me.compt = Module1.numeroparcelle) Then
					Me.parcelleok = True
				End If
				Me.compt = 0
				Dim num3 As Integer = Module1.numerocontrainte
				num2 = 1
				Do
					If (Operators.CompareString(Me.Légumecont(1, num2).Text, "", False) <> 0) Then
						Me.compt = Me.compt + 1
					End If
					num2 = num2 + 1
				Loop While num2 <= num3
				If (Me.compt = Module1.numerocontrainte) Then
					Me.contrainteok = True
				End If
				If (Not Me.parcelleok) Then
					MyProject.Forms.FormPasPas.Msgboxperso("Vous avez saisi moins de légumes que le nombre indiqué." & VbCrLf & "Veuillez renseigner tous les champs de légumes.", "Ail! Plus z'un zeste!")
					Me.lblProgression.Text = ""
					Me.StatutLabel.Text = "Veuillez vérifier les entrées et relancer le calcul"
					Me.Refresh()
				ElseIf (Me.contrainteok) Then
					Me.Cursor = Cursors.WaitCursor
					Me.lblProgression.Text = "Initialisation des calculs..."
					Me.Refresh()
					ReDim Module1.Legumes_selectionnésconvertis(Module1.numeroparcelle + 1 - 1)
					Dim num4 As Integer = Module1.numeroparcelle
					num2 = 1
					Do
						Dim num5 As Integer = Module1.nbrlegumesbase - 1
						num = 0
						Do
							If (Operators.CompareString(Module1.listelégumes(num), Me.Légume(1, num2).Text, False) = 0) Then
								Module1.Legumes_selectionnésconvertis(num2) = num
							End If
							num = num + 1
						Loop While num <= num5
						num2 = num2 + 1
					Loop While num2 <= num4
					Me.ProgressBar1.Value = 5
					ReDim Module1.Contraintes_selectionnéesconvertis(Module1.numerocontrainte + 1 - 1)
					Dim num6 As Integer = Module1.numerocontrainte
					num2 = 1
					Do
						Dim num7 As Integer = Module1.nbrlegumesbase - 1
						num = 0
						Do
							If (Operators.CompareString(Me.Légumecont(1, num2).Text, Module1.listelégumes(num), False) = 0) Then
								Module1.Contraintes_selectionnéesconvertis(num2) = num
							End If
							num = num + 1
						Loop While num <= num7
						num2 = num2 + 1
					Loop While num2 <= num6
					Me.ProgressBar1.Value = 10
					ReDim Module1.COULEURSUTILES(Module1.numeroparcelle + Module1.numerocontrainte + 1 - 1)
					Dim num8 As Integer = Module1.numeroparcelle
					num2 = 1
					Do
						Module1.COULEURSUTILES(num2) = Module1.couleurs(num2)
						num2 = num2 + 1
					Loop While num2 <= num8
					Dim num9 As Integer = Module1.numeroparcelle + 1
					Dim num10 As Integer = Module1.numerocontrainte + Module1.numeroparcelle
					num = num9
					Do
						Module1.COULEURSUTILES(num) = Module1.couleurscont(num - Module1.numeroparcelle)
						num = num + 1
					Loop While num <= num10
					Me.ProgressBar1.Value = 15
					Me.lblProgression.Text = "Comptage des frontières partagées..."
					Me.Refresh()
					ReDim Me.FRONTIERES(Module1.numeroparcelle + Module1.numerocontrainte + 1 - 1, Module1.numeroparcelle + Module1.numerocontrainte + 1 - 1)
					Dim num11 As Integer = Module1.numeroparcelle + Module1.numerocontrainte
					Dim num12 As Integer = 1
					Do
						Dim num13 As Integer = Module1.numeroparcelle + Module1.numerocontrainte
						Dim num14 As Integer = 1
						Do
							Me.compt = 0
							Dim num15 As Integer = Me.nbrcellules - 1
							num2 = 0
							Do
								Dim num16 As Integer = Me.nbrcellules - 1
								num = 0
								Do
									If (Me.grille(num2, num).BackColor = Module1.COULEURSUTILES(num12)) Then
										If (num2 = 0) Then
											If (num = 0) Then
												If (Me.grille(num2 + 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num + 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
											End If
											If (num = Me.nbrcellules - 1) Then
												If (Me.grille(num2 + 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num - 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
											End If
											If (num <> 0 And num <> Me.nbrcellules - 1) Then
												If (Me.grille(num2 + 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num + 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num - 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
											End If
										End If
										If (num2 = Me.nbrcellules - 1) Then
											If (num = 0) Then
												If (Me.grille(num2 - 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num + 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
											End If
											If (num = Me.nbrcellules - 1) Then
												If (Me.grille(num2 - 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num - 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
											End If
											If (num <> 0 And num <> Me.nbrcellules - 1) Then
												If (Me.grille(num2 - 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num + 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
												If (Me.grille(num2, num - 1).BackColor = Module1.COULEURSUTILES(num14)) Then
													Me.compt = Me.compt + 1
												End If
											End If
										End If
										If (num = 0 AndAlso num2 <> 0 And num2 <> Me.nbrcellules - 1) Then
											If (Me.grille(num2 - 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
											If (Me.grille(num2 + 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
											If (Me.grille(num2, num + 1).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
										End If
										If (num = Me.nbrcellules - 1 AndAlso num2 <> 0 And num2 <> Me.nbrcellules - 1) Then
											If (Me.grille(num2 - 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
											If (Me.grille(num2 + 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
											If (Me.grille(num2, num - 1).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
										End If
										If (0 < num2 And num2 < Me.nbrcellules - 1 AndAlso 0 < num And num < Me.nbrcellules - 1) Then
											If (Me.grille(num2 + 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
											If (Me.grille(num2 - 1, num).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
											If (Me.grille(num2, num + 1).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
											If (Me.grille(num2, num - 1).BackColor = Module1.COULEURSUTILES(num14)) Then
												Me.compt = Me.compt + 1
											End If
										End If
									End If
									num = num + 1
								Loop While num <= num16
								num2 = num2 + 1
							Loop While num2 <= num15
							Me.FRONTIERES(num12, num14) = Me.compt
							num14 = num14 + 1
						Loop While num14 <= num13
						num12 = num12 + 1
					Loop While num12 <= num11
					Module1.nbrfrontierespartagees = 0
					Dim num17 As Integer = Module1.numeroparcelle + Module1.numerocontrainte
					num2 = 1
					Do
						Dim num18 As Integer = Module1.numeroparcelle + Module1.numerocontrainte
						num = 1
						Do
							If (num2 <> num) Then
								Module1.nbrfrontierespartagees = Module1.nbrfrontierespartagees + Me.FRONTIERES(num2, num)
							End If
							num = num + 1
						Loop While num <= num18
						num2 = num2 + 1
					Loop While num2 <= num17
					Module1.nbrfrontierespartagees /= 2
					Me.ProgressBar1.Value = 20
					Me.lblProgression.Text = "Récupération des combinaisons..."
					Me.Refresh()
					Me.BackgroundWorkerannee0.RunWorkerAsync()
				End If
			End If
		End Sub

		Private Sub CalculerAnnee1Menu_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Module1.numeroparcelle > 1) Then
				Module1.numerocombinaisonrotation1 = 0
				If (Module1.nbrsolutionoptimisees <= 1) Then
					Module1.numerocombinaisonrotation1 = 1
				Else
					While True
						Me.rep = MyProject.Forms.FormPasPas.Inputboxperso(String.Concat("Veuillez entrez le numero de la combinaison pour laquelle vous voulez calculer la première rotation" & VbCrLf & "Le chiffre dois être compris entre 1 et ", Conversions.ToString(Module1.nbrsolutionoptimisees), "."), "Entrée des paramètres du calcul")
						Try
							If (Operators.CompareString(Me.rep, "", False) <> 0) Then
								Module1.numerocombinaisonrotation1 = Conversions.ToInteger(Me.rep)
								If (Module1.numerocombinaisonrotation1 <= Module1.nbrsolutionoptimisees) Then
									Exit While
								Else
									MyProject.Forms.FormPasPas.Msgboxperso("Le numéro de combinaison saisi est beaucoup trop grand!", "Ail! Plus z'un zeste!")
								End If
							Else
								Return
							End If
						Catch exception As System.Exception
							ProjectData.SetProjectError(exception)
							MyProject.Forms.FormPasPas.Msgboxperso("Le barratin n'est pas autorisé. Merci.", "Ail! Plus z'un zeste!")
							ProjectData.ClearProjectError()
						End Try
					End While
				End If
				If (Module1.numerocombinaisonrotation1 <> 0) Then
					If (Module1.loadcombrot1) Then
						Me.COMBROT1.Close()
						Module1.loadcombrot1 = False
					End If
					If (Module1.loadcombrot2) Then
						Me.COMBROT2.Close()
						Module1.loadcombrot2 = False
					End If
					If (Module1.loadbilan) Then
						Me.WinBilan.Close()
						Module1.loadbilan = False
					End If
					Me.Cursor = Cursors.WaitCursor
					Me.GroupBoxannee1.Visible = False
					Me.GroupBoxannee2.Visible = False
					Me.Annee1.Controls.Clear()
					Me.Annee2.Controls.Clear()
					Me.BackgroundWorkerannee1.RunWorkerAsync()
				End If
			End If
			Me.StatutLabel.Text = "Algorithme en cours..."
			Me.Refresh()
		End Sub

		Private Sub CalculerAnnee2Menu_Click(ByVal sender As Object, ByVal e As EventArgs)
			Module1.numerocombinaisonrotation2 = 0
			If (Module1.nbrrotationoptimisees1 <= 1) Then
				Module1.numerocombinaisonrotation2 = 1
			Else
				While True
					Me.rep = MyProject.Forms.FormPasPas.Inputboxperso(String.Concat("Veuillez entrez le numero de la combinaison pour laquelle vous voulez calculer la seconde rotation" & VbCrLf & "Le chiffre dois être compris entre 1 et ", Conversions.ToString(Module1.nbrrotationoptimisees1), "."), "Entrée des paramètres du calcul")
					Try
						If (Operators.CompareString(Me.rep, "", False) <> 0) Then
							Module1.numerocombinaisonrotation2 = Conversions.ToInteger(Me.rep)
							If (Module1.numerocombinaisonrotation2 <= Module1.nbrrotationoptimisees1) Then
								Exit While
							Else
								MyProject.Forms.FormPasPas.Msgboxperso("Le numéro de combinaison saisi est beaucoup trop grand!", "Ail! Plus z'un zeste!")
							End If
						Else
							Return
						End If
					Catch exception As System.Exception
						ProjectData.SetProjectError(exception)
						MyProject.Forms.FormPasPas.Msgboxperso("Le barratin n'est pas autorisé. Merci.", "Ail! Plus z'un zeste!")
						ProjectData.ClearProjectError()
					End Try
				End While
			End If
			If (Module1.numerocombinaisonrotation2 <> 0) Then
				If (Module1.loadcombrot2) Then
					Me.COMBROT2.Close()
					Module1.loadcombrot2 = False
				End If
				If (Module1.loadbilan) Then
					Me.WinBilan.Close()
					Module1.loadbilan = False
				End If
				Me.Cursor = Cursors.WaitCursor
				Me.GroupBoxannee2.Visible = False
				Me.Annee2.Controls.Clear()
				Me.BackgroundWorkerannee2.RunWorkerAsync()
			End If
			Me.StatutLabel.Text = "Algorithme en cours..."
		End Sub

		Public Function cellule(ByVal x As Integer) As Integer
			Dim num As Integer = 0
			Dim num1 As Integer = Me.nbrcellules - 1
			Dim num2 As Integer = 0
			Do
				Dim num3 As Integer = Me.nbrcellules - 1
				Dim num4 As Integer = 0
				Do
					If (Me.grille(num2, num4).BackColor = Module1.couleurs(x)) Then
						num = num + 1
					End If
					num4 = num4 + 1
				Loop While num4 <= num3
				num2 = num2 + 1
			Loop While num2 <= num1
			Return num
		End Function

		Public Function cellulecont(ByVal x As Integer) As Integer
			Dim num As Integer = 0
			Dim num1 As Integer = Me.nbrcellules - 1
			Dim num2 As Integer = 0
			Do
				Dim num3 As Integer = Me.nbrcellules - 1
				Dim num4 As Integer = 0
				Do
					If (Me.grille(num2, num4).BackColor = Module1.couleurscont(x)) Then
						num = num + 1
					End If
					num4 = num4 + 1
				Loop While num4 <= num3
				num2 = num2 + 1
			Loop While num2 <= num1
			Return num
		End Function

		Private Sub CheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim obj As Object = sender
			Dim objArray() As Object = { False }
			NewLateBinding.LateSet(obj, Nothing, "enabled", objArray, Nothing, Nothing)
			objArray = New Object() { True }
			NewLateBinding.LateSet(obj, Nothing, "enabled", objArray, Nothing, Nothing)
			obj = Nothing
		End Sub

		Private Sub CheckBox_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim color As System.Drawing.Color = New System.Drawing.Color()
			Dim seaGreen As Object()
			Dim color1 As System.Drawing.Color
			Dim color2 As System.Drawing.Color
			Dim flag As Boolean = True
			If (Me.CheckBoxsupp.Checked) Then
				If (Module1.numeroparcelle > 1) Then
					Dim num As Integer = Module1.numeroparcelle - 1
					For i As Integer = 1 To num Step 1
						Dim flag1 As Boolean = Me.cellule(i) = 1
						Dim obj As Object = NewLateBinding.LateGet(sender, Nothing, "Backcolor", New Object(-1) {}, Nothing, Nothing, Nothing)
						If (obj IsNot Nothing) Then
							color2 = DirectCast(obj, System.Drawing.Color)
						Else
							color2 = color
						End If
						If (flag1 And (color2 = Module1.couleurs(i))) Then
							seaGreen = New Object() { False }
							NewLateBinding.LateSet(sender, Nothing, "Checked", seaGreen, Nothing, Nothing)
							MyProject.Forms.FormPasPas.Msgboxperso("Vous ne pouvez supprimer entièrement que la dernière parcelle partitionnée", "Ail! Plus z'un zeste!")
							flag = False
						End If
					Next

				End If
				If (Module1.numerocontrainte > 1) Then
					Dim num1 As Integer = Module1.numerocontrainte - 1
					For j As Integer = 1 To num1 Step 1
						Dim flag2 As Boolean = Me.cellulecont(j) = 1
						Dim obj1 As Object = NewLateBinding.LateGet(sender, Nothing, "Backcolor", New Object(-1) {}, Nothing, Nothing, Nothing)
						If (obj1 IsNot Nothing) Then
							color1 = DirectCast(obj1, System.Drawing.Color)
						Else
							color1 = color
						End If
						If (flag2 And (color1 = Module1.couleurscont(j))) Then
							seaGreen = New Object() { False }
							NewLateBinding.LateSet(sender, Nothing, "Checked", seaGreen, Nothing, Nothing)
							MyProject.Forms.FormPasPas.Msgboxperso("Vous ne pouvez supprimer entièrement que la dernière contrainte partitionnée", "Ail! Plus z'un zeste!")
							flag = False
						End If
					Next

				End If
				If (flag AndAlso Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, Nothing, "Checked", New Object(-1) {}, Nothing, Nothing, Nothing), True, False)) Then
					Dim obj2 As Object = sender
					seaGreen = New Object() { "" }
					NewLateBinding.LateSet(obj2, Nothing, "Text", seaGreen, Nothing, Nothing)
					seaGreen = New Object() { False }
					NewLateBinding.LateSet(obj2, Nothing, "Checked", seaGreen, Nothing, Nothing)
					seaGreen = New Object() { System.Drawing.Color.SeaGreen }
					NewLateBinding.LateSet(obj2, Nothing, "BackColor", seaGreen, Nothing, Nothing)
					obj2 = Nothing
				End If
			End If
		End Sub

		Private Sub CheckBox_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
			Me.mousedownQ = True
		End Sub

		Private Sub CheckBox_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.mousedownQ And Not Me.CheckBoxsupp.Checked AndAlso Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, Nothing, "Checked", New Object(-1) {}, Nothing, Nothing, Nothing), False, False)) Then
				Dim objArray() As Object = { True }
				NewLateBinding.LateSet(sender, Nothing, "Checked", objArray, Nothing, Nothing)
			End If
		End Sub

		Private Sub CheckBox_MouseUp(ByVal sender As Object, ByVal e As EventArgs)
			Me.mousedownQ = False
		End Sub

		Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim i As Integer
			Dim j As Integer
			Dim str As String
			Dim size As System.Drawing.Size
			If (Me.CheckBoxsupp.Checked) Then
				Dim panel As System.Windows.Forms.Panel = Me.Panel
				str = String.Concat(Application.StartupPath.ToString(), "\grass.cur")
				panel.Cursor = New System.Windows.Forms.Cursor(Calculatrice.LoadCursorFromFile(str))
				Me.Buttonpart.Enabled = False
				Me.CalculerAnnee0Menu.Enabled = False
				Me.Buttonpartaveccontrainte.Enabled = False
				Dim num As Integer = Me.nbrcellules - 1
				For i = 0 To num Step 1
					Dim num1 As Integer = Me.nbrcellules - 1
					For j = 0 To num1 Step 1
						If (Me.grille(i, j).BackColor = Color.SeaGreen) Then
							Me.grille(i, j).Enabled = False
						Else
							Me.grille(i, j).Enabled = True
						End If
					Next

				Next

			End If
			If (Not Me.CheckBoxsupp.Checked) Then
				Dim cursor As System.Windows.Forms.Panel = Me.Panel
				str = String.Concat(Application.StartupPath.ToString(), "\Pellecurseur.cur")
				cursor.Cursor = New System.Windows.Forms.Cursor(Calculatrice.LoadCursorFromFile(str))
				Me.Buttonpart.Enabled = True
				Me.CalculerAnnee0Menu.Enabled = True
				Me.Buttonpartaveccontrainte.Enabled = True
				Dim num2 As Integer = Me.nbrcellules - 1
				For i = 0 To num2 Step 1
					Dim num3 As Integer = Me.nbrcellules - 1
					For j = 0 To num3 Step 1
						If (Me.grille(i, j).BackColor = Color.SeaGreen) Then
							Me.grille(i, j).Enabled = True
						Else
							Me.grille(i, j).Enabled = False
						End If
					Next

				Next

			End If
			If (Not Me.CheckBoxsupp.Checked And Module1.numeroparcelle > 0 AndAlso Me.cellule(Module1.numeroparcelle) = 0) Then
				Dim groupBoxlégumes As myGroupBox = Me.GroupBoxlégumes
				groupBoxlégumes.Controls.Remove(Me.Légume(1, Module1.numeroparcelle))
				size = New System.Drawing.Size(Me.Llegcont, Module1.screenadaptY(25) * (Module1.numeroparcelle + 1) + Module1.screenadaptY(10))
				groupBoxlégumes.Size = size
				groupBoxlégumes = Nothing
				Module1.numeroparcelle = Module1.numeroparcelle - 1
				Me.Légume = DirectCast(Utils.CopyArray(DirectCast(Me.Légume, Array), New ComboBox(1, Module1.numeroparcelle + 1 - 1) {}), ComboBox(,))
			End If
			If (Not Me.CheckBoxsupp.Checked And Module1.numerocontrainte > 0 AndAlso Me.cellulecont(Module1.numerocontrainte) = 0) Then
				Dim groupBoxcontraintes As myGroupBox = Me.GroupBoxcontraintes
				groupBoxcontraintes.Controls.Remove(Me.Légumecont(1, Module1.numerocontrainte))
				size = New System.Drawing.Size(Me.Llegcont, Module1.screenadaptY(25) * (Module1.numerocontrainte + 1) + Module1.screenadaptY(10))
				groupBoxcontraintes.Size = size
				groupBoxcontraintes = Nothing
				Module1.numerocontrainte = Module1.numerocontrainte - 1
				Me.Légumecont = DirectCast(Utils.CopyArray(DirectCast(Me.Légumecont, Array), New ComboBox(1, Module1.numerocontrainte + 1 - 1) {}), ComboBox(,))
			End If
		End Sub

		Private Sub comboclick(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, Nothing, "selectedindex", New Object(-1) {}, Nothing, Nothing, Nothing), -1, False)) Then
				Me.valeurprec = Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing))
			Else
				Me.valeurprec = ""
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

		Private Sub Empecherredondance1Menu_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Me.Empecherredondance1Menu.Checked) Then
				Me.Empecherredondance2Menu.Checked = False
			End If
		End Sub

		Private Sub Empecherredondance2Menu_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.Empecherredondance2Menu.Checked) Then
				Me.Empecherredondance1Menu.Checked = True
			End If
		End Sub

		Private Sub EnregistrerSousToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim i As Integer
			Dim num As Integer
			Dim str As String()
			If (Me.SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim fileName As String = Me.SaveFileDialog1.FileName
				If (Not Directory.Exists(fileName)) Then
					Directory.CreateDirectory(fileName)
				End If
				Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(String.Concat(fileName, "\COMBINAISONS.txt"), False, Encoding.[Default])
				streamWriter.WriteLine("SAVEZ-VOUS PLANTER LES CHOUX?")
				streamWriter.WriteLine("Optimisateur d'association de plantes en jardin potager" & VbCrLf & "" & VbCrLf & "")
				streamWriter.WriteLine("CONTRAINTES" & VbCrLf & "")
				If (Module1.numerocontrainte = 0) Then
					streamWriter.WriteLine("Néant" & VbCrLf & "" & VbCrLf & "")
				Else
					Dim num1 As Integer = Module1.numerocontrainte
					i = 1
					Do
						Me.ch = ""
						Me.ch = String.Concat("Parcelle C", Conversions.ToString(i), ": ", Module1.listelégumes(Module1.Contraintes_selectionnéesconvertis(i)))
						streamWriter.WriteLine(Me.ch)
						i = i + 1
					Loop While i <= num1
					streamWriter.WriteLine("" & VbCrLf & "" & VbCrLf & "")
				End If
				If (Module1.numeroparcelle <= 1) Then
					str = New String() { "Parcelle 1: ", Module1.listelégumes(Module1.Legumes_selectionnésconvertis(1)), "" & VbCrLf & "" & VbCrLf & "La note de la configuration est ", Conversions.ToString(Me.note), "" & VbCrLf & "Sur une échelle allant de -", Conversions.ToString(Module1.nbrfrontierespartagees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees), "." }
					streamWriter.WriteLine(String.Concat(str))
				Else
					streamWriter.WriteLine(String.Concat("RESULTATS ANNEE 0" & VbCrLf & "" & VbCrLf & "Il y a ", Conversions.ToString(Module1.nbrsolutionoptimisees), " configuration(s) optimisées."))
					str = New String() { "La note des COMBINAISONS est de ", Conversions.ToString(Module1.NOTEASSMAX), " sur une échelle de -", Conversions.ToString(Module1.nbrfrontierespartagees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees), "." & VbCrLf & "" & VbCrLf & "" }
					streamWriter.WriteLine(String.Concat(str))
					Dim num2 As Integer = Module1.nbrsolutionoptimisees - 1
					i = 0
					Do
						Me.ch = ""
						Me.ch = String.Concat(Me.ch, "Configuration ", Conversions.ToString(i + 1), "" & VbCrLf & "" & VbCrLf & "")
						Dim num3 As Integer = Module1.numeroparcelle
						num = 1
						Do
							str = New String() { Me.ch, "Parcelle ", Conversions.ToString(num), ": ", Module1.RESULTSASS(i + 1, num), "" & VbCrLf & "" }
							Me.ch = String.Concat(str)
							num = num + 1
						Loop While num <= num3
						streamWriter.Write(String.Concat(Me.ch, "" & VbCrLf & ""))
						i = i + 1
					Loop While i <= num2
					streamWriter.Write("" & VbCrLf & "")
				End If
				If (Module1.numeroparcelle > 1) Then
					streamWriter.WriteLine(String.Concat("RESULTATS ANNEE 1" & VbCrLf & "" & VbCrLf & "Il y a ", Conversions.ToString(Module1.nbrrotationoptimisees1), " configuration(s) optimisées calculées à partir de la combinaison ", Conversions.ToString(Module1.numerocombinaisonrotation1)))
					str = New String() { "La note des COMBINAISONS est de ", Conversions.ToString(Module1.NOTEMAX1), " sur une échelle de -", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), "." & VbCrLf & "" & VbCrLf & "" }
					streamWriter.WriteLine(String.Concat(str))
					Dim num4 As Integer = Module1.nbrrotationoptimisees1 - 1
					i = 0
					Do
						Me.ch = ""
						Me.ch = String.Concat(Me.ch, "Configuration ", Conversions.ToString(i + 1), "" & VbCrLf & "" & VbCrLf & "")
						Dim num5 As Integer = Module1.numeroparcelle
						num = 1
						Do
							str = New String() { Me.ch, "Parcelle ", Conversions.ToString(num), ": ", Module1.RESULTSROT1(i + 1, num), "" & VbCrLf & "" }
							Me.ch = String.Concat(str)
							num = num + 1
						Loop While num <= num5
						streamWriter.Write(String.Concat(Me.ch, "" & VbCrLf & ""))
						i = i + 1
					Loop While i <= num4
					streamWriter.Write("" & VbCrLf & "" & VbCrLf & "")
				End If
				If (Module1.numeroparcelle > 1) Then
					streamWriter.WriteLine(String.Concat("RESULTATS ANNEE 2" & VbCrLf & "" & VbCrLf & "Il y a ", Conversions.ToString(Module1.nbrrotationoptimisees2), " configuration(s) optimisées calculée à partir de la combinaison ", Conversions.ToString(Module1.numerocombinaisonrotation2)))
					str = New String() { "La note des COMBINAISONS est de ", Conversions.ToString(Module1.NOTEMAX2), " sur une échelle de -", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), "." & VbCrLf & "" & VbCrLf & "" }
					streamWriter.WriteLine(String.Concat(str))
					Dim num6 As Integer = Module1.nbrrotationoptimisees2 - 1
					For i = 0 To num6 Step 1
						Me.ch = ""
						Me.ch = String.Concat(Me.ch, "Configuration ", Conversions.ToString(i + 1), "" & VbCrLf & "" & VbCrLf & "")
						Dim num7 As Integer = Module1.numeroparcelle
						num = 1
						Do
							str = New String() { Me.ch, "Parcelle ", Conversions.ToString(num), ": ", Module1.RESULTSROT2(i + 1, num), "" & VbCrLf & "" }
							Me.ch = String.Concat(str)
							num = num + 1
						Loop While num <= num7
						streamWriter.Write(String.Concat(Me.ch, "" & VbCrLf & ""))
					Next

				End If
				streamWriter.Close()
				Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.Panel.Width, Me.Panel.Width)
				Dim panel As System.Windows.Forms.Panel = Me.Panel
				Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.Panel.Width, Me.Panel.Width)
				panel.DrawToBitmap(bitmap, rectangle)
				bitmap.Save(String.Concat(fileName, "\Géométrie parcelles.bmp"))
			End If
		End Sub

		Public Function fact(ByVal x As Integer) As Integer
			Dim num As Integer = 1
			Dim num1 As Integer = x
			Dim num2 As Integer = 1
			Do
				num = num * num2
				num2 = num2 + 1
			Loop While num2 <= num1
			Return num
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim current As System.Windows.Forms.Control
			Dim size As System.Drawing.Size
			Dim point As System.Drawing.Point
			Dim enumerator As IEnumerator = Nothing
			Dim size1 As System.Drawing.Size
			Dim size2 As System.Drawing.Size
			Dim enumerator1 As IEnumerator = Nothing
			Dim enumerator2 As IEnumerator = Nothing
			Me.datacal = New Integer() { 0, Module1.screenadaptX(100), Module1.screenadaptY(14), Module1.screenadaptX(32), Module1.screenadaptX(16), Module1.screenadaptY(4), 5 * Me.datacal(5), Module1.screenadaptfont(8) }
			ReDim Me.ligne1(11)
			Dim num As Integer = 0
			Do
				Me.ligne1(num) = New Label()
				Dim darkKhaki As Label = Me.ligne1(num)
				darkKhaki.BackColor = Color.DarkKhaki
				darkKhaki.TextAlign = ContentAlignment.MiddleCenter
				size = New System.Drawing.Size(Me.datacal(3), Me.datacal(2))
				darkKhaki.Size = size
				point = New System.Drawing.Point(2 * Me.datacal(1) + 3 + num * Me.datacal(3), 1)
				darkKhaki.Location = point
				darkKhaki = Nothing
				num = num + 1
			Loop While num <= 11
			Me.ligne1(0).Text = "Jan"
			Me.ligne1(1).Text = "Fév"
			Me.ligne1(2).Text = "Mar"
			Me.ligne1(3).Text = "Avr"
			Me.ligne1(4).Text = "Mai"
			Me.ligne1(5).Text = "Jun"
			Me.ligne1(6).Text = "Jul"
			Me.ligne1(7).Text = "Aou"
			Me.ligne1(8).Text = "Sept"
			Me.ligne1(9).Text = "Oct"
			Me.ligne1(10).Text = "Nov"
			Me.ligne1(11).Text = "Déc"
			Me.dimnoterotfiltre = New Integer() { 0, 0, 1, 2, 9, 44, 265, 1854, 14833, 133496 }
			Dim panel As System.Windows.Forms.Panel = Me.Panel
			Dim str As String = String.Concat(Application.StartupPath, "\Pellecurseur.cur")
			panel.Cursor = New System.Windows.Forms.Cursor(SVPLCApplication.Calculatrice.LoadCursorFromFile(str))
			Me.Mhaut = 80
			Me.Mgauche = Module1.screenadaptX(40)
			Me.Llegcont = Module1.screenadaptX(170)
			Me.Hmaxlegcont = Module1.screenadaptY(260)
			Me.ComboX = Module1.screenadaptX(150)
			Me.largcol = Module1.screenadaptY(14)
			Me.longcol = Module1.screenadaptX(120)
			Me.longcol1 = Module1.screenadaptX(80)
			Me.nbrcellules = 16
			Me.cotecelluleX = Module1.screenadaptX(30)
			Me.cotecelluleY = Module1.screenadaptY(30)
			Me.espaceentredeuxcellules = -1
			ReDim Me.grille(Me.nbrcellules - 1 + 1 - 1, Me.nbrcellules - 1 + 1 - 1)
			Dim num1 As Integer = Me.nbrcellules - 1
			Dim num2 As Integer = 0
			Do
				Dim num3 As Integer = Me.nbrcellules - 1
				Dim num4 As Integer = 0
				Do
					Me.grille(num2, num4) = New CheckBox()
					Dim seaGreen As CheckBox = Me.grille(num2, num4)
					seaGreen.Appearance = Appearance.Button
					seaGreen.FlatStyle = FlatStyle.Flat
					seaGreen.BackColor = Color.SeaGreen
					seaGreen.FlatAppearance.CheckedBackColor = Color.SaddleBrown
					size = New System.Drawing.Size(Me.cotecelluleX, Me.cotecelluleY)
					seaGreen.Size = size
					point = New System.Drawing.Point(num2 * (Me.cotecelluleX + Me.espaceentredeuxcellules), num4 * (Me.cotecelluleY + Me.espaceentredeuxcellules))
					seaGreen.Location = point
					Dim calculatrice As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.CheckStateChanged,  New EventHandler(AddressOf calculatrice.CheckBox_CheckedChanged)
					Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.MouseDown,  New MouseEventHandler(AddressOf calculatrice1.CheckBox_MouseDown)
					Dim calculatrice2 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.Click,  New EventHandler(AddressOf calculatrice2.CheckBox_Click)
					Dim calculatrice3 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.MouseUp,  New MouseEventHandler(AddressOf calculatrice3.CheckBox_MouseUp)
					Dim calculatrice4 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.MouseMove,  New MouseEventHandler(AddressOf calculatrice4.CheckBox_MouseMove)
					seaGreen = Nothing
					Me.Lgrille = Me.nbrcellules * (Me.cotecelluleX + Me.espaceentredeuxcellules) - Me.espaceentredeuxcellules
					Me.Hgrille = Me.nbrcellules * (Me.cotecelluleY + Me.espaceentredeuxcellules) - Me.espaceentredeuxcellules
					Dim black As System.Windows.Forms.Panel = Me.Panel
					black.Controls.Add(Me.grille(num2, num4))
					size = New System.Drawing.Size(Me.Lgrille, Me.Hgrille)
					black.Size = size
					point = New System.Drawing.Point(Me.Mgauche, Me.Mhaut)
					black.Location = point
					black.BackColor = Color.Black
					black = Nothing
					num4 = num4 + 1
				Loop While num4 <= num3
				num2 = num2 + 1
			Loop While num2 <= num1
			Dim pictureBoxcocc1 As PictureBox = Me.PictureBoxcocc1
			point = New System.Drawing.Point(Module1.screenadaptX(725), Module1.screenadaptY(44))
			pictureBoxcocc1.Location = point
			size = New System.Drawing.Size(Module1.screenadaptX(50), Module1.screenadaptY(50))
			pictureBoxcocc1.Size = size
			pictureBoxcocc1 = Nothing
			Dim pictureBoxpap As PictureBox = Me.PictureBoxpap
			point = New System.Drawing.Point(Module1.screenadaptX(12), Module1.screenadaptY(900))
			pictureBoxpap.Location = point
			size = New System.Drawing.Size(Module1.screenadaptX(256), Module1.screenadaptY(256))
			pictureBoxpap.Size = size
			pictureBoxpap = Nothing
			Dim pictureBoxjardinier As PictureBox = Me.PictureBoxjardinier
			point = New System.Drawing.Point(Module1.screenadaptX(595), Module1.screenadaptY(510))
			pictureBoxjardinier.Location = point
			size = New System.Drawing.Size(Module1.screenadaptX(737), Module1.screenadaptY(646))
			pictureBoxjardinier.Size = size
			pictureBoxjardinier = Nothing
			Dim collections As Collection = New Collection()
			collections.Add(Me.GroupBoxannee0, Nothing, Nothing, Nothing)
			collections.Add(Me.GroupBoxannee1, Nothing, Nothing, Nothing)
			collections.Add(Me.GroupBoxannee2, Nothing, Nothing, Nothing)
			collections.Add(Me.GroupBoxcalculs, Nothing, Nothing, Nothing)
			collections.Add(Me.GroupBoxcalendrier, Nothing, Nothing, Nothing)
			collections.Add(Me.GroupBoxcontraintes, Nothing, Nothing, Nothing)
			collections.Add(Me.GroupBoxlégumes, Nothing, Nothing, Nothing)
			collections.Add(Me.GroupBoxPartitionnement, Nothing, Nothing, Nothing)
			Dim groupBoxcontraintes As myGroupBox = Me.GroupBoxcontraintes
			point = New System.Drawing.Point(Me.Mgauche + Me.Lgrille + Module1.screenadaptX(30), Me.Mhaut + Me.Hmaxlegcont + Module1.screenadaptY(20))
			groupBoxcontraintes.Location = point
			Dim groupBoxlégumes As myGroupBox = Me.GroupBoxlégumes
			point = New System.Drawing.Point(Me.Mgauche + Me.Lgrille + Module1.screenadaptX(30), Me.Mhaut)
			groupBoxlégumes.Location = point
			Dim groupBoxcalendrier As myGroupBox = Me.GroupBoxcalendrier
			point = New System.Drawing.Point(Me.Mgauche, Module1.screenadaptY(730))
			groupBoxcalendrier.Location = point
			Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(Module1.screenadaptX(10))
			groupBoxcalendrier.Padding = padding
			groupBoxcalendrier = Nothing
			Dim groupBoxannee0 As myGroupBox = Me.GroupBoxannee0
			point = New System.Drawing.Point(Me.Mgauche + Me.Lgrille + Module1.screenadaptX(30) + Me.Llegcont + Module1.screenadaptX(90), Me.Mhaut)
			groupBoxannee0.Location = point
			groupBoxannee0 = Nothing
			Dim groupBoxPartitionnement As myGroupBox = Me.GroupBoxPartitionnement
			point = New System.Drawing.Point(Me.Mgauche, Me.Mhaut + Me.Hgrille + Module1.screenadaptY(20))
			groupBoxPartitionnement.Location = point
			size = New System.Drawing.Size(Module1.screenadaptX(165), Module1.screenadaptY(120))
			groupBoxPartitionnement.Size = size
			groupBoxPartitionnement = Nothing
			Dim groupBoxcalculs As myGroupBox = Me.GroupBoxcalculs
			Dim mgauche As Integer = Me.Mgauche
			Dim bounds As Rectangle = Me.GroupBoxPartitionnement.Bounds
			point = New System.Drawing.Point(mgauche + bounds.Width + Module1.screenadaptX(10), Me.Mhaut + Me.Hgrille + Module1.screenadaptY(20))
			groupBoxcalculs.Location = point
			size = New System.Drawing.Size(Module1.screenadaptX(294), Module1.screenadaptY(120))
			groupBoxcalculs.Size = size
			groupBoxcalculs = Nothing
			Dim buttonreset As Button = Me.Buttonreset
			point = New System.Drawing.Point(Me.Mgauche, Me.Mhaut - Module1.screenadaptY(25))
			buttonreset.Location = point
			size = New System.Drawing.Size(Module1.screenadaptX(110), Module1.screenadaptY(24))
			buttonreset.Size = size
			buttonreset.Font = New System.Drawing.Font(buttonreset.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(buttonreset.Font.Size))))), buttonreset.Font.Style)
			buttonreset = Nothing
			Dim légende As System.Windows.Forms.Panel = Me.Légende
			point = New System.Drawing.Point(Module1.screenadaptX(650), Module1.screenadaptY(730))
			légende.Location = point
			size = New System.Drawing.Size(Module1.screenadaptX(89), Module1.screenadaptY(62))
			légende.Size = size
			Try
				enumerator = légende.Controls.GetEnumerator()
				While enumerator.MoveNext()
					current = DirectCast(enumerator.Current, System.Windows.Forms.Control)
					Dim font As System.Windows.Forms.Control = current
					size = font.Bounds.Size
					Dim num5 As Integer = Module1.screenadaptX(size.Width)
					size1 = font.Bounds.Size
					size2 = New System.Drawing.Size(num5, Module1.screenadaptY(size1.Height))
					font.Size = size2
					point = New System.Drawing.Point(Module1.screenadaptX(font.Left), Module1.screenadaptY(font.Top))
					font.Location = point
					font.Font = New System.Drawing.Font(font.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(font.Font.Size))))), font.Font.Style)
					font = Nothing
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			légende = Nothing
			Try
				enumerator1 = collections.GetEnumerator()
				While enumerator1.MoveNext()
					Dim _myGroupBox As myGroupBox = DirectCast(enumerator1.Current, myGroupBox)
					_myGroupBox.Thickness = Module1.screenadaptX(_myGroupBox.Thickness)
					_myGroupBox.Font = New System.Drawing.Font(_myGroupBox.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(_myGroupBox.Font.Size))))), _myGroupBox.Font.Style)
					padding = New System.Windows.Forms.Padding(Module1.screenadaptX(3))
					_myGroupBox.Padding = padding
					Try
						enumerator2 = _myGroupBox.Controls.GetEnumerator()
						While enumerator2.MoveNext()
							current = DirectCast(enumerator2.Current, System.Windows.Forms.Control)
							Dim control As System.Windows.Forms.Control = current
							size2 = control.Bounds.Size
							Dim num6 As Integer = Module1.screenadaptX(size2.Width)
							size1 = control.Bounds.Size
							size = New System.Drawing.Size(num6, Module1.screenadaptY(size1.Height))
							control.Size = size
							point = New System.Drawing.Point(Module1.screenadaptX(control.Left), Module1.screenadaptY(control.Top))
							control.Location = point
							control.Font = New System.Drawing.Font(control.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(control.Font.Size))))), control.Font.Style)
							control = Nothing
						End While
					Finally
						If (TypeOf enumerator2 Is IDisposable) Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					_myGroupBox = Nothing
				End While
			Finally
				If (TypeOf enumerator1 Is IDisposable) Then
					TryCast(enumerator1, IDisposable).Dispose()
				End If
			End Try
			Me.ResultatsAssociationMenu.Enabled = False
			Me.CalculerAnnee1Menu.Enabled = False
			Me.btnAnnee1.Enabled = False
			Me.CalculerAnnee2Menu.Enabled = False
			Me.btnAnnee2.Enabled = False
			Me.BilanMenu.Enabled = False
			Me.GroupBoxannee1.Visible = False
			Me.GroupBoxannee2.Visible = False
			Me.GroupBoxcontraintes.Visible = False
			Me.GroupBoxannee0.Visible = False
			Me.GroupBoxlégumes.Visible = False
			Me.GroupBoxcalendrier.Visible = False
			Me.Légende.Visible = False
			Module1.numeroparcelle = 0
			Module1.numerocontrainte = 0
			Me.bgcalinit = True
			Me.ImprimerMenu.Enabled = False
			Me.EnregistrerSousMenu.Enabled = False
			Me.lblProgression.Text = ""
			Me.Empecherredondance1Menu.Checked = True
			Me.Empecherredondance2Menu.Checked = True
			Me.BilanMenu.Enabled = False
			Me.StatutLabel.Text = "Commencez par dessiner votre potager, renseignez ensuite les légumes que vous voudriez planter et cliquez sur Année 0"
		End Sub

		Private Sub ImprimerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.PrintDialog1.PrinterSettings = Me.PrintDocument1.PrinterSettings
			If (Me.PrintDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Me.PrintDocument1.PrinterSettings = Me.PrintDialog1.PrinterSettings
				Dim pageSetting As PageSettings = New PageSettings()
				Dim pageSetting1 As PageSettings = pageSetting
				pageSetting1.Margins.Left = 50
				pageSetting1.Margins.Right = 50
				pageSetting1.Margins.Top = 50
				pageSetting1.Margins.Bottom = 50
				pageSetting1.Landscape = False
				pageSetting1 = Nothing
				Me.PrintDocument1.DefaultPageSettings = pageSetting
			End If
			Me.PrintPreviewDialog1.Document = Me.PrintDocument1
			Me.PrintPreviewDialog1.ShowDialog()
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculatrice))
			Me.Panel = New System.Windows.Forms.Panel()
			Me.SaveFileDialog1 = New SaveFileDialog()
			Me.MenuPrinc = New System.Windows.Forms.MenuStrip()
			Me.FichierMenu = New System.Windows.Forms.ToolStripMenuItem()
			Me.EnregistrerSousMenu = New System.Windows.Forms.ToolStripMenuItem()
			Me.ImprimerMenu = New System.Windows.Forms.ToolStripMenuItem()
			Me.RésultatsMenu = New System.Windows.Forms.ToolStripMenuItem()
			Me.CalculerAnnee0Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.CalculerAnnee1Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.CalculerAnnee2Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator3 = New ToolStripSeparator()
			Me.ResultatsAssociationMenu = New System.Windows.Forms.ToolStripMenuItem()
			Me.AfficherCombinaisons0Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.AfficherCombinaisons1Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.AfficherCombinaisons2Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.BilanMenu = New System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator1 = New ToolStripSeparator()
			Me.Empecherredondance1Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.Empecherredondance2Menu = New System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripSeparator2 = New ToolStripSeparator()
			Me.ResetMenu = New System.Windows.Forms.ToolStripMenuItem()
			Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
			Me.StatutLabel = New ToolStripStatusLabel()
			Me.PrintDialog1 = New PrintDialog()
			Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
			Me.PrintDocument1 = New PrintDocument()
			Me.PictureBoxcocc1 = New System.Windows.Forms.PictureBox()
			Me.PictureBoxpap = New System.Windows.Forms.PictureBox()
			Me.Légende = New System.Windows.Forms.Panel()
			Me.Label5 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.semis = New System.Windows.Forms.Label()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.BackgroundWorkerannee0 = New BackgroundWorker()
			Me.Buttonreset = New System.Windows.Forms.Button()
			Me.BackgroundWorkerannee1 = New BackgroundWorker()
			Me.BackgroundWorkerannee2 = New BackgroundWorker()
			Me.PictureBoxjardinier = New System.Windows.Forms.PictureBox()
			Me.Buttonpart = New System.Windows.Forms.Button()
			Me.GroupBoxcalendrier = New myGroupBox()
			Me.GroupBoxannee2 = New myGroupBox()
			Me.Annee21 = New System.Windows.Forms.Label()
			Me.Annee2 = New System.Windows.Forms.Panel()
			Me.Annee22 = New System.Windows.Forms.Label()
			Me.Annee23 = New System.Windows.Forms.Label()
			Me.GroupBoxannee1 = New myGroupBox()
			Me.Annee11 = New System.Windows.Forms.Label()
			Me.Annee13 = New System.Windows.Forms.Label()
			Me.Annee12 = New System.Windows.Forms.Label()
			Me.Annee1 = New System.Windows.Forms.Panel()
			Me.GroupBoxannee0 = New myGroupBox()
			Me.Annee0 = New System.Windows.Forms.Panel()
			Me.Annee01 = New System.Windows.Forms.Label()
			Me.Annee03 = New System.Windows.Forms.Label()
			Me.Annee02 = New System.Windows.Forms.Label()
			Me.GroupBoxcontraintes = New myGroupBox()
			Me.GroupBoxlégumes = New myGroupBox()
			Me.GroupBoxcalculs = New myGroupBox()
			Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
			Me.btnAnnee2 = New System.Windows.Forms.Button()
			Me.lblProgression = New System.Windows.Forms.Label()
			Me.btnAnnee0 = New System.Windows.Forms.Button()
			Me.btnAnnee1 = New System.Windows.Forms.Button()
			Me.GroupBoxPartitionnement = New myGroupBox()
			Me.CheckBoxsupp = New System.Windows.Forms.CheckBox()
			Me.Buttonpartaveccontrainte = New System.Windows.Forms.Button()
			Me.MenuPrinc.SuspendLayout()
			Me.StatusStrip1.SuspendLayout()
			DirectCast(Me.PictureBoxcocc1, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBoxpap, ISupportInitialize).BeginInit()
			Me.Légende.SuspendLayout()
			DirectCast(Me.PictureBoxjardinier, ISupportInitialize).BeginInit()
			Me.GroupBoxannee2.SuspendLayout()
			Me.GroupBoxannee1.SuspendLayout()
			Me.GroupBoxannee0.SuspendLayout()
			Me.GroupBoxcalculs.SuspendLayout()
			Me.GroupBoxPartitionnement.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel.Cursor = Cursors.[Default]
			Dim panel As System.Windows.Forms.Panel = Me.Panel
			Dim point As System.Drawing.Point = New System.Drawing.Point(40, 80)
			panel.Location = point
			Me.Panel.Name = "Panel"
			Dim panel1 As System.Windows.Forms.Panel = Me.Panel
			Dim size As System.Drawing.Size = New System.Drawing.Size(472, 457)
			panel1.Size = size
			Me.Panel.TabIndex = 2
			Me.SaveFileDialog1.Title = "Enregistrer sous..."
			Me.MenuPrinc.BackColor = Color.FromArgb(255, 128, 0)
			Dim items As ToolStripItemCollection = Me.MenuPrinc.Items
			Dim fichierMenu() As ToolStripItem = { Me.FichierMenu, Me.RésultatsMenu }
			items.AddRange(fichierMenu)
			Me.MenuPrinc.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
			Dim menuPrinc As System.Windows.Forms.MenuStrip = Me.MenuPrinc
			point = New System.Drawing.Point(0, 0)
			menuPrinc.Location = point
			Me.MenuPrinc.Name = "MenuPrinc"
			Dim menuStrip As System.Windows.Forms.MenuStrip = Me.MenuPrinc
			size = New System.Drawing.Size(1380, 24)
			menuStrip.Size = size
			Me.MenuPrinc.TabIndex = 0
			Me.MenuPrinc.Text = "MenuStrip1"
			Dim dropDownItems As ToolStripItemCollection = Me.FichierMenu.DropDownItems
			fichierMenu = New ToolStripItem() { Me.EnregistrerSousMenu, Me.ImprimerMenu }
			dropDownItems.AddRange(fichierMenu)
			Me.FichierMenu.ForeColor = Color.Black
			Me.FichierMenu.Name = "FichierMenu"
			Dim toolStripMenuItem As System.Windows.Forms.ToolStripMenuItem = Me.FichierMenu
			size = New System.Drawing.Size(54, 20)
			toolStripMenuItem.Size = size
			Me.FichierMenu.Text = "&Fichier"
			Me.EnregistrerSousMenu.Image = Resources.disquette1
			Me.EnregistrerSousMenu.Name = "EnregistrerSousMenu"
			Dim enregistrerSousMenu As System.Windows.Forms.ToolStripMenuItem = Me.EnregistrerSousMenu
			size = New System.Drawing.Size(173, 22)
			enregistrerSousMenu.Size = size
			Me.EnregistrerSousMenu.Text = "Enregistrer sous..."
			Me.ImprimerMenu.Image = Resources.print1
			Me.ImprimerMenu.Name = "ImprimerMenu"
			Dim imprimerMenu As System.Windows.Forms.ToolStripMenuItem = Me.ImprimerMenu
			size = New System.Drawing.Size(173, 22)
			imprimerMenu.Size = size
			Me.ImprimerMenu.Text = "Impression express"
			Dim toolStripItemCollections As ToolStripItemCollection = Me.RésultatsMenu.DropDownItems
			fichierMenu = New ToolStripItem() { Me.CalculerAnnee0Menu, Me.CalculerAnnee1Menu, Me.CalculerAnnee2Menu, Me.ToolStripSeparator3, Me.ResultatsAssociationMenu, Me.BilanMenu, Me.ToolStripSeparator1, Me.Empecherredondance1Menu, Me.Empecherredondance2Menu, Me.ToolStripSeparator2, Me.ResetMenu }
			toolStripItemCollections.AddRange(fichierMenu)
			Me.RésultatsMenu.ForeColor = Color.Black
			Me.RésultatsMenu.Name = "RésultatsMenu"
			Dim résultatsMenu As System.Windows.Forms.ToolStripMenuItem = Me.RésultatsMenu
			size = New System.Drawing.Size(57, 20)
			résultatsMenu.Size = size
			Me.RésultatsMenu.Text = "Calculs"
			Me.CalculerAnnee0Menu.Name = "CalculerAnnee0Menu"
			Dim calculerAnnee0Menu As System.Windows.Forms.ToolStripMenuItem = Me.CalculerAnnee0Menu
			size = New System.Drawing.Size(320, 22)
			calculerAnnee0Menu.Size = size
			Me.CalculerAnnee0Menu.Text = "Calculer les associations (Année 0)"
			Me.CalculerAnnee1Menu.Name = "CalculerAnnee1Menu"
			Dim calculerAnnee1Menu As System.Windows.Forms.ToolStripMenuItem = Me.CalculerAnnee1Menu
			size = New System.Drawing.Size(320, 22)
			calculerAnnee1Menu.Size = size
			Me.CalculerAnnee1Menu.Text = "Calculer la première rotation (Année +1)"
			Me.CalculerAnnee2Menu.Name = "CalculerAnnee2Menu"
			Dim calculerAnnee2Menu As System.Windows.Forms.ToolStripMenuItem = Me.CalculerAnnee2Menu
			size = New System.Drawing.Size(320, 22)
			calculerAnnee2Menu.Size = size
			Me.CalculerAnnee2Menu.Text = "Calculer la seconde rotation (Année +2)"
			Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
			Dim toolStripSeparator3 As ToolStripSeparator = Me.ToolStripSeparator3
			size = New System.Drawing.Size(317, 6)
			toolStripSeparator3.Size = size
			Dim dropDownItems1 As ToolStripItemCollection = Me.ResultatsAssociationMenu.DropDownItems
			fichierMenu = New ToolStripItem() { Me.AfficherCombinaisons0Menu, Me.AfficherCombinaisons1Menu, Me.AfficherCombinaisons2Menu }
			dropDownItems1.AddRange(fichierMenu)
			Me.ResultatsAssociationMenu.Name = "ResultatsAssociationMenu"
			Dim resultatsAssociationMenu As System.Windows.Forms.ToolStripMenuItem = Me.ResultatsAssociationMenu
			size = New System.Drawing.Size(320, 22)
			resultatsAssociationMenu.Size = size
			Me.ResultatsAssociationMenu.Text = "Résultats"
			Me.AfficherCombinaisons0Menu.Image = Resources.ass1
			Me.AfficherCombinaisons0Menu.Name = "AfficherCombinaisons0Menu"
			Dim afficherCombinaisons0Menu As System.Windows.Forms.ToolStripMenuItem = Me.AfficherCombinaisons0Menu
			size = New System.Drawing.Size(380, 22)
			afficherCombinaisons0Menu.Size = size
			Me.AfficherCombinaisons0Menu.Text = "Afficher toutes les combinaisons optimisées de l'année 0"
			Me.AfficherCombinaisons1Menu.Image = Resources.rot11
			Me.AfficherCombinaisons1Menu.Name = "AfficherCombinaisons1Menu"
			Dim afficherCombinaisons1Menu As System.Windows.Forms.ToolStripMenuItem = Me.AfficherCombinaisons1Menu
			size = New System.Drawing.Size(380, 22)
			afficherCombinaisons1Menu.Size = size
			Me.AfficherCombinaisons1Menu.Text = "Afficher toutes les combinaisons optimisées de l'année +1"
			Me.AfficherCombinaisons2Menu.Image = Resources.rot21
			Me.AfficherCombinaisons2Menu.Name = "AfficherCombinaisons2Menu"
			Dim afficherCombinaisons2Menu As System.Windows.Forms.ToolStripMenuItem = Me.AfficherCombinaisons2Menu
			size = New System.Drawing.Size(380, 22)
			afficherCombinaisons2Menu.Size = size
			Me.AfficherCombinaisons2Menu.Text = "Afficher toutes les combinaisons optimisées de l'année +2"
			Me.BilanMenu.Image = Resources.courbe
			Me.BilanMenu.Name = "BilanMenu"
			Dim bilanMenu As System.Windows.Forms.ToolStripMenuItem = Me.BilanMenu
			size = New System.Drawing.Size(320, 22)
			bilanMenu.Size = size
			Me.BilanMenu.Text = "Bilan et Statistiques des 3 années"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim toolStripSeparator1 As ToolStripSeparator = Me.ToolStripSeparator1
			size = New System.Drawing.Size(317, 6)
			toolStripSeparator1.Size = size
			Me.Empecherredondance1Menu.CheckOnClick = True
			Me.Empecherredondance1Menu.Name = "Empecherredondance1Menu"
			Dim empecherredondance1Menu As System.Windows.Forms.ToolStripMenuItem = Me.Empecherredondance1Menu
			size = New System.Drawing.Size(320, 22)
			empecherredondance1Menu.Size = size
			Me.Empecherredondance1Menu.Text = "Empêcher la redondance des cultures sur 1 an"
			Me.Empecherredondance2Menu.CheckOnClick = True
			Me.Empecherredondance2Menu.Name = "Empecherredondance2Menu"
			Dim empecherredondance2Menu As System.Windows.Forms.ToolStripMenuItem = Me.Empecherredondance2Menu
			size = New System.Drawing.Size(320, 22)
			empecherredondance2Menu.Size = size
			Me.Empecherredondance2Menu.Text = "Empêcher la redondance des cultures sur 2 ans"
			Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
			Dim toolStripSeparator2 As ToolStripSeparator = Me.ToolStripSeparator2
			size = New System.Drawing.Size(317, 6)
			toolStripSeparator2.Size = size
			Me.ResetMenu.Name = "ResetMenu"
			Dim resetMenu As System.Windows.Forms.ToolStripMenuItem = Me.ResetMenu
			size = New System.Drawing.Size(320, 22)
			resetMenu.Size = size
			Me.ResetMenu.Text = "&Recommencer"
			Me.StatusStrip1.AutoSize = False
			Me.StatusStrip1.BackColor = Color.DarkKhaki
			Me.StatusStrip1.Dock = DockStyle.Top
			Dim items1 As ToolStripItemCollection = Me.StatusStrip1.Items
			fichierMenu = New ToolStripItem() { Me.StatutLabel }
			items1.AddRange(fichierMenu)
			Dim statusStrip1 As System.Windows.Forms.StatusStrip = Me.StatusStrip1
			point = New System.Drawing.Point(0, 24)
			statusStrip1.Location = point
			Me.StatusStrip1.Name = "StatusStrip1"
			Dim statusStrip As System.Windows.Forms.StatusStrip = Me.StatusStrip1
			size = New System.Drawing.Size(1380, 20)
			statusStrip.Size = size
			Me.StatusStrip1.TabIndex = 12
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.StatutLabel.Font = New System.Drawing.Font("Segoe UI", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.StatutLabel.Name = "StatutLabel"
			Dim statutLabel As ToolStripStatusLabel = Me.StatutLabel
			size = New System.Drawing.Size(129, 15)
			statutLabel.Size = size
			Me.StatutLabel.Text = "ToolStripStatusLabel1"
			Me.PrintDialog1.UseEXDialog = True
			Dim printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog = Me.PrintPreviewDialog1
			size = New System.Drawing.Size(0, 0)
			printPreviewDialog1.AutoScrollMargin = size
			Dim printPreviewDialog As System.Windows.Forms.PrintPreviewDialog = Me.PrintPreviewDialog1
			size = New System.Drawing.Size(0, 0)
			printPreviewDialog.AutoScrollMinSize = size
			Dim printPreviewDialog11 As System.Windows.Forms.PrintPreviewDialog = Me.PrintPreviewDialog1
			size = New System.Drawing.Size(400, 300)
			printPreviewDialog11.ClientSize = size
			Me.PrintPreviewDialog1.Enabled = True
			Me.PrintPreviewDialog1.Icon = DirectCast(componentResourceManager.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
			Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
			Me.PrintPreviewDialog1.ShowIcon = False
			Me.PrintPreviewDialog1.Visible = False
			Me.PictureBoxcocc1.BackColor = Color.Transparent
			Me.PictureBoxcocc1.BackgroundImageLayout = ImageLayout.Stretch
			Me.PictureBoxcocc1.Image = Resources.animals_ladybug2
			Dim pictureBoxcocc1 As System.Windows.Forms.PictureBox = Me.PictureBoxcocc1
			point = New System.Drawing.Point(725, 44)
			pictureBoxcocc1.Location = point
			Me.PictureBoxcocc1.Name = "PictureBoxcocc1"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBoxcocc1
			size = New System.Drawing.Size(50, 50)
			pictureBox.Size = size
			Me.PictureBoxcocc1.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBoxcocc1.TabIndex = 36
			Me.PictureBoxcocc1.TabStop = False
			Me.PictureBoxpap.BackColor = Color.Transparent
			Me.PictureBoxpap.BackgroundImageLayout = ImageLayout.Stretch
			Me.PictureBoxpap.Image = Resources.papillon
			Dim pictureBoxpap As System.Windows.Forms.PictureBox = Me.PictureBoxpap
			point = New System.Drawing.Point(12, 900)
			pictureBoxpap.Location = point
			Me.PictureBoxpap.Name = "PictureBoxpap"
			Dim pictureBoxpap1 As System.Windows.Forms.PictureBox = Me.PictureBoxpap
			size = New System.Drawing.Size(256, 256)
			pictureBoxpap1.Size = size
			Me.PictureBoxpap.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBoxpap.TabIndex = 38
			Me.PictureBoxpap.TabStop = False
			Me.Légende.BackColor = Color.Transparent
			Me.Légende.Controls.Add(Me.Label5)
			Me.Légende.Controls.Add(Me.Label4)
			Me.Légende.Controls.Add(Me.Label3)
			Me.Légende.Controls.Add(Me.semis)
			Me.Légende.Controls.Add(Me.Label1)
			Dim légende As System.Windows.Forms.Panel = Me.Légende
			point = New System.Drawing.Point(624, 720)
			légende.Location = point
			Me.Légende.Name = "Légende"
			Dim légende1 As System.Windows.Forms.Panel = Me.Légende
			size = New System.Drawing.Size(89, 62)
			légende1.Size = size
			Me.Légende.TabIndex = 10
			Me.Label5.BackColor = Color.Red
			Dim label5 As System.Windows.Forms.Label = Me.Label5
			point = New System.Drawing.Point(16, 35)
			label5.Location = point
			Me.Label5.Name = "Label5"
			Dim label As System.Windows.Forms.Label = Me.Label5
			size = New System.Drawing.Size(13, 13)
			label.Size = size
			Me.Label5.TabIndex = 3
			Me.Label4.BackColor = Color.Green
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(16, 12)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(13, 13)
			label41.Size = size
			Me.Label4.TabIndex = 0
			Me.Label3.AutoSize = True
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(35, 35)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(44, 13)
			label31.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "Récolte"
			Me.semis.AutoSize = True
			Dim label1 As System.Windows.Forms.Label = Me.semis
			point = New System.Drawing.Point(35, 12)
			label1.Location = point
			Me.semis.Name = "semis"
			Dim label2 As System.Windows.Forms.Label = Me.semis
			size = New System.Drawing.Size(35, 13)
			label2.Size = size
			Me.semis.TabIndex = 2
			Me.semis.Text = "Semis"
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Color.Green
			Dim label11 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(16, 12)
			label11.Location = point
			Me.Label1.Name = "Label1"
			Dim label12 As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(0, 13)
			label12.Size = size
			Me.Label1.TabIndex = 1
			Me.BackgroundWorkerannee0.WorkerReportsProgress = True
			Me.Buttonreset.BackColor = SystemColors.ActiveCaption
			Me.Buttonreset.FlatStyle = FlatStyle.Popup
			Me.Buttonreset.Font = New System.Drawing.Font("Segoe UI", 6.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim buttonreset As System.Windows.Forms.Button = Me.Buttonreset
			point = New System.Drawing.Point(40, 50)
			buttonreset.Location = point
			Me.Buttonreset.Name = "Buttonreset"
			Dim button As System.Windows.Forms.Button = Me.Buttonreset
			size = New System.Drawing.Size(109, 24)
			button.Size = size
			Me.Buttonreset.TabIndex = 1
			Me.Buttonreset.Text = "Recommencer"
			Me.Buttonreset.UseVisualStyleBackColor = False
			Me.BackgroundWorkerannee1.WorkerReportsProgress = True
			Me.BackgroundWorkerannee2.WorkerReportsProgress = True
			Me.PictureBoxjardinier.Image = Resources.Jardinierpiston
			Dim pictureBoxjardinier As System.Windows.Forms.PictureBox = Me.PictureBoxjardinier
			point = New System.Drawing.Point(595, 510)
			pictureBoxjardinier.Location = point
			Me.PictureBoxjardinier.Name = "PictureBoxjardinier"
			Dim pictureBoxjardinier1 As System.Windows.Forms.PictureBox = Me.PictureBoxjardinier
			size = New System.Drawing.Size(737, 646)
			pictureBoxjardinier1.Size = size
			Me.PictureBoxjardinier.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBoxjardinier.TabIndex = 50
			Me.PictureBoxjardinier.TabStop = False
			Me.Buttonpart.BackColor = Color.FromArgb(255, 128, 0)
			Me.Buttonpart.FlatStyle = FlatStyle.Popup
			Me.Buttonpart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Buttonpart.ForeColor = Color.Black
			Dim buttonpart As System.Windows.Forms.Button = Me.Buttonpart
			point = New System.Drawing.Point(30, 21)
			buttonpart.Location = point
			Me.Buttonpart.Name = "Buttonpart"
			Dim buttonpart1 As System.Windows.Forms.Button = Me.Buttonpart
			size = New System.Drawing.Size(109, 23)
			buttonpart1.Size = size
			Me.Buttonpart.TabIndex = 0
			Me.Buttonpart.Text = "Partitionner"
			Me.Buttonpart.UseVisualStyleBackColor = False
			Me.GroupBoxcalendrier.AutoSize = True
			Me.GroupBoxcalendrier.BackColor = Color.Transparent
			Me.GroupBoxcalendrier.BorderColor = Color.Gold
			Me.GroupBoxcalendrier.Diagonale = 4
			Me.GroupBoxcalendrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.GroupBoxcalendrier.ForeColor = Color.Black
			Dim groupBoxcalendrier As myGroupBox = Me.GroupBoxcalendrier
			point = New System.Drawing.Point(40, 720)
			groupBoxcalendrier.Location = point
			Me.GroupBoxcalendrier.Name = "GroupBoxcalendrier"
			Me.GroupBoxcalendrier.Padding = New System.Windows.Forms.Padding(10)
			Dim _myGroupBox As myGroupBox = Me.GroupBoxcalendrier
			size = New System.Drawing.Size(483, 99)
			_myGroupBox.Size = size
			Me.GroupBoxcalendrier.TabIndex = 49
			Me.GroupBoxcalendrier.TabStop = False
			Me.GroupBoxcalendrier.Text = "Calendrier Semis/Récolte "
			Me.GroupBoxcalendrier.Thickness = 4
			Me.GroupBoxcalendrier.Titlecolor = Color.DarkOrange
			Me.GroupBoxannee2.BackColor = Color.Transparent
			Me.GroupBoxannee2.BorderColor = Color.Green
			Me.GroupBoxannee2.Controls.Add(Me.Annee21)
			Me.GroupBoxannee2.Controls.Add(Me.Annee2)
			Me.GroupBoxannee2.Controls.Add(Me.Annee22)
			Me.GroupBoxannee2.Controls.Add(Me.Annee23)
			Me.GroupBoxannee2.Diagonale = 4
			Me.GroupBoxannee2.ForeColor = Color.Black
			Dim groupBoxannee2 As myGroupBox = Me.GroupBoxannee2
			point = New System.Drawing.Point(774, 510)
			groupBoxannee2.Location = point
			Me.GroupBoxannee2.Name = "GroupBoxannee2"
			Dim groupBoxannee21 As myGroupBox = Me.GroupBoxannee2
			size = New System.Drawing.Size(210, 200)
			groupBoxannee21.Size = size
			Me.GroupBoxannee2.TabIndex = 48
			Me.GroupBoxannee2.TabStop = False
			Me.GroupBoxannee2.Text = "Annee +2   "
			Me.GroupBoxannee2.Thickness = 4
			Me.GroupBoxannee2.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.Annee21.AutoSize = True
			Dim annee21 As System.Windows.Forms.Label = Me.Annee21
			point = New System.Drawing.Point(10, 25)
			annee21.Location = point
			Me.Annee21.Name = "Annee21"
			Dim annee211 As System.Windows.Forms.Label = Me.Annee21
			size = New System.Drawing.Size(33, 13)
			annee211.Size = size
			Me.Annee21.TabIndex = 0
			Me.Annee21.Text = "Label"
			Me.Annee2.ForeColor = Color.Black
			Dim annee2 As System.Windows.Forms.Panel = Me.Annee2
			point = New System.Drawing.Point(85, 120)
			annee2.Location = point
			Me.Annee2.Name = "Annee2"
			Dim annee22 As System.Windows.Forms.Panel = Me.Annee2
			size = New System.Drawing.Size(65, 25)
			annee22.Size = size
			Me.Annee2.TabIndex = 3
			Me.Annee22.AutoSize = True
			Dim annee221 As System.Windows.Forms.Label = Me.Annee22
			point = New System.Drawing.Point(10, 65)
			annee221.Location = point
			Me.Annee22.Name = "Annee22"
			Dim annee222 As System.Windows.Forms.Label = Me.Annee22
			size = New System.Drawing.Size(33, 13)
			annee222.Size = size
			Me.Annee22.TabIndex = 1
			Me.Annee22.Text = "Label"
			Me.Annee23.AutoSize = True
			Dim annee23 As System.Windows.Forms.Label = Me.Annee23
			point = New System.Drawing.Point(10, 92)
			annee23.Location = point
			Me.Annee23.Name = "Annee23"
			Dim annee231 As System.Windows.Forms.Label = Me.Annee23
			size = New System.Drawing.Size(33, 13)
			annee231.Size = size
			Me.Annee23.TabIndex = 2
			Me.Annee23.Text = "Label"
			Me.GroupBoxannee1.BackColor = Color.Transparent
			Me.GroupBoxannee1.BorderColor = Color.Green
			Me.GroupBoxannee1.Controls.Add(Me.Annee11)
			Me.GroupBoxannee1.Controls.Add(Me.Annee13)
			Me.GroupBoxannee1.Controls.Add(Me.Annee12)
			Me.GroupBoxannee1.Controls.Add(Me.Annee1)
			Me.GroupBoxannee1.Diagonale = 4
			Me.GroupBoxannee1.ForeColor = Color.Black
			Dim groupBoxannee1 As myGroupBox = Me.GroupBoxannee1
			point = New System.Drawing.Point(774, 300)
			groupBoxannee1.Location = point
			Me.GroupBoxannee1.Name = "GroupBoxannee1"
			Dim groupBoxannee11 As myGroupBox = Me.GroupBoxannee1
			size = New System.Drawing.Size(210, 200)
			groupBoxannee11.Size = size
			Me.GroupBoxannee1.TabIndex = 47
			Me.GroupBoxannee1.TabStop = False
			Me.GroupBoxannee1.Text = "Annee +1  "
			Me.GroupBoxannee1.Thickness = 4
			Me.GroupBoxannee1.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.Annee11.AutoSize = True
			Dim annee11 As System.Windows.Forms.Label = Me.Annee11
			point = New System.Drawing.Point(10, 25)
			annee11.Location = point
			Me.Annee11.Name = "Annee11"
			Dim annee111 As System.Windows.Forms.Label = Me.Annee11
			size = New System.Drawing.Size(33, 13)
			annee111.Size = size
			Me.Annee11.TabIndex = 0
			Me.Annee11.Text = "Label"
			Me.Annee13.AutoSize = True
			Dim annee13 As System.Windows.Forms.Label = Me.Annee13
			point = New System.Drawing.Point(10, 92)
			annee13.Location = point
			Me.Annee13.Name = "Annee13"
			Dim annee131 As System.Windows.Forms.Label = Me.Annee13
			size = New System.Drawing.Size(33, 13)
			annee131.Size = size
			Me.Annee13.TabIndex = 2
			Me.Annee13.Text = "Label"
			Me.Annee12.AutoSize = True
			Dim annee12 As System.Windows.Forms.Label = Me.Annee12
			point = New System.Drawing.Point(10, 65)
			annee12.Location = point
			Me.Annee12.Name = "Annee12"
			Dim annee121 As System.Windows.Forms.Label = Me.Annee12
			size = New System.Drawing.Size(33, 13)
			annee121.Size = size
			Me.Annee12.TabIndex = 1
			Me.Annee12.Text = "Label"
			Me.Annee1.ForeColor = Color.Black
			Dim annee1 As System.Windows.Forms.Panel = Me.Annee1
			point = New System.Drawing.Point(85, 120)
			annee1.Location = point
			Me.Annee1.Name = "Annee1"
			Dim panel2 As System.Windows.Forms.Panel = Me.Annee1
			size = New System.Drawing.Size(80, 52)
			panel2.Size = size
			Me.Annee1.TabIndex = 3
			Me.GroupBoxannee0.BackColor = Color.Transparent
			Me.GroupBoxannee0.BorderColor = Color.Green
			Me.GroupBoxannee0.Controls.Add(Me.Annee0)
			Me.GroupBoxannee0.Controls.Add(Me.Annee01)
			Me.GroupBoxannee0.Controls.Add(Me.Annee03)
			Me.GroupBoxannee0.Controls.Add(Me.Annee02)
			Me.GroupBoxannee0.Diagonale = 4
			Me.GroupBoxannee0.ForeColor = Color.Black
			Dim groupBoxannee0 As myGroupBox = Me.GroupBoxannee0
			point = New System.Drawing.Point(774, 80)
			groupBoxannee0.Location = point
			Me.GroupBoxannee0.Name = "GroupBoxannee0"
			Dim groupBoxannee01 As myGroupBox = Me.GroupBoxannee0
			size = New System.Drawing.Size(210, 200)
			groupBoxannee01.Size = size
			Me.GroupBoxannee0.TabIndex = 46
			Me.GroupBoxannee0.TabStop = False
			Me.GroupBoxannee0.Text = "Annee 0   "
			Me.GroupBoxannee0.Thickness = 4
			Me.GroupBoxannee0.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.Annee0.ForeColor = Color.Black
			Dim annee0 As System.Windows.Forms.Panel = Me.Annee0
			point = New System.Drawing.Point(24, 117)
			annee0.Location = point
			Me.Annee0.Name = "Annee0"
			Dim annee01 As System.Windows.Forms.Panel = Me.Annee0
			size = New System.Drawing.Size(141, 50)
			annee01.Size = size
			Me.Annee0.TabIndex = 3
			Me.Annee01.AutoSize = True
			Dim annee011 As System.Windows.Forms.Label = Me.Annee01
			point = New System.Drawing.Point(10, 25)
			annee011.Location = point
			Me.Annee01.Name = "Annee01"
			Dim annee012 As System.Windows.Forms.Label = Me.Annee01
			size = New System.Drawing.Size(33, 13)
			annee012.Size = size
			Me.Annee01.TabIndex = 0
			Me.Annee01.Text = "Label"
			Me.Annee03.AutoSize = True
			Dim annee03 As System.Windows.Forms.Label = Me.Annee03
			point = New System.Drawing.Point(10, 92)
			annee03.Location = point
			Me.Annee03.Name = "Annee03"
			Dim annee031 As System.Windows.Forms.Label = Me.Annee03
			size = New System.Drawing.Size(33, 13)
			annee031.Size = size
			Me.Annee03.TabIndex = 2
			Me.Annee03.Text = "Label"
			Me.Annee02.AutoSize = True
			Dim annee02 As System.Windows.Forms.Label = Me.Annee02
			point = New System.Drawing.Point(10, 65)
			annee02.Location = point
			Me.Annee02.Name = "Annee02"
			Dim annee021 As System.Windows.Forms.Label = Me.Annee02
			size = New System.Drawing.Size(33, 13)
			annee021.Size = size
			Me.Annee02.TabIndex = 1
			Me.Annee02.Text = "Label"
			Me.GroupBoxcontraintes.BackColor = Color.Transparent
			Me.GroupBoxcontraintes.BorderColor = Color.Green
			Me.GroupBoxcontraintes.Diagonale = 4
			Me.GroupBoxcontraintes.ForeColor = Color.FromArgb(0, 192, 0)
			Dim groupBoxcontraintes As myGroupBox = Me.GroupBoxcontraintes
			point = New System.Drawing.Point(565, 372)
			groupBoxcontraintes.Location = point
			Me.GroupBoxcontraintes.Name = "GroupBoxcontraintes"
			Dim groupBoxcontraintes1 As myGroupBox = Me.GroupBoxcontraintes
			size = New System.Drawing.Size(162, 100)
			groupBoxcontraintes1.Size = size
			Me.GroupBoxcontraintes.TabIndex = 45
			Me.GroupBoxcontraintes.TabStop = False
			Me.GroupBoxcontraintes.Text = "Contraintes  "
			Me.GroupBoxcontraintes.Thickness = 4
			Me.GroupBoxcontraintes.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.GroupBoxlégumes.BackColor = Color.Transparent
			Me.GroupBoxlégumes.BorderColor = Color.Green
			Me.GroupBoxlégumes.Diagonale = 4
			Me.GroupBoxlégumes.ForeColor = Color.FromArgb(0, 192, 0)
			Dim groupBoxlégumes As myGroupBox = Me.GroupBoxlégumes
			point = New System.Drawing.Point(565, 80)
			groupBoxlégumes.Location = point
			Me.GroupBoxlégumes.Name = "GroupBoxlégumes"
			Dim groupBoxlégumes1 As myGroupBox = Me.GroupBoxlégumes
			size = New System.Drawing.Size(162, 100)
			groupBoxlégumes1.Size = size
			Me.GroupBoxlégumes.TabIndex = 44
			Me.GroupBoxlégumes.TabStop = False
			Me.GroupBoxlégumes.Text = "Légumes   "
			Me.GroupBoxlégumes.Thickness = 4
			Me.GroupBoxlégumes.Titlecolor = Color.FromArgb(0, 192, 0)
			Me.GroupBoxcalculs.BackColor = Color.Transparent
			Me.GroupBoxcalculs.BorderColor = Color.FromArgb(128, 64, 0)
			Me.GroupBoxcalculs.Controls.Add(Me.ProgressBar1)
			Me.GroupBoxcalculs.Controls.Add(Me.btnAnnee2)
			Me.GroupBoxcalculs.Controls.Add(Me.lblProgression)
			Me.GroupBoxcalculs.Controls.Add(Me.btnAnnee0)
			Me.GroupBoxcalculs.Controls.Add(Me.btnAnnee1)
			Me.GroupBoxcalculs.Diagonale = 4
			Me.GroupBoxcalculs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.GroupBoxcalculs.ForeColor = Color.DarkRed
			Dim groupBoxcalculs As myGroupBox = Me.GroupBoxcalculs
			point = New System.Drawing.Point(211, 570)
			groupBoxcalculs.Location = point
			Me.GroupBoxcalculs.Name = "GroupBoxcalculs"
			Dim groupBoxcalculs1 As myGroupBox = Me.GroupBoxcalculs
			size = New System.Drawing.Size(294, 122)
			groupBoxcalculs1.Size = size
			Me.GroupBoxcalculs.TabIndex = 43
			Me.GroupBoxcalculs.TabStop = False
			Me.GroupBoxcalculs.Text = "Calculs  "
			Me.GroupBoxcalculs.Thickness = 4
			Me.GroupBoxcalculs.Titlecolor = Color.FromArgb(64, 0, 0)
			Dim progressBar1 As System.Windows.Forms.ProgressBar = Me.ProgressBar1
			point = New System.Drawing.Point(15, 21)
			progressBar1.Location = point
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar As System.Windows.Forms.ProgressBar = Me.ProgressBar1
			size = New System.Drawing.Size(263, 23)
			progressBar.Size = size
			Me.ProgressBar1.TabIndex = 0
			Me.btnAnnee2.BackColor = Color.FromArgb(255, 128, 0)
			Me.btnAnnee2.FlatStyle = FlatStyle.Popup
			Me.btnAnnee2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim button1 As System.Windows.Forms.Button = Me.btnAnnee2
			point = New System.Drawing.Point(199, 78)
			button1.Location = point
			Me.btnAnnee2.Name = "btnAnnee2"
			Dim button2 As System.Windows.Forms.Button = Me.btnAnnee2
			size = New System.Drawing.Size(85, 22)
			button2.Size = size
			Me.btnAnnee2.TabIndex = 4
			Me.btnAnnee2.Text = "Année +2"
			Me.btnAnnee2.UseVisualStyleBackColor = False
			Me.lblProgression.AutoSize = True
			Me.lblProgression.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.lblProgression.ForeColor = Color.FromArgb(255, 128, 0)
			Dim label6 As System.Windows.Forms.Label = Me.lblProgression
			point = New System.Drawing.Point(12, 53)
			label6.Location = point
			Me.lblProgression.Name = "lblProgression"
			Dim label7 As System.Windows.Forms.Label = Me.lblProgression
			size = New System.Drawing.Size(73, 13)
			label7.Size = size
			Me.lblProgression.TabIndex = 1
			Me.lblProgression.Text = "Progression"
			Me.btnAnnee0.BackColor = Color.FromArgb(255, 128, 0)
			Me.btnAnnee0.FlatStyle = FlatStyle.Popup
			Me.btnAnnee0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.btnAnnee0.ForeColor = Color.Black
			Dim button3 As System.Windows.Forms.Button = Me.btnAnnee0
			point = New System.Drawing.Point(15, 78)
			button3.Location = point
			Me.btnAnnee0.Name = "btnAnnee0"
			Dim button4 As System.Windows.Forms.Button = Me.btnAnnee0
			size = New System.Drawing.Size(85, 22)
			button4.Size = size
			Me.btnAnnee0.TabIndex = 2
			Me.btnAnnee0.Text = "Année 0"
			Me.btnAnnee0.UseVisualStyleBackColor = False
			Me.btnAnnee1.BackColor = Color.FromArgb(255, 128, 0)
			Me.btnAnnee1.FlatStyle = FlatStyle.Popup
			Me.btnAnnee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim button5 As System.Windows.Forms.Button = Me.btnAnnee1
			point = New System.Drawing.Point(107, 78)
			button5.Location = point
			Me.btnAnnee1.Name = "btnAnnee1"
			Dim button6 As System.Windows.Forms.Button = Me.btnAnnee1
			size = New System.Drawing.Size(85, 22)
			button6.Size = size
			Me.btnAnnee1.TabIndex = 3
			Me.btnAnnee1.Text = "Année +1"
			Me.btnAnnee1.UseVisualStyleBackColor = False
			Me.GroupBoxPartitionnement.BackColor = Color.Transparent
			Me.GroupBoxPartitionnement.BorderColor = Color.FromArgb(128, 64, 0)
			Me.GroupBoxPartitionnement.Controls.Add(Me.Buttonpart)
			Me.GroupBoxPartitionnement.Controls.Add(Me.CheckBoxsupp)
			Me.GroupBoxPartitionnement.Controls.Add(Me.Buttonpartaveccontrainte)
			Me.GroupBoxPartitionnement.Diagonale = 4
			Me.GroupBoxPartitionnement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.GroupBoxPartitionnement.ForeColor = Color.Maroon
			Dim groupBoxPartitionnement As myGroupBox = Me.GroupBoxPartitionnement
			point = New System.Drawing.Point(40, 570)
			groupBoxPartitionnement.Location = point
			Me.GroupBoxPartitionnement.Name = "GroupBoxPartitionnement"
			Dim groupBoxPartitionnement1 As myGroupBox = Me.GroupBoxPartitionnement
			size = New System.Drawing.Size(165, 122)
			groupBoxPartitionnement1.Size = size
			Me.GroupBoxPartitionnement.TabIndex = 42
			Me.GroupBoxPartitionnement.TabStop = False
			Me.GroupBoxPartitionnement.Text = "Partitionnement"
			Me.GroupBoxPartitionnement.Thickness = 4
			Me.GroupBoxPartitionnement.Titlecolor = Color.FromArgb(64, 0, 0)
			Me.CheckBoxsupp.Appearance = Appearance.Button
			Me.CheckBoxsupp.BackColor = Color.Firebrick
			Me.CheckBoxsupp.FlatStyle = FlatStyle.Popup
			Me.CheckBoxsupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.CheckBoxsupp.ForeColor = Color.Black
			Dim checkBoxsupp As System.Windows.Forms.CheckBox = Me.CheckBoxsupp
			point = New System.Drawing.Point(30, 78)
			checkBoxsupp.Location = point
			Me.CheckBoxsupp.Name = "CheckBoxsupp"
			Dim checkBox As System.Windows.Forms.CheckBox = Me.CheckBoxsupp
			size = New System.Drawing.Size(109, 23)
			checkBox.Size = size
			Me.CheckBoxsupp.TabIndex = 2
			Me.CheckBoxsupp.Text = "Supprimer"
			Me.CheckBoxsupp.TextAlign = ContentAlignment.MiddleCenter
			Me.CheckBoxsupp.UseVisualStyleBackColor = False
			Me.Buttonpartaveccontrainte.BackColor = Color.FromArgb(255, 128, 0)
			Me.Buttonpartaveccontrainte.FlatStyle = FlatStyle.Popup
			Me.Buttonpartaveccontrainte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Buttonpartaveccontrainte.ForeColor = Color.Black
			Dim buttonpartaveccontrainte As System.Windows.Forms.Button = Me.Buttonpartaveccontrainte
			point = New System.Drawing.Point(30, 48)
			buttonpartaveccontrainte.Location = point
			Me.Buttonpartaveccontrainte.Name = "Buttonpartaveccontrainte"
			Dim buttonpartaveccontrainte1 As System.Windows.Forms.Button = Me.Buttonpartaveccontrainte
			size = New System.Drawing.Size(109, 23)
			buttonpartaveccontrainte1.Size = size
			Me.Buttonpartaveccontrainte.TabIndex = 1
			Me.Buttonpartaveccontrainte.Text = "Contraindre"
			Me.Buttonpartaveccontrainte.UseVisualStyleBackColor = False
			Me.AcceptButton = Me.Buttonpart
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoScroll = True
			Me.BackColor = Color.Olive
			size = New System.Drawing.Size(1397, 752)
			Me.ClientSize = size
			Me.Controls.Add(Me.Buttonreset)
			Me.Controls.Add(Me.GroupBoxcalendrier)
			Me.Controls.Add(Me.GroupBoxannee2)
			Me.Controls.Add(Me.GroupBoxannee1)
			Me.Controls.Add(Me.GroupBoxannee0)
			Me.Controls.Add(Me.GroupBoxcontraintes)
			Me.Controls.Add(Me.GroupBoxlégumes)
			Me.Controls.Add(Me.GroupBoxcalculs)
			Me.Controls.Add(Me.GroupBoxPartitionnement)
			Me.Controls.Add(Me.StatusStrip1)
			Me.Controls.Add(Me.Légende)
			Me.Controls.Add(Me.Panel)
			Me.Controls.Add(Me.MenuPrinc)
			Me.Controls.Add(Me.PictureBoxpap)
			Me.Controls.Add(Me.PictureBoxcocc1)
			Me.Controls.Add(Me.PictureBoxjardinier)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.Name = "Calculatrice"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Calculatrice avancée"
			Me.WindowState = FormWindowState.Maximized
			Me.MenuPrinc.ResumeLayout(False)
			Me.MenuPrinc.PerformLayout()
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			DirectCast(Me.PictureBoxcocc1, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBoxpap, ISupportInitialize).EndInit()
			Me.Légende.ResumeLayout(False)
			Me.Légende.PerformLayout()
			DirectCast(Me.PictureBoxjardinier, ISupportInitialize).EndInit()
			Me.GroupBoxannee2.ResumeLayout(False)
			Me.GroupBoxannee2.PerformLayout()
			Me.GroupBoxannee1.ResumeLayout(False)
			Me.GroupBoxannee1.PerformLayout()
			Me.GroupBoxannee0.ResumeLayout(False)
			Me.GroupBoxannee0.PerformLayout()
			Me.GroupBoxcalculs.ResumeLayout(False)
			Me.GroupBoxcalculs.PerformLayout()
			Me.GroupBoxPartitionnement.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		<DllImport("user32.dll", CharSet:=CharSet.Unicode, EntryPoint:="LoadCursorFromFileW", ExactSpelling:=True, SetLastError:=True)>
		Private Shared Function LoadCursorFromFile(ByRef filename As String) As IntPtr
		End Function

		Private Sub PHOTOPANEL(ByVal panele As System.Windows.Forms.Panel)
			Dim capt As System.Windows.Forms.Panel = panele
			Me.largeur = capt.Width
			Me.hauteur = capt.Height
			Me.Capt = New System.Drawing.Bitmap(Me.largeur, Me.hauteur)
			Dim bitmap As System.Drawing.Bitmap = Me.Capt
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.largeur, Me.hauteur)
			capt.DrawToBitmap(bitmap, rectangle)
			capt.BackgroundImage = Me.Capt
			capt.Visible = True
			capt.Controls.Clear()
			capt = Nothing
		End Sub

		Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
			Dim width As Integer = Me.GroupBoxannee0.Width
			Dim height As Integer = Me.GroupBoxannee0.Height
			Dim num As Integer = 1
			Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.Panel.Width, Me.Panel.Width)
			Dim panel As System.Windows.Forms.Panel = Me.Panel
			Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.Panel.Width, Me.Panel.Width)
			panel.DrawToBitmap(bitmap, rectangle)
			Dim bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap(width, height)
			Dim groupBoxannee0 As myGroupBox = Me.GroupBoxannee0
			rectangle = New System.Drawing.Rectangle(0, 0, width, height)
			groupBoxannee0.DrawToBitmap(bitmap1, rectangle)
			Dim bitmap2 As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.GroupBoxlégumes.Width, Me.GroupBoxlégumes.Height)
			Dim groupBoxlégumes As myGroupBox = Me.GroupBoxlégumes
			rectangle = New System.Drawing.Rectangle(0, 0, Me.GroupBoxlégumes.Width, Me.GroupBoxlégumes.Height)
			groupBoxlégumes.DrawToBitmap(bitmap2, rectangle)
			Dim size As System.Drawing.Size = New System.Drawing.Size(300, 300)
			Dim bitmap3 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap, size)
			size = New System.Drawing.Size(width * num, height * num)
			Dim bitmap4 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap1, size)
			size = New System.Drawing.Size(Me.GroupBoxlégumes.Width, Me.GroupBoxlégumes.Height)
			Dim bitmap5 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap2, size)
			Dim graphics As System.Drawing.Graphics = e.Graphics
			graphics.DrawImage(bitmap3, 460, 40)
			graphics.DrawImage(bitmap4, 40, 40)
			graphics.DrawImage(bitmap5, 470, 380)
			graphics = Nothing
			If (Me.GroupBoxannee1.Visible) Then
				Dim bitmap6 As System.Drawing.Bitmap = New System.Drawing.Bitmap(width, height)
				Dim groupBoxannee1 As myGroupBox = Me.GroupBoxannee1
				rectangle = New System.Drawing.Rectangle(0, 0, width, height)
				groupBoxannee1.DrawToBitmap(bitmap6, rectangle)
				size = New System.Drawing.Size(width * num, height * num)
				Dim bitmap7 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap6, size)
				e.Graphics.DrawImage(bitmap7, 40, 400)
			End If
			If (Me.GroupBoxannee2.Visible) Then
				Dim bitmap8 As System.Drawing.Bitmap = New System.Drawing.Bitmap(width, height)
				Dim groupBoxannee2 As myGroupBox = Me.GroupBoxannee2
				rectangle = New System.Drawing.Rectangle(0, 0, width, height)
				groupBoxannee2.DrawToBitmap(bitmap8, rectangle)
				size = New System.Drawing.Size(width * num, height * num)
				Dim bitmap9 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap8, size)
				e.Graphics.DrawImage(bitmap9, 40, 760)
			End If
			If (Module1.numerocontrainte > 0) Then
				Dim bitmap10 As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.GroupBoxcontraintes.Width, Me.GroupBoxcontraintes.Height)
				Dim groupBoxcontraintes As myGroupBox = Me.GroupBoxcontraintes
				rectangle = New System.Drawing.Rectangle(0, 0, Me.GroupBoxcontraintes.Width, Me.GroupBoxcontraintes.Height)
				groupBoxcontraintes.DrawToBitmap(bitmap10, rectangle)
				size = New System.Drawing.Size(Me.GroupBoxcontraintes.Width, Me.GroupBoxcontraintes.Height)
				Dim bitmap11 As System.Drawing.Bitmap = New System.Drawing.Bitmap(bitmap10, size)
				e.Graphics.DrawImage(bitmap11, 630, 380)
			End If
		End Sub

		Private Sub ResetToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Légume = Nothing
			Me.Légumecont = Nothing
			Me.FRONTIERES = Nothing
			Module1.COMBINAISONS = Nothing
			Module1.Notepp = Nothing
			Module1.Notepc = Nothing
			Module1.NOTESASS = Nothing
			Me.NOTES1 = Nothing
			Me.NOTES2 = Nothing
			Module1.RESULTSASS = Nothing
			Module1.RESULTSROT1 = Nothing
			Module1.RESULTSROT2 = Nothing
			Me.calendrierselectionne.Clear()
			Me.GroupBoxcontraintes.Visible = False
			Me.GroupBoxlégumes.Visible = False
			Me.GroupBoxannee0.Visible = False
			Me.GroupBoxannee1.Visible = False
			Me.GroupBoxannee2.Visible = False
			Me.GroupBoxcalendrier.Visible = False
			Me.Légende.Visible = False
			Me.ResultatsAssociationMenu.Enabled = False
			Me.CalculerAnnee1Menu.Enabled = False
			Me.CalculerAnnee2Menu.Enabled = False
			Me.EnregistrerSousMenu.Enabled = False
			Me.ImprimerMenu.Enabled = False
			If (Module1.loadcombass) Then
				Me.COMBASS.Close()
				Module1.loadcombass = False
			End If
			If (Module1.loadcombrot1) Then
				Me.COMBROT1.Close()
				Module1.loadcombrot1 = False
			End If
			If (Module1.loadcombrot2) Then
				Me.COMBROT2.Close()
				Module1.loadcombrot2 = False
			End If
			Me.GroupBoxcontraintes.Controls.Clear()
			Me.GroupBoxlégumes.Controls.Clear()
			Me.ProgressBar1.Value = 0
			Module1.numeroparcelle = 0
			Module1.numerocontrainte = 0
			Me.lblProgression.Text = ""
			Me.Panel.Controls.Clear()
			Me.nbrcellules = 16
			Me.cotecelluleX = Module1.screenadaptX(30)
			Me.cotecelluleY = Module1.screenadaptY(30)
			Me.espaceentredeuxcellules = -1
			ReDim Me.grille(Me.nbrcellules - 1 + 1 - 1, Me.nbrcellules - 1 + 1 - 1)
			Dim num As Integer = Me.nbrcellules - 1
			Dim num1 As Integer = 0
			Do
				Dim num2 As Integer = Me.nbrcellules - 1
				Dim num3 As Integer = 0
				Do
					Me.grille(num1, num3) = New CheckBox()
					Dim seaGreen As CheckBox = Me.grille(num1, num3)
					seaGreen.Appearance = Appearance.Button
					seaGreen.FlatStyle = FlatStyle.Flat
					seaGreen.BackColor = Color.SeaGreen
					seaGreen.FlatAppearance.CheckedBackColor = Color.SaddleBrown
					Dim size As System.Drawing.Size = New System.Drawing.Size(Me.cotecelluleX, Me.cotecelluleY)
					seaGreen.Size = size
					Dim point As System.Drawing.Point = New System.Drawing.Point(num1 * (Me.cotecelluleX + Me.espaceentredeuxcellules), num3 * (Me.cotecelluleY + Me.espaceentredeuxcellules))
					seaGreen.Location = point
					Dim calculatrice As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.CheckStateChanged,  New EventHandler(AddressOf calculatrice.CheckBox_CheckedChanged)
					Dim calculatrice1 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.MouseDown,  New MouseEventHandler(AddressOf calculatrice1.CheckBox_MouseDown)
					Dim calculatrice2 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.Click,  New EventHandler(AddressOf calculatrice2.CheckBox_Click)
					Dim calculatrice3 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.MouseUp,  New MouseEventHandler(AddressOf calculatrice3.CheckBox_MouseUp)
					Dim calculatrice4 As SVPLCApplication.Calculatrice = Me
					AddHandler seaGreen.MouseMove,  New MouseEventHandler(AddressOf calculatrice4.CheckBox_MouseMove)
					seaGreen = Nothing
					Me.Lgrille = Me.nbrcellules * (Me.cotecelluleX + Me.espaceentredeuxcellules) - Me.espaceentredeuxcellules
					Me.Hgrille = Me.nbrcellules * (Me.cotecelluleY + Me.espaceentredeuxcellules) - Me.espaceentredeuxcellules
					Dim panel As System.Windows.Forms.Panel = Me.Panel
					panel.Controls.Add(Me.grille(num1, num3))
					size = New System.Drawing.Size(Me.Lgrille, Me.Hgrille)
					panel.Size = size
					point = New System.Drawing.Point(Me.Mgauche, Me.Mhaut)
					panel.Location = point
					panel.BackColor = Color.Black
					panel = Nothing
					num3 = num3 + 1
				Loop While num3 <= num2
				num1 = num1 + 1
			Loop While num1 <= num
			Me.StatutLabel.Text = "Commencer par dessiner votre potager, renseignez ensuite les légumes que vous voudriez planter et cliquez sur Annee 0"
		End Sub

		Private Sub selectedindexchanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.valeurnouv = Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing))
			If (Operators.CompareString(Me.valeurnouv, Me.valeurprec, False) <> 0) Then
				Me.Cursor = Cursors.WaitCursor
				Me.GroupBoxPartitionnement.Focus()
				Me.CalculerAnnee1Menu.Enabled = False
				Me.CalculerAnnee2Menu.Enabled = False
				If (Not Me.bgcalinit) Then
					Me.Panelcalendrier.Dispose()
					Me.Panelcalendrier = New System.Windows.Forms.Panel()
				Else
					Me.bgcalinit = False
					Me.Panelcalendrier = New System.Windows.Forms.Panel()
				End If
				Me.GroupBoxcalendrier.Visible = False
				Me.Légende.Visible = False
				Me.colonne12 = Nothing
				Me.resultatcalendrier = Nothing
				Me.trouv = False
				If (Operators.CompareString(Me.valeurprec, "", False) <> 0) Then
					Dim num As Integer = Module1.nbrlignecal - 1
					Dim num1 As Integer = 0
					While num1 <= num
						If (Not LikeOperator.LikeString(Module1.Base_de_données_calendrier(num1), Me.valeurnouv, CompareMethod.Binary)) Then
							num1 = num1 + 9
						Else
							Me.ran = Me.L.IndexOf(Me.valeurprec)
							If (Me.ran <> -1) Then
								Me.calendrierselectionne.RemoveRange(Me.ran * 6, 6)
								Me.L.Remove(Me.valeurprec)
							End If
							Me.L.Add(Me.valeurnouv)
							Me.L.Sort()
							Me.ran = Me.L.IndexOf(Me.valeurnouv)
							Dim num2 As Integer = 0
							Do
								If (Operators.CompareString(Me.valeurnouv, Me.L.Last(), False) <> 0) Then
									Me.calendrierselectionne.Insert(Me.ran * 6 + num2, Module1.Base_de_données_calendrier(num1 + num2))
								Else
									Me.calendrierselectionne.Add(Module1.Base_de_données_calendrier(num1 + num2))
								End If
								num2 = num2 + 1
							Loop While num2 <= 5
							Me.trouv = True
							Exit While
						End If
					End While
					If (Not Me.trouv) Then
						Me.calendrierselectionne.RemoveRange(Me.L.IndexOf(Me.valeurprec) * 6, 6)
						Me.L.Remove(Me.valeurprec)
					End If
					Me.nbrlignecalselec = Me.calendrierselectionne.Count
				Else
					Dim num3 As Integer = Module1.nbrlignecal - 1
					Dim num4 As Integer = 0
					While num4 <= num3
						If (Not LikeOperator.LikeString(Module1.Base_de_données_calendrier(num4), Me.valeurnouv, CompareMethod.Binary)) Then
							num4 = num4 + 9
						Else
							Me.L.Add(Me.valeurnouv)
							Me.L.Sort()
							Me.ran = Me.L.IndexOf(Me.valeurnouv)
							Dim num5 As Integer = 0
							Do
								If (Operators.CompareString(Me.valeurnouv, Me.L.Last(), False) <> 0) Then
									Me.calendrierselectionne.Insert(Me.ran * 6 + num5, Module1.Base_de_données_calendrier(num4 + num5))
								Else
									Me.calendrierselectionne.Add(Module1.Base_de_données_calendrier(num4 + num5))
								End If
								num5 = num5 + 1
							Loop While num5 <= 5
							Me.trouv = True
							Exit While
						End If
					End While
					Me.nbrlignecalselec = Me.calendrierselectionne.Count
				End If
				ReDim Me.colonne12(1, Me.nbrlignecalselec / 6 + 1 - 1)
				Me.colonne12(0, 0) = New System.Windows.Forms.Label()
				Dim label As System.Windows.Forms.Label = Me.colonne12(0, 0)
				label.Text = "Plante"
				Dim size As System.Drawing.Size = New System.Drawing.Size(Me.datacal(1), Me.datacal(2))
				label.Size = size
				Dim point As System.Drawing.Point = New System.Drawing.Point(1, 1)
				label.Location = point
				label = Nothing
				Me.colonne12(1, 0) = New System.Windows.Forms.Label()
				Dim label1 As System.Windows.Forms.Label = Me.colonne12(1, 0)
				label1.Text = "Famille"
				size = New System.Drawing.Size(Me.datacal(1), Me.datacal(2))
				label1.Size = size
				point = New System.Drawing.Point(Me.datacal(1) + 2, 1)
				label1.Location = point
				label1 = Nothing
				ReDim Me.resultatcalendrier(23, (Module1.numeroparcelle + Module1.numerocontrainte) * 5 - 1 + 1 - 1)
				Dim num6 As Integer = 0
				Do
					Dim num7 As Integer = Me.nbrlignecalselec / 6 * 5 - 1
					Dim num8 As Integer = 0
					Do
						Me.resultatcalendrier(num6, num8) = New System.Windows.Forms.Label()
						Dim darkKhaki As System.Windows.Forms.Label = Me.resultatcalendrier(num6, num8)
						size = New System.Drawing.Size(Me.datacal(4), Me.datacal(5))
						darkKhaki.Size = size
						point = New System.Drawing.Point(2 * Me.datacal(1) + 3 + Me.datacal(4) * num6, Me.datacal(2) + 2 + Me.datacal(5) * num8)
						darkKhaki.Location = point
						darkKhaki.BackColor = Color.DarkKhaki
						darkKhaki = Nothing
						num8 = num8 + 1
					Loop While num8 <= num7
					num6 = num6 + 1
				Loop While num6 <= 23
				Dim num9 As Integer = Me.nbrlignecalselec / 6
				Dim num10 As Integer = 1
				Do
					Me.colonne12(0, num10) = New System.Windows.Forms.Label()
					Dim item As System.Windows.Forms.Label = Me.colonne12(0, num10)
					item.Text = Me.calendrierselectionne((num10 - 1) * 6)
					item.AutoEllipsis = True
					size = New System.Drawing.Size(Me.datacal(1), Me.datacal(6))
					item.Size = size
					point = New System.Drawing.Point(1, Me.datacal(2) + 2 + (num10 - 1) * Me.datacal(6))
					item.Location = point
					item = Nothing
					Me.colonne12(1, num10) = New System.Windows.Forms.Label()
					Dim item1 As System.Windows.Forms.Label = Me.colonne12(1, num10)
					item1.Text = Me.calendrierselectionne((num10 - 1) * 6 + 1)
					item1.AutoEllipsis = True
					size = New System.Drawing.Size(Me.datacal(1), Me.datacal(6))
					item1.Size = size
					point = New System.Drawing.Point(Me.datacal(1) + 2, Me.datacal(2) + 2 + (num10 - 1) * Me.datacal(6))
					item1.Location = point
					item1 = Nothing
					num10 = num10 + 1
				Loop While num10 <= num9
				Me.compt = 1
				Dim num11 As Integer = Me.nbrlignecalselec - 4
				Dim num12 As Integer = 2
				Do
					If (Conversions.ToInteger(Me.calendrierselectionne(num12)) <= Conversions.ToInteger(Me.calendrierselectionne(num12 + 1))) Then
						Dim [integer] As Integer = Conversions.ToInteger(Me.calendrierselectionne(num12))
						Dim integer1 As Integer = Conversions.ToInteger(Me.calendrierselectionne(num12 + 1))
						For i As Integer = [integer] To integer1 Step 1
							Me.resultatcalendrier(i - 1, Me.compt).BackColor = Color.Green
						Next

					End If
					If (Conversions.ToInteger(Me.calendrierselectionne(num12)) > Conversions.ToInteger(Me.calendrierselectionne(num12 + 1))) Then
						For j As Integer = Conversions.ToInteger(Me.calendrierselectionne(num12)) To 24 Step 1
							Me.resultatcalendrier(j - 1, Me.compt).BackColor = Color.Green
						Next

						Dim integer2 As Integer = Conversions.ToInteger(Me.calendrierselectionne(num12 + 1))
						For k As Integer = 1 To integer2 Step 1
							Me.resultatcalendrier(k - 1, Me.compt).BackColor = Color.Green
						Next

					End If
					Me.compt = Me.compt + 5
					num12 = num12 + 6
				Loop While num12 <= num11
				Me.compt = 3
				Dim num13 As Integer = Me.nbrlignecalselec - 2
				Dim num14 As Integer = 4
				Do
					Dim integer3 As Integer = Conversions.ToInteger(Me.calendrierselectionne(num14))
					Dim integer4 As Integer = Conversions.ToInteger(Me.calendrierselectionne(num14 + 1))
					Dim num15 As Integer = integer3
					Do
						Me.resultatcalendrier(num15 - 1, Me.compt).BackColor = Color.Red
						num15 = num15 + 1
					Loop While num15 <= integer4
					If (Conversions.ToInteger(Me.calendrierselectionne(num14)) > Conversions.ToInteger(Me.calendrierselectionne(num14 + 1))) Then
						For l As Integer = Conversions.ToInteger(Me.calendrierselectionne(num14)) To 24 Step 1
							Me.resultatcalendrier(l - 1, Me.compt).BackColor = Color.Red
						Next

						Dim integer5 As Integer = Conversions.ToInteger(Me.calendrierselectionne(num14 + 1))
						For m As Integer = 1 To integer5 Step 1
							Me.resultatcalendrier(m - 1, Me.compt).BackColor = Color.Red
						Next

					End If
					Me.compt = Me.compt + 5
					num14 = num14 + 6
				Loop While num14 <= num13
				Dim panelcalendrier As System.Windows.Forms.Panel = Me.Panelcalendrier
				Dim num16 As Integer = 0
				Do
					Dim num17 As Integer = Me.nbrlignecalselec / 6
					Dim num18 As Integer = 0
					Do
						Dim darkKhaki1 As System.Windows.Forms.Label = Me.colonne12(num16, num18)
						darkKhaki1.BackColor = Color.DarkKhaki
						darkKhaki1.TextAlign = ContentAlignment.MiddleCenter
						darkKhaki1 = Nothing
						panelcalendrier.Controls.Add(Me.colonne12(num16, num18))
						num18 = num18 + 1
					Loop While num18 <= num17
					num16 = num16 + 1
				Loop While num16 <= 1
				Dim num19 As Integer = 0
				Do
					panelcalendrier.Controls.Add(Me.ligne1(num19))
					num19 = num19 + 1
				Loop While num19 <= 11
				Dim num20 As Integer = 0
				Do
					Dim num21 As Integer = (Module1.numeroparcelle + Module1.numerocontrainte) * 5 - 1
					Dim num22 As Integer = 0
					Do
						panelcalendrier.Controls.Add(Me.resultatcalendrier(num20, num22))
						num22 = num22 + 1
					Loop While num22 <= num21
					num20 = num20 + 1
				Loop While num20 <= 23
				panelcalendrier.BackColor = Color.Black
				size = New System.Drawing.Size(2 * Me.datacal(1) + 12 * Me.datacal(3) + 4, Me.nbrlignecalselec / 6 * Me.datacal(6) + Me.datacal(2) + 3)
				panelcalendrier.Size = size
				panelcalendrier.Font = New System.Drawing.Font("Courier new", CSng(Me.datacal(7)), FontStyle.Regular)
				point = New System.Drawing.Point(Module1.screenadaptX(10), Module1.screenadaptY(20) + Me.datacal(7) / 2)
				panelcalendrier.Location = point
				panelcalendrier = Nothing
				Me.PHOTOPANEL(Me.Panelcalendrier)
				Dim groupBoxcalendrier As myGroupBox = Me.GroupBoxcalendrier
				groupBoxcalendrier.Controls.Add(Me.Panelcalendrier)
				size = New System.Drawing.Size(2 * Module1.screenadaptX(10) + Module1.screenadaptX(584) + 4, CInt(Math.Round(CDbl((Me.datacal(2) + 3)) + CDbl(Me.nbrlignecalselec) / 6 * CDbl(Me.datacal(6)) + CDbl(Module1.screenadaptY(20)) + CDbl((Me.datacal(7) / 2)))))
				groupBoxcalendrier.Size = size
				groupBoxcalendrier.Visible = True
				groupBoxcalendrier = Nothing
				Me.Légende.Visible = True
				Me.Cursor = Cursors.Arrow
			End If
		End Sub

		Private Sub semisrecoltelegumeclick(ByVal sender As Object, ByVal e As EventArgs)
			Dim fiche As SVPLCApplication.Fiche = New SVPLCApplication.Fiche()
			Module1.nomfiche = Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing))
			Dim fiche1 As SVPLCApplication.Fiche = fiche
			fiche1.Text = Module1.nomfiche
			fiche1.Label1.Text = Module1.nomfiche
			fiche1 = Nothing
			fiche.Show()
		End Sub
	End Class
End Namespace