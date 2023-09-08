Public Class frmSelect
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            MsgBox("Please select product type")
            Exit Sub
        End If

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Invalid quantity")
            Exit Sub
        End If

        LoadWOfrRFID.JobProductMaterial = ComboBox1.Text
        LoadWOfrRFID.JobQTy = TextBox1.Text
        frmMain.lbl_currcounter.Text = "0"
        LoadWOfrRFID.JobHeadCount = frmMain.lbl_currcounter.Text
        frmMain.Label5.Text = "0"
        LoadWOfrRFID.JobUnitaryCount = frmMain.Label5.Text
        frmMain.lbl_currentref.Text = LoadWOfrRFID.JobProductMaterial
        frmMain.lbl_wocounter.Text = LoadWOfrRFID.JobQTy
        UpdateStnStatus()
        Me.Hide()
    End Sub
End Class