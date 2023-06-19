using UnityEngine;

namespace Assets.Scripts.Contracts
{
    public abstract class UnitCauseDamage : MonoBehaviour
    {
        public MonoBehaviour Owner { get; set; }
        public float Value { get; private set; }

        public void SetValue(float value)
        {
            Value = value;
        }
    }
}