//Silnia
let rec factorial n =
    match n with
    | 0 -> 1
    | _ -> n * factorial (n - 1)


//Suma elementów
let rec sumList lst =
    match lst with
    | [] -> 0
    | head :: tail -> head + sumList tail


//n-ty element ciągu Fibanociego
let rec fibonacci n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | _ -> fibonacci (n - 1) + fibonacci (n - 2)


[<EntryPoint>]
let main argv =
    let resultFactorial = factorial 5
    printfn "Wynik silni dla liczby 5: %d" resultFactorial

    let myList = [1; 2; 3; 4; 5]
    let resultSumList = sumList myList
    printfn "Suma elementów listy %A: %d" myList resultSumList

    let resultFibonacci = fibonacci 10
    printfn "10-ty element ciągu Fibonacciego: %d" resultFibonacci

    0