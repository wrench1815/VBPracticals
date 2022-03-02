Imports System

Module Program
    Sub Main()
        'Collections: Stack,Queue, ArrayList, Hash Table
        Dim table As New Hashtable From {
            {"0", "Ram"},
            {"1", "Sham"},
            {"2", "Shubham"},
            {"3", "Harry"},
            {"4", "Hardeep"}
        }

        For Each key As String In table.Keys
            Console.WriteLine("{0} : {1}", key, table(key))
        Next
    End Sub
End Module