type Customer = string
type Ingredient = string
type Order = {
    Customer: Customer
    Base: Ingredient
    Protein: Ingredient
    Dips: Ingredient list
    Toppings: Ingredient list
    Dressing: Ingredient list
}

let sampleOrder = {
    Customer = "Lester"
    Base = "Grain Bowl"
    Protein = "Lamb"
    Dips = ["Harissa"]
    Toppings = ["Olives"; "Feta"]
    Dressing = ["Herb Tahini"]
}