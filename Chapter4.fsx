type Meza = Shrimp
          | Calamari
          | Escargots
          | Hummus

type Main = Steak
          | Ravioli
          | Chicken
          | Eggplant

type Salad = Green
           | Cucumber
           | Greek

type Dessert = Sundae
             | Mousse
             | Torte

let line9 = (Calamari, Ravioli, Greek, Sundae)

let line11 = (Hummus, Steak, Green, Torte)

let line12 = (Torte, Hummus, Steak, Sundae)

let line18 = (Shrimp, Sundae)

let addASteak x = (x, Steak)

let line28 = addASteak(Escargots)

let line29 = addASteak(5)

let eqMain = function
    | (Steak, Steak)       -> true
    | (Ravioli, Ravioli)   -> true
    | (Chicken, Chicken)   -> true
    | (Eggplant, Eggplant) -> true
    | (aMain, anotherMain) -> false

//https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/pattern-matching#wildcard-pattern

let eqMain = function
    | (Steak, Steak)       -> true
    | (Ravioli, Ravioli)   -> true
    | (Chicken, Chicken)   -> true
    | (Eggplant, Eggplant) -> true
    | _                    -> false

let hasSteak = function
    | (aMeza, Steak, aDessert) -> true
    | (aMeza, aMain, aDessert) -> false

let hasSteak2 = function
    | (aMeza, Steak, aDessert) -> true
    | _                        -> false

let line48 = hasSteak(Hummus, Ravioli, Sundae)

let line49 = hasSteak(Shrimp, Steak, Mousse)

let line56 = hasSteak(5, Steak, true)

//https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/functions/#parameters

let hasSteak3 (m : Meza, s : Main, d : Dessert) = function
    | (m, Steak, d) -> true
    | _             -> false

let addASteak2 (x : Meza) = (x, Steak)

(*Some functions consume values of star type;
  some produce values of star type.*)