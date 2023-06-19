using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Weapon.Bullet
{
    public class CommonBullet : Contracts.Bullet
    {
        private void Awake()
        {
            SetValue(2);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            print("Enter bullet");
            var unit = collision.GetComponent<UnitDamagable>();
            if (unit)
            {
                var damage = new GetDamage(this);
                unit.Damage(damage);
                Destroy(gameObject);
            }
        }
    }
}