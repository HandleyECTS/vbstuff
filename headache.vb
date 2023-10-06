Imports System
Imports System.Threading

Module Headache
    Sub Main(args As String())
        Dim count As Integer = 1

        ' Get all possible ConsoleColor values
        Dim allColors() As ConsoleColor = DirectCast([Enum].GetValues(GetType(ConsoleColor)), ConsoleColor())
        Dim random As New Random()

        While True


            For Each character As Char In count.ToString()
                ' Randomly select a color from the allColors array
                Dim randomColorIndex As Integer = random.Next(0, allColors.Length)
                Console.ForegroundColor = allColors(randomColorIndex)

                Console.Write(character)

            Next

            count += 1
        End While
    End Sub
End Module
