<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_agendar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_agendar))
        Me.data_agenda = New ns1.BunifuDatepicker()
        Me.txt_telefone = New ns1.BunifuMaterialTextbox()
        Me.cmb_clientes = New ns1.BunifuDropdown()
        Me.txt_cpf = New ns1.BunifuMaterialTextbox()
        Me.cmb_fotografo = New ns1.BunifuDropdown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_horario = New ns1.BunifuDropdown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_planos = New ns1.BunifuDropdown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_dados_sessoes = New ns1.BunifuCustomDataGrid()
        Me.cmb_pagamento = New ns1.BunifuDropdown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_valor = New ns1.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_parcelado = New ns1.BunifuDropdown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_agendar = New ns1.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgv_dados_sessoes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_agenda
        '
        Me.data_agenda.BackColor = System.Drawing.Color.Sienna
        Me.data_agenda.BorderRadius = 0
        Me.data_agenda.ForeColor = System.Drawing.Color.White
        Me.data_agenda.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.data_agenda.FormatCustom = Nothing
        Me.data_agenda.Location = New System.Drawing.Point(571, 53)
        Me.data_agenda.Name = "data_agenda"
        Me.data_agenda.Size = New System.Drawing.Size(217, 36)
        Me.data_agenda.TabIndex = 0
        Me.data_agenda.Value = New Date(2024, 5, 27, 21, 52, 8, 31)
        '
        'txt_telefone
        '
        Me.txt_telefone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_telefone.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefone.ForeColor = System.Drawing.Color.Black
        Me.txt_telefone.HintForeColor = System.Drawing.Color.Empty
        Me.txt_telefone.HintText = ""
        Me.txt_telefone.isPassword = False
        Me.txt_telefone.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_telefone.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_telefone.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_telefone.LineThickness = 3
        Me.txt_telefone.Location = New System.Drawing.Point(418, 100)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(107, 44)
        Me.txt_telefone.TabIndex = 2
        Me.txt_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmb_clientes
        '
        Me.cmb_clientes.BackColor = System.Drawing.Color.Transparent
        Me.cmb_clientes.BorderRadius = 3
        Me.cmb_clientes.ForeColor = System.Drawing.Color.White
        Me.cmb_clientes.Items = New String(-1) {}
        Me.cmb_clientes.Location = New System.Drawing.Point(156, 54)
        Me.cmb_clientes.Name = "cmb_clientes"
        Me.cmb_clientes.NomalColor = System.Drawing.Color.Sienna
        Me.cmb_clientes.onHoverColor = System.Drawing.Color.Sienna
        Me.cmb_clientes.selectedIndex = -1
        Me.cmb_clientes.Size = New System.Drawing.Size(217, 35)
        Me.cmb_clientes.TabIndex = 3
        '
        'txt_cpf
        '
        Me.txt_cpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cpf.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.Color.Black
        Me.txt_cpf.HintForeColor = System.Drawing.Color.Empty
        Me.txt_cpf.HintText = ""
        Me.txt_cpf.isPassword = False
        Me.txt_cpf.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_cpf.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_cpf.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_cpf.LineThickness = 3
        Me.txt_cpf.Location = New System.Drawing.Point(418, 45)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(107, 44)
        Me.txt_cpf.TabIndex = 24
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cmb_fotografo
        '
        Me.cmb_fotografo.BackColor = System.Drawing.Color.Transparent
        Me.cmb_fotografo.BorderRadius = 3
        Me.cmb_fotografo.ForeColor = System.Drawing.Color.White
        Me.cmb_fotografo.Items = New String(-1) {}
        Me.cmb_fotografo.Location = New System.Drawing.Point(571, 109)
        Me.cmb_fotografo.Name = "cmb_fotografo"
        Me.cmb_fotografo.NomalColor = System.Drawing.Color.Sienna
        Me.cmb_fotografo.onHoverColor = System.Drawing.Color.Sienna
        Me.cmb_fotografo.selectedIndex = -1
        Me.cmb_fotografo.Size = New System.Drawing.Size(217, 35)
        Me.cmb_fotografo.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Selecione um cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Selecione um fotógrafo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(568, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Selecione um dia:"
        '
        'cmb_horario
        '
        Me.cmb_horario.BackColor = System.Drawing.Color.Transparent
        Me.cmb_horario.BorderRadius = 3
        Me.cmb_horario.ForeColor = System.Drawing.Color.White
        Me.cmb_horario.Items = New String(-1) {}
        Me.cmb_horario.Location = New System.Drawing.Point(571, 164)
        Me.cmb_horario.Name = "cmb_horario"
        Me.cmb_horario.NomalColor = System.Drawing.Color.Sienna
        Me.cmb_horario.onHoverColor = System.Drawing.Color.Sienna
        Me.cmb_horario.selectedIndex = -1
        Me.cmb_horario.Size = New System.Drawing.Size(217, 35)
        Me.cmb_horario.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(570, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Selecione um horário:"
        '
        'cmb_planos
        '
        Me.cmb_planos.BackColor = System.Drawing.Color.Transparent
        Me.cmb_planos.BorderRadius = 3
        Me.cmb_planos.ForeColor = System.Drawing.Color.White
        Me.cmb_planos.Items = New String() {"Bronze", "Silver", "Gold"}
        Me.cmb_planos.Location = New System.Drawing.Point(156, 109)
        Me.cmb_planos.Name = "cmb_planos"
        Me.cmb_planos.NomalColor = System.Drawing.Color.Sienna
        Me.cmb_planos.onHoverColor = System.Drawing.Color.Sienna
        Me.cmb_planos.selectedIndex = -1
        Me.cmb_planos.Size = New System.Drawing.Size(217, 35)
        Me.cmb_planos.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Selecione um plano:"
        '
        'dgv_dados_sessoes
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv_dados_sessoes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados_sessoes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_dados_sessoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_dados_sessoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados_sessoes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados_sessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_sessoes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.data, Me.hora, Me.cliente, Me.valor, Me.excluir})
        Me.dgv_dados_sessoes.DoubleBuffered = True
        Me.dgv_dados_sessoes.EnableHeadersVisualStyles = False
        Me.dgv_dados_sessoes.HeaderBgColor = System.Drawing.Color.Sienna
        Me.dgv_dados_sessoes.HeaderForeColor = System.Drawing.Color.White
        Me.dgv_dados_sessoes.Location = New System.Drawing.Point(0, 248)
        Me.dgv_dados_sessoes.Name = "dgv_dados_sessoes"
        Me.dgv_dados_sessoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_dados_sessoes.Size = New System.Drawing.Size(801, 202)
        Me.dgv_dados_sessoes.TabIndex = 33
        '
        'cmb_pagamento
        '
        Me.cmb_pagamento.BackColor = System.Drawing.Color.Transparent
        Me.cmb_pagamento.BorderRadius = 3
        Me.cmb_pagamento.ForeColor = System.Drawing.Color.White
        Me.cmb_pagamento.Items = New String() {"À Vista", "Débito", "Crédito", "PIX"}
        Me.cmb_pagamento.Location = New System.Drawing.Point(156, 199)
        Me.cmb_pagamento.Name = "cmb_pagamento"
        Me.cmb_pagamento.NomalColor = System.Drawing.Color.Sienna
        Me.cmb_pagamento.onHoverColor = System.Drawing.Color.Sienna
        Me.cmb_pagamento.selectedIndex = -1
        Me.cmb_pagamento.Size = New System.Drawing.Size(217, 35)
        Me.cmb_pagamento.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(155, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Forma de pagamento:"
        '
        'txt_valor
        '
        Me.txt_valor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_valor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_valor.ForeColor = System.Drawing.Color.Black
        Me.txt_valor.HintForeColor = System.Drawing.Color.Empty
        Me.txt_valor.HintText = ""
        Me.txt_valor.isPassword = False
        Me.txt_valor.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_valor.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_valor.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_valor.LineThickness = 3
        Me.txt_valor.Location = New System.Drawing.Point(156, 148)
        Me.txt_valor.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(123, 32)
        Me.txt_valor.TabIndex = 38
        Me.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "CPF:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(415, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 15)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Telefone:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(155, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Valor:"
        '
        'cmb_parcelado
        '
        Me.cmb_parcelado.BackColor = System.Drawing.Color.Transparent
        Me.cmb_parcelado.BorderRadius = 3
        Me.cmb_parcelado.ForeColor = System.Drawing.Color.White
        Me.cmb_parcelado.Items = New String() {"2x", "3x", "4x", "5x", "6x"}
        Me.cmb_parcelado.Location = New System.Drawing.Point(286, 158)
        Me.cmb_parcelado.Name = "cmb_parcelado"
        Me.cmb_parcelado.NomalColor = System.Drawing.Color.Sienna
        Me.cmb_parcelado.onHoverColor = System.Drawing.Color.Sienna
        Me.cmb_parcelado.selectedIndex = -1
        Me.cmb_parcelado.Size = New System.Drawing.Size(87, 22)
        Me.cmb_parcelado.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(286, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 15)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Parcelado em:"
        '
        'btn_agendar
        '
        Me.btn_agendar.ActiveBorderThickness = 1
        Me.btn_agendar.ActiveCornerRadius = 20
        Me.btn_agendar.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btn_agendar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_agendar.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btn_agendar.BackColor = System.Drawing.Color.LightGray
        Me.btn_agendar.BackgroundImage = CType(resources.GetObject("btn_agendar.BackgroundImage"), System.Drawing.Image)
        Me.btn_agendar.ButtonText = "AGENDAR"
        Me.btn_agendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agendar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agendar.ForeColor = System.Drawing.Color.White
        Me.btn_agendar.IdleBorderThickness = 1
        Me.btn_agendar.IdleCornerRadius = 20
        Me.btn_agendar.IdleFillColor = System.Drawing.Color.Sienna
        Me.btn_agendar.IdleForecolor = System.Drawing.Color.Transparent
        Me.btn_agendar.IdleLineColor = System.Drawing.Color.Transparent
        Me.btn_agendar.Location = New System.Drawing.Point(637, 207)
        Me.btn_agendar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agendar.Name = "btn_agendar"
        Me.btn_agendar.Size = New System.Drawing.Size(151, 33)
        Me.btn_agendar.TabIndex = 35
        Me.btn_agendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btn_voltar
        '
        Me.btn_voltar.ActiveBorderThickness = 1
        Me.btn_voltar.ActiveCornerRadius = 20
        Me.btn_voltar.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btn_voltar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_voltar.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btn_voltar.BackColor = System.Drawing.Color.LightGray
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.ButtonText = "RETORNAR"
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.IdleBorderThickness = 1
        Me.btn_voltar.IdleCornerRadius = 20
        Me.btn_voltar.IdleFillColor = System.Drawing.Color.Sienna
        Me.btn_voltar.IdleForecolor = System.Drawing.Color.Transparent
        Me.btn_voltar.IdleLineColor = System.Drawing.Color.Transparent
        Me.btn_voltar.Location = New System.Drawing.Point(712, 0)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(76, 36)
        Me.btn_voltar.TabIndex = 44
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'data
        '
        Me.data.HeaderText = "Data:"
        Me.data.Name = "data"
        '
        'hora
        '
        Me.hora.HeaderText = "Hora:"
        Me.hora.Name = "hora"
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cliente.HeaderText = "Cliente:"
        Me.cliente.Name = "cliente"
        '
        'valor
        '
        Me.valor.HeaderText = "Valor:"
        Me.valor.Name = "valor"
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Name = "excluir"
        '
        'frm_agendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.cmb_parcelado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_pagamento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_agendar)
        Me.Controls.Add(Me.dgv_dados_sessoes)
        Me.Controls.Add(Me.cmb_planos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_horario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_fotografo)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmb_clientes)
        Me.Controls.Add(Me.txt_telefone)
        Me.Controls.Add(Me.data_agenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_valor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_agendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_agendar"
        CType(Me.dgv_dados_sessoes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents data_agenda As ns1.BunifuDatepicker
    Friend WithEvents txt_telefone As ns1.BunifuMaterialTextbox
    Friend WithEvents cmb_clientes As ns1.BunifuDropdown
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_cpf As ns1.BunifuMaterialTextbox
    Friend WithEvents cmb_fotografo As ns1.BunifuDropdown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_horario As ns1.BunifuDropdown
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_planos As ns1.BunifuDropdown
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_dados_sessoes As ns1.BunifuCustomDataGrid
    Friend WithEvents btn_agendar As ns1.BunifuThinButton2
    Friend WithEvents cmb_pagamento As ns1.BunifuDropdown
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_valor As ns1.BunifuMaterialTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_parcelado As ns1.BunifuDropdown
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents excluir As DataGridViewButtonColumn
End Class
