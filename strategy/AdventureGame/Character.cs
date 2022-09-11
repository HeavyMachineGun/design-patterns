using Strategy.Weapon;
namespace Strategy.AdventureGame
{
    public abstract class Character
    {
        protected IWeaponBehavior? _weapon;
        public IWeaponBehavior Weapon 
        {
            set
            {
                _weapon = value;
            }
        }
        public void UseWeapon(){
            _weapon?.useWeapon();
        }

        public abstract void Fight();
    }
}