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
    ' IdAssessoria,contato,empresa,responsavel,mes,ano,PRO-LABORE,SALARIO13,FOLHA,SEFIP,GPS,
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
    ' IdAssessoria,contato,empresa,responsavel,mes,ano,PRO-LABORE,SALARIO13,FOLHA,SEFIP,GPS,
    ' GRF,IRRF,DAS,DASZERO,DASN,DCTF,RAIS,RAISNEGATIVA,ECF,EFD,GIA,CAGED,obs
End Class
