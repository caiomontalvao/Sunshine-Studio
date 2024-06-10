Public Class frm_gerenciamentoContas


    Private Sub frm_gerenciamentoContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(4).Selected = True Then ' se o campo editar estiver selecionado
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "Select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        cmb_data_nasc.Text = rs.Fields(3).Value
                        txt_celular.Text = rs.Fields(4).Value
                        txt_email.Text = rs.Fields(2).Value
                        txt_usuario.Text = rs.Fields(5).Value
                        txt_def_senha.Text = rs.Fields(6).Value
                        Dim valorCargo As String
                        valorCargo = rs.Fields(8).Value
                        cont = cmb_cargo.FindString(valorCargo)
                        cmb_cargo.SelectedIndex = cont
                        txt_cpf.Enabled = False
                    End If
                    'ElseIf .CurrentRow.Cells(4).Selected = True Then 'se o campo excluir estiver selecionado
                    ' aux_cpf = .CurrentRow.Cells(0).Value
                    ' sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    ' rs = db.Execute(sql)
                    ' If rs.EOF = False Then
                    'resp = MsgBox("Deseja realmente excluir o" + vbNewLine &
                    '               "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    'If resp = MsgBoxResult.Yes Then
                    'sql = "delete from tb_cadastro where cpf ='" & aux_cpf & "'"
                    'rs = db.Execute(sql)
                    'carregar_dados()
                    'txt_cpf.Clear()
                    'txt_nome.Clear()
                    'txt_email.Clear()
                    'txt_celular.Clear()
                    'txt_usuario.Clear()
                    'txt_def_senha.Clear()
                    'txt_cpf.Focus()
                    'End If
                    'End If
                ElseIf .CurrentRow.Cells(5).Selected = True Then 'se o campo status estiver selecionado
                    If .CurrentRow.Cells(5).Value = "ATIVO" Then
                        .CurrentRow.Cells(5).Value = "BLOQUEADO"
                        aux_cpf = .CurrentRow.Cells(0).Value
                        sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            sql = "update tb_cadastro set status='" & .CurrentRow.Cells(5).Value & "' WHERE CPF ='" & aux_cpf & "'"
                            rs = db.Execute(sql)
                        End If
                        carregar_dados()
                    Else
                        .CurrentRow.Cells(5).Value = "ATIVO"
                        aux_cpf = .CurrentRow.Cells(0).Value
                        sql = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            sql = "update tb_cadastro set status='" & .CurrentRow.Cells(5).Value & "' WHERE CPF ='" & aux_cpf & "'"
                            rs = db.Execute(sql)
                        End If
                        carregar_dados()
                    End If
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar a ação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        frm_gerencia.Show()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click

        If txt_celular.Text = "" Or txt_cpf.Text = "" Or txt_def_senha.Text = "" Or txt_email.Text = "" Or txt_nome.Text = "" Or txt_usuario.Text = "" Or cmb_cargo.SelectedIndex = -1 Then
            MsgBox("Existem campos em branco", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            Try
                sql = "select * from tb_cadastro where cpf= '" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then 'Se existir o cpf no banco
                    Dim cargo As String
                    cargo = cmb_cargo.Items(cmb_cargo.SelectedIndex).ToString
                    sql = "update tb_cadastro set nome='" & txt_nome.Text & "', " &
                                                 "email='" & txt_email.Text & "', " &
                                                 "data_nasc='" & cmb_data_nasc.Value.Date & "', " &
                                                 "celular='" & txt_celular.Text & "', " &
                                                 "usuario='" & txt_usuario.Text & "', " &
                                                 "senha='" & txt_def_senha.Text & "', " &
                                                 "cargo='" & cargo & "' WHERE CPF ='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cpf.Enabled = True
                    txt_cpf.Clear()
                    txt_nome.Clear()
                    txt_email.Clear()
                    txt_celular.Clear()
                    txt_usuario.Clear()
                    txt_def_senha.Clear()
                    txt_cpf.Focus()
                    cmb_data_nasc.Value = Date.Now
                Else
                    Dim cargo As String
                    cargo = cmb_cargo.Items(cmb_cargo.SelectedIndex).ToString
                    sql = "INSERT INTO tb_cadastro VALUES ('" & txt_cpf.Text & "', " &
                                                      "'" & txt_nome.Text & "', " &
                                                      "'" & txt_email.Text & "', " &
                                                      "'" & cmb_data_nasc.Value.Date & "', " &
                                                      "'" & txt_celular.Text & "', " &
                                                      "'" & txt_usuario.Text & "', " &
                                                      "'" & txt_def_senha.Text & "', " &
                                                      "'ATIVO', " &
                                                      "'" & cargo & "')"

                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cpf.Clear()
                    txt_nome.Clear()
                    txt_email.Clear()
                    txt_celular.Clear()
                    txt_usuario.Clear()
                    txt_def_senha.Clear()
                    txt_cpf.Focus()
                End If
                carregar_dados()
            Catch ex As Exception
                MsgBox("Não foi possível cadastrar!" + ex.Message + txt_celular.Text, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
            End Try
        End If

    End Sub

End Class