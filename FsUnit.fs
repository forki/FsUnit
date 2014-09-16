namespace FsUnit

open NUnit.Framework

[<AutoOpen>]
module Extensions =
  let shouldEqual (x: 'a) (y: 'a) = Assert.AreEqual(x, y, sprintf "Expected: %A\nActual: %A" x y)
  let shouldBeSmallerThan (x: 'a) (y: 'a) = Assert.GreaterOrEqual(x, y, sprintf "Expected: %A\nActual: %A" x y)
  let shouldBeGreaterThan (x: 'a) (y: 'a) = Assert.Greater(y, x, sprintf "Expected: %A\nActual: %A" x y)
