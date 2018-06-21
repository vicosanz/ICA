Imports System.Windows.Forms
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports System
Imports System.Text
Imports System.Xml.Serialization
Imports System.IO
Imports Infoware.Docking
Imports System.Deployment

Public Class FrmPrincipal
  'Private ArchSesion As String = ""

  Private mToolBoxSistemas As ToolBoxSistemas
  Private mToolBoxModulos As ToolBoxModulos
  Private mToolBoxFavoritos As ToolBoxFavoritos
  Private mToolBoxReportes As ToolBoxReportes
  Private m_deserializeDockContent As DeserializeDockContent

  Private configFile As String

  Private Sub FrmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    mToolBoxReportes.Show(DockPanel1)
    mToolBoxFavoritos.Show(DockPanel1)
    mToolBoxModulos.Show(DockPanel1)
    mToolBoxSistemas.Show(DockPanel1)

    Try
      DockPanel1.SaveAsXml(configFile)
    Catch ex As Exception

    End Try
    CloseAllDocuments()
  End Sub

  Private Sub FrmPrincipal_PantallaCompleta(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PantallaCompleta
    If Me.esPantallaCompleta Then
      Me.WindowState = FormWindowState.Maximized
      mToolBoxReportes.Hide()
      mToolBoxFavoritos.Hide()
      mToolBoxModulos.Hide()
      mToolBoxSistemas.Hide()
      Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
      Me.Invalidate()
      Me.tmrFullScreen.Enabled = True
    Else
      Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
      mToolBoxReportes.Show(DockPanel1)
      mToolBoxFavoritos.Show(DockPanel1)
      mToolBoxModulos.Show(DockPanel1)
      mToolBoxSistemas.Show(DockPanel1)
      Me.tmrFullScreen.Enabled = False

      Me.pnlhidemenu.Visible = False
      Me.MenuStrip.Visible = True
      Me.tmrFullScreen.Enabled = False
    End If
  End Sub

  Private Function GetContentFromPersistString(ByVal persistString As String) As IDockContent
    If persistString = GetType(ToolBoxSistemas).FullName Then
      Return mToolBoxSistemas
    ElseIf persistString = GetType(ToolBoxModulos).FullName Then
      Return mToolBoxModulos
    ElseIf persistString = GetType(ToolBoxFavoritos).FullName Then
      Return mToolBoxFavoritos
    ElseIf persistString = GetType(ToolBoxReportes).FullName Then
      Return mToolBoxReportes
    Else
      'DummyDoc overrides GetPersistString to add extra information into persistString.
      'Any DockContent may override this value to add any needed information for deserialization.

      Dim parsedStrings As String() = persistString.Split(New Char() {","})
      If Not parsedStrings.Length = 3 Then
        Return Nothing
      End If

      'if (not parsedStrings(0) = typeof(DummyDoc).ToString())
      '    Return Nothing
      '  End If

      '  (dummyDoc = New DummyDoc())
      'if (parsedStrings[1] != string.Empty)
      '	dummyDoc.FileName = parsedStrings[1]
      'if (parsedStrings[2] != string.Empty)
      '	dummyDoc.Text = parsedStrings[2]

      '      Return dummyDoc
      Return Nothing
    End If
  End Function

  Private Sub CloseAllDocuments()

    If (DockPanel1.DocumentStyle = DocumentStyle.SystemMdi) Then
      For Each forma As Form In MdiChildren
        forma.Close()
      Next
    Else
      For index As Integer = DockPanel1.Contents.Count - 1 To 0 Step -1
        If TypeOf DockPanel1.Contents(index) Is IDockContent Then
          Dim content As IDockContent = DockPanel1.Contents(index)
          content.DockHandler.Close()
        End If
      Next
    End If
  End Sub

  'Private Sub FrmPrincipal_AbrirSesion(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AbrirSesion
  '  mAssemblies = DeSerializeList(ArchSesion)
  '  'RefrescarAplicaciones()
  'End Sub

  'Private Sub FrmPrincipal_GuardarSesion(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GuardarSesion
  '  SerializeList(mAssemblies, ArchSesion)
  'End Sub

  'Public Sub SerializeList(ByVal _source As List(Of String), ByVal filename As String)
  '  Dim x As XmlSerializer = New XmlSerializer(GetType(List(Of String)))
  '  Dim writer As TextWriter = New StreamWriter(filename)
  '  x.Serialize(writer, _source)
  '  writer.Close()
  'End Sub

  'Public Function DeSerializeList(ByVal filename As String) As List(Of String)
  '  Dim oResult As New List(Of String)
  '  Try
  '    Dim myFileStream As FileStream = New FileStream(filename, FileMode.Open)
  '    Dim reader As New Xml.XmlTextReader(myFileStream)
  '    Dim serializer As New XmlSerializer(GetType(List(Of String)))
  '    If serializer.CanDeserialize(reader) Then
  '      oResult = serializer.Deserialize(reader)
  '    End If
  '    myFileStream.Close()
  '  Catch ex As Exception
  '  End Try
  '  Return oResult
  'End Function

  Private Sub FrmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.Text = My.Application.Info.Title
    '  'AplicacionDatos.CrearMenuAyuda(MenuAyuda, Nothing)

    '  If My.Application.CommandLineArgs.Count > 0 AndAlso Not My.Application.CommandLineArgs(0) = "endebug" Then
    '    Dim comandos(My.Application.CommandLineArgs.Count - 1) As String
    '    Dim t As Integer = 0
    '    For Each _arg As String In My.Application.CommandLineArgs
    '      comandos(t) = _arg
    '      t += 1
    '    Next
    '    Cargar_Assemblies(comandos)
    '  End If
    '  'ToolStripManager.Merge(Me.MenuStrip1, Me.MenuStrip)
  End Sub

  'Private mAssemblies As New List(Of String)

  'Private Sub AgregarComplementosToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.OnAgregarBotones, Me.AgregarComplementos
  '  With Me.OpenFileDialog1
  '    .FileName = ""
  '    .Filter = "Ejecutable compatible (*.exe)|*.exe|Libreria compatible (*.dll)|*.dll|Todos los archivos (*.*)|*.*"

  '    If .ShowDialog = Windows.Forms.DialogResult.OK Then
  '      Cargar_Assemblies(.FileNames)
  '    End If
  '  End With
  'End Sub

  'Sub Cargar_Assemblies(ByVal _archivos As String())
  '  For Each _archivo As String In _archivos
  '    Dim existe As Boolean = False
  '    For Each _assem As String In mAssemblies
  '      If System.IO.File.Equals(_archivo, _assem) Then
  '        existe = True
  '      End If
  '    Next
  '    If Not existe Then
  '      Try
  '        Dim _assembly As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(_archivo)
  '        Dim _pudoinicializar As Boolean = False
  '        For Each _type As Type In _assembly.GetTypes
  '          If _type.Name.Trim.ToUpper = "INICIALIZACION" Then
  '            _pudoinicializar = True
  '            Dim obj As IAplicacion = System.Activator.CreateInstance(_type)
  '            If obj.Validacion(AplicacionDatos.Usuario) Then
  '              mAssemblies.Add(_archivo)
  '            Else
  '              'MsgBox(String.Format("La aplicación {0} no pudo inicializar. Verifique que sea válida en este contexto", _archivo), MsgBoxStyle.Exclamation, "Información")
  '            End If
  '          End If
  '        Next
  '        If Not _pudoinicializar Then
  '          MsgBox(String.Format("La aplicación {0} no es válida para este sistema", _archivo), MsgBoxStyle.Exclamation, "Información")
  '          Exit Sub
  '        End If
  '      Catch ex As Exception
  '        MsgBox(String.Format("Error al cargar aplicación {0}. compruebe que sea una aplicación válida. {1}", _archivo, ex.Message), MsgBoxStyle.Critical, "Error")
  '        Exit Sub
  '      End Try
  '    End If
  '  Next
  '  RefrescarAplicaciones()
  'End Sub

  'Private Sub RefrescarAplicaciones()
  '  '' ''LeftSpine1.Items.Clear()
  '  AplicacionDatos.OpcionesNuevo.Clear()
  '  AplicacionDatos.OpcionesBuscar.Clear()
  '  For Each _assem As String In mAssemblies
  '    Try
  '      Dim _assembly As System.Reflection.Assembly = System.Reflection.Assembly.LoadFrom(_assem)
  '      For Each _type As Type In _assembly.GetTypes
  '        If _type.Name.Trim.ToUpper = "INICIALIZACION" Then
  '          Dim obj As IAplicacion = System.Activator.CreateInstance(_type)
  '          If obj.Validacion(AplicacionDatos.Usuario) Then
  '            'obj.CargarListaOpciones()
  '            AplicacionDatos.OpcionesNuevo.AddRange(obj.CargarListaNuevos)
  '            AplicacionDatos.OpcionesBuscar.AddRange(obj.CargarListaBuscar)
  '          End If

  '        End If
  '      Next
  '      '' ''LeftSpine1.Refrescar()
  '      '' ''LeftSpine1.Opcion = 0
  '    Catch ex As Exception
  '      MsgBox(String.Format("Error al cargar aplicación {0}. Por favor vuelva a intentarlo más tarde o remueva la aplicación", _assem), MsgBoxStyle.Critical, "Error")
  '    End Try
  '  Next

  '  AplicacionDatos.CrearMenuNuevo(Me.MenuNuevo, Me.btnnuevo)
  '  AplicacionDatos.CrearMenuAyuda(MenuAyuda, Nothing)

  '  Dim _buscalista As New List(Of OpcionBuscar)
  '  For Each _opcion As OpcionBuscar In Me.AplicacionDatos.OpcionesBuscar
  '    If AplicacionDatos.Restricciones.Buscar(_opcion.Opcion).Restri_Lectura Then
  '      _buscalista.Add(_opcion)
  '    End If
  '  Next
  '  Me.CboTiposBusqueda.ComboBox.DataSource = _buscalista
  '  Me.CboTiposBusqueda.ComboBox.DisplayMember = "Texto"
  'End Sub

  'Private Sub FrmPrincipal_onBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.onBuscar
  '  'Me.AplicacionDatos.OpcionesBuscar(Me.CboTiposBusqueda.SelectedIndex).CargarOpcion(AplicacionDatos, Me.cbofiltro.Text)
  'End Sub

#Region "New"
  Public Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmPrincipal_Inicializar(Me, Nothing)
  End Sub

  'Public Const clavekey = "SOFTWARE\\Infoware\\ICA2"

  Private Sub FrmPrincipal_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    If Not LeerClave() = System.Reflection.Assembly.GetExecutingAssembly.Location Then
      GuardarClave(System.Reflection.Assembly.GetExecutingAssembly.Location)
    End If

    mToolBoxSistemas = New ToolBoxSistemas
    mToolBoxModulos = New ToolBoxModulos
    mToolBoxFavoritos = New ToolBoxFavoritos
    mToolBoxReportes = New ToolBoxReportes

    AddHandler mToolBoxSistemas.AbrirSistema, AddressOf AbrirSistema
    AddHandler mToolBoxModulos.Desconetarsistema, AddressOf CerrarSistema
    AddHandler mToolBoxModulos.MensajeError, AddressOf MostrarMensajeError
    AddHandler mToolBoxModulos.FullScreenOpcion, AddressOf sifullscreen
    AddHandler mToolBoxModulos.CambioFavoritos, AddressOf refrescarfavoritos

    m_deserializeDockContent = New DeserializeDockContent(AddressOf GetContentFromPersistString)

    configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config")

    Dim errorxml As Boolean = False
    If File.Exists(configFile) Then
      Try
        DockPanel1.LoadFromXml(configFile, m_deserializeDockContent)
      Catch ex As Exception
        errorxml = True
      End Try
    Else
      errorxml = True
    End If

    If errorxml Then
      mToolBoxReportes.Show(DockPanel1, Docking.DockState.DockLeft)
      'mToolBoxModulos.Show(DockPanel1, Docking.DockState.DockLeft)
      mToolBoxModulos.Show(mToolBoxReportes.Pane, Docking.DockState.DockTopAutoHide, 0.6)
      mToolBoxSistemas.Show(mToolBoxModulos.Pane, Docking.DockState.DockTopAutoHide, 0.3)
      mToolBoxFavoritos.Show(DockPanel1, Docking.DockState.DockRightAutoHide)
    End If

    ToolStripManager.Merge(Me.ToolStrip1, BarraEstandar)
    Me.ToolStrip1.Visible = False

    Dim MenuItem As System.Windows.Forms.ToolStripMenuItem
    MenuItem = New System.Windows.Forms.ToolStripMenuItem
    MenuItem.Text = "Sistemas registrados"
    MenuItem.ToolTipText = "Muestra la lista de sistemas registrados"
    MenuItem.Image = Me.btnsistemas.Image
    AddHandler MenuItem.Click, AddressOf btnsistemas_Click
    ViewToolStripMenuItem.DropDownItems.Insert(0, MenuItem)

    MenuItem = New System.Windows.Forms.ToolStripMenuItem
    MenuItem.Text = "Explorador de sistemas"
    MenuItem.ToolTipText = "Muestra la lista de opciones del sistema seleccionado"
    MenuItem.Image = Me.btnexplorador.Image
    AddHandler MenuItem.Click, AddressOf btnexplorador_Click
    ViewToolStripMenuItem.DropDownItems.Insert(1, MenuItem)

    MenuItem = New System.Windows.Forms.ToolStripMenuItem
    MenuItem.Text = "Favoritos"
    MenuItem.ToolTipText = "Muestra las opciones favoritas del sistema seleccionado"
    MenuItem.Image = Me.btnfavoritos.Image
    AddHandler MenuItem.Click, AddressOf btnfavoritos_Click
    ViewToolStripMenuItem.DropDownItems.Insert(2, MenuItem)

    MenuItem = New System.Windows.Forms.ToolStripMenuItem
    MenuItem.Text = "Reportes"
    MenuItem.ToolTipText = "Muestra los reportes del sistema seleccionado"
    MenuItem.Image = Me.btnreportes.Image
    AddHandler MenuItem.Click, AddressOf btnreportes_Click
    ViewToolStripMenuItem.DropDownItems.Insert(3, MenuItem)

    Dim menuseparador As New ToolStripSeparator
    ViewToolStripMenuItem.DropDownItems.Insert(4, menuseparador)

    ''ArchSesion = String.Format("{0}\Configuracion\Sesion.xml", AplicacionDatos.DirectorioRaiz)
    ''Me.lbl_contectadoa.Text = String.Format("Conectado a: {0}", AplicacionDatos.OperadorDatos.Descripcion)
    ' MyBase.Inicializar()
  End Sub
#End Region

#Region "Docks"
  Private Sub btnexplorador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnexplorador.Click
    nofullscreen(Me, Nothing)
    mToolBoxModulos.Show(DockPanel1)
  End Sub

  Private Sub btnfavoritos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnfavoritos.Click
    nofullscreen(Me, Nothing)
    mToolBoxFavoritos.Show(DockPanel1)
  End Sub

  Private Sub btnreportes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreportes.Click
    nofullscreen(Me, Nothing)
    mToolBoxReportes.Show(DockPanel1)
  End Sub

  Private Sub btnsistemas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsistemas.Click
    nofullscreen(Me, Nothing)
    mToolBoxSistemas.Show(DockPanel1)
  End Sub
#End Region

#Region "Regedit"
  Dim mDirectorioRaiz = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, My.Application.Info.Title)
  Dim mDirectorioConfig = System.IO.Path.Combine(mDirectorioRaiz, "Configuracion")

  Public Sub GuardarClave(ByVal valor As String)
    My.Computer.FileSystem.CreateDirectory(mDirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(mDirectorioConfig)

    configFile = Path.Combine(mDirectorioConfig, "Link.config")

    My.Computer.FileSystem.WriteAllText(configFile, valor, False)
  End Sub

  Public Function LeerClave() As String
    My.Computer.FileSystem.CreateDirectory(mDirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(mDirectorioConfig)

    configFile = Path.Combine(mDirectorioConfig, "Link.config")

    Dim result As String = ""
    Try
      result = My.Computer.FileSystem.ReadAllText(configFile)
    Catch ex As Exception

    End Try

    Return result
  End Function
#End Region

#Region "Eventos sistemas"
  Sub AbrirSistema(ByVal sender As Object, ByVal e As System.EventArgs)
    mToolBoxModulos.AgregarSistema(mToolBoxSistemas.SistemaSeleccionado)
    mToolBoxFavoritos.AgregarSistema(mToolBoxSistemas.SistemaSeleccionado, False)
    mToolBoxReportes.AgregarSistema(mToolBoxSistemas.SistemaSeleccionado)
  End Sub

  Sub CerrarSistema(ByVal sender As Object, ByVal e As System.EventArgs)
    mToolBoxSistemas.CerrarSistema(mToolBoxModulos.SistemaActual)
    mToolBoxFavoritos.CerrarSistema(mToolBoxModulos.SistemaActual)
    mToolBoxReportes.CerrarSistema(mToolBoxModulos.SistemaActual)
    mToolBoxModulos.CerrarSistema(mToolBoxModulos.SistemaActual)
  End Sub

  Sub MostrarMensajeError(ByVal sender As Object, ByVal e As EventArgs)
    Mostrarmensaje(CType(sender, Infoware.Datos.OperadorDatos).MsgError)
  End Sub
#End Region

  Sub nofullscreen(ByVal sender As Object, ByVal e As System.EventArgs)
    If esPantallaCompleta Then
      AlternatPantallaCompleta()
    End If
  End Sub

  Sub sifullscreen(ByVal sender As Object, ByVal e As System.EventArgs)
    tmr_activarfullscreen.Enabled = True
  End Sub

  Sub refrescarfavoritos(ByVal sender As Object, ByVal e As System.EventArgs)
    mToolBoxFavoritos.AgregarSistema(mToolBoxModulos.SistemaActual, True)
    mToolBoxFavoritos.Show()
  End Sub


  Private Sub tmr_activarfullscreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_activarfullscreen.Tick
    tmr_activarfullscreen.Enabled = False
    If Not esPantallaCompleta Then
      AlternatPantallaCompleta()
    End If
  End Sub

  Private Sub tmrFullScreen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFullScreen.Tick
    If Me.esPantallaCompleta Then
      Me.Visible = False
      Me.pnlhidemenu.Visible = True
      Me.MenuStrip.Visible = False
      Me.tmrFullScreen.Enabled = False
      Me.Visible = True
    End If
  End Sub

  Private Sub FrmPrincipal_MouseEnterHideMenu(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnterHideMenu
    If Me.esPantallaCompleta Then
      Me.pnlhidemenu.Visible = False
      Me.MenuStrip.Visible = True
      Me.tmrFullScreen.Enabled = False
      Me.Invalidate()
    End If
  End Sub

  Private Sub FrmPrincipal_MouseLeaveMenu(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeaveMenu
    If Me.esPantallaCompleta Then
      Me.tmrFullScreen.Enabled = True
    End If
  End Sub

  Private Sub tmrActivar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrActivar.Tick
    Try
      If My.Application.IsNetworkDeployed Then
        My.Application.Deployment.UpdateAsync()
      End If
    Catch ex As Exception

    End Try
  End Sub
End Class
