Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormBienvenue
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		<AccessedThroughProperty("PictureBox6")>
		Private _PictureBox6 As PictureBox

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBienvenue As SVPLCApplication.FormBienvenue = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBienvenue.Button1_Click)
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

		Friend Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label2 = value
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

		Friend Overridable Property PictureBox3 As PictureBox
			Get
				Return Me._PictureBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		Friend Overridable Property PictureBox4 As PictureBox
			Get
				Return Me._PictureBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		Friend Overridable Property PictureBox5 As PictureBox
			Get
				Return Me._PictureBox5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox5 = value
			End Set
		End Property

		Friend Overridable Property PictureBox6 As PictureBox
			Get
				Return Me._PictureBox6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox6 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
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

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBienvenue))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.PictureBox3 = New System.Windows.Forms.PictureBox()
			Me.PictureBox4 = New System.Windows.Forms.PictureBox()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.PictureBox2 = New System.Windows.Forms.PictureBox()
			Me.PictureBox5 = New System.Windows.Forms.PictureBox()
			Me.PictureBox6 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.PictureBox3, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox4, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox5, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox6, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New System.Drawing.Font("Cooper Black", 20.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.Green
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(74, 26)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(335, 31)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Bienvenue dans SVPLC!"
			Me.Label2.BackColor = Color.Transparent
			Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Color.Green
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(76, 72)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(351, 329)
			label21.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = componentResourceManager.GetString("Label2.Text")
			Me.Label2.TextAlign = ContentAlignment.MiddleCenter
			Me.Button1.BackColor = Color.Peru
			Me.Button1.FlatAppearance.BorderColor = Color.SaddleBrown
			Me.Button1.FlatAppearance.BorderSize = 3
			Me.Button1.FlatStyle = FlatStyle.Flat
			Me.Button1.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Color.Green
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(170, 421)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(162, 47)
			button.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Découvrir le logiciel"
			Me.Button1.UseVisualStyleBackColor = False
			Me.PictureBox3.Image = Resources.Abricotier
			Dim pictureBox3 As System.Windows.Forms.PictureBox = Me.PictureBox3
			point = New System.Drawing.Point(392, 223)
			pictureBox3.Location = point
			Me.PictureBox3.Name = "PictureBox3"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox3
			size = New System.Drawing.Size(70, 70)
			pictureBox.Size = size
			Me.PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox3.TabIndex = 5
			Me.PictureBox3.TabStop = False
			Me.PictureBox4.BackgroundImageLayout = ImageLayout.None
			Me.PictureBox4.Image = Resources.animals_ladybug2
			Dim pictureBox4 As System.Windows.Forms.PictureBox = Me.PictureBox4
			point = New System.Drawing.Point(20, 60)
			pictureBox4.Location = point
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox41 As System.Windows.Forms.PictureBox = Me.PictureBox4
			size = New System.Drawing.Size(50, 50)
			pictureBox41.Size = size
			Me.PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox4.TabIndex = 6
			Me.PictureBox4.TabStop = False
			Me.PictureBox1.Image = Resources.Arbres_fruitiers
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(372, 378)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox11 As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(70, 70)
			pictureBox11.Size = size
			Me.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox1.TabIndex = 7
			Me.PictureBox1.TabStop = False
			Me.PictureBox2.Image = Resources.Calendula
			Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox2
			point = New System.Drawing.Point(0, 239)
			pictureBox2.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox21 As System.Windows.Forms.PictureBox = Me.PictureBox2
			size = New System.Drawing.Size(70, 70)
			pictureBox21.Size = size
			Me.PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox2.TabIndex = 8
			Me.PictureBox2.TabStop = False
			Me.PictureBox5.Image = Resources.Laitue
			Dim pictureBox5 As System.Windows.Forms.PictureBox = Me.PictureBox5
			point = New System.Drawing.Point(56, 398)
			pictureBox5.Location = point
			Me.PictureBox5.Name = "PictureBox5"
			Dim pictureBox51 As System.Windows.Forms.PictureBox = Me.PictureBox5
			size = New System.Drawing.Size(70, 70)
			pictureBox51.Size = size
			Me.PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox5.TabIndex = 9
			Me.PictureBox5.TabStop = False
			Me.PictureBox6.Image = Resources.Piment
			Dim pictureBox6 As System.Windows.Forms.PictureBox = Me.PictureBox6
			point = New System.Drawing.Point(415, 12)
			pictureBox6.Location = point
			Me.PictureBox6.Name = "PictureBox6"
			Dim pictureBox61 As System.Windows.Forms.PictureBox = Me.PictureBox6
			size = New System.Drawing.Size(70, 70)
			pictureBox61.Size = size
			Me.PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize
			Me.PictureBox6.TabIndex = 10
			Me.PictureBox6.TabStop = False
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.YellowGreen
			Me.BackgroundImageLayout = ImageLayout.None
			size = New System.Drawing.Size(489, 503)
			Me.ClientSize = size
			Me.Controls.Add(Me.PictureBox6)
			Me.Controls.Add(Me.PictureBox5)
			Me.Controls.Add(Me.PictureBox2)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.PictureBox4)
			Me.Controls.Add(Me.PictureBox3)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "FormBienvenue"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Bienvenue dans SVPLC!"
			Me.TopMost = True
			DirectCast(Me.PictureBox3, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox4, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox5, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox6, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub
	End Class
End Namespace