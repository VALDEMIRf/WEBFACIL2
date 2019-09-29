Public Class frmPrincipal

    Private Sub CadastrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmCliente_Cadastro As New frmCadastroClientes
        frmCliente_Cadastro.ShowDialog()
    End Sub

    Private Sub CadastrodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrodToolStripMenuItem.Click
        Dim frmCliente_Cadastro As New frmCadastroClientes
        frmCliente_Cadastro.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
