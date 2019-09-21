'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb


Public Class cldBancoDados

    'Passa para variável StringConexao o valor do arquivo de configuração
    Dim StringConexao As String = My.Settings.Conexao.ToString
    'Função utilizada para abrir a conexão com o banco de dados
    Private Function AbreBanco() As OleDbConnection
        'Declara um Objeto de conexão
        Dim Conn As New OleDbConnection
        With Conn
            'Passa o valor da String de conexão e abre o banco de dados
            Conn.ConnectionString = StringConexao
            .Open()
        End With
        Return Conn
    End Function
    'Sub utilizada para fechar a conexão com o banco de dados
    Private Sub FechaBanco(ByVal Conn As OleDbConnection)
        'Verifica se a conexão do banco de dados está aberta
        If Conn.State = ConnectionState.Open Then
            'Fecha a conexão
            Conn.Close()
        End If
    End Sub
    'Função utilizada para executar comandos no banco de dados
    Public Sub ExecutaComando(ByVal strQuery As String)
        'Cria o objeto de conexão
        Dim Conn As New OleDbConnection()
        Try
            'Abre o banco de dados
            Conn = AbreBanco()

            'Cria o objeto de Comando
            Dim cmdComando As New OleDbCommand
            With cmdComando
                'passa os valores da Query SQL, tipo do comando, conexão e executa o comando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
                .ExecuteNonQuery()
            End With
            'Tratamento de excessões
        Catch ex As Exception
            Throw ex
        Finally
            'Em caso de erro ou não, o finally é executado para fechar a conexão com o banco de dados
            FechaBanco(Conn)
        End Try
    End Sub

    'Função utilizada para executar comandos com algum retorno do tipo Integer
    Public Function ExecutaComandoRetorno(ByVal strQuery As String) As Integer
        'cria o objeto de conexão
        Dim Conn As New OleDbConnection()
        'Declara um novo DataReader
        Dim dr As OleDbDataReader
        Try
            'Abre a conexão com obanco de dados
            Conn = AbreBanco()

            'Cria o objeto de Comando
            Dim cmdComando As New OleDbCommand
            With cmdComando
                'passa os valores da Query SQL, tipo do comando, conexão e executao comando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
                .ExecuteNonQuery()

                'Cria uma nova Query, que busca o valor do Identity gerado pelo banco de dados
                .CommandText = "Select @@Identity"
                'Executa a leitura do comando
                dr = .ExecuteReader()
            End With
            'lê o Data Reader
            dr.Read()
            'Retorna o valor
            Return dr(0)
            'Tratamento de excessões
        Catch ex As Exception
            Throw ex
        Finally
            'Em caso de erro ou não, o finally é executado para fechar a conexão com o banco de dados
            FechaBanco(Conn)
        End Try
    End Function
    'Função utilizada para retornar um DataSet a partir de uma Query SQL
    Public Function RetornaDataSet(ByVal strQuery As String) As DataSet
        'Cria o objeto de conexão
        Dim Conn As New OleDbConnection()
        Try
            'Abre a conexão com o banco de dados
            Conn = AbreBanco()
            'Cria o objeto de comando
            Dim cmdComando As New OleDbCommand
            With cmdComando
                'passa os valores da Query SQL, tipo do comando, conexão e executa o comando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn

            End With
            'Declara um DataAdapter
            Dim daAdaptador As New OleDbDataAdapter
            'Declara um DataSEt
            Dim dsDataSet As New DataSet

            'passa o comando a ser executado pelo DataAdapter
            daAdaptador.SelectCommand = cmdComando
            'O DataAdapter faz a conexão com o banco de dados, carrega o DataSet e fecha a conexão
            daAdaptador.Fill(dsDataSet)
            'retorna o DataSet carregado
            Return dsDataSet
            'Tratamento de excessões
        Catch ex As Exception
            Throw ex
        Finally
            'Em caso de erro ou não, o finally é executado para fechar a conexão com o banco de dados
            FechaBanco(Conn)
        End Try
    End Function
    'Função utilizada para retornar um DataReader a partir de uma Query Sql
    Public Function RetornaDataReader(ByVal strQuery As String) As OleDbDataReader
        'Cria o objeto de conexão
        Dim Conn As New OleDbConnection()
        Try
            'Abre a conexão com o banco de dados
            Conn = AbreBanco()
            'Cria o objeto de comando
            Dim CmdComando As New OleDbCommand
            With CmdComando
                'passa os valores da Query SQL, tipo do comando, conexão e executa o comando
                .CommandText = strQuery
                .CommandType = CommandType.Text
                .Connection = Conn
            End With

            'Retorna o comando executando a leitura
            Return CmdComando.ExecuteReader
            'Tratamento de excessões
        Catch ex As Exception
            Throw ex

        End Try
    End Function

End Class
