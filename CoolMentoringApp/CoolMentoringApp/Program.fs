// Learn more about F# at http://fsharp.org

open System
open System.IO


[<EntryPoint>]
let main argv =

    let text = File.ReadAllText argv.[0]

    let splitBySpace (x: string): string [] = x.Split ' '

    let splitText = text.Split(Environment.NewLine)

    let wordsCount =
        splitText
        |> Array.map splitBySpace
        |> Array.map Array.length
        |> Array.sum

    let lineCount = splitText.Length

    let charCount =
        splitText |> Array.map String.length |> Array.sum

    printfn "Line Count %d" lineCount
    printfn "Word Count %d" wordsCount
    printfn "Character Count %d" charCount

    0 // return an integer exit code
