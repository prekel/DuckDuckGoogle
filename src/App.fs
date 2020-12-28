module App

open Browser.Dom

let links =
    document.getElementById ("links") :?> Browser.Types.HTMLDivElement

let input =
    document.getElementById ("search_form_input") :?> Browser.Types.HTMLInputElement

let v = input.value

printfn "%s12" v

links.setAttribute ("style", "width: 700px")
