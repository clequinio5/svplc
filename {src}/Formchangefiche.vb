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
	Public Class Formchangefiche
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formchangefiche As SVPLCApplication.Formchangefiche = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formchangefiche.Button1_Click)
				If (Me._Button1 IsNot Nothing) Then
					RemoveHandler Me._Button1.Click,  eventHandler
				End If
				Me._Button1 = value
				If (Me._Button1 IsNot Nothing) Then
					AddHandler Me._Button1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property RichTextBox1 As RichTextBox
			Get
				Return Me._RichTextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Module1.modiffiche = Me.RichTextBox1.Text
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
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formchangefiche))
			Me.Button1 = New System.Windows.Forms.Button()
			Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.SuspendLayout()
			Me.Button1.BackColor = Color.DarkOrange
			Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Button1.FlatAppearance.BorderColor = Color.Goldenrod
			Me.Button1.FlatAppearance.BorderSize = 3
			Me.Button1.FlatStyle = FlatStyle.Flat
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			Dim point As System.Drawing.Point = New System.Drawing.Point(370, 145)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			Dim size As System.Drawing.Size = New System.Drawing.Size(75, 27)
			button.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Ok"
			Me.Button1.UseVisualStyleBackColor = False
			Me.RichTextBox1.BackColor = Color.Wheat
			Dim richTextBox1 As System.Windows.Forms.RichTextBox = Me.RichTextBox1
			point = New System.Drawing.Point(6, 8)
			richTextBox1.Location = point
			Me.RichTextBox1.Name = "RichTextBox1"
			Me.RichTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical
			Dim richTextBox As System.Windows.Forms.RichTextBox = Me.RichTextBox1
			size = New System.Drawing.Size(439, 131)
			richTextBox.Size = size
			Me.RichTextBox1.TabIndex = 1
			Me.RichTextBox1.Text = ""
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.YellowGreen
			size = New System.Drawing.Size(451, 178)
			Me.ClientSize = size
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formchangefiche"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Modifier la fiche"
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace