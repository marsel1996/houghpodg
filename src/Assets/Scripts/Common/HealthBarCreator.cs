using UnityEngine;

namespace Assets.Scripts.Common
{
    public class HealthBarCreator : Unit
    {
        [SerializeField] private HealthBar _healthBarPrefab;
        [SerializeField] private Transform _healthBarPoint;
        [SerializeField] private UnitHealth _target;

        private void Awake()
        {
            var prefab = _healthBarPrefab;
            prefab.Point = _healthBarPoint;
            prefab.Target = _target;
            var healthBar = Instantiate(prefab);
            _target.SetHealthBar(healthBar);
        }
    }
}