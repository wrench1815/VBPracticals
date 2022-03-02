Imports System

Module Program
    Sub Main()

        Dim byteVar As Byte
        Dim integerVar As Integer
        Dim singleVar As Single
        Dim doubleVar As Double
        Dim dateVar As Date
        Dim charVar As Char
        Dim stringVar As String
        Dim booleanVar As Boolean

        byteVar = 1
        integerVar = 1234567
        singleVar = 0.12345678901234566
        doubleVar = 0.12345678901234566
        dateVar = Today
        charVar = "A"c
        stringVar = "Visual Basic"
        booleanVar = True

        Console.WriteLine("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}", vbCrLf, byteVar, integerVar, singleVar, doubleVar, dateVar, charVar, stringVar, booleanVar)

    End Sub
End Module