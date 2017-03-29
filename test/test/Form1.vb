Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x1 As Integer
        Dim x2 As Integer
        Dim x3 As Integer

        x1 = CInt(TextBox1.Text)
        x2 = CInt(TextBox2.Text)

        If x1 >= 0 And x2 >= 0 Then
            x3 = x1 + x2
            MessageBox.Show(CStr(x3))
        ElseIf x1 >= 0 AndAlso x2 >= 0 Then
            x3 = x1 - x2
            MessageBox.Show(CStr(x3))
        Else
            x3 = -1 * (x1 + x2)
            MessageBox.Show(CStr(x3))
        End If
    End Sub
End Class
