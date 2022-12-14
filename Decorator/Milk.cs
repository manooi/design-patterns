namespace Decorator;

public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage)
    {
         Beverage = beverage;
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Milk";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + 1.25m;
    }
}