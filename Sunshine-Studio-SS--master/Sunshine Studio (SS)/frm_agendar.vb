Imports System
Imports System.Data
Imports System.Globalization


Public Class frm_agendar



    Dim horariosDisponiveis As String() = {"10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00"}


    Private Sub frm_agendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dgv_sessoes()
        carregar_clientes()
        carregar_horarios()
        carregar_fotografos()
        cmb_parcelado.Enabled = False

    End Sub

    Private Sub data_agenda_onValueChanged(sender As Object, e As EventArgs) Handles data_agenda.onValueChanged
        carregar_horarios()
    End Sub

    Sub carregar_clientes()
        sql = "select id, nome from tb_clientes order by nome asc"
        rs = db.Execute(sql)
        Dim item As String

        Do While Not rs.EOF
            item = rs.Fields(0).Value.ToString() & " - " & rs.Fields(1).Value.ToString
            cmb_clientes.AddItem(item)
            rs.MoveNext()
        Loop
    End Sub

    Sub carregar_horarios()
        Dim data As Date = data_agenda.Value
        Dim horariosFiltrados As New List(Of TimeSpan)
        Dim horariosDisponiveisFiltrados As New List(Of String)

        sql = "SELECT horario FROM tb_sessoes WHERE dia = '" & data & "'"
        rs = db.Execute(sql)

        Do While Not rs.EOF
            Dim horarioValue As Object = rs.Fields("horario").Value
            If Not IsDBNull(horarioValue) Then
                Dim horario As TimeSpan
                If TimeSpan.TryParse(horarioValue.ToString(), horario) Then ' Converter para TimeSpan com TryParse
                    horariosFiltrados.Add(horario)
                End If
            End If
            rs.MoveNext()
        Loop

        ' Filtrar os horários disponíveis
        horariosDisponiveisFiltrados = horariosDisponiveis.Where(Function(h) Not horariosFiltrados.Any(Function(hf) hf.ToString("hh\:mm") = h)).ToList()

        cmb_horario.Clear()
        For Each horario In horariosDisponiveisFiltrados
            cmb_horario.AddItem(horario)
        Next
    End Sub

    Sub carregar_fotografos()
        sql = "select nome from tb_cadastro WHERE cargo = 'FOTÓGRAFO'"
        rs = db.Execute(sql)
        Do While Not rs.EOF
            Dim fotografo As String = rs.Fields(0).Value.ToString()
            cmb_fotografo.AddItem(fotografo)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub txt_valor_OnValueChanged(sender As Object, e As EventArgs) Handles txt_valor.OnValueChanged
        If cmb_planos.ToString = "Bronze" Then
            txt_valor.Text = "R$ 250,00"

        ElseIf cmb_planos.ToString = "Silver" Then
            txt_valor.Text = "R$ 450,00"

        ElseIf cmb_planos.ToString = "Gold" Then
            txt_valor.Text = "R$ 550,00"

        End If
    End Sub

    Private Sub cmb_pagamento_onItemSelected(sender As Object, e As EventArgs) Handles cmb_pagamento.onItemSelected
        If cmb_pagamento.selectedValue() = "Crédito" Then
            cmb_parcelado.Enabled = True
        Else
            cmb_parcelado.Enabled = False
        End If

    End Sub

    Private Sub cmb_planos_onItemSelected(sender As Object, e As EventArgs) Handles cmb_planos.onItemSelected
        If cmb_planos.selectedValue = "Bronze" Then
            txt_valor.Text = "R$ 250,00"
            txt_valor.Enabled = False

        ElseIf cmb_planos.selectedValue = "Silver" Then
            txt_valor.Text = "R$ 450,00"
            txt_valor.Enabled = False

        ElseIf cmb_planos.selectedValue = "Gold" Then
            txt_valor.Text = "R$ 550,00"
            txt_valor.Enabled = False

        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        If cargo_ativo = "GERENCIA" Then
            Me.Hide()
            frm_gerencia.Show()
        Else
            Me.Hide()
            frm_recepcao.Show()
        End If

    End Sub

    Private Sub btn_agendar_Click(sender As Object, e As EventArgs) Handles btn_agendar.Click
        Try
            sql = "select * from tb_sessoes where dia= '" & data_agenda.Value.Date & "' and horario= '" & cmb_horario.selectedValue & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir o cpf no banco
                Dim valorTexto As String = txt_valor.Text.Replace("R$ ", "").Replace(",00", "")
                sql = "update tb_sessoes set dia='" & data_agenda.Value.Date & "', " &
                                             "nome_fotografo='" & cmb_fotografo.selectedValue & "', " &
                                             "valor='" & CDec(valorTexto) & "', " &
                                             "horario='" & cmb_horario.selectedValue.ToString() & "' WHERE cpf_clientes ='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else 'Se não existir CPF no banco
                Dim id As Integer
                id = ObterProximoID()
                Dim valorTexto As String = txt_valor.Text.Replace("R$ ", "").Replace(",00", "")

                sql = "INSERT INTO tb_sessoes VALUES ('" & id & "', " &
                                                  "'" & txt_cpf.Text & "', " &
                                                  "'" & cmb_clientes.selectedValue & "', " &
                                                  "'" & txt_telefone.Text & "', " &
                                                  "'" & data_agenda.Value.Date & "', " &
                                                  "'" & cmb_horario.selectedValue.ToString() & "', " &
                                                  "'" & cmb_fotografo.selectedValue & "', " &
                                                  "'" & CDec(valorTexto) & "', " &
                                                   "'" & cmb_pagamento.selectedValue & "')"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_cpf.Text = ""
                txt_telefone.Text = ""
                data_agenda.Value = Now
                cmb_clientes.Clear()
                carregar_clientes()
                cmb_horario.Clear()
                carregar_horarios()
                cmb_fotografo.Clear()
                carregar_fotografos()



            End If
            carregar_dgv_sessoes()
        Catch ex As Exception
            MsgBox("Não foi possível cadastrar!" + ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção!")
        End Try
    End Sub

    Private Function ObterSequenciaAntesDoEspaco(ByVal texto As String) As String
        Dim indiceEspaco As Integer = texto.IndexOf(" ")
        If indiceEspaco >= 0 Then
            Return texto.Substring(0, indiceEspaco)
        Else
            Return texto ' Retorna o texto original se não houver espaço
        End If
    End Function

    Private Sub cmb_clientes_onItemSelected(sender As Object, e As EventArgs) Handles cmb_clientes.onItemSelected
        Dim textoComboBox As String = cmb_clientes.selectedValue.ToString()
        Dim sequencia As String = ObterSequenciaAntesDoEspaco(textoComboBox)
        sql = "select cpf_clientes, celular from tb_clientes WHERE id='" & sequencia & "'"
        rs = db.Execute(sql)
        txt_cpf.Text = rs.Fields(0).Value.ToString()
        txt_cpf.Enabled = False
        txt_telefone.Text = rs.Fields(1).Value.ToString()
        txt_telefone.Enabled = False
    End Sub

    Private Sub dgv_dados_sessoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_sessoes.CellContentClick

        Try
            With dgv_dados_sessoes
                If .CurrentRow.Cells(4).Selected = True Then ' se o campo excluir estiver selecionado
                    aux_cpf = .CurrentRow.Cells(0).Value
                    sql = "delete from tb_sessoes where dia='" & .CurrentRow.Cells(0).Value & "' and horario='" & .CurrentRow.Cells(1).Value & "'"
                    rs = db.Execute(sql)
                    carregar_dgv_sessoes()
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar a ação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Public Function ObterProximoID() As Integer
        Dim proximoID As Integer = 0
        sql = "SELECT COALESCE(MAX(id_sessao), 0) + 1 AS ProximoID FROM tb_sessoes"
        rs = db.Execute(sql)
        proximoID = CInt(rs.Fields(0).Value)
        Return proximoID
    End Function

End Class