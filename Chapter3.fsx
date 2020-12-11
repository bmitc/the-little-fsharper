type Pizza = Crust
            | Cheese of Pizza
            | Onion of Pizza
            | Anchovy of Pizza
            | Sausage of Pizza

let line2 = Anchovy(Onion(Anchovy(Anchovy(Cheese(Crust)))))

let rec removeAnchovy = function
    | Crust      -> Crust
    | Cheese(x)  -> Cheese(removeAnchovy(x))
    | Onion(x)   -> Onion(removeAnchovy(x))
    | Anchovy(x) -> removeAnchovy(x)
    | Sausage(x) -> Sausage(removeAnchovy(x))

let rec topAnchovyWithCheese = function
    | Crust      -> Crust
    | Cheese(x)  -> Cheese(topAnchovyWithCheese(x))
    | Onion(x)   -> Onion(topAnchovyWithCheese(x))
    | Anchovy(x) -> Cheese(Anchovy(topAnchovyWithCheese(x)))
    | Sausage(x) -> Sausage(topAnchovyWithCheese(x))

let line36 = topAnchovyWithCheese(Onion(Anchovy(Cheese(Anchovy(Crust)))))

let line37 = topAnchovyWithCheese(Onion(Cheese(Sausage(Crust))))

let line45 = topAnchovyWithCheese(removeAnchovy(Onion(Anchovy(Cheese(Anchovy(Crust))))))

let line46 = removeAnchovy(topAnchovyWithCheese(Onion(Anchovy(Cheese(Anchovy(Crust))))))

let substAnchovyByCheese1 x = removeAnchovy(topAnchovyWithCheese x)

let substAnchovyByCheese2 x = topAnchovyWithCheese x |> removeAnchovy

let rec substAnchovyByCheese = function
    | Crust      -> Crust
    | Cheese(x)  -> Cheese(substAnchovyByCheese(x))
    | Onion(x)   -> Onion(substAnchovyByCheese(x))
    | Anchovy(x) -> Cheese(substAnchovyByCheese(x))
    | Sausage(x) -> Sausage(substAnchovyByCheese(x))

(*The Third Moral
  Functions that produce values of a type must use the
  associated constructors to build data of that type.*)