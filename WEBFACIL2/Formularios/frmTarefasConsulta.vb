Public Class frmTarefasConsulta
    Public idcli As Integer
    Public nome As String
    Private Sub CarregaGrid()
        Dim cldCliente As New clsTarefas
        dgdGrid.DataSource = cldCliente.Lista(txtDescricao.Text).Tables(0)

    End Sub




    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        CarregaGrid()
    End Sub

    Private Sub btNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNovo.Click
        Dim frmCliente As New frmTarefasCadastro
        With frmCliente
            .Operacao = clsFuncoesGerais.Operacao.Inclusao
            .ShowDialog()
        End With
        CarregaGrid()
    End Sub

    Private Sub btAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAlterar.Click
        If dgdGrid.RowCount <> 0 Then

            Dim frmCliente As New frmTarefasCadastro
            With frmCliente
                .Operacao = clsFuncoesGerais.Operacao.Alteracao
                .Codigo = dgdGrid.CurrentRow.Cells(0).Value
                .ShowDialog()
            End With
            CarregaGrid()
        Else
            MessageBox.Show("Clique no botão pesquisar e selecione um cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcluir.Click
        If dgdGrid.RowCount <> 0 Then
            If (MessageBox.Show("Deseja excluir o registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then Exit Sub
            Dim cldCliente As New clsTarefas
            cldCliente.Excluir(dgdGrid.CurrentRow.Cells(0).Value)
            MessageBox.Show("Registro excluído com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            CarregaGrid()
        Else
            MessageBox.Show("Clique no botão pesquisar e selecione um cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub



    Private Sub dgdGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdGrid.DoubleClick
        If dgdGrid.RowCount <> 0 Then
            idcli = dgdGrid.CurrentRow.Cells(0).Value
            nome = dgdGrid.CurrentRow.Cells(1).Value
            Me.Close()
            Dim frmCliente As New frmTarefasCadastro
            With frmCliente
                .Operacao = clsFuncoesGerais.Operacao.Alteracao
                .Codigo = dgdGrid.CurrentRow.Cells(0).Value
                .ShowDialog()
            End With
        End If
    End Sub
End Class