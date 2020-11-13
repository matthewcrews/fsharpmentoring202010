// Learn more about F# at http://fsharp.org

open System
open System.IO

type Chicken = {
  Name : string
  Size : float
}

//type Monkey = {
//  Name : string
//  Size : int
//}

module Chicken =

  let grow sizeToAdd chicken =
    { chicken with Size = chicken.Size + sizeToAdd }

  let rename newName chicken =
    { chicken with Name = newName }

  let transform sizeToAdd newName (chicken :Chicken) : Chicken = 
    {
      Name = newName
      Size = chicken.Size + sizeToAdd
    }

  let create name size : Chicken =
    {
      Name = name
      Size = size
    }



[<EntryPoint>]
let main argv =

    let chicken1 = Chicken.create "Clucky" 10.0
    let chicken2 = Chicken.grow 2.0 chicken1
    let chicken3 = Chicken.rename "Bob" chicken1

    let chicken5Grower = Chicken.grow 5.0
    let chicken4 = chicken5Grower chicken1

    let chicken10Grower = Chicken.grow 10.0

    let weirdFunction name = fun x -> Chicken.transform x name
    let growAndRename = weirdFunction "Ted"

    let c6 = growAndRename 6.0 chicken1

    let changeAllTheThings = Chicken.transform 3.34 "Floyd" 


    printfn "Chicken1 %A" chicken1
    printfn "Chicken2 %A" chicken2
    printfn "Chicken3 %A" chicken3
    printfn "Chicken4 %A" chicken4
    printfn "Chicken6 %A" c6

    //let x = 10
    //let y = "a string"
    //let mutable x = 10
    
    //let printX () =
    //  printfn "X is %i" x
    
    //printX () 

    //x <- 20

    //printX ()

    //let add x y =
    //  x + y

    //let add5 = add 5

    let text = File.ReadAllText argv.[0]

    let splitBySpace (x :string) = 
        x.Split ' '

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
