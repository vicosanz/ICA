Imports Infoware.Reglas.General

#Region "GrupoOpcion"
Public Class GrupoOpcion
  Private mGrupoOpcion As ParametroDet
  Private mOpciones As List(Of Opcion)
  Private mOpcionesFavoritos As List(Of Opcion)
  Private mOpcionesReportes As List(Of Opcion)

  Public Property GrupoOpcion() As ParametroDet
    Get
      Return mGrupoOpcion
    End Get
    Set(ByVal value As ParametroDet)
      mGrupoOpcion = value
    End Set
  End Property

  Public Property Opciones() As List(Of Opcion)
    Get
      Return mOpciones
    End Get
    Set(ByVal value As List(Of Opcion))
      mOpciones = value
    End Set
  End Property

  Public Property OpcionesFavoritos() As List(Of Opcion)
    Get
      Return mOpcionesFavoritos
    End Get
    Set(ByVal value As List(Of Opcion))
      mOpcionesFavoritos = value
    End Set
  End Property

  Public Property OpcionesReportes() As List(Of Opcion)
    Get
      Return mOpcionesReportes
    End Get
    Set(ByVal value As List(Of Opcion))
      mOpcionesReportes = value
    End Set
  End Property

  Public Sub New(ByVal _GrupoOpcion As ParametroDet, ByVal _Opciones As List(Of Opcion))
    GrupoOpcion = _GrupoOpcion
    Opciones = _Opciones
    OpcionesFavoritos = New List(Of Opcion)
    OpcionesReportes = New List(Of Opcion)
  End Sub

  Public Sub New(ByVal _GrupoOpcion As ParametroDet, ByVal _Opciones As List(Of Opcion), ByVal _OpcionesFavoritos As List(Of Opcion), ByVal _OpcionesReportes As List(Of Opcion))
    GrupoOpcion = _GrupoOpcion
    Opciones = _Opciones
    OpcionesFavoritos = _OpcionesFavoritos
    OpcionesReportes = _OpcionesReportes
  End Sub
End Class
#End Region
