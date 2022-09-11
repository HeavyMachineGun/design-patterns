namespace Decorator.Beverage.Condiments
{
    public class Wip : CondimentDecorator
    {
        public Wip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description { get => _beverage.Description + " " + "Wip";}
        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }

}
