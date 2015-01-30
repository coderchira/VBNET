Module Module3
    'Logic Demo
    '   Function
    '       Return a type
    '   Subroutines (Sub)
    '       Cannot return a type

    'Lifecycle of logic
    '   Declare a function /Sub
    '   Implement (Body of the function)
    '   Call from other blocks
    '   Test

    'Signature
    '   Name
    '   Security
    '   Number of parameters
    '   Type of parameters
    '   Sequence of parameters
    '   Return type of logic block

    'Module level variables
    Public pflag As Boolean
    Dim lastname As String

    'Access Specifier
    'Public
    'Private

    Private Function DoThis(flag As Integer, weight As Single, name As String) As Integer
        'Function level variables
        Dim myVariable As String
        myVariable = "Ruchira Agarwal"

        'Conditional Statements
        If flag = 10 And weight = 50.0 Then
            'Conditional statement level variables
            Dim count As Integer
            count = 1
            Console.WriteLine(count)
            'Do some operations
            Console.WriteLine("Hey there, we are inside if now!")
        ElseIf flag > 10 Then
            Console.WriteLine("We are inside Elseif and there are no curly braces- remember that")
        Else
            Console.WriteLine("Value is false")
        End If
        Console.ReadLine()

        'Select statments
        Select Case flag
            Case 10
                Console.WriteLine("Case is true")
            Case 20

            Case Else
                Console.WriteLine("Value is false")
        End Select

        'Looping statements
        'index variable's scope ends with end of the loop
        For index = 1 To 10
            'Declare another variable here
            'its scope will end with the loop
            Console.WriteLine(index)
        Next
        Console.ReadLine()

        For count = 1 To 10 Step 2
            'This will run for 1,3,5 and so on..
            Console.WriteLine(count)
        Next

        For myIndex = 10 To 1 Step -1
            Console.WriteLine(myIndex)
        Next

        'While
        weight = 3.0
        While weight <= 3.0
            'do operations
            weight = weight - 1
        End While

        'Do
        Do
            'Perform the operations
            'this will be run atleast once
            weight = weight - 1
        Loop While weight < 3

        Return 0
    End Function

    Sub DoThisAsWell()
        DoThis(True)

        Dim count As Integer
        count = DoThis(10)

        Dim rtr As Integer
        rtr = DoThis(10, 50.0, "ruchira")
    End Sub

    'Different signatures to the function named DoThis
    'Overloading
    Function DoThis(flag As Integer) As Integer

        Return 0
    End Function

    Function DoThis(name As String, weight As Single) As Integer

        Return 0
    End Function

    Function DoThis(anotherflag As Boolean) As Boolean
        Return True
    End Function
End Module
