'*
'* Financial Functions for calculating Simple,
'* Compound, and Continuous Compound Interest
'*

Public Class frmInterst
    Private Function SimpleInterest(ByVal P As Double, ByVal i As Double, ByVal n As Integer) As Double
        Return P * (1 + n * i)
    End Function
    Private Function CompoundInterest(ByVal P As Double, ByVal i As Double, ByVal n As Integer, ByVal q As Integer) As Double
        Return P * (1 + (i / q)) ^ n ^ q
    End Function
    Private Function ContinuousCompoundInterest(ByVal P As Double, ByVal i As Double, ByVal n As Integer) As Double
        Return P * Math.E ^ i ^ n
    End Function
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblPrincipal, dblInterest As Double
        Dim intYears, intTimesCompounded As Integer
        Dim dblSimpleInterest, dblCompoundInterest As Double
        Dim dblContinuousCompounding As Double
        '* Check that all textboxes are numeric
        If Not IsNumeric(txtInterestRate.Text) Or Not IsNumeric(txtInterestRate.Text) Or Not IsNumeric(txtYears.Text) Or _
        Not IsNumeric(txtTimesCompounded.Text) Then
            Exit Sub
        End If
        'Retrieve values from Textboxes
        dblPrincipal = CType(txtPrincipal.Text, Double)
        dblInterest = CType(txtInterestRate.Text, Double) / 100
        intYears = CType(txtYears.Text, Integer)
        intTimesCompounded = CType(txtTimesCompounded.Text, Integer)
        '* Calculate Future Amounts
        dblSimpleInterest = SimpleInterest(dblPrincipal, dblInterest, intYears)
        dblCompoundInterest = CompoundInterest(dblPrincipal, dblInterest, intYears, intTimesCompounded)
        dblContinuousCompounding = ContinuousCompoundInterest(dblPrincipal, dblInterest, intYears)
        'Display the results
        txtSimpleInterest.Text = dblSimpleInterest.ToString("$###,##0.00")
        txtCompoundInterest.Text = dblCompoundInterest.ToString("$###,##0.00")
        txtContinuousCompounding.Text = dblContinuousCompounding.ToString("$###,##0.00")
    End Sub
End Class