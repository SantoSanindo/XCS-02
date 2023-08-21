Imports System.Data.SqlClient
Public Class FormLogin
    Dim enterPressed As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "1"
        Else
            TextBox2.Text = TextBox2.Text & "1"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "2"
        Else
            TextBox2.Text = TextBox2.Text & "2"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "3"
        Else
            TextBox2.Text = TextBox2.Text & "3"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "4"
        Else
            TextBox2.Text = TextBox2.Text & "4"
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If enterPressed = 0 Then
            enterPressed = 1
            TextBox1.Enabled = False
            TextBox2.Enabled = True
        Else
            enterPressed = 0
            TextBox1.Enabled = True
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "5"
        Else
            TextBox2.Text = TextBox2.Text & "5"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "6"
        Else
            TextBox2.Text = TextBox2.Text & "6"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "7"
        Else
            TextBox2.Text = TextBox2.Text & "7"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "8"
        Else
            TextBox2.Text = TextBox2.Text & "8"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "9"
        Else
            TextBox2.Text = TextBox2.Text & "9"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "0"
        Else
            TextBox2.Text = TextBox2.Text & "0"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "Q"
        Else
            TextBox2.Text = TextBox2.Text & "Q"
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "W"
        Else
            TextBox2.Text = TextBox2.Text & "W"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "E"
        Else
            TextBox2.Text = TextBox2.Text & "E"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "R"
        Else
            TextBox2.Text = TextBox2.Text & "R"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "T"
        Else
            TextBox2.Text = TextBox2.Text & "T"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "Y"
        Else
            TextBox2.Text = TextBox2.Text & "Y"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "U"
        Else
            TextBox2.Text = TextBox2.Text & "U"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "I"
        Else
            TextBox2.Text = TextBox2.Text & "I"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "O"
        Else
            TextBox2.Text = TextBox2.Text & "O"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "P"
        Else
            TextBox2.Text = TextBox2.Text & "P"
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "A"
        Else
            TextBox2.Text = TextBox2.Text & "A"
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "S"
        Else
            TextBox2.Text = TextBox2.Text & "S"
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "D"
        Else
            TextBox2.Text = TextBox2.Text & "D"
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "F"
        Else
            TextBox2.Text = TextBox2.Text & "F"
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "G"
        Else
            TextBox2.Text = TextBox2.Text & "G"
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "H"
        Else
            TextBox2.Text = TextBox2.Text & "H"
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "J"
        Else
            TextBox2.Text = TextBox2.Text & "J"
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "K"
        Else
            TextBox2.Text = TextBox2.Text & "K"
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "L"
        Else
            TextBox2.Text = TextBox2.Text & "L"
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "Z"
        Else
            TextBox2.Text = TextBox2.Text & "Z"
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "X"
        Else
            TextBox2.Text = TextBox2.Text & "X"
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "C"
        Else
            TextBox2.Text = TextBox2.Text & "C"
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "V"
        Else
            TextBox2.Text = TextBox2.Text & "V"
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "B"
        Else
            TextBox2.Text = TextBox2.Text & "B"
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "N"
        Else
            TextBox2.Text = TextBox2.Text & "N"
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & "M"
        Else
            TextBox2.Text = TextBox2.Text & "M"
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If enterPressed = 0 Then
            If TextBox1.Text < " " Then
                TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1 + 1)
            Else
                TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1)
            End If
        Else
            If TextBox2.Text < " " Then
                TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 1 + 1)
            Else
                TextBox2.Text = Mid(TextBox2.Text, 1, Len(TextBox2.Text) - 1)
            End If
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If enterPressed = 0 Then
            TextBox1.Text = TextBox1.Text & " "
        Else
            TextBox2.Text = TextBox2.Text & " "
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = True
        TextBox2.Enabled = False
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If TextBox1.Text = "" Then
            MsgBox("Invalid id or password")
            Exit Sub
        End If
        Dim query = "Select * from [USER] where USER_ID ='" & TextBox1.Text & "'"
        Dim dt = ModuleKoneksiDB.bacaData(query).Tables(0)

        Try
            If UCase(TextBox2.Text) = UCase(dt.Rows(0).Item("USER_PASSWORD")) Then
                If LoginMaterial Then
                    FormMaterial.Show()
                ElseIf LoginDatabase Then
                    FormDatabase.Show()
                End If
                Me.Hide()
            Else
                MsgBox("Invalid id or password")
            End If
        Catch ex As Exception
            MsgBox("Invalid id or password")
        End Try

    End Sub
End Class