'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text

Public Class clsCPFVinculado
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados

    Private _vinc_id As Integer
    Public Property vinc_id() As Integer
        Get
            Return _vinc_id
        End Get
        Set(ByVal value As Integer)
            _vinc_id = value
        End Set
    End Property

    Private _clsCliente As clsCliente
    Public Property clsCliente() As clsCliente
        Get
            Return _clsCliente
        End Get
        Set(ByVal value As clsCliente)
            _clsCliente = value
        End Set
    End Property

    Private _vinc_nome As String
    Public Property vinc_nome() As String
        Get
            Return _vinc_nome
        End Get
        Set(ByVal value As String)
            _vinc_nome = value
        End Set
    End Property

    Private _vinc_CPF As String
    Public Property vinc_CPF() As String
        Get
            Return _vinc_CPF
        End Get
        Set(ByVal value As String)
            _vinc_CPF = value
        End Set
    End Property

    Private _vinc_vinculo As String
    Public Property vinc_vinculo() As String
        Get
            Return _vinc_vinculo
        End Get
        Set(ByVal value As String)
            _vinc_vinculo = value
        End Set
    End Property

    Private _vinc_lblVincID As Integer
    Public Property vinc_lblVincID() As Integer
        Get
            Return _vinc_lblVincID
        End Get
        Set(ByVal value As Integer)
            _vinc_lblVincID = value
        End Set
    End Property

    Public Sub GravarDados()
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO tbCPFVinculado ")
        strQuery.Append(" ( ")
        strQuery.Append(" cli_id ")
        strQuery.Append(", vinc_nome ")
        strQuery.Append(", vinc_CPF ")
        strQuery.Append(", vinc_vinculo ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" " & _vinc_lblVincID & " ")
        strQuery.Append(", '" & _vinc_nome & "' ")
        strQuery.Append(", '" & _vinc_CPF & "' ")
        strQuery.Append(", '" & _vinc_vinculo & "' ")
        strQuery.Append(" ); ")

        'Executa o método ExecutaComando da classe de banco de dados
        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

        'Using con As OleDbConnection = GetConnection()
        '    Try
        '        con.Open() '
        '        Dim sql As String = "INSERT INTO tbCPFVinculado(cli_id,vinc_nome,vinc_CPF,vinc_vinculo) VALUES(?,?,?,?)"
        '        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_id", _vinc_lblVincID))
        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_nome", _vinc_nome))
        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_CPF", _vinc_CPF))
        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_vinculo", _vinc_vinculo))
        '        cmd.ExecuteNonQuery()
        '        MessageBox.Show("Operação realizada com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    Catch ex As Exception
        '        MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        MsgBox(ex.Message.ToString)
        '    Finally
        '        con.Close()
        '    End Try
        'End Using
    End Sub

    Public Sub AlterarDados()
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder

        strQuery.Append(" UPDATE tbCPFVinculado ")
        strQuery.Append(" SET ")
        strQuery.Append(" cli_id = " & _vinc_lblVincID & " ")
        strQuery.Append(", vinc_nome='" & vinc_nome & "' ")
        strQuery.Append(", vinc_CPF='" & _vinc_CPF & "' ")
        strQuery.Append(", vinc_vinculo='" & _vinc_vinculo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" vinc_Id = " & _vinc_id & " ")

        'Executa o método ExecutaComando da classe de banco de dados
        Dim cldBancoDados As New cldBancoDados()
        cldBancoDados.ExecutaComando(strQuery.ToString)

        'Using con As OleDbConnection = GetConnection()
        '    Try
        '        con.Open()
        '        Dim sql As String = "UPDATE tbCPFVinculado SET cli_id=?,vinc_nome=?,vinc_CPF=?,vinc_vinculo=? WHERE empr_ID =" & CInt(vinc_id)
        '        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_id", _vinc_lblVincID))
        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_nome", _vinc_nome))
        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_CPF", _vinc_CPF))
        '        cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_vinculo", _vinc_vinculo))

        '        cmd.ExecuteNonQuery()

        '        MessageBox.Show("Operação de alteração realizada com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '    Catch ex As Exception
        '        MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        MsgBox(ex.Message.ToString)
        '    Finally
        '        con.Close()
        '    End Try
        'End Using

    End Sub


    ''METODO QUE LISTA AS PESSOAS VINCULADAS AO CLIENTE
    Public Function Listar(ByVal strDescricao As String) As DataSet
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder  'vinc_id,cli_id,vinc_nome,vinc_CPF,vinc_vinculo
        strQuery.Append(" SELECT v.vinc_id as Codigo,v.cli_id as ClienteID,v.vinc_Nome as Nome,v.vinc_CPF as CPF,v.vinc_vinculo as Tipo,c.cli_id,c.cli_Nome")

        strQuery.Append(" FROM tbCPFVinculado as v INNER JOIN tbClientes as c ")
        strQuery.Append(" ON v.cli_id = c.cli_id")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE c.cli_Nome like '%" & strDescricao & "%'")
        End If


        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function



End Class


