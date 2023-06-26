using Assets.Scripts.Common;

namespace Assets.Scripts.Contracts
{
    public abstract class CharacterShooter : Unit
    {
        public Weapon Weapon { get; set; }
    }
}