namespace testApp.FizzBuzzTests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open testApp.FizzBuzz

[<TestClass>]
type FizzBuzzTests () =

    [<TestMethod>]
    member this.OneIsOne() =
        Assert.AreEqual("1", fizzBuzz 1)

    [<TestMethod>]
    member this.ThreeIsFizz() =
        Assert.AreEqual("Fizz", fizzBuzz 3)

    [<TestMethod>]
    member this.FiveIsBuzz() =
        Assert.AreEqual("Buzz", fizzBuzz 5)

    [<TestMethod>]
    member this.FivteenIsFizzBuzz() =
        Assert.AreEqual("FizzBuzz", fizzBuzz 15)
