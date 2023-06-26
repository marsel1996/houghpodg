using Assets.Scripts.Character;
using Assets.Scripts.Common;
using Assets.Scripts.Enemy;

namespace Assets.Scripts.Contracts
{
    public interface IDamageVisiter
    {
        public void Visit(UnitDamagable unit);
        public void Visit(EnemyDamagable unit);
        public void Visit(CharacterDamagable unit);
    }
}