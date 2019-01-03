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
	Public Class Formbmp
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		Private fs As FileStream

		Friend Overridable Property PictureBox1 As PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formbmp1 As Formbmp = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formbmp1.Formbmp_Load)
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

		Private Sub Formbmp_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim size As System.Drawing.Size = New System.Drawing.Size(Module1.screenadaptX(Me.Width), Module1.screenadaptY(Me.Height))
			Me.Size = size
			Me.fs = File.OpenRead(MyProject.Forms.FormPasPas.pathbmp)
			Me.PictureBox1.BackgroundImage = Image.FromStream(Me.fs)
			Me.fs.Close()
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formbmp))
			Me.PictureBox1 = New PictureBox()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.BackgroundImageLayout = ImageLayout.Center
			Me.PictureBox1.Dock = DockStyle.Fill
			Me.PictureBox1.Location = New Point(0, 0)
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox1 As PictureBox = Me.PictureBox1
			Dim size As System.Drawing.Size = New System.Drawing.Size(860, 577)
			pictureBox1.Size = size
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.Olive
			size = New System.Drawing.Size(860, 577)
			Me.ClientSize = size
			Me.Controls.Add(Me.PictureBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formbmp"
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace