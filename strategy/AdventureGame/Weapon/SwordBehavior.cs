namespace Strategy.Weapon
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Sword Atack!!!");
        }
    }
}