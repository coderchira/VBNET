Module Module1

    Sub Main()
        'Module4.MyCollectionSub()
        AddressCollection.MySub()
        'Dim myPerson As New Person
        ''myPerson.setName("ruchira")
        ''Console.WriteLine(myPerson.getName())
        'myPerson.Name = "Ruchira"
        'Console.WriteLine(myPerson.Name())
        'Console.ReadLine()
        'myPerson.Walk()

        'Dim anotherPerson As Person ' handle of base class
        'anotherPerson = New Person()
        'implementation is the child class
        'anotherPerson = New Employee 'this is valid 

        'Dim pPerson As New Person
        'pPerson.Walk()

        Dim myEmployee As Employee
        myEmployee = New Employee
        'Here we can acccess the methods of base class
        myEmployee.Walk()

        'myEmployee = New Person 'this is not valid // illegal


        'myEmployee.Name = "Besly"
        'myEmployee.CompanyName = "Infosys"


        'What is a program?
        ' Set of instructions - Logic?
        '   Data and logic 
        ' Data <--> Logic
        '   Variables
        '       can change their value 
        '           Classified into 2 types:
        '               Native Types (Stack)
        '                   They are faster
        '                   They are fixed in size
        '                   They are disposed automatically
        '               Object Types (Heap)
        '                   Slower
        '                   The size is unknown
        '                   Explicitly dispose them when not in use
        '   Constants
        '       do not change their value

        'Lifecycle of variables
        '   Declare
        '   Use /Assign
        '   Dispose
        '       
        'Declaration
        '   Dim (Dimension)
        '   Name
        '   Type
        'Dim flag As Boolean ' 2 bytes
        'Dim num As Integer  '4 bytes
        'Dim precision As Single ' 4 bytes
        'Dim precisionDouble As Double ' 8 bytes
        'Dim accuracy As Decimal ' 16 bytes
        'Dim name As String ' depending on the value of the variable

        ''Use the variables
        'flag = True
        'num = 10
        'precision = 0.33333333
        'precisionDouble = 0.333333333333333
        'accuracy = 10.56
        'name = "Ruchira"

        'Console.WriteLine("Boolean value is {0}", flag)
        'Console.WriteLine(num)
        'Console.WriteLine(precision)
        'Console.WriteLine(precisionDouble)
        'Console.WriteLine(accuracy)
        'Console.WriteLine(name)
        'Console.ReadLine()

        'Dim leftInt As Integer
        'leftInt = 10

        'Dim rightInt As Integer
        'rightInt = 20

        'Dim addNumbers As Integer
        'addNumbers = leftInt + rightInt

        'Dim subNumbers As Integer
        'subNumbers = rightInt - leftInt

        'Dim prodNumbers As Integer
        'prodNumbers = leftInt * rightInt

        'Dim remainder As Integer
        'Dim quotient As Integer

        'quotient = Math.DivRem(rightInt, leftInt, remainder)
        'Console.WriteLine("Remainder {0} Quotient {1}", remainder, quotient)
        'Console.ReadLine()

        'Dim msg1 As String
        'msg1 = "This is the VB session day 1"

        'Dim msg2 As String
        'msg2 = " and we are confident on this day"

        ''Concatenation of two strings
        'Dim resultMsg As String
        'resultMsg = msg1 + msg2
        'Console.WriteLine(resultMsg)
        'Console.ReadLine()

        ''Some operations on strings
        ''Get the position of a keyword's first occurence from left
        'Dim position As Integer
        'position = InStr(resultMsg, "day")
        'Console.WriteLine("Position of day is {0}", position)

        ''Search from right and Get the position(from left or total stringlength - position from right)
        '' of keyword's first occurence
        'Dim position2 As Integer
        'position2 = InStrRev(resultMsg, "day")
        'Console.WriteLine("Position of day is {0}", position2)

        ''using Instr to get the second occurence from left
        'position2 = InStr(position + 1, resultMsg, "day")
        'Console.WriteLine("Position of session is {0} {1}", position, position2)
        'Console.ReadLine()

        'Dim leftPortion As String
        'leftPortion = Left(resultMsg, 20)
        'Console.WriteLine(leftPortion)
        'Console.ReadLine()

        'Dim rightPortion As String
        'rightPortion = Right(resultMsg, 24)
        'Console.WriteLine(rightPortion)
        'Console.ReadLine()

        'Dim myString As String
        'myString = "1.10"

        'Dim myStringasNumber As Integer
        'myStringasNumber = CInt(myString)

        'Dim mynumAsDouble As Double
        'mynumAsDouble = CDbl(myString)

        'Dim myNum As Integer
        'myNum = 10

        'Dim myNumasString As String
        'myNumasString = CStr(myNum)
        'myNumasString = myNum.ToString()

        ''Object Type variables
        ''Collections
        ''   New them - you are creating instance whenever you want to use them
        '' Declare a collection
        'Dim myCollection As Collection
        'myCollection = New Collection

        ''Using the collection
        'myCollection.Add(100)
        'myCollection.Add("ruchira")
        'myCollection.Add("Besly")
        'myCollection.Add(2)

        'myCollection.Remove(2)

        'Console.WriteLine(CStr(myCollection.Item(1)))
        'Console.ReadLine()

        ''Treat Object to be the parent of all types in .net
        ''Late binding
        ''   Flexible
        ''   slower
        ''   error prone
        'Dim collectItem As Object
        'collectItem = myCollection.Item(1).ToString()

        ''Dispose the object variable
        'myCollection = Nothing

    End Sub

End Module
