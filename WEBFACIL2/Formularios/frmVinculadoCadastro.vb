Public Class frmVinculadoCadastro

    Dim vinculo As New clsCPFVinculado
    Private _cli_id As Integer
    Dim _Operacao As clsFuncoesGerais.Operacao
    Dim txtEmaill As String

    Public Property Operacao() As clsFuncoesGerais.Operacao

        Get
            Return _Operacao
        End Get
        Set(ByVal value As clsFuncoesGerais.Operacao)
            _Operacao = value
        End Set
    End Property

    Dim _Codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _Codigo

        End Get
        Set(ByVal value As Integer)
            _Codigo = value
        End Set
    End Property
    Public Property cli_id() As Integer
        Get
            Return _cli_id
        End Get
        Set(ByVal value As Integer)
            _cli_id = value
        End Set
    End Property

    Private Sub frmCadastroFamiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        lblRecebeIDClienteVinculo.Text = Me.cli_id
    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGravar.Click
        If txtNomeVinculado.Text.Equals(String.Empty) Then
            errErro.SetError(txtNomeVinculado, "Digite o Nome do Vinculado")
            txtNomeVinculado.Focus()
            Exit Sub
        Else
            errErro.SetError(txtNomeVinculado, "")

        End If
        If txtCPFVinculado.Text.Equals(String.Empty) Then
            errErro.SetError(txtCPFVinculado, "Digite o CPF")
            Exit Sub
        Else
            errErro.SetError(txtCPFVinculado, "")
        End If

        If txtTipoVinculo.Text.Equals(String.Empty) Then
            errErro.SetError(txtTipoVinculo, "Digite o Tipo de Vinculo")
            Exit Sub
        Else
            errErro.SetError(txtTipoVinculo, "")
        End If

        Try
            Dim cldVinculo As New clsCPFVinculado
            With cldVinculo
                .vinc_nome = txtNomeVinculado.Text
                .vinc_CPF = txtCPFVinculado.Text
                .vinc_lblVincID = lblRecebeIDClienteVinculo.Text
                .vinc_vinculo = txtTipoVinculo.Text
            End With
            'vinculo.vinc_nome = txtNomeVinculado.Text
            'vinculo.vinc_CPF = txtCPFVinculado.Text
            'vinculo.vinc_lblVincID = lblRecebeIDClienteVinculo.Text
            'vinculo.vinc_vinculo = txtTipoVinculo.Text

            'vinculo.GravarDados()
            If _Operacao = clsFuncoesGerais.Operacao.Inclusao Then
                cldVinculo.GravarDados()
            ElseIf _Operacao = clsFuncoesGerais.Operacao.Alteracao Then
                cldVinculo.vinc_id = Codigo
                cldVinculo.AlterarDados()
            End If
            LimparCampos()
            MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Private Sub LimparCampos()
        txtNomeVinculado.Text = ""
        txtCPFVinculado.Text = ""
        txtTipoVinculo.Text = ""
        lblRecebeIDClienteVinculo.Text = ""
    End Sub

End Class