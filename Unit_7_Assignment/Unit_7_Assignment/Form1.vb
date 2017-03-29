'
'David Turner
'Unit 7 Assignment
'1/26/2016
'
Public Class Form1
    Private Sub btnRollDice_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        Dim intRandomNumber As Integer
        Dim intCount As Integer
        Dim intUserScore As Integer
        Dim rand As New Random
        Dim strTreasureLetter As String
        Dim strUserInput As String

        Try
            intRandomNumber = rand.Next(26) + 97
            strTreasureLetter = Chr(intRandomNumber)
            strUserInput = txtUserInput.Text.ToLower()

            For intCount = 0 To strUserInput.Length - 1
                If strUserInput.Substring(intCount, 1) = strTreasureLetter Then
                    intUserScore += 1
                End If
            Next
            If strUserInput.Length Mod intUserScore = 0.2 Or intUserScore > 10 Then
                MessageBox.Show("Congradulations you won. Your score was " & CStr(intUserScore - 10))
            Else
                MessageBox.Show("Sorry, you lost. You only matched the treasure letter " & CStr(intUserScore) & " time(s)")
            End If
        Catch ex As DivideByZeroException
            MessageBox.Show("None of your letters matched the Treasure Letter.")
        Catch ex As Exception
            MessageBox.Show("Sorry, something went wrong.")
        End Try
    End Sub
End Class
