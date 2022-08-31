/// Contains common types that are shared across the chapters of The Littler MLer
module CommonTypes

/// From Chapter 1
type Num =
    | Zero
    | OneMoreThan of Num

/// From Chapter 3
type Pizza =
    | Crust
    | Cheese  of Pizza
    | Onion   of Pizza
    | Anchovy of Pizza
    | Sausage of Pizza