namespace Decorator;

public abstract class Beverage
{
    public Beverage()
    {
    }
    public abstract string GetDescription();

    public abstract decimal Cost();
}