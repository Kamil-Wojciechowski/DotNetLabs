open System
open System.Numerics

type Fraction(numerator: BigInteger, denominator: BigInteger) =
    let mutable num = numerator
    let mutable denom = denominator

    member this.Numerator with get() = num
    member this.Denominator with get() = denom

    member this.Reduce() =
        let gcd = BigInteger.GreatestCommonDivisor(num, denom)
        num <- num / gcd
        denom <- denom / gcd

    override this.ToString() = sprintf "%O/%O" num denom

    static member (+) (fraction1: Fraction, fraction2: Fraction) =
        let newNumerator = fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator
        let newDenominator = fraction1.Denominator * fraction2.Denominator
        Fraction(newNumerator, newDenominator)

    static member (-) (fraction1: Fraction, fraction2: Fraction) =
        let newNumerator = fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator
        let newDenominator = fraction1.Denominator * fraction2.Denominator
        Fraction(newNumerator, newDenominator)

    static member (*) (fraction1: Fraction, fraction2: Fraction) =
        let newNumerator = fraction1.Numerator * fraction2.Numerator
        let newDenominator = fraction1.Denominator * fraction2.Denominator
        Fraction(newNumerator, newDenominator)

    static member (/) (fraction1: Fraction, fraction2: Fraction) =
        let newNumerator = fraction1.Numerator * fraction2.Denominator
        let newDenominator = fraction1.Denominator * fraction2.Numerator
        Fraction(newNumerator, newDenominator)

[<EntryPoint>]
let main argv =
    let fraction1 = Fraction(BigInteger(1), BigInteger(2))
    let fraction2 = Fraction(BigInteger(3), BigInteger(4))

    let sum = fraction1 + fraction2
    let difference = fraction1 - fraction2
    let product = fraction1 * fraction2
    let quotient = fraction1 / fraction2

    printfn "Fraction 1: %O" fraction1
    printfn "Fraction 2: %O" fraction2
    printfn "Sum: %O" sum
    printfn "Difference: %O" difference
    printfn "Product: %O" product
    printfn "Quotient: %O" quotient

    0
