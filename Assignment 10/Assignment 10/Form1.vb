'
'David Turner
'Assignment 10
'2/5/2017
'

Public Class Form1
    Private names() As String
    Private balances() As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBO1.Items.Add("John One")
        CBO1.Items.Add("Jack Two")
        CBO1.Items.Add("John Three")
        CBO1.Items.Add("Jack Four")
        CBO1.Items.Add("John Five")
        CBO1.Items.Add("Jack Six")
        CBO1.Items.Add("John Seven")
        CBO1.Items.Add("Jack Eight")

        CBO2.Items.Add("235.50")
        CBO2.Items.Add("78943.98")
        CBO2.Items.Add("230781.10")
        CBO2.Items.Add("78362.00")
        CBO2.Items.Add("12097.20")
        CBO2.Items.Add("89267.34")
        CBO2.Items.Add("34959.06")
        CBO2.Items.Add("559284.50")
        ' btnGetData.PerformClick()
    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        Try
            Dim intIndex As Integer
            ReDim names(CBO1.Items.Count - 1)
            ReDim balances(CBO1.Items.Count - 1)

            For intIndex = 0 To (CBO1.Items.Count - 1)
                names(intIndex) = CStr(CBO1.Items(intIndex))
                balances(intIndex) = CDbl(CBO2.Items(intIndex))
            Next
        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnShowBalance_Click(sender As Object, e As EventArgs) Handles btnShowBalance.Click
        Dim strClientName As String = ""
        Dim intIndex As Integer
        Dim intPosition As Integer
        Dim blnfound As Boolean

        Try
            strClientName = InputBox("Type in the client name.")
            intIndex = 0
            Do While intIndex < names.Length
                If names(intIndex) = strClientName Then
                    blnfound = True
                    intPosition = intIndex
                End If
                intIndex += 1
            Loop

            If blnfound Then
                MessageBox.Show(balances(intPosition).ToString("c"))
            Else
                MessageBox.Show("Client does not exist.")
            End If
        Catch ex As IndexOutOfRangeException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please click 'Get Data'")
        End Try
    End Sub

    Private Sub btnShowBankAssets_Click(sender As Object, e As EventArgs) Handles btnShowBankAssets.Click
        Try
            Dim dblTotal As Double = 0.0
            Dim intCounter As Integer

            For intCounter = 0 To balances.Length - 1
                dblTotal += balances(intCounter)
            Next
            MessageBox.Show("The sum of all balances is: " & dblTotal.ToString("c"))
        Catch ex As IndexOutOfRangeException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please click 'Get Data'")
        End Try
    End Sub

    Private Sub btnGetBalance_Click(sender As Object, e As EventArgs) Handles btnGetBalance.Click
        Try
            Dim strNames As String = ""
            Dim intVal As Integer
            For intVal = 0 To balances.Length - 1
                If balances(intVal) < 5000 Then
                    strNames += names(intVal) & ControlChars.CrLf
                End If
            Next
            MessageBox.Show(strNames)
        Catch ex As IndexOutOfRangeException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please click 'Get Data'")
        End Try
    End Sub
End Class
