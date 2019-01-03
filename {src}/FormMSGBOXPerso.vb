Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Media
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormMSGBOXPerso
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formMSGBOXPerso As SVPLCApplication.FormMSGBOXPerso = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMSGBOXPerso.Button1_Click)
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
				Dim formMSGBOXPerso As SVPLCApplication.FormMSGBOXPerso = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formMSGBOXPerso.Button2_Click)
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

		Friend Overridable Property Label4 As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label4 = value
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

		Friend Overridable Property PictureBox2 As PictureBox
			Get
				Return Me._PictureBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formMSGBOXPerso1 As FormMSGBOXPerso = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formMSGBOXPerso1.Form24_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Private Sub Buttonclose_Click(ByVal sender As Object, ByVal e As EventArgs)
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

		Private Sub Form24_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.Label1.Text = MyProject.Forms.FormPasPas.msgboxmess
			SystemSounds.Hand.Play()
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMSGBOXPerso))
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.PictureBox2 = New System.Windows.Forms.PictureBox()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Button2 = New System.Windows.Forms.Button()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.Image = Resources.animals_ladybug3
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			Dim point As System.Drawing.Point = New System.Drawing.Point(12, 12)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
			Dim size As System.Drawing.Size = New System.Drawing.Size(50, 50)
			pictureBox.Size = size
			Me.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.PictureBox2.Image = Resources.animals_ladybug2
			Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox2
			point = New System.Drawing.Point(347, 116)
			pictureBox2.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox21 As System.Windows.Forms.PictureBox = Me.PictureBox2
			size = New System.Drawing.Size(50, 50)
			pictureBox21.Size = size
			Me.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox2.TabIndex = 1
			Me.PictureBox2.TabStop = False
			Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.DarkRed
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(68, 12)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(273, 154)
			label.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Oups! Ceci est un messagebox d'erreur ou d'information"
			Me.Label1.TextAlign = ContentAlignment.MiddleCenter
			Me.Button1.BackColor = Color.SaddleBrown
			Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Button1.FlatAppearance.BorderColor = Color.DarkRed
			Me.Button1.FlatAppearance.BorderSize = 2
			Me.Button1.FlatStyle = FlatStyle.Flat
			Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Color.Black
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(174, 177)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(67, 26)
			button.Size = size
			Me.Button1.TabIndex = 3
			Me.Button1.Text = "Ok"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Label2.AutoSize = True
			Me.Label2.Font = New System.Drawing.Font("Cooper Black", 24!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Color.DarkRed
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(362, 26)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(25, 36)
			label21.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "!"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New System.Drawing.Font("Cooper Black", 24!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Color.DarkRed
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(25, 88)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(25, 36)
			label31.Size = size
			Me.Label3.TabIndex = 5
			Me.Label3.Text = "!"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New System.Drawing.Font("Cooper Black", 24!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Color.DarkRed
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(291, 166)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(25, 36)
			label41.Size = size
			Me.Label4.TabIndex = 6
			Me.Label4.Text = "!"
			Me.Button2.BackgroundImage = Resources.delmarron
			Me.Button2.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
			Me.Button2.FlatStyle = FlatStyle.Flat
			Dim button2 As System.Windows.Forms.Button = Me.Button2
			point = New System.Drawing.Point(360, 37)
			button2.Location = point
			Me.Button2.Name = "Button2"
			Dim button21 As System.Windows.Forms.Button = Me.Button2
			size = New System.Drawing.Size(27, 25)
			button21.Size = size
			Me.Button2.TabIndex = 7
			Me.Button2.UseVisualStyleBackColor = True
			Me.AcceptButton = Me.Button1
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = SystemColors.ActiveCaptionText
			Me.CancelButton = Me.Button2
			size = New System.Drawing.Size(409, 215)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.PictureBox2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Button2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormMSGBOXPerso"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Form24"
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
End Namespace