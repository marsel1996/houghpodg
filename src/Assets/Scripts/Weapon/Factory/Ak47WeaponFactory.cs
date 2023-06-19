using Assets.Scripts.Common.Factory;
using Assets.Scripts.Contracts;

namespace Assets.Scripts.Weapon.Factory
{
    public class Ak47WeaponFactory : WeaponFactory
    {
        public override Contracts.Weapon CreateWeapon()
        {
            return CharacterWeaponPrefabs.Initialize().Ak47;
        }
    }
}