Public Class Person
    Implements IDelete

    'Class = Data + its relevant functions or vice versa
    ' Responsilbility

    'Fields
    'Member variables
    'Private name As String
    Private email As String
    Private birthdate As Date
    Private _name As String
    Private location As String

    'Constructors
    Sub New()
        'location = "Pune"
        Console.WriteLine("Hi, This is Person class being newed")
        Console.ReadLine()
    End Sub

    'overloaded constructor
    Sub New(location As String)
        Console.WriteLine("We are passing the location everytime when we new this object")
        Console.ReadLine()
    End Sub
    'Other classes should not access my variables directly
    'So let's write a couple of functions which can read these variables
    'One function which can modify the variables
    'Function getName() As String
    '    Return name
    'End Function

    'Sub setName(myName As String)
    '    name = myName
    'End Sub


    'Readonly / Writeonly
    'Private on Get or set

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property


    Function getemail() As String
        Return email
    End Function

    Sub setemail(newEmail As String)
        email = newEmail
    End Sub

    Overridable Sub Walk()
        'Implementation goes here
        Console.WriteLine("Hey this is person walking")
        Console.ReadLine()
    End Sub

    Public Sub Delete() Implements IDelete.Delete
        'this is the implemenation of your interface
    End Sub
End Class
