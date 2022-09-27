namespace Decorator.Beverage.Condiments
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage ?? throw new NullReferenceException();
        }
        public override string Description { get => _beverage.Description + " " + "Soy";}
        public override double Cost()
        {
            double cost = _beverage.Cost();
            if(BeverageSize == Size.TALL){
                cost += .10;
            }
            if(BeverageSize == Size.GRANDE){
                cost += .15;
            }
            if(BeverageSize == Size.VENTI){
                cost += .20;
            }
            return cost;
        }
    }

}
