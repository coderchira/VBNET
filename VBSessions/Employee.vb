'Employee class - subclass or the derived class
'Person : base class or the parent class
'Multi level inheritance is possible
'Multiple inheritance not possible - a class can have only one parent

Public Class Employee
    Inherits Person
    'inheritance
    'whenever you want to inherit data or logic from another class
    '
    'Problem
    ' It has a name
    ' It has email
    ' It might have a location
    ' It might be on a company's rolls


    Sub New()
        Console.WriteLine("We are inside Employee constructor now")
        Console.ReadLine()
    End Sub

    Private _companyname As String
    Public Property CompanyName() As String
        Get
            Return _companyname
        End Get
        Set(ByVal value As String)
            _companyname = value
        End Set
    End Property

    Private _salary As String
    Public Property Salary() As String
        Get
            Return _salary
        End Get
        Set(ByVal value As String)
            _salary = value
        End Set
    End Property

    Overrides Sub Walk()
        'Different implemenattaion than the base class
        Console.WriteLine("Hey we are inside employee class now and i walk differently than the person")
        Console.ReadLine()
    End Sub
    Sub Code()
        Console.WriteLine("Hey this is the employee who can code")
        Console.ReadLine()
    End Sub
End Class
