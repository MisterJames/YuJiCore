open System

let input = "bgvyzdsv"
let prefix = "00000"

let md5 = System.Security.Cryptography.MD5.Create()


let rec findHash number = input + number
                          |> System.Text.Encoding.ASCII.GetBytes
                          |> md5.ComputeHash
                          |> (fun x -> BitConverter.ToString(x))
                          |> (fun x -> x.Replace("-",""))
                          |> Seq.take 5
                          |> (fun s -> match s with 
                                            | prefix -> number
                                            | _ -> Int32.Parse(number) + 1
                                                    |> (fun x -> findHash(x.ToString())))
                                // append number to key
                                // convert to hash
                                // check leading 5 characters
                                // if true return number
                                // else recursive call number + 1
findHash("0")