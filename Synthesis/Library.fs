module Synthesis

let abelar n = n > 12 && n < 3097 && n % 12 = 0 
    //failwith "Not implemented"

let area bs height =
    match bs >= 0.0 && height >= 0.0 with
     |true -> (bs * height)/2.0
     |false -> failwith "shouldFail"
    //failwith "ShouldFail"

let zollo num =match num < 0 with
               |true -> num * -1
               |false -> num * 2
    //failwith "Not implemented"

let min first second = match first > second with
                       |true -> second
                       |false -> first
    //failwith "Not implemented"

let max first second = match first > second with
                        |true -> first
                        |false -> second
    //failwith "Not implemented"

let ofTime hours minutes seconds = (hours * 3600) + (minutes * 60) + seconds
    //failwith "Not implemented"

let toTime seconds = match seconds >= 0 with
                      |true -> (seconds/3600),((seconds%3600)/60),((seconds%3600)%60)
                      |false -> 0,0,0

let rec digits num = match ((num < 10 && num >= 0) || (num < 0 && num > -10)) with
                     |true -> 1
                     |_ -> 1 + digits (num/10)

  //failwith "Not implemented"

let minmax (a,b,c,d) = (*match (a>b && a>c && a>d) || (b>a && b>c && b>d) || (d>a && d>b && d>c) with
                        |true -> a|b|c
                        |false -> a,b*)

    failwith "Not implemented"

let isLeap year = match year % 4 = 0 && (year % 100 <> 0 || (year % 400 = 0 && year % 100 = 0)) with
                   |true -> true
                   |false -> match year >= 1582 && year > 0 with
                              |false -> failwith "shouldFail"
                              |_ -> false

let month num = match num with
                |1 -> "January", 31
                |2 -> "February", 28
                |3 -> "March", 31
                |4 -> "April", 30
                |5 -> "May", 31
                |6 -> "June", 30
                |7 -> "July", 31
                |8 -> "August", 31
                |9 -> "September", 30
                |10 -> "October", 31
                |11 -> "November", 30
                |12 -> "December", 31
                |_ -> failwith "shouldFail"
    

let rec toBinary num = match num >= 0 with
                   |true -> match num with
                                 |0 | 1 -> string num
                                 |_ -> 
                                    let bit = string (num % 2)
                                    (toBinary (num/2))+bit
                   |false -> failwith "shouldFail"

let bizFuzz _ =
    failwith "Not implemented"

let monthDay _ _ =
    failwith "Not implemented"

let coord _ =
    failwith "Not implemented"