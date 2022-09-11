namespace Decorator.Beverage.Condiments 
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description { get => _beverage.Description + " " + "Milk";}
        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }

}
