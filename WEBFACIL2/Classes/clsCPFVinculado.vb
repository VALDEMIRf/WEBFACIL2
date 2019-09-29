'Adiciona as Namespaces necessárias nesta classe
Imports System.Data.OleDb
Imports System.Text

Public Class clsCPFVinculado
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

    Public Sub GravarDados()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open() '
                Dim sql As String = "INSERT INTO tbCPFVinculado(cli_id,vinc_nome,vinc_CPF,vinc_vinculo) VALUES(?,?,?,?)"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_id", _vinc_lblVincID))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_nome", _vinc_nome))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_CPF", _vinc_CPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_vinculo", _vinc_vinculo))
                

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

    Public Sub AlterarDados()

        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "UPDATE tbCPFVinculado SET cli_id=?,vinc_nome=?,vinc_CPF=?,vinc_vinculo=? WHERE empr_ID =" & CInt(vinc_id)
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)

                cmd.Parameters.Add(New OleDb.OleDbParameter("@cli_id", _vinc_lblVincID))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_nome", _vinc_nome))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_CPF", _vinc_CPF))
                cmd.Parameters.Add(New OleDb.OleDbParameter("@vinc_vinculo", _vinc_vinculo))

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



    Public Function Listar(ByVal strDescricao As String) As DataSet
        'Cria um StringBuilder para concatenar a Query Sql
        Dim strQuery As New StringBuilder
        ' strQuery.Append(" SELECT cli_id as Codigo,cli_CPF as CPF,cli_RG as RG,cli_Nome as Nome,cli_PIS,cli_TitEleitoral,cli_Logradouro,cli_Numero,cli_complemento,cli_Bairro,cli_Cidade,cli_UF,cli_CEP,cli_FoneRes,cli_FoneCel,cli_data_nasc,cli_Curriculo,cli_Email,cli_observacoes,cli_Aposentado,cli_NumBeneficio,cli_FuncPublico,cli_NomeFunc,cli_Autonomo,cli_AutonomoNome,cli_Falecido,cli_NomeFalecido,cli_Inativo,cli_InativoObs,cli_Parcelamento,cli_NumParcelamento,cli_EmprDom,cli_ESocial,cli_EsocialSenha,cli_VIP,cli_VIPDescricao,cli_PJ,cli_NumPJ,cli_MEI,cli_NumMEI,cli_ITR,cli_NumITR,cli_Mensalista,cli_NomeMensalista,cli_Decore,cli_DecoreDescricao,cli_IRPF,cli_NumIRPF,cli_SenWebPrefeitura,cli_SenhaWebPrefeitura,cli_Redesim,cli_SenhaRedesim,cli_CodRFB,cli_CodRFBNum,cli_CodRFBValidade ")
        strQuery.Append(" SELECT c.cli_id as codigo,c.cli_CPF as CPF,c.cli_RG as RG,c.cli_Nome as Nome,c.cli_PIS,c.cli_TitEleitoral,c.cli_Logradouro,c.cli_Numero,c.cli_complemento,c.cli_Bairro,c.cli_Cidade,c.cli_UF,c.cli_CEP,c.cli_FoneRes,c.cli_FoneCel,c.cli_data_nasc,c.cli_Curriculo,c.cli_Email,c.cli_observacoes,c.cli_Aposentado,c.cli_NumBeneficio,c.cli_FuncPublico,c.cli_NomeFunc,c.cli_Autonomo,c.cli_AutonomoNome,c.cli_Falecido,c.cli_NomeFalecido,c.cli_Inativo,c.cli_InativoObs,c.cli_Parcelamento,c.cli_NumParcelamento,c.cli_EmprDom,c.cli_ESocial,c.cli_EsocialSenha,c.cli_VIP,c.cli_VIPDescricao,c.cli_PJ,c.cli_NumPJ,c.cli_MEI,c.cli_NumMEI,c.cli_ITR,c.cli_NumITR,c.cli_Mensalista,c.cli_NomeMensalista,c.cli_Decore,c.cli_DecoreDescricao,c.cli_IRPF,c.cli_NumIRPF,c.cli_SenWebPrefeitura,c.cli_SenhaWebPrefeitura,c.cli_Redesim,c.cli_SenhaRedesim,c.cli_CodRFB,c.cli_CodRFBNum,c.cli_CodRFBValidade,e.empr_ID,e.empr_razaosocial as Empresa,e.empr_nomefantasia,e.empr_cnpj as CNPJ,e.empr_NIRE,e.empr_InscrEstadual,e.empr_CCM,e.empr_atividade,e.empr_Porte,e.cli_id,e.cat_Id,e.empr_dataInicio,e.empr_endereco,e.empr_numero,e.empr_complemento,e.empr_bairro,e.empr_cidade,e.empr_UF,e.empr_CEP,e.empr_obs,e.empr_Simples,e.empr_SimplesNacional,e.empr_Simei,e.empr_CodSimei,e.empr_sefaz,e.empr_SefazUsu,e.empr_SefazSen,e.empr_CodReceitaPJ,e.empr_NumCodReceitaPJ ")
        strQuery.Append(" FROM tbCPFVinculado as c INNER JOIN tbClientes as e ")
        strQuery.Append(" ON c.cli_id = e.cli_id")
        If Not strDescricao.Equals(String.Empty) Then
            strQuery.Append(" WHERE c.cli_CPF like '%" & strDescricao & "%'")
        End If


        'Executa o método RetornaDataReader da classe de banco de dados e retorna o DataReader
        Dim cldBancoDados As New cldBancoDados()
        Return cldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function



End Class


