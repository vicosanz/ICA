Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Interface ISistema
  ReadOnly Property DirectorioRaiz() As String
  ReadOnly Property NombrePublico() As String
  Property NombreSistema() As String
  Property DescripcionSistema() As String

  Property OperadorDatos() As OperadorDatos
  Property Ensamblado() As String

  Property Usuario() As Usuario
  Property UsuarioString() As String
  Property ContrasenaString() As String
  Property GuardarContrasena() As Boolean
  Property CargaralIniciar() As Boolean
  Function Probarconexion() As Boolean

  ReadOnly Property SistemaObjeto() As IAplicacion
End Interface
