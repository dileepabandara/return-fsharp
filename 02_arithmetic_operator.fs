module Arithmetic =  
    let add (a:int,b:int):int =   
        a+b  
    let sub (a:int,b:int):int =   
        a-b  
    let mul (a:int,b:int):int =   
        a*b  
    let div (a:int,b:int):int =   
        if b<>0 then  
         a/b  
        else 0  
    let modu (a:int,b:int):int =   
        a%b  
  
  
  
open Arithmetic  
let addition = add (10, 10)      
let subtraction = sub (50,20)  
let multiplication = mul (10,10)  
let division = div (10,2)  
let modulus = modu (10,3)  
  
printfn "--------------------Result------------------"  
printfn "sum = %d" addition  
printfn "subtraction = %d" subtraction  
printfn "multiply = %d" multiplication  
printfn "division = %d" division  
printfn "modulus = %d" modulus  