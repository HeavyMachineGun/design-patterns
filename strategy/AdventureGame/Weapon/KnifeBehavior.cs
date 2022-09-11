namespace Strategy.Weapon
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Knife Atack!!!");
        }
    }
}