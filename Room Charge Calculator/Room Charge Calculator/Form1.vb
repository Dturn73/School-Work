Public Class Form1
    Private Sub btnCalculateCharges_Click(sender As Object, e As EventArgs) Handles btnCalculateCharges.Click
        'Declare variables for the calculatoins
        Dim decRoomCharges As Decimal
        Dim decAddCharges As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        Const decTAX_RATE As Decimal = 0.08D

        Try
            'Calculate and display the room charge
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharges.Text)
            txtRoomCharges.Text = decRoomCharges.ToString("c")

            'Calculate and  display the additional charges
            decAddCharges = CDec(txtRoomService.Text) + CDec(txtMisc.Text) + CDec(txtTelephone.Text)
            txtAddCharges.Text = decAddCharges.ToString("c")

            'Calculate and display the subtotal
            decSubtotal = decRoomCharges + decAddCharges
            txtSubtotal.Text = decSubtotal.ToString("c")

            'Calculate and display the tax
            decTax = decSubtotal * decTAX_RATE
            txtTax.Text = decTax.ToString("c")

            'Calculate and display the total charges
            decTotal = decSubtotal + decTax
            txtTotalCharges.Text = decTotal.ToString("c")
        Catch ex As Exception
            MessageBox.Show("All input must be valid values")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDisplayDate.Text = CStr(Today)
        lblDisplayTime.Text = CStr(TimeOfDay)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddCharges.Clear()
        txtMisc.Clear()
        txtNightlyCharges.Clear()
        txtNights.Clear()
        txtRoomCharges.Clear()
        txtRoomService.Clear()
        txtSubtotal.Clear()
        txtTax.Clear()
        txtTelephone.Clear()
        txtTotalCharges.Clear()
        txtNights.Focus()
    End Sub
End Class
