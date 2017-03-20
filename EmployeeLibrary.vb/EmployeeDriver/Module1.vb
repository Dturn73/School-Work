Imports Employee.vb

Module Module1

    Sub Main()
        '*** Declare the object variables
        Dim emp As Employee.vb.Employee = Nothing
        Dim emps As Employees = New Employees()
        '*** Add employee Larry Wilson
        emp = New Employee.vb.Employee("43109", "Larry", "Robert", "Wilson", New DateTime(1954, 6, 11), New DateTime(1996, 4, 11),
                "IT", "Manager", 110000, MaritalStatusType.Married, GenderType.Male, "(213) 335-2226", "(310) 456-1234")
        emps.Add(emp)

        '*** Add employee John Brown
        emp = New Employee.vb.Employee("14352", "John", "Edward", "Brown", New DateTime(1952, 9, 14), New DateTime(2000, 5, 17), "IT", "Senior Programmer", 75000,
                MaritalStatusType.Single, GenderType.Male, "(818) 312-3184", "(310) 456-1233")
        emps.Add(emp)

        '*** Add employee Lizzy Jones 
        emp = New Employee.vb.Employee("13828", "Lizzy", "Beth", "Jones", New DateTime(1961, 4, 25), New DateTime(2004, 7, 12), "IT", "Senior Programmer", 85000,
                           MaritalStatusType.Single, GenderType.Female, "(818) 992-4203", "(310) 456-1232")
        emps.Add(emp)

        '*** Loop And display each Employee's information
        Console.WriteLine("List Employees:")
        For Each e As Employee.vb.Employee In emps
            Console.WriteLine(e)
        Next
        Console.WriteLine()
        '*** Loop And display each Employee's information
        Console.WriteLine("List Employees Full Names and Ages:")
        For Each e As Employee.vb.Employee In emps
            Console.WriteLine("{0} {1}", e.FullName, e.Age())
        Next
        Console.WriteLine()
        '*** Test Find and Remove Functions
        Dim empX As Employee.vb.Employee = emps.Find("14352")
        If empX IsNot Nothing Then
            emps.Remove(empX.ID)
        End If
        '*** Loop And display each Employee's information
        Console.WriteLine("List Employees After Find and Remove of '14352':")
        For Each e As Employee.vb.Employee In emps
            Console.WriteLine(e)
        Next
        Console.WriteLine()
        '*** Test Age Functions
        Console.WriteLine("List Employees After Find and Remove of '14352':")
        For Each e As Employee.vb.Employee In emps
            Console.WriteLine(e)
        Next
        Console.ReadLine()

    End Sub

End Module
