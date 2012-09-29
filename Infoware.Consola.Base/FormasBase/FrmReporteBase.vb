Imports System.ComponentModel
Imports System.Reflection
Imports Infoware.Reglas.General

Public Class FrmReporteBase
  Implements IOpcion

  Public WriteOnly Property Titulo() As String
    Set(ByVal value As String)
      Dim _titulo As String = "Reporte de " & value
      Me.Text = _titulo
      Me.ToolStriptitulo.Text = _titulo
    End Set
  End Property

  Public Property PuedeImprimir() As Boolean
    Get
      Return Me.btnimprimir.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.btnimprimir.Visible = value
    End Set
  End Property

  Public Property ReporteDatos As Object
    Get
      Return Me.CrystalReportViewer1.ReportSource
    End Get
    Set(ByVal value As Object)
      Me.CrystalReportViewer1.ReportSource = value
      Me.CrystalReportViewer1.BringToFront()
    End Set
  End Property

  Private Sub FrmReporteBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.HeaderStrip1.Visible = False
  End Sub

  'Public Event Cerrar As EventHandler
  Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
    Me.Close()
  End Sub

  'Public Event Ayuda As EventHandler
  Private Sub ToolStripButtonAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonAyuda.Click, AyudaDinamicaToolStripMenuItem.Click
    If Restriccion IsNot Nothing AndAlso Not Restriccion.PardetOpcion.Pardet_Leyenda = String.Empty Then
      Dim f As New FrmAyuda
      f.Titulo = Me.Text
      f.Descripcion = Restriccion.PardetOpcion.Pardet_Leyenda
      f.ShowDialog()
    End If
  End Sub

  Private Sub FrmAplicarRestricciones(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AplicarRestricciones
    'AplicacionDatos.CrearMenuEdicion(Me.EdicionToolStripMenuItem)
    'AplicacionDatos.CrearMenuAyuda(Me.AyudaToolStripMenuItem, Nothing)
    Me.btnimprimir.Enabled = Restriccion.Restri_Impresion
    Me.ImprimirToolStripMenuItem.Enabled = Restriccion.Restri_Impresion
    Me.btnexportar.Enabled = Restriccion.Restri_Impresion
    Me.ExportarToolStripMenuItem.Enabled = Restriccion.Restri_Impresion
    'Me.btncorreo.Visible = False 'Restriccion.Restri_Impresion
    'Me.CorreoToolStripMenuItem1.Visible = False ' Restriccion.Restri_Impresion
  End Sub

  'Public Event Imprimir As EventHandler
  Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click, ImprimirToolStripMenuItem.Click
    Me.CrystalReportViewer1.PrintReport()
    Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion)
    'RaiseEvent Imprimir(Me, Nothing)
  End Sub

  'Public Event Exportar As EventHandler
  Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click, ExportarToolStripMenuItem.Click
    Me.CrystalReportViewer1.ExportReport()
    Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar impresión")
    'RaiseEvent Exportar(Me, Nothing)
  End Sub

  Private Sub btncorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''''
  End Sub

#Region "New"
  Public Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionDefault As Integer = 0)
    MyBase.New(_Sistema, _Restriccion, _OpcionDefault)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmAplicarRestricciones(Me, Nothing)
    FrmReporteBase_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, Optional ByVal _OpcionDefault As Integer = 0)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _OpcionDefault)
  End Sub

  Private Sub FrmReporteBase_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
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

  Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
    Me.Close()
  End Sub
End Class