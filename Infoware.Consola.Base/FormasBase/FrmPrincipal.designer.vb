<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
  Inherits Infoware.Consola.Base.FrmFormaBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

  Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim DockPanelSkin1 As Infoware.Docking.DockPanelSkin = New Infoware.Docking.DockPanelSkin
    Dim AutoHideStripSkin1 As Infoware.Docking.AutoHideStripSkin = New Infoware.Docking.AutoHideStripSkin
    Dim DockPanelGradient1 As Infoware.Docking.DockPanelGradient = New Infoware.Docking.DockPanelGradient
    Dim TabGradient1 As Infoware.Docking.TabGradient = New Infoware.Docking.TabGradient
    Dim DockPaneStripSkin1 As Infoware.Docking.DockPaneStripSkin = New Infoware.Docking.DockPaneStripSkin
    Dim DockPaneStripGradient1 As Infoware.Docking.DockPaneStripGradient = New Infoware.Docking.DockPaneStripGradient
    Dim TabGradient2 As Infoware.Docking.TabGradient = New Infoware.Docking.TabGradient
    Dim DockPanelGradient2 As Infoware.Docking.DockPanelGradient = New Infoware.Docking.DockPanelGradient
    Dim TabGradient3 As Infoware.Docking.TabGradient = New Infoware.Docking.TabGradient
    Dim DockPaneStripToolWindowGradient1 As Infoware.Docking.DockPaneStripToolWindowGradient = New Infoware.Docking.DockPaneStripToolWindowGradient
    Dim TabGradient4 As Infoware.Docking.TabGradient = New Infoware.Docking.TabGradient
    Dim TabGradient5 As Infoware.Docking.TabGradient = New Infoware.Docking.TabGradient
    Dim DockPanelGradient3 As Infoware.Docking.DockPanelGradient = New Infoware.Docking.DockPanelGradient
    Dim TabGradient6 As Infoware.Docking.TabGradient = New Infoware.Docking.TabGradient
    Dim TabGradient7 As Infoware.Docking.TabGradient = New Infoware.Docking.TabGradient
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
    Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
    Me.DockPanel1 = New Infoware.Docking.DockPanel
    Me.tmr_error = New System.Windows.Forms.Timer(Me.components)
    Me.AyudaButton = New System.Windows.Forms.ToolStripButton
    Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
    Me.MenuStrip = New System.Windows.Forms.MenuStrip
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuNuevo = New System.Windows.Forms.ToolStripMenuItem
    Me.SeparadorNuevo = New System.Windows.Forms.ToolStripSeparator
    Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.menuedicion = New System.Windows.Forms.ToolStripMenuItem
    Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.EstandarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.BarraDeEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
    Me.PantallaCompletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.IrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuAyuda = New System.Windows.Forms.ToolStripMenuItem
    Me.PantallaCompletaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.BarraEstandar = New System.Windows.Forms.ToolStrip
    Me.btnnuevo = New System.Windows.Forms.ToolStripSplitButton
    Me.SeparadorNuevo2 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
    Me.ListViewToolStripButton = New System.Windows.Forms.ToolStripDropDownButton
    Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.LargeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.SmallIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.StatusStrip = New System.Windows.Forms.StatusStrip
    Me.lbl_contectadoa = New System.Windows.Forms.ToolStripStatusLabel
    Me.lblok = New System.Windows.Forms.ToolStripStatusLabel
    Me.lblerror = New System.Windows.Forms.ToolStripStatusLabel
    Me.pnlhidemenu = New System.Windows.Forms.Panel
    Me.MenuStrip.SuspendLayout()
    Me.BarraEstandar.SuspendLayout()
    Me.StatusStrip.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStripStatusLabel
    '
    Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
    Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
    Me.ToolStripStatusLabel.Text = "Status"
    '
    'DockPanel1
    '
    Me.DockPanel1.ActiveAutoHideContent = Nothing
    Me.DockPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DockPanel1.DockBackColor = System.Drawing.SystemColors.AppWorkspace
    Me.DockPanel1.Location = New System.Drawing.Point(0, 59)
    Me.DockPanel1.Name = "DockPanel1"
    Me.DockPanel1.Size = New System.Drawing.Size(737, 371)
    DockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight
    DockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight
    AutoHideStripSkin1.DockStripGradient = DockPanelGradient1
    TabGradient1.EndColor = System.Drawing.SystemColors.Control
    TabGradient1.StartColor = System.Drawing.SystemColors.Control
    TabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark
    AutoHideStripSkin1.TabGradient = TabGradient1
    DockPanelSkin1.AutoHideStripSkin = AutoHideStripSkin1
    TabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight
    TabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight
    TabGradient2.TextColor = System.Drawing.SystemColors.ControlText
    DockPaneStripGradient1.ActiveTabGradient = TabGradient2
    DockPanelGradient2.EndColor = System.Drawing.SystemColors.Control
    DockPanelGradient2.StartColor = System.Drawing.SystemColors.Control
    DockPaneStripGradient1.DockStripGradient = DockPanelGradient2
    TabGradient3.EndColor = System.Drawing.SystemColors.ControlLight
    TabGradient3.StartColor = System.Drawing.SystemColors.ControlLight
    TabGradient3.TextColor = System.Drawing.SystemColors.ControlText
    DockPaneStripGradient1.InactiveTabGradient = TabGradient3
    DockPaneStripSkin1.DocumentGradient = DockPaneStripGradient1
    TabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption
    TabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
    TabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption
    TabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText
    DockPaneStripToolWindowGradient1.ActiveCaptionGradient = TabGradient4
    TabGradient5.EndColor = System.Drawing.SystemColors.Control
    TabGradient5.StartColor = System.Drawing.SystemColors.Control
    TabGradient5.TextColor = System.Drawing.SystemColors.ControlText
    DockPaneStripToolWindowGradient1.ActiveTabGradient = TabGradient5
    DockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight
    DockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight
    DockPaneStripToolWindowGradient1.DockStripGradient = DockPanelGradient3
    TabGradient6.EndColor = System.Drawing.SystemColors.GradientInactiveCaption
    TabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
    TabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption
    TabGradient6.TextColor = System.Drawing.SystemColors.ControlText
    DockPaneStripToolWindowGradient1.InactiveCaptionGradient = TabGradient6
    TabGradient7.EndColor = System.Drawing.Color.Transparent
    TabGradient7.StartColor = System.Drawing.Color.Transparent
    TabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark
    DockPaneStripToolWindowGradient1.InactiveTabGradient = TabGradient7
    DockPaneStripSkin1.ToolWindowGradient = DockPaneStripToolWindowGradient1
    DockPanelSkin1.DockPaneStripSkin = DockPaneStripSkin1
    Me.DockPanel1.Skin = DockPanelSkin1
    Me.DockPanel1.TabIndex = 0
    '
    'tmr_error
    '
    Me.tmr_error.Interval = 60000
    '
    'AyudaButton
    '
    Me.AyudaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.AyudaButton.Image = My.Resources.Resources.ayuda.ToBitmap
    Me.AyudaButton.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.AyudaButton.Name = "AyudaButton"
    Me.AyudaButton.Size = New System.Drawing.Size(23, 22)
    Me.AyudaButton.Text = "Ayuda"
    '
    'ToolStripButton4
    '
    Me.ToolStripButton4.Checked = True
    Me.ToolStripButton4.CheckOnClick = True
    Me.ToolStripButton4.CheckState = System.Windows.Forms.CheckState.Checked
    Me.ToolStripButton4.Image = My.Resources.Resources.cancel.ToBitmap
    Me.ToolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton4.Margin = New System.Windows.Forms.Padding(0)
    Me.ToolStripButton4.Name = "ToolStripButton4"
    Me.ToolStripButton4.Padding = New System.Windows.Forms.Padding(5)
    Me.ToolStripButton4.Size = New System.Drawing.Size(202, 38)
    Me.ToolStripButton4.Text = "General"
    '
    'MenuStrip
    '
    Me.MenuStrip.AllowItemReorder = True
    Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.menuedicion, Me.ViewToolStripMenuItem, Me.IrToolStripMenuItem, Me.MenuAyuda, Me.PantallaCompletaToolStripMenuItem1})
    Me.MenuStrip.Location = New System.Drawing.Point(0, 10)
    Me.MenuStrip.Name = "MenuStrip"
    Me.MenuStrip.Size = New System.Drawing.Size(737, 24)
    Me.MenuStrip.TabIndex = 3
    Me.MenuStrip.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNuevo, Me.SeparadorNuevo, Me.ExitToolStripMenuItem})
    Me.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.FileToolStripMenuItem.MergeIndex = 0
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
    Me.FileToolStripMenuItem.Text = "&Archivo"
    '
    'MenuNuevo
    '
    Me.MenuNuevo.Image = CType(resources.GetObject("MenuNuevo.Image"), System.Drawing.Image)
    Me.MenuNuevo.ImageTransparentColor = System.Drawing.Color.Black
    Me.MenuNuevo.MergeIndex = 0
    Me.MenuNuevo.Name = "MenuNuevo"
    Me.MenuNuevo.Size = New System.Drawing.Size(116, 22)
    Me.MenuNuevo.Text = "&Nuevo"
    Me.MenuNuevo.ToolTipText = "Crea un nuevo elemento del sistema"
    Me.MenuNuevo.Visible = False
    '
    'SeparadorNuevo
    '
    Me.SeparadorNuevo.MergeIndex = 999
    Me.SeparadorNuevo.Name = "SeparadorNuevo"
    Me.SeparadorNuevo.Size = New System.Drawing.Size(113, 6)
    Me.SeparadorNuevo.Visible = False
    '
    'ExitToolStripMenuItem
    '
    Me.ExitToolStripMenuItem.MergeIndex = 999
    Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
    Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
    Me.ExitToolStripMenuItem.Text = "&Salir"
    '
    'menuedicion
    '
    Me.menuedicion.MergeIndex = 1
    Me.menuedicion.Name = "menuedicion"
    Me.menuedicion.Size = New System.Drawing.Size(52, 20)
    Me.menuedicion.Text = "&Edición"
    '
    'ViewToolStripMenuItem
    '
    Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarToolStripMenuItem, Me.BarraDeEstadoToolStripMenuItem, Me.ToolStripMenuItem3, Me.PantallaCompletaToolStripMenuItem})
    Me.ViewToolStripMenuItem.MergeIndex = 2
    Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
    Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
    Me.ViewToolStripMenuItem.Text = "&Ver"
    '
    'StatusBarToolStripMenuItem
    '
    Me.StatusBarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstandarToolStripMenuItem})
    Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
    Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
    Me.StatusBarToolStripMenuItem.Text = "&Barras de herramientas"
    '
    'EstandarToolStripMenuItem
    '
    Me.EstandarToolStripMenuItem.Checked = True
    Me.EstandarToolStripMenuItem.CheckOnClick = True
    Me.EstandarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
    Me.EstandarToolStripMenuItem.Name = "EstandarToolStripMenuItem"
    Me.EstandarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
    Me.EstandarToolStripMenuItem.Text = "Estándar"
    '
    'BarraDeEstadoToolStripMenuItem
    '
    Me.BarraDeEstadoToolStripMenuItem.Checked = True
    Me.BarraDeEstadoToolStripMenuItem.CheckOnClick = True
    Me.BarraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
    Me.BarraDeEstadoToolStripMenuItem.Name = "BarraDeEstadoToolStripMenuItem"
    Me.BarraDeEstadoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
    Me.BarraDeEstadoToolStripMenuItem.Text = "Barra de es&tado"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(194, 6)
    '
    'PantallaCompletaToolStripMenuItem
    '
    Me.PantallaCompletaToolStripMenuItem.CheckOnClick = True
    Me.PantallaCompletaToolStripMenuItem.Name = "PantallaCompletaToolStripMenuItem"
    Me.PantallaCompletaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
    Me.PantallaCompletaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
    Me.PantallaCompletaToolStripMenuItem.Text = "Pantalla completa"
    '
    'IrToolStripMenuItem
    '
    Me.IrToolStripMenuItem.MergeIndex = 4
    Me.IrToolStripMenuItem.Name = "IrToolStripMenuItem"
    Me.IrToolStripMenuItem.Size = New System.Drawing.Size(27, 20)
    Me.IrToolStripMenuItem.Text = "&Ir"
    Me.IrToolStripMenuItem.Visible = False
    '
    'MenuAyuda
    '
    Me.MenuAyuda.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.MenuAyuda.MergeIndex = 999
    Me.MenuAyuda.Name = "MenuAyuda"
    Me.MenuAyuda.Size = New System.Drawing.Size(24, 20)
    Me.MenuAyuda.Text = "&?"
    '
    'PantallaCompletaToolStripMenuItem1
    '
    Me.PantallaCompletaToolStripMenuItem1.Checked = True
    Me.PantallaCompletaToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
    Me.PantallaCompletaToolStripMenuItem1.Image = My.Resources.Resources.fullscreen.ToBitmap
    Me.PantallaCompletaToolStripMenuItem1.Name = "PantallaCompletaToolStripMenuItem1"
    Me.PantallaCompletaToolStripMenuItem1.Size = New System.Drawing.Size(119, 20)
    Me.PantallaCompletaToolStripMenuItem1.Text = "Pantalla completa"
    Me.PantallaCompletaToolStripMenuItem1.Visible = False
    '
    'BarraEstandar
    '
    Me.BarraEstandar.AllowItemReorder = True
    Me.BarraEstandar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevo, Me.SeparadorNuevo2, Me.ToolStripSeparator8, Me.ListViewToolStripButton})
    Me.BarraEstandar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
    Me.BarraEstandar.Location = New System.Drawing.Point(0, 34)
    Me.BarraEstandar.Name = "BarraEstandar"
    Me.BarraEstandar.Size = New System.Drawing.Size(737, 25)
    Me.BarraEstandar.TabIndex = 5
    Me.BarraEstandar.Text = "ToolStrip1"
    '
    'btnnuevo
    '
    Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Black
    Me.btnnuevo.MergeAction = System.Windows.Forms.MergeAction.Replace
    Me.btnnuevo.MergeIndex = 0
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(54, 22)
    Me.btnnuevo.Text = "&Nuevo"
    Me.btnnuevo.Visible = False
    '
    'SeparadorNuevo2
    '
    Me.SeparadorNuevo2.MergeIndex = 0
    Me.SeparadorNuevo2.Name = "SeparadorNuevo2"
    Me.SeparadorNuevo2.Size = New System.Drawing.Size(6, 25)
    Me.SeparadorNuevo2.Visible = False
    '
    'ToolStripSeparator8
    '
    Me.ToolStripSeparator8.MergeIndex = 2
    Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
    Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
    Me.ToolStripSeparator8.Visible = False
    '
    'ListViewToolStripButton
    '
    Me.ListViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.ListViewToolStripButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.LargeIconsToolStripMenuItem, Me.SmallIconsToolStripMenuItem})
    Me.ListViewToolStripButton.Image = CType(resources.GetObject("ListViewToolStripButton.Image"), System.Drawing.Image)
    Me.ListViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
    Me.ListViewToolStripButton.MergeIndex = 2
    Me.ListViewToolStripButton.Name = "ListViewToolStripButton"
    Me.ListViewToolStripButton.Size = New System.Drawing.Size(29, 22)
    Me.ListViewToolStripButton.Text = "Views"
    Me.ListViewToolStripButton.Visible = False
    '
    'ListToolStripMenuItem
    '
    Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
    Me.ListToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
    Me.ListToolStripMenuItem.Text = "Lista"
    '
    'DetailsToolStripMenuItem
    '
    Me.DetailsToolStripMenuItem.Checked = True
    Me.DetailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
    Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
    Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
    Me.DetailsToolStripMenuItem.Text = "Detalles"
    '
    'LargeIconsToolStripMenuItem
    '
    Me.LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
    Me.LargeIconsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
    Me.LargeIconsToolStripMenuItem.Text = "Iconos grandes"
    '
    'SmallIconsToolStripMenuItem
    '
    Me.SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
    Me.SmallIconsToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
    Me.SmallIconsToolStripMenuItem.Text = "Iconos pequeños"
    '
    'StatusStrip
    '
    Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_contectadoa, Me.lblok, Me.lblerror})
    Me.StatusStrip.Location = New System.Drawing.Point(0, 430)
    Me.StatusStrip.Name = "StatusStrip"
    Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
    Me.StatusStrip.Size = New System.Drawing.Size(737, 22)
    Me.StatusStrip.TabIndex = 7
    Me.StatusStrip.Text = "StatusStrip"
    '
    'lbl_contectadoa
    '
    Me.lbl_contectadoa.Image = My.Resources.Resources.connect.ToBitmap
    Me.lbl_contectadoa.Name = "lbl_contectadoa"
    Me.lbl_contectadoa.Size = New System.Drawing.Size(88, 17)
    Me.lbl_contectadoa.Text = "Conectado a:"
    '
    'lblok
    '
    Me.lblok.Image = My.Resources.Resources.ok.ToBitmap
    Me.lblok.Name = "lblok"
    Me.lblok.Size = New System.Drawing.Size(45, 17)
    Me.lblok.Text = "Listo"
    '
    'lblerror
    '
    Me.lblerror.Image = My.Resources.Resources.cancel.ToBitmap
    Me.lblerror.Name = "lblerror"
    Me.lblerror.Size = New System.Drawing.Size(47, 17)
    Me.lblerror.Text = "Error"
    Me.lblerror.Visible = False
    '
    'pnlhidemenu
    '
    Me.pnlhidemenu.BackColor = System.Drawing.Color.Transparent
    Me.pnlhidemenu.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlhidemenu.Location = New System.Drawing.Point(0, 0)
    Me.pnlhidemenu.Name = "pnlhidemenu"
    Me.pnlhidemenu.Size = New System.Drawing.Size(737, 10)
    Me.pnlhidemenu.TabIndex = 9
    Me.pnlhidemenu.Visible = False
    '
    'FrmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(737, 452)
    Me.Controls.Add(Me.DockPanel1)
    Me.Controls.Add(Me.StatusStrip)
    Me.Controls.Add(Me.BarraEstandar)
    Me.Controls.Add(Me.MenuStrip)
    Me.Controls.Add(Me.pnlhidemenu)
    Me.DoubleBuffered = True
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.MenuStrip
    Me.Name = "FrmPrincipal"
    Me.Text = "Infoware.Consola.Administrativa"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.MenuStrip.ResumeLayout(False)
    Me.MenuStrip.PerformLayout()
    Me.BarraEstandar.ResumeLayout(False)
    Me.BarraEstandar.PerformLayout()
    Me.StatusStrip.ResumeLayout(False)
    Me.StatusStrip.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents AyudaButton As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
  Friend WithEvents tmr_error As System.Windows.Forms.Timer
  Public WithEvents DockPanel1 As Infoware.Docking.DockPanel
  Public WithEvents MenuStrip As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents MenuNuevo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents SeparadorNuevo As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents menuedicion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EstandarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents BarraDeEstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents PantallaCompletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents IrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents MenuAyuda As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents btnnuevo As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents SeparadorNuevo2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ListViewToolStripButton As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LargeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents SmallIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
  Public WithEvents lbl_contectadoa As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents lblok As System.Windows.Forms.ToolStripStatusLabel
  Public WithEvents lblerror As System.Windows.Forms.ToolStripStatusLabel
  Public WithEvents BarraEstandar As System.Windows.Forms.ToolStrip
  Friend WithEvents PantallaCompletaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Public WithEvents pnlhidemenu As System.Windows.Forms.Panel

End Class
