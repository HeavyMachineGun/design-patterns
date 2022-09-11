namespace Strategy.Weapon
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Bow And Arrow Atack!!!");
        }
    }
}