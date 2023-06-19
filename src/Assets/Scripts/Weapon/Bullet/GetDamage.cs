using Assets.Scripts.Common;
using Assets.Scripts.Contracts;
using Assets.Scripts.Enemy;

namespace Assets.Scripts.Weapon.Bullet
{
    public class GetDamage : IDamageVisiter
    {
        private UnitCauseDamage _causeDamage;

        public GetDamage(UnitCauseDamage causeDamage)
        {
            _causeDamage = causeDamage;
        }

        public void Visit(EnemyDamagable unit)
        {
            var damage = _causeDamage.Value * -1;
            unit.Health.AddCurrentHealth(damage);
        }

        public void Visit(CharacterDamagable unit)
        {
        }

        public void Visit(UnitDamagable unit)
        {
            throw new System.Exception("Нет реализации получения урона.");
        }
    }
}