Imports Infoware.Consola.Base
Imports System.IO

Public Class ToolBoxSistemas
  Private mCargarArgumentos As Boolean = True
  Private configFile As String = ""

  Private mSistemas As SistemaList = Nothing
  Public Property Sistemas() As SistemaList
    Get
      Return mSistemas
    End Get
    Set(ByVal value As SistemaList)
      mSistemas = value
    End Set
  End Property

  Public ReadOnly Property SistemaSeleccionado() As Sistema
    Get
      If Me.treeView1.SelectedNode Is Nothing Then
        Return Nothing
      Else
        Return Me.treeView1.SelectedNode.Tag
      End If
    End Get
  End Property

  Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
    crearsistema()
  End Sub

  Sub crearsistema(Optional ByVal _ensamblado As String = "")
    Dim f As New FrmSistemas
    f.Sistema = New Sistema
    f.Ensamblado = _ensamblado
    If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
      mSistemas.Add(f.Sistema)

      SistemaList.SerializeList(mSistemas, configFile)

      Dim _node As New TreeNode
      _node.Text = f.Sistema.NombrePublico
      _node.Tag = f.Sistema
      _node.ImageIndex = 1
      _node.SelectedImageIndex = 1
      Me.treeView1.Nodes.Add(_node)
    End If
  End Sub

  Dim mDirectorioRaiz = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, My.Application.Info.Title)
  Dim mDirectorioConfig = System.IO.Path.Combine(mDirectorioRaiz, "Configuracion")

  Private Sub ToolBoxSistemas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    My.Computer.FileSystem.CreateDirectory(mDirectorioRaiz)
    My.Computer.FileSystem.CreateDirectory(mDirectorioConfig)

    configFile = Path.Combine(mDirectorioConfig, "Sistemas.config")
    Dim existe As Boolean = My.Computer.FileSystem.FileExists(configFile)
    Try
      If existe Then
        mSistemas = SistemaList.DeSerializeList(configFile)
      Else
        mSistemas = New SistemaList()
      End If
      If existe AndAlso mSistemas.Count = 0 Then
        Throw New Exception(String.Format("El archivo de configuración {0} está dañado", configFile))
      End If

      If mCargarArgumentos AndAlso My.Application.CommandLineArgs.Count > 0 Then
        For Each _arg As String In My.Application.CommandLineArgs
          Dim _existearg As Boolean = False
          For Each _sistema As Sistema In mSistemas
            If _arg.ToUpper = _sistema.Ensamblado.ToUpper Then
              _existearg = True
              Dim _existen2 As Integer = 0
              For Each _sistema2 As Sistema In mSistemas
                If _arg.ToUpper = _sistema2.Ensamblado.ToUpper Then
                  _existen2 += 1
                End If
              Next

              If _existen2 = 1 Then
                _sistema.CargarAhora = True
              End If
            ElseIf System.IO.Path.GetFileName(_arg).ToUpper = System.IO.Path.GetFileName(_sistema.Ensamblado).ToUpper Then
              If MsgBox(String.Format("Existe una nueva versión del programa {0}, ¿Desea que se actualice automáticamente los parámetros para acceder a este sistema?", System.IO.Path.GetFileName(_arg)), MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                _existearg = True
                For Each _sistema2 As Sistema In mSistemas
                  If System.IO.Path.GetFileName(_arg).ToUpper = System.IO.Path.GetFileName(_sistema2.Ensamblado).ToUpper Then
                    _sistema2.Ensamblado = _arg
                  End If
                Next
              End If
            End If
          Next

          If Not _existearg Then
            crearsistema(_arg)
          End If
        Next

        mCargarArgumentos = False
        Me.treeView1.Nodes.Clear()
        SistemaList.SerializeList(mSistemas, configFile)
      End If

      For Each _sistema As Sistema In mSistemas
        Dim _node As New TreeNode
        _node.Text = _sistema.NombrePublico
        _node.Tag = _sistema
        _node.ImageIndex = 1
        _node.SelectedImageIndex = 1
        Me.treeView1.Nodes.Add(_node)

        If _sistema.Cargaraliniciar Or _sistema.CargarAhora Then
          Me.treeView1.SelectedNode = _node
          EjecutarSistema()
        End If
      Next
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
      End
    End Try
  End Sub

  Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
    If Me.treeView1.SelectedNode Is Nothing Then
      Exit Sub
    End If
    mSistemas.Remove(Me.treeView1.SelectedNode.Tag)
    Me.treeView1.SelectedNode.Remove()
    SistemaList.SerializeList(mSistemas, configFile)
  End Sub

  Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
    modificar()
  End Sub

  Sub modificar()
    If Me.treeView1.SelectedNode Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmSistemas
    f.Sistema = Me.treeView1.SelectedNode.Tag
    If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
      Me.treeView1.SelectedNode.Text = f.Sistema.NombrePublico
      SistemaList.SerializeList(mSistemas, configFile)
    End If
  End Sub

	Function modificarlogin()
		If Me.treeView1.SelectedNode Is Nothing Then
			Return False
		End If
		Dim f As New FrmSistemasLogin
		f.Sistema = Me.treeView1.SelectedNode.Tag
		If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
			Me.treeView1.SelectedNode.Text = f.Sistema.NombrePublico
			SistemaList.SerializeList(mSistemas, configFile)
			Return True
		End If
		Return False
	End Function

	Public Event AbrirSistema As EventHandler

  Private Sub treeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeView1.DoubleClick
    EjecutarSistema()
  End Sub

  Sub EjecutarSistema()
    If Me.treeView1.SelectedNode Is Nothing Then
      Exit Sub
    End If
    Dim _sistema As Sistema = Me.treeView1.SelectedNode.Tag
		If Not _sistema.Probarconexion Then
			If Not modificarlogin() OrElse Not _sistema.Probarconexion Then
				Me.treeView1.SelectedNode.ImageIndex = 1
				Me.treeView1.SelectedNode.SelectedImageIndex = 1

				MsgBox("No se puede iniciar sesión en este sistema", MsgBoxStyle.Critical, "Error")
				Exit Sub
			End If
		End If

		Me.treeView1.SelectedNode.ImageIndex = 0
    Me.treeView1.SelectedNode.SelectedImageIndex = 0

    RaiseEvent AbrirSistema(Me, Nothing)
  End Sub

  Public Sub CerrarSistema(ByVal _Sistema As Sistema)
    For Each _nodo As TreeNode In Me.treeView1.Nodes
      If _nodo.Tag Is _Sistema Then
        If Not _Sistema.GuardarContrasena Then
          _Sistema.ContrasenaString = ""
        End If
        _nodo.ImageIndex = 1
        _nodo.SelectedImageIndex = 1
      End If
    Next
  End Sub

  Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

  End Sub
End Class
