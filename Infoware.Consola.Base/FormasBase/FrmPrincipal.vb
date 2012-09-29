Imports Infoware.Datos
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Infoware.Reglas.General

Public Class FrmPrincipal
  'Private WithEvents _OperadorDatos As OperadorDatos
  'Public Property OperadorDatos() As OperadorDatos
  '  Get
  '    Return _OperadorDatos
  '  End Get
  '  Set(ByVal value As OperadorDatos)
  '    _OperadorDatos = value
  '  End Set
  'End Property

#Region "Menu"
  Private Sub EstandarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstandarToolStripMenuItem.Click
    'EstandarToolStripMenuItem.Checked = Not EstandarToolStripMenuItem.Checked
    BarraEstandar.Visible = EstandarToolStripMenuItem.Checked
  End Sub

#End Region

  'Public Sub onfullscreen(ByVal sender As Object, ByVal e As EventArgs)
  '  Me.PantallaCompletaToolStripMenuItem.Checked = True
  '  PantallaCompletaToolStripMenuItem_Click(sender, e)
  'End Sub

  'Public Sub onnofullscreen(ByVal sender As Object, ByVal e As EventArgs)
  '  Me.PantallaCompletaToolStripMenuItem.Checked = False
  '  PantallaCompletaToolStripMenuItem_Click(sender, e)
  'End Sub

  'Public Sub fullscreen(ByVal sender As Object, ByVal e As EventArgs)
  '  Me.Visible = False
  '  '' ''SplitContainer.Panel1Collapsed = True

  '  If ToolBarToolStripMenuItem.Checked Then
  '    ToolBarToolStripMenuItem.Checked = False
  '    ToolBarToolStripMenuItem_Click(Me, Nothing)
  '  End If

  '  If EstandarToolStripMenuItem.Checked Then
  '    EstandarToolStripMenuItem.Checked = False
  '    EstandarToolStripMenuItem_Click(Me, Nothing)
  '  End If

  '  'If EmpresaToolStripMenuItem.Checked Then
  '  '  EmpresaToolStripMenuItem.Checked = False
  '  '  EmpresaToolStripMenuItem_Click(Me, Nothing)
  '  'End If

  '  'Me.BarraEmpresa.Visible = False
  '  If BarraDeEstadoToolStripMenuItem.Checked Then
  '    BarraDeEstadoToolStripMenuItem.Checked = False
  '    BarraDeEstadoToolStripMenuItem_Click(Me, Nothing)
  '  End If
  '  'Me.MenuStrip.Visible = False
  '  Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
  '  '    Me.TopMost = True
  '  Me.WindowState = FormWindowState.Maximized
  '  'Me.ResumeLayout()
  '  Me.Visible = True
  'End Sub

  'Public Sub nofullscreen(ByVal sender As Object, ByVal e As EventArgs)
  '  Me.SuspendLayout()
  '  '' ''SplitContainer.Panel1Collapsed = False

  '  If Not ToolBarToolStripMenuItem.Checked Then
  '    ToolBarToolStripMenuItem.Checked = True
  '    ToolBarToolStripMenuItem_Click(Me, Nothing)
  '  End If

  '  If Not EstandarToolStripMenuItem.Checked Then
  '    EstandarToolStripMenuItem.Checked = True
  '    EstandarToolStripMenuItem_Click(Me, Nothing)
  '  End If

  '  'If Not EmpresaToolStripMenuItem.Checked Then
  '  '  EmpresaToolStripMenuItem.Checked = True
  '  '  EmpresaToolStripMenuItem_Click(Me, Nothing)
  '  'End If

  '  If Not BarraDeEstadoToolStripMenuItem.Checked Then
  '    BarraDeEstadoToolStripMenuItem.Checked = True
  '    BarraDeEstadoToolStripMenuItem_Click(Me, Nothing)
  '  End If
  '  'Me.MenuStrip.Visible = True
  '  Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
  '  '   Me.TopMost = False
  '  Me.ResumeLayout()
  'End Sub

  'Public Sub AntesCargar_Cuerpo(ByVal sender As Object, ByVal e As EventArgs)
  '  If Me.panelcuerpo.Controls.Count > 0 Then
  '    'mControlCuerpo.Controls.Add(Me.panelcuerpo.Controls(0))
  '    Me.panelcuerpo.Controls(0).Dispose()
  '  End If
  'End Sub

  'Private Sub ToolStripButtonBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Me.cbofiltro.Text = String.Empty
  'End Sub

  'Public Event onBuscar As EventHandler

  'Private Sub ToolStripButtonBuscarAhora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  If Me.CboTiposBusqueda.SelectedIndex = -1 Then
  '    Exit Sub
  '  End If
  '  RaiseEvent onBuscar(Me, Nothing)
  '  '_Modulocargadoobjeto.EjecutarBusqueda(Me.CboTiposBusqueda.SelectedIndex, Me.cbofiltro.Text)
  'End Sub

  'Private Sub ToolStripButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Me.ToolStripButtonBusqueda.Checked = False
  'End Sub

  Private Sub tmr_error_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_error.Tick
    Me.lblerror.Visible = False
    Me.lblok.Visible = True
    Me.tmr_error.Enabled = False
  End Sub

  Public Sub Mostrarmensaje(ByVal _mensaje As String)
    Me.lblok.Visible = False
    Me.lblerror.Visible = True
    If _mensaje.Length <= 150 Then
      Me.lblerror.Text = _mensaje
    Else
      Me.lblerror.Text = _mensaje.Substring(0, 150)
    End If
    Me.tmr_error.Enabled = True
  End Sub

  Public Sub Conectadoa(ByVal _mensaje As String)
    Me.lbl_contectadoa.Text = String.Format("Conectado a: {0}", _mensaje)
  End Sub

