
let x = 1
let y = 2.0
let z = float x + y

let adder x y = 
    x + y

let inline otherAdder x y =
    x + y

let a = otherAdder 1 2
let b = otherAdder 1.0 2.0

type Chicken = {
    Name : string
    Size : float
}
    with
        static member (+) (a: Chicken, b: Chicken) =
            { a with Size = a.Size + b.Size }

        static member (+) (a: Chicken, b: float) =
            { a with Size = a.Size + b }

        static member (+) (b: float, a: Chicken) =
            { a with Size = a.Size + b }

        static member (+) (b: float, a: float) =
            { Name = "Floaty"; Size = 1.0 }

        member x.MyName () =
            x.Name

        member x.SillyName () =
            sprintf "Silly Name: %s" x.Name

        member _.EmptyThing () =
            "Empty thing"

        //static member fullDescription (a: Chicken) =
        //    sprintf "Name: %A Size: %A" a.Name a.Size
        
        member x.OtherDescription () =
            sprintf "Name: %A Size: %A" x.Name x.Size

module Chicken =

    let otherDescription (c: Chicken) =
        c.OtherDescription ()

    let sillyName (c: Chicken) =
        c.SillyName ()

type Monkey = {
    Name : string
}
with
    static member (+) (a: Monkey, b: Monkey) =
        { Name = "Monkey"; Size = 1.0 }

let c1 = { Name = "Clucky"; Size = 1.0 }
let c2 = { Name = "Lucky"; Size = 0.8 }
let c3 = otherAdder c1 c2
let c4 = otherAdder c1 2.0
let c5 = otherAdder 2.0 c1
let q = 1.0 + 2.0

let m1 = { Name = "Monkey1" }
let m2 = { Name = "Monkey2" }
let m3 = otherAdder m1 m2

printfn "%A" (c1.MyName ())
printfn "%A" (c1.SillyName ())
printfn "%A" (c1.EmptyThing())

c1.OtherDescription ()

//c1
//|> Chicken.fullDescription
//|> //other functions
let dumbDontDotThis =
    c1
    |> (fun x -> x.SillyName ())
    |> (fun x -> x = "Weird Name")

let doThisInstead =
    c1
    |> Chicken.sillyName
    |> (fun x -> x = "Weird Name")