using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Common
{
    public class HealthBar : Unit
    {
        [SerializeField] private UnitHealth _target;
        [SerializeField] private Text _textShower;
        [SerializeField] private Image _currentShower;
        [SerializeField] private Transform _point;
        private Transform _transform;

        public Transform Point
        {
            get => _point;
            set => _point = value;
        }

        public UnitHealth Target
        {
            get => _target;
            set => _target = value;
        }

        private void Awake()
        {
            _transform = transform;
        }

        private void Start() => UpdateHealthBar();

        private void OnEnable() => _target.OnHealthChanged += UpdateHealthBar;

        private void OnDisable() => _target.OnHealthChanged -= UpdateHealthBar;

        private void UpdateHealthBar()
        {
            var totalHealth = _target.Health;
            var currentHealth = _target.CurrentHealth;

            _textShower.text = $"<b>{currentHealth}</b> / <b>{totalHealth}</b>";
            _currentShower.fillAmount = currentHealth / totalHealth;
        }

        private void Update()
        {
            _transform.position = _point.position;
        }
    }
}