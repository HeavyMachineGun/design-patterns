namespace Strategy.Weapon
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Axe Atack!!!");
        }
    }
}