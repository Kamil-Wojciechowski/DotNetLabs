type Quaternion(real: float, i: float, j: float, k: float) =
    let mutable r = real
    let mutable imI = i
    let mutable imJ = j
    let mutable imK = k

    member this.Real with get() = r
    member this.ImI with get() = imI
    member this.ImJ with get() = imJ
    member this.ImK with get() = imK

    static member (+) (q1: Quaternion, q2: Quaternion) =
        Quaternion(q1.Real + q2.Real, q1.ImI + q2.ImI, q1.ImJ + q2.ImJ, q1.ImK + q2.ImK)

    static member (-) (q1: Quaternion, q2: Quaternion) =
        Quaternion(q1.Real - q2.Real, q1.ImI - q2.ImI, q1.ImJ - q2.ImJ, q1.ImK - q2.ImK)

    static member (*) (q1: Quaternion, q2: Quaternion) =
        let newReal = q1.Real * q2.Real - q1.ImI * q2.ImI - q1.ImJ * q2.ImJ - q1.ImK * q2.ImK
        let newImI = q1.Real * q2.ImI + q1.ImI * q2.Real + q1.ImJ * q2.ImK - q1.ImK * q2.ImJ
        let newImJ = q1.Real * q2.ImJ - q1.ImI * q2.ImK + q1.ImJ * q2.Real + q1.ImK * q2.ImI
        let newImK = q1.Real * q2.ImK + q1.ImI * q2.ImJ - q1.ImJ * q2.ImI + q1.ImK * q2.Real
        Quaternion(newReal, newImI, newImJ, newImK)

    override this.ToString() =
        sprintf "%f + %fi + %fj + %fk" this.Real this.ImI this.ImJ this.ImK

[<EntryPoint>]
let main argv =
    let quaternion1 = Quaternion(1.0, 2.0, 3.0, 4.0)
    let quaternion2 = Quaternion(5.0, 6.0, 7.0, 8.0)

    let sum = quaternion1 + quaternion2
    let difference = quaternion1 - quaternion2
    let product = quaternion1 * quaternion2

    printfn "Quaternion 1: %O" quaternion1
    printfn "Quaternion 2: %O" quaternion2
    printfn "Sum: %O" sum
    printfn "Difference: %O" difference
    printfn "Product: %O" product

    0
