Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
'Imports Infoware.Modulos.Base
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FrmMantenimientoBase
  Public WriteOnly Property Tabla() As String
    Set(ByVal value As String)
      Me.Text = value
      'Me.Lbl_tipo.Text = value
    End Set
  End Property

#Region "Puede"
  Public Property PuedeMover() As Boolean
    Get
      Return Me.ToolStripAnterior.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripAnterior.Visible = value
      Me.ToolStripSiguiente.Visible = value
      Me.ToolStripSeparatorMover.Visible = value
      If Not value Then
        Me.ToolStripAnterior.Enabled = value
        Me.ToolStripSiguiente.Enabled = value
        Me.ToolStripSeparatorMover.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeNuevo() As Boolean
    Get
      Return Me.ToolStripNuevo.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripNuevo.Visible = value
      Me.NuevoToolStripMenuItem.Visible = value
      Me.ToolStripMenuItemSepNuevo.Visible = value
      If Not value Then
        Me.ToolStripNuevo.Enabled = value
        Me.NuevoToolStripMenuItem.Enabled = value
        Me.ToolStripMenuItemSepNuevo.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeNuevoGeneral() As Boolean
    Get
      Return Me.ToolStripNuevoGeneral.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripNuevoGeneral.Visible = value
      If Not value Then
        Me.ToolStripNuevoGeneral.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeGuardar() As Boolean
    Get
      Return Me.ToolStripGuardar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripGuardar.Visible = value
      Me.GuardarToolStripMenuItem.Visible = value
      If Not value Then
        Me.ToolStripGuardar.Enabled = value
        Me.GuardarToolStripMenuItem.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeGuardarcerrar() As Boolean
    Get
      Return Me.ToolStripGuardarcerrar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripGuardarcerrar.Visible = value
      Me.GuardarYCerrarToolStripMenuItem.Visible = value
      If Not value Then
        Me.ToolStripGuardarcerrar.Enabled = value
        Me.GuardarYCerrarToolStripMenuItem.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeGuardarnuevo() As Boolean
    Get
      Return Me.ToolStripGuardarnuevo.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripGuardarnuevo.Visible = value
      Me.GuardarYNuevoToolStripMenuItem.Visible = value
      If Not value Then
        Me.ToolStripGuardarnuevo.Enabled = value
        Me.GuardarYNuevoToolStripMenuItem.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeEliminar() As Boolean
    Get
      Return Me.EliminarToolStripMenuItem.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.EliminarToolStripMenuItem.Visible = value
      Me.ToolStripMenuItemSepEli.Visible = value
      If Not value Then
        Me.EliminarToolStripMenuItem.Enabled = value
        Me.ToolStripMenuItemSepEli.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeAnular() As Boolean
    Get
      Return Me.ToolStripAnular.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripAnular.Visible = value
      If Not value Then
        Me.ToolStripAnular.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeRefrescar() As Boolean
    Get
      Return Me.ToolStripRefrescar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripRefrescar.Visible = value
      If Not value Then
        Me.ToolStripRefrescar.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeImprimir() As Boolean
    Get
      Return Me.ToolStripImprimir.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripImprimir.Visible = value
      Me.ToolStripSeparatorImprimir.Visible = value Or Me.ToolStripFormato.Visible
      If Not value Then
        Me.ToolStripImprimir.Enabled = value
        Me.ToolStripSeparatorImprimir.Enabled = value
      End If
    End Set
  End Property

  Public Property PuedeFormato() As Boolean
    Get
      Return Me.ToolStripFormato.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.ToolStripFormato.Visible = value
      Me.ToolStripSeparatorImprimir.Visible = Me.ToolStripImprimir.Visible Or value
      If Not value Then
        Me.ToolStripFormato.Enabled = value
        Me.ToolStripSeparatorImprimir.Enabled = value
      End If
    End Set
  End Property
#End Region

#Region "Guardar"
  Public Event Guardar As CancelEventHandler
  Private Sub ToolStripGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripGuardar.Click, GuardarToolStripMenuItem.Click
    GuardarCambios()
  End Sub

  Private Function GuardarCambios() As Boolean
    Dim ec As New CancelEventArgs
    RaiseEvent Guardar(Me, ec)
    Return Not ec.Cancel
  End Function

  'Public Event GuardaryCerrar As EventHandler
  Private Sub ToolStripGuardarcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripGuardarcerrar.Click, GuardarYCerrarToolStripMenuItem.Click
    If GuardarCambios() Then
      Me.Close()
    End If
    'RaiseEvent GuardaryCerrar(Me, Nothing)
  End Sub

  'Public Event GuardaryNuevo As EventHandler
  Private Sub ToolStripGuardarnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripGuardarnuevo.Click, GuardarYNuevoToolStripMenuItem.Click
    If GuardarCambios() Then
      crear_nuevo()
    End If
    'RaiseEvent GuardaryNuevo(Me, Nothing)
  End Sub
#End Region

