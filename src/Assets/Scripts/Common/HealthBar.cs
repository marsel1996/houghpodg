using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Common
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private UnitHealth _target;
        [SerializeField] private Text _textShower;
        [SerializeField] private Image _currentShower;

        private void Start() => UpdateHealthBar();

        private void OnEnable() => _target.OnHealthChanged += UpdateHealthBar;

        private void OnDisable() => _target.OnHealthChanged -= UpdateHealthBar;

        private void UpdateHealthBar()
        {
            var totalHealth = _target.Health;
            var currentHealth = _target.CurrentHealth;

            if (currentHealth <= 0)
            {
                Debug.Log("Кажется пора умерать");
                return;
            }

            _textShower.text = $"<b>{currentHealth}</b> / <b>{totalHealth}</b>";
            _currentShower.fillAmount = currentHealth / totalHealth;
        }
    }
}