Public Class frmTarefasCadastro
    Dim _Operacao As clsFuncoesGerais.Operacao
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

    Private Sub frmTarefasCadastro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Operacao = clsFuncoesGerais.Operacao.Alteracao Then
            Dim clnTarefas As New clsTarefas
            Dim drDados As System.Data.OleDb.OleDbDataReader
            drDados = clnTarefas.ListaTarefas(Codigo)

            If drDados.Read = True Then
                txtTarefa.Text = drDados("tarefa")
                txtResponsavel.Text = drDados("responsavel")
                txtDtCadastro.Text = drDados("DtCadastro")
                txtDtConclusao.Text = drDados("dtConclusao")
                chbAtivo.Checked = drDados("Ativo")
                txtObs.Text = drDados("obs")
                
            End If
        End If
    End Sub

    Private Sub btGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGravar.Click

        Dim cldTarefa As New clsTarefas
        With cldTarefa
            .tarefa = txtTarefa.Text
            .responsavel = txtResponsavel.Text
            .DtCadastro = txtDtCadastro.Text
            .dtConclusao = txtDtConclusao.Text
            .Ativo = chbAtivo.Checked
            .obs = txtObs.Text

        End With

        If _Operacao = clsFuncoesGerais.Operacao.Inclusao Then
            cldTarefa.GravarDados()
        ElseIf _Operacao = clsFuncoesGerais.Operacao.Alteracao Then
            cldTarefa.tarefas_id = Codigo
            cldTarefa.AlterarDados()
        End If

        MessageBox.Show("Registro gravado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub
End Class