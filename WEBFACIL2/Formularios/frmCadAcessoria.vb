Imports System.Data.OleDb
Imports System.Data
Public Class frmCadAcessoria
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Dim CodigoEmpresa As Integer
    Dim assessoria As New clsAcessoria
    Dim i As Integer = 0


    Public Enum TipoConsulta
        Assessoria
        Access = 1
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

    Private _IdAssessoria As Integer
    Public Property IdAssessoria() As Integer
        Get
            Return _IdAssessoria
        End Get
        Set(ByVal value As Integer)
            _IdAssessoria = value
        End Set
    End Property

    Private _empresa As String
    Public Property empresa() As String
        Get
            Return _empresa
        End Get
        Set(ByVal value As String)
            _empresa = value
        End Set
    End Property


    Dim valorEnum As TipoConsulta
    ' Sub New(ByVal bd As Integer)
    ' This call is required by the Windows Form Designer.
    ' InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    '  valorEnum = CType(bd, TipoConsulta)
    '  End Sub


    Private Sub frmCadAcessoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpresa.Focus()
        'carregaDados()


        Select Case valorEnum
            Case TipoConsulta.Access
                carregaCampos(txtMes.Text, txtAno.Text)

            Case Else
                Exit Select
        End Select

    End Sub
    '  Private Sub carregaDados(ByVal strMes As String, ByVal strAno As String) 'As DataSet
    Private Sub carregaDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM tbASSESSORIA WHERE mes = " & txtMes.Text
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                ' dgvAssessoria.DataSource = dt

                da = New OleDbDataAdapter("SELECT * FROM tbASSESSORIA WHERE mes = " & txtMes.Text, con)
                ds = New DataSet()
                da.Fill(ds, "tbASSESSORIA")
                Call ExibeDados()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub carregaCampos(ByVal strmes As Integer, ByVal strano As Integer) 'As DataSet
        carregaDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM tbASSESSORIA"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                ' dgvAssessoria.DataSource = dt

                da = New OleDbDataAdapter("select * from tbASSESSORIA WHERE mes = " & strmes & " AND ANO = " & strano & "", con)
                ds = New DataSet()
                da.Fill(ds, "tbASSESSORIA")
                Call ExibeDados()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub ExibeDados()

        lblAcessoID.Text = ds.Tables(0).Rows(i)("IdAssessoria").ToString()
        txtEmpresa.Text = ds.Tables(0).Rows(i)("empresa").ToString()
        txtGerente.Text = ds.Tables(0).Rows(i)("gerente").ToString()
        txtResponsavel.Text = ds.Tables(0).Rows(i)("responsavel").ToString()
        txtTelefone.Text = ds.Tables(0).Rows(i)("telefone").ToString()
        txtMes.Text = ds.Tables(0).Rows(i)("mes").ToString()
        txtAno.Text = ds.Tables(0).Rows(i)("ano").ToString()
        chbProlabore.Checked = ds.Tables(0).Rows(i)("PROLABORE").ToString()
        txt13salario.Text = ds.Tables(0).Rows(i)("SALARIO13").ToString()
        chbFolha.Checked = ds.Tables(0).Rows(i)("FOLHA").ToString()
        chbDARF.Checked = ds.Tables(0).Rows(i)("DARF").ToString()
        chbGRRF.Checked = ds.Tables(0).Rows(i)("GRRF").ToString()
        chbSefip.Checked = ds.Tables(0).Rows(i)("SEFIP").ToString()
        chbGPS.Checked = ds.Tables(0).Rows(i)("GPS").ToString()
        chbGRF.Checked = ds.Tables(0).Rows(i)("GRF").ToString()
        chbDAS.Checked = ds.Tables(0).Rows(i)("DAS").ToString()
        chbDASZERO.Checked = ds.Tables(0).Rows(i)("DASZERO").ToString()
        chbDASN.Checked = ds.Tables(0).Rows(i)("DASN").ToString()
        chbDEFIS.Checked = ds.Tables(0).Rows(i)("DEFIS").ToString()
        chbIRRF.Checked = ds.Tables(0).Rows(i)("IRRF").ToString()
        chbDCTF.Checked = ds.Tables(0).Rows(i)("DCTF").ToString()
        chbRAIS.Checked = ds.Tables(0).Rows(i)("RAIS").ToString()
        chbRAISNEGATIVA.Checked = ds.Tables(0).Rows(i)("RAISNEGATIVA").ToString()
        chbECF.Checked = ds.Tables(0).Rows(i)("ECF").ToString()
        chbEFD.Checked = ds.Tables(0).Rows(i)("EFD").ToString()
        chbGIA.Checked = ds.Tables(0).Rows(i)("GIA").ToString()
        chbCAGED.Checked = ds.Tables(0).Rows(i)("CAGED").ToString()
        txtObs.Text = ds.Tables(0).Rows(i)("obs").ToString()
        ' IdAssessoria,empresa,gerente,responsavel,telefone,mes,ano,PROLABORE,SALARIO13,FOLHA,
        'DARF,GRRF,SEFIP,GPS,GRF,DAS,DASZERO,DASN,DEFIS,IRRF,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,
        'GIA, CAGED, obs

    End Sub


    'botão de gravar
    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtEmpresa.Text.Equals(String.Empty) Then
            errErro.SetError(txtEmpresa, "Digite o nome da Empresa")
            txtEmpresa.Focus()
            Exit Sub
        Else
            errErro.SetError(txtEmpresa, "")

        End If
        'If txtGerente.Text.Equals(String.Empty) Then
        '    errErro.SetError(txtGerente, "Digite o nome do Contato")
        '    Exit Sub
        'Else
        '    errErro.SetError(txtGerente, "")
        'End If
        'If txtResponsavel.Text.Equals(String.Empty) Then
        '    errErro.SetError(txtResponsavel, "Digite o nome do Responsável")

        '    Exit Sub
        'Else
        '    errErro.SetError(txtResponsavel, "")

        'End If
        'If txtTelefone.Text.Equals(String.Empty) Then
        '    errErro.SetError(txtTelefone, "Digite o nome do Gerente")
        '    Exit Sub
        'Else
        '    errErro.SetError(txtTelefone, "")
        'End If
        If txtMes.Text.Equals(String.Empty) Then
            errErro.SetError(txtMes, "Digite o Mês")
            Exit Sub
        Else
            errErro.SetError(txtMes, "")
        End If
        If txtAno.Text.Equals(String.Empty) Then
            errErro.SetError(txtAno, "Digite o Ano")
            Exit Sub
        Else
            errErro.SetError(txtAno, "")
        End If
        ' IdAssessoria,empresa,gerente,responsavel,telefone,mes,ano,PROLABORE,SALARIO13,FOLHA,
        'DARF,GRRF,SEFIP,GPS,GRF,DAS,DASZERO,DASN,DEFIS,IRRF,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,
        'GIA, CAGED, obs
        Try
            assessoria.empresa = txtEmpresa.Text
            assessoria.gerente = txtGerente.Text
            assessoria.responsavel = txtResponsavel.Text
            assessoria.telefone = txtTelefone.Text
            assessoria.mes = txtMes.Text
            assessoria.ano = txtAno.Text
            assessoria.PROLABORE = chbProlabore.Checked
            assessoria.salario13 = txt13salario.Text
            assessoria.FOLHA = chbFolha.Checked
            assessoria.DARF = chbDARF.Checked
            assessoria.GRRF = chbGRRF.Checked
            assessoria.SEFIP = chbSefip.Checked
            assessoria.GPS = chbGPS.Checked
            assessoria.GRF = chbGRF.Checked
            assessoria.DAS = chbDAS.Checked
            assessoria.DASZERO = chbDASZERO.Checked
            assessoria.DASN = chbDASN.Checked
            assessoria.DEFIS = chbDEFIS.Checked
            assessoria.IRRF = chbIRRF.Checked
            assessoria.DCTF = chbDCTF.Checked
            assessoria.RAIS = chbRAIS.Checked
            assessoria.RAISNEGATIVA = chbRAISNEGATIVA.Checked
            assessoria.ECF = chbECF.Checked
            assessoria.EFD = chbEFD.Checked
            assessoria.GIA = chbGIA.Checked
            assessoria.CAGED = chbCAGED.Checked
            assessoria.obs = txtObs.Text

            assessoria.GravarDados()

            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' IdAssessoria,empresa,gerente,responsavel,telefone,mes,ano,PROLABORE,SALARIO13,FOLHA,
        'DARF,GRRF,SEFIP,GPS,GRF,DAS,DASZERO,DASN,DEFIS,IRRF,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,
        'GIA, CAGED, obs
        If txtEmpresa.Text.Equals(String.Empty) Then
            errErro.SetError(txtEmpresa, "Digite o nome da Empresa")
            txtEmpresa.Focus()
            Exit Sub
        Else
            errErro.SetError(txtEmpresa, "")

        End If

        If txtMes.Text.Equals(String.Empty) Then
            errErro.SetError(txtMes, "Digite o Mês")
            Exit Sub
        Else
            errErro.SetError(txtMes, "")
        End If
        If txtAno.Text.Equals(String.Empty) Then
            errErro.SetError(txtAno, "Digite o Ano")
            Exit Sub
        Else
            errErro.SetError(txtAno, "")
        End If
        ' IdAssessoria,empresa,gerente,responsavel,telefone,mes,ano,PROLABORE,SALARIO13,FOLHA,
        'DARF,GRRF,SEFIP,GPS,GRF,DAS,DASZERO,DASN,DEFIS,IRRF,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,
        'GIA, CAGED, obs
        Try
            assessoria.empresa = txtEmpresa.Text
            assessoria.gerente = txtGerente.Text
            assessoria.responsavel = txtResponsavel.Text
            assessoria.telefone = txtTelefone.Text
            assessoria.mes = txtMes.Text
            assessoria.ano = txtAno.Text
            assessoria.PROLABORE = chbProlabore.Checked
            assessoria.salario13 = txt13salario.Text
            assessoria.FOLHA = chbFolha.Checked
            assessoria.DARF = chbDARF.Checked
            assessoria.GRRF = chbGRRF.Checked
            assessoria.SEFIP = chbSefip.Checked
            assessoria.GPS = chbGPS.Checked
            assessoria.GRF = chbGRF.Checked
            assessoria.DAS = chbDAS.Checked
            assessoria.DASZERO = chbDASZERO.Checked
            assessoria.DASN = chbDASN.Checked
            assessoria.DEFIS = chbDEFIS.Checked
            assessoria.IRRF = chbIRRF.Checked
            assessoria.DCTF = chbDCTF.Checked
            assessoria.RAIS = chbRAIS.Checked
            assessoria.RAISNEGATIVA = chbRAISNEGATIVA.Checked
            assessoria.ECF = chbECF.Checked
            assessoria.EFD = chbEFD.Checked
            assessoria.GIA = chbGIA.Checked
            assessoria.CAGED = chbCAGED.Checked
            assessoria.obs = txtObs.Text

            assessoria.AlterarDados()

            LimparCampos()

        Catch ex As Exception
            MessageBox.Show("não foi possível fazer o alterar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmAcessoriaConsulta As New frmAcessoriaConsulta
        frmAcessoriaConsulta.Text = "Consulta de Cliente"
        frmAcessoriaConsulta.ConsultaTipo = frmAcessoriaConsulta.TipoConsulta.Assessoria
        frmAcessoriaConsulta.ShowDialog()
        ' IdAssessoria,empresa,gerente,responsavel,telefone,mes,ano,PROLABORE,SALARIO13,FOLHA,
        'DARF,GRRF,SEFIP,GPS,GRF,DAS,DASZERO,DASN,DEFIS,IRRF,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,
        'GIA, CAGED, obs
        CodigoEmpresa = frmAcessoriaConsulta.IdAssessoria
        lblAcessoID.Text = frmAcessoriaConsulta.IdAssessoria
        txtEmpresa.Text = frmAcessoriaConsulta.empresa
        txtGerente.Text = frmAcessoriaConsulta.gerente
        txtResponsavel.Text = frmAcessoriaConsulta.responsavel
        txtTelefone.Text = frmAcessoriaConsulta.telefone
        txtMes.Text = frmAcessoriaConsulta.mes
        txtAno.Text = frmAcessoriaConsulta.ano
        chbProlabore.Checked = frmAcessoriaConsulta.PROLABORE
        txt13salario.Text = frmAcessoriaConsulta.salario13
        chbFolha.Checked = frmAcessoriaConsulta.FOLHA
        chbDARF.Checked = frmAcessoriaConsulta.DARF
        chbGRRF.Checked = frmAcessoriaConsulta.GRRF
        chbSefip.Checked = frmAcessoriaConsulta.SEFIP
        chbGPS.Checked = frmAcessoriaConsulta.GPS
        chbGRF.Checked = frmAcessoriaConsulta.GRF
        chbDAS.Checked = frmAcessoriaConsulta.DAS
        chbDASZERO.Checked = frmAcessoriaConsulta.DASZERO
        chbDASN.Checked = frmAcessoriaConsulta.DASN
        chbDEFIS.Checked = frmAcessoriaConsulta.DEFIS
        chbIRRF.Checked = frmAcessoriaConsulta.IRRF
        chbDCTF.Checked = frmAcessoriaConsulta.DCTF
        chbRAIS.Checked = frmAcessoriaConsulta.RAIS
        chbRAISNEGATIVA.Checked = frmAcessoriaConsulta.RAISNEGATIVA
        chbECF.Checked = frmAcessoriaConsulta.ECF
        chbEFD.Checked = frmAcessoriaConsulta.EFD
        chbGIA.Checked = frmAcessoriaConsulta.GIA
        chbCAGED.Checked = frmAcessoriaConsulta.CAGED
        txtObs.Text = frmAcessoriaConsulta.obs

    End Sub

    Private Sub btSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub LimparCampos()

        txtEmpresa.Text = ""
        txtGerente.Text = ""
        txtResponsavel.Text = ""
        txtTelefone.Text = ""
        txtMes.Text = ""
        txtAno.Text = ""
        chbProlabore.Checked = False
        txt13salario.Text = ""
        chbFolha.Checked = False
        chbDARF.Checked = False
        chbGRRF.Checked = False
        chbSefip.Checked = False
        chbGPS.Checked = False
        chbGRF.Checked = False
        chbDAS.Checked = False
        chbDASZERO.Checked = False
        chbDASN.Checked = False
        chbIRRF.Checked = False
        chbDEFIS.Checked = False
        chbDCTF.Checked = False
        chbRAIS.Checked = False
        chbRAISNEGATIVA.Checked = False
        chbECF.Checked = False
        chbEFD.Checked = False
        chbGIA.Checked = False
        chbCAGED.Checked = False
        txtObs.Text = ""

    End Sub

    Private Sub btnPesquisar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Dim frmAcessoriaConsulta As New frmAcessoriaConsulta
        frmAcessoriaConsulta.Text = "Consulta de Cliente"
        frmAcessoriaConsulta.ConsultaTipo = frmAcessoriaConsulta.TipoConsulta.Assessoria
        frmAcessoriaConsulta.ShowDialog()

        CodigoEmpresa = frmAcessoriaConsulta.IdAssessoria
        lblAcessoID.Text = frmAcessoriaConsulta.IdAssessoria
        txtEmpresa.Text = frmAcessoriaConsulta.empresa
        txtGerente.Text = frmAcessoriaConsulta.gerente
        txtResponsavel.Text = frmAcessoriaConsulta.responsavel
        txtTelefone.Text = frmAcessoriaConsulta.telefone
        txtMes.Text = frmAcessoriaConsulta.mes
        txtAno.Text = frmAcessoriaConsulta.ano
        chbProlabore.Checked = frmAcessoriaConsulta.PROLABORE
        txt13salario.Text = frmAcessoriaConsulta.salario13
        chbFolha.Checked = frmAcessoriaConsulta.FOLHA
        chbDARF.Checked = frmAcessoriaConsulta.DARF
        chbGRRF.Checked = frmAcessoriaConsulta.GRRF
        chbSefip.Checked = frmAcessoriaConsulta.SEFIP
        chbGPS.Checked = frmAcessoriaConsulta.GPS
        chbGRF.Checked = frmAcessoriaConsulta.GRF
        chbDAS.Checked = frmAcessoriaConsulta.DAS
        chbDASZERO.Checked = frmAcessoriaConsulta.DASZERO
        chbDASN.Checked = frmAcessoriaConsulta.DASN
        chbDEFIS.Checked = frmAcessoriaConsulta.DEFIS
        chbIRRF.Checked = frmAcessoriaConsulta.IRRF
        chbDCTF.Checked = frmAcessoriaConsulta.DCTF
        chbRAIS.Checked = frmAcessoriaConsulta.RAIS
        chbRAISNEGATIVA.Checked = frmAcessoriaConsulta.RAISNEGATIVA
        chbECF.Checked = frmAcessoriaConsulta.ECF
        chbEFD.Checked = frmAcessoriaConsulta.EFD
        chbGIA.Checked = frmAcessoriaConsulta.GIA
        chbCAGED.Checked = frmAcessoriaConsulta.CAGED
        txtObs.Text = frmAcessoriaConsulta.obs
    End Sub

    Private Sub btRegistroAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRegistroAnterior.Click
        carregaDados()

        If i = ds.Tables(0).Rows.Count - 1 OrElse i <> 0 Then
            i -= 1
            Call ExibeDados()
        Else
            MsgBox("Início de arquivo.")
        End If
    End Sub

    Private Sub btProximoRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProximoRegistro.Click
        ' carregaCampos(ByVal strmes As Integer, ByVal strano As Integer) 'As DataSet
        carregaDados()
        If i < ds.Tables(0).Rows.Count - 1 Then
            i += 1
            Call ExibeDados()
        End If
    End Sub

    Private Sub btSalvar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalvar.Click

    End Sub
End Class