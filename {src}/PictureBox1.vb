Imports System
Imports System.Windows.Forms

Namespace SVPLCApplication
	Public Class PictureBox1
		Inherits PictureBox
		Private indplante As Integer

		Private indamen As Integer

		Private indsurf As Integer

		Private intcx As Integer

		Private intcy As Integer

		Private tag2 As String

		Public Property CX As Integer
			Get
				Return Me.intcx
			End Get
			Set(ByVal value As Integer)
				Me.intcx = value
			End Set
		End Property

		Public Property CY As Integer
			Get
				Return Me.intcy
			End Get
			Set(ByVal value As Integer)
				Me.intcy = value
			End Set
		End Property

		Public Property Indexa As Integer
			Get
				Return Me.indamen
			End Get
			Set(ByVal value As Integer)
				Me.indamen = value
			End Set
		End Property

		Public Property Indexp As Integer
			Get
				Return Me.indplante
			End Get
			Set(ByVal value As Integer)
				Me.indplante = value
			End Set
		End Property

		Public Property Indexs As Integer
			Get
				Return Me.indsurf
			End Get
			Set(ByVal value As Integer)
				Me.indsurf = value
			End Set
		End Property

		Public Property Tagfix As String
			Get
				Return Me.tag2
			End Get
			Set(ByVal value As String)
				Me.tag2 = value
			End Set
		End Property

		Public Sub New()
			MyBase.New()
			Me.indplante = -1
			Me.indamen = -1
			Me.indsurf = -1
			Me.intcx = -1
			Me.intcy = -1
			Me.tag2 = Nothing
			Me.Indexp = Me.indplante
			Me.Indexa = Me.indamen
			Me.Indexs = Me.indsurf
			Me.CX = Me.intcx
			Me.CY = Me.intcy
			Me.Tagfix = Me.tag2
		End Sub
	End Class
End Namespace