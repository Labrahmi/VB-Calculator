Public Class Form1

    Dim len_ As Integer
    Dim fr_num As Double
    Dim sec_num As Double
    Dim op As Integer
    Dim op_sel As Boolean = False
    Dim v1 As Double
    Dim r1 As String

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        len_ = Len(Guna2TextBox1.Text)
        If len_ > 0 Then
            If Guna2TextBox1.Text.Chars(0) <> "0" Then
                Guna2TextBox1.Text += "0"
            End If
        Else
            Guna2TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Guna2TextBox1.Text += "1"

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Guna2TextBox1.Text += "2"
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Guna2TextBox1.Text += "3"
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Guna2TextBox1.Text += "4"
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Guna2TextBox1.Text += "5"
        ''  Guna2TextBox1.Text = Guna2TextBox1.Text & "5"
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Guna2TextBox1.Text += "6"
    End Sub

    Private Sub Guna2Button19_Click(sender As Object, e As EventArgs) Handles Guna2Button19.Click
        Guna2TextBox1.Text += "7"
    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs) Handles Guna2Button18.Click
        Guna2TextBox1.Text += "8"
    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs) Handles Guna2Button17.Click
        Guna2TextBox1.Text += "9"
    End Sub
    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click

        '' 15.13.

        ''If Not Guna2TextBox1.Text.Contains(".") Then

        ''End If

        Dim pt As Integer = 0
        len_ = Len(Guna2TextBox1.Text)
        For i = 0 To len_ - 1
            If Guna2TextBox1.Text.Chars(i) = "." Then
                pt += 1
            End If
        Next
        If pt < 1 Then
            If Guna2TextBox1.Text = "" Then
                Guna2TextBox1.Text = "0."
            Else
                Guna2TextBox1.Text += "."
            End If
        End If

    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        len_ = Len(Guna2TextBox1.Text)
        If Guna2TextBox1.Text <> "" Then
            If Guna2TextBox1.Text.Chars(0) <> "-" Then
                Guna2TextBox1.Text = "-" + Guna2TextBox1.Text
            Else
                Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(1, len_ - 1)
            End If
        ElseIf Guna2TextBox1.Text = "" Then
            Guna2TextBox1.Text = "-"
        End If
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        sec_num = 0
        fr_num = 0
        op = -1
        op_sel = False
        Guna2TextBox1.Text = ""
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        If Guna2TextBox1.Text <> "" Then
            fr_num = Val(Guna2TextBox1.Text)
            Guna2TextBox1.Text = ""
            op_sel = True
            op = 5 ''mod
        End If

    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        If Guna2TextBox1.Text <> "" Then
            fr_num = Val(Guna2TextBox1.Text)
            Guna2TextBox1.Text = ""
            op_sel = True
            op = 4 ''/
        End If
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) Handles Guna2Button15.Click
        If Guna2TextBox1.Text <> "" Then
            fr_num = Val(Guna2TextBox1.Text)
            Guna2TextBox1.Text = ""
            op_sel = True
            op = 3 ''x
        End If

    End Sub

    Private Sub Guna2Button16_Click(sender As Object, e As EventArgs) Handles Guna2Button16.Click
        If Guna2TextBox1.Text <> "" Then
            fr_num = Val(Guna2TextBox1.Text)
            Guna2TextBox1.Text = ""
            op_sel = True
            op = 2 ''-
        End If

    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs) Handles Guna2Button20.Click
        If Guna2TextBox1.Text <> "" Then
            fr_num = Val(Guna2TextBox1.Text)
            Guna2TextBox1.Text = ""
            op_sel = True
            op = 1 ''+
        End If

    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        If Guna2TextBox1.Text <> "" Then
            If op_sel = True Then
                sec_num = Guna2TextBox1.Text
                Select Case op
                    Case 1
                        Guna2TextBox1.Text = Val(fr_num + sec_num)
                    Case 2
                        Guna2TextBox1.Text = Val(fr_num - sec_num)
                    Case 3
                        Guna2TextBox1.Text = Val(fr_num * sec_num)
                    Case 4
                        If Val(Guna2TextBox1.Text) = "0" Then
                            MessageBox.Show("Error!")
                        Else
                            Guna2TextBox1.Text = Val(fr_num / sec_num)
                        End If
                    Case 5
                        Guna2TextBox1.Text = Val(fr_num Mod sec_num)
                End Select
                op_sel = False
            End If

        End If
    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Dim x1 As Double = Val(Guna2TextBox2.Text)

        If Len(Guna2TextBox2.Text) > 0 Then
            If IsNumeric(Guna2TextBox2.Text) Then
                While (x1 > 0)
                    v1 = x1 Mod 2               '' 15/2 
                    x1 = x1 - v1
                    x1 = x1 / 2
                    r1 = v1.ToString & r1
                End While
                Guna2TextBox3.Text = r1
                Guna2TextBox4.Text = Hex(Val(Guna2TextBox2.Text))
                Guna2TextBox5.Text = Oct(Val(Guna2TextBox2.Text))
            End If
        Else
            Guna2TextBox3.Text = ""
            Guna2TextBox4.Text = ""
            Guna2TextBox5.Text = ""
            r1 = ""
        End If
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs) Handles Guna2Button14.Click
        If Guna2TextBox1.Text <> "" Then
            len_ = Len(Guna2TextBox1.Text)
            Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(0, len_ - 1)
            ''1234      ln = 4      0-3
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Y-H Calculator developped by" & vbNewLine & "Youssef YOUSSEF | Houria EL ACHIR"
    End Sub



    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        MessageBox.Show(" E = 4x² + 2x + 12 | a=4 | b=2 | c=12 ", " Example ")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim delta As Double
        Dim a, b, c As Double
        Dim x1, x2 As Double

        If Guna2TextBox6.Text <> "" And Guna2TextBox7.Text <> "" And Guna2TextBox8.Text <> "" Then
            If IsNumeric(Guna2TextBox6.Text) And IsNumeric(Guna2TextBox7.Text) And IsNumeric(Guna2TextBox8.Text) Then
                a = Val(Guna2TextBox6.Text)
                b = Val(Guna2TextBox7.Text)
                c = Val(Guna2TextBox8.Text)
                delta = (b ^ 2) - (4 * a * c)
                If delta > 0 Then
                    x1 = ((-1 * b) + Math.Sqrt(delta)) / 2 * a
                    x2 = ((-1 * b) - Math.Sqrt(delta)) / 2 * a
                    ListBox1.Items.Add("X1 = " & x1)
                    ListBox1.Items.Add("X2 = " & x2)
                    ListBox1.Items.Add("-----------------------")
                ElseIf delta = 0 Then
                    x1 = (-1 * b) / 2 * a
                    ListBox1.Items.Add("X1 = " & x1)
                    ListBox1.Items.Add("-----------------------")
                Else
                    ListBox1.Items.Add(" Pas de soulution en R ")
                    ListBox1.Items.Add("-----------------------")
                End If
            Else
                MessageBox.Show(" ecrire un nombre ", " ERREUR ")
            End If
        Else
            MessageBox.Show(" Remplir tous les champs ", " ERREUR ")
        End If
    End Sub
End Class