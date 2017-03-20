Public Class Employees
    Inherits System.Collections.ObjectModel.Collection(Of Employee)

    Public Overloads Sub Remove(ByVal ID As String)
        Dim empObject As Employee = Find(ID)

        If Not empObject Is Nothing Then
            Remove(empObject)
        Else
            Throw New System.Exception("Employee Not Found")
        End If
    End Sub

    Public Function Find(ByVal ID As String) As Employee
        For Each empObject As Employee In Me
            If empObject.ID = ID Then
                Return empObject
            End If
        Next
        Return Nothing
    End Function
End Class
