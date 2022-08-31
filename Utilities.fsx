/// Helper functions mainly to help print out types in .NET Interactive notebooks.
/// This module is only intended to be used in the context of a notebook.
module Utilities

open Microsoft.FSharp.Reflection
open System.Text.RegularExpressions

let private removeFSI typeString =
    let fsiRemoved = Regex.Replace(typeString, "FSI_[0-9]+\+", "")
    Regex.Replace(fsiRemoved, "\+_?[a-zA-Z]+", "")

let private removeSystem typeString =
    Regex.Replace(typeString, "System\.+", "")

let private replaceObject typeString =
    Regex.Replace(typeString, "Object", "'T")

let private replaceGeneric typeString =
    Regex.Replace(typeString, "\`[0-9]*\[.*\]", "<'T>")

/// Helper function to return the type of a value in a .NET Interactive notebook as a string
let getType value =
    value.GetType().ToDisplayString() // ToDisplayString is provided by .NET Interactive
    |> removeFSI
    |> removeSystem
    |> replaceObject

/// Helper function to return the type signature of a function in a .NET Interactive notebook as a string
let getTypeSignature f =
    let typeSignature =
        let rec loop nested t =
            if FSharpType.IsTuple t then
                FSharpType.GetTupleElements t
                |> Array.map (loop true)
                |> String.concat " * "
            elif FSharpType.IsFunction t then
                let fs = if nested then sprintf "(%s -> %s)" else sprintf "%s -> %s"
                let domain, range = FSharpType.GetFunctionElements t
                fs (loop true domain) (loop false range)
            else
                t.FullName
        loop false (f.GetType())
        |> removeFSI
        |> removeSystem
        |> replaceGeneric
        |> replaceObject
    typeSignature

/// Helper function to print a value
let print value = printfn "%A" value

/// Helper function to print a value with a label
let printWithLabel label value = printfn "%s: %A" label value

/// Helper function to return a string with a label
let sprintWithLabel label value = sprintf "%s: %s" label value
