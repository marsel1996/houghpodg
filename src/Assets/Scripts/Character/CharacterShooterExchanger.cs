using Assets.Scripts.Contracts;
using System;
using UnityEngine;

namespace Assets.Scripts.Character.Shooter
{
    public class CharacterShooterExchanger : MonoBehaviour
    {
        [SerializeField] private Character _character;
        [SerializeField] private CharacterWeaponModeExchanger _weaponMode;
        [SerializeField] private Contracts.Weapon _weapon;
        [SerializeField] private CharacterShooter _currentShooter;

        private void OnEnable()
        {
            _weaponMode.OnWeaponChanged += WeaponChanged;
        }

        private void OnDisable()
        {
            _weaponMode.OnWeaponChanged -= WeaponChanged;
        }

        private void WeaponChanged(Contracts.Weapon weapon)
        {
            var shooterType = GetShooterComponentByWeapon(weapon);
            SetCurrentShooter(shooterType);

            _weapon = weapon;
            if (_currentShooter)
            {
                _currentShooter.Weapon = weapon;
            }
        }

        private void SetCurrentShooter(Type shooterType)
        {
            if (shooterType == null)
            {
                Destroy(_currentShooter);
                return;
            }

            var notNeedChange = (_currentShooter is CharacterAutomatShooter && shooterType == typeof(CharacterAutomatShooter)) ||
                (_currentShooter is CharacterCommonShooter && shooterType == typeof(CharacterCommonShooter));

            if (notNeedChange) return;

            Destroy(_currentShooter);
            var shooterComponent = _character.gameObject.AddComponent(shooterType) as CharacterShooter;
            _currentShooter = shooterComponent;
        }

        private Type GetShooterComponentByWeapon(Contracts.Weapon weapon)
        {
            if (weapon is AutomaticGun)
            {
                return typeof(CharacterAutomatShooter);
            }
            else if (weapon is CommonGun)
            {
                return typeof(CharacterCommonShooter);
            }
            return null;
        }
    }
}