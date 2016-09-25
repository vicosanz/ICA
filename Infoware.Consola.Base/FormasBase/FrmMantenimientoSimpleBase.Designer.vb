<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoSimpleBase
  Inherits FrmFormaBase

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoSimpleBase))
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip()
    Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    Me.pnlcuerpo = New System.Windows.Forms.Panel()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnguardar = New System.Windows.Forms.ToolStripButton()
    Me.btnguardarnuevo = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripButtonAyuda = New System.Windows.Forms.ToolStripButton()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AyudaDinamicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.HeaderStrip1.SuspendLayout()
    Me.pnlcuerpo.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(592, 25)
    Me.HeaderStrip1.TabIndex = 1
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStripLabel1
    '
    Me.ToolStripLabel1.Name = "ToolStripLabel1"
    Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
    Me.ToolStripLabel1.Text = "Tabla"
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 49)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(592, 517)
    Me.pnlcuerpo.TabIndex = 0
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnguardar, Me.btnguardarnuevo, Me.ToolStripSeparator2, Me.ToolStripButtonAyuda})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(592, 25)
    Me.ToolStrip1.TabIndex = 1
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnguardar
    '
    Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
    Me.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardar.MergeIndex = 0
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(117, 22)
    Me.btnguardar.Text = "Guardar cambios"
    '
    'btnguardarnuevo
    '
    Me.btnguardarnuevo.Image = CType(resources.GetObject("btnguardarnuevo.Image"), System.Drawing.Image)
    Me.btnguardarnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnguardarnuevo.MergeIndex = 1
    Me.btnguardarnuevo.Name = "btnguardarnuevo"
    Me.btnguardarnuevo.Size = New System.Drawing.Size(114, 22)
    Me.btnguardarnuevo.Text = "Guardar y nuevo"
    Me.btnguardarnuevo.Visible = False
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator2.MergeIndex = 99
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'ToolStripButtonAyuda
    '
    Me.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripButtonAyuda.Image = CType(resources.GetObject("ToolStripButtonAyuda.Image"), System.Drawing.Image)
    Me.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButtonAyuda.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripButtonAyuda.MergeIndex = 99
    Me.ToolStripButtonAyuda.Name = "ToolStripButtonAyuda"
    Me.ToolStripButtonAyuda.Size = New System.Drawing.Size(23, 22)
    Me.ToolStripButtonAyuda.Text = "Ayuda dinámica"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdicionToolStripMenuItem, Me.AyudaToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
    Me.MenuStrip1.TabIndex = 2
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'ArchivoToolStripMenuItem
    '
    Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarCambiosToolStripMenuItem})
    Me.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
    Me.ArchivoToolStripMenuItem.MergeIndex = 0
    Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
    Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
    Me.ArchivoToolStripMenuItem.Text = "&Archivo"
    '
    'GuardarCambiosToolStripMenuItem
    '
    Me.GuardarCambiosToolStripMenuItem.Image = CType(resources.GetObject("GuardarCambiosToolStripMenuItem.Image"), System.Drawing.Image)
    Me.GuardarCambiosToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.GuardarCambiosToolStripMenuItem.MergeIndex = 1
    Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
    Me.GuardarCambiosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
    Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
    Me.GuardarCambiosToolStripMenuItem.Text = "&Guardar cambios"
    '
    'EdicionToolStripMenuItem
    '
    Me.EdicionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
    Me.EdicionToolStripMenuItem.MergeIndex = 1
    Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
    Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
    Me.EdicionToolStripMenuItem.Text = "&Edición"
    '
    'AyudaToolStripMenuItem
    '
    Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaDinamicaToolStripMenuItem})
    Me.AyudaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.AyudaToolStripMenuItem.MergeIndex = 5
    Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
    Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
    Me.AyudaToolStripMenuItem.Text = "Ay&uda"
    '
    'AyudaDinamicaToolStripMenuItem
    '
    Me.AyudaDinamicaToolStripMenuItem.Image = CType(resources.GetObject("AyudaDinamicaToolStripMenuItem.Image"), System.Drawing.Image)
    Me.AyudaDinamicaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.AyudaDinamicaToolStripMenuItem.MergeIndex = 1
    Me.AyudaDinamicaToolStripMenuItem.Name = "AyudaDinamicaToolStripMenuItem"
    Me.AyudaDinamicaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
    Me.AyudaDinamicaToolStripMenuItem.Text = "&Ayuda dinámica"
    '
    'FrmMantenimientoSimpleBase
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Window
    Me.ClientSize = New System.Drawing.Size(592, 566)
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "FrmMantenimientoSimpleBase"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnguardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents GuardarCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents pnlcuerpo As System.Windows.Forms.Panel
  Public WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AyudaDinamicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripButtonAyuda As System.Windows.Forms.ToolStripButton
  Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btnguardarnuevo As System.Windows.Forms.ToolStripButton
End Class
