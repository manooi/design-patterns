namespace Decorator;

public abstract class Beverage
{
    protected string Description = "Unknown Beverage";
    
    public Beverage()
    {
    }
    
    public string GetDescription()
    {
        return Description;
    }

    public abstract decimal Cost();
}