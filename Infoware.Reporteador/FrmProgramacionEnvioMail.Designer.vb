<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProgramacionEnvioMail
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

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
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.grpsucede = New Infoware.Controles.Base.GroupBoxHeader()
    Me.rdomensual = New System.Windows.Forms.RadioButton()
    Me.rdosemanal = New System.Windows.Forms.RadioButton()
    Me.rdodiario = New System.Windows.Forms.RadioButton()
    Me.grpdiario = New Infoware.Controles.Base.GroupBoxHeader()
    Me.numdiariocada = New System.Windows.Forms.NumericUpDown()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.grpsemanal = New Infoware.Controles.Base.GroupBoxHeader()
    Me.chksemanaldom = New Infoware.Controles.Base.CheckBoxStd()
    Me.chksemanalsab = New Infoware.Controles.Base.CheckBoxStd()
    Me.chksemanalvie = New Infoware.Controles.Base.CheckBoxStd()
    Me.chksemanaljue = New Infoware.Controles.Base.CheckBoxStd()
    Me.chksemanalmie = New Infoware.Controles.Base.CheckBoxStd()
    Me.chksemanalmar = New Infoware.Controles.Base.CheckBoxStd()
    Me.chksemanallun = New Infoware.Controles.Base.CheckBoxStd()
    Me.numsemanalcada = New System.Windows.Forms.NumericUpDown()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.grpmensual = New Infoware.Controles.Base.GroupBoxHeader()
    Me.cbomensualdiasemana = New Infoware.Controles.Base.ComboBoxStd()
    Me.cbomensualorden = New Infoware.Controles.Base.ComboBoxStd()
    Me.nummensualcada = New System.Windows.Forms.NumericUpDown()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.rdomensualelprimer = New System.Windows.Forms.RadioButton()
    Me.rdomensualeldia = New System.Windows.Forms.RadioButton()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.nummensualdia = New System.Windows.Forms.NumericUpDown()
    Me.grpfrecuencia = New Infoware.Controles.Base.GroupBoxHeader()
    Me.dtfrecuenciacadahasta = New Infoware.Controles.Base.DateTimePickerStd()
    Me.dtfrecuenciacadadesde = New Infoware.Controles.Base.DateTimePickerStd()
    Me.dtfrecuenciaalas = New Infoware.Controles.Base.DateTimePickerStd()
    Me.cbofrecuenciacadatipo = New Infoware.Controles.Base.ComboBoxStd()
    Me.rdofrecuenciasucedecada = New System.Windows.Forms.RadioButton()
    Me.rdofrecuenciaunavez = New System.Windows.Forms.RadioButton()
    Me.numfrecuenciacada = New System.Windows.Forms.NumericUpDown()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.grpduracion = New Infoware.Controles.Base.GroupBoxHeader()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.dtduracionfechahasta = New Infoware.Controles.Base.DateTimePickerStd()
    Me.dtduracionfechadesde = New Infoware.Controles.Base.DateTimePickerStd()
    Me.grpmails = New Infoware.Controles.Base.GroupBoxHeader()
    Me.btnbuscarcorreos = New Infoware.Controles.Base.ButtonStd()
    Me.txtemails = New Infoware.Controles.Base.TextBoxStd()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.GroupBoxHeader1 = New Infoware.Controles.Base.GroupBoxHeader()
    Me.chklisto = New System.Windows.Forms.CheckBox()
    Me.pnlcuerpo.SuspendLayout()
    Me.FlowLayoutPanel1.SuspendLayout()
    Me.grpsucede.SuspendLayout()
    Me.grpdiario.SuspendLayout()
    CType(Me.numdiariocada, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpsemanal.SuspendLayout()
    CType(Me.numsemanalcada, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpmensual.SuspendLayout()
    CType(Me.nummensualcada, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nummensualdia, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpfrecuencia.SuspendLayout()
    CType(Me.numfrecuenciacada, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpduracion.SuspendLayout()
    Me.grpmails.SuspendLayout()
    Me.GroupBoxHeader1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.FlowLayoutPanel1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(734, 462)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.FlowLayoutPanel1, 0)
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Controls.Add(Me.grpsucede)
    Me.FlowLayoutPanel1.Controls.Add(Me.grpdiario)
    Me.FlowLayoutPanel1.Controls.Add(Me.grpsemanal)
    Me.FlowLayoutPanel1.Controls.Add(Me.grpmensual)
    Me.FlowLayoutPanel1.Controls.Add(Me.grpfrecuencia)
    Me.FlowLayoutPanel1.Controls.Add(Me.grpduracion)
    Me.FlowLayoutPanel1.Controls.Add(Me.grpmails)
    Me.FlowLayoutPanel1.Controls.Add(Me.GroupBoxHeader1)
    Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 25)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(734, 437)
    Me.FlowLayoutPanel1.TabIndex = 3
    '
    'grpsucede
    '
    Me.grpsucede.Controls.Add(Me.rdomensual)
    Me.grpsucede.Controls.Add(Me.rdosemanal)
    Me.grpsucede.Controls.Add(Me.rdodiario)
    Me.grpsucede.Location = New System.Drawing.Point(7, 7)
    Me.grpsucede.Margin = New System.Windows.Forms.Padding(7)
    Me.grpsucede.Name = "grpsucede"
    Me.grpsucede.Size = New System.Drawing.Size(170, 90)
    Me.grpsucede.TabIndex = 2
    Me.grpsucede.TabStop = False
    Me.grpsucede.Text = "Sucede"
    '
    'rdomensual
    '
    Me.rdomensual.AutoSize = True
    Me.rdomensual.Location = New System.Drawing.Point(6, 65)
    Me.rdomensual.Name = "rdomensual"
    Me.rdomensual.Size = New System.Drawing.Size(94, 17)
    Me.rdomensual.TabIndex = 0
    Me.rdomensual.Text = "Mensualmente"
    Me.rdomensual.UseVisualStyleBackColor = True
    '
    'rdosemanal
    '
    Me.rdosemanal.AutoSize = True
    Me.rdosemanal.Location = New System.Drawing.Point(6, 42)
    Me.rdosemanal.Name = "rdosemanal"
    Me.rdosemanal.Size = New System.Drawing.Size(95, 17)
    Me.rdosemanal.TabIndex = 0
    Me.rdosemanal.Text = "Semanalmente"
    Me.rdosemanal.UseVisualStyleBackColor = True
    '
    'rdodiario
    '
    Me.rdodiario.AutoSize = True
    Me.rdodiario.Checked = True
    Me.rdodiario.Location = New System.Drawing.Point(6, 19)
    Me.rdodiario.Name = "rdodiario"
    Me.rdodiario.Size = New System.Drawing.Size(81, 17)
    Me.rdodiario.TabIndex = 0
    Me.rdodiario.TabStop = True
    Me.rdodiario.Text = "Diariamente"
    Me.rdodiario.UseVisualStyleBackColor = True
    '
    'grpdiario
    '
    Me.grpdiario.Controls.Add(Me.numdiariocada)
    Me.grpdiario.Controls.Add(Me.Label2)
    Me.grpdiario.Controls.Add(Me.Label1)
    Me.grpdiario.Location = New System.Drawing.Point(191, 7)
    Me.grpdiario.Margin = New System.Windows.Forms.Padding(7)
    Me.grpdiario.Name = "grpdiario"
    Me.grpdiario.Size = New System.Drawing.Size(274, 93)
    Me.grpdiario.TabIndex = 2
    Me.grpdiario.TabStop = False
    Me.grpdiario.Text = "Diariamente"
    '
    'numdiariocada
    '
    Me.numdiariocada.Location = New System.Drawing.Point(44, 19)
    Me.numdiariocada.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numdiariocada.Name = "numdiariocada"
    Me.numdiariocada.Size = New System.Drawing.Size(50, 20)
    Me.numdiariocada.TabIndex = 1
    Me.numdiariocada.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(100, 21)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "días"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 23)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(32, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Cada"
    '
    'grpsemanal
    '
    Me.grpsemanal.Controls.Add(Me.chksemanaldom)
    Me.grpsemanal.Controls.Add(Me.chksemanalsab)
    Me.grpsemanal.Controls.Add(Me.chksemanalvie)
    Me.grpsemanal.Controls.Add(Me.chksemanaljue)
    Me.grpsemanal.Controls.Add(Me.chksemanalmie)
    Me.grpsemanal.Controls.Add(Me.chksemanalmar)
    Me.grpsemanal.Controls.Add(Me.chksemanallun)
    Me.grpsemanal.Controls.Add(Me.numsemanalcada)
    Me.grpsemanal.Controls.Add(Me.Label3)
    Me.grpsemanal.Controls.Add(Me.Label4)
    Me.grpsemanal.Location = New System.Drawing.Point(7, 114)
    Me.grpsemanal.Margin = New System.Windows.Forms.Padding(7)
    Me.grpsemanal.Name = "grpsemanal"
    Me.grpsemanal.Size = New System.Drawing.Size(274, 93)
    Me.grpsemanal.TabIndex = 2
    Me.grpsemanal.TabStop = False
    Me.grpsemanal.Text = "Semanalmente"
    Me.grpsemanal.Visible = False
    '
    'chksemanaldom
    '
    Me.chksemanaldom.AutoSize = True
    Me.chksemanaldom.Checked = True
    Me.chksemanaldom.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chksemanaldom.Location = New System.Drawing.Point(115, 68)
    Me.chksemanaldom.Name = "chksemanaldom"
    Me.chksemanaldom.Size = New System.Drawing.Size(51, 17)
    Me.chksemanaldom.TabIndex = 2
    Me.chksemanaldom.Text = "Dom."
    Me.chksemanaldom.UseVisualStyleBackColor = True
    '
    'chksemanalsab
    '
    Me.chksemanalsab.AutoSize = True
    Me.chksemanalsab.Location = New System.Drawing.Point(62, 68)
    Me.chksemanalsab.Name = "chksemanalsab"
    Me.chksemanalsab.Size = New System.Drawing.Size(48, 17)
    Me.chksemanalsab.TabIndex = 2
    Me.chksemanalsab.Text = "Sab."
    Me.chksemanalsab.UseVisualStyleBackColor = True
    '
    'chksemanalvie
    '
    Me.chksemanalvie.AutoSize = True
    Me.chksemanalvie.Location = New System.Drawing.Point(9, 68)
    Me.chksemanalvie.Name = "chksemanalvie"
    Me.chksemanalvie.Size = New System.Drawing.Size(44, 17)
    Me.chksemanalvie.TabIndex = 2
    Me.chksemanalvie.Text = "Vie."
    Me.chksemanalvie.UseVisualStyleBackColor = True
    '
    'chksemanaljue
    '
    Me.chksemanaljue.AutoSize = True
    Me.chksemanaljue.Location = New System.Drawing.Point(167, 45)
    Me.chksemanaljue.Name = "chksemanaljue"
    Me.chksemanaljue.Size = New System.Drawing.Size(46, 17)
    Me.chksemanaljue.TabIndex = 2
    Me.chksemanaljue.Text = "Jue."
    Me.chksemanaljue.UseVisualStyleBackColor = True
    '
    'chksemanalmie
    '
    Me.chksemanalmie.AutoSize = True
    Me.chksemanalmie.Location = New System.Drawing.Point(115, 45)
    Me.chksemanalmie.Name = "chksemanalmie"
    Me.chksemanalmie.Size = New System.Drawing.Size(46, 17)
    Me.chksemanalmie.TabIndex = 2
    Me.chksemanalmie.Text = "Mie."
    Me.chksemanalmie.UseVisualStyleBackColor = True
    '
    'chksemanalmar
    '
    Me.chksemanalmar.AutoSize = True
    Me.chksemanalmar.Location = New System.Drawing.Point(62, 45)
    Me.chksemanalmar.Name = "chksemanalmar"
    Me.chksemanalmar.Size = New System.Drawing.Size(47, 17)
    Me.chksemanalmar.TabIndex = 2
    Me.chksemanalmar.Text = "Mar."
    Me.chksemanalmar.UseVisualStyleBackColor = True
    '
    'chksemanallun
    '
    Me.chksemanallun.AutoSize = True
    Me.chksemanallun.Location = New System.Drawing.Point(9, 45)
    Me.chksemanallun.Name = "chksemanallun"
    Me.chksemanallun.Size = New System.Drawing.Size(47, 17)
    Me.chksemanallun.TabIndex = 2
    Me.chksemanallun.Text = "Lun."
    Me.chksemanallun.UseVisualStyleBackColor = True
    '
    'numsemanalcada
    '
    Me.numsemanalcada.Location = New System.Drawing.Point(44, 19)
    Me.numsemanalcada.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numsemanalcada.Name = "numsemanalcada"
    Me.numsemanalcada.Size = New System.Drawing.Size(50, 20)
    Me.numsemanalcada.TabIndex = 1
    Me.numsemanalcada.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(100, 21)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(63, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "semanas el:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 23)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(32, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Cada"
    '
    'grpmensual
    '
    Me.grpmensual.Controls.Add(Me.cbomensualdiasemana)
    Me.grpmensual.Controls.Add(Me.cbomensualorden)
    Me.grpmensual.Controls.Add(Me.nummensualcada)
    Me.grpmensual.Controls.Add(Me.Label5)
    Me.grpmensual.Controls.Add(Me.rdomensualelprimer)
    Me.grpmensual.Controls.Add(Me.rdomensualeldia)
    Me.grpmensual.Controls.Add(Me.Label6)
    Me.grpmensual.Controls.Add(Me.nummensualdia)
    Me.grpmensual.Location = New System.Drawing.Point(295, 114)
    Me.grpmensual.Margin = New System.Windows.Forms.Padding(7)
    Me.grpmensual.Name = "grpmensual"
    Me.grpmensual.Size = New System.Drawing.Size(274, 93)
    Me.grpmensual.TabIndex = 2
    Me.grpmensual.TabStop = False
    Me.grpmensual.Text = "Mensualmente"
    Me.grpmensual.Visible = False
    '
    'cbomensualdiasemana
    '
    Me.cbomensualdiasemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomensualdiasemana.FormattingEnabled = True
    Me.cbomensualdiasemana.Items.AddRange(New Object() {"Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"})
    Me.cbomensualdiasemana.Location = New System.Drawing.Point(143, 67)
    Me.cbomensualdiasemana.Name = "cbomensualdiasemana"
    Me.cbomensualdiasemana.Size = New System.Drawing.Size(121, 21)
    Me.cbomensualdiasemana.TabIndex = 2
    '
    'cbomensualorden
    '
    Me.cbomensualorden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomensualorden.FormattingEnabled = True
    Me.cbomensualorden.Items.AddRange(New Object() {"1er", "2do", "3er", "4to", "último"})
    Me.cbomensualorden.Location = New System.Drawing.Point(48, 67)
    Me.cbomensualorden.Name = "cbomensualorden"
    Me.cbomensualorden.Size = New System.Drawing.Size(89, 21)
    Me.cbomensualorden.TabIndex = 2
    '
    'nummensualcada
    '
    Me.nummensualcada.Location = New System.Drawing.Point(44, 19)
    Me.nummensualcada.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nummensualcada.Name = "nummensualcada"
    Me.nummensualcada.Size = New System.Drawing.Size(50, 20)
    Me.nummensualcada.TabIndex = 1
    Me.nummensualcada.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(100, 21)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(37, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "meses"
    '
    'rdomensualelprimer
    '
    Me.rdomensualelprimer.AutoSize = True
    Me.rdomensualelprimer.Location = New System.Drawing.Point(9, 68)
    Me.rdomensualelprimer.Name = "rdomensualelprimer"
    Me.rdomensualelprimer.Size = New System.Drawing.Size(33, 17)
    Me.rdomensualelprimer.TabIndex = 0
    Me.rdomensualelprimer.Text = "el"
    Me.rdomensualelprimer.UseVisualStyleBackColor = True
    '
    'rdomensualeldia
    '
    Me.rdomensualeldia.AutoSize = True
    Me.rdomensualeldia.Checked = True
    Me.rdomensualeldia.Location = New System.Drawing.Point(9, 45)
    Me.rdomensualeldia.Name = "rdomensualeldia"
    Me.rdomensualeldia.Size = New System.Drawing.Size(52, 17)
    Me.rdomensualeldia.TabIndex = 0
    Me.rdomensualeldia.TabStop = True
    Me.rdomensualeldia.Text = "el día"
    Me.rdomensualeldia.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(6, 23)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(32, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Cada"
    '
    'nummensualdia
    '
    Me.nummensualdia.Location = New System.Drawing.Point(67, 45)
    Me.nummensualdia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
    Me.nummensualdia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nummensualdia.Name = "nummensualdia"
    Me.nummensualdia.Size = New System.Drawing.Size(50, 20)
    Me.nummensualdia.TabIndex = 1
    Me.nummensualdia.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'grpfrecuencia
    '
    Me.grpfrecuencia.Controls.Add(Me.dtfrecuenciacadahasta)
    Me.grpfrecuencia.Controls.Add(Me.dtfrecuenciacadadesde)
    Me.grpfrecuencia.Controls.Add(Me.dtfrecuenciaalas)
    Me.grpfrecuencia.Controls.Add(Me.cbofrecuenciacadatipo)
    Me.grpfrecuencia.Controls.Add(Me.rdofrecuenciasucedecada)
    Me.grpfrecuencia.Controls.Add(Me.rdofrecuenciaunavez)
    Me.grpfrecuencia.Controls.Add(Me.numfrecuenciacada)
    Me.grpfrecuencia.Controls.Add(Me.Label8)
    Me.grpfrecuencia.Controls.Add(Me.Label7)
    Me.grpfrecuencia.Location = New System.Drawing.Point(7, 221)
    Me.grpfrecuencia.Margin = New System.Windows.Forms.Padding(7)
    Me.grpfrecuencia.Name = "grpfrecuencia"
    Me.grpfrecuencia.Size = New System.Drawing.Size(439, 92)
    Me.grpfrecuencia.TabIndex = 2
    Me.grpfrecuencia.TabStop = False
    Me.grpfrecuencia.Text = "Frecuencia diaria"
    '
    'dtfrecuenciacadahasta
    '
    Me.dtfrecuenciacadahasta.Format = System.Windows.Forms.DateTimePickerFormat.Time
    Me.dtfrecuenciacadahasta.Location = New System.Drawing.Point(341, 68)
    Me.dtfrecuenciacadahasta.Name = "dtfrecuenciacadahasta"
    Me.dtfrecuenciacadahasta.ShowUpDown = True
    Me.dtfrecuenciacadahasta.Size = New System.Drawing.Size(94, 20)
    Me.dtfrecuenciacadahasta.TabIndex = 3
    '
    'dtfrecuenciacadadesde
    '
    Me.dtfrecuenciacadadesde.Format = System.Windows.Forms.DateTimePickerFormat.Time
    Me.dtfrecuenciacadadesde.Location = New System.Drawing.Point(341, 42)
    Me.dtfrecuenciacadadesde.Name = "dtfrecuenciacadadesde"
    Me.dtfrecuenciacadadesde.ShowUpDown = True
    Me.dtfrecuenciacadadesde.Size = New System.Drawing.Size(94, 20)
    Me.dtfrecuenciacadadesde.TabIndex = 3
    '
    'dtfrecuenciaalas
    '
    Me.dtfrecuenciaalas.Format = System.Windows.Forms.DateTimePickerFormat.Time
    Me.dtfrecuenciaalas.Location = New System.Drawing.Point(146, 17)
    Me.dtfrecuenciaalas.Name = "dtfrecuenciaalas"
    Me.dtfrecuenciaalas.ShowUpDown = True
    Me.dtfrecuenciaalas.Size = New System.Drawing.Size(94, 20)
    Me.dtfrecuenciaalas.TabIndex = 3
    '
    'cbofrecuenciacadatipo
    '
    Me.cbofrecuenciacadatipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbofrecuenciacadatipo.FormattingEnabled = True
    Me.cbofrecuenciacadatipo.Items.AddRange(New Object() {"horas", "minutos"})
    Me.cbofrecuenciacadatipo.Location = New System.Drawing.Point(160, 41)
    Me.cbofrecuenciacadatipo.Name = "cbofrecuenciacadatipo"
    Me.cbofrecuenciacadatipo.Size = New System.Drawing.Size(89, 21)
    Me.cbofrecuenciacadatipo.TabIndex = 2
    '
    'rdofrecuenciasucedecada
    '
    Me.rdofrecuenciasucedecada.AutoSize = True
    Me.rdofrecuenciasucedecada.Location = New System.Drawing.Point(9, 42)
    Me.rdofrecuenciasucedecada.Name = "rdofrecuenciasucedecada"
    Me.rdofrecuenciasucedecada.Size = New System.Drawing.Size(89, 17)
    Me.rdofrecuenciasucedecada.TabIndex = 0
    Me.rdofrecuenciasucedecada.Text = "Sucede cada"
    Me.rdofrecuenciasucedecada.UseVisualStyleBackColor = True
    '
    'rdofrecuenciaunavez
    '
    Me.rdofrecuenciaunavez.AutoSize = True
    Me.rdofrecuenciaunavez.Checked = True
    Me.rdofrecuenciaunavez.Location = New System.Drawing.Point(9, 19)
    Me.rdofrecuenciaunavez.Name = "rdofrecuenciaunavez"
    Me.rdofrecuenciaunavez.Size = New System.Drawing.Size(131, 17)
    Me.rdofrecuenciaunavez.TabIndex = 0
    Me.rdofrecuenciaunavez.TabStop = True
    Me.rdofrecuenciaunavez.Text = "Sucede una vez a las:"
    Me.rdofrecuenciaunavez.UseVisualStyleBackColor = True
    '
    'numfrecuenciacada
    '
    Me.numfrecuenciacada.Location = New System.Drawing.Point(104, 42)
    Me.numfrecuenciacada.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
    Me.numfrecuenciacada.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numfrecuenciacada.Name = "numfrecuenciacada"
    Me.numfrecuenciacada.Size = New System.Drawing.Size(50, 20)
    Me.numfrecuenciacada.TabIndex = 1
    Me.numfrecuenciacada.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(255, 72)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(69, 13)
    Me.Label8.TabIndex = 0
    Me.Label8.Text = "termina a las:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(255, 44)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(80, 13)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "comienza a las:"
    '
    'grpduracion
    '
    Me.grpduracion.Controls.Add(Me.Label10)
    Me.grpduracion.Controls.Add(Me.Label9)
    Me.grpduracion.Controls.Add(Me.dtduracionfechahasta)
    Me.grpduracion.Controls.Add(Me.dtduracionfechadesde)
    Me.grpduracion.Location = New System.Drawing.Point(460, 221)
    Me.grpduracion.Margin = New System.Windows.Forms.Padding(7)
    Me.grpduracion.Name = "grpduracion"
    Me.grpduracion.Size = New System.Drawing.Size(228, 70)
    Me.grpduracion.TabIndex = 3
    Me.grpduracion.TabStop = False
    Me.grpduracion.Text = "Duración"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(6, 47)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(62, 13)
    Me.Label10.TabIndex = 0
    Me.Label10.Text = "Fecha final:"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(6, 21)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(69, 13)
    Me.Label9.TabIndex = 0
    Me.Label9.Text = "Fecha inicial:"
    '
    'dtduracionfechahasta
    '
    Me.dtduracionfechahasta.Checked = False
    Me.dtduracionfechahasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtduracionfechahasta.Location = New System.Drawing.Point(92, 45)
    Me.dtduracionfechahasta.Name = "dtduracionfechahasta"
    Me.dtduracionfechahasta.ShowCheckBox = True
    Me.dtduracionfechahasta.Size = New System.Drawing.Size(117, 20)
    Me.dtduracionfechahasta.TabIndex = 3
    '
    'dtduracionfechadesde
    '
    Me.dtduracionfechadesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtduracionfechadesde.Location = New System.Drawing.Point(92, 19)
    Me.dtduracionfechadesde.Name = "dtduracionfechadesde"
    Me.dtduracionfechadesde.Size = New System.Drawing.Size(117, 20)
    Me.dtduracionfechadesde.TabIndex = 3
    '
    'grpmails
    '
    Me.grpmails.Controls.Add(Me.btnbuscarcorreos)
    Me.grpmails.Controls.Add(Me.txtemails)
    Me.grpmails.Controls.Add(Me.Label12)
    Me.grpmails.Location = New System.Drawing.Point(7, 327)
    Me.grpmails.Margin = New System.Windows.Forms.Padding(7)
    Me.grpmails.Name = "grpmails"
    Me.grpmails.Size = New System.Drawing.Size(439, 94)
    Me.grpmails.TabIndex = 3
    Me.grpmails.TabStop = False
    Me.grpmails.Text = "Enviar a"
    '
    'btnbuscarcorreos
    '
    Me.btnbuscarcorreos.Location = New System.Drawing.Point(360, 19)
    Me.btnbuscarcorreos.Name = "btnbuscarcorreos"
    Me.btnbuscarcorreos.Size = New System.Drawing.Size(26, 23)
    Me.btnbuscarcorreos.TabIndex = 2
    Me.btnbuscarcorreos.Text = "..."
    Me.btnbuscarcorreos.UseVisualStyleBackColor = True
    '
    'txtemails
    '
    Me.txtemails.Location = New System.Drawing.Point(108, 19)
    Me.txtemails.Mensaje = ""
    Me.txtemails.Multiline = True
    Me.txtemails.Name = "txtemails"
    Me.txtemails.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtemails.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtemails.PromptText = ""
    Me.txtemails.ReadOnly = True
    Me.txtemails.Size = New System.Drawing.Size(247, 69)
    Me.txtemails.TabIndex = 1
    Me.txtemails.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(6, 22)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(96, 13)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "Correo electrónico:"
    '
    'GroupBoxHeader1
    '
    Me.GroupBoxHeader1.Controls.Add(Me.chklisto)
    Me.GroupBoxHeader1.Location = New System.Drawing.Point(460, 327)
    Me.GroupBoxHeader1.Margin = New System.Windows.Forms.Padding(7)
    Me.GroupBoxHeader1.Name = "GroupBoxHeader1"
    Me.GroupBoxHeader1.Size = New System.Drawing.Size(228, 70)
    Me.GroupBoxHeader1.TabIndex = 3
    Me.GroupBoxHeader1.TabStop = False
    Me.GroupBoxHeader1.Text = "Estado"
    '
    'chklisto
    '
    Me.chklisto.AutoSize = True
    Me.chklisto.Location = New System.Drawing.Point(9, 18)
    Me.chklisto.Name = "chklisto"
    Me.chklisto.Size = New System.Drawing.Size(88, 17)
    Me.chklisto.TabIndex = 0
    Me.chklisto.Text = "En ejecución"
    Me.chklisto.UseVisualStyleBackColor = True
    '
    'FrmProgramacionEnvioMail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(734, 511)
    Me.Name = "FrmProgramacionEnvioMail"
    Me.Text = "Programación envío mail automático"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.FlowLayoutPanel1.ResumeLayout(False)
    Me.grpsucede.ResumeLayout(False)
    Me.grpsucede.PerformLayout()
    Me.grpdiario.ResumeLayout(False)
    Me.grpdiario.PerformLayout()
    CType(Me.numdiariocada, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpsemanal.ResumeLayout(False)
    Me.grpsemanal.PerformLayout()
    CType(Me.numsemanalcada, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpmensual.ResumeLayout(False)
    Me.grpmensual.PerformLayout()
    CType(Me.nummensualcada, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nummensualdia, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpfrecuencia.ResumeLayout(False)
    Me.grpfrecuencia.PerformLayout()
    CType(Me.numfrecuenciacada, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpduracion.ResumeLayout(False)
    Me.grpduracion.PerformLayout()
    Me.grpmails.ResumeLayout(False)
    Me.grpmails.PerformLayout()
    Me.GroupBoxHeader1.ResumeLayout(False)
    Me.GroupBoxHeader1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents grpsucede As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents rdomensual As System.Windows.Forms.RadioButton
  Friend WithEvents rdosemanal As System.Windows.Forms.RadioButton
  Friend WithEvents rdodiario As System.Windows.Forms.RadioButton
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents grpdiario As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents numdiariocada As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents grpsemanal As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents numsemanalcada As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents chksemanallun As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chksemanaldom As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chksemanalsab As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chksemanalvie As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chksemanaljue As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chksemanalmie As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chksemanalmar As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents grpmensual As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents nummensualcada As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents rdomensualelprimer As System.Windows.Forms.RadioButton
  Friend WithEvents rdomensualeldia As System.Windows.Forms.RadioButton
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents nummensualdia As System.Windows.Forms.NumericUpDown
  Friend WithEvents cbomensualdiasemana As Infoware.Controles.Base.ComboBoxStd
  Friend WithEvents cbomensualorden As Infoware.Controles.Base.ComboBoxStd
  Friend WithEvents grpfrecuencia As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents cbofrecuenciacadatipo As Infoware.Controles.Base.ComboBoxStd
  Friend WithEvents rdofrecuenciasucedecada As System.Windows.Forms.RadioButton
  Friend WithEvents rdofrecuenciaunavez As System.Windows.Forms.RadioButton
  Friend WithEvents dtfrecuenciacadahasta As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents dtfrecuenciacadadesde As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents dtfrecuenciaalas As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents numfrecuenciacada As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents grpduracion As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents dtduracionfechahasta As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents dtduracionfechadesde As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents grpmails As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents btnbuscarcorreos As Infoware.Controles.Base.ButtonStd
  Friend WithEvents txtemails As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents GroupBoxHeader1 As Infoware.Controles.Base.GroupBoxHeader
  Friend WithEvents chklisto As System.Windows.Forms.CheckBox
End Class
