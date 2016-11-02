
let input = "bgvyzdsv"
let prefix = "00000"

let md5 = System.Security.Cryptography.MD5.Create()


let rec findHash number = 
                                // append number to key
                                // convert to hash
                                // check leading 5 characters
                                // if true return number
                                // else recursive call number + 1