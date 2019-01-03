Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class Formajoutbouton
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("RadioButton1")>
		Private _RadioButton1 As RadioButton

		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("OpenFileDialog1")>
		Private _OpenFileDialog1 As OpenFileDialog

		Private nomfichier As String

		Private imagetraitee As Image

		Private fs As FileStream

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formajoutbouton As SVPLCApplication.Formajoutbouton = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formajoutbouton.Button1_Click)
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
				Dim formajoutbouton As SVPLCApplication.Formajoutbouton = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formajoutbouton.Button2_Click)
				If (Me._Button2 IsNot Nothing) Then
					RemoveHandler Me._Button2.Click,  eventHandler
				End If
				Me._Button2 = value
				If (Me._Button2 IsNot Nothing) Then
					AddHandler Me._Button2.Click,  eventHandler
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

		Friend Overridable Property OpenFileDialog1 As OpenFileDialog
			Get
				Return Me._OpenFileDialog1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As OpenFileDialog)
				Me._OpenFileDialog1 = value
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

		Friend Overridable Property RadioButton1 As RadioButton
			Get
				Return Me._RadioButton1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As RadioButton)
				Me._RadioButton1 = value
			End Set
		End Property

		Friend Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formajoutbouton As SVPLCApplication.Formajoutbouton = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formajoutbouton.TextBox1_TextChanged)
				If (Me._TextBox1 IsNot Nothing) Then
					RemoveHandler Me._TextBox1.TextChanged,  eventHandler
				End If
				Me._TextBox1 = value
				If (Me._TextBox1 IsNot Nothing) Then
					AddHandler Me._TextBox1.TextChanged,  eventHandler
				End If
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formajoutbouton1 As Formajoutbouton = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formajoutbouton1.Formajoutbouton_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
				Me.nomfichier = Me.OpenFileDialog1.FileName
				If (Me.nomfichier IsNot Nothing) Then
					Me.fs = File.OpenRead(Me.nomfichier)
					Me.imagetraitee = Image.FromStream(Me.fs)
					Me.RadioButton1.BackgroundImage = Me.imagetraitee
					Me.fs.Close()
				End If
			End If
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.imgtoadd = Me.nomfichier
			MyProject.Forms.FormPasPas.txttoadd = Me.TextBox1.Text
			Me.Close()
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

		Private Sub Formajoutbouton_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.Panel1.Enabled = False
			Me.nomfichier = ""
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formajoutbouton))
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.RadioButton1 = New System.Windows.Forms.RadioButton()
			Me.Button2 = New System.Windows.Forms.Button()
			Me.Panel1 = New System.Windows.Forms.Panel()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.OpenFileDialog1 = New OpenFileDialog()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			Dim point As System.Drawing.Point = New System.Drawing.Point(77, 30)
			textBox1.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			Dim size As System.Drawing.Size = New System.Drawing.Size(222, 22)
			textBox.Size = size
			Me.TextBox1.TabIndex = 0
			Me.Label1.AutoSize = True
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(25, 33)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(40, 16)
			label.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Nom:"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(25, 64)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(46, 16)
			label21.Size = size
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "Photo:"
			Me.Button1.BackColor = Color.ForestGreen
			Me.Button1.FlatStyle = FlatStyle.Flat
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(77, 61)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(75, 23)
			button.Size = size
			Me.Button1.TabIndex = 3
			Me.Button1.Text = "Parcourir..."
			Me.Button1.UseVisualStyleBackColor = False
			Me.RadioButton1.Appearance = Appearance.Button
			Me.RadioButton1.BackgroundImageLayout = ImageLayout.Stretch
			Dim radioButton1 As System.Windows.Forms.RadioButton = Me.RadioButton1
			point = New System.Drawing.Point(3, 3)
			radioButton1.Location = point
			Me.RadioButton1.Name = "RadioButton1"
			Dim radioButton As System.Windows.Forms.RadioButton = Me.RadioButton1
			size = New System.Drawing.Size(70, 70)
			radioButton.Size = size
			Me.RadioButton1.TabIndex = 0
			Me.RadioButton1.TabStop = True
			Me.RadioButton1.Text = "Legume"
			Me.RadioButton1.TextAlign = ContentAlignment.BottomCenter
			Me.RadioButton1.UseVisualStyleBackColor = True
			Me.Button2.BackColor = Color.ForestGreen
			Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Button2.FlatStyle = FlatStyle.Flat
			Dim button2 As System.Windows.Forms.Button = Me.Button2
			point = New System.Drawing.Point(395, 107)
			button2.Location = point
			Me.Button2.Name = "Button2"
			Dim button21 As System.Windows.Forms.Button = Me.Button2
			size = New System.Drawing.Size(75, 23)
			button21.Size = size
			Me.Button2.TabIndex = 5
			Me.Button2.Text = "Ajouter"
			Me.Button2.UseVisualStyleBackColor = False
			Me.Panel1.BorderStyle = BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.RadioButton1)
			Dim panel1 As System.Windows.Forms.Panel = Me.Panel1
			point = New System.Drawing.Point(392, 23)
			panel1.Location = point
			Me.Panel1.Name = "Panel1"
			Dim panel As System.Windows.Forms.Panel = Me.Panel1
			size = New System.Drawing.Size(78, 78)
			panel.Size = size
			Me.Panel1.TabIndex = 6
			Me.Label3.AutoSize = True
			Me.Label3.ForeColor = Color.FromArgb(64, 64, 64)
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(392, 4)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(44, 13)
			label31.Size = size
			Me.Label3.TabIndex = 7
			Me.Label3.Text = "Aperçu:"
			Me.OpenFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.SteelBlue
			Me.BackgroundImageLayout = ImageLayout.None
			size = New System.Drawing.Size(525, 142)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox1)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formajoutbouton"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Ajouter un bouton"
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.RadioButton1.Text = Me.TextBox1.Text
		End Sub
	End Class
End Namespace