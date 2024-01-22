Imports MySql.Data.MySqlClient
Public Class Form1
    Dim ServerString As String = "Server=127.0.0.1;user id=root;password='';database=kuliah"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
 Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles
        MyBase.Load()
        SQLConnection.ConnectionString = ServerString
        Try
            If SQLConnection.State = ConnectionState.Closed Then
                MsgBox("Succes berkoneksi ke mysql")
            Else
                SQLConnection.Close()
                MsgBox("Gagal berkoneksi ke mysql")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub SaveNames(ByRef SQLStatement As String)
        Dim cmd As MySqlCommand = New MySqlCommand
        With cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = SQLConnection
            .ExecuteNonQuery()
        End With
        SQLConnection.Close()
        MsgBox("Berhasil Menambahkan Menambahkan Nama Ke table Mahasiswa di databases Kuliah ")
        SQLConnection.Dispose()
    End Sub
 

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

    End Sub
End Class