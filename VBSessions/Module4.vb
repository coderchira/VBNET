Module Module4
    '2 collections
    '1 collection has 10 names
    'second collection is empty
    'code such that : transfer of all the names from one collection to another 
    'except the one which has your name

    Dim myCollection1 As Collection
    Dim myCollection2 As Collection

    Sub MyCollectionSub()
        myCollection1 = New Collection
        myCollection2 = New Collection

        'add 10 names to collection 1
        myCollection1.Add("Vamsi")
        myCollection1.Add("Sreejith")
        myCollection1.Add("Aditya")
        myCollection1.Add("Vaigaai")
        myCollection1.Add("Besly")
        myCollection1.Add("Hari")
        myCollection1.Add("Gautam")
        myCollection1.Add("Kiranmayee")
        myCollection1.Add("Anirudh")
        myCollection1.Add("Lokesh")

        Dim name As String = "Vamsi"
        For index = 1 To myCollection1.Count
            If myCollection1.Item(index) <> name Then
                myCollection2.Add(myCollection1.Item(index))
            End If
        Next

        'Another way
        ' add everything into collection 2
        ' and then use .Remove where item = your name

        'this is valid
        'myCollection2.Add(myCollection1)
        
            For Each item In myCollection2
                Console.WriteLine(item.ToString())
            Next
            Console.ReadLine()
    End Sub


End Module
