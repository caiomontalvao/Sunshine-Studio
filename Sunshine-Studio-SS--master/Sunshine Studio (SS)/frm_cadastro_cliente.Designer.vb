<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_cliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_cliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_dados_clientes = New System.Windows.Forms.DataGridView()
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.status = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txt_nome = New ns1.BunifuMaterialTextbox()
        Me.txt_endereco = New ns1.BunifuMaterialTextbox()
        Me.txt_email = New ns1.BunifuMaterialTextbox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.data_nascimento = New ns1.BunifuDatepicker()
        Me.btn_salvar = New ns1.BunifuThinButton2()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Sienna
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(180, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GERENCIAR CLIENTES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Sienna
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(426, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "CPF"
        '
        'txt_celular
        '
        Me.txt_celular.BackColor = System.Drawing.Color.LightGray
        Me.txt_celular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_celular.Location = New System.Drawing.Point(429, 128)
        Me.txt_celular.Mask = "(99)99999-9999"
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(100, 14)
        Me.txt_celular.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Sienna
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(568, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "DATA DE NASCIMENTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Sienna
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(426, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "CELULAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Sienna
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(155, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "E-MAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Sienna
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(155, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "NOME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Sienna
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(155, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "ENDEREÇO"
        '
        'dgv_dados_clientes
        '
        Me.dgv_dados_clientes.BackgroundColor = System.Drawing.Color.Sienna
        Me.dgv_dados_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_cliente, Me.nome, Me.email, Me.celular, Me.editar, Me.status})
        Me.dgv_dados_clientes.Location = New System.Drawing.Point(-1, 204)
        Me.dgv_dados_clientes.Name = "dgv_dados_clientes"
        Me.dgv_dados_clientes.Size = New System.Drawing.Size(742, 214)
        Me.dgv_dados_clientes.TabIndex = 44
        '
        'id_cliente
        '
        Me.id_cliente.HeaderText = "Id:"
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.Width = 50
        '
        'nome
        '
        Me.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nome.HeaderText = "Nome:"
        Me.nome.Name = "nome"
        '
        'email
        '
        Me.email.HeaderText = "Email:"
        Me.email.Name = "email"
        '
        'celular
        '
        Me.celular.HeaderText = "Celular:"
        Me.celular.Name = "celular"
        '
        'editar
        '
        Me.editar.HeaderText = "Editar:"
        Me.editar.Name = "editar"
        '
        'status
        '
        Me.status.HeaderText = "Status:"
        Me.status.Name = "status"
        '
        'txt_nome
        '
        Me.txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nome.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nome.HintForeColor = System.Drawing.Color.Empty
        Me.txt_nome.HintText = ""
        Me.txt_nome.isPassword = False
        Me.txt_nome.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nome.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_nome.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nome.LineThickness = 3
        Me.txt_nome.Location = New System.Drawing.Point(158, 72)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(257, 21)
        Me.txt_nome.TabIndex = 46
        Me.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_endereco
        '
        Me.txt_endereco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_endereco.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_endereco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_endereco.HintForeColor = System.Drawing.Color.Empty
        Me.txt_endereco.HintText = ""
        Me.txt_endereco.isPassword = False
        Me.txt_endereco.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_endereco.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_endereco.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_endereco.LineThickness = 3
        Me.txt_endereco.Location = New System.Drawing.Point(158, 171)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(257, 21)
        Me.txt_endereco.TabIndex = 48
        Me.txt_endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_email
        '
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_email.HintForeColor = System.Drawing.Color.Empty
        Me.txt_email.HintText = ""
        Me.txt_email.isPassword = False
        Me.txt_email.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_email.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_email.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_email.LineThickness = 3
        Me.txt_email.Location = New System.Drawing.Point(158, 121)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(257, 21)
        Me.txt_email.TabIndex = 49
        Me.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.Color.LightGray
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cpf.Location = New System.Drawing.Point(429, 79)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(100, 14)
        Me.txt_cpf.TabIndex = 41
        '
        'data_nascimento
        '
        Me.data_nascimento.AutoSize = True
        Me.data_nascimento.BackColor = System.Drawing.Color.LightGray
        Me.data_nascimento.BorderRadius = 0
        Me.data_nascimento.ForeColor = System.Drawing.Color.Black
        Me.data_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.data_nascimento.FormatCustom = "dd/MM/yyyy"
        Me.data_nascimento.Location = New System.Drawing.Point(537, 73)
        Me.data_nascimento.Margin = New System.Windows.Forms.Padding(0)
        Me.data_nascimento.Name = "data_nascimento"
        Me.data_nascimento.Size = New System.Drawing.Size(186, 21)
        Me.data_nascimento.TabIndex = 0
        Me.data_nascimento.Value = New Date(2024, 6, 3, 19, 41, 55, 767)
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
        Me.btn_salvar.Location = New System.Drawing.Point(580, 155)
        Me.btn_salvar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(116, 41)
        Me.btn_salvar.TabIndex = 51
        Me.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_voltar.Location = New System.Drawing.Point(657, 2)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(72, 37)
        Me.btn_voltar.TabIndex = 52
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_cadastro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(741, 417)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.dgv_dados_clientes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_celular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data_nascimento)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_cadastro_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastro_cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dados_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_celular As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgv_dados_clientes As DataGridView
    Friend WithEvents id_cliente As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents celular As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewButtonColumn
    Friend WithEvents status As DataGridViewButtonColumn
    Friend WithEvents txt_nome As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_endereco As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_email As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents data_nascimento As ns1.BunifuDatepicker
    Friend WithEvents btn_salvar As ns1.BunifuThinButton2
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
End Class
