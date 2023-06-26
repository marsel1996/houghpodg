using Assets.Scripts.Common;
using Assets.Scripts.Enemy;
using UnityEngine;

namespace Assets.Scripts.Weapon.Bullet
{
    public class CommonBullet : Contracts.Bullet
    {
        private void Awake()
        {
            SetValue(3);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var unit = collision.GetComponent<UnitDamagable>();
            if (unit && unit is EnemyDamagable)
            {
                Damage(unit);
            }
        }
    }
}