#Region "Anterior, siguiente, primero, ultimo"
  Public Event Anterior As CancelEventHandler
  Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAnterior.ButtonClick, IrAlElementoToolStripMenuItem.Click
    If BindingSource1 IsNot Nothing AndAlso BindingSource1.Count > 1 Then
      Dim result As New CancelEventArgs
      RaiseEvent Anterior(Me, result)

      If Not result.Cancel Then
        BindingSource1.MovePrevious()
      End If
    End If
  End Sub

  Public Event Siguiente As CancelEventHandler
  Private Sub ToolStripSiguiente_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSiguiente.ButtonClick, IrAlElementoToolStripMenuItem1.Click
    If BindingSource1 IsNot Nothing AndAlso BindingSource1.Count > 1 Then
      Dim result As New CancelEventArgs
      RaiseEvent Siguiente(Me, result)

      If Not result.Cancel Then
        BindingSource1.MoveNext()
      End If
    End If
  End Sub

  Public Event Primero As CancelEventHandler
  Private Sub IrAlPrimerElementoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrAlPrimerElementoToolStripMenuItem.Click
    If BindingSource1 IsNot Nothing AndAlso BindingSource1.Count > 1 Then
      Dim result As New CancelEventArgs
      RaiseEvent Primero(Me, result)

      If Not result.Cancel Then
        BindingSource1.MoveFirst()
      End If
    End If
  End Sub

  Public Event Ultimo As CancelEventHandler
  Private Sub IrAlÚltimoElementoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrAlÚltimoElementoToolStripMenuItem.Click
    If BindingSource1 IsNot Nothing AndAlso BindingSource1.Count > 1 Then
      Dim result As New CancelEventArgs
      RaiseEvent Ultimo(Me, result)

      If Not result.Cancel Then
        BindingSource1.MoveLast()
      End If
    End If
  End Sub
#End Region

#Region "Imprimir, Eliminar, Cerrar"
  Public Event Imprimir As EventHandler
  Private Sub ToolStripImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripImprimir.Click
    RaiseEvent Imprimir(Me, Nothing)
  End Sub

  Public Event ModificarFormato As EventHandler
  Private Sub ToolStripFormato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripFormato.Click
    RaiseEvent ModificarFormato(Me, Nothing)
  End Sub

  Public Event Eliminar As EventHandler
  Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
    RaiseEvent Eliminar(Me, Nothing)
  End Sub

  'Public Event Cerrar As EventHandler
  Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
    Me.Close()
  End Sub
#End Region

  Public Event Actualizar As EventHandler
  Private mEsNuevo As Boolean = False

  Public Sub ValidarRegistro()
    If BindingSource1 Is Nothing OrElse BindingSource1.Count < 2 Then
      Me.ToolStripAnterior.Enabled = False
      Me.ToolStripSiguiente.Enabled = False
    Else
      If PuedeMover Then
        Me.ToolStripAnterior.Enabled = True
        Me.ToolStripSiguiente.Enabled = True
      End If
    End If
    If BindingSource1 IsNot Nothing AndAlso BindingSource1.Current IsNot Nothing Then
      mEsNuevo = False
      If TypeOf BindingSource1.Current Is Infoware.Reglas._Database Then
        mEsNuevo = CType(BindingSource1.Current, Infoware.Reglas._Database).EsNuevo
      End If
      FrmAplicarRestricciones(Me, Nothing)
    End If
  End Sub

  Private Sub BindingSource1_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged
    ValidarRegistro()
    RaiseEvent Actualizar(Me, Nothing)
  End Sub

#Region "Nuevo"
  Public Event CrearNuevo As AddingNewEventHandler
  Private Sub BindingSource1_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles BindingSource1.AddingNew
    crear_nuevo()
  End Sub

  Private Sub crear_nuevo()
    Dim result As New AddingNewEventArgs
    RaiseEvent CrearNuevo(Me, result)
    BindingSource1.Add(result.NewObject)
    BindingSource1.MoveLast()
  End Sub

  Private Sub ToolStripNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripNuevo.Click, NuevoToolStripMenuItem.Click
    crear_nuevo()
  End Sub
#End Region

  Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
    Me.Close()
  End Sub

  Public Event Refrescar As EventHandler
  Private Sub ToolStripRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripRefrescar.Click
    RaiseEvent Refrescar(Me, Nothing)
  End Sub

  Public Event Anular As EventHandler
  Private Sub ToolStripAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAnular.Click
    RaiseEvent Anular(Me, Nothing)
  End Sub

  Private Sub FrmAplicarRestricciones(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AplicarRestricciones
    'AplicacionDatos.CrearMenuNuevo(Me.NuevoToolStripMenuItem, Me.ToolStripNuevoGeneral)
    'AplicacionDatos.CrearMenuEdicion(Me.EdicionToolStripMenuItem)
    'AplicacionDatos.CrearMenuAyuda(Me.AyudaToolStripMenuItem, Nothing)

    Me.NuevoToolStripMenuItem.Enabled = Restriccion.Restri_Ingreso

    Me.GuardarToolStripMenuItem.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
    Me.GuardarYCerrarToolStripMenuItem.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
    Me.GuardarYNuevoToolStripMenuItem.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
    Me.ToolStripGuardar.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
    Me.ToolStripGuardarcerrar.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
    Me.ToolStripGuardarnuevo.Enabled = (mEsNuevo And Restriccion.Restri_Ingreso) Or (Not mEsNuevo And Restriccion.Restri_Modificacion)
    Me.EliminarToolStripMenuItem.Enabled = Restriccion.Restri_Eliminacion
    Me.ToolStripAnular.Enabled = Restriccion.Restri_Eliminacion

    Me.ToolStripImprimir.Enabled = Restriccion.Restri_Impresion
  End Sub

  Private Sub AyudaDinamicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaDinamicaToolStripMenuItem.Click, ToolStripButtonAyuda.Click
    If Restriccion IsNot Nothing AndAlso Not Restriccion.PardetOpcion.Pardet_Leyenda = String.Empty Then
      Dim f As New FrmAyuda
      f.Titulo = Me.Text
      f.Descripcion = Restriccion.PardetOpcion.Pardet_Leyenda
      f.ShowDialog()
    End If
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
    FrmMantenimientoBase_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, Optional ByVal _OpcionDefault As Integer = 0)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _OpcionDefault)
  End Sub

  Private Sub FrmMantenimientoBase_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Dim mmenu As New MenuHelper
    mmenu.CrearMenuEdicion(Me.EdicionToolStripMenuItem)
  End Sub
#End Region

End Class