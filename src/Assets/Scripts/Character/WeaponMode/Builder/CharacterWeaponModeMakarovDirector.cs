using Assets.Scripts.Contracts;
using Assets.Scripts.Holder.Factory;
using Assets.Scripts.Weapon.Factory;

namespace Assets.Scripts.Character.WeaponMode.Builder
{
    public class CharacterWeaponModeMakarovDirector : ICharacterWeaponModeDirector
    {
        private CharacterWeaponModeBuilder _builder;

        public CharacterWeaponModeMakarovDirector(CharacterWeaponModeBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            var holderFactory = new WithPistolHolderFactory();
            var weaponFactory = new MakarovWeaponFactory();

            _builder
                .AddHolder(holderFactory.CreateHolder())
                .AddWeapon(weaponFactory.CreateWeapon());
        }
    }
}