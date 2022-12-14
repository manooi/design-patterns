namespace Decorator;

public class Espresso : Beverage
{
    public override string GetDescription()
    {
        return "Espresso";
    }

    public override decimal Cost()
    {
        return 2m;
    }
}