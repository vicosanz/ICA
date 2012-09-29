<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSistemas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.Panel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.btnayuda = New Infoware.Controles.Base.ButtonStd()
    Me.btncancelar = New Infoware.Controles.Base.ButtonStd()
    Me.btnguardar = New Infoware.Controles.Base.ButtonStd()
    Me.btnprobar = New Infoware.Controles.Base.ButtonStd()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.GroupBoxHeader2 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtnombresistema = New Infoware.Controles.Base.LblTextBoxStd()
    Me.txtdescripcionsistema = New Infoware.Controles.Base.LblTextBoxStd()
    Me.GroupBoxHeader1 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.txtnombreusuario = New Infoware.Controles.Base.LblTextBoxStd()
    Me.txtcontrasena = New Infoware.Controles.Base.LblTextBoxStd()
    Me.chkguardarcontrasena = New Infoware.Controles.Base.CheckBoxStd()
    Me.chkcargaraliniciar = New Infoware.Controles.Base.CheckBoxStd()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.GroupBoxHeader4 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
    Me.txtarchivoensamblado = New Infoware.Controles.Base.LblTextBoxStd()
    Me.btnexaminar = New Infoware.Controles.Base.ButtonStd()
    Me.GroupBoxHeader3 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
    Me.cboproveedor = New Infoware.Controles.Base.LblComboBoxStd()
    Me.cboservidor = New Infoware.Controles.Base.LblComboBoxStd()
    Me.txtbasedatos = New Infoware.Controles.Base.LblTextBoxStd()
    Me.txtnombreusuariobd = New Infoware.Controles.Base.LblTextBoxStd()
    Me.txtcontrasenabd = New Infoware.Controles.Base.LblTextBoxStd()
    Me.chkguardarcontrasenabd = New Infoware.Controles.Base.CheckBoxStd()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.Panel1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.GroupBoxHeader2.SuspendLayout()
    Me.FlowLayoutPanel2.SuspendLayout()
    Me.GroupBoxHeader1.SuspendLayout()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.GroupBoxHeader4.SuspendLayout()
    Me.FlowLayoutPanel4.SuspendLayout()
    Me.GroupBoxHeader3.SuspendLayout()
    Me.FlowLayoutPanel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btnayuda)
    Me.Panel1.Controls.Add(Me.btncancelar)
    Me.Panel1.Controls.Add(Me.btnguardar)
    Me.Panel1.Controls.Add(Me.btnprobar)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
    Me.Panel1.Location = New System.Drawing.Point(10, 350)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(399, 32)
    Me.Panel1.TabIndex = 1
    '
    'btnayuda
    '
    Me.btnayuda.Location = New System.Drawing.Point(321, 3)
    Me.btnayuda.Name = "btnayuda"
    Me.btnayuda.Size = New System.Drawing.Size(75, 23)
    Me.btnayuda.TabIndex = 3
    Me.btnayuda.Text = "&Ayuda"
    Me.btnayuda.UseVisualStyleBackColor = True
    '
    'btncancelar
    '
    Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btncancelar.Location = New System.Drawing.Point(240, 3)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(75, 23)
    Me.btncancelar.TabIndex = 2
    Me.btncancelar.Text = "&Cancelar"
    Me.btncancelar.UseVisualStyleBackColor = True
    '
    'btnguardar
    '
    Me.btnguardar.Location = New System.Drawing.Point(159, 3)
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(75, 23)
    Me.btnguardar.TabIndex = 1
    Me.btnguardar.Text = "&Guardar"
    Me.btnguardar.UseVisualStyleBackColor = True
    '
    'btnprobar
    '
    Me.btnprobar.Location = New System.Drawing.Point(78, 3)
    Me.btnprobar.Name = "btnprobar"
    Me.btnprobar.Size = New System.Drawing.Size(75, 23)
    Me.btnprobar.TabIndex = 0
    Me.btnprobar.Text = "&Probar"
    Me.btnprobar.UseVisualStyleBackColor = True
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(10, 10)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(399, 340)
    Me.TabControl1.TabIndex = 0
    Me.TabControl1.TabStop = False
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.GroupBoxHeader2)
    Me.TabPage1.Controls.Add(Me.GroupBoxHeader1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(10)
    Me.TabPage1.Size = New System.Drawing.Size(391, 314)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "General"
    '
    'GroupBoxHeader2
    '
    Me.GroupBoxHeader2.Controls.Add(Me.FlowLayoutPanel2)
    Me.GroupBoxHeader2.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBoxHeader2.Location = New System.Drawing.Point(10, 127)
    Me.GroupBoxHeader2.Name = "GroupBoxHeader2"
    Me.GroupBoxHeader2.Padding = New System.Windows.Forms.Padding(15, 10, 3, 3)
    Me.GroupBoxHeader2.Size = New System.Drawing.Size(371, 180)
    Me.GroupBoxHeader2.TabIndex = 4
    Me.GroupBoxHeader2.TabStop = False
    Me.GroupBoxHeader2.Text = "Sistema registrado"
    '
    'FlowLayoutPanel2
    '
    Me.FlowLayoutPanel2.Controls.Add(Me.Label1)
    Me.FlowLayoutPanel2.Controls.Add(Me.txtnombresistema)
    Me.FlowLayoutPanel2.Controls.Add(Me.txtdescripcionsistema)
    Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel2.Location = New System.Drawing.Point(15, 23)
    Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
    Me.FlowLayoutPanel2.Size = New System.Drawing.Size(353, 154)
    Me.FlowLayoutPanel2.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(3, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(314, 26)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Puede reemplazar el nombre del sistema registrado por un nuevo nombre y descripci" & _
    "ón"
    '
    'txtnombresistema
    '
    Me.txtnombresistema.Caption = "Nombre del &sistema registrado:"
    Me.txtnombresistema.Direccion = Infoware.Controles.Base.enumDireccion.Abajo
    Me.txtnombresistema.esPassword = False
    Me.txtnombresistema.Location = New System.Drawing.Point(3, 29)
    Me.txtnombresistema.MultiLine = False
    Me.txtnombresistema.Name = "txtnombresistema"
    Me.txtnombresistema.Size = New System.Drawing.Size(330, 40)
    Me.txtnombresistema.TabIndex = 0
    '
    'txtdescripcionsistema
    '
    Me.txtdescripcionsistema.Caption = "&Descripción del sistema registrado:"
    Me.txtdescripcionsistema.Direccion = Infoware.Controles.Base.enumDireccion.Abajo
    Me.txtdescripcionsistema.esPassword = False
    Me.txtdescripcionsistema.Location = New System.Drawing.Point(3, 75)
    Me.txtdescripcionsistema.MultiLine = True
    Me.txtdescripcionsistema.Name = "txtdescripcionsistema"
    Me.txtdescripcionsistema.Size = New System.Drawing.Size(330, 60)
    Me.txtdescripcionsistema.TabIndex = 1
    '
    'GroupBoxHeader1
    '
    Me.GroupBoxHeader1.Controls.Add(Me.FlowLayoutPanel1)
    Me.GroupBoxHeader1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBoxHeader1.Location = New System.Drawing.Point(10, 10)
    Me.GroupBoxHeader1.Name = "GroupBoxHeader1"
    Me.GroupBoxHeader1.Padding = New System.Windows.Forms.Padding(15, 10, 3, 3)
    Me.GroupBoxHeader1.Size = New System.Drawing.Size(371, 117)
    Me.GroupBoxHeader1.TabIndex = 3
    Me.GroupBoxHeader1.TabStop = False
    Me.GroupBoxHeader1.Text = "Inicio de sesión"
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.txtnombreusuario)
    Me.FlowLayoutPanel1.Controls.Add(Me.txtcontrasena)
    Me.FlowLayoutPanel1.Controls.Add(Me.chkguardarcontrasena)
    Me.FlowLayoutPanel1.Controls.Add(Me.chkcargaraliniciar)
    Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 23)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(353, 91)
    Me.FlowLayoutPanel1.TabIndex = 1
    '
    'txtnombreusuario
    '
    Me.txtnombreusuario.Caption = "&Nombre de usuario:"
    Me.txtnombreusuario.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtnombreusuario.esPassword = False
    Me.txtnombreusuario.Location = New System.Drawing.Point(3, 3)
    Me.txtnombreusuario.MultiLine = False
    Me.txtnombreusuario.Name = "txtnombreusuario"
    Me.txtnombreusuario.Size = New System.Drawing.Size(330, 20)
    Me.txtnombreusuario.TabIndex = 1
    '
    'txtcontrasena
    '
    Me.txtcontrasena.Caption = "&Contraseña:"
    Me.txtcontrasena.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtcontrasena.esPassword = True
    Me.txtcontrasena.Location = New System.Drawing.Point(3, 29)
    Me.txtcontrasena.MultiLine = False
    Me.txtcontrasena.Name = "txtcontrasena"
    Me.txtcontrasena.Size = New System.Drawing.Size(330, 20)
    Me.txtcontrasena.TabIndex = 2
    '
    'chkguardarcontrasena
    '
    Me.chkguardarcontrasena.AutoSize = True
    Me.chkguardarcontrasena.Location = New System.Drawing.Point(3, 55)
    Me.chkguardarcontrasena.Name = "chkguardarcontrasena"
    Me.chkguardarcontrasena.Size = New System.Drawing.Size(193, 17)
    Me.chkguardarcontrasena.TabIndex = 3
    Me.chkguardarcontrasena.Text = "&Guardar contraseña en este equipo"
    Me.chkguardarcontrasena.UseVisualStyleBackColor = True
    '
    'chkcargaraliniciar
    '
    Me.chkcargaraliniciar.AutoSize = True
    Me.chkcargaraliniciar.Enabled = False
    Me.chkcargaraliniciar.Location = New System.Drawing.Point(202, 55)
    Me.chkcargaraliniciar.Name = "chkcargaraliniciar"
    Me.chkcargaraliniciar.Size = New System.Drawing.Size(98, 17)
    Me.chkcargaraliniciar.TabIndex = 4
    Me.chkcargaraliniciar.Text = "&Cargar al iniciar"
    Me.chkcargaraliniciar.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.GroupBoxHeader4)
    Me.TabPage2.Controls.Add(Me.GroupBoxHeader3)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(10)
    Me.TabPage2.Size = New System.Drawing.Size(391, 314)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Conexión"
    '
    'GroupBoxHeader4
    '
    Me.GroupBoxHeader4.Controls.Add(Me.FlowLayoutPanel4)
    Me.GroupBoxHeader4.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBoxHeader4.Location = New System.Drawing.Point(10, 199)
    Me.GroupBoxHeader4.Name = "GroupBoxHeader4"
    Me.GroupBoxHeader4.Padding = New System.Windows.Forms.Padding(15, 10, 3, 3)
    Me.GroupBoxHeader4.Size = New System.Drawing.Size(371, 92)
    Me.GroupBoxHeader4.TabIndex = 1
    Me.GroupBoxHeader4.TabStop = False
    Me.GroupBoxHeader4.Text = "Directorio"
    '
    'FlowLayoutPanel4
    '
    Me.FlowLayoutPanel4.Controls.Add(Me.txtarchivoensamblado)
    Me.FlowLayoutPanel4.Controls.Add(Me.btnexaminar)
    Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel4.Location = New System.Drawing.Point(15, 23)
    Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
    Me.FlowLayoutPanel4.Size = New System.Drawing.Size(353, 66)
    Me.FlowLayoutPanel4.TabIndex = 0
    '
    'txtarchivoensamblado
    '
    Me.txtarchivoensamblado.Caption = "&Directorio de ensamblados:"
    Me.txtarchivoensamblado.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtarchivoensamblado.esPassword = False
    Me.txtarchivoensamblado.Location = New System.Drawing.Point(3, 3)
    Me.txtarchivoensamblado.MultiLine = False
    Me.txtarchivoensamblado.Name = "txtarchivoensamblado"
    Me.txtarchivoensamblado.Size = New System.Drawing.Size(330, 20)
    Me.txtarchivoensamblado.TabIndex = 0
    '
    'btnexaminar
    '
    Me.btnexaminar.Location = New System.Drawing.Point(3, 29)
    Me.btnexaminar.Name = "btnexaminar"
    Me.btnexaminar.Size = New System.Drawing.Size(120, 23)
    Me.btnexaminar.TabIndex = 1
    Me.btnexaminar.Text = "&Examinar"
    Me.btnexaminar.UseVisualStyleBackColor = True
    '
    'GroupBoxHeader3
    '
    Me.GroupBoxHeader3.Controls.Add(Me.FlowLayoutPanel3)
    Me.GroupBoxHeader3.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBoxHeader3.Location = New System.Drawing.Point(10, 10)
    Me.GroupBoxHeader3.Name = "GroupBoxHeader3"
    Me.GroupBoxHeader3.Padding = New System.Windows.Forms.Padding(15, 10, 3, 3)
    Me.GroupBoxHeader3.Size = New System.Drawing.Size(371, 189)
    Me.GroupBoxHeader3.TabIndex = 0
    Me.GroupBoxHeader3.TabStop = False
    Me.GroupBoxHeader3.Text = "Conectar a base de datos"
    '
    'FlowLayoutPanel3
    '
    Me.FlowLayoutPanel3.Controls.Add(Me.cboproveedor)
    Me.FlowLayoutPanel3.Controls.Add(Me.cboservidor)
    Me.FlowLayoutPanel3.Controls.Add(Me.txtbasedatos)
    Me.FlowLayoutPanel3.Controls.Add(Me.txtnombreusuariobd)
    Me.FlowLayoutPanel3.Controls.Add(Me.txtcontrasenabd)
    Me.FlowLayoutPanel3.Controls.Add(Me.chkguardarcontrasenabd)
    Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel3.Location = New System.Drawing.Point(15, 23)
    Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
    Me.FlowLayoutPanel3.Size = New System.Drawing.Size(353, 163)
    Me.FlowLayoutPanel3.TabIndex = 0
    '
    'cboproveedor
    '
    Me.cboproveedor.Caption = "Proveedor de datos:"
    Me.cboproveedor.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.cboproveedor.Location = New System.Drawing.Point(3, 3)
    Me.cboproveedor.Name = "cboproveedor"
    Me.cboproveedor.Size = New System.Drawing.Size(330, 21)
    Me.cboproveedor.TabIndex = 0
    '
    'cboservidor
    '
    Me.cboservidor.Caption = "Servidor:"
    Me.cboservidor.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.cboservidor.Location = New System.Drawing.Point(3, 30)
    Me.cboservidor.Name = "cboservidor"
    Me.cboservidor.Size = New System.Drawing.Size(330, 21)
    Me.cboservidor.TabIndex = 1
    '
    'txtbasedatos
    '
    Me.txtbasedatos.Caption = "&Base de datos:"
    Me.txtbasedatos.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtbasedatos.esPassword = False
    Me.txtbasedatos.Location = New System.Drawing.Point(3, 57)
    Me.txtbasedatos.MultiLine = False
    Me.txtbasedatos.Name = "txtbasedatos"
    Me.txtbasedatos.Size = New System.Drawing.Size(330, 20)
    Me.txtbasedatos.TabIndex = 2
    '
    'txtnombreusuariobd
    '
    Me.txtnombreusuariobd.Caption = "&Nombre de usuario:"
    Me.txtnombreusuariobd.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtnombreusuariobd.esPassword = False
    Me.txtnombreusuariobd.Location = New System.Drawing.Point(3, 83)
    Me.txtnombreusuariobd.MultiLine = False
    Me.txtnombreusuariobd.Name = "txtnombreusuariobd"
    Me.txtnombreusuariobd.Size = New System.Drawing.Size(330, 20)
    Me.txtnombreusuariobd.TabIndex = 3
    '
    'txtcontrasenabd
    '
    Me.txtcontrasenabd.Caption = "&Contraseña:"
    Me.txtcontrasenabd.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtcontrasenabd.esPassword = True
    Me.txtcontrasenabd.Location = New System.Drawing.Point(3, 109)
    Me.txtcontrasenabd.MultiLine = False
    Me.txtcontrasenabd.Name = "txtcontrasenabd"
    Me.txtcontrasenabd.Size = New System.Drawing.Size(330, 20)
    Me.txtcontrasenabd.TabIndex = 4
    '
    'chkguardarcontrasenabd
    '
    Me.chkguardarcontrasenabd.AutoSize = True
    Me.chkguardarcontrasenabd.Checked = True
    Me.chkguardarcontrasenabd.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkguardarcontrasenabd.Location = New System.Drawing.Point(3, 135)
    Me.chkguardarcontrasenabd.Name = "chkguardarcontrasenabd"
    Me.chkguardarcontrasenabd.Size = New System.Drawing.Size(193, 17)
    Me.chkguardarcontrasenabd.TabIndex = 5
    Me.chkguardarcontrasenabd.Text = "&Guardar contraseña en este equipo"
    Me.chkguardarcontrasenabd.UseVisualStyleBackColor = True
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'FrmSistemas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btncancelar
    Me.ClientSize = New System.Drawing.Size(419, 392)
    Me.Controls.Add(Me.TabControl1)
    Me.Controls.Add(Me.Panel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmSistemas"
    Me.Padding = New System.Windows.Forms.Padding(10)
    Me.Text = "Sistema registrado"
    Me.Panel1.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.GroupBoxHeader2.ResumeLayout(False)
    Me.FlowLayoutPanel2.ResumeLayout(False)
    Me.FlowLayoutPanel2.PerformLayout()
    Me.GroupBoxHeader1.ResumeLayout(False)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.GroupBoxHeader4.ResumeLayout(False)
    Me.FlowLayoutPanel4.ResumeLayout(False)
    Me.GroupBoxHeader3.ResumeLayout(False)
    Me.FlowLayoutPanel3.ResumeLayout(False)
    Me.FlowLayoutPanel3.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents GroupBoxHeader2 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents txtnombresistema As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents txtdescripcionsistema As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents btnayuda As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btncancelar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnguardar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnprobar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBoxHeader3 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents txtnombreusuariobd As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents txtcontrasenabd As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents chkguardarcontrasenabd As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents cboservidor As Infoware.Controles.Base.LblComboBoxStd
  Friend WithEvents txtbasedatos As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents GroupBoxHeader4 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents txtarchivoensamblado As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents btnexaminar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents GroupBoxHeader1 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents txtnombreusuario As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents txtcontrasena As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents chkguardarcontrasena As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chkcargaraliniciar As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents cboproveedor As Infoware.Controles.Base.LblComboBoxStd
End Class
