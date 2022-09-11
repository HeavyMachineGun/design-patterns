namespace Decorator.Beverage
{
    public  class HosuseBlend : Beverage
    {
        public override string Description { get => "Hause Blend"; set => base.Description = value; }
        public  override double Cost()
        {
            return .89;
        } 
    }
}