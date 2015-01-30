Public Class Person
    'Class = Data + its relevant functions or vice versa
    ' Responsilbility

    'Fields
    'Member variables
    'Private name As String
    Private email As String
    Private birthdate As Date
    Private _name As String

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

    Sub Walk()
        'Implementation goes here
        Console.WriteLine("Hey this is person walking")
        Console.ReadLine()
    End Sub

    

End Class
