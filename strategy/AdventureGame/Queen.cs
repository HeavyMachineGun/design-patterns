using System;
using Strategy.Weapon;
namespace Strategy.AdventureGame
{
    public class Queen : Character
    {
        public Queen()
        {
            _weapon = new AxeBehavior();   
        }

        public override void Fight(){
            Console.WriteLine("Queen atack!!!");
        }

    }
}