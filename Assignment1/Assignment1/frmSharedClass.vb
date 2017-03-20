Imports WindowsApplication1.GlobalFunctions
Public Class frmSharedClass
    Private blnDirty As Boolean

    Private Sub SetState()
        btnSave.Enabled = blnDirty And txtCapital.Text <> String.Empty And cboState.SelectedIndex > -1
    End Sub

    Private Sub cboState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboState.SelectedIndexChanged
        blnDirty = True
        SetState()
    End Sub

    Private Sub txtCapital_TextChanged(sender As Object, e As EventArgs) Handles txtCapital.TextChanged
        blnDirty = True
        SetState()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MessageBox.Show("Data Saved")
        blnDirty = False
        SetState()
    End Sub

    Private Sub frmShardClass_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        '*Exit Confirm
        If blnDirty Then
            Select Case ConfirmExit()
                Case Windows.Forms.DialogResult.Yes
                    btnSave.PerformClick()
                Case Windows.Forms.DialogResult.No
                    'No action required
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub
End Class
