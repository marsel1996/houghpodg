using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public abstract class UnitHealth : MonoBehaviour, IHealthable
    {
        [SerializeField] private float _health;
        [SerializeField] private float _currentHealth;

        public float Health => _health;
        public float CurrentHealth => _currentHealth;

        public event IHealthable.HealthChanged OnHealthChanged;

        public void AddCurrentHealth(float value)
        {
            _currentHealth += value;
            OnHealthChanged?.Invoke();
        }
    }
}