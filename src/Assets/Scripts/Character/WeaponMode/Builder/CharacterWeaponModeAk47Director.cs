using Assets.Scripts.Contracts;
using Assets.Scripts.Holder.Factory;
using Assets.Scripts.Weapon.Factory;

namespace Assets.Scripts.Character.WeaponMode.Builder
{
    public class CharacterWeaponModeAk47Director : ICharacterWeaponModeDirector
    {
        private CharacterWeaponModeBuilder _builder;

        public CharacterWeaponModeAk47Director(CharacterWeaponModeBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            var holderFactory = new WithAutomatHolderFactory();
            var weaponFactory = new Ak47WeaponFactory();

            _builder
                .AddHolder(holderFactory.CreateHolder())
                .AddWeapon(weaponFactory.CreateWeapon());
        }
    }
}