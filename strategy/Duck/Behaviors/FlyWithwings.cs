using System;
namespace Strategy.Duck.Behaviors
{
    public class FlyWithWings: IFlyBehavior
    {
        public void fly(){
            Console.WriteLine("I'm flying with wings");      
        }
    }    
}