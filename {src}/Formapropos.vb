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
	Public Class Formapropos
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("LinkLabel1")>
		Private _LinkLabel1 As LinkLabel

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Labelvers")>
		Private _Labelvers As Label

		<AccessedThroughProperty("Labelutil")>
		Private _Labelutil As Label

		<AccessedThroughProperty("Labellic")>
		Private _Labellic As Label

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

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

		Friend Overridable Property Labellic As Label
			Get
				Return Me._Labellic
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labellic = value
			End Set
		End Property

		Friend Overridable Property Labelutil As Label
			Get
				Return Me._Labelutil
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelutil = value
			End Set
		End Property

		Friend Overridable Property Labelvers As Label
			Get
				Return Me._Labelvers
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Labelvers = value
			End Set
		End Property

		Friend Overridable Property LinkLabel1 As LinkLabel
			Get
				Return Me._LinkLabel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As LinkLabel)
				Me._LinkLabel1 = value
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

		Friend Overridable Property TextBox2 As TextBox
			Get
				Return Me._TextBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		Friend Overridable Property TextBox3 As TextBox
			Get
				Return Me._TextBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formapropo As Formapropos = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formapropo.Formapropos_Load)
			Dim formapropo1 As Formapropos = Me
			AddHandler MyBase.FormClosing,  New FormClosingEventHandler(AddressOf formapropo1.Formapropos_FormClosing)
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

		Private Sub Formapropos_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
			Module1.loadapropos = False
		End Sub

		Private Sub Formapropos_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not MyProject.Forms.FormPasPas.activation) Then
				Me.TextBox1.Visible = False
				Me.TextBox2.Visible = False
				Me.TextBox3.Visible = False
				Me.Labellic.Visible = False
				Me.Labelutil.Visible = False
				Me.Labelvers.Visible = False
				Dim label As System.Windows.Forms.Label = New System.Windows.Forms.Label() With
				{
					.Location = New Point(21, 110),
					.Size = New System.Drawing.Size(437, 60),
					.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold),
					.ForeColor = SystemColors.HotTrack,
					.Text = "La version de SVPLC que vous utilisez est bridée. Pour accéder à l'intégralité de ses fonctions, vous devez effectuer un don en échange duquel des identifiants vous seront donnés. Pour vous enregistrer, merci de cliquez sur 'Soutenir' dans le menu de la fenêtre principale et de suivre les indications.",
					.AutoSize = False
				}
				Me.Controls.Add(label)
			Else
				Me.TextBox1.Text = MyProject.Forms.FormPasPas.version
				Me.TextBox2.Text = MyProject.Forms.FormPasPas.util
				Me.TextBox3.Text = MyProject.Forms.FormPasPas.activcode
			End If
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formapropos))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Labelvers = New System.Windows.Forms.Label()
			Me.Labelutil = New System.Windows.Forms.Label()
			Me.Labellic = New System.Windows.Forms.Label()
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.TextBox2 = New System.Windows.Forms.TextBox()
			Me.TextBox3 = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = SystemColors.HotTrack
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(21, 19)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(416, 39)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Pour signaler un bug, faire une remarque ou une suggestion, merci de contacter l'auteur à l'adresse:"
			Me.LinkLabel1.AutoSize = True
			Me.LinkLabel1.ForeColor = Color.Red
			Me.LinkLabel1.LinkColor = Color.Red
			Dim linkLabel1 As System.Windows.Forms.LinkLabel = Me.LinkLabel1
			point = New System.Drawing.Point(165, 70)
			linkLabel1.Location = point
			Me.LinkLabel1.Name = "LinkLabel1"
			Dim linkLabel As System.Windows.Forms.LinkLabel = Me.LinkLabel1
			size = New System.Drawing.Size(101, 13)
			linkLabel.Size = size
			Me.LinkLabel1.TabIndex = 1
			Me.LinkLabel1.TabStop = True
			Me.LinkLabel1.Text = "kikil592@gmail.com"
			Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = SystemColors.HotTrack
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(165, 190)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(179, 23)
			label31.Size = size
			Me.Label3.TabIndex = 3
			Me.Label3.Text = "SVPLC est un programme protégé."
			Me.Labelvers.AutoSize = True
			Me.Labelvers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelvers.ForeColor = SystemColors.HotTrack
			Dim labelvers As System.Windows.Forms.Label = Me.Labelvers
			point = New System.Drawing.Point(21, 103)
			labelvers.Location = point
			Me.Labelvers.Name = "Labelvers"
			Dim labelvers1 As System.Windows.Forms.Label = Me.Labelvers
			size = New System.Drawing.Size(59, 15)
			labelvers1.Size = size
			Me.Labelvers.TabIndex = 4
			Me.Labelvers.Text = "Version:"
			Me.Labelutil.AutoSize = True
			Me.Labelutil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labelutil.ForeColor = SystemColors.HotTrack
			Dim labelutil As System.Windows.Forms.Label = Me.Labelutil
			point = New System.Drawing.Point(21, 130)
			labelutil.Location = point
			Me.Labelutil.Name = "Labelutil"
			Dim labelutil1 As System.Windows.Forms.Label = Me.Labelutil
			size = New System.Drawing.Size(77, 15)
			labelutil1.Size = size
			Me.Labelutil.TabIndex = 5
			Me.Labelutil.Text = "Utilisateur:"
			Me.Labellic.AutoSize = True
			Me.Labellic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Labellic.ForeColor = SystemColors.HotTrack
			Dim labellic As System.Windows.Forms.Label = Me.Labellic
			point = New System.Drawing.Point(21, 158)
			labellic.Location = point
			Me.Labellic.Name = "Labellic"
			Dim labellic1 As System.Windows.Forms.Label = Me.Labellic
			size = New System.Drawing.Size(94, 15)
			labellic1.Size = size
			Me.Labellic.TabIndex = 6
			Me.Labellic.Text = "Code license:"
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			point = New System.Drawing.Point(168, 102)
			textBox1.Location = point
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.[ReadOnly] = True
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			size = New System.Drawing.Size(244, 20)
			textBox.Size = size
			Me.TextBox1.TabIndex = 7
			Dim textBox2 As System.Windows.Forms.TextBox = Me.TextBox2
			point = New System.Drawing.Point(168, 130)
			textBox2.Location = point
			Me.TextBox2.Name = "TextBox2"
			Me.TextBox2.[ReadOnly] = True
			Dim textBox21 As System.Windows.Forms.TextBox = Me.TextBox2
			size = New System.Drawing.Size(244, 20)
			textBox21.Size = size
			Me.TextBox2.TabIndex = 8
			Dim textBox3 As System.Windows.Forms.TextBox = Me.TextBox3
			point = New System.Drawing.Point(168, 157)
			textBox3.Location = point
			Me.TextBox3.Name = "TextBox3"
			Me.TextBox3.[ReadOnly] = True
			Dim textBox31 As System.Windows.Forms.TextBox = Me.TextBox3
			size = New System.Drawing.Size(244, 20)
			textBox31.Size = size
			Me.TextBox3.TabIndex = 9
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = SystemColors.ActiveCaptionText
			size = New System.Drawing.Size(461, 215)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Labellic)
			Me.Controls.Add(Me.Labelutil)
			Me.Controls.Add(Me.Labelvers)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.LinkLabel1)
			Me.Controls.Add(Me.Label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formapropos"
			Me.Text = "A propos de..."
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
End Namespace