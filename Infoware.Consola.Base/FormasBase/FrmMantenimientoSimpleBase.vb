Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports System.Windows.Forms

'Imports Infoware.Modulos.Base

Public Class FrmMantenimientoSimpleBase
  Implements IOpcion

  Public Property PuedeGuardaryNuevo() As Boolean
    Get
      Return Me.btnguardarnuevo.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.btnguardarnuevo.Visible = value
    End Set
  End Property

  Public WriteOnly Property Tabla() As String
    Set(ByVal value As String)
      Me.Text = value
      Me.ToolStripLabel1.Text = value
    End Set
  End Property

  Public Event Guardar As EventHandler
  Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem.Click, btnguardar.Click
    RaiseEvent Guardar(Me, Nothing)
  End Sub

  Public Event GuardaryNuevo As EventHandler
  Private Sub btnguardarnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarnuevo.Click
    RaiseEvent GuardaryNuevo(Me, Nothing)
  End Sub

  Private Sub FrmAplicarRestricciones(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AplicarRestricciones
    'AplicacionDatos.CrearMenuEdicion(Me.EdicionToolStripMenuItem)
    'AplicacionDatos.CrearMenuAyuda(Me.AyudaToolStripMenuItem, Nothing)

    Me.GuardarCambiosToolStripMenuItem.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
    Me.btnguardar.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
  End Sub

  '  Public Event Ayuda As EventHandler
  Private Sub ToolStripButtonAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAyuda.Click, AyudaDinamicaToolStripMenuItem.Click
    If Restriccion IsNot Nothing AndAlso Not Restriccion.PardetOpcion.Pardet_Leyenda = String.Empty Then
      Dim f As New FrmAyuda
      f.Titulo = Me.Text
      f.Descripcion = Restriccion.PardetOpcion.Pardet_Leyenda
      f.ShowDialog()
    End If
  End Sub

#Region "New"
  Private mEsNuevo As Boolean = False
  Public Property EsNuevo() As Boolean
    Get
      Return mEsNuevo
    End Get
    Set(ByVal value As Boolean)
      mEsNuevo = value
      FrmAplicarRestricciones(Me, Nothing)
    End Set
  End Property

  Public Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _EsNuevo As Boolean, Optional ByVal _OpcionDefault As Integer = 0)
    MyBase.New(_Sistema, _Restriccion, _OpcionDefault)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    mEsNuevo = _EsNuevo
    ' Add any initialization after the InitializeComponent() call.
    FrmAplicarRestricciones(Me, Nothing)
    FrmMantenimientoSimpleBase_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, ByVal _EsNuevo As Boolean, Optional ByVal _OpcionDefault As Integer = 0)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _EsNuevo, _OpcionDefault)
  End Sub

  Private Sub FrmMantenimientoSimpleBase_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Dim mmenu As New MenuHelper
    mmenu.CrearMenuEdicion(Me.EdicionToolStripMenuItem)
  End Sub
#End Region

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements IOpcion.Control
    Get
      Return Me.pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements IOpcion.MenuStrip
    Get
      Return Me.MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements IOpcion.ToolStrip
    Get
      Return Me.ToolStrip1
    End Get
  End Property
End Class