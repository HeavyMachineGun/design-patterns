using System;
using Strategy.Duck.Behaviors;
namespace Strategy.Duck
{
    public abstract class Duck
    {
        protected IFlyBehavior? _flyBehavior;
        public IFlyBehavior FlyBehavior 
        {
            set 
            {
                _flyBehavior= value;
            }
        }

        protected IQuackBehavior? _quackBehavior;
        
        public IQuackBehavior QuackBehavior 
        {
            set 
            {
                _quackBehavior= value;
            }
        }
        public Duck()
        {
        }
        public virtual void PerformFly()
        {
            _flyBehavior?.fly();
        }
        public virtual  void PerformQuack()
        {
            _quackBehavior?.quack();
        }

        public virtual void Swim(){
            Console.WriteLine("All ducks swim");
        }
        public abstract void Display();
    }
}