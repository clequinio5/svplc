Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormInputbox
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		Private lecture0 As StreamReader

		Private compt As Integer

		Private contenufichier As String

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formInputbox As SVPLCApplication.FormInputbox = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInputbox.Button1_Click)
				If (Me._Button1 IsNot Nothing) Then
					RemoveHandler Me._Button1.Click,  eventHandler
				End If
				Me._Button1 = value
				If (Me._Button1 IsNot Nothing) Then
					AddHandler Me._Button1.Click,  eventHandler
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

		Friend Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formInputbox1 As FormInputbox = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formInputbox1.Forminputbox_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim text As String = Me.Button1.Text
			If (Operators.CompareString(text, "Ok", False) = 0) Then
				MyProject.Forms.FormPasPas.stringinputbox = Me.TextBox1.Text
			ElseIf (Operators.CompareString(text, "Ajouter", False) = 0) Then
				Dim num As Integer = Module1.nbrlegumesbase - 1
				Dim num1 As Integer = 0
				Do
					If (Operators.CompareString(Me.TextBox1.Text, Module1.listelégumes(num1), False) = 0) Then
						MyProject.Forms.FormPasPas.Msgboxperso("Le légume renseigné existe déjà dans les BDD", "Le légume existe déjà")
						Me.TextBox1.Focus()
						Me.TextBox1.SelectAll()
						Return
					End If
					num1 = num1 + 1
				Loop While num1 <= num
				Try
					Dim strs As List(Of String) = New List(Of String)(File.ReadAllLines(Module1.PATHS(0), Encoding.[Default]).ToList()) From
					{
						Me.TextBox1.Text
					}
					File.WriteAllLines(Module1.PATHS(0), strs, Encoding.[Default])
				Catch exception As System.Exception
					ProjectData.SetProjectError(exception)
					MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture du nouveau légume", "Erreur d'écriture")
					ProjectData.ClearProjectError()
				End Try
				MyProject.Forms.FormPasPas.ChargementBDDlisteleg()
				MyProject.Forms.FormPasPas.ChargementBDDasso()
				MyProject.Forms.FormPasPas.ChargementBDDrot()
				MyProject.Forms.FormPasPas.Chargement_radiobutton_listeleg()
				Me.Close()
			ElseIf (Operators.CompareString(text, "Supprimer", False) = 0) Then
				Dim strs1 As List(Of String) = New List(Of String)(File.ReadAllLines(Module1.PATHS(0), Encoding.[Default]).ToList())
				For i As Integer = strs1.Count - 1 To 0 Step -1
					If (Operators.CompareString(strs1(i), Me.TextBox1.Text, False) = 0) Then
						strs1.RemoveAt(i)
					End If
				Next

				File.WriteAllLines(Module1.PATHS(0), strs1, Encoding.[Default])
				Dim num2 As Integer = 1
				Do
					strs1 = New List(Of String)(File.ReadAllLines(Module1.PATHS(num2), Encoding.[Default]).ToList())
					For j As Integer = strs1.Count - 1 To 0 Step -1
						If (Operators.CompareString(strs1(j), Me.TextBox1.Text, False) = 0) Then
							If (Not (Operators.CompareString(strs1(j + 1), "o", False) = 0 Or Operators.CompareString(strs1(j + 1), "n", False) = 0)) Then
								strs1.RemoveAt(j)
								strs1.RemoveAt(j + 1)
								strs1.RemoveAt(j + 2)
							Else
								strs1.RemoveAt(j - 1)
								strs1.RemoveAt(j)
								strs1.RemoveAt(j + 1)
							End If
						End If
					Next

					File.WriteAllLines(Module1.PATHS(1), strs1, Encoding.[Default])
					num2 = num2 + 1
				Loop While num2 <= 2
				strs1 = New List(Of String)(File.ReadAllLines(Module1.PATHS(11), Encoding.[Default]).ToList())
				For k As Integer = strs1.Count - 1 To 0 Step -1
					If (Operators.CompareString(strs1(k), Me.TextBox1.Text, False) = 0) Then
						strs1.RemoveAt(k)
						strs1.RemoveAt(k + 1)
						strs1.RemoveAt(k + 2)
						strs1.RemoveAt(k + 3)
						strs1.RemoveAt(k + 4)
						strs1.RemoveAt(k + 5)
						strs1.RemoveAt(k + 6)
						strs1.RemoveAt(k + 7)
						strs1.RemoveAt(k + 8)
					End If
				Next

				File.WriteAllLines(Module1.PATHS(11), strs1, Encoding.[Default])
				MyProject.Forms.FormPasPas.ChargementBDDlisteleg()
				MyProject.Forms.FormPasPas.ChargementBDDasso()
				MyProject.Forms.FormPasPas.ChargementBDDcal()
				MyProject.Forms.FormPasPas.ChargementBDDrot()
				MyProject.Forms.FormPasPas.Buttonreset.PerformClick()
				Me.Close()
			ElseIf (Operators.CompareString(text, "Renommer", False) = 0) Then
				Try
					Dim strArrays(1) As String
					strArrays = Microsoft.VisualBasic.Strings.Split(Me.TextBox1.Text, "/", -1, CompareMethod.Binary)
					Dim str As String = strArrays(0)
					Dim str1 As String = strArrays(1)
					Dim num3 As Integer = 0
					Do
						Me.contenufichier = File.ReadAllText(Module1.PATHS(num3), Encoding.[Default])
						File.WriteAllText(Module1.PATHS(num3), Me.contenufichier.Replace(str, str1), Encoding.[Default])
						num3 = num3 + 1
					Loop While num3 <= 2
					Me.contenufichier = File.ReadAllText(Module1.PATHS(11), Encoding.[Default])
					File.WriteAllText(Module1.PATHS(11), Me.contenufichier.Replace(str, str1), Encoding.[Default])
					If (File.Exists(String.Concat(Module1.PATHS(13), "\", str, ".png"))) Then
						MyProject.Computer.FileSystem.RenameFile(String.Concat(Module1.PATHS(13), "\", str, ".png"), String.Concat(str1, ".png"))
					End If
					If (File.Exists(String.Concat(Module1.PATHS(12), "\", str, ".txt"))) Then
						MyProject.Computer.FileSystem.RenameFile(String.Concat(Module1.PATHS(12), "\", str, ".txt"), String.Concat(str1, ".txt"))
					End If
					MyProject.Forms.FormPasPas.ChargementBDDlisteleg()
					MyProject.Forms.FormPasPas.ChargementBDDasso()
					MyProject.Forms.FormPasPas.ChargementBDDrot()
					MyProject.Forms.FormPasPas.ChargementBDDcal()
					MyProject.Forms.FormPasPas.Chargement_radiobutton_listeleg()
					MyProject.Forms.FormPasPas.Buttonreset.PerformClick()
					Me.Close()
				Catch exception1 As System.Exception
					ProjectData.SetProjectError(exception1)
					MyProject.Forms.FormPasPas.Msgboxperso("Une erreur est survenue. " & VbCrLf & "Vérifier la syntaxe du champ de saisie et réessayez.", "Erreur")
					ProjectData.ClearProjectError()
				End Try
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

		Private Sub Forminputbox_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim text As String = Me.Button1.Text
			If (Operators.CompareString(text, "Ok", False) = 0) Then
				Me.Label1.Text = ""
				Me.TextBox1.Text = MyProject.Forms.FormPasPas.stringinputbox
				Me.TextBox1.SelectAll()
			ElseIf (Operators.CompareString(text, "Ajouter", False) = 0) Then
				Me.TextBox1.Text = "Nouveau légume"
				Me.TextBox1.SelectAll()
			ElseIf (Operators.CompareString(text, "Supprimer", False) = 0) Then
				Me.TextBox1.Text = "Légume à supprimer"
				Me.TextBox1.SelectAll()
			ElseIf (Operators.CompareString(text, "Renommer", False) = 0) Then
				Me.TextBox1.Text = "Légume à renommer/Nouveau nom"
				Me.TextBox1.SelectAll()
			End If
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputbox))
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			Dim point As System.Drawing.Point = New System.Drawing.Point(66, 70)
			textBox1.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			Dim size As System.Drawing.Size = New System.Drawing.Size(328, 22)
			textBox.Size = size
			Me.TextBox1.TabIndex = 0
			Me.Button1.BackColor = Color.OliveDrab
			Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Button1.FlatAppearance.BorderColor = Color.Green
			Me.Button1.FlatStyle = FlatStyle.Flat
			Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(364, 136)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(86, 23)
			button.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Ok"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Color.Transparent
			Me.Label1.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.Orange
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(66, 32)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(241, 15)
			label.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Entrez le nom du légume à ajouter:"
			Me.AcceptButton = Me.Button1
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.SaddleBrown
			Me.BackgroundImage = Resources.papillon
			Me.BackgroundImageLayout = ImageLayout.None
			size = New System.Drawing.Size(462, 171)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox1)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormInputbox"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Modifier la légende"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
End Namespace