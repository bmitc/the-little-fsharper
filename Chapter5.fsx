type 'a Pizza = Bottom
              | Topping of ('a * ('a Pizza))
// Note: Parantheses are not needed but help clarify
// and are as they are found in the book.

type Fish = Anchovy
          | Lox
          | Tuna

let line4 = Topping(Anchovy, Topping(Tuna, Topping(Anchovy, Bottom)))

let line5 = Topping(Tuna, Topping(Anchovy, Bottom))

let line6 = Topping(Anchovy, Bottom)

let rec remAnchovy = function
    | Bottom              -> Bottom
    | Topping(Anchovy, p) -> remAnchovy(p)
    | Topping(Tuna, p)    -> Topping(Tuna, remAnchovy(p))
    | Topping(Lox, p)     -> Topping(Lox, remAnchovy(p))

let rec remAnchovy2 = function
    | Bottom              -> Bottom
    | Topping(Anchovy, p) -> remAnchovy2(p)
    | Topping(t, p)       -> Topping(t, remAnchovy2(p))

let rec remTuna = function
    | Bottom              -> Bottom
    | Topping(Anchovy, p) -> Topping(Anchovy, remTuna(p))
    | Topping(Tuna, p)    -> remTuna(p)
    | Topping(Lox, p)     -> Topping(Lox, remTuna(p))

// Line 16 is not true for F#. It's not clear why it's true for SML either.
let rec remTuna2 = function
    | Bottom           -> Bottom
    | Topping(Tuna, p) -> remTuna2(p)
    | Topping(t, p)    -> Topping(t, remTuna2(p))

// Line 18: I think there are some typos in the book at this point.
// The authors did not follow their own advice given the type definition
// in line 3 and the function definition in line 11.