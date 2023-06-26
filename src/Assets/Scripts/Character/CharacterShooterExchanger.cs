using Assets.Scripts.Common;
using Assets.Scripts.Contracts;
using System;
using UnityEngine;

namespace Assets.Scripts.Character.Shooter
{
    public class CharacterShooterExchanger : Unit
    {
        [SerializeField] private Character _character;
        [SerializeField] private CharacterWeaponModeExchanger _weaponMode;
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

            if (_currentShooter != null)
            {
                _currentShooter.Weapon = weapon;
            }
        }

        private void SetCurrentShooter(Type shooterType)
        {
            if (shooterType == null)
            {
                _currentShooter?.Remove();
                _currentShooter = null;
                return;
            }

            var notNeedChange = (_currentShooter is CharacterAutomatShooter && shooterType == typeof(CharacterAutomatShooter)) ||
                (_currentShooter is CharacterCommonShooter && shooterType == typeof(CharacterCommonShooter));

            if (notNeedChange) return;

            _currentShooter?.Remove();
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