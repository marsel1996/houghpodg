using Assets.Scripts.Common;
using Assets.Scripts.Contracts;

namespace Assets.Scripts.Weapon.Factory
{
    public class Ak47WeaponFactory : WeaponFactory
    {
        public override Contracts.Weapon CreateWeapon()
        {
            return WeaponPrefabs.Initialize().Ak47;
        }
    }
}