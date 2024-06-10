Public Class frm_login
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Verificar as credenciais usando os valores dos campos de texto
        Dim usuario As String = txt_login.Text
        Dim senha As String = txt_senha.Text

        If txt_login.Text = "admin" And txt_senha.Text = "admin" Then
            cargo_ativo = "GERENCIA"
            frm_gerencia.Show()
            Me.Hide()
        Else
            sql = "select * from tb_cadastro where usuario='" & usuario & "' and senha='" & senha & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then

                If rs.Fields(7).Value = "BLOQUEADO" Then
                    lbl_bloqueado.Show()

                ElseIf rs.Fields(8).Value = "RECEPÇÃO" Then 'as informações de login estão corretas
                    cargo_ativo = "RECEPÇÃO"
                    frm_recepcao.Show()
                    Me.Hide()

                ElseIf rs.Fields(8).Value = "FOTÓGRAFO" Then 'as informações de login estão corretas
                    usuario_ativo = usuario
                    carregar_dgv_fotografo()
                    frm_fotografo.Show()
                    Me.Hide()

                ElseIf rs.Fields(8).Value = "GERENCIA" Then 'as informações de login estão corretas
                    cargo_ativo = "GERENCIA"
                    frm_gerencia.Show()
                    Me.Hide()
                End If

            Else 'as informações de login estão incorretas
                lbl_incorreto.Show()
            End If

        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        conecta_banco_sqlserver()
        lbl_incorreto.Hide()
        lbl_bloqueado.Hide()
    End Sub

    Private Sub Check_Senha_CheckedChanged(sender As Object, e As EventArgs) Handles check_Senha.CheckedChanged
        If check_Senha.Checked Then
            txt_senha.isPassword = False
        Else
            txt_senha.isPassword = True
        End If
    End Sub

    Private Sub txt_senha_Enter(sender As Object, e As EventArgs) Handles txt_senha.Enter
        If txt_senha.Text = "Senha" Then
            txt_senha.Text = String.Empty
            txt_senha.isPassword = True

        End If
    End Sub

    Private Sub txt_login_OnValueChanged(sender As Object, e As EventArgs) Handles txt_login.OnValueChanged
        lbl_incorreto.Hide()
        lbl_bloqueado.Hide()
    End Sub

    Private Sub txt_senha_OnValueChanged(sender As Object, e As EventArgs) Handles txt_senha.OnValueChanged
        lbl_incorreto.Hide()
        lbl_bloqueado.Hide()
    End Sub
End Class