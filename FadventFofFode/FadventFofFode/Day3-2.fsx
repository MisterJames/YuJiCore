
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

input                                         // [v,x,v,x,v,x]
|> Seq.mapi (fun i x -> i%2, x)               // [(0,v),(1,x),(0,v),(1,x),(0,v),(1,x)]
|> Seq.groupBy fst                            // [[(0,v),(0,v),(0,v)],[(1,x),(1,x),(1,x)]]
|> Seq.map (fun (_, gr) -> gr                 // [0, [(0,v),(0,v),(0,v)]]          [1, [(1,x),(1,x),(1,x)]]
                            |> Seq.map snd)   // [v,v,v]                           [x,x,x]
|> Seq.collect (Seq.fold move [(0, 0)])       // [v,v,v] -> [(0,0),(0,1),(1,1)]    [x,x,x] -> [(0,0),(0,-1),(1,-1)]
                                              // [(0,0),(0,1),(1,1),(0,0),(0,-1),(1,-1)]
|> Seq.distinct                               // [(0,0),(0,1),(1,1),(0,-1),(1,-1)]
|> Seq.length                                 // 5
