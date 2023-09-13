Imports System.Data.SqlClient
Public Class frmDatabase
    Private Sub FormDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRefCombo()

    End Sub
    Private Sub LoadRefCombo()
        ComboBox1.Items.Add("Zamak")
        ComboBox1.Items.Add("Plastic")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Then Exit Sub
        Dim query = "Select * from Record WHERE MaterialType = '" & ComboBox1.Text & "'"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)
        Dim textBoxes As List(Of TextBox) = New List(Of TextBox) From {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20}
        For i As Integer = 1 To 20
            Try
                textBoxes(i - 1).Text = dt.Rows(0).Item("Part" & i.ToString)
            Catch ex As Exception
                textBoxes(i - 1).Text = String.Empty
            End Try
        Next

        Dim comboBoxes As List(Of ComboBox) = New List(Of ComboBox) From {ComboBox2, ComboBox3, ComboBox4, ComboBox5, ComboBox6, ComboBox7, ComboBox8, ComboBox9, ComboBox10, ComboBox11, ComboBox12, ComboBox13, ComboBox14, ComboBox15, ComboBox16, ComboBox17, ComboBox18, ComboBox19, ComboBox20, ComboBox21}
        For i As Integer = 1 To 20
            Try
                comboBoxes(i - 1).Text = dt.Rows(0).Item("Flag" & i.ToString)
            Catch ex As Exception
                comboBoxes(i - 1).Text = String.Empty
            End Try
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            Dim konek As New SqlConnection(Database)
            Dim textBoxes As List(Of TextBox) = New List(Of TextBox) From {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20}
            Dim comboBoxes As List(Of ComboBox) = New List(Of ComboBox) From {ComboBox2, ComboBox3, ComboBox4, ComboBox5, ComboBox6, ComboBox7, ComboBox8, ComboBox9, ComboBox10, ComboBox11, ComboBox12, ComboBox13, ComboBox14, ComboBox15, ComboBox16, ComboBox17, ComboBox18, ComboBox19, ComboBox20, ComboBox21}
            For i As Integer = 1 To textBoxes.Count
                Try
                    Dim sql As String = "Update Record Set Part" & i & " = '" & textBoxes(i - 1).Text & "', Flag" & i & " = '" & comboBoxes(i - 1).Text & "' where MaterialType = '" & ComboBox1.Text & "'"
                    Console.WriteLine(sql)
                    konek.Open()
                    Dim sc As New SqlCommand(sql, konek)
                    Dim adapter As New SqlDataAdapter(sc)
                    adapter.SelectCommand.ExecuteNonQuery().ToString()
                    konek.Close()
                    If i >= textBoxes.Count Then MsgBox("Saving succeed!")
                Catch ex As Exception
                    If textBoxes(i - 1).Text <> "" And comboBoxes(i - 1).Text <> "" Then
                        MsgBox("Saving Failed!")
                    Else
                        If i >= textBoxes.Count Then MsgBox("Saving succeed!")
                    End If
                End Try
            Next
        Else
            MsgBox("You have to select Material Type !")
        End If
    End Sub
End Class