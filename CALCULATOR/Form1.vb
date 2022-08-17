Public Class Form1
    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles btnClr.Click, btnMul.Click, btnDiv.Click, btnSub.Click, btnAdd.Click, btnEql.Click, btnDot.Click, btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "btnClr" Then
            dis.Text = ""
        End If
        If button.Name = "btnMul" Then
            dis.Text = dis.Text + "*"
        End If
        If button.Name = "btnDiv" Then
            dis.Text = dis.Text + "/"
        End If
        If button.Name = "btnSub" Then
            dis.Text = dis.Text + "-"
        End If
        If button.Name = "btnAdd" Then
            dis.Text = dis.Text + "+"
        End If
        If button.Name = "btnDot" Then
            dis.Text = dis.Text + "."
        End If
        If button.Name = "btn0" Then
            dis.Text = dis.Text + "0"
        End If
        If button.Name = "btn1" Then
            dis.Text = dis.Text + "1"
        End If
        If button.Name = "btn2" Then
            dis.Text = dis.Text + "2"
        End If
        If button.Name = "btn3" Then
            dis.Text = dis.Text + "3"
        End If
        If button.Name = "btn4" Then
            dis.Text = dis.Text + "4"
        End If
        If button.Name = "btn5" Then
            dis.Text = dis.Text + "5"
        End If
        If button.Name = "btn6" Then
            dis.Text = dis.Text + "6"
        End If
        If button.Name = "btn7" Then
            dis.Text = dis.Text + "7"
        End If
        If button.Name = "btn8" Then
            dis.Text = dis.Text + "8"
        End If
        If button.Name = "btn9" Then
            dis.Text = dis.Text + "9"
        End If
        If button.Name = "btnEql" Then
            Dim str As String = dis.Text
            Dim str1 As String = "="
            Dim result As String = New DataTable().Compute(str, Nothing)
            dis.Text = str + str1 + result
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
