namespace Decorator.Beverage
{
    public  class DarkRoast : Beverage
    {
        public override string Description { get => "Dark Roast"; set => base.Description = value; }
        public override double Cost()
        {
            return .99;
        } 
    }
}