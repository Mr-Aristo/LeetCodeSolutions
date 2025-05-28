namespace LeetCodeSolutions.Patterns.Creational;
// Complex Product 
public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }
    public override string ToString() => $"{Dough}, {Sauce}, {Topping}";
}


public interface IPizzaBuilder
{
    void BuildDough();
    void BuildSauce();
    void BuildTopping();
    Pizza GetPizza();
}

// Concrete Builder
public class MargheritaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza();
    public void BuildDough() => _pizza.Dough = "Classic";
    public void BuildSauce() => _pizza.Sauce = "Tomato";
    public void BuildTopping() => _pizza.Topping = "Cheese";
    public Pizza GetPizza() => _pizza;
}

// Director
public class PizzaDirector
{
    public Pizza MakePizza(IPizzaBuilder builder)
    {
        builder.BuildDough();
        builder.BuildSauce();
        builder.BuildTopping();
        return builder.GetPizza();
    }
}

// Example Usage: 
var director = new PizzaDirector();
var margherita = director.MakePizza(new MargheritaBuilder());
Console.WriteLine(margherita); // Classic, Tomato, Cheese


/*
    Purpose : Creates complext objects step by step.
    Usage   : Complex structs exp. query creating, JSON configuration
    Example : SQL queries and creating reports
*/