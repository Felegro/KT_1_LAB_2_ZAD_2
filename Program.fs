// Lecture1 - работа со списками
let binaryStrings = ["1"; "10"; "11"; "100"; "101"; "110"; "111"; "1000"; "1001"]

// Lecture2 - функции высшего порядка и конвейерный оператор
let sumOfBinaryNumbers = 
    binaryStrings
    |> List.map (fun binaryStr -> System.Convert.ToInt32(binaryStr, 2))  // Lecture2 - лямбда-функция
    |> List.sum  // Lecture3 - агрегатные операторы

// Lecture1 - вывод результатов
printfn "Исходный список двоичных чисел: %A" binaryStrings
printfn "Сумма в десятичной системе: %d" sumOfBinaryNumbers

// Альтернативное решение с явным описанием шагов (более учебный вариант)
let binaryToDecimal binaryStr =
    System.Convert.ToInt32(binaryStr, 2)

let decimalNumbers = List.map binaryToDecimal binaryStrings  // Lecture1 - List.map
let totalSum = List.sum decimalNumbers  // Lecture3 - List.sum

printfn "Десятичные представления: %A" decimalNumbers
printfn "Сумма: %d" totalSum