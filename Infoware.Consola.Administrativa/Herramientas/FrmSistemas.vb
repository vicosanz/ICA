Imports Infoware.Consola.Base
Imports Infoware.Datos

Public Class FrmSistemas
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

  Public Property Ensamblado() As String
    Get
      Return Me.txtarchivoensamblado.Text
    End Get
    Set(ByVal value As String)
      Me.txtarchivoensamblado.Text = value
    End Set
  End Property

  Sub llenar_datos()
    Me.txtnombresistema.Text = mSistema.NombreSistema
    Me.txtdescripcionsistema.Text = mSistema.DescripcionSistema
    Me.chkSeguridadWindows.Checked = mSistema.SeguridadWindows
    Me.txtnombreusuario.Text = mSistema.UsuarioString
    Me.txtcontrasena.Text = mSistema.ContrasenaString
    Me.chkguardarcontrasena.Checked = mSistema.GuardarContrasena
    Me.chkcargaraliniciar.Checked = mSistema.Cargaraliniciar

    Me.txtarchivoensamblado.Text = mSistema.Ensamblado

    Me.cboproveedor.ComboBoxStd1.Items.Clear()
    Me.cboproveedor.ComboBoxStd1.Items.Add("SQL Server")
    Me.cboproveedor.ComboBoxStd1.Items.Add("Oracle")
    Me.cboproveedor.ComboBoxStd1.Items.Add("Sybase")
    Me.cboproveedor.ComboBoxStd1.DropDownStyle = ComboBoxStyle.DropDownList
    Me.cboproveedor.ComboBoxStd1.SelectedIndex = 0

    If mSistema.OperadorDatos IsNot Nothing Then
      Me.cboproveedor.ComboBoxStd1.SelectedIndex = mSistema.OperadorDatos.Proveedor
      Me.cboservidor.Text = mSistema.OperadorDatos.Servidor
      Me.txtnombreusuariobd.Text = mSistema.OperadorDatos.Usuario
      Me.txtcontrasenabd.Text = mSistema.OperadorDatos.Clave
      Me.chkSeguridadIntegrada.Checked = mSistema.OperadorDatos.SeguridadIntegrada
      Me.txtbasedatos.Text = mSistema.OperadorDatos.Base
      Me.chkguardarcontrasenabd.Checked = mSistema.OperadorDatos.GuardarContrasena
      Me.txtDirectorioReplicacion.Text = mSistema.OperadorDatos.DirectorioReplicacion
      Me.txtSufijoReplicacion.Text = mSistema.OperadorDatos.SufijoReplicacion
    End If

    If Not String.IsNullOrEmpty(Me.txtnombreusuario.Text) Then
      Me.txtcontrasena.Select()
    End If
  End Sub

  Sub mapear_datos()
    mSistema.NombreSistema = Me.txtnombresistema.Text
    mSistema.DescripcionSistema = Me.txtdescripcionsistema.Text
    mSistema.SeguridadWindows = Me.chkSeguridadWindows.Checked
    mSistema.UsuarioString = Me.txtnombreusuario.Text
    mSistema.ContrasenaString = Me.txtcontrasena.Text
    mSistema.GuardarContrasena = Me.chkguardarcontrasena.Checked
    mSistema.Cargaraliniciar = Me.chkguardarcontrasena.Checked And Me.chkcargaraliniciar.Checked

    mSistema.Ensamblado = Me.txtarchivoensamblado.Text
    mSistema.OperadorDatos = OperadorDatosFactory.CrearInstancia(Me.cboproveedor.ComboBoxStd1.SelectedIndex, Me.cboservidor.Text, Me.txtbasedatos.Text, Me.txtnombreusuariobd.Text, Me.txtcontrasenabd.Text, Me.chkSeguridadIntegrada.Checked)
    mSistema.OperadorDatos.DirectorioReplicacion = Me.txtDirectorioReplicacion.Text
    mSistema.OperadorDatos.SufijoReplicacion = Me.txtSufijoReplicacion.Text
    If Not String.IsNullOrWhiteSpace(Me.txtDirectorioReplicacion.Text) Then
      If Not My.Computer.FileSystem.DirectoryExists(Me.txtDirectorioReplicacion.Text) OrElse String.IsNullOrWhiteSpace(Me.txtSufijoReplicacion.Text) Then
        Throw New Exception("Debe ingresar un directorio de replicación váldo y un Sufijo")
      End If
    End If
    'mSistema.OperadorDatos.Usuario = Me.txtnombreusuariobd.Text
    'mSistema.OperadorDatos.Clave = Me.txtcontrasenabd.Text
    'mSistema.OperadorDatos.Servidor = Me.cboservidor.Text
    'mSistema.OperadorDatos.Base = Me.txtbasedatos.Text
    'mSistema.OperadorDatos.GuardarContrasena = Me.chkguardarcontrasenabd.Checked
  End Sub

  Private Sub btnprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprobar.Click
    Try
      mapear_datos()
      'Dim a As New OperadorDatosList
      'a.Add(mSistema.OperadorDatos)
      'a.axml("c:\temp\xml.xml")
      If Not mSistema.Probarconexion Then
        MsgBox(String.Format("{0} {1}", mSistema.MensajeError, mSistema.OperadorDatos.MsgError), MsgBoxStyle.Critical, "Error")
      Else
        If Not mSistema.SeguridadWindows AndAlso mSistema.Usuario.Usuari_CambiarContrasena Then
          Dim f As New FrmCambiarContrasena
          f.Usuario = mSistema.Usuario
          f.ShowDialog()
        End If

        MsgBox("Todas las pruebas satisfactorias", MsgBoxStyle.Information, "Información")
      End If
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
    End Try
  End Sub

  Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
    Try
      mapear_datos()
      Me.DialogResult = Windows.Forms.DialogResult.OK
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
    End Try
  End Sub

  Private Sub btnexaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexaminar.Click
    With Me.OpenFileDialog1
      .Multiselect = False
      .FileName = ""
      .Filter = "Ejecutable compatible (*.exe)|*.exe|Libreria compatible (*.dll)|*.dll|Todos los archivos (*.*)|*.*"

      If .ShowDialog = Windows.Forms.DialogResult.OK Then
        Me.txtarchivoensamblado.Text = .FileNames(0)
      End If
    End With
  End Sub

  Private Sub FrmSistemas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  
  End Sub

  Private Sub chkguardarcontrasena_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkguardarcontrasena.CheckedChanged
    Me.chkcargaraliniciar.Enabled = Me.chkguardarcontrasena.Checked
  End Sub

  Dim _cargolistasql As Boolean = False
  Private Sub cboservidor_AbrioCombo(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboservidor.AbrioCombo
    If Me.cboproveedor.ComboBoxStd1.SelectedIndex = 0 And Not _cargolistasql Then 'sql 

      Dim _complete As New AutoCompleteStringCollection
      Dim x As Sql.SqlDataSourceEnumerator = Sql.SqlDataSourceEnumerator.Instance
      For Each _dr As DataRow In x.GetDataSources.Rows
        Dim _servidor As String
        If TypeOf _dr(1) Is DBNull Then
          _servidor = String.Format("{0}", _dr(0).trim)
        Else
          _servidor = String.Format("{0}{1}{2}", _dr(0).trim, "\", _dr(1).trim)
        End If
        _complete.Add(_servidor)
        Me.cboservidor.ComboBoxStd1.Items.Clear()
        Me.cboservidor.ComboBoxStd1.Items.Add(_servidor)
      Next

      Me.cboservidor.ComboBoxStd1.AutoCompleteCustomSource = _complete
      _cargolistasql = True
    End If

    If Not Me.cboproveedor.ComboBoxStd1.SelectedIndex = 0 And _cargolistasql Then
      Me.cboservidor.ComboBoxStd1.Items.Clear()
      Me.cboservidor.ComboBoxStd1.AutoCompleteCustomSource = Nothing
      _cargolistasql = False
    End If
  End Sub

  Private Sub cboproveedor_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboproveedor.CambioItem
    
  End Sub

  Private Sub cboproveedor_Load(sender As System.Object, e As System.EventArgs) Handles cboproveedor.Load

  End Sub

  Private Sub chkSeguridadIntegrada_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSeguridadIntegrada.CheckedChanged
    Me.txtnombreusuariobd.Enabled = Not Me.chkSeguridadIntegrada.Checked
    Me.txtcontrasenabd.Enabled = Not Me.chkSeguridadIntegrada.Checked
  End Sub

  Private Sub ButtonStd1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonStd1.Click
    If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
      txtDirectorioReplicacion.Text = FolderBrowserDialog1.SelectedPath
    End If
  End Sub

  Private Sub chkSeguridadWindows_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeguridadWindows.CheckedChanged
    Me.flowUserPassword.Enabled = Not Me.chkSeguridadWindows.Checked
  End Sub
End Class