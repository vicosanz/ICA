Imports System.ComponentModel
Imports System.Reflection
Imports Microsoft.Office.Interop
Imports Infoware.Reglas.General
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Excel
Imports Infoware.Consola.Base.StructExcel

Public Class FrmListaSimpleBase
  Public WriteOnly Property Titulo() As String
    Set(ByVal value As String)
      Dim _titulo As String = value
      Me.Text = _titulo
      Me.ToolStriptitulo.Text = _titulo
    End Set
  End Property

  Public Event Imprimir As EventHandler

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

  Private mAutoUpdate As Integer = 0
  Public Property AutoUpdate() As Integer
    Get
      Return mAutoUpdate
    End Get
    Set(ByVal value As Integer)
      mAutoUpdate = value
      If value = 0 Then
        Me.Timer1.Enabled = False
        Me.ToolStripProgressBar1.Visible = False
      Else
        Me.Timer1.Interval = 500
        Me.Timer1.Enabled = True
        Me.ToolStripProgressBar1.Visible = True
        Me.ToolStripProgressBar1.Minimum = 0
        Me.ToolStripProgressBar1.Maximum = value * 2
        Me.ToolStripProgressBar1.Step = 1
        Me.ToolStripProgressBar1.Value = 0
      End If
    End Set
  End Property

  Private mAutoMail As Boolean = False
  Public Property AutoMail() As Boolean
    Get
      Return mAutoMail
    End Get
    Set(ByVal value As Boolean)
      mAutoMail = value
    End Set
  End Property

  Private mProximoAutoMail As Date = Nothing
  Public Property ProximoAutoMail() As Date
    Get
      Return mProximoAutoMail
    End Get
    Set(ByVal value As Date)
      mProximoAutoMail = value
      If Not value = Nothing Then
        mEnviandomail = False
        Me.Timer2.Interval = 10000
        Me.Timer2.Enabled = True
        Me.btnenviomails.Visible = True
        Me.btnenviomails.Text = String.Format("El envío se realizará {0} {1}", mProximoAutoMail.ToShortDateString, mProximoAutoMail.ToShortTimeString)
      Else
        Me.Timer2.Enabled = False
        Me.btnenviomails.Text = "No se ha definido envío automático"
      End If
    End Set
  End Property

  Private Sub btnword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnword.Click, WordToolStripMenuItem1.Click
    EnviarExcel(EnumSalida.MailMerge, mDocSalida)
  End Sub

  'Private mExcelAgrupado As Integer = 0
  'Public Property ExcelAgrupado() As Integer
  '  Get
  '    Return mExcelAgrupado
  '  End Get
  '  Set(ByVal value As Integer)
  '    mExcelAgrupado = value
  '  End Set
  'End Property

  'Private mExcelSumarizar As Integer()
  'Public Property ExcelSumarizar() As Integer()
  '  Get
  '    Return mExcelSumarizar
  '  End Get
  '  Set(ByVal value As Integer())
  '    mExcelSumarizar = value
  '  End Set
  'End Property

  'Public Structure StructExcelCamposTablaPivot
  '  Enum EnumTipoCampoPivot
  '    Pivot
  '    Suma
  '    Promedio
  '    Cuenta
  '    Maximo
  '    Minimo
  '  End Enum
  '  Public TipoCampo As EnumTipoCampoPivot
  '  Public NombreCampo As String
  '  Public Formato As String
  'End Structure

  'Private mExcelCamposTablaPivot As List(Of StructExcelCamposTablaPivot)
  'Public Property ExcelCamposTablaPivot() As List(Of StructExcelCamposTablaPivot)
  '  Get
  '    Return mExcelCamposTablaPivot
  '  End Get
  '  Set(ByVal value As List(Of StructExcelCamposTablaPivot))
  '    mExcelCamposTablaPivot = value
  '  End Set
  'End Property

  Public Enum EnumSalida
    Excel
    Correo
    MailMerge
    Archivo
  End Enum

  Delegate Sub DespuesExportarTexto(ByVal sender As Object, ByVal e As EventArgs)
  Private mDespuesExportarTexto As DespuesExportarTexto = Nothing

  Public Property ObjDespuesExportarTexto As DespuesExportarTexto
    Get
      Return mDespuesExportarTexto
    End Get
    Set(value As DespuesExportarTexto)
      mDespuesExportarTexto = value
    End Set
  End Property

  Private Function EnviarExcel(Optional ByVal _output As EnumSalida = EnumSalida.Excel, Optional ByVal _docmerge As String = "", Optional ByVal _archivosalida As String = "", Optional ByVal _mostrarmensajes As Boolean = True) As String
    Try
      If TabControl1.TabPages.Count = 0 Then 'evitar generar archivo en blanco
        Return String.Empty
      End If

			Dim empty As Boolean = True
			Dim excelApp As New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim _esTxt As Boolean = False

      Dim idtab As Integer = 0
      For Each _tab As TabPage In TabControl1.TabPages
        Dim dg As DataGridView = _tab.Controls(0)
        Dim excelWorksheet As Excel.Worksheet

        If idtab + 1 <= excelBook.Worksheets.Count Then
          excelWorksheet = excelBook.Worksheets(idtab + 1)
        Else
          excelWorksheet = excelBook.Worksheets.Add(After:=excelBook.Worksheets(idtab))
        End If
        'CType(excelBook.Worksheets(1), Excel.Worksheet)
        With excelWorksheet
          .Name = _tab.Text
          Dim data As System.Data.DataTable = CType(dg.DataSource.DataSource, System.Data.DataTable)

          'If data Is Nothing OrElse data.Rows.Count = 0 Then
          '  Throw New Exception("No existen registros a exportar")
          'End If
          For t As Integer = 1 To dg.ColumnCount
            If dg.Columns(t - 1).HeaderText.Trim.ToLower = "txt_salida" Then
              _esTxt = True
            End If
          Next

          If Not _esTxt Then
            Dim icol As Integer = 1
            For t As Integer = 1 To dg.ColumnCount
              If Not dg.Columns(t - 1).HeaderText.Chars(0) = "_" Then
                .Cells(1, icol).Value = dg.Columns(t - 1).HeaderText
                .Columns(icol).columnwidth = IIf(dg.Columns(t - 1).Width / 6.8 > 255, 255, dg.Columns(t - 1).Width / 6.8)

                If dg.Columns(t - 1).HeaderText.ToUpper.IndexOf("FECHA_HORA") >= 0 Then
                  .Columns(icol).numberformat = "m/d/yy h:mm;@"
                ElseIf Not _output = EnumSalida.MailMerge AndAlso (data.Columns(t - 1).DataType Is GetType(Decimal) Or data.Columns(t - 1).DataType Is GetType(Double)) Then
                  .Columns(icol).numberformat = "0.00" '& Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator & "00"
                ElseIf Not _output = EnumSalida.MailMerge AndAlso (data.Columns(t - 1).DataType Is GetType(Integer) Or data.Columns(t - 1).DataType Is GetType(Byte)) Then
                  .Columns(icol).numberformat = "0"
                ElseIf Not _output = EnumSalida.MailMerge AndAlso data.Columns(t - 1).DataType Is GetType(System.DateTime) Then
                  .Columns(icol).numberformat = My.Application.Culture.DateTimeFormat.ShortDatePattern
                Else 'data.Columns(t - 1).DataType Is GetType(String) Or data.Columns(t - 1).DataType Is GetType(Boolean) Then
                  .Columns(icol).numberformat = "@"
                End If
                icol += 1
              End If
            Next
          End If

          Dim _fila As Integer = 0
          If _esTxt Then
            _fila = -1
          End If

					If empty AndAlso data.Rows.Count > 0 Then
						empty = False
					End If

					If data.Rows.Count > 1000 OrElse TabControl1.TabPages.Count > 3 Then
						If data.Rows.Count > 0 Then
							dg.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
							dg.SelectAll()
							Dim dataobj As DataObject = dg.GetClipboardContent
							Clipboard.SetDataObject(dataobj, True)
							dg.ClearSelection()
							.Cells(_fila + 2, 1).select()
							.Paste()
						End If
					Else

						For Each _row As DataRow In data.Rows
              _fila += 1
              Dim icol As Integer = 1
              For t As Integer = 1 To dg.ColumnCount
                If Not dg.Columns(t - 1).HeaderText.Chars(0) = "_" Then
                  Dim valor As Object
                  valor = _row(t - 1)
                  If TypeOf valor Is Boolean Then
                    .Cells(_fila + 1, icol).Value = IIf(CBool(valor), "Sí", "No")
                  ElseIf TypeOf valor Is System.Array Then
                  Else
                    If Not TypeOf valor Is DBNull Then
                      If _output = EnumSalida.MailMerge AndAlso (data.Columns(t - 1).DataType Is GetType(Decimal) Or data.Columns(t - 1).DataType Is GetType(Double)) Then
                        .Cells(_fila + 1, icol).value = Val(valor).ToString("0.00")
                      ElseIf _output = EnumSalida.MailMerge AndAlso (data.Columns(t - 1).DataType Is GetType(Integer) Or data.Columns(t - 1).DataType Is GetType(Byte)) Then
                        .Cells(_fila + 1, icol).value = Val(valor).ToString("0")
                      ElseIf _output = EnumSalida.MailMerge AndAlso data.Columns(t - 1).DataType Is GetType(System.DateTime) Then
                        .Cells(_fila + 1, icol).value = Format(valor, My.Application.Culture.DateTimeFormat.ShortDatePattern)
                      Else 'data.Columns(t - 1).DataType Is GetType(String) Or data.Columns(t - 1).DataType Is GetType(Boolean) Then
                        .Cells(_fila + 1, icol).Value = valor
                      End If
                    End If
                    '.Cells(_fila + 1, icol).Value = valor
                  End If
                  icol += 1
                End If
              Next
            Next
          End If

          If Not _esTxt Then
            .Cells(1, 1).AutoFormat(Format:=Excel.XlRangeAutoFormat.xlRangeAutoFormatList3, Number:=True, Font:=True, Alignment:=True, Border:=True, Pattern:=True, Width:=True)
          End If

          Dim _struct As StructExcel = CType(Me.TabControl1.Tag, StructExcelList).Devolver(idtab + 1)
          'If idtab = 0 AndAlso mExcelAgrupado > 0 AndAlso mExcelSumarizar IsNot Nothing AndAlso mExcelSumarizar.Length > 0 Then
          If _struct.Subtotales IsNot Nothing AndAlso _struct.Subtotales.Count > 0 Then
            For Each _subtotal As StructExcel.StructSubtotales In _struct.Subtotales
              Dim _resultados(_subtotal.CamposResultado.Count - 1) As Integer
              Dim t As Integer = 0
              For Each _campo As Integer In _subtotal.CamposResultado
                _resultados(t) = _campo
                t += 1
              Next
              Dim _operacion As Excel.XlConsolidationFunction
              Select Case _subtotal.Funcion
                Case StructExcel.EnumFuncion.Suma
                  _operacion = XlConsolidationFunction.xlSum
                Case StructExcel.EnumFuncion.Promedio
                  _operacion = XlConsolidationFunction.xlAverage
                Case StructExcel.EnumFuncion.Cuenta
                  _operacion = XlConsolidationFunction.xlCount
                Case StructExcel.EnumFuncion.Minimo
                  _operacion = XlConsolidationFunction.xlMin
                Case StructExcel.EnumFuncion.Maximo
                  _operacion = XlConsolidationFunction.xlMax
              End Select
              If _fila > 0 Then
                .Cells(1, 1).Subtotal(GroupBy:=_subtotal.CampoAgrupado, Function:=_operacion, TotalList:=_resultados, Replace:=True, PageBreaks:=False, SummaryBelowData:=True)
              End If
            Next
          ElseIf _struct.Totalizar IsNot Nothing AndAlso _struct.Totalizar.Count > 0 Then
            Dim _ocupoprimeracolumna As Boolean = False
            For Each _totalizar As StructExcel.StructTotalizar In _struct.Totalizar
              If _totalizar.Campo = 1 Then
                _ocupoprimeracolumna = True
              End If
              Dim _formula As String = ""
              'Select Case _totalizar.Funcion
              '  Case StructExcel.EnumFuncion.Suma
              '    _formula = "=SUMA(F{1}C{0}:F{2}C{0})"
              '  Case StructExcel.EnumFuncion.Promedio
              '    _formula = "=PROMEDIO(F{1}C{0}:F{2}C{0})"
              '  Case StructExcel.EnumFuncion.Maximo
              '    _formula = "=MAX(F{1}C{0}:F{2}C{0})"
              '  Case StructExcel.EnumFuncion.Minimo
              '    _formula = "=MIN(F{1}C{0}:F{2}C{0})"
              '  Case StructExcel.EnumFuncion.Cuenta
              '    _formula = "=CONTAR(F{1}C{0}:F{2}C{0})"
              'End Select
              Select Case _totalizar.Funcion
                Case StructExcel.EnumFuncion.Suma
                  _formula = "=SUM(R{1}C{0}:R{2}C{0})"
                Case StructExcel.EnumFuncion.Promedio
                  _formula = "=AVERAGE(R{1}C{0}:R{2}C{0})"
                Case StructExcel.EnumFuncion.Maximo
                  _formula = "=MAX(R{1}C{0}:R{2}C{0})"
                Case StructExcel.EnumFuncion.Minimo
                  _formula = "=MIN(R{1}C{0}:R{2}C{0})"
                Case StructExcel.EnumFuncion.Cuenta
                  _formula = "=COUNT(R{1}C{0}:R{2}C{0})"
              End Select

              .Cells(data.Rows.Count + 2, _totalizar.Campo).FormulaR1C1 = String.Format(_formula, (_totalizar.Campo).ToString.Trim, (2).ToString.Trim, (data.Rows.Count + 1).ToString.Trim)
            Next
            If Not _ocupoprimeracolumna Then
              .Cells(data.Rows.Count + 2, 1) = "Totales"
            End If
            .Cells(1, 1).AutoFormat(Format:=Excel.XlRangeAutoFormat.xlRangeAutoFormatList3, Number:=True, Font:=True, Alignment:=True, Border:=True, Pattern:=True, Width:=True)
          ElseIf _struct.TablaDinamica.Campos IsNot Nothing AndAlso _struct.TablaDinamica.Campos.Count > 0 Then
            excelBook.PivotCaches.Add(SourceType:=Excel.XlPivotTableSourceType.xlDatabase, SourceData:="'" + .Name + "'!R1C1:R" & (dg.RowCount + 1).ToString.Trim & "C" & dg.ColumnCount.ToString.Trim).CreatePivotTable(TableDestination:="", TableName:="Tabla dinámica " & _tab.Text, DefaultVersion:=Excel.XlPivotTableVersionList.xlPivotTableVersion10)
            Dim sheetpivot As Excel.Worksheet
            sheetpivot = excelBook.ActiveSheet
            Dim tabla As Excel.PivotTable
            tabla = sheetpivot.PivotTables("Tabla dinámica " & _tab.Text)

            sheetpivot.PivotTableWizard(TableDestination:=sheetpivot.Cells(3, 1))

            Dim pospivot As Integer = 0
            For Each _pivot As String In _struct.TablaDinamica.Pivots
              With tabla.PivotFields(_pivot)
                .Orientation = Excel.XlPivotFieldOrientation.xlRowField
                pospivot += 1
                .Position = pospivot
              End With
            Next

            pospivot = 0
            For Each _pivot As String In _struct.TablaDinamica.PivotsColumns
              With tabla.PivotFields(_pivot)
                .Orientation = Excel.XlPivotFieldOrientation.xlColumnField
                pospivot += 1
                .Position = pospivot
              End With
            Next

            pospivot = 0
            For Each _pivot As String In _struct.TablaDinamica.PivotsPage
              With tabla.PivotFields(_pivot)
                .Orientation = Excel.XlPivotFieldOrientation.xlPageField
                pospivot += 1
                .Position = pospivot
              End With
            Next

            For Each _item As StructCampoTablaDinamica In _struct.TablaDinamica.Campos
              Dim proceso As Excel.XlConsolidationFunction = Excel.XlConsolidationFunction.xlCount
              Select Case _item.Funcion
                Case EnumFuncion.Cuenta
                  proceso = Excel.XlConsolidationFunction.xlCount
                Case EnumFuncion.Suma
                  proceso = Excel.XlConsolidationFunction.xlSum
                Case EnumFuncion.Promedio
                  proceso = Excel.XlConsolidationFunction.xlAverage
                Case EnumFuncion.Maximo
                  proceso = Excel.XlConsolidationFunction.xlMax
                Case EnumFuncion.Minimo
                  proceso = Excel.XlConsolidationFunction.xlMin
              End Select

              With tabla
                .AddDataField(tabla.PivotFields(_item.Campo), _item.Funcion.ToString & " de " & _item.Campo, proceso)
              End With

              If _item.Formato.Trim <> String.Empty Then
                tabla.PivotFields(_item.Funcion.ToString & " de " & _item.Campo).NumberFormat = _item.Formato
              End If
            Next

            If _struct.TablaDinamica.DataPivotFieldasColumn Then
              tabla.DataPivotField.Orientation = XlPivotFieldOrientation.xlColumnField
            End If

            'tabla.Format(Excel.XlPivotFormatType.xlReport1)
            excelBook.ShowPivotTableFieldList = False
          End If

          'graficar
          If _struct.Graficar.TipoGrafico <> 0 Then
            Dim _chart As Chart = excelApp.Charts.Add()
            With _chart
              .ChartType = _struct.Graficar.TipoGrafico
              'Dim _rango As Excel.Range
              '_rango = excelWorksheet.Range(excelWorksheet.Cells(1, 1), excelWorksheet.Cells(dg.RowCount + 1, dg.ColumnCount + 1))

              .SetSourceData(Source:=excelWorksheet.Range(excelWorksheet.Cells(1, 1), excelWorksheet.Cells(dg.RowCount + 1, dg.ColumnCount)), PlotBy:=_struct.Graficar.Orientacion)
              .Location(Where:=XlChartLocation.xlLocationAsObject, Name:=_tab.Text)
              '.HasTitle = False
              '.Axes(XlAxisType.xlCategory, XlAxisGroup.xlPrimary).HasTitle = False
              '.Axes(XlAxisType.xlValue, XlAxisGroup.xlPrimary).HasTitle = False
              Try
                .Axes(XlAxisType.xlCategory).TickLabelSpacingIsAuto = True
              Catch ex As Exception

              End Try
              Try
                .Axes(XlAxisType.xlCategory).TickLabelSpacing = 1
              Catch ex As Exception

              End Try
            End With
            .Shapes.Item(1).Left = 0
            .Shapes.Item(1).Top = 15 * (data.Rows.Count + 3)
            .Shapes.Item(1).Height = .Shapes.Item(1).Height * _struct.Graficar.RelacionAlto
            .Shapes.Item(1).Width = .Shapes.Item(1).Width * _struct.Graficar.RelacionAncho
          End If

        End With
        idtab += 1
      Next
      excelBook.Worksheets(1).select()
      excelApp.ScreenUpdating = True
			'excelWorksheet.PrintPreview()
			'excelApp.Quit()
			If _esTxt Then
				'Dim _salida As String = "C:\Salida.txt"
				Dim _salida As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Salida.txt")

				Try
					Kill(_salida)
				Catch ex As Exception
					'Throw New Exception(String.Format("No se puede eliminar el archivo temporal {0), posiblemente esté en uso", _salida))
				End Try

				excelApp.Visible = False
				excelApp.ActiveWorkbook.SaveAs(Filename:=_salida, FileFormat:=Excel.XlFileFormat.xlTextMSDOS, CreateBackup:=False)
				Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Txt")
				excelApp.ActiveWorkbook.Close(False)
				excelApp.Quit()

				Process.Start(_salida)

				If mDespuesExportarTexto IsNot Nothing Then
					mDespuesExportarTexto.Invoke(Me, Nothing)
				End If

				If _mostrarmensajes Then
					'MsgBox(String.Format("Archivo generado correctamente en {0}", "C:\Salida.txt"), MsgBoxStyle.Information, "Información")
					MsgBox(String.Format("Archivo generado correctamente en {0}", _salida), MsgBoxStyle.Information, "Información")
				End If
			ElseIf _output = EnumSalida.Correo Then
				excelApp.Visible = True
				excelApp.Dialogs(Excel.XlBuiltInDialog.xlDialogSendMail).Show()
				Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel y enviar por mail")

			ElseIf _output = EnumSalida.Archivo Then
				excelApp.Visible = False
				Dim rutfte As String = ""
				If Not empty Then
					If String.IsNullOrEmpty(_archivosalida) Then
						rutfte = String.Format("{0}{1}", My.Computer.FileSystem.GetTempFileName.ToLower.Replace(".tmp", ""), ".xlsx")
					Else
						rutfte = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, _archivosalida + ".xlsx")
						Dim ok As Boolean = False
						Dim intento As Integer = 0
						While Not ok
							If IO.File.Exists(rutfte) Then
								Try
									IO.File.Delete(rutfte)
									ok = True
								Catch ex As Exception
									ok = False
									intento += 1
									rutfte = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, _archivosalida + intento.ToString.Trim + ".xlsx")
								End Try
							Else
								ok = True
							End If
						End While
					End If

					excelBook.SaveAs(Filename:=rutfte)
					'excelBook.SaveAs(Filename:=rutfte, FileFormat:=Excel.XlFileFormat.xlExcel5)
					excelBook.Close()
					excelApp.Quit()
					Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a archivo")
				End If
				Return rutfte

			ElseIf _output = EnumSalida.MailMerge Then
				Dim rutfte As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.xlsx"
				Try
					If My.Computer.FileSystem.FileExists(rutfte) Then
						Kill(rutfte)
					End If
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
					.OpenDataSource(Name:=rutfte, Connection:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutfte & ";", SQLStatement:="SELECT * FROM `" & Me.TabControl1.TabPages(0).Text & "$`")
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
				excelApp.Visible = True
				Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Exportar a Excel")
			End If
		Catch ex As Exception
      If _mostrarmensajes Then
        MsgBox("Error al exporta a Microsoft Excel. " & ex.Message, MsgBoxStyle.Critical, "Error")
      End If
    Finally

    End Try
    Return Nothing
  End Function

  Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click, ImprimirToolStripMenuItem.Click
    Dim doc As New Infoware.Reportes.ReportDocument
    doc.Titulo = Me.Text

    Dim _tab As TabPage = TabControl1.TabPages(0)
    Dim _dg As DataGridView = _tab.Controls(0)

    If _dg.ColumnCount > 5 Then
      doc.DefaultPageSettings.Landscape = True
    End If
    doc.DataGridView = _dg
    Dim previo As New System.Windows.Forms.PrintPreviewDialog
    previo.Document = doc
    previo.Document.DocumentName = Me.Text
    previo.Text = Me.Text
    previo.WindowState = FormWindowState.Maximized
    previo.ShowDialog()

    Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion)
    RaiseEvent Imprimir(Me, Nothing)
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
    Me.btncorreo.Enabled = Restriccion.Restri_Impresion
    Me.CorreoToolStripMenuItem1.Enabled = Restriccion.Restri_Impresion
    Me.btnword.Enabled = Restriccion.Restri_Impresion
    Me.WordToolStripMenuItem1.Enabled = Restriccion.Restri_Impresion
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
    FrmListaSimpleBase_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, Optional ByVal _OpcionDefault As Integer = 0)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _OpcionDefault)
  End Sub

  Private Sub FrmListaSimpleBase_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Dim mmenu As New MenuHelper
    mmenu.CrearMenuEdicion(Me.EdicionToolStripMenuItem)
  End Sub
