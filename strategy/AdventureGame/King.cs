using System;
using Strategy.Weapon;

namespace Strategy.AdventureGame
{
    public class King : Character
    {
        public King()
        {
            _weapon = new KnifeBehavior();
        }

        public override void Fight(){
            Console.WriteLine("King atack!!!");
        }

    }
}