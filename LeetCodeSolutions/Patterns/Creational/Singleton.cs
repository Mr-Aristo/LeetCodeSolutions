namespace LeetCodeSolutions.Patterns.Creational;

public sealed class Singleton //Better implementation 
{
    private static readonly Lazy<Singleton> _instance = // Lazy is a class which creates objects when needed. Lazy loading. 
        new Lazy<Singleton> (()=> new Singleton());     //Lazy provides thread safety.

    public static Singleton Instance => _instance.Value; 

    private Singletom(){}

    public void DoSomething()
    {
        Console.WriteLine("Singeleton instance using");

    }

    //Example usage;
    // Singleton.Instance.DoSomething();

}

//Another example without Lazy

public class Singleton2 
{
    private static Singleton2 _instance; 

    private Singleton2(){}

    public static Singleton Instance 
    {
        get
        {
            if(_instance is null)
                _instance = new Singleton2();

            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton Instance using");
    }

    //Example usage
    // Singleton2 instance = Singleton2.Instance;
    // instance.DoSomethign();
    // Singleton2 instance2 = Singleton2.Instance;
    // instance2.DoSomething();
    //Console.WriteLine(Object.ReferanceEquals(instance, instance2)); // output: true

}

/*
 Purpose : A class can have only one instance
 Usage   : Logs, Configuration Management
 Example : ConfogurationManager 
*/