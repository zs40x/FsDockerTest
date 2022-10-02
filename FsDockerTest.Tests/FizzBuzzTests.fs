namespace MathService.Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open testApp.FizzBuzz

[<TestClass>]
type FizzBuzzTests () =

    [<TestMethod>]
    member this.OneIsOne() =
        Assert.AreEqual("1", fizzBuzz 1)