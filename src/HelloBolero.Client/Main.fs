module HelloBolero.Client.Main

open Elmish
open Bolero
open Bolero.Html
open System.Collections.Generic

type Model =
    {
        value: int
    }

let initModel =
    {
        value = 0
    }

type Message =
    | Increment
    | Decrement

let update message model =
    match message with
    | Increment -> { model with value = model.value + 1 }
    | Decrement -> { model with value = model.value - 1 }

let textAreaClick _ =
    let text = [1;2;3;4] |> List.map (fun x -> x * 2) |> List.sum
    printfn "click ... %A" (text)

let view model dispatch =
    concat [
        button [on.click (fun _ -> dispatch Decrement)] [text "-"]
        span [] [textf " %i " model.value]
        button [on.click (fun _ -> dispatch Increment)] [text "+"]
        button [on.click textAreaClick; attr.style "background: green;"] [ text "Hello"]
    ]

type MyApp() =
    inherit ProgramComponent<Model, Message>()

    override this.Program =
        Program.mkSimple (fun _ -> initModel) update view
