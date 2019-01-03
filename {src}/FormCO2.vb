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

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormCO2
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("BackgroundWorkercomb")>
		Private _BackgroundWorkercomb As BackgroundWorker

		<AccessedThroughProperty("GroupBoxCombinaisons")>
		Private _GroupBoxCombinaisons As GroupBox

		Private tab As Label(,)

		Private combinaison As Label(,)

		Private tableau As Panel(,)

		Private Panelcomb As Panel

		Private nbrcolonnetableau As Integer

		Private nbrlignetableau As Integer

		Private espaceentrepaneau As Integer

		Private nbrsolutionsaffichees As Integer

		Private largeurpaneau As Integer

		Private police As Integer

		Private hauteurpaneau As Integer

		Private Llabel1 As Integer

		Private Llabel2 As Integer

		Private trait As Integer

		Private Hlabel As Integer

		Private colonne As Integer

		Private ligne As Integer

		Private Overridable Property BackgroundWorkercomb As BackgroundWorker
			Get
				Return Me._BackgroundWorkercomb
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As BackgroundWorker)
				Dim formCO2 As SVPLCApplication.FormCO2 = Me
				Dim runWorkerCompletedEventHandler As System.ComponentModel.RunWorkerCompletedEventHandler = New System.ComponentModel.RunWorkerCompletedEventHandler(AddressOf formCO2.BackgroundWorker_RunWorkerCompleted)
				Dim formCO21 As SVPLCApplication.FormCO2 = Me
				Dim doWorkEventHandler As System.ComponentModel.DoWorkEventHandler = New System.ComponentModel.DoWorkEventHandler(AddressOf formCO21.BackgroundWorker_DoWork)
				If (Me._BackgroundWorkercomb IsNot Nothing) Then
					RemoveHandler Me._BackgroundWorkercomb.RunWorkerCompleted,  runWorkerCompletedEventHandler
					RemoveHandler Me._BackgroundWorkercomb.DoWork,  doWorkEventHandler
				End If
				Me._BackgroundWorkercomb = value
				If (Me._BackgroundWorkercomb IsNot Nothing) Then
					AddHandler Me._BackgroundWorkercomb.RunWorkerCompleted,  runWorkerCompletedEventHandler
					AddHandler Me._BackgroundWorkercomb.DoWork,  doWorkEventHandler
				End If
			End Set
		End Property

		Private Overridable Property GroupBoxCombinaisons As GroupBox
			Get
				Return Me._GroupBoxCombinaisons
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As GroupBox)
				Me._GroupBoxCombinaisons = value
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

		Public Sub New()
			MyBase.New()
			Dim formCO21 As FormCO2 = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formCO21.Form8_Load)
			Dim formCO22 As FormCO2 = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formCO22.FormCO2_FormClosed)
			Me.InitializeComponent()
		End Sub

		Private Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
			Dim size As System.Drawing.Size
			Dim point As System.Drawing.Point
			Me.Panelcomb = New Panel()
			Me.colonne = 0
			Me.ligne = 0
			ReDim Me.tableau(Me.nbrcolonnetableau - 1 + 1 - 1, Me.nbrlignetableau - 1 + 1 - 1)
			ReDim Me.combinaison(Me.nbrcolonnetableau - 1 + 1 - 1, Me.nbrlignetableau - 1 + 1 - 1)
			ReDim Me.tab(1, Module1.numeroparcelle - 1 + 1 - 1)
			Dim num As Integer = Me.nbrsolutionsaffichees - 1
			Dim num1 As Integer = 0
			Do
				Me.combinaison(Me.colonne, Me.ligne) = New Label()
				Dim font As Label = Me.combinaison(Me.colonne, Me.ligne)
				font.Text = String.Concat("Combinaison ", Conversions.ToString(num1 + 1))
				font.TextAlign = ContentAlignment.MiddleCenter
				font.Font = New System.Drawing.Font("Times new roman", CSng(Me.police), FontStyle.Bold)
				font.ForeColor = Color.Black
				size = New System.Drawing.Size(Me.Llabel1 + Me.Llabel2, Me.Hlabel)
				font.Size = size
				point = New System.Drawing.Point(Me.espaceentrepaneau + (Me.espaceentrepaneau + Me.largeurpaneau) * Me.colonne, (Me.espaceentrepaneau + Me.hauteurpaneau) * (Me.ligne + 1) - 5)
				font.Location = point
				font = Nothing
				Dim num2 As Integer = Module1.numeroparcelle - 1
				Dim num3 As Integer = 0
				Do
					Me.tab(0, num3) = New Label()
					Dim str As Label = Me.tab(0, num3)
					str.BackColor = Module1.couleurs(num3 + 1)
					str.TextAlign = ContentAlignment.MiddleCenter
					str.Text = Conversions.ToString(num3 + 1)
					str.Font = New System.Drawing.Font("Times new roman", CSng(Me.police))
					str.ForeColor = Color.Black
					size = New System.Drawing.Size(Me.Llabel1, Me.Hlabel)
					str.Size = size
					point = New System.Drawing.Point(Me.trait, Me.trait + (Me.trait + Me.Hlabel) * num3)
					str.Location = point
					str = Nothing
					Me.tab(1, num3) = New Label()
					Dim rESULTSROT2 As Label = Me.tab(1, num3)
					rESULTSROT2.TextAlign = ContentAlignment.MiddleCenter
					rESULTSROT2.Text = Module1.RESULTSROT2(num1 + 1, num3 + 1)
					rESULTSROT2.Font = New System.Drawing.Font("Times new roman", CSng(Me.police))
					rESULTSROT2.ForeColor = Color.Black
					rESULTSROT2.BackColor = Color.DarkKhaki
					size = New System.Drawing.Size(Me.Llabel2, Me.Hlabel)
					rESULTSROT2.Size = size
					point = New System.Drawing.Point(Me.Llabel1 + 2 * Me.trait, Me.trait + (Me.trait + Me.Hlabel) * num3)
					rESULTSROT2.Location = point
					rESULTSROT2 = Nothing
					num3 = num3 + 1
				Loop While num3 <= num2
				Me.tableau(Me.colonne, Me.ligne) = New Panel()
				Dim black As Panel = Me.tableau(Me.colonne, Me.ligne)
				black.BackColor = Color.Black
				point = New System.Drawing.Point(Me.espaceentrepaneau + (Me.espaceentrepaneau + Me.largeurpaneau) * Me.colonne, Me.espaceentrepaneau + (Me.espaceentrepaneau + Me.hauteurpaneau) * Me.ligne)
				black.Location = point
				size = New System.Drawing.Size(Me.largeurpaneau + 3 * Me.trait, Module1.numeroparcelle * (Me.trait + Me.Hlabel) + Me.trait)
				black.Size = size
				black = Nothing
				Dim num4 As Integer = Module1.numeroparcelle - 1
				Dim num5 As Integer = 0
				Do
					num3 = 0
					Do
						Me.tableau(Me.colonne, Me.ligne).Controls.Add(Me.tab(num3, num5))
						num3 = num3 + 1
					Loop While num3 <= 1
					num5 = num5 + 1
				Loop While num5 <= num4
				Me.Panelcomb.Controls.Add(Me.tableau(Me.colonne, Me.ligne))
				Me.Panelcomb.Controls.Add(Me.combinaison(Me.colonne, Me.ligne))
				Me.colonne = Me.colonne + 1
				If (Me.colonne = Me.nbrcolonnetableau) Then
					Me.ligne = Me.ligne + 1
					Me.colonne = 0
				End If
				num1 = num1 + 1
			Loop While num1 <= num
			Dim panelcomb As Panel = Me.Panelcomb
			point = New System.Drawing.Point(Me.Llabel1, Me.Llabel1)
			panelcomb.Location = point
			panelcomb.Dock = DockStyle.Fill
			panelcomb.AutoScroll = True
			size = New System.Drawing.Size(Me.nbrcolonnetableau * (Me.largeurpaneau + 3 * Me.trait + Me.espaceentrepaneau) + Me.espaceentrepaneau, Me.nbrlignetableau * (Me.espaceentrepaneau + (Me.trait + Me.Hlabel) * Module1.numeroparcelle + Me.trait) + 3 * Me.espaceentrepaneau)
			panelcomb.Size = size
			panelcomb = Nothing
			e.Result = Me.Panelcomb
		End Sub

		Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
			Dim groupBoxCombinaisons As GroupBox = Me.GroupBoxCombinaisons
			groupBoxCombinaisons.Controls.Add(DirectCast(e.Result, Control))
			groupBoxCombinaisons.Visible = True
			groupBoxCombinaisons = Nothing
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

		Private Sub Form8_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim enumerator As IEnumerator = Nothing
			Dim size As System.Drawing.Size = New System.Drawing.Size(Module1.screenadaptX(Me.Width), Module1.screenadaptY(Me.Height))
			Me.Size = size
			Try
				enumerator = Me.Controls.GetEnumerator()
				While enumerator.MoveNext()
					Dim current As Control = DirectCast(enumerator.Current, Control)
					Dim point As System.Drawing.Point = New System.Drawing.Point(Module1.screenadaptX(current.Left), Module1.screenadaptY(current.Top))
					current.Location = point
					size = New System.Drawing.Size(Module1.screenadaptX(current.Width), Module1.screenadaptY(current.Height))
					current.Size = size
					current.Font = New System.Drawing.Font(current.Font.Name, CSng(Module1.screenadaptfont(CInt(Math.Round(CDbl(current.Font.Size))))), current.Font.Style)
					current = Nothing
				End While
			Finally
				If (TypeOf enumerator Is IDisposable) Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.GroupBoxCombinaisons.Visible = False
			Dim label1 As Label = Me.Label1
			Dim str() As String = { "Il y a ", Conversions.ToString(Module1.nbrrotationoptimisees2), " solutions optimisées parmis ", Conversions.ToString(Module1.factnumeroparcelle), " possibles et dont la note est de ", Conversions.ToString(Module1.NOTEMAX2), " sur une échelle allant de -", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), " à ", Conversions.ToString(Module1.nbrfrontierespartagees + Module1.nbrcellulesutilisees), " ." }
			label1.Text = String.Concat(str)
			If (Module1.nbrrotationoptimisees2 <= 120) Then
				Me.nbrsolutionsaffichees = Module1.nbrrotationoptimisees2
			Else
				Me.nbrsolutionsaffichees = 120
				MyProject.Forms.FormPasPas.Msgboxperso(String.Concat("Le nombre de solutions optimisées est très grand." & VbCrLf & "Afin de ne pas ralentir excessivement votre pc, seulement ", Conversions.ToString(Me.nbrsolutionsaffichees), " solutions seront générées."), "Avertissement")
			End If
			Me.nbrcolonnetableau = 6
			Me.nbrlignetableau = CInt(Math.Round(Conversion.Int(CDbl(Me.nbrsolutionsaffichees) / CDbl(Me.nbrcolonnetableau)) + 1))
			Me.espaceentrepaneau = Module1.screenadaptX(30)
			Me.trait = 1
			Me.Hlabel = Module1.screenadaptY(14)
			Me.Llabel1 = Module1.screenadaptX(20)
			Me.Llabel2 = Module1.screenadaptX(100)
			Me.police = Module1.screenadaptfont(9)
			Me.hauteurpaneau = (Module1.numeroparcelle + 1) * Me.Hlabel + 2
			Me.largeurpaneau = Me.Llabel1 + Me.Llabel2
			Me.colonne = 0
			Me.ligne = 0
			Me.BackgroundWorkercomb.RunWorkerAsync()
		End Sub

		Private Sub FormCO2_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadcombrot2 = False
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCO2))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.BackgroundWorkercomb = New BackgroundWorker()
			Me.GroupBoxCombinaisons = New System.Windows.Forms.GroupBox()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.FromArgb(192, 0, 0)
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(40, 20)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(55, 19)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Label1"
			Me.GroupBoxCombinaisons.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.GroupBoxCombinaisons.ForeColor = Color.Red
			Dim groupBoxCombinaisons As System.Windows.Forms.GroupBox = Me.GroupBoxCombinaisons
			point = New System.Drawing.Point(5, 71)
			groupBoxCombinaisons.Location = point
			Me.GroupBoxCombinaisons.Name = "GroupBoxCombinaisons"
			Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBoxCombinaisons
			size = New System.Drawing.Size(974, 560)
			groupBox.Size = size
			Me.GroupBoxCombinaisons.TabIndex = 1
			Me.GroupBoxCombinaisons.TabStop = False
			Me.GroupBoxCombinaisons.Text = "Combinaisons"
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.Olive
			size = New System.Drawing.Size(984, 662)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBoxCombinaisons)
			Me.Controls.Add(Me.Label1)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormCO2"
			Me.Text = "Combinaisons optimisées  année +2"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
End Namespace