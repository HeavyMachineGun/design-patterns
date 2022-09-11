namespace Decorator.Beverage
{
    public  class Expresso : Beverage
    {
        public override string Description { get => "Expresso"; set => base.Description = value; }
        public override double Cost()
        {
            return .99;
        } 
    }
}