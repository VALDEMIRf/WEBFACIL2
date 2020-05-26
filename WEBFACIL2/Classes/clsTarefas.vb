'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text
Public Class clsTarefas
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados

    Private _tarefas_id As Integer
    Public Property tarefas_id() As Integer
        Get
            Return _tarefas_id
        End Get
        Set(ByVal value As Integer)
            _tarefas_id = value
        End Set
    End Property

    Private _tarefa As String
    Public Property tarefa() As String
        Get
            Return _tarefa
        End Get
        Set(ByVal value As String)
            _tarefa = value
        End Set
    End Property

    Private _responsavel As String
    Public Property responsavel() As String
        Get
            Return _responsavel
        End Get
        Set(ByVal value As String)
            _responsavel = value
        End Set
    End Property




    Private _dtConclusao As DateTime

    Public Property dtConclusao() As DateTime
        Get
            Return _dtConclusao
        End Get
        Set(ByVal value As DateTime)
            _dtConclusao = value
        End Set
    End Property

    Private _DtCadastro As DateTime

    Public Property DtCadastro() As DateTime
        Get
            Return _DtCadastro
        End Get
        Set(ByVal value As DateTime)
            _DtCadastro = value
        End Set
    End Property



    Private _Ativo As Boolean
    Public Property Ativo() As Boolean
        Get
            Return _Ativo
        End Get
        Set(ByVal value As Boolean)
            _Ativo = value
        End Set
    End Property

    Private _obs As String
    Public Property obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property



    'MÉTODO QUE GRAVA DADOS PESSOA FÍSICA
    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO tbTarefas(tarefa,responsavel,DtCadastro,dtConclusao,Ativo,obs) VALUES(?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@tarefa", _tarefa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@responsavel", _responsavel))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DtCadastro", _DtCadastro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@dtConclusao", _dtConclusao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Ativo", _Ativo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@obs", _obs))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Operação realizada com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using
    End Sub


    'METODO QUE ALTERA DADOS PESSOA FÍSICA
    Public Sub AlterarDados()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE tbTarefas SET tarefa=?,responsavel=?,DtCadastro=?,DtConclusao=?,Ativo=?,obs=? WHERE tarefas_id=" & CInt(tarefas_id)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@tarefa", _tarefa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@responsavel", _responsavel))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DtCadastro", _DtCadastro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@dtConclusao", _dtConclusao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@Ativo", _Ativo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@obs", _obs))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Operação de alteração realizada com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using

    End Sub


    Public Function Lista(ByVal strDescricao As String) As DataSet
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT * ")
        strQuery.Append(" FROM tbTarefas ")

        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE Ativo like '%" & strDescricao & "%'")
        End If

        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Function ListaTarefas(ByVal intCodigo As Integer) As OleDbDataReader
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT tarefa,responsavel,DtCadastro,dtConclusao,Ativo,obs ")
        strQuery.Append(" FROM tbTarefas ")
        strQuery.Append(" WHERE tarefas_id = " & intCodigo & " ")

        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataReader(strQuery.ToString)
    End Function

    Public Sub Excluir(ByVal intCodigo As Integer)
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM tbTarefas ")
        strQuery.Append(" WHERE tarefas_id = " & intCodigo & "")

        'Executa o método ExecutaComando da classe de banco de dados
        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub


    Function ListTarefa(ByVal p1 As String) As DataSet

        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT tarefa,responsavel,DtCadastro,dtConclusao,Ativo,obs ")
        strQuery.Append(" FROM tbTarefas WHERE tarefa like '%" & p1 & "%' ")


        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function


End Class
