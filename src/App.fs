module App

open Browser.Dom
open Fable.Core.JS

let results =
    (document.getElementsByClassName("results--main")).[0] :?> Browser.Types.HTMLDivElement

results.setAttribute ("style", "width: 700px")


let input =
    document.getElementById ("search_form_input") :?> Browser.Types.HTMLInputElement

let duckbar =
    document.getElementById ("duckbar_static") :?> Browser.Types.HTMLUListElement

let googleListItem =
    document.createElement ("li") :?> Browser.Types.HTMLLIElement

googleListItem.className <- "zcm__item"

let googleA =
    document.createElement ("a") :?> Browser.Types.HTMLAnchorElement

googleA.className <- "zcm__link js-zci-link"

googleA.href <-
    "https://www.google.com/search?q="
    + encodeURIComponent (input.value)

googleA.textContent <- "Google"

googleListItem.appendChild (googleA) |> ignore
duckbar.appendChild (googleListItem) |> ignore
