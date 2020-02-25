Imports System.Data.OleDb
Public Class frmPrincipal

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ' PCarregaDadosDia()
        ' PCarregaDados()
    End Sub

    Private Sub ClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsToolStripMenuItem.Click
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim frmCliente_Cadastro As New frmCadastroClientes
        frmCliente_Cadastro.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PCarregaDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT cli_id,cli_Nome as Nome,cli_data_nasc as DtNasc FROM tbClientes WHERE MONTH(cli_data_nasc) = " & cmbMes.Text
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dgvAniversariantes.DataSource = dt

                With dgvAniversariantes
                    .Columns("cli_Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao carregr os dados. Erro: " & ex.Message.ToString, MsgBoxStyle.Critical, "Aniversariantes")
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PCarregaDadosDia()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT cli_id,cli_Nome as Nome,cli_data_nasc as DtNasc FROM tbClientes WHERE DAY(cli_data_nasc) = " & cmbDia.Text
                Dim cmd As New OleDbCommand(sql, con)
                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dgvAniversariantes.DataSource = dt

                With dgvAniversariantes
                    .Columns("cli_Nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao carregr os dados. Erro: " & ex.Message.ToString, MsgBoxStyle.Critical, "Aniversariantes")
            Finally
                con.Close()
            End Try
        End Using
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

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        PCarregaDados()
    End Sub

    Private Sub cmbDia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDia.SelectedIndexChanged
        PCarregaDadosDia()
    End Sub

   
    Private Sub TrabalhosDiáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrabalhosDiáriosToolStripMenuItem.Click
        Dim frmCadAcessoria As New frmCadAcessoria
        frmCadAcessoria.ShowDialog()
    End Sub
End Class
