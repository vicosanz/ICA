Public Class StructExcel
  Enum EnumFuncion
    'Pivot
    Suma
    Promedio
    Cuenta
    Maximo
    Minimo
  End Enum

  Private mNumero As Integer
  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
    End Set
  End Property

#Region "Subtotales"
  Public Structure StructSubtotales
    Public CampoAgrupado As Integer
    Public Funcion As EnumFuncion
    Public CamposResultado As List(Of Integer)
  End Structure

  Public Subtotales As List(Of StructSubtotales)
#End Region

#Region "TablasDinamicas"
  Public Structure StructCampoTablaDinamica
    Public Campo As String
    Public Funcion As EnumFuncion
    Public Formato As String
  End Structure

  Public Structure StructTablaDinamica
    Public Pivots As List(Of String)
    Public PivotsColumns As List(Of String)
    Public PivotsPage As List(Of String)
    Public DataPivotFieldasColumn As Boolean
    Public Campos As List(Of StructCampoTablaDinamica)
  End Structure

  Public TablaDinamica As StructTablaDinamica
#End Region

#Region "Totalizar"
  Public Structure StructTotalizar
    Public Funcion As EnumFuncion
    Public Campo As Integer
  End Structure

  Public Totalizar As List(Of StructTotalizar)
#End Region

#Region "Graficar"
  Public Enum enumGraficarOrientacion
    Columnas = 2
    Filas = 1
  End Enum

  Public Structure StructGraficar
    Public TipoGrafico As Integer
    Public Orientacion As enumGraficarOrientacion
    Public RelacionAncho As Decimal
    Public RelacionAlto As Decimal
  End Structure

  Public Graficar As StructGraficar
#End Region

#Region "NombreHoja"
  Public NombreHoja As String
#End Region

  Sub New()
    Subtotales = New List(Of StructSubtotales)
    TablaDinamica = New StructTablaDinamica
    TablaDinamica.DataPivotFieldasColumn = False
    Totalizar = New List(Of StructTotalizar)
    Graficar = New StructGraficar
  End Sub
End Class

Public Class StructExcelList
  Inherits System.ComponentModel.BindingList(Of StructExcel)

  Public Function Devolver(ByVal _Numero As Integer) As StructExcel
    Dim _result As StructExcel = Nothing
    For Each _struct As StructExcel In Me
      If _struct.Numero = _Numero Then
        _result = _struct
      End If
    Next
    If _result Is Nothing Then
      _result = New StructExcel
      _result.Numero = _Numero
      Me.Add(_result)
    End If
    Return _result
  End Function
End Class