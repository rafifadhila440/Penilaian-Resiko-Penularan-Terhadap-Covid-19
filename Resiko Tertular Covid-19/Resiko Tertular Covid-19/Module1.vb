Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public cmd As OleDbCommand
    Public RD As OleDbDataReader
    Dim sqlnya As String
    Public Sub koneksi()
        sqlnya = "provider=microsoft.jet.oledb.4.0;data source=setormuka.mdb"
        conn = New OleDbConnection(sqlnya)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
