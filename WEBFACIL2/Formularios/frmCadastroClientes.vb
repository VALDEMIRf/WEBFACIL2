Imports System.Data.OleDb

Public Class frmCadastroClientes
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Dim CodigoCliente As Integer
    Dim CodigoEmpresa As Integer
    Dim cliente As New clsCliente
    Dim empresa As New clsEmpresa
    Public Enum TipoConsulta
        Cliente
        '  Empresa
    End Enum
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

    Private _cli_Nome As String
    Public Property cli_Nome() As String
        Get
            Return _cli_Nome
        End Get
        Set(ByVal value As String)
            _cli_Nome = value
        End Set
    End Property


    Private Sub frmCadastroClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCPF.Focus()
        TabEmpresa.Enabled = False

        Dim clnCategoria As New clsCategoria
        Dim dsCategoria As New Data.DataSet
        dsCategoria = clnCategoria.Listar("")
        With cbTipo
            .DataSource = dsCategoria.Tables(0)
            .DisplayMember = "Descricao"
            .ValueMember = "Codigo"
        End With

        Dim clnCliente As New clsCliente
        Dim dsCliente As New Data.DataSet
        dsCliente = clnCliente.ListarCpf("")
        With cboCliente
            .DataSource = dsCliente.Tables(0)
            .DisplayMember = "Descricao"
            .ValueMember = "Codigo"
        End With

    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click
        
        If txtCPF.Text.Equals(String.Empty) Then
            errErro.SetError(txtCPF, "Digite um CPF")
            txtCPF.Focus()
            Exit Sub
        Else
            errErro.SetError(txtCPF, "")

        End If
        If txtNome.Text.Equals(String.Empty) Then
            errErro.SetError(txtNome, "Digite um nome")
            Exit Sub
        Else
            errErro.SetError(txtNome, "")
        End If
        Try
            cliente.cli_CPF = txtCPF.Text
            cliente.cli_Situacao = cboSituacao.Text
            cliente.cli_RG = txtRG.Text
            cliente.cli_Nome = txtNome.Text
            cliente.cli_PIS = txtPIS.Text
            cliente.cli_TitEleitoral = txtTitEleitoral.Text
            cliente.cli_Logradouro = txtLogradouro.Text
            cliente.cli_Numero = txtNumero.Text
            cliente.cli_complemento = txtComplemento.Text
            cliente.cli_Bairro = txtBairro.Text
            cliente.cli_Cidade = txtCidade.Text
            cliente.cli_UF = cboUF.Text
            cliente.cli_CEP = txtCEP.Text
            cliente.cli_FoneRes = txtFoneRes.Text
            cliente.cli_FoneCel = txtFoneCel.Text
            cliente.cli_data_nasc = txtDtNasc.Text
            cliente.cli_Curriculo = chbCurriculo.Checked
            cliente.cli_Email = txtEmail.Text
            cliente.cli_observacoes = txtObs.Text
            cliente.cli_Aposentado = chbAposentado.Checked
            cliente.cli_NumBeneficio = txtNumBeneficio.Text
            cliente.cli_FuncPublico = chbFuncPublico.Checked
            cliente.cli_NomeFunc = txtFuncPublico.Text
            cliente.cli_Autonomo = chbAutonomo.Checked
            cliente.cli_AutonomoNome = txtAutonomo.Text
            cliente.cli_Falecido = chbFalecido.Checked
            cliente.cli_NomeFalecido = txtFalecido.Text
            cliente.cli_Inativo = chbInativo.Checked
            cliente.cli_InativoObs = txtInativo.Text
            cliente.cli_Parcelamento = chbParcelamentos.Checked
            cliente.cli_NumParcelamento = txtParcelamentos.Text
            cliente.cli_EmprDom = chbESocial.Checked
            cliente.cli_ESocial = txtESocial.Text
            cliente.cli_EsocialSenha = txtEsocialSenha.Text
            cliente.cli_VIP = chbVIP.Checked
            cliente.cli_VIPDescricao = txtVIP.Text
            cliente.cli_PJ = chbPJ.Checked
            cliente.cli_NumPJ = txtPJ.Text
            cliente.cli_MEI = chbMEI.Checked
            cliente.cli_NumMEI = txtMEI.Text
            cliente.cli_ITR = chbITR.Checked
            cliente.cli_NumITR = txtITR.Text
            cliente.cli_Mensalista = chbMensalista.Checked
            cliente.cli_NomeMensalista = txtMensalista.Text
            cliente.cli_Decore = chbDecore.Checked
            cliente.cli_DecoreDescricao = txtDecore.Text
            cliente.cli_IRPF = chbIRPF.Checked
            cliente.cli_NumIRPF = txtIRPF.Text
            cliente.cli_SenWebPrefeitura = chbSenhaWeb.Checked
            cliente.cli_SenhaWebPrefeitura = txtSenhaWeb.Text
            cliente.cli_Redesim = chbRedesim.Checked
            cliente.cli_SenhaRedesim = txtSenhaRedesim.Text
            cliente.cli_CodRFB = chbCodRFB.Checked
            cliente.cli_CodRFBNum = txtCodRFB.Text
            cliente.cli_CodRFBValidade = txtValidadeRFB.Text
            cliente.cli_DtCadastro = Now.Date

            cliente.GravarDados()

            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btEmpresaSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEmpresaSalvar.Click
        If txtRazaoSocial.Text.Equals(String.Empty) Then
            errErro.SetError(txtRazaoSocial, "Digite O nome da Empresa")
            Exit Sub
        Else
            errErro.SetError(txtRazaoSocial, "")
        End If
        If txtCNPJ.Text.Equals(String.Empty) Then
            errErro.SetError(txtCNPJ, "Digite o CNPJ da Empresa")
            Exit Sub
        Else
            errErro.SetError(txtCNPJ, "")

        End If
        Dim clnCategoria As New clsCategoria
        clnCategoria.cat_ID = cbTipo.SelectedValue

        Dim clnCliente As New clsCliente
        clnCliente.cli_id = cboCliente.SelectedValue


        Dim recebeIDCliente As Integer
        recebeIDCliente = lblciID.Text

        Try
            empresa.empr_razaosocial = txtRazaoSocial.Text
            empresa.empr_nomefantasia = txtNomeFantasia.Text
            empresa.empr_cnpj = txtCNPJ.Text
            empresa.empr_Situacaocnpj = cboSituacaoCNPJ.Text
            empresa.empr_NIRE = txtNIRE.Text
            empresa.empr_InscrEstadual = txtInscrEstadual.Text
            empresa.empr_CCM = txtCCM.Text
            empresa.empr_atividade = txtAtividade.Text
            empresa.empr_Porte = txtEmprPorte.Text
            empresa.empr_lblclienteID = lblclienteID.Text
            empresa.clsCategoria = clnCategoria
            empresa.empr_dataInicio = dtpDataInicio.Text
            empresa.empr_endereco = txtEmprEndereco.Text
            empresa.empr_numero = txtEmprNum.Text
            empresa.empr_complemento = txtEmprComplemento.Text
            empresa.empr_bairro = txtEmprBairro.Text
            empresa.empr_cidade = txtEmprCidade.Text
            empresa.empr_UF = txtEmprUF.Text
            empresa.empr_CEP = txtEmprCEP.Text
            empresa.empr_obs = txtEmprObs.Text
            empresa.empr_Simples = chbSimples.Checked
            empresa.empr_SimplesNacional = txtSimplesNacional.Text
            empresa.empr_Simei = chbSIMEI.Checked
            empresa.empr_CodSimei = txtEmprSimei.Text
            empresa.empr_sefaz = chbSefaz.Checked
            empresa.empr_SefazUsu = txtSefazUsu.Text
            empresa.empr_SefazSen = txtSefazSen.Text
            empresa.empr_CodReceitaPJ = chbSenhaWebPJ.Checked
            empresa.empr_NumCodReceitaPJ = txtSenhaWebPJ.Text

            empresa.GravarDados()
            LimparCampos()

        Catch ex As Exception
            ' MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLimpar.Click
        LimparCampos()
    End Sub

    Private Sub btPesquisarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisarCliente.Click
        Dim frmClienteConsulta As New frmClienteConsulta
        frmClienteConsulta.Text = "Consulta de Cliente"
        frmClienteConsulta.ConsultaTipo = frmClienteConsulta.TipoConsulta.Cliente
        frmClienteConsulta.ShowDialog()

        CodigoCliente = frmClienteConsulta.cli_id
        lblciID.Text = frmClienteConsulta.cli_id
        txtCPF.Text = frmClienteConsulta.cli_CPF
        cboSituacao.Text = frmClienteConsulta.cli_Situacao
        txtEmprCPF.Text = frmClienteConsulta.cli_CPF
        txtCPFRedesim.Text = frmClienteConsulta.cli_CPF
        lblclienteID.Text = frmClienteConsulta.cli_id
        txtRG.Text = frmClienteConsulta.cli_RG
        txtNome.Text = frmClienteConsulta.cli_Nome
        txtPIS.Text = frmClienteConsulta.cli_PIS
        txtTitEleitoral.Text = frmClienteConsulta.cli_TitEleitoral
        txtLogradouro.Text = frmClienteConsulta.cli_Logradouro
        txtNumero.Text = frmClienteConsulta.cli_Numero
        txtComplemento.Text = frmClienteConsulta.cli_complemento
        txtBairro.Text = frmClienteConsulta.cli_Bairro
        txtCidade.Text = frmClienteConsulta.cli_Cidade
        cboUF.Text = frmClienteConsulta.cli_UF
        txtCEP.Text = frmClienteConsulta.cli_CEP
        txtFoneRes.Text = frmClienteConsulta.cli_FoneRes
        txtFoneCel.Text = frmClienteConsulta.cli_FoneCel
        txtDtNasc.Text = frmClienteConsulta.cli_data_nasc
        chbCurriculo.Checked = frmClienteConsulta.cli_Curriculo
        txtEmail.Text = frmClienteConsulta.cli_Email
        txtObs.Text = frmClienteConsulta.cli_observacoes
        chbAposentado.Checked = frmClienteConsulta.cli_Aposentado
        txtNumBeneficio.Text = frmClienteConsulta.cli_NumBeneficio
        chbFuncPublico.Checked = frmClienteConsulta.cli_FuncPublico
        txtFuncPublico.Text = frmClienteConsulta.cli_NomeFunc
        chbAutonomo.Checked = frmClienteConsulta.cli_Autonomo
        txtAutonomo.Text = frmClienteConsulta.cli_AutonomoNome
        chbFalecido.Checked = frmClienteConsulta.cli_Falecido
        txtFalecido.Text = frmClienteConsulta.cli_NomeFalecido
        chbParcelamentos.Checked = frmClienteConsulta.cli_Parcelamento
        txtParcelamentos.Text = frmClienteConsulta.cli_NumParcelamento
        chbESocial.Checked = frmClienteConsulta.cli_EmprDom
        txtESocial.Text = frmClienteConsulta.cli_ESocial
        txtEsocialSenha.Text = frmClienteConsulta.cli_EsocialSenha
        chbVIP.Checked = frmClienteConsulta.cli_VIP
        txtVIP.Text = frmClienteConsulta.cli_VIPDescricao
        chbPJ.Checked = frmClienteConsulta.cli_PJ
        txtPJ.Text = frmClienteConsulta.cli_NumPJ
        chbMEI.Checked = frmClienteConsulta.cli_MEI
        txtMEI.Text = frmClienteConsulta.cli_NumMEI
        chbITR.Checked = frmClienteConsulta.cli_ITR
        txtITR.Text = frmClienteConsulta.cli_NumITR
        chbMensalista.Checked = frmClienteConsulta.cli_Mensalista
        txtMensalista.Text = frmClienteConsulta.cli_NomeMensalista
        chbDecore.Checked = frmClienteConsulta.cli_Decore
        txtDecore.Text = frmClienteConsulta.cli_DecoreDescricao
        chbIRPF.Checked = frmClienteConsulta.cli_IRPF
        txtIRPF.Text = frmClienteConsulta.cli_NumIRPF
        chbSenhaWeb.Checked = frmClienteConsulta.cli_SenWebPrefeitura
        txtSenhaWeb.Text = frmClienteConsulta.cli_SenhaWebPrefeitura
        chbRedesim.Checked = frmClienteConsulta.cli_Redesim
        txtSenhaRedesim.Text = frmClienteConsulta.cli_SenhaRedesim
        chbCodRFB.Checked = frmClienteConsulta.cli_CodRFB
        txtCodRFB.Text = frmClienteConsulta.cli_CodRFBNum
        txtValidadeRFB.Text = frmClienteConsulta.cli_CodRFBValidade

    End Sub

    Private Sub btPesquisaEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisaEmpresa.Click
        Dim frmEmpresaConsulta As New frmEmpresaConsulta
        frmEmpresaConsulta.Text = "Consulta de Cliente com Empresa"
        frmEmpresaConsulta.ConsultaTipo = frmEmpresaConsulta.TipoConsulta.Cliente
        frmEmpresaConsulta.ShowDialog()

        CodigoCliente = frmEmpresaConsulta.cli_id
        lblciID.Text = frmEmpresaConsulta.cli_id
        txtCPF.Text = frmEmpresaConsulta.cli_CPF
        txtEmprCPF.Text = frmEmpresaConsulta.cli_CPF
        cboSituacao.Text = frmEmpresaConsulta.cli_Situacao
        lblclienteID.Text = frmEmpresaConsulta.cli_id
        txtRG.Text = frmEmpresaConsulta.cli_RG
        txtNome.Text = frmEmpresaConsulta.cli_Nome
        txtPIS.Text = frmEmpresaConsulta.cli_PIS
        txtTitEleitoral.Text = frmEmpresaConsulta.cli_TitEleitoral
        txtLogradouro.Text = frmEmpresaConsulta.cli_Logradouro
        txtNumero.Text = frmEmpresaConsulta.cli_Numero
        txtComplemento.Text = frmEmpresaConsulta.cli_complemento
        txtBairro.Text = frmEmpresaConsulta.cli_Bairro
        txtCidade.Text = frmEmpresaConsulta.cli_Cidade
        cboUF.Text = frmEmpresaConsulta.cli_UF
        txtCEP.Text = frmEmpresaConsulta.cli_CEP
        txtFoneRes.Text = frmEmpresaConsulta.cli_FoneRes
        txtFoneCel.Text = frmEmpresaConsulta.cli_FoneCel
        txtDtNasc.Text = frmEmpresaConsulta.cli_data_nasc
        chbCurriculo.Checked = frmEmpresaConsulta.cli_Curriculo
        txtEmail.Text = frmEmpresaConsulta.cli_Email
        txtObs.Text = frmEmpresaConsulta.cli_observacoes
        chbAposentado.Checked = frmEmpresaConsulta.cli_Aposentado
        txtNumBeneficio.Text = frmEmpresaConsulta.cli_NumBeneficio
        chbFuncPublico.Checked = frmEmpresaConsulta.cli_FuncPublico
        txtFuncPublico.Text = frmEmpresaConsulta.cli_NomeFunc
        chbAutonomo.Checked = frmEmpresaConsulta.cli_Autonomo
        txtAutonomo.Text = frmEmpresaConsulta.cli_AutonomoNome
        chbFalecido.Checked = frmEmpresaConsulta.cli_Falecido
        txtFalecido.Text = frmEmpresaConsulta.cli_NomeFalecido
        chbParcelamentos.Checked = frmEmpresaConsulta.cli_Parcelamento
        txtParcelamentos.Text = frmEmpresaConsulta.cli_NumParcelamento
        chbESocial.Checked = frmEmpresaConsulta.cli_EmprDom
        txtESocial.Text = frmEmpresaConsulta.cli_ESocial
        txtEsocialSenha.Text = frmEmpresaConsulta.cli_EsocialSenha
        chbVIP.Checked = frmEmpresaConsulta.cli_VIP
        txtVIP.Text = frmEmpresaConsulta.cli_VIPDescricao
        chbPJ.Checked = frmEmpresaConsulta.cli_PJ
        txtPJ.Text = frmEmpresaConsulta.cli_NumPJ
        chbMEI.Checked = frmEmpresaConsulta.cli_MEI
        txtMEI.Text = frmEmpresaConsulta.cli_NumMEI
        chbITR.Checked = frmEmpresaConsulta.cli_ITR
        txtITR.Text = frmEmpresaConsulta.cli_NumITR
        chbMensalista.Checked = frmEmpresaConsulta.cli_Mensalista
        txtMensalista.Text = frmEmpresaConsulta.cli_NomeMensalista
        chbDecore.Checked = frmEmpresaConsulta.cli_Decore
        txtDecore.Text = frmEmpresaConsulta.cli_DecoreDescricao
        chbIRPF.Checked = frmEmpresaConsulta.cli_IRPF
        txtIRPF.Text = frmEmpresaConsulta.cli_NumIRPF
        chbSenhaWeb.Checked = frmEmpresaConsulta.cli_SenWebPrefeitura
        txtSenhaWeb.Text = frmEmpresaConsulta.cli_SenhaWebPrefeitura
        chbRedesim.Checked = frmEmpresaConsulta.cli_Redesim
        txtSenhaRedesim.Text = frmEmpresaConsulta.cli_SenhaRedesim
        chbCodRFB.Checked = frmEmpresaConsulta.cli_CodRFB
        txtCodRFB.Text = frmEmpresaConsulta.cli_CodRFBNum
        txtValidadeRFB.Text = frmEmpresaConsulta.cli_CodRFBValidade

        'PESQUISA DE CAMPOS DA EMPRESA
        CodigoEmpresa = frmEmpresaConsulta.empr_ID
        lblidEmpresa.Text = frmEmpresaConsulta.empr_ID
        txtRazaoSocial.Text = frmEmpresaConsulta.empr_razaosocial
        txtNomeFantasia.Text = frmEmpresaConsulta.empr_nomefantasia
        txtCNPJ.Text = frmEmpresaConsulta.empr_cnpj
        cboSituacaoCNPJ.Text = frmEmpresaConsulta.empr_Situacaocnpj
        txtNIRE.Text = frmEmpresaConsulta.empr_NIRE
        txtInscrEstadual.Text = frmEmpresaConsulta.empr_InscrEstadual
        txtCCM.Text = frmEmpresaConsulta.empr_CCM
        txtAtividade.Text = frmEmpresaConsulta.empr_atividade
        txtEmprPorte.Text = frmEmpresaConsulta.empr_Porte
        dtpDataInicio.Text = frmEmpresaConsulta.empr_dataInicio
        txtEmprEndereco.Text = frmEmpresaConsulta.empr_endereco
        txtEmprNum.Text = frmEmpresaConsulta.empr_numero
        txtEmprComplemento.Text = frmEmpresaConsulta.empr_complemento
        txtEmprBairro.Text = frmEmpresaConsulta.empr_bairro
        txtEmprCidade.Text = frmEmpresaConsulta.empr_cidade
        lblclienteID.Text = frmEmpresaConsulta.empr_lblclienteID
        txtEmprUF.Text = frmEmpresaConsulta.empr_UF
        txtEmprCEP.Text = frmEmpresaConsulta.empr_CEP
        txtEmprObs.Text = frmEmpresaConsulta.empr_obs
        chbSimples.Checked = frmEmpresaConsulta.empr_Simples
        txtSimplesNacional.Text = frmEmpresaConsulta.empr_SimplesNacional
        chbSIMEI.Checked = frmEmpresaConsulta.empr_Simei
        txtEmprSimei.Text = frmEmpresaConsulta.empr_CodSimei
        chbSefaz.Checked = frmEmpresaConsulta.empr_sefaz
        txtSefazUsu.Text = frmEmpresaConsulta.empr_SefazUsu
        txtSefazSen.Text = frmEmpresaConsulta.empr_SefazSen
        chbSenhaWebPJ.Checked = frmEmpresaConsulta.empr_CodReceitaPJ
        txtSenhaWebPJ.Text = frmEmpresaConsulta.empr_NumCodReceitaPJ
    End Sub

    Private Sub btAlterarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterarDados.Click
        If txtCPF.Text.Equals(String.Empty) Then
            errErro.SetError(txtCPF, "Digite um CPF")
            txtCPF.Focus()
            Exit Sub
        Else
            errErro.SetError(txtCPF, "")

        End If

        If txtNome.Text.Equals(String.Empty) Then
            errErro.SetError(txtNome, "Digite um nome")
            txtNome.Focus()
            Exit Sub
        Else
            errErro.SetError(txtNome, "")
        End If

        Try
            cliente.cli_id = lblciID.Text
            cliente.cli_CPF = txtCPF.Text
            cliente.cli_Situacao = cboSituacao.Text
            cliente.cli_RG = txtRG.Text
            cliente.cli_Nome = txtNome.Text
            cliente.cli_PIS = txtPIS.Text
            cliente.cli_TitEleitoral = txtTitEleitoral.Text
            cliente.cli_Logradouro = txtLogradouro.Text
            cliente.cli_Numero = txtNumero.Text
            cliente.cli_complemento = txtComplemento.Text
            cliente.cli_Bairro = txtBairro.Text
            cliente.cli_Cidade = txtCidade.Text
            cliente.cli_UF = cboUF.Text
            cliente.cli_CEP = txtCEP.Text
            cliente.cli_FoneRes = txtFoneRes.Text
            cliente.cli_FoneCel = txtFoneCel.Text
            cliente.cli_data_nasc = txtDtNasc.Text
            cliente.cli_Curriculo = chbCurriculo.Checked
            cliente.cli_Email = txtEmail.Text
            cliente.cli_observacoes = txtObs.Text
            cliente.cli_Aposentado = chbAposentado.Checked
            cliente.cli_NumBeneficio = txtNumBeneficio.Text
            cliente.cli_FuncPublico = chbFuncPublico.Checked
            cliente.cli_NomeFunc = txtFuncPublico.Text
            cliente.cli_Autonomo = chbAutonomo.Checked
            cliente.cli_AutonomoNome = txtAutonomo.Text
            cliente.cli_Falecido = chbFalecido.Checked
            cliente.cli_NomeFalecido = txtFalecido.Text
            cliente.cli_Inativo = chbInativo.Checked
            cliente.cli_InativoObs = txtInativo.Text
            cliente.cli_Parcelamento = chbParcelamentos.Checked
            cliente.cli_NumParcelamento = txtParcelamentos.Text
            cliente.cli_EmprDom = chbESocial.Checked
            cliente.cli_ESocial = txtESocial.Text
            cliente.cli_EsocialSenha = txtEsocialSenha.Text
            cliente.cli_VIP = chbVIP.Checked
            cliente.cli_VIPDescricao = txtVIP.Text
            cliente.cli_PJ = chbPJ.Checked
            cliente.cli_NumPJ = txtPJ.Text
            cliente.cli_MEI = chbMEI.Checked
            cliente.cli_NumMEI = txtMEI.Text
            cliente.cli_ITR = chbITR.Checked
            cliente.cli_NumITR = txtITR.Text
            cliente.cli_Mensalista = chbMensalista.Checked
            cliente.cli_NomeMensalista = txtMensalista.Text
            cliente.cli_Decore = chbDecore.Checked
            cliente.cli_DecoreDescricao = txtDecore.Text
            cliente.cli_IRPF = chbIRPF.Checked
            cliente.cli_NumIRPF = txtIRPF.Text
            cliente.cli_SenWebPrefeitura = chbSenhaWeb.Checked
            cliente.cli_SenhaWebPrefeitura = txtSenhaWeb.Text
            cliente.cli_Redesim = chbRedesim.Checked
            cliente.cli_SenhaRedesim = txtSenhaRedesim.Text
            cliente.cli_CodRFB = chbCodRFB.Checked
            cliente.cli_CodRFBNum = txtCodRFB.Text
            cliente.cli_CodRFBValidade = txtValidadeRFB.Text
            cliente.cli_DtCadastro = Now.Date

            cliente.AlterarDados()
            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btAlterarDadosEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterarDadosEmpresa.Click
        If txtRazaoSocial.Text.Equals(String.Empty) Then
            errErro.SetError(txtRazaoSocial, "Digite O nome da Empresa")
            Exit Sub
        Else
            errErro.SetError(txtRazaoSocial, "")
        End If
        If txtCNPJ.Text.Equals(String.Empty) Then
            errErro.SetError(txtCNPJ, "Digite o CNPJ da Empresa")
            Exit Sub
        Else
            errErro.SetError(txtCNPJ, "")

        End If
        Dim clnCategoria As New clsCategoria
        clnCategoria.cat_ID = cbTipo.SelectedValue

        Dim clnCliente As New clsCliente
        clnCliente.cli_id = cboCliente.SelectedValue

        Try

            empresa.empr_ID = lblidEmpresa.Text
            empresa.empr_razaosocial = txtRazaoSocial.Text
            empresa.empr_nomefantasia = txtNomeFantasia.Text
            empresa.empr_cnpj = txtCNPJ.Text
            empresa.empr_Situacaocnpj = cboSituacaoCNPJ.Text
            empresa.empr_NIRE = txtNIRE.Text
            empresa.empr_InscrEstadual = txtInscrEstadual.Text
            empresa.empr_CCM = txtCCM.Text
            empresa.empr_atividade = txtAtividade.Text
            empresa.empr_Porte = txtEmprPorte.Text
            empresa.empr_lblclienteID = lblclienteID.Text
            empresa.clsCategoria = clnCategoria
            empresa.empr_dataInicio = dtpDataInicio.Text
            empresa.empr_endereco = txtEmprEndereco.Text
            empresa.empr_numero = txtEmprNum.Text
            empresa.empr_complemento = txtEmprComplemento.Text
            empresa.empr_bairro = txtEmprBairro.Text
            empresa.empr_cidade = txtEmprCidade.Text
            empresa.empr_UF = txtEmprUF.Text
            empresa.empr_CEP = txtEmprCEP.Text
            empresa.empr_obs = txtEmprObs.Text
            empresa.empr_Simples = chbSimples.Checked
            empresa.empr_SimplesNacional = txtSimplesNacional.Text
            empresa.empr_Simei = chbSIMEI.Checked
            empresa.empr_CodSimei = txtEmprSimei.Text
            empresa.empr_sefaz = chbSefaz.Checked
            empresa.empr_SefazUsu = txtSefazUsu.Text
            empresa.empr_SefazSen = txtSefazSen.Text
            empresa.empr_CodReceitaPJ = chbSenhaWebPJ.Checked
            empresa.empr_NumCodReceitaPJ = txtSenhaWebPJ.Text

            empresa.AlterarDados()
            LimparCampos()

        Catch ex As Exception
            ' MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btPesquisarCPFVinculado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisarCPFVinculado.Click
        Dim frmVinculadoCadastro As New frmVinculadoConsulta
        Dim enviarDados As New frmVinculadoConsulta
        enviarDados.myString = txtNome.Text
        enviarDados.vinc_id = lblciID.Text
        enviarDados.ShowDialog()
    End Sub



    Private Sub LimparCampos()
        lblciID.Text = ""
        lblidEmpresa.Text = ""
        txtCPF.Text = ""
        cboSituacao.Text = ""
        txtRG.Text = ""
        txtNome.Text = ""
        txtPIS.Text = ""
        txtTitEleitoral.Text = ""
        txtLogradouro.Text = ""
        txtNumero.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cboUF.Text = ""
        txtCEP.Text = ""
        txtFoneRes.Text = ""
        txtFoneCel.Text = ""
        txtDtNasc.Text = ""
        chbCurriculo.Checked = False
        txtEmail.Text = ""
        txtObs.Text = ""
        chbAposentado.Checked = False
        txtNumBeneficio.Text = ""

        chbFuncPublico.Checked = False
        ' txtFuncPublico_old.Text = ""
        chbAutonomo.Checked = False
        txtAutonomo.Text = ""
        chbFalecido.Checked = False
        txtFalecido.Text = ""
        chbInativo.Checked = False
        txtInativo.Text = ""
        chbParcelamentos.Checked = False
        txtParcelamentos.Text = ""
        chbESocial.Checked = False
        txtESocial.Text = ""
        txtEsocialSenha.Text = ""
        chbVIP.Checked = False
        txtVIP.Text = ""
        chbPJ.Checked = False
        txtPJ.Text = ""
        chbMEI.Checked = False
        txtMEI.Text = ""
        chbITR.Checked = False
        txtITR.Text = ""
        chbMensalista.Checked = False
        txtMensalista.Text = ""
        chbDecore.Checked = False
        txtDecore.Text = ""
        chbIRPF.Checked = False
        txtIRPF.Text = ""
        chbSenhaWeb.Checked = False
        txtSenhaWeb.Text = ""
        chbRedesim.Checked = False
        txtSenhaRedesim.Text = ""
        chbCodRFB.Checked = False
        txtCodRFB.Text = ""
        txtValidadeRFB.Text = ""

        txtRazaoSocial.Text = ""
        txtNomeFantasia.Text = ""
        txtCNPJ.Text = ""
        txtNIRE.Text = ""
        txtInscrEstadual.Text = ""
        txtCCM.Text = ""
        txtAtividade.Text = ""
        txtEmprPorte.Text = ""
        dtpDataInicio.Text = ""
        txtEmprEndereco.Text = ""
        txtEmprNum.Text = ""
        txtEmprComplemento.Text = ""
        txtEmprBairro.Text = ""
        txtEmprCidade.Text = ""
        txtEmprCPF.Text = ""
        cboCliente.Text = ""
        txtEmprUF.Text = ""
        txtEmprCEP.Text = ""
        txtEmprObs.Text = ""
        chbSimples.Checked = False
        cboSituacaoCNPJ.Text = ""
        txtSimplesNacional.Text = ""
        chbSIMEI.Checked = False
        txtEmprSimei.Text = ""
        chbSefaz.Checked = False
        txtSefazUsu.Text = ""
        txtSefazSen.Text = ""
        chbSenhaWebPJ.Checked = False
        txtSenhaWebPJ.Text = ""
        lblclienteID.Text = ""
    End Sub

    Private Sub txtPIS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtESocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSenhaWeb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenhaWeb.KeyPress
        ''Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        ''KeyAscii = CShort(SoNumeros(KeyAscii))
        ''If KeyAscii = 0 Then
        ''    e.Handled = True
        ''    MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''End If
    End Sub

    Private Sub txtCodRFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodRFB.KeyPress
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SoNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        '    MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub txtSimplesNacional_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSimplesNacional.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSenhaWebPJ_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenhaWebPJ.KeyPress
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SoNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        '    MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub txtNIRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtTitEleitoral_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub chbAposentado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAposentado.CheckedChanged
        If chbAposentado.Checked = True Then
            ' lblNBeneficio.Visible = True
            txtNumBeneficio.Visible = True

        Else
            ' lblNBeneficio.Visible = False
            txtNumBeneficio.Visible = False

        End If
    End Sub

    Private Sub chbFuncPublico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFuncPublico.CheckedChanged
        If chbFuncPublico.Checked = True Then
            '  lblFuncPublico.Visible = True
            txtFuncPublico.Visible = True

        Else
            '    lblFuncPublico.Visible = False
            txtFuncPublico.Visible = False

        End If
    End Sub

    Private Sub chbAutonomo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAutonomo.CheckedChanged

    End Sub

    Private Sub chbFalecido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFalecido.CheckedChanged
        If chbFalecido.Checked = True Then
            '  lblFalecido.Visible = True
            txtFalecido.Visible = True

        Else
            '   lblFalecido.Visible = False
            txtFalecido.Visible = False

        End If
    End Sub

    Private Sub chbInativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbInativo.CheckedChanged
        If chbInativo.Checked = True Then
            txtInativo.Visible = True

        Else
            txtInativo.Visible = False

        End If
    End Sub

    Private Sub chbParcelamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbParcelamentos.CheckedChanged
        If chbParcelamentos.Checked = True Then
            '  lblParcelamentos.Visible = True
            txtParcelamentos.Visible = True

        Else
            '  lblParcelamentos.Visible = False
            txtParcelamentos.Visible = False

        End If
    End Sub

    Private Sub chbESocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbESocial.CheckedChanged
        If chbESocial.Checked = True Then
            '  lblESocial.Visible = True
            txtESocial.Visible = True
            txtEsocialSenha.Visible = True
            lblEsocialSenha.Visible = True
        Else
            '   lblESocial.Visible = False
            txtESocial.Visible = False
            txtEsocialSenha.Visible = False
            lblEsocialSenha.Visible = False
        End If
    End Sub

    Private Sub chbVIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbVIP.CheckedChanged
        If chbVIP.Checked = True Then
            '  lblVIP.Visible = True
            txtVIP.Visible = True

        Else
            '  lblVIP.Visible = False
            txtVIP.Visible = False

        End If
    End Sub

    Private Sub chbPJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbPJ.CheckedChanged
        If chbPJ.Checked = True Then
            ' lblPJ.Visible = True
            '  txtPJ.Visible = True
            TabEmpresa.Enabled = True
            ' TabControl.SelectedTab = TabPage2

        Else
            ' lblPJ.Visible = False
            'txtPJ.Visible = False
            TabEmpresa.Enabled = False
        End If
    End Sub

    Private Sub chbMEI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMEI.CheckedChanged
        If chbMEI.Checked = True Then
            ' lblMEI.Visible = True
            TabEmpresa.Enabled = True
            ' txtMEI.Visible = True

        Else
            '   lblMEI.Visible = False
            ' txtMEI.Visible = False
            TabEmpresa.Enabled = False
        End If
    End Sub

    Private Sub chbITR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbITR.CheckedChanged
        If chbITR.Checked = True Then
            ' lblITR.Visible = True
            txtITR.Visible = True

        Else
            '   lblITR.Visible = False
            txtITR.Visible = False

        End If
    End Sub

    Private Sub chbMensalista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMensalista.CheckedChanged
        If chbMensalista.Checked = True Then
            '   lblMensalista.Visible = True
            txtMensalista.Visible = True

        Else
            '   lblMensalista.Visible = False
            txtMensalista.Visible = False

        End If
    End Sub

    Private Sub chbDecore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDecore.CheckedChanged
        If chbDecore.Checked = True Then
            '     lblDecore.Visible = True
            txtDecore.Visible = True

        Else
            '   lblDecore.Visible = False
            txtDecore.Visible = False

        End If
    End Sub

    Private Sub chbIRPF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbIRPF.CheckedChanged
        If chbIRPF.Checked = True Then
            '  lblIRPF.Visible = True
            txtIRPF.Visible = True

        Else
            ' lblIRPF.Visible = False
            txtIRPF.Visible = False

        End If
    End Sub

    Private Sub chbSenhaWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSenhaWeb.CheckedChanged
        If chbSenhaWeb.Checked = True Then
            'lblSenhaWeb.Visible = True
            txtSenhaWeb.Visible = True
           
        Else
            ' lblSenhaWeb.Visible = False
            txtSenhaWeb.Visible = False
           
        End If
    End Sub

    Private Sub chbRedesim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbRedesim.CheckedChanged
        If chbRedesim.Checked = True Then
            lblSenhaRedesim.Visible = True
            txtSenhaRedesim.Visible = True
            txtCPFRedesim.Visible = True
            lblcpfRedesim.Visible = True
        Else
            lblSenhaRedesim.Visible = False
            txtSenhaRedesim.Visible = False
            txtCPFRedesim.Visible = False
            lblcpfRedesim.Visible = False
        End If
    End Sub

    Private Sub chbCodRFB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbCodRFB.CheckedChanged
        If chbCodRFB.Checked = True Then
            txtCodRFB.Visible = True
            lblValidoRFB.Visible = True
            txtValidadeRFB.Visible = True

        Else
            txtCodRFB.Visible = False
            lblValidoRFB.Visible = False
            txtValidadeRFB.Visible = False

        End If
    End Sub

    Private Sub chbSimples_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSimples.CheckedChanged
        If chbSimples.Checked = True Then
            txtSimplesNacional.Visible = True
        Else
            txtSimplesNacional.Visible = False
        End If
    End Sub

    Private Sub chbSIMEI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSIMEI.CheckedChanged
        If chbSIMEI.Checked = True Then
            txtEmprSimei.Visible = True
        Else
            txtEmprSimei.Visible = False
        End If
    End Sub

    Private Sub chbSefaz_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSefaz.CheckedChanged
        If chbSefaz.Checked = True Then
            lblUsuario.Visible = True
            lblSenhaSefaz.Visible = True
            txtSefazUsu.Visible = True
            txtSefazSen.Visible = True
        Else
            lblUsuario.Visible = False
            lblSenhaSefaz.Visible = False
            txtSefazUsu.Visible = False
            txtSefazSen.Visible = False
        End If
    End Sub

    Private Sub chbSenhaWebPJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSenhaWebPJ.CheckedChanged
        If chbSenhaWebPJ.Checked = True Then
            lblSenhaWebPJ.Visible = True
            lblSenhaPJValidade.Visible = True
            txtSenhaWebPJ.Visible = True
            txtSenhaPJValidade.Visible = True
        Else
            lblSenhaWebPJ.Visible = False
            lblSenhaPJValidade.Visible = False
            txtSenhaWebPJ.Visible = False
            txtSenhaPJValidade.Visible = False
        End If
    End Sub

   
    
    Private Sub txtEsocialSenha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEsocialSenha.TextChanged

    End Sub
    Private Sub lblEsocialSenha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEsocialSenha.Click

    End Sub
End Class