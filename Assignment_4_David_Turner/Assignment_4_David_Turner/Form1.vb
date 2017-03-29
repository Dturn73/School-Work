Public Class Form1
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear the EnterAGuess textbox control
        txtEnterAGuess.Clear()
        'Clear the EnterAMaxRange textbox control
        txtEnterAMaxRange.Clear()
        txtEnterAGuess.Focus()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Define variable max_range and user_guess
        Dim intMaxRange As Integer
        Dim intUserGuess As Integer
        Try
            'Get the val from range textbox and assign it to MaxRange
            intMaxRange = CInt(txtEnterAMaxRange.Text)
            'Get the val from user textbox and assign it to UserGuess
            intUserGuess = CInt(txtEnterAGuess.Text)

            'Check that the user guess is a positive number. If it is, check that user guess is less that the max range
            If intUserGuess >= 0 Then
                'If user guess is less than max range display "input is valid"
                If intUserGuess <= intMaxRange Then
                    MessageBox.Show("Your Input is valid", "Input Error")
                Else
                    'Otherwise, display "your guess exceedes upper limit
                    MessageBox.Show("Your guess exceeds the upper limit", "Input Error")
                End If
            Else
                'If user guess in not positive, display "enter positive numbers only"
                MessageBox.Show("Enter positive numbers only", "Input Error")
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Enter numeric values only", "Input Error")
        Catch ex As Exception
            MessageBox.Show("An Error Occured.", "Error")
        End Try
    End Sub
End Class
