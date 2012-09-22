Imports Infoware.Reglas.General
Imports System.Windows.Forms

Public Class FrmFormaBase
  Public Event AplicarRestricciones As EventHandler

  Public Event Inicializar As EventHandler

  Private mSistema As Sistema = Nothing
  Public Property Sistema() As Sistema
    Get
      Return mSistema
    End Get
    Set(ByVal value As Sistema)
      mSistema = value
      If value IsNot Nothing Then
        RaiseEvent Inicializar(Me, Nothing)
      End If
    End Set
  End Property

  Private mRestriccion As Restriccion = Nothing
  Public Property Restriccion() As Restriccion
    Get
      Return mRestriccion
    End Get
    Set(ByVal value As Restriccion)
      mRestriccion = value
    End Set
  End Property

#Region "New"
  Public Sub New()
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionDefault As Integer = 0)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Sistema = _Sistema
    ''''Sistema.OpcionDefault = _OpcionDefault
    Restriccion = _Restriccion
    RaiseEvent AplicarRestricciones(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, Optional ByVal _OpcionDefault As Integer = 0)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _OpcionDefault)
  End Sub
#End Region


  Private Sub FrmMantenimientoSimpleBase_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
    Try
      If TypeOf Me.Parent Is MdiClient Then
        Me.MainMenuStrip.Visible = False
      Else
        Me.MainMenuStrip.Visible = True
      End If
    Catch ex As Exception

    End Try
  End Sub

End Class