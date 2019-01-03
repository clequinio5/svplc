Imports Microsoft.VisualBasic.ApplicationServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports SVPLCApplication

Namespace SVPLCApplication.My
	<EditorBrowsable(EditorBrowsableState.Never)>
	<GeneratedCode("MyTemplate", "10.0.0.0")>
	Friend Class MyApplication
		Inherits WindowsFormsApplicationBase
		Private charg As FormLOGO

		Private Const hauteurref As Integer = 962

		Private Const largeurref As Integer = 1403

		Public PH As Decimal

		Public PL As Decimal

		Public mincoeff As Decimal

		Public hauteurscreen As Integer

		Public largeurscreen As Integer

		<DebuggerStepThrough>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Dim myApplication1 As MyApplication = Me
			AddHandler MyBase.Startup,  New StartupEventHandler(AddressOf myApplication1.MyApplication_Startup)
			Me.IsSingleInstance = True
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
		End Sub

		<DebuggerHidden>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		<STAThread>
		Friend Shared Sub Main(ByVal Args As String())
			Try
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering)
			Finally
			End Try
			MyProject.Application.Run(Args)
		End Sub

		Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
			Me.charg = New FormLOGO()
			Me.charg.Show()
			Dim bounds As Rectangle = Screen.PrimaryScreen.Bounds
			Dim size As System.Drawing.Size = bounds.Size
			Me.hauteurscreen = size.Height
			bounds = Screen.PrimaryScreen.Bounds
			size = bounds.Size
			Me.largeurscreen = size.Width
			Me.PH = New Decimal(CDbl(Me.hauteurscreen) / 962)
			Me.PL = New Decimal(CDbl(Me.largeurscreen) / 1403)
			If (Decimal.Compare(Me.PL, Me.PH) >= 0) Then
				Me.mincoeff = Me.PH
			Else
				Me.mincoeff = Me.PL
			End If
		End Sub

		<DebuggerStepThrough>
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = MyProject.Forms.FormPasPas
		End Sub
	End Class
End Namespace