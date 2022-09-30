namespace MathService.Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open testApp.FizzBuzz

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.OneIsOne() =
        Assert.AreEqual(1, FizzBuzz.fizzBuzz 1)

    [<TestMethod>]
     member this.FailEveryTime() = Assert.IsTrue(false)