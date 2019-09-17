﻿Imports System.Data.OleDb

Public Class frmCadastroClientes
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao

    Dim cliente As New clsCliente
    Private Sub frmCadastroClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabEmpresa.Enabled = False
    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

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
            cliente.cli_SenhaWebValidade = txtValidade.Text
            cliente.cli_Redesim = chbRedesim.Checked
            cliente.cli_SenhaRedesim = txtSenhaRedesim.Text
            cliente.cli_DtCadastro = Now.Date

            '  If cliente.cli_id > 0 Then
            cliente.GravarDados()
            ' Else 
            '  cliente.Alterar()
            '  End If

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
        Try
            Dim campo As DataRow
            cliente.cli_CPF = txtCPF.Text
            ds = cliente.ConsultarCliente()
            campo = ds.Tables(0).Rows(0)
            txtCPF.Text = campo(2)
            txtRG.Text = campo(3)
            txtNome.Text = campo(4)
            txtPIS.Text = campo(5)
            txtTitEleitoral.Text = campo(6)
            txtLogradouro.Text = campo(7)
            txtNumero.Text = campo(8)
            txtComplemento.Text = campo(9)
            txtBairro.Text = campo(10)
            txtCidade.Text = campo(11)
            cboUF.Text = campo(12)
            txtCEP.Text = campo(13)
            txtFoneRes.Text = campo(14)
            txtFoneCel.Text = campo(15)
            txtDtNasc.Text = campo(16)
            chbCurriculo.Checked = campo(17)
            txtEmail.Text = campo(18)
            txtObs.Text = campo(19)
            chbAposentado.Checked = campo(20)
            txtNumBeneficio.Text = campo(21)
            chbFuncPublico.Checked = campo(22)
            txtFuncPublico.Text = campo(23)
            chbAutonomo.Checked = campo(24)
            txtAutonomo.Text = campo(25)
            chbFalecido.Checked = campo(26)
            txtFalecido.Text = campo(27)
            chbParcelamentos.Checked = campo(28)
            txtParcelamentos.Text = campo(29)
            chbESocial.Checked = campo(30)
            txtESocial.Text = campo(31)
            txtEsocialSenha.Text = campo(32)
            chbVIP.Checked = campo(33)
            txtVIP.Text = campo(34)
            chbPJ.Checked = campo(35)
            txtPJ.Text = campo(36)
            chbMEI.Checked = campo(37)
            txtMEI.Text = campo(38)
            chbITR.Checked = campo(39)
            txtITR.Text = campo(40)
            chbMensalista.Checked = campo(41)
            txtMensalista.Text = campo(42)
            chbDecore.Checked = campo(43)
            txtDecore.Text = campo(44)
            chbIRPF.Checked = campo(45)
            txtIRPF.Text = campo(46)
            chbSenhaWeb.Checked = campo(47)
            txtSenhaWeb.Text = campo(48)
            txtValidade.Text = campo(49)
            chbRedesim.Checked = campo(50)
            txtSenhaRedesim.Text = campo(51)

        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar o Cliente!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try
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
                lblSenhaWeb.Visible = True
                txtSenhaWeb.Visible = True
                lblValido.Visible = True
                txtValidade.Visible = True

            Else
                lblSenhaWeb.Visible = False
                txtSenhaWeb.Visible = False
                lblValido.Visible = False
                txtValidade.Visible = False

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
        txtValidade.Text = ""
        chbRedesim.Checked = False
        txtSenhaRedesim.Text = ""
    End Sub

    
    
    
   
    
End Class