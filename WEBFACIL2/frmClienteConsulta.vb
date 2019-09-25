
Public Class frmClienteConsulta
    Public Enum TipoConsulta
        Cliente
        '  Empresa
    End Enum

    Private Sub CarregaGrid()
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente
                Dim clnCliente As New clsCliente
                dsConsulta = clnCliente.Listar(txtCPFPesquisa.Text)

                'Case TipoConsulta.Empresa
                '    Dim clnEmpresa As New clsEmpresa
                '    dsConsulta = clnEmpresa.Listar(txtCPFPesquisa.Text)
        End Select
        dgvGrid.DataSource = dsConsulta.Tables(0)
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


    Private Sub btPesquisaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisaCliente.Click
        CarregaGrid()
    End Sub

    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub btEnviarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarDados.Click
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente
                If dgvGrid.RowCount <> 0 Then
                    _cli_id = dgvGrid.CurrentRow.Cells(0).Value
                    _cli_CPF = dgvGrid.CurrentRow.Cells(1).Value
                    _cli_RG = dgvGrid.CurrentRow.Cells(2).Value
                    _cli_Nome = dgvGrid.CurrentRow.Cells(3).Value
                    _cli_PIS = dgvGrid.CurrentRow.Cells(4).Value
                    _cli_TitEleitoral = dgvGrid.CurrentRow.Cells(5).Value
                    _cli_Logradouro = dgvGrid.CurrentRow.Cells(6).Value
                    _cli_Numero = dgvGrid.CurrentRow.Cells(7).Value
                    _cli_complemento = dgvGrid.CurrentRow.Cells(8).Value
                    _cli_Bairro = dgvGrid.CurrentRow.Cells(9).Value
                    _cli_Cidade = dgvGrid.CurrentRow.Cells(10).Value
                    _cli_UF = dgvGrid.CurrentRow.Cells(11).Value
                    _cli_CEP = dgvGrid.CurrentRow.Cells(12).Value
                    _cli_FoneRes = dgvGrid.CurrentRow.Cells(13).Value
                    _cli_FoneCel = dgvGrid.CurrentRow.Cells(14).Value
                    _cli_data_nasc = dgvGrid.CurrentRow.Cells(15).Value
                    _cli_Curriculo = dgvGrid.CurrentRow.Cells(16).Value
                    _cli_Email = dgvGrid.CurrentRow.Cells(17).Value
                    _cli_observacoes = dgvGrid.CurrentRow.Cells(18).Value
                    _cli_Aposentado = dgvGrid.CurrentRow.Cells(19).Value
                    _cli_NumBeneficio = dgvGrid.CurrentRow.Cells(20).Value
                    _cli_FuncPublico = dgvGrid.CurrentRow.Cells(21).Value
                    _cli_NomeFunc = dgvGrid.CurrentRow.Cells(22).Value
                    _cli_Autonomo = dgvGrid.CurrentRow.Cells(23).Value
                    _cli_AutonomoNome = dgvGrid.CurrentRow.Cells(24).Value
                    _cli_Falecido = dgvGrid.CurrentRow.Cells(25).Value
                    _cli_NomeFalecido = dgvGrid.CurrentRow.Cells(26).Value
                    _cli_Inativo = dgvGrid.CurrentRow.Cells(27).Value
                    _cli_InativoObs = dgvGrid.CurrentRow.Cells(28).Value
                    _cli_Parcelamento = dgvGrid.CurrentRow.Cells(29).Value
                    _cli_NumParcelamento = dgvGrid.CurrentRow.Cells(30).Value
                    _cli_EmprDom = dgvGrid.CurrentRow.Cells(31).Value
                    _cli_ESocial = dgvGrid.CurrentRow.Cells(32).Value
                    _cli_EsocialSenha = dgvGrid.CurrentRow.Cells(33).Value
                    _cli_VIP = dgvGrid.CurrentRow.Cells(34).Value
                    _cli_VIPDescricao = dgvGrid.CurrentRow.Cells(35).Value
                    _cli_PJ = dgvGrid.CurrentRow.Cells(36).Value
                    _cli_NumPJ = dgvGrid.CurrentRow.Cells(37).Value
                    _cli_MEI = dgvGrid.CurrentRow.Cells(38).Value
                    _cli_NumMEI = dgvGrid.CurrentRow.Cells(39).Value
                    _cli_ITR = dgvGrid.CurrentRow.Cells(40).Value
                    _cli_NumITR = dgvGrid.CurrentRow.Cells(41).Value
                    _cli_Mensalista = dgvGrid.CurrentRow.Cells(42).Value
                    _cli_NomeMensalista = dgvGrid.CurrentRow.Cells(43).Value
                    _cli_Decore = dgvGrid.CurrentRow.Cells(44).Value
                    _cli_DecoreDescricao = dgvGrid.CurrentRow.Cells(45).Value
                    _cli_IRPF = dgvGrid.CurrentRow.Cells(46).Value
                    _cli_NumIRPF = dgvGrid.CurrentRow.Cells(47).Value
                    _cli_SenWebPrefeitura = dgvGrid.CurrentRow.Cells(48).Value
                    _cli_SenhaWebPrefeitura = dgvGrid.CurrentRow.Cells(49).Value
                    _cli_Redesim = dgvGrid.CurrentRow.Cells(50).Value
                    _cli_SenhaRedesim = dgvGrid.CurrentRow.Cells(51).Value
                    _cli_CodRFB = dgvGrid.CurrentRow.Cells(52).Value
                    _cli_CodRFBNum = dgvGrid.CurrentRow.Cells(53).Value
                    _cli_CodRFBValidade = dgvGrid.CurrentRow.Cells(54).Value
                    '  End If
                    'ENVIO DE DADOS DA EMPRESA
                    _empr_ID = dgvGrid.CurrentRow.Cells(55).Value
                    _empr_razaosocial = dgvGrid.CurrentRow.Cells(56).Value
                    _empr_nomefantasia = dgvGrid.CurrentRow.Cells(57).Value
                    _empr_cnpj = dgvGrid.CurrentRow.Cells(58).Value
                    _empr_NIRE = dgvGrid.CurrentRow.Cells(59).Value
                    _empr_InscrEstadual = dgvGrid.CurrentRow.Cells(60).Value
                    _empr_CCM = dgvGrid.CurrentRow.Cells(61).Value
                    _empr_atividade = dgvGrid.CurrentRow.Cells(62).Value
                    _empr_Porte = dgvGrid.CurrentRow.Cells(63).Value
                    _empr_lblclienteID = dgvGrid.CurrentRow.Cells(64).Value
                    ' _clsCategoria.cat_ID = dgvGrid.CurrentRow.Cells(65).Value
                    _empr_dataInicio = dgvGrid.CurrentRow.Cells(66).Value
                    _empr_endereco = dgvGrid.CurrentRow.Cells(67).Value
                    _empr_numero = dgvGrid.CurrentRow.Cells(68).Value
                    _empr_complemento = dgvGrid.CurrentRow.Cells(69).Value
                    _empr_bairro = dgvGrid.CurrentRow.Cells(70).Value
                    _empr_cidade = dgvGrid.CurrentRow.Cells(71).Value
                    _empr_UF = dgvGrid.CurrentRow.Cells(72).Value
                    _empr_CEP = dgvGrid.CurrentRow.Cells(73).Value
                    _empr_obs = dgvGrid.CurrentRow.Cells(74).Value
                    _empr_Simples = dgvGrid.CurrentRow.Cells(75).Value
                    _empr_SimplesNacional = dgvGrid.CurrentRow.Cells(76).Value
                    _empr_Simei = dgvGrid.CurrentRow.Cells(77).Value
                    _empr_CodSimei = dgvGrid.CurrentRow.Cells(78).Value
                    _empr_sefaz = dgvGrid.CurrentRow.Cells(79).Value
                    _empr_SefazUsu = dgvGrid.CurrentRow.Cells(80).Value
                    _empr_SefazSen = dgvGrid.CurrentRow.Cells(81).Value
                    _empr_CodReceitaPJ = dgvGrid.CurrentRow.Cells(82).Value
                    _empr_NumCodReceitaPJ = dgvGrid.CurrentRow.Cells(83).Value
                    Me.Close()

                End If

        End Select
    End Sub

    Private Sub dgvGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvGrid.DoubleClick
        If dgvGrid.RowCount <> 0 Then
            _cli_id = dgvGrid.CurrentRow.Cells(0).Value
            _cli_CPF = dgvGrid.CurrentRow.Cells(1).Value
            _cli_RG = dgvGrid.CurrentRow.Cells(2).Value
            _cli_Nome = dgvGrid.CurrentRow.Cells(3).Value
            _cli_PIS = dgvGrid.CurrentRow.Cells(4).Value
            _cli_TitEleitoral = dgvGrid.CurrentRow.Cells(5).Value
            _cli_Logradouro = dgvGrid.CurrentRow.Cells(6).Value
            _cli_Numero = dgvGrid.CurrentRow.Cells(7).Value
            _cli_complemento = dgvGrid.CurrentRow.Cells(8).Value
            _cli_Bairro = dgvGrid.CurrentRow.Cells(9).Value
            _cli_Cidade = dgvGrid.CurrentRow.Cells(10).Value
            _cli_UF = dgvGrid.CurrentRow.Cells(11).Value
            _cli_CEP = dgvGrid.CurrentRow.Cells(12).Value
            _cli_FoneRes = dgvGrid.CurrentRow.Cells(13).Value
            _cli_FoneCel = dgvGrid.CurrentRow.Cells(14).Value
            _cli_data_nasc = dgvGrid.CurrentRow.Cells(15).Value
            _cli_Curriculo = dgvGrid.CurrentRow.Cells(16).Value
            _cli_Email = dgvGrid.CurrentRow.Cells(17).Value
            _cli_observacoes = dgvGrid.CurrentRow.Cells(18).Value
            _cli_Aposentado = dgvGrid.CurrentRow.Cells(19).Value
            _cli_NumBeneficio = dgvGrid.CurrentRow.Cells(20).Value
            _cli_FuncPublico = dgvGrid.CurrentRow.Cells(21).Value
            _cli_NomeFunc = dgvGrid.CurrentRow.Cells(22).Value
            _cli_Autonomo = dgvGrid.CurrentRow.Cells(23).Value
            _cli_AutonomoNome = dgvGrid.CurrentRow.Cells(24).Value
            _cli_Falecido = dgvGrid.CurrentRow.Cells(25).Value
            _cli_NomeFalecido = dgvGrid.CurrentRow.Cells(26).Value
            _cli_Inativo = dgvGrid.CurrentRow.Cells(27).Value
            _cli_InativoObs = dgvGrid.CurrentRow.Cells(28).Value
            _cli_Parcelamento = dgvGrid.CurrentRow.Cells(29).Value
            _cli_NumParcelamento = dgvGrid.CurrentRow.Cells(30).Value
            _cli_EmprDom = dgvGrid.CurrentRow.Cells(31).Value
            _cli_ESocial = dgvGrid.CurrentRow.Cells(32).Value
            _cli_EsocialSenha = dgvGrid.CurrentRow.Cells(33).Value
            _cli_VIP = dgvGrid.CurrentRow.Cells(34).Value
            _cli_VIPDescricao = dgvGrid.CurrentRow.Cells(35).Value
            _cli_PJ = dgvGrid.CurrentRow.Cells(36).Value
            _cli_NumPJ = dgvGrid.CurrentRow.Cells(37).Value
            _cli_MEI = dgvGrid.CurrentRow.Cells(38).Value
            _cli_NumMEI = dgvGrid.CurrentRow.Cells(39).Value
            _cli_ITR = dgvGrid.CurrentRow.Cells(40).Value
            _cli_NumITR = dgvGrid.CurrentRow.Cells(41).Value
            _cli_Mensalista = dgvGrid.CurrentRow.Cells(42).Value
            _cli_NomeMensalista = dgvGrid.CurrentRow.Cells(43).Value
            _cli_Decore = dgvGrid.CurrentRow.Cells(44).Value
            _cli_DecoreDescricao = dgvGrid.CurrentRow.Cells(45).Value
            _cli_IRPF = dgvGrid.CurrentRow.Cells(46).Value
            _cli_NumIRPF = dgvGrid.CurrentRow.Cells(47).Value
            _cli_SenWebPrefeitura = dgvGrid.CurrentRow.Cells(48).Value
            _cli_SenhaWebPrefeitura = dgvGrid.CurrentRow.Cells(49).Value
            _cli_Redesim = dgvGrid.CurrentRow.Cells(50).Value
            _cli_SenhaRedesim = dgvGrid.CurrentRow.Cells(51).Value
            _cli_CodRFB = dgvGrid.CurrentRow.Cells(52).Value
            _cli_CodRFBNum = dgvGrid.CurrentRow.Cells(53).Value
            _cli_CodRFBValidade = dgvGrid.CurrentRow.Cells(54).Value
            'ENVIO DE DADOS DA EMPRESA
            _empr_ID = dgvGrid.CurrentRow.Cells(55).Value
            _empr_razaosocial = dgvGrid.CurrentRow.Cells(56).Value
            _empr_nomefantasia = dgvGrid.CurrentRow.Cells(57).Value
            _empr_cnpj = dgvGrid.CurrentRow.Cells(58).Value
            _empr_NIRE = dgvGrid.CurrentRow.Cells(59).Value
            _empr_InscrEstadual = dgvGrid.CurrentRow.Cells(60).Value
            _empr_CCM = dgvGrid.CurrentRow.Cells(61).Value
            _empr_atividade = dgvGrid.CurrentRow.Cells(62).Value
            _empr_Porte = dgvGrid.CurrentRow.Cells(63).Value
            _empr_lblclienteID = dgvGrid.CurrentRow.Cells(64).Value
            ' _clsCategoria.cat_ID = dgvGrid.CurrentRow.Cells(65).Value
            _empr_dataInicio = dgvGrid.CurrentRow.Cells(66).Value
            _empr_endereco = dgvGrid.CurrentRow.Cells(67).Value
            _empr_numero = dgvGrid.CurrentRow.Cells(68).Value
            _empr_complemento = dgvGrid.CurrentRow.Cells(69).Value
            _empr_bairro = dgvGrid.CurrentRow.Cells(70).Value
            _empr_cidade = dgvGrid.CurrentRow.Cells(71).Value
            _empr_UF = dgvGrid.CurrentRow.Cells(72).Value
            _empr_CEP = dgvGrid.CurrentRow.Cells(73).Value
            _empr_obs = dgvGrid.CurrentRow.Cells(74).Value
            _empr_Simples = dgvGrid.CurrentRow.Cells(75).Value
            _empr_SimplesNacional = dgvGrid.CurrentRow.Cells(76).Value
            _empr_Simei = dgvGrid.CurrentRow.Cells(77).Value
            _empr_CodSimei = dgvGrid.CurrentRow.Cells(78).Value
            _empr_sefaz = dgvGrid.CurrentRow.Cells(79).Value
            _empr_SefazUsu = dgvGrid.CurrentRow.Cells(80).Value
            _empr_SefazSen = dgvGrid.CurrentRow.Cells(81).Value
            _empr_CodReceitaPJ = dgvGrid.CurrentRow.Cells(82).Value
            _empr_NumCodReceitaPJ = dgvGrid.CurrentRow.Cells(83).Value

            Me.Close()
        End If
    End Sub
End Class