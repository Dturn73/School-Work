'David Turner
'CS 19 Advanced Visual Basic
'5/1/2017
'Assignment 7: Handling Exceptions and Exception Logging
'In this assignment, you will explore typical examples of system and input/output exceptions with the goal
'of learning about exception handling, exception classes, and exception logging.


Imports System.IO

Public Class frmExceptionTester
    Inherits System.Windows.Forms.Form

    Private Const LOGFILE As String = "c:\Users\David Turner\errorlog.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arrFNames() As String

        Try
            '*Returns a list of files
            arrFNames = System.IO.Directory.GetFiles("C:\Test999")

        Catch ex As DirectoryNotFoundException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sr As StreamReader
        Dim strLine As String

        Try
            '*Open the file
            sr = New StreamReader("TestFile.txt")

            'read and display the lines from the file until the end of the file is reached
            Do
                strLine = sr.ReadLine()
                Console.WriteLine(strLine)
            Loop Until strLine Is Nothing

        Catch ex As FileNotFoundException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        Finally
            If Not sr Is Nothing Then sr.Close()
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim d1, d2, d3 As Decimal
        Try
            d1 = 15
            d2 = 0
            '* Divide by zero
            d3 = d1 / d2
        Catch ex As DivideByZeroException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i1, i2, i3 As Integer
        Try
            '* Set integers to maximum value
            i1 = Integer.MaxValue
            i2 = Integer.MaxValue
            i3 = i1 * i2
        Catch ex As OverflowException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim arrTest() As Integer = {3, 4, 2, 3}
        Try
            MessageBox.Show(arrTest(4).ToString)
        Catch ex As IndexOutOfRangeException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        End Try
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim str1, str2 As String
        Try
            str1 = "The lazy cat"
            str2 = str1.Substring(14)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        End Try
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sr As StreamReader
        Dim strLine As String
        Dim strText As String
        Try
            '* Open the file
            ' Read and display the lines from the file until the end
            ' of the file is reached.
            Do
                strLine = sr.ReadLine()
                Console.WriteLine(strLine)
            Loop Until strLine Is Nothing
            '* Try to read another line after file closed
            strLine = sr.ReadLine
        Catch ex As NullReferenceException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        Finally
            If Not sr Is Nothing Then sr.Close()
        End Try
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim sr As StreamReader
        Dim strLine As String
        Try
            '* Open the file
            sr = New StreamReader(System.Environment.CurrentDirectory & "\TextFile1.txt")
            ' Read and display the lines from the file until the end
            ' of the file is reached.
            Do
                strLine = sr.ReadLine()
                Console.WriteLine(strLine)
            Loop Until strLine Is Nothing
            sr.Close()
            '* Try to read another line after file closed
            strLine = sr.ReadLine
        Catch ex As ObjectDisposedException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        Finally
            If Not sr Is Nothing Then sr.Close()
        End Try
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim d1 As Decimal
        Try
            d1 = CDec("A12B")
        Catch ex As InvalidCastException
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        End Try
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim strName As String
        Try
            strName = InputBox("Enter your name.", "Name Test")
            '* Check that name is "George"
            If strName <> "George" Then
                Throw New Exception("You are not authorized to use this system.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
            LogError(ex)
        End Try
    End Sub

    Private Sub LogError(ByVal exc As System.Exception)
        Dim sw As StreamWriter
        Try
            '* Open Error Logger with Append Option
            sw = New StreamWriter(LOGFILE, True)
            '* Write Out Error Text
            sw.WriteLine("****************************** " & _
            "Error Incident ******************************")
            sw.WriteLine(" ")
            sw.WriteLine(Now.ToString)
            sw.WriteLine(System.Environment.UserName)
            sw.WriteLine(exc.ToString)
            sw.WriteLine(" ")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        Finally
            If Not sw Is Nothing Then sw.Close()
        End Try
    End Sub
End Class