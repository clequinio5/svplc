Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormBDDFICHE
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		Private nomfiche As String

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDDFICHE As SVPLCApplication.FormBDDFICHE = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDDFICHE.Button1_Click)
				If (Me._Button1 IsNot Nothing) Then
					RemoveHandler Me._Button1.Click,  eventHandler
				End If
				Me._Button1 = value
				If (Me._Button1 IsNot Nothing) Then
					AddHandler Me._Button1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ComboBox1 As ComboBox
			Get
				Return Me._ComboBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox1 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formBDDFICHE1 As FormBDDFICHE = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formBDDFICHE1.bddfiche_Load)
			Dim formBDDFICHE2 As FormBDDFICHE = Me
			AddHandler MyBase.FormClosing,  New FormClosingEventHandler(AddressOf formBDDFICHE2.bddfiche_FormClosing)
			Me.InitializeComponent()
		End Sub

		Private Sub bddfiche_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			Module1.loadbddfiche = False
		End Sub

		Private Sub bddfiche_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer = Module1.nbrlegumesbase - 1
			For i As Integer = 0 To num Step 1
				Me.ComboBox1.Items.Add(Module1.listelégumes(i))
			Next

		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim fiche As SVPLCApplication.Fiche = New SVPLCApplication.Fiche()
			Me.nomfiche = Me.ComboBox1.Text
			Dim fiche1 As SVPLCApplication.Fiche = fiche
			fiche1.Text = Me.nomfiche
			fiche1.Label1.Text = Me.nomfiche
			fiche1 = Nothing
			fiche.Show()
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

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBDDFICHE))
			Me.Button1 = New System.Windows.Forms.Button()
			Me.ComboBox1 = New System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			Me.Button1.BackColor = Color.Tan
			Me.Button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0)
			Me.Button1.FlatAppearance.BorderSize = 2
			Me.Button1.FlatStyle = FlatStyle.Flat
			Me.Button1.Font = New System.Drawing.Font("Cooper Black", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			Dim point As System.Drawing.Point = New System.Drawing.Point(189, 20)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			Dim size As System.Drawing.Size = New System.Drawing.Size(48, 27)
			button.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Ok"
			Me.Button1.UseVisualStyleBackColor = False
			Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox1.FormattingEnabled = True
			Dim comboBox1 As System.Windows.Forms.ComboBox = Me.ComboBox1
			point = New System.Drawing.Point(27, 23)
			comboBox1.Location = point
			Me.ComboBox1.MaxLength = 35
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBox1
			size = New System.Drawing.Size(139, 21)
			comboBox.Size = size
			Me.ComboBox1.TabIndex = 1
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.DarkGoldenrod
			size = New System.Drawing.Size(260, 68)
			Me.ClientSize = size
			Me.Controls.Add(Me.ComboBox1)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormBDDFICHE"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Base de données Fiches"
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace