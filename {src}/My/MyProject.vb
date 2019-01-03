Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports SVPLCApplication

Namespace SVPLCApplication.My
	<GeneratedCode("MyTemplate", "10.0.0.0")>
	<HideModuleName>
	Friend Module MyProject
		Private ReadOnly m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer)

		Private ReadOnly m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication)

		Private ReadOnly m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of Microsoft.VisualBasic.ApplicationServices.User)

		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)

		Private ReadOnly m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)

		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As Microsoft.VisualBasic.ApplicationServices.User
			<DebuggerHidden>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		Sub New()
			MyProject.m_ComputerObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()
			MyProject.m_AppObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()
			MyProject.m_UserObjectProvider = New MyProject.ThreadSafeObjectProvider(Of Microsoft.VisualBasic.ApplicationServices.User)()
			MyProject.m_MyFormsObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()
			MyProject.m_MyWebServicesObjectProvider = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()
		End Sub

		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			Public m_Calculatrice As Calculatrice

			Public m_Fiche As Fiche

			Public m_Formaddmat As Formaddmat

			Public m_Formaddrecolte As Formaddrecolte

			Public m_Formajoutbouton As Formajoutbouton

			Public m_Formapropos As Formapropos

			Public m_FormBDDASS As FormBDDASS

			Public m_FormBDDCal As FormBDDCal

			Public m_FormBDDFICHE As FormBDDFICHE

			Public m_FormBDDROT As FormBDDROT

			Public m_FormBDNumerique As FormBDNumerique

			Public m_FormBienvenue As FormBienvenue

			Public m_FormBilan As FormBilan

			Public m_Formbilanfin As Formbilanfin

			Public m_Formbmp As Formbmp

			Public m_FormCalLun As FormCalLun

			Public m_Formchangefiche As Formchangefiche

			Public m_FormCO0 As FormCO0

			Public m_FormCO1 As FormCO1

			Public m_FormCO2 As FormCO2

			Public m_FormExplicationCalendrierLunaire As FormExplicationCalendrierLunaire

			Public m_FormInputbox As FormInputbox

			Public m_FormInternet As FormInternet

			Public m_FormLOGO As FormLOGO

			Public m_FormMonJardin As FormMonJardin

			Public m_FormMSGBOXPerso As FormMSGBOXPerso

			Public m_FormPasPas As FormPasPas

			Public m_Formpaypal As Formpaypal

			Public m_Formpropphoto As Formpropphoto

			<ThreadStatic>
			Private Shared m_FormBeingCreated As Hashtable

			Public Property Calculatrice As Calculatrice
				Get
					Me.m_Calculatrice = MyProject.MyForms.Create__Instance__(Of Calculatrice)(Me.m_Calculatrice)
					Return Me.m_Calculatrice
				End Get
				Set(ByVal value As Calculatrice)
					If (value = Me.m_Calculatrice) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Calculatrice)(Me.m_Calculatrice)
				End Set
			End Property

			Public Property Fiche As Fiche
				Get
					Me.m_Fiche = MyProject.MyForms.Create__Instance__(Of Fiche)(Me.m_Fiche)
					Return Me.m_Fiche
				End Get
				Set(ByVal value As Fiche)
					If (value = Me.m_Fiche) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Fiche)(Me.m_Fiche)
				End Set
			End Property

			Public Property Formaddmat As Formaddmat
				Get
					Me.m_Formaddmat = MyProject.MyForms.Create__Instance__(Of Formaddmat)(Me.m_Formaddmat)
					Return Me.m_Formaddmat
				End Get
				Set(ByVal value As Formaddmat)
					If (value = Me.m_Formaddmat) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formaddmat)(Me.m_Formaddmat)
				End Set
			End Property

			Public Property Formaddrecolte As Formaddrecolte
				Get
					Me.m_Formaddrecolte = MyProject.MyForms.Create__Instance__(Of Formaddrecolte)(Me.m_Formaddrecolte)
					Return Me.m_Formaddrecolte
				End Get
				Set(ByVal value As Formaddrecolte)
					If (value = Me.m_Formaddrecolte) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formaddrecolte)(Me.m_Formaddrecolte)
				End Set
			End Property

			Public Property Formajoutbouton As Formajoutbouton
				Get
					Me.m_Formajoutbouton = MyProject.MyForms.Create__Instance__(Of Formajoutbouton)(Me.m_Formajoutbouton)
					Return Me.m_Formajoutbouton
				End Get
				Set(ByVal value As Formajoutbouton)
					If (value = Me.m_Formajoutbouton) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formajoutbouton)(Me.m_Formajoutbouton)
				End Set
			End Property

			Public Property Formapropos As Formapropos
				Get
					Me.m_Formapropos = MyProject.MyForms.Create__Instance__(Of Formapropos)(Me.m_Formapropos)
					Return Me.m_Formapropos
				End Get
				Set(ByVal value As Formapropos)
					If (value = Me.m_Formapropos) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formapropos)(Me.m_Formapropos)
				End Set
			End Property

			Public Property FormBDDASS As FormBDDASS
				Get
					Me.m_FormBDDASS = MyProject.MyForms.Create__Instance__(Of FormBDDASS)(Me.m_FormBDDASS)
					Return Me.m_FormBDDASS
				End Get
				Set(ByVal value As FormBDDASS)
					If (value = Me.m_FormBDDASS) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormBDDASS)(Me.m_FormBDDASS)
				End Set
			End Property

			Public Property FormBDDCal As FormBDDCal
				Get
					Me.m_FormBDDCal = MyProject.MyForms.Create__Instance__(Of FormBDDCal)(Me.m_FormBDDCal)
					Return Me.m_FormBDDCal
				End Get
				Set(ByVal value As FormBDDCal)
					If (value = Me.m_FormBDDCal) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormBDDCal)(Me.m_FormBDDCal)
				End Set
			End Property

			Public Property FormBDDFICHE As FormBDDFICHE
				Get
					Me.m_FormBDDFICHE = MyProject.MyForms.Create__Instance__(Of FormBDDFICHE)(Me.m_FormBDDFICHE)
					Return Me.m_FormBDDFICHE
				End Get
				Set(ByVal value As FormBDDFICHE)
					If (value = Me.m_FormBDDFICHE) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormBDDFICHE)(Me.m_FormBDDFICHE)
				End Set
			End Property

			Public Property FormBDDROT As FormBDDROT
				Get
					Me.m_FormBDDROT = MyProject.MyForms.Create__Instance__(Of FormBDDROT)(Me.m_FormBDDROT)
					Return Me.m_FormBDDROT
				End Get
				Set(ByVal value As FormBDDROT)
					If (value = Me.m_FormBDDROT) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormBDDROT)(Me.m_FormBDDROT)
				End Set
			End Property

			Public Property FormBDNumerique As FormBDNumerique
				Get
					Me.m_FormBDNumerique = MyProject.MyForms.Create__Instance__(Of FormBDNumerique)(Me.m_FormBDNumerique)
					Return Me.m_FormBDNumerique
				End Get
				Set(ByVal value As FormBDNumerique)
					If (value = Me.m_FormBDNumerique) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormBDNumerique)(Me.m_FormBDNumerique)
				End Set
			End Property

			Public Property FormBienvenue As FormBienvenue
				Get
					Me.m_FormBienvenue = MyProject.MyForms.Create__Instance__(Of FormBienvenue)(Me.m_FormBienvenue)
					Return Me.m_FormBienvenue
				End Get
				Set(ByVal value As FormBienvenue)
					If (value = Me.m_FormBienvenue) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormBienvenue)(Me.m_FormBienvenue)
				End Set
			End Property

			Public Property FormBilan As FormBilan
				Get
					Me.m_FormBilan = MyProject.MyForms.Create__Instance__(Of FormBilan)(Me.m_FormBilan)
					Return Me.m_FormBilan
				End Get
				Set(ByVal value As FormBilan)
					If (value = Me.m_FormBilan) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormBilan)(Me.m_FormBilan)
				End Set
			End Property

			Public Property Formbilanfin As Formbilanfin
				Get
					Me.m_Formbilanfin = MyProject.MyForms.Create__Instance__(Of Formbilanfin)(Me.m_Formbilanfin)
					Return Me.m_Formbilanfin
				End Get
				Set(ByVal value As Formbilanfin)
					If (value = Me.m_Formbilanfin) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formbilanfin)(Me.m_Formbilanfin)
				End Set
			End Property

			Public Property Formbmp As Formbmp
				Get
					Me.m_Formbmp = MyProject.MyForms.Create__Instance__(Of Formbmp)(Me.m_Formbmp)
					Return Me.m_Formbmp
				End Get
				Set(ByVal value As Formbmp)
					If (value = Me.m_Formbmp) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formbmp)(Me.m_Formbmp)
				End Set
			End Property

			Public Property FormCalLun As FormCalLun
				Get
					Me.m_FormCalLun = MyProject.MyForms.Create__Instance__(Of FormCalLun)(Me.m_FormCalLun)
					Return Me.m_FormCalLun
				End Get
				Set(ByVal value As FormCalLun)
					If (value = Me.m_FormCalLun) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormCalLun)(Me.m_FormCalLun)
				End Set
			End Property

			Public Property Formchangefiche As Formchangefiche
				Get
					Me.m_Formchangefiche = MyProject.MyForms.Create__Instance__(Of Formchangefiche)(Me.m_Formchangefiche)
					Return Me.m_Formchangefiche
				End Get
				Set(ByVal value As Formchangefiche)
					If (value = Me.m_Formchangefiche) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formchangefiche)(Me.m_Formchangefiche)
				End Set
			End Property

			Public Property FormCO0 As FormCO0
				Get
					Me.m_FormCO0 = MyProject.MyForms.Create__Instance__(Of FormCO0)(Me.m_FormCO0)
					Return Me.m_FormCO0
				End Get
				Set(ByVal value As FormCO0)
					If (value = Me.m_FormCO0) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormCO0)(Me.m_FormCO0)
				End Set
			End Property

			Public Property FormCO1 As FormCO1
				Get
					Me.m_FormCO1 = MyProject.MyForms.Create__Instance__(Of FormCO1)(Me.m_FormCO1)
					Return Me.m_FormCO1
				End Get
				Set(ByVal value As FormCO1)
					If (value = Me.m_FormCO1) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormCO1)(Me.m_FormCO1)
				End Set
			End Property

			Public Property FormCO2 As FormCO2
				Get
					Me.m_FormCO2 = MyProject.MyForms.Create__Instance__(Of FormCO2)(Me.m_FormCO2)
					Return Me.m_FormCO2
				End Get
				Set(ByVal value As FormCO2)
					If (value = Me.m_FormCO2) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormCO2)(Me.m_FormCO2)
				End Set
			End Property

			Public Property FormExplicationCalendrierLunaire As FormExplicationCalendrierLunaire
				Get
					Me.m_FormExplicationCalendrierLunaire = MyProject.MyForms.Create__Instance__(Of FormExplicationCalendrierLunaire)(Me.m_FormExplicationCalendrierLunaire)
					Return Me.m_FormExplicationCalendrierLunaire
				End Get
				Set(ByVal value As FormExplicationCalendrierLunaire)
					If (value = Me.m_FormExplicationCalendrierLunaire) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormExplicationCalendrierLunaire)(Me.m_FormExplicationCalendrierLunaire)
				End Set
			End Property

			Public Property FormInputbox As FormInputbox
				Get
					Me.m_FormInputbox = MyProject.MyForms.Create__Instance__(Of FormInputbox)(Me.m_FormInputbox)
					Return Me.m_FormInputbox
				End Get
				Set(ByVal value As FormInputbox)
					If (value = Me.m_FormInputbox) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormInputbox)(Me.m_FormInputbox)
				End Set
			End Property

			Public Property FormInternet As FormInternet
				Get
					Me.m_FormInternet = MyProject.MyForms.Create__Instance__(Of FormInternet)(Me.m_FormInternet)
					Return Me.m_FormInternet
				End Get
				Set(ByVal value As FormInternet)
					If (value = Me.m_FormInternet) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormInternet)(Me.m_FormInternet)
				End Set
			End Property

			Public Property FormLOGO As FormLOGO
				Get
					Me.m_FormLOGO = MyProject.MyForms.Create__Instance__(Of FormLOGO)(Me.m_FormLOGO)
					Return Me.m_FormLOGO
				End Get
				Set(ByVal value As FormLOGO)
					If (value = Me.m_FormLOGO) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormLOGO)(Me.m_FormLOGO)
				End Set
			End Property

			Public Property FormMonJardin As FormMonJardin
				Get
					Me.m_FormMonJardin = MyProject.MyForms.Create__Instance__(Of FormMonJardin)(Me.m_FormMonJardin)
					Return Me.m_FormMonJardin
				End Get
				Set(ByVal value As FormMonJardin)
					If (value = Me.m_FormMonJardin) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormMonJardin)(Me.m_FormMonJardin)
				End Set
			End Property

			Public Property FormMSGBOXPerso As FormMSGBOXPerso
				Get
					Me.m_FormMSGBOXPerso = MyProject.MyForms.Create__Instance__(Of FormMSGBOXPerso)(Me.m_FormMSGBOXPerso)
					Return Me.m_FormMSGBOXPerso
				End Get
				Set(ByVal value As FormMSGBOXPerso)
					If (value = Me.m_FormMSGBOXPerso) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormMSGBOXPerso)(Me.m_FormMSGBOXPerso)
				End Set
			End Property

			Public Property FormPasPas As FormPasPas
				Get
					Me.m_FormPasPas = MyProject.MyForms.Create__Instance__(Of FormPasPas)(Me.m_FormPasPas)
					Return Me.m_FormPasPas
				End Get
				Set(ByVal value As FormPasPas)
					If (value = Me.m_FormPasPas) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of FormPasPas)(Me.m_FormPasPas)
				End Set
			End Property

			Public Property Formpaypal As Formpaypal
				Get
					Me.m_Formpaypal = MyProject.MyForms.Create__Instance__(Of Formpaypal)(Me.m_Formpaypal)
					Return Me.m_Formpaypal
				End Get
				Set(ByVal value As Formpaypal)
					If (value = Me.m_Formpaypal) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formpaypal)(Me.m_Formpaypal)
				End Set
			End Property

			Public Property Formpropphoto As Formpropphoto
				Get
					Me.m_Formpropphoto = MyProject.MyForms.Create__Instance__(Of Formpropphoto)(Me.m_Formpropphoto)
					Return Me.m_Formpropphoto
				End Get
				Set(ByVal value As Formpropphoto)
					If (value = Me.m_Formpropphoto) Then
						Return
					End If
					If (value IsNot Nothing) Then
						Throw New ArgumentException("Property can only be set to Nothing")
					End If
					Me.Dispose__Instance__(Of Formpropphoto)(Me.m_Formpropphoto)
				End Set
			End Property

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
				MyBase.New()
			End Sub

			<DebuggerHidden>
			Private Shared Function Create__Instance__(Of T As {Form, New})(ByVal Instance As T) As T
				Dim t1 As T
				If (Instance IsNot Nothing AndAlso Not Instance.IsDisposed) Then
					Return Instance
				End If
				If (MyProject.MyForms.m_FormBeingCreated Is Nothing) Then
					MyProject.MyForms.m_FormBeingCreated = New Hashtable()
				ElseIf (MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))) Then
					Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
				End If
				MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
				Try
					Try
						t1 = Activator.CreateInstance(Of T)()
					Catch targetInvocationException As System.Reflection.TargetInvocationException When targetInvocationException.InnerException IsNot Nothing
						Dim message() As String = { targetInvocationException.InnerException.Message }
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", message)
						Throw New InvalidOperationException(resourceString, targetInvocationException.InnerException)
					End Try
				Finally
					MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
				End Try
				Return t1
			End Function

			<DebuggerHidden>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(ByVal o As Object) As Boolean
				Return Me.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return Me.GetHashCode()
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Shadows Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return Me.ToString()
			End Function
		End Class

		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
				MyBase.New()
			End Sub

			<DebuggerHidden>
			Private Shared Function Create__Instance__(Of T As New)(ByVal instance As T) As T
				If (instance Is Nothing) Then
					Return Activator.CreateInstance(Of T)()
				End If
				Return instance
			End Function

			<DebuggerHidden>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(ByVal o As Object) As Boolean
				Return Me.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return Me.GetHashCode()
			End Function

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Shadows Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return Me.ToString()
			End Function
		End Class

		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			<CompilerGenerated>
			<ThreadStatic>
			Private Shared m_ThreadStaticValue As T

			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden>
				Get
					If (MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing) Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			<DebuggerHidden>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
				MyBase.New()
			End Sub
		End Class
	End Module
End Namespace