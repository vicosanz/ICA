Imports Infoware.Consola.Base
Imports Infoware.Datos

Public Class FrmSistemasLogin
  Private mSistema As Sistema
  Public Property Sistema() As Sistema
    Get
      Return mSistema
    End Get
    Set(ByVal value As Sistema)
      mSistema = value
      llenar_datos()
    End Set
  End Property

  Sub llenar_datos()
		Me.chkSeguridadWindows.Checked = mSistema.SeguridadWindows
		Me.txtnombreusuario.Text = mSistema.UsuarioString
		Me.txtcontrasena.Text = mSistema.ContrasenaString
		Me.chkguardarcontrasena.Checked = mSistema.GuardarContrasena

		If Not String.IsNullOrEmpty(Me.txtnombreusuario.Text) Then
      Me.txtcontrasena.Select()
    End If
  End Sub

	Sub mapear_datos()
		mSistema.SeguridadWindows = Me.chkSeguridadWindows.Checked
		mSistema.UsuarioString = Me.txtnombreusuario.Text
		mSistema.ContrasenaString = Me.txtcontrasena.Text
		mSistema.GuardarContrasena = Me.chkguardarcontrasena.Checked
	End Sub

	Private Sub btnguardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnguardar.Click
		Try
			mapear_datos()
			'Me.ColorFadeBusyBar1.Start()
			If mSistema.Probarconexion() Then
				If mSistema.Usuario.Usuari_CambiarContrasena Then
					Dim f As New FrmCambiarContrasena
					f.Usuario = mSistema.Usuario
					If Not f.ShowDialog() = DialogResult.OK Then
						mSistema.ContrasenaString = String.Empty
						Throw New Exception("Error al cambiar la contraseña")
					End If
				End If

				DialogResult = DialogResult.OK
			Else
				Throw New Exception(mSistema.MensajeError)
			End If
			'Me.ColorFadeBusyBar1.Stop()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
			DialogResult = DialogResult.Cancel
		End Try
	End Sub

	Private Sub FrmSistemasLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If My.Application.Info.Title = "Infoware.Consola.Administrativa" Then
			PictureBox1.Image = My.Resources.ica
		Else
			PictureBox1.Image = My.Resources.integra
		End If
  End Sub

  Private Sub chkSeguridadWindows_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeguridadWindows.CheckedChanged
    FlowUserPassword.Enabled = Not Me.chkSeguridadWindows.Checked
  End Sub
End Class