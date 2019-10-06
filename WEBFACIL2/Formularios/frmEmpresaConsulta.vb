Public Class frmEmpresaConsulta
    Public Enum TipoConsulta
        Cliente
        '  Empresa
    End Enum
    Private Sub CarregaGrid()
        Dim dsConsulta As New Data.DataSet
        Select _ConsultaTipo
            Case TipoConsulta.Cliente
                Dim clnCliente As New clsCliente
                dsConsulta = clnCliente.Listar(txtCPFConsulta.Text)

        End Select
        dgvGridEmpresa.DataSource = dsConsulta.Tables(0)

    End Sub
    Private _ConsultaTipo As TipoConsulta
    Public Property ConsultaTipo() As TipoConsulta
        Get
            Return _ConsultaTipo
        End Get
        Set(ByVal value As TipoConsulta)
            _ConsultaTipo = value
        End Set
    End Property

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

    Private _cli_Situacao As String
    Public Property cli_Situacao() As String
        Get
            Return _cli_Situacao
        End Get
        Set(ByVal value As String)
            _cli_Situacao = value
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

    Private Sub btPesquisaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisaEmpresa.Click
        CarregaGrid()
    End Sub

    Private Sub btEnviarDadosEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarDadosEmpresa.Click
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente
                If dgvGridEmpresa.RowCount <> 0 Then
                    'ENVIO DE DADOS DO CLIENTE
                    _cli_id = dgvGridEmpresa.CurrentRow.Cells(0).Value
                    _cli_CPF = dgvGridEmpresa.CurrentRow.Cells(1).Value
                    _cli_Situacao = dgvGridEmpresa.CurrentRow.Cells(2).Value.ToString
                    _cli_RG = dgvGridEmpresa.CurrentRow.Cells(3).Value
                    _cli_Nome = dgvGridEmpresa.CurrentRow.Cells(4).Value
                    _cli_PIS = dgvGridEmpresa.CurrentRow.Cells(5).Value
                    _cli_TitEleitoral = dgvGridEmpresa.CurrentRow.Cells(6).Value
                    _cli_Logradouro = dgvGridEmpresa.CurrentRow.Cells(7).Value
                    _cli_Numero = dgvGridEmpresa.CurrentRow.Cells(8).Value
                    _cli_complemento = dgvGridEmpresa.CurrentRow.Cells(9).Value
                    _cli_Bairro = dgvGridEmpresa.CurrentRow.Cells(10).Value
                    _cli_Cidade = dgvGridEmpresa.CurrentRow.Cells(11).Value
                    _cli_UF = dgvGridEmpresa.CurrentRow.Cells(12).Value
                    _cli_CEP = dgvGridEmpresa.CurrentRow.Cells(13).Value
                    _cli_FoneRes = dgvGridEmpresa.CurrentRow.Cells(14).Value
                    _cli_FoneCel = dgvGridEmpresa.CurrentRow.Cells(15).Value
                    _cli_data_nasc = dgvGridEmpresa.CurrentRow.Cells(16).Value
                    _cli_Curriculo = dgvGridEmpresa.CurrentRow.Cells(17).Value
                    _cli_Email = dgvGridEmpresa.CurrentRow.Cells(18).Value
                    _cli_observacoes = dgvGridEmpresa.CurrentRow.Cells(19).Value
                    _cli_Aposentado = dgvGridEmpresa.CurrentRow.Cells(20).Value
                    _cli_NumBeneficio = dgvGridEmpresa.CurrentRow.Cells(21).Value
                    _cli_FuncPublico = dgvGridEmpresa.CurrentRow.Cells(22).Value
                    _cli_NomeFunc = dgvGridEmpresa.CurrentRow.Cells(23).Value
                    _cli_Autonomo = dgvGridEmpresa.CurrentRow.Cells(24).Value
                    _cli_AutonomoNome = dgvGridEmpresa.CurrentRow.Cells(25).Value
                    _cli_Falecido = dgvGridEmpresa.CurrentRow.Cells(26).Value
                    _cli_NomeFalecido = dgvGridEmpresa.CurrentRow.Cells(27).Value
                    _cli_Inativo = dgvGridEmpresa.CurrentRow.Cells(28).Value
                    _cli_InativoObs = dgvGridEmpresa.CurrentRow.Cells(29).Value
                    _cli_Parcelamento = dgvGridEmpresa.CurrentRow.Cells(30).Value
                    _cli_NumParcelamento = dgvGridEmpresa.CurrentRow.Cells(31).Value
                    _cli_EmprDom = dgvGridEmpresa.CurrentRow.Cells(32).Value
                    _cli_ESocial = dgvGridEmpresa.CurrentRow.Cells(33).Value
                    _cli_EsocialSenha = dgvGridEmpresa.CurrentRow.Cells(34).Value
                    _cli_VIP = dgvGridEmpresa.CurrentRow.Cells(35).Value
                    _cli_VIPDescricao = dgvGridEmpresa.CurrentRow.Cells(36).Value
                    _cli_PJ = dgvGridEmpresa.CurrentRow.Cells(37).Value
                    _cli_NumPJ = dgvGridEmpresa.CurrentRow.Cells(38).Value
                    _cli_MEI = dgvGridEmpresa.CurrentRow.Cells(39).Value
                    _cli_NumMEI = dgvGridEmpresa.CurrentRow.Cells(40).Value
                    _cli_ITR = dgvGridEmpresa.CurrentRow.Cells(41).Value
                    _cli_NumITR = dgvGridEmpresa.CurrentRow.Cells(42).Value
                    _cli_Mensalista = dgvGridEmpresa.CurrentRow.Cells(43).Value
                    _cli_NomeMensalista = dgvGridEmpresa.CurrentRow.Cells(44).Value
                    _cli_Decore = dgvGridEmpresa.CurrentRow.Cells(45).Value
                    _cli_DecoreDescricao = dgvGridEmpresa.CurrentRow.Cells(46).Value
                    _cli_IRPF = dgvGridEmpresa.CurrentRow.Cells(47).Value
                    _cli_NumIRPF = dgvGridEmpresa.CurrentRow.Cells(48).Value
                    _cli_SenWebPrefeitura = dgvGridEmpresa.CurrentRow.Cells(49).Value
                    _cli_SenhaWebPrefeitura = dgvGridEmpresa.CurrentRow.Cells(50).Value
                    _cli_Redesim = dgvGridEmpresa.CurrentRow.Cells(51).Value
                    _cli_SenhaRedesim = dgvGridEmpresa.CurrentRow.Cells(52).Value
                    _cli_CodRFB = dgvGridEmpresa.CurrentRow.Cells(53).Value
                    _cli_CodRFBNum = dgvGridEmpresa.CurrentRow.Cells(54).Value
                    _cli_CodRFBValidade = dgvGridEmpresa.CurrentRow.Cells(55).Value

                    'ENVIO DE DADOS DA EMPRESA
                    _empr_ID = dgvGridEmpresa.CurrentRow.Cells(56).Value
                    _empr_razaosocial = dgvGridEmpresa.CurrentRow.Cells(57).Value
                    _empr_nomefantasia = dgvGridEmpresa.CurrentRow.Cells(58).Value
                    _empr_cnpj = dgvGridEmpresa.CurrentRow.Cells(59).Value 'empr_Situacaocnpj
                    _empr_Situacaocnpj = dgvGridEmpresa.CurrentRow.Cells(60).Value.ToString
                    _empr_NIRE = dgvGridEmpresa.CurrentRow.Cells(61).Value
                    _empr_InscrEstadual = dgvGridEmpresa.CurrentRow.Cells(62).Value
                    _empr_CCM = dgvGridEmpresa.CurrentRow.Cells(63).Value
                    _empr_atividade = dgvGridEmpresa.CurrentRow.Cells(64).Value
                    _empr_Porte = dgvGridEmpresa.CurrentRow.Cells(65).Value
                    _empr_lblclienteID = dgvGridEmpresa.CurrentRow.Cells(66).Value
                    ' _clsCategoria.cat_ID = dgvGridEmpresa.CurrentRow.Cells(67).Value
                    _empr_dataInicio = dgvGridEmpresa.CurrentRow.Cells(68).Value
                    _empr_endereco = dgvGridEmpresa.CurrentRow.Cells(69).Value
                    _empr_numero = dgvGridEmpresa.CurrentRow.Cells(70).Value
                    _empr_complemento = dgvGridEmpresa.CurrentRow.Cells(71).Value
                    _empr_bairro = dgvGridEmpresa.CurrentRow.Cells(72).Value
                    _empr_cidade = dgvGridEmpresa.CurrentRow.Cells(73).Value
                    _empr_UF = dgvGridEmpresa.CurrentRow.Cells(74).Value
                    _empr_CEP = dgvGridEmpresa.CurrentRow.Cells(75).Value
                    _empr_obs = dgvGridEmpresa.CurrentRow.Cells(76).Value
                    _empr_Simples = dgvGridEmpresa.CurrentRow.Cells(77).Value
                    _empr_SimplesNacional = dgvGridEmpresa.CurrentRow.Cells(78).Value
                    _empr_Simei = dgvGridEmpresa.CurrentRow.Cells(79).Value
                    _empr_CodSimei = dgvGridEmpresa.CurrentRow.Cells(80).Value
                    _empr_sefaz = dgvGridEmpresa.CurrentRow.Cells(81).Value
                    _empr_SefazUsu = dgvGridEmpresa.CurrentRow.Cells(82).Value
                    _empr_SefazSen = dgvGridEmpresa.CurrentRow.Cells(83).Value
                    _empr_CodReceitaPJ = dgvGridEmpresa.CurrentRow.Cells(84).Value
                    _empr_NumCodReceitaPJ = dgvGridEmpresa.CurrentRow.Cells(85).Value
                    Me.Close()

                End If
        End Select

    End Sub

    Private Sub dgvGridEmpresa_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvGridEmpresa.DoubleClick
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente
                If dgvGridEmpresa.RowCount <> 0 Then
                    'ENVIO DE DADOS DO CLIENTE
                    _cli_id = dgvGridEmpresa.CurrentRow.Cells(0).Value
                    _cli_CPF = dgvGridEmpresa.CurrentRow.Cells(1).Value
                    _cli_Situacao = dgvGridEmpresa.CurrentRow.Cells(2).Value.ToString
                    _cli_RG = dgvGridEmpresa.CurrentRow.Cells(3).Value
                    _cli_Nome = dgvGridEmpresa.CurrentRow.Cells(4).Value
                    _cli_PIS = dgvGridEmpresa.CurrentRow.Cells(5).Value
                    _cli_TitEleitoral = dgvGridEmpresa.CurrentRow.Cells(6).Value
                    _cli_Logradouro = dgvGridEmpresa.CurrentRow.Cells(7).Value
                    _cli_Numero = dgvGridEmpresa.CurrentRow.Cells(8).Value
                    _cli_complemento = dgvGridEmpresa.CurrentRow.Cells(9).Value
                    _cli_Bairro = dgvGridEmpresa.CurrentRow.Cells(10).Value
                    _cli_Cidade = dgvGridEmpresa.CurrentRow.Cells(11).Value
                    _cli_UF = dgvGridEmpresa.CurrentRow.Cells(12).Value
                    _cli_CEP = dgvGridEmpresa.CurrentRow.Cells(13).Value
                    _cli_FoneRes = dgvGridEmpresa.CurrentRow.Cells(14).Value
                    _cli_FoneCel = dgvGridEmpresa.CurrentRow.Cells(15).Value
                    _cli_data_nasc = dgvGridEmpresa.CurrentRow.Cells(16).Value
                    _cli_Curriculo = dgvGridEmpresa.CurrentRow.Cells(17).Value
                    _cli_Email = dgvGridEmpresa.CurrentRow.Cells(18).Value
                    _cli_observacoes = dgvGridEmpresa.CurrentRow.Cells(19).Value
                    _cli_Aposentado = dgvGridEmpresa.CurrentRow.Cells(20).Value
                    _cli_NumBeneficio = dgvGridEmpresa.CurrentRow.Cells(21).Value
                    _cli_FuncPublico = dgvGridEmpresa.CurrentRow.Cells(22).Value
                    _cli_NomeFunc = dgvGridEmpresa.CurrentRow.Cells(23).Value
                    _cli_Autonomo = dgvGridEmpresa.CurrentRow.Cells(24).Value
                    _cli_AutonomoNome = dgvGridEmpresa.CurrentRow.Cells(25).Value
                    _cli_Falecido = dgvGridEmpresa.CurrentRow.Cells(26).Value
                    _cli_NomeFalecido = dgvGridEmpresa.CurrentRow.Cells(27).Value
                    _cli_Inativo = dgvGridEmpresa.CurrentRow.Cells(28).Value
                    _cli_InativoObs = dgvGridEmpresa.CurrentRow.Cells(29).Value
                    _cli_Parcelamento = dgvGridEmpresa.CurrentRow.Cells(30).Value
                    _cli_NumParcelamento = dgvGridEmpresa.CurrentRow.Cells(31).Value
                    _cli_EmprDom = dgvGridEmpresa.CurrentRow.Cells(32).Value
                    _cli_ESocial = dgvGridEmpresa.CurrentRow.Cells(33).Value
                    _cli_EsocialSenha = dgvGridEmpresa.CurrentRow.Cells(34).Value
                    _cli_VIP = dgvGridEmpresa.CurrentRow.Cells(35).Value
                    _cli_VIPDescricao = dgvGridEmpresa.CurrentRow.Cells(36).Value
                    _cli_PJ = dgvGridEmpresa.CurrentRow.Cells(37).Value
                    _cli_NumPJ = dgvGridEmpresa.CurrentRow.Cells(38).Value
                    _cli_MEI = dgvGridEmpresa.CurrentRow.Cells(39).Value
                    _cli_NumMEI = dgvGridEmpresa.CurrentRow.Cells(40).Value
                    _cli_ITR = dgvGridEmpresa.CurrentRow.Cells(41).Value
                    _cli_NumITR = dgvGridEmpresa.CurrentRow.Cells(42).Value
                    _cli_Mensalista = dgvGridEmpresa.CurrentRow.Cells(43).Value
                    _cli_NomeMensalista = dgvGridEmpresa.CurrentRow.Cells(44).Value
                    _cli_Decore = dgvGridEmpresa.CurrentRow.Cells(45).Value
                    _cli_DecoreDescricao = dgvGridEmpresa.CurrentRow.Cells(46).Value
                    _cli_IRPF = dgvGridEmpresa.CurrentRow.Cells(47).Value
                    _cli_NumIRPF = dgvGridEmpresa.CurrentRow.Cells(48).Value
                    _cli_SenWebPrefeitura = dgvGridEmpresa.CurrentRow.Cells(49).Value
                    _cli_SenhaWebPrefeitura = dgvGridEmpresa.CurrentRow.Cells(50).Value
                    _cli_Redesim = dgvGridEmpresa.CurrentRow.Cells(51).Value
                    _cli_SenhaRedesim = dgvGridEmpresa.CurrentRow.Cells(52).Value
                    _cli_CodRFB = dgvGridEmpresa.CurrentRow.Cells(53).Value
                    _cli_CodRFBNum = dgvGridEmpresa.CurrentRow.Cells(54).Value
                    _cli_CodRFBValidade = dgvGridEmpresa.CurrentRow.Cells(55).Value

                    'ENVIO DE DADOS DA EMPRESA
                    _empr_ID = dgvGridEmpresa.CurrentRow.Cells(56).Value
                    _empr_razaosocial = dgvGridEmpresa.CurrentRow.Cells(57).Value
                    _empr_nomefantasia = dgvGridEmpresa.CurrentRow.Cells(58).Value
                    _empr_cnpj = dgvGridEmpresa.CurrentRow.Cells(59).Value 'empr_Situacaocnpj
                    _empr_Situacaocnpj = dgvGridEmpresa.CurrentRow.Cells(60).Value.ToString
                    _empr_NIRE = dgvGridEmpresa.CurrentRow.Cells(61).Value
                    _empr_InscrEstadual = dgvGridEmpresa.CurrentRow.Cells(62).Value
                    _empr_CCM = dgvGridEmpresa.CurrentRow.Cells(63).Value
                    _empr_atividade = dgvGridEmpresa.CurrentRow.Cells(64).Value
                    _empr_Porte = dgvGridEmpresa.CurrentRow.Cells(65).Value
                    _empr_lblclienteID = dgvGridEmpresa.CurrentRow.Cells(66).Value
                    ' _clsCategoria.cat_ID = dgvGridEmpresa.CurrentRow.Cells(67).Value
                    _empr_dataInicio = dgvGridEmpresa.CurrentRow.Cells(68).Value
                    _empr_endereco = dgvGridEmpresa.CurrentRow.Cells(69).Value
                    _empr_numero = dgvGridEmpresa.CurrentRow.Cells(70).Value
                    _empr_complemento = dgvGridEmpresa.CurrentRow.Cells(71).Value
                    _empr_bairro = dgvGridEmpresa.CurrentRow.Cells(72).Value
                    _empr_cidade = dgvGridEmpresa.CurrentRow.Cells(73).Value
                    _empr_UF = dgvGridEmpresa.CurrentRow.Cells(74).Value
                    _empr_CEP = dgvGridEmpresa.CurrentRow.Cells(75).Value
                    _empr_obs = dgvGridEmpresa.CurrentRow.Cells(76).Value
                    _empr_Simples = dgvGridEmpresa.CurrentRow.Cells(77).Value
                    _empr_SimplesNacional = dgvGridEmpresa.CurrentRow.Cells(78).Value
                    _empr_Simei = dgvGridEmpresa.CurrentRow.Cells(79).Value
                    _empr_CodSimei = dgvGridEmpresa.CurrentRow.Cells(80).Value
                    _empr_sefaz = dgvGridEmpresa.CurrentRow.Cells(81).Value
                    _empr_SefazUsu = dgvGridEmpresa.CurrentRow.Cells(82).Value
                    _empr_SefazSen = dgvGridEmpresa.CurrentRow.Cells(83).Value
                    _empr_CodReceitaPJ = dgvGridEmpresa.CurrentRow.Cells(84).Value
                    _empr_NumCodReceitaPJ = dgvGridEmpresa.CurrentRow.Cells(85).Value
                    Me.Close()

                End If
        End Select
    End Sub

    Private Sub btFecharEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFecharEmpresa.Click
        Me.Close()
    End Sub
End Class