<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDialogoBase
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
    Me.OK_Button = New Infoware.Controles.Base.ButtonStd
    Me.Cancel_Button = New Infoware.Controles.Base.ButtonStd
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OK_Button.Location = New System.Drawing.Point(181, 3)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(79, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "Aceptar"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Location = New System.Drawing.Point(266, 3)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(79, 23)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancelar"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Cancel_Button)
    Me.Panel1.Controls.Add(Me.OK_Button)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.Location = New System.Drawing.Point(0, 195)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(353, 37)
    Me.Panel1.TabIndex = 1000
    '
    'FrmMantBase
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(353, 232)
    Me.Controls.Add(Me.Panel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmMantBase"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "FrmMantBase"
    Me.Panel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents OK_Button As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Cancel_Button As Infoware.Controles.Base.ButtonStd
  Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
