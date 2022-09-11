
using Decorator.Beverage;
using Decorator.Beverage.Condiments;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Beverage beverage = new Expresso();

Console.WriteLine($"{ beverage.Description } ${ beverage.Cost() }");

Beverage beverage1 = new DarkRoast();
beverage1 = new Milk(beverage1);
beverage1 = new Mocha(beverage1);
beverage1 = new Mocha(beverage1);
beverage1 = new Wip(beverage1);

Console.WriteLine($"{ beverage1.Description } ${ beverage1.Cost() }");

Beverage baverage2 = new DarkRoast();
baverage2 = new Mocha(baverage2);
baverage2 = new Mocha(baverage2);
baverage2 = new Milk(baverage2);
baverage2 = new Wip(baverage2);

Console.WriteLine($"{ baverage2.Description } ${ baverage2.Cost() }");
