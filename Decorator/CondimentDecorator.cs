namespace Decorator;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage;

    public CondimentDecorator(Beverage beverage)
    {
        Beverage = beverage;
    }

    public abstract override string GetDescription();

}