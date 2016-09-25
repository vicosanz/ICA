Imports System.ComponentModel
Imports System.Reflection
Imports Infoware.Reglas.General
Imports Microsoft.Office.Interop
Imports Infoware.Reportes
Imports System.Windows.Forms

Public Class FrmListaBase
  Implements IOpcion

  Public WriteOnly Property Titulo() As String
    Set(ByVal value As String)
      Dim _titulo As String = "Lista de " & value
      Me.Text = _titulo
      Me.ToolStriptitulo.Text = _titulo
    End Set
  End Property

  Public WriteOnly Property AgregarLeyenda() As String
    Set(ByVal value As String)
      Me.LinkAgregar.Text = value
    End Set
  End Property

  Private mEsBusqueda As Boolean = True
  Public Property EsBusqueda() As Boolean
    Get
      Return mEsBusqueda
    End Get
    Set(ByVal value As Boolean)
      mEsBusqueda = value
      btnseleccionar.Visible = mEsBusqueda
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

  Public Property PuedeNuevo() As Boolean
    Get
      Return Me.LinkAgregar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.LinkAgregar.Visible = value
      Me.NuevoToolStripMenuItem.Visible = value
    End Set
  End Property

  Public Property PuedeEliminar() As Boolean
    Get
      Return Me.btneliminar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.btneliminar.Visible = value
      Me.EliminarToolStripMenuItem.Visible = value
      Me.ToolStripMenuItemSepEli.Visible = value
    End Set
  End Property

  Public Property PuedeRefrescar() As Boolean
    Get
      Return Me.btnrefrescar.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.btnrefrescar.Visible = value
    End Set
  End Property

  Public Event Agregar As EventHandler
  Public Event Imprimir As EventHandler
  Public Event Eliminar As EventHandler
  Public Event Refrescar As EventHandler
  Public Event Seleccionar As EventHandler
  Public Event Abrir As EventHandler

  Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
    btncancelarbuscar_Click(Me, Nothing)
  End Sub

  Private Sub LinkAgregar_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkAgregar.LinkClicked
    RaiseEvent Agregar(Me, Nothing)
  End Sub

  Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click, ExportarToolStripMenuItem.Click
    EnviarExcel()
  End Sub

  Private Sub btncorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncorreo.Click, CorreoToolStripMenuItem1.Click
    EnviarExcel(EnumSalida.Correo)
  End Sub

  Private mDocSalida As String = ""
  Public Property DocSalida() As String
    Get
      Return mDocSalida
    End Get
    Set(ByVal value As String)
      mDocSalida = value
      Me.btnword.Visible = Not String.IsNullOrEmpty(value)
      Me.WordToolStripMenuItem1.Visible = Not String.IsNullOrEmpty(value)
    End Set
  End Property

  Private Sub btnword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnword.Click, WordToolStripMenuItem1.Click
    EnviarExcel(EnumSalida.MailMerge, mDocSalida)
  End Sub

  Public Enum EnumSalida
    Excel
    Correo
    MailMerge
  End Enum

  Private Sub EnviarExcel(Optional ByVal _output As EnumSalida = EnumSalida.Excel, Optional ByVal _docmerge As String = "")
    Try
      Dim data As IList = CType(Me.DataGridView1.DataSource.DataSource, IList)

      If data Is Nothing OrElse data.Count = 0 Then
        Throw New Exception("No existen registros a exportar")
        Exit Sub
      End If

      Dim dets As Type
      dets = data.Item(0).GetType

      Dim excelApp As New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      With excelWorksheet
        For t As Integer = 1 To Me.DataGridView1.ColumnCount
          .Cells(1, t).Value = Me.DataGridView1.Columns(t - 1).HeaderText
          .Columns(t).columnwidth = IIf(Me.DataGridView1.Columns(t - 1).Width / 6.8 > 255, 255, Me.DataGridView1.Columns(t - 1).Width / 6.8)

          Dim _pro As System.Reflection.PropertyInfo
          _pro = dets.GetProperty(Me.DataGridView1.Columns(t - 1).DataPropertyName)

          If _pro IsNot Nothing Then
            If Not _output = EnumSalida.MailMerge AndAlso (_pro.PropertyType Is GetType(Decimal) Or _pro.PropertyType Is GetType(Double)) Then
              .Columns(t).numberformat = "0.00" '& Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator & "00"
            ElseIf Not _output = EnumSalida.MailMerge AndAlso (_pro.PropertyType Is GetType(Integer) Or _pro.PropertyType Is GetType(Byte)) Then
              .Columns(t).numberformat = "0"
            Else
              'If Not _output = EnumSalida.MailMerge AndAlso (_pro.PropertyType Is GetType(String) Or _pro.PropertyType Is GetType(Boolean)) Then
              .Columns(t).numberformat = "@"
            End If
          End If
        Next

        For _row As Integer = 1 To data.Count
          'Dim vals As Object
          'vals = typeDs.GetProperty("Item").GetValue(Me.DataGridView1.DataSource.DataSource, New Object() {_row - 1})

          For t As Integer = 1 To Me.DataGridView1.ColumnCount
            'Dim _pro As System.Reflection.PropertyInfo
            '_pro = vals.GetType.GetProperty(Me.DataGridView1.Columns(t - 1).DataPropertyName)
            Dim valor As Object
            valor = GetField(data.Item(_row - 1), Me.DataGridView1.Columns(t - 1).DataPropertyName)
            If TypeOf valor Is Boolean Then
              .Cells(_row + 1, t).Value = IIf(CBool(valor), "Sí", "No")
            Else
              Dim _pro As System.Reflection.PropertyInfo
              _pro = dets.GetProperty(Me.DataGridView1.Columns(t - 1).DataPropertyName)

              '.Cells(_row + 1, t).Value = valor
              If _output = EnumSalida.MailMerge AndAlso (_pro.PropertyType Is GetType(Decimal) Or _pro.PropertyType Is GetType(Double)) Then
                .Cells(_row + 1, t).value = Val(valor).ToString("0.00")
              ElseIf _output = EnumSalida.MailMerge AndAlso (_pro.PropertyType Is GetType(Integer) Or _pro.PropertyType Is GetType(Byte)) Then
                .Cells(_row + 1, t).value = Val(valor).ToString("0")
              Else 'data.Columns(t - 1).DataType Is GetType(String) Or data.Columns(t - 1).DataType Is GetType(Boolean) Then
                .Cells(_row + 1, t).Value = valor
              End If
            End If
          Next
        Next
      End With
      excelApp.Visible = True
      excelApp.ScreenUpdating = True
      'excelWorksheet.PrintPreview()
      'excelApp.Quit()
      If _output = EnumSalida.Correo Then
        excelApp.Dialogs(Excel.XlBuiltInDialog.xlDialogSendMail).Show()
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel y enviar por mail")
      ElseIf _output = EnumSalida.MailMerge Then
        Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.xls"
        Try
          Kill(rutfte)
        Catch ex As Exception
          Throw New Exception(String.Format("No se puede eliminar el archivo temporal {0), posiblemente esté en uso", rutfte))
        End Try

        excelBook.SaveAs(Filename:=rutfte)
        'excelBook.SaveAs(Filename:=rutfte, FileFormat:=Excel.XlFileFormat.xlExcel5)
        excelBook.Close()
        excelApp.Quit()

        Dim WordApp As New Word.Application
        Dim WordDocument As Word.Document = WordApp.Documents.Open(_docmerge)
        'WordDocument.MailMerge.Destination = Word.WdMailMergeDestination.wdSendToNewDocument
        WordApp.Visible = True
        WordDocument.Activate()
        With WordDocument.MailMerge
          .OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `Hoja1$`")
          .ViewMailMergeFieldCodes = False
          .Destination = 0        'nuevo documento
          .SuppressBlankLines = True
          With .DataSource
            .FirstRecord = 1
            .LastRecord = -16
          End With
          .Execute(Pause:=False)
        End With
        WordDocument.ActiveWindow.Close()

        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel y combinó correspondencia")
      Else
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel")
      End If
    Catch ex As Exception
      MsgBox("No se puede exporta a Microsoft Excel. " & ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
    End Try
  End Sub

#Region " GetField "

  Public Function GetField(ByVal obj As Object, ByVal FieldName As String) As Object
    Try
      Dim sourcetype As Type = obj.GetType
      Dim prop As PropertyInfo = sourcetype.GetProperty(FieldName)
      If prop Is Nothing OrElse Not prop.CanRead Then
        ' no readable property of that name exists - check for a field
        Dim field As FieldInfo = sourcetype.GetField(FieldName)

        If field Is Nothing Then
          Return "No such value " & FieldName
        Else
          Return field.GetValue(obj)
        End If
      Else
        ' found a property, return its value
        Return prop.GetValue(obj, Nothing)
      End If
    Catch ex As Exception
      Return ex.Message
    End Try
  End Function

#End Region

  Public Event DespuesSeleccionarCampos As EventHandler

  Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click, ImprimirToolStripMenuItem.Click
    Try
      Dim doc As New Infoware.Reportes.ReportDocument
      doc.Titulo = Me.Text
      If Me.DataGridView1.ColumnCount > 5 Then
        doc.DefaultPageSettings.Landscape = True
      End If
      doc.DataGridView = Me.DataGridView1
      Dim previo As New System.Windows.Forms.PrintPreviewDialog
      previo.Document = doc
      previo.Document.DocumentName = Me.Text
      previo.Text = Me.Text
      previo.WindowState = FormWindowState.Maximized
      previo.ShowDialog()

      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion)
      RaiseEvent Imprimir(Me, Nothing)
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click, EliminarToolStripMenuItem.Click
    If Restriccion.Restri_Eliminacion Then
      RaiseEvent Eliminar(Me, Nothing)
    End If
  End Sub

  Private Sub btnrefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefrescar.Click
    'RefrescarLista()
    btncancelarbuscar_Click(Me, Nothing)
  End Sub

  'Sub activarbusy()
  '  Application.DoEvents()
  '  Me.ColorFadeBusyBar1.Start()
  '  Me.ColorFadeBusyBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
  'End Sub

  'Sub desactivarbusy()
  '  Me.ColorFadeBusyBar1.Stop()
  '  Me.ColorFadeBusyBar1.ForeColor = System.Drawing.SystemColors.Window
  'End Sub

  Public Sub RefrescarLista()
    'desactivarbusy()
    RaiseEvent Refrescar(Me, Nothing)
  End Sub

  Public Event Buscar As System.ComponentModel.CancelEventHandler

  Private Sub combobuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combobuscar.KeyPress
    If e.KeyChar = vbCr Then
      Hacer_busqueda()
      e.Handled = True
    End If
  End Sub

  Private Sub combobuscar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combobuscar.TextChanged
    If Me.btncancelarbuscar.Visible Then
      Me.btncancelarbuscar.Visible = False
      Me.btnbuscar.Visible = True
    End If
  End Sub

  Private Sub combobuscar_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    Hacer_busqueda()
  End Sub

  Public Sub Hacer_busqueda()
    Dim _e As New CancelEventArgs
    RaiseEvent Buscar(Me, _e)
    If Not _e.Cancel Then
      'activarbusy()

      If Not Me.combobuscar.Text.Trim = String.Empty Then
        Me.HeaderStrip1.esBusqueda = True
        Me.combobuscar.Items.Add(Me.combobuscar.Text)
        Me.btncancelarbuscar.Visible = True
        Me.btnbuscar.Visible = False
      Else
        Me.HeaderStrip1.esBusqueda = False
        Me.btncancelarbuscar.Visible = False
        Me.btnbuscar.Visible = True
      End If
      Me.DataGridView1.Select()
    End If
  End Sub

  Public Event CancelarBuscar As EventHandler

  Private Sub btncancelarbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelarbuscar.Click
    Me.HeaderStrip1.esBusqueda = False
    Me.btnbuscar.Visible = True
    Me.btncancelarbuscar.Visible = False

    RaiseEvent CancelarBuscar(Me, Nothing)
    'desactivarbusy()
  End Sub

  Private Sub ToolStripAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAbrir.Click, AbrirToolStripMenuItem.Click
    OnAbrir()
  End Sub

  Sub OnAbrir()
    RaiseEvent Abrir(Me, Nothing)
  End Sub

  Public Event FormatearCelda As DataGridViewCellFormattingEventHandler
  Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
    RaiseEvent FormatearCelda(sender, e)
  End Sub

  Private Sub DataGridView1_DespuesSeleccionarCampos(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DespuesSeleccionarCampos
    RaiseEvent DespuesSeleccionarCampos(Me, Nothing)
  End Sub

  Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
    If mEsBusqueda Then
      RaiseEvent Seleccionar(Me, Nothing)
    Else
      OnAbrir()
      Me.DataGridView1.Invalidate()
    End If
  End Sub

  Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        If mEsBusqueda Then
          RaiseEvent Seleccionar(Me, Nothing)
        Else
          RaiseEvent Abrir(Me, Nothing)
        End If
      Case Keys.Insert
        e.Handled = True
        If Me.LinkAgregar.Visible Then
          RaiseEvent Agregar(Me, Nothing)
        End If
      Case Keys.Delete
        e.Handled = True
        If Me.btneliminar.Visible AndAlso Restriccion.Restri_Eliminacion Then
          RaiseEvent Eliminar(Me, Nothing)
        End If
      Case Keys.A To Keys.Z, Keys.D0 To Keys.D9, Keys.NumPad0 To Keys.NumPad9
        If Me.combobuscar.Visible Then
          e.Handled = True
          Me.btnbuscar.Visible = True
          Me.btncancelarbuscar.Visible = False
          Me.combobuscar.Focus()
          If e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9 Then
            Me.combobuscar.Text = Chr(Keys.D0 + (e.KeyCode - Keys.NumPad0))
          Else
            Me.combobuscar.Text = Chr(e.KeyCode)
          End If
          Me.combobuscar.SelectionStart = 1
        End If
      Case Else
        e.Handled = False
    End Select
  End Sub

  Private Sub FrmListaBase_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir

  End Sub

  Private Sub FrmListaBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'mEsBusqueda = True
  End Sub

  'Public Event Cerrar As EventHandler
  Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
    If EsBusqueda Then
      Me.Close()
    End If
  End Sub

  Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
    RaiseEvent Agregar(Me, Nothing)
    Me.DataGridView1.Invalidate()
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

    Me.LinkAgregar.Enabled = Restriccion.Restri_Ingreso
    Me.NuevoToolStripMenuItem.Enabled = Restriccion.Restri_Ingreso

    Me.btneliminar.Enabled = Restriccion.Restri_Eliminacion
    Me.EliminarToolStripMenuItem.Enabled = Restriccion.Restri_Eliminacion

    Me.btnimprimir.Enabled = Restriccion.Restri_Impresion
    Me.ImprimirToolStripMenuItem.Enabled = Restriccion.Restri_Impresion
    Me.btnexportar.Enabled = Restriccion.Restri_Impresion
    Me.ExportarToolStripMenuItem.Enabled = Restriccion.Restri_Impresion
    Me.btncorreo.Enabled = Restriccion.Restri_Impresion
    Me.CorreoToolStripMenuItem1.Enabled = Restriccion.Restri_Impresion
  End Sub

#Region "New"
  Public Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Busqueda As Boolean, Optional ByVal _OpcionDefault As Integer = 0)
    MyBase.New(_Sistema, _Restriccion, _OpcionDefault)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    EsBusqueda = _Busqueda
    FrmAplicarRestricciones(Me, Nothing)
    FrmListaBase_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, ByVal _Busqueda As Boolean, Optional ByVal _OpcionDefault As Integer = 0)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _Busqueda, _OpcionDefault)
  End Sub

  Private Sub FrmListaBase_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Dim mmenu As New MenuHelper
    mmenu.CrearMenuEdicion(Me.EdicionToolStripMenuItem)
  End Sub
#End Region

  'Private Sub ListBindingSource_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBindingSource.DataSourceChanged
  '  AutoDiscover()
  '  'SeleccionarCampos(Me, Nothing)
  'End Sub


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

  Private Sub ListBindingSource_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Me.DataGridView1.AutoDiscover()
    If Me.ListBindingSource Is Nothing OrElse Me.ListBindingSource.Count = 0 Then
      Me.lblmensaje.Text = ""
    Else
      Me.lblmensaje.Text = String.Format("{0} registros presentados", Me.ListBindingSource.Count)
    End If
  End Sub

  Private Sub ArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoToolStripMenuItem.Click

  End Sub

  Public Event SeleccionoFila As EventHandler


  Private Sub ListBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    RaiseEvent SeleccionoFila(Me, Nothing)
  End Sub

  Private Sub btnseleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btnseleccionar.Click
    Me.Close()
  End Sub
End Class