using System;
namespace Strategy.Duck.Behaviors
{
    public class MimicQuack: IQuackBehavior
    {
        public void quack(){
            Console.WriteLine("Quack!!!");      
        }
    }    
}