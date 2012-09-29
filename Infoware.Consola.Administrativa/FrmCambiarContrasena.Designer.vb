<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarContrasena
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
    Me.Cancel = New Infoware.Controles.Base.ButtonStd
    Me.OK = New Infoware.Controles.Base.ButtonStd
    Me.txtnueva = New Infoware.Controles.Base.TextBoxStd
    Me.PasswordLabel = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtconfirmar = New Infoware.Controles.Base.TextBoxStd
    Me.SuspendLayout()
    '
    'Cancel
    '
    Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel.Location = New System.Drawing.Point(267, 102)
    Me.Cancel.Name = "Cancel"
    Me.Cancel.Size = New System.Drawing.Size(94, 23)
    Me.Cancel.TabIndex = 7
    Me.Cancel.Text = "&Cancelar"
    '
    'OK
    '
    Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OK.Location = New System.Drawing.Point(164, 102)
    Me.OK.Name = "OK"
    Me.OK.Size = New System.Drawing.Size(94, 23)
    Me.OK.TabIndex = 6
    Me.OK.Text = "&Aceptar"
    '
    'txtnueva
    '
    Me.txtnueva.Location = New System.Drawing.Point(154, 17)
    Me.txtnueva.Mensaje = ""
    Me.txtnueva.Name = "txtnueva"
    Me.txtnueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtnueva.Size = New System.Drawing.Size(158, 20)
    Me.txtnueva.TabIndex = 3
    Me.txtnueva.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtnueva.UseSystemPasswordChar = True
    '
    'PasswordLabel
    '
    Me.PasswordLabel.AutoSize = True
    Me.PasswordLabel.Location = New System.Drawing.Point(12, 21)
    Me.PasswordLabel.Name = "PasswordLabel"
    Me.PasswordLabel.Size = New System.Drawing.Size(97, 13)
    Me.PasswordLabel.TabIndex = 2
    Me.PasswordLabel.Text = "C&ontraseña nueva:"
    Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 47)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(110, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Co&nfirmar contraseña:"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtconfirmar
    '
    Me.txtconfirmar.Location = New System.Drawing.Point(154, 43)
    Me.txtconfirmar.Mensaje = ""
    Me.txtconfirmar.Name = "txtconfirmar"
    Me.txtconfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtconfirmar.Size = New System.Drawing.Size(158, 20)
    Me.txtconfirmar.TabIndex = 5
    Me.txtconfirmar.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtconfirmar.UseSystemPasswordChar = True
    '
    'FrmCambiarContrasena
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(373, 137)
    Me.Controls.Add(Me.Cancel)
    Me.Controls.Add(Me.OK)
    Me.Controls.Add(Me.txtconfirmar)
    Me.Controls.Add(Me.txtnueva)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.PasswordLabel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmCambiarContrasena"
    Me.ShowIcon = False
    Me.Text = "Cambiar contraseña"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Cancel As Infoware.Controles.Base.ButtonStd
  Friend WithEvents OK As Infoware.Controles.Base.ButtonStd
  Friend WithEvents txtnueva As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents PasswordLabel As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtconfirmar As Infoware.Controles.Base.TextBoxStd
End Class
