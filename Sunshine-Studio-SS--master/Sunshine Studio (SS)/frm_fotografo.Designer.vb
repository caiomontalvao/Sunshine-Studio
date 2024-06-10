<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fotografo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fotografo))
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.btn_sair = New ns1.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgv_fotografo = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_fotografo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.LightGray
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(197, 37)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(314, 56)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "FOTÓGRAFO"
        '
        'btn_voltar
        '
        Me.btn_voltar.ActiveBorderThickness = 1
        Me.btn_voltar.ActiveCornerRadius = 15
        Me.btn_voltar.ActiveFillColor = System.Drawing.Color.Black
        Me.btn_voltar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_voltar.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_voltar.BackColor = System.Drawing.Color.LightGray
        Me.btn_voltar.BackgroundImage = CType(resources.GetObject("btn_voltar.BackgroundImage"), System.Drawing.Image)
        Me.btn_voltar.ButtonText = "LOGOUT"
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_voltar.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.IdleBorderThickness = 1
        Me.btn_voltar.IdleCornerRadius = 20
        Me.btn_voltar.IdleFillColor = System.Drawing.Color.Black
        Me.btn_voltar.IdleForecolor = System.Drawing.Color.White
        Me.btn_voltar.IdleLineColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(496, 1)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(67, 33)
        Me.btn_voltar.TabIndex = 32
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_sair
        '
        Me.btn_sair.ActiveBorderThickness = 1
        Me.btn_sair.ActiveCornerRadius = 15
        Me.btn_sair.ActiveFillColor = System.Drawing.Color.Black
        Me.btn_sair.ActiveForecolor = System.Drawing.Color.White
        Me.btn_sair.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_sair.BackColor = System.Drawing.Color.LightGray
        Me.btn_sair.BackgroundImage = CType(resources.GetObject("btn_sair.BackgroundImage"), System.Drawing.Image)
        Me.btn_sair.ButtonText = "SAIR"
        Me.btn_sair.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_sair.Font = New System.Drawing.Font("Century Gothic", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.IdleBorderThickness = 1
        Me.btn_sair.IdleCornerRadius = 20
        Me.btn_sair.IdleFillColor = System.Drawing.Color.Black
        Me.btn_sair.IdleForecolor = System.Drawing.Color.White
        Me.btn_sair.IdleLineColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(569, 1)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(36, 33)
        Me.btn_sair.TabIndex = 31
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(234, 198)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'dgv_fotografo
        '
        Me.dgv_fotografo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fotografo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.cliente, Me.telefone, Me.dia, Me.hora, Me.valor})
        Me.dgv_fotografo.Location = New System.Drawing.Point(-41, 173)
        Me.dgv_fotografo.Name = "dgv_fotografo"
        Me.dgv_fotografo.Size = New System.Drawing.Size(661, 180)
        Me.dgv_fotografo.TabIndex = 34
        '
        'id
        '
        Me.id.HeaderText = "ID:"
        Me.id.Name = "id"
        '
        'cliente
        '
        Me.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cliente.HeaderText = "Cliente:"
        Me.cliente.Name = "cliente"
        '
        'telefone
        '
        Me.telefone.HeaderText = "Celular:"
        Me.telefone.Name = "telefone"
        '
        'dia
        '
        Me.dia.HeaderText = "Dia:"
        Me.dia.Name = "dia"
        '
        'hora
        '
        Me.hora.HeaderText = "Hora:"
        Me.hora.Name = "hora"
        '
        'valor
        '
        Me.valor.HeaderText = "Valor:"
        Me.valor.Name = "valor"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'frm_fotografo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(618, 353)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgv_fotografo)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_fotografo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FOTOGRÁFO"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_fotografo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents btn_sair As ns1.BunifuThinButton2
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgv_fotografo As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents telefone As DataGridViewTextBoxColumn
    Friend WithEvents dia As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
    Friend WithEvents valor As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
