'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text

Public Class clsCliente
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados

    Private _cli_id As Integer
    Friend Shared nome As Object

    Public Property cli_id() As Integer
        Get
            Return _cli_id
        End Get
        Set(ByVal value As Integer)
            _cli_id = value
        End Set
    End Property

    Private _cli_CPF As String
    Public Property cli_CPF() As String
        Get
            Return _cli_CPF
        End Get
        Set(ByVal value As String)
            _cli_CPF = value
        End Set
    End Property

    Private _cli_Situacao As String
    Public Property cli_Situacao() As String
        Get
            Return _cli_Situacao
        End Get
        Set(ByVal value As String)
            _cli_Situacao = value
        End Set
    End Property

    Private _cli_UF As String
    Public Property cli_UF() As String
        Get
            Return _cli_UF
        End Get
        Set(ByVal value As String)
            _cli_UF = value
        End Set
    End Property

    Private _cli_Nome As String
    Public Property cli_Nome() As String
        Get
            Return _cli_Nome
        End Get
        Set(ByVal value As String)
            _cli_Nome = value
        End Set
    End Property

    Private _cli_RG As String
    Public Property cli_RG() As String
        Get
            Return _cli_RG
        End Get
        Set(ByVal value As String)
            _cli_RG = value
        End Set
    End Property

    Private _cli_PIS As String
    Public Property cli_PIS() As String
        Get
            Return _cli_PIS
        End Get
        Set(ByVal value As String)
            _cli_PIS = value
        End Set
    End Property

    Private _cli_TitEleitoral As String
    Public Property cli_TitEleitoral() As String
        Get
            Return _cli_TitEleitoral
        End Get
        Set(ByVal value As String)
            _cli_TitEleitoral = value
        End Set
    End Property

    Private _cli_Logradouro As String
    Public Property cli_Logradouro() As String
        Get
            Return _cli_Logradouro
        End Get
        Set(ByVal value As String)
            _cli_Logradouro = value
        End Set
    End Property

    Private _cli_Numero As String
    Public Property cli_Numero() As String
        Get
            Return _cli_Numero
        End Get
        Set(ByVal value As String)
            _cli_Numero = value
        End Set
    End Property

    Private _cli_complemento As String
    Public Property cli_complemento() As String
        Get
            Return _cli_complemento
        End Get
        Set(ByVal value As String)
            _cli_complemento = value
        End Set
    End Property

    Private _cli_Bairro As String
    Public Property cli_Bairro() As String
        Get
            Return _cli_Bairro
        End Get
        Set(ByVal value As String)
            _cli_Bairro = value
        End Set
    End Property

    Private _cli_Cidade As String
    Public Property cli_Cidade() As String
        Get
            Return _cli_Cidade
        End Get
        Set(ByVal value As String)
            _cli_Cidade = value
        End Set
    End Property

    Private _cli_CEP As String
    Public Property cli_CEP() As String
        Get
            Return _cli_CEP
        End Get
        Set(ByVal value As String)
            _cli_CEP = value
        End Set
    End Property

    Private _cli_FoneRes As String
    Public Property cli_FoneRes() As String
        Get
            Return _cli_FoneRes
        End Get
        Set(ByVal value As String)
            _cli_FoneRes = value
        End Set
    End Property

    Private _cli_FoneCel As String
    Public Property cli_FoneCel() As String
        Get
            Return _cli_FoneCel
        End Get
        Set(ByVal value As String)
            _cli_FoneCel = value
        End Set
    End Property

    Private _cli_data_nasc As String
    Public Property cli_data_nasc() As String
        Get
            Return _cli_data_nasc
        End Get
        Set(ByVal value As String)
            _cli_data_nasc = value
        End Set
    End Property

    Private _cli_Dia As String
    Public Property cli_Dia() As String
        Get
            Return _cli_Dia
        End Get
        Set(ByVal value As String)
            _cli_Dia = value
        End Set
    End Property

    Private _cli_Mes As String
    Public Property cli_Mes() As String
        Get
            Return _cli_Mes
        End Get
        Set(ByVal value As String)
            _cli_Mes = value
        End Set
    End Property

    Private _cli_Ano As String
    Public Property cli_Ano() As String
        Get
            Return _cli_Ano
        End Get
        Set(ByVal value As String)
            _cli_Ano = value
        End Set
    End Property

    Private _cli_Email As String
    Public Property cli_Email() As String
        Get
            Return _cli_Email
        End Get
        Set(ByVal value As String)
            _cli_Email = value
        End Set
    End Property

    Private _cli_Curriculo As Boolean
    Public Property cli_Curriculo() As Boolean
        Get
            Return _cli_Curriculo
        End Get
        Set(ByVal value As Boolean)
            _cli_Curriculo = value
        End Set
    End Property

    Private _clsCPFVinculado As clsCPFVinculado
    Public Property clnCPFVinculado() As clsCPFVinculado
        Get
            Return _clsCPFVinculado
        End Get
        Set(ByVal value As clsCPFVinculado)
            _clsCPFVinculado = value
        End Set
    End Property

    Private _cli_CPFVinculado As String
    Public Property cli_CPFVinculado() As String
        Get
            Return _cli_CPFVinculado
        End Get
        Set(ByVal value As String)
            _cli_CPFVinculado = value
        End Set
    End Property

    Private _cli_TipoVinculacao As String
    Public Property cli_TipoVinculacao() As String
        Get
            Return _cli_TipoVinculacao
        End Get
        Set(ByVal value As String)
            _cli_TipoVinculacao = value
        End Set
    End Property

    Private _cli_observacoes As String
    Public Property cli_observacoes() As String
        Get
            Return _cli_observacoes
        End Get
        Set(ByVal value As String)
            _cli_observacoes = value
        End Set
    End Property

    Private _cli_Aposentado As Boolean
    Public Property cli_Aposentado() As Boolean
        Get
            Return _cli_Aposentado
        End Get
        Set(ByVal value As Boolean)
            _cli_Aposentado = value
        End Set
    End Property

    Private _cli_NumBeneficio As String
    Public Property cli_NumBeneficio() As String
        Get
            Return _cli_NumBeneficio
        End Get
        Set(ByVal value As String)
            _cli_NumBeneficio = value
        End Set
    End Property

    Private _cli_FuncPublico As Boolean
    Public Property cli_FuncPublico() As Boolean
        Get
            Return _cli_FuncPublico
        End Get
        Set(ByVal value As Boolean)
            _cli_FuncPublico = value
        End Set
    End Property

    Private _cli_NomeFunc As String
    Public Property cli_NomeFunc() As String
        Get
            Return _cli_NomeFunc
        End Get
        Set(ByVal value As String)
            _cli_NomeFunc = value
        End Set
    End Property

    Private _cli_Autonomo As Boolean
    Public Property cli_Autonomo() As Boolean
        Get
            Return _cli_Autonomo
        End Get
        Set(ByVal value As Boolean)
            _cli_Autonomo = value
        End Set
    End Property

    Private _cli_AutonomoNome As String
    Public Property cli_AutonomoNome() As String
        Get
            Return _cli_AutonomoNome
        End Get
        Set(ByVal value As String)
            _cli_AutonomoNome = value
        End Set
    End Property

    Private _cli_Falecido As Boolean
    Public Property cli_Falecido() As Boolean
        Get
            Return _cli_Falecido
        End Get
        Set(ByVal value As Boolean)
            _cli_Falecido = value
        End Set
    End Property

    Private _cli_NomeFalecido As String
    Public Property cli_NomeFalecido() As String
        Get
            Return _cli_NomeFalecido
        End Get
        Set(ByVal value As String)
            _cli_NomeFalecido = value
        End Set
    End Property

    Private _cli_Inativo As Boolean
    Public Property cli_Inativo() As Boolean
        Get
            Return _cli_Inativo
        End Get
        Set(ByVal value As Boolean)
            _cli_Inativo = value
        End Set
    End Property

    Private _cli_InativoObs As String
    Public Property cli_InativoObs() As String
        Get
            Return _cli_InativoObs
        End Get
        Set(ByVal value As String)
            _cli_InativoObs = value
        End Set
    End Property

    Private _cli_Parcelamento As Boolean
    Public Property cli_Parcelamento() As Boolean
        Get
            Return _cli_Parcelamento
        End Get
        Set(ByVal value As Boolean)
            _cli_Parcelamento = value
        End Set
    End Property

    Private _cli_NumParcelamento As String
    Public Property cli_NumParcelamento() As String
        Get
            Return _cli_NumParcelamento
        End Get
        Set(ByVal value As String)
            _cli_NumParcelamento = value
        End Set
    End Property

    Private _cli_EmprDom As Boolean
    Public Property cli_EmprDom() As Boolean
        Get
            Return _cli_EmprDom
        End Get
        Set(ByVal value As Boolean)
            _cli_EmprDom = value
        End Set
    End Property

    Private _cli_ESocial As String
    Public Property cli_ESocial() As String
        Get
            Return _cli_ESocial
        End Get
        Set(ByVal value As String)
            _cli_ESocial = value
        End Set
    End Property

    Private _cli_EsocialSenha As String
    Public Property cli_EsocialSenha() As String
        Get
            Return _cli_EsocialSenha
        End Get
        Set(ByVal value As String)
            _cli_EsocialSenha = value
        End Set
    End Property

    Private _cli_VIP As Boolean
    Public Property cli_VIP() As Boolean
        Get
            Return _cli_VIP
        End Get
        Set(ByVal value As Boolean)
            _cli_VIP = value
        End Set
    End Property

    Private _cli_VIPDescricao As String
    Public Property cli_VIPDescricao() As String
        Get
            Return _cli_VIPDescricao
        End Get
        Set(ByVal value As String)
            _cli_VIPDescricao = value
        End Set
    End Property

    Private _cli_PJ As Boolean
    Public Property cli_PJ() As Boolean
        Get
            Return _cli_PJ
        End Get
        Set(ByVal value As Boolean)
            _cli_PJ = value
        End Set
    End Property

    Private _cli_NumPJ As String
    Public Property cli_NumPJ() As String
        Get
            Return _cli_NumPJ
        End Get
        Set(ByVal value As String)
            _cli_NumPJ = value
        End Set
    End Property

    Private _cli_MEI As Boolean
    Public Property cli_MEI() As Boolean
        Get
            Return _cli_MEI
        End Get
        Set(ByVal value As Boolean)
            _cli_MEI = value
        End Set
    End Property

    Private _cli_NumMEI As String
    Public Property cli_NumMEI() As String
        Get
            Return _cli_NumMEI
        End Get
        Set(ByVal value As String)
            _cli_NumMEI = value
        End Set
    End Property

    Private _cli_ITR As Boolean
    Public Property cli_ITR() As Boolean
        Get
            Return _cli_ITR
        End Get
        Set(ByVal value As Boolean)
            _cli_ITR = value
        End Set
    End Property

    Private _cli_NumITR As String
    Public Property cli_NumITR() As String
        Get
            Return _cli_NumITR
        End Get
        Set(ByVal value As String)
            _cli_NumITR = value
        End Set
    End Property

    Private _cli_Mensalista As Boolean
    Public Property cli_Mensalista() As Boolean
        Get
            Return _cli_Mensalista
        End Get
        Set(ByVal value As Boolean)
            _cli_Mensalista = value
        End Set
    End Property

    Private _cli_NomeMensalista As String
    Public Property cli_NomeMensalista() As String
        Get
            Return _cli_NomeMensalista
        End Get
        Set(ByVal value As String)
            _cli_NomeMensalista = value
        End Set
    End Property

    Private _cli_Decore As Boolean
    Public Property cli_Decore() As Boolean
        Get
            Return _cli_Decore
        End Get
        Set(ByVal value As Boolean)
            _cli_Decore = value
        End Set
    End Property

    Private _cli_DecoreDescricao As String
    Public Property cli_DecoreDescricao() As String
        Get
            Return _cli_DecoreDescricao
        End Get
        Set(ByVal value As String)
            _cli_DecoreDescricao = value
        End Set
    End Property

    Private _cli_IRPF As Boolean
    Public Property cli_IRPF() As Boolean
        Get
            Return _cli_IRPF
        End Get
        Set(ByVal value As Boolean)
            _cli_IRPF = value
        End Set
    End Property

    Private _cli_NumIRPF As String
    Public Property cli_NumIRPF() As String
        Get
            Return _cli_NumIRPF
        End Get
        Set(ByVal value As String)
            _cli_NumIRPF = value
        End Set
    End Property

    Private _cli_SenWebPrefeitura As Boolean
    Public Property cli_SenWebPrefeitura() As Boolean
        Get
            Return _cli_SenWebPrefeitura
        End Get
        Set(ByVal value As Boolean)
            _cli_SenWebPrefeitura = value
        End Set
    End Property

    Private _cli_SenhaWebPrefeitura As String
    Public Property cli_SenhaWebPrefeitura() As String
        Get
            Return _cli_SenhaWebPrefeitura
        End Get
        Set(ByVal value As String)
            _cli_SenhaWebPrefeitura = value
        End Set
    End Property

    Private _cli_Redesim As Boolean
    Public Property cli_Redesim() As Boolean
        Get
            Return _cli_Redesim
        End Get
        Set(ByVal value As Boolean)
            _cli_Redesim = value
        End Set
    End Property

    Private _cli_SenhaRedesim As String
    Public Property cli_SenhaRedesim() As String
        Get
            Return _cli_SenhaRedesim
        End Get
        Set(ByVal value As String)
            _cli_SenhaRedesim = value
        End Set
    End Property

    Private _cli_CodRFB As Boolean
    Public Property cli_CodRFB() As Boolean
        Get
            Return _cli_CodRFB
        End Get
        Set(ByVal value As Boolean)
            _cli_CodRFB = value
        End Set
    End Property

    Private _cli_CodRFBNum As String
    Public Property cli_CodRFBNum() As String
        Get
            Return _cli_CodRFBNum
        End Get
        Set(ByVal value As String)
            _cli_CodRFBNum = value
        End Set
    End Property

    Private _cli_CodRFBValidade As String
    Public Property cli_CodRFBValidade() As String
        Get
            Return _cli_CodRFBValidade
        End Get
        Set(ByVal value As String)
            _cli_CodRFBValidade = value
        End Set
    End Property

    Private _cli_DtCadastro As DateTime

    Public Property cli_DtCadastro() As DateTime
        Get
            Return _cli_DtCadastro
        End Get
        Set(ByVal value As DateTime)
            _cli_DtCadastro = value
        End Set
    End Property

    'MÉTODO QUE GRAVA DADOS PESSOA FÍSICA
    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO tbClientes(cli_CPF,cli_Situacao,cli_RG,cli_Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_Dia,cli_Mes,cli_Ano,cli_Curriculo,cli_Email,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Inativo,cli_InativoObs,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade,cli_DtCadastro) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CPF", _cli_CPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Situacao", _cli_Situacao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_RG", _cli_RG))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Nome", _cli_Nome))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PIS", _cli_PIS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_TitEleitoral", _cli_TitEleitoral))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Logradouro", _cli_Logradouro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Numero", _cli_Numero))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_complemento", _cli_complemento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Bairro", _cli_Bairro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Cidade", _cli_Cidade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_UF", _cli_UF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CEP", _cli_CEP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneRes", _cli_FoneRes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneCel", _cli_FoneCel))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Dia", _cli_Dia))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mes", _cli_Mes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Ano", _cli_Ano))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Curriculo", _cli_Curriculo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Email", _cli_Email))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_observacoes", _cli_observacoes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Aposentado", _cli_Aposentado))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumBeneficio", _cli_NumBeneficio))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FuncPublico", _cli_FuncPublico))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFunc", _cli_NomeFunc))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Autonomo", _cli_Autonomo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_AutonomoNome", _cli_AutonomoNome))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Falecido", _cli_Falecido))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFalecido", _cli_NomeFalecido))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Inativo", _cli_Inativo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_InativoObs", _cli_InativoObs))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Parcelamento", _cli_Parcelamento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumParcelamento", _cli_NumParcelamento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EmprDom", _cli_EmprDom))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ESocial", _cli_ESocial))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EsocialSenha", _cli_EsocialSenha))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIP", _cli_VIP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIPDescricao", _cli_VIPDescricao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PJ", _cli_PJ))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumPJ", _cli_NumPJ))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_MEI))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_NumMEI))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_ITR))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_NumITR))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_Mensalista))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_NomeMensalista))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Decore", _cli_Decore))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_DecoreDescricao", _cli_DecoreDescricao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_IRPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_NumIRPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenWebPrefeitura", _cli_SenWebPrefeitura))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaWebPrefeitura", _cli_SenhaWebPrefeitura))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Redesim", _cli_Redesim))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaRedesim", _cli_SenhaRedesim))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFB", _cli_CodRFB))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBNum", _cli_CodRFBNum))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBValidade", _cli_CodRFBValidade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_DtCadastro", Now.Date))
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
        strQuery.Append(" SELECT c.cli_id as codigo,c.cli_CPF as CPF,c.cli_Situacao as Situacao,c.cli_RG as RG,c.cli_Nome as Nome,c.cli_PIS,c.cli_TitEleitoral,c.cli_Logradouro,c.cli_Numero,c.cli_complemento,c.cli_Bairro,c.cli_Cidade,c.cli_UF,c.cli_CEP,c.cli_FoneRes,c.cli_FoneCel,c.cli_Dia,c.cli_Mes,c.cli_Ano,c.cli_Curriculo,c.cli_Email,c.cli_observacoes,c.cli_Aposentado,c.cli_NumBeneficio,c.cli_FuncPublico,c.cli_NomeFunc,c.cli_Autonomo,c.cli_AutonomoNome,c.cli_Falecido,c.cli_NomeFalecido,c.cli_Inativo,c.cli_InativoObs,c.cli_Parcelamento,c.cli_NumParcelamento,c.cli_EmprDom,c.cli_ESocial,c.cli_EsocialSenha,c.cli_VIP,c.cli_VIPDescricao,c.cli_PJ,c.cli_NumPJ,c.cli_MEI,c.cli_NumMEI,c.cli_ITR,c.cli_NumITR,c.cli_Mensalista,c.cli_NomeMensalista,c.cli_Decore,c.cli_DecoreDescricao,c.cli_IRPF,c.cli_NumIRPF,c.cli_SenWebPrefeitura,c.cli_SenhaWebPrefeitura,c.cli_Redesim,c.cli_SenhaRedesim,c.cli_CodRFB,c.cli_CodRFBNum,c.cli_CodRFBValidade,e.empr_ID,e.empr_razaosocial as Empresa,e.empr_nomefantasia,e.empr_cnpj as CNPJ,e.empr_Situacaocnpj,e.empr_NIRE,e.empr_InscrEstadual,e.empr_CCM,e.empr_atividade,e.empr_Porte,e.cli_id,e.cat_Id,e.empr_dataInicio,e.empr_endereco,e.empr_numero,e.empr_complemento,e.empr_bairro,e.empr_cidade,e.empr_UF,e.empr_CEP,e.empr_obs,e.empr_Simples,e.empr_SimplesNacional,e.empr_Simei,e.empr_CodSimei,e.empr_sefaz,e.empr_SefazUsu,e.empr_SefazSen,e.empr_CodReceitaPJ,e.empr_NumCodReceitaPJ ")
        strQuery.Append(" FROM tbClientes as c INNER JOIN tbEmpresas as e ")
        strQuery.Append(" ON c.cli_id = e.cli_id")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE c.cli_CPF like '%" & strDescricao & "%'")
        End If

        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    'METODO QUE LISTA PESSOA FÍSICA
    Public Function ListarCpf(ByVal strDescricao As String) As DataSet
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cli_id as Codigo,cli_CPF as CPF,cli_Situacao as Situacao,cli_RG as RG,cli_Nome as Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_Dia,cli_Mes,cli_Ano,cli_Curriculo,cli_Email,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Inativo,cli_InativoObs,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade ")
        strQuery.Append(" FROM tbClientes ")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE cli_CPF like '%" & strDescricao & "%'")
        End If

        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Function LeInformacoesCliente(ByVal strDescricao As String) As DataSet
        Dim dr As OleDbDataReader = Nothing
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cli_id,cli_CPF,cli_Nome ")
        strQuery.Append(" FROM tbClientes ")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE cli_CPF like '%" & strDescricao & "%'")
        End If
        ''Using con As OleDbConnection = GetConnection()
        ''    Try
        ''        con.Open()
        ''        'Dim sql As String = "SELECT cli_id,cli_CPF,cli_Nome FROM tbClientes WHERE cli_CPF = '" & cli.cli_CPF & "'"
        ''        Dim sql As String = "SELECT cli_id,cli_CPF,cli_Nome FROM tbClientes WHERE cli_id = " & lblciID.Text
        ''        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        ''        dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
        ''        If dr.HasRows Then
        ''            dr.Read()
        ''            'lblciID.Text = dr.Item("cli_id")
        ''            ' lblclienteID.Text = dr.Item("cli_id")
        ''            txtNome.Text = dr.Item("cli_Nome")
        ''            cli = dr.Item("cli_Nome")
        ''            ' txtNome.Text = cli.cli_Nome
        ''        Else
        ''            MsgBox("Não foi possível carregar os dados.", MsgBoxStyle.Critical, "Aviso do Sistema")
        ''        End If

        ''    Catch ex As Exception
        ''        MsgBox(ex.Message.ToString)
        ''    Finally
        ''        dr.Close()
        ''        con.Close()

        ''    End Try
        ''End Using
        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    'METODO QUE ALTERA DADOS PESSOA FÍSICA
    Public Sub AlterarDados()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE tbClientes SET cli_CPF=?,cli_Situacao=?,cli_RG=?,cli_Nome=?,cli_PIS=?,cli_TitEleitoral=?,cli_Logradouro=?,cli_Numero=?,cli_complemento=?,cli_Bairro=?,cli_Cidade=?,cli_UF=?,cli_CEP=?,cli_FoneRes=?,cli_FoneCel=?,cli_Dia=?,cli_Mes=?,cli_Ano=?,cli_Curriculo=?,cli_Email=?,cli_observacoes=?,cli_Aposentado=?,cli_NumBeneficio=?,cli_FuncPublico=?,cli_NomeFunc=?,cli_Autonomo=?,cli_AutonomoNome=?,cli_Falecido=?,cli_NomeFalecido=?,cli_Inativo=?,cli_InativoObs=?,cli_Parcelamento=?,cli_NumParcelamento=?,cli_EmprDom=?,cli_ESocial=?,cli_EsocialSenha=?,cli_VIP=?,cli_VIPDescricao=?,cli_PJ=?,cli_NumPJ=?,cli_MEI=?,cli_NumMEI=?,cli_ITR=?,cli_NumITR=?,cli_Mensalista=?,cli_NomeMensalista=?,cli_Decore=?,cli_DecoreDescricao=?,cli_IRPF=?,cli_NumIRPF=?,cli_SenWebPrefeitura=?,cli_SenhaWebPrefeitura=?,cli_Redesim=?,cli_SenhaRedesim=?,cli_CodRFB=?,cli_CodRFBNum=?,cli_CodRFBValidade=? WHERE cli_Id=" & CInt(cli_id)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CPF", _cli_CPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Situacao", _cli_Situacao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_RG", _cli_RG))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Nome", _cli_Nome))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PIS", _cli_PIS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_TitEleitoral", _cli_TitEleitoral))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Logradouro", _cli_Logradouro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Numero", _cli_Numero))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_complemento", _cli_complemento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Bairro", _cli_Bairro))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Cidade", _cli_Cidade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_UF", _cli_UF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CEP", _cli_CEP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneRes", _cli_FoneRes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FoneCel", _cli_FoneCel))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Dia", _cli_Dia))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mes", _cli_Mes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Ano", _cli_Ano))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Curriculo", _cli_Curriculo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Email", _cli_Email))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_observacoes", _cli_observacoes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Aposentado", _cli_Aposentado))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumBeneficio", _cli_NumBeneficio))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FuncPublico", _cli_FuncPublico))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFunc", _cli_NomeFunc))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Autonomo", _cli_Autonomo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_AutonomoNome", _cli_AutonomoNome))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Falecido", _cli_Falecido))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFalecido", _cli_NomeFalecido))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Inativo", _cli_Inativo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_InativoObs", _cli_InativoObs))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Parcelamento", _cli_Parcelamento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumParcelamento", _cli_NumParcelamento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EmprDom", _cli_EmprDom))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ESocial", _cli_ESocial))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EsocialSenha", _cli_EsocialSenha))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIP", _cli_VIP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIPDescricao", _cli_VIPDescricao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PJ", _cli_PJ))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumPJ", _cli_NumPJ))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_MEI))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_MEI", _cli_NumMEI))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_ITR))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ITR", _cli_NumITR))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_Mensalista))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Mensalista", _cli_NomeMensalista))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Decore", _cli_Decore))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_DecoreDescricao", _cli_DecoreDescricao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_IRPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_IRPF", _cli_NumIRPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenWebPrefeitura", _cli_SenWebPrefeitura))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaWebPrefeitura", _cli_SenhaWebPrefeitura))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Redesim", _cli_Redesim))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaRedesim", _cli_SenhaRedesim))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFB", _cli_CodRFB))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBNum", _cli_CodRFBNum))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CodRFBValidade", _cli_CodRFBValidade))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_DtCadastro", Now.Date))

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
