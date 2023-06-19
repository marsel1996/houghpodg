using Assets.Scripts.Contracts;

namespace Assets.Scripts.Common
{
    public class CharacterDamagable : UnitDamagable
    {
        public override void Damage(IDamageVisiter visiter)
        {
            visiter.Visit(this);
        }
    }
}