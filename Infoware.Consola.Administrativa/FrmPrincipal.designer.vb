<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
  Inherits Infoware.Consola.Base.FrmPrincipal

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.btnsistemas = New System.Windows.Forms.ToolStripButton
    Me.btnexplorador = New System.Windows.Forms.ToolStripButton
    Me.btnfavoritos = New System.Windows.Forms.ToolStripButton
    Me.btnreportes = New System.Windows.Forms.ToolStripButton
    Me.tmrFullScreen = New System.Windows.Forms.Timer(Me.components)
    Me.tmr_activarfullscreen = New System.Windows.Forms.Timer(Me.components)
    Me.tmrActivar = New System.Windows.Forms.Timer(Me.components)
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'DockPanel1
    '
    Me.DockPanel1.Location = New System.Drawing.Point(0, 84)
    Me.DockPanel1.Size = New System.Drawing.Size(737, 346)
    '
    'pnlhidemenu
    '
    Me.pnlhidemenu.Location = New System.Drawing.Point(0, 49)
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnsistemas, Me.btnexplorador, Me.btnfavoritos, Me.btnreportes})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 59)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(737, 25)
    Me.ToolStrip1.TabIndex = 9
    '
    'btnsistemas
    '
    Me.btnsistemas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnsistemas.Image = My.Resources.Resources.db.ToBitmap
    Me.btnsistemas.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnsistemas.Name = "btnsistemas"
    Me.btnsistemas.Size = New System.Drawing.Size(23, 22)
    Me.btnsistemas.Text = "Sistemas registrados"
    '
    'btnexplorador
    '
    Me.btnexplorador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnexplorador.Image = My.Resources.Resources.table.ToBitmap
    Me.btnexplorador.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnexplorador.Name = "btnexplorador"
    Me.btnexplorador.Size = New System.Drawing.Size(23, 22)
    Me.btnexplorador.Text = "Explorador de sistemas"
    '
    'btnfavoritos
    '
    Me.btnfavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnfavoritos.Image = My.Resources.Resources.favorites.ToBitmap
    Me.btnfavoritos.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnfavoritos.Name = "btnfavoritos"
    Me.btnfavoritos.Size = New System.Drawing.Size(23, 22)
    Me.btnfavoritos.Text = "Favoritos"
    '
    'btnreportes
    '
    Me.btnreportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnreportes.Image = My.Resources.Resources.print.ToBitmap
    Me.btnreportes.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnreportes.Name = "btnreportes"
    Me.btnreportes.Size = New System.Drawing.Size(23, 22)
    Me.btnreportes.Text = "Reportes"
    '
    'tmrFullScreen
    '
    Me.tmrFullScreen.Interval = 1000
    '
    'tmr_activarfullscreen
    '
    Me.tmr_activarfullscreen.Interval = 1000
    '
    'tmrActivar
    '
    Me.tmrActivar.Enabled = True
    Me.tmrActivar.Interval = 10000
    '
    'FrmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(737, 452)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Location = New System.Drawing.Point(0, 0)
    Me.Name = "FrmPrincipal"
    Me.Text = "."
    Me.Controls.SetChildIndex(Me.pnlhidemenu, 0)
    Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
    Me.Controls.SetChildIndex(Me.DockPanel1, 0)
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnsistemas As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnexplorador As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnfavoritos As System.Windows.Forms.ToolStripButton
  Friend WithEvents tmrFullScreen As System.Windows.Forms.Timer
  Friend WithEvents tmr_activarfullscreen As System.Windows.Forms.Timer
  Friend WithEvents btnreportes As System.Windows.Forms.ToolStripButton
  Friend WithEvents tmrActivar As System.Windows.Forms.Timer

End Class
