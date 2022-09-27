namespace Decorator.Beverage
{
    public abstract class Beverage
    {
        public Beverage(){
            Description = "Unknown Beverage";
            BeverageSize = Size.TALL;
        }
        public enum Size {TALL, GRANDE, VENTI}

        protected Size BeverageSize {get;set;}
        public virtual string Description { get; set; }
        public abstract double Cost(); 
    }
}