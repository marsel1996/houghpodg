using Assets.Scripts.Contracts;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public abstract class UnitDamagable : MonoBehaviour
    {
        [SerializeField] private Collider2D _triggerArea;

        public abstract void Damage(IDamageVisiter unit);

        private void Awake()
        {
            if (!_triggerArea)
                throw new System.Exception("Нет колайдера для принятия врагом урона.");
        }
    }
}