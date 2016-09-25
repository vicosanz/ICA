Imports System.Windows.Forms
Imports System.Reflection
Imports Infoware.Reportes
Imports System.Drawing
Imports Microsoft.Office.Interop

Public Class DataGridViewAutoDiscover
  Inherits DataGridView

  Private mAgruparRepetidos As Boolean = False
  Public Property AgruparRepetidos() As Boolean
    Get
      Return mAgruparRepetidos
    End Get
    Set(ByVal value As Boolean)
      mAgruparRepetidos = value
    End Set
  End Property

  Private ContextMenuStrip1 As New ContextMenuStrip

  Public Sub AutoDiscover()
    Me.Invalidate()
    Me.ContextMenuStrip = ContextMenuStrip1
    Me.ContextMenuStrip1.Items.Clear()
    Try
      Dim data As IList = CType(Me.DataSource.DataSource, IList)
      Dim SourceType As Type = data.Item(0).GetType
      For Each mInfo As PropertyInfo In SourceType.GetProperties
        Dim attrCustom As CampoReporteAtributo = Nothing

        For Each attr As Attribute In Attribute.GetCustomAttributes(mInfo)
          If TypeOf attr Is CampoReporteAtributo Then
            attrCustom = CType(attr, CampoReporteAtributo)
            attrCustom.Campo = mInfo.Name
          End If
        Next

        If attrCustom IsNot Nothing AndAlso Not attrCustom.Ignorar Then
          If mInfo.PropertyType.BaseType Is GetType(Object) Or mInfo.PropertyType.BaseType Is GetType(ValueType) Then
            Dim _item As New System.Windows.Forms.ToolStripMenuItem
            _item.Text = attrCustom.Etiqueta
            _item.Tag = attrCustom
            _item.CheckOnClick = True

            Dim _existe As Boolean = False
            For t As Integer = 1 To Me.ColumnCount
              If Me.Columns(t - 1).DataPropertyName.ToUpper.Trim = attrCustom.Campo.ToUpper.Trim Then
                _existe = True
              End If
            Next

            _item.Checked = _existe Or attrCustom.Predeterminado
            _item.Enabled = Not attrCustom.Predeterminado

            Me.ContextMenuStrip1.Items.Add(_item)
            AddHandler _item.Click, AddressOf SeleccionarCampos
            'mColumns.Add(props(column).Name)
          End If
        End If
      Next
      If Me.Columns.Count = 0 OrElse Me.Columns(0).Name = "none" Then
        SeleccionarCampos(Me, Nothing)
      End If

    Catch ex As Exception
      Me.Columns.Clear()
      Me.Columns.Add("none", "No existen registros a presentar")
    End Try
  End Sub

  Public Event DespuesSeleccionarCampos As EventHandler

  Sub SeleccionarCampos(ByVal sender As System.Object, ByVal e As EventArgs)
    Me.Columns.Clear()
    For Each _item As ToolStripMenuItem In Me.ContextMenuStrip1.Items
      Dim attrCustom As CampoReporteAtributo = _item.Tag
      If _item.Checked OrElse attrCustom.Predeterminado Then
        Dim _datagridcolumn As DataGridViewColumn = Nothing
        Select Case attrCustom.TipoDato
          Case CampoReporteAtributo.EnumTipoDato.Texto
            _datagridcolumn = New DataGridViewTextBoxColumn
            _datagridcolumn.DataPropertyName = attrCustom.Campo
            _datagridcolumn.HeaderText = attrCustom.Etiqueta
            _datagridcolumn.Width = attrCustom.Tamano
          Case CampoReporteAtributo.EnumTipoDato.Boton
            _datagridcolumn = New DataGridViewButtonColumn
            _datagridcolumn.DataPropertyName = attrCustom.Campo
            _datagridcolumn.HeaderText = attrCustom.Etiqueta
            _datagridcolumn.Width = attrCustom.Tamano
          Case CampoReporteAtributo.EnumTipoDato.Decimales
            Dim estilonum2 As New DataGridViewCellStyle()
            estilonum2.Format = "N2"

            _datagridcolumn = New DataGridViewTextBoxColumn
            _datagridcolumn.DataPropertyName = attrCustom.Campo
            _datagridcolumn.DefaultCellStyle = estilonum2
            _datagridcolumn.HeaderText = attrCustom.Etiqueta
            _datagridcolumn.Width = attrCustom.Tamano
          Case CampoReporteAtributo.EnumTipoDato.Numero
            Dim estilonum0 As New DataGridViewCellStyle()
            estilonum0.Format = "N0"

            _datagridcolumn = New DataGridViewTextBoxColumn
            _datagridcolumn.DataPropertyName = attrCustom.Campo
            _datagridcolumn.DefaultCellStyle = estilonum0
            _datagridcolumn.HeaderText = attrCustom.Etiqueta
            _datagridcolumn.Width = attrCustom.Tamano
          Case CampoReporteAtributo.EnumTipoDato.Logico
            _datagridcolumn = New DataGridViewCheckBoxColumn
            _datagridcolumn.DataPropertyName = attrCustom.Campo
            _datagridcolumn.HeaderText = attrCustom.Etiqueta
            _datagridcolumn.Width = attrCustom.Tamano
          Case CampoReporteAtributo.EnumTipoDato.Fecha
            _datagridcolumn = New DataGridViewTextBoxColumn
            _datagridcolumn.DataPropertyName = attrCustom.Campo
            _datagridcolumn.HeaderText = attrCustom.Etiqueta
            _datagridcolumn.Width = attrCustom.Tamano
        End Select
        Me.Columns.Add(_datagridcolumn)
      End If
    Next
    RaiseEvent DespuesSeleccionarCampos(Me, Nothing)
  End Sub

  Private Sub DataGridViewAutoDiscover_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DataSourceChanged
    Me.AutoDiscover()
  End Sub

  Public Sub Merge()
    If Not AgruparRepetidos Then
      Exit Sub
    End If
    Me.RowHeadersVisible = False
    If Me.DisplayedRowCount(True) = 0 Then
      Exit Sub
    End If

    For Each _control As Control In Me.Controls
      If TypeOf _control Is Label Then
        _control.Dispose()
      End If
    Next

    Dim _texto As String = ">>>>"
    Dim x As Integer
    Dim y As Integer
    Dim w As Integer
    Dim h As Integer

    Dim countrow As Integer = -1
    For Each _row As DataGridViewRow In Me.Rows
      countrow += 1
      If _row.Displayed Then
        Dim valor As Object
        valor = GetField(CType(Me.DataSource, IList).Item(countrow), Me.Columns(0).DataPropertyName)

        If valor <> _texto Then
          If _texto <> ">>>>" Then
            Dim _label As New Label
            With _label
              .Text = _texto
              .Font = New Drawing.Font(Me.DefaultCellStyle.Font, Me.DefaultCellStyle.Font.Style)
              .SetBounds(x, y, w, h)
            End With
            Me.Controls.Add(_label)
          End If

          x = Me.GetRowDisplayRectangle(_row.Index, False).Left
          y = Me.GetRowDisplayRectangle(_row.Index, False).Top
          w = Me.GetColumnDisplayRectangle(0, False).Right - x - 1
          h = Me.GetRowDisplayRectangle(_row.Index, False).Size.Height - 1

          _texto = valor
        Else
          h += Me.GetRowDisplayRectangle(_row.Index, False).Size.Height
        End If
      End If
    Next
    If _texto <> ">>>>>" Then
      Dim _label As New Label
      With _label
        .Text = _texto
        .Font = New Drawing.Font(Me.DefaultCellStyle.Font, Me.DefaultCellStyle.Font.Style)
        .TextAlign = ContentAlignment.MiddleLeft
        .SetBounds(x, y, w, h)
      End With
      Me.Controls.Add(_label)
    End If
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

  Private Sub DataGridView1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Merge()
  End Sub

  Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Me.RowPostPaint
    Merge()
  End Sub

  Public Sub New()
    Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
  End Sub

  Public Enum EnumSalida
    Excel
    Correo
    MailMerge
  End Enum

  Public Sub Excel(_output As EnumSalida, Optional _docmerge As String = "", Optional _progressbar As ProgressBar = Nothing)
    Try
      Dim data As IList = CType(Me.DataSource.DataSource, IList)

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
        For t As Integer = 1 To Me.ColumnCount
          .Cells(1, t).Value = Me.Columns(t - 1).HeaderText
          .Columns(t).columnwidth = IIf(Me.Columns(t - 1).Width / 6.8 > 255, 255, Me.Columns(t - 1).Width / 6.8)

          Dim _pro As System.Reflection.PropertyInfo
          _pro = dets.GetProperty(Me.Columns(t - 1).DataPropertyName)

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

        If _progressbar IsNot Nothing Then
          _progressbar.Visible = True
          _progressbar.Maximum = data.Count
          _progressbar.Minimum = 0
          _progressbar.Value = 0
        End If

        Dim r As Integer = 0
        For _row As Integer = 1 To data.Count
          'Dim vals As Object
          'vals = typeDs.GetProperty("Item").GetValue(Me.DataSource.DataSource, New Object() {_row - 1})
          r += 1
          If _progressbar IsNot Nothing Then
            _progressbar.Value = r
          End If

          For t As Integer = 1 To Me.ColumnCount
            'Dim _pro As System.Reflection.PropertyInfo
            '_pro = vals.GetType.GetProperty(Me.Columns(t - 1).DataPropertyName)
            Dim valor As Object
            valor = GetField(data.Item(_row - 1), Me.Columns(t - 1).DataPropertyName)
            If TypeOf valor Is Boolean Then
              .Cells(_row + 1, t).Value = IIf(CBool(valor), "Sí", "No")
            Else
              Dim _pro As System.Reflection.PropertyInfo
              _pro = dets.GetProperty(Me.Columns(t - 1).DataPropertyName)

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

        If _progressbar IsNot Nothing Then
          _progressbar.Visible = False
        End If
      End With
      excelApp.Visible = True
      excelApp.ScreenUpdating = True
      'excelWorksheet.PrintPreview()
      'excelApp.Quit()
      If _output = EnumSalida.Correo Then
        excelApp.Dialogs(Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogSendMail).Show()
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
      Else
      End If
    Catch ex As Exception
      MsgBox("No se puede exporta a Microsoft Excel. " & ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
    End Try
  End Sub
End Class