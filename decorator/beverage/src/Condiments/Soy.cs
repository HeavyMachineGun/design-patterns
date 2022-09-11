namespace Decorator.Beverage.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description { get => _beverage.Description + " " + "Soy";}
        public override double Cost()
        {
            return _beverage.Cost() + .15;
        }
    }

}
