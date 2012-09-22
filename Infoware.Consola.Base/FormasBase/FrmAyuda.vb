Public Class FrmAyuda
  Public Property Titulo() As String
    Get
      Return Me.lbltitulo.Text
    End Get
    Set(ByVal value As String)
      Me.lbltitulo.Text = value
    End Set
  End Property

  Public Property Descripcion() As String
    Get
      Return Me.txtdescripcion.Text
    End Get
    Set(ByVal value As String)
      Me.txtdescripcion.Text = value
    End Set
  End Property

  Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
    Me.Close()
  End Sub
End Class