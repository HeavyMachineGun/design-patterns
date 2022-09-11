using System;
namespace Strategy.Duck.Behaviors
{
    public class FlyNoWay: IFlyBehavior
    {
        public void fly(){
            Console.WriteLine("I can't fly");      
        }
    }    
}