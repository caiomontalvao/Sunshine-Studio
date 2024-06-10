Public Class frm_recepcao
    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub btn_agendar_sessao_Click(sender As Object, e As EventArgs) Handles btn_agendar_sessao.Click
        carregar_dgv_sessoes()
        Me.Hide()
        frm_agendar.Show()
    End Sub


    Private Sub btn_cadastrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_cliente.Click
        carregar_dgv_clientes()
        Me.Hide()
        frm_cadastro_cliente.Show()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
        End
    End Sub
End Class