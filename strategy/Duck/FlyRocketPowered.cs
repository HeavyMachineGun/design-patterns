using System;
using Strategy.Duck.Behaviors;
namespace Strategy.Duck
{
    public class FlyRocketPowered: IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm Flying by a rocket");
        }
    }
}