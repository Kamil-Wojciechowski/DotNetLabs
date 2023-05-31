type Complex(real: float, imaginary: float) =
    let mutable re = real
    let mutable im = imaginary

    member this.Real with get() = re
    member this.Imaginary with get() = im

    static member (+) (c1: Complex, c2: Complex) =
        Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary)

    static member (-) (c1: Complex, c2: Complex) =
        Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary)

    static member (*) (c1: Complex, c2: Complex) =
        let newReal = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary
        let newImaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
        Complex(newReal, newImaginary)

    override this.ToString() =
        sprintf "%f + %fi" this.Real this.Imaginary

[<EntryPoint>]
let main argv =
    let complex1 = Complex(1.0, 2.0)
    let complex2 = Complex(3.0, 4.0)

    let sum = complex1 + complex2
    let difference = complex1 - complex2
    let product = complex1 * complex2

    printfn "Complex 1: %O" complex1
    printfn "Complex 2: %O" complex2
    printfn "Sum: %O" sum
    printfn "Difference: %O" difference
    printfn "Product: %O" product

    0
