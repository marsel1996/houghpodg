using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public class EnemyHealth : UnitHealth
    {
        [SerializeField] private Contracts.Enemy _enemy;

        public override void Die()
        {
            _enemy.Die();
            Destroy(_healthBar.gameObject);
            Destroy(_enemy.GetComponent<EnemyDamagable>());
            Invoke(nameof(Death), 2f);
        }

        private void Death()
        {
            Destroy(gameObject);
        }
    }
}