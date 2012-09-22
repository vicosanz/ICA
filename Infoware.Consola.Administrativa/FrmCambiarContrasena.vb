Imports Infoware.Datos
Imports Infoware.Consola.Base
Imports Infoware.Reglas.General

Public Class FrmCambiarContrasena
  Private mUsuario As Usuario = Nothing
  Public Property Usuario() As Usuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As Usuario)
      mUsuario = value
    End Set
  End Property

  Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
    Try
      If Me.txtnueva.Text = Me.txtconfirmar.Text Then
        If Me.txtnueva.Text.Trim = String.Empty Then
          Throw New Exception("La contraseña no puede estar en blanco")
        End If
        mUsuario.Usuari_Password = Me.txtnueva.Text.Trim
        mUsuario.CambiarContrasena()
        mUsuario.Usuari_CambiarContrasena = False
        mUsuario.Guardar()

        Me.DialogResult = Windows.Forms.DialogResult.OK
      Else
        Throw New Exception("La contraseña nueva y la confirmación deben ser iguales. Por favor redigítelas")
      End If

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Información")
    End Try

  End Sub

  Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
    mUsuario.Usuari_CambiarContrasena = False
    mUsuario.Guardar()
  End Sub
End Class