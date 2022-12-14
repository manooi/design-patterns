using Decorator;

Beverage beverage1 = new Espresso();
beverage1 = new Whip(beverage1);
beverage1 = new Milk(beverage1);
Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.Cost()}");

Beverage beverage2 = new Latte();
beverage2 = new Whip(beverage2);
Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");