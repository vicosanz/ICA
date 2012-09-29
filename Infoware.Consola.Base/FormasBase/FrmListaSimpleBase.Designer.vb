<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaSimpleBase
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaSimpleBase))
    Me.pnlcuerpo = New System.Windows.Forms.Panel()
    Me.pnldatos = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.HeaderStrip1 = New Infoware.Docking.HeaderStrip()
    Me.ToolStriptitulo = New System.Windows.Forms.ToolStripLabel()
    Me.btnsalir = New Infoware.Controles.Base.ButtonStd()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.btnexportar = New System.Windows.Forms.ToolStripButton()
    Me.btnimprimir = New System.Windows.Forms.ToolStripButton()
    Me.btncorreo = New System.Windows.Forms.ToolStripButton()
    Me.btnword = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
    Me.btnenviomails = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButtonAyuda = New System.Windows.Forms.ToolStripButton()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.CorreoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.WordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
    Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AyudaDinamicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
    Me.pnlcuerpo.SuspendLayout()
    Me.pnldatos.SuspendLayout()
    Me.HeaderStrip1.SuspendLayout()
    Me.ToolStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.BackColor = System.Drawing.SystemColors.Window
    Me.pnlcuerpo.Controls.Add(Me.pnldatos)
    Me.pnlcuerpo.Controls.Add(Me.Panel2)
    Me.pnlcuerpo.Controls.Add(Me.Panel1)
    Me.pnlcuerpo.Controls.Add(Me.HeaderStrip1)
    Me.pnlcuerpo.Controls.Add(Me.btnsalir)
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 49)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(590, 515)
    Me.pnlcuerpo.TabIndex = 0
    '
    'pnldatos
    '
    Me.pnldatos.Controls.Add(Me.TabControl1)
    Me.pnldatos.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnldatos.Location = New System.Drawing.Point(0, 104)
    Me.pnldatos.Name = "pnldatos"
    Me.pnldatos.Size = New System.Drawing.Size(590, 411)
    Me.pnldatos.TabIndex = 5
    '
    'TabControl1
    '
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(590, 411)
    Me.TabControl1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 76)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(590, 28)
    Me.Panel2.TabIndex = 3
    Me.Panel2.Visible = False
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 25)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Panel1.Size = New System.Drawing.Size(590, 51)
    Me.Panel1.TabIndex = 1
    Me.Panel1.Visible = False
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
    Me.HeaderStrip1.Size = New System.Drawing.Size(590, 25)
    Me.HeaderStrip1.TabIndex = 0
    Me.HeaderStrip1.Text = "HeaderStrip1"
    '
    'ToolStriptitulo
    '
    Me.ToolStriptitulo.Name = "ToolStriptitulo"
    Me.ToolStriptitulo.Size = New System.Drawing.Size(73, 22)
    Me.ToolStriptitulo.Text = "Lista de "
    '
    'btnsalir
    '
    Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnsalir.Location = New System.Drawing.Point(503, 484)
    Me.btnsalir.Name = "btnsalir"
    Me.btnsalir.Size = New System.Drawing.Size(75, 23)
    Me.btnsalir.TabIndex = 4
    Me.btnsalir.TabStop = False
    Me.btnsalir.Text = "Salir"
    Me.btnsalir.UseVisualStyleBackColor = True
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnexportar, Me.btnimprimir, Me.btncorreo, Me.btnword, Me.ToolStripSeparator2, Me.ToolStripProgressBar1, Me.btnenviomails, Me.ToolStripButtonAyuda})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(590, 25)
    Me.ToolStrip1.TabIndex = 1
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'btnexportar
    '
    Me.btnexportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
    Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnexportar.MergeIndex = 0
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(23, 22)
    Me.btnexportar.Text = "Exportar a Microsoft Excel"
    '
    'btnimprimir
    '
    Me.btnimprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
    Me.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnimprimir.MergeIndex = 0
    Me.btnimprimir.Name = "btnimprimir"
    Me.btnimprimir.Size = New System.Drawing.Size(23, 22)
    Me.btnimprimir.Text = "Imprimir"
    '
    'btncorreo
    '
    Me.btncorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btncorreo.Image = CType(resources.GetObject("btncorreo.Image"), System.Drawing.Image)
    Me.btncorreo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btncorreo.Name = "btncorreo"
    Me.btncorreo.Size = New System.Drawing.Size(23, 22)
    Me.btncorreo.Text = "Enviar por correo"
    '
    'btnword
    '
    Me.btnword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnword.Image = CType(resources.GetObject("btnword.Image"), System.Drawing.Image)
    Me.btnword.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnword.Name = "btnword"
    Me.btnword.Size = New System.Drawing.Size(23, 22)
    Me.btnword.Text = "Enviar a Microsoft Word"
    Me.btnword.Visible = False
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.MergeIndex = 99
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'ToolStripProgressBar1
    '
    Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
    Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 22)
    Me.ToolStripProgressBar1.Visible = False
    '
    'btnenviomails
    '
    Me.btnenviomails.Image = CType(resources.GetObject("btnenviomails.Image"), System.Drawing.Image)
    Me.btnenviomails.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnenviomails.Name = "btnenviomails"
    Me.btnenviomails.Size = New System.Drawing.Size(216, 22)
    Me.btnenviomails.Text = "No se ha definido envío automático"
    Me.btnenviomails.ToolTipText = "Clic aquí para iniciar el envío manualmente"
    Me.btnenviomails.Visible = False
    '
    'ToolStripButtonAyuda
    '
    Me.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripButtonAyuda.Image = CType(resources.GetObject("ToolStripButtonAyuda.Image"), System.Drawing.Image)
    Me.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
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
    Me.MenuStrip1.Size = New System.Drawing.Size(590, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'ArchivoToolStripMenuItem
    '
    Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem, Me.CorreoToolStripMenuItem1, Me.WordToolStripMenuItem1, Me.ImprimirToolStripMenuItem, Me.ToolStripMenuItem3, Me.CerrarToolStripMenuItem})
    Me.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
    Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
    Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
    Me.ArchivoToolStripMenuItem.Text = "&Archivo"
    '
    'ExportarToolStripMenuItem
    '
    Me.ExportarToolStripMenuItem.Image = CType(resources.GetObject("ExportarToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ExportarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ExportarToolStripMenuItem.MergeIndex = 1
    Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
    Me.ExportarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
    Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
    Me.ExportarToolStripMenuItem.Text = "&Exportar a Excel"
    '
    'CorreoToolStripMenuItem1
    '
    Me.CorreoToolStripMenuItem1.Image = CType(resources.GetObject("CorreoToolStripMenuItem1.Image"), System.Drawing.Image)
    Me.CorreoToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.CorreoToolStripMenuItem1.MergeIndex = 2
    Me.CorreoToolStripMenuItem1.Name = "CorreoToolStripMenuItem1"
    Me.CorreoToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
    Me.CorreoToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
    Me.CorreoToolStripMenuItem1.Text = "En&viar por correo"
    '
    'WordToolStripMenuItem1
    '
    Me.WordToolStripMenuItem1.Image = CType(resources.GetObject("WordToolStripMenuItem1.Image"), System.Drawing.Image)
    Me.WordToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.WordToolStripMenuItem1.MergeIndex = 2
    Me.WordToolStripMenuItem1.Name = "WordToolStripMenuItem1"
    Me.WordToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
    Me.WordToolStripMenuItem1.Text = "Enviar por &Word"
    Me.WordToolStripMenuItem1.Visible = False
    '
    'ImprimirToolStripMenuItem
    '
    Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
    Me.ImprimirToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ImprimirToolStripMenuItem.MergeIndex = 3
    Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
    Me.ImprimirToolStripMenuItem.ShortcutKeyDisplayString = ""
    Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
    Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
    Me.ImprimirToolStripMenuItem.Text = "&Imprimir"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(206, 6)
    '
    'CerrarToolStripMenuItem
    '
    Me.CerrarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove
    Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
    Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
    Me.CerrarToolStripMenuItem.Text = "&Cerrar"
    '
    'EdicionToolStripMenuItem
    '
    Me.EdicionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
    Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
    Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
    Me.EdicionToolStripMenuItem.Text = "&Edición"
    '
    'AyudaToolStripMenuItem
    '
    Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaDinamicaToolStripMenuItem})
    Me.AyudaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
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
    'Timer1
    '
    '
    'Timer2
    '
    Me.Timer2.Interval = 1001
    '
    'FrmListaSimpleBase
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnsalir
    Me.ClientSize = New System.Drawing.Size(590, 564)
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "FrmListaSimpleBase"
    Me.Text = "Lista de "
    Me.pnlcuerpo.ResumeLayout(False)
    Me.pnldatos.ResumeLayout(False)
    Me.HeaderStrip1.ResumeLayout(False)
    Me.HeaderStrip1.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents HeaderStrip1 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStriptitulo As System.Windows.Forms.ToolStripLabel
  Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnimprimir As System.Windows.Forms.ToolStripButton
  Public WithEvents pnlcuerpo As System.Windows.Forms.Panel
  Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnsalir As Infoware.Controles.Base.ButtonStd
  Public WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripButtonAyuda As System.Windows.Forms.ToolStripButton
  Friend WithEvents AyudaDinamicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents WordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents btncorreo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnword As System.Windows.Forms.ToolStripButton
  Friend WithEvents CorreoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
  Public WithEvents Timer1 As System.Windows.Forms.Timer
  Public WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents btnenviomails As System.Windows.Forms.ToolStripButton
  Public WithEvents Timer2 As System.Windows.Forms.Timer
  Friend WithEvents pnldatos As System.Windows.Forms.Panel
  Public WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
