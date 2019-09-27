'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text

Public Class clsCategoria
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados
    Private _cat_ID As Integer

    Public Property cat_ID() As Integer
        Get
            Return _cat_ID

        End Get
        Set(ByVal value As Integer)
            _cat_ID = value

        End Set
    End Property

    Private _cat_Descricao As String
    Public Property cat_Descricao() As String
        Get
            Return _cat_Descricao

        End Get
        Set(ByVal value As String)
            _cat_Descricao = value

        End Set
    End Property

    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO tbCategoria(cat_Descricao) VALUES(?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@cat_Descricao", _cat_Descricao))
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

    Public Function Listar(ByVal strDescricao As String) As DataSet
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cat_id as Codigo,cat_Descricao as Descricao")
        ' strQuery.Append(" SELECT * FROM tbClientes ")
        strQuery.Append(" FROM tbCategoria ORDER BY cat_Id")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE cat_id like '%" & strDescricao & "%'")
        End If

        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function


    Public Sub AlterarDados()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE tbCategoria SET cat_Descricao WHERE cat_id=" & CInt(cat_ID)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cat_Descricao", _cat_Descricao))
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
End Class
