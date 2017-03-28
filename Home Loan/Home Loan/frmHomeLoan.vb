Public Class frmHomeLoan
    'This function calculates the home loan payment using a well-know formula.
    Private Function Payment(ByVal P As Double, ByVal i As Double, ByVal n As Integer, ByVal q As Integer) As Double
        Return P * i / (q * (1 - (1 + (i / q)) ^ (-n) ^ q))
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblPrincipal As Double
        Dim dblInterest As Double
        Dim intYears As Integer
        Dim dblPayment As Double
        '* Validate that all of the Textboxes contain numeric values
        If Not IsNumeric(txtPrincipal.Text) Or _
        Not IsNumeric(txtInterestRate.Text) Or _
        Not IsNumeric(txtYears.Text) Then
            Exit Sub
        End If
        '* Retrieve values from Textboxes
        dblPrincipal = CType(txtPrincipal.Text, Double)
        dblInterest = CType(txtInterestRate.Text, Double) / 100
        intYears = CType(txtYears.Text, Integer)
        '* Calculate the Payment
        dblPayment = Payment(dblPrincipal, dblInterest, intYears, 12)
        '* Display the results
        txtPayment.Text = dblPayment.ToString("c")
    End Sub
End Class