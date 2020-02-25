'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text
Public Class clsAcessoria
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New Conexao
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados

    Private _IdAssessoria As Integer
    Public Property IdAssessoria() As Integer
        Get
            Return _IdAssessoria
        End Get
        Set(ByVal value As Integer)
            _IdAssessoria = value
        End Set
    End Property

    Private _contato As String

    Public Property contato() As String
        Get
            Return _contato
        End Get
        Set(ByVal value As String)
            _contato = value
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

    Private _responsavel As String
    Public Property responsavel() As String
        Get
            Return _responsavel
        End Get
        Set(ByVal value As String)
            _responsavel = value
        End Set
    End Property


    Private _mes As String
    Public Property mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
        End Set
    End Property

    Private _ano As Integer
    Public Property ano() As Integer
        Get
            Return _ano
        End Get
        Set(ByVal value As Integer)
            _ano = value
        End Set
    End Property

    Private _PROLABORE As Boolean
    Public Property PROLABORE() As Boolean
        Get
            Return _PROLABORE
        End Get
        Set(ByVal value As Boolean)
            _PROLABORE = value
        End Set
    End Property

    Private _salario13 As String
    Public Property salario13() As String
        Get
            Return _salario13
        End Get
        Set(ByVal value As String)
            _salario13 = value
        End Set
    End Property

    Private _FOLHA As Boolean
    Public Property FOLHA() As Boolean
        Get
            Return _FOLHA
        End Get
        Set(ByVal value As Boolean)
            _FOLHA = value
        End Set
    End Property


    Private _SEFIP As Boolean
    Public Property SEFIP() As Boolean
        Get
            Return _SEFIP
        End Get
        Set(ByVal value As Boolean)
            _SEFIP = value
        End Set
    End Property

    Private _GPS As Boolean
    Public Property GPS() As Boolean
        Get
            Return _GPS
        End Get
        Set(ByVal value As Boolean)
            _GPS = value
        End Set
    End Property

    Private _GRF As Boolean
    Public Property GRF() As Boolean
        Get
            Return _GRF
        End Get
        Set(ByVal value As Boolean)
            _GRF = value
        End Set
    End Property
    ' IdAssessoria,contato,empresa,responsavel,mes,ano,PROLABORE,SALARIO13,FOLHA,SEFIP,GPS,
    ' GRF,IRRF,DAS,DASZERO,DASN,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,GIA,CAGED,obs
    Private _IRRF As Boolean
    Public Property IRRF() As Boolean
        Get
            Return _IRRF
        End Get
        Set(ByVal value As Boolean)
            _IRRF = value
        End Set
    End Property

    Private _DAS As Boolean
    Public Property DAS() As Boolean
        Get
            Return _DAS
        End Get
        Set(ByVal value As Boolean)
            _DAS = value
        End Set
    End Property

    Private _DASZERO As Boolean
    Public Property DASZERO() As Boolean
        Get
            Return _DASZERO
        End Get
        Set(ByVal value As Boolean)
            _DASZERO = value
        End Set
    End Property

    Private _DASN As Boolean
    Public Property DASN() As Boolean
        Get
            Return _DASN
        End Get
        Set(ByVal value As Boolean)
            _DASN = value
        End Set
    End Property

    Private _DCTF As Boolean
    Public Property DCTF() As Boolean
        Get
            Return _DCTF
        End Get
        Set(ByVal value As Boolean)
            _DCTF = value
        End Set
    End Property

    Private _RAIS As Boolean
    Public Property RAIS() As Boolean
        Get
            Return _RAIS
        End Get
        Set(ByVal value As Boolean)
            _RAIS = value
        End Set
    End Property

    Private _RAISNEGATIVA As Boolean
    Public Property RAISNEGATIVA() As Boolean
        Get
            Return _RAISNEGATIVA
        End Get
        Set(ByVal value As Boolean)
            _RAISNEGATIVA = value
        End Set
    End Property

    Private _ECF As Boolean
    Public Property ECF() As Boolean
        Get
            Return _ECF
        End Get
        Set(ByVal value As Boolean)
            _ECF = value
        End Set
    End Property

    Private _EFD As Boolean
    Public Property EFD() As Boolean
        Get
            Return _EFD
        End Get
        Set(ByVal value As Boolean)
            _EFD = value
        End Set
    End Property

    Private _GIA As Boolean
    Public Property GIA() As Boolean
        Get
            Return _GIA
        End Get
        Set(ByVal value As Boolean)
            _GIA = value
        End Set
    End Property

    Private _CAGED As Boolean
    Public Property CAGED() As Boolean
        Get
            Return _CAGED
        End Get
        Set(ByVal value As Boolean)
            _CAGED = value
        End Set
    End Property

    Private _obs As String
    Public Property obs() As String
        Get
            Return _obs
        End Get
        Set(ByVal value As String)
            _obs = value
        End Set
    End Property

    'METODO QUE GRAVA DADOS em Acessoria Contábil
    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO tbAssessoria(empresa,contato,responsavel,mes,ano,PROLABORE,SALARIO13,FOLHA,SEFIP,GPS,GRF,IRRF,DAS,DASZERO,DASN,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,GIA,CAGED,obs) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@empresa", _empresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@contato", _contato))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@responsavel", _responsavel))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@mes", _mes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ano", _ano))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@PROLABORE", _PROLABORE))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@SALARIO13", _salario13))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@FOLHA", _FOLHA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@SEFIP", _SEFIP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@GPS", _GPS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@GRF", _GRF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@IRRF", _IRRF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DAS", _DAS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DASZERO", _DASZERO))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DASN", _DASN))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DCTF", _DCTF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@RAIS", _RAIS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@RAISNEGATIVA", _RAISNEGATIVA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ECF", _ECF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@EFD", _EFD))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@GIA", _GIA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CAGED", _CAGED))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@obs", _obs))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Operação realizada com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    'ALTERA DADOS em Acessoria Contábil

    Public Sub AlterarDados()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                ' IdAssessoria,empresa,contato,responsavel,mes,ano,PROLABORE,SALARIO13,FOLHA,SEFIP,GPS,GRF,IRRF,DAS,DASZERO,DASN,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,GIA,CAGED,obs
                Dim sql As String = "UPDATE tbAssessoria SET empresa=?,contato=?,responsavel=?,mes=?,ano=?,PROLABORE=?,SALARIO13=?,FOLHA=?,SEFIP=?,GPS=?,GRF=?,IRRF=?,DAS=?,DASZERO=?,DASN=?,DCTF=?,RAIS=?,RAISNEGATIVA=?,ECF=?,EFD=?,GIA=?,CAGED=?,obs=? WHERE IdAssessoria =" & CInt(IdAssessoria)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@empresa", _empresa))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@contato", _contato))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@responsavel", _responsavel))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@mes", _mes))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ano", _ano))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@PROLABORE", _PROLABORE))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@SALARIO13", _salario13))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@FOLHA", _FOLHA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@SEFIP", _SEFIP))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@GPS", _GPS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@GRF", _GRF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@IRRF", _IRRF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DAS", _DAS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DASZERO", _DASZERO))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DASN", _DASN))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@DCTF", _DCTF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@RAIS", _RAIS))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@RAISNEGATIVA", _RAISNEGATIVA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@ECF", _ECF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@EFD", _EFD))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@GIA", _GIA))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@CAGED", _CAGED))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@obs", _obs))

                cmd.ExecuteNonQuery()

                MessageBox.Show("Operação de alteração realizada com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    ' IdAssessoria,empresa,contato,responsavel,mes,ano,PROLABORE,SALARIO13,FOLHA,SEFIP,GPS,GRF,IRRF,DAS,DASZERO,DASN,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,GIA,CAGED,obs
    'lista DADOS 

    'Public Function Listar(ByVal strEmpresa As String, ByVal strMes As String, ByVal strAno As Integer) As DataSet
    Public Function Listar(ByVal strEmpresa As String, ByVal strMes As String, ByVal strAno As String) As DataSet
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT IdAssessoria as Codigo,empresa as Empresa,contato as Contato,responsavel as Responsavel,mes as Mes,ano as Ano,PROLABORE,SALARIO13,FOLHA,SEFIP,GPS,GRF,IRRF,DAS,DASZERO,DASN,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,GIA,CAGED,obs ")
        strQuery.Append(" FROM tbAssessoria ")
        If Not strEmpresa.Equals(String.Empty) Then
            strQuery.Append(" WHERE mes like '%" & strMes & "%'")
        End If

        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function





End Class
