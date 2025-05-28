namespace LeetCodeSolutions.Patterns.Creational;

public interface IProduct
{
    string GetName(); 

}

//Concrete Products 
public class ConcreteProductA : IProduct
{
    public string GetName() => "ProductA";
}

public class ConcereteProductB : IProduct 
{
   public string GetName() => "ProductB";
}

public abstract class Creator 
{
    public abstract IProduct FactoryMethod();

    public void AnOperation()
    {
        var product = FactoryMethod();
        
        Console.WriteLine($"Created : {product.GetName() }");
    }
}

//Concrete Creators
 
public class CreatorA : Creator
{
   public override IProduct FactoryMethod() => new ConcreteProductA(); 
}

public class CreatorB: Creator 
{
    public override IProduct FactoryMethod() => new ConcereteProductB();
}


// Usage:
// new CreatorA.AnOperation();
// new CreatorB.AnOperation();


/*
    Purpose : Decides to subclasses which kind of object they they must create
    Usage   : When need to create diffirent kind of objects
    Example : Diffirent kind of payment method (Paypal, credit card, crypto etc.)
*/