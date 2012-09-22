Imports Infoware.Reglas.General

#Region "Opcion"
Public Class Opcion
  Delegate Function DelegadoCargarOpcion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent

  Private mObjCargarOpcion As DelegadoCargarOpcion
  Private mRestriccion As Restriccion
  Private mDescripcionAlternativa As String
  Private mTag As Object

  Public Property Restriccion() As Restriccion
    Get
      Return mRestriccion
    End Get
    Set(ByVal value As Restriccion)
      mRestriccion = value
    End Set
  End Property

  Public Property DescripcionAlternativa() As String
    Get
      Return mDescripcionAlternativa
    End Get
    Set(ByVal value As String)
      mDescripcionAlternativa = value
    End Set
  End Property

  Public Property ObjCargarOpcion() As DelegadoCargarOpcion
    Get
      Return mObjCargarOpcion
    End Get
    Set(ByVal value As DelegadoCargarOpcion)
      mObjCargarOpcion = value
    End Set
  End Property

  Public Property Tag() As Object
    Get
      Return mTag
    End Get
    Set(ByVal value As Object)
      mTag = value
    End Set
  End Property

  Public Function CargarOpcion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion) As Infoware.Docking.IDockContent
    Dim _submodulo As DelegadoCargarOpcion = mObjCargarOpcion
    Return _submodulo(_Sistema, _Restriccion, me)
  End Function

  Public Sub New(ByVal _Restriccion As Restriccion, ByVal _ObjCargarOpcion As DelegadoCargarOpcion, Optional ByVal _DescripcionAlternativa As String = "", Optional ByVal _Tag As Object = Nothing)
    Restriccion = _Restriccion
    ObjCargarOpcion = _ObjCargarOpcion
    DescripcionAlternativa = _DescripcionAlternativa
    Tag = _Tag
  End Sub
End Class
#End Region
