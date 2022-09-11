using System;
using Strategy.Weapon;

namespace Strategy.AdventureGame
{
    public class Knight : Character
    {
        public Knight()
        {
            _weapon = new AxeBehavior();
        }

        public override void Fight(){
            Console.WriteLine("Knight atack!!!");
        }

    }
}