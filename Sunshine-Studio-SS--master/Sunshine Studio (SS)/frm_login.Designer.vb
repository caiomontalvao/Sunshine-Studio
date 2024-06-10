<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.check_Senha = New System.Windows.Forms.CheckBox()
        Me.txt_login = New ns1.BunifuMaterialTextbox()
        Me.txt_senha = New ns1.BunifuMaterialTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_incorreto = New System.Windows.Forms.Label()
        Me.lbl_bloqueado = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Stencil", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SENHA"
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Black
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_sair.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(265, 11)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(57, 24)
        Me.btn_sair.TabIndex = 5
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Black
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_login.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(114, 367)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(103, 32)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Acessar"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'check_Senha
        '
        Me.check_Senha.AutoSize = True
        Me.check_Senha.Location = New System.Drawing.Point(60, 345)
        Me.check_Senha.Name = "check_Senha"
        Me.check_Senha.Size = New System.Drawing.Size(93, 17)
        Me.check_Senha.TabIndex = 9
        Me.check_Senha.Text = "Mostrar senha"
        Me.check_Senha.UseVisualStyleBackColor = True
        '
        'txt_login
        '
        Me.txt_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_login.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_login.HintForeColor = System.Drawing.Color.Empty
        Me.txt_login.HintText = ""
        Me.txt_login.isPassword = False
        Me.txt_login.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_login.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_login.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_login.LineThickness = 3
        Me.txt_login.Location = New System.Drawing.Point(57, 221)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(205, 27)
        Me.txt_login.TabIndex = 10
        Me.txt_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_senha
        '
        Me.txt_senha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_senha.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_senha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_senha.HintForeColor = System.Drawing.Color.Empty
        Me.txt_senha.HintText = ""
        Me.txt_senha.isPassword = True
        Me.txt_senha.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_senha.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_senha.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_senha.LineThickness = 3
        Me.txt_senha.Location = New System.Drawing.Point(57, 299)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(205, 27)
        Me.txt_senha.TabIndex = 11
        Me.txt_senha.Text = "Senha"
        Me.txt_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(57, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lbl_incorreto
        '
        Me.lbl_incorreto.AutoSize = True
        Me.lbl_incorreto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.lbl_incorreto.ForeColor = System.Drawing.Color.Red
        Me.lbl_incorreto.Location = New System.Drawing.Point(57, 328)
        Me.lbl_incorreto.Name = "lbl_incorreto"
        Me.lbl_incorreto.Size = New System.Drawing.Size(119, 12)
        Me.lbl_incorreto.TabIndex = 12
        Me.lbl_incorreto.Text = "Usuário ou senha incorretos"
        '
        'lbl_bloqueado
        '
        Me.lbl_bloqueado.AutoSize = True
        Me.lbl_bloqueado.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.lbl_bloqueado.ForeColor = System.Drawing.Color.Red
        Me.lbl_bloqueado.Location = New System.Drawing.Point(57, 328)
        Me.lbl_bloqueado.Name = "lbl_bloqueado"
        Me.lbl_bloqueado.Size = New System.Drawing.Size(81, 12)
        Me.lbl_bloqueado.TabIndex = 13
        Me.lbl_bloqueado.Text = "Usuário bloqueado"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(332, 427)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_bloqueado)
        Me.Controls.Add(Me.lbl_incorreto)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.check_Senha)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_sair As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents check_Senha As CheckBox
    Friend WithEvents txt_login As ns1.BunifuMaterialTextbox
    Friend WithEvents txt_senha As ns1.BunifuMaterialTextbox
    Friend WithEvents lbl_incorreto As Label
    Friend WithEvents lbl_bloqueado As Label
End Class
