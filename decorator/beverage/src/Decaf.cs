namespace Decorator.Beverage
{
    public  class Decaf : Beverage
    {
        public override string Description { get => "Decaf"; set => base.Description = value; }
        public override double Cost()
        {
            return 1.55;
        } 
    }
}