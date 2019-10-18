Imports System.Data.OleDb

Module mdlAcessar
    Public Function GetConnection() As OleDbConnection

        Dim sql As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\WEB02\Meus Doctos\VALDEMIR\WEBFACIL_DB.accdb"
        ' Dim sql As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Valdemir\Documents\DB_Access\WEBFACIL_DB.accdb"
        Return New OleDbConnection(sql)
    End Function
End Module
