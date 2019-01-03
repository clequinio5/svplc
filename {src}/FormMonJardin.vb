Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormMonJardin
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Schema")>
		Private _Schema As TabPage

		<AccessedThroughProperty("RB")>
		Private _RB As TabPage

		<AccessedThroughProperty("Photos")>
		Private _Photos As TabPage

		<AccessedThroughProperty("ListView")>
		Private _ListView As System.Windows.Forms.ListView

		<AccessedThroughProperty("Photo")>
		Private _Photo As PictureBox

		<AccessedThroughProperty("GroupBoxMateriel")>
		Private _GroupBoxMateriel As GroupBox

		<AccessedThroughProperty("ListViewMateriel")>
		Private _ListViewMateriel As System.Windows.Forms.ListView

		<AccessedThroughProperty("ColumnHeader15")>
		Private _ColumnHeader15 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader16")>
		Private _ColumnHeader16 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader17")>
		Private _ColumnHeader17 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader18")>
		Private _ColumnHeader18 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader19")>
		Private _ColumnHeader19 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader20")>
		Private _ColumnHeader20 As ColumnHeader

		<AccessedThroughProperty("GroupBoxRecoltes")>
		Private _GroupBoxRecoltes As GroupBox

		<AccessedThroughProperty("ListViewRecoltes")>
		Private _ListViewRecoltes As System.Windows.Forms.ListView

		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader3")>
		Private _ColumnHeader3 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader4")>
		Private _ColumnHeader4 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader5")>
		Private _ColumnHeader5 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader6")>
		Private _ColumnHeader6 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader7")>
		Private _ColumnHeader7 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader8")>
		Private _ColumnHeader8 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader9")>
		Private _ColumnHeader9 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader10")>
		Private _ColumnHeader10 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader11")>
		Private _ColumnHeader11 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader12")>
		Private _ColumnHeader12 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader13")>
		Private _ColumnHeader13 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader14")>
		Private _ColumnHeader14 As ColumnHeader

		<AccessedThroughProperty("lblCommentaires")>
		Private _lblCommentaires As Label

		<AccessedThroughProperty("lblDate")>
		Private _lblDate As Label

		<AccessedThroughProperty("lblTitre")>
		Private _lblTitre As Label

		<AccessedThroughProperty("ColumnHeader21")>
		Private _ColumnHeader21 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader22")>
		Private _ColumnHeader22 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader23")>
		Private _ColumnHeader23 As ColumnHeader

		<AccessedThroughProperty("ColumnHeader24")>
		Private _ColumnHeader24 As ColumnHeader

		<AccessedThroughProperty("OpenFileDialogphoto")>
		Private _OpenFileDialogphoto As OpenFileDialog

		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		<AccessedThroughProperty("ColumnHeader25")>
		Private _ColumnHeader25 As ColumnHeader

		<AccessedThroughProperty("BackgroundWorker1")>
		Private _BackgroundWorker1 As BackgroundWorker

		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		<AccessedThroughProperty("ToolStripProgressBar1")>
		Private _ToolStripProgressBar1 As ToolStripProgressBar

		<AccessedThroughProperty("ToolStrip1")>
		Private _ToolStrip1 As ToolStrip

		<AccessedThroughProperty("ToolStripButton1")>
		Private _ToolStripButton1 As ToolStripButton

		<AccessedThroughProperty("ToolStripButton2")>
		Private _ToolStripButton2 As ToolStripButton

		<AccessedThroughProperty("ToolStripButton3")>
		Private _ToolStripButton3 As ToolStripButton

		<AccessedThroughProperty("SplitContainer1")>
		Private _SplitContainer1 As SplitContainer

		<AccessedThroughProperty("ToolStripButton4")>
		Private _ToolStripButton4 As ToolStripButton

		<AccessedThroughProperty("ColumnHeader26")>
		Private _ColumnHeader26 As ColumnHeader

		<AccessedThroughProperty("BackgroundWorker2")>
		Private _BackgroundWorker2 As BackgroundWorker

		<AccessedThroughProperty("ImageList2")>
		Private _ImageList2 As ImageList

		<AccessedThroughProperty("ToolStripButton5")>
		Private _ToolStripButton5 As ToolStripButton

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("Panelgrille")>
		Private _Panelgrille As Panel

		<AccessedThroughProperty("CheckBoxsupp")>
		Private _CheckBoxsupp As CheckBox

		<AccessedThroughProperty("PanelLégendes")>
		Private _PanelLégendes As Panel

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("ListView1")>
		Private _ListView1 As System.Windows.Forms.ListView

		<AccessedThroughProperty("ColumnHeader27")>
		Private _ColumnHeader27 As ColumnHeader

		<AccessedThroughProperty("ToolStrip2")>
		Private _ToolStrip2 As ToolStrip

		<AccessedThroughProperty("btnaddtof")>
		Private _btnaddtof As ToolStripButton

		<AccessedThroughProperty("btnsupptof")>
		Private _btnsupptof As ToolStripButton

		<AccessedThroughProperty("btnmodiftof")>
		Private _btnmodiftof As ToolStripButton

		<AccessedThroughProperty("ToolStrip3")>
		Private _ToolStrip3 As ToolStrip

		<AccessedThroughProperty("Buttonpart")>
		Private _Buttonpart As ToolStripButton

		<AccessedThroughProperty("Buttonreset")>
		Private _Buttonreset As ToolStripButton

		<AccessedThroughProperty("Buttonsave")>
		Private _Buttonsave As ToolStripButton

		<AccessedThroughProperty("Buttonsupp")>
		Private _Buttonsupp As ToolStripButton

		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		<AccessedThroughProperty("ToolStripLabel1")>
		Private _ToolStripLabel1 As ToolStripLabel

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("TabControl")>
		Private _TabControl As System.Windows.Forms.TabControl

		Private BMP As Formbmp

		Private nbrcell As Integer

		Private cotecellX As Integer

		Private espaceentredeuxcell As Integer

		Private nbrparcelles As Integer

		Private nbrmaxparcelles As Integer

		Private indexbmpselect As Integer

		Private Lgrille As Integer

		Private Hgrille As Integer

		Private cotecellY As Integer

		Private grille As CheckBox(,)

		Private mousedownQ As Boolean

		Private Légendes0 As List(Of Label)

		Private Légendes1 As List(Of Label)

		Private Pathjardin As List(Of String)

		Private couleursparcelles As Color()

		Private pathtempdossierjardin As String()

		Private namebmp As String

		Private Newrecolte As Formaddrecolte

		Private Newmateriel As Formaddmat

		Private Bilanfin As Formbilanfin

		Private Recoltes As List(Of String)

		Private Materiel As List(Of String)

		Private pathmateriel As String

		Private pathrecolte As String

		Private benef As Single

		Private couttotal As Single

		Private indexselection As Integer

		Private rang As Integer

		Private nbritemmat As Integer

		Private nbritemrecolte As Integer

		Private Propphoto As Formpropphoto

		Private Bibliophoto As List(Of Image)

		Private metadata As List(Of String)

		Private imagetraitee As Image

		Private pathimagetraitee As String

		Private newpathimage As String

		Private pathfichierphoto As String

		Private pathdossierphoto As String

		Private Pathphoto As String()

		Private nbrphotobibliochargee As Integer

		Private nbrphotobiblio As Integer

		Private indeximagetraitee As Integer

		Private Inputboxperso As FormInputbox

		Private fs As FileStream

		Private lecture As StreamReader

		Private ecriture As StreamWriter

		Private firstload1 As Boolean

		Private firstload2 As Boolean

		Private compt As Integer

		Friend Overridable Property BackgroundWorker1 As BackgroundWorker
			Get
				Return Me._BackgroundWorker1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim runWorkerCompletedEventHandler As System.ComponentModel.RunWorkerCompletedEventHandler = New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf formMonJardin.BackgroundWorker1_RunWorkerCompleted)
				Dim formMonJardin1 As SVPLCApplication.FormMonJardin = Me
				Dim progressChangedEventHandler As System.ComponentModel.ProgressChangedEventHandler = New System.ComponentModel.ProgressChangedEventHandler(AddressOf formMonJardin1.BackgroundWorker1_ProgressChanged)
				Dim formMonJardin2 As SVPLCApplication.FormMonJardin = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf formMonJardin2.BackgroundWorker1_DoWork)
				If (Me._BackgroundWorker1 IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorker1.RunWorkerCompleted,  runWorkerCompletedEventHandler
					RemoveHandler Me._BackgroundWorker1.ProgressChanged,  progressChangedEventHandler
					RemoveHandler Me._BackgroundWorker1.DoWork,  doWorkEventHandler
				End If
				Me._BackgroundWorker1 = value
				If (Me._BackgroundWorker1 IsNot Nothing) Then
					AddHandler Me._BackgroundWorker1.RunWorkerCompleted,  runWorkerCompletedEventHandler
					AddHandler Me._BackgroundWorker1.ProgressChanged,  progressChangedEventHandler
					AddHandler Me._BackgroundWorker1.DoWork,  doWorkEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property BackgroundWorker2 As BackgroundWorker
			Get
				Return Me._BackgroundWorker2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim runWorkerCompletedEventHandler As System.ComponentModel.RunWorkerCompletedEventHandler = New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf formMonJardin.BackgroundWorker2_RunWorkerCompleted)
				Dim formMonJardin1 As SVPLCApplication.FormMonJardin = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf formMonJardin1.BackgroundWorker2_DoWork)
				If (Me._BackgroundWorker2 IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorker2.RunWorkerCompleted,  runWorkerCompletedEventHandler
					RemoveHandler Me._BackgroundWorker2.DoWork,  doWorkEventHandler
				End If
				Me._BackgroundWorker2 = value
				If (Me._BackgroundWorker2 IsNot Nothing) Then
					AddHandler Me._BackgroundWorker2.RunWorkerCompleted,  runWorkerCompletedEventHandler
					AddHandler Me._BackgroundWorker2.DoWork,  doWorkEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property btnaddtof As ToolStripButton
			Get
				Return Me._btnaddtof
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.btnAjouterUnePhoto_Click)
				If (Me._btnaddtof IsNot Nothing) Then
					RemoveHandler Me._btnaddtof.Click,  eventHandler
				End If
				Me._btnaddtof = value
				If (Me._btnaddtof IsNot Nothing) Then
					AddHandler Me._btnaddtof.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property btnmodiftof As ToolStripButton
			Get
				Return Me._btnmodiftof
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.btnModifierLaPhoto_Click)
				If (Me._btnmodiftof IsNot Nothing) Then
					RemoveHandler Me._btnmodiftof.Click,  eventHandler
				End If
				Me._btnmodiftof = value
				If (Me._btnmodiftof IsNot Nothing) Then
					AddHandler Me._btnmodiftof.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property btnsupptof As ToolStripButton
			Get
				Return Me._btnsupptof
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.btnSupprimerLaPhoto_Click)
				If (Me._btnsupptof IsNot Nothing) Then
					RemoveHandler Me._btnsupptof.Click,  eventHandler
				End If
				Me._btnsupptof = value
				If (Me._btnsupptof IsNot Nothing) Then
					AddHandler Me._btnsupptof.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonpart As ToolStripButton
			Get
				Return Me._Buttonpart
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.Button2_Click)
				If (Me._Buttonpart IsNot Nothing) Then
					RemoveHandler Me._Buttonpart.Click,  eventHandler
				End If
				Me._Buttonpart = value
				If (Me._Buttonpart IsNot Nothing) Then
					AddHandler Me._Buttonpart.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonreset As ToolStripButton
			Get
				Return Me._Buttonreset
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.Buttonreset_Click)
				If (Me._Buttonreset IsNot Nothing) Then
					RemoveHandler Me._Buttonreset.Click,  eventHandler
				End If
				Me._Buttonreset = value
				If (Me._Buttonreset IsNot Nothing) Then
					AddHandler Me._Buttonreset.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonsave As ToolStripButton
			Get
				Return Me._Buttonsave
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.Button1_Click)
				If (Me._Buttonsave IsNot Nothing) Then
					RemoveHandler Me._Buttonsave.Click,  eventHandler
				End If
				Me._Buttonsave = value
				If (Me._Buttonsave IsNot Nothing) Then
					AddHandler Me._Buttonsave.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Buttonsupp As ToolStripButton
			Get
				Return Me._Buttonsupp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.Button2_Click_1)
				If (Me._Buttonsupp IsNot Nothing) Then
					RemoveHandler Me._Buttonsupp.Click,  eventHandler
				End If
				Me._Buttonsupp = value
				If (Me._Buttonsupp IsNot Nothing) Then
					AddHandler Me._Buttonsupp.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property CheckBoxsupp As CheckBox
			Get
				Return Me._CheckBoxsupp
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As CheckBox)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.CheckBox1_CheckedChanged)
				If (Me._CheckBoxsupp IsNot Nothing) Then
					RemoveHandler Me._CheckBoxsupp.CheckedChanged,  eventHandler
				End If
				Me._CheckBoxsupp = value
				If (Me._CheckBoxsupp IsNot Nothing) Then
					AddHandler Me._CheckBoxsupp.CheckedChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ColumnHeader1 As ColumnHeader
			Get
				Return Me._ColumnHeader1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader1 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader10 As ColumnHeader
			Get
				Return Me._ColumnHeader10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader10 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader11 As ColumnHeader
			Get
				Return Me._ColumnHeader11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader11 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader12 As ColumnHeader
			Get
				Return Me._ColumnHeader12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader12 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader13 As ColumnHeader
			Get
				Return Me._ColumnHeader13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader13 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader14 As ColumnHeader
			Get
				Return Me._ColumnHeader14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader14 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader15 As ColumnHeader
			Get
				Return Me._ColumnHeader15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader15 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader16 As ColumnHeader
			Get
				Return Me._ColumnHeader16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader16 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader17 As ColumnHeader
			Get
				Return Me._ColumnHeader17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader17 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader18 As ColumnHeader
			Get
				Return Me._ColumnHeader18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader18 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader19 As ColumnHeader
			Get
				Return Me._ColumnHeader19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader19 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader2 As ColumnHeader
			Get
				Return Me._ColumnHeader2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader2 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader20 As ColumnHeader
			Get
				Return Me._ColumnHeader20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader20 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader21 As ColumnHeader
			Get
				Return Me._ColumnHeader21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader21 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader22 As ColumnHeader
			Get
				Return Me._ColumnHeader22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader22 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader23 As ColumnHeader
			Get
				Return Me._ColumnHeader23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader23 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader24 As ColumnHeader
			Get
				Return Me._ColumnHeader24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader24 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader25 As ColumnHeader
			Get
				Return Me._ColumnHeader25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader25 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader26 As ColumnHeader
			Get
				Return Me._ColumnHeader26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader26 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader27 As ColumnHeader
			Get
				Return Me._ColumnHeader27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader27 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader3 As ColumnHeader
			Get
				Return Me._ColumnHeader3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader3 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader4 As ColumnHeader
			Get
				Return Me._ColumnHeader4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader4 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader5 As ColumnHeader
			Get
				Return Me._ColumnHeader5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader5 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader6 As ColumnHeader
			Get
				Return Me._ColumnHeader6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader6 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader7 As ColumnHeader
			Get
				Return Me._ColumnHeader7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader7 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader8 As ColumnHeader
			Get
				Return Me._ColumnHeader8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader8 = value
			End Set
		End Property

		Friend Overridable Property ColumnHeader9 As ColumnHeader
			Get
				Return Me._ColumnHeader9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ColumnHeader)
				Me._ColumnHeader9 = value
			End Set
		End Property

		Private Overridable Property GroupBoxMateriel As GroupBox
			Get
				Return Me._GroupBoxMateriel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As GroupBox)
				Me._GroupBoxMateriel = value
			End Set
		End Property

		Private Overridable Property GroupBoxRecoltes As GroupBox
			Get
				Return Me._GroupBoxRecoltes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As GroupBox)
				Me._GroupBoxRecoltes = value
			End Set
		End Property

		Private Overridable Property ImageList1 As ImageList
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
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.Label_Click)
				If (Me._Label3 IsNot Nothing) Then
					RemoveHandler Me._Label3.Click,  eventHandler
				End If
				Me._Label3 = value
				If (Me._Label3 IsNot Nothing) Then
					AddHandler Me._Label3.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Label4 As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.Label_Click)
				If (Me._Label4 IsNot Nothing) Then
					RemoveHandler Me._Label4.Click,  eventHandler
				End If
				Me._Label4 = value
				If (Me._Label4 IsNot Nothing) Then
					AddHandler Me._Label4.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property lblCommentaires As Label
			Get
				Return Me._lblCommentaires
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblCommentaires = value
			End Set
		End Property

		Private Overridable Property lblDate As Label
			Get
				Return Me._lblDate
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblDate = value
			End Set
		End Property

		Private Overridable Property lblTitre As Label
			Get
				Return Me._lblTitre
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lblTitre = value
			End Set
		End Property

		Private Overridable Property ListView As System.Windows.Forms.ListView
			Get
				Return Me._ListView
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.ListView)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim keyEventHandler As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf formMonJardin.ListView_KeyUp)
				Dim formMonJardin1 As SVPLCApplication.FormMonJardin = Me
				Dim keyEventHandler1 As System.Windows.Forms.KeyEventHandler = New System.Windows.Forms.KeyEventHandler(AddressOf formMonJardin1.ListView_KeyDown)
				Dim formMonJardin2 As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin2.ListView_Click)
				If (Me._ListView IsNot Nothing) Then
					RemoveHandler Me._ListView.KeyUp,  keyEventHandler
					RemoveHandler Me._ListView.KeyDown,  keyEventHandler1
					RemoveHandler Me._ListView.Click,  eventHandler
				End If
				Me._ListView = value
				If (Me._ListView IsNot Nothing) Then
					AddHandler Me._ListView.KeyUp,  keyEventHandler
					AddHandler Me._ListView.KeyDown,  keyEventHandler1
					AddHandler Me._ListView.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ListView1 As System.Windows.Forms.ListView
			Get
				Return Me._ListView1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.ListView)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.ListView1_Click)
				If (Me._ListView1 IsNot Nothing) Then
					RemoveHandler Me._ListView1.DoubleClick,  eventHandler
				End If
				Me._ListView1 = value
				If (Me._ListView1 IsNot Nothing) Then
					AddHandler Me._ListView1.DoubleClick,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property ListViewMateriel As System.Windows.Forms.ListView
			Get
				Return Me._ListViewMateriel
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.ListView)
				Me._ListViewMateriel = value
			End Set
		End Property

		Private Overridable Property ListViewRecoltes As System.Windows.Forms.ListView
			Get
				Return Me._ListViewRecoltes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.ListView)
				Me._ListViewRecoltes = value
			End Set
		End Property

		Private Overridable Property OpenFileDialogphoto As OpenFileDialog
			Get
				Return Me._OpenFileDialogphoto
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As OpenFileDialog)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim cancelEventHandler As System.ComponentModel.CancelEventHandler = New System.ComponentModel.CancelEventHandler(AddressOf formMonJardin.OpenFileDialogphoto_FileOk)
				If (Me._OpenFileDialogphoto IsNot Nothing) Then
					RemoveHandler Me._OpenFileDialogphoto.FileOk,  cancelEventHandler
				End If
				Me._OpenFileDialogphoto = value
				If (Me._OpenFileDialogphoto IsNot Nothing) Then
					AddHandler Me._OpenFileDialogphoto.FileOk,  cancelEventHandler
				End If
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

		Friend Overridable Property Panelgrille As Panel
			Get
				Return Me._Panelgrille
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelgrille = value
			End Set
		End Property

		Friend Overridable Property PanelLégendes As Panel
			Get
				Return Me._PanelLégendes
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._PanelLégendes = value
			End Set
		End Property

		Private Overridable Property Photo As PictureBox
			Get
				Return Me._Photo
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._Photo = value
			End Set
		End Property

		Friend Overridable Property Photos As TabPage
			Get
				Return Me._Photos
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabPage)
				Me._Photos = value
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

		Friend Overridable Property RB As TabPage
			Get
				Return Me._RB
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabPage)
				Me._RB = value
			End Set
		End Property

		Friend Overridable Property Schema As TabPage
			Get
				Return Me._Schema
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TabPage)
				Me._Schema = value
			End Set
		End Property

		Friend Overridable Property SplitContainer1 As SplitContainer
			Get
				Return Me._SplitContainer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As SplitContainer)
				Me._SplitContainer1 = value
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

		Public Overridable Property TabControl As System.Windows.Forms.TabControl
			Get
				Return Me._TabControl
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.TabControl)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.TabControl_SelectedIndexChanged)
				Dim formMonJardin1 As SVPLCApplication.FormMonJardin = Me
				Dim drawItemEventHandler As System.Windows.Forms.DrawItemEventHandler = New System.Windows.Forms.DrawItemEventHandler(AddressOf formMonJardin1.TabControl1_DrawItem)
				If (Me._TabControl IsNot Nothing) Then
					RemoveHandler Me._TabControl.SelectedIndexChanged,  eventHandler
					RemoveHandler Me._TabControl.DrawItem,  drawItemEventHandler
				End If
				Me._TabControl = value
				If (Me._TabControl IsNot Nothing) Then
					AddHandler Me._TabControl.SelectedIndexChanged,  eventHandler
					AddHandler Me._TabControl.DrawItem,  drawItemEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ToolStrip1 As ToolStrip
			Get
				Return Me._ToolStrip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStrip)
				Me._ToolStrip1 = value
			End Set
		End Property

		Friend Overridable Property ToolStrip2 As ToolStrip
			Get
				Return Me._ToolStrip2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStrip)
				Me._ToolStrip2 = value
			End Set
		End Property

		Friend Overridable Property ToolStrip3 As ToolStrip
			Get
				Return Me._ToolStrip3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStrip)
				Me._ToolStrip3 = value
			End Set
		End Property

		Friend Overridable Property ToolStripButton1 As ToolStripButton
			Get
				Return Me._ToolStripButton1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.ToolStripButton1_Click)
				If (Me._ToolStripButton1 IsNot Nothing) Then
					RemoveHandler Me._ToolStripButton1.Click,  eventHandler
				End If
				Me._ToolStripButton1 = value
				If (Me._ToolStripButton1 IsNot Nothing) Then
					AddHandler Me._ToolStripButton1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripButton2 As ToolStripButton
			Get
				Return Me._ToolStripButton2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.ToolStripButton2_Click)
				If (Me._ToolStripButton2 IsNot Nothing) Then
					RemoveHandler Me._ToolStripButton2.Click,  eventHandler
				End If
				Me._ToolStripButton2 = value
				If (Me._ToolStripButton2 IsNot Nothing) Then
					AddHandler Me._ToolStripButton2.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripButton3 As ToolStripButton
			Get
				Return Me._ToolStripButton3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.ToolStripButton3_Click)
				If (Me._ToolStripButton3 IsNot Nothing) Then
					RemoveHandler Me._ToolStripButton3.Click,  eventHandler
				End If
				Me._ToolStripButton3 = value
				If (Me._ToolStripButton3 IsNot Nothing) Then
					AddHandler Me._ToolStripButton3.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripButton4 As ToolStripButton
			Get
				Return Me._ToolStripButton4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.ToolStripButton4_Click)
				If (Me._ToolStripButton4 IsNot Nothing) Then
					RemoveHandler Me._ToolStripButton4.Click,  eventHandler
				End If
				Me._ToolStripButton4 = value
				If (Me._ToolStripButton4 IsNot Nothing) Then
					AddHandler Me._ToolStripButton4.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripButton5 As ToolStripButton
			Get
				Return Me._ToolStripButton5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripButton)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMonJardin.ToolStripButton5_Click)
				If (Me._ToolStripButton5 IsNot Nothing) Then
					RemoveHandler Me._ToolStripButton5.Click,  eventHandler
				End If
				Me._ToolStripButton5 = value
				If (Me._ToolStripButton5 IsNot Nothing) Then
					AddHandler Me._ToolStripButton5.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ToolStripLabel1 As ToolStripLabel
			Get
				Return Me._ToolStripLabel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripLabel)
				Me._ToolStripLabel1 = value
			End Set
		End Property

		Friend Overridable Property ToolStripProgressBar1 As ToolStripProgressBar
			Get
				Return Me._ToolStripProgressBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripProgressBar)
				Me._ToolStripProgressBar1 = value
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

		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel1 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formMonJardin1 As FormMonJardin = Me
			AddHandler MyBase.FormClosing,  New FormClosingEventHandler(AddressOf formMonJardin1.Formgarden_FormClosing)
			Dim formMonJardin2 As FormMonJardin = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formMonJardin2.Formgarden_FormClosed)
			Dim formMonJardin3 As FormMonJardin = Me
			AddHandler MyBase.KeyDown,  New KeyEventHandler(AddressOf formMonJardin3.Form1_KeyDown)
			Dim formMonJardin4 As FormMonJardin = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formMonJardin4.Formgarden_Load)
			Me.Légendes0 = New List(Of Label)()
			Me.Légendes1 = New List(Of Label)()
			Me.Pathjardin = New List(Of String)()
			Me.Recoltes = New List(Of String)()
			Me.Materiel = New List(Of String)()
			Me.Bibliophoto = New List(Of Image)()
			Me.metadata = New List(Of String)()
			Me.InitializeComponent()
		End Sub

		Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Me.lecture = New StreamReader(Me.pathfichierphoto)
			While Me.lecture.Peek() <> -1
				Me.metadata.Add(Me.lecture.ReadLine())
			End While
			Me.lecture.Close()
			Me.compt = 0
			Dim num As Integer = Me.nbrphotobiblio
			For i As Integer = 1 To num Step 1
				Me.fs = File.OpenRead(Me.Pathphoto(Me.compt))
				Me.imagetraitee = Image.FromStream(Me.fs)
				Me.fs.Close()
				Me.ImageList1.Images.Add(Conversions.ToString(Me.compt), Me.imagetraitee)
				Me.Bibliophoto.Add(Me.imagetraitee)
				Me.compt = Me.compt + 1
				Dim backgroundWorker1 As BackgroundWorker = Me.BackgroundWorker1
				Dim num1 As Integer = CInt(Math.Round(CDbl((Me.compt * 100)) / CDbl(Me.nbrphotobiblio)))
				Dim str() As String = { "Chargement de l'image ", Conversions.ToString(Me.compt), " sur ", Conversions.ToString(Me.nbrphotobiblio), "..." }
				backgroundWorker1.ReportProgress(num1, String.Concat(str))
			Next

		End Sub

		Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
			Me.ToolStripProgressBar1.Value = e.ProgressPercentage
			Me.ToolStripStatusLabel1.Text = Conversions.ToString(e.UserState)
		End Sub

		Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			Me.nbrphotobibliochargee = 0
			Dim num As Integer = Me.nbrphotobiblio * 3 - 1
			Dim num1 As Integer = 0
			Do
				Me.ListView.Items.Add("", Me.nbrphotobibliochargee)
				Dim subItems As ListViewItem.ListViewSubItemCollection = Me.ListView.Items(Me.nbrphotobibliochargee).SubItems
				subItems.Add(Me.metadata(num1))
				subItems.Add(Me.metadata(num1 + 2))
				subItems.Add(Me.metadata(num1 + 1))
				subItems = Nothing
				Me.nbrphotobibliochargee = Me.nbrphotobibliochargee + 1
				num1 = num1 + 3
			Loop While num1 <= num
			Me.ListView.Focus()
			Me.ListView.Items(0).Focused = True
			Me.ListView.Items(0).Selected = True
			Me.Photo.Image = Me.Bibliophoto(0)
			Me.lblTitre.Text = String.Concat("Titre: ", Me.metadata(0))
			Me.lblDate.Text = String.Concat("Date: ", Me.metadata(1))
			Me.lblCommentaires.Text = String.Concat("Commentaires: ", Me.metadata(2))
			Me.StatusStrip1.Visible = False
			Me.Cursor = Cursors.[Default]
		End Sub

		Private Sub BackgroundWorker2_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			If (File.Exists(Me.pathrecolte)) Then
				Me.lecture = New StreamReader(Me.pathrecolte)
				While Me.lecture.Peek() <> -1
					Me.Recoltes.Add(Me.lecture.ReadLine())
				End While
				Me.lecture.Close()
			Else
				File.Create(Me.pathrecolte)
			End If
			If (File.Exists(Me.pathmateriel)) Then
				Me.lecture = New StreamReader(Me.pathmateriel)
				While Me.lecture.Peek() <> -1
					Me.Materiel.Add(Me.lecture.ReadLine())
				End While
				Me.lecture.Close()
			Else
				File.Create(Me.pathmateriel)
			End If
		End Sub

		Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			Dim recoltes As List(Of String)
			Dim num As Integer
			Dim item As String
			Dim materiel As List(Of String)
			Dim num1 As Integer
			Dim str As String
			If (Me.Recoltes.Count > 0) Then
				Me.compt = 0
				Dim count As Integer = Me.Recoltes.Count - 1
				Dim num2 As Integer = 0
				Do
					Me.ListViewRecoltes.Items.Add(Me.Recoltes(num2))
					materiel = Me.Recoltes
					num1 = num2 + 3
					str = materiel(num1)
					Dim str1 As String = Me.splitxt(str, 0)
					materiel(num1) = str
					Dim [single] As Single = -Single.Parse(str1) * Single.Parse(Me.Recoltes(num2 + 7))
					recoltes = Me.Recoltes
					num = num2 + 8
					item = recoltes(num)
					Dim str2 As String = Me.splitxt(item, 0)
					recoltes(num) = item
					Dim single1 As Single = [single] + Single.Parse(str2) * Single.Parse(Me.Recoltes(num2 + 9))
					Dim strs As List(Of String) = Me.Recoltes
					Dim num3 As Integer = num2 + 10
					Dim item1 As String = strs(num3)
					Dim str3 As String = Me.splitxt(item1, 0)
					strs(num3) = item1
					Me.benef = single1 + Single.Parse(str3) * Single.Parse(Me.Recoltes(num2 + 11))
					Dim subItems As ListViewItem.ListViewSubItemCollection = Me.ListViewRecoltes.Items(Me.compt).SubItems
					subItems.Add(Me.Recoltes(num2 + 1))
					subItems.Add(Me.Recoltes(num2 + 2))
					recoltes = Me.Recoltes
					num = num2 + 3
					item = recoltes(num)
					Dim str4 As String = Me.splitxt(item, 0)
					recoltes(num) = item
					materiel = Me.Recoltes
					num1 = num2 + 3
					str = materiel(num1)
					Dim str5 As String = Me.splitxt(str, 1)
					materiel(num1) = str
					subItems.Add(String.Concat(str4, " ", str5))
					subItems.Add(Me.Recoltes(num2 + 4))
					recoltes = Me.Recoltes
					num = num2 + 5
					item = recoltes(num)
					Dim str6 As String = Me.splitxt(item, 0)
					recoltes(num) = item
					materiel = Me.Recoltes
					num1 = num2 + 5
					str = materiel(num1)
					Dim str7 As String = Me.splitxt(str, 1)
					materiel(num1) = str
					subItems.Add(String.Concat(str6, " ", str7))
					subItems.Add(Me.Recoltes(num2 + 6))
					subItems.Add(Me.Recoltes(num2 + 7))
					recoltes = Me.Recoltes
					num = num2 + 8
					item = recoltes(num)
					Dim str8 As String = Me.splitxt(item, 0)
					recoltes(num) = item
					materiel = Me.Recoltes
					num1 = num2 + 8
					str = materiel(num1)
					Dim str9 As String = Me.splitxt(str, 1)
					materiel(num1) = str
					subItems.Add(String.Concat(str8, " ", str9))
					subItems.Add(Me.Recoltes(num2 + 9))
					recoltes = Me.Recoltes
					num = num2 + 10
					item = recoltes(num)
					Dim str10 As String = Me.splitxt(item, 0)
					recoltes(num) = item
					materiel = Me.Recoltes
					num1 = num2 + 10
					str = materiel(num1)
					Dim str11 As String = Me.splitxt(str, 1)
					materiel(num1) = str
					subItems.Add(String.Concat(str10, " ", str11))
					subItems.Add(Me.Recoltes(num2 + 11))
					subItems.Add(Me.benef.ToString())
					subItems.Add(Me.Recoltes(num2 + 12))
					subItems = Nothing
					Me.compt = Me.compt + 1
					num2 = num2 + 13
				Loop While num2 <= count
				Me.nbritemrecolte = Me.compt
			End If
			If (Me.Materiel.Count > 0) Then
				Me.compt = 0
				Dim count1 As Integer = Me.Materiel.Count - 1
				Dim num4 As Integer = 0
				Do
					Me.ListViewMateriel.Items.Add(Me.Materiel(num4))
					materiel = Me.Materiel
					num1 = num4 + 2
					str = materiel(num1)
					Dim str12 As String = Me.splitxt(str, 0)
					materiel(num1) = str
					Me.couttotal = Single.Parse(str12) * Single.Parse(Me.Materiel(num4 + 3))
					Dim listViewSubItemCollections As ListViewItem.ListViewSubItemCollection = Me.ListViewMateriel.Items(Me.compt).SubItems
					listViewSubItemCollections.Add(Me.Materiel(num4 + 1))
					recoltes = Me.Materiel
					num = num4 + 2
					item = recoltes(num)
					Dim str13 As String = Me.splitxt(item, 0)
					recoltes(num) = item
					materiel = Me.Materiel
					num1 = num4 + 2
					str = materiel(num1)
					Dim str14 As String = Me.splitxt(str, 1)
					materiel(num1) = str
					listViewSubItemCollections.Add(String.Concat(str13, " ", str14))
					listViewSubItemCollections.Add(Me.Materiel(num4 + 3))
					listViewSubItemCollections.Add(Me.Materiel(num4 + 4))
					listViewSubItemCollections.Add(Me.Materiel(num4 + 5))
					listViewSubItemCollections.Add(Me.couttotal.ToString())
					listViewSubItemCollections.Add(Me.Materiel(num4 + 6))
					listViewSubItemCollections = Nothing
					Me.compt = Me.compt + 1
					num4 = num4 + 7
				Loop While num4 <= count1
				Me.nbritemmat = Me.compt
			End If
		End Sub

		Private Sub btnAjouterUnePhoto_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.OpenFileDialogphoto.ShowDialog()
		End Sub

		Private Sub btnModifierLaPhoto_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.titrephot = Me.metadata(Me.indeximagetraitee * 3)
			MyProject.Forms.FormPasPas.datephot = Me.metadata(Me.indeximagetraitee * 3 + 1)
			MyProject.Forms.FormPasPas.comphot = Me.metadata(Me.indeximagetraitee * 3 + 2)
			Me.Propphoto = New Formpropphoto()
			If (Me.Propphoto.ShowDialog(Me) <> System.Windows.Forms.DialogResult.Cancel) Then
				Me.metadata(Me.indeximagetraitee * 3) = MyProject.Forms.FormPasPas.titrephot
				Me.metadata(Me.indeximagetraitee * 3 + 1) = MyProject.Forms.FormPasPas.datephot
				Me.metadata(Me.indeximagetraitee * 3 + 2) = MyProject.Forms.FormPasPas.comphot
				Me.lblTitre.Text = String.Concat("Titre: ", Me.metadata(Me.indeximagetraitee * 3))
				Me.lblDate.Text = String.Concat("Date: ", Me.metadata(Me.indeximagetraitee * 3 + 1))
				Me.lblCommentaires.Text = String.Concat("Commentaires: ", Me.metadata(Me.indeximagetraitee * 3 + 2))
				Dim item As ListViewItem = Me.ListView.Items(Me.indeximagetraitee)
				item.SubItems(1).Text = Me.metadata(Me.indeximagetraitee * 3)
				item.SubItems(2).Text = Me.metadata(Me.indeximagetraitee * 3 + 2)
				item.SubItems(3).Text = Me.metadata(Me.indeximagetraitee * 3 + 1)
				item = Nothing
			Else
				MyProject.Forms.Formpropphoto.Dispose()
			End If
		End Sub

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub btnSupprimerLaPhoto_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.ImageList1.Images.RemoveAt(Me.indeximagetraitee)
			Me.Bibliophoto.RemoveAt(Me.indeximagetraitee)
			Me.metadata.RemoveRange(Me.indeximagetraitee * 3, 3)
			Me.ListView.Items.RemoveAt(Me.indeximagetraitee)
			File.Delete(String.Concat(Me.pathdossierphoto, "\Photo", Conversions.ToString(Me.indeximagetraitee)))
			If (Me.indeximagetraitee < Me.nbrphotobibliochargee - 1) Then
				Dim num As Integer = Me.indeximagetraitee + 1
				Dim num1 As Integer = Me.nbrphotobibliochargee - 1
				For i As Integer = num To num1 Step 1
					FileSystem.Rename(String.Concat(Me.pathdossierphoto, "\Photo", Conversions.ToString(i)), String.Concat(Me.pathdossierphoto, "\Photo", Conversions.ToString(i - 1)))
					Me.ListView.Items(i - 1).ImageIndex = i - 1
				Next

			End If
			Me.nbrphotobibliochargee = Me.nbrphotobibliochargee - 1
			If (Me.nbrphotobibliochargee <> 0) Then
				Me.ListView.Focus()
				Me.ListView.Items(0).Focused = True
				Me.ListView.Items(0).Selected = True
				Me.Photo.Image = Me.Bibliophoto(0)
				Me.lblTitre.Text = String.Concat("Titre: ", Me.metadata(0))
				Me.lblDate.Text = String.Concat("Date: ", Me.metadata(1))
				Me.lblCommentaires.Text = String.Concat("Commentaires: ", Me.metadata(2))
				Me.btnmodiftof.Enabled = True
				Me.btnsupptof.Enabled = True
			Else
				Me.Photo.Image = Nothing
				Me.lblTitre.Text = ""
				Me.lblDate.Text = ""
				Me.lblCommentaires.Text = ""
				Me.btnmodiftof.Enabled = False
				Me.btnsupptof.Enabled = False
			End If
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Try
				Dim bitmap As System.Drawing.Bitmap = New System.Drawing.Bitmap(Me.Panel1.Width, Me.Panel1.Width)
				Dim panel1 As Panel = Me.Panel1
				Dim rectangle As System.Drawing.Rectangle = New System.Drawing.Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Width)
				panel1.DrawToBitmap(bitmap, rectangle)
				bitmap.Save(String.Concat(Module1.PATHS(16), "\", Me.Label3.Text))
				Me.Pathjardin.Add(String.Concat(Module1.PATHS(16), "\", Me.Label3.Text))
				Me.ListView1.Items.Add(Me.Label3.Text)
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'enregistrement", "Ail! Plus z'un zeste!")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer
			Dim num1 As Integer = 0
			Dim num2 As Integer = Me.nbrcell - 1
			Dim num3 As Integer = 0
			Do
				Dim num4 As Integer = Me.nbrcell - 1
				num = 0
				Do
					If (Me.grille(num3, num).Checked) Then
						num1 = num1 + 1
					End If
					num = num + 1
				Loop While num <= num4
				num3 = num3 + 1
			Loop While num3 <= num2
			If (num1 > 0 And Me.nbrparcelles < Me.nbrmaxparcelles + 1) Then
				Me.nbrparcelles = Me.nbrparcelles + 1
			End If
			If (Me.nbrparcelles >= Me.nbrmaxparcelles + 1) Then
				MyProject.Forms.FormPasPas.Msgboxperso("Vous avez atteint le nombre limite de parcelles", "Ail! Plus z'un zeste...")
				Dim num5 As Integer = Me.nbrcell - 1
				num3 = 0
				Do
					Dim num6 As Integer = Me.nbrcell - 1
					num = 0
					Do
						If (Me.grille(num3, num).Checked) Then
							Me.grille(num3, num).Checked = False
						End If
						num = num + 1
					Loop While num <= num6
					num3 = num3 + 1
				Loop While num3 <= num5
				Me.nbrparcelles = Me.nbrparcelles - 1
			ElseIf (num1 > 0) Then
				Dim num7 As Integer = Me.nbrcell - 1
				num3 = 0
				Do
					Dim num8 As Integer = Me.nbrcell - 1
					num = 0
					Do
						If (Me.grille(num3, num).Checked) Then
							Dim checkBox As System.Windows.Forms.CheckBox = Me.grille(num3, num)
							checkBox.Checked = False
							checkBox.BackColor = Me.couleursparcelles(Me.nbrparcelles)
							checkBox.Enabled = False
							checkBox = Nothing
						End If
						num = num + 1
					Loop While num <= num8
					num3 = num3 + 1
				Loop While num3 <= num7
				Me.Légendes0.Add(New System.Windows.Forms.Label())
				Dim item As System.Windows.Forms.Label = Me.Légendes0(Me.nbrparcelles - 1)
				item.Size = New System.Drawing.Size(15, 15)
				item.BorderStyle = BorderStyle.FixedSingle
				item.BackColor = Me.couleursparcelles(Me.nbrparcelles)
				Dim point As System.Drawing.Point = New System.Drawing.Point(10, (Me.nbrparcelles - 1) * 25 + 25)
				item.Location = point
				item = Nothing
				Me.Légendes1.Add(New System.Windows.Forms.Label())
				Dim label As System.Windows.Forms.Label = Me.Légendes1(Me.nbrparcelles - 1)
				Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
				AddHandler label.Click,  New EventHandler(AddressOf formMonJardin.Label_Click)
				label.AutoSize = True
				label.Text = "Cliquez pour changer"
				point = New System.Drawing.Point(30, (Me.nbrparcelles - 1) * 25 + 25)
				label.Location = point
				label = Nothing
				Dim controls As Control.ControlCollection = Me.PanelLégendes.Controls
				controls.Add(Me.Légendes0(Me.nbrparcelles - 1))
				controls.Add(Me.Légendes1(Me.nbrparcelles - 1))
				controls = Nothing
			End If
		End Sub

		Private Sub Button2_Click_1(ByVal sender As Object, ByVal e As EventArgs)
			Try
				Me.indexbmpselect = Me.ListView1.SelectedIndices(0)
				File.Delete(Me.Pathjardin(Me.indexbmpselect))
				Me.Pathjardin.RemoveAt(Me.indexbmpselect)
				Me.ListView1.Items.RemoveAt(Me.indexbmpselect)
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Faudrait peut être m'indiquer ce que tu veux supprimer, nan? Je suis pas devin!", "Ail! Plus z'un zeste!")
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub Buttonreset_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.PanelLégendes.Controls.Clear()
			Me.Panelgrille.Controls.Clear()
			For i As Integer = Me.nbrparcelles - 1 To 0 Step -1
				Me.Légendes0.RemoveAt(i)
				Me.Légendes1.RemoveAt(i)
			Next

			Me.nbrparcelles = 0
			Me.nbrcell = 18
			Me.cotecellX = 30
			Me.cotecellY = 30
			Me.espaceentredeuxcell = -1
			ReDim Me.grille(Me.nbrcell - 1 + 1 - 1, Me.nbrcell - 1 + 1 - 1)
			Dim num As Integer = Me.nbrcell - 1
			For j As Integer = 0 To num Step 1
				Dim num1 As Integer = Me.nbrcell - 1
				For k As Integer = 0 To num1 Step 1
					Me.grille(j, k) = New CheckBox()
					Dim seaGreen As CheckBox = Me.grille(j, k)
					seaGreen.Appearance = Appearance.Button
					seaGreen.FlatStyle = FlatStyle.Flat
					seaGreen.BackColor = Color.SeaGreen
					seaGreen.FlatAppearance.CheckedBackColor = Color.SaddleBrown
					Dim size As System.Drawing.Size = New System.Drawing.Size(Me.cotecellX, Me.cotecellY)
					seaGreen.Size = size
					Dim point As System.Drawing.Point = New System.Drawing.Point(j * (Me.cotecellX + Me.espaceentredeuxcell), k * (Me.cotecellY + Me.espaceentredeuxcell))
					seaGreen.Location = point
					Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.CheckStateChanged,  New EventHandler(AddressOf formMonJardin.CheckBox_CheckedChanged)
					Dim formMonJardin1 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.MouseDown,  New MouseEventHandler(AddressOf formMonJardin1.CheckBox_MouseDown)
					Dim formMonJardin2 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.Click,  New EventHandler(AddressOf formMonJardin2.CheckBox_Click)
					Dim formMonJardin3 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.MouseUp,  New MouseEventHandler(AddressOf formMonJardin3.CheckBox_MouseUp)
					Dim formMonJardin4 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.MouseMove,  New MouseEventHandler(AddressOf formMonJardin4.CheckBox_MouseMove)
					seaGreen = Nothing
					Me.Lgrille = Me.nbrcell * (Me.cotecellX + Me.espaceentredeuxcell) - Me.espaceentredeuxcell
					Me.Hgrille = Me.nbrcell * (Me.cotecellY + Me.espaceentredeuxcell) - Me.espaceentredeuxcell
					Dim panelgrille As Panel = Me.Panelgrille
					panelgrille.Controls.Add(Me.grille(j, k))
					size = New System.Drawing.Size(Me.nbrcell * (Me.cotecellX + Me.espaceentredeuxcell) - Me.espaceentredeuxcell, Me.nbrcell * (Me.cotecellY + Me.espaceentredeuxcell) - Me.espaceentredeuxcell)
					panelgrille.Size = size
					point = New System.Drawing.Point(Module1.screenadaptX(30), Module1.screenadaptY(20))
					panelgrille.Location = point
					panelgrille.BackColor = Color.Black
					panelgrille = Nothing
				Next

			Next

		End Sub

		Public Function cellule(ByVal x As Integer) As Integer
			Dim num As Integer = 0
			Dim num1 As Integer = Me.nbrcell - 1
			Dim num2 As Integer = 0
			Do
				Dim num3 As Integer = Me.nbrcell - 1
				Dim num4 As Integer = 0
				Do
					If (Me.grille(num2, num4).BackColor = Me.couleursparcelles(x)) Then
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
			Dim flag As Boolean = True
			If (Me.CheckBoxsupp.Checked) Then
				If (Me.nbrparcelles > 1) Then
					Dim num As Integer = Me.nbrparcelles - 1
					For i As Integer = 1 To num Step 1
						Dim flag1 As Boolean = Me.cellule(i) = 1
						Dim obj As Object = NewLateBinding.LateGet(sender, Nothing, "Backcolor", New Object(-1) {}, Nothing, Nothing, Nothing)
						If (obj IsNot Nothing) Then
							color1 = DirectCast(obj, System.Drawing.Color)
						Else
							color1 = color
						End If
						If (flag1 And (color1 = Me.couleursparcelles(i))) Then
							seaGreen = New Object() { False }
							NewLateBinding.LateSet(sender, Nothing, "Checked", seaGreen, Nothing, Nothing)
							MyProject.Forms.FormPasPas.Msgboxperso("Vous ne pouvez supprimer entièrement que la dernière parcelle partitionnée", "Ail! Plus z'un zeste!")
							flag = False
						End If
					Next

				End If
				If (flag AndAlso Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, Nothing, "Checked", New Object(-1) {}, Nothing, Nothing, Nothing), True, False)) Then
					Dim obj1 As Object = sender
					seaGreen = New Object() { "" }
					NewLateBinding.LateSet(obj1, Nothing, "Text", seaGreen, Nothing, Nothing)
					seaGreen = New Object() { False }
					NewLateBinding.LateSet(obj1, Nothing, "Checked", seaGreen, Nothing, Nothing)
					seaGreen = New Object() { System.Drawing.Color.SeaGreen }
					NewLateBinding.LateSet(obj1, Nothing, "BackColor", seaGreen, Nothing, Nothing)
					obj1 = Nothing
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
			If (Me.CheckBoxsupp.Checked) Then
				Me.Buttonpart.Enabled = False
				Dim num As Integer = Me.nbrcell - 1
				For i = 0 To num Step 1
					Dim num1 As Integer = Me.nbrcell - 1
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
				Me.Buttonpart.Enabled = True
				Dim num2 As Integer = Me.nbrcell - 1
				For i = 0 To num2 Step 1
					Dim num3 As Integer = Me.nbrcell - 1
					For j = 0 To num3 Step 1
						If (Me.grille(i, j).BackColor = Color.SeaGreen) Then
							Me.grille(i, j).Enabled = True
						Else
							Me.grille(i, j).Enabled = False
						End If
					Next

				Next

			End If
			If (Not Me.CheckBoxsupp.Checked And Me.nbrparcelles > 0) Then
				Me.compt = 0
				Dim num4 As Integer = Me.nbrparcelles
				i = 1
				Do
					If (Me.cellule(i) = 0) Then
						Me.Légendes0.RemoveAt(i - 1)
						Me.Légendes1.RemoveAt(i - 1)
						Me.compt = Me.compt + 1
					End If
					i = i + 1
				Loop While i <= num4
				Me.nbrparcelles = Me.nbrparcelles - Me.compt
			End If
			Me.PanelLégendes.Controls.Clear()
			Dim num5 As Integer = Me.nbrparcelles - 1
			For i = 0 To num5 Step 1
				Dim controls As Control.ControlCollection = Me.PanelLégendes.Controls
				controls.Add(Me.Légendes0(i))
				controls.Add(Me.Légendes1(i))
				controls = Nothing
			Next

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

		Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If (Me.TabControl.SelectedIndex <> 0 OrElse e.KeyCode <> Keys.[Return]) Then
				Return
			End If
			Me.Buttonpart.PerformClick()
		End Sub

		Private Sub Formgarden_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadgarden = False
		End Sub

		Private Sub Formgarden_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			Try
				If (Me.nbrphotobibliochargee > 0) Then
					Me.ecriture = New StreamWriter(Me.pathfichierphoto, False, Encoding.[Default])
					Dim num As Integer = Me.nbrphotobibliochargee * 3 - 1
					Dim num1 As Integer = 0
					Do
						Me.ecriture.WriteLine(Me.metadata(num1))
						num1 = num1 + 1
					Loop While num1 <= num
					Me.ecriture.Close()
				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				ProjectData.ClearProjectError()
			End Try
			Try
				Me.ecriture = New StreamWriter(Me.pathrecolte, False, Encoding.[Default])
				Dim count As Integer = Me.Recoltes.Count - 1
				Dim num2 As Integer = 0
				Do
					Me.ecriture.WriteLine(Me.Recoltes(num2))
					num2 = num2 + 1
				Loop While num2 <= count
				Me.ecriture.Close()
			Catch exception1 As System.Exception
				ProjectData.SetProjectError(exception1)
				ProjectData.ClearProjectError()
			End Try
			Try
				Me.ecriture = New StreamWriter(Me.pathmateriel, False, Encoding.[Default])
				Dim count1 As Integer = Me.Materiel.Count - 1
				Dim num3 As Integer = 0
				Do
					Me.ecriture.WriteLine(Me.Materiel(num3))
					num3 = num3 + 1
				Loop While num3 <= count1
				Me.ecriture.Close()
			Catch exception2 As System.Exception
				ProjectData.SetProjectError(exception2)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub Formgarden_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not MyProject.Forms.FormPasPas.activation) Then
				Me.ToolStripButton4.Enabled = False
			End If
			Me.pathmateriel = String.Concat(Application.StartupPath, "\Materiel.txt")
			Me.pathrecolte = String.Concat(Application.StartupPath, "\Recolte.txt")
			Me.pathdossierphoto = String.Concat(Application.StartupPath, "\Photos")
			Me.pathfichierphoto = String.Concat(Application.StartupPath, "\Photos.txt")
			If (Not File.Exists(Me.pathmateriel)) Then
				File.Create(Me.pathmateriel)
			End If
			If (Not File.Exists(Me.pathrecolte)) Then
				File.Create(Me.pathrecolte)
			End If
			If (Not File.Exists(Me.pathfichierphoto)) Then
				File.Create(Me.pathfichierphoto)
			End If
			If (Not Directory.Exists(Me.pathmateriel)) Then
				Directory.CreateDirectory(Me.pathdossierphoto)
			End If
			Me.firstload1 = True
			Me.firstload2 = True
			Dim panelgrille As Panel = Me.Panelgrille
			Dim str As String = String.Concat(Application.StartupPath, "\Pellecurseur.cur")
			panelgrille.Cursor = New System.Windows.Forms.Cursor(SVPLCApplication.FormMonJardin.LoadCursorFromFile(str))
			Me.nbrcell = 18
			Me.cotecellX = 30
			Me.cotecellY = 30
			Me.espaceentredeuxcell = -1
			ReDim Me.grille(Me.nbrcell - 1 + 1 - 1, Me.nbrcell - 1 + 1 - 1)
			Dim num As Integer = Me.nbrcell - 1
			Dim num1 As Integer = 0
			Do
				Dim num2 As Integer = Me.nbrcell - 1
				Dim num3 As Integer = 0
				Do
					Me.grille(num1, num3) = New CheckBox()
					Dim seaGreen As CheckBox = Me.grille(num1, num3)
					seaGreen.Appearance = Appearance.Button
					seaGreen.FlatStyle = FlatStyle.Flat
					seaGreen.BackColor = Color.SeaGreen
					seaGreen.FlatAppearance.CheckedBackColor = Color.SaddleBrown
					Dim size As System.Drawing.Size = New System.Drawing.Size(Me.cotecellX, Me.cotecellY)
					seaGreen.Size = size
					Dim point As System.Drawing.Point = New System.Drawing.Point(num1 * (Me.cotecellX + Me.espaceentredeuxcell), num3 * (Me.cotecellY + Me.espaceentredeuxcell))
					seaGreen.Location = point
					Dim formMonJardin As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.CheckStateChanged,  New EventHandler(AddressOf formMonJardin.CheckBox_CheckedChanged)
					Dim formMonJardin1 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.MouseDown,  New MouseEventHandler(AddressOf formMonJardin1.CheckBox_MouseDown)
					Dim formMonJardin2 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.Click,  New EventHandler(AddressOf formMonJardin2.CheckBox_Click)
					Dim formMonJardin3 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.MouseUp,  New MouseEventHandler(AddressOf formMonJardin3.CheckBox_MouseUp)
					Dim formMonJardin4 As SVPLCApplication.FormMonJardin = Me
					AddHandler seaGreen.MouseMove,  New MouseEventHandler(AddressOf formMonJardin4.CheckBox_MouseMove)
					seaGreen = Nothing
					Me.Lgrille = Me.nbrcell * (Me.cotecellX + Me.espaceentredeuxcell) - Me.espaceentredeuxcell
					Me.Hgrille = Me.nbrcell * (Me.cotecellY + Me.espaceentredeuxcell) - Me.espaceentredeuxcell
					Dim black As Panel = Me.Panelgrille
					black.Controls.Add(Me.grille(num1, num3))
					size = New System.Drawing.Size(Me.nbrcell * (Me.cotecellX + Me.espaceentredeuxcell) - Me.espaceentredeuxcell, Me.nbrcell * (Me.cotecellY + Me.espaceentredeuxcell) - Me.espaceentredeuxcell)
					black.Size = size
					point = New System.Drawing.Point(Module1.screenadaptX(30), Module1.screenadaptY(20))
					black.Location = point
					black.BackColor = Color.Black
					black = Nothing
					num3 = num3 + 1
				Loop While num3 <= num2
				num1 = num1 + 1
			Loop While num1 <= num
			Me.nbrmaxparcelles = 18
			ReDim Me.couleursparcelles(Me.nbrmaxparcelles + 1 - 1)
			Me.couleursparcelles(1) = Color.Green
			Me.couleursparcelles(2) = Color.Yellow
			Me.couleursparcelles(3) = Color.Blue
			Me.couleursparcelles(4) = Color.Red
			Me.couleursparcelles(5) = Color.Maroon
			Me.couleursparcelles(6) = Color.Crimson
			Me.couleursparcelles(7) = Color.Violet
			Me.couleursparcelles(8) = Color.SteelBlue
			Me.couleursparcelles(9) = Color.GreenYellow
			Me.couleursparcelles(10) = Color.Chartreuse
			Me.couleursparcelles(11) = Color.Thistle
			Me.couleursparcelles(12) = Color.Chocolate
			Me.couleursparcelles(13) = Color.YellowGreen
			Me.couleursparcelles(14) = Color.Gainsboro
			Me.couleursparcelles(15) = Color.Goldenrod
			Me.couleursparcelles(16) = Color.Coral
			Me.couleursparcelles(17) = Color.DarkKhaki
			Me.couleursparcelles(18) = Color.IndianRed
			Me.pathtempdossierjardin = Directory.GetFiles(Module1.PATHS(16))
			Dim length As Integer = CInt(Me.pathtempdossierjardin.Length) - 1
			For i As Integer = 0 To length Step 1
				Me.Pathjardin.Add(Me.pathtempdossierjardin(i))
				Me.namebmp = Path.GetFileName(Me.pathtempdossierjardin(i))
				Me.ListView1.Items.Add(Me.namebmp)
			Next

		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMonJardin))
			Me.TabControl = New System.Windows.Forms.TabControl()
			Me.Schema = New System.Windows.Forms.TabPage()
			Me.CheckBoxsupp = New System.Windows.Forms.CheckBox()
			Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
			Me.Buttonpart = New System.Windows.Forms.ToolStripButton()
			Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.Buttonreset = New System.Windows.Forms.ToolStripButton()
			Me.ToolStripSeparator1 = New ToolStripSeparator()
			Me.Buttonsave = New System.Windows.Forms.ToolStripButton()
			Me.Buttonsupp = New System.Windows.Forms.ToolStripButton()
			Me.ListView1 = New System.Windows.Forms.ListView()
			Me.ColumnHeader27 = New ColumnHeader()
			Me.ImageList2 = New ImageList(Me.components)
			Me.Panel1 = New System.Windows.Forms.Panel()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.PanelLégendes = New System.Windows.Forms.Panel()
			Me.Panelgrille = New System.Windows.Forms.Panel()
			Me.RB = New System.Windows.Forms.TabPage()
			Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.GroupBoxRecoltes = New System.Windows.Forms.GroupBox()
			Me.ListViewRecoltes = New System.Windows.Forms.ListView()
			Me.ColumnHeader1 = New ColumnHeader()
			Me.ColumnHeader2 = New ColumnHeader()
			Me.ColumnHeader3 = New ColumnHeader()
			Me.ColumnHeader4 = New ColumnHeader()
			Me.ColumnHeader5 = New ColumnHeader()
			Me.ColumnHeader6 = New ColumnHeader()
			Me.ColumnHeader7 = New ColumnHeader()
			Me.ColumnHeader8 = New ColumnHeader()
			Me.ColumnHeader9 = New ColumnHeader()
			Me.ColumnHeader10 = New ColumnHeader()
			Me.ColumnHeader11 = New ColumnHeader()
			Me.ColumnHeader12 = New ColumnHeader()
			Me.ColumnHeader13 = New ColumnHeader()
			Me.ColumnHeader14 = New ColumnHeader()
			Me.GroupBoxMateriel = New System.Windows.Forms.GroupBox()
			Me.ListViewMateriel = New System.Windows.Forms.ListView()
			Me.ColumnHeader15 = New ColumnHeader()
			Me.ColumnHeader16 = New ColumnHeader()
			Me.ColumnHeader17 = New ColumnHeader()
			Me.ColumnHeader18 = New ColumnHeader()
			Me.ColumnHeader19 = New ColumnHeader()
			Me.ColumnHeader20 = New ColumnHeader()
			Me.ColumnHeader25 = New ColumnHeader()
			Me.ColumnHeader26 = New ColumnHeader()
			Me.Photos = New System.Windows.Forms.TabPage()
			Me.ListView = New System.Windows.Forms.ListView()
			Me.ColumnHeader21 = New ColumnHeader()
			Me.ColumnHeader22 = New ColumnHeader()
			Me.ColumnHeader23 = New ColumnHeader()
			Me.ColumnHeader24 = New ColumnHeader()
			Me.ImageList1 = New ImageList(Me.components)
			Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
			Me.btnaddtof = New System.Windows.Forms.ToolStripButton()
			Me.btnsupptof = New System.Windows.Forms.ToolStripButton()
			Me.btnmodiftof = New System.Windows.Forms.ToolStripButton()
			Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
			Me.ToolStripStatusLabel1 = New ToolStripStatusLabel()
			Me.ToolStripProgressBar1 = New ToolStripProgressBar()
			Me.lblCommentaires = New System.Windows.Forms.Label()
			Me.lblDate = New System.Windows.Forms.Label()
			Me.lblTitre = New System.Windows.Forms.Label()
			Me.Photo = New System.Windows.Forms.PictureBox()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.OpenFileDialogphoto = New OpenFileDialog()
			Me.BackgroundWorker1 = New BackgroundWorker()
			Me.BackgroundWorker2 = New BackgroundWorker()
			Me.TabControl.SuspendLayout()
			Me.Schema.SuspendLayout()
			Me.ToolStrip3.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.RB.SuspendLayout()
			Me.ToolStrip1.SuspendLayout()
			DirectCast(Me.SplitContainer1, ISupportInitialize).BeginInit()
			Me.SplitContainer1.Panel1.SuspendLayout()
			Me.SplitContainer1.Panel2.SuspendLayout()
			Me.SplitContainer1.SuspendLayout()
			Me.GroupBoxRecoltes.SuspendLayout()
			Me.GroupBoxMateriel.SuspendLayout()
			Me.Photos.SuspendLayout()
			Me.ToolStrip2.SuspendLayout()
			Me.StatusStrip1.SuspendLayout()
			DirectCast(Me.Photo, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.TabControl.Controls.Add(Me.Schema)
			Me.TabControl.Controls.Add(Me.RB)
			Me.TabControl.Controls.Add(Me.Photos)
			Me.TabControl.Dock = DockStyle.Fill
			Me.TabControl.DrawMode = TabDrawMode.OwnerDrawFixed
			Me.TabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim tabControl As System.Windows.Forms.TabControl = Me.TabControl
			Dim size As System.Drawing.Size = New System.Drawing.Size(160, 25)
			tabControl.ItemSize = size
			Dim tabControl1 As System.Windows.Forms.TabControl = Me.TabControl
			Dim point As System.Drawing.Point = New System.Drawing.Point(0, 0)
			tabControl1.Location = point
			Me.TabControl.Name = "TabControl"
			Me.TabControl.SelectedIndex = 0
			Dim tabControl2 As System.Windows.Forms.TabControl = Me.TabControl
			size = New System.Drawing.Size(1094, 672)
			tabControl2.Size = size
			Me.TabControl.SizeMode = TabSizeMode.Fixed
			Me.TabControl.TabIndex = 0
			Me.Schema.BackColor = Color.Peru
			Me.Schema.Controls.Add(Me.CheckBoxsupp)
			Me.Schema.Controls.Add(Me.ToolStrip3)
			Me.Schema.Controls.Add(Me.ListView1)
			Me.Schema.Controls.Add(Me.Panel1)
			Me.Schema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Schema.ImageIndex = 0
			Dim schema As System.Windows.Forms.TabPage = Me.Schema
			point = New System.Drawing.Point(4, 29)
			schema.Location = point
			Me.Schema.Name = "Schema"
			Dim tabPage As System.Windows.Forms.TabPage = Me.Schema
			Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(3)
			tabPage.Padding = padding
			Dim schema1 As System.Windows.Forms.TabPage = Me.Schema
			size = New System.Drawing.Size(1086, 639)
			schema1.Size = size
			Me.Schema.TabIndex = 0
			Me.Schema.Text = "Schéma de mon jardin"
			Me.CheckBoxsupp.Appearance = Appearance.Button
			Me.CheckBoxsupp.BackColor = Color.Firebrick
			Me.CheckBoxsupp.FlatStyle = FlatStyle.Popup
			Dim checkBoxsupp As System.Windows.Forms.CheckBox = Me.CheckBoxsupp
			point = New System.Drawing.Point(108, 11)
			checkBoxsupp.Location = point
			Me.CheckBoxsupp.Name = "CheckBoxsupp"
			Dim checkBox As System.Windows.Forms.CheckBox = Me.CheckBoxsupp
			size = New System.Drawing.Size(111, 25)
			checkBox.Size = size
			Me.CheckBoxsupp.TabIndex = 2
			Me.CheckBoxsupp.Text = "Supprimer un terrain"
			Me.CheckBoxsupp.UseVisualStyleBackColor = False
			Me.ToolStrip3.Anchor = AnchorStyles.Left
			Me.ToolStrip3.AutoSize = False
			Me.ToolStrip3.BackColor = Color.DarkOliveGreen
			Me.ToolStrip3.Dock = DockStyle.None
			Dim items As ToolStripItemCollection = Me.ToolStrip3.Items
			Dim buttonpart() As ToolStripItem = { Me.Buttonpart, Me.ToolStripLabel1, Me.Buttonreset, Me.ToolStripSeparator1, Me.Buttonsave, Me.Buttonsupp }
			items.AddRange(buttonpart)
			Dim toolStrip3 As System.Windows.Forms.ToolStrip = Me.ToolStrip3
			point = New System.Drawing.Point(3, 8)
			toolStrip3.Location = point
			Me.ToolStrip3.Name = "ToolStrip3"
			Dim toolStrip As System.Windows.Forms.ToolStrip = Me.ToolStrip3
			size = New System.Drawing.Size(1078, 30)
			toolStrip.Size = size
			Me.ToolStrip3.TabIndex = 6
			Me.ToolStrip3.Text = "ToolStrip3"
			Me.Buttonpart.BackColor = Color.ForestGreen
			Me.Buttonpart.Image = Resources.ajadd
			Me.Buttonpart.ImageTransparentColor = Color.Magenta
			Dim toolStripButton As System.Windows.Forms.ToolStripButton = Me.Buttonpart
			padding = New System.Windows.Forms.Padding(3)
			toolStripButton.Margin = padding
			Me.Buttonpart.Name = "Buttonpart"
			Dim buttonpart1 As System.Windows.Forms.ToolStripButton = Me.Buttonpart
			size = New System.Drawing.Size(89, 24)
			buttonpart1.Size = size
			Me.Buttonpart.Text = "Partitionner"
			Me.ToolStripLabel1.AutoSize = False
			Dim toolStripLabel1 As System.Windows.Forms.ToolStripLabel = Me.ToolStripLabel1
			padding = New System.Windows.Forms.Padding(1, 10, 1, 2)
			toolStripLabel1.Margin = padding
			Me.ToolStripLabel1.Name = "ToolStripLabel1"
			Dim toolStripLabel As System.Windows.Forms.ToolStripLabel = Me.ToolStripLabel1
			size = New System.Drawing.Size(111, 2)
			toolStripLabel.Size = size
			Me.ToolStripLabel1.Text = "ToolStripLabel1"
			Me.Buttonreset.BackColor = Color.Gold
			Me.Buttonreset.Image = Resources.reset
			Me.Buttonreset.ImageTransparentColor = Color.Magenta
			Dim buttonreset As System.Windows.Forms.ToolStripButton = Me.Buttonreset
			padding = New System.Windows.Forms.Padding(3)
			buttonreset.Margin = padding
			Me.Buttonreset.Name = "Buttonreset"
			Dim buttonreset1 As System.Windows.Forms.ToolStripButton = Me.Buttonreset
			size = New System.Drawing.Size(104, 24)
			buttonreset1.Size = size
			Me.Buttonreset.Text = "Recommencer"
			Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
			Dim toolStripSeparator1 As ToolStripSeparator = Me.ToolStripSeparator1
			size = New System.Drawing.Size(6, 30)
			toolStripSeparator1.Size = size
			Me.Buttonsave.BackColor = Color.Gray
			Me.Buttonsave.Image = Resources.disquette1
			Me.Buttonsave.ImageTransparentColor = Color.Magenta
			Dim buttonsave As System.Windows.Forms.ToolStripButton = Me.Buttonsave
			padding = New System.Windows.Forms.Padding(3)
			buttonsave.Margin = padding
			Me.Buttonsave.Name = "Buttonsave"
			Dim buttonsave1 As System.Windows.Forms.ToolStripButton = Me.Buttonsave
			size = New System.Drawing.Size(92, 24)
			buttonsave1.Size = size
			Me.Buttonsave.Text = "Sauvegarder"
			Me.Buttonsupp.BackColor = Color.DarkRed
			Me.Buttonsupp.Image = Resources.suppdel
			Me.Buttonsupp.ImageTransparentColor = Color.Magenta
			Dim buttonsupp As System.Windows.Forms.ToolStripButton = Me.Buttonsupp
			padding = New System.Windows.Forms.Padding(3)
			buttonsupp.Margin = padding
			Me.Buttonsupp.Name = "Buttonsupp"
			Dim buttonsupp1 As System.Windows.Forms.ToolStripButton = Me.Buttonsupp
			size = New System.Drawing.Size(157, 24)
			buttonsupp1.Size = size
			Me.Buttonsupp.Text = "Supprimer la sauvegarde"
			Me.ListView1.BackColor = Color.Gray
			Dim columns As System.Windows.Forms.ListView.ColumnHeaderCollection = Me.ListView1.Columns
			Dim columnHeader27() As ColumnHeader = { Me.ColumnHeader27 }
			columns.AddRange(columnHeader27)
			Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
			Dim listView1 As System.Windows.Forms.ListView = Me.ListView1
			point = New System.Drawing.Point(887, 56)
			listView1.Location = point
			Me.ListView1.Name = "ListView1"
			Me.ListView1.Scrollable = False
			Dim listView As System.Windows.Forms.ListView = Me.ListView1
			size = New System.Drawing.Size(176, 577)
			listView.Size = size
			Me.ListView1.SmallImageList = Me.ImageList2
			Me.ListView1.TabIndex = 4
			Me.ListView1.UseCompatibleStateImageBehavior = False
			Me.ListView1.View = View.Details
			Me.ColumnHeader27.Text = "Date de la sauvegarde"
			Me.ColumnHeader27.Width = 174
			Me.ImageList2.ColorDepth = ColorDepth.Depth8Bit
			Dim imageList2 As ImageList = Me.ImageList2
			size = New System.Drawing.Size(1, 23)
			imageList2.ImageSize = size
			Me.ImageList2.TransparentColor = Color.Transparent
			Me.Panel1.BackColor = Color.Silver
			Me.Panel1.BorderStyle = BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.Label2)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Controls.Add(Me.PanelLégendes)
			Me.Panel1.Controls.Add(Me.Panelgrille)
			Dim panel1 As System.Windows.Forms.Panel = Me.Panel1
			point = New System.Drawing.Point(8, 55)
			panel1.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel As System.Windows.Forms.Panel = Me.Panel1
			size = New System.Drawing.Size(860, 577)
			panel.Size = size
			Me.Panel1.TabIndex = 0
			Me.Label4.AutoSize = True
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(646, 538)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(107, 13)
			label.Size = size
			Me.Label4.TabIndex = 5
			Me.Label4.Text = "Cliquez pour changer"
			Me.Label3.AutoSize = True
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(646, 507)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(107, 13)
			label31.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "Cliquez pour changer"
			Me.Label2.AutoSize = True
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(595, 538)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(48, 13)
			label21.Size = size
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "Echelle :"
			Me.Label1.AutoSize = True
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(595, 507)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label11 As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(28, 13)
			label11.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Titre"
			Me.PanelLégendes.BackColor = Color.Transparent
			Dim panelLégendes As System.Windows.Forms.Panel = Me.PanelLégendes
			point = New System.Drawing.Point(598, 20)
			panelLégendes.Location = point
			Me.PanelLégendes.Name = "PanelLégendes"
			Dim panelLégendes1 As System.Windows.Forms.Panel = Me.PanelLégendes
			size = New System.Drawing.Size(246, 471)
			panelLégendes1.Size = size
			Me.PanelLégendes.TabIndex = 1
			Dim panelgrille As System.Windows.Forms.Panel = Me.Panelgrille
			point = New System.Drawing.Point(30, 20)
			panelgrille.Location = point
			Me.Panelgrille.Name = "Panelgrille"
			Dim panelgrille1 As System.Windows.Forms.Panel = Me.Panelgrille
			size = New System.Drawing.Size(540, 540)
			panelgrille1.Size = size
			Me.Panelgrille.TabIndex = 0
			Me.RB.BackColor = Color.Tan
			Me.RB.Controls.Add(Me.ToolStrip1)
			Me.RB.Controls.Add(Me.SplitContainer1)
			Me.RB.ImageIndex = 1
			Dim rB As System.Windows.Forms.TabPage = Me.RB
			point = New System.Drawing.Point(4, 29)
			rB.Location = point
			Dim rB1 As System.Windows.Forms.TabPage = Me.RB
			padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
			rB1.Margin = padding
			Me.RB.Name = "RB"
			Dim tabPage1 As System.Windows.Forms.TabPage = Me.RB
			padding = New System.Windows.Forms.Padding(3)
			tabPage1.Padding = padding
			Dim rB2 As System.Windows.Forms.TabPage = Me.RB
			size = New System.Drawing.Size(1086, 639)
			rB2.Size = size
			Me.RB.TabIndex = 1
			Me.RB.Text = "Récoltes et Budgets"
			Me.ToolStrip1.AutoSize = False
			Me.ToolStrip1.BackColor = Color.FromArgb(128, 64, 0)
			Me.ToolStrip1.Dock = DockStyle.None
			Dim toolStripItemCollections As ToolStripItemCollection = Me.ToolStrip1.Items
			buttonpart = New ToolStripItem() { Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton1, Me.ToolStripButton5, Me.ToolStripButton4 }
			toolStripItemCollections.AddRange(buttonpart)
			Dim toolStrip1 As System.Windows.Forms.ToolStrip = Me.ToolStrip1
			point = New System.Drawing.Point(3, 8)
			toolStrip1.Location = point
			Me.ToolStrip1.Name = "ToolStrip1"
			Dim toolStrip11 As System.Windows.Forms.ToolStrip = Me.ToolStrip1
			size = New System.Drawing.Size(1078, 30)
			toolStrip11.Size = size
			Me.ToolStrip1.TabIndex = 6
			Me.ToolStrip1.Text = "ToolStrip1"
			Me.ToolStripButton3.BackColor = Color.FromArgb(0, 192, 0)
			Me.ToolStripButton3.Image = Resources.ajadd
			Me.ToolStripButton3.ImageTransparentColor = Color.Magenta
			Dim toolStripButton3 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton3
			padding = New System.Windows.Forms.Padding(3)
			toolStripButton3.Margin = padding
			Me.ToolStripButton3.Name = "ToolStripButton3"
			Dim toolStripButton31 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton3
			size = New System.Drawing.Size(128, 24)
			toolStripButton31.Size = size
			Me.ToolStripButton3.Text = "Ajouter une récolte"
			Me.ToolStripButton3.TextAlign = ContentAlignment.MiddleLeft
			Me.ToolStripButton2.BackColor = Color.Green
			Me.ToolStripButton2.Image = Resources.ajadd
			Me.ToolStripButton2.ImageTransparentColor = Color.Magenta
			Dim toolStripButton2 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton2
			padding = New System.Windows.Forms.Padding(3)
			toolStripButton2.Margin = padding
			Me.ToolStripButton2.Name = "ToolStripButton2"
			Dim toolStripButton21 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton2
			size = New System.Drawing.Size(129, 24)
			toolStripButton21.Size = size
			Me.ToolStripButton2.Text = "Ajouter un matériel"
			Me.ToolStripButton1.BackColor = Color.DarkRed
			Me.ToolStripButton1.Image = Resources.suppdel
			Me.ToolStripButton1.ImageTransparentColor = Color.Magenta
			Dim toolStripButton1 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton1
			padding = New System.Windows.Forms.Padding(3)
			toolStripButton1.Margin = padding
			Me.ToolStripButton1.Name = "ToolStripButton1"
			Dim toolStripButton11 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton1
			size = New System.Drawing.Size(82, 24)
			toolStripButton11.Size = size
			Me.ToolStripButton1.Text = "Supprimer"
			Me.ToolStripButton5.BackColor = Color.OrangeRed
			Me.ToolStripButton5.Image = Resources.modify
			Me.ToolStripButton5.ImageTransparentColor = Color.Magenta
			Dim toolStripButton5 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton5
			padding = New System.Windows.Forms.Padding(3)
			toolStripButton5.Margin = padding
			Me.ToolStripButton5.Name = "ToolStripButton5"
			Dim toolStripButton51 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton5
			size = New System.Drawing.Size(72, 24)
			toolStripButton51.Size = size
			Me.ToolStripButton5.Text = "Modifier"
			Me.ToolStripButton4.BackColor = Color.Gold
			Me.ToolStripButton4.Image = Resources.euro
			Me.ToolStripButton4.ImageTransparentColor = Color.Magenta
			Dim toolStripButton4 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton4
			padding = New System.Windows.Forms.Padding(3)
			toolStripButton4.Margin = padding
			Me.ToolStripButton4.Name = "ToolStripButton4"
			Dim toolStripButton41 As System.Windows.Forms.ToolStripButton = Me.ToolStripButton4
			size = New System.Drawing.Size(104, 24)
			toolStripButton41.Size = size
			Me.ToolStripButton4.Text = "Bilan Financier"
			Dim splitContainer1 As System.Windows.Forms.SplitContainer = Me.SplitContainer1
			point = New System.Drawing.Point(3, 50)
			splitContainer1.Location = point
			Me.SplitContainer1.Name = "SplitContainer1"
			Me.SplitContainer1.Orientation = Orientation.Horizontal
			Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBoxRecoltes)
			Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBoxMateriel)
			Dim splitContainer As System.Windows.Forms.SplitContainer = Me.SplitContainer1
			size = New System.Drawing.Size(1078, 580)
			splitContainer.Size = size
			Me.SplitContainer1.SplitterDistance = 307
			Me.SplitContainer1.SplitterWidth = 20
			Me.SplitContainer1.TabIndex = 5
			Me.GroupBoxRecoltes.Controls.Add(Me.ListViewRecoltes)
			Me.GroupBoxRecoltes.Dock = DockStyle.Fill
			Dim groupBoxRecoltes As System.Windows.Forms.GroupBox = Me.GroupBoxRecoltes
			point = New System.Drawing.Point(0, 0)
			groupBoxRecoltes.Location = point
			Me.GroupBoxRecoltes.Name = "GroupBoxRecoltes"
			Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBoxRecoltes
			size = New System.Drawing.Size(1078, 307)
			groupBox.Size = size
			Me.GroupBoxRecoltes.TabIndex = 0
			Me.GroupBoxRecoltes.TabStop = False
			Me.GroupBoxRecoltes.Text = "Récoltes"
			Me.ListViewRecoltes.BackgroundImage = Resources.fond
			Me.ListViewRecoltes.BackgroundImageTiled = True
			Dim columnHeaderCollections As System.Windows.Forms.ListView.ColumnHeaderCollection = Me.ListViewRecoltes.Columns
			columnHeader27 = New ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14 }
			columnHeaderCollections.AddRange(columnHeader27)
			Me.ListViewRecoltes.Dock = DockStyle.Fill
			Me.ListViewRecoltes.FullRowSelect = True
			Me.ListViewRecoltes.HeaderStyle = ColumnHeaderStyle.Nonclickable
			Dim listViewRecoltes As System.Windows.Forms.ListView = Me.ListViewRecoltes
			point = New System.Drawing.Point(3, 16)
			listViewRecoltes.Location = point
			Me.ListViewRecoltes.MultiSelect = False
			Me.ListViewRecoltes.Name = "ListViewRecoltes"
			Dim listViewRecoltes1 As System.Windows.Forms.ListView = Me.ListViewRecoltes
			size = New System.Drawing.Size(1072, 288)
			listViewRecoltes1.Size = size
			Me.ListViewRecoltes.SmallImageList = Me.ImageList2
			Me.ListViewRecoltes.TabIndex = 0
			Me.ListViewRecoltes.UseCompatibleStateImageBehavior = False
			Me.ListViewRecoltes.View = View.Details
			Me.ColumnHeader1.Text = "Nom générique"
			Me.ColumnHeader1.Width = 89
			Me.ColumnHeader2.Text = "Variété"
			Me.ColumnHeader2.Width = 56
			Me.ColumnHeader3.Text = "Date de plantation"
			Me.ColumnHeader3.Width = 104
			Me.ColumnHeader4.Text = "Quantité plantée"
			Me.ColumnHeader4.Width = 95
			Me.ColumnHeader5.Text = "Date de la récolte"
			Me.ColumnHeader5.Width = 101
			Me.ColumnHeader6.Text = "Quantité récoltée"
			Me.ColumnHeader6.Width = 94
			Me.ColumnHeader7.Text = "Provenance"
			Me.ColumnHeader7.Width = 76
			Me.ColumnHeader8.Text = "Prix unitaire d'achat"
			Me.ColumnHeader8.Width = 108
			Me.ColumnHeader9.Text = "Quantité vendue"
			Me.ColumnHeader9.Width = 97
			Me.ColumnHeader10.Text = "Prix unitaire de vente"
			Me.ColumnHeader10.Width = 112
			Me.ColumnHeader11.Text = "Quantité consommée"
			Me.ColumnHeader11.Width = 113
			Me.ColumnHeader12.Text = "Prix du marché"
			Me.ColumnHeader12.Width = 85
			Me.ColumnHeader13.Text = "Economie, bénéfice"
			Me.ColumnHeader13.Width = 112
			Me.ColumnHeader14.Text = "Commentaires"
			Me.ColumnHeader14.Width = 82
			Me.GroupBoxMateriel.Controls.Add(Me.ListViewMateriel)
			Me.GroupBoxMateriel.Dock = DockStyle.Fill
			Dim groupBoxMateriel As System.Windows.Forms.GroupBox = Me.GroupBoxMateriel
			point = New System.Drawing.Point(0, 0)
			groupBoxMateriel.Location = point
			Me.GroupBoxMateriel.Name = "GroupBoxMateriel"
			Dim groupBoxMateriel1 As System.Windows.Forms.GroupBox = Me.GroupBoxMateriel
			size = New System.Drawing.Size(1078, 253)
			groupBoxMateriel1.Size = size
			Me.GroupBoxMateriel.TabIndex = 1
			Me.GroupBoxMateriel.TabStop = False
			Me.GroupBoxMateriel.Text = "Materiel"
			Me.ListViewMateriel.BackgroundImage = Resources.fond
			Me.ListViewMateriel.BackgroundImageTiled = True
			Dim columns1 As System.Windows.Forms.ListView.ColumnHeaderCollection = Me.ListViewMateriel.Columns
			columnHeader27 = New ColumnHeader() { Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader25, Me.ColumnHeader26 }
			columns1.AddRange(columnHeader27)
			Me.ListViewMateriel.Dock = DockStyle.Fill
			Me.ListViewMateriel.FullRowSelect = True
			Me.ListViewMateriel.HeaderStyle = ColumnHeaderStyle.Nonclickable
			Dim listViewMateriel As System.Windows.Forms.ListView = Me.ListViewMateriel
			point = New System.Drawing.Point(3, 16)
			listViewMateriel.Location = point
			Me.ListViewMateriel.Name = "ListViewMateriel"
			Dim listViewMateriel1 As System.Windows.Forms.ListView = Me.ListViewMateriel
			size = New System.Drawing.Size(1072, 234)
			listViewMateriel1.Size = size
			Me.ListViewMateriel.SmallImageList = Me.ImageList2
			Me.ListViewMateriel.TabIndex = 0
			Me.ListViewMateriel.UseCompatibleStateImageBehavior = False
			Me.ListViewMateriel.View = View.Details
			Me.ColumnHeader15.Text = "Nom"
			Me.ColumnHeader16.Text = "Caractéristiques"
			Me.ColumnHeader16.Width = 240
			Me.ColumnHeader17.Text = "Quantité"
			Me.ColumnHeader18.Text = "Prix unitaire"
			Me.ColumnHeader18.Width = 71
			Me.ColumnHeader19.Text = "Provenance"
			Me.ColumnHeader19.Width = 220
			Me.ColumnHeader20.Text = "Date de l'achat"
			Me.ColumnHeader20.Width = 92
			Me.ColumnHeader25.Text = "Coût total"
			Me.ColumnHeader25.Width = 67
			Me.ColumnHeader26.Text = "Commentaires"
			Me.ColumnHeader26.Width = 259
			Me.Photos.BackColor = Color.DarkSeaGreen
			Me.Photos.BackgroundImageLayout = ImageLayout.None
			Me.Photos.Controls.Add(Me.ListView)
			Me.Photos.Controls.Add(Me.ToolStrip2)
			Me.Photos.Controls.Add(Me.StatusStrip1)
			Me.Photos.Controls.Add(Me.lblCommentaires)
			Me.Photos.Controls.Add(Me.lblDate)
			Me.Photos.Controls.Add(Me.lblTitre)
			Me.Photos.Controls.Add(Me.Photo)
			Me.Photos.Controls.Add(Me.PictureBox1)
			Me.Photos.ForeColor = SystemColors.ActiveCaptionText
			Me.Photos.ImageIndex = 2
			Dim photos As System.Windows.Forms.TabPage = Me.Photos
			point = New System.Drawing.Point(4, 29)
			photos.Location = point
			Me.Photos.Name = "Photos"
			Dim photos1 As System.Windows.Forms.TabPage = Me.Photos
			padding = New System.Windows.Forms.Padding(3)
			photos1.Padding = padding
			Dim photos2 As System.Windows.Forms.TabPage = Me.Photos
			size = New System.Drawing.Size(1086, 639)
			photos2.Size = size
			Me.Photos.TabIndex = 2
			Me.Photos.Text = "Photos"
			Me.ListView.BackColor = Color.Gray
			Dim columnHeaderCollections1 As System.Windows.Forms.ListView.ColumnHeaderCollection = Me.ListView.Columns
			columnHeader27 = New ColumnHeader() { Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24 }
			columnHeaderCollections1.AddRange(columnHeader27)
			Me.ListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.ListView.FullRowSelect = True
			Me.ListView.HeaderStyle = ColumnHeaderStyle.Nonclickable
			Me.ListView.LabelWrap = False
			Dim listView2 As System.Windows.Forms.ListView = Me.ListView
			point = New System.Drawing.Point(18, 66)
			listView2.Location = point
			Me.ListView.Name = "ListView"
			Me.ListView.Scrollable = False
			Dim listView3 As System.Windows.Forms.ListView = Me.ListView
			size = New System.Drawing.Size(303, 363)
			listView3.Size = size
			Me.ListView.SmallImageList = Me.ImageList1
			Me.ListView.TabIndex = 0
			Dim listView4 As System.Windows.Forms.ListView = Me.ListView
			size = New System.Drawing.Size(400, 48)
			listView4.TileSize = size
			Me.ListView.UseCompatibleStateImageBehavior = False
			Me.ListView.View = View.Details
			Me.ColumnHeader21.Text = "Aperçu"
			Me.ColumnHeader21.Width = 66
			Me.ColumnHeader22.Text = "Titre"
			Me.ColumnHeader23.Text = "Commentaires"
			Me.ColumnHeader23.Width = 102
			Me.ColumnHeader24.Text = "Date"
			Me.ColumnHeader24.Width = 71
			Me.ImageList1.ColorDepth = ColorDepth.Depth8Bit
			Dim imageList1 As ImageList = Me.ImageList1
			size = New System.Drawing.Size(60, 40)
			imageList1.ImageSize = size
			Me.ImageList1.TransparentColor = Color.Transparent
			Me.ToolStrip2.AutoSize = False
			Me.ToolStrip2.BackColor = SystemColors.ActiveCaption
			Me.ToolStrip2.Dock = DockStyle.None
			Me.ToolStrip2.GripStyle = ToolStripGripStyle.Hidden
			Dim items1 As ToolStripItemCollection = Me.ToolStrip2.Items
			buttonpart = New ToolStripItem() { Me.btnaddtof, Me.btnsupptof, Me.btnmodiftof }
			items1.AddRange(buttonpart)
			Dim toolStrip2 As System.Windows.Forms.ToolStrip = Me.ToolStrip2
			point = New System.Drawing.Point(18, 35)
			toolStrip2.Location = point
			Me.ToolStrip2.Name = "ToolStrip2"
			Dim toolStrip21 As System.Windows.Forms.ToolStrip = Me.ToolStrip2
			size = New System.Drawing.Size(303, 30)
			toolStrip21.Size = size
			Me.ToolStrip2.TabIndex = 5
			Me.ToolStrip2.Text = "ToolStrip2"
			Me.btnaddtof.AutoSize = False
			Me.btnaddtof.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnaddtof.Image = Resources.ajadd
			Me.btnaddtof.ImageTransparentColor = Color.Magenta
			Me.btnaddtof.Name = "btnaddtof"
			Dim toolStripButton6 As System.Windows.Forms.ToolStripButton = Me.btnaddtof
			size = New System.Drawing.Size(60, 27)
			toolStripButton6.Size = size
			Me.btnsupptof.AutoSize = False
			Me.btnsupptof.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnsupptof.Image = Resources.suppdel
			Me.btnsupptof.ImageTransparentColor = Color.Magenta
			Me.btnsupptof.Name = "btnsupptof"
			Dim toolStripButton7 As System.Windows.Forms.ToolStripButton = Me.btnsupptof
			size = New System.Drawing.Size(60, 27)
			toolStripButton7.Size = size
			Me.btnsupptof.Text = "ToolStripButton7"
			Me.btnmodiftof.AutoSize = False
			Me.btnmodiftof.DisplayStyle = ToolStripItemDisplayStyle.Image
			Me.btnmodiftof.Image = Resources.modify
			Me.btnmodiftof.ImageTransparentColor = Color.Magenta
			Me.btnmodiftof.Name = "btnmodiftof"
			Dim toolStripButton8 As System.Windows.Forms.ToolStripButton = Me.btnmodiftof
			size = New System.Drawing.Size(60, 27)
			toolStripButton8.Size = size
			Me.btnmodiftof.Text = "ToolStripButton8"
			Me.StatusStrip1.AutoSize = False
			Me.StatusStrip1.BackColor = Color.Green
			Dim toolStripItemCollections1 As ToolStripItemCollection = Me.StatusStrip1.Items
			buttonpart = New ToolStripItem() { Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1 }
			toolStripItemCollections1.AddRange(buttonpart)
			Dim statusStrip1 As System.Windows.Forms.StatusStrip = Me.StatusStrip1
			point = New System.Drawing.Point(3, 646)
			statusStrip1.Location = point
			Me.StatusStrip1.Name = "StatusStrip1"
			Dim statusStrip As System.Windows.Forms.StatusStrip = Me.StatusStrip1
			size = New System.Drawing.Size(1078, 30)
			statusStrip.Size = size
			Me.StatusStrip1.TabIndex = 4
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.StatusStrip1.Visible = False
			Me.ToolStripStatusLabel1.AutoSize = False
			Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
			Dim toolStripStatusLabel1 As ToolStripStatusLabel = Me.ToolStripStatusLabel1
			size = New System.Drawing.Size(300, 25)
			toolStripStatusLabel1.Size = size
			Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
			Me.ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
			Me.ToolStripProgressBar1.Alignment = ToolStripItemAlignment.Right
			Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
			Dim toolStripProgressBar1 As ToolStripProgressBar = Me.ToolStripProgressBar1
			size = New System.Drawing.Size(750, 24)
			toolStripProgressBar1.Size = size
			Me.ToolStripProgressBar1.Style = ProgressBarStyle.Continuous
			Me.lblCommentaires.BackColor = Color.Transparent
			Dim label5 As System.Windows.Forms.Label = Me.lblCommentaires
			point = New System.Drawing.Point(434, 482)
			label5.Location = point
			Me.lblCommentaires.Name = "lblCommentaires"
			Dim label6 As System.Windows.Forms.Label = Me.lblCommentaires
			size = New System.Drawing.Size(580, 75)
			label6.Size = size
			Me.lblCommentaires.TabIndex = 3
			Dim label7 As System.Windows.Forms.Label = Me.lblDate
			point = New System.Drawing.Point(434, 455)
			label7.Location = point
			Me.lblDate.Name = "lblDate"
			Dim label8 As System.Windows.Forms.Label = Me.lblDate
			size = New System.Drawing.Size(580, 16)
			label8.Size = size
			Me.lblDate.TabIndex = 2
			Dim label9 As System.Windows.Forms.Label = Me.lblTitre
			point = New System.Drawing.Point(434, 432)
			label9.Location = point
			Me.lblTitre.Name = "lblTitre"
			Dim label10 As System.Windows.Forms.Label = Me.lblTitre
			size = New System.Drawing.Size(580, 16)
			label10.Size = size
			Me.lblTitre.TabIndex = 1
			Me.Photo.BackgroundImage = Resources.Appareil_photo
			Me.Photo.BackgroundImageLayout = ImageLayout.Center
			Me.Photo.BorderStyle = BorderStyle.FixedSingle
			Me.Photo.ErrorImage = Resources.papillon
			Dim photo As System.Windows.Forms.PictureBox = Me.Photo
			point = New System.Drawing.Point(434, 29)
			photo.Location = point
			Me.Photo.Name = "Photo"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.Photo
			size = New System.Drawing.Size(600, 400)
			pictureBox.Size = size
			Me.Photo.SizeMode = PictureBoxSizeMode.StretchImage
			Me.Photo.TabIndex = 0
			Me.Photo.TabStop = False
			Me.PictureBox1.Image = Resources.Jardin
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(18, 435)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox11 As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(355, 198)
			pictureBox11.Size = size
			Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 6
			Me.PictureBox1.TabStop = False
			Me.OpenFileDialogphoto.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg"
			Me.BackgroundWorker1.WorkerReportsProgress = True
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoScroll = True
			Me.BackColor = SystemColors.Control
			size = New System.Drawing.Size(1094, 672)
			Me.ClientSize = size
			Me.Controls.Add(Me.TabControl)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.KeyPreview = True
			Me.MaximizeBox = False
			Me.Name = "FormMonJardin"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Mon jardin"
			Me.TabControl.ResumeLayout(False)
			Me.Schema.ResumeLayout(False)
			Me.ToolStrip3.ResumeLayout(False)
			Me.ToolStrip3.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.RB.ResumeLayout(False)
			Me.ToolStrip1.ResumeLayout(False)
			Me.ToolStrip1.PerformLayout()
			Me.SplitContainer1.Panel1.ResumeLayout(False)
			Me.SplitContainer1.Panel2.ResumeLayout(False)
			DirectCast(Me.SplitContainer1, ISupportInitialize).EndInit()
			Me.SplitContainer1.ResumeLayout(False)
			Me.GroupBoxRecoltes.ResumeLayout(False)
			Me.GroupBoxMateriel.ResumeLayout(False)
			Me.Photos.ResumeLayout(False)
			Me.ToolStrip2.ResumeLayout(False)
			Me.ToolStrip2.PerformLayout()
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			DirectCast(Me.Photo, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		Private Sub Label_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.stringinputbox = Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(-1) {}, Nothing, Nothing, Nothing))
			Me.Inputboxperso = New FormInputbox()
			If (Me.Inputboxperso.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim formPasPas() As Object = { MyProject.Forms.FormPasPas.stringinputbox }
				NewLateBinding.LateSet(sender, Nothing, "text", formPasPas, Nothing, Nothing)
			End If
		End Sub

		Private Sub ListView_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.indeximagetraitee = Me.ListView.SelectedIndices(0)
			Me.Photo.Image = Me.Bibliophoto(Me.indeximagetraitee)
			Me.lblTitre.Text = String.Concat("Titre: ", Me.metadata(Me.indeximagetraitee * 3))
			Me.lblDate.Text = String.Concat("Date: ", Me.metadata(Me.indeximagetraitee * 3 + 1))
			Me.lblCommentaires.Text = String.Concat("Commentaires: ", Me.metadata(Me.indeximagetraitee * 3 + 2))
		End Sub

		Private Sub ListView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			Me.indeximagetraitee = Me.ListView.SelectedIndices(0)
			Me.Photo.Image = Me.Bibliophoto(Me.indeximagetraitee)
			Me.lblTitre.Text = String.Concat("Titre: ", Me.metadata(Me.indeximagetraitee * 3))
			Me.lblDate.Text = String.Concat("Date: ", Me.metadata(Me.indeximagetraitee * 3 + 1))
			Me.lblCommentaires.Text = String.Concat("Commentaires: ", Me.metadata(Me.indeximagetraitee * 3 + 2))
		End Sub

		Private Sub ListView_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			Me.indeximagetraitee = Me.ListView.SelectedIndices(0)
			Me.Photo.Image = Me.Bibliophoto(Me.indeximagetraitee)
			Me.lblTitre.Text = String.Concat("Titre: ", Me.metadata(Me.indeximagetraitee * 3))
			Me.lblDate.Text = String.Concat("Date: ", Me.metadata(Me.indeximagetraitee * 3 + 1))
			Me.lblCommentaires.Text = String.Concat("Commentaires: ", Me.metadata(Me.indeximagetraitee * 3 + 2))
		End Sub

		Private Sub ListView1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.indexbmpselect = Me.ListView1.SelectedIndices(0)
			MyProject.Forms.FormPasPas.pathbmp = Me.Pathjardin(Me.indexbmpselect)
			Me.BMP = New Formbmp()
			Me.BMP.Show()
		End Sub

		<DllImport("user32.dll", CharSet:=CharSet.Unicode, EntryPoint:="LoadCursorFromFileW", ExactSpelling:=True, SetLastError:=True)>
		Private Shared Function LoadCursorFromFile(ByRef filename As String) As IntPtr
		End Function

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Public Function nbfich(ByVal chemin As String, ByVal ParamArray termin As Object()) As Long
			Dim num As Long = 0L
			Dim objArray As Object() = termin
			Dim num1 As Integer = 0
			Do
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(objArray(num1))
				Dim str As String = FileSystem.Dir(Conversions.ToString(Operators.ConcatenateObject(String.Concat(chemin, "\*."), objectValue)), FileAttribute.Normal)
				While Operators.CompareString(str, "", False) <> 0
					num = num + CLng(1)
					str = FileSystem.Dir()
				End While
				num1 = num1 + 1
			Loop While num1 < CInt(objArray.Length)
			Return num
		End Function

		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub OpenFileDialogphoto_FileOk(ByVal sender As Object, ByVal e As CancelEventArgs)
			Me.pathimagetraitee = Me.OpenFileDialogphoto.FileName
			Me.newpathimage = String.Concat(Me.pathdossierphoto, "\Photo", Conversions.ToString(Me.nbrphotobibliochargee))
			FileSystem.FileCopy(Me.pathimagetraitee, Me.newpathimage)
			Me.fs = File.OpenRead(Me.newpathimage)
			Me.imagetraitee = Image.FromStream(Me.fs)
			Me.fs.Close()
			Me.ImageList1.Images.Add(Conversions.ToString(Me.nbrphotobibliochargee), Me.imagetraitee)
			Me.Bibliophoto.Add(Me.imagetraitee)
			Me.Photo.Image = Me.Bibliophoto(Me.nbrphotobibliochargee)
			MyProject.Forms.FormPasPas.titrephot = ""
			MyProject.Forms.FormPasPas.datephot = ""
			MyProject.Forms.FormPasPas.comphot = ""
			Me.Propphoto = New Formpropphoto()
			If (Me.Propphoto.ShowDialog(Me) <> System.Windows.Forms.DialogResult.OK) Then
				Me.metadata.Add("")
				Me.metadata.Add("")
				Me.metadata.Add("")
				Me.ListView.Items.Add("", Me.nbrphotobibliochargee)
				Dim subItems As ListViewItem.ListViewSubItemCollection = Me.ListView.Items(Me.nbrphotobibliochargee).SubItems
				subItems.Add(Me.metadata(Me.nbrphotobibliochargee * 3))
				subItems.Add(Me.metadata(Me.nbrphotobibliochargee * 3 + 2))
				subItems.Add(Me.metadata(Me.nbrphotobibliochargee * 3 + 1))
				subItems = Nothing
				Me.lblTitre.Text = "Titre:"
				Me.lblDate.Text = "Date:"
				Me.lblCommentaires.Text = "Commentaires:"
			Else
				Me.metadata.Add(MyProject.Forms.FormPasPas.titrephot)
				Me.metadata.Add(MyProject.Forms.FormPasPas.datephot)
				Me.metadata.Add(MyProject.Forms.FormPasPas.comphot)
				Me.ListView.Items.Add("", Me.nbrphotobibliochargee)
				Dim listViewSubItemCollections As ListViewItem.ListViewSubItemCollection = Me.ListView.Items(Me.nbrphotobibliochargee).SubItems
				listViewSubItemCollections.Add(Me.metadata(Me.nbrphotobibliochargee * 3))
				listViewSubItemCollections.Add(Me.metadata(Me.nbrphotobibliochargee * 3 + 2))
				listViewSubItemCollections.Add(Me.metadata(Me.nbrphotobibliochargee * 3 + 1))
				listViewSubItemCollections = Nothing
				Me.lblTitre.Text = String.Concat("Titre: ", MyProject.Forms.FormPasPas.titrephot)
				Me.lblDate.Text = String.Concat("Date: ", MyProject.Forms.FormPasPas.datephot)
				Me.lblCommentaires.Text = String.Concat("Commentaires: ", MyProject.Forms.FormPasPas.comphot)
			End If
			Me.btnmodiftof.Enabled = True
			Me.btnsupptof.Enabled = True
			Me.nbrphotobibliochargee = Me.nbrphotobibliochargee + 1
		End Sub

		Public Function splitxt(ByRef str As String, ByVal int As Integer) As String
			Dim strArrays As String()
			Try
				strArrays = Strings.Split(str, "|", -1, CompareMethod.Binary)
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				strArrays = New String() { "", "" }
				ProjectData.ClearProjectError()
			End Try
			Return strArrays(int)
		End Function

		Private Sub TabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.TabControl.SelectedIndex = 1 AndAlso Me.firstload1) Then
				Me.BackgroundWorker2.RunWorkerAsync()
				Me.firstload1 = False
			End If
			If (Me.TabControl.SelectedIndex = 2 AndAlso Me.firstload2) Then
				If (Not Directory.Exists(Me.pathdossierphoto)) Then
					Directory.CreateDirectory(Me.pathdossierphoto)
				End If
				If (Not File.Exists(Me.pathfichierphoto)) Then
					File.Create(Me.pathfichierphoto)
				End If
				Me.Pathphoto = Directory.GetFiles(Me.pathdossierphoto)
				Me.nbrphotobiblio = CInt(Me.Pathphoto.Length)
				If (Me.nbrphotobiblio <= 0) Then
					Me.btnmodiftof.Enabled = False
					Me.btnsupptof.Enabled = False
				Else
					Me.StatusStrip1.Visible = True
					Me.Cursor = Cursors.WaitCursor
					Me.BackgroundWorker1.RunWorkerAsync()
				End If
				Me.firstload2 = False
			End If
		End Sub

		Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
			Dim num As Integer = 1
			Dim black As Brush = Brushes.Black
			Dim tabRect As Rectangle = Me.TabControl.GetTabRect(e.Index)
			If (e.Index = 0) Then
				If (e.State <> DrawItemState.Selected) Then
					e.Graphics.FillRectangle(Brushes.Peru, tabRect)
					black = Brushes.Black
				Else
					e.Graphics.FillRectangle(Brushes.Peru, tabRect)
					black = Brushes.Black
				End If
			End If
			If (e.Index = 1) Then
				If (e.State <> DrawItemState.Selected) Then
					e.Graphics.FillRectangle(Brushes.Tan, tabRect)
					black = Brushes.Black
				Else
					e.Graphics.FillRectangle(Brushes.Tan, tabRect)
					black = Brushes.Black
				End If
			End If
			If (e.Index = 2) Then
				If (e.State <> DrawItemState.Selected) Then
					e.Graphics.FillRectangle(Brushes.DarkSeaGreen, tabRect)
					black = Brushes.Black
				Else
					e.Graphics.FillRectangle(Brushes.DarkSeaGreen, tabRect)
					black = Brushes.Black
				End If
			End If
			Dim rectangleF As System.Drawing.RectangleF = New System.Drawing.RectangleF(CSng((tabRect.Left + num)), CSng((tabRect.Y + num)), CSng((tabRect.Width - 2 * num)), CSng((tabRect.Height - 2 * num)))
			Dim stringFormat As System.Drawing.StringFormat = New System.Drawing.StringFormat()
			Dim font As System.Drawing.Font = New System.Drawing.Font(Me.Font, FontStyle.Bold)
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			e.Graphics.DrawString(Me.TabControl.TabPages(e.Index).Text, font, black, rectangleF, stringFormat)
			stringFormat.Dispose()
		End Sub

		Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Try
				Me.indexselection = Me.ListViewRecoltes.SelectedIndices(0)
				If (Interaction.MsgBox("Voulez vous vraiment supprimer la ligne sélectionnée?", MsgBoxStyle.YesNo, "Suppression d'une ligne") = MsgBoxResult.Yes) Then
					Me.ListViewRecoltes.Items.RemoveAt(Me.indexselection)
					Me.rang = Me.indexselection * 13
					Me.Recoltes.RemoveRange(Me.rang, 13)
					Me.nbritemrecolte = Me.nbritemrecolte - 1
				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				ProjectData.ClearProjectError()
			End Try
			Try
				Me.indexselection = Me.ListViewMateriel.SelectedIndices(0)
				If (Interaction.MsgBox("Voulez vous vraiment supprimer la ligne sélectionnée?", MsgBoxStyle.YesNo, "Suppression d'une ligne") = MsgBoxResult.Yes) Then
					Me.ListViewMateriel.Items.RemoveAt(Me.indexselection)
					Me.rang = Me.indexselection * 7
					Me.Materiel.RemoveRange(Me.rang, 7)
					Me.nbritemmat = Me.nbritemmat - 1
				End If
			Catch exception1 As System.Exception
				ProjectData.SetProjectError(exception1)
				ProjectData.ClearProjectError()
			End Try
		End Sub

		Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.Materieldata(0) = ""
			MyProject.Forms.FormPasPas.Materieldata(1) = ""
			MyProject.Forms.FormPasPas.Materieldata(2) = "0,00|"
			MyProject.Forms.FormPasPas.Materieldata(3) = "0,00"
			MyProject.Forms.FormPasPas.Materieldata(4) = ""
			MyProject.Forms.FormPasPas.Materieldata(5) = ""
			MyProject.Forms.FormPasPas.Materieldata(6) = ""
			Me.Newmateriel = New Formaddmat()
			If (Me.Newmateriel.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim num As Integer = 0
				Do
					Me.Materiel.Add(MyProject.Forms.FormPasPas.Materieldata(num))
					num = num + 1
				Loop While num <= 6
				Me.ListViewMateriel.Items.Add(MyProject.Forms.FormPasPas.Materieldata(0))
				Me.couttotal = Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Materieldata(3))
				Dim subItems As ListViewItem.ListViewSubItemCollection = Me.ListViewMateriel.Items(Me.nbritemmat).SubItems
				subItems.Add(MyProject.Forms.FormPasPas.Materieldata(1))
				subItems.Add(String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 1)))
				subItems.Add(MyProject.Forms.FormPasPas.Materieldata(3))
				subItems.Add(MyProject.Forms.FormPasPas.Materieldata(4))
				subItems.Add(MyProject.Forms.FormPasPas.Materieldata(5))
				subItems.Add(Me.couttotal.ToString())
				subItems.Add(MyProject.Forms.FormPasPas.Materieldata(6))
				subItems = Nothing
				Me.nbritemmat = Me.nbritemmat + 1
			End If
		End Sub

		Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.Recoltedata(0) = ""
			MyProject.Forms.FormPasPas.Recoltedata(1) = ""
			MyProject.Forms.FormPasPas.Recoltedata(2) = ""
			MyProject.Forms.FormPasPas.Recoltedata(3) = "0,00|"
			MyProject.Forms.FormPasPas.Recoltedata(4) = ""
			MyProject.Forms.FormPasPas.Recoltedata(5) = "0,00|"
			MyProject.Forms.FormPasPas.Recoltedata(6) = ""
			MyProject.Forms.FormPasPas.Recoltedata(7) = "0,00"
			MyProject.Forms.FormPasPas.Recoltedata(8) = "0,00|"
			MyProject.Forms.FormPasPas.Recoltedata(9) = "0,00"
			MyProject.Forms.FormPasPas.Recoltedata(10) = "0,00|"
			MyProject.Forms.FormPasPas.Recoltedata(11) = "0,00"
			MyProject.Forms.FormPasPas.Recoltedata(12) = ""
			Me.Newrecolte = New Formaddrecolte()
			If (Me.Newrecolte.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Dim num As Integer = 0
				Do
					Me.Recoltes.Add(MyProject.Forms.FormPasPas.Recoltedata(num))
					num = num + 1
				Loop While num <= 12
				Me.ListViewRecoltes.Items.Add(MyProject.Forms.FormPasPas.Recoltedata(0))
				Me.benef = -Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Recoltedata(7)) + Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Recoltedata(9)) + Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Recoltedata(11))
				Dim subItems As ListViewItem.ListViewSubItemCollection = Me.ListViewRecoltes.Items(Me.nbritemrecolte).SubItems
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(1))
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(2))
				subItems.Add(String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 1)))
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(4))
				subItems.Add(String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(5), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(5), 1)))
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(6))
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(7))
				subItems.Add(String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 1)))
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(9))
				subItems.Add(String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 1)))
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(11))
				subItems.Add(Me.benef.ToString())
				subItems.Add(MyProject.Forms.FormPasPas.Recoltedata(12))
				subItems = Nothing
				Me.nbritemrecolte = Me.nbritemrecolte + 1
			End If
		End Sub

		Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim gardenfinance As Double()
			Dim num As Integer
			Dim recoltes As List(Of String)
			Dim num1 As Integer
			Dim item As String
			Me.compt = 0
			MyProject.Forms.FormPasPas.Gardenfinance(0) = 0
			MyProject.Forms.FormPasPas.Gardenfinance(1) = 0
			MyProject.Forms.FormPasPas.Gardenfinance(2) = 0
			MyProject.Forms.FormPasPas.Gardenfinance(3) = 0
			Try
				If (Me.nbritemrecolte <= 0) Then
					Me.compt = Me.compt + 1
				Else
					Dim num2 As Integer = Me.nbritemrecolte - 1
					For i As Integer = 0 To num2 Step 1
						Me.rang = i * 13
						gardenfinance = MyProject.Forms.FormPasPas.Gardenfinance
						num = 0
						Dim num3 As Double = gardenfinance(num)
						recoltes = Me.Recoltes
						num1 = Me.rang + 3
						item = recoltes(num1)
						Dim str As String = Me.splitxt(item, 0)
						recoltes(num1) = item
						gardenfinance(num) = num3 + CDbl((Single.Parse(str) * Single.Parse(Me.Recoltes(Me.rang + 7))))
						gardenfinance = MyProject.Forms.FormPasPas.Gardenfinance
						num1 = 2
						Dim num4 As Double = gardenfinance(num1)
						recoltes = Me.Recoltes
						num = Me.rang + 10
						item = recoltes(num)
						Dim str1 As String = Me.splitxt(item, 0)
						recoltes(num) = item
						gardenfinance(num1) = num4 + CDbl((Single.Parse(str1) * Single.Parse(Me.Recoltes(Me.rang + 11))))
						gardenfinance = MyProject.Forms.FormPasPas.Gardenfinance
						num1 = 3
						Dim num5 As Double = gardenfinance(num1)
						recoltes = Me.Recoltes
						num = Me.rang + 8
						item = recoltes(num)
						Dim str2 As String = Me.splitxt(item, 0)
						recoltes(num) = item
						gardenfinance(num1) = num5 + CDbl((Single.Parse(str2) * Single.Parse(Me.Recoltes(Me.rang + 9))))
					Next

				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Vous n'avez pas renseigné suffisamment de données numériques dans les récoltes pour que le bilan soit complet", "Déficit d'arguments")
				ProjectData.ClearProjectError()
			End Try
			Try
				If (Me.nbritemmat <= 0) Then
					Me.compt = Me.compt + 1
				Else
					Dim num6 As Integer = Me.nbritemmat - 1
					For j As Integer = 0 To num6 Step 1
						Me.rang = j * 7
						gardenfinance = MyProject.Forms.FormPasPas.Gardenfinance
						num1 = 1
						Dim num7 As Double = gardenfinance(num1)
						recoltes = Me.Materiel
						num = Me.rang + 2
						item = recoltes(num)
						Dim str3 As String = Me.splitxt(item, 0)
						recoltes(num) = item
						gardenfinance(num1) = num7 + CDbl((Single.Parse(str3) * Single.Parse(Me.Materiel(Me.rang + 3))))
					Next

				End If
			Catch exception1 As System.Exception
				ProjectData.SetProjectError(exception1)
				MyProject.Forms.FormPasPas.Msgboxperso("Vous n'avez pas renseigné suffisamment de données numériques dans le materiel pour que le bilan soit complet", "Déficit d'arguments")
				ProjectData.ClearProjectError()
			End Try
			If (Me.compt = 2) Then
				MyProject.Forms.FormPasPas.Msgboxperso("Pas de données, pas de calculs!" & VbCrLf & "T'as vraiment cru que j'étais là pour coller des gommettes?!", "Absence de données")
			Else
				Me.Bilanfin = New Formbilanfin()
				Me.Bilanfin.Show()
			End If
		End Sub

		Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs)
			Try
				Me.indexselection = Me.ListViewRecoltes.SelectedIndices(0)
				Me.rang = Me.indexselection * 13
				Dim num As Integer = 0
				Do
					MyProject.Forms.FormPasPas.Recoltedata(num) = Me.Recoltes(Me.rang + num)
					num = num + 1
				Loop While num <= 12
				Me.Newrecolte = New Formaddrecolte() With
				{
					.Text = "Modifier",
					.Icon = Resources.modif
				}
				If (Me.Newrecolte.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
					Dim recoltedata As Integer = 0
					Do
						Me.Recoltes(Me.rang + recoltedata) = MyProject.Forms.FormPasPas.Recoltedata(recoltedata)
						recoltedata = recoltedata + 1
					Loop While recoltedata <= 12
					Me.ListViewRecoltes.Items(Me.indexselection).Text = MyProject.Forms.FormPasPas.Recoltedata(0)
					Me.benef = -Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Recoltedata(7)) + Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Recoltedata(9)) + Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Recoltedata(11))
					Dim item As ListViewItem = Me.ListViewRecoltes.Items(Me.indexselection)
					item.SubItems(1).Text = MyProject.Forms.FormPasPas.Recoltedata(1)
					item.SubItems(2).Text = MyProject.Forms.FormPasPas.Recoltedata(2)
					item.SubItems(3).Text = String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 1))
					item.SubItems(4).Text = MyProject.Forms.FormPasPas.Recoltedata(4)
					item.SubItems(5).Text = String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(5), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(5), 1))
					item.SubItems(6).Text = MyProject.Forms.FormPasPas.Recoltedata(6)
					item.SubItems(7).Text = MyProject.Forms.FormPasPas.Recoltedata(7)
					item.SubItems(8).Text = String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 1))
					item.SubItems(9).Text = MyProject.Forms.FormPasPas.Recoltedata(9)
					item.SubItems(10).Text = String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 1))
					item.SubItems(11).Text = MyProject.Forms.FormPasPas.Recoltedata(11)
					item.SubItems(12).Text = Me.benef.ToString()
					item.SubItems(13).Text = MyProject.Forms.FormPasPas.Recoltedata(12)
					item = Nothing
				End If
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				ProjectData.ClearProjectError()
			End Try
			Try
				Me.indexselection = Me.ListViewMateriel.SelectedIndices(0)
				Me.rang = Me.indexselection * 7
				Dim num1 As Integer = 0
				Do
					MyProject.Forms.FormPasPas.Materieldata(num1) = Me.Materiel(Me.rang + num1)
					num1 = num1 + 1
				Loop While num1 <= 6
				Me.Newmateriel = New Formaddmat() With
				{
					.Text = "Modifier",
					.Icon = Resources.modif
				}
				If (Me.Newmateriel.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
					Dim materieldata As Integer = 0
					Do
						Me.Materiel(Me.rang + materieldata) = MyProject.Forms.FormPasPas.Materieldata(materieldata)
						materieldata = materieldata + 1
					Loop While materieldata <= 6
					Me.ListViewMateriel.Items(Me.indexselection).Text = MyProject.Forms.FormPasPas.Materieldata(0)
					Me.couttotal = Single.Parse(Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 0)) * Single.Parse(MyProject.Forms.FormPasPas.Materieldata(3))
					Dim str As ListViewItem = Me.ListViewMateriel.Items(Me.indexselection)
					str.SubItems(1).Text = MyProject.Forms.FormPasPas.Materieldata(1)
					str.SubItems(2).Text = String.Concat(Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 0), " ", Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 1))
					str.SubItems(3).Text = MyProject.Forms.FormPasPas.Materieldata(3)
					str.SubItems(4).Text = MyProject.Forms.FormPasPas.Materieldata(4)
					str.SubItems(5).Text = MyProject.Forms.FormPasPas.Materieldata(5)
					str.SubItems(6).Text = Me.couttotal.ToString()
					str.SubItems(7).Text = MyProject.Forms.FormPasPas.Materieldata(6)
					str = Nothing
				End If
			Catch exception1 As System.Exception
				ProjectData.SetProjectError(exception1)
				ProjectData.ClearProjectError()
			End Try
		End Sub
	End Class
End Namespace