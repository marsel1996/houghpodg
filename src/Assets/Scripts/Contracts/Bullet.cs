using Assets.Scripts.Common;
using Assets.Scripts.Weapon.Bullet;
using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class Bullet : UnitCauseDamage
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _flyTime;

        public float Speed => _speed;
        public float FlyTime => _flyTime;

        public void Damage(UnitDamagable unit)
        {
            var damage = new GetDamage(this);
            unit.Damage(damage);
            Remove(true);
        }
    }
}