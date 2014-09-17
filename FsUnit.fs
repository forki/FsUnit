namespace FsUnit

open System.Diagnostics
open NUnit.Framework

[<AutoOpen>]
module Extensions =

  [<DebuggerStepThrough>]
  let shouldEqual (x: 'a) (y: 'a) = Assert.AreEqual(x, y, sprintf "Expected: %A\nActual: %A" x y)

  [<DebuggerStepThrough>]
  let shouldBeSmallerThan (x: 'a) (y: 'a) = Assert.GreaterOrEqual(x, y, sprintf "Expected: %A\nActual: %A" x y)

  [<DebuggerStepThrough>]
  let shouldBeGreaterThan (x: 'a) (y: 'a) = Assert.Greater(y, x, sprintf "Expected: %A\nActual: %A" x y)
