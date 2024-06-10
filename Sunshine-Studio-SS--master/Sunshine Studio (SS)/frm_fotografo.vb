Public Class frm_fotografo

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        usuario_ativo = ""
        Me.Hide()
        frm_login.Show()
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Application.Exit()
        End
    End Sub

    Private Sub frm_fotografo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dgv_fotografo()
    End Sub

End Class