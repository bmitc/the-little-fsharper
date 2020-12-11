//https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/discriminated-unions

type Seasoning = Salt
               | Pepper

type Num = Zero
         | OneMoreThan of Num

//https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/fsharp-types

type 'a OpenFacedSandwich = Bread of 'a
                          | Slice of 'a OpenFacedSandwich

type OpenFacedSandwich2<'a> = Bread2 of 'a
                            | Slice2 of OpenFacedSandwich2<'a>

let line17 = Salt

let line18 = Pepper

let line22 = Zero

let line23 = OneMoreThan(Zero)

let line25 = OneMoreThan(OneMoreThan(Zero))

let line27 = OneMoreThan(OneMoreThan(OneMoreThan(OneMoreThan(Zero))))

let line33 = Bread 0

let line34 = Bread true

let line42 = Bread 0

let line44 = Bread true

let line45 = Bread(OneMoreThan(Zero))

let line46 = Bread(Bread(0))

let line47 = Bread(Bread(OneMoreThan(Zero)))

(*The First Moral
  Use type to describe types. When a type contains lots of
  values, the type definition refers to itself. Use 'a with
  type to define shapes.*)