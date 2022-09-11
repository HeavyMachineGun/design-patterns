using System;
using Strategy.Weapon;

namespace Strategy.AdventureGame
{
    public class Troll : Character
    {
        public Troll()
        {
            _weapon = new BowAndArrowBehavior();
        }

        public override void Fight(){
            Console.WriteLine("Troll atack!!!");
        }

    }
}