#End Region

#Region "Abrir"
  Public Event Abrir As EventHandler

  Public Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    RaiseEvent Abrir(Me, Nothing)
  End Sub

  Public Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Select Case e.KeyCode
      Case Keys.Enter
        e.Handled = True
        RaiseEvent Abrir(Me, Nothing)
    End Select
  End Sub
#End Region


  Public Event Actualizar As EventHandler

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    Me.ToolStripProgressBar1.Increment(1)
    If Me.ToolStripProgressBar1.Value >= Me.ToolStripProgressBar1.Maximum Then
      Me.ToolStripProgressBar1.Value = 0
      RaiseEvent Actualizar(Me, Nothing)
    End If
  End Sub

  Public Sub ReiniciarProgressBar()
    Me.ToolStripProgressBar1.Value = 0
  End Sub

  Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
    Me.Close()
  End Sub

  Public Property PuedeImprimir() As Boolean
    Get
      Return Me.btnimprimir.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.btnimprimir.Enabled = value
      Me.ImprimirToolStripMenuItem.Enabled = value
      Me.btnexportar.Enabled = value
      Me.ExportarToolStripMenuItem.Enabled = value
    End Set
  End Property

  Public Event EnviandoAutoMail As EventHandler

  Private mEnviandomail As Boolean = False

  Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
    If mProximoAutoMail = Nothing Then
      Return
    End If
    Try
      Dim minutosfaltan As Integer = Math.Abs(mProximoAutoMail.Subtract(Now).Hours * 60 + mProximoAutoMail.Subtract(Now).Minutes)

      If Not mEnviandomail AndAlso mProximoAutoMail.Subtract(Now).Days = 0 AndAlso minutosfaltan < 1 AndAlso minutosfaltan > -1 Then
        mEnviandomail = True
        EnviarAutoMail()
        Me.btnenviomails.Text = "No se ha definido envío automático"

        RaiseEvent EnviandoAutoMail(Me, Nothing)
      End If
    Catch ex As Exception

    End Try
  End Sub

  Private mAutoMailAsunto As String
  Public Property AutoMailAsunto() As String
    Get
      Return mAutoMailAsunto
    End Get
    Set(ByVal value As String)
      mAutoMailAsunto = value
    End Set
  End Property

  Private mAutoMailArchivo As String
  Public Property AutoMailArchivo() As String
    Get
      Return mAutoMailArchivo
    End Get
    Set(ByVal value As String)
      mAutoMailArchivo = value
    End Set
  End Property

  Private mAutoMailLista As String
  Public Property AutoMailLista() As String
    Get
      Return mAutoMailLista
    End Get
    Set(ByVal value As String)
      mAutoMailLista = value
    End Set
  End Property

	Public Sub EnviarAutoMail(Optional OriginalMessage As Outlook.MailItem = Nothing)
		RaiseEvent Actualizar(Me, Nothing)

		If String.IsNullOrEmpty(AutoMailLista) AndAlso OriginalMessage Is Nothing Then
			Exit Sub
		End If

		Timer2.Enabled = False
		Dim sSource As String = EnviarExcel(EnumSalida.Archivo, "", AutoMailArchivo, False)
		If String.IsNullOrEmpty(sSource) OrElse Not IO.File.Exists(sSource) Then
			Exit Sub
		End If

		Dim oApp As Outlook._Application
		oApp = New Outlook.Application()
		Dim oMsg As Outlook._MailItem
		If OriginalMessage IsNot Nothing Then
			oMsg = OriginalMessage.ReplyAll
		Else
			oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
			oMsg.Subject = AutoMailAsunto
			oMsg.Body = Me.Text
			oMsg.To = AutoMailLista
		End If

		Dim sDisplayName As String = "Archivo.xlsx"
		Dim sBodyLen As String = oMsg.Body.Length
		Dim oAttachs As Outlook.Attachments = oMsg.Attachments
		Dim oAttach As Outlook.Attachment
		oAttach = oAttachs.Add(sSource, , sBodyLen + 1, sDisplayName)

		oMsg.Send()

		oApp = Nothing
		oMsg = Nothing
		oAttach = Nothing
		oAttachs = Nothing
	End Sub

	Private Sub btnenviomails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenviomails.Click
    EnviarAutoMail()
  End Sub
End Class