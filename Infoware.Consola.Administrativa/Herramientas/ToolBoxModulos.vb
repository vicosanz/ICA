Imports Infoware.Consola.Base
Imports Infoware.Docking

Public Class ToolBoxModulos
  Private mSistemas As New SistemaList

  Public ReadOnly Property SistemaActual() As Sistema
    Get
      If Me.treeView1.SelectedNode Is Nothing Then
        Return Nothing
      End If
      Dim _nodo As TreeNode = Me.treeView1.SelectedNode

      While _nodo.Parent IsNot Nothing
        _nodo = _nodo.Parent
      End While
      Return _nodo.Tag
    End Get
  End Property

  Public Sub AgregarSistema(ByVal _Sistema As Sistema)
    Dim _existe As Boolean = False
    For Each _nodo As TreeNode In Me.treeView1.Nodes
      'If CType(_nodo.Tag, Sistema).NombrePublico = _Sistema.NombrePublico Then
      If _nodo.Tag Is _Sistema Then
        Me.treeView1.SelectedNode = _nodo
        _existe = True
      End If
    Next

    If Not _existe Then
      Dim _node As New TreeNode
      _node.Text = _Sistema.NombrePublico
      _node.Tag = _Sistema
      _node.ImageIndex = 1
      _node.SelectedImageIndex = 1

      Me.treeView1.Nodes.Add(_node)
      Me.treeView1.SelectedNode = _node
      mSistemas.Add(_Sistema)
      If _Sistema.Probarconexion Then
        _node.ImageIndex = 0
        _node.SelectedImageIndex = 0
        Dim _primeraopcion As TreeNode = Nothing
        Dim _grupoopciones As List(Of GrupoOpcion) = _Sistema.SistemaObjeto.CargarListaGrupoOpciones(_Sistema)
        For Each _grupoopcion As GrupoOpcion In _grupoopciones
          Dim _nodogrupo As New TreeNode
          _nodogrupo.Text = _grupoopcion.GrupoOpcion.Pardet_Descripcion
          Try
            If _grupoopcion.GrupoOpcion.Pardet_Imagen Is Nothing Then
              Me.ImageList1.Images.Add(Me.ImageList1.Images.Count.ToString, My.Resources.empty)
            Else
              Me.ImageList1.Images.Add(Me.ImageList1.Images.Count.ToString, _grupoopcion.GrupoOpcion.Pardet_Imagen)
            End If
          Catch ex As Exception
            Me.ImageList1.Images.Add(Me.ImageList1.Images.Count.ToString, My.Resources.empty)
          End Try
          _nodogrupo.Tag = _grupoopcion
          _nodogrupo.ImageIndex = Me.ImageList1.Images.Count - 1
          _nodogrupo.SelectedImageIndex = Me.ImageList1.Images.Count - 1

          For Each _opcion As Opcion In _grupoopcion.Opciones
            Dim _nodoopcion As New TreeNode
            If Not String.IsNullOrEmpty(_opcion.DescripcionAlternativa) Then
              _nodoopcion.Text = _opcion.DescripcionAlternativa
            Else
              _nodoopcion.Text = _opcion.Restriccion.PardetOpcionString
            End If
            If _opcion.Restriccion.PardetOpcion.Pardet_Imagen Is Nothing Then
              Me.ImageList1.Images.Add(Me.ImageList1.Images.Count.ToString, My.Resources.empty)
            Else
              Try
                Me.ImageList1.Images.Add(Me.ImageList1.Images.Count.ToString, _opcion.Restriccion.PardetOpcion.Pardet_Imagen)
              Catch ex As Exception
                Me.ImageList1.Images.Add(Me.ImageList1.Images.Count.ToString, My.Resources.empty)
              End Try
            End If
            _nodoopcion.Tag = _opcion
            _nodoopcion.ImageIndex = Me.ImageList1.Images.Count - 1
            _nodoopcion.SelectedImageIndex = Me.ImageList1.Images.Count - 1

            If _primeraopcion Is Nothing Then
              _primeraopcion = _nodoopcion
            End If
            _nodogrupo.Nodes.Add(_nodoopcion)
          Next

          If _nodogrupo.Nodes.Count > 0 Then
            _node.Nodes.Add(_nodogrupo)
            _node.ExpandAll()
          End If
        Next

        If _Sistema.Cargaraliniciar Then
          Me.treeView1.SelectedNode = _primeraopcion
          EjecutarOpcion()
        End If

        AddHandler _Sistema.OperadorDatos.OperadorDatosError, AddressOf CapturarError
      Else
        MsgBox(_Sistema.MensajeError, MsgBoxStyle.Critical, "Error")
      End If
    End If
  End Sub


  Sub EjecutarOpcion()
    If TypeOf Me.treeView1.SelectedNode.Tag Is Opcion Then
      Dim _opcion As Opcion = Me.treeView1.SelectedNode.Tag

      Dim _existe As Boolean = False

      If (Me.DockPanel.DocumentStyle = DocumentStyle.SystemMdi) Then
        For Each forma As Form In MdiChildren
          If forma.Tag IsNot Nothing AndAlso TypeOf forma.Tag Is Opcion Then
            If forma.Tag Is _opcion Then
              _existe = True
            End If
          End If
        Next
      Else
        For index As Integer = Me.DockPanel.Contents.Count - 1 To 0 Step -1
          If TypeOf Me.DockPanel.Contents(index) Is IDockContent Then
            If CType(Me.DockPanel.Contents(index), Form).Tag Is _opcion Then
              _existe = True
              Me.DockPanel.Contents(index).DockHandler.Show()
            End If
          End If
        Next
      End If

      If Not _existe OrElse _opcion.Restriccion.PardetOpcion.Pardet_DatoInt1 = 1 Then
        Dim f As Infoware.Docking.DockContent
        f = _opcion.CargarOpcion(Me.treeView1.SelectedNode.Parent.Parent.Tag, _opcion.Restriccion)
        If f IsNot Nothing Then
          f.Tag = _opcion
          f.HideOnClose = False
          f.Show(Me.DockPanel, Docking.DockState.Document)
          If f.FullScreen Then
            RaiseEvent FullScreenOpcion(Me, Nothing)
          End If
        End If
      End If
    End If
  End Sub

  Public Event FullScreenOpcion As EventHandler
  Public Event Desconetarsistema As EventHandler

  Private Sub btndesconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndesconectar.Click
    RaiseEvent Desconetarsistema(Me, Nothing)
  End Sub

  Public Sub CerrarSistema(ByVal _Sistema As Sistema)
    DockPanel.SuspendLayout(True)
    For Each _nodo As TreeNode In Me.treeView1.Nodes
      If _nodo.Tag Is _Sistema Then
        'buscar todas las opciones y cerrar opciones
        For Each _nodogrp As TreeNode In _nodo.Nodes
          For Each _nodoopc As TreeNode In _nodogrp.Nodes
            For t = Me.DockPanel.Contents.Count - 1 To 0 Step -1
              If CType(DockPanel.Contents(t), DockContent).Tag Is _nodoopc.Tag Then
                CType(DockPanel.Contents(t), DockContent).DockHandler.Close()
              End If
            Next
          Next
        Next

        RemoveHandler _Sistema.OperadorDatos.OperadorDatosError, AddressOf CapturarError
        Me.treeView1.Nodes.Remove(_nodo)
      End If
    Next
    DockPanel.ResumeLayout(True, True)
  End Sub

  Public Event MensajeError As EventHandler

  Public Sub CapturarError(ByVal sender As Object, ByVal e As EventArgs)
    RaiseEvent MensajeError(sender, e)
  End Sub

  Private Sub treeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
    EjecutarOpcion()
  End Sub

  Private Sub treeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeView1.DoubleClick
    EjecutarOpcion()
  End Sub

  Public Event CambioFavoritos As EventHandler

  Private Sub btnfavoritos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfavoritos.Click
   
  End Sub

  Private Sub AgregarAFavoritosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAFavoritosToolStripMenuItem.Click
    If Me.treeView1.SelectedNode Is Nothing Then
      Exit Sub
    End If
    If TypeOf Me.treeView1.SelectedNode.Tag Is Opcion Then
      Dim _opcion As Opcion = Me.treeView1.SelectedNode.Tag

      _opcion.Restriccion.Restri_Favorito = True
      _opcion.Restriccion.Guardar()
      RaiseEvent CambioFavoritos(Me, Nothing)
    End If
  End Sub

  Private Sub QuitarDeFavoritosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarDeFavoritosToolStripMenuItem.Click
    If Me.treeView1.SelectedNode Is Nothing Then
      Exit Sub
    End If
    If TypeOf Me.treeView1.SelectedNode.Tag Is Opcion Then
      Dim _opcion As Opcion = Me.treeView1.SelectedNode.Tag

      _opcion.Restriccion.Restri_Favorito = False
      _opcion.Restriccion.Guardar()
      RaiseEvent CambioFavoritos(Me, Nothing)
    End If
  End Sub
End Class
