Module AddressCollection
    Sub MySub()
        Dim CNames As Collection
        CNames = New Collection

        CNames.Add("ruchira")
        CNames.Add("ruchi")

        Dim CEmails As Collection
        CEmails = New Collection

        CEmails.Add("ruchira_agarwal")
        CEmails.Add("ruchi_abc")

        Dim CAddr As Collection
        CAddr = New Collection

        'For Each CItem As Host in CNames,CEmails
        '    CItem.Add(CNames.IndexOf(CNames) + "," + CEmails.IndexOf(CEmails))
        'Next

        Console.ReadLine()

    End Sub

End Module
