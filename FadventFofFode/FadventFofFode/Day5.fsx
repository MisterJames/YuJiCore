open System.IO
let dirPath = "C:\\Dev\\YuJiCore\\FadventFofFode\\FadventFofFode\\"  // corey

let containsThreeVowels set = set

let doubleLetter set = set

let notContainNaughtyStrings set = set



let run = File.ReadAllLines (dirPath + "Day5Input.txt" )
                |> containsThreeVowels
                |> doubleLetter
                |> notContainNaughtyStrings
                |> Seq.length


