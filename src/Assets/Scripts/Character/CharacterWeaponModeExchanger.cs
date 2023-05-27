using Assets.Scripts.Character.WeaponMode.Builder;
using Assets.Scripts.Contracts;
using Assets.Scripts.Enums;
using System;
using UnityEngine;

namespace Assets.Scripts.Character
{
    public class CharacterWeaponModeExchanger : MonoBehaviour
    {
        [SerializeField] private Character _character;
        [SerializeField] private CharacterWeaponModeType _defaultMode = CharacterWeaponModeType.Empty; 
        [SerializeField] private CharacterWeaponModeType _currentMode;
        [SerializeField] private GameObject _currenctHolder;
        [SerializeField] private GameObject _currenctWeapon;

        public delegate void WeaponChanged(Contracts.Weapon weapon);
        public delegate void HolderChanged(Contracts.Holder holder);

        private bool IsEmpty => _currenctHolder == null;

        public event WeaponChanged OnWeaponChanged;
        public event HolderChanged OnHolderChanged;

        public void SetMode(CharacterWeaponModeType mode)
        {
            if (!IsEmpty)
            {
                Destroy(_currenctHolder.gameObject);
                Destroy(_currenctWeapon.gameObject);
                Destroy(_currenctHolder);
                Destroy(_currenctWeapon);
            }

            var modeBuilder = new CharacterWeaponModeBuilder();

            var directorCreator = GetDirectorWeaponModeByType(mode);
            var director = directorCreator(modeBuilder);
            director?.Build();

            var weaponMode = modeBuilder.GetMode();

            var holder = Instantiate(weaponMode.Holder, _character.HolderPoint.position, Quaternion.identity, _character.HolderPoint);
            _currenctHolder = holder.gameObject;

            Contracts.Weapon weapon = null;

            if (weaponMode.Weapon)
            {
                weapon = Instantiate(weaponMode.Weapon, new Vector3(0, 0, 0), Quaternion.identity, holder.WeaponPoint);
                weapon.transform.localPosition = new Vector3(0, 0, 0);
                _currenctWeapon = weapon.gameObject;
            }

            OnWeaponChanged?.Invoke(weapon);
            OnHolderChanged?.Invoke(holder);
        }

        private void Start()
        {
            SetMode(_defaultMode);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                SetMode(CharacterWeaponModeType.Main);
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                SetMode(CharacterWeaponModeType.Second);
            }
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                SetMode(CharacterWeaponModeType.Empty);
            }
        }

        private Func<CharacterWeaponModeBuilder, ICharacterWeaponModeDirector> GetDirectorWeaponModeByType(CharacterWeaponModeType mode)
        {
            switch (mode)
            {
                case CharacterWeaponModeType.Main: return (CharacterWeaponModeBuilder builder) => new CharacterWeaponModeAk47Director(builder);
                case CharacterWeaponModeType.Second: return (CharacterWeaponModeBuilder builder) => new CharacterWeaponModeMakarovDirector(builder);
                default: return (CharacterWeaponModeBuilder builder) => new CharacterWeaponModeBareHandsDirector(builder);
            }
        }
    }
}