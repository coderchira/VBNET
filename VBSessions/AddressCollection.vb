Module AddressCollection
    '3 collections:
    'collection 1  has names
    'Collection 2 has emails 
    'Code such that collection 3 is going to be a collection of collection representing a complete address

    Sub MySub()
        Dim CNames As New Collection
        CNames.Add("ruchira")
        CNames.Add("ruchi")

        Dim CEmails As New Collection
        CEmails.Add("ruchira_agarwal")
        CEmails.Add("ruchi_abc")

        Dim CAddr As New Collection

        'For Each CItem As Host in CNames,CEmails
        '    CItem.Add(CNames.IndexOf(CNames) + "," + CEmails.IndexOf(CEmails))
        'Next
        Console.ReadLine()
    End Sub
End Module
