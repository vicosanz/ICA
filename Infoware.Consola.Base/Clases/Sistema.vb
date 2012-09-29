Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports System.Xml.Serialization
Imports System.IO
Imports System.Xml

Public Class Sistema
  Implements ISistema

  Private mUsuarioString As String = ""
  Private mContrasenaString As String = ""
  Private mGuardarContrasena As Boolean = False
  Private mCargaraliniciar As Boolean = False
  Private mCargarAhora As Boolean = False

  Private mNombreSistema As String = ""
  Private mDescripcionSistema As String = ""
  Private mEnsamblado As String = ""
  Private mOperadorDatos As OperadorDatos = Nothing

  Private mUsuario As Usuario = Nothing

  Private mSistemaObjeto As IAplicacion = Nothing

  Public ReadOnly Property NombrePublico() As String Implements ISistema.NombrePublico
    Get
      If String.IsNullOrEmpty(mNombreSistema) Then
        Return String.Format("{0} {1}", System.IO.Path.GetFileNameWithoutExtension(mEnsamblado), OperadorDatos.Descripcion)
      Else
        Return mNombreSistema.Trim
      End If
    End Get
  End Property

  Public ReadOnly Property DirectorioRaiz() As String Implements ISistema.DirectorioRaiz
    Get
      Dim _nombre As String = NombrePublico
      For Each _caracter As Char In Path.GetInvalidFileNameChars
        _nombre = _nombre.Replace(_caracter, "")
      Next 
      Return Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, _nombre)
    End Get
  End Property

  <XmlElement()> _
  Public Property DescripcionSistema() As String Implements ISistema.DescripcionSistema
    Get
      Return mDescripcionSistema
    End Get
    Set(ByVal value As String)
      mDescripcionSistema = value
    End Set
  End Property

  <XmlElement()> _
  Public Property Ensamblado() As String Implements ISistema.Ensamblado
    Get
      Return mEnsamblado
    End Get
    Set(ByVal value As String)
      mEnsamblado = value
    End Set
  End Property

  <XmlElement()> _
  Public Property NombreSistema() As String Implements ISistema.NombreSistema
    Get
      Return mNombreSistema
    End Get
    Set(ByVal value As String)
      mNombreSistema = value
    End Set
  End Property

  <XmlElement()> _
  Public Property GuardarContrasena() As Boolean Implements ISistema.GuardarContrasena
    Get
      Return mGuardarContrasena
    End Get
    Set(ByVal value As Boolean)
      mGuardarContrasena = value
    End Set
  End Property

  <XmlElement()> _
  Public Property Cargaraliniciar() As Boolean Implements ISistema.CargaralIniciar
    Get
      Return mCargaraliniciar
    End Get
    Set(ByVal value As Boolean)
      mCargaraliniciar = value
    End Set
  End Property

  <XmlIgnore()> _
  Public Property CargarAhora() As Boolean
    Get
      Return mCargarAhora
    End Get
    Set(ByVal value As Boolean)
      mCargarAhora = value
    End Set
  End Property

  <XmlIgnore()> _
  Public Property ContrasenaString() As String Implements ISistema.ContrasenaString
    Get
      Return mContrasenaString
    End Get
    Set(ByVal value As String)
      mContrasenaString = value
    End Set
  End Property

  <XmlElement()> _
  Public Property ContrasenaString2() As String
    Get
      If GuardarContrasena Then
        Return mContrasenaString
      Else
        Return String.Empty
      End If
    End Get
    Set(ByVal value As String)
      If GuardarContrasena Then
        mContrasenaString = value
      End If
    End Set
  End Property

  Public Property OperadorDatos() As Datos.OperadorDatos Implements ISistema.OperadorDatos
    Get
      If mOperadorDatos Is Nothing Then
        mOperadorDatos = Nothing  'New OperadorDatos()
      End If

      Return mOperadorDatos
    End Get
    Set(ByVal value As Datos.OperadorDatos)
      mOperadorDatos = value
    End Set
  End Property

  <XmlIgnore()> _
  Public Property Usuario() As Reglas.General.Usuario Implements ISistema.Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Reglas.General.Usuario)
      mUsuario = value
    End Set
  End Property

  <XmlElement()> _
  Public Property UsuarioString() As String Implements ISistema.UsuarioString
    Get
      Return mUsuarioString
    End Get
    Set(ByVal value As String)
      mUsuarioString = value
    End Set
  End Property

  Public Function Probarconexion() As Boolean Implements ISistema.Probarconexion
    Try
      mUsuario = New Usuario(OperadorDatos, mUsuarioString)
      If Not mUsuario.VerificarPassword(mContrasenaString) Then
        Throw New Exception("Error al autenticarse" & Environment.NewLine & "Posibles causas:" & Environment.NewLine & "Revise que tenga acceso al servidor, que el servidor de datos este activo " & Environment.NewLine & "y además que el usuario y la clave sean correctas")
      End If

      If SistemaObjeto Is Nothing Then
        Throw New Exception(String.Format("Error al cargar aplicación {0}. Por favor vuelva a intentarlo más tarde o remueva la aplicación. {1}", NombrePublico, MensajeError))
      End If
      Return True
    Catch ex As Exception
      mMensajeError = ex.Message
      Return False
    End Try
  End Function

  Private mMensajeError As String = ""
  <XmlIgnore()> _
  Public ReadOnly Property MensajeError() As String
    Get
      Return mMensajeError
    End Get
  End Property

  <XmlIgnore()> _
  Public ReadOnly Property Restricciones() As RestriccionList
    Get
      If mUsuario Is Nothing Then
        Return Nothing
      End If
      Return mUsuario.Restricciones
    End Get
  End Property

  Public ReadOnly Property SistemaObjeto() As IAplicacion Implements ISistema.SistemaObjeto
    Get
      If mSistemaObjeto Is Nothing Then
        If String.IsNullOrEmpty(mEnsamblado) Then
          mMensajeError = "No se ha especificado la ruta del ensamblado"
          Return Nothing
        End If
        Dim _assembly As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(mEnsamblado)
        For Each _type As Type In _assembly.GetTypes
          If _type.Name.Trim.ToUpper = "INICIALIZACION" Then
            Dim obj As IAplicacion = System.Activator.CreateInstance(_type)
            If obj.Validacion(Usuario) Then
              mSistemaObjeto = obj
            End If
          End If
        Next
      End If
      Return mSistemaObjeto
    End Get
  End Property
End Class

Public Class SistemaList
  Inherits System.ComponentModel.BindingList(Of Sistema)

  Public Shared Sub SerializeList(ByVal _SistemaList As SistemaList, ByVal filename As String)
    Dim x As XmlSerializer = New XmlSerializer(GetType(SistemaList), New Type() {GetType(SQLOperadorDatos), GetType(SybaseOperadorDatos)})

    Dim writer As TextWriter = New StreamWriter(filename)
    x.Serialize(writer, _SistemaList)
    writer.Close()
  End Sub

  Public Shared Function DeSerializeList(ByVal filename As String) As SistemaList
    Dim oResult As New SistemaList
    Try
      Dim myFileStream As FileStream = New FileStream(filename, FileMode.Open)
      Dim reader As New XmlTextReader(myFileStream)
      Dim serializer As New XmlSerializer(GetType(SistemaList), New Type() {GetType(SQLOperadorDatos), GetType(SybaseOperadorDatos)})
      If serializer.CanDeserialize(reader) Then
        oResult = serializer.Deserialize(reader)
      End If
      myFileStream.Close()
    Catch ex As Exception
    End Try
    Return oResult
  End Function
End Class
