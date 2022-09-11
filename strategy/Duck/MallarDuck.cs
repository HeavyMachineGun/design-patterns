using System;
using Strategy.Duck.Behaviors;
namespace Strategy.Duck
{
    public class MallarDuck: Duck
    {
        public MallarDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior= new Quack();
        }
        public override void Display()
        {
            Console.WriteLine($"I'm a Mallar Duck fellas..");
        }
    }
}