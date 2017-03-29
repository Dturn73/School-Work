'
' David Turner
' Assignment 9
' 2/2/2017
'
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnCheckPassword_Click(sender As Object, e As EventArgs) Handles btnCheckPassword.Click
        Dim strReturnVal As String
        Dim strUserPassword As String = txtUserPassword.Text
        Try
            strReturnVal = check_password(strUserPassword)
            MessageBox.Show(strReturnVal)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function length_check(ByVal userPassword As String) As Boolean
        If userPassword.Length >= 8 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function digit_check(ByVal userPassword As String) As Boolean
        Dim regex As Regex = New Regex("\d+")
        Dim match As Match = regex.Match(userPassword)
        If match.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Function caps_check(ByVal userPassword As String) As Boolean
        Dim regex As Regex = New Regex("[A-Z]")
        Dim match As Match = regex.Match(userPassword)
        If match.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Function check_password(ByVal userPassword As String) As String
        If length_check(userPassword) Then
            If digit_check(userPassword) Then
                If caps_check(userPassword) Then
                    Return "Your password is approved."
                Else
                    Return "Your password did not satisfy the security requirements of atleast one capital letter."
                End If
            Else
                Return "Your password did not satisfy the security requirements of atleast one digit."
            End If
        Else
            Return "Your password did not satisfy the security requirements of being atleast 8 characters long."
        End If
    End Function
End Class
