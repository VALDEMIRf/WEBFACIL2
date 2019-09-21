'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text

Public Class clsCliente
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados

    Private _cli_id As Integer
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

    Private _cli_UF As String
    Public Property cli_UF() As String
        Get
            Return _cli_UF
        End Get
        Set(ByVal value As String)
            _cli_UF = value
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

    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO tbClientes(cli_CPF,cli_RG,cli_Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_data_nasc,cli_Curriculo,cli_Email,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Inativo,cli_InativoObs,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade,cli_DtCadastro) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CPF", _cli_CPF))
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
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_data_nasc", _cli_data_nasc))
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

   
    Public Sub Alterar()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE tbClientes SET cli_CPF=?,cli_RG=?,cli_Nome=?,cli_PIS=?,cli_TitEleitoral=?,cli_Logradouro=?,cli_Numero=?,cli_complemento=?,cli_Bairro=?,cli_Cidade=?,cli_UF=?,cli_CEP=?,cli_FoneRes=?,cli_FoneCel=?,cli_data_nasc=?,cli_Curriculo=?,cli_Email=?,cli_observacoes=?,cli_Aposentado=?,cli_NumBeneficio=?,cli_FuncPublico=?,cli_NomeFunc=?,cli_Autonomo=?,cli_AutonomoNome=?,cli_Falecido=?,cli_NomeFalecido=?,cli_Parcelamento=?,cli_NumParcelamento=?,cli_EmprDom=?,cli_ESocial=?,cli_VIP=?,cli_VIPDescricao=?,cli_PJ=?,cli_NumPJ=?,cli_MEI=?,cli_NumMEI=?,cli_ITR=?,cli_NumITR=?,cli_Mensalista=?,cli_NomeMensalista=?,cli_Decore=?,cli_DecoreDescricao=?,cli_IRPF=?,cli_NumIRPF=?,cli_SenWebPrefeitura=?,cli_SenhaWebPrefeitura=?,cli_SenhaWebValidade=? WHERE cli_Id=" & CInt(cli_id)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_CPF", cli_CPF))
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
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_data_nasc", _cli_data_nasc))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Email", _cli_Email))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_id", _clsCPFVinculado.vinc_id))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_observacoes", _cli_observacoes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Aposentado", _cli_Aposentado))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NumBeneficio", _cli_NumBeneficio))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_FuncPublico", _cli_FuncPublico))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFunc", _cli_NomeFunc))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Autonomo", _cli_Autonomo))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_AutonomoNome", _cli_AutonomoNome))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Falecido", _cli_Falecido))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_NomeFalecido", _cli_NomeFalecido))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Parcelamento", _cli_Parcelamento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_Parcelamento", _cli_NumParcelamento))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_EmprDom", _cli_EmprDom))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_ESocial", _cli_ESocial))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIP", _cli_VIP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_VIPDescricao", _cli_VIPDescricao))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PJ", _cli_PJ))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_PJ", _cli_NumPJ))
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
                ' cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_SenhaWebValidade", _cli_SenhaWebValidade))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Operação realizada com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using

        'Cria um StringBuilder para concatenar a Query Sql

        ' Dim strQuery As New StringBuilder

        'cli_Nome, cli_CNPJ, cli_CPF ,cat_Id ,cli_data_nasc, cli_Logradouro, cli_Numero, 
        'cli_Complemento, cli_CEP, cli_Bairro, cli_Cidade, cli_UF, cli_FoneRes, cli_FoneCel, 
        'cli_Email, cli_Observacoes
        'strQuery.Append(" UPDATE tbClientes ")
        'strQuery.Append(" SET ")
        'strQuery.Append(" cli_Nome = '" & cli_Nome & "' ")
        'strQuery.Append(", cli_CNPJ = '" & _cli_CNPJ & "' ")
        'strQuery.Append(", cli_CPF = '" & _cli_CPF & "' ")
        'strQuery.Append(", cat_Id = " & _clsCategoria.cat_ID & "' ")
        'strQuery.Append(", cli_data_nasc = '" & _cli_data_nasc & "' ")
        'strQuery.Append(", cli_Logradouro = '" & _cli_Logradouro & "' ")
        'strQuery.Append(", cli_Numero = '" & _cli_Numero & "' ")
        'strQuery.Append(", cli_Complemento = '" & _cli_complemento & "' ")
        'strQuery.Append(", cli_CEP = '" & _cli_CEP & "' ")
        'strQuery.Append(", cli_Bairro = '" & _cli_Bairro & "' ")
        'strQuery.Append(", cli_Cidade = '" & _cli_Cidade & "' ")
        'strQuery.Append(", cli_UF = '" & _cli_UF & "' ")
        'strQuery.Append(", cli_FoneRes = '" & _cli_FoneRes & "' ")
        'strQuery.Append(", cli_FoneCel = '" & _cli_FoneCel & "' ")
        'strQuery.Append(", cli_Email = '" & _cli_Email & "' ")
        'strQuery.Append(", cli_Observacoes = '" & _cli_observacoes & "' ")
        'strQuery.Append(" WHERE ")
        'strQuery.Append(" cli_Id = " & _cli_id & " ")

        'Executa o método ExecutaComando da classe de banco de dados
        'Dim cldBancoDados As New cldBancoDados()
        'cldBancoDados.ExecutaComando(strQuery.ToString)
    End Sub

    '  Public Function Listar(ByVal strDescricao As String) As DataSet
    'Cria um StringBuilder para concatenar a Query Sql
    'Dim strQuery As New StringBuilder
    '    strQuery.Append(" SELECT cli_Id as Codigo,cli_CPF as CPF,cli_Nome as Descricao, cli_data_nasc as Data_Nasc ")
    '   strQuery.Append(" FROM tbClientes")
    '   If Not strDescricao.Equals(String.Empty) Then
    '        strQuery.Append(" WHERE cli_Nome like '%" & strDescricao & "%' ")
    '    End If


    'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
    'Dim cldBancoDados As New cldBancoDados()
    'Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    '   End Function

    ' Public Sub Excluir(ByVal intCodigo As Integer)
    'Cria um StringBuilder para concatenar a Query Sql
    'Dim strQuery As New StringBuilder
    '   strQuery.Append(" DELETE FROM tbClientes ")
    '   strQuery.Append(" WHERE cli_id = " & intCodigo & "")

    'Executa o método ExecutaComando da classe de banco de dados
    'Dim cldBancoDados As New cldBancoDados()
    'cldBancoDados.ExecutaComando(strQuery.ToString)
    ' End Sub

    ' Public Function ListarCliente(ByVal intCodigo As Integer) As OleDbDataReader
    'Cria um StringBuilder para concatenar a Query Sql
    'Dim strQuery As New StringBuilder
    '   strQuery.Append(" SELECT * FROM tbClientes WHERE cli_id = " & intCodigo & " ")
    'strQuery.Append(" SELECT cli_id, cli_CPF,cli_RG, cli_Nome, cli_PIS, cli_TitEleitoral, cli_Logradouro, cli_Numero,cli_complemento, cli_Bairro, cli_Cidade, cli_UF, cli_CEP,cli_FoneRes, cli_FoneCel, cli_data_nasc, cli_Curriculo, cli_Email, vinc_id, cli_observacoes, cli_Aposentado, cli_NumBeneficio, cli_FuncPublico, cli_NomeFunc, cli_Autonomo, cli_AutonomoNome, cli_Falecido, cli_NomeFalecido, cli_Parcelamento, cli_NumParcelamento, cli_EmprDom, cli_ESocial, cli_VIP, cli_VIPDescricao, cli_PJ, cli_NumPJ, cli_MEI, cli_NumMEI, cli_ITR, cli_NumITR, cli_Mensalista, cli_NomeMensalista, cli_Decore, cli_DecoreDescricao, cli_IRPF, cli_NumIRPF, cli_SenWebPrefeitura, cli_SenhaWebPrefeitura, cli_SenhaWebValidade ")
    'strQuery.Append(" FROM tbClientes ")
    'strQuery.Append(" WHERE cli_id = " & intCodigo & " ")

    'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
    'Dim cldBancoDados As New cldBancoDados()
    'Return cldBancoDados.RetornaDataReader(strQuery.ToString)
    '   End Function

    'cli_id,cli_CPF,cli_RG,cli_Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,
    'cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_data_nasc,cli_Curriculo,cli_Email,
    'vinc_id,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,
    'cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,
    'cli_ESocial,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,
    'cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,
    'cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_SenhaWebValidade,cli_DtCadastro

    'Public Function ConsultarCliente()
    '    Dim dr As OleDbDataReader = Nothing
    '    Using con As OleDbConnection = GetConnection()
    '        Try
    '            con.Open()
    '            sql = "SELECT * FROM tbClientes WHERE cli_CPF=" & cli_CPF & ""
    '            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
    '            dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
    '            If dr.HasRows Then
    '                dr.Read()
    '                ' txtLogin.Text = dr.Item("login")
    '                '  txtSenha.Text = dr.Item("senha")
    '                '  txtPerfil.Text = dr.Item("perfil")
    '            Else
    '                MsgBox("Não foi possível carregar os dados.", MsgBoxStyle.Critical, "Aviso do Sistema")
    '            End If

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        Finally
    '            dr.Close()
    '            con.Close()
    '        End Try
    '    End Using

    'End Function


End Class
