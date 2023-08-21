Imports System.Data.SqlClient
Module ModuleKoneksiDB
    Public Function Database() As String
        Dim db As String = "Data Source=WTID103263119DP\SQLEXPRESS;initial catalog=TESE;integrated security=True"
        Return db
    End Function

    Public Function bacaData(query As String) As DataSet
        Try
            Dim konek As New SqlConnection(Database)
            Dim sc As New SqlCommand(query, konek)
            Dim adapter As New SqlDataAdapter(sc)
            Dim ds As New DataSet

            If konek.State = ConnectionState.Closed Then konek.Open()

            adapter.Fill(ds)
            'koneksi.Close()
            Return ds
        Catch ex As Exception
            MsgBox("Database connection Error!")
        End Try
    End Function
End Module
