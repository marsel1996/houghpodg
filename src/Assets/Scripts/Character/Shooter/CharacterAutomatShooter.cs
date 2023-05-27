using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Character.Shooter
{
    public class CharacterAutomatShooter : CharacterShooter
    {
        private float _timer = 0;
        private AutomaticGun _automaticWeapon => Weapon as AutomaticGun;

        private void Update()
        {
            if (Input.GetButton("Fire1"))
            {
                if (_timer <= 0)
                {
                    _automaticWeapon.Attack();
                    _timer = _automaticWeapon.Delay;
                }
                else
                {
                    _timer -= Time.deltaTime;
                }
            }
        }
    }
}