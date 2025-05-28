
namespace LeetCodeSolutions.Patterns.Creational;

//Product Families
public interface IButton{ void Render(); }
public interface ICheckBox { void Render(); }

//Concrete Products
public class WinButton : IButton { public void Render() => Console.WriteLine("Win Button drawn"); }
public class MacButtom : IButton { public void Render() => Console.WriteLine("Mac Button drawn"); }

public class WinCheckBox : IButton { public void Render() => Console.WriteLine("Win Checkbox drawm");}
public class MacCheckBox : IButton { public void Render() => Console.WriteLine("Mac Checkbox drawm");}


//Abstract Factory
public interface IWidgetFactory
{
    public IButton CreateButton();
    public ICheckBox CreateCheckBox();
}

public class WinFactory : IWidgetFactory 
{
    IButton CreateButton() => new WinButton();
    ICheckBox CreateCheckBox() => new WinCheckBox();

}

public class MacFactory : IWidgetFactory 
{
    public IButton CreateButton() => new MacButton();
    public ICheckBox CreateCheckBox() => new MacCheckBox();
}


//Example Usage: Assuming that in any class we have function like
void RenderUI(IWidgetFactory factory)
{
    var button = factory.CreateButton();
    var checkbox = factory.CreateCheckBox();

    button.Render();
    checkbox.Render();
}

// Then we are sending parameters to RenderUI Function
RenderUI(new WinFactory());//Win and Mac factorey implements IWidgetFactory. That is why we can send as type IWidgetFactory
RenderUI(new MacFactory());

/*
    Purpose : Creates object families which have relation with each other. 
    Usage   : When we have diffirent product families. 
    Example : For produce diffirent UI components (Windows, MacOs, Web)
*/