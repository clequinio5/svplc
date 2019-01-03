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
	Public Class Formaddmat
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

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formaddmat As SVPLCApplication.Formaddmat = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddmat.Button1_Click)
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
				Dim formaddmat As SVPLCApplication.Formaddmat = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddmat.TextBox3_Leave)
				If (Me._TextBox3 IsNot Nothing) Then
					RemoveHandler Me._TextBox3.Leave,  eventHandler
				End If
				Me._TextBox3 = value
				If (Me._TextBox3 IsNot Nothing) Then
					AddHandler Me._TextBox3.Leave,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox4 As TextBox
			Get
				Return Me._TextBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formaddmat As SVPLCApplication.Formaddmat = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formaddmat.TextBox4_Leave)
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
				Me._TextBox6 = value
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

		Public Sub New()
			MyBase.New()
			Dim formaddmat1 As Formaddmat = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formaddmat1.Formaddmat_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.Materieldata(0) = Me.TextBox1.Text
			MyProject.Forms.FormPasPas.Materieldata(1) = Me.TextBox2.Text
			MyProject.Forms.FormPasPas.Materieldata(2) = String.Concat(Me.TextBox3.Text, "|", Me.ComboBox1.Text)
			MyProject.Forms.FormPasPas.Materieldata(3) = Me.TextBox4.Text
			MyProject.Forms.FormPasPas.Materieldata(4) = Me.TextBox5.Text
			MyProject.Forms.FormPasPas.Materieldata(5) = Me.TextBox6.Text
			MyProject.Forms.FormPasPas.Materieldata(6) = Me.TextBox7.Text
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

		Private Sub Formaddmat_Load(ByVal sender As Object, ByVal e As EventArgs)
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
			Me.TextBox1.Text = MyProject.Forms.FormPasPas.Materieldata(0)
			Me.TextBox2.Text = MyProject.Forms.FormPasPas.Materieldata(1)
			Me.TextBox3.Text = Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 0)
			Me.ComboBox1.Text = Me.splitxt(MyProject.Forms.FormPasPas.Materieldata(2), 1)
			Me.TextBox4.Text = MyProject.Forms.FormPasPas.Materieldata(3)
			Me.TextBox5.Text = MyProject.Forms.FormPasPas.Materieldata(4)
			Me.TextBox6.Text = MyProject.Forms.FormPasPas.Materieldata(5)
			Me.TextBox7.Text = MyProject.Forms.FormPasPas.Materieldata(6)
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formaddmat))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.Label5 = New System.Windows.Forms.Label()
			Me.Label6 = New System.Windows.Forms.Label()
			Me.Label7 = New System.Windows.Forms.Label()
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.TextBox2 = New System.Windows.Forms.TextBox()
			Me.TextBox3 = New System.Windows.Forms.TextBox()
			Me.TextBox4 = New System.Windows.Forms.TextBox()
			Me.TextBox5 = New System.Windows.Forms.TextBox()
			Me.TextBox6 = New System.Windows.Forms.TextBox()
			Me.TextBox7 = New System.Windows.Forms.TextBox()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.ComboBox1 = New System.Windows.Forms.ComboBox()
			Me.Label8 = New System.Windows.Forms.Label()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.PictureBox2 = New System.Windows.Forms.PictureBox()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = SystemColors.HotTrack
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(40, 50)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(34, 15)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Nom"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = SystemColors.HotTrack
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(40, 90)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(95, 15)
			label21.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "Caractéristiques"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = SystemColors.HotTrack
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(40, 130)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(53, 15)
			label31.Size = size
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "Quantité"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = SystemColors.HotTrack
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(40, 170)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(72, 15)
			label41.Size = size
			Me.Label4.TabIndex = 3
			Me.Label4.Text = "Prix unitaire"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = SystemColors.HotTrack
			Dim label5 As System.Windows.Forms.Label = Me.Label5
			point = New System.Drawing.Point(40, 210)
			label5.Location = point
			Me.Label5.Name = "Label5"
			Dim label51 As System.Windows.Forms.Label = Me.Label5
			size = New System.Drawing.Size(72, 15)
			label51.Size = size
			Me.Label5.TabIndex = 4
			Me.Label5.Text = "Provenance"
			Me.Label6.AutoSize = True
			Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = SystemColors.HotTrack
			Dim label6 As System.Windows.Forms.Label = Me.Label6
			point = New System.Drawing.Point(40, 250)
			label6.Location = point
			Me.Label6.Name = "Label6"
			Dim label61 As System.Windows.Forms.Label = Me.Label6
			size = New System.Drawing.Size(89, 15)
			label61.Size = size
			Me.Label6.TabIndex = 5
			Me.Label6.Text = "Date de l'achat"
			Me.Label7.AutoSize = True
			Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label7.ForeColor = SystemColors.HotTrack
			Dim label7 As System.Windows.Forms.Label = Me.Label7
			point = New System.Drawing.Point(40, 290)
			label7.Location = point
			Me.Label7.Name = "Label7"
			Dim label71 As System.Windows.Forms.Label = Me.Label7
			size = New System.Drawing.Size(88, 15)
			label71.Size = size
			Me.Label7.TabIndex = 6
			Me.Label7.Text = "Commentaires"
			Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			point = New System.Drawing.Point(201, 49)
			textBox1.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			size = New System.Drawing.Size(248, 22)
			textBox.Size = size
			Me.TextBox1.TabIndex = 7
			Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox2 As System.Windows.Forms.TextBox = Me.TextBox2
			point = New System.Drawing.Point(201, 87)
			textBox2.Location = point
			Me.TextBox2.Name = "TextBox2"
			Dim textBox21 As System.Windows.Forms.TextBox = Me.TextBox2
			size = New System.Drawing.Size(248, 22)
			textBox21.Size = size
			Me.TextBox2.TabIndex = 8
			Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox3 As System.Windows.Forms.TextBox = Me.TextBox3
			point = New System.Drawing.Point(201, 127)
			textBox3.Location = point
			Me.TextBox3.Name = "TextBox3"
			Dim textBox31 As System.Windows.Forms.TextBox = Me.TextBox3
			size = New System.Drawing.Size(80, 22)
			textBox31.Size = size
			Me.TextBox3.TabIndex = 9
			Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox4 As System.Windows.Forms.TextBox = Me.TextBox4
			point = New System.Drawing.Point(201, 167)
			textBox4.Location = point
			Me.TextBox4.Name = "TextBox4"
			Dim textBox41 As System.Windows.Forms.TextBox = Me.TextBox4
			size = New System.Drawing.Size(80, 22)
			textBox41.Size = size
			Me.TextBox4.TabIndex = 10
			Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox5 As System.Windows.Forms.TextBox = Me.TextBox5
			point = New System.Drawing.Point(201, 207)
			textBox5.Location = point
			Me.TextBox5.Name = "TextBox5"
			Dim textBox51 As System.Windows.Forms.TextBox = Me.TextBox5
			size = New System.Drawing.Size(248, 22)
			textBox51.Size = size
			Me.TextBox5.TabIndex = 11
			Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox6 As System.Windows.Forms.TextBox = Me.TextBox6
			point = New System.Drawing.Point(201, 247)
			textBox6.Location = point
			Me.TextBox6.Name = "TextBox6"
			Dim textBox61 As System.Windows.Forms.TextBox = Me.TextBox6
			size = New System.Drawing.Size(80, 22)
			textBox61.Size = size
			Me.TextBox6.TabIndex = 12
			Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim textBox7 As System.Windows.Forms.TextBox = Me.TextBox7
			point = New System.Drawing.Point(201, 290)
			textBox7.Location = point
			Me.TextBox7.Multiline = True
			Me.TextBox7.Name = "TextBox7"
			Me.TextBox7.ScrollBars = ScrollBars.Vertical
			Dim textBox71 As System.Windows.Forms.TextBox = Me.TextBox7
			size = New System.Drawing.Size(313, 98)
			textBox71.Size = size
			Me.TextBox7.TabIndex = 13
			Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(425, 406)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(89, 23)
			button.Size = size
			Me.Button1.TabIndex = 14
			Me.Button1.Text = "Ok"
			Me.Button1.UseVisualStyleBackColor = True
			Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
			Me.ComboBox1.FormattingEnabled = True
			Dim items As System.Windows.Forms.ComboBox.ObjectCollection = Me.ComboBox1.Items
			Dim objArray() As Object = { "Pièce(s)", "Kilogrammes", "Grammes", "Unité" }
			items.AddRange(objArray)
			Dim comboBox1 As System.Windows.Forms.ComboBox = Me.ComboBox1
			point = New System.Drawing.Point(304, 129)
			comboBox1.Location = point
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBox1
			size = New System.Drawing.Size(121, 21)
			comboBox.Size = size
			Me.ComboBox1.TabIndex = 28
			Me.Label8.AutoSize = True
			Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim label8 As System.Windows.Forms.Label = Me.Label8
			point = New System.Drawing.Point(304, 170)
			label8.Location = point
			Me.Label8.Name = "Label8"
			Dim label81 As System.Windows.Forms.Label = Me.Label8
			size = New System.Drawing.Size(16, 16)
			label81.Size = size
			Me.Label8.TabIndex = 29
			Me.Label8.Text = "€"
			Me.PictureBox1.BackgroundImage = Resources.leaf
			Me.PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(12, 308)
			pictureBox1.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(166, 137)
			pictureBox.Size = size
			Me.PictureBox1.TabIndex = 30
			Me.PictureBox1.TabStop = False
			Me.PictureBox2.BackgroundImage = Resources.gold_leaf
			Me.PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
			Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox2
			point = New System.Drawing.Point(396, 87)
			pictureBox2.Location = point
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox21 As System.Windows.Forms.PictureBox = Me.PictureBox2
			size = New System.Drawing.Size(146, 132)
			pictureBox21.Size = size
			Me.PictureBox2.TabIndex = 31
			Me.PictureBox2.TabStop = False
			Me.AcceptButton = Me.Button1
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.Peru
			Me.BackgroundImageLayout = ImageLayout.None
			size = New System.Drawing.Size(541, 441)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.ComboBox1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox7)
			Me.Controls.Add(Me.TextBox6)
			Me.Controls.Add(Me.TextBox5)
			Me.Controls.Add(Me.TextBox4)
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.PictureBox2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formaddmat"
			Me.Text = "Ajouter un matériel"
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox2, ISupportInitialize).EndInit()
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

		Private Sub TextBox3_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Versioned.IsNumeric(Me.TextBox3.Text)) Then
				Me.TextBox3.Focus()
				Me.TextBox3.TextAlign = HorizontalAlignment.Left
				Me.TextBox3.Text = "0,00"
				Me.TextBox3.SelectAll()
			Else
				Me.TextBox3.TextAlign = HorizontalAlignment.Right
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
	End Class
End Namespace