Imports System.Data.OleDb

Public Class frmCadastroClientes
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Dim CodigoCliente As Integer
    Dim cliente As New clsCliente
   
    Private Sub frmCadastroClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabEmpresa.Enabled = False

        Dim clnCategoria As New clsCategoria
        Dim dsCategoria As New Data.DataSet
        dsCategoria = clnCategoria.Listar("")
        With cbTipo
            .DataSource = dsCategoria.Tables(0)
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

    Private Sub LimparCampos()
        txtCPF.Text = ""
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
        txtFuncPublico.Text = ""
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
    End Sub

    Private Sub txtPIS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPIS.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtESocial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtESocial.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSenhaWeb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenhaWeb.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtCodRFB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodRFB.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNIRE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIRE.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtTitEleitoral_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTitEleitoral.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Digite apenas números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub chbAposentado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAposentado.CheckedChanged
        Aposentado()
    End Sub

    Private Sub chbFuncPublico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFuncPublico.CheckedChanged
        FuncPublico()
    End Sub

    Private Sub chbAutonomo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAutonomo.CheckedChanged
        Autonomo()
    End Sub

    Private Sub chbFalecido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbFalecido.CheckedChanged
        Falecido()
    End Sub

    Private Sub chbInativo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbInativo.CheckedChanged
        Inativo()
    End Sub

    Private Sub chbParcelamentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbParcelamentos.CheckedChanged
        Parcelamentos()
    End Sub

    Private Sub chbESocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbESocial.CheckedChanged
        ESocial()
    End Sub

    Private Sub chbVIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbVIP.CheckedChanged
        vip()
    End Sub

    Private Sub chbPJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbPJ.CheckedChanged
        PJ()
    End Sub

    Private Sub chbMEI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMEI.CheckedChanged
        MEI()
    End Sub

    Private Sub chbITR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbITR.CheckedChanged
        ITR()
    End Sub

    Private Sub chbMensalista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbMensalista.CheckedChanged
        Mensalista()
    End Sub

    Private Sub chbDecore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDecore.CheckedChanged
        Decore()
    End Sub

    Private Sub chbIRPF_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbIRPF.CheckedChanged
        IRPF()
    End Sub

    Private Sub chbSenhaWeb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSenhaWeb.CheckedChanged
        SenhaWeb()
    End Sub

    Private Sub chbRedesim_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbRedesim.CheckedChanged
        Redesim()
    End Sub

    Private Sub chbCodRFB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbCodRFB.CheckedChanged
        CodRFB()
    End Sub

    Private Sub Aposentado()
        Try
            If chbAposentado.Checked = True Then
                '  lblNumBeneficio.Visible = True
                txtNumBeneficio.Visible = True

            Else
                '   lblNumBeneficio.Visible = False
                txtNumBeneficio.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FuncPublico()
        Try
            If chbFuncPublico.Checked = True Then
                '  lblFuncPublico.Visible = True
                txtFuncPublico.Visible = True

            Else
                '    lblFuncPublico.Visible = False
                txtFuncPublico.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Autonomo()
        Try
            If chbAutonomo.Checked = True Then
                '  lblAutonomo.Visible = True
                txtAutonomo.Visible = True

            Else
                ' lblAutonomo.Visible = False
                txtAutonomo.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Falecido()
        Try
            If chbFalecido.Checked = True Then
                '  lblFalecido.Visible = True
                txtFalecido.Visible = True

            Else
                '   lblFalecido.Visible = False
                txtFalecido.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Inativo()
        Try
            If chbInativo.Checked = True Then
                txtInativo.Visible = True

            Else
                txtInativo.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Parcelamentos()
        Try
            If chbParcelamentos.Checked = True Then
                '  lblParcelamentos.Visible = True
                txtParcelamentos.Visible = True

            Else
                '  lblParcelamentos.Visible = False
                txtParcelamentos.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub vip()
        Try
            If chbVIP.Checked = True Then
                '  lblVIP.Visible = True
                txtVIP.Visible = True

            Else
                '  lblVIP.Visible = False
                txtVIP.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PJ()
        Try
            If chbPJ.Checked = True Then
                ' lblPJ.Visible = True
                '  txtPJ.Visible = True
                TabEmpresa.Enabled = True
                ' TabControl.SelectedTab = TabPage2

            Else
                ' lblPJ.Visible = False
                txtPJ.Visible = False
                TabEmpresa.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEI()
        Try
            If chbMEI.Checked = True Then
                ' lblMEI.Visible = True
                txtMEI.Visible = True

            Else
                '   lblMEI.Visible = False
                txtMEI.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ITR()
        Try
            If chbITR.Checked = True Then
                ' lblITR.Visible = True
                txtITR.Visible = True

            Else
                '   lblITR.Visible = False
                txtITR.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Mensalista()
        Try
            If chbMensalista.Checked = True Then
                '   lblMensalista.Visible = True
                txtMensalista.Visible = True

            Else
                '   lblMensalista.Visible = False
                txtMensalista.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Decore()
        Try
            If chbDecore.Checked = True Then
                '     lblDecore.Visible = True
                txtDecore.Visible = True

            Else
                '   lblDecore.Visible = False
                txtDecore.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IRPF()
        Try
            If chbIRPF.Checked = True Then
                '  lblIRPF.Visible = True
                txtIRPF.Visible = True

            Else
                ' lblIRPF.Visible = False
                txtIRPF.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ESocial()
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SenhaWeb()
        Try
            If chbSenhaWeb.Checked = True Then
                'lblSenhaWeb.Visible = True
                txtSenhaWeb.Visible = True
                lblValidoRFB.Visible = True
                txtValidadeRFB.Visible = True

            Else
                ' lblSenhaWeb.Visible = False
                txtSenhaWeb.Visible = False
                lblValidoRFB.Visible = False
                txtValidadeRFB.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Redesim()
        Try
            If chbRedesim.Checked = True Then
                lblSenhaRedesim.Visible = True
                txtSenhaRedesim.Visible = True

            Else
                lblSenhaRedesim.Visible = False
                txtSenhaRedesim.Visible = False


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CodRFB()
        Try
            If chbCodRFB.Checked = True Then
                txtCodRFB.Visible = True
                lblValidoRFB.Visible = True
                txtValidadeRFB.Visible = True

            Else
                txtCodRFB.Visible = False
                lblValidoRFB.Visible = False
                txtValidadeRFB.Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
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
    End Sub
End Class