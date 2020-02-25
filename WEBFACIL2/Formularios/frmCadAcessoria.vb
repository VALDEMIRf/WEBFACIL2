Imports System.Data.OleDb

Public Class frmCadAcessoria
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    Dim CodigoEmpresa As Integer
    Dim assessoria As New clsAcessoria
    Public Enum TipoConsulta
        Assessoria

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
    ' IdAssessoria,empresa,contato,responsavel,mes,ano,PROLABORE,SALARIO13,FOLHA,SEFIP,GPS,GRF,IRRF,DAS,DASZERO,DASN,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,GIA,CAGED,obs

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

    Private Sub frmCadAcessoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmpresa.Focus()


        carregaDados()
    End Sub

    Private Sub carregaDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM tbASSESSORIA"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                ' dgvAssessoria.DataSource = dt

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    'botão de gravar
    Private Sub btSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtEmpresa.Text.Equals(String.Empty) Then
            errErro.SetError(txtEmpresa, "Digite um CPF")
            txtEmpresa.Focus()
            Exit Sub
        Else
            errErro.SetError(txtEmpresa, "")

        End If
        If txtContato.Text.Equals(String.Empty) Then
            errErro.SetError(txtContato, "Digite um nome")
            Exit Sub
        Else
            errErro.SetError(txtContato, "")
        End If
        If txtResponsavel.Text.Equals(String.Empty) Then
            errErro.SetError(txtResponsavel, "Digite um CPF")

            Exit Sub
        Else
            errErro.SetError(txtResponsavel, "")

        End If
        If txtMes.Text.Equals(String.Empty) Then
            errErro.SetError(txtMes, "Digite um nome")
            Exit Sub
        Else
            errErro.SetError(txtMes, "")
        End If
        If txtAno.Text.Equals(String.Empty) Then
            errErro.SetError(txtAno, "Digite um nome")
            Exit Sub
        Else
            errErro.SetError(txtAno, "")
        End If

        Try
            assessoria.empresa = txtEmpresa.Text
            assessoria.contato = txtContato.Text
            assessoria.responsavel = txtResponsavel.Text
            assessoria.mes = txtMes.Text
            assessoria.ano = txtAno.Text
            assessoria.PROLABORE = chbProlabore.Checked
            assessoria.salario13 = txt13salario.Text
            assessoria.FOLHA = chbFolha.Checked
            assessoria.SEFIP = chbSefip.Checked
            assessoria.GPS = chbGPS.Checked
            assessoria.GRF = chbGRF.Checked
            assessoria.IRRF = chbIRRF.Checked
            assessoria.DAS = chbDAS.Checked
            assessoria.DASZERO = chbDASZERO.Checked
            assessoria.DASN = chbDASN.Checked
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
        ' IdAssessoria,empresa,contato,responsavel,mes,ano,PROLABORE,SALARIO13,FOLHA,SEFIP,GPS,GRF,
        'IRRF, DAS, DASZERO, DASN, DCTF, RAIS, RAISNEGATIVA, ECF, EFD, GIA, CAGED, obs

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmAcessoriaConsulta As New frmAcessoriaConsulta
        frmAcessoriaConsulta.Text = "Consulta de Cliente"
        frmAcessoriaConsulta.ConsultaTipo = frmAcessoriaConsulta.TipoConsulta.Assessoria
        frmAcessoriaConsulta.ShowDialog()

        CodigoEmpresa = frmAcessoriaConsulta.IdAssessoria
        txtEmpresa.Text = frmAcessoriaConsulta.empresa
        txtContato.Text = frmAcessoriaConsulta.contato
        txtResponsavel.Text = frmAcessoriaConsulta.responsavel
        txtMes.Text = frmAcessoriaConsulta.mes
        txtAno.Text = frmAcessoriaConsulta.ano
        chbProlabore.Checked = frmAcessoriaConsulta.PROLABORE
        txt13salario.Text = frmAcessoriaConsulta.salario13
        chbFolha.Checked = frmAcessoriaConsulta.FOLHA
        chbSefip.Checked = frmAcessoriaConsulta.SEFIP
        chbGPS.Checked = frmAcessoriaConsulta.GPS
        chbGRF.Checked = frmAcessoriaConsulta.GRF
        chbIRRF.Checked = frmAcessoriaConsulta.IRRF
        chbDAS.Checked = frmAcessoriaConsulta.DAS
        chbDASZERO.Checked = frmAcessoriaConsulta.DASZERO
        chbDASN.Checked = frmAcessoriaConsulta.DASN
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
        txtContato.Text = ""
        txtResponsavel.Text = ""
        txtMes.Text = ""
        txtAno.Text = ""
        chbProlabore.Checked = False
        txt13salario.Text = ""
        chbFolha.Checked = False
        chbSefip.Checked = False
        chbGPS.Checked = False
        chbGRF.Checked = False
        chbIRRF.Checked = False
        chbDAS.Checked = False
        chbDASZERO.Checked = False
        chbDASN.Checked = False
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
        txtEmpresa.Text = frmAcessoriaConsulta.empresa
        txtContato.Text = frmAcessoriaConsulta.contato
        txtResponsavel.Text = frmAcessoriaConsulta.responsavel
        txtMes.Text = frmAcessoriaConsulta.mes
        txtAno.Text = frmAcessoriaConsulta.ano
        chbProlabore.Checked = frmAcessoriaConsulta.PROLABORE
        txt13salario.Text = frmAcessoriaConsulta.salario13
        chbFolha.Checked = frmAcessoriaConsulta.FOLHA
        chbSefip.Checked = frmAcessoriaConsulta.SEFIP
        chbGPS.Checked = frmAcessoriaConsulta.GPS
        chbGRF.Checked = frmAcessoriaConsulta.GRF
        chbIRRF.Checked = frmAcessoriaConsulta.IRRF
        chbDAS.Checked = frmAcessoriaConsulta.DAS
        chbDASZERO.Checked = frmAcessoriaConsulta.DASZERO
        chbDASN.Checked = frmAcessoriaConsulta.DASN
        chbDCTF.Checked = frmAcessoriaConsulta.DCTF
        chbRAIS.Checked = frmAcessoriaConsulta.RAIS
        chbRAISNEGATIVA.Checked = frmAcessoriaConsulta.RAISNEGATIVA
        chbECF.Checked = frmAcessoriaConsulta.ECF
        chbEFD.Checked = frmAcessoriaConsulta.EFD
        chbGIA.Checked = frmAcessoriaConsulta.GIA
        chbCAGED.Checked = frmAcessoriaConsulta.CAGED
        txtObs.Text = frmAcessoriaConsulta.obs
    End Sub
End Class