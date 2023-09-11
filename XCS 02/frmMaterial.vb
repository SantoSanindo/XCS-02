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
        Dim sql As String = "Update RackMaterial Set Material1 = '" & TextBox1.Text & "', Material2 = '" & TextBox2.Text & "', Material3 = '" & TextBox3.Text & "', Material4 = '" & TextBox4.Text & "', Material5 = '" & TextBox5.Text & "', Material6 = '" & TextBox6.Text & "', Material7 = '" & TextBox7.Text & "', Material8 = '" & TextBox8.Text & "', Material9 = '" & TextBox9.Text & "', Material10 = '" & TextBox10.Text & "', Material11 = '" & TextBox11.Text & "', Material12 = '" & TextBox12.Text & "', Material13 = '" & TextBox13.Text & "', Material14 = '" & TextBox14.Text & "', Material15 = '" & TextBox15.Text & "', Material16 = '" & TextBox16.Text & "', Material17 = '" & TextBox17.Text & "', Material18 = '" & TextBox18.Text & "', Material19 = '" & TextBox19.Text & "', Material20 = '" & TextBox20.Text & "', Material21 = '" & TextBox21.Text & "', Material22 = '" & TextBox22.Text & "', Material23 = '" & TextBox23.Text & "', Material24 = '" & TextBox24.Text & "', Material25 = '" & TextBox25.Text & "', Material26 = '" & TextBox26.Text & "', Material27 = '" & TextBox27.Text & "', Material28 = '" & TextBox28.Text & "', Material29 = '" & TextBox29.Text & "', Material30 = '" & TextBox30.Text & "' where MaterialList = '" & "SubAssy1" & "'"
        konek.Open()
        Dim sc As New SqlCommand(sql, konek)
        Dim adapter As New SqlDataAdapter(sc)
        If adapter.SelectCommand.ExecuteNonQuery().ToString() = 1 Then
            MsgBox("Saving succeed!")
            konek.Close()
        Else
            MsgBox("Saving Failed!")
        End If
    End Sub
End Class