Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Threading

Namespace SVPLCApplication.My
	<CompilerGenerated>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
	Friend NotInheritable Class MySettings
		Inherits ApplicationSettingsBase
		Private Shared defaultInstance As MySettings

		Private Shared addedHandler As Boolean

		Private Shared addedHandlerLockObject As Object

		Public ReadOnly Shared Property [Default] As MySettings
			Get
				If (Not MySettings.addedHandler) Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					Dim flag As Boolean = False
					Try
						Monitor.Enter(obj, flag)
						If (Not MySettings.addedHandler) Then
							AddHandler MyProject.Application.Shutdown,  New ShutdownEventHandler(AddressOf MySettings.AutoSaveSettings)
							MySettings.addedHandler = True
						End If
					Finally
						If (flag) Then
							Monitor.[Exit](obj)
						End If
					End Try
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		Shared Sub New()
			MySettings.defaultInstance = DirectCast(SettingsBase.Synchronized(New MySettings()), MySettings)
			MySettings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(New Object())
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		<DebuggerNonUserCode>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As EventArgs)
			If (MyProject.Application.SaveMySettingsOnExit) Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub
	End Class
End Namespace