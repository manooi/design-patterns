namespace Decorator;

public class Latte : Beverage
{
    public override string GetDescription()
    {
        return "Latte";
    }

    public override decimal Cost()
    {
        return 2.25m;
    }
}