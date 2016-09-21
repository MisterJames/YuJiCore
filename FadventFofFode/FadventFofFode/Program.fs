open System.IO

let readLines (filePath:string) = File.ReadAllText(filePath)
let input = readLines "C:\Code\YuJimmy\FadventFofFode\FadventFofFode\Day1Input.txt"

// break down a string into chars
let explode (s:string) = [for c in s -> c]
let split = explode input

// let sampleTableOfSquares = [ for i in 0 .. 99 -> (i, i*i) ]
let directions = 
    [| for direction in split ->  
        if direction = ')' then  
            -1
        else  
            1 |]


let finalFloor = directions |> Array.sum  //|> printf "%i"

