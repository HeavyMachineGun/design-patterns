using System;
namespace Strategy.Duck.Behaviors
{
    public class Quack: IQuackBehavior
    {
        public void quack(){
            Console.WriteLine("Quack !!!");      
        }
    }    
}