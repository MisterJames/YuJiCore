
//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0 // return an integer exit code

open System.IO

let readLines (filePath:string) = seq {
    use sr = new System.IO.StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}

let input = readLines "C:\Code\YuJimmy\FadventFofFode\FadventFofFode\Day1Input.txt"

//let split = input.Split [|','|]


// break down a string into chars
let explode (s:string) =
    [for c in s -> c]

printfn "%A" input



// read the input into a string
// parse the string into an array/list/seq
// function that takes a seq and yields 1/-1
// var = sum of the call of the seq to the function

// let sampleTableOfSquares = [ for i in 0 .. 99 -> (i, i*i) ]
let directions = 
    [ for direction in input ->  
        if direction = ")" then  
            -1
        else  
            1 ]









