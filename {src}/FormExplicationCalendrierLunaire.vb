Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormExplicationCalendrierLunaire
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("PictureBox")>
		Private _PictureBox As System.Windows.Forms.PictureBox

		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As System.Windows.Forms.PictureBox

		<AccessedThroughProperty("lbldefinition")>
		Private _lbldefinition As Label

		Private Overridable Property lbldefinition As Label
			Get
				Return Me._lbldefinition
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Label)
				Me._lbldefinition = value
			End Set
		End Property

		Private Overridable Property PictureBox As System.Windows.Forms.PictureBox
			Get
				Return Me._PictureBox
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._PictureBox = value
			End Set
		End Property

		Private Overridable Property PictureBox1 As System.Windows.Forms.PictureBox
			Get
				Return Me._PictureBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As System.Windows.Forms.PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formExplicationCalendrierLunaire1 As FormExplicationCalendrierLunaire = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formExplicationCalendrierLunaire1.Form12_Load)
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

		Private Sub Form12_Load(ByVal sender As Object, ByVal e As EventArgs)
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
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExplicationCalendrierLunaire))
			Me.PictureBox = New System.Windows.Forms.PictureBox()
			Me.PictureBox1 = New System.Windows.Forms.PictureBox()
			Me.lbldefinition = New System.Windows.Forms.Label()
			DirectCast(Me.PictureBox, ISupportInitialize).BeginInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox.BackColor = Color.Transparent
			Me.PictureBox.Image = Resources.ScreenShotapgprg
			Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox
			Dim point As System.Drawing.Point = New System.Drawing.Point(504, 29)
			pictureBox.Location = point
			Me.PictureBox.Name = "PictureBox"
			Dim pictureBox1 As System.Windows.Forms.PictureBox = Me.PictureBox
			Dim size As System.Drawing.Size = New System.Drawing.Size(458, 291)
			pictureBox1.Size = size
			Me.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBox.TabIndex = 0
			Me.PictureBox.TabStop = False
			Me.PictureBox1.Image = Resources.ScreenShotapgprgplan
			Dim pictureBox11 As System.Windows.Forms.PictureBox = Me.PictureBox1
			point = New System.Drawing.Point(23, 12)
			pictureBox11.Location = point
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox12 As System.Windows.Forms.PictureBox = Me.PictureBox1
			size = New System.Drawing.Size(437, 331)
			pictureBox12.Size = size
			Me.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.lbldefinition.BackColor = Color.MidnightBlue
			Me.lbldefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.lbldefinition.ForeColor = Color.Gray
			Dim label As System.Windows.Forms.Label = Me.lbldefinition
			point = New System.Drawing.Point(20, 365)
			label.Location = point
			Me.lbldefinition.Name = "lbldefinition"
			Dim label1 As System.Windows.Forms.Label = Me.lbldefinition
			size = New System.Drawing.Size(942, 111)
			label1.Size = size
			Me.lbldefinition.TabIndex = 0
			Me.lbldefinition.Text = componentResourceManager.GetString("lbldefinition.Text")
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Color.MidnightBlue
			size = New System.Drawing.Size(987, 495)
			Me.ClientSize = size
			Me.Controls.Add(Me.lbldefinition)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.PictureBox)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form12"
			Me.Text = "Apogée, Périgée et Noeud lunaire"
			DirectCast(Me.PictureBox, ISupportInitialize).EndInit()
			DirectCast(Me.PictureBox1, ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub
	End Class
End Namespace