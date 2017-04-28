<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSistemasLogin
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
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.GroupBoxHeader1 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.FlowUserPassword = New System.Windows.Forms.FlowLayoutPanel()
    Me.txtnombreusuario = New Infoware.Controles.Base.LblTextBoxStd()
    Me.txtcontrasena = New Infoware.Controles.Base.LblTextBoxStd()
    Me.chkguardarcontrasena = New Infoware.Controles.Base.CheckBoxStd()
    Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
    Me.chkSeguridadWindows = New Infoware.Controles.Base.CheckBoxStd()
    Me.Panel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.btnayuda = New Infoware.Controles.Base.ButtonStd()
    Me.btncancelar = New Infoware.Controles.Base.ButtonStd()
    Me.btnguardar = New Infoware.Controles.Base.ButtonStd()
    Me.Panel2 = New System.Windows.Forms.Panel()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBoxHeader1.SuspendLayout()
    Me.FlowUserPassword.SuspendLayout()
    Me.FlowLayoutPanel2.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'PictureBox1
    '
    Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
    Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(559, 154)
    Me.PictureBox1.TabIndex = 2
    Me.PictureBox1.TabStop = False
    '
    'GroupBoxHeader1
    '
    Me.GroupBoxHeader1.Controls.Add(Me.FlowUserPassword)
    Me.GroupBoxHeader1.Controls.Add(Me.FlowLayoutPanel2)
    Me.GroupBoxHeader1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBoxHeader1.Location = New System.Drawing.Point(13, 12)
    Me.GroupBoxHeader1.Margin = New System.Windows.Forms.Padding(4)
    Me.GroupBoxHeader1.Name = "GroupBoxHeader1"
    Me.GroupBoxHeader1.Padding = New System.Windows.Forms.Padding(20, 12, 4, 4)
    Me.GroupBoxHeader1.Size = New System.Drawing.Size(533, 162)
    Me.GroupBoxHeader1.TabIndex = 3
    Me.GroupBoxHeader1.TabStop = False
    Me.GroupBoxHeader1.Text = "Inicio de sesión"
    '
    'FlowUserPassword
    '
    Me.FlowUserPassword.Controls.Add(Me.txtnombreusuario)
    Me.FlowUserPassword.Controls.Add(Me.txtcontrasena)
    Me.FlowUserPassword.Controls.Add(Me.chkguardarcontrasena)
    Me.FlowUserPassword.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowUserPassword.Location = New System.Drawing.Point(20, 56)
    Me.FlowUserPassword.Margin = New System.Windows.Forms.Padding(4)
    Me.FlowUserPassword.Name = "FlowUserPassword"
    Me.FlowUserPassword.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
    Me.FlowUserPassword.Size = New System.Drawing.Size(509, 102)
    Me.FlowUserPassword.TabIndex = 1
    '
    'txtnombreusuario
    '
    Me.txtnombreusuario.Caption = "&Nombre de usuario:"
    Me.txtnombreusuario.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtnombreusuario.esPassword = False
    Me.txtnombreusuario.Location = New System.Drawing.Point(25, 5)
    Me.txtnombreusuario.Margin = New System.Windows.Forms.Padding(5)
    Me.txtnombreusuario.MultiLine = False
    Me.txtnombreusuario.Name = "txtnombreusuario"
    Me.txtnombreusuario.Size = New System.Drawing.Size(330, 22)
    Me.txtnombreusuario.TabIndex = 1
    '
    'txtcontrasena
    '
    Me.txtcontrasena.Caption = "&Contraseña:"
    Me.txtcontrasena.Direccion = Infoware.Controles.Base.enumDireccion.Derecha
    Me.txtcontrasena.esPassword = True
    Me.txtcontrasena.Location = New System.Drawing.Point(25, 37)
    Me.txtcontrasena.Margin = New System.Windows.Forms.Padding(5)
    Me.txtcontrasena.MultiLine = False
    Me.txtcontrasena.Name = "txtcontrasena"
    Me.txtcontrasena.Size = New System.Drawing.Size(330, 22)
    Me.txtcontrasena.TabIndex = 2
    '
    'chkguardarcontrasena
    '
    Me.chkguardarcontrasena.AutoSize = True
    Me.chkguardarcontrasena.Location = New System.Drawing.Point(24, 68)
    Me.chkguardarcontrasena.Margin = New System.Windows.Forms.Padding(4)
    Me.chkguardarcontrasena.Name = "chkguardarcontrasena"
    Me.chkguardarcontrasena.Size = New System.Drawing.Size(256, 21)
    Me.chkguardarcontrasena.TabIndex = 3
    Me.chkguardarcontrasena.Text = "&Guardar contraseña en este equipo"
    Me.chkguardarcontrasena.UseVisualStyleBackColor = True
    '
    'FlowLayoutPanel2
    '
    Me.FlowLayoutPanel2.Controls.Add(Me.chkSeguridadWindows)
    Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.FlowLayoutPanel2.Location = New System.Drawing.Point(20, 27)
    Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
    Me.FlowLayoutPanel2.Size = New System.Drawing.Size(509, 29)
    Me.FlowLayoutPanel2.TabIndex = 3
    '
    'chkSeguridadWindows
    '
    Me.chkSeguridadWindows.AutoSize = True
    Me.chkSeguridadWindows.Location = New System.Drawing.Point(4, 4)
    Me.chkSeguridadWindows.Margin = New System.Windows.Forms.Padding(4)
    Me.chkSeguridadWindows.Name = "chkSeguridadWindows"
    Me.chkSeguridadWindows.Size = New System.Drawing.Size(270, 21)
    Me.chkSeguridadWindows.TabIndex = 4
    Me.chkSeguridadWindows.Text = "&Usar Seguridad de Microsoft Windows"
    Me.chkSeguridadWindows.UseVisualStyleBackColor = True
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btnayuda)
    Me.Panel1.Controls.Add(Me.btncancelar)
    Me.Panel1.Controls.Add(Me.btnguardar)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
    Me.Panel1.Location = New System.Drawing.Point(13, 182)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(533, 39)
    Me.Panel1.TabIndex = 1
    '
    'btnayuda
    '
    Me.btnayuda.Location = New System.Drawing.Point(409, 4)
    Me.btnayuda.Margin = New System.Windows.Forms.Padding(4)
    Me.btnayuda.Name = "btnayuda"
    Me.btnayuda.Size = New System.Drawing.Size(120, 23)
    Me.btnayuda.TabIndex = 3
    Me.btnayuda.Text = "&Ayuda"
    Me.btnayuda.UseVisualStyleBackColor = True
    '
    'btncancelar
    '
    Me.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btncancelar.Location = New System.Drawing.Point(281, 4)
    Me.btncancelar.Margin = New System.Windows.Forms.Padding(4)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(120, 23)
    Me.btncancelar.TabIndex = 2
    Me.btncancelar.Text = "&Cancelar"
    Me.btncancelar.UseVisualStyleBackColor = True
    '
    'btnguardar
    '
    Me.btnguardar.Location = New System.Drawing.Point(153, 4)
    Me.btnguardar.Margin = New System.Windows.Forms.Padding(4)
    Me.btnguardar.Name = "btnguardar"
    Me.btnguardar.Size = New System.Drawing.Size(120, 23)
    Me.btnguardar.TabIndex = 1
    Me.btnguardar.Text = "&Conectar"
    Me.btnguardar.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Panel1)
    Me.Panel2.Controls.Add(Me.GroupBoxHeader1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 154)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
    Me.Panel2.Size = New System.Drawing.Size(559, 233)
    Me.Panel2.TabIndex = 4
    '
    'FrmSistemasLogin
    '
    Me.AcceptButton = Me.btnguardar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btncancelar
    Me.ClientSize = New System.Drawing.Size(559, 387)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.PictureBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmSistemasLogin"
    Me.Text = "Sistema registrado"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBoxHeader1.ResumeLayout(False)
    Me.FlowUserPassword.ResumeLayout(False)
    Me.FlowUserPassword.PerformLayout()
    Me.FlowLayoutPanel2.ResumeLayout(False)
    Me.FlowLayoutPanel2.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents GroupBoxHeader1 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents FlowUserPassword As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents txtnombreusuario As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents txtcontrasena As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents chkguardarcontrasena As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents Panel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents btnayuda As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btncancelar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnguardar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents chkSeguridadWindows As Controles.Base.CheckBoxStd
  Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
End Class
