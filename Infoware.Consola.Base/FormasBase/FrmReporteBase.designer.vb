<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteBase
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteBase))
    Me.pnlcuerpo = New System.Windows.Forms.Panel()
    Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip()
    Me.ToolStriptitulo = New System.Windows.Forms.ToolStripLabel()
    Me.btnsalir = New Infoware.Controles.Base.ButtonStd()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnimprimir = New System.Windows.Forms.ToolStripButton()
    Me.btnexportar = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripButtonAyuda = New System.Windows.Forms.ToolStripButton()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
    Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AyudaDinamicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.pnlcuerpo.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.BackColor = System.Drawing.SystemColors.Window
    Me.pnlcuerpo.Controls.Add(Me.CrystalReportViewer1)
    Me.pnlcuerpo.Controls.Add(Me.btnsalir)
    Me.pnlcuerpo.Controls.Add(Me.Panel1)
    Me.pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 49)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(770, 378)
    Me.pnlcuerpo.TabIndex = 0
    '
    'CrystalReportViewer1
    '
    Me.CrystalReportViewer1.ActiveViewIndex = -1
    Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
    Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 91)
    Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
    Me.CrystalReportViewer1.Size = New System.Drawing.Size(770, 287)
    Me.CrystalReportViewer1.TabIndex = 6
    Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    '
    'HeaderStrip1
    '
    Me.HeaderStrip1.AutoSize = False
    Me.HeaderStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
    Me.HeaderStrip1.ForeColor = System.Drawing.Color.White
    Me.HeaderStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.HeaderStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStriptitulo})
    Me.HeaderStrip1.Location = New System.Drawing.Point(0, 0)
    Me.HeaderStrip1.Name = "HeaderStrip1"
    Me.HeaderStrip1.Size = New System.Drawing.Size(770, 25)
    Me.HeaderStrip1.TabIndex = 0
    Me.HeaderStrip1.TabStop = True
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStriptitulo
    '
    Me.ToolStriptitulo.Name = "ToolStriptitulo"
    Me.ToolStriptitulo.Size = New System.Drawing.Size(93, 22)
    Me.ToolStriptitulo.Text = "Reporte de"
    '
    'btnsalir
    '
    Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnsalir.Location = New System.Drawing.Point(683, 347)
    Me.btnsalir.Name = "btnsalir"
    Me.btnsalir.Size = New System.Drawing.Size(75, 23)
    Me.btnsalir.TabIndex = 4
    Me.btnsalir.TabStop = False
    Me.btnsalir.Text = "Salir"
    Me.btnsalir.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 25)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Panel1.Size = New System.Drawing.Size(770, 66)
    Me.Panel1.TabIndex = 5
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnimprimir, Me.btnexportar, Me.ToolStripSeparator2, Me.ToolStripButtonAyuda})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(770, 25)
    Me.ToolStrip1.TabIndex = 0
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnimprimir
    '
    Me.btnimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
    Me.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimir.Name = "btnimprimir"
    Me.btnimprimir.Size = New System.Drawing.Size(23, 22)
    Me.btnimprimir.Text = "Imprimir"
    '
    'btnexportar
    '
    Me.btnexportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
    Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(23, 22)
    Me.btnexportar.Text = "Exportar"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'ToolStripButtonAyuda
    '
    Me.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripButtonAyuda.Image = CType(resources.GetObject("ToolStripButtonAyuda.Image"), System.Drawing.Image)
    Me.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButtonAyuda.Name = "ToolStripButtonAyuda"
    Me.ToolStripButtonAyuda.Size = New System.Drawing.Size(23, 22)
    Me.ToolStripButtonAyuda.Text = "Ayuda dinámica"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EdicionToolStripMenuItem, Me.AyudaToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(770, 24)
    Me.MenuStrip1.TabIndex = 3
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'ArchivoToolStripMenuItem
    '
    Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.ToolStripMenuItem3, Me.CerrarToolStripMenuItem})
    Me.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
    Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
    Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
    Me.ArchivoToolStripMenuItem.Text = "&Archivo"
    '
    'ImprimirToolStripMenuItem
    '
    Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ImprimirToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ImprimirToolStripMenuItem.MergeIndex = 1
    Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
    Me.ImprimirToolStripMenuItem.ShortcutKeyDisplayString = ""
    Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
    Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
    Me.ImprimirToolStripMenuItem.Text = "&Imprimir"
    '
    'ExportarToolStripMenuItem
    '
    Me.ExportarToolStripMenuItem.Image = CType(resources.GetObject("ExportarToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ExportarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ExportarToolStripMenuItem.MergeIndex = 2
    Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
    Me.ExportarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
    Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
    Me.ExportarToolStripMenuItem.Text = "&Exportar a Acrobat PDF"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(232, 6)
    '
    'CerrarToolStripMenuItem
    '
    Me.CerrarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove
    Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
    Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
    Me.CerrarToolStripMenuItem.Text = "&Cerrar"
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
    'FrmReporteBase
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnsalir
    Me.ClientSize = New System.Drawing.Size(770, 427)
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "FrmReporteBase"
    Me.Text = "Reporte de"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStriptitulo As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnimprimir As System.Windows.Forms.ToolStripButton
  Public WithEvents ListBindingSource As System.Windows.Forms.BindingSource
  Public WithEvents pnlcuerpo As System.Windows.Forms.Panel
  Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnsalir As Infoware.Controles.Base.ButtonStd
  Public WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripButtonAyuda As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents AyudaDinamicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Private WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
