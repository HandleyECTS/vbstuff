Imports System

Module Program
    Sub Main()
        ' Get the buffer width of the console
        Dim bufferWidth As Integer = Console.BufferWidth

        ' Print the buffer width to the console
        Console.WriteLine("Console Buffer Width: " & bufferWidth)

        ' Wait for user input before exiting
        Console.ReadLine()
    End Sub
End Module
