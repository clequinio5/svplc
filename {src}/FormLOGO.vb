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
	Public Class FormLOGO
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		<AccessedThroughProperty("Timer2")>
		Private _Timer2 As Timer

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

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

		Friend Overridable Property Timer1 As Timer
			Get
				Return Me._Timer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Timer)
				Dim formLOGO As SVPLCApplication.FormLOGO = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formLOGO.Timer1_Tick)
				If (Me._Timer1 IsNot Nothing) Then
					RemoveHandler Me._Timer1.Tick,  eventHandler
				End If
				Me._Timer1 = value
				If (Me._Timer1 IsNot Nothing) Then
					AddHandler Me._Timer1.Tick,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Timer2 As Timer
			Get
				Return Me._Timer2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Timer)
				Dim formLOGO As SVPLCApplication.FormLOGO = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formLOGO.Timer2_Tick)
				If (Me._Timer2 IsNot Nothing) Then
					RemoveHandler Me._Timer2.Tick,  eventHandler
				End If
				Me._Timer2 = value
				If (Me._Timer2 IsNot Nothing) Then
					AddHandler Me._Timer2.Tick,  eventHandler
				End If
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formLOGO1 As FormLOGO = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formLOGO1.Form20_Load)
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

		Private Sub Form20_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Opacity = 0
			Me.Timer1.Start()
			Me.Timer2.Start()
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLOGO))
			Me.Timer1 = New Timer(Me.components)
			Me.Timer2 = New Timer(Me.components)
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.Timer1.Interval = 5
			Me.Timer2.Interval = 6000
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Color.Transparent
			Me.Label2.Font = New System.Drawing.Font("Cooper Black", 9.75!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Color.FromArgb(255, 128, 0)
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			Dim point As System.Drawing.Point = New System.Drawing.Point(297, 176)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label As System.Windows.Forms.Label = Me.Label2
			Dim size As System.Drawing.Size = New System.Drawing.Size(50, 15)
			label.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "v 8.1.5"
			Me.Label3.BackColor = Color.Transparent
			Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9!, FontStyle.Regular, GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Color.Gold
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(140, 270)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(230, 19)
			label31.Size = size
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "Optimisation et gestion du jardin"
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.SaddleBrown
			Me.BackgroundImage = DirectCast(componentResourceManager.GetObject("$this.BackgroundImage"), Image)
			Me.BackgroundImageLayout = ImageLayout.Stretch
			size = New System.Drawing.Size(400, 400)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.DoubleBuffered = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.Name = "Form20"
			Me.Opacity = 0
			Me.ShowInTaskbar = False
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.Text = "Form20"
			Me.TopMost = True
			Me.TransparencyKey = Color.SaddleBrown
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.Opacity = Me.Opacity + 0.01
			If (Me.Opacity = 100) Then
				Me.Timer1.Dispose()
			End If
		End Sub

		Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs)
			MyProject.Forms.FormPasPas.Opacity = 1
			Me.Close()
		End Sub
	End Class
End Namespace