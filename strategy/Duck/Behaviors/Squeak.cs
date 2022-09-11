using System;
namespace Strategy.Duck.Behaviors
{
    public class Squeak: IQuackBehavior
    {
        public void quack(){
            Console.WriteLine("Squeak !!!");      
        }
    }    
}