namespace Decorator;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage): base(beverage)
    {
        
    }

    public override string GetDescription()
    {
        return base.Beverage.GetDescription() + ", Whip";
    }

    public override decimal Cost()
    {
        return base.Beverage.Cost() + 0.5m;
    }
}