Imports System.ComponentModel
Imports System.Windows.Forms
Imports Infoware.Reglas.General

Public Class FrmDialogoBase
  Public Event AntesAceptar As CancelEventHandler
  Public Event AntesCancelar As CancelEventHandler

  Public Property TextoAceptar() As String
    Get
      Return OK_Button.Text
    End Get
    Set(ByVal value As String)
      OK_Button.Text = value
    End Set
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Dim ev As New CancelEventArgs
    RaiseEvent AntesAceptar(Me, ev)
    If Not ev.Cancel Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Dim ev As New CancelEventArgs
    RaiseEvent AntesCancelar(Me, ev)
    If Not ev.Cancel Then
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
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
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Opcion As Integer, Optional ByVal _OpcionDefault As Integer = 0)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_Opcion), _OpcionDefault)
  End Sub
#End Region

  Private Sub FrmAplicarRestricciones(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AplicarRestricciones
  End Sub
End Class
