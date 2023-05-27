using Assets.Scripts.Models;

namespace Assets.Scripts.Character.WeaponMode.Builder
{
    public class CharacterWeaponModeBuilder
    {
        private CharacterWeaponMode _mode;

        public CharacterWeaponModeBuilder()
        {
            _mode = new CharacterWeaponMode();
        }

        public CharacterWeaponModeBuilder AddHolder(Contracts.Holder holder)
        {
            _mode.Holder = holder;
            return this;
        }

        public CharacterWeaponModeBuilder AddWeapon(Contracts.Weapon weapon)
        {
            _mode.Weapon = weapon;
            return this;
        }

        public CharacterWeaponMode GetMode()
        {
            CharacterWeaponMode mode = _mode;
            _mode = new CharacterWeaponMode();
            return mode;
        }
    }
}