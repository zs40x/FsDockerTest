// For more information see https://aka.ms/fsharp-console-apps

let generateRandomNumber() =
    let r = System.Random()
    r.Next()

printfn "Hello from F#"

let number = generateRandomNumber()
printfn "Another Number: %i" number

let add(a:int) (b:int) : int = a + b

let calculationResult = add 10 12
printfn "Call a Function that Adds 2 Numbers: %i" calculationResult
