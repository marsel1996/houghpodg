using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public abstract class UnitHealth : Unit, IHealthable
    {
        [SerializeField] private float _health;
        [SerializeField] private float _currentHealth;
        [SerializeField] protected HealthBar _healthBar;

        public float Health => _health;
        public float CurrentHealth => _currentHealth;
        public HealthBar HealthBar => _healthBar;

        public event IHealthable.HealthChanged OnHealthChanged;

        public abstract void Die();

        public override void Remove(bool withGameObject = false)
        {
            _healthBar.Remove(true);
            base.Remove();
        }

        public void AddCurrentHealth(float value)
        {
            _currentHealth += value;

            if (_currentHealth <= 0)
            {
                Debug.Log("Кажется пора умерать");
                Die();
                return;
            }

            OnHealthChanged?.Invoke();
        }

        public void SetHealthBar(HealthBar healthBar)
        {
            _healthBar = healthBar;
        }
    }
}