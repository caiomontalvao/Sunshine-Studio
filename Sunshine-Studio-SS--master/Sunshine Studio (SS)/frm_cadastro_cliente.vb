Public Class frm_cadastro_cliente
    Private Sub frm_cadastro_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dgv_clientes()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        If frm_gerencia.Visible = True Then
            Me.Hide()

        Else
            Me.Hide()
            frm_recepcao.Show()
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If txt_celular.Text = "" Or txt_cpf.Text = "" Or txt_email.Text = "" Or txt_endereco.Text = "" Or txt_nome.Text = "" Then
            MsgBox("Existem campos em branco", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

        Else
            Try
                sql = "select * from tb_clientes where cpf_clientes= '" & txt_cpf.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then 'Se existir o cpf no banco
                    sql = "update tb_clientes set nome='" & txt_nome.Text & "', " &
                                                 "email='" & txt_email.Text & "', " &
                                                 "data_nasc='" & data_nascimento.Value.Date & "', " &
                                                 "celular='" & txt_celular.Text & "', " &
                                                 "endereco='" & txt_endereco.Text & "' WHERE cpf_clientes ='" & txt_cpf.Text & "'"
                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cpf.Enabled = True
                    txt_cpf.Text = ""
                    txt_nome.Text = ""
                    txt_email.Text = ""
                    txt_celular.Text = ""
                    txt_endereco.Text = ""
                    data_nascimento.Value = Date.Now


                Else 'Se não existir CPF no banco
                    Dim id As Integer
                    id = ObterProximoID()
                    sql = "INSERT INTO tb_clientes VALUES ('" & txt_cpf.Text & "', " &
                                                      "'" & id & "', " &
                                                      "'" & txt_nome.Text & "', " &
                                                      "'" & txt_email.Text & "', " &
                                                      "'" & txt_endereco.Text & "', " &
                                                      "'" & data_nascimento.Value.Date & "', " &
                                                      "'" & txt_celular.Text & "', " &
                                                      "'ATIVO' )"

                    rs = db.Execute(UCase(sql))
                    MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    txt_cpf.Clear()
                    txt_nome.Text = ""
                    txt_email.Text = ""
                    txt_endereco.Text = ""
                    txt_celular.Clear()
                    data_nascimento.Value = Now
                    txt_nome.Focus()
                End If
                carregar_dgv_clientes()
            Catch ex As Exception
                MsgBox("Não foi possível cadastrar!" + ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
            End Try
        End If
    End Sub
    Public Function ObterProximoID() As Integer
        Dim proximoID As Integer = 0
        sql = "SELECT COALESCE(MAX(id), 0) + 1 AS ProximoID FROM tb_clientes"
        rs = db.Execute(sql)
        proximoID = CInt(rs.Fields(0).Value)
        Return proximoID
    End Function

    Private Sub dgv_dados_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_clientes.CellContentClick
        Try
            With dgv_dados_clientes
                If .CurrentRow.Cells(4).Selected = True Then ' se o campo editar estiver selecionado
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "Select * from tb_clientes where id='" & aux_cpf & "'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(2).Value
                        data_nascimento.Value = rs.Fields(5).Value.ToString()
                        txt_celular.Text = rs.Fields(6).Value
                        txt_email.Text = rs.Fields(3).Value
                        txt_endereco.Text = rs.Fields(4).Value
                        txt_cpf.Enabled = False
                    End If

                ElseIf .CurrentRow.Cells(5).Selected = True Then 'se o campo status estiver selecionado
                    If .CurrentRow.Cells(5).Value = "ATIVO" Then
                        .CurrentRow.Cells(5).Value = "BLOQUEADO"
                        aux_cpf = .CurrentRow.Cells(0).Value
                        sql = "select * from tb_clientes where id='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            sql = "update tb_clientes set status='" & .CurrentRow.Cells(5).Value & "' WHERE id ='" & aux_cpf & "'"
                            rs = db.Execute(sql)
                        End If
                        carregar_dados()
                    Else
                        .CurrentRow.Cells(5).Value = "ATIVO"
                        aux_cpf = .CurrentRow.Cells(0).Value
                        sql = "select * from tb_clientes where id='" & aux_cpf & "'"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            sql = "update tb_clientes set status='" & .CurrentRow.Cells(5).Value & "' WHERE id ='" & aux_cpf & "'"
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
End Class