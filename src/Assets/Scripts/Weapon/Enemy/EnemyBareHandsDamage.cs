using Assets.Scripts.Common;
using Assets.Scripts.Contracts;
using Assets.Scripts.Weapon.Bullet;
using UnityEngine;

namespace Assets.Scripts.Weapon.Enemy
{
    public class EnemyBareHandsDamage : UnitCauseDamage
    {
        [SerializeField] private Collider2D _zone;
        [SerializeField] private float _delay;
        private float _timer = 0;

        public Collider2D Zone => _zone;

        private void Awake()
        {
            SetValue(2);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var unit = collision.GetComponent<UnitDamagable>();
            if (unit && unit is Character.CharacterDamagable)
            {
                _timer = _delay;
                Damage(unit);
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (_timer > 0)
            {
                _timer -= Time.deltaTime;
                return;
            }

            var unit = collision.GetComponent<UnitDamagable>();
            if (unit && unit is Character.CharacterDamagable)
            {
                _timer = _delay;
                Damage(unit);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            _timer = 0;
        }

        public void Damage(UnitDamagable unit)
        {
            var damage = new GetDamage(this);
            unit.Damage(damage);
        }
    }
}