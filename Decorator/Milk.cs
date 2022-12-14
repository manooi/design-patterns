namespace Decorator;

public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage): base(beverage)
    {
        
    }

    public override string GetDescription()
    {
        return base.Beverage.GetDescription() + ", Milk";
    }

    public override decimal Cost()
    {
        return base.Beverage.Cost() + 1.25m;
    }
}