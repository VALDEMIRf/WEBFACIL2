Imports System.Data.OleDb

Public Class frmVinculadoConsulta

    Private reader As OleDbDataReader

    Private Sub txtDescricao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescricao.TextChanged
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                'Dim dt As New DataTable
                '' Dim conn As New OleDbConnection
                '   Dim cmd As New OleDbCommand("SELECT cli_id,cli_Nome FROM tbClientes", con)
                Dim cmd As New OleDbCommand("SELECT Distinct(cli_Nome) FROM tbClientes", con)
                reader = cmd.ExecuteReader()
                Dim autoComp As New AutoCompleteStringCollection()
                While reader.Read()
                    autoComp.Add(reader("cli_Nome"))
                    '    lblRecebeIDCliente.GetType(cli_id)
                End While
                reader.Close()
                'Dim da As New OleDbDataAdapter(cmd)
                'Dim col As New AutoCompleteStringCollection
                'da.Fill(dt)
                'For i = 0 To dt.Rows.Count - 1
                '    col.Add(dt.Rows(i)("cli_Nome").ToString())
                'Next
                txtDescricao.AutoCompleteMode = AutoCompleteMode.Suggest
                txtDescricao.AutoCompleteSource = AutoCompleteSource.CustomSource
                txtDescricao.AutoCompleteCustomSource = autoComp

            Catch ex As Exception
                ' MessageBox.Show("não foi possível fazer o gravar!", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MsgBox(ex.Message.ToString)
            Finally
                con.Close()
            End Try
            


        End Using

    End Sub




End Class