Imports System.Data.SqlClient
Public Class frmMaterial
    Private Sub FormMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLocalParameter()

    End Sub
    Private Sub LoadLocalParameter()
        Dim query = "Select * from RackMaterial WHERE MaterialList = '" & "SubAssy1" & "'"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)

        Dim textBoxes As List(Of TextBox) = New List(Of TextBox) From {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22, TextBox23, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30}
        For i As Integer = 1 To 30
            Try
                textBoxes(i - 1).Text = dt.Rows(0).Item("Material" & i.ToString)
            Catch ex As Exception
                textBoxes(i - 1).Text = String.Empty
            End Try
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim konek As New SqlConnection(Database)
        Dim textBoxes As List(Of TextBox) = New List(Of TextBox) From {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22, TextBox23, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30}
        For i As Integer = 1 To 30
            Try
                Dim sql As String = "Update RackMaterial Set Material" & i & " = '" & textBoxes(i - 1).Text & "' where MaterialList = '" & "SubAssy1" & "'"
                konek.Open()
                Dim sc As New SqlCommand(sql, konek)
                Dim adapter As New SqlDataAdapter(sc)
                adapter.SelectCommand.ExecuteNonQuery().ToString()
                konek.Close()
                If i >= textBoxes.Count Then MsgBox("Saving succeed!")
            Catch ex As Exception
                MsgBox("Saving Failed!")
            End Try
        Next
    End Sub
End Class