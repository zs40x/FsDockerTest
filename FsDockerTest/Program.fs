// For more information see https://aka.ms/fsharp-console-apps

namespace testApp

open FizzBuzz

module Program = 
    [<EntryPoint>]
    let main argv =
        [1 .. 15]
            |> List.map FizzBuzz.fiffBuzz
            |> List.iter (fun result -> printfn "%s" result)
        0
