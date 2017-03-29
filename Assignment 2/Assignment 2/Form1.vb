Public Class frmAssignment2

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAssignment1.Clear()
        txtAssignment2.Clear()
        txtAssignment3.Clear()
        txtFinalExamScore.Clear()
        txtMidtermScore.Clear()
        txtResults.Clear()
        btnCalculate.Text = "Calculate Score"
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnCaluclateScore_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblAssignOneScore, dblAssignTwoScore, dblAssignThreeScore, dblMidtermScore, dblFinalScore, dblResult, dblExamsAverageScore As Double
        dblAssignOneScore = CDbl(txtAssignment1.Text)
        dblAssignTwoScore = CDbl(txtAssignment2.Text)
        dblAssignThreeScore = CDbl(txtAssignment3.Text)
        dblExamsAverageScore = ((dblAssignOneScore + dblAssignTwoScore + dblAssignThreeScore) / 3)
        dblMidtermScore = CDbl(txtMidtermScore.Text)
        dblFinalScore = CDbl(txtFinalExamScore.Text)
        dblResult = (dblExamsAverageScore * 0.3) + (dblMidtermScore * 0.3) + (dblFinalScore * 0.4)
        txtResults.Text = CStr(dblResult)
        btnCalculate.Text = "Accept"
    End Sub
End Class
