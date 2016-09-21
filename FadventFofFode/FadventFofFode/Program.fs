open System.IO

let finalFloor = File.ReadAllText "C:\Code\YuJimmy\FadventFofFode\FadventFofFode\Day1Input.txt" 
                |> ( fun s -> [| for c in s -> c |] )                   // convert to char array
                |> Array.map ( fun x -> if x = ')' then -1 else 1 )     // convert chars to 1/-1
                |> Array.reduce ( fun acc value -> acc + value )        // reduce array to single value


