Public NotInheritable Class GlobalFunctions
    Private Sub New()
    End Sub
    Public Shared Function ConfirmExit(Optional ByVal strMessage As String = "Save changes?",Optional ByVal strCaption As String = "Exit Confirm") As DialogResult
        Return MessageBox.Show(strMessage, strCaption,MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button3)
    End Function
    Public Shared Function ConfirmDelete(Optional ByVal strMessage As String = "Delete changes?", Optional ByVal strCaption As String = "Delete Confirm") As DialogResult
        Return MessageBox.Show(strMessage, strCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
    End Function
    Public Shared Function ConfirmCancel(Optional ByVal strMessage As String = "Cancel changes?", Optional ByVal strCaption As String = "Cancel Confirm") As DialogResult
        Return MessageBox.Show(strMessage, strCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
    End Function
End Class
