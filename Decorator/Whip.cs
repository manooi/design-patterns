namespace Decorator;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override string GetDescription()
    {
        return Beverage.GetDescription() + ", Whip";
    }

    public override decimal Cost()
    {
        return Beverage.Cost() + 0.5m;
    }
}