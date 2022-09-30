// For more information see https://aka.ms/fsharp-console-apps

let generateRandomNumber() =
    let r = System.Random()
    r.Next()

printfn "Hello from F#"

let number = generateRandomNumber()
printfn "Another Number: %i" number
