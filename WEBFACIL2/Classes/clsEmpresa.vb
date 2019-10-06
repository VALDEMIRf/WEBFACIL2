'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text

Public Class clsEmpresa
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados

    Private _empr_ID As Integer
    Public Property empr_ID() As Integer
        Get
            Return _empr_ID
        End Get
        Set(ByVal value As Integer)
            _empr_ID = value
        End Set
    End Property

    Private _empr_razaosocial As String

    Public Property empr_razaosocial() As String
        Get
            Return _empr_razaosocial
        End Get
        Set(ByVal value As String)
            _empr_razaosocial = value
        End Set
    End Property

    Private _empr_nomefantasia As String
    Public Property empr_nomefantasia() As String
        Get
            Return _empr_nomefantasia
        End Get
        Set(ByVal value As String)
            _empr_nomefantasia = value
        End Set
    End Property

    Private _empr_cnpj As String
    Public Property empr_cnpj() As String
        Get
            Return _empr_cnpj
        End Get
        Set(ByVal value As String)
            _empr_cnpj = value
        End Set
    End Property

    Private _empr_Situacaocnpj As String
    Public Property empr_Situacaocnpj() As String
        Get
            Return _empr_Situacaocnpj
        End Get
        Set(ByVal value As String)
            _empr_Situacaocnpj = value
        End Set
    End Property

    Private _empr_NIRE As String
    Public Property empr_NIRE() As String
        Get
            Return _empr_NIRE
        End Get
        Set(ByVal value As String)
            _empr_NIRE = value
        End Set
    End Property

    Private _empr_InscrEstadual As String
    Public Property empr_InscrEstadual() As String
        Get
            Return _empr_InscrEstadual
        End Get
        Set(ByVal value As String)
            _empr_InscrEstadual = value
        End Set
    End Property

    Private _empr_CCM As String
    Public Property empr_CCM() As String
        Get
            Return _empr_CCM
        End Get
        Set(ByVal value As String)
            _empr_CCM = value
        End Set
    End Property

    Private _empr_atividade As String
    Public Property empr_atividade() As String
        Get
            Return _empr_atividade
        End Get
        Set(ByVal value As String)
            _empr_atividade = value
        End Set
    End Property

    Private _empr_Porte As String
    Public Property empr_Porte() As String
        Get
            Return _empr_Porte
        End Get
        Set(ByVal value As String)
            _empr_Porte = value
        End Set
    End Property

    Private _cli_CPFSituacao As String
    Public Property cli_CPFSituacao() As String
        Get
            Return _cli_CPFSituacao
        End Get
        Set(ByVal value As String)
            _cli_CPFSituacao = value
        End Set
    End Property

    Private _clsCategoria As clsCategoria
    Public Property clsCategoria() As clsCategoria
        Get
            Return _clsCategoria
        End Get
        Set(ByVal value As clsCategoria)
            _clsCategoria = value
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


    Private _empr_lblclienteID As Integer
    Public Property empr_lblclienteID() As Integer
        Get
            Return _empr_lblclienteID
        End Get
        Set(ByVal value As Integer)
            _empr_lblclienteID = value
        End Set
    End Property

    Private _empr_dataInicio As String
    Public Property empr_dataInicio() As String
        Get
            Return _empr_dataInicio
        End Get
        Set(ByVal value As String)
            _empr_dataInicio = value
        End Set
    End Property

    Private _empr_endereco As String
    Public Property empr_endereco() As String
        Get
            Return _empr_endereco
        End Get
        Set(ByVal value As String)
            _empr_endereco = value
        End Set
    End Property

    Private _empr_numero As String
    Public Property empr_numero() As String
        Get
            Return _empr_numero
        End Get
        Set(ByVal value As String)
            _empr_numero = value
        End Set
    End Property

    Private _empr_complemento As String
    Public Property empr_complemento() As String
        Get
            Return _empr_complemento
        End Get
        Set(ByVal value As String)
            _empr_complemento = value
        End Set
    End Property

    Private _empr_bairro As String
    Public Property empr_bairro() As String
        Get
            Return _empr_bairro
        End Get
        Set(ByVal value As String)
            _empr_bairro = value
        End Set
    End Property

    Private _empr_cidade As String
    Public Property empr_cidade() As String
        Get
            Return _empr_cidade
        End Get
        Set(ByVal value As String)
            _empr_cidade = value
        End Set
    End Property

    Private _empr_UF As String
    Public Property empr_UF() As String
        Get
            Return _empr_UF
        End Get
        Set(ByVal value As String)
            _empr_UF = value
        End Set
    End Property

    Private _empr_CEP As String
    Public Property empr_CEP() As String
        Get
            Return _empr_CEP
        End Get
        Set(ByVal value As String)
            _empr_CEP = value
        End Set
    End Property

    Private _empr_obs As String
    Public Property empr_obs() As String
        Get
            Return _empr_obs
        End Get
        Set(ByVal value As String)
            _empr_obs = value
        End Set
    End Property

    Private _empr_Simples As Boolean
    Public Property empr_Simples() As Boolean
        Get
            Return _empr_Simples
        End Get
        Set(ByVal value As Boolean)
            _empr_Simples = value
        End Set
    End Property

    Private _empr_SimplesNacional As String
    Public Property empr_SimplesNacional() As String
        Get
            Return _empr_SimplesNacional
        End Get
        Set(ByVal value As String)
            _empr_SimplesNacional = value
        End Set
    End Property

    Private _empr_Simei As Boolean
    Public Property empr_Simei() As Boolean
        Get
            Return _empr_Simei
        End Get
        Set(ByVal value As Boolean)
            _empr_Simei = value
        End Set
    End Property

    Private _empr_CodSimei As String
    Public Property empr_CodSimei() As String
        Get
            Return _empr_CodSimei
        End Get
        Set(ByVal value As String)
            _empr_CodSimei = value
        End Set
    End Property

    Private _empr_sefaz As Boolean
    Public Property empr_sefaz() As Boolean
        Get
            Return _empr_sefaz
        End Get
        Set(ByVal value As Boolean)
            _empr_sefaz = value
        End Set
    End Property

    Private _empr_SefazUsu As String
    Public Property empr_SefazUsu() As String
        Get
            Return _empr_SefazUsu
        End Get
        Set(ByVal value As String)
            _empr_SefazUsu = value
        End Set
    End Property

    Private _empr_SefazSen As String
    Public Property empr_SefazSen() As String
        Get
            Return _empr_SefazSen
        End Get
        Set(ByVal value As String)
            _empr_SefazSen = value
        End Set
    End Property

    Private _empr_CodReceitaPJ As Boolean
    Public Property empr_CodReceitaPJ() As Boolean
        Get
            Return _empr_CodReceitaPJ
        End Get
        Set(ByVal value As Boolean)
            _empr_CodReceitaPJ = value
        End Set
    End Property

    Private _empr_NumCodReceitaPJ As String
    Public Property empr_NumCodReceitaPJ() As String
        Get
            Return _empr_NumCodReceitaPJ
        End Get
        Set(ByVal value As String)
            _empr_NumCodReceitaPJ = value
        End Set
    End Property

    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()                                                                             'empr_Situacaocnpj
                Dim sql As String = "INSERT INTO tbEmpresas(empr_razaosocial,empr_nomefantasia,empr_cnpj,empr_Situacaocnpj,empr_NIRE,empr_InscrEstadual,empr_CCM,empr_atividade,empr_Porte,cli_id,cat_Id,empr_dataInicio,empr_endereco,empr_numero,empr_complemento,empr_bairro,empr_cidade,empr_UF,empr_CEP,empr_obs,empr_Simples,empr_SimplesNacional,empr_Simei,empr_CodSimei,empr_sefaz,empr_SefazUsu,empr_SefazSen,empr_CodReceitaPJ,empr_NumCodReceitaPJ) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_razaosocial", _empr_razaosocial))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_nomefantasia", _empr_nomefantasia))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_cnpj", _empr_cnpj))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Situacaocnpj", _empr_Situacaocnpj))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_NIRE", _empr_NIRE))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_InscrEstadual", _empr_InscrEstadual))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CCM", _empr_CCM))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_atividade", _empr_atividade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Porte", _empr_Porte))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_id", _empr_lblclienteID))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cat_Id", _clsCategoria.cat_ID))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_dataInicio", _empr_dataInicio))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_endereco", _empr_endereco))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_numero", _empr_numero))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_complemento", _empr_complemento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_bairro", _empr_bairro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_cidade", _empr_cidade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_UF", _empr_UF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CEP", _empr_CEP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_obs", _empr_obs))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Simples", _empr_Simples))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_SimplesNacional", _empr_SimplesNacional))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Simei", _empr_Simei))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CodSimei", _empr_CodSimei))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_sefaz", _empr_sefaz))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_SefazUsu", _empr_SefazUsu))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_SefazSen", _empr_SefazSen))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CodReceitaPJ", _empr_CodReceitaPJ))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_NumCodReceitaPJ", _empr_NumCodReceitaPJ))

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
        strQuery.Append(" SELECT empr_ID as Codigo,empr_razaosocial as Razao Social,empr_nomefantasia as Nome Fantasia,empr_cnpj as CNPJ,empr_Situacaocnpj as Situacao,empr_NIRE,empr_InscrEstadual,empr_CCM,empr_atividade,empr_Porte,cli_id,cat_Id,empr_dataInicio,empr_endereco,empr_numero,empr_complemento,empr_bairro,empr_cidade,empr_UF,empr_CEP,empr_obs,empr_Simples,empr_SimplesNacional,empr_Simei,empr_CodSimei,empr_sefaz,empr_SefazUsu,empr_SefazSen,empr_CodReceitaPJ,empr_NumCodReceitaPJ ")
        strQuery.Append(" FROM tbEmpresas ")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE empr_cnpj like '%" & strDescricao & "%'")
        End If

        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Sub AlterarDados()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE tbEmpresas SET empr_razaosocial=?,empr_nomefantasia=?,empr_cnpj=?,empr_Situacaocnpj=?,empr_NIRE=?,empr_InscrEstadual=?,empr_CCM=?,empr_atividade=?,empr_Porte=?,cli_id=?,cat_Id=?,empr_dataInicio=?,empr_endereco=?,empr_numero=?,empr_complemento=?,empr_bairro=?,empr_cidade=?,empr_UF=?,empr_CEP=?,empr_obs=?,empr_Simples=?,empr_SimplesNacional=?,empr_Simei=?,empr_CodSimei=?,empr_sefaz=?,empr_SefazUsu=?,empr_SefazSen=?,empr_CodReceitaPJ=?,empr_NumCodReceitaPJ=? WHERE empr_ID =" & CInt(empr_ID)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_razaosocial", _empr_razaosocial))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_nomefantasia", _empr_nomefantasia))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_cnpj", _empr_cnpj)) 'empr_Situacaocnpj
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Situacaocnpj", _empr_Situacaocnpj))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_NIRE", _empr_NIRE))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_InscrEstadual", _empr_InscrEstadual))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CCM", _empr_CCM))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_atividade", _empr_atividade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Porte", _empr_Porte))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_id", _empr_lblclienteID))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cat_Id", _clsCategoria.cat_ID))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_dataInicio", _empr_dataInicio))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_endereco", _empr_endereco))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_numero", _empr_numero))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_complemento", _empr_complemento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_bairro", _empr_bairro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_cidade", _empr_cidade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_UF", _empr_UF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CEP", _empr_CEP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_obs", _empr_obs))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Simples", _empr_Simples))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_SimplesNacional", _empr_SimplesNacional))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_Simei", _empr_Simei))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CodSimei", _empr_CodSimei))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_sefaz", _empr_sefaz))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_SefazUsu", _empr_SefazUsu))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_SefazSen", _empr_SefazSen))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_CodReceitaPJ", _empr_CodReceitaPJ))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@empr_NumCodReceitaPJ", _empr_NumCodReceitaPJ))

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
