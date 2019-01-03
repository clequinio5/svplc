Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class Formpaypal
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		<AccessedThroughProperty("LinkLabel1")>
		Private _LinkLabel1 As LinkLabel

		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		<AccessedThroughProperty("LinkLabel2")>
		Private _LinkLabel2 As LinkLabel

		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		Private txtb As String

		Private txtbb As String

		Private hash As String

		Private util As String

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formpaypal As SVPLCApplication.Formpaypal = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formpaypal.Button1_Click)
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

		Friend Overridable Property LinkLabel1 As LinkLabel
			Get
				Return Me._LinkLabel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As LinkLabel)
				Dim formpaypal As SVPLCApplication.Formpaypal = Me
				Dim linkLabelLinkClickedEventHandler As System.Windows.Forms.LinkLabelLinkClickedEventHandler = New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf formpaypal.LinkLabel1_LinkClicked)
				If (Me._LinkLabel1 IsNot Nothing) Then
					RemoveHandler Me._LinkLabel1.LinkClicked,  linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel1 = value
				If (Me._LinkLabel1 IsNot Nothing) Then
					AddHandler Me._LinkLabel1.LinkClicked,  linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		Friend Overridable Property LinkLabel2 As LinkLabel
			Get
				Return Me._LinkLabel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As LinkLabel)
				Dim formpaypal As SVPLCApplication.Formpaypal = Me
				Dim linkLabelLinkClickedEventHandler As System.Windows.Forms.LinkLabelLinkClickedEventHandler = New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf formpaypal.LinkLabel2_LinkClicked)
				If (Me._LinkLabel2 IsNot Nothing) Then
					RemoveHandler Me._LinkLabel2.LinkClicked,  linkLabelLinkClickedEventHandler
				End If
				Me._LinkLabel2 = value
				If (Me._LinkLabel2 IsNot Nothing) Then
					AddHandler Me._LinkLabel2.LinkClicked,  linkLabelLinkClickedEventHandler
				End If
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

		Public Sub New()
			MyBase.New()
			Dim formpaypal1 As Formpaypal = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formpaypal1.Form21_FormClosed)
			Dim formpaypal2 As Formpaypal = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formpaypal2.Form21_Load)
			Me.InitializeComponent()
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			If (Operators.CompareString(Me.TextBox1.Text, "", False) <> 0 And Operators.CompareString(Me.TextBox2.Text, "", False) <> 0) Then
				Try
					Me.txtb = Me.TextBox2.Text
					Me.util = Me.TextBox1.Text
					Me.txtbb = Me.txtb.Insert(4, "108")
					Me.txtbb = Me.txtbb.Insert(15, "Ch212")
					Me.txtbb = Me.txtbb.Remove(8, 5)
					Me.hash = MyProject.Forms.FormPasPas.encrypt(Me.txtbb)
					If (Operators.CompareString(Me.hash, Me.util, False) <> 0) Then
						Interaction.MsgBox("Les identifiants saisis ne sont pas valides.", MsgBoxStyle.Exclamation, "Erreur identifiants")
					Else
						Me.Cursor = Cursors.WaitCursor
						Dim registryKey As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Svplc\\activ")
						Dim registryKey1 As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Svplc\\util")
						Try
							File.WriteAllText(String.Concat(Application.StartupPath.ToString(), "\License.txt"), Resources.License_payante)
							registryKey.SetValue("License", Me.hash)
							registryKey1.SetValue("Utilisateur", Me.txtb)
							Me.Cursor = Cursors.[Default]
							Interaction.MsgBox("La clé a été enregistrer avec succès. Le logiciel va redémarrer. Bonnes récoltes!", MsgBoxStyle.Information, "Enregistrement réussi")
							Application.Restart()
						Catch exception As System.Exception
							ProjectData.SetProjectError(exception)
							Interaction.MsgBox("Une erreur est survenue. Contactez le développeur", MsgBoxStyle.Exclamation, "Erreur critique")
							ProjectData.ClearProjectError()
						End Try
					End If
				Catch exception1 As System.Exception
					ProjectData.SetProjectError(exception1)
					Interaction.MsgBox("Les identifiants saisis ne sont pas valides.", MsgBoxStyle.Exclamation, "Erreur identifiants")
					ProjectData.ClearProjectError()
				End Try
			End If
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

		Private Sub Form21_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadactiv = False
		End Sub

		Private Sub Form21_Load(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formpaypal))
			Me.Label1 = New System.Windows.Forms.Label()
			Me.Label2 = New System.Windows.Forms.Label()
			Me.Label3 = New System.Windows.Forms.Label()
			Me.Label5 = New System.Windows.Forms.Label()
			Me.Label6 = New System.Windows.Forms.Label()
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.Label7 = New System.Windows.Forms.Label()
			Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
			Me.Label8 = New System.Windows.Forms.Label()
			Me.Label9 = New System.Windows.Forms.Label()
			Me.TextBox2 = New System.Windows.Forms.TextBox()
			Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
			Me.Label4 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = SystemColors.HotTrack
			Dim label1 As System.Windows.Forms.Label = Me.Label1
			Dim point As System.Drawing.Point = New System.Drawing.Point(12, 21)
			label1.Location = point
			Me.Label1.Name = "Label1"
			Dim label As System.Windows.Forms.Label = Me.Label1
			Dim size As System.Drawing.Size = New System.Drawing.Size(489, 39)
			label.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Pour enregistrer le logiciel et ainsi avoir accès à l'intégralité de ses fonctions, merci de suivre la procédure suivante:"
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = SystemColors.HotTrack
			Dim label2 As System.Windows.Forms.Label = Me.Label2
			point = New System.Drawing.Point(12, 87)
			label2.Location = point
			Me.Label2.Name = "Label2"
			Dim label21 As System.Windows.Forms.Label = Me.Label2
			size = New System.Drawing.Size(219, 13)
			label21.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "1) Vérifier que vous êtes connecté à internet."
			Me.Label3.AutoSize = True
			Me.Label3.ForeColor = SystemColors.HotTrack
			Dim label3 As System.Windows.Forms.Label = Me.Label3
			point = New System.Drawing.Point(12, 150)
			label3.Location = point
			Me.Label3.Name = "Label3"
			Dim label31 As System.Windows.Forms.Label = Me.Label3
			size = New System.Drawing.Size(305, 13)
			label31.Size = size
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "2) Faites un don supérieur ou égal à 10 € en cliquant sur le lien:"
			Me.Label3.Visible = False
			Me.Label5.ForeColor = SystemColors.HotTrack
			Dim label5 As System.Windows.Forms.Label = Me.Label5
			point = New System.Drawing.Point(12, 175)
			label5.Location = point
			Me.Label5.Name = "Label5"
			Dim label51 As System.Windows.Forms.Label = Me.Label5
			size = New System.Drawing.Size(489, 32)
			label51.Size = size
			Me.Label5.TabIndex = 4
			Me.Label5.Text = "3) N'oubliez pas de remplir correctement vos coordonnées, des identifiants vous seront envoyés dans les 48h après la réception du paiement."
			Me.Label6.AutoSize = True
			Me.Label6.ForeColor = SystemColors.HotTrack
			Dim label6 As System.Windows.Forms.Label = Me.Label6
			point = New System.Drawing.Point(15, 217)
			label6.Location = point
			Me.Label6.Name = "Label6"
			Dim label61 As System.Windows.Forms.Label = Me.Label6
			size = New System.Drawing.Size(187, 13)
			label61.Size = size
			Me.Label6.TabIndex = 5
			Me.Label6.Text = "4) Saisissez les identifiants ci dessous:"
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			point = New System.Drawing.Point(136, 275)
			textBox1.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			size = New System.Drawing.Size(253, 20)
			textBox.Size = size
			Me.TextBox1.TabIndex = 6
			Me.Button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0)
			Me.Button1.FlatStyle = FlatStyle.Flat
			Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = SystemColors.HotTrack
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(426, 339)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(75, 27)
			button.Size = size
			Me.Button1.TabIndex = 7
			Me.Button1.Text = "Activer"
			Me.Button1.TextAlign = ContentAlignment.TopCenter
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label7.ForeColor = SystemColors.HotTrack
			Dim label7 As System.Windows.Forms.Label = Me.Label7
			point = New System.Drawing.Point(12, 331)
			label7.Location = point
			Me.Label7.Name = "Label7"
			Dim label71 As System.Windows.Forms.Label = Me.Label7
			size = New System.Drawing.Size(410, 47)
			label71.Size = size
			Me.Label7.TabIndex = 8
			Me.Label7.Text = "Le paiement se fait via Paypal ou par carte bancaire. Pour toutes informations supplémentaires, merci de contacter l'auteur du logiciel à l'adresse kikil592@gmail.com"
			Me.LinkLabel1.AutoSize = True
			Me.LinkLabel1.ForeColor = Color.Black
			Me.LinkLabel1.LinkColor = Color.Red
			Dim linkLabel1 As System.Windows.Forms.LinkLabel = Me.LinkLabel1
			point = New System.Drawing.Point(332, 150)
			linkLabel1.Location = point
			Me.LinkLabel1.Name = "LinkLabel1"
			Dim linkLabel As System.Windows.Forms.LinkLabel = Me.LinkLabel1
			size = New System.Drawing.Size(66, 13)
			linkLabel.Size = size
			Me.LinkLabel1.TabIndex = 9
			Me.LinkLabel1.TabStop = True
			Me.LinkLabel1.Text = "Faire un don"
			Me.LinkLabel1.Visible = False
			Me.Label8.AutoSize = True
			Me.Label8.ForeColor = SystemColors.HotTrack
			Dim label8 As System.Windows.Forms.Label = Me.Label8
			point = New System.Drawing.Point(15, 278)
			label8.Location = point
			Me.Label8.Name = "Label8"
			Dim label81 As System.Windows.Forms.Label = Me.Label8
			size = New System.Drawing.Size(95, 13)
			label81.Size = size
			Me.Label8.TabIndex = 11
			Me.Label8.Text = "Code d'activation :"
			Me.Label9.AutoSize = True
			Me.Label9.ForeColor = SystemColors.HotTrack
			Dim label9 As System.Windows.Forms.Label = Me.Label9
			point = New System.Drawing.Point(15, 249)
			label9.Location = point
			Me.Label9.Name = "Label9"
			Dim label91 As System.Windows.Forms.Label = Me.Label9
			size = New System.Drawing.Size(59, 13)
			label91.Size = size
			Me.Label9.TabIndex = 12
			Me.Label9.Text = "Utilisateur :"
			Dim textBox2 As System.Windows.Forms.TextBox = Me.TextBox2
			point = New System.Drawing.Point(136, 246)
			textBox2.Location = point
			Me.TextBox2.Name = "TextBox2"
			Dim textBox21 As System.Windows.Forms.TextBox = Me.TextBox2
			size = New System.Drawing.Size(253, 20)
			textBox21.Size = size
			Me.TextBox2.TabIndex = 13
			Me.LinkLabel2.AutoSize = True
			Me.LinkLabel2.LinkColor = Color.Red
			Dim linkLabel2 As System.Windows.Forms.LinkLabel = Me.LinkLabel2
			point = New System.Drawing.Point(332, 117)
			linkLabel2.Location = point
			Me.LinkLabel2.Name = "LinkLabel2"
			Dim linkLabel21 As System.Windows.Forms.LinkLabel = Me.LinkLabel2
			size = New System.Drawing.Size(86, 13)
			linkLabel21.Size = size
			Me.LinkLabel2.TabIndex = 10
			Me.LinkLabel2.TabStop = True
			Me.LinkLabel2.Text = "Soutenir le projet"
			Me.Label4.AutoSize = True
			Me.Label4.ForeColor = SystemColors.HotTrack
			Dim label4 As System.Windows.Forms.Label = Me.Label4
			point = New System.Drawing.Point(12, 117)
			label4.Location = point
			Me.Label4.Name = "Label4"
			Dim label41 As System.Windows.Forms.Label = Me.Label4
			size = New System.Drawing.Size(244, 13)
			label41.Size = size
			Me.Label4.TabIndex = 3
			Me.Label4.Text = "2) Soutenez le projet en achetant la license à 20€:"
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = SystemColors.ActiveCaptionText
			size = New System.Drawing.Size(513, 387)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.Label9)
			Me.Controls.Add(Me.Label8)
			Me.Controls.Add(Me.LinkLabel2)
			Me.Controls.Add(Me.LinkLabel1)
			Me.Controls.Add(Me.Label7)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Formpaypal"
			Me.Text = "Activation du logiciel"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
			Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=Q77WT2ELDK3K8")
		End Sub

		Private Sub LinkLabel2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
			Process.Start("http://goo.gl/ZB5eRK")
		End Sub
	End Class
End Namespace