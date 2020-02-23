Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Public Class frmCadAcessoria

    Private Sub frmCadAcessoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

End Class