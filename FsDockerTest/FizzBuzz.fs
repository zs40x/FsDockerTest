namespace testApp

module FizzBuzz = 
    let fizzBuzz (number: int) : string =
        match number with
        | (n) when n % 3 = 0 && n % 5 = 0 -> "FizzBuzz"
        | (n) when n % 3 = 0 -> "Fizz"
        | (n) when n % 5 = 0 -> "Buzz"
        | _ ->sprintf "%i" number