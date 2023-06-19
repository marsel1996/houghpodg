using Assets.Scripts.Common;
using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class EnemyDamagable : UnitDamagable
    {
        [SerializeField] private EnemyHealth _health;

        public EnemyHealth Health => _health;

        public override void Damage(IDamageVisiter visiter)
        {
            visiter.Visit(this);
        }
    }
}