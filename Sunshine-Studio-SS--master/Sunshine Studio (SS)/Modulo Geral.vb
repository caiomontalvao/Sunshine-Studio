Imports System.Data.SqlClient

Module Modulo_Geral
    'Public diretorio As String 'Variável da foto do cliente openfiledialog1
    Public db As New ADODB.Connection 'Variável global do banco
    Public rs As New ADODB.Recordset 'Variável da tabela do banco
    Public sql, aux_cpf, resp As String 'Querys CRUD linguagem SQL
    Public cont As Integer
    Public usuario_ativo As String
    Public cargo_ativo As String
    Sub conecta_banco_sqlserver()
        'String de conexão ADO
        Try
            db = CreateObject("ADODB.Connection")
            db.Open(ConnectionString:="Provider=SQLOLEDB;Data Source=DESKTOP-98PO9Q2;Initial Catalog=agencia_foto;User Id=me;Password=1234;trusted_connection=yes;")
        Catch ex As Exception
            MsgBox("Erro de Conexão" + ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            sql = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(sql)
            With frm_gerenciamentoContas.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(4).Value, rs.Fields(8).Value, "editar", rs.Fields(7).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dgv_clientes()
        Try
            sql = "select * from tb_clientes order by nome asc"
            rs = db.Execute(sql)
            With frm_cadastro_cliente.dgv_dados_clientes
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(6).Value, "editar", rs.Fields(7).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dgv_sessoes()
        Try
            sql = "select * from tb_sessoes order by nome_cliente asc"
            rs = db.Execute(sql)
            With frm_agendar.dgv_dados_sessoes
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(2).Value, rs.Fields(7).Value, "excluir")
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dgv_fotografo()
        Try
            sql = "SELECT * from tb_sessoes WHERE nome_fotografo = (SELECT nome FROM tb_cadastro WHERE usuario = '" & usuario_ativo & "')"
            rs = db.Execute(sql)
            With frm_fotografo.dgv_fotografo
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(7).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


End Module