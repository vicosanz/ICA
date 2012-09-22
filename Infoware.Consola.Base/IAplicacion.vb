Imports Infoware.Datos
Imports Infoware.Reglas.General
'Imports Infoware.Controles.Especiales

Public Interface IAplicacion
  Function Validacion(ByVal _Usuario As Usuario) As Boolean
  Function CargarListaGrupoOpciones(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
  'Function CargarListaOpciones() As List(Of Opcion)
  'Sub CargarListaModulos(ByVal _Principal As FrmPrincipal)
  'Delegate Sub DelegadoCargarModulos(ByVal _Principal As FrmPrincipal)
  'Sub CargarModulo(ByVal _Principal As FrmPrincipal)

  'Function CargarListaNuevos() As List(Of OpcionNuevo)
  'Function CargarListaBuscar() As List(Of OpcionBuscar)
End Interface
