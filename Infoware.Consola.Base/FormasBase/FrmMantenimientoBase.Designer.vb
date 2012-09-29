<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoBase
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
    Me.components = New System.ComponentModel.Container
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
    Me.ToolStripNuevoGeneral = New System.Windows.Forms.ToolStripSplitButton
    Me.ToolStripNuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripGuardar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripGuardarcerrar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripGuardarnuevo = New System.Windows.Forms.ToolStripButton
    Me.ToolStripAnular = New System.Windows.Forms.ToolStripButton
    Me.ToolStripRefrescar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparatorImprimir = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripImprimir = New System.Windows.Forms.ToolStripButton
    Me.ToolStripFormato = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparatorMover = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripAnterior = New System.Windows.Forms.ToolStripSplitButton
    Me.IrAlElementoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.IrAlPrimerElementoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSiguiente = New System.Windows.Forms.ToolStripSplitButton
    Me.IrAlElementoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.IrAlÚltimoElementoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripButtonAyuda = New System.Windows.Forms.ToolStripButton
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
    Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItemSepNuevo = New System.Windows.Forms.ToolStripSeparator
    Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.GuardarYCerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.GuardarYNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItemSepEli = New System.Windows.Forms.ToolStripSeparator
    Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
    Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.EdicionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AyudaDinamicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.btnsalir = New Infoware.Controles.Base.ButtonStd
    Me.ToolStrip1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripNuevoGeneral, Me.ToolStripNuevo, Me.ToolStripGuardar, Me.ToolStripGuardarcerrar, Me.ToolStripGuardarnuevo, Me.ToolStripAnular, Me.ToolStripRefrescar, Me.ToolStripSeparatorImprimir, Me.ToolStripImprimir, Me.ToolStripFormato, Me.ToolStripSeparatorMover, Me.ToolStripAnterior, Me.ToolStripSiguiente, Me.ToolStripSeparator2, Me.ToolStripButtonAyuda})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(770, 25)
    Me.ToolStrip1.TabIndex = 1
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'ToolStripNuevoGeneral
    '
    Me.ToolStripNuevoGeneral.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.ToolStripNuevoGeneral.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripNuevoGeneral.MergeAction = System.Windows.Forms.MergeAction.Replace
    Me.ToolStripNuevoGeneral.MergeIndex = 0
    Me.ToolStripNuevoGeneral.Name = "ToolStripNuevoGeneral"
    Me.ToolStripNuevoGeneral.Size = New System.Drawing.Size(70, 22)
    Me.ToolStripNuevoGeneral.Text = "Nuevo"
    Me.ToolStripNuevoGeneral.Visible = False
    '
    'ToolStripNuevo
    '
    Me.ToolStripNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripNuevo.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.ToolStripNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripNuevo.MergeIndex = 0
    Me.ToolStripNuevo.Name = "ToolStripNuevo"
    Me.ToolStripNuevo.Size = New System.Drawing.Size(23, 22)
    Me.ToolStripNuevo.Text = "Nuevo"
    Me.ToolStripNuevo.Visible = False
    '
    'ToolStripGuardar
    '
    Me.ToolStripGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripGuardar.Image = My.Resources.Resources.save.ToBitmap
    Me.ToolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripGuardar.MergeIndex = 1
    Me.ToolStripGuardar.Name = "ToolStripGuardar"
    Me.ToolStripGuardar.Size = New System.Drawing.Size(23, 22)
    Me.ToolStripGuardar.Text = "Guardar"
    Me.ToolStripGuardar.Visible = False
    '
    'ToolStripGuardarcerrar
    '
    Me.ToolStripGuardarcerrar.Image = My.Resources.Resources.save.ToBitmap
    Me.ToolStripGuardarcerrar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripGuardarcerrar.MergeIndex = 1
    Me.ToolStripGuardarcerrar.Name = "ToolStripGuardarcerrar"
    Me.ToolStripGuardarcerrar.Size = New System.Drawing.Size(138, 22)
    Me.ToolStripGuardarcerrar.Text = "Guardar y cerrar <F5>"
    Me.ToolStripGuardarcerrar.Visible = False
    '
    'ToolStripGuardarnuevo
    '
    Me.ToolStripGuardarnuevo.Image = My.Resources.Resources.saveandnew.ToBitmap
    Me.ToolStripGuardarnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripGuardarnuevo.MergeIndex = 1
    Me.ToolStripGuardarnuevo.Name = "ToolStripGuardarnuevo"
    Me.ToolStripGuardarnuevo.Size = New System.Drawing.Size(139, 22)
    Me.ToolStripGuardarnuevo.Text = "Guardar y nuevo <F2>"
    '
    'ToolStripAnular
    '
    Me.ToolStripAnular.Image = My.Resources.Resources.cancel.ToBitmap
    Me.ToolStripAnular.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripAnular.MergeIndex = 2
    Me.ToolStripAnular.Name = "ToolStripAnular"
    Me.ToolStripAnular.Size = New System.Drawing.Size(58, 22)
    Me.ToolStripAnular.Text = "Anular"
    Me.ToolStripAnular.Visible = False
    '
    'ToolStripRefrescar
    '
    Me.ToolStripRefrescar.Image = My.Resources.Resources.Refrescar.ToBitmap
    Me.ToolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripRefrescar.MergeIndex = 2
    Me.ToolStripRefrescar.Name = "ToolStripRefrescar"
    Me.ToolStripRefrescar.Size = New System.Drawing.Size(74, 22)
    Me.ToolStripRefrescar.Text = "Refrescar"
    Me.ToolStripRefrescar.Visible = False
    '
    'ToolStripSeparatorImprimir
    '
    Me.ToolStripSeparatorImprimir.MergeIndex = 3
    Me.ToolStripSeparatorImprimir.Name = "ToolStripSeparatorImprimir"
    Me.ToolStripSeparatorImprimir.Size = New System.Drawing.Size(6, 25)
    Me.ToolStripSeparatorImprimir.Visible = False
    '
    'ToolStripImprimir
    '
    Me.ToolStripImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripImprimir.Image = My.Resources.Resources.print.ToBitmap
    Me.ToolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripImprimir.MergeIndex = 3
    Me.ToolStripImprimir.Name = "ToolStripImprimir"
    Me.ToolStripImprimir.Size = New System.Drawing.Size(23, 22)
    Me.ToolStripImprimir.Text = "Imprimir"
    Me.ToolStripImprimir.Visible = False
    '
    'ToolStripFormato
    '
    Me.ToolStripFormato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripFormato.Image = My.Resources.Resources.Formato.ToBitmap
    Me.ToolStripFormato.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripFormato.MergeIndex = 3
    Me.ToolStripFormato.Name = "ToolStripFormato"
    Me.ToolStripFormato.Size = New System.Drawing.Size(23, 22)
    Me.ToolStripFormato.Text = "Modificar formato"
    Me.ToolStripFormato.Visible = False
    '
    'ToolStripSeparatorMover
    '
    Me.ToolStripSeparatorMover.MergeIndex = 4
    Me.ToolStripSeparatorMover.Name = "ToolStripSeparatorMover"
    Me.ToolStripSeparatorMover.Size = New System.Drawing.Size(6, 25)
    '
    'ToolStripAnterior
    '
    Me.ToolStripAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripAnterior.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IrAlElementoToolStripMenuItem, Me.IrAlPrimerElementoToolStripMenuItem})
    Me.ToolStripAnterior.Image = My.Resources.Resources.arrowfirst
    Me.ToolStripAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripAnterior.MergeIndex = 4
    Me.ToolStripAnterior.Name = "ToolStripAnterior"
    Me.ToolStripAnterior.Size = New System.Drawing.Size(32, 22)
    Me.ToolStripAnterior.Text = "Ir al elemento anterior"
    '
    'IrAlElementoToolStripMenuItem
    '
    Me.IrAlElementoToolStripMenuItem.Image = My.Resources.Resources.arrowfirst
    Me.IrAlElementoToolStripMenuItem.Name = "IrAlElementoToolStripMenuItem"
    Me.IrAlElementoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
    Me.IrAlElementoToolStripMenuItem.Text = "Ir al elemento"
    '
    'IrAlPrimerElementoToolStripMenuItem
    '
    Me.IrAlPrimerElementoToolStripMenuItem.Name = "IrAlPrimerElementoToolStripMenuItem"
    Me.IrAlPrimerElementoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
    Me.IrAlPrimerElementoToolStripMenuItem.Text = "Ir al primer elemento"
    '
    'ToolStripSiguiente
    '
    Me.ToolStripSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripSiguiente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IrAlElementoToolStripMenuItem1, Me.IrAlÚltimoElementoToolStripMenuItem})
    Me.ToolStripSiguiente.Image = My.Resources.Resources.arrowlast
    Me.ToolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripSiguiente.MergeIndex = 4
    Me.ToolStripSiguiente.Name = "ToolStripSiguiente"
    Me.ToolStripSiguiente.Size = New System.Drawing.Size(32, 22)
    Me.ToolStripSiguiente.Text = "Ir al elemento siguiente"
    '
    'IrAlElementoToolStripMenuItem1
    '
    Me.IrAlElementoToolStripMenuItem1.Image = My.Resources.Resources.arrowlast
    Me.IrAlElementoToolStripMenuItem1.Name = "IrAlElementoToolStripMenuItem1"
    Me.IrAlElementoToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
    Me.IrAlElementoToolStripMenuItem1.Text = "Ir al elemento"
    '
    'IrAlÚltimoElementoToolStripMenuItem
    '
    Me.IrAlÚltimoElementoToolStripMenuItem.Name = "IrAlÚltimoElementoToolStripMenuItem"
    Me.IrAlÚltimoElementoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
    Me.IrAlÚltimoElementoToolStripMenuItem.Text = "Ir al último elemento"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.MergeIndex = 999
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
    '
    'ToolStripButtonAyuda
    '
    Me.ToolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ToolStripButtonAyuda.Image = My.Resources.Resources.help.ToBitmap
    Me.ToolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButtonAyuda.MergeIndex = 999
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
    Me.MenuStrip1.TabIndex = 2
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'ArchivoToolStripMenuItem
    '
    Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ToolStripMenuItemSepNuevo, Me.GuardarToolStripMenuItem, Me.GuardarYCerrarToolStripMenuItem, Me.GuardarYNuevoToolStripMenuItem, Me.ToolStripMenuItemSepEli, Me.EliminarToolStripMenuItem, Me.ToolStripMenuItem3, Me.CerrarToolStripMenuItem})
    Me.ArchivoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
    Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
    Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
    Me.ArchivoToolStripMenuItem.Text = "&Archivo"
    '
    'NuevoToolStripMenuItem
    '
    Me.NuevoToolStripMenuItem.Image = My.Resources.Resources.nuevo.ToBitmap
    Me.NuevoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
    Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
    Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
    Me.NuevoToolStripMenuItem.Text = "&Nuevo"
    Me.NuevoToolStripMenuItem.Visible = False
    '
    'ToolStripMenuItemSepNuevo
    '
    Me.ToolStripMenuItemSepNuevo.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripMenuItemSepNuevo.MergeIndex = 1
    Me.ToolStripMenuItemSepNuevo.Name = "ToolStripMenuItemSepNuevo"
    Me.ToolStripMenuItemSepNuevo.Size = New System.Drawing.Size(182, 6)
    Me.ToolStripMenuItemSepNuevo.Visible = False
    '
    'GuardarToolStripMenuItem
    '
    Me.GuardarToolStripMenuItem.Image = My.Resources.Resources.save.ToBitmap
    Me.GuardarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.GuardarToolStripMenuItem.MergeIndex = 2
    Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
    Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
    Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
    Me.GuardarToolStripMenuItem.Text = "&Guardar"
    Me.GuardarToolStripMenuItem.Visible = False
    '
    'GuardarYCerrarToolStripMenuItem
    '
    Me.GuardarYCerrarToolStripMenuItem.Image = My.Resources.Resources.save.ToBitmap
    Me.GuardarYCerrarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.GuardarYCerrarToolStripMenuItem.MergeIndex = 3
    Me.GuardarYCerrarToolStripMenuItem.Name = "GuardarYCerrarToolStripMenuItem"
    Me.GuardarYCerrarToolStripMenuItem.ShortcutKeyDisplayString = ""
    Me.GuardarYCerrarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
    Me.GuardarYCerrarToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
    Me.GuardarYCerrarToolStripMenuItem.Text = "Guardar y &cerrar"
    Me.GuardarYCerrarToolStripMenuItem.Visible = False
    '
    'GuardarYNuevoToolStripMenuItem
    '
    Me.GuardarYNuevoToolStripMenuItem.Image = My.Resources.Resources.saveandnew.ToBitmap
    Me.GuardarYNuevoToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.GuardarYNuevoToolStripMenuItem.MergeIndex = 4
    Me.GuardarYNuevoToolStripMenuItem.Name = "GuardarYNuevoToolStripMenuItem"
    Me.GuardarYNuevoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
    Me.GuardarYNuevoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
    Me.GuardarYNuevoToolStripMenuItem.Text = "G&uardar y nuevo"
    '
    'ToolStripMenuItemSepEli
    '
    Me.ToolStripMenuItemSepEli.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripMenuItemSepEli.MergeIndex = 5
    Me.ToolStripMenuItemSepEli.Name = "ToolStripMenuItemSepEli"
    Me.ToolStripMenuItemSepEli.Size = New System.Drawing.Size(182, 6)
    '
    'EliminarToolStripMenuItem
    '
    Me.EliminarToolStripMenuItem.Image = My.Resources.Resources.eliminar.ToBitmap
    Me.EliminarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.EliminarToolStripMenuItem.MergeIndex = 6
    Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
    Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
    Me.EliminarToolStripMenuItem.Text = "&Eliminar"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.Remove
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(182, 6)
    '
    'CerrarToolStripMenuItem
    '
    Me.CerrarToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Remove
    Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
    Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
    Me.CerrarToolStripMenuItem.Text = "&Cerrar"
    '
    'EdicionToolStripMenuItem
    '
    Me.EdicionToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
    Me.EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
    Me.EdicionToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
    Me.EdicionToolStripMenuItem.Text = "&Edición"
    '
    'AyudaToolStripMenuItem
    '
    Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaDinamicaToolStripMenuItem})
    Me.AyudaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
    Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
    Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
    Me.AyudaToolStripMenuItem.Text = "Ay&uda"
    '
    'AyudaDinamicaToolStripMenuItem
    '
    Me.AyudaDinamicaToolStripMenuItem.Image = My.Resources.Resources.help.ToBitmap
    Me.AyudaDinamicaToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.AyudaDinamicaToolStripMenuItem.MergeIndex = 1
    Me.AyudaDinamicaToolStripMenuItem.Name = "AyudaDinamicaToolStripMenuItem"
    Me.AyudaDinamicaToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
    Me.AyudaDinamicaToolStripMenuItem.Text = "&Ayuda dinámica"
    '
    'BindingSource1
    '
    '
    'btnsalir
    '
    Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnsalir.Location = New System.Drawing.Point(683, 534)
    Me.btnsalir.Name = "btnsalir"
    Me.btnsalir.Size = New System.Drawing.Size(75, 20)
    Me.btnsalir.TabIndex = 3
    Me.btnsalir.TabStop = False
    Me.btnsalir.Text = "Salir"
    Me.btnsalir.UseVisualStyleBackColor = True
    '
    'FrmMantenimientoBase
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Window
    Me.CancelButton = Me.btnsalir
    Me.ClientSize = New System.Drawing.Size(770, 566)
    Me.Controls.Add(Me.btnsalir)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "FrmMantenimientoBase"
    Me.Text = "Mantenimiento"
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolStripGuardarcerrar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripGuardarnuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparatorImprimir As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripAnterior As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents IrAlElementoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents IrAlPrimerElementoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSiguiente As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents IrAlElementoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents IrAlÚltimoElementoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EdicionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSepNuevo As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents GuardarYCerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents GuardarYNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSepEli As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents ToolStripGuardar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripNuevoGeneral As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents ToolStripFormato As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparatorMover As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripImprimir As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripNuevo As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripRefrescar As System.Windows.Forms.ToolStripButton
  Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnsalir As Infoware.Controles.Base.ButtonStd
  Friend WithEvents ToolStripAnular As System.Windows.Forms.ToolStripButton
  Public WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripButtonAyuda As System.Windows.Forms.ToolStripButton
  Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AyudaDinamicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
