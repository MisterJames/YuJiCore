
open System.IO
let finalFloor = File.ReadAllText "C:\Dev\YuJiCore\FadventFofFode\FadventFofFode\Day1Input.txt" 
                |> ( fun s -> [| for c in s -> c |] )                   // convert to char array
                |> Array.map ( fun x -> if x = ')' then -1 else 1 )     // convert chars to 1/-1
                |> Array.reduce ( fun acc value -> acc + value )        // reduce array to single value



let rec parse list floor answer = 
                                  match list with
                                  | _ when floor = -1 -> answer //stop rec
                                  | [] -> floor //stop rec
                                  | hd::tail ->
                                                match hd with
                                                | ')' -> parse tail (floor-1) answer+1
                                                | '(' -> parse tail (floor+1) answer+1 
                                                | _ -> parse tail floor answer
let parseStart list = parse list 0 0

let basement = File.ReadAllText "C:\Dev\YuJiCore\FadventFofFode\FadventFofFode\Day1Input.txt" 
                |> ( fun s -> [ for c in s -> c ] )
                |> parseStart


//                                                if hd = ')' 
//                                                then 
//                                                    parse tail floor+1 answer+1
//                                                else 
//                                                    parse tail floor-1 answer+1