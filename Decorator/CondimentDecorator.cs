namespace Decorator;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage;
    
    public new abstract string GetDescription();
}