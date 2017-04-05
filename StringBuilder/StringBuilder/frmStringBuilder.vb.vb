Public Class frmStringBuilder

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim str As String
        Dim strAll As String
        Dim sb As New System.Text.StringBuilder
        Dim intIterations As Integer = CInt(updIterations.Value)
        Dim intCtr As Integer
        Dim lngStart, lngFinish As Long
        Dim lngDiff1, lngDiff2 As Long
        lblNormal.Text = ""
        lblStringBuilder.Text = ""
        lblDifference.Text = ""
        Me.Cursor = Cursors.WaitCursor
        strAll = String.Empty
        '* Normal Concatenation
        str = txtString.Text & " "
        lngStart = Now.Ticks
        For intCtr = 0 To intIterations
            strAll = strAll & str
        Next
        lngFinish = Now.Ticks
        lngDiff1 = (lngFinish - lngStart)
        lblNormal.Text = lngDiff1.ToString("N0") & " ticks"
        Debug.WriteLine(strAll.Length.ToString())
        sb.EnsureCapacity(intIterations * txtString.Text.Length)
        '* Stringbuilder Concatenation
        lngStart = Now.Ticks
        For intCtr = 0 To intIterations
            sb.Append(str)
        Next
        lngFinish = Now.Ticks
        lngDiff2 = (lngFinish - lngStart)
        lblStringBuilder.Text = lngDiff2.ToString("N0") & " ticks"
        Debug.WriteLine(sb.ToString.Length.ToString())
        '* Difference
        lblDifference.Text = String.Format("{0:N0}", lngDiff1 / lngDiff2) & " times"
        sb = Nothing
        Me.Cursor = Cursors.Default
    End Sub
End Class
