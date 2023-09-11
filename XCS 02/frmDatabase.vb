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
        TextBox1.Text = dt.Rows(0).Item("Part1")
        TextBox2.Text = dt.Rows(0).Item("Part2")
        TextBox3.Text = dt.Rows(0).Item("Part3")
        TextBox4.Text = dt.Rows(0).Item("Part4")
        TextBox5.Text = dt.Rows(0).Item("Part5")
        TextBox6.Text = dt.Rows(0).Item("Part6")
        TextBox7.Text = dt.Rows(0).Item("Part7")
        TextBox8.Text = dt.Rows(0).Item("Part8")
        TextBox9.Text = dt.Rows(0).Item("Part9")
        TextBox10.Text = dt.Rows(0).Item("Part10")
        TextBox11.Text = dt.Rows(0).Item("Part11")
        TextBox12.Text = dt.Rows(0).Item("Part12")
        TextBox13.Text = dt.Rows(0).Item("Part13")
        TextBox14.Text = dt.Rows(0).Item("Part14")
        TextBox15.Text = dt.Rows(0).Item("Part15")
        'TextBox16.Text = dt.Rows(0).Item("Part16")
        'TextBox17.Text = dt.Rows(0).Item("Part17")                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        'TextBox18.Text = dt.Rows(0).Item("Part18")
        'TextBox19.Text = dt.Rows(0).Item("Part19")
        'TextBox20.Text = dt.Rows(0).Item("Part20")

        ComboBox2.Text = dt.Rows(0).Item("Flag1")
        ComboBox3.Text = dt.Rows(0).Item("Flag2")
        ComboBox4.Text = dt.Rows(0).Item("Flag3")
        ComboBox5.Text = dt.Rows(0).Item("Flag4")
        ComboBox6.Text = dt.Rows(0).Item("Flag5")
        ComboBox7.Text = dt.Rows(0).Item("Flag6")
        ComboBox8.Text = dt.Rows(0).Item("Flag7")
        ComboBox9.Text = dt.Rows(0).Item("Flag8")
        ComboBox10.Text = dt.Rows(0).Item("Flag9")
        ComboBox11.Text = dt.Rows(0).Item("Flag10")
        ComboBox12.Text = dt.Rows(0).Item("Flag11")
        ComboBox13.Text = dt.Rows(0).Item("Flag12")
        ComboBox14.Text = dt.Rows(0).Item("Flag13")
        ComboBox15.Text = dt.Rows(0).Item("Flag14")
        ComboBox16.Text = dt.Rows(0).Item("Flag15")
        'ComboBox17.Text = dt.Rows(0).Item("Flag16")
        'ComboBox18.Text = dt.Rows(0).Item("Flag17")
        'ComboBox19.Text = dt.Rows(0).Item("Flag18")
        'ComboBox20.Text = dt.Rows(0).Item("Flag19")
        'ComboBox21.Text = dt.Rows(0).Item("Flag20")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            Dim konek As New SqlConnection(Database)

            Dim sql As String = "Update Record Set Part1 = '" & TextBox1.Text & "', Flag1 = '" & ComboBox2.Text & "', Part2 = '" & TextBox2.Text & "', Flag2 = '" & ComboBox3.Text & "', Part3 = '" & TextBox3.Text & "', Flag3 = '" & ComboBox4.Text & "', Part4 = '" & TextBox4.Text & "', Flag4 = '" & ComboBox5.Text & "', Part5 = '" & TextBox5.Text & "', Flag5 = '" & ComboBox6.Text & "', Part6 = '" & TextBox6.Text & "', Flag6 = '" & ComboBox7.Text & "', Part7 = '" & TextBox7.Text & "', Flag7 = '" & ComboBox8.Text & "', Part8 = '" & TextBox8.Text & "', Flag8 = '" & ComboBox9.Text & "', Part9 = '" & TextBox9.Text & "', Flag9 = '" & ComboBox10.Text & "', Part10 = '" & TextBox10.Text & "', Flag10 = '" & ComboBox11.Text & "', Part11 = '" & TextBox11.Text & "', Flag11 = '" & ComboBox12.Text & "', Part12 = '" & TextBox12.Text & "', Flag12 = '" & ComboBox13.Text & "', Part13 = '" & TextBox13.Text & "', Flag13 = '" & ComboBox14.Text & "', Part14 = '" & TextBox14.Text & "', Flag14 = '" & ComboBox15.Text & "', Part15 = '" & TextBox15.Text & "', Flag15 = '" & ComboBox16.Text & "' where MaterialType = '" & ComboBox1.Text & "'"
            konek.Open()
            Dim sc As New SqlCommand(sql, konek)
            Dim adapter As New SqlDataAdapter(sc)
            If adapter.SelectCommand.ExecuteNonQuery().ToString() = 1 Then
                MsgBox("Saving succeed!")
                konek.Close()
            Else
                MsgBox("Saving Failed!")
            End If
        Else
            MsgBox("You have to select Material Type !")
        End If
    End Sub
End Class