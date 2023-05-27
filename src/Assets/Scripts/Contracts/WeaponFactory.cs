namespace Assets.Scripts.Contracts
{
    public abstract class WeaponFactory : IWeaponFactory
    {
        public abstract Weapon CreateWeapon();
    }
}
