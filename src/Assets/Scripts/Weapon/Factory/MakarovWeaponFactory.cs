using Assets.Scripts.Common;
using Assets.Scripts.Contracts;

namespace Assets.Scripts.Weapon.Factory
{
    public class MakarovWeaponFactory : WeaponFactory
    {
        public override Contracts.Weapon CreateWeapon()
        {
            return WeaponPrefabs.Initialize().Makarov;
        }
    }
}