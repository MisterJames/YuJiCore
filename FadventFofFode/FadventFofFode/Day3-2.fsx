
open System.IO
let dirPath = "C:\\Code\\YuJimmy\\FadventFofFode\\FadventFofFode\\"   // james
//let dirPath = "C:\Users\Corey\Documents\GitHub\YuJiCore\\FadventFofFode\\FadventFofFode\\"  // corey
// let dirPath = ""   // yujie

let input = File.ReadAllText  (dirPath + "Day3Input.txt" )

let move ((x, y)::_ as acc) dir =
    match dir with
    | '^' -> (x, y-1)::acc
    | '>' -> (x+1, y)::acc
    | 'v' -> (x, y+1)::acc
    | '<' -> (x-1, y)::acc

input
|> Seq.mapi (fun i x -> i%2, x)
|> Seq.groupBy fst
|> Seq.map (fun (_, gr) -> gr |> Seq.map snd)
|> Seq.collect (Seq.fold move [(0, 0)])
|> Seq.distinct
|> Seq.length
