namespace Decorator.Beverage
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; }
        public abstract double Cost(); 
    }
}