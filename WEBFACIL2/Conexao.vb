Imports System.Data.OleDb
Imports System.Text
Imports System.Data
Imports System.IO
Public Class Conexao
    Public con As New OleDbConnection
    Public cmd As OleDbCommand = con.CreateCommand
    Public ds As New DataSet
    Public da As OleDbDataAdapter = New OleDbDataAdapter(cmd)

    Public imgnome As String
    Public codigo As Integer

    Dim daImagem As OleDbDataAdapter
    Dim dsImagem As DataSet

    Dim cnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Valdemir\Documents\DB_Access\WEBFACIL_DB.accdb"

    Public Sub Conectar()
        Try
            con.Open()
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Valdemir\Documents\DB_Access\WEBFACIL_DB.accdb"


        Catch ex As Exception
            MsgBox(ex.Message & "Erro ao conectar")
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub Operar(ByVal sql)
        Conectar()
        Try
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            ' cmd.ExecuteReader()
            MsgBox("Operação realizada com sucesso!", MsgBoxStyle.Information, "Operando")

        Catch ex As Exception
            MsgBox(ex.Message & ex.ToString, MsgBoxStyle.Critical, "Erro no método operar")
        Finally
            con.Close()
        End Try
    End Sub

    Public Function listar(ByVal sql As String)
        Conectar()
        Try
            ds.Clear()
            cmd.CommandText = sql
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message & "Erro no método listar")
        Finally
            con.Close()
        End Try
        Return ds
    End Function

   
End Class
