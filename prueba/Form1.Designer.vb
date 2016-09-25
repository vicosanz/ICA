<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.LblTextBoxStd1 = New Infoware.Controles.Base.LblTextBoxStd()
    Me.LblTextBoxStd2 = New Infoware.Controles.Base.LblTextBoxStd()
    Me.GroupBoxHeader1 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.TaskBoxStd1 = New Infoware.Controles.Base.TaskBoxStd()
    Me.ButtonStd1 = New Infoware.Controles.Base.ButtonStd()
    Me.GroupBoxHeader1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(35, 68)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(160, 23)
    Me.Button1.TabIndex = 0
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'LblTextBoxStd1
    '
    Me.LblTextBoxStd1.Caption = "&Label1"
    Me.LblTextBoxStd1.Direccion = Infoware.Controles.Base.enumDireccion.Abajo
    Me.LblTextBoxStd1.esPassword = False
    Me.LblTextBoxStd1.Location = New System.Drawing.Point(35, 126)
    Me.LblTextBoxStd1.MultiLine = False
    Me.LblTextBoxStd1.Name = "LblTextBoxStd1"
    Me.LblTextBoxStd1.Size = New System.Drawing.Size(330, 40)
    Me.LblTextBoxStd1.TabIndex = 1
    '
    'LblTextBoxStd2
    '
    Me.LblTextBoxStd2.Caption = "Label1"
    Me.LblTextBoxStd2.Direccion = Infoware.Controles.Base.enumDireccion.Abajo
    Me.LblTextBoxStd2.esPassword = False
    Me.LblTextBoxStd2.Location = New System.Drawing.Point(35, 172)
    Me.LblTextBoxStd2.MultiLine = False
    Me.LblTextBoxStd2.Name = "LblTextBoxStd2"
    Me.LblTextBoxStd2.Size = New System.Drawing.Size(150, 40)
    Me.LblTextBoxStd2.TabIndex = 1
    '
    'GroupBoxHeader1
    '
    Me.GroupBoxHeader1.Controls.Add(Me.TaskBoxStd1)
    Me.GroupBoxHeader1.Location = New System.Drawing.Point(371, 39)
    Me.GroupBoxHeader1.Name = "GroupBoxHeader1"
    Me.GroupBoxHeader1.Size = New System.Drawing.Size(200, 100)
    Me.GroupBoxHeader1.TabIndex = 2
    Me.GroupBoxHeader1.TabStop = False
    Me.GroupBoxHeader1.Text = "GroupBoxHeader1"
    '
    'TaskBoxStd1
    '
    Me.TaskBoxStd1.BackColor = System.Drawing.Color.Transparent
    Me.TaskBoxStd1.HeaderText = ""
    Me.TaskBoxStd1.Location = New System.Drawing.Point(21, 56)
    Me.TaskBoxStd1.Name = "TaskBoxStd1"
    Me.TaskBoxStd1.Padding = New System.Windows.Forms.Padding(4, 44, 4, 3)
    Me.TaskBoxStd1.Size = New System.Drawing.Size(150, 130)
    Me.TaskBoxStd1.TabIndex = 3
    '
    'ButtonStd1
    '
    Me.ButtonStd1.Location = New System.Drawing.Point(64, 258)
    Me.ButtonStd1.Name = "ButtonStd1"
    Me.ButtonStd1.Size = New System.Drawing.Size(120, 23)
    Me.ButtonStd1.TabIndex = 3
    Me.ButtonStd1.Text = "ButtonStd1"
    Me.ButtonStd1.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(621, 309)
    Me.Controls.Add(Me.ButtonStd1)
    Me.Controls.Add(Me.GroupBoxHeader1)
    Me.Controls.Add(Me.LblTextBoxStd2)
    Me.Controls.Add(Me.LblTextBoxStd1)
    Me.Controls.Add(Me.Button1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.GroupBoxHeader1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents LblTextBoxStd1 As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents LblTextBoxStd2 As Infoware.Controles.Base.LblTextBoxStd
  Friend WithEvents GroupBoxHeader1 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents TaskBoxStd1 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents ButtonStd1 As Infoware.Controles.Base.ButtonStd

End Class
