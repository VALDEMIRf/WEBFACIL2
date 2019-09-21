
Public Class frmClienteConsulta
    Public Enum TipoConsulta
        Cliente
    End Enum

    Private Sub CarregaGrid()
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente
                Dim clnCliente As New clsCliente
                dsConsulta = clnCliente.Listar(txtCPFPesquisa.Text)
                'Case TipoConsulta.Produto
                '    Dim clnProduto As New DLLControleDeVendas.Produto
                '    dsConsulta = clnProduto.Listar(txtDescricao.Text)
        End Select
        dgvGrid.DataSource = dsConsulta.Tables(0)
    End Sub

    Private _ConsultaTipo As TipoConsulta
    Public Property ConsultaTipo() As TipoConsulta
        Get
            Return _ConsultaTipo
        End Get
        Set(ByVal value As TipoConsulta)
            _ConsultaTipo = value
        End Set
    End Property

    Private _CodigoRetorno As Integer
    Public Property CodigoRetorno() As Integer
        Get
            Return _CodigoRetorno
        End Get
        Set(ByVal value As Integer)
            _CodigoRetorno = value
        End Set
    End Property

    Private _NomeRetorno As String
    Public Property NomeRetorno() As String
        Get
            Return _NomeRetorno
        End Get
        Set(ByVal value As String)
            _NomeRetorno = value
        End Set
    End Property

    Private _CPFRetorno As String
    Public Property CPFRetorno() As String
        Get
            Return _CPFRetorno
        End Get
        Set(ByVal value As String)
            _CPFRetorno = value
        End Set
    End Property

    Private Sub btPesquisaCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPesquisaCliente.Click
        CarregaGrid()
    End Sub

    
    
    Private Sub btFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFechar.Click
        Me.Close()
    End Sub

    Private Sub btEnviarDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnviarDados.Click
        Dim dsConsulta As New Data.DataSet
        Select Case _ConsultaTipo
            Case TipoConsulta.Cliente
                If dgvGrid.RowCount <> 0 Then
                    _CodigoRetorno = dgvGrid.CurrentRow.Cells(0).Value
                    _NomeRetorno = dgvGrid.CurrentRow.Cells(1).Value
                    _CPFRetorno = dgvGrid.CurrentRow.Cells(2).Value
                    Me.Close()
                End If
                'Case TipoConsulta.Produto
                '    If dgvGrid.RowCount <> 0 Then
                '        _CodigoRetorno = dgvGrid.CurrentRow.Cells(0).Value
                '        _DescricaoRetorno = dgvGrid.CurrentRow.Cells(1).Value
                '        _valorpord = dgvGrid.CurrentRow.Cells(2).Value
                '        Me.Close()
                '    End If
        End Select
    End Sub

    Private Sub dgvGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvGrid.DoubleClick
        If dgvGrid.RowCount <> 0 Then
            _CodigoRetorno = dgvGrid.CurrentRow.Cells(0).Value
            _NomeRetorno = dgvGrid.CurrentRow.Cells(1).Value
            If _ConsultaTipo <> 0 Then
                _CPFRetorno = dgvGrid.CurrentRow.Cells(2).Value
            End If
            Me.Close()
        End If
    End Sub
End Class