Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports SVPLCApplication.My
Imports SVPLCApplication.My.Resources

Namespace SVPLCApplication
	<DesignerGenerated>
	Public Class FormInternet
		Inherits Form
		Private components As IContainer

		<AccessedThroughProperty("SplitContainer1")>
		Private _SplitContainer1 As SplitContainer

		<AccessedThroughProperty("Aller")>
		Private _Aller As Button

		<AccessedThroughProperty("Suivant")>
		Private _Suivant As Button

		<AccessedThroughProperty("Précédent")>
		Private _Précédent As Button

		<AccessedThroughProperty("WebBrowser1")>
		Private _WebBrowser1 As WebBrowser

		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		Private path As String

		Private favoris As String()

		Private suppfavoris As String()

		Private compt As Integer

		Private nbrfavoris As Integer

		Friend Overridable Property Aller As Button
			Get
				Return Me._Aller
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.Aller_Click)
				If (Me._Aller IsNot Nothing) Then
					RemoveHandler Me._Aller.Click,  eventHandler
				End If
				Me._Aller = value
				If (Me._Aller IsNot Nothing) Then
					AddHandler Me._Aller.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button1 As Button
			Get
				Return Me._Button1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.Button1_Click)
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
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.Button2_Click)
				If (Me._Button2 IsNot Nothing) Then
					RemoveHandler Me._Button2.Click,  eventHandler
				End If
				Me._Button2 = value
				If (Me._Button2 IsNot Nothing) Then
					AddHandler Me._Button2.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Button3 As Button
			Get
				Return Me._Button3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.Button3_Click)
				If (Me._Button3 IsNot Nothing) Then
					RemoveHandler Me._Button3.Click,  eventHandler
				End If
				Me._Button3 = value
				If (Me._Button3 IsNot Nothing) Then
					AddHandler Me._Button3.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property ComboBox1 As ComboBox
			Get
				Return Me._ComboBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As ComboBox)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.ComboBox1_SelectedIndexChanged)
				If (Me._ComboBox1 IsNot Nothing) Then
					RemoveHandler Me._ComboBox1.SelectedIndexChanged,  eventHandler
				End If
				Me._ComboBox1 = value
				If (Me._ComboBox1 IsNot Nothing) Then
					AddHandler Me._ComboBox1.SelectedIndexChanged,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property Précédent As Button
			Get
				Return Me._Précédent
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.Précédent_Click)
				If (Me._Précédent IsNot Nothing) Then
					RemoveHandler Me._Précédent.Click,  eventHandler
				End If
				Me._Précédent = value
				If (Me._Précédent IsNot Nothing) Then
					AddHandler Me._Précédent.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property SplitContainer1 As SplitContainer
			Get
				Return Me._SplitContainer1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As SplitContainer)
				Me._SplitContainer1 = value
			End Set
		End Property

		Friend Overridable Property Suivant As Button
			Get
				Return Me._Suivant
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As Button)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.Suivant_Click)
				If (Me._Suivant IsNot Nothing) Then
					RemoveHandler Me._Suivant.Click,  eventHandler
				End If
				Me._Suivant = value
				If (Me._Suivant IsNot Nothing) Then
					AddHandler Me._Suivant.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As TextBox)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim eventHandler As System.EventHandler = New System.EventHandler(AddressOf formInternet.TextBox1_Click)
				If (Me._TextBox1 IsNot Nothing) Then
					RemoveHandler Me._TextBox1.Click,  eventHandler
				End If
				Me._TextBox1 = value
				If (Me._TextBox1 IsNot Nothing) Then
					AddHandler Me._TextBox1.Click,  eventHandler
				End If
			End Set
		End Property

		Friend Overridable Property WebBrowser1 As WebBrowser
			Get
				Return Me._WebBrowser1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(ByVal value As WebBrowser)
				Dim formInternet As SVPLCApplication.FormInternet = Me
				Dim webBrowserDocumentCompletedEventHandler As System.Windows.Forms.WebBrowserDocumentCompletedEventHandler = New System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(AddressOf formInternet.WebBrowser1_DocumentCompleted)
				If (Me._WebBrowser1 IsNot Nothing) Then
					RemoveHandler Me._WebBrowser1.DocumentCompleted,  webBrowserDocumentCompletedEventHandler
				End If
				Me._WebBrowser1 = value
				If (Me._WebBrowser1 IsNot Nothing) Then
					AddHandler Me._WebBrowser1.DocumentCompleted,  webBrowserDocumentCompletedEventHandler
				End If
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Dim formInternet1 As FormInternet = Me
			AddHandler MyBase.Load,  New EventHandler(AddressOf formInternet1.Form4_Load)
			Dim formInternet2 As FormInternet = Me
			AddHandler MyBase.FormClosed,  New FormClosedEventHandler(AddressOf formInternet2.FormBiblio_FormClosed)
			Me.InitializeComponent()
		End Sub

		Private Sub Aller_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.WebBrowser1.Navigate(Me.ComboBox1.Text)
		End Sub

		Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Try
				Dim streamWriter As System.IO.StreamWriter = File.AppendText(Me.path)
				streamWriter.WriteLine(Me.ComboBox1.Text)
				streamWriter.Flush()
				streamWriter.Close()
				streamWriter = Nothing
				Me.nbrfavoris = Me.nbrfavoris + 1
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture du nouveau favoris", "Erreur d'écriture")
				ProjectData.ClearProjectError()
			End Try
			Try
				Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.path)
				Me.compt = 0
				While streamReader.Peek() <> -1
					Me.favoris = DirectCast(Utils.CopyArray(DirectCast(Me.favoris, Array), New String(Me.compt + 1 - 1) {}), String())
					Me.favoris(Me.compt) = streamReader.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Me.nbrfavoris = Me.compt
				streamReader.Close()
			Catch exception1 As System.Exception
				ProjectData.SetProjectError(exception1)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur de lecture des favoris", "Erreur d'écriture")
				ProjectData.ClearProjectError()
			End Try
			Me.ComboBox1.Items.Clear()
			Dim num As Integer = Me.nbrfavoris - 1
			For i As Integer = 0 To num Step 1
				Me.ComboBox1.Items.Add(Me.favoris(i))
			Next

		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim num As Integer = Me.nbrfavoris - 1
			Dim num1 As Integer = 0
			Do
				If (Operators.CompareString(Me.favoris(num1), Me.WebBrowser1.Url.ToString(), False) = 0) Then
					ReDim Me.suppfavoris(Me.nbrfavoris - 2 + 1 - 1)
					Dim num2 As Integer = num1 - 1
					Dim num3 As Integer = 0
					Do
						Me.suppfavoris(num3) = Me.favoris(num3)
						num3 = num3 + 1
					Loop While num3 <= num2
					Dim num4 As Integer = Me.nbrfavoris - 2
					Dim num5 As Integer = num1
					Do
						Me.suppfavoris(num5) = Me.favoris(num5 + 1)
						num5 = num5 + 1
					Loop While num5 <= num4
					Me.nbrfavoris = Me.nbrfavoris - 1
				End If
				num1 = num1 + 1
			Loop While num1 <= num
			Try
				Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(Me.path, False, Encoding.[Default])
				Dim num6 As Integer = Me.nbrfavoris - 1
				Dim num7 As Integer = 0
				Do
					streamWriter.WriteLine(Me.suppfavoris(num7))
					num7 = num7 + 1
				Loop While num7 <= num6
				streamWriter.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur d'écriture de la base de données favoris", "Erreur d'écriture")
				ProjectData.ClearProjectError()
			End Try
			Try
				Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.path)
				Me.compt = 0
				While streamReader.Peek() <> -1
					Me.favoris = DirectCast(Utils.CopyArray(DirectCast(Me.favoris, Array), New String(Me.compt + 1 - 1) {}), String())
					Me.favoris(Me.compt) = streamReader.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Me.nbrfavoris = Me.compt
				streamReader.Close()
			Catch exception1 As System.Exception
				ProjectData.SetProjectError(exception1)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur de lecture des favoris", "Erreur d'écriture")
				ProjectData.ClearProjectError()
			End Try
			Me.ComboBox1.Items.Clear()
			Dim num8 As Integer = Me.nbrfavoris - 1
			For i As Integer = 0 To num8 Step 1
				Me.ComboBox1.Items.Add(Me.favoris(i))
			Next

		End Sub

		Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.WebBrowser1.Navigate(String.Concat("http://www.google.fr/search?q=", Me.TextBox1.Text))
		End Sub

		Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.Aller.PerformClick()
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

		Private Sub Form4_Load(ByVal sender As Object, ByVal e As EventArgs)
			Me.path = String.Concat(Application.StartupPath, "\Favoris.txt")
			Try
				Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.path)
				Me.compt = 0
				While streamReader.Peek() <> -1
					Me.favoris = DirectCast(Utils.CopyArray(DirectCast(Me.favoris, Array), New String(Me.compt + 1 - 1) {}), String())
					Me.favoris(Me.compt) = streamReader.ReadLine()
					Me.compt = Me.compt + 1
				End While
				Me.nbrfavoris = Me.compt
				streamReader.Close()
			Catch exception As System.Exception
				ProjectData.SetProjectError(exception)
				MyProject.Forms.FormPasPas.Msgboxperso("Erreur de lecture des favoris", "Erreur d'écriture")
				ProjectData.ClearProjectError()
			End Try
			Me.ComboBox1.Items.Clear()
			Dim num As Integer = Me.nbrfavoris - 1
			Dim num1 As Integer = 0
			Do
				Me.ComboBox1.Items.Add(Me.favoris(num1))
				num1 = num1 + 1
			Loop While num1 <= num
			Me.ComboBox1.Text = "http://fr.wikipedia.org/wiki/Portail:Plantes_utiles#Plantes_alimentaires"
			Me.Aller.PerformClick()
		End Sub

		Private Sub FormBiblio_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			Module1.loadbiblio = False
		End Sub

		<DebuggerStepThrough>
		Private Sub InitializeComponent()
			Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInternet))
			Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.Button2 = New System.Windows.Forms.Button()
			Me.Button1 = New System.Windows.Forms.Button()
			Me.ComboBox1 = New System.Windows.Forms.ComboBox()
			Me.Aller = New System.Windows.Forms.Button()
			Me.Suivant = New System.Windows.Forms.Button()
			Me.Précédent = New System.Windows.Forms.Button()
			Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
			Me.TextBox1 = New System.Windows.Forms.TextBox()
			Me.Button3 = New System.Windows.Forms.Button()
			DirectCast(Me.SplitContainer1, ISupportInitialize).BeginInit()
			Me.SplitContainer1.Panel1.SuspendLayout()
			Me.SplitContainer1.Panel2.SuspendLayout()
			Me.SplitContainer1.SuspendLayout()
			Me.SuspendLayout()
			Me.SplitContainer1.Dock = DockStyle.Fill
			Me.SplitContainer1.FixedPanel = FixedPanel.Panel1
			Dim splitContainer1 As System.Windows.Forms.SplitContainer = Me.SplitContainer1
			Dim point As System.Drawing.Point = New System.Drawing.Point(0, 0)
			splitContainer1.Location = point
			Me.SplitContainer1.Name = "SplitContainer1"
			Me.SplitContainer1.Orientation = Orientation.Horizontal
			Me.SplitContainer1.Panel1.BackColor = Color.FromArgb(255, 128, 0)
			Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
			Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
			Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
			Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
			Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
			Me.SplitContainer1.Panel1.Controls.Add(Me.Aller)
			Me.SplitContainer1.Panel1.Controls.Add(Me.Suivant)
			Me.SplitContainer1.Panel1.Controls.Add(Me.Précédent)
			Me.SplitContainer1.Panel1.ForeColor = SystemColors.ActiveCaptionText
			Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
			Dim splitContainer As System.Windows.Forms.SplitContainer = Me.SplitContainer1
			Dim size As System.Drawing.Size = New System.Drawing.Size(993, 539)
			splitContainer.Size = size
			Me.SplitContainer1.SplitterDistance = 37
			Me.SplitContainer1.TabIndex = 0
			Me.Button2.BackgroundImage = Resources.lovenot
			Me.Button2.BackgroundImageLayout = ImageLayout.Zoom
			Me.Button2.FlatAppearance.BorderColor = Color.Red
			Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim button2 As System.Windows.Forms.Button = Me.Button2
			point = New System.Drawing.Point(687, 4)
			button2.Location = point
			Me.Button2.Name = "Button2"
			Dim button As System.Windows.Forms.Button = Me.Button2
			size = New System.Drawing.Size(32, 30)
			button.Size = size
			Me.Button2.TabIndex = 4
			Me.Button2.UseVisualStyleBackColor = True
			Me.Button1.BackgroundImage = Resources.favoris
			Me.Button1.BackgroundImageLayout = ImageLayout.Stretch
			Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim button1 As System.Windows.Forms.Button = Me.Button1
			point = New System.Drawing.Point(649, 4)
			button1.Location = point
			Me.Button1.Name = "Button1"
			Dim button11 As System.Windows.Forms.Button = Me.Button1
			size = New System.Drawing.Size(32, 30)
			button11.Size = size
			Me.Button1.TabIndex = 3
			Me.Button1.UseVisualStyleBackColor = True
			Me.ComboBox1.BackColor = SystemColors.Window
			Me.ComboBox1.FormattingEnabled = True
			Dim comboBox1 As System.Windows.Forms.ComboBox = Me.ComboBox1
			point = New System.Drawing.Point(119, 9)
			comboBox1.Location = point
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox As System.Windows.Forms.ComboBox = Me.ComboBox1
			size = New System.Drawing.Size(502, 21)
			comboBox.Size = size
			Me.ComboBox1.TabIndex = 2
			Me.Aller.BackColor = Color.OrangeRed
			Me.Aller.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0)
			Me.Aller.FlatAppearance.BorderSize = 0
			Me.Aller.FlatStyle = FlatStyle.Flat
			Me.Aller.ForeColor = Color.Green
			Dim aller As System.Windows.Forms.Button = Me.Aller
			point = New System.Drawing.Point(622, 8)
			aller.Location = point
			Me.Aller.Name = "Aller"
			Dim aller1 As System.Windows.Forms.Button = Me.Aller
			size = New System.Drawing.Size(21, 22)
			aller1.Size = size
			Me.Aller.TabIndex = 5
			Me.Aller.Text = ">"
			Me.Aller.UseVisualStyleBackColor = False
			Me.Suivant.BackgroundImage = Resources.flechenext
			Me.Suivant.BackgroundImageLayout = ImageLayout.Stretch
			Me.Suivant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim suivant As System.Windows.Forms.Button = Me.Suivant
			point = New System.Drawing.Point(39, 3)
			suivant.Location = point
			Me.Suivant.Name = "Suivant"
			Dim suivant1 As System.Windows.Forms.Button = Me.Suivant
			size = New System.Drawing.Size(32, 31)
			suivant1.Size = size
			Me.Suivant.TabIndex = 1
			Me.Suivant.UseVisualStyleBackColor = True
			Me.Précédent.BackgroundImage = Resources.flecheback
			Me.Précédent.BackgroundImageLayout = ImageLayout.Stretch
			Me.Précédent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, FontStyle.Bold, GraphicsUnit.Point, 0)
			Dim précédent As System.Windows.Forms.Button = Me.Précédent
			point = New System.Drawing.Point(3, 3)
			précédent.Location = point
			Me.Précédent.Name = "Précédent"
			Dim précédent1 As System.Windows.Forms.Button = Me.Précédent
			size = New System.Drawing.Size(32, 31)
			précédent1.Size = size
			Me.Précédent.TabIndex = 0
			Me.Précédent.UseVisualStyleBackColor = True
			Me.WebBrowser1.Dock = DockStyle.Fill
			Dim webBrowser1 As System.Windows.Forms.WebBrowser = Me.WebBrowser1
			point = New System.Drawing.Point(0, 0)
			webBrowser1.Location = point
			Dim webBrowser As System.Windows.Forms.WebBrowser = Me.WebBrowser1
			size = New System.Drawing.Size(20, 20)
			webBrowser.MinimumSize = size
			Me.WebBrowser1.Name = "WebBrowser1"
			Me.WebBrowser1.ScriptErrorsSuppressed = True
			Dim webBrowser11 As System.Windows.Forms.WebBrowser = Me.WebBrowser1
			size = New System.Drawing.Size(993, 498)
			webBrowser11.Size = size
			Me.WebBrowser1.TabIndex = 0
			Me.TextBox1.BackColor = SystemColors.Window
			Dim textBox1 As System.Windows.Forms.TextBox = Me.TextBox1
			point = New System.Drawing.Point(750, 9)
			textBox1.Location = point
			Me.TextBox1.Name = "TextBox1"
			Dim textBox As System.Windows.Forms.TextBox = Me.TextBox1
			size = New System.Drawing.Size(176, 20)
			textBox.Size = size
			Me.TextBox1.TabIndex = 6
			Me.TextBox1.Text = "Google"
			Dim button3 As System.Windows.Forms.Button = Me.Button3
			point = New System.Drawing.Point(935, 7)
			button3.Location = point
			Me.Button3.Name = "Button3"
			Dim button31 As System.Windows.Forms.Button = Me.Button3
			size = New System.Drawing.Size(35, 23)
			button31.Size = size
			Me.Button3.TabIndex = 7
			Me.Button3.Text = "Go!"
			Me.Button3.UseVisualStyleBackColor = True
			Me.AcceptButton = Me.Button3
			Me.AutoScaleDimensions = New SizeF(6!, 13!)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			size = New System.Drawing.Size(993, 539)
			Me.ClientSize = size
			Me.Controls.Add(Me.SplitContainer1)
			Me.Icon = DirectCast(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.Name = "FormBiblio"
			Me.Text = "Bibliothèque en ligne"
			Me.SplitContainer1.Panel1.ResumeLayout(False)
			Me.SplitContainer1.Panel1.PerformLayout()
			Me.SplitContainer1.Panel2.ResumeLayout(False)
			DirectCast(Me.SplitContainer1, ISupportInitialize).EndInit()
			Me.SplitContainer1.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub

		Private Sub Précédent_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.WebBrowser1.GoBack()
		End Sub

		Private Sub Suivant_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.WebBrowser1.GoForward()
		End Sub

		Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.TextBox1.SelectAll()
		End Sub

		Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)
			Me.ComboBox1.Text = Me.WebBrowser1.Url.ToString()
			Me.Text = String.Concat("Bibliothèque en ligne - ", Me.WebBrowser1.DocumentTitle)
		End Sub
	End Class
End Namespace