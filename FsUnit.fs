namespace FsUnit

open System.Diagnostics
open NUnit.Framework
open System.Collections.Generic

[<AutoOpen>]
module Extensions =

  [<DebuggerStepThrough>]
  let shouldEqual (x: 'a) (y: 'a) = Assert.AreEqual(x, y, sprintf "Expected: %A\nActual: %A" x y)

  [<DebuggerStepThrough>]
  let shouldContain (x: 'a) (y: 'a seq) =
    let list = List<_>()
    for a in y do
        list.Add a
    Assert.Contains(x, list)

  [<DebuggerStepThrough>]
  let shouldBeSmallerThan (x: 'a) (y: 'a) = Assert.GreaterOrEqual(x, y, sprintf "Expected: %A\nActual: %A" x y)

  [<DebuggerStepThrough>]
  let shouldBeGreaterThan (x: 'a) (y: 'a) = Assert.Greater(y, x, sprintf "Expected: %A\nActual: %A" x y)
