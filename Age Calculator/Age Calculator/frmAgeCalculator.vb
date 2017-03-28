Public Class frmAgeCalculator
    Private Function Age(ByVal dtBirthDate As Date) As Integer
        Dim intAge As Integer

        intAge = Now.Year - dtBirthDate.Year

        'Make adjustments to the age if it's necessary
        If dtBirthDate.Month > Now.Month Then
            intAge = intAge - 1
        ElseIf dtBirthDate.Month = Now.Month Then
            If dtBirthDate.Day > Now.Day Then
                intAge = intAge - 1
            End If
        End If
        Return intAge
    End Function

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculate.Click
        Dim dtTemp As Date = dtBirthDate.Value
        Dim intAge As Integer

        intAge = Age(dtTemp)

        txtAge.Text = intAge.ToString()
    End Sub

    Private Sub frmAgeCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtBirthDate.Value = Now.AddYears(-40)
    End Sub
End Class