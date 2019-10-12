Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
    'Private Sub CadastrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmCliente_Cadastro As New frmCadastroClientes
    '    frmCliente_Cadastro.ShowDialog()
    'End Sub

    'Private Sub CadastrodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrodToolStripMenuItem.Click
    '    Dim frmCliente_Cadastro As New frmCadastroClientes
    '    frmCliente_Cadastro.ShowDialog()
    'End Sub

    'Private Sub SairToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
    '    Me.Close()
    'End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        Dim frmCliente_Cadastro As New frmCadastroClientes
        frmCliente_Cadastro.ShowDialog()
    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

   
End Class
