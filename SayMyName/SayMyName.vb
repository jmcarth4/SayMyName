'Jessica McArthur
'RCET0265
'Spring 2020
'Say My Name
'https://github.com/jmcarth4/SayMyName

Option Explicit On
Option Strict On

Module SayMyName
    Sub Main()
        'variables declared 
        Dim userInput As String

        'user is asked their name.
        Console.WriteLine("Quelle est votre nom? Comment t'appelle tu? {Greetings earthling! What do they refer to you as?}")
        userInput = Console.ReadLine()

        'user is greatted by their name
        Console.WriteLine("Salut! Bonjour! Bonsoir! Bonjouree! " & userInput & " Go buy a flying monkey")
        Console.ReadLine()


    End Sub

End Module
