Imports System.Data.OleDb
Imports System.Text
Public Class frmVinculadoConsulta
    Public Enum TipoConsulta
        Cliente
    End Enum
    Private _myString As String
    
    Public Property myString() As String
        Set(ByVal value As String)
            _myString = value
        End Set
        Get
            Return _myString
        End Get
    End Property
    'Cria todos os métodos internos e propriedades externas com os mesmos atributos do banco de dados

    Private _vinc_id As Integer
    Public Property vinc_id() As Integer
        Get
            Return _vinc_id
        End Get
        Set(ByVal value As Integer)
            _vinc_id = value
        End Set
    End Property

    Private _ConsultaTipo As TipoConsulta
    Public Property ConsultaTipo() As TipoConsulta
        Get
            Return _ConsultaTipo
        End Get
        Set(ByVal value As TipoConsulta)
            _ConsultaTipo = value
        End Set
    End Property

    Private _clsCliente As clsCliente
    Public Property clsCliente() As clsCliente
        Get
            Return _clsCliente
        End Get
        Set(ByVal value As clsCliente)
            _clsCliente = value
        End Set
    End Property

    Private _vinc_nome As String
    Public Property vinc_nome() As String
        Get
            Return _vinc_nome
        End Get
        Set(ByVal value As String)
            _vinc_nome = value
        End Set
    End Property

    Private _vinc_CPF As String
    Public Property vinc_CPF() As String
        Get
            Return _vinc_CPF
        End Get
        Set(ByVal value As String)
            _vinc_CPF = value
        End Set
    End Property

    Private _vinc_vinculo As String
    Public Property vinc_vinculo() As String
        Get
            Return _vinc_vinculo
        End Get
        Set(ByVal value As String)
            _vinc_vinculo = value
        End Set
    End Property

    Private _vinc_lblVincID As Integer
    Public Property vinc_lblVincID() As Integer
        Get
            Return _vinc_lblVincID
        End Get
        Set(ByVal value As Integer)
            _vinc_lblVincID = value
        End Set
    End Property

    Private Sub frmVinculadoConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        txtDescricao.Text = Me.myString
        lblRecebeIDCliente.Text = Me.vinc_id

    End Sub






End Class