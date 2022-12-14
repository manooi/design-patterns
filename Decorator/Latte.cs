namespace Decorator;

public class Latte : Beverage
{
    public Latte()
    {
        Description = "Latte";
    }

    public override decimal Cost()
    {
        return 2.25m;
    }
}