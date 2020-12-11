#load "Chapter1.fsx"

open Chapter1

type ShishKebab = Skewer
                | Onion of ShishKebab
                | Lamb of ShishKebab
                | Tomato of ShishKebab

let rec onlyOnions = function
    | Skewer    -> true
    | Onion(x)  -> onlyOnions(x)
    | Lamb(x)   -> false
    | Tomato(x) -> false

let line25 = onlyOnions(Onion(Onion(Skewer)))

let line43 = onlyOnions(Onion(Lamb(Skewer)))

let line58 = Tomato(Skewer)

let line59 = Onion(Tomato(Skewer))

let line61 = Tomato(Onion(Tomato(Skewer)))

let line62 = Onion(Onion(Onion(Skewer)))

let rec isVegetarian = function
    | Skewer    -> true
    | Onion(x)  -> isVegetarian(x)
    | Lamb(x)   -> false
    | Tomato(x) -> isVegetarian(x)

type 'a Shish = Bottom of 'a
              | Onion of 'a Shish
              | Lamb of 'a Shish
              | Tomato of 'a Shish

type Shish2<'a> = Bottom2 of 'a
                | Onion2 of Shish2<'a>
                | Lamb2 of Shish2<'a>
                | Tomato2 of Shish2<'a>            

type Rod = Dagger
         | Fork
         | Sword

type Plate = GoldPlate
           | SilverPlate
           | BrassPlate

let line69 = Onion(Tomato(Bottom(Dagger)))

let line71 = Onion(Tomato(Bottom(GoldPlate)))

let rec isVeggie = function
    | Bottom(x) -> true
    | Onion(x)  -> isVeggie(x)
    | Lamb(x)   -> false
    | Tomato(x) -> isVeggie(x)

let line76 = isVeggie(Onion(Tomato(Bottom(Dagger))))

let line77 = Onion(Tomato(Bottom(Dagger)))

let line78 = isVeggie(Onion(Tomato(Bottom(GoldPlate))))

let line79 = Onion(Tomato(Bottom(GoldPlate)))

let line85 = isVeggie(Onion(Tomato(Bottom(52))))

let line86 = isVeggie(Onion(Tomato(Bottom(OneMoreThan(Zero)))))

let line87 = isVeggie(Onion(Tomato(Bottom(false))))

let rec whatBottom = function
    | Bottom(x) -> x
    | Onion(x)  -> whatBottom(x)
    | Lamb(x)   -> whatBottom(x)
    | Tomato(x) -> whatBottom(x)

let line99 = whatBottom(Bottom(52))

let line100 = whatBottom(Bottom(Sword))

let line103 = whatBottom(Tomato(Onion(Lamb(Bottom(52)))))

let line104 = whatBottom(Onion(Lamb(Bottom(52))))

let line105 = whatBottom(Lamb(Bottom(52)))

let line106 = whatBottom(Bottom(52))

(*The Second Moral
  The number and order of the patterns in the definition
  of a function should match that of the definition of
  the consumed datatype.*)