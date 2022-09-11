using System;
using Strategy.Duck.Behaviors;
namespace Strategy.Duck
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior= new Quack();
        }
        public override void Display()
        {
            Console.WriteLine($"I'm a Model Duck fellas..");
        }
    }
}