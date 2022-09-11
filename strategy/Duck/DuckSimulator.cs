using System;
namespace Strategy.Duck
{
    public class DuckSimulator
    {
        public static void Main()
        {
            var mallarduck = new MallarDuck();
            mallarduck.Display();
            mallarduck.PerformFly();
            mallarduck.PerformQuack();
            mallarduck.Swim();

            Console.WriteLine("-------");
            var modelDuck = new ModelDuck();
            modelDuck.Display();
            modelDuck.PerformFly();

            modelDuck.FlyBehavior = new FlyRocketPowered();

            modelDuck.PerformFly();

            Console.WriteLine("-------");
            var mimic = new MimicDuck();
            mimic.PlaySound();
        }
    }
}