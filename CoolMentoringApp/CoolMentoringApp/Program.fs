// Learn more about F# at http://fsharp.org

open System
open System.IO


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let otherAdd (x: float, y: float) =
        x + y

    let myAdd x y =
        x + y

    let myAdd5 = myAdd 5 6
    //let floatAdd = myAdd 1.0 2.0

    //let chicken = otherAdd (5, 5)

    let text = File.ReadAllText "RandomText.txt"

    let splitText = text.Split(System.Environment.NewLine)

    for s in splitText do
        printfn "%A" s

    0 // return an integer exit code
