using System;
using Strategy.Duck.Behaviors;
namespace Strategy.Duck
{
    public class MimicDuck
    {
        public MimicDuck()
        {
            _quackBehavior = new MimicQuack();
        }
        IQuackBehavior _quackBehavior;
    
        public void PlaySound()
        {
            _quackBehavior.quack();
        }
    }
}