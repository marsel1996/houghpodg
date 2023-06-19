using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Character.Shooter
{
    public class CharacterCommonShooter : CharacterShooter
    {
        private CommonGun _commonWeapon => Weapon as CommonGun;

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                _commonWeapon.Attack(Character);
            }
        }
    }
}