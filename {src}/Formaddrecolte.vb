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
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class Formaddrecolte
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		<AccessedThroughProperty("TextBox7")>
		Private _TextBox7 As TextBox

		<AccessedThroughProperty("TextBox8")>
		Private _TextBox8 As TextBox

		<AccessedThroughProperty("TextBox9")>
		Private _TextBox9 As TextBox

		<AccessedThroughProperty("TextBox10")>
		Private _TextBox10 As TextBox

		<AccessedThroughProperty("TextBox11")>
		Private _TextBox11 As TextBox

		<AccessedThroughProperty("TextBox12")>
		Private _TextBox12 As TextBox

		<AccessedThroughProperty("TextBox13")>
		Private _TextBox13 As TextBox

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		<AccessedThroughProperty("ComboBox3")>
		Private _ComboBox3 As ComboBox

		<AccessedThroughProperty("ComboBox4")>
		Private _ComboBox4 As ComboBox

		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

		<AccessedThroughProperty("Label15")>
		Private _Label15 As Label

		<AccessedThroughProperty("Label16")>
		Private _Label16 As Label

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.Button1_Click)
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

		Friend Overridable Property ComboBox2 As ComboBox
			Get
				Return Me._ComboBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox2 = value
			End Set
		End Property

		Friend Overridable Property ComboBox3 As ComboBox
			Get
				Return Me._ComboBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox3 = value
			End Set
		End Property

		Friend Overridable Property ComboBox4 As ComboBox
			Get
				Return Me._ComboBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Me._ComboBox4 = value
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

		Friend Overridable Property Label10 As Label
			Get
				Return Me._Label10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label10 = value
			End Set
		End Property

		Friend Overridable Property Label11 As Label
			Get
				Return Me._Label11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label11 = value
			End Set
		End Property

		Friend Overridable Property Label12 As Label
			Get
				Return Me._Label12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label12 = value
			End Set
		End Property

		Friend Overridable Property Label13 As Label
			Get
				Return Me._Label13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label13 = value
			End Set
		End Property

		Friend Overridable Property Label14 As Label
			Get
				Return Me._Label14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label14 = value
			End Set
		End Property

		Friend Overridable Property Label15 As Label
			Get
				Return Me._Label15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label15 = value
			End Set
		End Property

		Friend Overridable Property Label16 As Label
			Get
				Return Me._Label16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label16 = value
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

		Friend Overridable Property Label5 As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label5 = value
			End Set
		End Property

		Friend Overridable Property Label6 As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label6 = value
			End Set
		End Property

		Friend Overridable Property Label7 As Label
			Get
				Return Me._Label7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label7 = value
			End Set
		End Property

		Friend Overridable Property Label8 As Label
			Get
				Return Me._Label8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label8 = value
			End Set
		End Property

		Friend Overridable Property Label9 As Label
			Get
				Return Me._Label9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._Label9 = value
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

		Friend Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		Friend Overridable Property TextBox10 As TextBox
			Get
				Return Me._TextBox10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.TextBox10_Leave)
				If (Me._TextBox10 IsNot Nothing) Then
					RemoveHandler Me._TextBox10.Leave,  eventHandler
				End If
				Me._TextBox10 = value
				If (Me._TextBox10 IsNot Nothing) Then
					AddHandler Me._TextBox10.Leave,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox11 As TextBox
			Get
				Return Me._TextBox11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.TextBox11_Leave)
				If (Me._TextBox11 IsNot Nothing) Then
					RemoveHandler Me._TextBox11.Leave,  eventHandler
				End If
				Me._TextBox11 = value
				If (Me._TextBox11 IsNot Nothing) Then
					AddHandler Me._TextBox11.Leave,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox12 As TextBox
			Get
				Return Me._TextBox12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.TextBox12_Leave)
				If (Me._TextBox12 IsNot Nothing) Then
					RemoveHandler Me._TextBox12.Leave,  eventHandler
				End If
				Me._TextBox12 = value
				If (Me._TextBox12 IsNot Nothing) Then
					AddHandler Me._TextBox12.Leave,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox13 As TextBox
			Get
				Return Me._TextBox13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox13 = value
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

		Friend Overridable Property TextBox4 As TextBox
			Get
				Return Me._TextBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.TextBox4_Leave)
				If (Me._TextBox4 IsNot Nothing) Then
					RemoveHandler Me._TextBox4.Leave,  eventHandler
				End If
				Me._TextBox4 = value
				If (Me._TextBox4 IsNot Nothing) Then
					AddHandler Me._TextBox4.Leave,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox5 As TextBox
			Get
				Return Me._TextBox5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox5 = value
			End Set
		End Property

		Friend Overridable Property TextBox6 As TextBox
			Get
				Return Me._TextBox6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.TextBox6_Leave)
				If (Me._TextBox6 IsNot Nothing) Then
					RemoveHandler Me._TextBox6.Leave,  eventHandler
				End If
				Me._TextBox6 = value
				If (Me._TextBox6 IsNot Nothing) Then
					AddHandler Me._TextBox6.Leave,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox7 As TextBox
			Get
				Return Me._TextBox7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Me._TextBox7 = value
			End Set
		End Property

		Friend Overridable Property TextBox8 As TextBox
			Get
				Return Me._TextBox8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.TextBox8_Leave)
				If (Me._TextBox8 IsNot Nothing) Then
					RemoveHandler Me._TextBox8.Leave,  eventHandler
				End If
				Me._TextBox8 = value
				If (Me._TextBox8 IsNot Nothing) Then
					AddHandler Me._TextBox8.Leave,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox9 As TextBox
			Get
				Return Me._TextBox9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddrecolte As SVPLCApplication.Formaddrecolte = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddrecolte.TextBox9_Leave)
				If (Me._TextBox9 IsNot Nothing) Then
					RemoveHandler Me._TextBox9.Leave,  eventHandler
				End If
				Me._TextBox9 = value
				If (Me._TextBox9 IsNot Nothing) Then
					AddHandler Me._TextBox9.Leave,  eventHandler
				End If
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formaddrecolte1 As Formaddrecolte = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formaddrecolte1.Formaddrecolte_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.Recoltedata(0) = Me.TextBox1.Text
			MyProject.Forms.FormPasPas.Recoltedata(1) = Me.TextBox2.Text
			MyProject.Forms.FormPasPas.Recoltedata(2) = Me.TextBox3.Text
			MyProject.Forms.FormPasPas.Recoltedata(3) = String.Concat(Me.TextBox4.Text, "|", Me.ComboBox1.Text)
			MyProject.Forms.FormPasPas.Recoltedata(4) = Me.TextBox5.Text
			MyProject.Forms.FormPasPas.Recoltedata(5) = String.Concat(Me.TextBox6.Text, "|", Me.ComboBox2.Text)
			MyProject.Forms.FormPasPas.Recoltedata(6) = Me.TextBox7.Text
			MyProject.Forms.FormPasPas.Recoltedata(7) = Me.TextBox8.Text
			MyProject.Forms.FormPasPas.Recoltedata(8) = String.Concat(Me.TextBox9.Text, "|", Me.ComboBox3.Text)
			MyProject.Forms.FormPasPas.Recoltedata(9) = Me.TextBox10.Text
			MyProject.Forms.FormPasPas.Recoltedata(10) = String.Concat(Me.TextBox11.Text, "|", Me.ComboBox4.Text)
			MyProject.Forms.FormPasPas.Recoltedata(11) = Me.TextBox12.Text
			MyProject.Forms.FormPasPas.Recoltedata(12) = Me.TextBox13.Text
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

		Private Sub Formaddrecolte_Load(ByVal sender As Object, ByVal e As EventArgs)
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
			Me.TextBox1.Text = MyProject.Forms.FormPasPas.Recoltedata(0)
			Me.TextBox2.Text = MyProject.Forms.FormPasPas.Recoltedata(1)
			Me.TextBox3.Text = MyProject.Forms.FormPasPas.Recoltedata(2)
			Me.TextBox4.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 0)
			Me.ComboBox1.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(3), 1)
			Me.TextBox5.Text = MyProject.Forms.FormPasPas.Recoltedata(4)
			Me.TextBox6.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(5), 0)
			Me.ComboBox2.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(5), 1)
			Me.TextBox7.Text = MyProject.Forms.FormPasPas.Recoltedata(6)
			Me.TextBox8.Text = MyProject.Forms.FormPasPas.Recoltedata(7)
			Me.TextBox9.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 0)
			Me.ComboBox3.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(8), 1)
			Me.TextBox10.Text = MyProject.Forms.FormPasPas.Recoltedata(9)
			Me.TextBox11.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 0)
			Me.ComboBox4.Text = Me.splitxt(MyProject.Forms.FormPasPas.Recoltedata(10), 1)
			Me.TextBox12.Text = MyProject.Forms.FormPasPas.Recoltedata(11)
			Me.TextBox13.Text = MyProject.Forms.FormPasPas.Recoltedata(12)
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formaddrecolte))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Label5 = New System.Windows.Forms.Label()
			Me.Label6 = New System.Windows.Forms.Label()
			Me.Label7 = New System.Windows.Forms.Label()
			Me.Label8 = New System.Windows.Forms.Label()
			Me.Label9 = New System.Windows.Forms.Label()
			Me.Label10 = New System.Windows.Forms.Label()
			Me.Label11 = New System.Windows.Forms.Label()
			Me.Label12 = New System.Windows.Forms.Label()
			Me.Label13 = New System.Windows.Forms.Label()
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.TextBox2 = New System.Windows.Forms.TextBox()
			Me.TextBox3 = New System.Windows.Forms.TextBox()
			Me.TextBox4 = New System.Windows.Forms.TextBox()
			Me.TextBox5 = New System.Windows.Forms.TextBox()
			Me.TextBox6 = New System.Windows.Forms.TextBox()
			Me.TextBox7 = New System.Windows.Forms.TextBox()
			Me.TextBox8 = New System.Windows.Forms.TextBox()
			Me.TextBox9 = New System.Windows.Forms.TextBox()
			Me.TextBox10 = New System.Windows.Forms.TextBox()
			Me.TextBox11 = New System.Windows.Forms.TextBox()
			Me.TextBox12 = New System.Windows.Forms.TextBox()
			Me.TextBox13 = New System.Windows.Forms.TextBox()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.ComboBox1 = New System.Windows.Forms.ComboBox()
			Me.ComboBox2 = New System.Windows.Forms.ComboBox()
			Me.ComboBox3 = New System.Windows.Forms.ComboBox()
			Me.ComboBox4 = New System.Windows.Forms.ComboBox()
			Me.Label14 = New System.Windows.Forms.Label()
			Me.Label15 = New System.Windows.Forms.Label()
			Me.Label16 = New System.Windows.Forms.Label()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = SystemColors.HotTrack
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(40, 50)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(93, 15)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Nom générique"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = SystemColors.HotTrack
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(40, 90)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(45, 15)
			label21.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "Variété"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = SystemColors.HotTrack
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(40, 130)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(107, 15)
			label31.Size = size
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "Date de plantation"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = SystemColors.HotTrack
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(40, 170)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(97, 15)
			label41.Size = size
			Me.Label4.TabIndex = 3
			Me.Label4.Text = "Quantité plantée"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = SystemColors.HotTrack
			Dim label5 As System.Windows.Forms.Label = Me.Label5
			point = New System.Drawing.Point(40, 210)
			label5.Location = point
			Me.Label5.Name = "Label5"
			Dim label51 As System.Windows.Forms.Label = Me.Label5
			size = New System.Drawing.Size(90, 15)
			label51.Size = size
			Me.Label5.TabIndex = 4
			Me.Label5.Text = "Date de récolte"
			Me.Label6.AutoSize = True
			Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = SystemColors.HotTrack
			Dim label6 As System.Windows.Forms.Label = Me.Label6
			point = New System.Drawing.Point(40, 250)
			label6.Location = point
			Me.Label6.Name = "Label6"
			Dim label61 As System.Windows.Forms.Label = Me.Label6
			size = New System.Drawing.Size(100, 15)
			label61.Size = size
			Me.Label6.TabIndex = 5
			Me.Label6.Text = "Quantité récoltée"
			Me.Label7.AutoSize = True
			Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label7.ForeColor = SystemColors.HotTrack
			Dim label7 As System.Windows.Forms.Label = Me.Label7
			point = New System.Drawing.Point(40, 290)
			label7.Location = point
			Me.Label7.Name = "Label7"
			Dim label71 As System.Windows.Forms.Label = Me.Label7
			size = New System.Drawing.Size(72, 15)
			label71.Size = size
			Me.Label7.TabIndex = 6
			Me.Label7.Text = "Provenance"
			Me.Label8.AutoSize = True
			Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label8.ForeColor = SystemColors.HotTrack
			Dim label8 As System.Windows.Forms.Label = Me.Label8
			point = New System.Drawing.Point(40, 330)
			label8.Location = point
			Me.Label8.Name = "Label8"
			Dim label81 As System.Windows.Forms.Label = Me.Label8
			size = New System.Drawing.Size(115, 15)
			label81.Size = size
			Me.Label8.TabIndex = 7
			Me.Label8.Text = "Prix unitaire d'achat"
			Me.Label9.AutoSize = True
			Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label9.ForeColor = SystemColors.HotTrack
			Dim label9 As System.Windows.Forms.Label = Me.Label9
			point = New System.Drawing.Point(40, 370)
			label9.Location = point
			Me.Label9.Name = "Label9"
			Dim label91 As System.Windows.Forms.Label = Me.Label9
			size = New System.Drawing.Size(96, 15)
			label91.Size = size
			Me.Label9.TabIndex = 8
			Me.Label9.Text = "Quantité vendue"
			Me.Label10.AutoSize = True
			Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label10.ForeColor = SystemColors.HotTrack
			Dim label10 As System.Windows.Forms.Label = Me.Label10
			point = New System.Drawing.Point(40, 410)
			label10.Location = point
			Me.Label10.Name = "Label10"
			Dim label101 As System.Windows.Forms.Label = Me.Label10
			size = New System.Drawing.Size(121, 15)
			label101.Size = size
			Me.Label10.TabIndex = 9
			Me.Label10.Text = "Prix unitaire de vente"
			Me.Label11.AutoSize = True
			Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label11.ForeColor = SystemColors.HotTrack
			Dim label11 As System.Windows.Forms.Label = Me.Label11
			point = New System.Drawing.Point(40, 450)
			label11.Location = point
			Me.Label11.Name = "Label11"
			Dim label111 As System.Windows.Forms.Label = Me.Label11
			size = New System.Drawing.Size(125, 15)
			label111.Size = size
			Me.Label11.TabIndex = 10
			Me.Label11.Text = "Quantité consommée"
			Me.Label12.AutoSize = True
			Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label12.ForeColor = SystemColors.HotTrack
			Dim label12 As System.Windows.Forms.Label = Me.Label12
			point = New System.Drawing.Point(40, 490)
			label12.Location = point
			Me.Label12.Name = "Label12"
			Dim label121 As System.Windows.Forms.Label = Me.Label12
			size = New System.Drawing.Size(90, 15)
			label121.Size = size
			Me.Label12.TabIndex = 11
			Me.Label12.Text = "Prix du marché"
			Me.Label13.AutoSize = True
			Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label13.ForeColor = SystemColors.HotTrack
			Dim label13 As System.Windows.Forms.Label = Me.Label13
			point = New System.Drawing.Point(40, 530)
			label13.Location = point
			Me.Label13.Name = "Label13"
			Dim label131 As System.Windows.Forms.Label = Me.Label13
			size = New System.Drawing.Size(88, 15)
			label131.Size = size
			Me.Label13.TabIndex = 12
			Me.Label13.Text = "Commentaires"
			Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			point = New System.Drawing.Point(229, 49)
			textBox1.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			size = New System.Drawing.Size(272, 22)
			textBox.Size = size
			Me.TextBox1.TabIndex = 13
			Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox2 As System.Windows.Forms.TextBox = Me.TextBox2
			point = New System.Drawing.Point(229, 87)
			textBox2.Location = point
			Me.TextBox2.Name = "TextBox2"
			Dim textBox21 As System.Windows.Forms.TextBox = Me.TextBox2
			size = New System.Drawing.Size(272, 22)
			textBox21.Size = size
			Me.TextBox2.TabIndex = 14
			Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox3 As System.Windows.Forms.TextBox = Me.TextBox3
			point = New System.Drawing.Point(229, 127)
			textBox3.Location = point
			Me.TextBox3.Name = "TextBox3"
			Dim textBox31 As System.Windows.Forms.TextBox = Me.TextBox3
			size = New System.Drawing.Size(272, 22)
			textBox31.Size = size
			Me.TextBox3.TabIndex = 15
			Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox4 As System.Windows.Forms.TextBox = Me.TextBox4
			point = New System.Drawing.Point(229, 167)
			textBox4.Location = point
			Me.TextBox4.Name = "TextBox4"
			Dim textBox41 As System.Windows.Forms.TextBox = Me.TextBox4
			size = New System.Drawing.Size(80, 22)
			textBox41.Size = size
			Me.TextBox4.TabIndex = 16
			Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox5 As System.Windows.Forms.TextBox = Me.TextBox5
			point = New System.Drawing.Point(229, 207)
			textBox5.Location = point
			Me.TextBox5.Name = "TextBox5"
			Dim textBox51 As System.Windows.Forms.TextBox = Me.TextBox5
			size = New System.Drawing.Size(272, 22)
			textBox51.Size = size
			Me.TextBox5.TabIndex = 17
			Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox6 As System.Windows.Forms.TextBox = Me.TextBox6
			point = New System.Drawing.Point(229, 247)
			textBox6.Location = point
			Me.TextBox6.Name = "TextBox6"
			Dim textBox61 As System.Windows.Forms.TextBox = Me.TextBox6
			size = New System.Drawing.Size(80, 22)
			textBox61.Size = size
			Me.TextBox6.TabIndex = 18
			Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox7 As System.Windows.Forms.TextBox = Me.TextBox7
			point = New System.Drawing.Point(229, 287)
			textBox7.Location = point
			Me.TextBox7.Name = "TextBox7"
			Dim textBox71 As System.Windows.Forms.TextBox = Me.TextBox7
			size = New System.Drawing.Size(272, 22)
			textBox71.Size = size
			Me.TextBox7.TabIndex = 19
			Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox8 As System.Windows.Forms.TextBox = Me.TextBox8
			point = New System.Drawing.Point(229, 327)
			textBox8.Location = point
			Me.TextBox8.Name = "TextBox8"
			Dim textBox81 As System.Windows.Forms.TextBox = Me.TextBox8
			size = New System.Drawing.Size(80, 22)
			textBox81.Size = size
			Me.TextBox8.TabIndex = 20
			Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox9 As System.Windows.Forms.TextBox = Me.TextBox9
			point = New System.Drawing.Point(229, 367)
			textBox9.Location = point
			Me.TextBox9.Name = "TextBox9"
			Dim textBox91 As System.Windows.Forms.TextBox = Me.TextBox9
			size = New System.Drawing.Size(80, 22)
			textBox91.Size = size
			Me.TextBox9.TabIndex = 21
			Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox10 As System.Windows.Forms.TextBox = Me.TextBox10
			point = New System.Drawing.Point(229, 407)
			textBox10.Location = point
			Me.TextBox10.Name = "TextBox10"
			Dim textBox101 As System.Windows.Forms.TextBox = Me.TextBox10
			size = New System.Drawing.Size(80, 22)
			textBox101.Size = size
			Me.TextBox10.TabIndex = 22
			Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox11 As System.Windows.Forms.TextBox = Me.TextBox11
			point = New System.Drawing.Point(229, 447)
			textBox11.Location = point
			Me.TextBox11.Name = "TextBox11"
			Dim textBox111 As System.Windows.Forms.TextBox = Me.TextBox11
			size = New System.Drawing.Size(80, 22)
			textBox111.Size = size
			Me.TextBox11.TabIndex = 23
			Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox12 As System.Windows.Forms.TextBox = Me.TextBox12
			point = New System.Drawing.Point(229, 487)
			textBox12.Location = point
			Me.TextBox12.Name = "TextBox12"
			Dim textBox121 As System.Windows.Forms.TextBox = Me.TextBox12
			size = New System.Drawing.Size(80, 22)
			textBox121.Size = size
			Me.TextBox12.TabIndex = 24
			Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox13 As System.Windows.Forms.TextBox = Me.TextBox13
			point = New System.Drawing.Point(229, 527)
			textBox13.Location = point
			Me.TextBox13.Multiline = True
			Me.TextBox13.Name = "TextBox13"
			Me.TextBox13.ScrollBars = ScrollBars.Vertical
			Dim textBox131 As System.Windows.Forms.TextBox = Me.TextBox13
			size = New System.Drawing.Size(381, 84)
			textBox131.Size = size
			Me.TextBox13.TabIndex = 25
			Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(505, 632)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(105, 25)
			button.Size = size
			Me.Button1.TabIndex = 26
			Me.Button1.Text = "Ok"
			Me.Button1.UseVisualStyleBackColor = True
			Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox1.FormattingEnabled = True
			Dim items As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox1.Items
			Dim objArray() As Object = { "Pièce(s)", "Graine(s)", "Kilogrammes", "Grammes", "Unité" }
			items.AddRange(objArray)
			Dim comboBox1 As System.Windows.Forms.ComboBox = Me.ComboBox1
			point = New System.Drawing.Point(331, 167)
			comboBox1.Location = point
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBox1
			size = New System.Drawing.Size(121, 21)
			comboBox.Size = size
			Me.ComboBox1.TabIndex = 27
			Me.ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox2.FormattingEnabled = True
			Dim objectCollections As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox2.Items
			objArray = New Object() { "Pièce(s)", "Graine(s)", "Kilogrammes", "Grammes", "Unité" }
			objectCollections.AddRange(objArray)
			Dim comboBox2 As System.Windows.Forms.ComboBox = Me.ComboBox2
			point = New System.Drawing.Point(331, 249)
			comboBox2.Location = point
			Me.ComboBox2.Name = "ComboBox2"
			Dim comboBox21 As System.Windows.Forms.ComboBox = Me.ComboBox2
			size = New System.Drawing.Size(121, 21)
			comboBox21.Size = size
			Me.ComboBox2.TabIndex = 28
			Me.ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox3.FormattingEnabled = True
			Dim items1 As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox3.Items
			objArray = New Object() { "Pièce(s)", "Graine(s)", "Kilogrammes", "Grammes", "Unité" }
			items1.AddRange(objArray)
			Dim comboBox3 As System.Windows.Forms.ComboBox = Me.ComboBox3
			point = New System.Drawing.Point(331, 369)
			comboBox3.Location = point
			Me.ComboBox3.Name = "ComboBox3"
			Dim comboBox31 As System.Windows.Forms.ComboBox = Me.ComboBox3
			size = New System.Drawing.Size(121, 21)
			comboBox31.Size = size
			Me.ComboBox3.TabIndex = 29
			Me.ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox4.FormattingEnabled = True
			Dim objectCollections1 As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox4.Items
			objArray = New Object() { "Pièce(s)", "Graine(s)", "Kilogrammes", "Grammes", "Unité" }
			objectCollections1.AddRange(objArray)
			Dim comboBox4 As System.Windows.Forms.ComboBox = Me.ComboBox4
			point = New System.Drawing.Point(331, 449)
			comboBox4.Location = point
			Me.ComboBox4.Name = "ComboBox4"
			Dim comboBox41 As System.Windows.Forms.ComboBox = Me.ComboBox4
			size = New System.Drawing.Size(121, 21)
			comboBox41.Size = size
			Me.ComboBox4.TabIndex = 30
			Me.Label14.AutoSize = True
			Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim label14 As System.Windows.Forms.Label = Me.Label14
			point = New System.Drawing.Point(328, 332)
			label14.Location = point
			Me.Label14.Name = "Label14"
			Dim label141 As System.Windows.Forms.Label = Me.Label14
			size = New System.Drawing.Size(16, 16)
			label141.Size = size
			Me.Label14.TabIndex = 31
			Me.Label14.Text = "€"
			Me.Label15.AutoSize = True
			Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim label15 As System.Windows.Forms.Label = Me.Label15
			point = New System.Drawing.Point(328, 410)
			label15.Location = point
			Me.Label15.Name = "Label15"
			Dim label151 As System.Windows.Forms.Label = Me.Label15
			size = New System.Drawing.Size(16, 16)
			label151.Size = size
			Me.Label15.TabIndex = 32
			Me.Label15.Text = "€"
			Me.Label16.AutoSize = True
			Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim label16 As System.Windows.Forms.Label = Me.Label16
			point = New System.Drawing.Point(328, 490)
			label16.Location = point
			Me.Label16.Name = "Label16"
			Dim label161 As System.Windows.Forms.Label = Me.Label16
			size = New System.Drawing.Size(16, 16)
			label161.Size = size
			Me.Label16.TabIndex = 33
			Me.Label16.Text = "€"
			Me.PictureBox1.BackgroundImage = Resources.jinko
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(367, 90)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(280, 413)
			pictureBox.Size = size
			Me.PictureBox1.TabIndex = 34
			Me.PictureBox1.TabStop = False
			Me.AcceptButton = Me.Button1
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.DarkKhaki
			Me.BackgroundImageLayout = ImageLayout.None
			size = New System.Drawing.Size(642, 669)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label16)
			Me.Controls.Add(Me.Label15)
			Me.Controls.Add(Me.Label14)
			Me.Controls.Add(Me.ComboBox4)
			Me.Controls.Add(Me.ComboBox3)
			Me.Controls.Add(Me.ComboBox2)
			Me.Controls.Add(Me.ComboBox1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox13)
			Me.Controls.Add(Me.TextBox12)
			Me.Controls.Add(Me.TextBox11)
			Me.Controls.Add(Me.TextBox10)
			Me.Controls.Add(Me.TextBox9)
			Me.Controls.Add(Me.TextBox8)
			Me.Controls.Add(Me.TextBox7)
			Me.Controls.Add(Me.TextBox6)
			Me.Controls.Add(Me.TextBox5)
			Me.Controls.Add(Me.TextBox4)
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Label13)
			Me.Controls.Add(Me.Label12)
			Me.Controls.Add(Me.Label11)
			Me.Controls.Add(Me.Label10)
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.PictureBox1)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formaddrecolte"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Ajouter une récolte"
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Public Function splitxt(ByRef str As String, ByVal int As Integer) As String
			Dim strArrays As String()
			Try
				strArrays = Strings.Split(str, "|", -1, CompareMethod.Binary)
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				strArrays = New String() { "", "" }
				ProjectData.ClearProjectError()
			End Try
			Return strArrays(int)
		End Function

		Private Sub TextBox10_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox10.Text)) Then
				Me.TextBox10.Focus()
				Me.TextBox10.TextAlign = HorizontalAlignment.Left
				Me.TextBox10.Text = "0,00"
				Me.TextBox10.SelectAll()
			Else
				Me.TextBox10.TextAlign = HorizontalAlignment.Right
			End If
		End Sub

		Private Sub TextBox11_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox11.Text)) Then
				Me.TextBox11.Focus()
				Me.TextBox11.TextAlign = HorizontalAlignment.Left
				Me.TextBox11.Text = "0,00"
				Me.TextBox11.SelectAll()
			Else
				Me.TextBox11.TextAlign = HorizontalAlignment.Right
			End If
		End Sub

		Private Sub TextBox12_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox12.Text)) Then
				Me.TextBox12.Focus()
				Me.TextBox12.TextAlign = HorizontalAlignment.Left
				Me.TextBox12.Text = "0,00"
				Me.TextBox12.SelectAll()
			Else
				Me.TextBox12.TextAlign = HorizontalAlignment.Right
			End If
		End Sub

		Private Sub TextBox4_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox4.Text)) Then
				Me.TextBox4.Focus()
				Me.TextBox4.TextAlign = HorizontalAlignment.Left
				Me.TextBox4.Text = "0,00"
				Me.TextBox4.SelectAll()
			Else
				Me.TextBox4.TextAlign = HorizontalAlignment.Right
			End If
		End Sub

		Private Sub TextBox6_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox6.Text)) Then
				Me.TextBox6.Focus()
				Me.TextBox6.TextAlign = HorizontalAlignment.Left
				Me.TextBox6.Text = "0,00"
				Me.TextBox6.SelectAll()
			Else
				Me.TextBox6.TextAlign = HorizontalAlignment.Right
			End If
		End Sub

		Private Sub TextBox8_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox8.Text)) Then
				Me.TextBox8.Focus()
				Me.TextBox8.TextAlign = HorizontalAlignment.Left
				Me.TextBox8.Text = "0,00"
				Me.TextBox8.SelectAll()
			Else
				Me.TextBox8.TextAlign = HorizontalAlignment.Right
			End If
		End Sub

		Private Sub TextBox9_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox9.Text)) Then
				Me.TextBox9.Focus()
				Me.TextBox9.TextAlign = HorizontalAlignment.Left
				Me.TextBox9.Text = "0,00"
				Me.TextBox9.SelectAll()
			Else
				Me.TextBox9.TextAlign = HorizontalAlignment.Right
			End If
		End Sub
	End Class
End Namespace