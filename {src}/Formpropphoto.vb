Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class Formpropphoto
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("lblTitre")>
		Private _lblTitre As Label

		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		<AccessedThroughProperty("lbl1")>
		Private _lbl1 As Label

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		<AccessedThroughProperty("btnOk")>
		Private _btnOk As Button

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		Private Overridable Property btnOk As Button
			Get
				Return Me._btnOk
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formpropphoto As SVPLCApplication.Formpropphoto = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formpropphoto.btnOk_Click)
				If (Me._btnOk IsNot Nothing) Then
					RemoveHandler Me._btnOk.Click,  eventHandler
				End If
				Me._btnOk = value
				If (Me._btnOk IsNot Nothing) Then
					AddHandler Me._btnOk.Click,  eventHandler
				End If
			End Set
		End Property

		Private Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label1 = value
			End Set
		End Property

		Private Overridable Property lbl1 As Label
			Get
				Return Me._lbl1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lbl1 = value
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

		Friend Overridable Property PictureBox1 As PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		Private Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		Private Overridable Property TextBox2 As TextBox
			Get
				Return Me._TextBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		Private Overridable Property TextBox3 As TextBox
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
			Dim formpropphoto1 As Formpropphoto = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formpropphoto1.Formpropphoto_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.titrephot = Me.TextBox3.Text
			MyProject.Forms.FormPasPas.datephot = Me.TextBox1.Text
			MyProject.Forms.FormPasPas.comphot = Me.TextBox2.Text
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

		Private Sub Formpropphoto_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.TextBox3.Text = MyProject.Forms.FormPasPas.titrephot
			Me.TextBox1.Text = MyProject.Forms.FormPasPas.datephot
			Me.TextBox2.Text = MyProject.Forms.FormPasPas.comphot
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formpropphoto))
			Me.lblTitre = New System.Windows.Forms.Label()
			Me.TextBox3 = New System.Windows.Forms.TextBox()
			Me.lbl1 = New System.Windows.Forms.Label()
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.TextBox2 = New System.Windows.Forms.TextBox()
			Me.btnOk = New System.Windows.Forms.Button()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label As System.Windows.Forms.Label = Me.lblTitre
			Dim point As System.Drawing.Point = New System.Drawing.Point(29, 39)
			label.Location = point
			Dim label1 As System.Windows.Forms.Label = Me.lblTitre
			Dim padding As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
			label1.Margin = padding
			Me.lblTitre.Name = "lblTitre"
			Dim label2 As System.Windows.Forms.Label = Me.lblTitre
			Dim size As System.Drawing.Size = New System.Drawing.Size(49, 20)
			label2.Size = size
			Me.lblTitre.TabIndex = 0
			Me.lblTitre.Text = "Titre"
			Dim textBox3 As System.Windows.Forms.TextBox = Me.TextBox3
			point = New System.Drawing.Point(146, 37)
			textBox3.Location = point
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox3
			padding = New System.Windows.Forms.Padding(4)
			textBox.Margin = padding
			Me.TextBox3.Name = "TextBox3"
			Dim textBox31 As System.Windows.Forms.TextBox = Me.TextBox3
			size = New System.Drawing.Size(276, 22)
			textBox31.Size = size
			Me.TextBox3.TabIndex = 1
			Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label3 As System.Windows.Forms.Label = Me.lbl1
			point = New System.Drawing.Point(29, 84)
			label3.Location = point
			Dim label4 As System.Windows.Forms.Label = Me.lbl1
			padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
			label4.Margin = padding
			Me.lbl1.Name = "lbl1"
			Dim label5 As System.Windows.Forms.Label = Me.lbl1
			size = New System.Drawing.Size(99, 20)
			label5.Size = size
			Me.lbl1.TabIndex = 3
			Me.lbl1.Text = "Date"
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			point = New System.Drawing.Point(146, 81)
			textBox1.Location = point
			Dim textBox11 As System.Windows.Forms.TextBox = Me.TextBox1
			padding = New System.Windows.Forms.Padding(4)
			textBox11.Margin = padding
			Me.TextBox1.Name = "TextBox1"
			Dim textBox12 As System.Windows.Forms.TextBox = Me.TextBox1
			size = New System.Drawing.Size(276, 22)
			textBox12.Size = size
			Me.TextBox1.TabIndex = 2
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim label11 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(29, 137)
			label11.Location = point
			Dim label12 As System.Windows.Forms.Label = Me.Label1
			padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
			label12.Margin = padding
			Me.Label1.Name = "Label1"
			Dim label13 As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(127, 20)
			label13.Size = size
			Me.Label1.TabIndex = 5
			Me.Label1.Text = "Commentaires"
			Me.TextBox2.AcceptsReturn = True
			Me.TextBox2.AcceptsTab = True
			Dim textBox2 As System.Windows.Forms.TextBox = Me.TextBox2
			point = New System.Drawing.Point(146, 134)
			textBox2.Location = point
			Dim textBox21 As System.Windows.Forms.TextBox = Me.TextBox2
			padding = New System.Windows.Forms.Padding(4)
			textBox21.Margin = padding
			Me.TextBox2.Multiline = True
			Me.TextBox2.Name = "TextBox2"
			Me.TextBox2.ScrollBars = ScrollBars.Vertical
			Dim textBox22 As System.Windows.Forms.TextBox = Me.TextBox2
			size = New System.Drawing.Size(433, 142)
			textBox22.Size = size
			Me.TextBox2.TabIndex = 4
			Me.btnOk.Anchor = AnchorStyles.Top Or AnchorStyles.Right
			Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.btnOk.ForeColor = SystemColors.ControlText
			Dim button As System.Windows.Forms.Button = Me.btnOk
			point = New System.Drawing.Point(480, 295)
			button.Location = point
			Dim button1 As System.Windows.Forms.Button = Me.btnOk
			padding = New System.Windows.Forms.Padding(4)
			button1.Margin = padding
			Me.btnOk.Name = "btnOk"
			Dim button2 As System.Windows.Forms.Button = Me.btnOk
			size = New System.Drawing.Size(99, 27)
			button2.Size = size
			Me.btnOk.TabIndex = 6
			Me.btnOk.Text = "Ok"
			Me.btnOk.UseVisualStyleBackColor = True
			Me.PictureBox1.BackColor = Color.Transparent
			Me.PictureBox1.BackgroundImage = Resources.Appareil_photo
			Me.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(408, -13)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(203, 157)
			pictureBox.Size = size
			Me.PictureBox1.TabIndex = 7
			Me.PictureBox1.TabStop = False
			Me.AcceptButton = Me.btnOk
			Me.AutoScaleDimensions = New SizeF(8!, 16!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.Silver
			Me.BackgroundImageLayout = ImageLayout.None
			size = New System.Drawing.Size(598, 345)
			Me.ClientSize = size
			Me.Controls.Add(Me.btnOk)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.lbl1)
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.lblTitre)
			Me.Controls.Add(Me.PictureBox1)
			Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.ForeColor = SystemColors.HotTrack
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			padding = New System.Windows.Forms.Padding(4)
			Me.Margin = padding
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formpropphoto"
			Me.Text = "Propriétés de la photo"
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
End Namespace