Public Enum GenderType
    Male
    Female
End Enum

Public Enum MaritalStatusType
    [Single]
    Married
    Divorced
    Separated
End Enum
Public Class Employee

#Region "Constructors"
    Public Sub New()
    End Sub

    Public Sub New(ByVal ID As String,
            ByVal FirstName As String,
            ByVal MiddleName As String,
            ByVal LastName As String,
            ByVal BirthDate As DateTime,
            ByVal HireDate As DateTime,
            ByVal Department As String,
            ByVal JobTitle As String,
            ByVal Salary As Decimal,
            ByVal MaritalStatus As MaritalStatusType,
            ByVal Gender As GenderType,
            ByVal WorkPhone As String,
            ByVal HomePhone As String)

        '* Initialize properties
        Me.ID = ID
        Me.FirstName = FirstName
        Me.MiddleName = MiddleName
        Me.LastName = LastName
        Me.Department = Department
        Me.JobTitle = JobTitle
        Me.BirthDate = CStr(BirthDate)
        Me.HireDate = CStr(HireDate)
        Me.Salary = CStr(Salary)
        Me.MaritalStatus = MaritalStatus
        Me.Gender = Gender
        Me.WorkPhone = WorkPhone
        Me.HomePhone = HomePhone
    End Sub
#End Region

#Region "Public Proteries"
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    Private _MiddleName As String
    Public Property MiddleName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _MiddleName = value
        End Set
    End Property

    Private _LastName As String
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property

    Private _Gender As GenderType
    Public Property Gender() As GenderType
        Get
            Return _Gender
        End Get
        Set(ByVal value As GenderType)
            _Gender = value
        End Set
    End Property

    Private _MaritalStatus As MaritalStatusType
    Public Property MaritalStatus() As MaritalStatusType
        Get
            Return _MaritalStatus
        End Get
        Set(ByVal value As MaritalStatusType)
            _MaritalStatus = value
        End Set
    End Property

    Private _JobTitle As String
    Public Property JobTitle() As String
        Get
            Return _JobTitle
        End Get
        Set(ByVal value As String)
            _JobTitle = value
        End Set
    End Property

    Private _BirthDate As DateTime
    Public Property BirthDate() As String
        Get
            Return CStr(_BirthDate)
        End Get
        Set(ByVal value As String)
            If (CDate(value) < DateTime.Now) Then
                _BirthDate = CDate(value)
            Else
                Throw New ArgumentOutOfRangeException("Birth Date must occur before today.")
            End If
        End Set
    End Property

    Private _HireDate As DateTime
    Public Property HireDate() As String
        Get
            Return CStr(_HireDate)
        End Get
        Set(ByVal value As String)
            If (CDate(value) < DateTime.Now) Then
                _HireDate = CDate(value)
            Else
                Throw New ArgumentOutOfRangeException("Hire Date must occur before today.")
            End If
        End Set
    End Property

    Private _HomePhone As String
    Public Property HomePhone() As String
        Get
            Return _HomePhone
        End Get
        Set(ByVal value As String)
            _HomePhone = value
        End Set
    End Property

    Private _WorkPhone As String
    Public Property WorkPhone() As String
        Get
            Return _WorkPhone
        End Get
        Set(ByVal value As String)
            _WorkPhone = value
        End Set
    End Property

    Private _Salary As Decimal
    Public Property Salary() As String
        Get
            Return CStr(_Salary)
        End Get
        Set(ByVal value As String)
            If (CDec(value) >= 0 And CDec(value) <= 500000) Then
                _Salary = CDec(value)
            Else
                Throw New ArgumentException("Salary must be greater than $0 less than $500,000")
            End If
        End Set
    End Property

    Private _Depatment As String
    Public Property Department() As String
        Get
            Return _Depatment
        End Get
        Set(ByVal value As String)
            _Depatment = value
        End Set
    End Property
#End Region

#Region "Public Methods"

    Public Function ReverseName() As String
        Return String.Format("{0},{1} {2}", _LastName, _FirstName, _MiddleName)
    End Function

    Public Function FullName() As String
        Return String.Format("{0} {1} {2}", _LastName, _MiddleName, _LastName)
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0},{1},{2},{3},{4},{5},{6},{7:d},{8:d},{9},{10},{11:C},{12}",
                             _ID, _FirstName, _MiddleName, _LastName, _Gender.ToString(), _MaritalStatus.ToString(),
                             _JobTitle, _BirthDate, _HireDate, _HomePhone, _WorkPhone, _Salary, _Depatment.ToString())
    End Function

    'overloaded Age function that returns current age
    Public Function Age() As Integer
        Return Age(Now)
    End Function

    'overloaded Age function that returns future age
    Public Function Age(ByVal ageDate As DateTime) As Integer
        Dim intAge As Integer

        intAge = ageDate.Year - _BirthDate.Year

        'Make adjustment in Age if it is required
        If _BirthDate.Month > ageDate.Month Then
            intAge = intAge - 1
        ElseIf _BirthDate.Month = ageDate.Month Then
            If _BirthDate.Day > ageDate.Day Then
                intAge = intAge - 1
            End If
        End If
        Return intAge
    End Function
#End Region
End Class
