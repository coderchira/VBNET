Module Module2

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

    'Declare a function
    Private Function myCalledFunc() As String
        'body /Implementation
        Return ("Hi from Function")
    End Function

    Private Function myCallingFunc() As Integer
        'body
        'call another function
        myCalledFunc()
        Return 0
    End Function

    Sub MySub()
        myCalledFunc()
    End Sub

End Module
