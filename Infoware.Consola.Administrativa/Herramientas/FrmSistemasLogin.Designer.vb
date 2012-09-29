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
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.GroupBoxHeader1 = New Infoware.Controles.Base.GroupBoxHeader
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
    Me.txtnombreusuario = New Infoware.Controles.Base.LblTextBoxStd
    Me.txtcontrasena = New Infoware.Controles.Base.LblTextBoxStd
    Me.chkguardarcontrasena = New Infoware.Controles.Base.CheckBoxStd
    Me.Panel1 = New System.Windows.Forms.FlowLayoutPanel
    Me.btnayuda = New Infoware.Controles.Base.ButtonStd
    Me.btncancelar = New Infoware.Controles.Base.ButtonStd
    Me.btnguardar = New Infoware.Controles.Base.ButtonStd
    Me.Panel2 = New System.Windows.Forms.Panel
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBoxHeader1.SuspendLayout()
    Me.FlowLayoutPanel1.SuspendLayout()
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
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(419, 125)
    Me.PictureBox1.TabIndex = 2
    Me.PictureBox1.TabStop = False
    '
    'GroupBoxHeader1
    '
    Me.GroupBoxHeader1.Controls.Add(Me.FlowLayoutPanel1)
    Me.GroupBoxHeader1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBoxHeader1.Location = New System.Drawing.Point(10, 10)
    Me.GroupBoxHeader1.Name = "GroupBoxHeader1"
    Me.GroupBoxHeader1.Padding = New System.Windows.Forms.Padding(15, 10, 3, 3)
    Me.GroupBoxHeader1.Size = New System.Drawing.Size(399, 115)
    Me.GroupBoxHeader1.TabIndex = 3
    Me.GroupBoxHeader1.TabStop = False
    Me.GroupBoxHeader1.Text = "Inicio de sesión"
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.txtnombreusuario)
    Me.FlowLayoutPanel1.Controls.Add(Me.txtcontrasena)
    Me.FlowLayoutPanel1.Controls.Add(Me.chkguardarcontrasena)
    Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 23)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(381, 89)
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
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.btnayuda)
    Me.Panel1.Controls.Add(Me.btncancelar)
    Me.Panel1.Controls.Add(Me.btnguardar)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
    Me.Panel1.Location = New System.Drawing.Point(10, 130)
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
    Me.btnguardar.Text = "&Conectar"
    Me.btnguardar.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Panel1)
    Me.Panel2.Controls.Add(Me.GroupBoxHeader1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 125)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
    Me.Panel2.Size = New System.Drawing.Size(419, 172)
    Me.Panel2.TabIndex = 4
    '
    'FrmSistemasLogin
    '
    Me.AcceptButton = Me.btnguardar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btncancelar
    Me.ClientSize = New System.Drawing.Size(419, 297)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.PictureBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmSistemasLogin"
    Me.Text = "Sistema registrado"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBoxHeader1.ResumeLayout(False)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.FlowLayoutPanel1.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents GroupBoxHeader1 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents txtnombreusuario As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents txtcontrasena As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents chkguardarcontrasena As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents Panel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents btnayuda As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btncancelar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents btnguardar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
