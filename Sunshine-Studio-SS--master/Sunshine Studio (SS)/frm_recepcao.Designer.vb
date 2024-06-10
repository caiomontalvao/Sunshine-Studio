<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recepcao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recepcao))
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.btn_agendar_sessao = New ns1.BunifuThinButton2()
        Me.btn_cadastrar_cliente = New ns1.BunifuThinButton2()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_voltar = New ns1.BunifuThinButton2()
        Me.btn_sair = New ns1.BunifuThinButton2()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(135, 31)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(405, 42)
        Me.BunifuCustomLabel1.TabIndex = 17
        Me.BunifuCustomLabel1.Text = "ESCOLHA UMA OPÇÃO"
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
        Me.btn_agendar_sessao.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agendar_sessao.ForeColor = System.Drawing.Color.White
        Me.btn_agendar_sessao.IdleBorderThickness = 1
        Me.btn_agendar_sessao.IdleCornerRadius = 20
        Me.btn_agendar_sessao.IdleFillColor = System.Drawing.Color.Black
        Me.btn_agendar_sessao.IdleForecolor = System.Drawing.Color.White
        Me.btn_agendar_sessao.IdleLineColor = System.Drawing.Color.White
        Me.btn_agendar_sessao.Location = New System.Drawing.Point(359, 221)
        Me.btn_agendar_sessao.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_agendar_sessao.Name = "btn_agendar_sessao"
        Me.btn_agendar_sessao.Size = New System.Drawing.Size(170, 61)
        Me.btn_agendar_sessao.TabIndex = 20
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
        Me.btn_cadastrar_cliente.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_cliente.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.IdleBorderThickness = 1
        Me.btn_cadastrar_cliente.IdleCornerRadius = 20
        Me.btn_cadastrar_cliente.IdleFillColor = System.Drawing.Color.Black
        Me.btn_cadastrar_cliente.IdleForecolor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.IdleLineColor = System.Drawing.Color.White
        Me.btn_cadastrar_cliente.Location = New System.Drawing.Point(359, 139)
        Me.btn_cadastrar_cliente.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_cadastrar_cliente.Name = "btn_cadastrar_cliente"
        Me.btn_cadastrar_cliente.Size = New System.Drawing.Size(170, 72)
        Me.btn_cadastrar_cliente.TabIndex = 19
        Me.btn_cadastrar_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(304, 277)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(138, 106)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 32
        Me.PictureBox3.TabStop = False
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
        Me.btn_voltar.Location = New System.Drawing.Point(475, -1)
        Me.btn_voltar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(67, 33)
        Me.btn_voltar.TabIndex = 34
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
        Me.btn_sair.Location = New System.Drawing.Point(548, -1)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(36, 33)
        Me.btn_sair.TabIndex = 33
        Me.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_recepcao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(590, 339)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.btn_agendar_sessao)
        Me.Controls.Add(Me.btn_cadastrar_cliente)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_recepcao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_recepcao"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_agendar_sessao As ns1.BunifuThinButton2
    Friend WithEvents btn_cadastrar_cliente As ns1.BunifuThinButton2
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_voltar As ns1.BunifuThinButton2
    Friend WithEvents btn_sair As ns1.BunifuThinButton2
End Class
