namespace testApp

module FizzBuzz = 
    let fiffBuzz (number: int) : string =
        if number % 3 = 0 && number % 5 = 0 then
            "FizzBuzz"
        elif number % 3 = 0 then
            "Fizz"
        elif number % 5 = 0 then
            "Buzz"
        else
            sprintf "%i" number