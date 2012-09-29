<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolBoxFavoritos
  Inherits Infoware.Docking.DockContent

  'UserControl reemplaza a Dispose para limpiar la lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolBoxFavoritos))
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnquitarfavoritos = New System.Windows.Forms.ToolStripButton
    Me.treeView1 = New System.Windows.Forms.TreeView
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStrip1
    '
    Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnquitarfavoritos})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.ToolStrip1.Size = New System.Drawing.Size(226, 25)
    Me.ToolStrip1.TabIndex = 0
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnquitarfavoritos
    '
    Me.btnquitarfavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnquitarfavoritos.Image = My.Resources.Resources.delete.ToBitmap
    Me.btnquitarfavoritos.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnquitarfavoritos.Name = "btnquitarfavoritos"
    Me.btnquitarfavoritos.Size = New System.Drawing.Size(23, 22)
    Me.btnquitarfavoritos.Text = "Quitar de favoritos"
    '
    'treeView1
    '
    Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.treeView1.ImageIndex = 0
    Me.treeView1.ImageList = Me.ImageList1
    Me.treeView1.Indent = 19
    Me.treeView1.Location = New System.Drawing.Point(0, 25)
    Me.treeView1.Name = "treeView1"
    Me.treeView1.SelectedImageIndex = 0
    Me.treeView1.ShowLines = False
    Me.treeView1.Size = New System.Drawing.Size(226, 399)
    Me.treeView1.TabIndex = 1
    '
    'ImageList1
    '
    Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    Me.ImageList1.Images.SetKeyName(0, "db16.ico")
    Me.ImageList1.Images.SetKeyName(1, "db16_d.ico")
    '
    'ToolBoxFavoritos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(226, 424)
    Me.Controls.Add(Me.treeView1)
    Me.Controls.Add(Me.ToolStrip1)
    Me.DockAreas = CType(((Infoware.Docking.DockAreas.Float Or Infoware.Docking.DockAreas.DockLeft) _
                Or Infoware.Docking.DockAreas.DockRight), Infoware.Docking.DockAreas)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
    Me.HideOnClose = True
    Me.Name = "ToolBoxFavoritos"
    Me.Text = "Favoritos"
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Private WithEvents treeView1 As System.Windows.Forms.TreeView
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents btnquitarfavoritos As System.Windows.Forms.ToolStripButton

End Class
