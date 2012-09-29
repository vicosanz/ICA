<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAyuda
    Inherits System.Windows.Forms.Form

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAyuda))
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.lbltitulo = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btncerrar = New Infoware.Controles.Base.ButtonStd()
    Me.txtdescripcion = New System.Windows.Forms.TextBox()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
    Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(29, 26)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'lbltitulo
    '
    Me.lbltitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lbltitulo.Location = New System.Drawing.Point(47, 10)
    Me.lbltitulo.Name = "lbltitulo"
    Me.lbltitulo.Size = New System.Drawing.Size(311, 17)
    Me.lbltitulo.TabIndex = 1
    Me.lbltitulo.Text = "Label1"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(12, 42)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(70, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'btncerrar
    '
    Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btncerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btncerrar.Location = New System.Drawing.Point(283, 145)
    Me.btncerrar.Name = "btncerrar"
    Me.btncerrar.Size = New System.Drawing.Size(75, 23)
    Me.btncerrar.TabIndex = 3
    Me.btncerrar.Text = "&Cerrar"
    Me.btncerrar.UseVisualStyleBackColor = True
    '
    'txtdescripcion
    '
    Me.txtdescripcion.BackColor = System.Drawing.SystemColors.Window
    Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtdescripcion.Location = New System.Drawing.Point(15, 58)
    Me.txtdescripcion.Multiline = True
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.ReadOnly = True
    Me.txtdescripcion.Size = New System.Drawing.Size(343, 81)
    Me.txtdescripcion.TabIndex = 4
    '
    'FrmAyuda
    '
    Me.AcceptButton = Me.btncerrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.SystemColors.Window
    Me.CancelButton = Me.btncerrar
    Me.ClientSize = New System.Drawing.Size(370, 175)
    Me.Controls.Add(Me.txtdescripcion)
    Me.Controls.Add(Me.btncerrar)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lbltitulo)
    Me.Controls.Add(Me.PictureBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "FrmAyuda"
    Me.Text = "Ayuda"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents lbltitulo As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btncerrar As Infoware.Controles.Base.ButtonStd
  Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
End Class
