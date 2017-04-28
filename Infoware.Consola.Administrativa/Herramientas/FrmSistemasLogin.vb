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
    'Me.txtnombresistema.Text = mSistema.NombreSistema
    'Me.txtdescripcionsistema.Text = mSistema.DescripcionSistema
    Me.chkSeguridadWindows.Checked = mSistema.DirectorioRaiz
    Me.txtnombreusuario.Text = mSistema.UsuarioString
    Me.txtcontrasena.Text = mSistema.ContrasenaString
    Me.chkguardarcontrasena.Checked = mSistema.GuardarContrasena

    'Me.txtarchivoensamblado.Text = mSistema.Ensamblado

    'Me.txtnombreusuariobd.Text = mSistema.OperadorDatos.Usuario
    'Me.txtcontrasenabd.Text = mSistema.OperadorDatos.Clave
    'Me.cboservidor.Text = mSistema.OperadorDatos.Servidor
    'Me.txtbasedatos.Text = mSistema.OperadorDatos.Base
    'Me.chkguardarcontrasenabd.Checked = mSistema.OperadorDatos.GuardarContrasena

    If Not String.IsNullOrEmpty(Me.txtnombreusuario.Text) Then
      Me.txtcontrasena.Select()
    End If
  End Sub

  Sub mapear_datos()
    'mSistema.NombreSistema = Me.txtnombresistema.Text
    'mSistema.DescripcionSistema = Me.txtdescripcionsistema.Text
    mSistema.SeguridadWindows = Me.chkSeguridadWindows.Checked
    mSistema.UsuarioString = Me.txtnombreusuario.Text
    mSistema.ContrasenaString = Me.txtcontrasena.Text
    mSistema.GuardarContrasena = Me.chkguardarcontrasena.Checked

    'mSistema.Ensamblado = Me.txtarchivoensamblado.Text
    'mSistema.OperadorDatos.Usuario = Me.txtnombreusuariobd.Text
    'mSistema.OperadorDatos.Clave = Me.txtcontrasenabd.Text
    'mSistema.OperadorDatos.Servidor = Me.cboservidor.Text
    'mSistema.OperadorDatos.Base = Me.txtbasedatos.Text
    'mSistema.OperadorDatos.GuardarContrasena = Me.chkguardarcontrasenabd.Checked
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      mapear_datos()
      'Me.ColorFadeBusyBar1.Start()
      If mSistema.Probarconexion() Then
        If mSistema.Usuario.Usuari_CambiarContrasena Then
          Dim f As New FrmCambiarContrasena
          f.Usuario = mSistema.Usuario
          f.ShowDialog()
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
      Else
        Throw New Exception(mSistema.MensajeError)
      End If
      'Me.ColorFadeBusyBar1.Stop()
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
    End Try
  End Sub

  Private Sub FrmSistemasLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If My.Application.Info.Title = "Infoware.Consola.Administrativa" Then
      Me.PictureBox1.Image = My.Resources.Resources.ica
    Else
      Me.PictureBox1.Image = My.Resources.Resources.integra
    End If
  End Sub

  Private Sub chkSeguridadWindows_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeguridadWindows.CheckedChanged
    FlowUserPassword.Enabled = Not Me.chkSeguridadWindows.Checked
  End Sub
End Class