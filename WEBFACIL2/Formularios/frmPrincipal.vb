Imports System.Data.OleDb
Imports System.Data
Public Class frmPrincipal

    Private _tarefas_id As Integer
    Public Property tarefas_id() As Integer
        Get
            Return _tarefas_id
        End Get
        Set(ByVal value As Integer)
            _tarefas_id = value
        End Set
    End Property

    Private _tarefa As String
    Public Property tarefa() As String
        Get
            Return _tarefa
        End Get
        Set(ByVal value As String)
            _tarefa = value
        End Set
    End Property

    Private _Ativo As Boolean
    Public Property Ativo() As Boolean
        Get
            Return _Ativo
        End Get
        Set(ByVal value As Boolean)
            _Ativo = value
        End Set
    End Property

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        cmbMes.SelectedIndex = 0
        PCarregaDadosIniciais()
        ' ListaTarefas()
        CarregaGrid()
    End Sub

    Private Sub PCarregaDadosIniciais()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT cli_id,cli_Nome,cli_Logradouro,cli_CEP,cli_Cidade,cli_UF,cli_Ano,"
                sql += "cli_FoneCel,cli_Dia,cli_Mes,cli_Email From tbClientes ORDER BY cli_Mes"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvAniversariantes.DataSource = dt

                'Formata a gridview
                PFormataDataGridView()

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao carregar os dados. Erro: " & ex.Message.ToString, MsgBoxStyle.Critical, "Aniversariantes")
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PFormataDataGridView()
        With dgvAniversariantes
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False

            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Endereço"
            .Columns(3).HeaderText = "Cep"
            .Columns(4).HeaderText = "Cidade"
            .Columns(5).HeaderText = "Estado"
            .Columns(6).HeaderText = "Telefone"
            .Columns(7).HeaderText = "Celular"
            .Columns(8).HeaderText = "Dia"
            .Columns(9).HeaderText = "Mês"
            .Columns(10).HeaderText = "E-mail"

            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        If cmbMes.SelectedIndex = 0 Then
            PCarregaDadosIniciais()
        Else
            PCarregaDados(cmbMes.Text)
        End If
    End Sub

    Private Sub PCarregaDados(ByVal strMes As String)
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String

                sql = "SELECT cli_id,cli_Nome,cli_Logradouro,cli_CEP,cli_Cidade,cli_UF,cli_FoneRes, "
                sql += "cli_FoneCel,cli_Dia,cli_Mes,cli_Email From tbClientes Where cli_Mes='" & strMes & "' ORDER BY cli_Dia"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvAniversariantes.DataSource = dt

                'Formata a gridview
                PFormataDataGridView()
            Catch ex As Exception
                MsgBox(ex.Message).ToString()
            Finally
                con.Close()
            End Try
        End Using
    End Sub


    Private Sub txtPesquisa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisa.SelectedIndexChanged
        If txtPesquisa.SelectedIndex = 0 Then
            CarregaGrid()
        Else
            ListaTarefas(txtPesquisa.Text)
        End If
    End Sub

    Private Sub rbAtivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAtivo.CheckedChanged
        If txtPesquisa.SelectedIndex = 0 Then
            CarregaGrid()
        Else
            ListaTarefas(txtPesquisa.Text)
        End If
    End Sub

    Private Sub ListaTarefas(ByVal strPesquisa As String)
        'Using con As OleDbConnection = GetConnection()
        '    Try
        '        con.Open()
        '        Dim sql As String = "SELECT tarefa,responsavel,DtCadastro,dtConclusao,Ativo,obs FROM tbTarefas "
        '        ' Dim sql As String = "SELECT tarefa,responsavel,DtCadastro,dtConclusao,Ativo,obs FROM tbTarefas WHERE Ativo = '" &  & "' "
        '        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        '        Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        '        Dim dt As DataTable = New DataTable
        '        da.Fill(dt)
        '        dgvTarefas.DataSource = dt

        '    Catch ex As Exception
        '        MsgBox(ex.Message.ToString)
        '    Finally
        '        con.Close()
        '    End Try
        'End Using

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "SELECT tarefa,responsavel,DtCadastro,dtConclusao,"
                sql += "Ativo,obs FROM tbTarefas Where Ativo=" & rbAtivo.Checked 'dgvTarefas.Rows[dgvTarefas.SelectedRows[0].Index + 1].Selected = true
                ' sql += "Ativo,obs FROM tbTarefas WHERE Ativo = '" & frmTarefasCadastro.chbAtivo.Checked & "'"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvTarefas.DataSource = dt
                'dgvTarefas.Rows[dgvTarefas.SelectedRows[0].Index + 1].Selected = true


                'Formata a gridview
                PFormataDataGridView1()

            Catch ex As Exception
                MsgBox("Ocorreu um erro ao carregar os dados. Erro: " & ex.Message.ToString, MsgBoxStyle.Critical, "Aniversariantes")
            Finally
                con.Close()
            End Try
        End Using
    End Sub

   


    Private Sub ClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsToolStripMenuItem.Click
        Dim frmCliente_Cadastro As New frmCadastroClientes
        frmCliente_Cadastro.ShowDialog()
    End Sub

    Private Sub AssessoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssessoriaToolStripMenuItem.Click
        Dim frmCadAcessoria As New frmCadAcessoria
        frmCadAcessoria.ShowDialog()
    End Sub

    Private Sub CadastroDeTarefasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeTarefasToolStripMenuItem.Click
        Dim frmCadTarefas As New frmTarefasCadastro
        frmCadTarefas.ShowDialog()
    End Sub

    Private Sub ConsultaDeTarefasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeTarefasToolStripMenuItem.Click
        Dim frmConTarefas As New frmTarefasConsulta
        frmConTarefas.ShowDialog()
    End Sub

    'cli_Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_Dia,cli_Mes,cli_Ano,cli_Curriculo,cli_Email,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Inativo,cli_InativoObs,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade,cli_DtCadastro) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

    Private Sub CarregaGrid()
        Dim cldTarefa As New clsTarefas
        dgvTarefas.DataSource = cldTarefa.ListTarefa(txtPesquisa.Text).Tables(0)
    End Sub

    Private Sub btCarregaGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCarregaGrid.Click
        'ListaTarefas()
        CarregaGrid()
    End Sub

    Private Sub PFormataDataGridView1()
        With dgvAniversariantes
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToResizeColumns = False
            .EnableHeadersVisualStyles = False

            .Columns(0).HeaderText = "Código"
            .Columns(1).HeaderText = "Nome"
            .Columns(2).HeaderText = "Endereço"
            .Columns(3).HeaderText = "Cep"
            .Columns(4).HeaderText = "Cidade"
            .Columns(5).HeaderText = "ativo"
            .Columns(6).HeaderText = "Telefone"
            .Columns(7).HeaderText = "Celular"
            .Columns(8).HeaderText = "Dia"
            .Columns(9).HeaderText = "Mês"
            .Columns(10).HeaderText = "E-mail"

            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub


    
   
   
End Class
