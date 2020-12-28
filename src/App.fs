module App

open Browser.Dom

let private links =
    document.getElementById ("links") :?> Browser.Types.HTMLDivElement

let private input =
    document.getElementById ("search_form_input") :?> Browser.Types.HTMLInputElement

let private v = input.value

printfn "%s12" v

links.setAttribute ("style", "width: 700px")