#Region "menu"
  Private Sub BarraDeEstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeEstadoToolStripMenuItem.Click
    Me.StatusStrip.Visible = BarraDeEstadoToolStripMenuItem.Checked
  End Sub

  Private Sub MenuNuevo_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Me.SeparadorNuevo.Visible = Me.MenuNuevo.Visible
    Me.btnnuevo.Visible = Me.MenuNuevo.Visible
    Me.SeparadorNuevo2.Visible = Me.MenuNuevo.Visible
  End Sub

  'Private Sub menuedicion_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuedicion.DropDownOpening
  '  Me.menuedicion.DropDownItems.Clear()
  '  AplicacionDatos.CrearMenuEdicion(Me.menuedicion)
  'End Sub
#End Region


#Region "New"
  Public Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'FrmAplicarRestricciones(Me, Nothing)
    FrmPrincipal_Inicializar(Me, Nothing)
  End Sub

  'Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionDefault As Integer = 0)
  '  MyBase.New(_Sistema, _Restriccion, _OpcionDefault)
  '  ' This call is required by the Windows Form Designer.
  '  InitializeComponent()

  '  ' Add any initialization after the InitializeComponent() call.
  '  _OperadorDatos = _Sistema.OperadorDatos
  '  FrmPrincipal_Inicializar(Me, Nothing)
  'End Sub

  'Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, Optional ByVal _OpcionDefault As Integer = 0)
  '  Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _OpcionDefault)
  '  'FrmPrincipal_Inicializar(Me, Nothing)
  'End Sub

  Private Sub FrmPrincipal_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Dim mmenu As New MenuHelper
    mmenu.CrearMenuEdicion(Me.menuedicion)
    'Me.Barrabusqueda.Visible = False
  End Sub
#End Region

  'Public Event AgregarComplementos As EventHandler
  'Private Sub AgregarComplementosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarComplementosToolStripMenuItem.Click
  '  RaiseEvent AgregarComplementos(Me, Nothing)
  'End Sub

  'Public Event AbrirSesion As EventHandler
  'Private Sub AbrirSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirSesionToolStripMenuItem.Click
  '  RaiseEvent AbrirSesion(Me, Nothing)
  'End Sub

  'Public Event GuardarSesion As EventHandler
  'Private Sub GuardarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarSesionToolStripMenuItem.Click
  '  RaiseEvent GuardarSesion(Me, Nothing)
  'End Sub

  Public Property esPantallaCompleta() As Boolean
    Get
      Return PantallaCompletaToolStripMenuItem.Checked
    End Get
    Set(ByVal value As Boolean)
      PantallaCompletaToolStripMenuItem.Checked = value
    End Set
  End Property

  Public Event PantallaCompleta As EventHandler
  Private Sub PantallaCompletaToolStripMenuItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PantallaCompletaToolStripMenuItem.Click
    Me.Visible = False
    PantallaCompletaToolStripMenuItem1.Visible = Me.PantallaCompletaToolStripMenuItem.Checked
    PantallaCompletaToolStripMenuItem1.Checked = Me.PantallaCompletaToolStripMenuItem.Checked

    Me.BarraDeEstadoToolStripMenuItem.Checked = Not esPantallaCompleta
    BarraDeEstadoToolStripMenuItem_Click(Me, Nothing)
    Me.EstandarToolStripMenuItem.Checked = Not esPantallaCompleta
    EstandarToolStripMenuItem_Click(Me, Nothing)
    RaiseEvent PantallaCompleta(Me, Nothing)
    Me.Visible = True
  End Sub

  Private Sub PantallaCompletaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PantallaCompletaToolStripMenuItem1.Click
    Me.PantallaCompletaToolStripMenuItem.Checked = False
    PantallaCompletaToolStripMenuItem_CheckedChanged(Me, Nothing)
  End Sub

  Public Sub AlternatPantallaCompleta()
    Me.PantallaCompletaToolStripMenuItem.Checked = Not Me.PantallaCompletaToolStripMenuItem.Checked
    PantallaCompletaToolStripMenuItem_CheckedChanged(Me, Nothing)
  End Sub

  Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
    Me.Close()
  End Sub

  Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click

  End Sub

  Private Sub DockPanel1_ActiveDocumentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DockPanel1.ActiveDocumentChanged
    Conectadoa("")
    If Not TypeOf sender Is Infoware.Docking.DockPanel Then
      Exit Sub
    End If
    Dim _panel As Infoware.Docking.DockPanel = sender
    If _panel.ActiveDocument Is Nothing Then
      Exit Sub
    End If
    Dim _formabase As FrmFormaBase = _panel.ActiveDocument
    Conectadoa(_formabase.Sistema.OperadorDatos.Descripcion)
  End Sub

  Public Event MouseEnterHideMenu As EventHandler

  Private Sub pnlhidemenu_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlhidemenu.MouseEnter
    RaiseEvent MouseEnterHideMenu(Me, Nothing)
  End Sub

  Public Event MouseLeaveMenu As EventHandler
  Private Sub MenuStrip_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuStrip.MouseLeave
    RaiseEvent MouseLeaveMenu(Me, Nothing)
  End Sub

  Private Sub pnlhidemenu_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlhidemenu.Paint

  End Sub
End Class
