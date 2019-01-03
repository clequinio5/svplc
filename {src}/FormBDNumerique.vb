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
	Public Class FormBDNumerique
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("NumericUpDown1")>
		Private _NumericUpDown1 As NumericUpDown

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formBDNumerique As SVPLCApplication.FormBDNumerique = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formBDNumerique.Button1_Click)
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

		Friend Overridable Property NumericUpDown1 As NumericUpDown
			Get
				Return Me._NumericUpDown1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As NumericUpDown)
				Me._NumericUpDown1 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formBDNumerique1 As FormBDNumerique = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formBDNumerique1.Form23_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.reponse = Me.NumericUpDown1.Text
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

		Private Sub Form23_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.Text = MyProject.Forms.FormPasPas.titreinput
			Me.Label1.Text = MyProject.Forms.FormPasPas.labelinput
			Me.NumericUpDown1.Text = "1"
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBDNumerique))
			Me.Button1 = New System.Windows.Forms.Button()
			Me.Label1 = New System.Windows.Forms.Label()
			Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
			DirectCast(Me.NumericUpDown1, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Button1.BackColor = Color.BlueViolet
			Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.Button1.FlatAppearance.BorderColor = Color.DarkRed
			Me.Button1.FlatAppearance.BorderSize = 2
			Me.Button1.FlatStyle = FlatStyle.Flat
			Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			Dim point As System.Drawing.Point = New System.Drawing.Point(307, 111)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			Dim size As System.Drawing.Size = New System.Drawing.Size(54, 26)
			button.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Ok"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Label1.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Color.ForestGreen
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			point = New System.Drawing.Point(12, 9)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			size = New System.Drawing.Size(349, 47)
			label.Size = size
			Me.Label1.TabIndex = 1
			Me.Label1.Text = "Question"
			Me.NumericUpDown1.BackColor = Color.RoyalBlue
			Me.NumericUpDown1.Font = New System.Drawing.Font("Cooper Black", 14.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.NumericUpDown1.ForeColor = Color.Gold
			Dim numericUpDown1 As System.Windows.Forms.NumericUpDown = Me.NumericUpDown1
			point = New System.Drawing.Point(150, 69)
			numericUpDown1.Location = point
			Dim numericUpDown As System.Windows.Forms.NumericUpDown = Me.NumericUpDown1
			Dim numArray() As Integer = { 362880, 0, 0, 0 }
			Dim num As Decimal = New Decimal(numArray)
			numericUpDown.Maximum = num
			Dim numericUpDown11 As System.Windows.Forms.NumericUpDown = Me.NumericUpDown1
			numArray = New Integer() { 1, 0, 0, 0 }
			num = New Decimal(numArray)
			numericUpDown11.Minimum = num
			Me.NumericUpDown1.Name = "NumericUpDown1"
			Dim numericUpDown12 As System.Windows.Forms.NumericUpDown = Me.NumericUpDown1
			size = New System.Drawing.Size(71, 29)
			numericUpDown12.Size = size
			Me.NumericUpDown1.TabIndex = 3
			Me.NumericUpDown1.TextAlign = HorizontalAlignment.Center
			Dim numericUpDown2 As System.Windows.Forms.NumericUpDown = Me.NumericUpDown1
			numArray = New Integer() { 1, 0, 0, 0 }
			num = New Decimal(numArray)
			numericUpDown2.Value = num
			Me.AcceptButton = Me.Button1
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.FromArgb(128, 64, 0)
			size = New System.Drawing.Size(373, 149)
			Me.ClientSize = size
			Me.Controls.Add(Me.NumericUpDown1)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form23"
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Question"
			DirectCast(Me.NumericUpDown1, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace