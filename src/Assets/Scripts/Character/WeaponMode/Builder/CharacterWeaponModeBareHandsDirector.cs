using Assets.Scripts.Contracts;
using Assets.Scripts.Holder.Factory;

namespace Assets.Scripts.Character.WeaponMode.Builder
{
    public class CharacterWeaponModeBareHandsDirector : ICharacterWeaponModeDirector
    {
        private CharacterWeaponModeBuilder _builder;

        public CharacterWeaponModeBareHandsDirector(CharacterWeaponModeBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            var holderFactory = new EmptyHolderFactory();

            _builder
                .AddHolder(holderFactory.CreateHolder());
        }
    }
}