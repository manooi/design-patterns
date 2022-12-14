namespace Decorator;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }

    public override decimal Cost()
    {
        return 2m;
    }
}