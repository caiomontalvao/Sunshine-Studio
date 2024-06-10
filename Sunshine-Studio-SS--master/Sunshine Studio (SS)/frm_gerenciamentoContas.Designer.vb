<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_gerenciamentoContas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerenciamentoContas))
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Status = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_def_senha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_cargo = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.btn_salvar = New ns1.BunifuThinButton2()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.Sienna
        Me.dgv_dados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_dados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_dados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CPF, Me.Nome, Me.Celular, Me.Cargo, Me.Editar, Me.Status})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_dados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_dados.GridColor = System.Drawing.Color.Black
        Me.dgv_dados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgv_dados.Location = New System.Drawing.Point(-3, 202)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(1)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_dados.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_dados.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_dados.Size = New System.Drawing.Size(860, 277)
        Me.dgv_dados.TabIndex = 0
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.MinimumWidth = 6
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        Me.CPF.Width = 125
        '
        'Nome
        '
        Me.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 6
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.MinimumWidth = 6
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        Me.Celular.Width = 125
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.MinimumWidth = 6
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        Me.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Cargo.Width = 125
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.MinimumWidth = 6
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        Me.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Editar.Width = 125
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Status.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Sienna
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(169, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GERENCIAMENTO DE COLABORADORES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Sienna
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(171, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NOME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Sienna
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(171, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "E-MAIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Sienna
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(442, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CELULAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Sienna
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(557, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DATA DE NASCIMENTO"
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.Location = New System.Drawing.Point(560, 77)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(143, 20)
        Me.cmb_data_nasc.TabIndex = 7
        Me.cmb_data_nasc.Value = New Date(2024, 5, 6, 19, 48, 16, 0)
        '
        'txt_celular
        '
        Me.txt_celular.BackColor = System.Drawing.Color.LightGray
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_celular.Location = New System.Drawing.Point(445, 134)
        Me.txt_celular.Mask = "(99)99999-9999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(100, 13)
        Me.txt_celular.TabIndex = 8
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.LightGray
        Me.txt_email.Location = New System.Drawing.Point(174, 126)
        Me.txt_email.MaxLength = 99
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(257, 20)
        Me.txt_email.TabIndex = 9
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.LightGray
        Me.txt_nome.Location = New System.Drawing.Point(174, 77)
        Me.txt_nome.MaxLength = 99
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(257, 20)
        Me.txt_nome.TabIndex = 10
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.LightGray
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Location = New System.Drawing.Point(445, 85)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 13)
        Me.txt_cpf.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Sienna
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(442, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "CPF"
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.LightGray
        Me.txt_usuario.Location = New System.Drawing.Point(174, 174)
        Me.txt_usuario.MaxLength = 99
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(118, 20)
        Me.txt_usuario.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Sienna
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(171, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "USUÁRIO"
        '
        'txt_def_senha
        '
        Me.txt_def_senha.BackColor = System.Drawing.Color.LightGray
        Me.txt_def_senha.Location = New System.Drawing.Point(313, 174)
        Me.txt_def_senha.MaxLength = 99
        Me.txt_def_senha.Name = "txt_def_senha"
        Me.txt_def_senha.Size = New System.Drawing.Size(118, 20)
        Me.txt_def_senha.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Sienna
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(310, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "SENHA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Sienna
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(557, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Cargo"
        '
        'cmb_cargo
        '
        Me.cmb_cargo.BackColor = System.Drawing.Color.LightGray
        Me.cmb_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_cargo.FormattingEnabled = True
        Me.cmb_cargo.Items.AddRange(New Object() {"Fotógrafo", "Recepção", "Gerencia"})
        Me.cmb_cargo.Location = New System.Drawing.Point(560, 126)
        Me.cmb_cargo.Name = "cmb_cargo"
        Me.cmb_cargo.Size = New System.Drawing.Size(143, 21)
        Me.cmb_cargo.TabIndex = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(138, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
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
        Me.btn_voltar.Location = New System.Drawing.Point(777, 0)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(72, 37)
        Me.btn_voltar.TabIndex = 54
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_salvar
        '
        Me.btn_salvar.ActiveBorderThickness = 1
        Me.btn_salvar.ActiveCornerRadius = 20
        Me.btn_salvar.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btn_salvar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_salvar.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btn_salvar.BackColor = System.Drawing.Color.LightGray
        Me.btn_salvar.BackgroundImage = CType(resources.GetObject("btn_salvar.BackgroundImage"), System.Drawing.Image)
        Me.btn_salvar.ButtonText = "SALVAR"
        Me.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_salvar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salvar.ForeColor = System.Drawing.Color.White
        Me.btn_salvar.IdleBorderThickness = 1
        Me.btn_salvar.IdleCornerRadius = 20
        Me.btn_salvar.IdleFillColor = System.Drawing.Color.Sienna
        Me.btn_salvar.IdleForecolor = System.Drawing.Color.Transparent
        Me.btn_salvar.IdleLineColor = System.Drawing.Color.Transparent
        Me.btn_salvar.Location = New System.Drawing.Point(700, 153)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(116, 41)
        Me.btn_salvar.TabIndex = 53
        Me.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_gerenciamentoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(854, 477)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.cmb_cargo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_def_senha)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.cmb_data_nasc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_dados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_gerenciamentoContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GerenciamentoContas"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_def_senha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_cargo As ComboBox
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewButtonColumn
    Friend WithEvents Status As DataGridViewButtonColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents btn_salvar As ns1.BunifuThinButton2
End Class
