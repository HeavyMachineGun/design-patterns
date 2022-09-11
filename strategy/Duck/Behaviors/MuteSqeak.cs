using System;
namespace Strategy.Duck.Behaviors
{
    public class MuteSqueak: IQuackBehavior
    {
        public void quack(){
            Console.WriteLine("Can't Quack!!!");      
        }
    }    
}