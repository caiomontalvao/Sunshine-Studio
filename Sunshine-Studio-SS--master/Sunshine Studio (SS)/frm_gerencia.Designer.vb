<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_gerencia))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.btn_agendar_sessao = New ns1.BunifuThinButton2()
        Me.btn_cadastrar_cliente = New ns1.BunifuThinButton2()
        Me.btn_sair = New ns1.BunifuThinButton2()
        Me.btn_gerir_funcionario = New ns1.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(108, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
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
        Me.btn_voltar.Location = New System.Drawing.Point(368, 0)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(67, 33)
        Me.btn_voltar.TabIndex = 30
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_agendar_sessao
        '
        Me.btn_agendar_sessao.ActiveBorderThickness = 1
        Me.btn_agendar_sessao.ActiveCornerRadius = 15
        Me.btn_agendar_sessao.ActiveFillColor = System.Drawing.Color.Black
        Me.btn_agendar_sessao.ActiveForecolor = System.Drawing.Color.White
        Me.btn_agendar_sessao.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_agendar_sessao.BackColor = System.Drawing.Color.LightGray
        Me.btn_agendar_sessao.BackgroundImage = CType(resources.GetObject("btn_agendar_sessao.BackgroundImage"), System.Drawing.Image)
        Me.btn_agendar_sessao.ButtonText = "AGENDAR SESSÕES"
        Me.btn_agendar_sessao.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_agendar_sessao.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agendar_sessao.ForeColor = System.Drawing.Color.White
        Me.btn_agendar_sessao.IdleBorderThickness = 1
        Me.btn_agendar_sessao.IdleCornerRadius = 20
        Me.btn_agendar_sessao.IdleFillColor = System.Drawing.Color.Black
        Me.btn_agendar_sessao.IdleForecolor = System.Drawing.Color.White
        Me.btn_agendar_sessao.IdleLineColor = System.Drawing.Color.White
        Me.btn_agendar_sessao.Location = New System.Drawing.Point(14, 188)
        Me.btn_agendar_sessao.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agendar_sessao.Name = "btn_agendar_sessao"
        Me.btn_agendar_sessao.Size = New System.Drawing.Size(159, 58)
        Me.btn_agendar_sessao.TabIndex = 29
        Me.btn_agendar_sessao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cadastrar_cliente
        '
        Me.btn_cadastrar_cliente.ActiveBorderThickness = 1
        Me.btn_cadastrar_cliente.ActiveCornerRadius = 15
        Me.btn_cadastrar_cliente.ActiveFillColor = System.Drawing.Color.Black
        Me.btn_cadastrar_cliente.ActiveForecolor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_cadastrar_cliente.BackColor = System.Drawing.Color.LightGray
        Me.btn_cadastrar_cliente.BackgroundImage = CType(resources.GetObject("btn_cadastrar_cliente.BackgroundImage"), System.Drawing.Image)
        Me.btn_cadastrar_cliente.ButtonText = "CADASTRAR CLIENTES"
        Me.btn_cadastrar_cliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_cadastrar_cliente.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_cliente.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.IdleBorderThickness = 1
        Me.btn_cadastrar_cliente.IdleCornerRadius = 20
        Me.btn_cadastrar_cliente.IdleFillColor = System.Drawing.Color.Black
        Me.btn_cadastrar_cliente.IdleForecolor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.IdleLineColor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.Location = New System.Drawing.Point(14, 120)
        Me.btn_cadastrar_cliente.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente"
        Me.btn_cadastrar_cliente.Size = New System.Drawing.Size(159, 58)
        Me.btn_cadastrar_cliente.TabIndex = 28
        Me.btn_cadastrar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_sair.Location = New System.Drawing.Point(441, 0)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(36, 33)
        Me.btn_sair.TabIndex = 27
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_gerir_funcionario
        '
        Me.btn_gerir_funcionario.ActiveBorderThickness = 1
        Me.btn_gerir_funcionario.ActiveCornerRadius = 15
        Me.btn_gerir_funcionario.ActiveFillColor = System.Drawing.Color.Black
        Me.btn_gerir_funcionario.ActiveForecolor = System.Drawing.Color.White
        Me.btn_gerir_funcionario.ActiveLineColor = System.Drawing.Color.Black
        Me.btn_gerir_funcionario.BackColor = System.Drawing.Color.LightGray
        Me.btn_gerir_funcionario.BackgroundImage = CType(resources.GetObject("btn_gerir_funcionario.BackgroundImage"), System.Drawing.Image)
        Me.btn_gerir_funcionario.ButtonText = "GERIR FUNCIONÁRIOS"
        Me.btn_gerir_funcionario.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_gerir_funcionario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerir_funcionario.ForeColor = System.Drawing.Color.White
        Me.btn_gerir_funcionario.IdleBorderThickness = 1
        Me.btn_gerir_funcionario.IdleCornerRadius = 20
        Me.btn_gerir_funcionario.IdleFillColor = System.Drawing.Color.Black
        Me.btn_gerir_funcionario.IdleForecolor = System.Drawing.Color.White
        Me.btn_gerir_funcionario.IdleLineColor = System.Drawing.Color.White
        Me.btn_gerir_funcionario.Location = New System.Drawing.Point(14, 256)
        Me.btn_gerir_funcionario.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_gerir_funcionario.Name = "btn_gerir_funcionario"
        Me.btn_gerir_funcionario.Size = New System.Drawing.Size(159, 58)
        Me.btn_gerir_funcionario.TabIndex = 31
        Me.btn_gerir_funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(293, 140)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(176, 162)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'frm_gerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(481, 336)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_gerir_funcionario)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_agendar_sessao)
        Me.Controls.Add(Me.btn_cadastrar_cliente)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_gerencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_gerencia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents btn_agendar_sessao As ns1.BunifuThinButton2
    Friend WithEvents btn_cadastrar_cliente As ns1.BunifuThinButton2
    Friend WithEvents btn_sair As ns1.BunifuThinButton2
    Friend WithEvents btn_gerir_funcionario As ns1.BunifuThinButton2
    Friend WithEvents PictureBox2 As PictureBox
End Class
