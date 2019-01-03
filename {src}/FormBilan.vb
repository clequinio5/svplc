Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormBilan
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("GroupBoxBilan")>
		Private _GroupBoxBilan As GroupBox

		<AccessedThroughProperty("Panelbilan")>
		Private _Panelbilan As Panel

		<AccessedThroughProperty("Panelstat")>
		Private _Panelstat As Panel

		<AccessedThroughProperty("Panelechelle")>
		Private _Panelechelle As Panel

		Private tabbilan As Label(,)

		Private tabstat As Label(,)

		Private tabech As Label(,)

		Private combsynt As String(,)

		Private rep As String

		Private codecombinaisonchoisie3 As String

		Private stats As Integer(,)

		Private numerocombinaisonrotation3 As Integer

		Private traitab As Integer

		Private indicecombchoisie1 As Integer

		Private indicecombchoisie2 As Integer

		Private indicecombchoisie3 As Integer

		Private Overridable Property GroupBoxBilan As GroupBox
			Get
				Return Me._GroupBoxBilan
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As GroupBox)
				Me._GroupBoxBilan = value
			End Set
		End Property

		Private Overridable Property Panelbilan As Panel
			Get
				Return Me._Panelbilan
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelbilan = value
			End Set
		End Property

		Private Overridable Property Panelechelle As Panel
			Get
				Return Me._Panelechelle
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelechelle = value
			End Set
		End Property

		Private Overridable Property Panelstat As Panel
			Get
				Return Me._Panelstat
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Panel)
				Me._Panelstat = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formBilan1 As FormBilan = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formBilan1.Formbilan_Load)
			Dim formBilan2 As FormBilan = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formBilan2.Formbilan_FormClosed)
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

		Private Sub Formbilan_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadbilan = False
		End Sub

		Private Sub Formbilan_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer
			Dim num1 As Double
			Me.numerocombinaisonrotation3 = 0
			If (Module1.nbrrotationoptimisees2 <= 1) Then
				Me.numerocombinaisonrotation3 = 1
			Else
				While True
					Me.rep = MyProject.Forms.FormPasPas.Inputboxperso(String.Concat("Veuillez entrez le numero de la combinaison pour laquelle vous voulez calculer la première rotation" & VbCrLf & "Le chiffre dois être compris entre 1 et ", Conversions.ToString(Module1.nbrrotationoptimisees2), "."), "Entrée des paramètres du calcul")
					Try
						If (Operators.CompareString(Me.rep, "", False) <> 0) Then
							Me.numerocombinaisonrotation3 = Conversions.ToInteger(Me.rep)
							If (Me.numerocombinaisonrotation3 <= Module1.nbrrotationoptimisees2) Then
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
			Me.codecombinaisonchoisie3 = ""
			Dim num2 As Integer = Module1.numeroparcelle
			Dim num3 As Integer = 1
			Do
				Dim num4 As Integer = Module1.numeroparcelle
				Dim num5 As Integer = 1
				Do
					If (Operators.CompareString(Module1.listelégumes(Module1.Legumes_selectionnésconvertis(num5)), Module1.RESULTSROT2(Me.numerocombinaisonrotation3, num3), False) = 0) Then
						Me.codecombinaisonchoisie3 = String.Concat(Me.codecombinaisonchoisie3, Conversions.ToString(num5))
					End If
					num5 = num5 + 1
				Loop While num5 <= num4
				num3 = num3 + 1
			Loop While num3 <= num2
			Me.combsynt = Nothing
			ReDim Me.combsynt(2, Module1.numeroparcelle + Module1.numerocontrainte + 1 - 1)
			Dim num6 As Integer = Module1.numeroparcelle
			Dim num7 As Integer = 1
			Do
				Me.combsynt(0, num7) = Module1.RESULTSASS(Module1.numerocombinaisonrotation1, num7)
				num7 = num7 + 1
			Loop While num7 <= num6
			Dim num8 As Integer = Module1.numeroparcelle
			Dim num9 As Integer = 1
			Do
				Me.combsynt(1, num9) = Module1.RESULTSROT1(Module1.numerocombinaisonrotation2, num9)
				num9 = num9 + 1
			Loop While num9 <= num8
			Dim num10 As Integer = Module1.numeroparcelle
			Dim num11 As Integer = 1
			Do
				Me.combsynt(2, num11) = Module1.RESULTSROT2(Me.numerocombinaisonrotation3, num11)
				num11 = num11 + 1
			Loop While num11 <= num10
			If (Module1.numerocontrainte <> 0) Then
				Dim num12 As Integer = Module1.numerocontrainte
				For i As Integer = 1 To num12 Step 1
					Dim num13 As Integer = 0
					Do
						Me.combsynt(num13, i + Module1.numeroparcelle) = Module1.listelégumes(Module1.Contraintes_selectionnéesconvertis(i))
						num13 = num13 + 1
					Loop While num13 <= 2
				Next

			End If
			Me.indicecombchoisie1 = 0
			Dim num14 As Integer = Module1.factnumeroparcelle
			Dim num15 As Integer = 1
			Do
				If (Operators.CompareString(Module1.COMBINAISONS(num15), Module1.codecombinaisonchoisie1, False) = 0) Then
					Me.indicecombchoisie1 = num15
				End If
				num15 = num15 + 1
			Loop While num15 <= num14
			Me.indicecombchoisie2 = 0
			Dim num16 As Integer = Module1.factnumeroparcelle
			Dim num17 As Integer = 1
			Do
				If (Operators.CompareString(Module1.COMBINAISONS(num17), Module1.codecombinaisonchoisie2, False) = 0) Then
					Me.indicecombchoisie2 = num17
				End If
				num17 = num17 + 1
			Loop While num17 <= num16
			Me.indicecombchoisie3 = 0
			Dim num18 As Integer = Module1.factnumeroparcelle
			Dim num19 As Integer = 1
			Do
				If (Operators.CompareString(Module1.COMBINAISONS(num19), Me.codecombinaisonchoisie3, False) = 0) Then
					Me.indicecombchoisie3 = num19
				End If
				num19 = num19 + 1
			Loop While num19 <= num18
			ReDim Me.stats(2, 7)
			Me.stats(0, 1) = Module1.Notepp(Me.indicecombchoisie1)
			Me.stats(1, 1) = Module1.Notepp(Me.indicecombchoisie2)
			Me.stats(2, 1) = Module1.Notepp(Me.indicecombchoisie3)
			If (Module1.numerocontrainte = 0) Then
				Dim num20 As Integer = 0
				Do
					Dim num21 As Integer = 2
					Do
						Me.stats(num20, num21) = 0
						num21 = num21 + 1
					Loop While num21 <= 3
					num20 = num20 + 1
				Loop While num20 <= 2
			Else
				Me.stats(0, 2) = Module1.Notepc(Me.indicecombchoisie1)
				Me.stats(1, 2) = Module1.Notepc(Me.indicecombchoisie2)
				Me.stats(2, 2) = Module1.Notepc(Me.indicecombchoisie3)
				Dim num22 As Integer = 0
				Do
					Me.stats(num22, 3) = Module1.Notecc
					num22 = num22 + 1
				Loop While num22 <= 2
			End If
			Me.stats(0, 4) = Module1.NOTEASSMAX
			Me.stats(1, 4) = Module1.NOTESASS(Me.indicecombchoisie2 - 1)
			Me.stats(2, 4) = Module1.NOTESASS(Me.indicecombchoisie3 - 1)
			Me.stats(0, 6) = Module1.NOTEASSMAX
			Me.stats(1, 6) = Module1.NOTEMAX1
			Me.stats(2, 6) = Module1.NOTEMAX2
			Me.stats(0, 5) = 0
			Me.stats(1, 5) = Me.stats(1, 6) - Me.stats(1, 4)
			Me.stats(2, 5) = Me.stats(2, 6) - Me.stats(2, 4)
			Me.stats(0, 7) = Module1.nbrfrontierespartagees
			Me.stats(1, 7) = Module1.nbrcellulesutilisees
			Me.stats(2, 7) = Me.stats(0, 7) + Me.stats(1, 7)
			ReDim Me.tabbilan(3, Module1.numeroparcelle + Module1.numerocontrainte + 1 - 1)
			Me.traitab = 1
			Me.tabbilan(0, 0) = New System.Windows.Forms.Label()
			Dim darkKhaki As System.Windows.Forms.Label = Me.tabbilan(0, 0)
			darkKhaki.Text = "Parcelle"
			Dim point As System.Drawing.Point = New System.Drawing.Point(Me.traitab, Me.traitab)
			darkKhaki.Location = point
			darkKhaki.BackColor = Color.DarkKhaki
			darkKhaki.TextAlign = ContentAlignment.MiddleCenter
			Dim size As System.Drawing.Size = New System.Drawing.Size(100, 14)
			darkKhaki.Size = size
			darkKhaki = Nothing
			Me.Panelbilan.Controls.Add(Me.tabbilan(0, 0))
			Dim num23 As Integer = 1
			Do
				Me.tabbilan(num23, 0) = New System.Windows.Forms.Label()
				Dim label As System.Windows.Forms.Label = Me.tabbilan(num23, 0)
				label.BackColor = Color.DarkKhaki
				num = num23 - 1
				label.Text = String.Concat("Année ", num.ToString())
				size = New System.Drawing.Size(100, 14)
				label.Size = size
				point = New System.Drawing.Point(num23 * 100 + (num23 + 1) * Me.traitab, Me.traitab)
				label.Location = point
				label = Nothing
				Me.Panelbilan.Controls.Add(Me.tabbilan(num23, 0))
				num23 = num23 + 1
			Loop While num23 <= 3
			Dim num24 As Integer = Module1.numeroparcelle
			Dim num25 As Integer = 1
			Do
				Me.tabbilan(0, num25) = New System.Windows.Forms.Label()
				Dim cOULEURSUTILES As System.Windows.Forms.Label = Me.tabbilan(0, num25)
				cOULEURSUTILES.BackColor = Module1.COULEURSUTILES(num25)
				cOULEURSUTILES.Text = num25.ToString()
				cOULEURSUTILES.TextAlign = ContentAlignment.MiddleCenter
				size = New System.Drawing.Size(100, 14)
				cOULEURSUTILES.Size = size
				point = New System.Drawing.Point(Me.traitab, num25 * 14 + (num25 + 1) * Me.traitab)
				cOULEURSUTILES.Location = point
				cOULEURSUTILES = Nothing
				Me.Panelbilan.Controls.Add(Me.tabbilan(0, num25))
				num25 = num25 + 1
			Loop While num25 <= num24
			If (Module1.numerocontrainte <> 0) Then
				Dim num26 As Integer = Module1.numeroparcelle + 1
				Dim num27 As Integer = Module1.numeroparcelle + Module1.numerocontrainte
				For j As Integer = num26 To num27 Step 1
					Me.tabbilan(0, j) = New System.Windows.Forms.Label()
					Dim cOULEURSUTILES1 As System.Windows.Forms.Label = Me.tabbilan(0, j)
					cOULEURSUTILES1.BackColor = Module1.COULEURSUTILES(j)
					num = j - Module1.numeroparcelle
					cOULEURSUTILES1.Text = String.Concat("C", num.ToString())
					cOULEURSUTILES1.TextAlign = ContentAlignment.MiddleCenter
					size = New System.Drawing.Size(100, 14)
					cOULEURSUTILES1.Size = size
					point = New System.Drawing.Point(Me.traitab, j * 14 + (j + 1) * Me.traitab)
					cOULEURSUTILES1.Location = point
					cOULEURSUTILES1 = Nothing
					Me.Panelbilan.Controls.Add(Me.tabbilan(0, j))
				Next

			End If
			Dim num28 As Integer = 1
			Do
				Dim num29 As Integer = Module1.numeroparcelle + Module1.numerocontrainte
				Dim num30 As Integer = 1
				Do
					Me.tabbilan(num28, num30) = New System.Windows.Forms.Label()
					Dim darkKhaki1 As System.Windows.Forms.Label = Me.tabbilan(num28, num30)
					darkKhaki1.BackColor = Color.DarkKhaki
					darkKhaki1.Text = Me.combsynt(num28 - 1, num30)
					size = New System.Drawing.Size(100, 14)
					darkKhaki1.Size = size
					point = New System.Drawing.Point(num28 * (100 + Me.traitab) + Me.traitab, num30 * (14 + Me.traitab) + Me.traitab)
					darkKhaki1.Location = point
					darkKhaki1 = Nothing
					Me.Panelbilan.Controls.Add(Me.tabbilan(num28, num30))
					num30 = num30 + 1
				Loop While num30 <= num29
				num28 = num28 + 1
			Loop While num28 <= 3
			Dim panelbilan As Panel = Me.Panelbilan
			panelbilan.BackColor = Color.Black
			point = New System.Drawing.Point(20, 40)
			panelbilan.Location = point
			size = New System.Drawing.Size(400 + 5 * Me.traitab, (Module1.numeroparcelle + Module1.numerocontrainte + 1) * 14 + (Module1.numeroparcelle + Module1.numerocontrainte + 2) * Me.traitab)
			panelbilan.Size = size
			panelbilan.Visible = True
			panelbilan = Nothing
			ReDim Me.tabstat(3, 6)
			Dim num31 As Integer = 1
			Do
				Me.tabstat(num31, 0) = New System.Windows.Forms.Label()
				Dim rosyBrown As System.Windows.Forms.Label = Me.tabstat(num31, 0)
				rosyBrown.BackColor = Color.RosyBrown
				num = num31 - 1
				rosyBrown.Text = String.Concat("Année ", num.ToString())
				size = New System.Drawing.Size(100, 14)
				rosyBrown.Size = size
				point = New System.Drawing.Point(num31 * 100 + (num31 + 1) * Me.traitab, Me.traitab)
				rosyBrown.Location = point
				rosyBrown = Nothing
				num31 = num31 + 1
			Loop While num31 <= 3
			Dim num32 As Integer = 0
			Do
				Me.tabstat(0, num32) = New System.Windows.Forms.Label()
				Dim rosyBrown1 As System.Windows.Forms.Label = Me.tabstat(0, num32)
				rosyBrown1.BackColor = Color.RosyBrown
				rosyBrown1.TextAlign = ContentAlignment.MiddleCenter
				size = New System.Drawing.Size(100, 14)
				rosyBrown1.Size = size
				point = New System.Drawing.Point(Me.traitab, num32 * 14 + (num32 + 1) * Me.traitab)
				rosyBrown1.Location = point
				rosyBrown1 = Nothing
				num32 = num32 + 1
			Loop While num32 <= 6
			Me.tabstat(0, 0).Text = "Calcul"
			Me.tabstat(0, 1).Text = "note pp"
			Me.tabstat(0, 2).Text = "note pc"
			Me.tabstat(0, 3).Text = "note cc"
			Me.tabstat(0, 4).Text = "NOTE ASS"
			Me.tabstat(0, 5).Text = "NOTE ROT"
			Me.tabstat(0, 6).Text = "TOTAL"
			Dim num33 As Integer = 1
			Do
				Dim num34 As Integer = 1
				Do
					Me.tabstat(num33, num34) = New System.Windows.Forms.Label()
					Dim str As System.Windows.Forms.Label = Me.tabstat(num33, num34)
					str.BackColor = Color.RosyBrown
					str.Text = Me.stats(num33 - 1, num34).ToString()
					size = New System.Drawing.Size(100, 14)
					str.Size = size
					point = New System.Drawing.Point(num33 * 100 + (num33 + 1) * Me.traitab, num34 * 14 + (num34 + 1) * Me.traitab)
					str.Location = point
					str = Nothing
					num34 = num34 + 1
				Loop While num34 <= 6
				num33 = num33 + 1
			Loop While num33 <= 3
			Dim num35 As Integer = 1
			Do
				Dim label1 As System.Windows.Forms.Label = Me.tabstat(num35, 4)
				Dim text As String = Me.tabstat(num35, 4).Text
				num1 = Math.Round(CDbl((Me.stats(num35 - 1, 4) * 100)) / CDbl(Me.stats(0, 7)), 1, MidpointRounding.AwayFromZero)
				label1.Text = String.Concat(text, "  (", num1.ToString(), "%)")
				num35 = num35 + 1
			Loop While num35 <= 3
			Dim num36 As Integer = 1
			Do
				Dim label2 As System.Windows.Forms.Label = Me.tabstat(num36, 5)
				Dim text1 As String = Me.tabstat(num36, 5).Text
				num1 = Math.Round(CDbl((Me.stats(num36 - 1, 5) * 100)) / CDbl(Me.stats(1, 7)), 1, MidpointRounding.AwayFromZero)
				label2.Text = String.Concat(text1, "  (", num1.ToString(), "%)")
				num36 = num36 + 1
			Loop While num36 <= 3
			Dim num37 As Integer = 0
			Do
				Dim num38 As Integer = 0
				Do
					Me.Panelstat.Controls.Add(Me.tabstat(num37, num38))
					num38 = num38 + 1
				Loop While num38 <= 6
				num37 = num37 + 1
			Loop While num37 <= 3
			Dim panelstat As Panel = Me.Panelstat
			panelstat.BackColor = Color.Black
			point = New System.Drawing.Point(20, 80 + (Module1.numeroparcelle + Module1.numerocontrainte + 1) * 14 + (Module1.numeroparcelle + Module1.numerocontrainte + 2) * Me.traitab)
			panelstat.Location = point
			size = New System.Drawing.Size(400 + 5 * Me.traitab, 98 + 8 * Me.traitab)
			panelstat.Size = size
			panelstat.Visible = True
			panelstat = Nothing
			ReDim Me.tabech(1, 2)
			Dim num39 As Integer = 0
			Do
				Dim num40 As Integer = 0
				Do
					Me.tabech(num39, num40) = New System.Windows.Forms.Label()
					Dim cornflowerBlue As System.Windows.Forms.Label = Me.tabech(num39, num40)
					cornflowerBlue.BackColor = Color.CornflowerBlue
					size = New System.Drawing.Size(100, 14)
					cornflowerBlue.Size = size
					point = New System.Drawing.Point(num39 * (100 + Me.traitab) + Me.traitab, num40 * (14 + Me.traitab) + Me.traitab)
					cornflowerBlue.Location = point
					cornflowerBlue = Nothing
					num40 = num40 + 1
				Loop While num40 <= 2
				num39 = num39 + 1
			Loop While num39 <= 1
			Me.tabech(0, 0).Text = "Frontières"
			Me.tabech(0, 1).Text = "Superficie"
			Me.tabech(0, 2).Text = "ECHELLE"
			Me.tabech(1, 0).Text = Me.stats(0, 7).ToString()
			Me.tabech(1, 1).Text = Me.stats(1, 7).ToString()
			Me.tabech(1, 2).Text = String.Concat(Me.stats(0, 7).ToString(), " / ", Me.stats(2, 7).ToString())
			Dim num41 As Integer = 0
			Do
				Dim num42 As Integer = 0
				Do
					Me.Panelechelle.Controls.Add(Me.tabech(num41, num42))
					num42 = num42 + 1
				Loop While num42 <= 2
				num41 = num41 + 1
			Loop While num41 <= 1
			Dim panelechelle As Panel = Me.Panelechelle
			panelechelle.BackColor = Color.Black
			size = New System.Drawing.Size(200 + 3 * Me.traitab, 42 + 4 * Me.traitab)
			panelechelle.Size = size
			point = New System.Drawing.Point(20, (Module1.numeroparcelle + Module1.numerocontrainte + 1) * 14 + (Module1.numeroparcelle + Module1.numerocontrainte + 2) * Me.traitab + 188 + 8 * Me.traitab)
			panelechelle.Location = point
			panelechelle.Visible = True
			panelechelle = Nothing
			Me.GroupBoxBilan.Visible = True
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBilan))
			Me.GroupBoxBilan = New System.Windows.Forms.GroupBox()
			Me.Panelechelle = New System.Windows.Forms.Panel()
			Me.Panelstat = New System.Windows.Forms.Panel()
			Me.Panelbilan = New System.Windows.Forms.Panel()
			Me.GroupBoxBilan.SuspendLayout()
			Me.SuspendLayout()
			Me.GroupBoxBilan.BackColor = Color.Olive
			Me.GroupBoxBilan.Controls.Add(Me.Panelechelle)
			Me.GroupBoxBilan.Controls.Add(Me.Panelstat)
			Me.GroupBoxBilan.Controls.Add(Me.Panelbilan)
			Me.GroupBoxBilan.Dock = DockStyle.Fill
			Dim groupBoxBilan As System.Windows.Forms.GroupBox = Me.GroupBoxBilan
			Dim point As System.Drawing.Point = New System.Drawing.Point(0, 0)
			groupBoxBilan.Location = point
			Me.GroupBoxBilan.Name = "GroupBoxBilan"
			Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBoxBilan
			Dim size As System.Drawing.Size = New System.Drawing.Size(484, 498)
			groupBox.Size = size
			Me.GroupBoxBilan.TabIndex = 0
			Me.GroupBoxBilan.TabStop = False
			Me.GroupBoxBilan.Text = "Bilan et statistiques"
			Dim panelechelle As System.Windows.Forms.Panel = Me.Panelechelle
			point = New System.Drawing.Point(5, 434)
			panelechelle.Location = point
			Me.Panelechelle.Name = "Panelechelle"
			Dim panel As System.Windows.Forms.Panel = Me.Panelechelle
			size = New System.Drawing.Size(90, 82)
			panel.Size = size
			Me.Panelechelle.TabIndex = 2
			Dim panelstat As System.Windows.Forms.Panel = Me.Panelstat
			point = New System.Drawing.Point(5, 225)
			panelstat.Location = point
			Me.Panelstat.Name = "Panelstat"
			Dim panelstat1 As System.Windows.Forms.Panel = Me.Panelstat
			size = New System.Drawing.Size(358, 203)
			panelstat1.Size = size
			Me.Panelstat.TabIndex = 1
			Me.Panelbilan.BackColor = Color.Olive
			Dim panelbilan As System.Windows.Forms.Panel = Me.Panelbilan
			point = New System.Drawing.Point(5, 23)
			panelbilan.Location = point
			Me.Panelbilan.Name = "Panelbilan"
			Dim panelbilan1 As System.Windows.Forms.Panel = Me.Panelbilan
			size = New System.Drawing.Size(358, 197)
			panelbilan1.Size = size
			Me.Panelbilan.TabIndex = 0
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoSize = True
			size = New System.Drawing.Size(484, 498)
			Me.ClientSize = size
			Me.Controls.Add(Me.GroupBoxBilan)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formbilan"
			Me.Text = "Bilan et Statistiques"
			Me.GroupBoxBilan.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace