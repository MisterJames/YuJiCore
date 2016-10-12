module Day3
open System.IO
//let dirPath = "C:\\Code\\YuJimmy\\FadventFofFode\\FadventFofFode\\"   // james
let dirPath = "C:\Users\Corey\Documents\GitHub\YuJiCore\\FadventFofFode\\FadventFofFode\\"  // corey
// let dirPath = ""   // yujie

let allArea = File.ReadAllText  (dirPath + "Day3Input.txt" )
              |> Seq.fold (fun ((x,y)::_ as acc) s -> match s with
                                                        | '^' -> (x,y+1)::acc 
                                                        | 'v' -> (x,y-1)::acc
                                                        | '<' -> (x-1,y)::acc 
                                                        | '>' -> (x+1,y)::acc 
                                                        )[(0,0)]
              |> Seq.distinct
              |> Seq.length


