using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Weapon.Bullet
{
    public class CommonEnemyBullet : Contracts.Bullet
    {
        private void Awake()
        {
            SetValue(2);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var unit = collision.GetComponent<UnitDamagable>();
            if (unit && unit is Character.CharacterDamagable)
            {
                Damage(unit);
            }
        }
    }
}