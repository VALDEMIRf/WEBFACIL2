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

    Private _NumCodReceitaPJ As String
    Public Property NumCodReceitaPJ() As String
        Get
            Return _NumCodReceitaPJ
        End Get
        Set(ByVal value As String)
            _NumCodReceitaPJ = value
        End Set
    End Property

    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO tbClientes(cli_CPF,cli_RG,cli_Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_data_nasc,cli_Curriculo,cli_Email,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Inativo,cli_InativoObs,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade,cli_DtCadastro) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CPF", _cli_CPF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_RG", _cli_RG))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Nome", _cli_Nome))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PIS", _cli_PIS))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_TitEleitoral", _cli_TitEleitoral))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Logradouro", _cli_Logradouro))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Numero", _cli_Numero))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_complemento", _cli_complemento))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Bairro", _cli_Bairro))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Cidade", _cli_Cidade))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_UF", _cli_UF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CEP", _cli_CEP))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneRes", _cli_FoneRes))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneCel", _cli_FoneCel))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_data_nasc", _cli_data_nasc))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Curriculo", _cli_Curriculo))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Email", _cli_Email))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_observacoes", _cli_observacoes))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Aposentado", _cli_Aposentado))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumBeneficio", _cli_NumBeneficio))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FuncPublico", _cli_FuncPublico))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFunc", _cli_NomeFunc))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Autonomo", _cli_Autonomo))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_AutonomoNome", _cli_AutonomoNome))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Falecido", _cli_Falecido))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFalecido", _cli_NomeFalecido))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Inativo", _cli_Inativo))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_InativoObs", _cli_InativoObs))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Parcelamento", _cli_Parcelamento))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumParcelamento", _cli_NumParcelamento))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EmprDom", _cli_EmprDom))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ESocial", _cli_ESocial))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EsocialSenha", _cli_EsocialSenha))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIP", _cli_VIP))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIPDescricao", _cli_VIPDescricao))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PJ", _cli_PJ))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumPJ", _cli_NumPJ))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_MEI))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_NumMEI))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_ITR))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_NumITR))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_Mensalista))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_NomeMensalista))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Decore", _cli_Decore))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_DecoreDescricao", _cli_DecoreDescricao))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_IRPF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_NumIRPF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenWebPrefeitura", _cli_SenWebPrefeitura))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaWebPrefeitura", _cli_SenhaWebPrefeitura))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Redesim", _cli_Redesim))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaRedesim", _cli_SenhaRedesim))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFB", _cli_CodRFB))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBNum", _cli_CodRFBNum))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBValidade", _cli_CodRFBValidade))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_DtCadastro", Now.Date))
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
        strQuery.Append(" SELECT cli_id as Codigo,cli_CPF as CPF,cli_RG as RG,cli_Nome as Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_data_nasc,cli_Curriculo,cli_Email,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Inativo,cli_InativoObs,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade ")
        ' strQuery.Append(" SELECT * FROM tbClientes ")
        strQuery.Append(" FROM tbClientes ")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE cli_CPF like '%" & strDescricao & "%'")
        End If


        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function


    Public Sub AlterarDados()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                ' Dim sql As String = "UPDATE tbClientes SET cli_CPF=?,cli_RG=?,cli_Nome=?,cli_PIS=?,cli_TitEleitoral=?,cli_Logradouro=?,cli_Numero=?,cli_complemento=?,cli_Bairro=?,cli_Cidade=?,cli_UF=?,cli_CEP=?,cli_FoneRes=?,cli_FoneCel=?,cli_data_nasc=?,cli_Curriculo=?,cli_Email=?,cli_observacoes=?,cli_Aposentado=?,cli_NumBeneficio=?,cli_FuncPublico=?,cli_NomeFunc=?,cli_Autonomo=?,cli_AutonomoNome=?,cli_Falecido=?,cli_NomeFalecido=?,cli_Inativo=?,cli_InativoObs=?,cli_Parcelamento=?,cli_NumParcelamento=?,cli_EmprDom=?,cli_ESocial=?,cli_EsocialSenha=?,cli_VIP=?,cli_VIPDescricao=?,cli_PJ=?,cli_NumPJ=?,cli_MEI=?,cli_NumMEI=?,cli_ITR=?,cli_NumITR=?,cli_Mensalista=?,cli_NomeMensalista=?,cli_Decore=?,cli_DecoreDescricao=?,cli_IRPF=?,cli_NumIRPF=?,cli_SenWebPrefeitura=?,cli_SenhaWebPrefeitura=?,cli_Redesim=?,cli_SenhaRedesim=?,cli_CodRFB=?,cli_CodRFBNum=?,cli_CodRFBValidade=? WHERE cli_Id=" & CInt(cli_id)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CPF", _cli_CPF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_RG", _cli_RG))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Nome", _cli_Nome))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PIS", _cli_PIS))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_TitEleitoral", _cli_TitEleitoral))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Logradouro", _cli_Logradouro))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Numero", _cli_Numero))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_complemento", _cli_complemento))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Bairro", _cli_Bairro))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Cidade", _cli_Cidade))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_UF", _cli_UF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CEP", _cli_CEP))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneRes", _cli_FoneRes))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneCel", _cli_FoneCel))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_data_nasc", _cli_data_nasc))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Curriculo", _cli_Curriculo))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Email", _cli_Email))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_observacoes", _cli_observacoes))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Aposentado", _cli_Aposentado))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumBeneficio", _cli_NumBeneficio))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FuncPublico", _cli_FuncPublico))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFunc", _cli_NomeFunc))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Autonomo", _cli_Autonomo))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_AutonomoNome", _cli_AutonomoNome))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Falecido", _cli_Falecido))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFalecido", _cli_NomeFalecido))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Inativo", _cli_Inativo))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_InativoObs", _cli_InativoObs))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Parcelamento", _cli_Parcelamento))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumParcelamento", _cli_NumParcelamento))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EmprDom", _cli_EmprDom))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ESocial", _cli_ESocial))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EsocialSenha", _cli_EsocialSenha))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIP", _cli_VIP))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIPDescricao", _cli_VIPDescricao))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PJ", _cli_PJ))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumPJ", _cli_NumPJ))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_MEI))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_NumMEI))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_ITR))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_NumITR))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_Mensalista))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_NomeMensalista))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Decore", _cli_Decore))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_DecoreDescricao", _cli_DecoreDescricao))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_IRPF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_NumIRPF))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenWebPrefeitura", _cli_SenWebPrefeitura))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaWebPrefeitura", _cli_SenhaWebPrefeitura))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Redesim", _cli_Redesim))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaRedesim", _cli_SenhaRedesim))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFB", _cli_CodRFB))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBNum", _cli_CodRFBNum))
                'cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBValidade", _cli_CodRFBValidade))

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
