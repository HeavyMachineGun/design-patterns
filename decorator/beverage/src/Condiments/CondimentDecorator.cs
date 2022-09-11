using Decorator.Beverage;
namespace Decorator.Beverage.Condiments 
{
    public class CondimentDecorator : Beverage
    {
        protected Beverage? _beverage { get; set; }
        public override string? Description { get => "Some condiment";}

        public override double Cost()
        {
            return 0.0;
        }
        
    }

}
