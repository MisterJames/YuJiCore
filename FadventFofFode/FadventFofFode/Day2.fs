
open System.IO

let dirPath = "C:\\Code\\YuJimmy\\FadventFofFode\\FadventFofFode\\"   // james
// let dirPath = ""   // corey
// let dirPath = ""   // yujie

let allArea = File.ReadAllLines (dirPath + "Day2Input.txt" )
                |> Seq.map ( fun s -> s.Split[|'x'|] |> Seq.map int |> Seq.sort |> Seq.toArray )
                |> Seq.map ( fun a -> 3 * a.[0] * a.[1] + 2 * a.[1] * a.[2] + 2 * a.[0] * a.[2] )
                |> Seq.sum






