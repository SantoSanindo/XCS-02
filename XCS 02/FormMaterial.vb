Imports System.Data.SqlClient
Public Class FormMaterial
    Private Sub FormMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLocalParameter()

    End Sub
    Private Sub LoadLocalParameter()
        Dim query = "Select * from RackMaterial WHERE MaterialList = '" & "SubAssy1" & "'"
        Dim dt = ModuleKoneksiDB.bacaData(query).Tables(0)

        TextBox1.Text = dt.Rows(0).Item("Material1")
        TextBox2.Text = dt.Rows(0).Item("Material2")
        TextBox3.Text = dt.Rows(0).Item("Material3")
        TextBox4.Text = dt.Rows(0).Item("Material4")
        TextBox5.Text = dt.Rows(0).Item("Material5")
        TextBox6.Text = dt.Rows(0).Item("Material6")
        TextBox7.Text = dt.Rows(0).Item("Material7")
        TextBox8.Text = dt.Rows(0).Item("Material8")
        TextBox9.Text = dt.Rows(0).Item("Material9")
        TextBox10.Text = dt.Rows(0).Item("Material10")
        TextBox11.Text = dt.Rows(0).Item("Material11")
        TextBox12.Text = dt.Rows(0).Item("Material12")
        TextBox13.Text = dt.Rows(0).Item("Material13")
        TextBox14.Text = dt.Rows(0).Item("Material14")
        TextBox15.Text = dt.Rows(0).Item("Material15")
        TextBox16.Text = dt.Rows(0).Item("Material16")
        TextBox17.Text = dt.Rows(0).Item("Material17")
        TextBox18.Text = dt.Rows(0).Item("Material18")
        TextBox19.Text = dt.Rows(0).Item("Material19")
        TextBox20.Text = dt.Rows(0).Item("Material20")
        TextBox21.Text = dt.Rows(0).Item("Material21")
        TextBox22.Text = dt.Rows(0).Item("Material22")
        TextBox23.Text = dt.Rows(0).Item("Material23")
        TextBox24.Text = dt.Rows(0).Item("Material24")
        TextBox25.Text = dt.Rows(0).Item("Material25")
        TextBox26.Text = dt.Rows(0).Item("Material26")
        TextBox27.Text = dt.Rows(0).Item("Material27")
        TextBox28.Text = dt.Rows(0).Item("Material28")
        TextBox29.Text = dt.Rows(0).Item("Material29")
        TextBox30.Text = dt.Rows(0).Item("Material30")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
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